using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using DesignPatterns.Command;
using JetBrains.ReSharper.TestRunner.Abstractions.Extensions;

namespace Helpers.String.Modifiers
{
    public class XmlStringEscaper : StringModifierBase
    {
        private static Lazy<XmlStringEscaper> instance = new Lazy<XmlStringEscaper>(() => new XmlStringEscaper());

        private XmlStringEscaper()
        {
            this.Commands.Add(new EscapeParametersCommand());
            this.Commands.Add(new EscapeNewLineCommand());
        }

        public static XmlStringEscaper Instance => instance.Value;
    }
}