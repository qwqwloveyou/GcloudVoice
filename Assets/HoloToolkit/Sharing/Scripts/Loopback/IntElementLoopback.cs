// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace HoloToolkit.Sharing
{
    public class IntElementLoopback : IntElement
    {
        private int value;
        private XString name;

        internal IntElementLoopback(XString name, int value) : base(IntPtr.Zero, false)
        {
            this.name = name;
            this.value = value;
        }

        public override int GetValue()
        {
            return value;
        }

        public override void SetValue(int newValue)
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
