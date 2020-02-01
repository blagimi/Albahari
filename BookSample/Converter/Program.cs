using System;

    public class UnitConverter //Обьявление класса
{
    int ratio;                                                  //Поле экземпляра
    public UnitConverter(int unitRatio) { ratio = unitRatio; }  //Конструктор
    public int Convert (int unit) { return unit * ratio; }      //Обьявление метода с входящим значением unit, умножение значения unit на передаваемое в поле ratio значение, возвращение результата
}                              //Конец класса

    class Program   //Обьявление класса
    {
        static void Main() //Обьявление метода
        {
        UnitConverter feetToInchesConverter = new UnitConverter(12);    
        UnitConverter milesToFeetConverter = new UnitConverter(5280);
        Console.WriteLine(feetToInchesConverter.Convert(30));                               //результат 360
        Console.WriteLine(feetToInchesConverter.Convert(100));                              //Результат 1200
        Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));  //Результат 63360
        }                 //Конец метода
    }              //Конец класса

