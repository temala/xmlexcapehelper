using DesignPatterns.Iterator;
using Helpers.String.Modifiers;

namespace DesignPatterns.Factories
{
    public abstract class StringModifierFactoryBase
    {
        public abstract StringModifierBase Create();

        public string Modify(string source)
        {
            return this.Create()
                .Process(source);
        }
    }
}