using System.Collections;
using System.Collections.Generic;
using Helpers.String.Modifiers;

namespace DesignPatterns.Iterator
{
    internal abstract class Iterator : IEnumerator<StringModifierBase>
    {
        protected abstract StringModifierBase Current();
        
        public abstract bool MoveNext();
        public abstract void Reset();

        StringModifierBase IEnumerator<StringModifierBase>.Current => Current();
        object IEnumerator.Current => Current();

        public void Dispose()
        {
        }
    }
}