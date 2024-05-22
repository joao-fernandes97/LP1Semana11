using System;
using System.Collections.Generic;
using System.Collections;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T _var1;
        private T _var2;
        private T _var3;

        public Guarda3()
        {
            _var1 = default;
            _var2 = default;
            _var3 = default;
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return _var1;
            yield return _var2;
            yield return _var3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        public T GetItem(int i)
        {
            switch (i)
            {
                case 0:
                    return _var1;
                case 1:
                    return _var2;
                case 2:
                    return _var3;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    _var1 = item;
                    break;
                case 1:
                    _var2 = item;
                    break;
                case 2:
                    _var3 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public void Add(T item)
        {
            if (Equals(_var1,default(T)))
                _var1 = item;
             else if (Equals(_var2,default(T)))
                _var2 = item;
             else if (Equals(_var3,default(T)))
                _var3 = item;
            
        }
    }
}