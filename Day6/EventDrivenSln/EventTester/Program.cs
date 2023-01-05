using Governance;
using Banking;
class MainClass
{
    static public void Main(String[] args)
    {
        CtrlGovernment bjpGov = new CtrlGovernment();

        TaxOperations incomeTax = new TaxOperations(bjpGov.DeductIncomeTax);
        TaxOperations profTax = new TaxOperations(bjpGov.DeductProfessionalTax);
        TaxOperations serviceTax = new TaxOperations(bjpGov.DeductServiceTax);
        // incomeTax(5000);
        // profTax(5000);
        // serviceTax(5000);

        // Console.WriteLine("------------------------------------");
        TaxOperations allTaxOperations = null;
        allTaxOperations += incomeTax;
        allTaxOperations += profTax;
        allTaxOperations += serviceTax;
        // allTaxOperations(5000);

        // Console.WriteLine("------------------------------------");
        // allTaxOperations -= profTax;
        // allTaxOperations(5000);


        BankManager bankManager = new BankManager();
        BankManagerOperations sendSMS = new BankManagerOperations(bankManager.SendSMS);
        BankManagerOperations sendEmail = new BankManagerOperations(bankManager.SendEmail);
        BankManagerOperations blockAccount = new BankManagerOperations(bankManager.BlockAccount);
        BankManagerOperations allManagerOperations = null;
        allManagerOperations += sendSMS;
        allManagerOperations += sendEmail;
        allManagerOperations += blockAccount;


        Account acc3726 = new Account(4000);
        acc3726.underBalance += allManagerOperations;
        acc3726.overBalance += allTaxOperations;

        acc3726.ProcessTax();

        Console.WriteLine("Withdrawing 3000");
        acc3726.Withdraw(3000);

        Console.WriteLine("Withdrawing 600");
        acc3726.Withdraw(600);
    }
}