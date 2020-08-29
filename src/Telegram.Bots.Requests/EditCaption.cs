using Telegram.Bots.Types;

namespace Telegram.Bots.Requests
{
  using Result = Either<bool, CaptionableMessage>;

  public abstract class EditCaptionBase : IRequest<Result>, ICaptionable, IInlineMarkupable
  {
    public string? Caption { get; set; }

    public ParseMode? ParseMode { get; set; }

    public InlineKeyboardMarkup? ReplyMarkup { get; set; }

    public string Method { get; } = "editMessageCaption";
  }

  public abstract class EditCaption<TChatId> : EditCaptionBase, IChatMessageTargetable<TChatId>
  {
    public TChatId ChatId { get; }

    public int MessageId { get; }

    protected EditCaption(TChatId chatId, int messageId)
    {
      ChatId = chatId;
      MessageId = messageId;
    }
  }

  public sealed class EditCaption : EditCaption<long>
  {
    public EditCaption(long chatId, int messageId) : base(chatId, messageId) { }
  }

  namespace Usernames
  {
    public sealed class EditCaption : EditCaption<string>
    {
      public EditCaption(string username, int messageId) : base(username, messageId) { }
    }
  }

  namespace Inline
  {
    public sealed class EditCaption : EditCaptionBase, IInlineMessageTargetable
    {
      public string MessageId { get; }

      public EditCaption(string messageId) => MessageId = messageId;
    }
  }
}