namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Changed answer into inferred type.
            var answer = 4;
            // Changed var to inferred type and the if else statement into its' ternary equivalent.
            var response = answer < 9 ? 
                $"{answer} is less than nine." : 
                $"{answer} is greater than or equal to nine";
            // Print out response.
            Console.WriteLine(response);
        }
    }
}
