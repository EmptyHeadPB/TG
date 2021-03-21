// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020 Aman Agnihotri

namespace Telegram.Bots.Requests.Admins
{
  public abstract record UnbanChatMember<TChatId> : IRequest<bool>, IChatMemberTargetable<TChatId>
  {
    public TChatId ChatId { get; }

    public long UserId { get; }

    public bool? OnlyIfBanned { get; init; }

    public string Method { get; } = "unbanChatMember";

    protected UnbanChatMember(TChatId chatId, long userId)
    {
      ChatId = chatId;
      UserId = userId;
    }
  }

  public sealed record UnbanChatMember : UnbanChatMember<long>
  {
    public UnbanChatMember(long chatId, long userId) : base(chatId, userId) { }
  }

  namespace Usernames
  {
    public sealed record UnbanChatMember : UnbanChatMember<string>
    {
      public UnbanChatMember(string username, long userId) : base(username, userId) { }
    }
  }
}
