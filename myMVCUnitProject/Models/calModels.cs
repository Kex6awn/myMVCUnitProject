using System.ComponentModel.DataAnnotations;

//
//    Name:           Francis Ferdinard 
//    Date:           09/22/2024
//    Description:    Unit 1 Project
//

namespace myMVCUnitProject.Models
{
    public class calModels
    {
        [Required]
        public int FirstValue { get; set; }

        [Required]
        public int SecondValue { get; set; }

        public int? FinalValue { get; set; }

        [Required]
        public string? Operation { get; set; }
    }
}
