namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their favorite school subject.
            Console.WriteLine("Hello!\nWhat's your favorite school subject?");
            Console.WriteLine("History = 0");
            Console.WriteLine("Math = 1");
            Console.WriteLine("Science = 2");
            Console.WriteLine("English = 3");
            Console.WriteLine("Art = 4");

            //Store their answer in a variable
            var favSubject = int.Parse(Console.ReadLine());

            //Pass the variable as the expression in a switch statement.
            //Create 5 different cases for different subjects. Each case will print the subject chosen and a custom message of your choosing.
            //Create a default case to handle any case not handled.
            
            switch (favSubject) 
            {
                case 0:
                    Console.WriteLine("nice!");
                    break;
                case 1:
                    Console.WriteLine("Are you sure about that?");
                    break;
                case 2:
                    Console.WriteLine("Not to bad of a subject.");
                    break;
                case 3:
                    Console.WriteLine("Me too");
                    break;
                case 4:
                    Console.WriteLine("Good choice.");
                    break;
                default:
                    Console.WriteLine("come on!");
                    break;

                        
                      

            }

            


        }
    }
}