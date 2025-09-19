namespace NumbersGame
{   //Daniel Hultmark NET25
    internal class Program
    {
        static void Main(string[] args)
        {
            bool spelaIgen = true;

            while (spelaIgen)
            //Huvudloopen för att kunna spela igen
            {
                Console.WriteLine("Välkommen!");
                Console.WriteLine("Jag tänker på ett nummer. kan du gissa vilket?");
                Console.WriteLine("Du får fem försök.");
                Console.WriteLine("Skriv in en siffra mellan 1 och 20");
                Random random = new Random();
                int number = random.Next(1, 21);
                //Här valde jag att skriva flera rader för att strukturera upp texten så att det inte bara blev en lång string
                //Även random ligger här för att slumpa fram ett nytt nummer varje gång
        static void Spela()
                {
                    for (int n = 5; n > 0; n--) //Här skapade jag en for-loop som räknar ner från 5 så att användaren bara får 5 försök
                    {
                        //Jag använde if satser för att se om användare gissade rätt eller fel
                        //Jag använde också TryParse för att felhantera felaktiga inmatningar
                        if (!int.TryParse(Console.ReadLine(), out int guess))
                        {
                            Console.WriteLine("Din gissning är utanför 1-20, försök igen!");
                            n++;//Lade in n++ så att användare inte blir av med ett försöka om hen matar in tal utanför parametern.
                            continue;

                        }
                        if (guess == number)
                        {
                            Console.WriteLine("Grattis! Du gissade rätt!");
                            break; // ja in break här så att loppen inte fortsatte när användaren gissade rätt
                        }
                        else if (guess >= number)
                        {
                            Console.WriteLine("Talet är för högt!");

                        }
                        else if (guess <= number)
                        {
                            Console.WriteLine("Talet är för lågt!");

                        }

                        if (n > 1)
                        {
                            Console.WriteLine($"Du har {n - 1} försök kvar");
                        }   //Lade in en extra if sats för att skriva ut hur många försök som är kvar

                        else
                        {

                            Console.WriteLine("Du har inga försök kvar! Korrekt svar var: " + (number));
                            break;//När användarens försök tar loopen slut och rätt nummer skrivs ut
                        }


                    }
                    //här nere lade jag nästa if sats i while loopen så att användaren får frågan om hen vill försöka igen

                    Console.WriteLine("Vill du spela igen? (j/n)");
                    string svar = Console.ReadLine().ToLower();//skapar en string av svaret för att lägga in i if-satsen samt ToLower så att det små bokstäver även om användaren skriver stora bokstäver
                    if (svar == "j")
                    {
                        spelaIgen = true;

                    }
                    else if (svar == "n")
                    {
                        spelaIgen = false;
                        Console.WriteLine("Tack för att du spelade!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt svar, skriv j/n");
                        //Lade även in en else ifall anvädare inte svarar med j eller n
                    }
                }

            }
        }
    }
}