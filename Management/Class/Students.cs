using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Class
{
    public class Students : Base
    {
        public Students(string _name, string _telephone, string _classroom, string _StudentRegistration)
        {
            this.Name = _name;
            this.Telephone = _telephone;
            this.ClassRoom = _telephone;
            this.StudentRegistration = _StudentRegistration;
        }

        public Students() { }

    }
}
