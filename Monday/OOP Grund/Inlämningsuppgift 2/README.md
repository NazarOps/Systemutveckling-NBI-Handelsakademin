# Inlämningsuppgift 2 – Fitnessklubbsystem

Detta projekt är en inlämningsuppgift där jag utvecklar ett **Fitnessklubbsystem** i C#.
Syftet är att öva på objektorienterad programmering (OOP) genom att använda **klasser, arv, inkapsling och metoder**.

---

## 📋 Beskrivning

Systemet innehåller **8 klasser** och motsvarande objekt.
Varje klass har egna attribut och metoder, och flera klasser ärver från varandra för att visa på användning av arv i OOP.

---

## 🧩 Klasser och objekt

### `Equipment.cs`
- **Beskrivning:** Grundklass för träningsutrustning.
- **Attribut:**
  - `Brand` (märke)
  - `Condition` (skick)
  - `Type` (typ av equipment)
  - `Quantity` (antal som finns i gymmet)
- **Metoder:**
  - `Info()` – skriver ut information om utrustningen.

---

### `BenchPress.cs`
- Ärver från `Equipment`.
- Har en egen metod `InUse()` som kan anropas för att simulera användning.

---

### `SquatRacks.cs`
- Ärver från `Equipment`.
- Har en egen metod `InUse()` som kan anropas för att simulera användning.

---

### `Machines.cs`
- Ärver från `Equipment`.
- Har en egen metod `InUse()` som kan anropas för att simulera användning.

---

### `Person.cs`
- Klass för en "Gymgoer".
- **Inkapsling:** innehåller privata attribut som bara kan nås via **public metoder**.

---

### `Customer.cs`
- Ärver från `Person`.
- Extra attribut:
  - Antal år kunden har tränat.
  - Om kunden är **nybörjare** eller **erfaren**.

---

### `Membership.cs`
- Klass för gymmedlemskap ("gymkort").
- Innehåller **startdatum** och **slutdatum**.
- Är inkapslad, så man måste anropa attribut via **public metoder**.

---

### `Employee.cs`
- Ärver från `Person`.
- Extra attribut:
  - Antal anställda på gymmet.
  - Om de är erfarna eller oerfarna.
- **Metod:**
  - `Info()` – skriver ut antalet anställda och deras erfarenhet.

---

## 🛠️ Teknisk information

- **Språk:** C#
- **Paradigm:** Objektorienterad programmering (OOP)
- **OOP-principer:** Arv, inkapsling, polymorfism

---

## 🚀 Installation och körning

1. Klona projektet:
   ```bash
   git clone https://github.com/DITT-ANVÄNDARNAMN/inlamningsuppgift2-fitnessklubb.git
   ```
2. Öppna projektet i **Visual Studio** eller **Visual Studio Code** med .NET SDK installerat.
3. Kör programmet via `Program.cs`.

---

## 📖 Exempel på användning

```csharp
// Skapa en ny bänkpress
BenchPress bench = new BenchPress("Eleiko", "Bench Press", "Nytt", 2);

// Anropa metod för att använda bänkpressen
bench.InUse();

// Skapa en kund
Customer kund = new Customer("Anna", "Eriksson", 25, "Kvinna", "3 år", false);

// Skapa ett medlemskap
Membership medlemskap = new Membership(DateTime.Now, DateTime.Now.AddYears(1));
```

---

## 📂 Projektstruktur

```
inlamningsuppgift2/
│── Equipment.cs
│── BenchPress.cs
│── SquatRacks.cs
│── Machines.cs
│── Person.cs
│── Customer.cs
│── Membership.cs
│── Employee.cs
│── Program.cs
└── README.md
```

---

## ✨ Lärdomar

- Arv och inkapsling i C#
- Strukturering av objektorienterad kod
- Modellering av verkliga system med hjälp av klasser och objekt

---

## 📜 Licens

Detta projekt är en skoluppgift och är inte avsett för kommersiellt bruk.
