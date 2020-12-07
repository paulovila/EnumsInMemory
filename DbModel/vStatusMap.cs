using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DbModel
{
    [Keyless]
    public partial class vStatusMap
    {
        public StatusMapEnum StatusMapId { get; set; }
        [Required]
        [StringLength(32)]
        public string StatusMapName { get; set; }
        public StatusMapCodesEnum CurrentStatusCodeId { get; set; }
        [StringLength(16)]
        public string CurrentStatusCode { get; set; }
        [StringLength(128)]
        public string CurrentStatusDescription { get; set; }
        public bool CurrentStatusIsAuthoriseState { get; set; }
        public int EventId { get; set; }
        [StringLength(32)]
        public string EventName { get; set; }
        [StringLength(128)]
        public string EventDescription { get; set; }
        public byte DisplayOrder { get; set; }
        public StatusMapCodesEnum NextStatusCodeId { get; set; }
        [StringLength(16)]
        public string NextStatusCode { get; set; }
        [StringLength(128)]
        public string NextStatusDescription { get; set; }
        public bool NextStatusIsAuthoriseState { get; set; }
        public bool SecondUserAuthorisation { get; set; }
    }
}
