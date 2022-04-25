using System.Collections.Generic;
using DesignPatterns.Command;

namespace Helpers.String.Modifiers
{
    public class XmlIdentationManager:StringModifierBase
    {
        private static XmlIdentationManager instance;

        private XmlIdentationManager()
        {
            this.Commands.Add(new IdentXmlCommand());
        }

        public static StringModifierBase Create()
        {
            instance ??= new XmlIdentationManager();

            return instance;
        }
    }
}