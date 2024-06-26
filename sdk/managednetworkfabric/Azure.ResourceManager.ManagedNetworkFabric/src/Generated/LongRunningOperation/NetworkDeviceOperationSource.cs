// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class NetworkDeviceOperationSource : IOperationSource<NetworkDeviceResource>
    {
        private readonly ArmClient _client;

        internal NetworkDeviceOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkDeviceResource IOperationSource<NetworkDeviceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkDeviceData.DeserializeNetworkDeviceData(document.RootElement);
            return new NetworkDeviceResource(_client, data);
        }

        async ValueTask<NetworkDeviceResource> IOperationSource<NetworkDeviceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkDeviceData.DeserializeNetworkDeviceData(document.RootElement);
            return new NetworkDeviceResource(_client, data);
        }
    }
}
