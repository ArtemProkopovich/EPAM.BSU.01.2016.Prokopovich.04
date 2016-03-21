using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Subject : IEquatable<Subject>
    {
        private static int currentID = 0;
        public int ID;
        public string Name { get; set; }
        public Teacher Teacher { get; set; }

        public List<Student> StudentList { get; set; } = new List<Student>();

        public Subject()
        {
            ID = currentID;
            currentID++;
        }

        public bool Equals(Subject obj)
        {
            if (ReferenceEquals(obj, null))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return ID == obj.ID;
        }
    }
}
