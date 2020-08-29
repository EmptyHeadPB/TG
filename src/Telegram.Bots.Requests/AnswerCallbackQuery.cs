using System;

namespace Telegram.Bots.Requests
{
  public sealed class AnswerCallbackQuery : IRequest<bool>
  {
    public string QueryId { get; }

    public string Text { get; }

    public bool? ShowAlert { get; set; }

    public Uri? Url { get; set; }

    public int? CacheTime { get; set; }

    public string Method { get; } = "answerCallbackQuery";

    public AnswerCallbackQuery(string queryId, string text)
    {
      QueryId = queryId;
      Text = text;
    }
  }
}
