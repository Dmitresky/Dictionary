using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace MyAwesomeDictionary
{
    public class MyDictionary : IDictionary<Key, string>
    {
        private readonly string[] _bucket = new string[10];

        public string this[Key key]
        {
            get
            {
                int x = key.GetHashCode();
                return _bucket[x];
            }
            set
            {
                int x = key.GetHashCode();
                _bucket[x] = value;
            }
        }

        public ICollection<Key> Keys => throw new NotImplementedException();

        public ICollection<string> Values => throw new NotImplementedException();

        public int Count 
        {
            get
            {
                return _bucket.Count(x => !string.IsNullOrEmpty(x));
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Key key, string value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<Key, string> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<Key, string> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(Key key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<Key, string>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<Key, string>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Key key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<Key, string> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(Key key, [MaybeNullWhen(false)] out string value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}