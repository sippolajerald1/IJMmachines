using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IJMmachines.Models
{
    public class Machine
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }



        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Manufacturer {  get; set; } = string.Empty;


         
        public int? Tonnage { get; set; }


        [Display(Name ="Defect or damaged")]
        public int? MachineNumberOfDefectsDamaged { get; set; }
        public int? ProcessingDefects {  get; set; }


        [Range(1,2000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MachineCost { get; set; } = 0;

        public string? Description { get; set; } = string.Empty;

        
    }
}
