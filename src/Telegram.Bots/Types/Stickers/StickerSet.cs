// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020 Aman Agnihotri

using System.Collections.Generic;

namespace Telegram.Bots.Types.Stickers
{
  public sealed record StickerSet
  {
    public string Name { get; init; } = null!;

    public string Title { get; init; } = null!;

    public bool IsAnimated { get; init; }

    public bool ContainsMasks { get; init; }

    public IReadOnlyList<Sticker> Stickers { get; init; } = null!;

    public Photo? Thumb { get; init; }
  }
}
