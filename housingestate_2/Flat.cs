using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    class Flat
    {
        private int address;
        private int area;
        private int rooms;
        public Flat(int address, int area, int rooms)
        {
            this.address = address;
            this.area = area;
            this.rooms = rooms;
        }
        public int Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public int Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public List<Person> inhabitants = new List<Person> ();

        public override string ToString()
        {
            return "address: " + address + "\n" + "area: " + area +"m2" +  "\n" + "number of rooms: " + rooms + "\n" + "number of inhabitants: " + inhabitants.Count;
        }
        
        public void AddInhabitant(Person person)
        {
            inhabitants.Add(person);
            person.XFlat = this;
        }
    }
}
