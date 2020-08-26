using System.Collections.Generic;

namespace Telegram.Bots.Types
{
  public sealed class PollAnswer
  {
    public string PollId { get; set; } = null!;

    public User User { get; set; } = null!;

    public IReadOnlyList<uint> OptionIds { get; set; } = null!;
  }
}
