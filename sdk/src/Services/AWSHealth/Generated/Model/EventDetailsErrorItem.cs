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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EventDetailsErrorItem
    {
        private string _errorMessage;
        private string _errorName;
        private string _eventArn;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorName. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string ErrorName
        {
            get { return this._errorName; }
            set { this._errorName = value; }
        }

        // Check to see if ErrorName property is set
        internal bool IsSetErrorName()
        {
            return this._errorName != null;
        }

        /// <summary>
        /// Gets and sets the property EventArn. 
        /// <para>
        /// The unique identifier for the event. Format: <code>arn:aws:silvermine:<i>event-region</i>::event/<i>EVENT_ID</i>
        /// </code>. Example: <code>arn:aws:silvermine:us-east-1::event/EC2_MAINTENANCE_5331</code>
        /// 
        /// </para>
        /// </summary>
        public string EventArn
        {
            get { return this._eventArn; }
            set { this._eventArn = value; }
        }

        // Check to see if EventArn property is set
        internal bool IsSetEventArn()
        {
            return this._eventArn != null;
        }

    }
}