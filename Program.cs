bool flag1 =true;
bool flag2 =true;
bool flag3 =true;
double number1=0;
double number2=0;
double result=0;
string caloperator;

while (flag1)
{
    Console.WriteLine("enter number 1 :");
    try
    {
        number1 = Convert.ToDouble(Console.ReadLine());
        flag1 = false;

    }
    catch(FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("your input is invalid !");
        Console.ResetColor();
        flag1 = true;
        
    }
}
while (flag2)
{
    Console.WriteLine("enter number 2 :");
    try
    {
        number2 = Convert.ToDouble(Console.ReadLine());
        flag2 = false;

    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        flag2 = true;
        Console.WriteLine("your input is invalid !");
        Console.ResetColor();
    }

}

while (flag3)
{
    Console.WriteLine("enter operator ( + , - , * , / ) :");
    try
    {
        caloperator = Console.ReadLine();
        flag3 = false;
        switch (caloperator)
        {
            case "+" :
                result = number1 + number2;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"result =>  {number2} {caloperator} {number1} = {result}");
                Console.ResetColor();
                break;
            case "-" :
                result = number2 - number1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"result => {number2} {caloperator} {number1} = {result}");
                Console.ResetColor();
                break;
            case "*" :
                result = number2 * number1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"result => {number2} {caloperator} {number1} = {result}");
                Console.ResetColor();
                break;
            case "/" :
                result = number2 / number1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"result => {number2} {caloperator} {number1} = {result}");
                Console.ResetColor();
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your entry must be one of the 4 modes listed !");
                Console.ResetColor();
                flag3 = true;
                break;
            
        }
    }
    catch (FormatException)
    {
        flag3 = true;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("your input is invalid !");
        Console.ResetColor();
    }
}
Console.WriteLine("Enter something to close");
Console.ReadKey();



