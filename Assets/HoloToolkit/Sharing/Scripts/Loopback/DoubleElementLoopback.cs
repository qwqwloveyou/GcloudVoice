// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace HoloToolkit.Sharing
{
    public class DoubleElementLoopback : DoubleElement
    {
        private double value;
        private XString name;

        internal DoubleElementLoopback(XString name, double value) : base(IntPtr.Zero, false)
        {
            this.name = name;
            this.value = value;
        }

        public override double GetValue()
        {
            return value;
        }

        public override void SetValue(double newValue)
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
