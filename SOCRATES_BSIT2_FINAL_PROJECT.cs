using System;
public class Phonebook{
    string studentNumber{get; set;}
    string Surname{get; set;}
    string Firstname{get; set;}
    string Occupation{get; set;}
    string Gender{get; set;}
    string countryCode{get; set;}
    string areaCode{get; set;}
    string phoneNumber{get; set;}
    
    
    public Phonebook(string studentNumber, string Surname, string Firstname, string Occupation, string Gender, string countryCode, string areaCode, string phoneNumber){
        this.studentNumber =  studentNumber;
        this.Surname = Surname;
        this.Firstname = Firstname;
        this.Occupation = Occupation;
        this.Gender = Gender;
        this.countryCode = countryCode;
        this.areaCode = areaCode;
        this.phoneNumber = phoneNumber;
    }
    
    
    static void Main() {
    List<Phonebook> Students = new List<Phonebook>();
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