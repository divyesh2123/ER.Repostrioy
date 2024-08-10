using ConsoleApp5;

EmpoyeeRepositroy empoyeeRepositroy = new EmpoyeeRepositroy();

Employee d= new Employee();

Console.WriteLine("Please Enter Name");

d.Name =  Console.ReadLine();

Console.WriteLine("Please Enter Address");

d.Address = Console.ReadLine();

bool p= empoyeeRepositroy.AddEmployee(d);

if(p)
{
    Console.WriteLine("Record saved suces.");
}
else
{
    Console.WriteLine("error");
}