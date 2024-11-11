
    //nameSpace is a keyword used to declare a scope that contains a set of related objects. 
    //SelectionStatementExercise is the name of the folder that contains the code

    using System.Security.Cryptography;
    using System.Threading.Channels;

    namespace SelectionStatementExercise
{ 
    //public class -  is the Class Type
    // class - is a bundle of related code,(can be used as blueprint to creat objects (OOP)
    // program - is the named of the class.
    // side note: the class is named program and the point of that class is to group the program.
    
    public class Program
    {
       //Static void is the method that dose not return a value.
       
        
        static void Main(string[] args)
        {
            var random = new Random();
            var favoriteNumbber = random.Next(1, 11);
            int reponse = 0;
            
            
            //while is a variable loop
            // 
            while (reponse != favoriteNumbber)
            {
                Console.WriteLine("Give me a number between 1 and 10:");
                int respose = int.Parse(Console.ReadLine());

                if (respose < favoriteNumbber)
                {
                    Console.WriteLine($"Too low!\nYour guess: {respose}");
                }
                else if (respose > favoriteNumbber)
                {
                    Console.WriteLine($"Too high!\nYour guess: {respose}");
                }
                else
                {
                    Console.WriteLine("$You guessed it!\nThe favorite number was {favoriteNumbber}!");
                }
            }
        }
    }
}
