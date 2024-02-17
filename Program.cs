using Chem;

static void RunPrompt() {
    while (true) {
        Console.Write(">>> ");
        string? line = Console.ReadLine();
        if (line is null) {
            Console.WriteLine();
            break;
        }

        try {
            Equation test = new(line);
            Console.WriteLine(test.ToString());
        }
        catch(Exception e) {
            Console.WriteLine($"There was an error : {e}");
        }
    }
}

RunPrompt();
