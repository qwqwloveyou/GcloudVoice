// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace HoloToolkit.Sharing
{
    public class LongElementLoopback : LongElement
    {
        private long value;
        private XString name;

        internal LongElementLoopback(XString name, long value) : base(IntPtr.Zero, false)
        {
            this.name = name;
            this.value = value;
        }

        public override long GetValue()
        {
            return value;
        }

        public override void SetValue(long newValue)
        {
            this.value = newValue;
        }

        public override XString GetName()
        {
            return this.name;
        }

        public override ElementType GetElementType()
        {
            return ElementType.BoolType;
        }
    }
}
