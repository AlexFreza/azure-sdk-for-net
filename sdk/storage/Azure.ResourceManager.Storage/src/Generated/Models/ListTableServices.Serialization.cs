// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ListTableServices
    {
        internal static ListTableServices DeserializeListTableServices(JsonElement element)
        {
            IReadOnlyList<TableServiceProperties> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TableServiceProperties> array = new List<TableServiceProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TableServiceProperties.DeserializeTableServiceProperties(item));
                        }
                    }
                    value = array;
                    continue;
                }
            }
            return new ListTableServices(value);
        }
    }
}
