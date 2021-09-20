using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingSWheels.Models;

namespace TrainingSWheels.Services
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharacter);
        List<Character> AddRandomCharacter();
    }

    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character {Id = 1, Name = "Sam"}
        };

        public List<Character> AddRandomCharacter()
        {
            characters.Add(new Character());
            return characters;
        }

        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}
