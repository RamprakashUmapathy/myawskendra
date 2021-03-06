/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// This is the response object from the DescribeHumanLoop operation.
    /// </summary>
    public partial class DescribeHumanLoopResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTimestamp;
        private string _failureCode;
        private string _failureReason;
        private string _flowDefinitionArn;
        private string _humanLoopArn;
        private HumanLoopInputContent _humanLoopInput;
        private string _humanLoopName;
        private HumanLoopOutputContent _humanLoopOutput;
        private HumanLoopStatus _humanLoopStatus;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The timestamp when Amazon Augmented AI created the human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTimestamp
        {
            get { return this._creationTimestamp.GetValueOrDefault(); }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// A failure code denoting a specific type of failure.
        /// </para>
        /// </summary>
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why a human loop has failed. The failure reason is returned when the human
        /// loop status is <code>Failed</code>.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property FlowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string FlowDefinitionArn
        {
            get { return this._flowDefinitionArn; }
            set { this._flowDefinitionArn = value; }
        }

        // Check to see if FlowDefinitionArn property is set
        internal bool IsSetFlowDefinitionArn()
        {
            return this._flowDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string HumanLoopArn
        {
            get { return this._humanLoopArn; }
            set { this._humanLoopArn = value; }
        }

        // Check to see if HumanLoopArn property is set
        internal bool IsSetHumanLoopArn()
        {
            return this._humanLoopArn != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopInput. 
        /// <para>
        /// An object containing information about the human loop input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HumanLoopInputContent HumanLoopInput
        {
            get { return this._humanLoopInput; }
            set { this._humanLoopInput = value; }
        }

        // Check to see if HumanLoopInput property is set
        internal bool IsSetHumanLoopInput()
        {
            return this._humanLoopInput != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopName. 
        /// <para>
        /// The name of the human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string HumanLoopName
        {
            get { return this._humanLoopName; }
            set { this._humanLoopName = value; }
        }

        // Check to see if HumanLoopName property is set
        internal bool IsSetHumanLoopName()
        {
            return this._humanLoopName != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopOutput. 
        /// <para>
        /// An object containing information about the output of the human loop.
        /// </para>
        /// </summary>
        public HumanLoopOutputContent HumanLoopOutput
        {
            get { return this._humanLoopOutput; }
            set { this._humanLoopOutput = value; }
        }

        // Check to see if HumanLoopOutput property is set
        internal bool IsSetHumanLoopOutput()
        {
            return this._humanLoopOutput != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopStatus. 
        /// <para>
        /// The status of the human loop. Valid values:
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HumanLoopStatus HumanLoopStatus
        {
            get { return this._humanLoopStatus; }
            set { this._humanLoopStatus = value; }
        }

        // Check to see if HumanLoopStatus property is set
        internal bool IsSetHumanLoopStatus()
        {
            return this._humanLoopStatus != null;
        }

    }
}