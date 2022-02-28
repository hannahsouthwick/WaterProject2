using System;
using System.Linq;

namespace WaterProject2.Models
{
    public interface IDonationRepository
    {
        IQueryable<Donation> Donations { get; set; }

        void SaveDonation(Donation donation);
    }
}
