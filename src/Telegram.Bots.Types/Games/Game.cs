using System.Collections.Generic;

namespace Telegram.Bots.Types.Games
{
  public sealed class Game
  {
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public IReadOnlyList<Photo> PhotoSet { get; set; } = null!;

    public string? Text { get; set; }

    public IReadOnlyList<MessageEntity>? TextEntities { get; set; }

    public Animation? Animation { get; set; }
  }
}
