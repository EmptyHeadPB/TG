namespace Telegram.Bots.Types.Payments
{
  public sealed class PreCheckoutQuery
  {
    public string Id { get; set; } = null!;

    public User From { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public int TotalAmount { get; set; }

    public string InvoicePayload { get; set; } = null!;

    public string? ShippingOptionId { get; set; }

    public OrderInfo? OrderInfo { get; set; }
  }
}
