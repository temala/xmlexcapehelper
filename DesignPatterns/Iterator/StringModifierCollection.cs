#nullable enable
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DesignPatterns.Factories;
using Helpers.String.Modifiers;

namespace DesignPatterns.Iterator
{
    public class StringModifierCollection : IEnumerable
    {
        private readonly List<StringModifierFactoryBase> collection;

        public StringModifierCollection()
        {
            collection = new List<StringModifierFactoryBase>()
                {new IdentationManagerFactory(), new EscapeManagerFactory()};
        }

        public int Count => this.collection.Count;

        public IEnumerator GetEnumerator()
        {
            return new StringModifierIterator(this);
        }

        public string this[int index,string source] => this.collection[index].Modify(source);
        public StringModifierBase this[int index] => this.collection[index].Create();
    }
}