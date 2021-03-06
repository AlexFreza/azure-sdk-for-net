// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteCircuit : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (AllowClassicOperations != null)
            {
                writer.WritePropertyName("allowClassicOperations");
                writer.WriteBooleanValue(AllowClassicOperations.Value);
            }
            if (CircuitProvisioningState != null)
            {
                writer.WritePropertyName("circuitProvisioningState");
                writer.WriteStringValue(CircuitProvisioningState);
            }
            if (ServiceProviderProvisioningState != null)
            {
                writer.WritePropertyName("serviceProviderProvisioningState");
                writer.WriteStringValue(ServiceProviderProvisioningState.Value.ToString());
            }
            if (Authorizations != null)
            {
                writer.WritePropertyName("authorizations");
                writer.WriteStartArray();
                foreach (var item in Authorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Peerings != null)
            {
                writer.WritePropertyName("peerings");
                writer.WriteStartArray();
                foreach (var item in Peerings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ServiceKey != null)
            {
                writer.WritePropertyName("serviceKey");
                writer.WriteStringValue(ServiceKey);
            }
            if (ServiceProviderNotes != null)
            {
                writer.WritePropertyName("serviceProviderNotes");
                writer.WriteStringValue(ServiceProviderNotes);
            }
            if (ServiceProviderProperties != null)
            {
                writer.WritePropertyName("serviceProviderProperties");
                writer.WriteObjectValue(ServiceProviderProperties);
            }
            if (ExpressRoutePort != null)
            {
                writer.WritePropertyName("expressRoutePort");
                writer.WriteObjectValue(ExpressRoutePort);
            }
            if (BandwidthInGbps != null)
            {
                writer.WritePropertyName("bandwidthInGbps");
                writer.WriteNumberValue(BandwidthInGbps.Value);
            }
            if (Stag != null)
            {
                writer.WritePropertyName("stag");
                writer.WriteNumberValue(Stag.Value);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (GatewayManagerEtag != null)
            {
                writer.WritePropertyName("gatewayManagerEtag");
                writer.WriteStringValue(GatewayManagerEtag);
            }
            if (GlobalReachEnabled != null)
            {
                writer.WritePropertyName("globalReachEnabled");
                writer.WriteBooleanValue(GlobalReachEnabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteCircuit DeserializeExpressRouteCircuit(JsonElement element)
        {
            ExpressRouteCircuitSku sku = default;
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            string location = default;
            IDictionary<string, string> tags = default;
            bool? allowClassicOperations = default;
            string circuitProvisioningState = default;
            ServiceProviderProvisioningState? serviceProviderProvisioningState = default;
            IList<ExpressRouteCircuitAuthorization> authorizations = default;
            IList<ExpressRouteCircuitPeering> peerings = default;
            string serviceKey = default;
            string serviceProviderNotes = default;
            ExpressRouteCircuitServiceProviderProperties serviceProviderProperties = default;
            SubResource expressRoutePort = default;
            float? bandwidthInGbps = default;
            int? stag = default;
            ProvisioningState? provisioningState = default;
            string gatewayManagerEtag = default;
            bool? globalReachEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ExpressRouteCircuitSku.DeserializeExpressRouteCircuitSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("allowClassicOperations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowClassicOperations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("circuitProvisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            circuitProvisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderProvisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceProviderProvisioningState = new ServiceProviderProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authorizations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteCircuitAuthorization> array = new List<ExpressRouteCircuitAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ExpressRouteCircuitAuthorization.DeserializeExpressRouteCircuitAuthorization(item));
                                }
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("peerings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteCircuitPeering> array = new List<ExpressRouteCircuitPeering>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ExpressRouteCircuitPeering.DeserializeExpressRouteCircuitPeering(item));
                                }
                            }
                            peerings = array;
                            continue;
                        }
                        if (property0.NameEquals("serviceKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderNotes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceProviderNotes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceProviderProperties = ExpressRouteCircuitServiceProviderProperties.DeserializeExpressRouteCircuitServiceProviderProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("expressRoutePort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRoutePort = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bandwidthInGbps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bandwidthInGbps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("stag"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stag = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("gatewayManagerEtag"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gatewayManagerEtag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("globalReachEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            globalReachEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteCircuit(id, name, type, location, tags, sku, etag, allowClassicOperations, circuitProvisioningState, serviceProviderProvisioningState, authorizations, peerings, serviceKey, serviceProviderNotes, serviceProviderProperties, expressRoutePort, bandwidthInGbps, stag, provisioningState, gatewayManagerEtag, globalReachEnabled);
        }
    }
}
