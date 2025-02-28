// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The workflow trigger recurrence for ComputeStartStop schedule type. </summary>
    public partial class ComputeStartStopRecurrenceSchedule
    {
        /// <summary> Initializes a new instance of ComputeStartStopRecurrenceSchedule. </summary>
        public ComputeStartStopRecurrenceSchedule()
        {
        }

        /// <summary> Initializes a new instance of ComputeStartStopRecurrenceSchedule. </summary>
        /// <param name="frequency"> [Required] The frequency to trigger schedule. </param>
        /// <param name="interval"> [Required] Specifies schedule interval in conjunction with frequency. </param>
        /// <param name="startTime"> The start time in yyyy-MM-ddTHH:mm:ss format. </param>
        /// <param name="timeZone">
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </param>
        /// <param name="schedule"> [Required] The recurrence schedule. </param>
        internal ComputeStartStopRecurrenceSchedule(MachineLearningRecurrenceFrequency? frequency, int? interval, string startTime, string timeZone, MachineLearningRecurrenceSchedule schedule)
        {
            Frequency = frequency;
            Interval = interval;
            StartTime = startTime;
            TimeZone = timeZone;
            Schedule = schedule;
        }

        /// <summary> [Required] The frequency to trigger schedule. </summary>
        public MachineLearningRecurrenceFrequency? Frequency { get; set; }
        /// <summary> [Required] Specifies schedule interval in conjunction with frequency. </summary>
        public int? Interval { get; set; }
        /// <summary> The start time in yyyy-MM-ddTHH:mm:ss format. </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </summary>
        public string TimeZone { get; set; }
        /// <summary> [Required] The recurrence schedule. </summary>
        public MachineLearningRecurrenceSchedule Schedule { get; set; }
    }
}
