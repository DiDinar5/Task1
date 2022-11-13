namespace Task1
{
    public interface ICalculator
    {
        public int Sum(int a, int b);
    }
    class Calculator : ICalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Калькулятор начал свою работу");
            try
            {
                while (true)
                {
                    Console.WriteLine("Введите первое число");
                    a = int.Parse(Console.ReadLine());
                    ///  if (int.TryParse(Console.ReadLine(), out a));
                    Console.WriteLine("Введите второе число");
                    b = int.Parse(Console.ReadLine());
                    /// if (int.TryParse(Console.ReadLine(), out b));
                    Calculator calculator = new Calculator();
                    int res = calculator.Sum(a, b);
                    Console.WriteLine("{0} + {1} = {2}", a, b, res);
                }
            }
            catch
            {
                Console.WriteLine("Введено не корректное значение");
                Console.WriteLine("Калькулятор завершил свою работу");
            }
        }

    }
}
