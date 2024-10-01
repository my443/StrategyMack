using System.ComponentModel;

namespace StrategyMack.Models
{
    public enum District
    {
        [Description("All Districts")]
        AllDistricts,
        [Description("North District")]
        North,
        [Description("South District")]
        South,
        [Description("East District")]
        East,
        [Description("West District")]
        West,
        [Description("Central District")]
        Central,
        [Description("Central East District")]
        CentralEast,
        [Description("Saskatchewan")]
        Saskatchewan
    }
}
