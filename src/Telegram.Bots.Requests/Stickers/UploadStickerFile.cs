using System.Collections.Generic;
using Telegram.Bots.Types;

namespace Telegram.Bots.Requests.Stickers
{
  public sealed class UploadStickerFile : IRequest<FileInfo>, IUserTargetable, IUploadable
  {
    public int UserId { get; }

    public InputFile Sticker { get; }

    public string Method { get; } = "uploadStickerFile";

    public UploadStickerFile(int userId, InputFile sticker)
    {
      UserId = userId;
      Sticker = sticker;
    }

    public IEnumerable<InputFile?> GetFiles() => new[] { Sticker };
  }
}
