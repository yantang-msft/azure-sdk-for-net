// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Sync state of the sync member. </summary>
    public readonly partial struct SyncMemberState : IEquatable<SyncMemberState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SyncMemberState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SyncMemberState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SyncInProgressValue = "SyncInProgress";
        private const string SyncSucceededValue = "SyncSucceeded";
        private const string SyncFailedValue = "SyncFailed";
        private const string DisabledTombstoneCleanupValue = "DisabledTombstoneCleanup";
        private const string DisabledBackupRestoreValue = "DisabledBackupRestore";
        private const string SyncSucceededWithWarningsValue = "SyncSucceededWithWarnings";
        private const string SyncCancellingValue = "SyncCancelling";
        private const string SyncCancelledValue = "SyncCancelled";
        private const string UnProvisionedValue = "UnProvisioned";
        private const string ProvisioningValue = "Provisioning";
        private const string ProvisionedValue = "Provisioned";
        private const string ProvisionFailedValue = "ProvisionFailed";
        private const string DeProvisioningValue = "DeProvisioning";
        private const string DeProvisionedValue = "DeProvisioned";
        private const string DeProvisionFailedValue = "DeProvisionFailed";
        private const string ReprovisioningValue = "Reprovisioning";
        private const string ReprovisionFailedValue = "ReprovisionFailed";
        private const string UnReprovisionedValue = "UnReprovisioned";

        /// <summary> SyncInProgress. </summary>
        public static SyncMemberState SyncInProgress { get; } = new SyncMemberState(SyncInProgressValue);
        /// <summary> SyncSucceeded. </summary>
        public static SyncMemberState SyncSucceeded { get; } = new SyncMemberState(SyncSucceededValue);
        /// <summary> SyncFailed. </summary>
        public static SyncMemberState SyncFailed { get; } = new SyncMemberState(SyncFailedValue);
        /// <summary> DisabledTombstoneCleanup. </summary>
        public static SyncMemberState DisabledTombstoneCleanup { get; } = new SyncMemberState(DisabledTombstoneCleanupValue);
        /// <summary> DisabledBackupRestore. </summary>
        public static SyncMemberState DisabledBackupRestore { get; } = new SyncMemberState(DisabledBackupRestoreValue);
        /// <summary> SyncSucceededWithWarnings. </summary>
        public static SyncMemberState SyncSucceededWithWarnings { get; } = new SyncMemberState(SyncSucceededWithWarningsValue);
        /// <summary> SyncCancelling. </summary>
        public static SyncMemberState SyncCancelling { get; } = new SyncMemberState(SyncCancellingValue);
        /// <summary> SyncCancelled. </summary>
        public static SyncMemberState SyncCancelled { get; } = new SyncMemberState(SyncCancelledValue);
        /// <summary> UnProvisioned. </summary>
        public static SyncMemberState UnProvisioned { get; } = new SyncMemberState(UnProvisionedValue);
        /// <summary> Provisioning. </summary>
        public static SyncMemberState Provisioning { get; } = new SyncMemberState(ProvisioningValue);
        /// <summary> Provisioned. </summary>
        public static SyncMemberState Provisioned { get; } = new SyncMemberState(ProvisionedValue);
        /// <summary> ProvisionFailed. </summary>
        public static SyncMemberState ProvisionFailed { get; } = new SyncMemberState(ProvisionFailedValue);
        /// <summary> DeProvisioning. </summary>
        public static SyncMemberState DeProvisioning { get; } = new SyncMemberState(DeProvisioningValue);
        /// <summary> DeProvisioned. </summary>
        public static SyncMemberState DeProvisioned { get; } = new SyncMemberState(DeProvisionedValue);
        /// <summary> DeProvisionFailed. </summary>
        public static SyncMemberState DeProvisionFailed { get; } = new SyncMemberState(DeProvisionFailedValue);
        /// <summary> Reprovisioning. </summary>
        public static SyncMemberState Reprovisioning { get; } = new SyncMemberState(ReprovisioningValue);
        /// <summary> ReprovisionFailed. </summary>
        public static SyncMemberState ReprovisionFailed { get; } = new SyncMemberState(ReprovisionFailedValue);
        /// <summary> UnReprovisioned. </summary>
        public static SyncMemberState UnReprovisioned { get; } = new SyncMemberState(UnReprovisionedValue);
        /// <summary> Determines if two <see cref="SyncMemberState"/> values are the same. </summary>
        public static bool operator ==(SyncMemberState left, SyncMemberState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SyncMemberState"/> values are not the same. </summary>
        public static bool operator !=(SyncMemberState left, SyncMemberState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SyncMemberState"/>. </summary>
        public static implicit operator SyncMemberState(string value) => new SyncMemberState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SyncMemberState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SyncMemberState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}