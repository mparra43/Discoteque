using Microsoft.EntityFrameworkCore.Metadata.Internal;using System.ComponentModel.DataAnnotations.Schema;

namespace Discoteque.Data.Models
{
    public class Tour : BaseEntity<int>
    {
        public string Name { get; set; } = "";

        public string City { get; set; } = "";

        public DateTime Date  { get; set; } = DateTime.Now;


        [ForeignKey("id")]
        public int? ArtistId { get; set; }
        public virtual Artist? Artist { get; set; }

        public int Tickets { get; set; } = 10;
    }
}
