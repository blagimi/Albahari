using System;
    class Program   //Обьявление класса
    {
        /* switch case example #1 */
        static void ShowCard (int cardNumber)   //Обьявление метода
        { 
            switch (cardNumber)                 //Переход на описанный случай от передаваемого в метод значения
        {
            case 13:                            //Могут быть записаны в столбик если вывод более чем для одного значения    case 13:
                Console.WriteLine("King");      //                                                                          case 12:
                break;                          //                                                                          case 11:
            case 12:                            //                                                                              Console.WriteLine("Face card");
                Console.WriteLine("Queen");     //                                                                              break;
                break;                          //                                                                          default:
            case 11:                            //                                                                              Console.WriteLine("Plain card");
                Console.WriteLine("Jack");      //                                                                              break;
                break;
            case -1:
                goto case 12;
            default:
                Console.WriteLine(cardNumber);
                break;
        }
        }                                       //Конец метода
        /* if else example #1 */ 
        static void TellMeWhatICanDo (int age)  //Обьявление метода
        {
        if (age >= 35)      //Запуск цикла if
            Console.WriteLine("You can be a president");
        else if (age >=21)
            Console.WriteLine("You can drink");
        else if (age >=18)
            Console.WriteLine("You can vote");
        else
            Console.WriteLine("You can wait");
        }                                       //Конец метода
        static void Main()  //Обьявление метода
        /* If */
        {
        if (5 < 2 * 3)    //Запуск цикла if
        {
            Console.WriteLine(true);    //Вывод на экран значения если условие верно Результат true
        }
        /* If else */
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~If else");
        if (2 + 2 == 5)     //Запуск цикла if
        {
            Console.WriteLine("DoesNotCopmpute"); //Вывод на экран значения если условие верно
        }
        else  
        { 
            Console.WriteLine("False"); //Вывод на экран значения если условие ложно Результат false
        }
        /* if else example #1 */
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~If else example #1");
        TellMeWhatICanDo(36); //Вызов метода
        /* switch case example #1 */
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~Switch example #1");
        ShowCard(13);   //Вызов метода
        /* while */
        int i = 0;
        while (i<3) //Запуск цикла while выражение проверяется на достоверность перед выполнением тела цикла
        {
            Console.WriteLine(i);   //Вывод на экран значение если условие верно Результат 0 1 2
            i++;    //Инкремент значения i
        }
        /* do while */
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~Do while");
        int j = 0;
        do   //Запуск цикла do while выражение проверяется на достоверность после выполнения тела цикла, выполнение цикла минимум 1 раз
        {
            Console.WriteLine(j);
            j++;
        }
        while (j < 3);
        /* for */
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~For");
        for (int k = 0; k < 3; k++) //Запуск цикла for 
            Console.WriteLine(k);   //Вывод на экран значения k Результат 0 1 2
        /* for example #1 Фибоначи сумма двух предыдущих чисел это новое число */
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~Фибоначи");
        int prevFib, curFib;
        for (j = 0, prevFib = 1, curFib = 1; j < 10; j++)   //Запуск цикла
        {
            Console.WriteLine(prevFib);
            int newFib = prevFib + curFib;      //Новое число фибоначи сумма последнего числа и предыдущего
            prevFib = curFib; curFib = newFib;  //Предыдущее число становится текущем, текущее новым
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~foreach");
        foreach (char c in "beer")  //Запуск цикла foreach проход по каждом элементу в перечисляемом обьекте
            Console.WriteLine(c);   //Вывод на экран значения c Результат b e e r
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~оператор цикла continue");
        for (int n = 0; n <10; n++) //Запуск цикла
        {
            if ((n % 2) == 0)   //Проверка условия на остаток от деленияе ели число чётное переход далее
                continue;   // Если число не чётное continue игнорируется
            Console.WriteLine(n + ""); //Вывод на экран значения не являющиеся чётными
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~оператор цикла goto");
        int h = 1;  //Присваивание переменной h значения 1
        startLoop:  //Обьявление метки
        if (h <= 5)   //Условие 
        {
            Console.WriteLine(h+" ");   //Вывод на экран значение h Результат 1 2 3 4 5, код выполняет симуляцию цикла for
            h++;    //Инкремент значения h
            goto startLoop; //Переход к обьявленной метке
        }
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~оператор цикла throw");
        string w = null;
        if (w == null)  //Условие
            throw new ArgumentNullException(); //Если условие верно генерирует исключение что бы указать на ошибки.
        }                   //Конец метода
    }               //Конец класса

