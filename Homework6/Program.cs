/**       
 *--------------------------------------------------------------------
 * 	   File name: Homework 6
 * 	Project name: Methods
 *--------------------------------------------------------------------
 * Author’s name and email:	 Hardev Nischal nischal@etsu.edu			
 *          Course-Section: CSCI-1250-002
 *           Creation Date:	 04/01/22		
 * -------------------------------------------------------------------
 */
 ShowCharacter();
 CalculateRetail();
 Celsius();
 IsPrime();

static void ShowCharacter()
{
    Console.WriteLine("Enter a string");
    string strInput = Console.ReadLine();
    Console.WriteLine("What character position are you looking for?");
    int charInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The string you entered is {strInput} and the character you are looking for is {strInput[(charInput) - 1]}");
}

static void CalculateRetail()
{
    Console.WriteLine("Enter the wholesale cost");
    decimal wholesaleCost = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Enter markup percentage: %");
    decimal markupPercentage = Convert.ToDecimal(Console.ReadLine());
    decimal markupDecimal = markupPercentage / 100;
    decimal markupPrice = wholesaleCost * markupDecimal;
    decimal retailPrice = wholesaleCost + markupPrice;
    Console.WriteLine($"The retail price for this item is {retailPrice}");
}

static void Celsius()
{
    Console.WriteLine("Enter a temperature in Fahrenheit");
    var fahrenheitTemperature = Convert.ToDecimal(Console.ReadLine());
    System.Console.WriteLine("-----Table from 80F to 100F-----");
    while(fahrenheitTemperature <= 100)
    {
        var celsiusTemperature = 5 * (fahrenheitTemperature - 32) / 9;
        System.Console.WriteLine($"{fahrenheitTemperature++} F = {celsiusTemperature} C");
    }
}

static void IsPrime()
{
Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
if (IsPrime(number))
{
    Console.WriteLine("It is prime");
}
else
{
    Console.WriteLine("It is not prime");
}       
static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;
    var boundary = (int)Math.Floor(Math.Sqrt(number));
    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;
    return true;        
}
}
