// See https://aka.ms/new-console-template for more information


using Exercise___Interfaces_and_Abstraction.Problem_1___2;

TestProblem1();

static void TestProblem1()
{
    Console.Write("Enter citizen's name: ");
    string name = Console.ReadLine();
    Console.Write("Enter citizen's age: ");
    int age = int.Parse(Console.ReadLine());
    IPerson person = new Citizen(name, age);
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Age);
}
