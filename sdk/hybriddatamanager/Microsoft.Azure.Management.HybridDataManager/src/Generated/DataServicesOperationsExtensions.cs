// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataServicesOperations.
    /// </summary>
    public static partial class DataServicesOperationsExtensions
    {
            /// <summary>
            /// This method gets all the data services.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            public static IPage<DataService> ListByDataManager(this IDataServicesOperations operations, string resourceGroupName, string dataManagerName)
            {
                return operations.ListByDataManagerAsync(resourceGroupName, dataManagerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method gets all the data services.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataService>> ListByDataManagerAsync(this IDataServicesOperations operations, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataManagerWithHttpMessagesAsync(resourceGroupName, dataManagerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the data service that matches the data service name given.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The name of the data service that is being queried.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            public static DataService Get(this IDataServicesOperations operations, string dataServiceName, string resourceGroupName, string dataManagerName)
            {
                return operations.GetAsync(dataServiceName, resourceGroupName, dataManagerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the data service that matches the data service name given.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dataServiceName'>
            /// The name of the data service that is being queried.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='dataManagerName'>
            /// The name of the DataManager Resource within the specified resource group.
            /// DataManager names must be between 3 and 24 characters in length and use any
            /// alphanumeric and underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataService> GetAsync(this IDataServicesOperations operations, string dataServiceName, string resourceGroupName, string dataManagerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(dataServiceName, resourceGroupName, dataManagerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This method gets all the data services.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataService> ListByDataManagerNext(this IDataServicesOperations operations, string nextPageLink)
            {
                return operations.ListByDataManagerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method gets all the data services.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataService>> ListByDataManagerNextAsync(this IDataServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataManagerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
