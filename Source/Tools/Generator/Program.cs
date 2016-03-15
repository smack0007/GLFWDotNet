using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class Program
    {
        class EnumData
        {
            public string Name { get; set; }

            public string Value { get; set; }

            public override string ToString() => this.Name;
        }

        class FunctionData
        {
            public string Group { get; set; }

            public string BriefDescription { get; set; }

            public string Description { get; set; }

            public string Remarks { get; set; }

            public string ReturnDescription { get; set; }

            public string ReturnType { get; set; }

            public string Name { get; set; }

            public List<FunctionParamData> Params { get; } = new List<FunctionParamData>();

            public override string ToString() => this.Name;
        }

        enum FunctionParamModifier
        {
            None,
            In,
            Out
        }

        class FunctionParamData
        {
            public FunctionParamModifier Modifier { get; set; }

            public string Description { get; set; }

            public string Type { get; set; }

            public string Name { get; set; }

            public override string ToString() => this.Name;
        }

        class CallbackData
        {
            public string ReturnType { get; set; }

            public string Name { get; set; }

            public string[] ParamTypes { get; set; }

            public override string ToString() => this.Name;
        }

        class StructData
        {
            public bool IsOpaque { get; set; }

            public string Name { get; set; }

            public override string ToString() => this.Name;
        }

        public static void Main(string[] args)
        {
            var lines = File.ReadAllLines("glfw3.h");
            var enums = new List<EnumData>();
            var functions = new List<FunctionData>();
            var callbacks = new List<CallbackData>();
            var structs = new List<StructData>();

            Parse(lines, enums, functions, callbacks, structs);

            Write(enums, functions, callbacks, structs);
        }

        private static string ParseType(string[] parts, ref int j)
        {
            string result = string.Empty;

            if (parts[j] == "const")
            {
                result += "const ";
                j++;
            }
            
            if (parts[j] == "unsigned")
            {
                result += "unsigned ";
                j++;
            }

            result += parts[j];

            return result;
        }

        private static FunctionData ParseFunction(string[] lines, int i)
        {
            string[] parts = lines[i].Split(new char[] { ' ', '\t', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int j = 1;

            FunctionData function = new FunctionData();

            function.ReturnType = ParseType(parts, ref j);
            j++;

            function.Name = parts[j];
            j++;

            if (parts[j] != "void")
            {
                while (parts[j] != ";")
                {
                    FunctionParamData paramData = new FunctionParamData();

                    paramData.Type = ParseType(parts, ref j);
                    j++;

                    paramData.Name = parts[j];
                    j++;

                    function.Params.Add(paramData);
                }
            }

            ParseFunctionDocs(lines, i, function);

            return function;
        }

        enum FunctionDocState
        {
            None,
            BriefDescription,
            Description,
            Param,
            Remarks,
            Return
        }

        private static void ParseFunctionDocsFlush(
            FunctionData functionData,
            ref FunctionDocState state,
            StringBuilder sb,
            string paramName,
            FunctionParamModifier paramModifier)
        {
            switch (state)
            {
                case FunctionDocState.BriefDescription:
                    functionData.BriefDescription = sb.ToString();
                    break;

                case FunctionDocState.Description:
                    functionData.Description = sb.ToString();
                    break;

                case FunctionDocState.Param:
                    var param = functionData.Params.Single(x => x.Name == paramName);
                    param.Modifier = paramModifier;
                    param.Description = sb.ToString();
                    break;

                case FunctionDocState.Remarks:
                    functionData.Remarks = sb.ToString();
                    break;

                case FunctionDocState.Return:
                    functionData.ReturnDescription = sb.ToString();
                    break;
            }

            if (state == FunctionDocState.BriefDescription)
            {
                state = FunctionDocState.Description;
            }
            else
            {
                state = FunctionDocState.None;
            }

            sb.Clear();
        }

        private static void ParseFunctionDocs(string[] lines, int i, FunctionData functionData)
        {
            while (!lines[i].StartsWith("/*!"))
            {
                i--;
            }

            FunctionDocState state = FunctionDocState.None;
            StringBuilder sb = new StringBuilder(1024);
            string paramName = string.Empty;
            FunctionParamModifier paramModifier = FunctionParamModifier.None;

            while (true)
            {
                bool finished = false;

                string trimmedLine = null;

                if (lines[i].Length >= 4)
                {
                    trimmedLine = lines[i].Substring(4);
                }
                else
                {
                    trimmedLine = string.Empty;
                }

                if (trimmedLine.StartsWith("@brief"))
                {
                    state = FunctionDocState.BriefDescription;
                    sb.AppendLine(trimmedLine.Substring("@brief ".Length));
                }
                else if (trimmedLine.StartsWith("@ingroup"))
                {
                    functionData.Group = trimmedLine.Substring("@ingroup ".Length).Trim();
                }
                else if (trimmedLine.StartsWith("@param"))
                {
                    ParseFunctionDocsFlush(functionData, ref state, sb, paramName, paramModifier);

                    state = FunctionDocState.Param;
                    paramModifier = FunctionParamModifier.None;

                    trimmedLine = trimmedLine.Substring("@param".Length);

                    if (trimmedLine.StartsWith("[in]"))
                    {
                        paramModifier = FunctionParamModifier.In;
                        trimmedLine = trimmedLine.Substring("[in]".Length);
                    }
                    else if (trimmedLine.StartsWith("[out]"))
                    {
                        paramModifier = FunctionParamModifier.Out;
                        trimmedLine = trimmedLine.Substring("[out]".Length);
                    }

                    trimmedLine = trimmedLine.Substring(1);

                    int index = trimmedLine.IndexOf(' ');
                    paramName = trimmedLine.Substring(0, index);

                    sb.AppendLine(trimmedLine.Substring(index + 1));
                }
                else if (trimmedLine.StartsWith("@remarks"))
                {
                    state = FunctionDocState.Remarks;
                    sb.AppendLine(trimmedLine.Substring("@remarks ".Length));
                }
                else if (trimmedLine.StartsWith("@return"))
                {
                    ParseFunctionDocsFlush(functionData, ref state, sb, paramName, paramModifier);
                    state = FunctionDocState.Return;
                    sb.AppendLine(trimmedLine.Substring("@return ".Length));
                }
                else if (lines[i].StartsWith(" */"))
                {
                    ParseFunctionDocsFlush(functionData, ref state, sb, paramName, paramModifier);
                    finished = true;
                }
                else if (trimmedLine == string.Empty || trimmedLine.StartsWith("@"))
                {
                    ParseFunctionDocsFlush(functionData, ref state, sb, paramName, paramModifier);
                }
                else
                {
                    sb.AppendLine(trimmedLine);
                }

                if (finished)
                    break;

                i++;
            }
        }

        private static CallbackData ParseCallback(string[] lines, int i)
        {
            string[] parts = lines[i].Split(new char[] { ' ', '\t', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int j = 1;

            CallbackData callback = new CallbackData();

            callback.ReturnType = ParseType(parts, ref j);
            j += 2;

            callback.Name = parts[j];
            j++;

            List<string> argTypes = new List<string>();

            if (parts[j] != "void")
            {
                while (parts[j] != ";")
                {
                    argTypes.Add(ParseType(parts, ref j));
                    j++;
                }
            }

            callback.ParamTypes = argTypes.ToArray();

            return callback;
        }

        private static StructData ParseStruct(string[] lines, ref int i)
        {
            string[] parts = lines[i].Split(' ');

            var @struct = new StructData();
            @struct.Name = parts[2];

            if (lines[i].EndsWith(";"))
            {
                @struct.IsOpaque = true;
            }
            else
            {
                
            }

            return @struct;
        }

        private static void Parse(
            string[] lines,
            List<EnumData> enums,
            List<FunctionData> functions,
            List<CallbackData> callbacks,
            List<StructData> structs)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("#define "))
                {
                    string[] parts = lines[i].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 3)
                    {
                        enums.Add(new EnumData()
                        {
                            Name = parts[1],
                            Value = parts[2]
                        });
                    }
                }
                else if (lines[i].StartsWith("GLFWAPI "))
                {
                    FunctionData function = ParseFunction(lines, i);
                    functions.Add(function);
                }
                else if (lines[i].StartsWith("typedef "))
                {
                    if (lines[i].Contains("(* "))
                    {
                        CallbackData callback = ParseCallback(lines, i);
                        callbacks.Add(callback);
                    }
                    else if (lines[i].StartsWith("typedef struct "))
                    {
                        StructData @struct = ParseStruct(lines, ref i);
                        structs.Add(@struct);
                    }
                }
            }
        }

        private static string TrimGLFWPrefix(string input)
        {
            if (input.StartsWith("glfw") || input.StartsWith("GLFW"))
            {
                input = input.Substring("GLFW".Length);
                input = input.Substring(0, 1).ToUpper() + input.Substring(1);
            }

            return input;
        }

        private static string GetType(string type, List<StructData> structs)
        {
            if (type.StartsWith("const "))
                type = type.Substring("const ".Length);

            if (type.EndsWith("*") || type.EndsWith("**"))
            {
                string structName = type.TrimEnd('*');

                var @struct = structs.SingleOrDefault(x => x.Name == structName);

                if (@struct != null)
                {
                    if (@struct.IsOpaque)
                    {
                        if (type.EndsWith("**"))
                        {
                            return "IntPtr[]";
                        }
                        else
                        {
                            return "IntPtr";
                        }
                    }
                    else
                    {
                        type = structName;
                    }
                }
            }

            type = TrimGLFWPrefix(type);

            switch (type)
            {
                case "char*":
                    return "string";

                case "char**":
                    return "string[]";

                case "double*":
                    return "double";

                case "float*":
                    return "float[]";

                case "Glproc":
                    return "IntPtr";

                case "int*":
                    return "int";

                case "unsigned int":
                    return "uint";

                case "unsigned char*":
                    return "string";

                case "void*":
                    return "IntPtr";
            }

            return type;
        }

        private static string GetReturnType(string type, List<StructData> structs)
        {
            return GetType(type, structs);
        }

        private static string GetParamType(string type, FunctionParamModifier modifier, List<StructData> structs)
        {
            type = GetType(type, structs);

            if (modifier == FunctionParamModifier.Out)
            {
                type = "out " + type;
            }

            return type;
        }

        private static string GetFunctionName(string function)
        {
            return TrimGLFWPrefix(function);
        }

        private static string GetFunctionParamName(string name)
        {
            switch (name)
            {
                case "string":
                    return "@string";
            }

            return name;
        }

        private static string FormatDocs(string input, string padding)
        {
            return
                padding + "/// " +
                string.Join(
                    Environment.NewLine + padding + "/// ",
                    input.TrimEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                );
        }

        private static void Write(
            List<EnumData> enums,
            List<FunctionData> functions,
            List<CallbackData> callbacks,
            List<StructData> structs)
        {
            StringBuilder sb = new StringBuilder(1024);

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine();
            sb.AppendLine("namespace GLFWDotNet");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class GLFW");
            sb.AppendLine("\t{");

            foreach (var @enum in enums)
            {
                string name = @enum.Name.Substring(5);
                string value = @enum.Value;

                if (value.StartsWith("GLFW_"))                
                    value = value.Substring(5);

                sb.AppendLine($"\t\tpublic const int {name} = {value};");
            }

            sb.AppendLine();

            foreach (var @struct in structs.Where(x => !x.IsOpaque))
            {
                sb.AppendLine($"\t\tpublic struct {GetType(@struct.Name, structs)}");
                sb.AppendLine("\t\t{");
                sb.AppendLine("\t\t}");

                sb.AppendLine();
            }

            foreach (var callback in callbacks)
            {
                string parameters = string.Join(", ", callback.ParamTypes.Select((x, i) => GetParamType(x, FunctionParamModifier.None, structs) + " arg" + i));

                sb.AppendLine($"\t\tpublic delegate {GetReturnType(callback.ReturnType, structs)} {GetFunctionName(callback.Name)}({parameters});");

                sb.AppendLine();
            }

            foreach (var function in functions)
            {
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x.Type, x.Modifier, structs) + " " + GetFunctionParamName(x.Name)));

                sb.AppendLine("\t\t/// <summary>");
                sb.AppendLine(FormatDocs(function.BriefDescription, "\t\t"));
                sb.AppendLine("\t\t/// </summary>");
                sb.AppendLine("\t\t/// <remarks>");
                sb.AppendLine(FormatDocs(function.Description, "\t\t"));
                sb.AppendLine("\t\t/// </remarks>");

                foreach (var param in function.Params)
                {
                    sb.AppendLine($"\t\t/// <param name=\"{param.Name}\">");
                    sb.AppendLine(FormatDocs(param.Description, "\t\t"));
                    sb.AppendLine("\t\t/// </param>");
                }

                if (!string.IsNullOrEmpty(function.ReturnDescription))
                {
                    sb.AppendLine("\t\t/// <returns>");
                    sb.AppendLine(FormatDocs(function.ReturnDescription, "\t\t"));
                    sb.AppendLine("\t\t/// </returns>");
                }

                sb.AppendLine($"\t\t[DllImport(Library, EntryPoint = \"{function.Name}\", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]");
                sb.AppendLine($"\t\tpublic static extern {GetReturnType(function.ReturnType, structs)} {GetFunctionName(function.Name)}({parameters});");

                sb.AppendLine();
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            File.WriteAllText(@"..\..\..\..\GLFWDotNet\GLFW.Generated.cs", sb.ToString());
        }
    }
}
