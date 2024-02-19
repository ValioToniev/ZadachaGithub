namespace ZadachaGithub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Прочитане на входните данни
            string[] stringArray = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            List<string> commands = new List<string>();

            for (int i = 0; i < n; i++)
            {
                commands.Add(Console.ReadLine());
            }

            // Обработка на командите
            ProcessCommands(stringArray, commands);

            // Извеждане на резултата
            Console.WriteLine(string.Join(", ", stringArray));
        }

        static void ProcessCommands(string[] array, List<string> commands)
        {
            foreach (var command in commands)
            {
                if (command == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (command == "Distinct")
                {
                    array = array.Distinct().ToArray();
                }
                else if (command.StartsWith("Replace"))
                {
                    var parts = command.Split();
                    int index = int.Parse(parts[1]);
                    string newString = parts[2];
                    array[index - 1] = newString;
                }
            }
        }
    }
}