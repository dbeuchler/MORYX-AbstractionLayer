﻿using Marvin.AbstractionLayer.Resources;
using Marvin.Container;

namespace Marvin.Resources.Management
{
    /// <summary>
    /// Factory for resources
    /// </summary>
    [PluginFactory(typeof(INameBasedComponentSelector))]
    internal interface IResourceFactory
    {
        /// <summary>
        /// Create a resource instance for this config entry
        /// </summary>
        /// <param name="resourceType">PluginName of this resource.</param>
        IResource Create(string resourceType);

        /// <summary>
        /// Machs kaputt!
        /// </summary>
        void Destroy(IResource resource);
    }
}