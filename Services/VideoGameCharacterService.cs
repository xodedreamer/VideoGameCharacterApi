using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services
{
    public class VideoGameCharacterService : IVideoGameCharacterService
    {

        static List <Character> Characters  = new List<Character>
            {
                new Character { Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Protagonist" },
                new Character { Id = 2, Name = "Link", Game = "The Legend of Zelda", Role = "Protagonist" },
                new Character { Id = 3, Name = "Master Chief", Game = "Halo", Role = "Protagonist" },
                new Character { Id = 4, Name = "Lara Croft", Game = "Tomb Raider", Role = "Protagonist" },
                new Character { Id = 5, Name = "Lindo", Game = "X-Man", Role = "Vilan" }
            };
        public Task<Character> AddCharacterAsync(Character character)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCharacterAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Character>> GetAllCharactersAsync()
            => await Task.FromResult(Characters);

        public async Task<Character?> GetCharacterByIdAsync(int id)
        {
            var results =  Characters.FirstOrDefault(c => c.Id == id);
            return await Task.FromResult(results);
        }
          

        public Task<bool> UpdateCharacterAsync(int id, Character character)
        {
            throw new NotImplementedException();
        }
    }
}
