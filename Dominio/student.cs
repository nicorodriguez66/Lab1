using System.Collections.Generic;

namespace Dominio
{
    public class student:person
    {
        public int number { get; set; }
        public int idcard { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public List<payment> payments { get; set; }

        public student()
        {

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