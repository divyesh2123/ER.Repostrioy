using ConsoleApp5;

EmpoyeeRepositroy empoyeeRepositroy = new EmpoyeeRepositroy();

//var d = empoyeeRepositroy.GetAllEmployees();

//foreach (var employee in d)
//{
//    Console.WriteLine(employee.Name);
//}

Employee employeeobj = new Employee();
Console.WriteLine("Please Enter EmployeeId for update");
employeeobj.Id = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Name to update");

employeeobj.Name = Console.ReadLine();


Console.WriteLine("Please Enter Address to update");

employeeobj.Address = Console.ReadLine();

empoyeeRepositroy.UpdateEmployee(employeeobj);





//Console.WriteLine("Please Enter EmployeeId");
//int employeeId = Convert.ToInt32(Console.ReadLine());
//empoyeeRepositroy.DeleteEmployee(employeeId);

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