// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of sensitivity labels. </summary>
    internal partial class SynapseSensitivityLabelListResult
    {
        /// <summary> Initializes a new instance of SynapseSensitivityLabelListResult. </summary>
        internal SynapseSensitivityLabelListResult()
        {
            Value = new ChangeTrackingList<SynapseSensitivityLabelData>();
        }

        /// <summary> Initializes a new instance of SynapseSensitivityLabelListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SynapseSensitivityLabelListResult(IReadOnlyList<SynapseSensitivityLabelData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseSensitivityLabelData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
