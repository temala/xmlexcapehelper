using Helpers.String.Modifiers;

namespace DesignPatterns.Factories
{
    public class IdentationManagerFactory : StringModifierFactoryBase
    {
        public override StringModifierBase Create()
        {
            return XmlIdentationManager.Create();
        }
    }
}