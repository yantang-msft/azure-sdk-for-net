// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A node that accepts raw video as input, and detects if there are moving
    /// objects present. If so, then it emits an event, and allows frames where
    /// motion was detected to pass through. Other frames are blocked/dropped.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.MediaGraphMotionDetectionProcessor")]
    public partial class MediaGraphMotionDetectionProcessor : MediaGraphProcessor
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MediaGraphMotionDetectionProcessor class.
        /// </summary>
        public MediaGraphMotionDetectionProcessor()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MediaGraphMotionDetectionProcessor class.
        /// </summary>
        /// <param name="name">The name for this processor node.</param>
        /// <param name="inputs">An array of the names of the other nodes in
        /// the media graph, the outputs of which are used as input for this
        /// processor node.</param>
        /// <param name="sensitivity">Enumeration that specifies the
        /// sensitivity of the motion detection processor. Possible values
        /// include: 'Low', 'Medium', 'High'</param>
        /// <param name="outputMotionRegion">Indicates whether the processor
        /// should detect and output the regions, within the video frame, where
        /// motion was detected. Default is true.</param>
        public MediaGraphMotionDetectionProcessor(string name, IList<MediaGraphNodeInput> inputs, string sensitivity = default(string), bool? outputMotionRegion = default(bool?))
            : base(name, inputs)
        {
            Sensitivity = sensitivity;
            OutputMotionRegion = outputMotionRegion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets enumeration that specifies the sensitivity of the
        /// motion detection processor. Possible values include: 'Low',
        /// 'Medium', 'High'
        /// </summary>
        [JsonProperty(PropertyName = "sensitivity")]
        public string Sensitivity { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the processor should detect and
        /// output the regions, within the video frame, where motion was
        /// detected. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "outputMotionRegion")]
        public bool? OutputMotionRegion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}