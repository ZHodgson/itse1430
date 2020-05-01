/*Zachary Hodgson
 * ITSE 1430
 * Mr. Taylor
 * Lab 3
 * 4/21/2020
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CharacterCreator
{
    public class Character : IValidatableObject
    {
        public string Name
        {
            get { return _name ?? "";  }
            set { _name = value?.Trim(); }
        }
        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value?.Trim(); }
        }
        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value?.Trim(); }
        }
        public int Id
        { get; set; }
        public int Strength
        { get; set; }

        public int Intelligence
        { get; set; }
        public int Agility
        { get; set; }
        public int Constitution
        { get; set; }
        public int Charisma
        { get; set; }

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }
        public int PointsRemaining
        { get; set; }


        public override string ToString ()
        {
            return Id + ":  " + Name;
        }
        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (PointsRemaining != 0)
            {
                yield return new ValidationResult("Please use your remaining points", new[] { nameof(PointsRemaining) });
            };
            if (String.IsNullOrEmpty(Name))
            {
                yield return new ValidationResult("Please add a name.", new[] { nameof(Name) });
            };

            
            char[] charsToTrim = { ':', '*', '?', '<', '>', '\\', '/' };
            var temp = Name.Trim(charsToTrim);
            if (temp != Name)
            {
                yield return new ValidationResult(@"Special Characters are not permitted.", new[] { nameof(Name) });
            };

            if (String.IsNullOrEmpty(Profession))
            {
                yield return new ValidationResult("Please pick a profession.", new[] { nameof(Profession) });
            };

            if (String.IsNullOrEmpty(Race))
            {
                yield return new ValidationResult("Please pick a race.", new[] { nameof(Race) });
            };
        }

        private string _name;
        private string _race;
        private string _profession;
        private string _description;
    }
}
