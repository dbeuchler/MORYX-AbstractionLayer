﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the Marvin template for generating a DbContext and Entities. 
// If you have any questions or suggestions for improvement regarding this code, contact Thomas Fuchs. I allways need feedback to improve.
// 
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Linq;
using Marvin.Model;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Marvin.Products.Model
{

    /// <summary>
    /// There are no comments for Marvin.Products.Model.ProductEntity in the schema.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [System.Runtime.Serialization.KnownType(typeof(PartLink))]
    [System.Runtime.Serialization.KnownType(typeof(ProductRecipeEntity))]
    [System.Runtime.Serialization.KnownType(typeof(ProductProperties))]
    [System.Runtime.Serialization.KnownType(typeof(ProductDocument))]
    public partial class ProductEntity : IEquatable<ProductEntity>, IMergeParent, IModificationTrackedEntity    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ProductEntity()
        {
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual long Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        private long _id;

    
        /// <summary>
        /// There are no comments for Created in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual global::System.DateTime Created
        {
            get
            {
                return _created;
            }
            set
            {
                if (_created != value)
                {
                    _created = value;
                    OnPropertyChanged("Created");
                }
            }
        }
        private global::System.DateTime _created;

    
        /// <summary>
        /// There are no comments for Updated in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual global::System.DateTime Updated
        {
            get
            {
                return _updated;
            }
            set
            {
                if (_updated != value)
                {
                    _updated = value;
                    OnPropertyChanged("Updated");
                }
            }
        }
        private global::System.DateTime _updated;

    
        /// <summary>
        /// There are no comments for Deleted in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual global::System.Nullable<System.DateTime> Deleted
        {
            get
            {
                return _deleted;
            }
            set
            {
                if (_deleted != value)
                {
                    _deleted = value;
                    OnPropertyChanged("Deleted");
                }
            }
        }
        private global::System.Nullable<System.DateTime> _deleted;

    
        /// <summary>
        /// There are no comments for MaterialNumber in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual string MaterialNumber
        {
            get
            {
                return _materialNumber;
            }
            set
            {
                if (_materialNumber != value)
                {
                    _materialNumber = value;
                    OnPropertyChanged("MaterialNumber");
                }
            }
        }
        private string _materialNumber;

    
        /// <summary>
        /// There are no comments for Revision in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual short Revision
        {
            get
            {
                return _revision;
            }
            set
            {
                if (_revision != value)
                {
                    _revision = value;
                    OnPropertyChanged("Revision");
                }
            }
        }
        private short _revision;

    
        /// <summary>
        /// There are no comments for TypeName in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual string TypeName
        {
            get
            {
                return _typeName;
            }
            set
            {
                if (_typeName != value)
                {
                    _typeName = value;
                    OnPropertyChanged("TypeName");
                }
            }
        }
        private string _typeName;

    
        /// <summary>
        /// There are no comments for CurrentVersionId in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual long CurrentVersionId
        {
            get
            {
                return _currentVersionId;
            }
            set
            {
                if (_currentVersionId != value)
                {
                    _currentVersionId = value;
                    OnPropertyChanged("CurrentVersionId");
                }
            }
        }
        private long _currentVersionId;


        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for Parts in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual ICollection<PartLink> Parts
        {
		    get; set;
        }
    
        /// <summary>
        /// There are no comments for Parents in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual ICollection<PartLink> Parents
        {
		    get; set;
        }
    
        /// <summary>
        /// There are no comments for Recipes in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual ICollection<ProductRecipeEntity> Recipes
        {
		    get; set;
        }
    
        /// <summary>
        /// There are no comments for OldVersions in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual ICollection<ProductProperties> OldVersions
        {
		    get; set;
        }
    
        /// <summary>
        /// There are no comments for CurrentVersion in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual ProductProperties CurrentVersion
        {
            get;
            protected internal set;
        }
    
        /// <summary>
        /// There are no comments for Documents in the schema.
        /// </summary>
        [System.Runtime.Serialization.DataMember]
        public virtual ICollection<ProductDocument> Documents
        {
		    get; set;
        }

        #endregion
        #region IEquatable
        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object other)
        {
            return Equals(other as ProductEntity); 
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="other">The ProductEntity to compare with the current ProductEntity.</param>
        /// <returns><c>true</c> if the specified ProductEntity is equal to the current ProductEntity; otherwise, <c>false</c>.</returns>
        public bool Equals(ProductEntity other)
        {
            if((object)other == null)
                return false;
            
            // First look for Id, then compare references
            return (Id != 0 && Id == other.Id) || object.ReferenceEquals(this, other);
        }
     
        /// <summary>
        /// Compares two ProductEntity objects.
        /// </summary>
        /// <param name="a">The first ProductEntity to compare</param>
        /// <param name="b">The second ProductEntity to compare</param>
        /// <returns><c>true</c> if the specified objects are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(ProductEntity  a, ProductEntity  b)
        {
            if((object)a == null && (object)b == null)
                return true;
            return (object)a != null && a.Equals(b);
        }

        /// <summary>
        /// Compares two ProductEntity objects.
        /// </summary>
        /// <param name="a">The first ProductEntity to compare</param>
        /// <param name="b">The second ProductEntity to compare</param>
        /// <returns><c>true</c> if the specified objects are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(ProductEntity  a, ProductEntity b)
        {
            return !(a == b);
        }

        #endregion
        
        /// <summary>
        /// Reference to merged child
        /// </summary>
        object IMergeParent.Child { get; set; }
    
        #region INotifyPropertyChanged Members

        /// <summary>
        /// Raised when a property value changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises a PropertyChanged event.
        /// </summary>
        protected void OnPropertyChanged(string propertyName) {

          if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

}
