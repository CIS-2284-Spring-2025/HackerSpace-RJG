using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    /// <summary>
    /// Badge describes badges students can earn
    /// </summary>
    public class Badge
    {
        /// <summary>
        /// Unique id for the badge
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Title for the badge.
        /// Required and must have 5 characters.
        /// </summary>
        [Required]
        [MinLength(5)]
        public string? Title { get; set; }
        /// <summary>
        /// Description to the student on what the badge is for. Required and must have 20 characters.
        /// </summary>
        [Required]
        [MinLength(20)]
        public string? Description { get; set; }
        /// <summary>
        /// Instructions to the student on how to get credit for their work. Required and must have 20 characters.
        /// </summary>
        [Required]
        [MinLength(20)]
        public string? TurnInInstructions { get; set; }
        /// <summary>
        /// Badge is not displayed to students until this is true. Required and must have 20 characters.
        /// </summary>
        public bool? IsVisible { get; set; }
    }
}
