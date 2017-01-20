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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CostAndUsageReport.Model;

namespace Amazon.CostAndUsageReport
{
    /// <summary>
    /// Interface for accessing CostAndUsageReport
    ///
    /// All public APIs for AWS Cost and Usage Report service
    /// </summary>
    public partial interface IAmazonCostAndUsageReport : IAmazonService, IDisposable
    {

        
        #region  DeleteReportDefinition


        /// <summary>
        /// Delete a specified report definition
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// This exception is thrown on a known dependency failure.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// This exception is thrown when providing an invalid input. eg. Put a report preference
        /// with an invalid report name, or Delete a report preference with an empty report name.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        DeleteReportDefinitionResponse DeleteReportDefinition(DeleteReportDefinitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        Task<DeleteReportDefinitionResponse> DeleteReportDefinitionAsync(DeleteReportDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReportDefinitions


        /// <summary>
        /// Describe a list of report definitions owned by the account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportDefinitions service method.</param>
        /// 
        /// <returns>The response from the DescribeReportDefinitions service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// This exception is thrown on a known dependency failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DescribeReportDefinitions">REST API Reference for DescribeReportDefinitions Operation</seealso>
        DescribeReportDefinitionsResponse DescribeReportDefinitions(DescribeReportDefinitionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReportDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/DescribeReportDefinitions">REST API Reference for DescribeReportDefinitions Operation</seealso>
        Task<DescribeReportDefinitionsResponse> DescribeReportDefinitionsAsync(DescribeReportDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutReportDefinition


        /// <summary>
        /// Create a new report definition
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition service method.</param>
        /// 
        /// <returns>The response from the PutReportDefinition service method, as returned by CostAndUsageReport.</returns>
        /// <exception cref="Amazon.CostAndUsageReport.Model.DuplicateReportNameException">
        /// This exception is thrown when putting a report preference with a name that already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.InternalErrorException">
        /// This exception is thrown on a known dependency failure.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ReportLimitReachedException">
        /// This exception is thrown when the number of report preference reaches max limit. The
        /// max number is 5.
        /// </exception>
        /// <exception cref="Amazon.CostAndUsageReport.Model.ValidationException">
        /// This exception is thrown when providing an invalid input. eg. Put a report preference
        /// with an invalid report name, or Delete a report preference with an empty report name.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        PutReportDefinitionResponse PutReportDefinition(PutReportDefinitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cur-2017-01-06/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        Task<PutReportDefinitionResponse> PutReportDefinitionAsync(PutReportDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}