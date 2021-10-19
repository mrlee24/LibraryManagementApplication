using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.bus
{
    class Actor
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Actor()
        {
            this.name = "Undefine";
        }
        public Actor(string name)
        {
            this.name = name;
        }
    }
}
