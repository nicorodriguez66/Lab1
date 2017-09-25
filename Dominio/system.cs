using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class system
    {
        private List<teacher> allteachers;
        private List<student> allstudents;
        private List<subject> allsubjects;
        private List<van> allvans;

        public List<teacher> showallteachers()
        {
            return allteachers;
        }
        public List<student> showallstudents()
        {
            return allstudents;
        }
        public List<subject> showallsubjects()
        {
            return allsubjects;
        }
        public List<van> showallvans()
        {
            return allvans;
        }

    }
}
