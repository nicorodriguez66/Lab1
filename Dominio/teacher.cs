namespace Dominio
{
    public class teacher:person
    {
        public teacher()
        {
            name = "";
            surname = "";
            subjects = null;
        }
        public void EditTeacher()
        {

        }
        public void DeleteTeacher()
        {
            subjects.Clear();
        }
    }
}