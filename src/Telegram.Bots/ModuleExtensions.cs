// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2022 Aman Agnihotri

using System;
using System.Linq;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;
using Polly.Wrap;
using Telegram.Bots.Configs;
using Telegram.Bots.Http;
using Telegram.Bots.Json;

namespace Telegram.Bots
{
  using IServices = IServiceCollection;

  public static class ModuleExtensions
  {
    public static IHttpClientBuilder AddBotClient(this IServices services, string token) =>
      services.AddBotClient(new BotConfig(token));

    public static IHttpClientBuilder AddBotClient(this IServices services, IConfiguration config)
    {
      if (config is null) throw new ArgumentNullException(nameof(config));

      return services.AddBotClient(config.GetSection("Bot").Get<BotConfig>());
    }

    public static IHttpClientBuilder AddBotClient(this IServices services, BotConfig config)
    {
      if (config is null) throw new ArgumentNullException(nameof(config));

      services.AddSingleton<IBotConfig>(config).AddSingleton<ISerializer, Serializer>();

      return services.AddHttpClient<IBotClient, BotClient>(client =>
        {
          client.BaseAddress = config.BaseAddress;
          client.Timeout = config.Timeout;
        })
        .SetHandlerLifetime(TimeSpan.FromSeconds(config.HandlerLifetime))
        .AddPolicyHandler(GetPolicy());

      AsyncPolicyWrap<HttpResponseMessage> GetPolicy()
      {
        var waitAndRetryPolicy = HttpPolicyExtensions.HandleTransientHttpError()
          .WaitAndRetryAsync(config.WaitsBeforeRetry.Select(value => TimeSpan.FromSeconds(value)));

        var circuitBreakerPolicy = HttpPolicyExtensions.HandleTransientHttpError()
          .CircuitBreakerAsync(config.EventsAllowedBeforeBreaking,
            TimeSpan.FromSeconds(config.BreakDuration));

        return Policy.WrapAsync(waitAndRetryPolicy, circuitBreakerPolicy);
      }
    }
  }
}
