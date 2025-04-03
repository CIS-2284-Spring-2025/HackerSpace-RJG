using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Evaluator
    {/// <summary>
     /// Unique id for the badge
     /// </summary>
        public Guid Id { get; set; }
        public Guid ApplicationUserId { get; set; }

        [NotMapped]
        public string? Email { get; set; }

        public Guid BadgeId { get; set; }
        virtual public Badge? Badge { get; set; }
    }
}
