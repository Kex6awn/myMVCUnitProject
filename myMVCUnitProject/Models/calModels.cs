using System.ComponentModel.DataAnnotations;

namespace myMVCUnitProject.Models
{
    public class calModels
    {
        [Required]
        public int FirstValue { get; set; }

        [Required]
        public int SecondValue { get; set; }

        public int? FinalValue { get; set; }

    }
}
