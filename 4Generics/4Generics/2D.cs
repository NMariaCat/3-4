using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Generics
{
    class _2D<T> : IPrinter
    {
        private IProvider<T> _provider;
        private T[,] _items;
        private int _height;
        private int _width;
        public _2D(int height,int width, IProvider<T> provider, bool InpWay)
        {
            //T provider = IProvider;
            _width = width;
            _height = height;
            _items = new T[_height,_width];
            _provider = provider;
            if (InpWay == false)
            {
                for (int i = 0; i < _height; i++)
                {
                    for (int j = 0; j < _width; j++)
                    {
                        _items[i, j] = provider.RandomValue();
                    }
                }    
            }
            else
            {
                for (int i = 0; i < _height; i++)
                {
                    for (int j = 0; j < _width; j++)
                    {
                        _items[i, j] = provider.getUserValue();
                    }
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    Console.Write(_items[i, j]);
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }
    }

}
