namespace Telegram.Bots.Types.Payments
{
  public sealed class ShippingQuery
  {
    public string Id { get; set; } = null!;

    public User From { get; set; } = null!;

    public string InvoicePayment { get; set; } = null!;

    public ShippingAddress ShippingAddress { get; set; } = null!;
  }
}
