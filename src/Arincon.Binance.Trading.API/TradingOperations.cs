using Binance.Account.Orders;
using System;
using System.Threading.Tasks;

namespace Arincon.Binance.Trading.API
{
    public class TradingOperations
    {
        private long orderId;
        private Order orderData;
        private bool buyFilled;
        private bool sellFilled;
        private decimal buyFilledQty;
        private decimal sellFilledQty;
        private decimal stopLoss;
        private decimal quantity;
        private decimal stepSize;

        private const decimal WAIT_TIME_BUY_SELL = 0.6m;
        private const decimal WAIT_TIME_STOP_LOSS = 20m;
        private const decimal INVALID_ATTEMPTS_LIMIT = 10m;
        private const decimal MAX_TRADE_SIZE = 7m;

        public TradingOperations()
        {
            orderId = 0;
            buyFilled = true;
            sellFilled = true;
            buyFilledQty = 0;
            sellFilledQty = 0;
            stopLoss = 0;
            quantity = 0;
            stepSize = 0;
        }

        public TradingOperations(long orderId, decimal quantity) : this()
        {
            this.orderId = orderId;
            this.quantity = quantity;
        }

        public void Buy()
        {

        }

        public void Sell()
        {

        }

        public void Stop()
        {

        }

        public void Check()
        {

        }

        public void Cancel()
        {

        }

        public void Calc()
        {

        }

        public void CheckOrder()
        {

        }

        public void Action()
        {

        }

        public void Filter()
        {

        }
    }
}
