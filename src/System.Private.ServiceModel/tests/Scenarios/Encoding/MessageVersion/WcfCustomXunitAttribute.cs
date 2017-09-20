// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Xunit;
using Xunit.Sdk;

namespace Infrastructure.Common
{
    [XunitTestCaseDiscoverer("Infrastructure.Common.WcfFactDiscoverer", "Encoding.MessageVersion.Tests")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class WcfFactAttribute : FactAttribute
    {
    }

    [XunitTestCaseDiscoverer("Infrastructure.Common.WcfTheoryDiscoverer", "Encoding.MessageVersion.Tests")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class WcfTheoryAttribute : TheoryAttribute
    {
    }
}
