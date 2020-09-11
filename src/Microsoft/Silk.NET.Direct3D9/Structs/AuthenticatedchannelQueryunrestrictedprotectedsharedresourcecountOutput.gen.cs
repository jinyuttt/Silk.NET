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
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYUNRESTRICTEDPROTECTEDSHAREDRESOURCECOUNT_OUTPUT")]
    public unsafe partial struct AuthenticatedchannelQueryunrestrictedprotectedsharedresourcecountOutput
    {
        public AuthenticatedchannelQueryunrestrictedprotectedsharedresourcecountOutput
        (
            AuthenticatedchannelQueryOutput output = default,
            uint numUnrestrictedProtectedSharedResources = default
        )
        {
            Output = output;
            NumUnrestrictedProtectedSharedResources = numUnrestrictedProtectedSharedResources;
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedchannelQueryOutput Output;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumUnrestrictedProtectedSharedResources")]
        public uint NumUnrestrictedProtectedSharedResources;
    }
}