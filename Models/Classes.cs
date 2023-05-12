using Arcade.Models;
using System.ComponentModel.DataAnnotations;

namespace ArcadeClasses
{
    public class game
    {
        [Key]
        public string? title { get; set; }

        public ICollection<score>? scores { get; set; }
    }

    public class player
    {
        [Key]
        public string username { get; set; }

        public ICollection<score> scores { get; set; }
    }

    public class score
    {
        public int scoreId { get; set; }
        public string title { get; set; }
        public string username { get; set; }
        public int playerScore { get; set; }

        public game game { get; set; }
        public player player { get; set; }
    }
}
