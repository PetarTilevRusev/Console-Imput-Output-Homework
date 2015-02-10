using System;
                /*Problem 2. Print Company Information
                
                    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
                    Write a program that reads the information about a company and its manager and prints it back on the console.
                
                            Example input:                                                     Example output:
                            program 	            user
                            Company name: 	        Telerik Academy                                Telerik Academy
                            Company address: 	    31 Al. Malinov, Sofia                          Address:     231 Al. Malinov, Sofia
                            Phone number: 	        +359 888 55 55 555                             Tel.         +359 888 55 55 555
                            Fax number: 	        2                                              Fax:         (no fax)
                            Web site: 	            http://telerikacademy.com/                     Web site:    http://telerikacademy.com/
                            Manager first name:     Nikolay                                        Manager:     Nikolay Kostov (age: 25, tel. +359 2 981 981)  
                            Manager last name: 	    Kostov
                            Manager age: 	        25
                            Manager phone: 	        +359 2 981 981
                */
class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Welcome to ---> RegisterYourCompany.com <---");
        Console.WriteLine("Please follow the instructions bellow!");
        Console.WriteLine(new string('-', 80));

        //Taking the company information
        Console.Write("\nCompany name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.Clear(); //Cleaning the console

        //Printing the company information
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhone);
        Console.WriteLine("Fax. {0}", faxNumber);
        Console.WriteLine("Web Site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (Age: {2}, Tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

