namespace OperatorOverloadingEx1
{
    public class Calculator
    {
        public int number { get; set; }

        public static Calculator operator ++(Calculator obj)
        {
            obj.number++;
            return obj;
        }
        public static Calculator operator --(Calculator obj) 
        {
            obj.number--;
            return obj;
        }
        public static bool operator >(Calculator left, Calculator right)
        {
            bool larger = false;
            if (left.number > right.number) 
                larger = true;
            return larger;
        }
        public static bool operator <(Calculator left, Calculator right) 
        {
            bool smaller = false;
            if(left.number < right.number)
                smaller = true;
            return smaller;
        }
        public static Calculator operator +(Calculator obj1, Calculator obj2)
        {
            Calculator calc1 = new Calculator();
            calc1.number = obj1.number + obj2.number;
            return calc1;
        }
        public static Calculator operator -(Calculator obj1, Calculator obj2) 
        { 
            Calculator calc2 = new Calculator();
            calc2.number = obj1.number - obj2.number;
            return calc2;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Calculator[] numbers = new Calculator[10];
            Console.Write("Original Numbers = ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Calculator(); 
                numbers[i].number = r.Next(1, 100);  
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            
            Console.Write("New Numbers +1 or -1 = ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].number % 2 == 0)
                {
                    numbers[i]++;
                }
                else
                {
                    numbers[i]--;
                }
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            Calculator numToAdd = new Calculator();
            numToAdd.number = r.Next(1, 20);
            Console.Write($"Numbers + {numToAdd.number} = ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += numToAdd;
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            Calculator numToSub = new Calculator();
            numToSub.number = r.Next(1, 20);
            Console.Write($"Numbers - {numToSub.number} = ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= numToSub;
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            Calculator numToCompare = new Calculator();
            numToCompare.number = r.Next(1, 100);
            Console.WriteLine($"Numbers above or below {numToCompare.number}:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numToCompare)
                    Console.WriteLine($"{numbers[i].number} is above");
                else if (numbers[i] < numToCompare)
                    Console.WriteLine($"{numbers[i].number} is below");
                else
                    Console.WriteLine($"{numbers[i].number} is equal to");
            }
        }
    }
}