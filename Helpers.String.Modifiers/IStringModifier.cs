using System.Collections.Generic;
using DesignPatterns.Command;

namespace Helpers.String.Modifiers
{
    public class StringModifierBase
    {
        protected readonly List<IModifyCommand> Commands = new List<IModifyCommand>();
        public string Process(string source)
        {
            foreach (var Command in Commands)
            {
                source= Command.Execute(source);
            }

            return source;
        }
    }
}