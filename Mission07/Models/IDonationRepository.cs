using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission07.Models
{
    public interface IDonationRepository
    {
        IQueryable<Donation> Donations { get; }

        public void SaveDonation(Donation donation);
    }
}
