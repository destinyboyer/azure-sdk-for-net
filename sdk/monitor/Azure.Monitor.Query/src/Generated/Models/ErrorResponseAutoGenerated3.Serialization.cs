// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Monitor.Query.Models
{
    internal partial class ErrorResponseAutoGenerated3
    {
        internal static ErrorResponseAutoGenerated3 DeserializeErrorResponseAutoGenerated3(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ErrorInfo error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    error = ErrorInfo.DeserializeErrorInfo(property.Value);
                    continue;
                }
            }
            return new ErrorResponseAutoGenerated3(error);
        }
    }
}
