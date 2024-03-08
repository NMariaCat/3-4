using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Generics
{
    class _1D<T> : IPrinter
    {
        private T[] _items;
        private IProvider<T> _provider;
        private int _length;
        //private T _provider;
        public _1D(int length, IProvider<T> provider, bool InpWay)
        {
            _length = length;
            _provider = provider;
            _items = new T[_length];
            if (InpWay == false)
            {
                //T provider = IProvider;
                for (int i = 0; i < _length; i++)
                {
                    _items[i] = _provider.RandomValue();
                }
            }
            else
            {
                for (int i = 0; i < _length; i++)
                {
                    _items[i] = provider.getUserValue();
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < _length; i++)
            {
                Console.Write(_items[i]);
                Console.Write("   ");
            }
            Console.WriteLine();
        }

    }
}
