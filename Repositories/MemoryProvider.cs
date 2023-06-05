using TspuWebLabs.Data;

namespace igoryan.Repositories
{
    public class MemoryProvider
    {
        public List<User> Users { get; set; }
        public int ValidId { get; set; }
        public MemoryProvider()
        {
            Users = new List<User>();
            ValidId = 0;
        }

    }
}
