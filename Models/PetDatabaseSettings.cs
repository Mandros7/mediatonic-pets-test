namespace MediatonicPets.Models
{

    public class PetDatabaseSettings : IPetDatabaseSettings
    {
        public string PetCollectionName { get; set; }
        public string UserCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IPetDatabaseSettings
    {
        string PetCollectionName { get; set; }
        string UserCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}