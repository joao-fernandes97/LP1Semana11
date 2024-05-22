using System;
using System.Collections.Generic;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private readonly T _var1;
        private readonly T _var2;
        private readonly T _var3;

        public Guarda3()
        {
            _var1 = default;
            _var2 = default;
            _var3 = default;
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
    }
}