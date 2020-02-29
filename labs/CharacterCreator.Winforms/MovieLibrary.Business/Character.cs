using System;

namespace CharacterCreator.Business
{
    /// <summary>Represents a character.</summary>
    /// <remarks>
    /// Lots of info.
    /// </remarks>
    public class Character
    {
        public Profession CharacterProfession { get; set; }
        public Race CharacterRace { get; set; }

        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get {
                return _name ?? "";
                }

            set { _name = value?.Trim(); }
        }
        private string _name;

        public int Strength { get; set; } = 50;

        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }
        private string _description;

        public int Intelligence { get; set; } = 50;

        public int Agility { get; set; } = 50;

        public int Constitution { get; set; } = 50;

        public int Charisma { get; set; } = 50;

        public override string ToString ()
        {
            return Name;
        }

        public bool Validate ( out string error )
        {
            if (String.IsNullOrEmpty(Name))
            {
                error = "Name is required.";
                return false;
            };

            if (Strength > 100)
            {
                error = "Strength must be between 0 and 100.";
                return false;
            } else if (Strength < 0)
            {
                error = "Strength must be between 0 and 100.";
                return false;
            };

            if (Intelligence > 100)
            {
                error = "Intelligence year must be >= 1900.";
                return false;
            } else if (Intelligence < 0)
            {
                error = "Intelligence must be between 0 and 100.";
                return false;
            };
            
            if (Charisma > 100)
            {
                error = "Charisma must be between 0 and 100.";
                return false;
            } else if (Charisma < 0)
            {
                error = "Charisma must be between 0 and 100.";
                return false;
            };
            
            if (Constitution > 100)
            {
                error = "Constitution must be between 0 and 100.";
                return false;
            } else if (Constitution < 0)
            {
                error = "Constitution must be between 0 and 100.";
                return false;
            };

            if (Agility > 100)
            {
                error = "Agility must be between 0 and 100.";
                return false;
            } else if (Agility < 0)
            {
                error = "Agility must be between 0 and 100.";
                return false;
            };

            error = null;
            return true;
        }
    }
}
