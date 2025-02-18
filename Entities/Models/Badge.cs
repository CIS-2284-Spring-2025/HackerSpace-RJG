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
        /// Title for the badge
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Description to the student on what the badge is for.
        /// </summary>
        public string? Description { get; set; }        
        /// <summary>
        /// Instructions to the student on how to get credit for their work.
        /// </summary>
        public string? TurnInInstructions { get; set; }
        /// <summary>
        /// Badge is not displayed to students until this is true.
        /// </summary>
        public bool? IsVisible { get; set; }
    }
}
