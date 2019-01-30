using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730067
{
    class program

    {
        static void Main(string[] args)
        {

        }
        class Village
        {
            //Node is an ADT
            //what KIND of DATA do we need in a NODE?
            public Village nextVillage;
            public String VillageName;
            public string previousVillage;
            public bool IsAstrildeHere = false;
        }
        class Countryside
        {
            Village Maple = new Village();
            Village Toronto = new Village();
            Village Ajax = new Village();
            Village First;
            Village Last;
            public void launch()
            {
                Maple.VillageName = "Maple";
                Maple.nextVillage = Toronto;
                Maple.previousVillage = null;
                Toronto.VillageName = "toronto";
                Toronto.nextVillage = Ajax;
                Toronto.previousVillage = Maple;
                Ajax.VillageName = "Ajax";
                Ajax.nextVillage = null;
                Ajax.nextVillage= Toronto;



            }
        }
    }

}

