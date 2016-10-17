using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStarcraft_Creator.Object
{
    class Player : BaseObject
    {

        public string type
        {
            get; set;
        }

        public string name
        {
            get; set;
        }

        public int offensive
        {
            get; set;
        }

        public int defensive
        {
            get; set;
        }

        public int aggro
        {
            get; set;
        }

        public int sight
        {
            get; set;
        }

        public int control
        {
            get; set;
        }

        public int resource
        {
            get; set;
        }

        public int fight
        {
            get; set;
        }
    }
}
