namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un comando:");
            string input = Console.ReadLine();

            switch (input)
            {
                case null:
                    Console.WriteLine("Nessun input rilevato");
                    break;

                case "ciao":
                    Console.WriteLine("Buon giorno!");
                    break;

                case "initialize":
                    InitializeUser();
                    break;

                default:
                    Console.WriteLine("Input non riconosciuto");
                    break;
            }


            static void InitializeUser()
            {
                Console.WriteLine("Inserisci il nome:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Inserisci il cognome:");
                string lastName = Console.ReadLine();

                Utente utente1 = new Utente(firstName, lastName);

                Console.WriteLine($"Utente {utente1.FullName()} inizializzato!");

            }
        }

    }
    
}