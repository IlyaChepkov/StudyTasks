using IlyaCode;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите номер раздела");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case -3:
                Tree.Do();
                break;
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
            case 5:
                Case.Do();
                break;
            case 6:
                For.Do();
                break;
            case 7:
                While.Do();
                break;
        }
        Console.ReadLine();
    }
}