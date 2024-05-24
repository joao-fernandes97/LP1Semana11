using System;
using System.Collections.Generic;
using System.Collections;

namespace MyOwnCollection
{
    class ShortQueue<T> : ICollection<T>
    {
        
        private T[] _array;
        private int _tail; //index of where the next item is added
        private int _size; //current amount of items in list
        public int Count => _size;
        public bool IsReadOnly => false;

        public ShortQueue()
        {
            _array = new T[5];
        }

        public ShortQueue(int size)
        {
            _array = new T[size];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            _array[_tail] = item;
            MoveNext(ref _tail);
            _size = _size==_array.Length ? _array.Length : _size+1;
        }

        private void MoveNext(ref int index)
        {
            int tmp = index+1;
            if(tmp==_array.Length)
                tmp = 0;
            index = tmp;
        }

        public void Clear()
        {
            if(_size != 0)
            {
                Array.Clear(_array);
                _size = 0;
                _tail = 0;
            }

        }

        public bool Contains(T item)
        {
            if (_size == 0)
                return false;
            
            return Array.IndexOf(_array, item) >= 0;
        }

        public void CopyTo(T[] array, int index)
        {

        }

        public bool Remove(T item)
        {
            if (Contains(item))
            {
                if(Array.IndexOf(_array, item, _tail)>=0)
                    _array[Array.IndexOf(_array, item, _tail)] = default;
                else
                    _array[Array.IndexOf(_array, item)] = default;  
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Join(",",_array);
        }
    }
}
