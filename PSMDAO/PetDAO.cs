using BuisinessObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PSMDAO
{
    public class PetDAO
    {
        private static PetDAO instance = null;
        private static string filePathTypes = "C:\\Visual Studio\\PSMSolution\\PSMData\\PSMTypes.json";
        private static string filePathBreedDogs = "C:\\Visual Studio\\PSMSolution\\PSMData\\PSMBreedDogs.json";
        private static string filePathBreedCats = "C:\\Visual Studio\\PSMSolution\\PSMData\\PSMBreedCats.json";
        private static string filePathPets = "C:\\Visual Studio\\PSMSolution\\PSMData\\PSMPets.json";

        private PetDAO()
        {
        }

        public static PetDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PetDAO();
                }
                return instance;
            }
        }

        public List<Pets> GetPetByName(string name)
        {
            try
            {
                if (File.Exists(filePathPets))
                {
                    List<Pets> PetList = new List<Pets>();


                    using (StreamReader reader = new StreamReader(filePathPets))
                    {
                        string json = reader.ReadToEnd();
                        dynamic data = JsonConvert.DeserializeObject(json);


                        foreach (var pet in data.Pets)
                        {
                            PetList.Add(new Pets(pet.Id.ToString(), pet.Name.ToString(), Convert.ToDateTime(pet.MonthYear), pet.Type.ToString(), pet.Breed.ToString(), Convert.ToInt32(pet.Price), Convert.ToInt32(pet.Discount)));
                        }
                    }
                    Pets petSearch = PetList.FirstOrDefault(p => p.Name.ToLower().Contains(name.ToLower()));
                    List<Pets> PetListView = new List<Pets>();
                    PetListView.Add(petSearch);
                    return PetListView;
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathPets);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return null;
        }
        public List<Pets> GetAllPets()
        {
            try
            {
                if (File.Exists(filePathPets))
                {
                    List<Pets> PetList = new List<Pets>();

                    using (StreamReader reader = new StreamReader(filePathPets))
                    {
                        string json = reader.ReadToEnd();
                        dynamic data = JsonConvert.DeserializeObject(json);

                        foreach (var pet in data.Pets)
                        {
                            PetList.Add(new Pets(pet.Id.ToString(), pet.Name.ToString(), Convert.ToDateTime(pet.MonthYear), pet.Type.ToString(), pet.Breed.ToString(), Convert.ToInt32(pet.Price), Convert.ToInt32(pet.Discount)));
                        }
                    }
                    return PetList;
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathPets);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return null;
        }
        public void CreatePet(Pets pet)
        {
            try
            {
                string id = null;
                int maxNumber = 0;
                List<Pets> petList = GetAllPets();
                Pets newPet = null;


                if (File.Exists(filePathPets))
                {
                    bool flag = false;
                    foreach (var existingPet in petList)
                    {
                        if (existingPet.Id == pet.Id || existingPet.Name == pet.Name)
                        {
                            flag = true;
                            break;
                        }
                        int number;
                        if (int.TryParse(existingPet.Id.Substring(1), out number))
                        {
                            if (number > maxNumber)
                            {
                                maxNumber = number;
                            }
                        }
                    }
                    if (flag)
                    {
                        throw new Exception("Id or Name is duplicated");
                    }
                    if (pet.Id != null)
                    {
                        id = pet.Id.ToString();
                        
                    }
                    id = "P" + (maxNumber + 1).ToString("D3");

                    newPet = new Pets(
                        id,
                        pet.Name,
                        pet.MonthYear,
                        pet.Type,
                        pet.Breed,
                        pet.Price,
                        pet.Discount
                        );

                    petList.Add( newPet );

                    string json = JsonConvert.SerializeObject(new { Pets = petList }, Formatting.Indented);
                    File.WriteAllText(filePathPets, json);
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathPets);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public void EditPet(Pets pet)
        {
            try
            {
                if (File.Exists(filePathPets))
                {
                    List<Pets> PetList = GetAllPets();

                    Pets existingPet = PetList.FirstOrDefault(p => p.Id == pet.Id);

                    if (existingPet != null)
                    {
                        // Update the properties of existingPet with the properties of pet.
                        existingPet.Name = pet.Name;
                        existingPet.MonthYear = pet.MonthYear;
                        existingPet.Type = pet.Type;
                        existingPet.Breed = pet.Breed;
                        existingPet.Price = pet.Price;
                        existingPet.Discount = pet.Discount;

                        string json = JsonConvert.SerializeObject(new { Pets = PetList }, Formatting.Indented);
                        File.WriteAllText(filePathPets, json);
                    }
                    else
                    {
                        throw new Exception("Pet not found.");
                    }
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathPets);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public void RemovePet(string id)
        {
            try
            {
                if (File.Exists(filePathPets))
                {
                    List<Pets> PetList = GetAllPets();

                    Pets petToRemove = PetList.FirstOrDefault(p => p.Id == id);

                    if (petToRemove != null)
                    {
                        PetList.Remove(petToRemove);

                        string json = JsonConvert.SerializeObject(new { Pets = PetList }, Formatting.Indented);
                        File.WriteAllText(filePathPets, json);
                    }
                    else
                    {
                        throw new Exception("Pet not found.");
                    }
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathPets);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        public List<string> GetAllTypes()
        {
            try
            {
                if (File.Exists(filePathTypes))
                {
                    List<string> typeList = new List<string>();

                    using (StreamReader reader = new StreamReader(filePathTypes))
                    {
                        string json = reader.ReadToEnd();
                        dynamic data = JsonConvert.DeserializeObject(json);

                        foreach (var type in data.Types)
                        {
                            typeList.Add(type.Type.ToString());
                        }
                    }
                    return typeList;
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathTypes);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return null;
        }
        public List<string> GetAllBreedDogs()
        {
            try
            {
                if (File.Exists(filePathBreedDogs))
                {
                    List<string> breedList = new List<string>();

                    using (StreamReader reader = new StreamReader(filePathBreedDogs))
                    {
                        string json = reader.ReadToEnd();
                        dynamic data = JsonConvert.DeserializeObject(json);

                        foreach (var type in data.BreedDogs)
                        {
                            breedList.Add(type.Breed.ToString());
                        }
                    }
                    return breedList;
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathBreedDogs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return null;
        }
        public List<string> GetAllBreedCats()
        {
            try
            {
                if (File.Exists(filePathBreedCats))
                {
                    List<string> breedList = new List<string>();

                    using (StreamReader reader = new StreamReader(filePathBreedCats))
                    {
                        string json = reader.ReadToEnd();
                        dynamic data = JsonConvert.DeserializeObject(json);

                        foreach (var type in data.BreedCats)
                        {
                            breedList.Add(type.Breed.ToString());
                        }
                    }
                    return breedList;
                }
                else
                {
                    throw new FileNotFoundException("File not found.", filePathBreedCats);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return null;
        }
    }
}
