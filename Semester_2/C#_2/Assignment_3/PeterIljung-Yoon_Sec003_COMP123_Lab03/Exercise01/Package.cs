using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    abstract class Package : Object
    {
        private int packageID; //Instance data members
        private string sendName;
        private string sendAdd;

        public int PackageID
        {
            get
            {
                return packageID;
            } // end get
            set
            {
                packageID = value;
            }
        }
        public string SendName
        {
            get
            {
                return sendName;
            } // end get
            set
            {
                sendName = value;
            }
        }
        public string SendAdd
        {
            get
            {
                return sendAdd;
            } // end get
            set
            {
                sendAdd = value;
            }
        }

        public Package(int packageID, string sendName, string sendAdd)
        {
            this.packageID = packageID;
            this.sendName = sendName;
            this.sendAdd = sendAdd;
        }
        public abstract double CalculatePackageCost(double weight, double ratePerGram, double value = 1);

        public override string ToString()
        {
            return string.Format("Package ID: {0} \nSender name: {1} \nSender Address: {2}", PackageID, SendName, SendAdd);
        }
    }
}
