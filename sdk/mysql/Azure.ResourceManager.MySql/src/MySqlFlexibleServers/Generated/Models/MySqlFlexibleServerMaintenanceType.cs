// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> The type of this maintenance. </summary>
    public readonly partial struct MySqlFlexibleServerMaintenanceType : IEquatable<MySqlFlexibleServerMaintenanceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerMaintenanceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MySqlFlexibleServerMaintenanceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RoutineMaintenanceValue = "RoutineMaintenance";
        private const string MinorVersionUpgradeValue = "MinorVersionUpgrade";
        private const string SecurityPatchesValue = "SecurityPatches";
        private const string HotFixesValue = "HotFixes";

        /// <summary> RoutineMaintenance. </summary>
        public static MySqlFlexibleServerMaintenanceType RoutineMaintenance { get; } = new MySqlFlexibleServerMaintenanceType(RoutineMaintenanceValue);
        /// <summary> MinorVersionUpgrade. </summary>
        public static MySqlFlexibleServerMaintenanceType MinorVersionUpgrade { get; } = new MySqlFlexibleServerMaintenanceType(MinorVersionUpgradeValue);
        /// <summary> SecurityPatches. </summary>
        public static MySqlFlexibleServerMaintenanceType SecurityPatches { get; } = new MySqlFlexibleServerMaintenanceType(SecurityPatchesValue);
        /// <summary> HotFixes. </summary>
        public static MySqlFlexibleServerMaintenanceType HotFixes { get; } = new MySqlFlexibleServerMaintenanceType(HotFixesValue);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerMaintenanceType"/> values are the same. </summary>
        public static bool operator ==(MySqlFlexibleServerMaintenanceType left, MySqlFlexibleServerMaintenanceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerMaintenanceType"/> values are not the same. </summary>
        public static bool operator !=(MySqlFlexibleServerMaintenanceType left, MySqlFlexibleServerMaintenanceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MySqlFlexibleServerMaintenanceType"/>. </summary>
        public static implicit operator MySqlFlexibleServerMaintenanceType(string value) => new MySqlFlexibleServerMaintenanceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MySqlFlexibleServerMaintenanceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MySqlFlexibleServerMaintenanceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
