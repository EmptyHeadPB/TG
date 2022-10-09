// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2022 Aman Agnihotri

namespace Telegram.Bots.Types.Inline;

using System.Collections.Generic;

public interface ICaptionable
{
  string? Caption { get; init; }

  ParseMode? ParseMode { get; init; }

  IEnumerable<MessageEntity>? CaptionEntities { get; init; }
}
