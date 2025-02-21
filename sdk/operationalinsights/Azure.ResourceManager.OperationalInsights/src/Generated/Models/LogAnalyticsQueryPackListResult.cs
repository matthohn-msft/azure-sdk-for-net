// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Describes the list of Log Analytics QueryPack resources. </summary>
    internal partial class LogAnalyticsQueryPackListResult
    {
        /// <summary> Initializes a new instance of LogAnalyticsQueryPackListResult. </summary>
        /// <param name="value"> List of Log Analytics QueryPack definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal LogAnalyticsQueryPackListResult(IEnumerable<LogAnalyticsQueryPackData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of LogAnalyticsQueryPackListResult. </summary>
        /// <param name="value"> List of Log Analytics QueryPack definitions. </param>
        /// <param name="nextLink"> The URI to get the next set of Log Analytics QueryPack definitions if too many QueryPacks where returned in the result set. </param>
        internal LogAnalyticsQueryPackListResult(IReadOnlyList<LogAnalyticsQueryPackData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Log Analytics QueryPack definitions. </summary>
        public IReadOnlyList<LogAnalyticsQueryPackData> Value { get; }
        /// <summary> The URI to get the next set of Log Analytics QueryPack definitions if too many QueryPacks where returned in the result set. </summary>
        public string NextLink { get; }
    }
}
