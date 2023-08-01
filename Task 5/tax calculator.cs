
using System;

public abstract class Taxcalculator
{
    public decimal income;
    public decimal taxAmount;

    public decimal Income
    {
        get { return income; }
        set { income = value; }
    }

    public decimal TaxAmount
    {
        get { return taxAmount; }
    }

    public abstract void calculateTax();

    public void displaytax()
    {
        Console.WriteLine($"Income:Rs {income}");
        Console.WriteLine($"Tax Amount:Rs {taxAmount}");
    }
}

public class lowsalary : Taxcalculator
{
    public override void calculateTax()
    {
        taxAmount = income * 0.1m;
    }

}
public class midsalary : Taxcalculator
{
    public override void calculateTax()
    {
        taxAmount = income * 0.3m;
    }

}
public class highsalary : Taxcalculator
{
    public override void calculateTax()
    {
        taxAmount = income * 0.5m;
    }

}

class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter salary");
        decimal employeesalary = Convert.ToDecimal(Console.ReadLine());
        Taxcalculator tax;

        if (employeesalary > 25000)
        {
            tax = new lowsalary();
        }
        else if (employeesalary > 50000)
                {
            tax = new midsalary();
        }
        else
        {
            tax = new highsalary();
        }

        tax.Income = employeesalary;

        tax.calculateTax();
        Console.WriteLine("tax details :");
        tax.displaytax();
        Console.ReadLine();
    }
}