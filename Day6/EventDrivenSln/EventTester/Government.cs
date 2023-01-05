namespace Governance{
    public delegate void TaxOperations(double amount);
    public class CtrlGovernment{
        public void DeductIncomeTax(double amount){
            Console.WriteLine($"45% income tax {amount*0.45} is deducted from your account");
        }
        public void DeductServiceTax(double amount){
            Console.WriteLine($"18% income tax {amount*0.18} is deducted from your account");
        }
        public void DeductProfessionalTax(double amount){
            Console.WriteLine($"10% income tax {amount*0.1} is deducted from your account");

        }
    }
}