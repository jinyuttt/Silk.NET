// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_QUERY_VIDEO_MEMORY_INFO")]
    public unsafe partial struct QueryVideoMemoryInfo
    {
        public QueryVideoMemoryInfo
        (
            ulong budget = default,
            ulong currentUsage = default,
            ulong availableForReservation = default,
            ulong currentReservation = default
        )
        {
            Budget = budget;
            CurrentUsage = currentUsage;
            AvailableForReservation = availableForReservation;
            CurrentReservation = currentReservation;
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Budget")]
        public ulong Budget;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CurrentUsage")]
        public ulong CurrentUsage;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "AvailableForReservation")]
        public ulong AvailableForReservation;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CurrentReservation")]
        public ulong CurrentReservation;
    }
}