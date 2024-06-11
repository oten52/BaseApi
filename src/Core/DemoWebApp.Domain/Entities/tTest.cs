using DemoWebApp.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace DemoWebApp.Domain.Entities
{
    public class t_AlertEvents : BaseEntity<Guid>
    {
        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string Descriptions { get; set; }
    }
}
