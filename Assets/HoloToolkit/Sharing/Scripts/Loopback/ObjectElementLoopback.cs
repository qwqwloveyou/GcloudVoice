// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using UnityEngine;
using HoloToolkit.Sharing.Utilities;
using HoloToolkit.Unity;
using System.Collections.Generic;

namespace HoloToolkit.Sharing
{
    public class ObjectElementLoopback : ObjectElement
    {
        private IList<Element> elementArray;
        private XString name;

        internal ObjectElementLoopback(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn)
        {
            name = new XString("Root");
            elementArray = new List<Element>();
        }

        internal ObjectElementLoopback(XString name, XString objectType) : base(IntPtr.Zero, false)
        {
            this.name = name;
            elementArray = new List<Element>();
        }

        public override BoolElement CreateBoolElement(XString name, bool value)
        {
            return new BoolElementLoopback(name, value);
        }

        public override DoubleElement CreateDoubleElement(XString name, double value)
        {
            return new DoubleElementLoopback(name, value);
        }

        public override FloatElement CreateFloatElement(XString name, float value)
        {
            return new FloatElementLoopback(name, value);
        }

        public override IntElement CreateIntElement(XString name, int value)
        {
            return new IntElementLoopback(name, value);
        }

        public override LongElement CreateLongElement(XString name, long value)
        {
            return new LongElementLoopback(name, value);
        }

        public override StringElement CreateStringElement(XString name, XString value)
        {
            return new StringElementLoopback(name, value);
        }

        public override ObjectElement CreateObjectElement(XString name, XString objectType)
        {
            // TODO:
            return base.CreateObjectElement(name, objectType);
        }

        public override int GetElementCount()
        {
            return this.elementArray.Count;
        }

        public override Element GetElement(long id)
        {
            // TODO: 
            return base.GetElement(id);
        }

        public override Element GetElementAt(int index)
        {
            return this.elementArray[index];
        }

        public override Element GetElement(XString name)
        {
            // TODO: 
            return base.GetElement(name);
        }

        public override XString GetName()
        {
            return this.name;
        }

        public override ElementType GetElementType()
        {
            return ElementType.ObjectType;
        }
    }
}
