using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_ACL_Checker
{
    class Character
    {
        private string id;
        private string name;
        private string allianceId;
        private string corporationId;
        private string gender;
        private string description;
        private string birthday;
        private int race;
        private int ancestry;
        private int bloodline;

        public string ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string AllianceId { get => allianceId; set => allianceId = value; }
        public string CorporationId { get => corporationId; set => corporationId = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Description { get => description; set => description = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public int Race { get => race; set => race = value; }
        public int Ancestry { get => ancestry; set => ancestry = value; }
        public int Bloodline { get => bloodline; set => bloodline = value; }


        public Character(string id, string name)
        {
            ID = id;
            Name = name;
        }

        public Character(string id, string name, string allianceId, string corporationId, string gender, string description, string birthday, int race, int ancestry, int bloodline)
        {

            ID = id;
            Name = name;
            AllianceId = allianceId;
            CorporationId = corporationId;
            Gender = gender;
            Description = description;
            Birthday = birthday;
            Race = race;
            Ancestry = ancestry;
            Bloodline = bloodline;
            
        }

        public bool Equals(string id)
        {
            return ID == this.id;
        }

        public override bool Equals(object character)
        {
            return (character is Character && ID == ((Character)character).ID);
        }
    }
}
