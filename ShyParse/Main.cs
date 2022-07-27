void Header()
{
    Console.WriteLine("\t=-- ShyParse.cs --=");
    Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
    Console.WriteLine("- Attempting to recreate TryParse() -");
    Console.WriteLine("-                                   -");
}

void Footer()
{
    Console.WriteLine("-                                   -");
    Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
}

double ShyParse(string input, bool log)
{
    if (log) Console.WriteLine("-                                   -");
    if (log) Console.WriteLine("- ShyParse(" + input + ")\n-");

    string numbers = "0123456789";
    string output = "";

    foreach (char c in input)
    {
        if (log) Console.Write("- char: " + c);

        if (numbers.Contains(c))
        {
            if (log) Console.WriteLine(" [TRUE]");

            output += c;
            if (log) Console.WriteLine("- output: " + output + "\n-");
        } 
        else
        {
            if (log) Console.WriteLine(" [FALSE]\n-");
        }
    }

    if (output == "")
    {
        if (log) Console.WriteLine("-\n- ShyParse(" + input + ") = 0");
        if (log) Console.WriteLine("-                                   -");

        return 0;
    } 
    else
    {
        if (log) Console.WriteLine("-\n- ShyParse(" + input + ") = " + double.Parse(output));
        if (log) Console.WriteLine("-                                   -");

        return double.Parse(output);
    }
}

// Main
while (true)
{
    Console.Clear();
    Header();

    Console.Write("- rawString: ");
    string rawString = Console.ReadLine();

    double output = ShyParse(rawString, false);
    Console.WriteLine("- output: " + output);

    Console.WriteLine("-                                   -");

    Console.Write("- Run again? (y/n): ");
    if (Console.ReadLine().ToLower() == "y")
    {
        continue;
    }
    else
    {
        Footer();
        break;
    }
}