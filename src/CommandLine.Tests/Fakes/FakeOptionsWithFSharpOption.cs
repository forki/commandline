﻿// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See doc/License.md in the project root for license information.

using Microsoft.FSharp.Core;

namespace CommandLine.Tests.Fakes
{
    class FakeOptionsWithFSharpOption
    {
        [Option]
        public FSharpOption<string> FileName { get; set; }

        [Value(0)]
        public FSharpOption<int> Offset { get; set; }
    }
}
