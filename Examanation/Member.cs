using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum PaymentSchedule
{
    Annual,
    Biannual,
    Monthly
}
namespace Examanation
{
    class Member
    {
        //Varibles
        #region Declaration
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Fee { get; set; }
        public PaymentSchedule PaymentType { get; set; }
        public decimal IncrementedFee { get; set; }
        public virtual string desc
        {
            get
            {
                return $"{Name}" +

                    $"\nJoin Date {JoinDate}" +
                    $"\nBasic Fee {Fee}" +
                    $"\nPayment Schedule {PaymentType}: {IncrementedFee}" +
                    $"\nRenewal Date {RenewalDate}" +
                    $"\nDays to Renewal {DaysToRenewal}" +
                    $"\nMember Type: Regular";
            }
        }

        public DateTime RenewalDate
        {
            get
            {
                return JoinDate.AddYears(1);
            }
        }
        public int DaysToRenewal
        {
            get
            {
                
                return (JoinDate.Date - RenewalDate.Date).Days;
            }
        }
        #endregion
        //Methods
        public void CalculateFees()
        {
            
            if(PaymentType == PaymentSchedule.Annual)
            {
                IncrementedFee = Fee;
            }
            else if(PaymentType == PaymentSchedule.Biannual)
            {
                IncrementedFee = Fee / 2;
            }
            else if(PaymentType == PaymentSchedule.Monthly)
            {
                IncrementedFee = Fee / 12;
            }
        }
        //To String
        public override string ToString()
        {
            return $"{Name}";
               
                
        }
    }
}
