using System;

namespace Srp.Example
{
    // providers 
    public enum Providers
    {
        Airtel,
        Vodafone
    }
    public class SimpleOnlineRecharge
    {
        // Phone Details
        public string PhoneNumber { get; set; }

        // Recharge Details
        public decimal Amount { get; set; }

        // Balance Details
        public decimal BalanceAmount { get; set; }

        // Providers 
        public Providers ProviderName { get; set; }

        public void Recharge(string PhoneNumber, decimal Amount)
        {
            // Call External APIs 
            if(ProviderName == Providers.Airtel)
            {
                // Call airtel API 
            }

            if (ProviderName == Providers.Vodafone)
            {
                // Call airtel API 
            }

        }
    }
}
