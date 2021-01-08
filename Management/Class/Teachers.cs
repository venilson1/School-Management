using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Class
{
    class Teachers : Base
    {
        public string CPF;
        public string Educate;
        public Teachers() { }

        public Teachers(string _name, string _telephone, string _cpf, string _educate)
        {
            this.Name = _name;
            this.Telephone = _telephone;
            this.CPF = _cpf;
            this.Educate = _educate;
        }

        public override void WriteFile()
        {
            var DataList = this.Read();
            DataList.Add(this);

            StreamWriter r = new StreamWriter(FilesDirectory());
            r.WriteLine("nome;telefone; CPF; Matéria");
            foreach (Teachers data in DataList)
            {
                var line =
                    data.Name + ";" +
                    data.Telephone + ";" +
                    data.CPF + ";" +
                    data.Educate + ";";
                r.WriteLine(line);
            }

            r.Close();
        }

        public override List<IPeople> Read()
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
                        var data = (Teachers)Activator.CreateInstance(this.GetType());

                        data.SetName(filesStudents[0]);
                        data.SetTelephone(filesStudents[1]);
                        data.CPF = filesStudents[2];
                        data.Educate = filesStudents[3];


                        DataList.Add(data);
                    }
                }
            }

            return DataList;
        }
    }
}
