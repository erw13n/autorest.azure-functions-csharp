// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Storage.Management.Models
{
    /// <summary> The resource model definition for a ARM tracked top level resource. </summary>
    public partial class TrackedResource : Resource
    {
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public string Location { get; set; }
    }
}
