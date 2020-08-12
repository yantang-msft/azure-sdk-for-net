// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class AzureMLWebServiceFile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("filePath");
            writer.WriteObjectValue(FilePath);
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            writer.WriteEndObject();
        }

        internal static AzureMLWebServiceFile DeserializeAzureMLWebServiceFile(JsonElement element)
        {
            object filePath = default;
            LinkedServiceReference linkedServiceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filePath"))
                {
                    filePath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
            }
            return new AzureMLWebServiceFile(filePath, linkedServiceName);
        }
    }
}