﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.DotNet.Tools.Uninstall.Shared.Exceptions
{
    internal abstract class DotNetUninstallException : Exception
    {
        public DotNetUninstallException(string message) : base(message) { }
    }
}
