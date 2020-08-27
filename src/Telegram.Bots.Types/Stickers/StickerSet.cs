using System.Collections.Generic;

namespace Telegram.Bots.Types.Stickers
{
  public sealed class StickerSet
  {
    public string Name { get; set; } = null!;

    public string Title { get; set; } = null!;

    public bool IsAnimated { get; set; }

    public bool ContainsMasks { get; set; }

    public IReadOnlyList<Sticker> Stickers { get; set; } = null!;

    public Photo? Thumb { get; set; }
  }
}
