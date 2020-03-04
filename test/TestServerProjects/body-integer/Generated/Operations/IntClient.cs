// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace body_integer
{
    public partial class IntClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal IntRestClient RestClient { get; }
        /// <summary> Initializes a new instance of IntClient. </summary>
        internal IntClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new IntRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        /// <summary> Get null Int value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<int>> GetNullAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetNullAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get null Int value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<int> GetNull(CancellationToken cancellationToken = default)
        {
            return RestClient.GetNull(cancellationToken);
        }
        /// <summary> Get invalid Int value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<int>> GetInvalidAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetInvalidAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get invalid Int value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<int> GetInvalid(CancellationToken cancellationToken = default)
        {
            return RestClient.GetInvalid(cancellationToken);
        }
        /// <summary> Get overflow Int32 value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<int>> GetOverflowInt32Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetOverflowInt32Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get overflow Int32 value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<int> GetOverflowInt32(CancellationToken cancellationToken = default)
        {
            return RestClient.GetOverflowInt32(cancellationToken);
        }
        /// <summary> Get underflow Int32 value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<int>> GetUnderflowInt32Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetUnderflowInt32Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get underflow Int32 value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<int> GetUnderflowInt32(CancellationToken cancellationToken = default)
        {
            return RestClient.GetUnderflowInt32(cancellationToken);
        }
        /// <summary> Get overflow Int64 value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<long>> GetOverflowInt64Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetOverflowInt64Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get overflow Int64 value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<long> GetOverflowInt64(CancellationToken cancellationToken = default)
        {
            return RestClient.GetOverflowInt64(cancellationToken);
        }
        /// <summary> Get underflow Int64 value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<long>> GetUnderflowInt64Async(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetUnderflowInt64Async(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get underflow Int64 value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<long> GetUnderflowInt64(CancellationToken cancellationToken = default)
        {
            return RestClient.GetUnderflowInt64(cancellationToken);
        }
        /// <summary> Put max int32 value. </summary>
        /// <param name="intBody"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutMax32Async(int intBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutMax32Async(intBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Put max int32 value. </summary>
        /// <param name="intBody"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutMax32(int intBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutMax32(intBody, cancellationToken);
        }
        /// <summary> Put max int64 value. </summary>
        /// <param name="intBody"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutMax64Async(long intBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutMax64Async(intBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Put max int64 value. </summary>
        /// <param name="intBody"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutMax64(long intBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutMax64(intBody, cancellationToken);
        }
        /// <summary> Put min int32 value. </summary>
        /// <param name="intBody"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutMin32Async(int intBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutMin32Async(intBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Put min int32 value. </summary>
        /// <param name="intBody"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutMin32(int intBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutMin32(intBody, cancellationToken);
        }
        /// <summary> Put min int64 value. </summary>
        /// <param name="intBody"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutMin64Async(long intBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutMin64Async(intBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Put min int64 value. </summary>
        /// <param name="intBody"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutMin64(long intBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutMin64(intBody, cancellationToken);
        }
        /// <summary> Get datetime encoded as Unix time value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<DateTimeOffset>> GetUnixTimeAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetUnixTimeAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get datetime encoded as Unix time value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DateTimeOffset> GetUnixTime(CancellationToken cancellationToken = default)
        {
            return RestClient.GetUnixTime(cancellationToken);
        }
        /// <summary> Put datetime encoded as Unix time. </summary>
        /// <param name="intBody"> The Unixtime to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutUnixTimeDateAsync(DateTimeOffset intBody, CancellationToken cancellationToken = default)
        {
            return await RestClient.PutUnixTimeDateAsync(intBody, cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Put datetime encoded as Unix time. </summary>
        /// <param name="intBody"> The Unixtime to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutUnixTimeDate(DateTimeOffset intBody, CancellationToken cancellationToken = default)
        {
            return RestClient.PutUnixTimeDate(intBody, cancellationToken);
        }
        /// <summary> Get invalid Unix time value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<DateTimeOffset>> GetInvalidUnixTimeAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetInvalidUnixTimeAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get invalid Unix time value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DateTimeOffset> GetInvalidUnixTime(CancellationToken cancellationToken = default)
        {
            return RestClient.GetInvalidUnixTime(cancellationToken);
        }
        /// <summary> Get null Unix time value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<DateTimeOffset>> GetNullUnixTimeAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetNullUnixTimeAsync(cancellationToken).ConfigureAwait(false);
        }
        /// <summary> Get null Unix time value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DateTimeOffset> GetNullUnixTime(CancellationToken cancellationToken = default)
        {
            return RestClient.GetNullUnixTime(cancellationToken);
        }
    }
}
