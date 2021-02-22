using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1, 
                BirthYear = 1984, 
                FirstName = "ENES", 
                LastName = "BORA", 
                IdentityNumber = 12607745192
            });
            Console.WriteLine("Hello World!");
        }
    }
}
