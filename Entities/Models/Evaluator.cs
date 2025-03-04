namespace Entities.Models
{
    public class Evaluator
    {
        /// <summary>
        /// Unique id for evalutor
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Evaluators first name
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// Evaluators middle name
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// Evaluators last name
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Evaluators Identity
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Navigation property that provides list of badges the evaluator can evaluate.
        /// </summary>
        public virtual List<Badge>? Badges { get; set; }
    }
}
