using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ice_task_lambda_17_04_23
{
    public delegate List<int> sort(List<int> numbers);
    public delegate Queue<int> even(Queue<int> digits);
    internal class Even
    {


        public List<int> getEvenNumbers(List<int> numbers)
        {

            numbers.ForEach(number => { if (number % 2 == 0) Console.WriteLine(number); });


            for (int i = 0; i < numbers.Count; i++) {
                
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                
            }
            return numbers;
        }
        
        public Queue<int> EvenNumbers(Queue<int> digits)
        {
            foreach(int i in digits.Where(number =>number % 2 == 0)) { 
                Console.WriteLine($"{i}");
            }

            return digits;
        }
        
    }
}
