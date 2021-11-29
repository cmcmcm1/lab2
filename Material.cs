using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Material
    {
        public string author { get; set; }
        public string name { get; set; }
        public string faculty { get; set; }
        public string cathedra { get; set; }
        public string size { get; set; }
        public string dateOfCreating { get; set; }
        public Material()
        {
            author = "";
            name = "";
            faculty = "";
            cathedra = "";
            size = "";
            dateOfCreating = "";
        }
    }
}