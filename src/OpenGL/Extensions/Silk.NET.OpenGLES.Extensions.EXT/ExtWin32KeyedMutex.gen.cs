// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_win32_keyed_mutex")]
    public abstract unsafe partial class ExtWin32KeyedMutex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_win32_keyed_mutex";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="key">
        /// To be added.
        /// </param>
        /// <param name="timeout">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glAcquireKeyedMutexWin32EXT")]
        public abstract bool AcquireKeyedMutexWin32([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong key, [Flow(FlowDirection.In)] uint timeout);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="key">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glReleaseKeyedMutexWin32EXT")]
        public abstract bool ReleaseKeyedMutexWin32([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong key);

        public ExtWin32KeyedMutex(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

