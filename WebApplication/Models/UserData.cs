using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    [Serializable]
    public class UserData
    {
        public string PassSeries { get; set; }
        public string PassNumber { get; set; }
        public string PassFullName { get; set; }
        public DateTime PassReceivingDate { get; set; }
        public string PassIss { get; set; }
        public string PassAddress { get; set; }
        public string LicenseSeries { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime LicenseReceivingDate { get; set; }
        public string[][] CarList { get; set; }
    }
}