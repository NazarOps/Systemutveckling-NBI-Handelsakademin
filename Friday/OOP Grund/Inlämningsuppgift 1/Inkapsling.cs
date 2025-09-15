namespace Inlämningsuppgift_1
{
    public class Person
    {
        // Privat attribut som resten av appen och användare kan INTE använda'
        // Vi har tillgång till denna attribut med hjälp av public metoder eller public attributer
        private string namn;

        // Konstruktör säger att när vi skapar ett objekt av klassen Person, så måste vi specifiera attributen, annars = null

        public Person(string namn) 
        {
            Name = namn;
        }

        // Vi kommer göra en public metod för att komma åt den privata attributen

        public string Name
        {
            get { return namn;  }
            set { namn = value; }
            // Skriver man Person.Name, så hämtar man alla attributer från namn, alltså den privata strängen
        }
    }
}
