using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace StrategyMack.Models
{
    public class AttributeDetailMultiple
    {
        public int Id { get; set; }

        public District District { get; set; }
        public int Year { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal JanuaryValue { get; set; }
        public string FebruaryValue { get; set; }
        public string MarchValue { get; set; }
        public string AprilValue { get; set; }
        public string MayValue { get; set; }
        public string JuneValue { get; set; }
        public string JulyValue { get; set; }
        public string AugustValue { get; set; }
        public string SeptemberValue { get; set; }
        public string OctoberValue { get; set; }
        public string NovemberValue { get; set; }
        public string DecemberValue { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Modified { get; set; } = DateTime.Now;

        public int InitiativeAttributeId { get; set; }
        public InitiativeAttribute InitiativeAttribute { get; set; }

    }
}
