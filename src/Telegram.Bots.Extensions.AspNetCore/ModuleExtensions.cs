// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2022 Aman Agnihotri

using Microsoft.Extensions.DependencyInjection;
using Telegram.Bots.Json;

namespace Telegram.Bots.Extensions.AspNetCore;

public static class ModuleExtensions
{
  public static IMvcBuilder AddBotSerializer(this IMvcBuilder builder) =>
    builder.AddNewtonsoftJson(o => Serializer.Modify(o.SerializerSettings));
}
