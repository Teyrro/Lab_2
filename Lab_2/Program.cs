 
class Program
{
    static void Main(string[] arg)
    {
        try
        {
            RomanNumber number = new RomanNumber(3);
            RomanNumber number2 = new RomanNumber(2);

            Console.WriteLine($"n1 - {number}, n2 - {number2}");
             
            Console.WriteLine($"Add(n1, n2) - {RomanNumber.Add(number, number2).ToString()} ");

            
            Console.WriteLine($"Sub(n1, n2) - {RomanNumber.Sub(number, number2).ToString()} ");

         
            Console.WriteLine($"Mul(n1, n2) - {RomanNumber.Mul(number, number2).ToString()} ");

          
            Console.WriteLine($"Div(n1, n2) - {RomanNumber.Div(number, number2).ToString()} ");
        }
        catch (RomanNumberException e)
        {
            Console.WriteLine($"{e.Message}");
            Console.WriteLine($"Некорректное значение: {e.Value}");
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine($"{e.Message}");
        }
    }
}