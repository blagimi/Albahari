using System;
    class Program   //Обьявление класса
    {
        static void Main()  //Обьявление метода
        {
        char[] vowels = new char[5];            //Обьявление массива из 5 символов Или char[] vowels = new char [] ('a','b','c','d','e'); Или char[] vowels = ('a','b','c','d','e');
        vowels[0] = 'a';
        vowels[1] = 'b';
        vowels[2] = 'c';
        vowels[3] = 'd';
        vowels[4] = 'e';
        Console.WriteLine(vowels[1]);           //Вывод на экран символа под номеров 1, нумерация ведется с 0 Результат b
        for(int i = 0; i < vowels.Length; i++)  //Запуск цикла for для перебора всех значений в цикле от 0 до конца длинны массива (4) инкремент значения i
        {
            Console.WriteLine(vowels[i]);       //Вывод на экран содержимого каждой ячейки массива от 0 до 4 которые цикл for перебрал по очереди 
        }                                       //Конец цикла

        int[,] matrix = new int[,]              //Обьявление прямоугольного массива 3х3 Или int[,] matrix = new int[3,3];
        {
            {0,1,2},
            {3,4,5},
            {6,7,8}
        };
        Console.WriteLine(matrix[0,1]);         //Вывод на экран значение ячейки массива, нумерация ведется с 0 строка\столбец Результат 1
        for (int j = 0; j<matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
                matrix[j, k] = j * 3 + k;
        }

        int[][] matrix2 = new int[][]           //Обьявление зубчатого массива Или int [][] matrix = new [3][]
        {
            new int[] {0,1,2},
            new int[] {3,4,5},
            new int[] {6,7,8,9}
        };
        for (int l = 0; l < matrix2.Length;l++)
        {
            matrix2[l] = new int[3]; //Создать внутренний массив
            for (int m = 0; m < matrix2.Length; m++)
                matrix2[l][m] = l * 3 + m;
            Console.WriteLine(matrix2[0]);      //Вывод на экран строки массива, нумерация ведется с 0
        }
        /*Упрощенная запись масивов */
        char[] vowels2 = { 'a', 'e', 'i', 'o', 'u' };       //Простой массив
        int[,] rectangularMatrix =                          //Прямоугольный массив
        {
            {0,1,2 },
            {3,4,5 },
            {6,7,8 }
        };
        int[][] jaggedMatrix =                              //Зубчатый массив
        {
            new int[]{0,1,2},
            new int[]{3,4,5},
            new int[]{6,7,8,9}
        };


        }               //Конец метода
    }              //Конец класса