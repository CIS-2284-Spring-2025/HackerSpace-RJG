namespace Entities.Models
{
    public class EvaluationRequest
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public Guid? BadgeId { get; set; }
        public virtual Badge? Badge { get; set; }
        public string? SubmissionText { get; set; }
    }
}
