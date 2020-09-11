// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "ID3D11TracingDevice")]
    public unsafe partial struct ID3D11TracingDevice
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11TracingDevice val)
            => Unsafe.As<ID3D11TracingDevice, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D11TracingDevice* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D11TracingDevice
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
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D11TracingDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11TracingDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11TracingDevice* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11TracingDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11TracingDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11TracingDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11TracingDevice* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11TracingDevice*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11TracingDevice* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11TracingDevice*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11TracingDevice* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11TracingDevice*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetShaderTrackingOptionsByType(uint ResourceTypeFlags, uint Options)
        {
            fixed (ID3D11TracingDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11TracingDevice*, uint, uint, int>)LpVtbl[3])(@this, ResourceTypeFlags, Options);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetShaderTrackingOptions(Silk.NET.Core.Native.IUnknown* pShader, uint Options)
        {
            fixed (ID3D11TracingDevice* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11TracingDevice*, Silk.NET.Core.Native.IUnknown*, uint, int>)LpVtbl[4])(@this, pShader, Options);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetShaderTrackingOptions(ref Silk.NET.Core.Native.IUnknown pShader, uint Options)
        {
            fixed (ID3D11TracingDevice* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pShaderPtr = &pShader)
                {
                    ret = ((delegate* cdecl<ID3D11TracingDevice*, Silk.NET.Core.Native.IUnknown*, uint, int>)LpVtbl[4])(@this, pShaderPtr, Options);
                }
                return ret;
            }
        }

    }
}