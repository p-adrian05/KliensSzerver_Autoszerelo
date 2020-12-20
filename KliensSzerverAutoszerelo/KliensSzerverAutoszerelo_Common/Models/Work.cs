using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KliensSzerverAutoszerelo_Common.Models{
    public class Work {

        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(20)]
        public string CarBrand { get; set; }
        [Required]
        [MaxLength(20)]
        public string CarType { get; set; }
        [Required]
        [MaxLength(6)]
        public string LicensePlate { get; set; }
        public string Description { get; set; }
        [Required]
        public WorkState WorkState { get; set; }

        public Work() {
            this.WorkState = WorkState.Recorded;
        }

        public override string ToString()
        {
            return $"{CarBrand} {CarType} {LicensePlate}";
        }
    }
}
