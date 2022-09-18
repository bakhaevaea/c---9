
using System;

class MyNewClass
{

    public static int[] startEnd()
    {
        int[] rez = new int[2];
        System.Console.WriteLine("Введите M ");
        int M = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Введите N ");
        int N = int.Parse(Console.ReadLine());

        int start, end;
        if (M < N)
        {
            start = M;
            end = N;
        }
        else
        {
            start = N;
            end = M;
        }
        if (end < 1)
        {
            System.Console.WriteLine("Натуральных чисел нет ");
        }
        if (start < 1) start = 1;
        rez[0] = start;
        rez[1] = end;
        return rez;
    }

    public static int natNum(int M, int N)
    {
        if (M > N)
        {
            return 1;
        }
        else
        {
            Console.Write($"{M}  ");
            return natNum(M + 1, N);
        }
    }

    public static int sumNatNum(int M, int N)
    {
        if (M > N)
        {
            return 0;
        }
        else 
        {
            return sumNatNum(M + 1, N) + M;
        }
    }
    public static int akkerman(int M, int N)
    {
        if (M == 0)
        {
            return N + 1;
        }
        else if (M > 0 && N == 0)
        {
            return akkerman(M - 1, 1);

        }
        else if (M > 0 && N > 0)
        {
            return akkerman(M-1, akkerman(M, N-1));
        }
        return 0;
    }

    static void Main()
    {
        System.Console.WriteLine("Задача 64: Выведет все натуральные числа в промежутке от M до N.");
        System.Console.WriteLine("Задача 66: Найдёт сумму натуральных элементов в промежутке от M до N.");
        System.Console.WriteLine("Задача 68: Вычисление функции Аккермана с помощью рекурсии.");

        int Task = int.Parse(Console.ReadLine());
        switch (Task)
        {
            case 64:
                {

                    int[] nat = startEnd();
                    natNum(nat[0], nat[1]);
                    break;
                }
            case 66:
                {
                    int[] nat = startEnd();
                    int sum = sumNatNum(nat[0], nat[1]);
                    System.Console.WriteLine($"Сумма натуральных чисел {sum}"); 
                    break;
                }
            case 68:
                {
                     System.Console.WriteLine("Введите неотрицательное M ");
                    int M = int.Parse(Console.ReadLine());

                    System.Console.WriteLine("Введите неотрицательное N ");
                    int N = int.Parse(Console.ReadLine());
                    int akk = akkerman(M, N);
                    System.Console.WriteLine($"Функция Аккермана = {akk}"); 
                    break;
                }
            default: break;
        }
    }


    public static void million()
    {
        // Пишем кто хочет стать миллионером :)
        int count = 0;

        string[,] array = {
        {"Какие из перечисленных ниже программ являются антивирусными?",
            "MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
        {"Какого типа графики не существует?",
    "Растровая", "Векторная", "Облачная", "Трехмерная", "Облачная"},
        {"Когда появился термин «информационные технологии» в современном значении?",
    "В 1893 году", "В 1990 году", "В 1958 году", "В 1902 году", "В 1958 году"},
        {"В каком году компанией IBM был выпущен первый в истории жесткий диск?",
    "В 1956 году", "В 1958 году", "В 1955 году", "В 1957 году", "В 1956 году"},
        {"Какая поисковая система была самой популярной в 2011 году?",
    "Yahoo!", "Google", "Bing", "Yandex", "Google"},
        {"Страна лидер по количеству суперкомпьютеров?",
    "Китай", "США", "Япония", "Россия", "Китай"},
        {"Какого Интернет-браузера не существует?",
    "MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"},
        {"Какие из клавиш клавиатуры относятся к группе функциональных?",
    "Китай", "Россия", "Великобритания", "США", "США"},
        {"Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП?",
    "F1-F12", "CTRL, ALT, Shift", "Windows","Tab",  "F1-F12"},
        {"Какие из перечисленных ниже программ являются антивирусными?","200 МБит/с", "1 МБит/с", "100 МБит/с", "10 МБит/с", "100 МБит/с"}
    };

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine($"{array[i, 0]}");
            for (int j = 1; j < array.GetLength(1) - 1; j++)
            {
                Console.WriteLine($"{j} - {array[i, j]}");
            }
            System.Console.WriteLine("0 - выход, 5 - 50/50");
            int result = Convert.ToInt32(Console.ReadLine());
            if (result == 0)
            {
                break;
            }
            int someNum = 0, key = 0;
            if (result == 5)
            {
                for (int k = 1; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] == array[i, 5])
                    {
                        key = k;

                        while (true)
                        {
                            someNum = new Random().Next(1, 5);
                            if (someNum != k)
                            {
                                break;
                            }
                        }
                    }
                }
                if (someNum > key)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{key} - {array[i, key]}");
                    Console.WriteLine($"{someNum} - {array[i, someNum]}");
                }
                else
                {

                    Console.WriteLine($"{someNum} - {array[i, someNum]}");
                    Console.WriteLine($"{key} - {array[i, key]}");
                }
                result = Convert.ToInt32(Console.ReadLine());
            }
            if (array[i, result] == array[i, 5])
            {
                count++;
                System.Console.WriteLine("Верно");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine($"Правельных ответов {count}");
    }

}