using IlyaCode;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите номер раздела");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case -2:
                TextHelper.Do();
                break;
            case -1:
                Calc.Do();
                break;
            case 1: 
                Begin.Do();
                break;
            case 2:
                Integer.Do();
                break;
            case 3:
                _Boolean.Do();
                break;
            case 4:
                If.Do();
                break;
        }
        Console.ReadLine();
    }
}