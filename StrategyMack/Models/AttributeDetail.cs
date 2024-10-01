using System.ComponentModel;

namespace StrategyMack.Models
{
    public class AttributeDetail
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public int InitiativeId {  get; set; }
        public int InitiativeAttributeId { get; set; }
        public DateTime Created {  get; set; } = DateTime.Now;
        public DateTime Modified { get; set; } = DateTime.Now;

    }
}
