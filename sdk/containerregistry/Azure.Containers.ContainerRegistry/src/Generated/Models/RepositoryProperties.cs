// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Repository attributes. </summary>
    public partial class RepositoryProperties
    {
        /// <summary> Initializes a new instance of RepositoryProperties. </summary>
        internal RepositoryProperties()
        {
        }

        /// <summary> Initializes a new instance of RepositoryProperties. </summary>
        /// <param name="registry"> Registry name. </param>
        /// <param name="name"> Image name. </param>
        /// <param name="createdOn"> Image created time. </param>
        /// <param name="lastUpdatedOn"> Image last update time. </param>
        /// <param name="registryArtifactCount"> Number of the manifests. </param>
        /// <param name="tagCount"> Number of the tags. </param>
        /// <param name="modifiableProperties"> Changeable attributes. </param>
        internal RepositoryProperties(string registry, string name, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, int registryArtifactCount, int tagCount, ContentProperties modifiableProperties)
        {
            Registry = registry;
            Name = name;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            RegistryArtifactCount = registryArtifactCount;
            TagCount = tagCount;
            ModifiableProperties = modifiableProperties;
        }

        /// <summary> Registry name. </summary>
        public string Registry { get; }
    }
}
