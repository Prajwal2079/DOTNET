namespace PayrollSystem;

public class SalarySlip
{
    private static int slipNo = 1001;
    public readonly int SalarySlipId;
    public double BasicSal { get; set; }
    public double HrAllowance;
    public double DA;

    public double GrossSal;

    public SalarySlip(double basicSal)
    {
        this.SalarySlipId = slipNo;
        this.BasicSal = basicSal;
        this.HrAllowance = basicSal * 0.15;
        this.DA = basicSal * 0.08;
        this.GrossSal = BasicSal + HrAllowance + DA;
        slipNo++;
    }

    public override string ToString()
    {
        return $"Salary Slip Id: {this.SalarySlipId} Basic Salary: {this.BasicSal} HR Allowance: {this.HrAllowance} DA Allowance: {this.DA} Gross Salary:{this.GrossSal}";
    }
}