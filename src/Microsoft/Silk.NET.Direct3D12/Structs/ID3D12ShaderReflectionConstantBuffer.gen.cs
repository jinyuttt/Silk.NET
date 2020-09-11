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
    [NativeName("Name", "ID3D12ShaderReflectionConstantBuffer")]
    public unsafe partial struct ID3D12ShaderReflectionConstantBuffer
    {
        public ID3D12ShaderReflectionConstantBuffer
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int GetDesc(ShaderBufferDesc* pDesc)
        {
            fixed (ID3D12ShaderReflectionConstantBuffer* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionConstantBuffer*, ShaderBufferDesc*, int>)LpVtbl[0])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref ShaderBufferDesc pDesc)
        {
            fixed (ID3D12ShaderReflectionConstantBuffer* @this = &this)
            {
                int ret = default;
                fixed (ShaderBufferDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflectionConstantBuffer*, ShaderBufferDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionVariable* GetVariableByIndex(uint Index)
        {
            fixed (ID3D12ShaderReflectionConstantBuffer* @this = &this)
            {
                ID3D12ShaderReflectionVariable* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionConstantBuffer*, uint, ID3D12ShaderReflectionVariable*>)LpVtbl[1])(@this, Index);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionVariable* GetVariableByName(byte* Name)
        {
            fixed (ID3D12ShaderReflectionConstantBuffer* @this = &this)
            {
                ID3D12ShaderReflectionVariable* ret = default;
                ret = ((delegate* cdecl<ID3D12ShaderReflectionConstantBuffer*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[2])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionVariable* GetVariableByName(ref byte Name)
        {
            fixed (ID3D12ShaderReflectionConstantBuffer* @this = &this)
            {
                ID3D12ShaderReflectionVariable* ret = default;
                fixed (byte* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12ShaderReflectionConstantBuffer*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[2])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe ID3D12ShaderReflectionVariable* GetVariableByName(string Name)
        {
            fixed (ID3D12ShaderReflectionConstantBuffer* @this = &this)
            {
                ID3D12ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12ShaderReflectionConstantBuffer*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[2])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

    }
}