using NServiceBus;

namespace Shipping;

partial class ShippingPolicyData : ContainSagaData
{
    public partial string OrderId { get; set; }
    public bool IsOrderPlaced { get; set; }
    public bool IsOrderBilled { get; set; }
}