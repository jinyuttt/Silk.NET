// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkPerformanceValueDataINTEL")]
    public unsafe struct PerformanceValueDataINTEL
    {
        public PerformanceValueDataINTEL
        (
            uint value32 = default,
            ulong value64 = default,
            float valueFloat = default,
            Bool32 valueBool = default,
            byte* valueString = default
        )
        {
           Value32 = value32;
           Value64 = value64;
           ValueFloat = valueFloat;
           ValueBool = valueBool;
           ValueString = valueString;
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "value32")]
        public uint Value32;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "value64")]
        public ulong Value64;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "valueFloat")]
        public float ValueFloat;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "valueBool")]
        public Bool32 ValueBool;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "valueString")]
        public byte* ValueString;
    }
}
