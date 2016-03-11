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
            public string Docs { get; set; }

            public bool IsCallback { get; set; }

            public string ReturnType { get; set; }

            public string Name { get; set; }

            public List<FunctionParamData> Params { get; } = new List<FunctionParamData>();
        }

        class FunctionParamData
        {
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

        private static string ParseDocs(string[] lines, int i)
        {
            while (!lines[i].StartsWith("/*!"))
            {
                i--;
            }

            StringBuilder sb = new StringBuilder(512);

            while (!lines[i].StartsWith(" */"))
            {
                if (lines[i].Length >= 4)
                {
                    sb.AppendLine(lines[i].Substring(4));
                }
                else
                {
                    sb.AppendLine();
                }
                
                i++;
            }

            return sb.ToString();
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

                    functionData.Docs = ParseDocs(lines, i);

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

        private static void Write(List<EnumData> enums, List<FunctionData> functions)
        {
            StringBuilder sb = new StringBuilder(1024);

            sb.AppendLine("namespace GLFWDotNet");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static partial class GLFW");
            sb.AppendLine("\t{");

            foreach (var enumData in enums)
            {
                sb.AppendLine($"\t\tpublic const int {enumData.Name} = {enumData.Value};");
            }

            sb.AppendLine();

            foreach (var functionData in functions)
            {
                string returnType = functionData.ReturnType;
                string name = functionData.Name;
                string parameters = string.Join(", ", functionData.Params.Select(x => x.Type + " " + x.Name));

                sb.AppendLine($"\t\t// public static {returnType} {name}({parameters});");
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            File.WriteAllText(@"..\..\..\..\GLFWDotNet\GLFW.Generated.cs", sb.ToString());
        }
    }
}
