// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace HoloToolkit.Sharing
{
    public class BoolElementLoopback : BoolElement
    {
        private bool value;
        private XString name;

        internal BoolElementLoopback(XString name, bool value) : base(IntPtr.Zero, false)
        {
            this.name = name;
            this.value = value;
        }

        public override bool GetValue()
        {
            return value;
        }

        public override void SetValue(bool newValue)
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
