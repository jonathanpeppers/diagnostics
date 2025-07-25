// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Microsoft.Diagnostics.NETCore.Client
{
    public class DiagnosticsClientException : Exception
    {
        public DiagnosticsClientException(string msg) : base(msg) { }
        public DiagnosticsClientException(string msg, Exception exception) : base(msg, exception) { }
    }

    // When a certian command is not supported by either the library or the target process' runtime
    public class UnsupportedProtocolException : DiagnosticsClientException
    {
        public UnsupportedProtocolException(string msg) : base(msg) { }
    }

    // When the runtime is no longer availble for attaching.
    public class ServerNotAvailableException : DiagnosticsClientException
    {
        public ServerNotAvailableException(string msg) : base(msg) { }
        public ServerNotAvailableException(string msg, Exception exception) : base(msg, exception) { }
    }

    // When the runtime responded with an error
    public class ServerErrorException : DiagnosticsClientException
    {
        public ServerErrorException(string msg) : base(msg) { }
    }

    // When the runtime doesn't support the command
    public class UnsupportedCommandException : ServerErrorException
    {
        public UnsupportedCommandException(string msg) : base(msg) { }
    }

    // When the runtime already has loaded profiler
    public class ProfilerAlreadyActiveException : ServerErrorException
    {
        public ProfilerAlreadyActiveException(string msg) : base(msg) { }
    }
}
