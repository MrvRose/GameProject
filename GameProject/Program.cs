using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                Birthday = 1986,
                FırstName = "Engin",
                LastName = "Demirg",
                IdentityNumber = 12345

            });
            

        }
    }
}
