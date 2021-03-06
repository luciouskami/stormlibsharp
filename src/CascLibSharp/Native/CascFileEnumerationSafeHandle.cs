﻿using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CascLibSharp.Native
{
    internal class CascFileEnumerationSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public CascFileEnumerationSafeHandle()
            : base(true) { }
        public CascFileEnumerationSafeHandle(IntPtr handle)
            : this()
        {
            SetHandle(handle);
        }

        protected override bool ReleaseHandle()
        {
            return NativeMethods.CascFindClose(DangerousGetHandle());
        }
    }
}
