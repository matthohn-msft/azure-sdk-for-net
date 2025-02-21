// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The list tables operation response. </summary>
    internal partial class TablesListResult
    {
        /// <summary> Initializes a new instance of TablesListResult. </summary>
        internal TablesListResult()
        {
            Value = new ChangeTrackingList<OperationalInsightsTableData>();
        }

        /// <summary> Initializes a new instance of TablesListResult. </summary>
        /// <param name="value"> A list of data tables. </param>
        internal TablesListResult(IReadOnlyList<OperationalInsightsTableData> value)
        {
            Value = value;
        }

        /// <summary> A list of data tables. </summary>
        public IReadOnlyList<OperationalInsightsTableData> Value { get; }
    }
}
