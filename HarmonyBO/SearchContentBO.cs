using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarmonyBO
{
    public class SearchContentBO
    {
        public string ProviderId { get; set; }
        public string Provider_UUID { get; set; }
        public string ProviderName { get; set; }
        public bool IsMailingAddress { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string County { get; set; }
        public string Municipality { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public string SortDescription { get; set; }
        public string LongDescription { get; set; }
        public string[] Service { get; set; }
        public string Neighborhood { get; set; }
        public string[] Keywords { get; set; }
        public string ProviderEmail { get; set; }
        public string ServiceAreaTown { get; set; }
        public string ServiceAreaZipCode { get; set; }
        public string ServiceAreaCounty { get; set; }
        public string ServiceAreaMunicipality { get; set; }
        public string AddressAndAreaServed { get; set; }
        public string Notes { get; set; }
        public string AreaServedServices { get; set; }
    }
}
