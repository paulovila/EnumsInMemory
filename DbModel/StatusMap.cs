using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DbModel
{
    [Table("StatusMap", Schema = "Core")]
    [Index(nameof(Name), Name = "UI_StatusMap.Name", IsUnique = true)]
    public partial class StatusMap
    {
        public StatusMap()
        {
            StatusMapEvents = new HashSet<StatusMapEvent>();
        }

        [Key]
        public StatusMapEnum Id { get; set; }
        [Required]
        [StringLength(32)]
        public string Name { get; set; }
        public bool SecondUserAuthorisation { get; set; }

        [InverseProperty(nameof(StatusMapEvent.StatusMap))]
        public virtual ICollection<StatusMapEvent> StatusMapEvents { get; set; }
    }
}
