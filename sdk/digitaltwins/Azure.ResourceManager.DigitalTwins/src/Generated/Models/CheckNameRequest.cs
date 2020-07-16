// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The result returned from a database check name availability request. </summary>
    public partial class CheckNameRequest
    {
        /// <summary> Initializes a new instance of CheckNameRequest. </summary>
        /// <param name="name"> Resource name. </param>
        public CheckNameRequest(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Type = "Microsoft.DigitalTwins/digitalTwinsInstances";
        }

        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, for instance Microsoft.DigitalTwins/digitalTwinsInstances. </summary>
        public string Type { get; }
    }
}