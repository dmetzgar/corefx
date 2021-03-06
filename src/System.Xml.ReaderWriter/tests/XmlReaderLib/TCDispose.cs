﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;
using OLEDB.Test.ModuleCore;

namespace XmlReaderTest.Common
{
    public partial class TCDispose : TCXMLReaderBaseGeneral
    {
        // Type is XmlReaderTest.Common.TCDispose
        // Test Case
        public override void AddChildren()
        {
            // for function Variation1
            {
                this.AddChild(new CVariation(Variation1) { Attribute = new Variation("Test Integrity of all values after Dispose") });
            }


            // for function Variation2
            {
                this.AddChild(new CVariation(Variation2) { Attribute = new Variation("Call Dispose Multiple(3) Times") });
            }


            // for function Variation3
            {
                this.AddChild(new CVariation(Variation3) { Attribute = new Variation("Check Dispose with Exclusive Stream") });
            }
        }
    }
}
