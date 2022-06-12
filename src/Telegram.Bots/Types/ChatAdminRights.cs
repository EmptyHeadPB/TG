// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2022 Aman Agnihotri

namespace Telegram.Bots.Types
{
  public sealed record ChatAdminRights
  {
    public bool IsAnonymous { get; init; }
    
    public bool CanManageChat { get; init; }
    
    public bool CanDeleteMessages { get; init; }
    
    public bool CanManageVideoChats { get; init; }
    
    public bool CanRestrictMembers { get; init; }
    
    public bool CanPromoteMembers { get; init; }
    
    public bool CanChangeInfo { get; init; }
    
    public bool CanInviteUsers { get; init; }
    
    public bool? CanPostMessages { get; init; }
    
    public bool? CanEditMessages { get; init; }
    
    public bool? CanPinMessages { get; init; }
  }
}
