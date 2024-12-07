using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsHillMarina
{
    internal class Pier
    {

        int id;
        String berthId;
        int boatId; //used when loading piers which have a boat docked

        public Pier(int id, String berthId) {
            this.id = id;
            this.berthId = berthId;
        }

        public Pier(int id, String berthId, int boatId)
        {
            this.id = id;
            this.berthId = berthId;
            this.boatId = boatId;
        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public String BerthId { get { return this.berthId; } set { this.berthId = value; } }

        public int BoatId { get { return this.boatId; } set { this.boatId = value; } }

        public String PierLabel { get { return this.berthId + " - " + this.id; } }
    }
}
