using System.Collections.Generic;

namespace Dominio
{
    public class subject
    {
        private string name { get; set; }
        private string code { get; set; }
        private List<student> students;
        private List<teacher> teachers;
        public subject()
        {
            students = null;
            teachers = null;
            name = "empty";
            code = "-1";
        }
        public void EditSubject()
        {

        }
        public void DeleteSubject()
        {
            students.Clear();
            teachers.Clear();
        }

    }
}