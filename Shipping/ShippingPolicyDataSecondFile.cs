using NServiceBus;

namespace Shipping;

partial class ShippingPolicyData
{
    private string _orderId = string.Empty;

    public partial string OrderId
    {
        get { return _orderId; }
        set { _orderId = value; }
    }
}
