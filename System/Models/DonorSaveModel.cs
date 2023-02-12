using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Donation.Core.Models
{
    public class DonorSaveModel
    {
        public string DonorName { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
    }
}
