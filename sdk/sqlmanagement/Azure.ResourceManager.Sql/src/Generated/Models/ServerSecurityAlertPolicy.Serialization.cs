// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ServerSecurityAlertPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(DisabledAlerts))
            {
                writer.WritePropertyName("disabledAlerts");
                writer.WriteStartArray();
                foreach (var item in DisabledAlerts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EmailAddresses))
            {
                writer.WritePropertyName("emailAddresses");
                writer.WriteStartArray();
                foreach (var item in EmailAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EmailAccountAdmins))
            {
                writer.WritePropertyName("emailAccountAdmins");
                writer.WriteBooleanValue(EmailAccountAdmins.Value);
            }
            if (Optional.IsDefined(StorageEndpoint))
            {
                writer.WritePropertyName("storageEndpoint");
                writer.WriteStringValue(StorageEndpoint);
            }
            if (Optional.IsDefined(StorageAccountAccessKey))
            {
                writer.WritePropertyName("storageAccountAccessKey");
                writer.WriteStringValue(StorageAccountAccessKey);
            }
            if (Optional.IsDefined(RetentionDays))
            {
                writer.WritePropertyName("retentionDays");
                writer.WriteNumberValue(RetentionDays.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServerSecurityAlertPolicy DeserializeServerSecurityAlertPolicy(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<SecurityAlertPolicyState> state = default;
            Optional<IList<string>> disabledAlerts = default;
            Optional<IList<string>> emailAddresses = default;
            Optional<bool> emailAccountAdmins = default;
            Optional<string> storageEndpoint = default;
            Optional<string> storageAccountAccessKey = default;
            Optional<int> retentionDays = default;
            Optional<DateTimeOffset> creationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"))
                        {
                            state = property0.Value.GetString().ToSecurityAlertPolicyState();
                            continue;
                        }
                        if (property0.NameEquals("disabledAlerts"))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            disabledAlerts = array;
                            continue;
                        }
                        if (property0.NameEquals("emailAddresses"))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            emailAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("emailAccountAdmins"))
                        {
                            emailAccountAdmins = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageEndpoint"))
                        {
                            storageEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountAccessKey"))
                        {
                            storageAccountAccessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retentionDays"))
                        {
                            retentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServerSecurityAlertPolicy(id.Value, name.Value, type.Value, Optional.ToNullable(state), Optional.ToList(disabledAlerts), Optional.ToList(emailAddresses), Optional.ToNullable(emailAccountAdmins), storageEndpoint.Value, storageAccountAccessKey.Value, Optional.ToNullable(retentionDays), Optional.ToNullable(creationTime));
        }
    }
}