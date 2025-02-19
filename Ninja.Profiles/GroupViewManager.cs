﻿using System.Collections.Generic;
using MahApps.Metro.IconPacks;
using Ninja.Models;

namespace Ninja.Profiles
{
    using Models;

    public static class GroupViewManager
    {
        // List of all applications
        public static List<GroupViewInfo> List => new()
        {
            // General
            new GroupViewInfo(GroupViewName.General, new PackIconModern { Kind = PackIconModernKind.Box }),

            // Applications
            new GroupViewInfo(GroupViewName.RemoteDesktop, ApplicationManager.GetIcon(ApplicationName.RemoteDesktop)),
            new GroupViewInfo(GroupViewName.PowerShell, ApplicationManager.GetIcon(ApplicationName.PowerShell)),
            new GroupViewInfo(GroupViewName.PuTTY, ApplicationManager.GetIcon(ApplicationName.PuTTY)),
            new GroupViewInfo(GroupViewName.AWSSessionManager,
                ApplicationManager.GetIcon(ApplicationName.AWSSessionManager)),
            new GroupViewInfo(GroupViewName.TigerVNC, ApplicationManager.GetIcon(ApplicationName.TigerVNC)),
            new GroupViewInfo(GroupViewName.SNMP, ApplicationManager.GetIcon(ApplicationName.SNMP))
        };
    }
}