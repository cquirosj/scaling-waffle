namespace Sales;
public partial class BuyersRemorseState
{
    private string _orderId = string.Empty;

    public partial string OrderId
    {
        get { return _orderId; }
        set { _orderId = value; }
    }
}