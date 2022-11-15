//Задача 10
void Task_10 ()
{
    // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    //456 -> 5
    //782 -> 8
    //918 -> 1

    Console.WriteLine("                                 -----------Задача 10----------");
    Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.Write("Введите трёхзначное число:-> ");
    int container = Convert.ToInt32(Console.ReadLine());

    int number = Math.Abs(container);

    if (number > 100 & number < 1000)
    {
        int result = (number / 10) % 10;
        Console.WriteLine($"Вторая цифра числа {container} ->  {result}");
    }
    else
    {
        Console.WriteLine($"Введенное значение {container} не подходит!");       
    }    
}

//Задача 13
void Task_13 ()
{
    //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    //645 -> 5
    //78 -> третьей цифры нет
    //32679 -> 6

    Console.WriteLine("                                -----------Задача 13----------");
    Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");   

    Console.Write("Введите число:-> ");
    int number = Convert.ToInt32(Console.ReadLine());
    int container = Math.Abs(number);
    int residuals = 0;

    if (container > 99)
    {
        while (container > 999)
        {
            container /= 10;
        }
        residuals = container % 10;
        Console.WriteLine($"Третья цифра числа {number} -> {residuals} ");              
    }
    else
    {
        Console.WriteLine($"В набранном числе {number} -> третьей цифры нет!");            

    }
}

//Задача 15
void Task_15 ()
{
    //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    //6 -> да
    //7 -> да
    //1 -> нет

    Console.WriteLine("                       -----------Задача 15----------");
    Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели,");   
    Console.WriteLine("                и проверяет, является ли этот день выходным.");   

    Console.Write("Введите число дня недели от 1 до 7:-> ");
    int weekDay = Convert.ToInt32(Console.ReadLine());

    if (weekDay >= 1 & weekDay <= 5)
    {
        Console.WriteLine($"{Week(weekDay)} не является выходным днем, идите работать!");              
    }
    else if (weekDay == 6 | weekDay == 7 )
    {
        Console.WriteLine($"{Week(weekDay)} является выходным днем, надо отдохнуть!");             
    }
    else
    {
        Console.WriteLine($"Ввод неверный! Такого дня недели НЕТ!");          
    }
}

//Возврат тип string по дню недели  
string Week(int day) 
{
    string weekday = "";
    if (day == 1) weekday = "Понедельник";
    if (day == 2) weekday = "Вторник";
    if (day == 3) weekday = "Среда";
    if (day == 4) weekday = "Четверг";
    if (day == 5) weekday = "Пятница";
    if (day == 6) weekday = "Суббота"; 
    if (day == 7) weekday = "Воскресенье";     
    return weekday;
}

//Task_10 ();

//Task_13 ();

//Task_15 ();
