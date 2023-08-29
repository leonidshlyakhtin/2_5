
using _5;

int startYear, startMonth, startDay, finishYear, finishMonth, finishDay;
try
{
    Console.Write("Введите год началльной даты:");
    startYear = int.Parse(Console.ReadLine());
    Console.Write("Введите месяц начальной даты:");
    startMonth = int.Parse(Console.ReadLine());
    Console.Write("Введите день начальной даты:");
    startDay = int.Parse(Console.ReadLine());
    Console.Write("Введите год конечной даты:");
    finishYear = int.Parse(Console.ReadLine());
    Console.Write("Введите месяц конечной даты:");
    finishMonth = int.Parse(Console.ReadLine());
    Console.Write("Введите день конечной даты:");
    finishDay = int.Parse(Console.ReadLine());
    DateTime start = new DateTime(startYear, startMonth, startDay);
    DateTime finish = new DateTime(finishYear, finishMonth, finishDay);

    try
    {
        TimeSpan totalLong = LongTime(start, finish);
        Console.WriteLine(totalLong);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    try
    {
        TimeSpan totalLong = LongTimeWith(start, finish);
        Console.WriteLine(totalLong);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    try
    {
        TimeSpan totalLong = LongTimeExp(start, finish);
        Console.WriteLine(totalLong);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    try
    {
        TimeSpan totalLong = FuncOur(start, finish);
        Console.WriteLine(totalLong);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }


}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}

catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}




TimeSpan LongTime(DateTime start, DateTime end)
{

    return end.Subtract(start);
}



TimeSpan LongTimeWith(DateTime start, DateTime end)
{
    return end.Subtract(start);

    throw new Exception("Какая-то ошибка!");
}





TimeSpan LongTimeExp(DateTime start, DateTime end)
{
    int totalLong = 0;

    try
    {
        return end.Subtract(start);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    return new TimeSpan(0);
}

TimeSpan FuncOur(DateTime start, DateTime end)
{
    return end.Subtract(start);
    throw new OurException("любое исключение");
}