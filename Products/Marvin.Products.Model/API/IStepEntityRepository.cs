﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the Marvin template for generating Repositories and a Unit of Work for Entity Framework.
// If you have any questions or suggestions for improvement regarding this code, contact Thomas Fuchs. I allways need feedback to improve.
//
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. So even when you think you can do better,
// don't touch it.
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Marvin.Model;


namespace Marvin.Products.Model
{
    /// <summary>
    /// The public API of the StepEntity repository.
    /// </summary>
    public partial interface IStepEntityRepository : IRepository<StepEntity>
    {
		/// <summary>
        /// Get all StepEntitys from the database
        /// </summary>
		/// <param name="deleted">Include deleted entities in result</param>
		/// <returns>A collection of entities. The result may be empty but not null.</returns>
        ICollection<StepEntity> GetAll(bool deleted);
        /// <summary>
        /// Creates instance with all not nullable properties prefilled
        /// </summary>
        StepEntity Create(long stepId, string name, string assembly, string nameSpace, string classname); 
    }
}
