namespace ice_task_lambda_17_04_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Even e = new Even();
            
            List<int> numbers = new List<int>()
            {
                1, 7, 2, 5, 10, 16, 20, 24
            };

            Queue<int> digits = new Queue<int>();

            foreach(int i in numbers)
            {
                digits.Enqueue(i);
            }

            sort s = e.getEvenNumbers;
            List<int> list = s(numbers);

            even ev = e.EvenNumbers;
            Queue<int> q = ev(digits);

            int x = numbers[2];
            int y = numbers[3];


            Func<int, int, int > add = delegate { return x + y; };
            Func<int, int, int> subtract = delegate { return x- y; };
            Func<int, int, int> multiply = delegate { return x * y; };
            Func<int, int, int> divide = delegate { return x / y; };

            Console.WriteLine($"x + y = {add(x, y)}");
            Console.WriteLine($"x - y = {subtract(x, y)}");
            Console.WriteLine($"x * y = {multiply(x, y)}");
            Console.WriteLine($"x / y = {divide(x, y)}");
        }
    }
}