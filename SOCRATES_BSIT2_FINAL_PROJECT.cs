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
    
    public static void AddStudent(List<Phonebook> Students){
        string addMore;
        do{
            Console.Write("Enter Student Number: ");
            string studentNumber = Console.ReadLine();
            
            Console.Write("Enter Surname: ");
            string Surname = Console.ReadLine();
            
            Console.Write("Enter First Name: ");
            string Firstname = Console.ReadLine();
            
            Console.Write("Enter Occupation: ");
            string Occupation = Console.ReadLine();
            
            string Gender;
            do{
                Console.Write("Enter Gender (M/F): ");
                Gender = Console.ReadLine().ToUpper();
                if (Gender != "M" && Gender != "F"){
                    Console.WriteLine("Select a VALID Option");
                }
            }while (Gender != "M" && Gender != "F");
            
            Console.Write("Enter Country Code: ");
            string countryCode = Console.ReadLine();
            
            Console.Write("Enter Area Code: ");
            string areaCode = Console.ReadLine();
            
            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();
            
            Phonebook studentDetail = new Phonebook(studentNumber, Surname, Firstname, Occupation,Gender,countryCode,areaCode,phoneNumber);
            Students.Add(studentDetail);
            
            Console.Write("Do you want to enter another entry [Y/N]? ");
            addMore = Console.ReadLine().ToUpper();
            do{
                if (addMore != "Y" && addMore != "N"){
                    Console.Write("Select a VALID Option");
                    addMore = Console.ReadLine().ToUpper();
                }}while(addMore != "Y" && addMore != "N");
        }while (addMore == "Y");
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
                AddStudent(Students);
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