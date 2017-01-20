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
    /// Container for the parameters to the RebootCacheCluster operation.
    /// Reboots some, or all, of the cache nodes within a provisioned cache cluster. This
    /// operation applies any modified cache parameter groups to the cache cluster. The reboot
    /// operation takes place as soon as possible, and results in a momentary outage to the
    /// cache cluster. During the reboot, the cache cluster status is set to REBOOTING.
    /// 
    ///  
    /// <para>
    /// The reboot causes the contents of the cache (for each cache node being rebooted) to
    /// be lost.
    /// </para>
    ///  
    /// <para>
    /// When the reboot is complete, a cache cluster event is created.
    /// </para>
    /// </summary>
    public partial class RebootCacheClusterRequest : AmazonElastiCacheRequest
    {
        private string _cacheClusterId;
        private List<string> _cacheNodeIdsToReboot = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RebootCacheClusterRequest() { }

        /// <summary>
        /// Instantiates RebootCacheClusterRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheClusterId">The cache cluster identifier. This parameter is stored as a lowercase string.</param>
        /// <param name="cacheNodeIdsToReboot">A list of cache node IDs to reboot. A node ID is a numeric identifier (0001, 0002, etc.). To reboot an entire cache cluster, specify all of the cache node IDs.</param>
        public RebootCacheClusterRequest(string cacheClusterId, List<string> cacheNodeIdsToReboot)
        {
            _cacheClusterId = cacheClusterId;
            _cacheNodeIdsToReboot = cacheNodeIdsToReboot;
        }

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The cache cluster identifier. This parameter is stored as a lowercase string.
        /// </para>
        /// </summary>
        public string CacheClusterId
        {
            get { return this._cacheClusterId; }
            set { this._cacheClusterId = value; }
        }

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this._cacheClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CacheNodeIdsToReboot. 
        /// <para>
        /// A list of cache node IDs to reboot. A node ID is a numeric identifier (0001, 0002,
        /// etc.). To reboot an entire cache cluster, specify all of the cache node IDs.
        /// </para>
        /// </summary>
        public List<string> CacheNodeIdsToReboot
        {
            get { return this._cacheNodeIdsToReboot; }
            set { this._cacheNodeIdsToReboot = value; }
        }

        // Check to see if CacheNodeIdsToReboot property is set
        internal bool IsSetCacheNodeIdsToReboot()
        {
            return this._cacheNodeIdsToReboot != null && this._cacheNodeIdsToReboot.Count > 0; 
        }

    }
}