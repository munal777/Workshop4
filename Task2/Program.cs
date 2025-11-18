class Program
{
    public static void Main(string[] args)
    {
        Calculator obj = new Calculator();

        int sum = obj.Add(2,3);
        int mul = obj.Multiply(5);

        obj.PrintWelcome();
        Console.WriteLine($"sum result: {sum}, mul result: {mul}");
    }
}