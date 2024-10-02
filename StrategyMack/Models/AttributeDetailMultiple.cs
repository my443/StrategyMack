using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace StrategyMack.Models
{
    public class AttributeDetailMultiple
    {
        public int Id { get; set; }

        public string District { get; set; }
        public string FiscalYear { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal JanuaryValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal FebruaryValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MarchValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AprilValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MayValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal JuneValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal JulyValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AugustValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SeptemberValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal OctoberValue { get; set; }
        public decimal NovemberValue { get; set; }
        public decimal DecemberValue { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Modified { get; set; } = DateTime.Now;

        public int InitiativeAttributeId { get; set; }
        public int InitiativeId { get; set; }

    }
}
