// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Moryx.AbstractionLayer;
using Moryx.AbstractionLayer.Products;

namespace Moryx.Products.Management
{
    /// <summary>
    /// Base class for importing a prototype
    /// </summary>
    public class PrototypeParameters : IPrototypeParameters
    {
        /// <summary>
        /// Identifier of the new product
        /// </summary>
        [Description("Identifier of the new product"), Required]
        [DefaultValue("2901234")]
        [StringLength(7, MinimumLength = 7), RegularExpression(@"\d+")]
        public string Identifier { get; set; }

        /// <summary>
        /// Revision of the new product
        /// </summary>
        [Description("Revision of the new product"), Required]
        public short Revision { get; set; }

        /// <summary>
        /// Optional name of the product
        /// </summary>
        public string Name { get; set; }
    }
}
