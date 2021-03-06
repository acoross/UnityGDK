// ===========
// DO NOT EDIT - this file is automatically regenerated.
// ===========

using UnityEngine;
using Improbable.Gdk.Core;

namespace Generated.Improbable.Gdk.Tests
{ 
    public class SpatialOSExhaustiveSingular : Component, ISpatialComponentData
    {
        public BlittableBool DirtyBit { get; set; }

        private BlittableBool field1;

        public BlittableBool Field1
        {
            get { return field1; }
            set
            {
                DirtyBit = true;
                field1 = value;
            }
        }

        private float field2;

        public float Field2
        {
            get { return field2; }
            set
            {
                DirtyBit = true;
                field2 = value;
            }
        }

        private int field4;

        public int Field4
        {
            get { return field4; }
            set
            {
                DirtyBit = true;
                field4 = value;
            }
        }

        private long field5;

        public long Field5
        {
            get { return field5; }
            set
            {
                DirtyBit = true;
                field5 = value;
            }
        }

        private double field6;

        public double Field6
        {
            get { return field6; }
            set
            {
                DirtyBit = true;
                field6 = value;
            }
        }

        private string field7;

        public string Field7
        {
            get { return field7; }
            set
            {
                DirtyBit = true;
                field7 = value;
            }
        }

        private uint field8;

        public uint Field8
        {
            get { return field8; }
            set
            {
                DirtyBit = true;
                field8 = value;
            }
        }

        private ulong field9;

        public ulong Field9
        {
            get { return field9; }
            set
            {
                DirtyBit = true;
                field9 = value;
            }
        }

        private int field10;

        public int Field10
        {
            get { return field10; }
            set
            {
                DirtyBit = true;
                field10 = value;
            }
        }

        private long field11;

        public long Field11
        {
            get { return field11; }
            set
            {
                DirtyBit = true;
                field11 = value;
            }
        }

        private uint field12;

        public uint Field12
        {
            get { return field12; }
            set
            {
                DirtyBit = true;
                field12 = value;
            }
        }

        private ulong field13;

        public ulong Field13
        {
            get { return field13; }
            set
            {
                DirtyBit = true;
                field13 = value;
            }
        }

        private int field14;

        public int Field14
        {
            get { return field14; }
            set
            {
                DirtyBit = true;
                field14 = value;
            }
        }

        private long field15;

        public long Field15
        {
            get { return field15; }
            set
            {
                DirtyBit = true;
                field15 = value;
            }
        }

        private long field16;

        public long Field16
        {
            get { return field16; }
            set
            {
                DirtyBit = true;
                field16 = value;
            }
        }

        private global::Generated.Improbable.Gdk.Tests.SomeType field17;

        public global::Generated.Improbable.Gdk.Tests.SomeType Field17
        {
            get { return field17; }
            set
            {
                DirtyBit = true;
                field17 = value;
            }
        }

        public struct Update : ISpatialComponentUpdate
        {
            public Option<BlittableBool> Field1;
            public Option<float> Field2;
            public Option<int> Field4;
            public Option<long> Field5;
            public Option<double> Field6;
            public Option<string> Field7;
            public Option<uint> Field8;
            public Option<ulong> Field9;
            public Option<int> Field10;
            public Option<long> Field11;
            public Option<uint> Field12;
            public Option<ulong> Field13;
            public Option<int> Field14;
            public Option<long> Field15;
            public Option<long> Field16;
            public Option<global::Generated.Improbable.Gdk.Tests.SomeType> Field17;
        }
    }
}
