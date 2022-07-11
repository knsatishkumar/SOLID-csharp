using System;
using System.Collections.Generic;
using System.Text;

namespace Srp.Example.Refactor
{
    public class SrpOnlineRecharge
    {
        private IRecharge recharge;
        private IPayment payment;

        public SrpOnlineRecharge(IRecharge recharge)
        {
            this.recharge = recharge;
        }
        public void MyRecharge()
        {
            recharge.Recharge();            
        }
    }
}
