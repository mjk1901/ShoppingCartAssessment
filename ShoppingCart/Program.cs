using ShoppingCart.Billing;
using ShoppingCart.Disounts.Factory;

var factory = new DiscountPolicyFactory();
var calculator = new BillingCalculator(factory);

Console.WriteLine(calculator.CalculateBill("Regular", 5000)); 
Console.WriteLine(calculator.CalculateBill("Regular", 10000)); 
Console.WriteLine(calculator.CalculateBill("Regular", 15000)); 
Console.WriteLine(calculator.CalculateBill("Premium", 4000)); 
Console.WriteLine(calculator.CalculateBill("Premium", 8000)); 
Console.WriteLine(calculator.CalculateBill("Premium", 12000)); 
Console.WriteLine(calculator.CalculateBill("Premium", 20000)); 