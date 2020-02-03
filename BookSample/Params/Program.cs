using System;
public class Test           //Обьявление класса
{
    public static void Foo(int p)      //Обьявление метода
    {
        Console.WriteLine("Передача с параметром по умолчанию (значению) перед входом в метод Default");
        p += 1;                     //Увеличеие p на 1
        Console.WriteLine("Значение p = {0}", p);        //Вывод на экран значие p
    }                           //Конец метода
    public static void Foo2(ref int j) //Обьявление метода
    {
        Console.WriteLine("Передача с параметром ref по ссылке перед входом в метод");
        j += 1;
        Console.WriteLine("Значение j = {0}", j);       //Вывод на экран значие j
    }                           //Конец метода
    public static void Split(string name, out string firstNames, out string lastName) //Обьявление метода
    {
        Console.WriteLine("Передача с параметром out по ссылке перед выходом из метода Split");
        int i = name.LastIndexOf(' ');      //Присваивание i последнего пустого значения строки name
        firstNames = name.Substring(0, i);  //Присваивание firstName значения до последнего пустого значения поля name     Результат Stevie Ray
        lastName = name.Substring(i + 1);   //Присваивание lastName значение после последнего пустого значения поля name   Результат Vaughan
    }                                                                                   //Конец метода
    public static void Swap(ref string a, ref string b)    //Обьявление метода обмена
    {
        Console.WriteLine("Передача с параметром ref по ссылке перед входом в метод Swap");
        string temp = a;    //Присваивание строке temp значение а
        a = b;              //Присваивание строке а значение б
        b = temp;           //Присваивание строке б значение temp
    }                                                       //Конец метода
    public static int Sum(params int[] ints)   //Обьявление метода
    {
        Console.WriteLine("Передача с параметром params массива");
        int Sum = 0;        //Присваивание Sum значения 0
        for (int j = 0; j < ints.Length; j++)   //Перебор значений массива от 0
            Sum += ints[j]; //Увеличение значения Sum на каждое значение в массиве
        return Sum;         //Возвращение результата Sum
    }                                          //Конец метода
    public static void DefArg (int x = 0, int y = 0)    //Обьявление метода
    {
        Console.WriteLine("Значения по умолчанию");
        Console.WriteLine("Значение x = {0}, значение y = {1}", x, y);  //Вывод значения x,y
    }                                                   //Конец метода
    public static void Namearg (int x, int y)           //Обьявление метода
    {
        Console.WriteLine("Именнованные аргументы");
        Console.WriteLine("Значение x = {0}, значение y = {1}",x,y);    //Вывод значения x,y
    }                                                   //Конец метода
}                           //Конец класса
    public class Program    //Обьявление класса
{ 
        static void Main()          //Обьявление метода
        {
        /* Без параметра */
        int x = 8;                  //Присваивание аргумента 
            Test.Foo(x);                 //Передача аргумента параметром по умолчанию перед входом в метод
        Console.WriteLine("Значение x = {0}",x);        //Вывод на экран значение x
        int k = 8;                  //Присваивание аргумента
        /* С параметром ref */
        Test.Foo2(ref k);                //Передача аргумента параметром ref по ссылке перед входом в метод
        Console.WriteLine("Значение k = {0}",k);          //Вывод на экран значение k
        /* С параметром ref обмен строки */
        string g = "Penn";          //Присвание строке g значения "Penn"
        string y = "Teller";        //Присваивание строке y значения "Teller"
        Test.Swap(ref g, ref y);    //Передача аргумента параметром ref по ссылке перед входом в метод
        Console.WriteLine("Значенение g строки по умолчаниею {0} после {1}",y,g);       //Вывод на экран строки g Результат: Teller
        Console.WriteLine("Значенение g строки по умолчаниею {0} после {1}",g,y);       //Вывод на экран строки y Результат: Penn
        /* C параметром out разделение строки */
        string a, b;
        Test.Split("Stevie Ray Vaughan", out a, out b); //Переда аргумента параметром out по ссылке перед выходом из метода
        Console.WriteLine("Строка по умолчанию {0} {1}",a,b);     //Вывод на экран строки по умолчанию
        Console.WriteLine("Значение a (firstName) = {0}",a);      //Вывод на экран значение строки a (firstName)
        Console.WriteLine("Значение b (lastName) = {0}",b);       //Вывод на экран значение строки b (lastName)
        /* С параметром params массива */
        int total = Test.Sum(1, 2, 3, 4);   //Передача массива параметром params 
        Console.WriteLine("Значение total (Sum) = {0}",total);   //Вывод на экран значения total (Sum) Результат 10
        /* Именнованые аргументы */
        Test.Namearg(x: 1, y: 2);   //Передача аргумента по имени
        /* Стандартное значение аргументов */
        Test.DefArg(1);             //Передача значения
        }                           //Конец метода
}                   //Конец класса
