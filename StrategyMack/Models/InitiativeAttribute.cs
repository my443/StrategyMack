namespace StrategyMack.Models
{
    public class InitiativeAttribute
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; } = null;
        public bool HasMultipleDetails { get; set; } = false;
        public bool IsActive { get; set; } = true;

        public int AttributeDetailsId { get; set; }
        public ICollection<AttributeDetail> AttributeDetails { get; set; }
    }
}
