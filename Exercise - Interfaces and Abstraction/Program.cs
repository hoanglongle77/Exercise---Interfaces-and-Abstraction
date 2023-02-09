// See https://aka.ms/new-console-template for more information


using Exercise___Interfaces_and_Abstraction.Problem_1___2;
using Exercise___Interfaces_and_Abstraction.Problem_3;

using System.Numerics;

TestProblem3();

/*static void TestProblem1()
{
    Console.Write("Enter citizen's name: ");
    string name = Console.ReadLine();
    Console.Write("Enter citizen's age: ");
    int age = int.Parse(Console.ReadLine());
    IPerson person = new Citizen(name, age);
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Age);
}*/

static void TestProblem2()
{
    Console.Write("Enter citizen's id: ");
    string id = Console.ReadLine();
    Console.Write("Enter citizen's name: ");
    string name = Console.ReadLine();
    Console.Write("Enter citizen's age: ");
    int age = int.Parse(Console.ReadLine());
    Console.Write("Enter citizen's birthdate: ");
    string birthdate = Console.ReadLine();
    IIdentifiable identifiable = new Citizen(id, name, age, birthdate);
    IBirthdate birthdate1 = new Citizen(id, name, age, birthdate);
    Console.WriteLine(identifiable.Id);
    Console.WriteLine(birthdate1.Birthdate);

}

static void TestProblem3()
{
    SmartPhone myPhone = new SmartPhone("IPhone X");

    var numbersToCall = Console.ReadLine().Split();

    foreach (var number in numbersToCall)
    {
        Console.WriteLine(myPhone.Call(number));
    }

    var sitesToBrowse = Console.ReadLine().Split();

    foreach (var site in sitesToBrowse)
    {
        Console.WriteLine(myPhone.Browse(site));
    }
}