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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEX1D_ARRAY_RTV")]
    public unsafe partial struct Tex1DArrayRtv
    {
        public Tex1DArrayRtv
        (
            uint mipSlice = default,
            uint firstArraySlice = default,
            uint arraySize = default
        )
        {
            MipSlice = mipSlice;
            FirstArraySlice = firstArraySlice;
            ArraySize = arraySize;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipSlice")]
        public uint MipSlice;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstArraySlice")]
        public uint FirstArraySlice;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ArraySize")]
        public uint ArraySize;
    }
}