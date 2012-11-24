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

namespace SGPS.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class hospitalEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new hospitalEntities object using the connection string found in the 'hospitalEntities' section of the application configuration file.
        /// </summary>
        public hospitalEntities() : base("name=hospitalEntities", "hospitalEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new hospitalEntities object.
        /// </summary>
        public hospitalEntities(string connectionString) : base(connectionString, "hospitalEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new hospitalEntities object.
        /// </summary>
        public hospitalEntities(EntityConnection connection) : base(connection, "hospitalEntities")
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
        public ObjectSet<hospital> hospitals
        {
            get
            {
                if ((_hospitals == null))
                {
                    _hospitals = base.CreateObjectSet<hospital>("hospitals");
                }
                return _hospitals;
            }
        }
        private ObjectSet<hospital> _hospitals;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the hospitals EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTohospitals(hospital hospital)
        {
            base.AddObject("hospitals", hospital);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="hospitalModel", Name="hospital")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class hospital : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new hospital object.
        /// </summary>
        /// <param name="idHospital">Initial value of the idHospital property.</param>
        /// <param name="strRazaoSocial">Initial value of the strRazaoSocial property.</param>
        /// <param name="strCNPJ">Initial value of the strCNPJ property.</param>
        /// <param name="strEndereco">Initial value of the strEndereco property.</param>
        /// <param name="strTelefone">Initial value of the strTelefone property.</param>
        public static hospital Createhospital(global::System.Int32 idHospital, global::System.String strRazaoSocial, global::System.String strCNPJ, global::System.String strEndereco, global::System.String strTelefone)
        {
            hospital hospital = new hospital();
            hospital.idHospital = idHospital;
            hospital.strRazaoSocial = strRazaoSocial;
            hospital.strCNPJ = strCNPJ;
            hospital.strEndereco = strEndereco;
            hospital.strTelefone = strTelefone;
            return hospital;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idHospital
        {
            get
            {
                return _idHospital;
            }
            set
            {
                if (_idHospital != value)
                {
                    OnidHospitalChanging(value);
                    ReportPropertyChanging("idHospital");
                    _idHospital = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("idHospital");
                    OnidHospitalChanged();
                }
            }
        }
        private global::System.Int32 _idHospital;
        partial void OnidHospitalChanging(global::System.Int32 value);
        partial void OnidHospitalChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String strRazaoSocial
        {
            get
            {
                return _strRazaoSocial;
            }
            set
            {
                OnstrRazaoSocialChanging(value);
                ReportPropertyChanging("strRazaoSocial");
                _strRazaoSocial = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("strRazaoSocial");
                OnstrRazaoSocialChanged();
            }
        }
        private global::System.String _strRazaoSocial;
        partial void OnstrRazaoSocialChanging(global::System.String value);
        partial void OnstrRazaoSocialChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String strCNPJ
        {
            get
            {
                return _strCNPJ;
            }
            set
            {
                OnstrCNPJChanging(value);
                ReportPropertyChanging("strCNPJ");
                _strCNPJ = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("strCNPJ");
                OnstrCNPJChanged();
            }
        }
        private global::System.String _strCNPJ;
        partial void OnstrCNPJChanging(global::System.String value);
        partial void OnstrCNPJChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String strEndereco
        {
            get
            {
                return _strEndereco;
            }
            set
            {
                OnstrEnderecoChanging(value);
                ReportPropertyChanging("strEndereco");
                _strEndereco = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("strEndereco");
                OnstrEnderecoChanged();
            }
        }
        private global::System.String _strEndereco;
        partial void OnstrEnderecoChanging(global::System.String value);
        partial void OnstrEnderecoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String strTelefone
        {
            get
            {
                return _strTelefone;
            }
            set
            {
                OnstrTelefoneChanging(value);
                ReportPropertyChanging("strTelefone");
                _strTelefone = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("strTelefone");
                OnstrTelefoneChanged();
            }
        }
        private global::System.String _strTelefone;
        partial void OnstrTelefoneChanging(global::System.String value);
        partial void OnstrTelefoneChanged();

        #endregion
    
    }

    #endregion
    
}
