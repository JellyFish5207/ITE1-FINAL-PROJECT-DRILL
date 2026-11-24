using System;
public class Phonebook{
    string Country {get; set;}
    int countryCode{get; set;}
    
    public Phonebook(string Country, int countryCode){
        this.Country =  Country;
        this.countryCode = countryCode;
    }
    
    
    static void Main() {
    string menuSelect;
    do{
        Console.WriteLine("[1] Store to ASEAN phonebook");
        Console.WriteLine("[2] Edit entry in ASEAN phonebook");
        Console.WriteLine("[3] Search ASEAN phonebook by country");
        Console.WriteLine("[4] Exit");
        Console.Write("Select Option: ");
        menuSelect = Console.ReadLine();
        switch (menuSelect){
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                Console.Write("Exiting Program...");
                break;
            default:
                Console.WriteLine("Select a VALID Option");
                break;
        }
    }while (menuSelect != "4");
  }
}