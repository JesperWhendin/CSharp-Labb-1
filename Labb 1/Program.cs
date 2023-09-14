void Labb1()
{
    {
        // Labb 1 – Hitta tal i sträng med tecken

        // Skapa en konsollapplikation som tar en textsträng(string) som argument till
        // Main eller uppmanar användaren mata in en sträng i konsollen.
        // Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
        // och slutar på samma siffra, utan att start/ slutsiffran, eller något annat tecken än
        // siffror förekommer där emellan.
        // ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
        // ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
        // t.ex 95a9 är inte heller ett korrekt tal.

        // Skriv ut och markera varje korrekt delsträng
        // För varje sådan delsträng som matchar kriteriet ovan ska programmet skriva ut en
        // rad med hela strängen, men där delsträngen är markerad i en annan färg.
        // Exempel output för input ”29535123p48723487597645723645”:


        // Byt färg genom Console.ForegroundColor.

        // Addera ihop alla tal och skriv ut totalen
        // Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
        // sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.
        // Exempel output för input ”29535123p48723487597645723645”:
        // Total = 5836428677242

        // Redovisning
        // Uppgiften ska lösas individuellt.
        // Lämna in uppgiften på ithsdistans med en kommentar med github-länken.
    } // Labbeskrivning
    {
        // För godkänt:
        // * Räcker att lösa en av uppgifterna, d.v.s.antingen skriva ut alla
        //   delsträngar som i exemplet ovan, eller räkna ut och skriva ut totalen.
        // * Om man matar in strängen i exemplet ska man få samma output som ovan.
        // * Det ska även fungera generellt, oavsett vilken sträng man matar in.

        // För väl godkänt krävs även:
        // * Båda uppgifterna ska vara lösta, d.v.s.programmet ska först skriva ut alla
        //   delsträngar som i exemplet ovan och därefter räkna ut och skriva ut total.
        // * Koden ska vara väl strukturerad och lätt att förstå.
    } // Betygskriterier
    {
        // Be om textsträng
        //




    } // Psuedokod
    {
        // string[] nummer = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        // string[] alfabet = new string[29] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "å", "ä", "ö" };
        // string inputSequence = string.Empty;
        // inputSequence = "29535123p48723487597645723645";
        // inputSequence = "0904782+393h19921g8765432654321";
        // inputSequence = "11931g81488";
    } // Utkommenterade variabler jag deklarerat och använt mig av för tester

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
                else if (!char.IsDigit(inputSequence[j])) // Om den inre for-loopen står på ett index som inte är en siffra, så bryts den inre for-loopens nuvarande iteration och fortsätter med nästa index.
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
Labb1(); // Anropar Labb1 då jag valde att skriva allt i en metod.
         // För min egen del är det lättare att både förstå andras och skriva egen kod om de
         // initiala och vertikala sträcken är synliga och om all kod är indenterad.