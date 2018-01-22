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
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using Marvin.Model;

namespace Marvin.Products.Model
{
    internal partial class StepEntityRepository : EntityFrameworkRepository<StepEntity>, IStepEntityRepository
    {
        public static IRepository Create(IUnitOfWork uow, DbContext context)
        {
            var instance = new StepEntityRepository();
            instance.UnitOfWork = uow;
            instance.Context = context;
            instance.DbSet = context.Set<StepEntity>();
            return instance;
        }

        public ICollection<StepEntity> GetAll(bool deleted)
		{
			return DbSet.Where(e => e.Deleted == null || deleted).ToList();
		}
        public StepEntity Create(long stepId, string name, string assembly, string nameSpace, string classname) 
        {
            var entity = Create();
            entity.StepId = stepId;
            entity.Name = name;
            entity.Assembly = assembly;
            entity.NameSpace = nameSpace;
            entity.Classname = classname;
            return entity;
        }
        protected override void ExecuteRemove(StepEntity entity, bool permanent)
        {
            if (permanent)
                base.ExecuteRemove(entity, permanent);
            else
                entity.Deleted = DateTime.Now;
		}

		protected override void ExecuteRemoveRange(IEnumerable<StepEntity> entities, bool permanent)
		{
            if (permanent)
            {
                base.ExecuteRemoveRange(entities, permanent);
            }
            else
            {
                foreach (var entity in entities)
                {
                    entity.Deleted = DateTime.Now;
                }
            }
		}

    }
}
