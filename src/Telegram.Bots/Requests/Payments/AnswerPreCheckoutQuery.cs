// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020-2022 Aman Agnihotri

namespace Telegram.Bots.Requests.Payments;

public sealed record AnswerPreCheckoutQuery : IRequest<bool>
{
  public string QueryId { get; }

  public bool Ok { get; }

  public string? ErrorMessage { get; }

  public string Method => "answerPreCheckoutQuery";

  public AnswerPreCheckoutQuery(string queryId, string? errorMessage = default)
  {
    QueryId = queryId;

    if (errorMessage is null)
    {
      Ok = true;
    }
    else
    {
      ErrorMessage = errorMessage;
    }
  }
}
