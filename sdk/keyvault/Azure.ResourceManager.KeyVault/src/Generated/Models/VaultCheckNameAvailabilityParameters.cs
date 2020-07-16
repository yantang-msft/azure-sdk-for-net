// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The parameters used to check the availability of the vault name. </summary>
    public partial class VaultCheckNameAvailabilityParameters
    {
        /// <summary> Initializes a new instance of VaultCheckNameAvailabilityParameters. </summary>
        /// <param name="name"> The vault name. </param>
        public VaultCheckNameAvailabilityParameters(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Type = "Microsoft.KeyVault/vaults";
        }

        /// <summary> The vault name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, Microsoft.KeyVault/vaults. </summary>
        public string Type { get; }
    }
}