namespace Telegram.Bots.Types.Stickers
{
  public sealed class Sticker : File
  {
    public int Width { get; set; }

    public int Height { get; set; }

    public bool IsAnimated { get; set; }

    public Photo? Thumb { get; set; }

    public string? Emoji { get; set; }

    public string? SetName { get; set; }

    public MaskPosition? MaskPosition { get; set; }
  }
}
