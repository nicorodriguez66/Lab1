using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class activity : payment
    {
        private string name;
        private int id;
        private DateTime date;
        private int cost;
        private List<student> students;


        public activity()
        {
        }
        public void EditActivity()
        {
        }

        public void DeleteActivity()
        {
            students.Clear();
        }
        public override void pay()
        {
            throw new NotImplementedException();
        }
    }
}
