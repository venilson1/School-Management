using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Class
{
    public class Base : IPeople
    {
        public string Name;
        public string Telephone;
        public string ClassRoom;
        public string StudentRegistration;


        public Base(string _name, string _telephone, string _ClassRoom, string _StudentRegistration)
        {
            this.Name = _name;
            this.Telephone = _telephone;
            this.ClassRoom = _ClassRoom;
            this.StudentRegistration = _StudentRegistration;
        }

        public Base() { }
        

        public void SetName(string _name)
        {
            this.Name = _name;
        }

        public void SetTelephone(string _telephone)
        {
            this.Telephone = _telephone;
        }

        public void SetClassRoom(string _ClassRoom)
        {
            this.ClassRoom = _ClassRoom;
        }

        public void SetStudentRegistration(string _StudentRegistration)
        {
            this.StudentRegistration = _StudentRegistration;
        }


        protected string FilesDirectory()
        {
            return ConfigurationManager.AppSettings["FilesDirectory"] + this.GetType().Name + ".csv";
        }

        public virtual void WriteFile()
        {
            var DataList = this.Read();
            DataList.Add(this);

            StreamWriter r = new StreamWriter(FilesDirectory());
            r.WriteLine("nome;telefone;Classe;Registo do Aluno");
            foreach (Base data in DataList)
            {
                var line = 
                    data.Name + ";" + 
                    data.Telephone + ";" +
                    data.ClassRoom + ";" +
                    data.StudentRegistration + ";";
                r.WriteLine(line);
            }

            r.Close();
        }


        public virtual List<IPeople> Read()
        {
            var DataList = new List<IPeople>();
            if (File.Exists(FilesDirectory()))
            {
                using (StreamReader files = File.OpenText(FilesDirectory()))
                {
                    string line;
                    int i = 0;
                    while ((line = files.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var filesStudents = line.Split(";");
                        var data = (IPeople)Activator.CreateInstance(this.GetType());
                        
                        data.SetName(filesStudents[0]);
                        data.SetTelephone(filesStudents[1]);
                        data.SetClassRoom(filesStudents[2]);
                        data.SetStudentRegistration(filesStudents[3]);


                        DataList.Add(data);
                    }
                }
            }

            return DataList;
        }
    }
}
