using PayrollSystem;
using System.Collections.Generic;

List<Employee> emplist = new List<Employee>();
Employee emp1 = new Employee(100, "Prajwal", 30000);
Employee emp2 = new Employee(101, "Suraj", 20000);
Employee emp3 = new Employee(102, "Shruti", 60000);
Employee emp4 = new Employee(103, "Swanad", 10000);
Employee employee;

emplist.Add(emp1);
emplist.Add(emp2);
emplist.Add(emp3);
emplist.Add(emp4);
int choice;
bool flag = false;

do
{
    Console.WriteLine("Make a choice.\n1.Add SalarySlip for an employee.\n2.Get Specific Employee SalarySlip\n3.Delete salaryslip by Salary Slip ID.\n4.Display Salary Slips of all Employee.\n5.Update Basic Salary of existing employee\n6.Exit");
    choice = Convert.ToInt16(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter Employee ID, Employee Name and Basic Salary");
            employee = new Employee(Convert.ToInt16(Console.ReadLine()), Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
            emplist.Add(employee);
            Console.WriteLine("Salary Slip Generated");
            break;

        case 2:
            Console.WriteLine("Enter the Employee Id");
            int empId = Convert.ToInt16(Console.ReadLine());
            foreach (Employee emp in emplist)
            {
                if (emp.EmpId == empId)
                {
                    Console.WriteLine(emp);
                    flag = true;
                }
            }
            if (!flag)
                Console.WriteLine("Employee Not Found");

            break;

        case 3:
            Console.WriteLine("Enter the Salary Slip Id");
            int id = Convert.ToInt16(Console.ReadLine());
            Employee temp = null;
            foreach (Employee emp in emplist)
            {
                if (emp.Salary.SalarySlipId == id)
                {
                    temp = emp;
                }
            }
            emplist.Remove(temp);
            break;

        case 4:
            foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp);
            }
            break;

        case 5:
            Console.WriteLine("Enter the Employee ID and Salary Slip Id");
            int empid = Convert.ToInt16(Console.ReadLine());
            id = Convert.ToInt16(Console.ReadLine());
            foreach (Employee emp in emplist)
            {
                if (emp.EmpId == empid && emp.Salary.SalarySlipId == id)
                {
                    Console.WriteLine("Enter new Basic Salary");
                    double basicSal = Convert.ToDouble(Console.ReadLine());
                    emp.Salary.BasicSal = basicSal;
                    emp.Salary.HrAllowance = emp.Salary.BasicSal * 0.15;
                    emp.Salary.DA = emp.Salary.BasicSal * 0.08;
                    emp.Salary.GrossSal = emp.Salary.BasicSal + emp.Salary.HrAllowance + emp.Salary.DA;
                    flag = true;
                    break;
                }
            }
            if (!flag)
                Console.WriteLine("Employee Not Found");
            break;

        case 6:
            Console.WriteLine("Thankyou");
            break;
    }
} while (choice != 6);

