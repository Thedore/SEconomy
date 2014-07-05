﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Model", "fk_transaction_bank_account", "bank_account", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Wolfje.Plugins.SEconomy.Journal.MySQLJournal.Database.bank_account), "bank_account_transaction", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Wolfje.Plugins.SEconomy.Journal.MySQLJournal.Database.bank_account_transaction), true)]
[assembly: EdmRelationshipAttribute("Model", "fk_transaction_transaction", "bank_account_transaction", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Wolfje.Plugins.SEconomy.Journal.MySQLJournal.Database.bank_account_transaction), "bank_account_transaction1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Wolfje.Plugins.SEconomy.Journal.MySQLJournal.Database.bank_account_transaction), true)]

#endregion

namespace Wolfje.Plugins.SEconomy.Journal.MySQLJournal.Database
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Context : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Context object using the connection string found in the 'Context' section of the application configuration file.
        /// </summary>
        public Context() : base("name=Context", "Context")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Context object.
        /// </summary>
        public Context(string connectionString) : base(connectionString, "Context")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Context object.
        /// </summary>
        public Context(EntityConnection connection) : base(connection, "Context")
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
        public ObjectSet<bank_account> bank_account
        {
            get
            {
                if ((_bank_account == null))
                {
                    _bank_account = base.CreateObjectSet<bank_account>("bank_account");
                }
                return _bank_account;
            }
        }
        private ObjectSet<bank_account> _bank_account;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<bank_account_transaction> bank_account_transaction
        {
            get
            {
                if ((_bank_account_transaction == null))
                {
                    _bank_account_transaction = base.CreateObjectSet<bank_account_transaction>("bank_account_transaction");
                }
                return _bank_account_transaction;
            }
        }
        private ObjectSet<bank_account_transaction> _bank_account_transaction;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the bank_account EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTobank_account(bank_account bank_account)
        {
            base.AddObject("bank_account", bank_account);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the bank_account_transaction EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTobank_account_transaction(bank_account_transaction bank_account_transaction)
        {
            base.AddObject("bank_account_transaction", bank_account_transaction);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="bank_account")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class bank_account : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new bank_account object.
        /// </summary>
        /// <param name="bank_account_id">Initial value of the bank_account_id property.</param>
        /// <param name="user_account_name">Initial value of the user_account_name property.</param>
        /// <param name="world_id">Initial value of the world_id property.</param>
        /// <param name="flags">Initial value of the flags property.</param>
        /// <param name="flags2">Initial value of the flags2 property.</param>
        /// <param name="description">Initial value of the description property.</param>
        public static bank_account Createbank_account(global::System.Int64 bank_account_id, global::System.String user_account_name, global::System.Int64 world_id, global::System.Int32 flags, global::System.Int32 flags2, global::System.String description)
        {
            bank_account bank_account = new bank_account();
            bank_account.bank_account_id = bank_account_id;
            bank_account.user_account_name = user_account_name;
            bank_account.world_id = world_id;
            bank_account.flags = flags;
            bank_account.flags2 = flags2;
            bank_account.description = description;
            return bank_account;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 bank_account_id
        {
            get
            {
                return _bank_account_id;
            }
            set
            {
                if (_bank_account_id != value)
                {
                    Onbank_account_idChanging(value);
                    ReportPropertyChanging("bank_account_id");
                    _bank_account_id = StructuralObject.SetValidValue(value, "bank_account_id");
                    ReportPropertyChanged("bank_account_id");
                    Onbank_account_idChanged();
                }
            }
        }
        private global::System.Int64 _bank_account_id;
        partial void Onbank_account_idChanging(global::System.Int64 value);
        partial void Onbank_account_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String user_account_name
        {
            get
            {
                return _user_account_name;
            }
            set
            {
                Onuser_account_nameChanging(value);
                ReportPropertyChanging("user_account_name");
                _user_account_name = StructuralObject.SetValidValue(value, false, "user_account_name");
                ReportPropertyChanged("user_account_name");
                Onuser_account_nameChanged();
            }
        }
        private global::System.String _user_account_name;
        partial void Onuser_account_nameChanging(global::System.String value);
        partial void Onuser_account_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 world_id
        {
            get
            {
                return _world_id;
            }
            set
            {
                Onworld_idChanging(value);
                ReportPropertyChanging("world_id");
                _world_id = StructuralObject.SetValidValue(value, "world_id");
                ReportPropertyChanged("world_id");
                Onworld_idChanged();
            }
        }
        private global::System.Int64 _world_id;
        partial void Onworld_idChanging(global::System.Int64 value);
        partial void Onworld_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 flags
        {
            get
            {
                return _flags;
            }
            set
            {
                OnflagsChanging(value);
                ReportPropertyChanging("flags");
                _flags = StructuralObject.SetValidValue(value, "flags");
                ReportPropertyChanged("flags");
                OnflagsChanged();
            }
        }
        private global::System.Int32 _flags;
        partial void OnflagsChanging(global::System.Int32 value);
        partial void OnflagsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 flags2
        {
            get
            {
                return _flags2;
            }
            set
            {
                Onflags2Changing(value);
                ReportPropertyChanging("flags2");
                _flags2 = StructuralObject.SetValidValue(value, "flags2");
                ReportPropertyChanged("flags2");
                Onflags2Changed();
            }
        }
        private global::System.Int32 _flags2;
        partial void Onflags2Changing(global::System.Int32 value);
        partial void Onflags2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String description
        {
            get
            {
                return _description;
            }
            set
            {
                OndescriptionChanging(value);
                ReportPropertyChanging("description");
                _description = StructuralObject.SetValidValue(value, false, "description");
                ReportPropertyChanged("description");
                OndescriptionChanged();
            }
        }
        private global::System.String _description;
        partial void OndescriptionChanging(global::System.String value);
        partial void OndescriptionChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "fk_transaction_bank_account", "bank_account_transaction")]
        public EntityCollection<bank_account_transaction> bank_account_transactions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<bank_account_transaction>("Model.fk_transaction_bank_account", "bank_account_transaction");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<bank_account_transaction>("Model.fk_transaction_bank_account", "bank_account_transaction", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="bank_account_transaction")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class bank_account_transaction : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new bank_account_transaction object.
        /// </summary>
        /// <param name="bank_account_transaction_id">Initial value of the bank_account_transaction_id property.</param>
        /// <param name="bank_account_fk">Initial value of the bank_account_fk property.</param>
        /// <param name="amount">Initial value of the amount property.</param>
        /// <param name="flags">Initial value of the flags property.</param>
        /// <param name="flags2">Initial value of the flags2 property.</param>
        /// <param name="transaction_date_utc">Initial value of the transaction_date_utc property.</param>
        public static bank_account_transaction Createbank_account_transaction(global::System.Int64 bank_account_transaction_id, global::System.Int64 bank_account_fk, global::System.Int64 amount, global::System.Int32 flags, global::System.Int32 flags2, global::System.DateTime transaction_date_utc)
        {
            bank_account_transaction bank_account_transaction = new bank_account_transaction();
            bank_account_transaction.bank_account_transaction_id = bank_account_transaction_id;
            bank_account_transaction.bank_account_fk = bank_account_fk;
            bank_account_transaction.amount = amount;
            bank_account_transaction.flags = flags;
            bank_account_transaction.flags2 = flags2;
            bank_account_transaction.transaction_date_utc = transaction_date_utc;
            return bank_account_transaction;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 bank_account_transaction_id
        {
            get
            {
                return _bank_account_transaction_id;
            }
            set
            {
                if (_bank_account_transaction_id != value)
                {
                    Onbank_account_transaction_idChanging(value);
                    ReportPropertyChanging("bank_account_transaction_id");
                    _bank_account_transaction_id = StructuralObject.SetValidValue(value, "bank_account_transaction_id");
                    ReportPropertyChanged("bank_account_transaction_id");
                    Onbank_account_transaction_idChanged();
                }
            }
        }
        private global::System.Int64 _bank_account_transaction_id;
        partial void Onbank_account_transaction_idChanging(global::System.Int64 value);
        partial void Onbank_account_transaction_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> bank_account_transaction_fk
        {
            get
            {
                return _bank_account_transaction_fk;
            }
            set
            {
                Onbank_account_transaction_fkChanging(value);
                ReportPropertyChanging("bank_account_transaction_fk");
                _bank_account_transaction_fk = StructuralObject.SetValidValue(value, "bank_account_transaction_fk");
                ReportPropertyChanged("bank_account_transaction_fk");
                Onbank_account_transaction_fkChanged();
            }
        }
        private Nullable<global::System.Int64> _bank_account_transaction_fk;
        partial void Onbank_account_transaction_fkChanging(Nullable<global::System.Int64> value);
        partial void Onbank_account_transaction_fkChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 bank_account_fk
        {
            get
            {
                return _bank_account_fk;
            }
            set
            {
                Onbank_account_fkChanging(value);
                ReportPropertyChanging("bank_account_fk");
                _bank_account_fk = StructuralObject.SetValidValue(value, "bank_account_fk");
                ReportPropertyChanged("bank_account_fk");
                Onbank_account_fkChanged();
            }
        }
        private global::System.Int64 _bank_account_fk;
        partial void Onbank_account_fkChanging(global::System.Int64 value);
        partial void Onbank_account_fkChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 amount
        {
            get
            {
                return _amount;
            }
            set
            {
                OnamountChanging(value);
                ReportPropertyChanging("amount");
                _amount = StructuralObject.SetValidValue(value, "amount");
                ReportPropertyChanged("amount");
                OnamountChanged();
            }
        }
        private global::System.Int64 _amount;
        partial void OnamountChanging(global::System.Int64 value);
        partial void OnamountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String message
        {
            get
            {
                return _message;
            }
            set
            {
                OnmessageChanging(value);
                ReportPropertyChanging("message");
                _message = StructuralObject.SetValidValue(value, true, "message");
                ReportPropertyChanged("message");
                OnmessageChanged();
            }
        }
        private global::System.String _message;
        partial void OnmessageChanging(global::System.String value);
        partial void OnmessageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 flags
        {
            get
            {
                return _flags;
            }
            set
            {
                OnflagsChanging(value);
                ReportPropertyChanging("flags");
                _flags = StructuralObject.SetValidValue(value, "flags");
                ReportPropertyChanged("flags");
                OnflagsChanged();
            }
        }
        private global::System.Int32 _flags;
        partial void OnflagsChanging(global::System.Int32 value);
        partial void OnflagsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 flags2
        {
            get
            {
                return _flags2;
            }
            set
            {
                Onflags2Changing(value);
                ReportPropertyChanging("flags2");
                _flags2 = StructuralObject.SetValidValue(value, "flags2");
                ReportPropertyChanged("flags2");
                Onflags2Changed();
            }
        }
        private global::System.Int32 _flags2;
        partial void Onflags2Changing(global::System.Int32 value);
        partial void Onflags2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime transaction_date_utc
        {
            get
            {
                return _transaction_date_utc;
            }
            set
            {
                Ontransaction_date_utcChanging(value);
                ReportPropertyChanging("transaction_date_utc");
                _transaction_date_utc = StructuralObject.SetValidValue(value, "transaction_date_utc");
                ReportPropertyChanged("transaction_date_utc");
                Ontransaction_date_utcChanged();
            }
        }
        private global::System.DateTime _transaction_date_utc;
        partial void Ontransaction_date_utcChanging(global::System.DateTime value);
        partial void Ontransaction_date_utcChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "fk_transaction_bank_account", "bank_account")]
        public bank_account bank_account
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<bank_account>("Model.fk_transaction_bank_account", "bank_account").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<bank_account>("Model.fk_transaction_bank_account", "bank_account").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<bank_account> bank_accountReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<bank_account>("Model.fk_transaction_bank_account", "bank_account");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<bank_account>("Model.fk_transaction_bank_account", "bank_account", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "fk_transaction_transaction", "bank_account_transaction1")]
        public EntityCollection<bank_account_transaction> bank_account_transactions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<bank_account_transaction>("Model.fk_transaction_transaction", "bank_account_transaction1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<bank_account_transaction>("Model.fk_transaction_transaction", "bank_account_transaction1", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "fk_transaction_transaction", "bank_account_transaction")]
        public bank_account_transaction bank_account_transaction_inverse
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<bank_account_transaction>("Model.fk_transaction_transaction", "bank_account_transaction").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<bank_account_transaction>("Model.fk_transaction_transaction", "bank_account_transaction").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<bank_account_transaction> bank_account_transaction_inverseReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<bank_account_transaction>("Model.fk_transaction_transaction", "bank_account_transaction");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<bank_account_transaction>("Model.fk_transaction_transaction", "bank_account_transaction", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
