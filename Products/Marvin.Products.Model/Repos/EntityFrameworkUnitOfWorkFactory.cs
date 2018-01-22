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
using System.Data.Entity.Core.EntityClient;
using System.Diagnostics;
using System.Text;
using Devart.Data.PostgreSql;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using Marvin.Modules;
using Marvin.Configuration;
using Marvin.Model;

namespace Marvin.Products.Model
{
    internal delegate IRepository RepoBuilder(IUnitOfWork uow, DbContext context);

    /// <summary>
    /// Factory to get a unit of work for the Products model
    /// </summary>
    [ModelFactory("Marvin.Products.Model")]
    public class EntityFrameworkUnitOfWorkFactory : IUnitOfWorkFactory, IParentFactory, IInitializable
    {
        private string _connectionString;
        private readonly Dictionary<string, IUnitOfWorkFactory> _children = new Dictionary<string, IUnitOfWorkFactory>();

        /// <summary>
        /// Repository builder dictionary, to create new instances of 
        /// </summary>
        private static readonly Dictionary<Type, RepoBuilder> RepoBuilders = new Dictionary<Type, RepoBuilder>
        {
            { typeof(IProductEntityRepository), ProductEntityRepository.Create },
            { typeof(IRepository<ProductEntity>), ProductEntityRepository.Create },
            { typeof(IPartLinkRepository), PartLinkRepository.Create },
            { typeof(IRepository<PartLink>), PartLinkRepository.Create },
            { typeof(IRevisionHistoryRepository), RevisionHistoryRepository.Create },
            { typeof(IRepository<RevisionHistory>), RevisionHistoryRepository.Create },
            { typeof(IProductRecipeEntityRepository), ProductRecipeEntityRepository.Create },
            { typeof(IRepository<ProductRecipeEntity>), ProductRecipeEntityRepository.Create },
            { typeof(IProductPropertiesRepository), ProductPropertiesRepository.Create },
            { typeof(IRepository<ProductProperties>), ProductPropertiesRepository.Create },
            { typeof(IArticleEntityRepository), ArticleEntityRepository.Create },
            { typeof(IRepository<ArticleEntity>), ArticleEntityRepository.Create },
            { typeof(IWorkplanEntityRepository), WorkplanEntityRepository.Create },
            { typeof(IRepository<WorkplanEntity>), WorkplanEntityRepository.Create },
            { typeof(IProductDocumentRepository), ProductDocumentRepository.Create },
            { typeof(IRepository<ProductDocument>), ProductDocumentRepository.Create },
            { typeof(IWorkplanReferenceRepository), WorkplanReferenceRepository.Create },
            { typeof(IRepository<WorkplanReference>), WorkplanReferenceRepository.Create },
            { typeof(IStepEntityRepository), StepEntityRepository.Create },
            { typeof(IRepository<StepEntity>), StepEntityRepository.Create },
            { typeof(IConnectorEntityRepository), ConnectorEntityRepository.Create },
            { typeof(IRepository<ConnectorEntity>), ConnectorEntityRepository.Create },
            { typeof(IConnectorReferenceRepository), ConnectorReferenceRepository.Create },
            { typeof(IRepository<ConnectorReference>), ConnectorReferenceRepository.Create },
            { typeof(IOutputDescriptionEntityRepository), OutputDescriptionEntityRepository.Create },
            { typeof(IRepository<OutputDescriptionEntity>), OutputDescriptionEntityRepository.Create },
         };

        /// <summary>
        /// ConfigurationManager to get the connection settings through the database.
        /// Will be injected!
        /// </summary>
        public IConfigManager ConfigManager { get; set; }

        /// <summary>
        /// Static instance for internal usage
        /// </summary>
        internal static EntityFrameworkUnitOfWorkFactory Instance { get; private set; }

        /// <summary>
        /// Prepare to use the factory to get a unit of work.
        /// Called by the IoC container.
        /// </summary>
        public void Initialize()
        {
            // Read config and build connection string
            ReloadConfiguration();

            // Set static for internal access
            Instance = this;
        }

        /// <summary>
        /// Load the current configurations and build the connection string 
        /// through the configured database.
        /// </summary>
        public void ReloadConfiguration()
        {
            var config = ConfigManager.GetConfiguration<DbConfig>();
            _connectionString = BuildConnectionString(config);
        }

        /// <summary>
        /// Build a connection string from config
        /// </summary>
        /// <param name="databaseConfig"></param>
        /// <returns></returns>
        private static string BuildConnectionString(IDatabaseConfig databaseConfig)
        {
            // Read given config and create connection string
            var conStringBuilder = new EntityConnectionStringBuilder
            {
                Metadata = "res://*/Marvin.Products.Model.Model.Products.csdl|" +
                           "res://*/Marvin.Products.Model.Model.Products.ssdl|" +
                           "res://*/Marvin.Products.Model.Model.Products.msl",
            };

            var providerConStr = new PgSqlConnectionStringBuilder
            {
                UserId = databaseConfig.User,
                Password = databaseConfig.Password,
                Host = databaseConfig.Server,
                Port = databaseConfig.Port,
                Database = databaseConfig.Database,
                PersistSecurityInfo = true,
                Schema = databaseConfig.Schema,
                Unicode = true
            }.ToString();

            conStringBuilder.Provider = "Devart.Data.PostgreSql";
            conStringBuilder.ProviderConnectionString = providerConStr;
            return conStringBuilder.ToString();
        }

        /// <summary>
        /// Register the derived data models.
        /// Called by the unit of work factory of the derived datamodel.
        /// </summary>
        /// <param name="childFactory">The unit of work factory of the derived data model.</param>
        /// <param name="childModel">The name of the derived data model.</param>
        public void RegisterChild(IUnitOfWorkFactory childFactory, string childModel)
        {
            _children[childModel] = childFactory;
        }

        #region IUnitOfWorkFactory Members

        /// <summary>
        /// Creates a new unit of work instance to access the data model.
        /// </summary>
        /// <param name="context">The dbcontext thought the data model.</param>
        /// <returns>Created unit of work.</returns>
        internal IUnitOfWork Create(Marvin.Products.Model.Entities context) 
        {
            if (context == null)
                throw new InvalidOperationException("Context has not been initialized.");
            return new EntityFrameworkUnitOfWork(context, RepoBuilders); 
        }

        /// <summary>
        /// Creates a merged new unit of work instance to access the data model.
        /// </summary>
        /// <param name="context">The dbcontext thought the data model.</param>
        /// <param name="other">The unit of work of the model to merge with.</param>
        /// <returns>Created unit of work.</returns>
        internal IUnitOfWork CreateMerged(Marvin.Products.Model.Entities context, IUnitOfWork other) 
        {
            if (context == null)
                throw new InvalidOperationException("Context has not been initialized.");
            return new EntityFrameworkMergedUnitOfWork(context, RepoBuilders, other); 
        }

        /// <summary>
        /// Creates a new unit of work instance to access the data model.
        /// </summary>
        /// <returns>Created unit of work.</returns>
        public IUnitOfWork Create()
        {
            var context = new Marvin.Products.Model.Entities(_connectionString, ContextMode.AllOn);

            return Create(context);
        }

        /// <summary>
        /// Creates a new unit of work instance to access the data model.
        /// </summary>
        /// <param name="mode">The mode of the dbcontext. Decides witch behavior the entities you get will have.</param>
        /// <returns>Created unit of work.</returns>
        public IUnitOfWork Create(ContextMode mode)
        {
            var context = new Marvin.Products.Model.Entities(_connectionString, mode);

            return Create(context);
        }

        /// <summary>
        /// Merges the given unit of work instance with a new instance for this model.
        /// </summary>
        /// <param name="other">The unit of work to merge.</param>
        /// <returns>Created unit of work with merged instance.</returns>
        public IUnitOfWork Merge(IUnitOfWork other)
        {
            return Merge(other, ContextMode.AllOn);
        }

        /// <summary>
        /// Merges the given unit of work instance with a new instance for this model.
        /// </summary>
        /// <param name="other">The unit of work to merge.</param>
        /// <param name="mode">The mode of the dbcontext. Decides witch behavior the entities you get will have.</param>
        /// <returns>Created unit of work with merged instance.</returns>
        public IUnitOfWork Merge(IUnitOfWork other, ContextMode mode)
        {
            var context = new Marvin.Products.Model.Entities(_connectionString, mode);
            other.Mode = mode;
            return CreateMerged(context, other);
        }

        /// <summary>
        /// Get a child with a given type and name.
        /// </summary>
        /// <param name="targetType">The type this instance is assigned to - irrelevant for data models</param>
        /// <param name="name">The name of the child.</param>
        /// <returns>The child with the given type and name.</returns>
        public IUnitOfWorkFactory GetChild(string name, Type targetType)
        {
            if (string.IsNullOrEmpty(name))
               return this;
            // currently the only supported child-type is IUnitOfWorkFactory!
            return _children.ContainsKey(name) ? _children[name] : null;
        }
        #endregion
    }
}
