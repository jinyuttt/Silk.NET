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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "ID3D12VideoProcessCommandList")]
    public unsafe partial struct ID3D12VideoProcessCommandList
    {
        public static implicit operator ID3D12CommandList(ID3D12VideoProcessCommandList val)
            => Unsafe.As<ID3D12VideoProcessCommandList, ID3D12CommandList>(ref val);

        public readonly ref ID3D12CommandList AsCommandList()
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                return ref *(ID3D12CommandList*)@this;
            }
        }

        public static implicit operator ID3D12DeviceChild(ID3D12VideoProcessCommandList val)
            => Unsafe.As<ID3D12VideoProcessCommandList, ID3D12DeviceChild>(ref val);

        public readonly ref ID3D12DeviceChild AsDeviceChild()
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                return ref *(ID3D12DeviceChild*)@this;
            }
        }

        public static implicit operator ID3D12Object(ID3D12VideoProcessCommandList val)
            => Unsafe.As<ID3D12VideoProcessCommandList, ID3D12Object>(ref val);

        public readonly ref ID3D12Object AsObject()
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                return ref *(ID3D12Object*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoProcessCommandList val)
            => Unsafe.As<ID3D12VideoProcessCommandList, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D12VideoProcessCommandList
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
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetName(char* Name)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, char*, int>)LpVtbl[6])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(ref char Name)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(string Name)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDevicePtr = &ppvDevice)
                    {
                        ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public CommandListType GetType()
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                CommandListType ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, CommandListType>)LpVtbl[8])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Close()
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, int>)LpVtbl[9])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Reset(ID3D12CommandAllocator* pAllocator)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocator);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Reset(ref ID3D12CommandAllocator pAllocator)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                int ret = default;
                fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
                {
                    ret = ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocatorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void ClearState()
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, void>)LpVtbl[11])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriers);
            }
        }

        /// <summary>To be added.</summary>
        public void ResourceBarrier(uint NumBarriers, ref ResourceBarrier pBarriers)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegion);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardResource(ID3D12Resource* pResource, ref DiscardRegion pRegion)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (DiscardRegion* pRegionPtr = &pRegion)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegionPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void DiscardResource(ref ID3D12Resource pResource, DiscardRegion* pRegion)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegion);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void DiscardResource(ref ID3D12Resource pResource, ref DiscardRegion pRegion)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (DiscardRegion* pRegionPtr = &pRegion)
                    {
                        ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeap, Type, Index);
            }
        }

        /// <summary>To be added.</summary>
        public void BeginQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeap, Type, Index);
            }
        }

        /// <summary>To be added.</summary>
        public void EndQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
                {
                    fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                    {
                        ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
            }
        }

        /// <summary>To be added.</summary>
        public void SetPredication(ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetMarker(uint Metadata, void* pData, uint Size)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pData, Size);
            }
        }

        /// <summary>To be added.</summary>
        public void SetMarker<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint, T0*, uint, void>)LpVtbl[18])(@this, Metadata, pDataPtr, Size);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void BeginEvent(uint Metadata, void* pData, uint Size)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pData, Size);
            }
        }

        /// <summary>To be added.</summary>
        public void BeginEvent<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint, T0*, uint, void>)LpVtbl[19])(@this, Metadata, pDataPtr, Size);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void EndEvent()
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, void>)LpVtbl[20])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArguments);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArguments);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments* pInputArguments)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                    {
                        ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments pInputArguments)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
                {
                    fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                    {
                        fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                        {
                            ((delegate* cdecl<ID3D12VideoProcessCommandList*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModes);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (WritebufferimmediateMode* pModesPtr = &pModes)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
                {
                    ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes)
        {
            fixed (ID3D12VideoProcessCommandList* @this = &this)
            {
                fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
                {
                    fixed (WritebufferimmediateMode* pModesPtr = &pModes)
                    {
                        ((delegate* cdecl<ID3D12VideoProcessCommandList*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModesPtr);
                    }
                }
            }
        }

    }
}