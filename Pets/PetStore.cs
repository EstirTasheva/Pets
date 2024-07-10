using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class PetStore
    {
        private List<Pet> pets = new List<Pet>();
        private List<Owner> owners = new List<Owner>();

        public void AddPet(Pet pet)
        {
            pets.Add(pet);
        }

        public void AddOwner(Owner owner)
        {
            owners.Add(owner);
        }

        public void DisplayPets()
        {
            if (pets.Count == 0)
            {
                Console.WriteLine("Няма налични домашни любимци.");
            }
            else
            {
                Console.WriteLine("Налични домашни любимци:");
                foreach (var pet in pets)
                {
                    pet.PetInformation();
                }
            }
        }

        public void DisplayOwners()
        {
            if (owners.Count == 0)
            {
                Console.WriteLine("Няма налични собственици.");
            }
            else
            {
                Console.WriteLine("Налични собственици:");
                foreach (var owner in owners)
                {
                    owner.OwnerInformation();
                }
            }
        }
    }
}
