using System.ComponentModel.DataAnnotations;

namespace TheWaterProject2.Models
{
    public class Project
    {
        [Key]
        public int projectId { get; set; }
        public string projectName { get; set; } = "N/A";
        public string programName { get; set; }
        public string? projectType { get; set; }
        public int projectImpactLevel { get; set; }
        public DateTime projectInstallation { get; set; }
        public string projectPhase { get; set; }
    }
}
