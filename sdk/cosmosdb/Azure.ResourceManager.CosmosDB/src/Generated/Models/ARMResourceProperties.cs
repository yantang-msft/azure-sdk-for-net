// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The core properties of ARM resources. </summary>
    public partial class ARMResourceProperties
    {
        /// <summary> Initializes a new instance of ARMResourceProperties. </summary>
        public ARMResourceProperties()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ARMResourceProperties. </summary>
        /// <param name="id"> The unique resource identifier of the ARM resource. </param>
        /// <param name="name"> The name of the ARM resource. </param>
        /// <param name="type"> The type of Azure resource. </param>
        /// <param name="location"> The location of the resource group to which the resource belongs. </param>
        /// <param name="tags"> Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with &quot;defaultExperience&quot;: &quot;Cassandra&quot;. Current &quot;defaultExperience&quot; values also include &quot;Table&quot;, &quot;Graph&quot;, &quot;DocumentDB&quot;, and &quot;MongoDB&quot;. </param>
        internal ARMResourceProperties(string id, string name, string type, string location, IDictionary<string, string> tags)
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
        }

        /// <summary> The unique resource identifier of the ARM resource. </summary>
        public string Id { get; }
        /// <summary> The name of the ARM resource. </summary>
        public string Name { get; }
        /// <summary> The type of Azure resource. </summary>
        public string Type { get; }
        /// <summary> The location of the resource group to which the resource belongs. </summary>
        public string Location { get; set; }
        /// <summary> Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with &quot;defaultExperience&quot;: &quot;Cassandra&quot;. Current &quot;defaultExperience&quot; values also include &quot;Table&quot;, &quot;Graph&quot;, &quot;DocumentDB&quot;, and &quot;MongoDB&quot;. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}