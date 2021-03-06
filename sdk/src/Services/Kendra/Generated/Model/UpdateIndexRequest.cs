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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIndex operation.
    /// Updates an existing Amazon Kendra index.
    /// </summary>
    public partial class UpdateIndexRequest : AmazonKendraRequest
    {
        private string _description;
        private List<DocumentMetadataConfiguration> _documentMetadataConfigurationUpdates = new List<DocumentMetadataConfiguration>();
        private string _id;
        private string _name;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentMetadataConfigurationUpdates. 
        /// <para>
        /// The document metadata to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<DocumentMetadataConfiguration> DocumentMetadataConfigurationUpdates
        {
            get { return this._documentMetadataConfigurationUpdates; }
            set { this._documentMetadataConfigurationUpdates = value; }
        }

        // Check to see if DocumentMetadataConfigurationUpdates property is set
        internal bool IsSetDocumentMetadataConfigurationUpdates()
        {
            return this._documentMetadataConfigurationUpdates != null && this._documentMetadataConfigurationUpdates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the index to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the index to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// A new IAM role that gives Amazon Kendra permission to access your Amazon CloudWatch
        /// logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1284)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}