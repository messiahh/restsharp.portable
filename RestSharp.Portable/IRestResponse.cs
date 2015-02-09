﻿using System;
using System.Net;
using System.Net.Http.Headers;

namespace RestSharp.Portable
{
    /// <summary>
    /// The generic REST response
    /// </summary>
    public interface IRestResponse
    {
        /// <summary>
        /// Gets the Request that resulted in this response
        /// </summary>
        IRestRequest Request { get; }

        /// <summary>
        /// Gets the full response URL
        /// </summary>
        Uri ResponseUri { get; }

        /// <summary>
        /// Gets the raw data
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "Required for RestSharp compatibility")]
        byte[] RawBytes { get; }

        /// <summary>
        /// Gets the content type of the raw data
        /// </summary>
        string ContentType { get; }

        /// <summary>
        /// Gets the response headers (without content headers)
        /// </summary>
        HttpHeaders Headers { get; }

        /// <summary>
        /// Gets the HTTP status code
        /// </summary>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gest the description for the HTTP status code
        /// </summary>
        string StatusDescription { get; }
    }

    /// <summary>
    /// Typed response
    /// </summary>
    /// <typeparam name="T">Type of the object to deserialize from the raw data</typeparam>
    public interface IRestResponse<T> : IRestResponse
    {
        /// <summary>
        /// Gets the deserialized object of type T
        /// </summary>
        T Data { get; }
    }
}
