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
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D9_SHADOW_SUPPORT")]
    public unsafe partial struct FeatureDataD3D9ShadowSupport
    {
        public FeatureDataD3D9ShadowSupport
        (
            int supportsDepthAsTextureWithLessEqualComparisonFilter = default
        )
        {
            SupportsDepthAsTextureWithLessEqualComparisonFilter = supportsDepthAsTextureWithLessEqualComparisonFilter;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "SupportsDepthAsTextureWithLessEqualComparisonFilter")]
        public int SupportsDepthAsTextureWithLessEqualComparisonFilter;
    }
}