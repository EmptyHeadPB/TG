// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020 Aman Agnihotri

using Telegram.Bots.Types;

namespace Telegram.Bots.Requests
{
  public sealed record GetMe : IRequest<MyBot>
  {
    public string Method { get; } = "getMe";
  }
}
