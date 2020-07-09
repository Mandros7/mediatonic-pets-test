using MediatonicPets.Models;

namespace MediatonicPets.Factories
{
    /// <summary>
    /// Class <c>DogFactory</c> inherits from PetFactory and allows to potentially insert additional
    /// features to the generation of specific Pets. In the event that different pets have different metrics,
    /// it will be possible to attend to those here.
    /// </summary>
    public class DogFactory : PetFactory
    {       
        private string BASE_TYPE = "dog"; 
        public override Pet GetPet() {
            Pet newPet = base.GetPet();
            newPet.Type = BASE_TYPE;
            return newPet;
        }

        public DogFactory(IPetConfigurationSettings settings) : base(settings) {
            BASE_TYPE = "dog";                   
        }

        public DogFactory() : base() {
        }
    }
}