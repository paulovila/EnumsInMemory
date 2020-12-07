using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DbModel
{
    [Table("Event", Schema = "Core")]
    public partial class Event
    {
        public Event()
        {
            StatusMapEvents = new HashSet<StatusMapEvent>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(32)]
        public string Name { get; set; }
        [StringLength(128)]
        public string Description { get; set; }
        public byte DisplayOrder { get; set; }

        [InverseProperty(nameof(StatusMapEvent.Event))]
        public virtual ICollection<StatusMapEvent> StatusMapEvents { get; set; }
    }
}
