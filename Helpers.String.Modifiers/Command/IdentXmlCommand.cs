using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace DesignPatterns.Command
{
    internal class IdentXmlCommand: IModifyCommand
    {
        public string Execute(string source)
        {
            var document = XDocument.Parse(source);

            Encoding encoding= null;
            
            if (document.Declaration.Encoding != null)
            {
                encoding =Encoding.GetEncoding(document.Declaration.Encoding);
            }
            
            var sb = new EncodedStringWriter(encoding);

            var settings = new XmlWriterSettings
            {
                Indent = true,
            };

            using (var xmlWriter = XmlWriter.Create(sb,settings))
            {
                document.WriteTo(xmlWriter);
            }

            return sb.ToString();
        }
        
        private class EncodedStringWriter : StringWriter
        {
            public EncodedStringWriter(Encoding encoding)
            {
                this.Encoding = encoding;
            }
        
            public override Encoding Encoding { get; }
        }
    }
}