// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkSessionState
    {
        internal static SparkSessionState DeserializeSparkSessionState(JsonElement element)
        {
            Optional<DateTimeOffset> notStartedAt = default;
            Optional<DateTimeOffset> startingAt = default;
            Optional<DateTimeOffset> idleAt = default;
            Optional<DateTimeOffset> deadAt = default;
            Optional<DateTimeOffset> shuttingDownAt = default;
            Optional<DateTimeOffset> killedAt = default;
            Optional<DateTimeOffset> recoveringAt = default;
            Optional<DateTimeOffset> busyAt = default;
            Optional<DateTimeOffset> errorAt = default;
            Optional<string> currentState = default;
            Optional<SparkRequest> jobCreationRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notStartedAt"))
                {
                    notStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startingAt"))
                {
                    startingAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("idleAt"))
                {
                    idleAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deadAt"))
                {
                    deadAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("shuttingDownAt"))
                {
                    shuttingDownAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("killedAt"))
                {
                    killedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveringAt"))
                {
                    recoveringAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("busyAt"))
                {
                    busyAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errorAt"))
                {
                    errorAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"))
                {
                    currentState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobCreationRequest"))
                {
                    jobCreationRequest = SparkRequest.DeserializeSparkRequest(property.Value);
                    continue;
                }
            }
            return new SparkSessionState(Optional.ToNullable(notStartedAt), Optional.ToNullable(startingAt), Optional.ToNullable(idleAt), Optional.ToNullable(deadAt), Optional.ToNullable(shuttingDownAt), Optional.ToNullable(killedAt), Optional.ToNullable(recoveringAt), Optional.ToNullable(busyAt), Optional.ToNullable(errorAt), currentState.Value, jobCreationRequest.Value);
        }
    }
}