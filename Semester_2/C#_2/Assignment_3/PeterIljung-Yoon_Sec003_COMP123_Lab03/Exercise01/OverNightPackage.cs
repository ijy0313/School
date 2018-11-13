using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class OverNightPackage : Package
    {
        private double expressCharge;
        public double ExpressCharge
        {
            get
            {
                return expressCharge;
            }
            set
            {
                expressCharge = value + 0.1;
            }
        }
        public OverNightPackage(int packageID, string sendName, string sendAdd, double expressCharge) : base(packageID, sendName, sendAdd)
        {
            ExpressCharge = expressCharge;
        }
        public override double CalculatePackageCost(double weight, double ratePerGram, double adminCharge = 0)
        {
            return weight * (0.1+ratePerGram) + adminCharge ;
        }
        public override string ToString()
        {
            return string.Format("Package ID: {0} \nSender name: {1} \nSender Address: {2} \nOvernight express rate per gram extra is: {3:c}"
                , PackageID, SendName, SendAdd, ExpressCharge);
        }
    }
}
