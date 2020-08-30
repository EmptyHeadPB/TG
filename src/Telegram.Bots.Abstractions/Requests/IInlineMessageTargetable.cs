// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020 Aman Agnihotri

namespace Telegram.Bots.Requests
{
  public interface IInlineMessageTargetable
  {
    string MessageId { get; }
  }
}
