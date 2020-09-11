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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_PIXEL_SHADER_TRACE_DESC")]
    public unsafe partial struct PixelShaderTraceDesc
    {
        public PixelShaderTraceDesc
        (
            ulong invocation = default,
            int x = default,
            int y = default,
            ulong sampleMask = default
        )
        {
            Invocation = invocation;
            X = x;
            Y = y;
            SampleMask = sampleMask;
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Invocation")]
        public ulong Invocation;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "X")]
        public int X;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "Y")]
        public int Y;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SampleMask")]
        public ulong SampleMask;
    }
}