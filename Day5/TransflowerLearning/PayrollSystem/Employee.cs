namespace PayrollSystem;
public class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public SalarySlip Salary { get; set; }

    public Employee(int empId, string ename, double basicSal)
    {
        this.EmpId = empId;
        this.EmpName = ename;
        this.Salary = new SalarySlip(basicSal);
    }

    public override string ToString()
    {
        return $"Employee Id: {this.EmpId} Employee Name: {this.EmpName} Salary :{this.Salary}";
    }
}
