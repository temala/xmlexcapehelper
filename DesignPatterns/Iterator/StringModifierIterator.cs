using Helpers.String.Modifiers;

namespace DesignPatterns.Iterator
{
    class StringModifierIterator : Iterator
    {
        private readonly StringModifierCollection collection;
        
        private int position = -1;
        
        public StringModifierIterator(StringModifierCollection collection)
        {
            this.collection = collection;
        }

        protected override StringModifierBase Current()
        {
            return this.collection[position];
        }

        public override bool MoveNext()
        {
            return ++this.position < this.collection.Count;
        }
        
        public override void Reset()
        {
            this.position =  -1;
        }
    }
}