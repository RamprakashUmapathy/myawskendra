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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCacheSecurityGroups operation.
    /// Returns a list of cache security group descriptions. If a cache security group name
    /// is specified, the list contains only the description of that group.
    /// </summary>
    public partial class DescribeCacheSecurityGroupsRequest : AmazonElastiCacheRequest
    {
        private string _cacheSecurityGroupName;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeCacheSecurityGroupsRequest() { }

        /// <summary>
        /// Instantiates DescribeCacheSecurityGroupsRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheSecurityGroupName">The name of the cache security group to return details for.</param>
        public DescribeCacheSecurityGroupsRequest(string cacheSecurityGroupName)
        {
            _cacheSecurityGroupName = cacheSecurityGroupName;
        }

        /// <summary>
        /// Gets and sets the property CacheSecurityGroupName. 
        /// <para>
        /// The name of the cache security group to return details for.
        /// </para>
        /// </summary>
        public string CacheSecurityGroupName
        {
            get { return this._cacheSecurityGroupName; }
            set { this._cacheSecurityGroupName = value; }
        }

        // Check to see if CacheSecurityGroupName property is set
        internal bool IsSetCacheSecurityGroupName()
        {
            return this._cacheSecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by <code>MaxRecords</code>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <code>MaxRecords</code> value, a marker is included in the response
        /// so that the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20; maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

    }
}