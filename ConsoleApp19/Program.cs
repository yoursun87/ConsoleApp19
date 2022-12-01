using ConsoleApp19;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Hello");
        WriteLine("Выберите команду");
        while (true)
        {
            var command = Console.ReadLine().ToLower().Split(' ');
            Controller s = new Controller();
            switch (command[0])
            {

                case "добавить":

                    s.AddGood(float.Parse(command[1]), command[2], float.Parse(command[3]), float.Parse(command[4]), command[5]);
                    break;
                case "список":
                    Console.WriteLine(s.GetGoods());
                    break;
                case "сохранить":
                    s.SaveList();
                    break;
                case "открыть":
                    s.OpenList();
                    break;
                case "удалить":
                    s.Udalenie();
                    break;
                   
                default:
                   
                    WriteLine("Ошибка в команде");
                    break;
                    
            }
        }
    }
}