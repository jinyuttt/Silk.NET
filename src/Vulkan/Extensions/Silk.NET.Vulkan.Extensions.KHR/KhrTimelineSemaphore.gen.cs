// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_timeline_semaphore")]
    public abstract unsafe partial class KhrTimelineSemaphore : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_timeline_semaphore";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValueKHR")]
        public abstract unsafe Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValueKHR")]
        public abstract Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pValue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphoreKHR")]
        public abstract unsafe Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreSignalInfo* pSignalInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphoreKHR")]
        public abstract Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreSignalInfo pSignalInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphoresKHR")]
        public abstract unsafe Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreWaitInfo* pWaitInfo, [Count(Count = 0)] ulong timeout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphoresKHR")]
        public abstract Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreWaitInfo pWaitInfo, [Count(Count = 0)] ulong timeout);

        public KhrTimelineSemaphore(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

