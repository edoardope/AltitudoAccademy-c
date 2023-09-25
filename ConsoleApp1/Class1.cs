using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Utente
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Costruttore nome e cognome 
        public Utente(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Costruttore data di nascita, email e numero di telefono
        public Utente(string firstName, string lastName, DateTime birthDate, string email, string phoneNumber)
            : this(firstName, lastName)
        {
            BirthDate = birthDate;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        // lettura età dell'utente
        public int Age
        {
            get
            {
                if (BirthDate != DateTime.MinValue)
                {
                    DateTime today = DateTime.Today;
                    int age = today.Year - BirthDate.Year;
                    if (BirthDate.Date > today.AddYears(-age)) age--;
                    return age;
                }
                return -1; // Età sconosciuta
            }
        }

        // Metodo per nome completo
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        // Metodo per informazioni sull'utente
        public void DisplayInfo()
        {
            Console.WriteLine("Nome completo: " + FullName());
            Console.WriteLine("Data di nascita: " + (BirthDate != DateTime.MinValue ? BirthDate.ToShortDateString() : "N/A"));
            Console.WriteLine("Età: " + (Age != -1 ? Age.ToString() : "N/A"));
            Console.WriteLine("Email: " + (!string.IsNullOrEmpty(Email) ? Email : "N/A"));
            Console.WriteLine("Numero di telefono: " + (!string.IsNullOrEmpty(PhoneNumber) ? PhoneNumber : "N/A"));
        }
    }
}
