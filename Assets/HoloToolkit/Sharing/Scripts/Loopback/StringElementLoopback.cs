// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace HoloToolkit.Sharing
{
    public class StringElementLoopback : StringElement
    {
        private XString value;
        private XString name;

        internal StringElementLoopback(XString name, XString value) : base(IntPtr.Zero, false)
        {
            this.name = name;
            this.value = value;
        }

        public override XString GetValue()
        {
            return value;
        }

        public override void SetValue(XString newValue)
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
