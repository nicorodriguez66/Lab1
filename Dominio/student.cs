using System.Collections.Generic;

namespace Dominio
{
    public class student:person
    {
        private string v1;
        private string v2;

        public int number { get; set; }
        public int idcard { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public List<payment> payments { get; set; }

        public student()
        {
            name = "";
            surname = "";
            subjects = null;
            number = 0;
            idcard = 0;
            x = 0;
            y = 0;
            payments = null;

        }

        public student(string oneName, string oneSurname)
        {
            this.name = oneName;
            this.surname = oneSurname;
        }

        public void EditStudent()
        {
        }
        public void DeleteStudent()
        {
            payments.Clear();
        }

    }
}