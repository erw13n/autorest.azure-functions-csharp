// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace azure_parameter_grouping.Models
{
    /// <summary> Parameter group. </summary>
    public partial class FirstParameterGroup
    {
        /// <summary> Initializes a new instance of FirstParameterGroup. </summary>
        public FirstParameterGroup()
        {
        }

        /// <summary> Initializes a new instance of FirstParameterGroup. </summary>
        /// <param name="headerOne"> . </param>
        /// <param name="queryOne"> Query parameter with default. </param>
        internal FirstParameterGroup(string headerOne, int? queryOne)
        {
            HeaderOne = headerOne;
            QueryOne = queryOne;
        }

        public string HeaderOne { get; set; }
        /// <summary> Query parameter with default. </summary>
        public int? QueryOne { get; set; }
    }
}
