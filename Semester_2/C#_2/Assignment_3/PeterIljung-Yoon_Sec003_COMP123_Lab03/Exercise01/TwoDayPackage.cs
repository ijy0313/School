using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class TwoDayPackage : Package
    {
        private double adminCharge;
        public double AdminCharge
        {
            get
            {
                return adminCharge;
            }
            set
            {
                adminCharge = 10.00;
            }
        }
        public TwoDayPackage(int packageID, string sendName, string sendAdd, double adminCharge) : base (packageID, sendName, sendAdd)
        {
            AdminCharge = adminCharge;
        }
        public override double CalculatePackageCost(double weight, double ratePerGram, double adminCharge)
        {
            return weight * ratePerGram + adminCharge;
        }
        public override string ToString()
        {
            return string.Format("Package ID: {0} \nSender name: {1} \nSender address: {2} \nAdmin cost: {3:c}"
                , PackageID, SendName, SendAdd, AdminCharge);
        }
    }
}
