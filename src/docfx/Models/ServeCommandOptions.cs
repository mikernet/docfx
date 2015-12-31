// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DocAsCode
{
    using CommandLine;

    internal class ServeCommandOptions : IHasHelp
    {
        [ValueOption(0)]
        public string Folder { get; set; }

        [Option('p', "port", HelpText = "Specify the port of the hosted website [8080]")]
        public int? Port { get; set; }

        [Option('h', "help", HelpText = "Print help message for this sub-command")]
        public bool IsHelp { get; set; }
    }
}
