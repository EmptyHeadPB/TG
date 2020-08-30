namespace Telegram.Bots.Types.Inline
{
  public sealed class InlineGame : InlineResult
  {
    public override ResultType Type { get; } = ResultType.Game;

    public string ShortName { get; }

    public InlineGame(string id, string shortName) : base(id) => ShortName = shortName;
  }
}
