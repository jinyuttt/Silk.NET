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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT")]
    public unsafe partial struct AuthenticatedchannelConfigureOutput
    {
        public AuthenticatedchannelConfigureOutput
        (
            D3DOMac omac = default,
            Guid configureType = default,
            void* hChannel = default,
            uint sequenceNumber = default,
            int returnCode = default
        )
        {
            Omac = omac;
            ConfigureType = configureType;
            HChannel = hChannel;
            SequenceNumber = sequenceNumber;
            ReturnCode = returnCode;
        }


        [NativeName("Type", "D3D_OMAC")]
        [NativeName("Type.Name", "D3D_OMAC")]
        [NativeName("Name", "omac")]
        public D3DOMac Omac;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "ConfigureType")]
        public Guid ConfigureType;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hChannel")]
        public void* HChannel;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SequenceNumber")]
        public uint SequenceNumber;

        [NativeName("Type", "HRESULT")]
        [NativeName("Type.Name", "HRESULT")]
        [NativeName("Name", "ReturnCode")]
        public int ReturnCode;
    }
}