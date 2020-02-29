using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Business
{
    public class Profession
    {
        public Profession ( string description )
        {
            Description = description ?? "";
        }

        public string Description { get; }

        public override string ToString ()
        {
            return Description;
        }
    }
    public class Race
    {
        public Race ( string description )
        {
            Description = description ?? "";
        }

        public string Description { get; }

        public override string ToString ()
        {
            return Description;
        }
    }
    public class Professions
    {
        public static Profession[] GetAll ()
        {
            var items = new Profession[5];
            items[0] = new Profession("Fighter");
            items[1] = new Profession("Hunter");
            items[2] = new Profession("Priest");
            items[3] = new Profession("Rogue");
            items[4] = new Profession("Wizard");

            return items;
        }
    }
    public class Races

    {
        public static Race[] GetAll ()
        {
            var items = new Race[5];
            items[0] = new Race("Dwarf");
            items[1] = new Race("Elf");
            items[2] = new Race("Gnome");
            items[3] = new Race("Half Elf");
            items[4] = new Race("Human");

            return items;
        }
    }
}
