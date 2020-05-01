/*Zachary Hodgson
 * ITSE 1430
 * Mr. Taylor
 * Lab 3
 * 4/21/2020
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace CharacterCreator
{
    public class CharacterDatabase : ICharacterRoster
    {
        public Character SaveCharacter ( Character character )
        {
            if (character == null)
                return null;
            var existing = FindByName(character.Name);
            if (existing != null)
                return null;

            var item = DuplicateCharacter(character);
            item.Id = _id++;
            _characters.Add(item);
            return DuplicateCharacter(item);
        }


        public void SaveList ()
        {
            //Saves to my docs folder
            var writer = new XmlSerializer(typeof(List<Character>));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\characterDatabase.ccs";
            var file = File.Create(path);
            writer.Serialize(file, _characters);
            file.Close();
        }
        public string Update ( int id, Character character )
        {
            if (character == null)
                return "The requested character was not found.";
            var errors = Validation.Validate(character);
            
            if (errors.Any())
                return null;
            
            if (id < 0)
                return "The requested ID is invalid.";

            var existing = FindById(id);
            if (existing == null)
                return "The requested character was not found.";

            var sameName = FindByName(character.Name);
            if (sameName != null && sameName.Id != id)
                return "Name already taken.";

            CopyCharacter(existing, character, false);

            return null;
        }
        public void LoadCharacter ()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\characterDatabase.ccs";
            if (!File.Exists(path))
                return;
            
            var reader = new XmlSerializer(typeof(List<Character>));
           
            var file = new StreamReader(path);
            
            _characters = (List<Character>)reader.Deserialize(file);
            
            _id = _characters.Count() + 1;
            file.Close();
        }

        private Character FindByName ( string name )
        {
            foreach (var character in _characters)
            {
                if (String.Compare(character?.Name, name, true) == 0)
                    return character;
            };

            return null;
        }

        private Character FindById ( int id )
        {
            foreach (var character in _characters)
            {
                if (character.Id == id)
                    return character;
            };

            return null;
        }
        public Character[] GetAll ()
        {
            var items = new Character[_characters.Count];
            var index = 0;
            foreach (var character in _characters)
            {
                items[index++] = DuplicateCharacter(character);
            };

            return items;
        }

        public void Delete ( int id )
        {
            if (id <= 0)
                return;

            var character = FindById(id);
            if (character != null)
                _characters.Remove(character);
        }
        private Character DuplicateCharacter ( Character character )
        {
            var item = new Character();
            CopyCharacter(item, character, true);

            return item;
        }

        private void CopyCharacter ( Character target, Character source, bool includeId )
        {
            if (includeId)
                target.Id = source.Id;
            
            target.Name = source.Name;
            
            target.Profession = source.Profession;
            
            target.Race = source.Race;
            
            target.Intelligence = source.Intelligence;
            
            target.Strength = source.Strength;
            
            target.Description = source.Description;
            
            target.Constitution = source.Constitution;
            
            target.Agility = source.Agility;
            
            target.Charisma = source.Charisma;
            
            target.PointsRemaining = source.PointsRemaining;
        }
        
        private List<Character> _characters = new List<Character>();
        
        private int _id = 1;
    }
}
