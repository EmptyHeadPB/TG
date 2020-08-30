using System;

namespace Telegram.Bots.Types.Inline
{
  public abstract class InlineVoice<TVoice> : ReplaceableResult
  {
    public override ResultType Type { get; } = ResultType.Voice;

    public string Title { get; }

    public TVoice Voice { get; }

    public string? Caption { get; set; }

    public ParseMode? ParseMode { get; set; }

    protected InlineVoice(string id, string title, TVoice voice) : base(id)
    {
      Title = title;
      Voice = voice;
    }
  }

  public sealed class InlineVoice : InlineVoice<Uri>
  {
    public int? Duration { get; set; }

    public InlineVoice(string id, string title, Uri voice) : base(id, title, voice) { }
  }

  public sealed class InlineCachedVoice : InlineVoice<string>
  {
    public InlineCachedVoice(string id, string title, string voice) : base(id, title, voice) { }
  }
}
