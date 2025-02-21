﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// Options for closing a job.
    /// </summary>
    public partial class CloseJobOptions
    {
        /// <summary> Initializes a new instance of CloseJobOptions. </summary>
        internal CloseJobOptions()
        {
        }

        /// <param name="jobId"> Id of the job. </param>
        /// <param name="assignmentId"> Id of the assignment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="assignmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> or <paramref name="assignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        public CloseJobOptions(string jobId, string assignmentId)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));
            Argument.AssertNotNullOrEmpty(assignmentId, nameof(assignmentId));

            JobId = jobId;
            AssignmentId = assignmentId;
        }

        /// <summary> Id of the job assignment. </summary>
        public string AssignmentId { get; }

        /// <summary> Id of the job. </summary>
        public string JobId { get; }

        /// <summary> Reason code for cancelled or closed jobs. </summary>
        public string DispositionCode { get; set; }

        /// <summary>
        /// If not provided, worker capacity is released immediately along with a JobClosedEvent notification.
        /// If provided, worker capacity is released along with a JobClosedEvent notification at a future time in UTC.
        /// </summary>
        public DateTimeOffset CloseAt { get; set; }

        /// <summary>
        /// Custom supplied note.
        /// </summary>
        public string Note { get; set; }
    }
}
