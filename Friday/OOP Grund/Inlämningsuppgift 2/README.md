# Inlämningsuppgift 2 – Fitnessklubbsystem

Detta projekt är en inlämningsuppgift där jag utvecklar ett Fitnessklubbsystem i C#.
Syftet är att öva på objektorienterad programmering (OOP) genom att använda klasser, arv, inkapsling och metoder.

Programmet innehåller 8 stycken klasser och alla har sina egna attributer och metoder. 

I program.cs så finns det alla objekt och metoder som anropas. 

- Customer.cs
En klass för kunden. Klassen innehåller en 
inkapsling princip som är privat och vi anropar den med hjälp av public metoder.

- BenchPress.cs
En klass för bänkpress, klassen ärver all information från Equipment.cs och har sin egen
metod som är InUse().

- Equipment.cs 
En huvudklass för all träningsutrustning som exempelvis BenchPress.cs ärver från. Klassen innehåller
information om vad det är för typ av märke, vilken skick utrustningen är i och om den 
används eller inte.

- Machines.cs
En klass för träningsmaskiner. Samma sak gäller här som i BenchPress.cs klassen. Machines.cs ärver
allt från Equipment.cs och den har sin egen metod som säger om träningsmaskinen används eller inte.

- Employee.cs
En klass för alla som jobbar på gymmet. Den ärver information från klassen Person.cs men den har också
sina egna attributer så som arbetslivserfarenhet och antalet människor som jobbar på gymmet och den har
sin egen metod info() som skriver ut information hur många personer det är som jobbar på gymmet och
deras arbetslivserfarenhet.

- Membership.cs
En huvudklass för medlemskapet. Man kan säga att denna klass är ett gymkort som har inkapslad information.
Klassen innehåller information om startdatum, slutdatum och nuvarande status för medlemskapet.

- Person.cs
En huvudklass för en person som innehåller inkapslad information om Namn, Ålder och Kön. Klassen använder get; set;
metoderna för att hämta information

- SquatRack.cs
En klass för squatracken. Klassen ärver allt från Equipment.cs och den har sin egen metod InUse() som talar om
racken är uppdaten eller inte.


