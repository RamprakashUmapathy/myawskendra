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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudWatch.Model;

namespace Amazon.CloudWatch
{
    /// <summary>
    /// Interface for accessing CloudWatch
    ///
    /// Amazon CloudWatch monitors your Amazon Web Services (AWS) resources and the applications
    /// you run on AWS in real-time. You can use CloudWatch to collect and track metrics,
    /// which are the variables you want to measure for your resources and applications.
    /// 
    ///  
    /// <para>
    /// CloudWatch alarms send notifications or automatically make changes to the resources
    /// you are monitoring based on rules that you define. For example, you can monitor the
    /// CPU usage and disk reads and writes of your Amazon Elastic Compute Cloud (Amazon EC2)
    /// instances and then use this data to determine whether you should launch additional
    /// instances to handle increased load. You can also use this data to stop under-used
    /// instances to save money.
    /// </para>
    ///  
    /// <para>
    /// In addition to monitoring the built-in metrics that come with AWS, you can monitor
    /// your own custom metrics. With CloudWatch, you gain system-wide visibility into resource
    /// utilization, application performance, and operational health.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudWatch : IAmazonService, IDisposable
    {

        
        #region  DeleteAlarms


        /// <summary>
        /// Deletes the specified alarms. In the event of an error, no alarms are deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms service method.</param>
        /// 
        /// <returns>The response from the DeleteAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlarms
        ///         operation.</returns>
        IAsyncResult BeginDeleteAlarms(DeleteAlarmsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlarms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlarms.</param>
        /// 
        /// <returns>Returns a  DeleteAlarmsResult from CloudWatch.</returns>
        DeleteAlarmsResponse EndDeleteAlarms(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAlarmHistory


        /// <summary>
        /// Retrieves the history for the specified alarm. You can filter the results by date
        /// range or item type. If an alarm name is not specified, the histories for all alarms
        /// are returned.
        /// 
        ///  
        /// <para>
        /// Note that Amazon CloudWatch retains the history of an alarm even if you delete the
        /// alarm.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmHistoryResponse DescribeAlarmHistory();

        /// <summary>
        /// Retrieves the history for the specified alarm. You can filter the results by date
        /// range or item type. If an alarm name is not specified, the histories for all alarms
        /// are returned.
        /// 
        ///  
        /// <para>
        /// Note that Amazon CloudWatch retains the history of an alarm even if you delete the
        /// alarm.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarmHistory
        ///         operation.</returns>
        IAsyncResult BeginDescribeAlarmHistory(DescribeAlarmHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarmHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmHistory.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmHistoryResult from CloudWatch.</returns>
        DescribeAlarmHistoryResponse EndDescribeAlarmHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAlarms


        /// <summary>
        /// Retrieves the specified alarms. If no alarms are specified, all alarms are returned.
        /// Alarms can be retrieved by using only a prefix for the alarm name, the alarm state,
        /// or a prefix for any action.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmsResponse DescribeAlarms();

        /// <summary>
        /// Retrieves the specified alarms. If no alarms are specified, all alarms are returned.
        /// Alarms can be retrieved by using only a prefix for the alarm name, the alarm state,
        /// or a prefix for any action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarms
        ///         operation.</returns>
        IAsyncResult BeginDescribeAlarms(DescribeAlarmsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarms.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmsResult from CloudWatch.</returns>
        DescribeAlarmsResponse EndDescribeAlarms(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAlarmsForMetric


        /// <summary>
        /// Retrieves the alarms for the specified metric. Specify a statistic, period, or unit
        /// to filter the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarmsForMetric service method, as returned by CloudWatch.</returns>
        DescribeAlarmsForMetricResponse DescribeAlarmsForMetric(DescribeAlarmsForMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarmsForMetric
        ///         operation.</returns>
        IAsyncResult BeginDescribeAlarmsForMetric(DescribeAlarmsForMetricRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarmsForMetric operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmsForMetric.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmsForMetricResult from CloudWatch.</returns>
        DescribeAlarmsForMetricResponse EndDescribeAlarmsForMetric(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableAlarmActions


        /// <summary>
        /// Disables the actions for the specified alarms. When an alarm's actions are disabled,
        /// the alarm actions do not execute when the alarm state changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions service method.</param>
        /// 
        /// <returns>The response from the DisableAlarmActions service method, as returned by CloudWatch.</returns>
        DisableAlarmActionsResponse DisableAlarmActions(DisableAlarmActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableAlarmActions
        ///         operation.</returns>
        IAsyncResult BeginDisableAlarmActions(DisableAlarmActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAlarmActions.</param>
        /// 
        /// <returns>Returns a  DisableAlarmActionsResult from CloudWatch.</returns>
        DisableAlarmActionsResponse EndDisableAlarmActions(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableAlarmActions


        /// <summary>
        /// Enables the actions for the specified alarms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions service method.</param>
        /// 
        /// <returns>The response from the EnableAlarmActions service method, as returned by CloudWatch.</returns>
        EnableAlarmActionsResponse EnableAlarmActions(EnableAlarmActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableAlarmActions
        ///         operation.</returns>
        IAsyncResult BeginEnableAlarmActions(EnableAlarmActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAlarmActions.</param>
        /// 
        /// <returns>Returns a  EnableAlarmActionsResult from CloudWatch.</returns>
        EnableAlarmActionsResponse EndEnableAlarmActions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMetricStatistics


        /// <summary>
        /// Gets statistics for the specified metric.
        /// 
        ///  
        /// <para>
        /// Amazon CloudWatch retains metric data as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data points with a period of 60 seconds (1 minute) are available for 15 days
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 300 seconds (5 minute) are available for 63 days
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 3600 seconds (1 hour) are available for 455 days (15
        /// months)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that CloudWatch started retaining 5-minute and 1-hour metric data as of 9 July
        /// 2016.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of data points returned from a single call is 1,440. If you request
        /// more than 1,440 data points, Amazon CloudWatch returns an error. To reduce the number
        /// of data points, you can narrow the specified time range and make multiple requests
        /// across adjacent time ranges, or you can increase the specified period. A period can
        /// be as short as one minute (60 seconds). Note that data points are not returned in
        /// chronological order.
        /// </para>
        ///  
        /// <para>
        /// Amazon CloudWatch aggregates data points based on the length of the period that you
        /// specify. For example, if you request statistics with a one-hour period, Amazon CloudWatch
        /// aggregates all data points with time stamps that fall within each one-hour period.
        /// Therefore, the number of values aggregated by CloudWatch is larger than the number
        /// of data points returned.
        /// </para>
        ///  
        /// <para>
        /// For a list of metrics and dimensions supported by AWS services, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CW_Support_For_AWS.html">Amazon
        /// CloudWatch Metrics and Dimensions Reference</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics service method.</param>
        /// 
        /// <returns>The response from the GetMetricStatistics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters that cannot be used together were used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetricStatistics
        ///         operation.</returns>
        IAsyncResult BeginGetMetricStatistics(GetMetricStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetricStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricStatistics.</param>
        /// 
        /// <returns>Returns a  GetMetricStatisticsResult from CloudWatch.</returns>
        GetMetricStatisticsResponse EndGetMetricStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMetrics


        /// <summary>
        /// List the specified metrics. You can use the returned metrics with <a>GetMetricStatistics</a>
        /// to obtain statistical data.
        /// 
        ///  
        /// <para>
        /// Up to 500 results are returned for any one call. To retrieve additional results, use
        /// the returned token with subsequent calls.
        /// </para>
        ///  
        /// <para>
        /// After you create a metric, allow up to fifteen minutes before the metric appears.
        /// Statistics about the metric, however, are available sooner using <a>GetMetricStatistics</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        ListMetricsResponse ListMetrics();

        /// <summary>
        /// List the specified metrics. You can use the returned metrics with <a>GetMetricStatistics</a>
        /// to obtain statistical data.
        /// 
        ///  
        /// <para>
        /// Up to 500 results are returned for any one call. To retrieve additional results, use
        /// the returned token with subsequent calls.
        /// </para>
        ///  
        /// <para>
        /// After you create a metric, allow up to fifteen minutes before the metric appears.
        /// Statistics about the metric, however, are available sooner using <a>GetMetricStatistics</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics service method.</param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        ListMetricsResponse ListMetrics(ListMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetrics
        ///         operation.</returns>
        IAsyncResult BeginListMetrics(ListMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetrics.</param>
        /// 
        /// <returns>Returns a  ListMetricsResult from CloudWatch.</returns>
        ListMetricsResponse EndListMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMetricAlarm


        /// <summary>
        /// Creates or updates an alarm and associates it with the specified metric. Optionally,
        /// this operation can associate one or more Amazon SNS resources with the alarm.
        /// 
        ///  
        /// <para>
        /// When this operation creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
        /// The alarm is evaluated and its state is set appropriately. Any actions associated
        /// with the state are then executed.
        /// </para>
        ///  
        /// <para>
        /// When you update an existing alarm, its state is left unchanged, but the update completely
        /// overwrites the previous configuration of the alarm.
        /// </para>
        ///  
        /// <para>
        /// If you are an AWS Identity and Access Management (IAM) user, you must have Amazon
        /// EC2 permissions for some operations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2:DescribeInstanceStatus</code> and <code>ec2:DescribeInstances</code> for
        /// all alarms on EC2 instance status metrics
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:StopInstances</code> for alarms with stop actions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:TerminateInstances</code> for alarms with terminate actions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:DescribeInstanceRecoveryAttribute</code> and <code>ec2:RecoverInstances</code>
        /// for alarms with recover actions
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you have read/write permissions for Amazon CloudWatch but not for Amazon EC2, you
        /// can still create an alarm, but the stop or terminate actions won't be performed. However,
        /// if you are later granted the required permissions, the alarm actions that you created
        /// earlier will be performed.
        /// </para>
        ///  
        /// <para>
        /// If you are using an IAM role (for example, an Amazon EC2 instance profile), you cannot
        /// stop or terminate the instance using alarm actions. However, you can still see the
        /// alarm state and perform any other actions such as Amazon SNS notifications or Auto
        /// Scaling policies.
        /// </para>
        ///  
        /// <para>
        /// If you are using temporary security credentials granted using the AWS Security Token
        /// Service (AWS STS), you cannot stop or terminate an Amazon EC2 instance using alarm
        /// actions.
        /// </para>
        ///  
        /// <para>
        /// Note that you must create at least one stop, terminate, or reboot alarm using the
        /// Amazon EC2 or CloudWatch console to create the <b>EC2ActionsAccess</b> IAM role. After
        /// this IAM role is created, you can create stop, terminate, or reboot alarms using a
        /// command-line interface or an API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm service method.</param>
        /// 
        /// <returns>The response from the PutMetricAlarm service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.LimitExceededException">
        /// The quota for alarms for this customer has already been reached.
        /// </exception>
        PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetricAlarm
        ///         operation.</returns>
        IAsyncResult BeginPutMetricAlarm(PutMetricAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetricAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricAlarm.</param>
        /// 
        /// <returns>Returns a  PutMetricAlarmResult from CloudWatch.</returns>
        PutMetricAlarmResponse EndPutMetricAlarm(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMetricData


        /// <summary>
        /// Publishes metric data points to Amazon CloudWatch. Amazon CloudWatch associates the
        /// data points with the specified metric. If the specified metric does not exist, Amazon
        /// CloudWatch creates the metric. When Amazon CloudWatch creates a metric, it can take
        /// up to fifteen minutes for the metric to appear in calls to <a>ListMetrics</a>.
        /// 
        ///  
        /// <para>
        /// Each <code>PutMetricData</code> request is limited to 8 KB in size for HTTP GET requests
        /// and is limited to 40 KB in size for HTTP POST requests.
        /// </para>
        ///  
        /// <para>
        /// Although the <code>Value</code> parameter accepts numbers of type <code>Double</code>,
        /// Amazon CloudWatch rejects values that are either too small or too large. Values must
        /// be in the range of 8.515920e-109 to 1.174271e+108 (Base 10) or 2e-360 to 2e360 (Base
        /// 2). In addition, special values (e.g., NaN, +Infinity, -Infinity) are not supported.
        /// </para>
        ///  
        /// <para>
        /// Data points with time stamps from 24 hours ago or longer can take at least 48 hours
        /// to become available for <a>GetMetricStatistics</a> from the time they are submitted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters that cannot be used together were used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        PutMetricDataResponse PutMetricData(PutMetricDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetricData
        ///         operation.</returns>
        IAsyncResult BeginPutMetricData(PutMetricDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricData.</param>
        /// 
        /// <returns>Returns a  PutMetricDataResult from CloudWatch.</returns>
        PutMetricDataResponse EndPutMetricData(IAsyncResult asyncResult);

        #endregion
        
        #region  SetAlarmState


        /// <summary>
        /// Temporarily sets the state of an alarm for testing purposes. When the updated state
        /// differs from the previous value, the action configured for the appropriate state is
        /// invoked. For example, if your alarm is configured to send an Amazon SNS message when
        /// an alarm is triggered, temporarily changing the alarm state to <code>ALARM</code>
        /// sends an Amazon SNS message. The alarm returns to its actual state (often within seconds).
        /// Because the alarm state change happens very quickly, it is typically only visible
        /// in the alarm's <b>History</b> tab in the Amazon CloudWatch console or through <a>DescribeAlarmHistory</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState service method.</param>
        /// 
        /// <returns>The response from the SetAlarmState service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidFormatException">
        /// Data was not syntactically valid JSON.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetAlarmState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetAlarmState
        ///         operation.</returns>
        IAsyncResult BeginSetAlarmState(SetAlarmStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetAlarmState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetAlarmState.</param>
        /// 
        /// <returns>Returns a  SetAlarmStateResult from CloudWatch.</returns>
        SetAlarmStateResponse EndSetAlarmState(IAsyncResult asyncResult);

        #endregion
        
    }
}