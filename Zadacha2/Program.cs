namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Прочитане на входните данни
            string[] stringArray = Console.ReadLine().Split();
            List<string> commands = new List<string>();

            // Обработка на командите
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                commands.Add(command);
            }

            // Обработка на входните данни и командите
            ProcessCommands(stringArray, commands);

            // Извеждане на резултата
            Console.WriteLine(string.Join(", ", stringArray));
        }

        static void ProcessCommands(string[] array, List<string> commands)
        {
            foreach (var command in commands)
            {
                var parts = command.Split();
                if (parts[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (parts[0] == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (parts[0] == "Replace")
                {
                    int index = int.Parse(parts[1]) - 1;
                    if (index >= 0 && index < array.Length)
                    {
                        array[index] = parts[2];
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}