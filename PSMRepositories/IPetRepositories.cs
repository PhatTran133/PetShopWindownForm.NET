using BuisinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMRepositories
{
    public interface IPetRepositories
    {
        List<Pets> GetPetByName(string name);
        List<Pets> GetAllPets();
        void CreatePet(Pets pet);
        void EditPet(Pets pet);
        void RemovePet(string id);
        List<string> GetAllTypes();
        List<string> GetAllBreedDogs();
        List<string> GetAllBreedCats();
    }
}
