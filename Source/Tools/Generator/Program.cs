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
        }

        class FunctionData
        {
            public bool IsCallback { get; set; }

            public string Group { get; set; }

            public string BriefDescription { get; set; }

            public string Description { get; set; }

            public string Remarks { get; set; }

            public string ReturnDescription { get; set; }

            public string ReturnType { get; set; }

            public string Name { get; set; }

            public List<FunctionParamData> Params { get; } = new List<FunctionParamData>();
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

            public string Type { get; set; }

            public string Name { get; set; }
        }

        public static void Main(string[] args)
        {
            var lines = File.ReadAllLines("glfw3.h");
            var enums = new List<EnumData>();
            var functions = new List<FunctionData>();
            
            Parse(lines, enums, functions);

            Write(enums, functions);
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

        private static void Parse(string[] lines, List<EnumData> enums, List<FunctionData> functions)
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
                    string[] parts = lines[i].Split(new char[] { ' ', '\t', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    int j = 1;

                    FunctionData functionData = new FunctionData();

                    functionData.ReturnType = ParseType(parts, ref j);
                    j++;

                    functionData.Name = parts[j];
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

                            functionData.Params.Add(paramData);
                        }
                    }

                    ParseFunctionDocs(lines, i, functionData);

                    functions.Add(functionData);
                }
                else if (lines[i].StartsWith("typedef "))
                {
                    if (lines[i].Contains("(* "))
                    {

                    }
                    else
                    {

                    }
                }
            }
        }

        private static string GetReturnType(FunctionData function)
        {
            string type = function.ReturnType;

            if (type.StartsWith("const "))
                type = type.Substring("const ".Length);

            switch (type)
            {
                case "char*":
                    return "string";

                case "void*":
                    return "IntPtr";
            }

            return type;
        }

        private static string GetParamType(FunctionParamData param)
        {
            string type = param.Type;

            switch (type)
            {
                case "const char*":
                    return "string";

                case "int*":
                    if (param.Modifier == FunctionParamModifier.Out)
                    {
                        return "out int";
                    }
                    else
                    {
                        return "ref int";
                    }

                case "void*":
                    return "IntPtr";
            }

            return type;
        }

        private static string GetFunctionName(FunctionData function)
        {
            return function.Name.Substring(4);
        }

        private static void Write(List<EnumData> enums, List<FunctionData> functions)
        {
            StringBuilder sb = new StringBuilder(1024);

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine();
            sb.AppendLine("namespace GLFWDotNet");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class GLFW");
            sb.AppendLine("\t{");

            foreach (var enumData in enums)
            {
                sb.AppendLine($"\t\tpublic const int {enumData.Name} = {enumData.Value};");
            }

            sb.AppendLine();

            foreach (var function in functions)
            {
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + x.Name));

                sb.AppendLine($"\t\t[DllImport(Library, EntryPoint = \"{function.Name}\", ExactSpelling = true)]");
                sb.AppendLine($"\t\tpublic static extern {GetReturnType(function)} {GetFunctionName(function)}({parameters});");

                sb.AppendLine();
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            File.WriteAllText(@"..\..\..\..\GLFWDotNet\GLFW.Generated.cs", sb.ToString());
        }
    }
}
