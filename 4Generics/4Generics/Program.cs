// See https://aka.ms/new-console-template for more information
using _4Generics;


public class Program
{
    static void Main()
    {
        IProvider<int> intProvider = new IntProvider();
        IProvider<string> stringProvider = new StringProvider();
        IProvider<double> doubleProvider = new DoubleProvider();
        IProvider<bool> boolProvider = new BoolProvider();


        Console.WriteLine("Введите длину одномерного массива.");
        int length1D = int.Parse(Console.ReadLine());
        Console.WriteLine("Хотите сами вводить одномерные массивы? + = да, - = нет");
        bool InpWay1D;
        if (Console.ReadLine() == "-") InpWay1D = false;
        else
        {
            InpWay1D = true;
            Console.WriteLine("Введите элементы массива целых чисел, затем массива строк, затем массива логического типа данных bool, затем массива дробных чисел.");
        }

        IPrinter[] _prov1D = new IPrinter[4];
        _prov1D[0] = new _1D<int>(length1D, intProvider, InpWay1D);
        _prov1D[1] = new _1D<string>(length1D, stringProvider, InpWay1D);
        _prov1D[2] = new _1D<bool>(length1D, boolProvider, InpWay1D);
        _prov1D[3] = new _1D<double>(length1D, doubleProvider, InpWay1D);
        for (int i = 0; i < 4; i++)
        {
            _prov1D[i].Print();
        }

        Console.WriteLine("Введите количество столбцов (ширину) двумерных массивов.");
        int width2D = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество строк (высоту) двумерных массивов.");
        int height2D = int.Parse(Console.ReadLine());

        Console.WriteLine("Хотите сами вводить двумерные массивы? + = да, - = нет");
        bool InpWay2D;
        if (Console.ReadLine() == "-") InpWay2D = false;
        else
        {
            InpWay2D = true;
            Console.WriteLine("Введите элементы массива целых чисел, затем массива строк, затем массива логического типа данных bool, затем массива дробных чисел.");
        }

        IPrinter[] _prov2D = new IPrinter[4];
        _prov2D[0] = new _2D<int>(height2D, width2D, intProvider, InpWay2D);
        _prov2D[1] = new _2D<string>(height2D, width2D, stringProvider, InpWay2D);
        _prov2D[2] = new _2D<bool>(height2D, width2D, boolProvider, InpWay2D);
        _prov2D[3] = new _2D<double>(height2D, width2D, doubleProvider, InpWay2D);
        for (int i = 0; i < 4; i++)
        {
            _prov2D[i].Print();
        }
    }
}


