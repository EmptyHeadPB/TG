using System;
using System.Collections.Generic;
using Telegram.Bots.Types;

namespace Telegram.Bots.Requests.Webhooks
{
  public sealed class SetWebhook : IRequest<bool>, IUploadable
  {
    public Uri? Url { get; }

    public InputFile? Certificate { get; set; }

    public uint? MaxConnections { get; set; }

    public IEnumerable<UpdateType>? AllowedUpdates { get; set; }

    public string Method { get; } = "setWebhook";

    public SetWebhook(Uri? url = default) => Url = url;

    public IEnumerable<InputFile?> GetFiles() => new[] { Certificate };
  }
}
