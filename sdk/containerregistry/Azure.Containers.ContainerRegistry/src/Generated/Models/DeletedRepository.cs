// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Deleted repository. </summary>
    internal partial class DeletedRepository
    {
        /// <summary> Initializes a new instance of DeletedRepository. </summary>
        internal DeletedRepository()
        {
            ManifestsDeleted = new ChangeTrackingList<string>();
            TagsDeleted = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DeletedRepository. </summary>
        /// <param name="manifestsDeleted"> SHA of the deleted image. </param>
        /// <param name="tagsDeleted"> Tag of the deleted image. </param>
        internal DeletedRepository(IReadOnlyList<string> manifestsDeleted, IReadOnlyList<string> tagsDeleted)
        {
            ManifestsDeleted = manifestsDeleted;
            TagsDeleted = tagsDeleted;
        }

        /// <summary> SHA of the deleted image. </summary>
        public IReadOnlyList<string> ManifestsDeleted { get; }
        /// <summary> Tag of the deleted image. </summary>
        public IReadOnlyList<string> TagsDeleted { get; }
    }
}
