using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public static class Utility
    {
        public static List<string> Elements
        {
            get
            {
                var elements = Enum.GetNames(typeof(Element));

                return elements.ToList();
            }
        }

        public static string GetElementAt( int index )
        {
            if (index < 0 || index >= Elements.Count)
                return string.Empty;

            return Elements[index];
        }

        public static string GetAllElements( bool formatting )
        {
            string elementString = string.Empty;

            foreach (var e in Elements)
            {
                if (formatting)
                {
                    if (elementString != string.Empty)
                    {
                        if (elementString.Length % 10 == 0)
                            elementString += $"{e,20}\n\r";
                        else
                            elementString += $"{e,20}";
                    }
                    else
                        elementString += $"{e,15}";
                }
                else
                    elementString += $"{e},";
            }

            return $"{elementString}";
            
        }
    }

    public enum State
    {
        Unknown = 0,
        Solid,
        Liquid,
        Gas,
        Plasma
    }

    // Currently not used but something I want to play with beyond this knowledge check.
    public enum Element
    {
        Hydrogen = 1,
        Helium,
        Lithium,
        Beryllium,
        Boron,
        Carbon,
        Nitrogen,
        Oxygen,
        Fluorine,
        Neon,
        Sodium,
        Magnesium,
        Aluminum,
        Silicon,
        Phosphorus,
        Sulfur,
        Chlorine,
        Argon,
        Potassium,
        Calcium,
        Scandium,
        Titanium,
        Vanadium,
        Chromium,
        Manganese,
        Iron,
        Cobalt,
        Nickel,
        Copper,
        Zinc,
        Gallium,
        Germanium,
        Arsenic,
        Selenium,
        Bromine,
        Krypton,
        Rubidium,
        Strontium,
        Yttrium,
        Zirconium,
        Niobium,
        Molybdenum,
        Technetium,
        Ruthenium,
        Rhodium,
        Palladium,
        Silver,
        Cadmium,
        Indium,
        Tin,
        Antimony,
        Tellurium,
        Iodine,
        Xenon,
        Cesium,
        Barium,
        Lanthanum,
        Cerium,
        Praseodymium,
        Neodymium,
        Promethium,
        Samarium,
        Europium,
        Gadolinium,
        Terbium,
        Dysprosium,
        Holmium,
        Erbium,
        Thulium,
        Ytterbium,
        Lutetium,
        Hafnium,
        Tantalum,
        Tungsten,
        Rhenium,
        Osmium,
        Iridium,
        Platinum,
        Gold,
        Mercury,
        Thallium,
        Lead,
        Bismuth,
        Polonium,
        Astatine,
        Radon,
        Francium,
        Radium,
        Actinium,
        Thorium,
        Protactinium,
        Uranium,
        Neptunium,
        Plutonium,
        Americium,
        Curium,
        Berkelium,
        Californium,
        Einsteinium,
        Fermium,
        Mendelevium,
        Nobelium,
        Lawrencium,
        Rutherfordium,
        Dubnium,
        Seaborgium,
        Bohrium,
        Hassium,
        Meitnerium,
        Darmstadtium,
        Roentgenium,
        Copernicium,
        Nihonium,
        Flerovium,
        Moscovium,
        Livermorium,
        Tennessine,
        Oganesson
    }
}
