namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Changed answer and response into inferred type.
            var answer = 4;
            var response = "";
            // Changed if else statement into its' ternary equivalent.
            response = answer < 9 ? 
                $"{answer} is less than nine." : 
                $"{answer} is greater than or equal to nine";
            // Print out response.
            Console.WriteLine(response);
        }
    }
}
