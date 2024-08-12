using ConsoleApp5;

EmpoyeeRepositroy empoyeeRepositroy = new EmpoyeeRepositroy();

Console.WriteLine("Please Enter EmployeeId");
int employeeId = Convert.ToInt32(Console.ReadLine());
empoyeeRepositroy.DeleteEmployee(employeeId);

//Employee d= new Employee();

//Console.WriteLine("Please Enter Name");

//d.Name =  Console.ReadLine();

//Console.WriteLine("Please Enter Address");

//d.Address = Console.ReadLine();

//bool p= empoyeeRepositroy.AddEmployee(d);

//if(p)
//{
//    Console.WriteLine("Record saved suces.");
//}
//else
//{
//    Console.WriteLine("error");
//}