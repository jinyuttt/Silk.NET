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
    [NativeName("Name", "DXGI_MODE_DESC")]
    public unsafe partial struct ModeDesc
    {
        public ModeDesc
        (
            uint width = default,
            uint height = default,
            Rational refreshRate = default,
            Silk.NET.DXGI.Format format = default,
            ModeScanlineOrder scanlineOrdering = default,
            ModeScaling scaling = default
        )
        {
            Width = width;
            Height = height;
            RefreshRate = refreshRate;
            Format = format;
            ScanlineOrdering = scanlineOrdering;
            Scaling = scaling;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "RefreshRate")]
        public Rational RefreshRate;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "DXGI_MODE_SCANLINE_ORDER")]
        [NativeName("Type.Name", "DXGI_MODE_SCANLINE_ORDER")]
        [NativeName("Name", "ScanlineOrdering")]
        public ModeScanlineOrder ScanlineOrdering;

        [NativeName("Type", "DXGI_MODE_SCALING")]
        [NativeName("Type.Name", "DXGI_MODE_SCALING")]
        [NativeName("Name", "Scaling")]
        public ModeScaling Scaling;
    }
}