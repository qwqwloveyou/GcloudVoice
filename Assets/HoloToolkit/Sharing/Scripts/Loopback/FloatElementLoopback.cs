// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace HoloToolkit.Sharing
{
    public class FloatElementLoopback : FloatElement
    {
        private float value;
        private XString name;

        internal FloatElementLoopback(XString name, float value) : base(IntPtr.Zero, false)
        {
            this.name = name;
            this.value = value;
        }

        public override float GetValue()
        {
            return value;
        }

        public override void SetValue(float newValue)
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
