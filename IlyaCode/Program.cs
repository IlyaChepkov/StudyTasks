using IlyaCode;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите номер раздела");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case -7:
                Imager.Do();
                break;
            case -6:
                GameOfLife.Do();
                break;
            case -5:
                OGE.Do();
                break;
            case -4:
                House.Do();
                break;
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
            case 8:
                Series.Do();
                break;
            case 9:
                Proc.Do();
                break;
            case 10:
                Minmax.Do();
                break;
            case 11:
                IlyaCode.Array.Do();
                break;
            case 12:
                Matrix.Do();
                break;
            case 13:
                Strings.Do();
                break;
            case 14:
                StudyFile.Do();
                break;
            case 15:
                Text.Do();
                break;
            case 16:
                Param.Do();
                break;
            case 17:
                Recur.Do();
                break;
            case 18:
                Dynamic.Do();
                break;
            default:
                Console.WriteLine("Ты болбес? Такого раздела не существует!!!");
                break;
        }
        Console.ReadLine();
    }
}