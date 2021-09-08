namespace Ghosts
{
    public class Evidence
    {
        private int _id;
        private string _description;

        public int ID => _id;

        public Evidence(int id, string description)
        {
            _id = id;
            _description = description;
        }
    }
}