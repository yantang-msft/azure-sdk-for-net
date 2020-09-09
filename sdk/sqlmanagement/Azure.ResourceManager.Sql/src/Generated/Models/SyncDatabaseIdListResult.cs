// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of sync database ID properties. </summary>
    public partial class SyncDatabaseIdListResult
    {
        /// <summary> Initializes a new instance of SyncDatabaseIdListResult. </summary>
        internal SyncDatabaseIdListResult()
        {
            Value = new ChangeTrackingList<SyncDatabaseIdProperties>();
        }

        /// <summary> Initializes a new instance of SyncDatabaseIdListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SyncDatabaseIdListResult(IReadOnlyList<SyncDatabaseIdProperties> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SyncDatabaseIdProperties> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}