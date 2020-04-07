namespace DemoApp.Topics
{
    public struct OrderId
    {
        private long _value;

        public OrderId(long orderId)
        {
            _value = orderId;
        }

        public long CalculateNextOrderId()
        {
            // _value++;
            return _value + 1;
        }
    }
}