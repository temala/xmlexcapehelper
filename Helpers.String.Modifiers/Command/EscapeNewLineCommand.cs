using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DesignPatterns.Command
{
    internal class EscapeNewLineCommand: IModifyCommand
    {
        public string Execute(string source)
        {
            var lines = source.Split(Environment.NewLine).Select(Wrap);

            return string.Join($" + {Environment.NewLine}",lines);
        }
        
        private string Wrap(string source)
        {
            var identStartSpacesRegx = new Regex("^ +");
         
            var identStartSpaces =identStartSpacesRegx.Match(source);
           
            source = source.Trim();
            
            return  $"{identStartSpaces.Value}\"{source}\"";
        }
    }
}