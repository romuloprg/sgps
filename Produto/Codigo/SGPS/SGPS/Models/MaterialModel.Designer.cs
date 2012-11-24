﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("materialModel", "FK_movimentacaoEstoque_material", "material", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(SGPS.Models.material), "movimentacaoEstoque", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SGPS.Models.movimentacaoEstoque), true)]

#endregion

namespace SGPS.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class materialEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new materialEntities object using the connection string found in the 'materialEntities' section of the application configuration file.
        /// </summary>
        public materialEntities() : base("name=materialEntities", "materialEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new materialEntities object.
        /// </summary>
        public materialEntities(string connectionString) : base(connectionString, "materialEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new materialEntities object.
        /// </summary>
        public materialEntities(EntityConnection connection) : base(connection, "materialEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<material> materials
        {
            get
            {
                if ((_materials == null))
                {
                    _materials = base.CreateObjectSet<material>("materials");
                }
                return _materials;
            }
        }
        private ObjectSet<material> _materials;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<movimentacaoEstoque> movimentacaoEstoques
        {
            get
            {
                if ((_movimentacaoEstoques == null))
                {
                    _movimentacaoEstoques = base.CreateObjectSet<movimentacaoEstoque>("movimentacaoEstoques");
                }
                return _movimentacaoEstoques;
            }
        }
        private ObjectSet<movimentacaoEstoque> _movimentacaoEstoques;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the materials EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTomaterials(material material)
        {
            base.AddObject("materials", material);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the movimentacaoEstoques EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTomovimentacaoEstoques(movimentacaoEstoque movimentacaoEstoque)
        {
            base.AddObject("movimentacaoEstoques", movimentacaoEstoque);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="materialModel", Name="material")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class material : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new material object.
        /// </summary>
        /// <param name="idMaterial">Initial value of the idMaterial property.</param>
        /// <param name="strDesMat">Initial value of the strDesMat property.</param>
        /// <param name="strQtdMat">Initial value of the strQtdMat property.</param>
        public static material Creatematerial(global::System.Int32 idMaterial, global::System.String strDesMat, global::System.String strQtdMat)
        {
            material material = new material();
            material.idMaterial = idMaterial;
            material.strDesMat = strDesMat;
            material.strQtdMat = strQtdMat;
            return material;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idMaterial
        {
            get
            {
                return _idMaterial;
            }
            set
            {
                if (_idMaterial != value)
                {
                    OnidMaterialChanging(value);
                    ReportPropertyChanging("idMaterial");
                    _idMaterial = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("idMaterial");
                    OnidMaterialChanged();
                }
            }
        }
        private global::System.Int32 _idMaterial;
        partial void OnidMaterialChanging(global::System.Int32 value);
        partial void OnidMaterialChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String strDesMat
        {
            get
            {
                return _strDesMat;
            }
            set
            {
                OnstrDesMatChanging(value);
                ReportPropertyChanging("strDesMat");
                _strDesMat = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("strDesMat");
                OnstrDesMatChanged();
            }
        }
        private global::System.String _strDesMat;
        partial void OnstrDesMatChanging(global::System.String value);
        partial void OnstrDesMatChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String strQtdMat
        {
            get
            {
                return _strQtdMat;
            }
            set
            {
                OnstrQtdMatChanging(value);
                ReportPropertyChanging("strQtdMat");
                _strQtdMat = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("strQtdMat");
                OnstrQtdMatChanged();
            }
        }
        private global::System.String _strQtdMat;
        partial void OnstrQtdMatChanging(global::System.String value);
        partial void OnstrQtdMatChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("materialModel", "FK_movimentacaoEstoque_material", "movimentacaoEstoque")]
        public EntityCollection<movimentacaoEstoque> movimentacaoEstoques
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<movimentacaoEstoque>("materialModel.FK_movimentacaoEstoque_material", "movimentacaoEstoque");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<movimentacaoEstoque>("materialModel.FK_movimentacaoEstoque_material", "movimentacaoEstoque", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="materialModel", Name="movimentacaoEstoque")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class movimentacaoEstoque : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new movimentacaoEstoque object.
        /// </summary>
        /// <param name="idMovMat">Initial value of the idMovMat property.</param>
        /// <param name="strDesMov">Initial value of the strDesMov property.</param>
        /// <param name="dtmDatMov">Initial value of the dtmDatMov property.</param>
        /// <param name="strQtdMov">Initial value of the strQtdMov property.</param>
        /// <param name="idMaterial">Initial value of the idMaterial property.</param>
        public static movimentacaoEstoque CreatemovimentacaoEstoque(global::System.Int32 idMovMat, global::System.String strDesMov, global::System.DateTime dtmDatMov, global::System.String strQtdMov, global::System.Int32 idMaterial)
        {
            movimentacaoEstoque movimentacaoEstoque = new movimentacaoEstoque();
            movimentacaoEstoque.idMovMat = idMovMat;
            movimentacaoEstoque.strDesMov = strDesMov;
            movimentacaoEstoque.dtmDatMov = dtmDatMov;
            movimentacaoEstoque.strQtdMov = strQtdMov;
            movimentacaoEstoque.idMaterial = idMaterial;
            return movimentacaoEstoque;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idMovMat
        {
            get
            {
                return _idMovMat;
            }
            set
            {
                if (_idMovMat != value)
                {
                    OnidMovMatChanging(value);
                    ReportPropertyChanging("idMovMat");
                    _idMovMat = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("idMovMat");
                    OnidMovMatChanged();
                }
            }
        }
        private global::System.Int32 _idMovMat;
        partial void OnidMovMatChanging(global::System.Int32 value);
        partial void OnidMovMatChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String strDesMov
        {
            get
            {
                return _strDesMov;
            }
            set
            {
                OnstrDesMovChanging(value);
                ReportPropertyChanging("strDesMov");
                _strDesMov = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("strDesMov");
                OnstrDesMovChanged();
            }
        }
        private global::System.String _strDesMov;
        partial void OnstrDesMovChanging(global::System.String value);
        partial void OnstrDesMovChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime dtmDatMov
        {
            get
            {
                return _dtmDatMov;
            }
            set
            {
                OndtmDatMovChanging(value);
                ReportPropertyChanging("dtmDatMov");
                _dtmDatMov = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("dtmDatMov");
                OndtmDatMovChanged();
            }
        }
        private global::System.DateTime _dtmDatMov;
        partial void OndtmDatMovChanging(global::System.DateTime value);
        partial void OndtmDatMovChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String strQtdMov
        {
            get
            {
                return _strQtdMov;
            }
            set
            {
                OnstrQtdMovChanging(value);
                ReportPropertyChanging("strQtdMov");
                _strQtdMov = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("strQtdMov");
                OnstrQtdMovChanged();
            }
        }
        private global::System.String _strQtdMov;
        partial void OnstrQtdMovChanging(global::System.String value);
        partial void OnstrQtdMovChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idMaterial
        {
            get
            {
                return _idMaterial;
            }
            set
            {
                OnidMaterialChanging(value);
                ReportPropertyChanging("idMaterial");
                _idMaterial = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("idMaterial");
                OnidMaterialChanged();
            }
        }
        private global::System.Int32 _idMaterial;
        partial void OnidMaterialChanging(global::System.Int32 value);
        partial void OnidMaterialChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("materialModel", "FK_movimentacaoEstoque_material", "material")]
        public material material
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<material>("materialModel.FK_movimentacaoEstoque_material", "material").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<material>("materialModel.FK_movimentacaoEstoque_material", "material").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<material> materialReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<material>("materialModel.FK_movimentacaoEstoque_material", "material");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<material>("materialModel.FK_movimentacaoEstoque_material", "material", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}