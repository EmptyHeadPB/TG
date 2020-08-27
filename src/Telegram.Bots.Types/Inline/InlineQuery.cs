namespace Telegram.Bots.Types.Inline
{
  public sealed class InlineQuery
  {
    public string Id { get; set; } = null!;

    public User From { get; set; } = null!;

    public Location? Location { get; set; }

    public string Query { get; set; } = null!;

    public string Offset { get; set; } = null!;
  }
}