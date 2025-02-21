// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> A script name availability request. </summary>
    public partial class KustoScriptNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of KustoScriptNameAvailabilityContent. </summary>
        /// <param name="name"> Script name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public KustoScriptNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = KustoScriptType.MicrosoftKustoClustersDatabasesScripts;
        }

        /// <summary> Script name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, Microsoft.Kusto/clusters/databases/scripts. </summary>
        public KustoScriptType ResourceType { get; }
    }
}
