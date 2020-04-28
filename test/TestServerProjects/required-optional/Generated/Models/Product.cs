// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace required_optional.Models
{
    /// <summary> The Product. </summary>
    public partial class Product
    {
        /// <summary> Initializes a new instance of Product. </summary>
        /// <param name="id"> . </param>
        public Product(int id)
        {
            Id = id;
        }

        /// <summary> Initializes a new instance of Product. </summary>
        /// <param name="id"> . </param>
        /// <param name="name"> . </param>
        internal Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}