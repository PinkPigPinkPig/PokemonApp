using PokemonApp.Models;

namespace PokemonApp.Interfaces
{
    public interface ICountryRepository
    {
         ICollection<Country> GetCountries();
         Country GetCountry(int id);
         Country GetCountryByOwner(int ownerId);
         ICollection<Owner> GetOwnersFromCountry(int countryId);
         bool IsCountryExists(int id);
         bool CreateCountry(Country country);
         bool Save();
    }
}