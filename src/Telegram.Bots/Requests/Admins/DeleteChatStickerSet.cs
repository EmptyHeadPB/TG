// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020 Aman Agnihotri

namespace Telegram.Bots.Requests.Admins
{
  public abstract record DeleteChatStickerSet<TChatId> : IRequest<bool>, IChatTargetable<TChatId>
  {
    public TChatId ChatId { get; }

    public string Method { get; } = "deleteChatStickerSet";

    protected DeleteChatStickerSet(TChatId chatId) => ChatId = chatId;
  }

  public sealed record DeleteChatStickerSet : DeleteChatStickerSet<long>
  {
    public DeleteChatStickerSet(long chatId) : base(chatId) { }
  }

  namespace Usernames
  {
    public sealed record DeleteChatStickerSet : DeleteChatStickerSet<string>
    {
      public DeleteChatStickerSet(string username) : base(username) { }
    }
  }
}
