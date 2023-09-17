void Labb1()
{
    string highlightSequence = string.Empty;
    double parseResult;
    double sumOfInputSequenceSubstrings = 0;

    Console.WriteLine("Mata in en sträng:");
    string inputSequence = Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"Du har skrivit in följande sträng: \n{inputSequence}");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    foreach (char sign in inputSequence)
    {
        Console.Write("-");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();

    for (int i = 0; i < inputSequence.Length; i++) // For-loop som utför något en gång för varje index [i] i inputSequence.
    {
        if (char.IsDigit(inputSequence[i])) // Den yttre for-loopen tillåts bara utföra något om indexet den står på är en siffra.
        {
            for (int j = i + 1; j < inputSequence.Length; j++) // Nestlad for-loop som utför något en gång för varje resterande index [j] varje gång den yttre loopen körs (j = i + 1 för att inte jämföra samma index med varandra).
            {
                if (inputSequence[i] == inputSequence[j]) // Det som ska utföras om tecknet på index [i] är samma som tecknet på index [j].
                {
                    Console.Write(inputSequence.Substring(0, i)); // Skriver ut första delen i strängen, om det finns någon (så länge index [i] är större än 0).
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(inputSequence.Substring(i, j - i + 1)); // Skriver ut den markerade delen (i en annan färg dessutom).
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(inputSequence.Substring(j + 1)); // Skriver ut den sista delen i strängen, om det finns någon (från index [j] + 1 till slutet av strängen).
                    highlightSequence = inputSequence.Substring(i, j - i + 1); // Sparar den markerade delen i strängen till en annan string variabel (ersätter även eventuella befintliga strängar).
                    Console.WriteLine(); // Enbart till för radbrytning. Går att ändra rad 90 från Write till WriteLine för samma resultat men jag tycker detta är tydligare.
                    double.TryParse(highlightSequence, out parseResult); // Analyserar highlightSequence där den markerade delsträngen skall vara sparat och sparar detta med ett numeriskt värde i en annan double variabel.
                    sumOfInputSequenceSubstrings += parseResult; // Lägger in den markerade delsträngen med det numeriska värdet i en ny variabel där summan av alla delsträngar adderas ihop.
                    break;
                }
                else if (!char.IsDigit(inputSequence[j])) // Om den inre for-loopen står på ett index som inte är en siffra, så bryts den inre for-loopens nuvarande iteration.
                {
                    break;
                }
            }
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    foreach (char sign in inputSequence)
    {
        Console.Write("-");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.Write("Summan av de markerade delsträngarna är ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(sumOfInputSequenceSubstrings);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.ReadKey();
}
Labb1();