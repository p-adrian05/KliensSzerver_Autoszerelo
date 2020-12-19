using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KliensSzerverAutoszerelo_Common.Models{
    public class Work {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CarBrand { get; set; }
        public string CarType { get; set; }
        public string LicensePlate { get; set; }
        public string Description { get; set; }
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
