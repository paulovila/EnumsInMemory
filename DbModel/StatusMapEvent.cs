using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DbModel
{
    [Table("StatusMapEvent", Schema = "Core")]
    public partial class StatusMapEvent
    {
        [Key]
        public StatusMapEnum StatusMapId { get; set; }
        [Key]
        public StatusMapCodesEnum CurrentStatusCodeId { get; set; }
        [Key]
        public int EventId { get; set; }
        [Key]
        public StatusMapCodesEnum NextStatusCodeId { get; set; }

        [ForeignKey(nameof(EventId))]
        [InverseProperty("StatusMapEvents")]
        public virtual Event Event { get; set; }
        [ForeignKey(nameof(StatusMapId))]
        [InverseProperty("StatusMapEvents")]
        public virtual StatusMap StatusMap { get; set; }
    }
}
