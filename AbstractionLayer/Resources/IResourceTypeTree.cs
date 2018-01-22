﻿using System;
using System.Collections.Generic;

namespace Marvin.AbstractionLayer.Resources
{
    /// <summary>
    /// Component that manages the resource type tree
    /// </summary>
    public interface IResourceTypeTree
    {
        /// <summary>
        /// Types derived from <see cref="Resource"/> and their derived types
        /// </summary>
        IEnumerable<IResourceTypeNode> RootTypes { get; }

        /// <summary>
        /// Find all types that implement the given type constraint
        /// </summary>
        IEnumerable<IResourceTypeNode> SupportedTypes(Type constraint);

        /// <summary>
        /// Find all resource type trees that implement the given type constraints
        /// </summary>
        IEnumerable<IResourceTypeNode> SupportedTypes(ICollection<Type> constraints);
    }
}