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
    [NativeName("Name", "ID3D11VideoDevice2")]
    public unsafe partial struct ID3D11VideoDevice2
    {
        public static implicit operator ID3D11VideoDevice1(ID3D11VideoDevice2 val)
            => Unsafe.As<ID3D11VideoDevice2, ID3D11VideoDevice1>(ref val);

        public readonly ref ID3D11VideoDevice1 AsVideoDevice1()
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                return ref *(ID3D11VideoDevice1*)@this;
            }
        }

        public static implicit operator ID3D11VideoDevice(ID3D11VideoDevice2 val)
            => Unsafe.As<ID3D11VideoDevice2, ID3D11VideoDevice>(ref val);

        public readonly ref ID3D11VideoDevice AsVideoDevice()
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                return ref *(ID3D11VideoDevice*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11VideoDevice2 val)
            => Unsafe.As<ID3D11VideoDevice2, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D11VideoDevice2
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
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoder);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDesc, pConfig, ppDecoderPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(VideoDecoderDesc* pVideoDesc, ref VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDesc, pConfigPtr, ppDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoder);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, VideoDecoderConfig* pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDescPtr, pConfig, ppDecoderPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ID3D11VideoDecoder** ppDecoder)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoder);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoder(ref VideoDecoderDesc pVideoDesc, ref VideoDecoderConfig pConfig, ref ID3D11VideoDecoder* ppDecoder)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                    {
                        fixed (ID3D11VideoDecoder** ppDecoderPtr = &ppDecoder)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)LpVtbl[3])(@this, pVideoDescPtr, pConfigPtr, ppDecoderPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessor);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)LpVtbl[4])(@this, pEnum, RateConversionIndex, ppVideoProcessorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessor);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessor(ref ID3D11VideoProcessorEnumerator pEnum, uint RateConversionIndex, ref ID3D11VideoProcessor* ppVideoProcessor)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (ID3D11VideoProcessor** ppVideoProcessorPtr = &ppVideoProcessor)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)LpVtbl[4])(@this, pEnumPtr, RateConversionIndex, ppVideoProcessorPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateAuthenticatedChannel(AuthenticatedChannelType ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannel);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateAuthenticatedChannel(AuthenticatedChannelType ChannelType, ref ID3D11AuthenticatedChannel* ppAuthenticatedChannel)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11AuthenticatedChannel** ppAuthenticatedChannelPtr = &ppAuthenticatedChannel)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)LpVtbl[5])(@this, ChannelType, ppAuthenticatedChannelPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, ppCryptoSessionPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSession);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSession);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, ppCryptoSessionPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSession);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateCryptoSession(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref ID3D11CryptoSession* ppCryptoSession)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                        {
                            fixed (ID3D11CryptoSession** ppCryptoSessionPtr = &ppCryptoSession)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)LpVtbl[6])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, ppCryptoSessionPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResource, pDesc, ppVDOVView);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResource, pDesc, ppVDOVViewPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ID3D11Resource* pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResource, pDescPtr, ppVDOVViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, VideoDecoderOutputViewDesc* pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResourcePtr, pDesc, ppVDOVViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoDecoderOutputView(ref ID3D11Resource pResource, ref VideoDecoderOutputViewDesc pDesc, ref ID3D11VideoDecoderOutputView* ppVDOVView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoDecoderOutputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoDecoderOutputView** ppVDOVViewPtr = &ppVDOVView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, VideoDecoderOutputViewDesc*, ID3D11VideoDecoderOutputView**, int>)LpVtbl[7])(@this, pResourcePtr, pDescPtr, ppVDOVViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIView);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnum, pDesc, ppVPIViewPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnum, pDescPtr, ppVPIViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnumPtr, pDesc, ppVPIViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResource, pEnumPtr, pDescPtr, ppVPIViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnum, pDesc, ppVPIViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnum, pDescPtr, ppVPIViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorInputViewDesc* pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPIViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ID3D11VideoProcessorInputView** ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIView);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorInputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorInputViewDesc pDesc, ref ID3D11VideoProcessorInputView* ppVPIView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (VideoProcessorInputViewDesc* pDescPtr = &pDesc)
                        {
                            fixed (ID3D11VideoProcessorInputView** ppVPIViewPtr = &ppVPIView)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDesc*, ID3D11VideoProcessorInputView**, int>)LpVtbl[8])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPIViewPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOView);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnum, pDesc, ppVPOViewPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnum, pDescPtr, ppVPOViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnumPtr, pDesc, ppVPOViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ID3D11Resource* pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResource, pEnumPtr, pDescPtr, ppVPOViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOView);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnum, pDesc, ppVPOViewPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ID3D11VideoProcessorEnumerator* pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                    {
                        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnum, pDescPtr, ppVPOViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOView);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, VideoProcessorOutputViewDesc* pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDesc, ppVPOViewPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOView);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorOutputView(ref ID3D11Resource pResource, ref ID3D11VideoProcessorEnumerator pEnum, ref VideoProcessorOutputViewDesc pDesc, ref ID3D11VideoProcessorOutputView* ppVPOView)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D11VideoProcessorEnumerator* pEnumPtr = &pEnum)
                    {
                        fixed (VideoProcessorOutputViewDesc* pDescPtr = &pDesc)
                        {
                            fixed (ID3D11VideoProcessorOutputView** ppVPOViewPtr = &ppVPOView)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDesc*, ID3D11VideoProcessorOutputView**, int>)LpVtbl[9])(@this, pResourcePtr, pEnumPtr, pDescPtr, ppVPOViewPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorEnumerator(VideoProcessorContentDesc* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)LpVtbl[10])(@this, pDesc, ppEnum);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorEnumerator(VideoProcessorContentDesc* pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)LpVtbl[10])(@this, pDesc, ppEnumPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorEnumerator(ref VideoProcessorContentDesc pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)LpVtbl[10])(@this, pDescPtr, ppEnum);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateVideoProcessorEnumerator(ref VideoProcessorContentDesc pDesc, ref ID3D11VideoProcessorEnumerator* ppEnum)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoProcessorContentDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D11VideoProcessorEnumerator** ppEnumPtr = &ppEnum)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoProcessorContentDesc*, ID3D11VideoProcessorEnumerator**, int>)LpVtbl[10])(@this, pDescPtr, ppEnumPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetVideoDecoderProfileCount()
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, uint>)LpVtbl[11])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderProfile(uint Index, Guid* pDecoderProfile)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, uint, Guid*, int>)LpVtbl[12])(@this, Index, pDecoderProfile);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVideoDecoderProfile(uint Index, ref Guid pDecoderProfile)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, uint, Guid*, int>)LpVtbl[12])(@this, Index, pDecoderProfilePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderFormat(Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)LpVtbl[13])(@this, pDecoderProfile, Format, pSupported);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderFormat(Guid* pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)LpVtbl[13])(@this, pDecoderProfile, Format, pSupportedPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderFormat(ref Guid pDecoderProfile, Silk.NET.DXGI.Format Format, int* pSupported)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupported);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckVideoDecoderFormat(ref Guid pDecoderProfile, Silk.NET.DXGI.Format Format, ref int pSupported)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Silk.NET.DXGI.Format, int*, int>)LpVtbl[13])(@this, pDecoderProfilePtr, Format, pSupportedPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfigCount(VideoDecoderDesc* pDesc, uint* pCount)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)LpVtbl[14])(@this, pDesc, pCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfigCount(VideoDecoderDesc* pDesc, ref uint pCount)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)LpVtbl[14])(@this, pDesc, pCountPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfigCount(ref VideoDecoderDesc pDesc, uint* pCount)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)LpVtbl[14])(@this, pDescPtr, pCount);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVideoDecoderConfigCount(ref VideoDecoderDesc pDesc, ref uint pCount)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (uint* pCountPtr = &pCount)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, uint*, int>)LpVtbl[14])(@this, pDescPtr, pCountPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfig(VideoDecoderDesc* pDesc, uint Index, VideoDecoderConfig* pConfig)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)LpVtbl[15])(@this, pDesc, Index, pConfig);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfig(VideoDecoderDesc* pDesc, uint Index, ref VideoDecoderConfig pConfig)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)LpVtbl[15])(@this, pDesc, Index, pConfigPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderConfig(ref VideoDecoderDesc pDesc, uint Index, VideoDecoderConfig* pConfig)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)LpVtbl[15])(@this, pDescPtr, Index, pConfig);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVideoDecoderConfig(ref VideoDecoderDesc pDesc, uint Index, ref VideoDecoderConfig pConfig)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pDescPtr = &pDesc)
                {
                    fixed (VideoDecoderConfig* pConfigPtr = &pConfig)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, uint, VideoDecoderConfig*, int>)LpVtbl[15])(@this, pDescPtr, Index, pConfigPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(Guid* pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCaps);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(Guid* pCryptoType, Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoType, pDecoderProfile, pCapsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(Guid* pCryptoType, ref Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCaps);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(Guid* pCryptoType, ref Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoType, pDecoderProfilePtr, pCapsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(ref Guid pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCaps);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(ref Guid pCryptoType, Guid* pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfile, pCapsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContentProtectionCaps(ref Guid pCryptoType, ref Guid pDecoderProfile, VideoContentProtectionCaps* pCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCaps);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetContentProtectionCaps(ref Guid pCryptoType, ref Guid pDecoderProfile, ref VideoContentProtectionCaps pCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (VideoContentProtectionCaps* pCapsPtr = &pCaps)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, VideoContentProtectionCaps*, int>)LpVtbl[16])(@this, pCryptoTypePtr, pDecoderProfilePtr, pCapsPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoType, pDecoderProfile, Index, pKeyExchangeTypePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, ref Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeType);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(Guid* pCryptoType, ref Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoType, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(ref Guid pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeType);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(ref Guid pCryptoType, Guid* pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfile, Index, pKeyExchangeTypePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckCryptoKeyExchange(ref Guid pCryptoType, ref Guid pDecoderProfile, uint Index, Guid* pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeType);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckCryptoKeyExchange(ref Guid pCryptoType, ref Guid pDecoderProfile, uint Index, ref Guid pKeyExchangeType)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, uint, Guid*, int>)LpVtbl[17])(@this, pCryptoTypePtr, pDecoderProfilePtr, Index, pKeyExchangeTypePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, void*, int>)LpVtbl[18])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, T0*, int>)LpVtbl[18])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, void*, int>)LpVtbl[18])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, T0*, int>)LpVtbl[18])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[19])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[19])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[19])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[19])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(Guid* pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                        {
                            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoType, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, Guid* pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                    {
                        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                        {
                            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfile, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSizePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSize);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, Guid* pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                        {
                            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeType, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSize);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, uint* pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                        {
                            fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSize, pPrivateOutputSizePtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, uint* pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                        {
                            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSize);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetCryptoSessionPrivateDataSize(ref Guid pCryptoType, ref Guid pDecoderProfile, ref Guid pKeyExchangeType, ref uint pPrivateInputSize, ref uint pPrivateOutputSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                    {
                        fixed (Guid* pKeyExchangeTypePtr = &pKeyExchangeType)
                        {
                            fixed (uint* pPrivateInputSizePtr = &pPrivateInputSize)
                            {
                                fixed (uint* pPrivateOutputSizePtr = &pPrivateOutputSize)
                                {
                                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, Guid*, Guid*, uint*, uint*, int>)LpVtbl[20])(@this, pCryptoTypePtr, pDecoderProfilePtr, pKeyExchangeTypePtr, pPrivateInputSizePtr, pPrivateOutputSizePtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCapsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCaps);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pCryptoTypePtr = &pCryptoType)
                {
                    fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCaps);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCapsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (Guid* pCryptoTypePtr = &pCryptoType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCaps);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (Guid* pCryptoTypePtr = &pCryptoType)
                    {
                        fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfile, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCapsPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pCryptoTypePtr = &pCryptoType)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCaps);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, Silk.NET.DXGI.Rational* pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Guid* pCryptoTypePtr = &pCryptoType)
                    {
                        fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCaps);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, Guid* pCryptoType, ref uint pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoType, pDecoderCapsPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, uint* pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (Guid* pCryptoTypePtr = &pCryptoType)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCaps);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetVideoDecoderCaps(ref Guid pDecoderProfile, uint SampleWidth, uint SampleHeight, ref Silk.NET.DXGI.Rational pFrameRate, uint BitRate, ref Guid pCryptoType, ref uint pDecoderCaps)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Guid* pDecoderProfilePtr = &pDecoderProfile)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (Guid* pCryptoTypePtr = &pCryptoType)
                        {
                            fixed (uint* pDecoderCapsPtr = &pDecoderCaps)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, Guid*, uint, uint, Silk.NET.DXGI.Rational*, uint, Guid*, uint*, int>)LpVtbl[21])(@this, pDecoderProfilePtr, SampleWidth, SampleHeight, pFrameRatePtr, BitRate, pCryptoTypePtr, pDecoderCapsPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (int* pSupportedPtr = &pSupported)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (int* pSupportedPtr = &pSupported)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pSupportedPtr = &pSupported)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pSupportedPtr = &pSupported)
                            {
                                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                                {
                                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (int* pSupportedPtr = &pSupported)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pSupportedPtr = &pSupported)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pSupportedPtr = &pSupported)
                            {
                                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                                {
                                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupported, pRealTimeHintPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (int* pSupportedPtr = &pSupported)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pSupportedPtr = &pSupported)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                        {
                            fixed (int* pSupportedPtr = &pSupported)
                            {
                                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                                {
                                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHint);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                        {
                            fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupported, pRealTimeHintPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                        {
                            fixed (int* pSupportedPtr = &pSupported)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHint);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                        {
                            fixed (int* pSupportedPtr = &pSupported)
                            {
                                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                                {
                                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDesc, pSupportedPtr, pRealTimeHintPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                        {
                            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHint);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, int* pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                        {
                            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                            {
                                fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                                {
                                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupported, pRealTimeHintPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, int* pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                        {
                            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                            {
                                fixed (int* pSupportedPtr = &pSupported)
                                {
                                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHint);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckVideoDecoderDownsampling(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pOutputDesc, ref int pSupported, ref int pRealTimeHint)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                        {
                            fixed (VideoSampleDesc* pOutputDescPtr = &pOutputDesc)
                            {
                                fixed (int* pSupportedPtr = &pSupported)
                                {
                                    fixed (int* pRealTimeHintPtr = &pRealTimeHint)
                                    {
                                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int*, int*, int>)LpVtbl[22])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pOutputDescPtr, pSupportedPtr, pRealTimeHintPtr);
                                    }
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                {
                    fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDescPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDescPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDesc);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(VideoDecoderDesc* pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDesc, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDescPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDescPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDesc);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                    {
                        fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfig, pFrameRatePtr, pRecommendedOutputDescPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDesc);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, Silk.NET.DXGI.Rational* pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRate, pRecommendedOutputDescPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, VideoSampleDesc* pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                        {
                            ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDesc);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RecommendVideoDecoderDownsampleParameters(ref VideoDecoderDesc pInputDesc, Silk.NET.DXGI.ColorSpaceType InputColorSpace, ref VideoDecoderConfig pInputConfig, ref Silk.NET.DXGI.Rational pFrameRate, ref VideoSampleDesc pRecommendedOutputDesc)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (VideoDecoderDesc* pInputDescPtr = &pInputDesc)
                {
                    fixed (VideoDecoderConfig* pInputConfigPtr = &pInputConfig)
                    {
                        fixed (Silk.NET.DXGI.Rational* pFrameRatePtr = &pFrameRate)
                        {
                            fixed (VideoSampleDesc* pRecommendedOutputDescPtr = &pRecommendedOutputDesc)
                            {
                                ret = ((delegate* cdecl<ID3D11VideoDevice2*, VideoDecoderDesc*, Silk.NET.DXGI.ColorSpaceType, VideoDecoderConfig*, Silk.NET.DXGI.Rational*, VideoSampleDesc*, int>)LpVtbl[23])(@this, pInputDescPtr, InputColorSpace, pInputConfigPtr, pFrameRatePtr, pRecommendedOutputDescPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckFeatureSupport(FeatureVideo Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, FeatureVideo, void*, uint, int>)LpVtbl[24])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckFeatureSupport<T0>(FeatureVideo Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pFeatureSupportDataPtr = &pFeatureSupportData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, FeatureVideo, T0*, uint, int>)LpVtbl[24])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int NegotiateCryptoSessionKeyExchangeMT(ID3D11CryptoSession* pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, void*, int>)LpVtbl[25])(@this, pCryptoSession, flags, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int NegotiateCryptoSessionKeyExchangeMT<T0>(ID3D11CryptoSession* pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, T0*, int>)LpVtbl[25])(@this, pCryptoSession, flags, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int NegotiateCryptoSessionKeyExchangeMT(ref ID3D11CryptoSession pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, void* pData)
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, void*, int>)LpVtbl[25])(@this, pCryptoSessionPtr, flags, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int NegotiateCryptoSessionKeyExchangeMT<T0>(ref ID3D11CryptoSession pCryptoSession, CryptoSessionKeyExchangeFlags flags, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D11VideoDevice2* @this = &this)
            {
                int ret = default;
                fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D11VideoDevice2*, ID3D11CryptoSession*, CryptoSessionKeyExchangeFlags, uint, T0*, int>)LpVtbl[25])(@this, pCryptoSessionPtr, flags, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

    }
}