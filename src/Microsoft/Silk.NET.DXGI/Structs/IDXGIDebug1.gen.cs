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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "IDXGIDebug1")]
    public unsafe partial struct IDXGIDebug1
    {
        public static implicit operator IDXGIDebug(IDXGIDebug1 val)
            => Unsafe.As<IDXGIDebug1, IDXGIDebug>(ref val);

        public readonly ref IDXGIDebug AsDebug()
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                return ref *(IDXGIDebug*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIDebug1 val)
            => Unsafe.As<IDXGIDebug1, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDXGIDebug1
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
            fixed (IDXGIDebug1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDebug1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGIDebug1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIDebug1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGIDebug1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIDebug1*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIDebug1*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ReportLiveObjects(Guid apiid, DebugRloFlags flags)
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDebug1*, Guid, DebugRloFlags, int>)LpVtbl[3])(@this, apiid, flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void EnableLeakTrackingForThread()
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                ((delegate* cdecl<IDXGIDebug1*, void>)LpVtbl[4])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public void DisableLeakTrackingForThread()
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                ((delegate* cdecl<IDXGIDebug1*, void>)LpVtbl[5])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public int IsLeakTrackingEnabledForThread()
        {
            fixed (IDXGIDebug1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDebug1*, int>)LpVtbl[6])(@this);
                return ret;
            }
        }

    }
}