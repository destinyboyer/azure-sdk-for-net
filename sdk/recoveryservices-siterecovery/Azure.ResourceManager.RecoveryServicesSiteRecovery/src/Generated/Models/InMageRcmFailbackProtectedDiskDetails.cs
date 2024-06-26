// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcmFailback protected disk details. </summary>
    public partial class InMageRcmFailbackProtectedDiskDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackProtectedDiskDetails"/>. </summary>
        internal InMageRcmFailbackProtectedDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackProtectedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id (reported by source agent). </param>
        /// <param name="diskName"> The disk name. </param>
        /// <param name="isOSDisk"> A value indicating whether the disk is the OS disk. </param>
        /// <param name="capacityInBytes"> The disk capacity in bytes. </param>
        /// <param name="diskUuid"> The disk Uuid (reported by vCenter). </param>
        /// <param name="dataPendingInLogDataStoreInMB"> The data pending in log data store in MB. </param>
        /// <param name="dataPendingAtSourceAgentInMB"> The data pending at source agent in MB. </param>
        /// <param name="isInitialReplicationComplete"> A value indicating whether initial replication is complete or not. </param>
        /// <param name="irDetails"> The initial replication details. </param>
        /// <param name="resyncDetails"> The resync details. </param>
        /// <param name="lastSyncedOn"> The last sync time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmFailbackProtectedDiskDetails(string diskId, string diskName, string isOSDisk, long? capacityInBytes, string diskUuid, double? dataPendingInLogDataStoreInMB, double? dataPendingAtSourceAgentInMB, string isInitialReplicationComplete, InMageRcmFailbackSyncDetails irDetails, InMageRcmFailbackSyncDetails resyncDetails, DateTimeOffset? lastSyncedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            DiskName = diskName;
            IsOSDisk = isOSDisk;
            CapacityInBytes = capacityInBytes;
            DiskUuid = diskUuid;
            DataPendingInLogDataStoreInMB = dataPendingInLogDataStoreInMB;
            DataPendingAtSourceAgentInMB = dataPendingAtSourceAgentInMB;
            IsInitialReplicationComplete = isInitialReplicationComplete;
            IrDetails = irDetails;
            ResyncDetails = resyncDetails;
            LastSyncedOn = lastSyncedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The disk Id (reported by source agent). </summary>
        public string DiskId { get; }
        /// <summary> The disk name. </summary>
        public string DiskName { get; }
        /// <summary> A value indicating whether the disk is the OS disk. </summary>
        public string IsOSDisk { get; }
        /// <summary> The disk capacity in bytes. </summary>
        public long? CapacityInBytes { get; }
        /// <summary> The disk Uuid (reported by vCenter). </summary>
        public string DiskUuid { get; }
        /// <summary> The data pending in log data store in MB. </summary>
        public double? DataPendingInLogDataStoreInMB { get; }
        /// <summary> The data pending at source agent in MB. </summary>
        public double? DataPendingAtSourceAgentInMB { get; }
        /// <summary> A value indicating whether initial replication is complete or not. </summary>
        public string IsInitialReplicationComplete { get; }
        /// <summary> The initial replication details. </summary>
        public InMageRcmFailbackSyncDetails IrDetails { get; }
        /// <summary> The resync details. </summary>
        public InMageRcmFailbackSyncDetails ResyncDetails { get; }
        /// <summary> The last sync time. </summary>
        public DateTimeOffset? LastSyncedOn { get; }
    }
}
