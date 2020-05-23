using System.ComponentModel;

namespace RazorPageUI.Models
{
    public class BoardGame
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DisplayName("Publishing Company")]
        public string PublishingCompany { get; set; }

        [DisplayName("Minimum Players")]
        public int MinPlayers { get; set; }

        [DisplayName("Maximum Players")]
        public int MaxPlayers { get; set; }
    }

}