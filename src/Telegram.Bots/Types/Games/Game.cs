// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020 Aman Agnihotri

using System.Collections.Generic;

namespace Telegram.Bots.Types.Games
{
  public sealed record Game
  {
    public string Title { get; init; } = null!;

    public string Description { get; init; } = null!;

    public IReadOnlyList<Photo> PhotoSet { get; init; } = null!;

    public string? Text { get; init; }

    public IReadOnlyList<MessageEntity>? TextEntities { get; init; }

    public Animation? Animation { get; init; }
  }
}
