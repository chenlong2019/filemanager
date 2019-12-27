using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class User
    {
        private string id;
        private string name;
        private string staff_Number;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Staff_Number { get => staff_Number; set => staff_Number = value; }
    }
}
