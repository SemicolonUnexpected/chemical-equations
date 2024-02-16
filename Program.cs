using Chem;


static void RunPrompt() {
    while (true) {
        Console.Write(">>> ");
        string? line = Console.ReadLine();
        if (line is null) {
            Console.WriteLine();
            break;
        }

        Equation test = new(line);
    }
}

RunPrompt();
