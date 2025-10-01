using CaseStudy.Model;
using CaseStudy.Service;
using CaseStudy.Animals;

namespace MyApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool continueProgram = true;
            
            while (continueProgram)
            {
                Console.Clear();
                Console.WriteLine("=== Question Selection Menu ===");
                Console.WriteLine("1. First Question - Try-Catch Structure");
                Console.WriteLine("2. Second Question");
                Console.WriteLine("3. Third Question");
                Console.WriteLine("4. Fourth Question");
                Console.WriteLine("5. Fifth Question");
                Console.WriteLine("0. Exit");
                Console.Write("Please make a selection (0-5): ");
                
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Program is terminating...");
                            continueProgram = false;
                            break;
                        case 1:
                            FirstQuestion();
                            break;
                        case 2:
                            SecondQuestion();
                            break;
                        case 3:
                            ThirdQuestion().Wait();
                            break;
                        case 4:
                            FourthQuestion();
                            break;
                        case 5:
                            FifthQuestion();
                            break;
                        default:
                            Console.WriteLine("Invalid selection! Please enter a number between 0-5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                }
                
                if (continueProgram)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        public static void FirstQuestion()
        {
            Console.WriteLine("\n First Question: Try-Catch Structure");

            int[] numbers = { 1, 2, 3 };

            try
            {
                Console.WriteLine("Array elements: [1, 2, 3]");
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error caught: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        public static void SecondQuestion()
        {
            Console.WriteLine("\n Second Question: Person Class");
            
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write("Please enter your age: ");
            string ageInput = Console.ReadLine();
            
            if (int.TryParse(ageInput, out int age))
            {
                Person person = new Person(name, age);
                string introduction = person.Introduce();
                
                Console.WriteLine("\n Introduction:");
                Console.WriteLine(introduction);
            }
            else
            {
                Console.WriteLine("Invalid age input! Please enter a valid number.");
            }
        }

        public static async Task ThirdQuestion()
        {
            Console.WriteLine("\n Third Question: Async Methods");
            
            CountService countService = new CountService();

            Task<int> userCountTask = countService.GetUserCountAsync();
            Task<int> orderCountTask = countService.GetOrderCountAsync();
            Task<int> productCountTask = countService.GetProductCountAsync();
            
            Console.WriteLine("All three async methods started simultaneously!");
            Console.WriteLine("Waiting for all results to complete...");
        
            int[] results = await Task.WhenAll(userCountTask, orderCountTask, productCountTask);
            
            Console.WriteLine("\n All Results Completed ===");
            Console.WriteLine($"User Count: {results[0]}");
            Console.WriteLine($"Order Count: {results[1]}");
            Console.WriteLine($"Product Count: {results[2]}");
        }

        public static void FourthQuestion()
        {
            Console.WriteLine("\n Fourth Question: LINQ GetMax Method" );
        
            List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 3 };

            int? max = GetMax(numbers);

            Console.WriteLine($"List: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Maximum value: {max}");
        }
        
        public static int? GetMax(List<int> list)
        {
            if (list==null || !list.Any())
            {
                return null;
            }
            return list.Max();
        }

        public static void FifthQuestion()
        {
            Console.WriteLine("\n Fifth Question: Polymorphic Structure");
            
            IAnimal[] animals = {
                new Dog(),
                new Cat()
            };
            
            foreach (IAnimal animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
