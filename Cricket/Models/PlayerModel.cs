using Cricket.Data.Models;

namespace Cricket.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }
    }
}
