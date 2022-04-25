using Helpers.String.Modifiers;

namespace DesignPatterns.Factories
{
    public class EscapeManagerFactory : StringModifierFactoryBase
    {
        public override StringModifierBase Create()
        {
            return XmlStringEscaper.Instance;
        }
    }
}