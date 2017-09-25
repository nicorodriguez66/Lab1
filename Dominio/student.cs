using System.Collections.Generic;

namespace Dominio
{
    public class student:person
    {
        private int number;
        private int idcard;
        private float x;
        private float y;
        private List<payment> payments;
        public student()
        {
            number = 0;
            idcard = 0;
            x = 0;
            y = 0;
            payments = null;
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