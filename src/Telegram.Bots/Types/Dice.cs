// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020 Aman Agnihotri

namespace Telegram.Bots.Types
{
  public sealed record Dice
  {
    public Emoji Emoji { get; init; }

    public uint Value { get; init; }
  }
}
