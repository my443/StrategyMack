using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StrategyMack.Models
{
    public class Initiative
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; } = null;

        public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly EndDate { get; set; } = DateOnly.FromDateTime(DateTime.Now).AddYears(1);
        public bool IsActive { get; set; } = true;
    }
}
