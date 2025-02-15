// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Diagnostics.Repl;
using System.CommandLine;
using System.Threading.Tasks;

namespace Microsoft.Diagnostics.Tools.Dump
{
    [Command(Name = "exit", Help = "Exit interactive mode.")]
    [CommandAlias(Name = "quit")]
    public class ExitCommand : CommandBase
    {
        public ConsoleProvider ConsoleProvider { get; set; }

        public override void Invoke()
        {
            ConsoleProvider.Stop();
        }
    }
}
