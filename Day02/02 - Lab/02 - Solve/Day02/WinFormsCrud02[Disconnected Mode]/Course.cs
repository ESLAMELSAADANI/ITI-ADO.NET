using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCrud02_Disconnected_Mode_
{
    internal class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Duration { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Duration}";
        }
    }
}
