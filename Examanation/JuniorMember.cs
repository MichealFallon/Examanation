using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examanation
{
    class JuniorMember: Member
    {
        //updating the fees for Junior Members
        public decimal UpdatedFee
        {
            get
            {
                return Fee / 2;
            }
        }
        public decimal UpdatedIncrementedFee
        {
            get
            {
                return IncrementedFee / 2;
            }
        }
        //updating the t string for Junior Members
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
                    $"\nMember Type: Junior";
            }
        }
        public override string ToString()//changed to virtual
        {
            return $"{Name}";
            /*
                    $"\nJoin Date {JoinDate}" +
                    $"\nBasic Fee {UpdatedFee}" +
                    $"\nPayment Schedule {PaymentType}: {UpdatedIncrementedFee}" +
                    $"\nRenewal Date {RenewalDate}" +
                    $"\nDays to Renewal {DaysToRenewal}" +
                    $"\nMember Type: Junior";
            */
        }
    }
}
