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
    [NativeName("Name", "D3D12_VIDEO_PROCESS_REFERENCE_SET")]
    public unsafe partial struct VideoProcessReferenceSet
    {
        public VideoProcessReferenceSet
        (
            uint numPastFrames = default,
            ID3D12Resource** ppPastFrames = default,
            uint* pPastSubresources = default,
            uint numFutureFrames = default,
            ID3D12Resource** ppFutureFrames = default,
            uint* pFutureSubresources = default
        )
        {
            NumPastFrames = numPastFrames;
            PpPastFrames = ppPastFrames;
            PPastSubresources = pPastSubresources;
            NumFutureFrames = numFutureFrames;
            PpFutureFrames = ppFutureFrames;
            PFutureSubresources = pFutureSubresources;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumPastFrames")]
        public uint NumPastFrames;

        [NativeName("Type", "ID3D12Resource **")]
        [NativeName("Type.Name", "ID3D12Resource **")]
        [NativeName("Name", "ppPastFrames")]
        public ID3D12Resource** PpPastFrames;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pPastSubresources")]
        public uint* PPastSubresources;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumFutureFrames")]
        public uint NumFutureFrames;

        [NativeName("Type", "ID3D12Resource **")]
        [NativeName("Type.Name", "ID3D12Resource **")]
        [NativeName("Name", "ppFutureFrames")]
        public ID3D12Resource** PpFutureFrames;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pFutureSubresources")]
        public uint* PFutureSubresources;
    }
}