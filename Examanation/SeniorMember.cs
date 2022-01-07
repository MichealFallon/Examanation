using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examanation
{
    class SeniorMember: Member
    {
        //updating the fee for the senior members
        public decimal UpdatedFee
        {
            get
            {
                return Fee / 4;
            }
        }
        public decimal UpdatedIncrementedFee
        {
            get
            {
                return IncrementedFee / 4;
            }
        }
        public override string desc
        {
            get
            {
                return $"{Name}" +

                    $"\nJoin Date {JoinDate}" +
                    $"\nBasic Fee {UpdatedFee}" +
                    $"\nPayment Schedule {PaymentType}: {UpdatedIncrementedFee}" +
                    $"\nRenewal Date {RenewalDate}" +
                    $"\nDays to Renewal {DaysToRenewal}" +
                    $"\nMember Type: Senior";
            }
        }
        //updating the to string for senior members
        public override string ToString()
        {
            return $"{Name}";
            /*
                    $"\nJoin Date {JoinDate}" +
                    $"\nBasic Fee {UpdatedFee}" +
                    $"\nPayment Schedule {PaymentType}: {UpdatedIncrementedFee}" +
                    $"\nRenewal Date {RenewalDate}" +
                    $"\nDays to Renewal {DaysToRenewal}" +
                    $"\nMember Type: Senior";
            */
        }
    }
}
