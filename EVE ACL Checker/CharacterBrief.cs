using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_ACL_Checker
{
    class CharacterBrief
    {
        private string name;
        private string id;

        public string character { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public CharacterBrief(string id)
        {
            character = id;
        }
    }
}
