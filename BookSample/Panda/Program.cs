using System;

    public class Panda //Обьявление класса
{
    public string Name;             //Поле экземпляра
    public static int Population;   //Статическое поле (относится ко всем экзмеплярам)
    public Panda (string n)         //Конструктор 
    {
        Name = n;                       //Присвоение значения полю экземляра
        Population += 1;    //Инкрементировать значение статического поля
    }
}                      //Конец класса
    class Program   //Обьявление класса
    {
        static void Main()      //Обьявление метода
        {
        Panda p1 = new Panda("Pan Dee");        //Присвоение значения Pan Dee экземпляру p1 класса Panda 
        Panda p2 = new Panda("Pan Dah");        //Присвоение значения Pan Dah экземпляру p2 класса Panda
        Console.WriteLine(p1.Name);             //Вывод на экран значение Name экземпляра p1 класса Panda   Результат: Pan Dee
        Console.WriteLine(p2.Name);             //Вывод на экран значение Name экземпляра p2 класса Panda   Результат: Pan Dah
        Console.WriteLine(Panda.Population);    //Вывод на экран значение статического поля Population      Результат: 2
        }                       //Конец метода
    }              //Конец класса
