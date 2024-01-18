// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary>
    /// Recurrence object.
    /// Please note <see cref="AlertProcessingRuleRecurrence"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DailyRecurrence"/>, <see cref="AlertProcessingRuleMonthlyRecurrence"/> and <see cref="AlertProcessingRuleWeeklyRecurrence"/>.
    /// </summary>
    public abstract partial class AlertProcessingRuleRecurrence
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleRecurrence"/>. </summary>
        protected AlertProcessingRuleRecurrence()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleRecurrence"/>. </summary>
        /// <param name="recurrenceType"> Specifies when the recurrence should be applied. </param>
        /// <param name="startOn"> Start time for recurrence. </param>
        /// <param name="endOn"> End time for recurrence. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertProcessingRuleRecurrence(RecurrenceType recurrenceType, TimeSpan? startOn, TimeSpan? endOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RecurrenceType = recurrenceType;
            StartOn = startOn;
            EndOn = endOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies when the recurrence should be applied. </summary>
        internal RecurrenceType RecurrenceType { get; set; }
        /// <summary> Start time for recurrence. </summary>
        public TimeSpan? StartOn { get; set; }
        /// <summary> End time for recurrence. </summary>
        public TimeSpan? EndOn { get; set; }
    }
}
