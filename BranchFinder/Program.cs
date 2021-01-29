using LibGit2Sharp;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.IO;

namespace BranchFinder
{
    class Program
    {
        private static readonly string _repo = GetCurrentDir();
        public static void Main(string[] args)
        {
            Branch branch = GetCheckedOutBranch();
            string msg = ConvertToJson(branch.FriendlyName);
            if (IsValidJson(msg))
            {
                Console.WriteLine(msg);
            }
            else
            {
                throw new ArgumentException("JSON contained invalid syntax" + msg);
            }
        }
        private static Branch GetCheckedOutBranch()
        {
            Branch checkedOutBranch = new Repository(_repo).Head;
            return checkedOutBranch;
        }
        private static string ConvertToJson(string branch)
        {
            return "{ \"branch\" : \"" + branch + "\" }";            
        }
        private static string GetCurrentDir()
        {
            string path = Assembly.GetExecutingAssembly().CodeBase;
            string directory = Path.GetDirectoryName(path);
            
            string cleanDir = directory.Replace("file:\\", string.Empty);

            return cleanDir;
        }
        private static bool IsValidJson(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            input = input.Trim();
            if ((input.StartsWith("{") && input.EndsWith("}")) || (input.StartsWith("[") && input.EndsWith("]"))) 
            {
                try
                {
                    JToken jToken = JToken.Parse(input);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}