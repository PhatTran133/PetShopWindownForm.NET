using BuisinessObject;
using PSMDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMRepositories
{
    public class PetRepositories : IPetRepositories
    {
        void IPetRepositories.CreatePet(Pets pet) => PetDAO.Instance.CreatePet(pet);
        void IPetRepositories.EditPet(Pets pet) => PetDAO.Instance.EditPet(pet);
        void IPetRepositories.RemovePet(string id) => PetDAO.Instance.RemovePet(id);
        List<string> IPetRepositories.GetAllBreedCats() => PetDAO.Instance.GetAllBreedCats();
        List<string> IPetRepositories.GetAllBreedDogs() => PetDAO.Instance.GetAllBreedDogs();
        List<Pets> IPetRepositories.GetAllPets() => PetDAO.Instance.GetAllPets();
        List<string> IPetRepositories.GetAllTypes() => PetDAO.Instance.GetAllTypes();
        List<Pets> IPetRepositories.GetPetByName(string name) => PetDAO.Instance.GetPetByName(name);
        

    }
}
