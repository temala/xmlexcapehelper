using System.Linq;
using System.Text.RegularExpressions;

namespace DesignPatterns.Command
{
    internal class EscapeParametersCommand:IModifyCommand
    {
        public string Execute(string source)
        {
            var regx = new Regex("\"(.*?)\"");
            var matches = regx.Matches(source);

            foreach (var match in matches.Where(m=>m!=null))
            {
                source =source.Replace(match.ToString(), $"\\\"{match.Value.Replace("\"","")}\\\"");
            }
            
            return source;
        }
    }
}