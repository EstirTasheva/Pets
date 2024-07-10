using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PetStore petStore = new PetStore();

            Console.Write("Въведете брой домашни любимци: ");
            int petCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < petCount; i++)
            {
                Console.Write("Въведете име на домашния любимец: ");
                string petName = Console.ReadLine();
                Console.Write("Въведете вид на домашния любимец: ");
                string petType = Console.ReadLine();
                Console.Write("Въведете възраст на домашния любимец: ");
                int petAge = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Pet pet = new Pet(petName, petType, petAge);
                petStore.AddPet(pet);
            }

            Console.Write("Въведете брой собственици: ");
            int ownerCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < ownerCount; i++)
            {
                Console.Write("Въведете име на собственика: ");
                string ownerName = Console.ReadLine();
                Console.Write("Въведете възраст на собственика: ");
                int ownerAge = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Owner owner = new Owner(ownerName, ownerAge);
                petStore.AddOwner(owner);
            }

            petStore.DisplayPets();
            petStore.DisplayOwners();
        }
    }
}
