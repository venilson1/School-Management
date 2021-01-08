using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public interface IPeople
    {
        void SetName(string _name);
        void SetTelephone(string _telephone);
        void SetClassRoom(string _ClassRoom);
        void SetStudentRegistration(string _StudentRegistration);

        void WriteFile();
    }
}
