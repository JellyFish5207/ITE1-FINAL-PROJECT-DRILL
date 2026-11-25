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
    
    public static void EditStudent(List<Phonebook> Students){
        Console.Write("Search Student Number: ");
        string searchStudent = Console.ReadLine();
        bool studentFound = false;
        foreach (Phonebook studentID in Students){
            if (searchStudent == studentID.studentNumber){
                Console.WriteLine($"{studentID.Firstname} {studentID.Surname} is a {studentID.Occupation}. Gender is {studentID.Gender}. And their number is {studentID.countryCode}-{studentID.areaCode}-{studentID.phoneNumber}");
                studentFound = true;
                
                Console.WriteLine("Which of the Following information do you wish to change?");
                string menuSelect;
                do{
                    Console.WriteLine("[1] Student Number | [2] Surname | [3] Firstname | [4] Gender");
                    Console.WriteLine("[5] Occupation | [6] Country Code | [7] Area Code | [8] Phone Number");
                    Console.WriteLine("[9] Go Back to Main Menu");
                    Console.Write("Select Option: ");
                    menuSelect = Console.ReadLine();
                    switch (menuSelect){
                        case "1":
                            Console.Write($"Changing Student Number from {studentID.studentNumber} to: ");
                            studentID.studentNumber = Console.ReadLine();
                            Console.WriteLine($"Student Number is now {studentID.studentNumber}");
                            Console.WriteLine($"{studentID.Firstname} {studentID.Surname} is a {studentID.Occupation}. Gender is {studentID.Gender}. And their number is {studentID.countryCode}-{studentID.areaCode}-{studentID.phoneNumber}");
                            break;
                        case "2":
                            Console.Write($"Changing Surname from {studentID.Surname} to: ");
                            studentID.Surname = Console.ReadLine();
                            Console.WriteLine($"Surname is now {studentID.Surname}");
                            Console.WriteLine($"{studentID.Firstname} {studentID.Surname} is a {studentID.Occupation}. Gender is {studentID.Gender}. And their number is {studentID.countryCode}-{studentID.areaCode}-{studentID.phoneNumber}");
                            break;
                        case "3":
                            Console.Write($"Changing First Name from {studentID.Firstname} to: ");
                            studentID.Firstname = Console.ReadLine();
                            Console.WriteLine($"Firstname is now {studentID.Firstname}");
                            Console.WriteLine($"{studentID.Firstname} {studentID.Surname} is a {studentID.Occupation}. Gender is {studentID.Gender}. And their number is {studentID.countryCode}-{studentID.areaCode}-{studentID.phoneNumber}");
                            break;
                        case "4":
                        string genderNew;
                            do{
                                Console.Write($"Changing Gender from {studentID.Gender} to (M/F): ");
                                genderNew = Console.ReadLine().ToUpper();
                                if (genderNew != "M" && genderNew != "F"){
                                    Console.WriteLine("Select a VALID Option");
                                }
                            }while (genderNew != "M" && genderNew != "F");
                            studentID.Gender = genderNew;
                            Console.WriteLine($"Gender is now {studentID.Gender}");
                            Console.WriteLine($"{studentID.Firstname} {studentID.Surname} is a {studentID.Occupation}. Gender is {studentID.Gender}. And their number is {studentID.countryCode}-{studentID.areaCode}-{studentID.phoneNumber}");
                            break;
                        case "5":
                            Console.Write($"Changing Occupation from {studentID.Occupation} to: ");
                            studentID.Occupation = Console.ReadLine();
                            Console.WriteLine($"Occupation is now {studentID.Occupation}");  
                            Console.WriteLine($"{studentID.Firstname} {studentID.Surname} is a {studentID.Occupation}. Gender is {studentID.Gender}. And their number is {studentID.countryCode}-{studentID.areaCode}-{studentID.phoneNumber}");
                            break;
                        case "6":
                            Console.Write($"Changing Country Code from {studentID.countryCode} to: ");
                            studentID.countryCode = Console.ReadLine();
                            Console.WriteLine($"Country Code is now {studentID.countryCode}");  
                            Console.WriteLine($"{studentID.Firstname} {studentID.Surname} is a {studentID.Occupation}. Gender is {studentID.Gender}. And their number is {studentID.countryCode}-{studentID.areaCode}-{studentID.phoneNumber}");
                            break;
                        case "7":
                            Console.Write($"Changing Area Code from {studentID.areaCode} to: ");
                            studentID.areaCode = Console.ReadLine();
                            Console.WriteLine($"Area Code is now {studentID.areaCode}");
                            Console.WriteLine($"{studentID.Firstname} {studentID.Surname} is a {studentID.Occupation}. Gender is {studentID.Gender}. And their number is {studentID.countryCode}-{studentID.areaCode}-{studentID.phoneNumber}");
                            break;
                        case "8":
                            Console.Write($"Changing Phone Number from {studentID.phoneNumber} to: ");
                            studentID.phoneNumber = Console.ReadLine();
                            Console.WriteLine($"Phone Number is now {studentID.phoneNumber}");
                            Console.WriteLine($"{studentID.Firstname} {studentID.Surname} is a {studentID.Occupation}. Gender is {studentID.Gender}. And their number is {studentID.countryCode}-{studentID.areaCode}-{studentID.phoneNumber}");
                            break;    
                        case "9":
                            Console.Write("Returning to Main Menu...");
                            break;
                        default:
                            Console.WriteLine("Select a VALID Option");
                            break;
                    }
                }while (menuSelect != "9");
            }
            }
            if (!studentFound){
                Console.WriteLine("Student Not Found");
            }
        }
    
    public static void SearchStudent(List<Phonebook> Students){
     Console.WriteLine("Which country would you like to search?");
        string menuSelect;
        do{
            Console.WriteLine("[1] Philippines | [2] Thailand | [3] Singapore | [4] Indonesia");
            Console.WriteLine("[5] Malaysia | [6] ALL | [0] No More");
            Console.Write("Search Option: ");
            menuSelect = Console.ReadLine();
            switch (menuSelect){
                case "1":
                    Console.WriteLine("Here are the students from Philippines:");   
                    foreach (Phonebook studentCountry in Students){
                        if (studentCountry.countryCode == "63"){
                        Console.WriteLine($"{studentCountry.Firstname} {studentCountry.Surname} is a {studentCountry.Occupation}. Gender is {studentCountry.Gender}. And their number is {studentCountry.countryCode}-{studentCountry.areaCode}-{studentCountry.phoneNumber}");                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Here are the students from Thailand:");   
                    foreach (Phonebook studentCountry in Students){
                        if (studentCountry.countryCode == "66"){
                        Console.WriteLine($"{studentCountry.Firstname} {studentCountry.Surname} is a {studentCountry.Occupation}. Gender is {studentCountry.Gender}. And their number is {studentCountry.countryCode}-{studentCountry.areaCode}-{studentCountry.phoneNumber}");                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Here are the students from Singapore:");   
                    foreach (Phonebook studentCountry in Students){
                        if (studentCountry.countryCode == "65"){
                        Console.WriteLine($"{studentCountry.Firstname} {studentCountry.Surname} is a {studentCountry.Occupation}. Gender is {studentCountry.Gender}. And their number is {studentCountry.countryCode}-{studentCountry.areaCode}-{studentCountry.phoneNumber}");                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("Here are the students from Indonesia:");   
                    foreach (Phonebook studentCountry in Students){
                        if (studentCountry.countryCode == "62"){
                        Console.WriteLine($"{studentCountry.Firstname} {studentCountry.Surname} is a {studentCountry.Occupation}. Gender is {studentCountry.Gender}. And their number is {studentCountry.countryCode}-{studentCountry.areaCode}-{studentCountry.phoneNumber}");                        }
                    }
                    break;
                case "5":
                    Console.WriteLine("Here are the students from Malaysia:");   
                    foreach (Phonebook studentCountry in Students){
                        if (studentCountry.countryCode == "60"){
                        Console.WriteLine($"{studentCountry.Firstname} {studentCountry.Surname} is a {studentCountry.Occupation}. Gender is {studentCountry.Gender}. And their number is {studentCountry.countryCode}-{studentCountry.areaCode}-{studentCountry.phoneNumber}");                        }
                    }
                    break;
                case "6":
                    Console.WriteLine("Here are the students from Philippines:");   
                    foreach (Phonebook studentCountry in Students){
                        if (studentCountry.countryCode == "63"){
                        Console.WriteLine($"{studentCountry.Firstname} {studentCountry.Surname} is a {studentCountry.Occupation}. Gender is {studentCountry.Gender}. And their number is {studentCountry.countryCode}-{studentCountry.areaCode}-{studentCountry.phoneNumber}");                        }
                    }
                    Console.WriteLine("\nHere are the students from Thailand:");   
                    foreach (Phonebook studentCountry in Students){
                        if (studentCountry.countryCode == "66"){
                        Console.WriteLine($"{studentCountry.Firstname} {studentCountry.Surname} is a {studentCountry.Occupation}. Gender is {studentCountry.Gender}. And their number is {studentCountry.countryCode}-{studentCountry.areaCode}-{studentCountry.phoneNumber}");                        }
                    }
                    Console.WriteLine("\nHere are the students from Singapore:");   
                    foreach (Phonebook studentCountry in Students){
                        if (studentCountry.countryCode == "65"){
                        Console.WriteLine($"{studentCountry.Firstname} {studentCountry.Surname} is a {studentCountry.Occupation}. Gender is {studentCountry.Gender}. And their number is {studentCountry.countryCode}-{studentCountry.areaCode}-{studentCountry.phoneNumber}");                        }
                    }
                    Console.WriteLine("\nHere are the students from Indonesia:");   
                    foreach (Phonebook studentCountry in Students){
                        if (studentCountry.countryCode == "62"){
                        Console.WriteLine($"{studentCountry.Firstname} {studentCountry.Surname} is a {studentCountry.Occupation}. Gender is {studentCountry.Gender}. And their number is {studentCountry.countryCode}-{studentCountry.areaCode}-{studentCountry.phoneNumber}");                        }
                    }
                    Console.WriteLine("\nHere are the students from Malaysia:");   
                    foreach (Phonebook studentCountry in Students){
                        if (studentCountry.countryCode == "60"){
                        Console.WriteLine($"{studentCountry.Firstname} {studentCountry.Surname} is a {studentCountry.Occupation}. Gender is {studentCountry.Gender}. And their number is {studentCountry.countryCode}-{studentCountry.areaCode}-{studentCountry.phoneNumber}");                        }
                    }
                    break;
                case "0":
                    Console.Write("Search by Country has ended.\nReturning to Main Menu...");
                    break;
                default:
                    Console.WriteLine("Select a VALID Option");
                    break;
                    }
                }while (menuSelect != "0");    
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
                EditStudent(Students);
                break;
            case "3":
                SearchStudent(Students);
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