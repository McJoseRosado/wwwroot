///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Entity class which represents the entity 'User'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class UserEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<AssetReclamationServiceChangeLogEntity> _assetReclamationServiceChangeLog;
		private EntityCollection<ChangeLogEntity> _changeLog;
		private EntityCollection<DeepFryerServiceChangeLogEntity> _deepFryerServiceChangeLog;
		private EntityCollection<RebateEntity> _rebate;
		private EntityCollection<RecycleServiceActionEntity> _recycleServiceAction_;
		private EntityCollection<RecycleServiceActionEntity> _recycleServiceAction;
		private EntityCollection<RecycleServiceChangeLogEntity> _recycleServiceChangeLog;
		private EntityCollection<UserAccountEntity> _userAccount;
		private EntityCollection<AccountEntity> _accountCollectionViaRebate;
		private EntityCollection<AccountEntity> _accountCollectionViaUserAccount;
		private EntityCollection<AssetReclamationServiceEntity> _assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog;
		private EntityCollection<ChangeTypeEntity> _changeTypeCollectionViaChangeLog;
		private EntityCollection<DeepFryerServiceEntity> _deepFryerServiceCollectionViaDeepFryerServiceChangeLog;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaRecycleServiceAction_;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaRecycleServiceAction;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaRecycleServiceChangeLog;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaRecycleServiceAction___;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaRecycleServiceAction__;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaDeepFryerServiceChangeLog;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaDeepFryerServiceChangeLog_;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaAssetReclamationServiceChangeLog;
		private EntityCollection<RebateTypeEntity> _rebateTypeCollectionViaRebate;
		private EntityCollection<RecycleServiceEntity> _recycleServiceCollectionViaRecycleServiceChangeLog;
		private EntityCollection<RecycleServiceEntity> _recycleServiceCollectionViaRecycleServiceAction_;
		private EntityCollection<RecycleServiceEntity> _recycleServiceCollectionViaRecycleServiceAction;
		private EntityCollection<RecycleTypeEntity> _recycleTypeCollectionViaRecycleServiceAction;
		private EntityCollection<RecycleTypeEntity> _recycleTypeCollectionViaRecycleServiceAction_;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaDeepFryerServiceChangeLog;
		private UserTypeEntity _userType;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name UserType</summary>
			public static readonly string UserType = "UserType";
			/// <summary>Member name AssetReclamationServiceChangeLog</summary>
			public static readonly string AssetReclamationServiceChangeLog = "AssetReclamationServiceChangeLog";
			/// <summary>Member name ChangeLog</summary>
			public static readonly string ChangeLog = "ChangeLog";
			/// <summary>Member name DeepFryerServiceChangeLog</summary>
			public static readonly string DeepFryerServiceChangeLog = "DeepFryerServiceChangeLog";
			/// <summary>Member name Rebate</summary>
			public static readonly string Rebate = "Rebate";
			/// <summary>Member name RecycleServiceAction_</summary>
			public static readonly string RecycleServiceAction_ = "RecycleServiceAction_";
			/// <summary>Member name RecycleServiceAction</summary>
			public static readonly string RecycleServiceAction = "RecycleServiceAction";
			/// <summary>Member name RecycleServiceChangeLog</summary>
			public static readonly string RecycleServiceChangeLog = "RecycleServiceChangeLog";
			/// <summary>Member name UserAccount</summary>
			public static readonly string UserAccount = "UserAccount";
			/// <summary>Member name AccountCollectionViaRebate</summary>
			public static readonly string AccountCollectionViaRebate = "AccountCollectionViaRebate";
			/// <summary>Member name AccountCollectionViaUserAccount</summary>
			public static readonly string AccountCollectionViaUserAccount = "AccountCollectionViaUserAccount";
			/// <summary>Member name AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog</summary>
			public static readonly string AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog";
			/// <summary>Member name ChangeTypeCollectionViaChangeLog</summary>
			public static readonly string ChangeTypeCollectionViaChangeLog = "ChangeTypeCollectionViaChangeLog";
			/// <summary>Member name DeepFryerServiceCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string DeepFryerServiceCollectionViaDeepFryerServiceChangeLog = "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceAction_</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceAction_ = "EmployeeCollectionViaRecycleServiceAction_";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceAction</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceAction = "EmployeeCollectionViaRecycleServiceAction";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceChangeLog</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceChangeLog = "EmployeeCollectionViaRecycleServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceAction___</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceAction___ = "EmployeeCollectionViaRecycleServiceAction___";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceAction__</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceAction__ = "EmployeeCollectionViaRecycleServiceAction__";
			/// <summary>Member name EmployeeCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string EmployeeCollectionViaDeepFryerServiceChangeLog = "EmployeeCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaDeepFryerServiceChangeLog_</summary>
			public static readonly string EmployeeCollectionViaDeepFryerServiceChangeLog_ = "EmployeeCollectionViaDeepFryerServiceChangeLog_";
			/// <summary>Member name EmployeeCollectionViaAssetReclamationServiceChangeLog</summary>
			public static readonly string EmployeeCollectionViaAssetReclamationServiceChangeLog = "EmployeeCollectionViaAssetReclamationServiceChangeLog";
			/// <summary>Member name RebateTypeCollectionViaRebate</summary>
			public static readonly string RebateTypeCollectionViaRebate = "RebateTypeCollectionViaRebate";
			/// <summary>Member name RecycleServiceCollectionViaRecycleServiceChangeLog</summary>
			public static readonly string RecycleServiceCollectionViaRecycleServiceChangeLog = "RecycleServiceCollectionViaRecycleServiceChangeLog";
			/// <summary>Member name RecycleServiceCollectionViaRecycleServiceAction_</summary>
			public static readonly string RecycleServiceCollectionViaRecycleServiceAction_ = "RecycleServiceCollectionViaRecycleServiceAction_";
			/// <summary>Member name RecycleServiceCollectionViaRecycleServiceAction</summary>
			public static readonly string RecycleServiceCollectionViaRecycleServiceAction = "RecycleServiceCollectionViaRecycleServiceAction";
			/// <summary>Member name RecycleTypeCollectionViaRecycleServiceAction</summary>
			public static readonly string RecycleTypeCollectionViaRecycleServiceAction = "RecycleTypeCollectionViaRecycleServiceAction";
			/// <summary>Member name RecycleTypeCollectionViaRecycleServiceAction_</summary>
			public static readonly string RecycleTypeCollectionViaRecycleServiceAction_ = "RecycleTypeCollectionViaRecycleServiceAction_";
			/// <summary>Member name ServiceLocationCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string ServiceLocationCollectionViaDeepFryerServiceChangeLog = "ServiceLocationCollectionViaDeepFryerServiceChangeLog";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UserEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public UserEntity():base("UserEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UserEntity(IEntityFields2 fields):base("UserEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(IValidator validator):base("UserEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public UserEntity(System.Int32 userId):base("UserEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.UserId = userId;
		}

		/// <summary> CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public UserEntity(System.Int32 userId, IValidator validator):base("UserEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.UserId = userId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected UserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_assetReclamationServiceChangeLog = (EntityCollection<AssetReclamationServiceChangeLogEntity>)info.GetValue("_assetReclamationServiceChangeLog", typeof(EntityCollection<AssetReclamationServiceChangeLogEntity>));
				_changeLog = (EntityCollection<ChangeLogEntity>)info.GetValue("_changeLog", typeof(EntityCollection<ChangeLogEntity>));
				_deepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceChangeLogEntity>)info.GetValue("_deepFryerServiceChangeLog", typeof(EntityCollection<DeepFryerServiceChangeLogEntity>));
				_rebate = (EntityCollection<RebateEntity>)info.GetValue("_rebate", typeof(EntityCollection<RebateEntity>));
				_recycleServiceAction_ = (EntityCollection<RecycleServiceActionEntity>)info.GetValue("_recycleServiceAction_", typeof(EntityCollection<RecycleServiceActionEntity>));
				_recycleServiceAction = (EntityCollection<RecycleServiceActionEntity>)info.GetValue("_recycleServiceAction", typeof(EntityCollection<RecycleServiceActionEntity>));
				_recycleServiceChangeLog = (EntityCollection<RecycleServiceChangeLogEntity>)info.GetValue("_recycleServiceChangeLog", typeof(EntityCollection<RecycleServiceChangeLogEntity>));
				_userAccount = (EntityCollection<UserAccountEntity>)info.GetValue("_userAccount", typeof(EntityCollection<UserAccountEntity>));
				_accountCollectionViaRebate = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaRebate", typeof(EntityCollection<AccountEntity>));
				_accountCollectionViaUserAccount = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaUserAccount", typeof(EntityCollection<AccountEntity>));
				_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<AssetReclamationServiceEntity>)info.GetValue("_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", typeof(EntityCollection<AssetReclamationServiceEntity>));
				_changeTypeCollectionViaChangeLog = (EntityCollection<ChangeTypeEntity>)info.GetValue("_changeTypeCollectionViaChangeLog", typeof(EntityCollection<ChangeTypeEntity>));
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceEntity>)info.GetValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<DeepFryerServiceEntity>));
				_employeeCollectionViaRecycleServiceAction_ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaRecycleServiceAction_", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaRecycleServiceAction = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaRecycleServiceAction", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaRecycleServiceChangeLog = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaRecycleServiceChangeLog", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaRecycleServiceAction___ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaRecycleServiceAction___", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaRecycleServiceAction__ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaRecycleServiceAction__", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaDeepFryerServiceChangeLog = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog_", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaAssetReclamationServiceChangeLog", typeof(EntityCollection<EmployeeEntity>));
				_rebateTypeCollectionViaRebate = (EntityCollection<RebateTypeEntity>)info.GetValue("_rebateTypeCollectionViaRebate", typeof(EntityCollection<RebateTypeEntity>));
				_recycleServiceCollectionViaRecycleServiceChangeLog = (EntityCollection<RecycleServiceEntity>)info.GetValue("_recycleServiceCollectionViaRecycleServiceChangeLog", typeof(EntityCollection<RecycleServiceEntity>));
				_recycleServiceCollectionViaRecycleServiceAction_ = (EntityCollection<RecycleServiceEntity>)info.GetValue("_recycleServiceCollectionViaRecycleServiceAction_", typeof(EntityCollection<RecycleServiceEntity>));
				_recycleServiceCollectionViaRecycleServiceAction = (EntityCollection<RecycleServiceEntity>)info.GetValue("_recycleServiceCollectionViaRecycleServiceAction", typeof(EntityCollection<RecycleServiceEntity>));
				_recycleTypeCollectionViaRecycleServiceAction = (EntityCollection<RecycleTypeEntity>)info.GetValue("_recycleTypeCollectionViaRecycleServiceAction", typeof(EntityCollection<RecycleTypeEntity>));
				_recycleTypeCollectionViaRecycleServiceAction_ = (EntityCollection<RecycleTypeEntity>)info.GetValue("_recycleTypeCollectionViaRecycleServiceAction_", typeof(EntityCollection<RecycleTypeEntity>));
				_serviceLocationCollectionViaDeepFryerServiceChangeLog = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<ServiceLocationEntity>));
				_userType = (UserTypeEntity)info.GetValue("_userType", typeof(UserTypeEntity));
				if(_userType!=null)
				{
					_userType.AfterSave+=new EventHandler(OnEntityAfterSave);
				}

				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((UserFieldIndex)fieldIndex)
			{
				case UserFieldIndex.UserTypeId:
					DesetupSyncUserType(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
				
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{
				case "UserType":
					this.UserType = (UserTypeEntity)entity;
					break;
				case "AssetReclamationServiceChangeLog":
					this.AssetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)entity);
					break;
				case "ChangeLog":
					this.ChangeLog.Add((ChangeLogEntity)entity);
					break;
				case "DeepFryerServiceChangeLog":
					this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)entity);
					break;
				case "Rebate":
					this.Rebate.Add((RebateEntity)entity);
					break;
				case "RecycleServiceAction_":
					this.RecycleServiceAction_.Add((RecycleServiceActionEntity)entity);
					break;
				case "RecycleServiceAction":
					this.RecycleServiceAction.Add((RecycleServiceActionEntity)entity);
					break;
				case "RecycleServiceChangeLog":
					this.RecycleServiceChangeLog.Add((RecycleServiceChangeLogEntity)entity);
					break;
				case "UserAccount":
					this.UserAccount.Add((UserAccountEntity)entity);
					break;
				case "AccountCollectionViaRebate":
					this.AccountCollectionViaRebate.IsReadOnly = false;
					this.AccountCollectionViaRebate.Add((AccountEntity)entity);
					this.AccountCollectionViaRebate.IsReadOnly = true;
					break;
				case "AccountCollectionViaUserAccount":
					this.AccountCollectionViaUserAccount.IsReadOnly = false;
					this.AccountCollectionViaUserAccount.Add((AccountEntity)entity);
					this.AccountCollectionViaUserAccount.IsReadOnly = true;
					break;
				case "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog":
					this.AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = false;
					this.AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.Add((AssetReclamationServiceEntity)entity);
					this.AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = true;
					break;
				case "ChangeTypeCollectionViaChangeLog":
					this.ChangeTypeCollectionViaChangeLog.IsReadOnly = false;
					this.ChangeTypeCollectionViaChangeLog.Add((ChangeTypeEntity)entity);
					this.ChangeTypeCollectionViaChangeLog.IsReadOnly = true;
					break;
				case "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog":
					this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog.Add((DeepFryerServiceEntity)entity);
					this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaRecycleServiceAction_":
					this.EmployeeCollectionViaRecycleServiceAction_.IsReadOnly = false;
					this.EmployeeCollectionViaRecycleServiceAction_.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaRecycleServiceAction_.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaRecycleServiceAction":
					this.EmployeeCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.EmployeeCollectionViaRecycleServiceAction.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaRecycleServiceAction.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaRecycleServiceChangeLog":
					this.EmployeeCollectionViaRecycleServiceChangeLog.IsReadOnly = false;
					this.EmployeeCollectionViaRecycleServiceChangeLog.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaRecycleServiceChangeLog.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaRecycleServiceAction___":
					this.EmployeeCollectionViaRecycleServiceAction___.IsReadOnly = false;
					this.EmployeeCollectionViaRecycleServiceAction___.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaRecycleServiceAction___.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaRecycleServiceAction__":
					this.EmployeeCollectionViaRecycleServiceAction__.IsReadOnly = false;
					this.EmployeeCollectionViaRecycleServiceAction__.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaRecycleServiceAction__.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog":
					this.EmployeeCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.EmployeeCollectionViaDeepFryerServiceChangeLog.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog_":
					this.EmployeeCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = false;
					this.EmployeeCollectionViaDeepFryerServiceChangeLog_.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaAssetReclamationServiceChangeLog":
					this.EmployeeCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = false;
					this.EmployeeCollectionViaAssetReclamationServiceChangeLog.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = true;
					break;
				case "RebateTypeCollectionViaRebate":
					this.RebateTypeCollectionViaRebate.IsReadOnly = false;
					this.RebateTypeCollectionViaRebate.Add((RebateTypeEntity)entity);
					this.RebateTypeCollectionViaRebate.IsReadOnly = true;
					break;
				case "RecycleServiceCollectionViaRecycleServiceChangeLog":
					this.RecycleServiceCollectionViaRecycleServiceChangeLog.IsReadOnly = false;
					this.RecycleServiceCollectionViaRecycleServiceChangeLog.Add((RecycleServiceEntity)entity);
					this.RecycleServiceCollectionViaRecycleServiceChangeLog.IsReadOnly = true;
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction_":
					this.RecycleServiceCollectionViaRecycleServiceAction_.IsReadOnly = false;
					this.RecycleServiceCollectionViaRecycleServiceAction_.Add((RecycleServiceEntity)entity);
					this.RecycleServiceCollectionViaRecycleServiceAction_.IsReadOnly = true;
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction":
					this.RecycleServiceCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.RecycleServiceCollectionViaRecycleServiceAction.Add((RecycleServiceEntity)entity);
					this.RecycleServiceCollectionViaRecycleServiceAction.IsReadOnly = true;
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction":
					this.RecycleTypeCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.RecycleTypeCollectionViaRecycleServiceAction.Add((RecycleTypeEntity)entity);
					this.RecycleTypeCollectionViaRecycleServiceAction.IsReadOnly = true;
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction_":
					this.RecycleTypeCollectionViaRecycleServiceAction_.IsReadOnly = false;
					this.RecycleTypeCollectionViaRecycleServiceAction_.Add((RecycleTypeEntity)entity);
					this.RecycleTypeCollectionViaRecycleServiceAction_.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog":
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
					break;

				default:
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return UserEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "UserType":
					toReturn.Add(UserEntity.Relations.UserTypeEntityUsingUserTypeId);
					break;
				case "AssetReclamationServiceChangeLog":
					toReturn.Add(UserEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByUserId);
					break;
				case "ChangeLog":
					toReturn.Add(UserEntity.Relations.ChangeLogEntityUsingUserId);
					break;
				case "DeepFryerServiceChangeLog":
					toReturn.Add(UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId);
					break;
				case "Rebate":
					toReturn.Add(UserEntity.Relations.RebateEntityUsingEnteredByUserId);
					break;
				case "RecycleServiceAction_":
					toReturn.Add(UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId);
					break;
				case "RecycleServiceAction":
					toReturn.Add(UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId);
					break;
				case "RecycleServiceChangeLog":
					toReturn.Add(UserEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByUserId);
					break;
				case "UserAccount":
					toReturn.Add(UserEntity.Relations.UserAccountEntityUsingUserId);
					break;
				case "AccountCollectionViaRebate":
					toReturn.Add(UserEntity.Relations.RebateEntityUsingEnteredByUserId, "UserEntity__", "Rebate_", JoinHint.None);
					toReturn.Add(RebateEntity.Relations.AccountEntityUsingAccountId, "Rebate_", string.Empty, JoinHint.None);
					break;
				case "AccountCollectionViaUserAccount":
					toReturn.Add(UserEntity.Relations.UserAccountEntityUsingUserId, "UserEntity__", "UserAccount_", JoinHint.None);
					toReturn.Add(UserAccountEntity.Relations.AccountEntityUsingAccountId, "UserAccount_", string.Empty, JoinHint.None);
					break;
				case "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog":
					toReturn.Add(UserEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByUserId, "UserEntity__", "AssetReclamationServiceChangeLog_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceChangeLogEntity.Relations.AssetReclamationServiceEntityUsingAssetReclamationServiceId, "AssetReclamationServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "ChangeTypeCollectionViaChangeLog":
					toReturn.Add(UserEntity.Relations.ChangeLogEntityUsingUserId, "UserEntity__", "ChangeLog_", JoinHint.None);
					toReturn.Add(ChangeLogEntity.Relations.ChangeTypeEntityUsingChangeTypeId, "ChangeLog_", string.Empty, JoinHint.None);
					break;
				case "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId, "UserEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.DeepFryerServiceEntityUsingDeepFryerServiceId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceAction_":
					toReturn.Add(UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId, "UserEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingActionEmployeeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceAction":
					toReturn.Add(UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId, "UserEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingLastChangedByEmployeeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceChangeLog":
					toReturn.Add(UserEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByUserId, "UserEntity__", "RecycleServiceChangeLog_", JoinHint.None);
					toReturn.Add(RecycleServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, "RecycleServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceAction___":
					toReturn.Add(UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId, "UserEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingActionEmployeeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceAction__":
					toReturn.Add(UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId, "UserEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingLastChangedByEmployeeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId, "UserEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog_":
					toReturn.Add(UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId, "UserEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingServicedBy, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAssetReclamationServiceChangeLog":
					toReturn.Add(UserEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByUserId, "UserEntity__", "AssetReclamationServiceChangeLog_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, "AssetReclamationServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "RebateTypeCollectionViaRebate":
					toReturn.Add(UserEntity.Relations.RebateEntityUsingEnteredByUserId, "UserEntity__", "Rebate_", JoinHint.None);
					toReturn.Add(RebateEntity.Relations.RebateTypeEntityUsingRebateTypeId, "Rebate_", string.Empty, JoinHint.None);
					break;
				case "RecycleServiceCollectionViaRecycleServiceChangeLog":
					toReturn.Add(UserEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByUserId, "UserEntity__", "RecycleServiceChangeLog_", JoinHint.None);
					toReturn.Add(RecycleServiceChangeLogEntity.Relations.RecycleServiceEntityUsingRecycleServiceId, "RecycleServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction_":
					toReturn.Add(UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId, "UserEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleServiceEntityUsingRecycleServiceId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction":
					toReturn.Add(UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId, "UserEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleServiceEntityUsingRecycleServiceId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction":
					toReturn.Add(UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId, "UserEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction_":
					toReturn.Add(UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId, "UserEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId, "UserEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;

				default:

					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it
		/// will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckOneWayRelations(string propertyName)
		{
			// use template trick to calculate the # of single-sided / oneway relations
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));


				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "UserType":
					SetupSyncUserType(relatedEntity);
					break;
				case "AssetReclamationServiceChangeLog":
					this.AssetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)relatedEntity);
					break;
				case "ChangeLog":
					this.ChangeLog.Add((ChangeLogEntity)relatedEntity);
					break;
				case "DeepFryerServiceChangeLog":
					this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)relatedEntity);
					break;
				case "Rebate":
					this.Rebate.Add((RebateEntity)relatedEntity);
					break;
				case "RecycleServiceAction_":
					this.RecycleServiceAction_.Add((RecycleServiceActionEntity)relatedEntity);
					break;
				case "RecycleServiceAction":
					this.RecycleServiceAction.Add((RecycleServiceActionEntity)relatedEntity);
					break;
				case "RecycleServiceChangeLog":
					this.RecycleServiceChangeLog.Add((RecycleServiceChangeLogEntity)relatedEntity);
					break;
				case "UserAccount":
					this.UserAccount.Add((UserAccountEntity)relatedEntity);
					break;

				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "UserType":
					DesetupSyncUserType(false, true);
					break;
				case "AssetReclamationServiceChangeLog":
					base.PerformRelatedEntityRemoval(this.AssetReclamationServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ChangeLog":
					base.PerformRelatedEntityRemoval(this.ChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerServiceChangeLog":
					base.PerformRelatedEntityRemoval(this.DeepFryerServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Rebate":
					base.PerformRelatedEntityRemoval(this.Rebate, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleServiceAction_":
					base.PerformRelatedEntityRemoval(this.RecycleServiceAction_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleServiceAction":
					base.PerformRelatedEntityRemoval(this.RecycleServiceAction, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleServiceChangeLog":
					base.PerformRelatedEntityRemoval(this.RecycleServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "UserAccount":
					base.PerformRelatedEntityRemoval(this.UserAccount, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_userType!=null)
			{
				toReturn.Add(_userType);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.AssetReclamationServiceChangeLog);
			toReturn.Add(this.ChangeLog);
			toReturn.Add(this.DeepFryerServiceChangeLog);
			toReturn.Add(this.Rebate);
			toReturn.Add(this.RecycleServiceAction_);
			toReturn.Add(this.RecycleServiceAction);
			toReturn.Add(this.RecycleServiceChangeLog);
			toReturn.Add(this.UserAccount);

			return toReturn;
		}
		


		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_assetReclamationServiceChangeLog", ((_assetReclamationServiceChangeLog!=null) && (_assetReclamationServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_assetReclamationServiceChangeLog:null);
				info.AddValue("_changeLog", ((_changeLog!=null) && (_changeLog.Count>0) && !this.MarkedForDeletion)?_changeLog:null);
				info.AddValue("_deepFryerServiceChangeLog", ((_deepFryerServiceChangeLog!=null) && (_deepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_deepFryerServiceChangeLog:null);
				info.AddValue("_rebate", ((_rebate!=null) && (_rebate.Count>0) && !this.MarkedForDeletion)?_rebate:null);
				info.AddValue("_recycleServiceAction_", ((_recycleServiceAction_!=null) && (_recycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_recycleServiceAction_:null);
				info.AddValue("_recycleServiceAction", ((_recycleServiceAction!=null) && (_recycleServiceAction.Count>0) && !this.MarkedForDeletion)?_recycleServiceAction:null);
				info.AddValue("_recycleServiceChangeLog", ((_recycleServiceChangeLog!=null) && (_recycleServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_recycleServiceChangeLog:null);
				info.AddValue("_userAccount", ((_userAccount!=null) && (_userAccount.Count>0) && !this.MarkedForDeletion)?_userAccount:null);
				info.AddValue("_accountCollectionViaRebate", ((_accountCollectionViaRebate!=null) && (_accountCollectionViaRebate.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaRebate:null);
				info.AddValue("_accountCollectionViaUserAccount", ((_accountCollectionViaUserAccount!=null) && (_accountCollectionViaUserAccount.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaUserAccount:null);
				info.AddValue("_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", ((_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog!=null) && (_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog:null);
				info.AddValue("_changeTypeCollectionViaChangeLog", ((_changeTypeCollectionViaChangeLog!=null) && (_changeTypeCollectionViaChangeLog.Count>0) && !this.MarkedForDeletion)?_changeTypeCollectionViaChangeLog:null);
				info.AddValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", ((_deepFryerServiceCollectionViaDeepFryerServiceChangeLog!=null) && (_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_deepFryerServiceCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_employeeCollectionViaRecycleServiceAction_", ((_employeeCollectionViaRecycleServiceAction_!=null) && (_employeeCollectionViaRecycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaRecycleServiceAction_:null);
				info.AddValue("_employeeCollectionViaRecycleServiceAction", ((_employeeCollectionViaRecycleServiceAction!=null) && (_employeeCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaRecycleServiceAction:null);
				info.AddValue("_employeeCollectionViaRecycleServiceChangeLog", ((_employeeCollectionViaRecycleServiceChangeLog!=null) && (_employeeCollectionViaRecycleServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaRecycleServiceChangeLog:null);
				info.AddValue("_employeeCollectionViaRecycleServiceAction___", ((_employeeCollectionViaRecycleServiceAction___!=null) && (_employeeCollectionViaRecycleServiceAction___.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaRecycleServiceAction___:null);
				info.AddValue("_employeeCollectionViaRecycleServiceAction__", ((_employeeCollectionViaRecycleServiceAction__!=null) && (_employeeCollectionViaRecycleServiceAction__.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaRecycleServiceAction__:null);
				info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog", ((_employeeCollectionViaDeepFryerServiceChangeLog!=null) && (_employeeCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog_", ((_employeeCollectionViaDeepFryerServiceChangeLog_!=null) && (_employeeCollectionViaDeepFryerServiceChangeLog_.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaDeepFryerServiceChangeLog_:null);
				info.AddValue("_employeeCollectionViaAssetReclamationServiceChangeLog", ((_employeeCollectionViaAssetReclamationServiceChangeLog!=null) && (_employeeCollectionViaAssetReclamationServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaAssetReclamationServiceChangeLog:null);
				info.AddValue("_rebateTypeCollectionViaRebate", ((_rebateTypeCollectionViaRebate!=null) && (_rebateTypeCollectionViaRebate.Count>0) && !this.MarkedForDeletion)?_rebateTypeCollectionViaRebate:null);
				info.AddValue("_recycleServiceCollectionViaRecycleServiceChangeLog", ((_recycleServiceCollectionViaRecycleServiceChangeLog!=null) && (_recycleServiceCollectionViaRecycleServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_recycleServiceCollectionViaRecycleServiceChangeLog:null);
				info.AddValue("_recycleServiceCollectionViaRecycleServiceAction_", ((_recycleServiceCollectionViaRecycleServiceAction_!=null) && (_recycleServiceCollectionViaRecycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_recycleServiceCollectionViaRecycleServiceAction_:null);
				info.AddValue("_recycleServiceCollectionViaRecycleServiceAction", ((_recycleServiceCollectionViaRecycleServiceAction!=null) && (_recycleServiceCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_recycleServiceCollectionViaRecycleServiceAction:null);
				info.AddValue("_recycleTypeCollectionViaRecycleServiceAction", ((_recycleTypeCollectionViaRecycleServiceAction!=null) && (_recycleTypeCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_recycleTypeCollectionViaRecycleServiceAction:null);
				info.AddValue("_recycleTypeCollectionViaRecycleServiceAction_", ((_recycleTypeCollectionViaRecycleServiceAction_!=null) && (_recycleTypeCollectionViaRecycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_recycleTypeCollectionViaRecycleServiceAction_:null);
				info.AddValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", ((_serviceLocationCollectionViaDeepFryerServiceChangeLog!=null) && (_serviceLocationCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_userType", (!this.MarkedForDeletion?_userType:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(UserFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(UserFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new UserRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AssetReclamationServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAssetReclamationServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AssetReclamationServiceChangeLogFields.EnteredByUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ChangeLogFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceChangeLogFields.EnteredByUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Rebate' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRebate()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RebateFields.EnteredByUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleServiceAction' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceActionFields.LastChangedByUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleServiceAction' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceActionFields.ActionUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceChangeLogFields.EnteredByUserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'UserAccount' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserAccount()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserAccountFields.UserId, null, ComparisonOperator.Equal, this.UserId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaRebate()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaRebate"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaUserAccount()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaUserAccount"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AssetReclamationService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ChangeType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoChangeTypeCollectionViaChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ChangeTypeCollectionViaChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerServiceCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaRecycleServiceAction_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaRecycleServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaRecycleServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaRecycleServiceAction___()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaRecycleServiceAction___"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaRecycleServiceAction__()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaRecycleServiceAction__"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaDeepFryerServiceChangeLog_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaDeepFryerServiceChangeLog_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaAssetReclamationServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaAssetReclamationServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RebateType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRebateTypeCollectionViaRebate()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RebateTypeCollectionViaRebate"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceCollectionViaRecycleServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleServiceCollectionViaRecycleServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceCollectionViaRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleServiceCollectionViaRecycleServiceAction_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleServiceCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleTypeCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleTypeCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleTypeCollectionViaRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleTypeCollectionViaRecycleServiceAction_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserFields.UserId, null, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'UserType' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserTypeFields.UserTypeId, null, ComparisonOperator.Equal, this.UserTypeId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.UserEntity);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._assetReclamationServiceChangeLog);
			collectionsQueue.Enqueue(this._changeLog);
			collectionsQueue.Enqueue(this._deepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._rebate);
			collectionsQueue.Enqueue(this._recycleServiceAction_);
			collectionsQueue.Enqueue(this._recycleServiceAction);
			collectionsQueue.Enqueue(this._recycleServiceChangeLog);
			collectionsQueue.Enqueue(this._userAccount);
			collectionsQueue.Enqueue(this._accountCollectionViaRebate);
			collectionsQueue.Enqueue(this._accountCollectionViaUserAccount);
			collectionsQueue.Enqueue(this._assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog);
			collectionsQueue.Enqueue(this._changeTypeCollectionViaChangeLog);
			collectionsQueue.Enqueue(this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._employeeCollectionViaRecycleServiceAction_);
			collectionsQueue.Enqueue(this._employeeCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._employeeCollectionViaRecycleServiceChangeLog);
			collectionsQueue.Enqueue(this._employeeCollectionViaRecycleServiceAction___);
			collectionsQueue.Enqueue(this._employeeCollectionViaRecycleServiceAction__);
			collectionsQueue.Enqueue(this._employeeCollectionViaDeepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._employeeCollectionViaDeepFryerServiceChangeLog_);
			collectionsQueue.Enqueue(this._employeeCollectionViaAssetReclamationServiceChangeLog);
			collectionsQueue.Enqueue(this._rebateTypeCollectionViaRebate);
			collectionsQueue.Enqueue(this._recycleServiceCollectionViaRecycleServiceChangeLog);
			collectionsQueue.Enqueue(this._recycleServiceCollectionViaRecycleServiceAction_);
			collectionsQueue.Enqueue(this._recycleServiceCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._recycleTypeCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._recycleTypeCollectionViaRecycleServiceAction_);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaDeepFryerServiceChangeLog);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._assetReclamationServiceChangeLog = (EntityCollection<AssetReclamationServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._changeLog = (EntityCollection<ChangeLogEntity>) collectionsQueue.Dequeue();
			this._deepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._rebate = (EntityCollection<RebateEntity>) collectionsQueue.Dequeue();
			this._recycleServiceAction_ = (EntityCollection<RecycleServiceActionEntity>) collectionsQueue.Dequeue();
			this._recycleServiceAction = (EntityCollection<RecycleServiceActionEntity>) collectionsQueue.Dequeue();
			this._recycleServiceChangeLog = (EntityCollection<RecycleServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._userAccount = (EntityCollection<UserAccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaRebate = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaUserAccount = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<AssetReclamationServiceEntity>) collectionsQueue.Dequeue();
			this._changeTypeCollectionViaChangeLog = (EntityCollection<ChangeTypeEntity>) collectionsQueue.Dequeue();
			this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaRecycleServiceAction_ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaRecycleServiceAction = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaRecycleServiceChangeLog = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaRecycleServiceAction___ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaRecycleServiceAction__ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaDeepFryerServiceChangeLog = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._rebateTypeCollectionViaRebate = (EntityCollection<RebateTypeEntity>) collectionsQueue.Dequeue();
			this._recycleServiceCollectionViaRecycleServiceChangeLog = (EntityCollection<RecycleServiceEntity>) collectionsQueue.Dequeue();
			this._recycleServiceCollectionViaRecycleServiceAction_ = (EntityCollection<RecycleServiceEntity>) collectionsQueue.Dequeue();
			this._recycleServiceCollectionViaRecycleServiceAction = (EntityCollection<RecycleServiceEntity>) collectionsQueue.Dequeue();
			this._recycleTypeCollectionViaRecycleServiceAction = (EntityCollection<RecycleTypeEntity>) collectionsQueue.Dequeue();
			this._recycleTypeCollectionViaRecycleServiceAction_ = (EntityCollection<RecycleTypeEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaDeepFryerServiceChangeLog = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._assetReclamationServiceChangeLog != null)
			{
				return true;
			}
			if (this._changeLog != null)
			{
				return true;
			}
			if (this._deepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._rebate != null)
			{
				return true;
			}
			if (this._recycleServiceAction_ != null)
			{
				return true;
			}
			if (this._recycleServiceAction != null)
			{
				return true;
			}
			if (this._recycleServiceChangeLog != null)
			{
				return true;
			}
			if (this._userAccount != null)
			{
				return true;
			}
			if (this._accountCollectionViaRebate != null)
			{
				return true;
			}
			if (this._accountCollectionViaUserAccount != null)
			{
				return true;
			}
			if (this._assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog != null)
			{
				return true;
			}
			if (this._changeTypeCollectionViaChangeLog != null)
			{
				return true;
			}
			if (this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._employeeCollectionViaRecycleServiceAction_ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaRecycleServiceAction != null)
			{
				return true;
			}
			if (this._employeeCollectionViaRecycleServiceChangeLog != null)
			{
				return true;
			}
			if (this._employeeCollectionViaRecycleServiceAction___ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaRecycleServiceAction__ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaDeepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._employeeCollectionViaDeepFryerServiceChangeLog_ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaAssetReclamationServiceChangeLog != null)
			{
				return true;
			}
			if (this._rebateTypeCollectionViaRebate != null)
			{
				return true;
			}
			if (this._recycleServiceCollectionViaRecycleServiceChangeLog != null)
			{
				return true;
			}
			if (this._recycleServiceCollectionViaRecycleServiceAction_ != null)
			{
				return true;
			}
			if (this._recycleServiceCollectionViaRecycleServiceAction != null)
			{
				return true;
			}
			if (this._recycleTypeCollectionViaRecycleServiceAction != null)
			{
				return true;
			}
			if (this._recycleTypeCollectionViaRecycleServiceAction_ != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaDeepFryerServiceChangeLog != null)
			{
				return true;
			}
			return base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AssetReclamationServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RebateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserAccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserAccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AssetReclamationServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ChangeTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RebateTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("UserType", _userType);
			toReturn.Add("AssetReclamationServiceChangeLog", _assetReclamationServiceChangeLog);
			toReturn.Add("ChangeLog", _changeLog);
			toReturn.Add("DeepFryerServiceChangeLog", _deepFryerServiceChangeLog);
			toReturn.Add("Rebate", _rebate);
			toReturn.Add("RecycleServiceAction_", _recycleServiceAction_);
			toReturn.Add("RecycleServiceAction", _recycleServiceAction);
			toReturn.Add("RecycleServiceChangeLog", _recycleServiceChangeLog);
			toReturn.Add("UserAccount", _userAccount);
			toReturn.Add("AccountCollectionViaRebate", _accountCollectionViaRebate);
			toReturn.Add("AccountCollectionViaUserAccount", _accountCollectionViaUserAccount);
			toReturn.Add("AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", _assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog);
			toReturn.Add("ChangeTypeCollectionViaChangeLog", _changeTypeCollectionViaChangeLog);
			toReturn.Add("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog", _deepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaRecycleServiceAction_", _employeeCollectionViaRecycleServiceAction_);
			toReturn.Add("EmployeeCollectionViaRecycleServiceAction", _employeeCollectionViaRecycleServiceAction);
			toReturn.Add("EmployeeCollectionViaRecycleServiceChangeLog", _employeeCollectionViaRecycleServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaRecycleServiceAction___", _employeeCollectionViaRecycleServiceAction___);
			toReturn.Add("EmployeeCollectionViaRecycleServiceAction__", _employeeCollectionViaRecycleServiceAction__);
			toReturn.Add("EmployeeCollectionViaDeepFryerServiceChangeLog", _employeeCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaDeepFryerServiceChangeLog_", _employeeCollectionViaDeepFryerServiceChangeLog_);
			toReturn.Add("EmployeeCollectionViaAssetReclamationServiceChangeLog", _employeeCollectionViaAssetReclamationServiceChangeLog);
			toReturn.Add("RebateTypeCollectionViaRebate", _rebateTypeCollectionViaRebate);
			toReturn.Add("RecycleServiceCollectionViaRecycleServiceChangeLog", _recycleServiceCollectionViaRecycleServiceChangeLog);
			toReturn.Add("RecycleServiceCollectionViaRecycleServiceAction_", _recycleServiceCollectionViaRecycleServiceAction_);
			toReturn.Add("RecycleServiceCollectionViaRecycleServiceAction", _recycleServiceCollectionViaRecycleServiceAction);
			toReturn.Add("RecycleTypeCollectionViaRecycleServiceAction", _recycleTypeCollectionViaRecycleServiceAction);
			toReturn.Add("RecycleTypeCollectionViaRecycleServiceAction_", _recycleTypeCollectionViaRecycleServiceAction_);
			toReturn.Add("ServiceLocationCollectionViaDeepFryerServiceChangeLog", _serviceLocationCollectionViaDeepFryerServiceChangeLog);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_assetReclamationServiceChangeLog!=null)
			{
				_assetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_changeLog!=null)
			{
				_changeLog.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerServiceChangeLog!=null)
			{
				_deepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_rebate!=null)
			{
				_rebate.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceAction_!=null)
			{
				_recycleServiceAction_.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceAction!=null)
			{
				_recycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceChangeLog!=null)
			{
				_recycleServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_userAccount!=null)
			{
				_userAccount.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaRebate!=null)
			{
				_accountCollectionViaRebate.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaUserAccount!=null)
			{
				_accountCollectionViaUserAccount.ActiveContext = base.ActiveContext;
			}
			if(_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog!=null)
			{
				_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_changeTypeCollectionViaChangeLog!=null)
			{
				_changeTypeCollectionViaChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerServiceCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaRecycleServiceAction_!=null)
			{
				_employeeCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaRecycleServiceAction!=null)
			{
				_employeeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaRecycleServiceChangeLog!=null)
			{
				_employeeCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaRecycleServiceAction___!=null)
			{
				_employeeCollectionViaRecycleServiceAction___.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaRecycleServiceAction__!=null)
			{
				_employeeCollectionViaRecycleServiceAction__.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_employeeCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaDeepFryerServiceChangeLog_!=null)
			{
				_employeeCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaAssetReclamationServiceChangeLog!=null)
			{
				_employeeCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_rebateTypeCollectionViaRebate!=null)
			{
				_rebateTypeCollectionViaRebate.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceCollectionViaRecycleServiceChangeLog!=null)
			{
				_recycleServiceCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceCollectionViaRecycleServiceAction_!=null)
			{
				_recycleServiceCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceCollectionViaRecycleServiceAction!=null)
			{
				_recycleServiceCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_recycleTypeCollectionViaRecycleServiceAction!=null)
			{
				_recycleTypeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_recycleTypeCollectionViaRecycleServiceAction_!=null)
			{
				_recycleTypeCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_serviceLocationCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_userType!=null)
			{
				_userType.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_assetReclamationServiceChangeLog = null;
			_changeLog = null;
			_deepFryerServiceChangeLog = null;
			_rebate = null;
			_recycleServiceAction_ = null;
			_recycleServiceAction = null;
			_recycleServiceChangeLog = null;
			_userAccount = null;
			_accountCollectionViaRebate = null;
			_accountCollectionViaUserAccount = null;
			_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = null;
			_changeTypeCollectionViaChangeLog = null;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = null;
			_employeeCollectionViaRecycleServiceAction_ = null;
			_employeeCollectionViaRecycleServiceAction = null;
			_employeeCollectionViaRecycleServiceChangeLog = null;
			_employeeCollectionViaRecycleServiceAction___ = null;
			_employeeCollectionViaRecycleServiceAction__ = null;
			_employeeCollectionViaDeepFryerServiceChangeLog = null;
			_employeeCollectionViaDeepFryerServiceChangeLog_ = null;
			_employeeCollectionViaAssetReclamationServiceChangeLog = null;
			_rebateTypeCollectionViaRebate = null;
			_recycleServiceCollectionViaRecycleServiceChangeLog = null;
			_recycleServiceCollectionViaRecycleServiceAction_ = null;
			_recycleServiceCollectionViaRecycleServiceAction = null;
			_recycleTypeCollectionViaRecycleServiceAction = null;
			_recycleTypeCollectionViaRecycleServiceAction_ = null;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog = null;
			_userType = null;

			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("UserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Username", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Password", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MiddleName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("UserTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsEnabled", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EmailAddress", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _userType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUserType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _userType, new PropertyChangedEventHandler( OnUserTypePropertyChanged ), "UserType", UserEntity.Relations.UserTypeEntityUsingUserTypeId, true, signalRelatedEntity, "User", resetFKFields, new int[] { (int)UserFieldIndex.UserTypeId } );		
			_userType = null;
		}

		/// <summary> setups the sync logic for member _userType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUserType(IEntity2 relatedEntity)
		{
			if(_userType!=relatedEntity)
			{
				DesetupSyncUserType(true, true);
				_userType = (UserTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _userType, new PropertyChangedEventHandler( OnUserTypePropertyChanged ), "UserType", UserEntity.Relations.UserTypeEntityUsingUserTypeId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this UserEntity</param>
		/// <param name="fields">Fields of this entity</param>
		protected virtual void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			base.Fields = fields;
			base.IsNew=true;
			base.Validator = validator;
			InitClassMembers();

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static UserRelations Relations
		{
			get	{ return new UserRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AssetReclamationServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAssetReclamationServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AssetReclamationServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("AssetReclamationServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceChangeLogEntity, 0, null, null, null, null, "AssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathChangeLog
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("ChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, 0, null, null, null, null, "ChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("DeepFryerServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, 0, null, null, null, null, "DeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Rebate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRebate
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RebateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateEntityFactory))),
					(IEntityRelation)GetRelationsForField("Rebate")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RebateEntity, 0, null, null, null, null, "Rebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleServiceAction' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceAction_
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleServiceAction_")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, null, "RecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleServiceAction' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceAction
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleServiceAction")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, null, "RecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RecycleServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceChangeLogEntity, 0, null, null, null, null, "RecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UserAccount' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserAccount
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<UserAccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserAccountEntityFactory))),
					(IEntityRelation)GetRelationsForField("UserAccount")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.UserAccountEntity, 0, null, null, null, null, "UserAccount", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaRebate
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RebateEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "Rebate_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaRebate"), null, "AccountCollectionViaRebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaUserAccount
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.UserAccountEntityUsingUserId;
				intermediateRelation.SetAliases(string.Empty, "UserAccount_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaUserAccount"), null, "AccountCollectionViaUserAccount", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AssetReclamationService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<AssetReclamationServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, 0, null, null, GetRelationsForField("AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog"), null, "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ChangeType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathChangeTypeCollectionViaChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.ChangeLogEntityUsingUserId;
				intermediateRelation.SetAliases(string.Empty, "ChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<ChangeTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity, 0, null, null, GetRelationsForField("ChangeTypeCollectionViaChangeLog"), null, "ChangeTypeCollectionViaChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerServiceCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, GetRelationsForField("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog"), null, "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction_"), null, "EmployeeCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction"), null, "EmployeeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceChangeLog"), null, "EmployeeCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaRecycleServiceAction___
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction___"), null, "EmployeeCollectionViaRecycleServiceAction___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaRecycleServiceAction__
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction__"), null, "EmployeeCollectionViaRecycleServiceAction__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog"), null, "EmployeeCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog_"), null, "EmployeeCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAssetReclamationServiceChangeLog"), null, "EmployeeCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RebateType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRebateTypeCollectionViaRebate
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RebateEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "Rebate_");
				return new PrefetchPathElement2(new EntityCollection<RebateTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RebateTypeEntity, 0, null, null, GetRelationsForField("RebateTypeCollectionViaRebate"), null, "RebateTypeCollectionViaRebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceChangeLog"), null, "RecycleServiceCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction_"), null, "RecycleServiceCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction"), null, "RecycleServiceCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleTypeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction"), null, "RecycleTypeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleTypeCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction_"), null, "RecycleTypeCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog"), null, "ServiceLocationCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UserType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserType
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UserTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("UserType")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.UserTypeEntity, 0, null, null, null, null, "UserType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return UserEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value
		/// pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return UserEntity.FieldsCustomProperties;}
		}

		/// <summary> The UserId property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 UserId
		{
			get { return (System.Int32)GetValue((int)UserFieldIndex.UserId, true); }
			set	{ SetValue((int)UserFieldIndex.UserId, value); }
		}

		/// <summary> The Username property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."Username"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Username
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Username, true); }
			set	{ SetValue((int)UserFieldIndex.Username, value); }
		}

		/// <summary> The Password property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): Binary, 0, 0, 16<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Password
		{
			get { return (System.Byte[])GetValue((int)UserFieldIndex.Password, true); }
			set	{ SetValue((int)UserFieldIndex.Password, value); }
		}

		/// <summary> The FirstName property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.FirstName, true); }
			set	{ SetValue((int)UserFieldIndex.FirstName, value); }
		}

		/// <summary> The MiddleName property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."MiddleName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MiddleName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.MiddleName, true); }
			set	{ SetValue((int)UserFieldIndex.MiddleName, value); }
		}

		/// <summary> The LastName property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.LastName, true); }
			set	{ SetValue((int)UserFieldIndex.LastName, value); }
		}

		/// <summary> The UserTypeId property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."UserTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 UserTypeId
		{
			get { return (System.Int32)GetValue((int)UserFieldIndex.UserTypeId, true); }
			set	{ SetValue((int)UserFieldIndex.UserTypeId, value); }
		}

		/// <summary> The IsActive property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsActive, true); }
			set	{ SetValue((int)UserFieldIndex.IsActive, value); }
		}

		/// <summary> The IsEnabled property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."IsEnabled"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsEnabled
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsEnabled, true); }
			set	{ SetValue((int)UserFieldIndex.IsEnabled, value); }
		}

		/// <summary> The EmailAddress property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."EmailAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmailAddress
		{
			get { return (System.String)GetValue((int)UserFieldIndex.EmailAddress, true); }
			set	{ SetValue((int)UserFieldIndex.EmailAddress, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AssetReclamationServiceChangeLogEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AssetReclamationServiceChangeLogEntity))]
		public virtual EntityCollection<AssetReclamationServiceChangeLogEntity> AssetReclamationServiceChangeLog
		{
			get
			{
				if(_assetReclamationServiceChangeLog==null)
				{
					_assetReclamationServiceChangeLog = new EntityCollection<AssetReclamationServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceChangeLogEntityFactory)));
					_assetReclamationServiceChangeLog.SetContainingEntityInfo(this, "User");
				}
				return _assetReclamationServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ChangeLogEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ChangeLogEntity))]
		public virtual EntityCollection<ChangeLogEntity> ChangeLog
		{
			get
			{
				if(_changeLog==null)
				{
					_changeLog = new EntityCollection<ChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeLogEntityFactory)));
					_changeLog.SetContainingEntityInfo(this, "User");
				}
				return _changeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerServiceChangeLogEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerServiceChangeLogEntity))]
		public virtual EntityCollection<DeepFryerServiceChangeLogEntity> DeepFryerServiceChangeLog
		{
			get
			{
				if(_deepFryerServiceChangeLog==null)
				{
					_deepFryerServiceChangeLog = new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory)));
					_deepFryerServiceChangeLog.SetContainingEntityInfo(this, "User");
				}
				return _deepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RebateEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RebateEntity))]
		public virtual EntityCollection<RebateEntity> Rebate
		{
			get
			{
				if(_rebate==null)
				{
					_rebate = new EntityCollection<RebateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateEntityFactory)));
					_rebate.SetContainingEntityInfo(this, "User");
				}
				return _rebate;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceActionEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceActionEntity))]
		public virtual EntityCollection<RecycleServiceActionEntity> RecycleServiceAction_
		{
			get
			{
				if(_recycleServiceAction_==null)
				{
					_recycleServiceAction_ = new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory)));
					_recycleServiceAction_.SetContainingEntityInfo(this, "User_");
				}
				return _recycleServiceAction_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceActionEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceActionEntity))]
		public virtual EntityCollection<RecycleServiceActionEntity> RecycleServiceAction
		{
			get
			{
				if(_recycleServiceAction==null)
				{
					_recycleServiceAction = new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory)));
					_recycleServiceAction.SetContainingEntityInfo(this, "User");
				}
				return _recycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceChangeLogEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceChangeLogEntity))]
		public virtual EntityCollection<RecycleServiceChangeLogEntity> RecycleServiceChangeLog
		{
			get
			{
				if(_recycleServiceChangeLog==null)
				{
					_recycleServiceChangeLog = new EntityCollection<RecycleServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceChangeLogEntityFactory)));
					_recycleServiceChangeLog.SetContainingEntityInfo(this, "User");
				}
				return _recycleServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserAccountEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserAccountEntity))]
		public virtual EntityCollection<UserAccountEntity> UserAccount
		{
			get
			{
				if(_userAccount==null)
				{
					_userAccount = new EntityCollection<UserAccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserAccountEntityFactory)));
					_userAccount.SetContainingEntityInfo(this, "User");
				}
				return _userAccount;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaRebate
		{
			get
			{
				if(_accountCollectionViaRebate==null)
				{
					_accountCollectionViaRebate = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaRebate.IsReadOnly=true;
				}
				return _accountCollectionViaRebate;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaUserAccount
		{
			get
			{
				if(_accountCollectionViaUserAccount==null)
				{
					_accountCollectionViaUserAccount = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaUserAccount.IsReadOnly=true;
				}
				return _accountCollectionViaUserAccount;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AssetReclamationServiceEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AssetReclamationServiceEntity))]
		public virtual EntityCollection<AssetReclamationServiceEntity> AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				if(_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog==null)
				{
					_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = new EntityCollection<AssetReclamationServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceEntityFactory)));
					_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.IsReadOnly=true;
				}
				return _assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ChangeTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ChangeTypeEntity))]
		public virtual EntityCollection<ChangeTypeEntity> ChangeTypeCollectionViaChangeLog
		{
			get
			{
				if(_changeTypeCollectionViaChangeLog==null)
				{
					_changeTypeCollectionViaChangeLog = new EntityCollection<ChangeTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ChangeTypeEntityFactory)));
					_changeTypeCollectionViaChangeLog.IsReadOnly=true;
				}
				return _changeTypeCollectionViaChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerServiceEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerServiceEntity))]
		public virtual EntityCollection<DeepFryerServiceEntity> DeepFryerServiceCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				if(_deepFryerServiceCollectionViaDeepFryerServiceChangeLog==null)
				{
					_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory)));
					_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.IsReadOnly=true;
				}
				return _deepFryerServiceCollectionViaDeepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaRecycleServiceAction_
		{
			get
			{
				if(_employeeCollectionViaRecycleServiceAction_==null)
				{
					_employeeCollectionViaRecycleServiceAction_ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaRecycleServiceAction_.IsReadOnly=true;
				}
				return _employeeCollectionViaRecycleServiceAction_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaRecycleServiceAction
		{
			get
			{
				if(_employeeCollectionViaRecycleServiceAction==null)
				{
					_employeeCollectionViaRecycleServiceAction = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaRecycleServiceAction.IsReadOnly=true;
				}
				return _employeeCollectionViaRecycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaRecycleServiceChangeLog
		{
			get
			{
				if(_employeeCollectionViaRecycleServiceChangeLog==null)
				{
					_employeeCollectionViaRecycleServiceChangeLog = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaRecycleServiceChangeLog.IsReadOnly=true;
				}
				return _employeeCollectionViaRecycleServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaRecycleServiceAction___
		{
			get
			{
				if(_employeeCollectionViaRecycleServiceAction___==null)
				{
					_employeeCollectionViaRecycleServiceAction___ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaRecycleServiceAction___.IsReadOnly=true;
				}
				return _employeeCollectionViaRecycleServiceAction___;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaRecycleServiceAction__
		{
			get
			{
				if(_employeeCollectionViaRecycleServiceAction__==null)
				{
					_employeeCollectionViaRecycleServiceAction__ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaRecycleServiceAction__.IsReadOnly=true;
				}
				return _employeeCollectionViaRecycleServiceAction__;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				if(_employeeCollectionViaDeepFryerServiceChangeLog==null)
				{
					_employeeCollectionViaDeepFryerServiceChangeLog = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaDeepFryerServiceChangeLog.IsReadOnly=true;
				}
				return _employeeCollectionViaDeepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				if(_employeeCollectionViaDeepFryerServiceChangeLog_==null)
				{
					_employeeCollectionViaDeepFryerServiceChangeLog_ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaDeepFryerServiceChangeLog_.IsReadOnly=true;
				}
				return _employeeCollectionViaDeepFryerServiceChangeLog_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				if(_employeeCollectionViaAssetReclamationServiceChangeLog==null)
				{
					_employeeCollectionViaAssetReclamationServiceChangeLog = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaAssetReclamationServiceChangeLog.IsReadOnly=true;
				}
				return _employeeCollectionViaAssetReclamationServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RebateTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RebateTypeEntity))]
		public virtual EntityCollection<RebateTypeEntity> RebateTypeCollectionViaRebate
		{
			get
			{
				if(_rebateTypeCollectionViaRebate==null)
				{
					_rebateTypeCollectionViaRebate = new EntityCollection<RebateTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateTypeEntityFactory)));
					_rebateTypeCollectionViaRebate.IsReadOnly=true;
				}
				return _rebateTypeCollectionViaRebate;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceEntity))]
		public virtual EntityCollection<RecycleServiceEntity> RecycleServiceCollectionViaRecycleServiceChangeLog
		{
			get
			{
				if(_recycleServiceCollectionViaRecycleServiceChangeLog==null)
				{
					_recycleServiceCollectionViaRecycleServiceChangeLog = new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory)));
					_recycleServiceCollectionViaRecycleServiceChangeLog.IsReadOnly=true;
				}
				return _recycleServiceCollectionViaRecycleServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceEntity))]
		public virtual EntityCollection<RecycleServiceEntity> RecycleServiceCollectionViaRecycleServiceAction_
		{
			get
			{
				if(_recycleServiceCollectionViaRecycleServiceAction_==null)
				{
					_recycleServiceCollectionViaRecycleServiceAction_ = new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory)));
					_recycleServiceCollectionViaRecycleServiceAction_.IsReadOnly=true;
				}
				return _recycleServiceCollectionViaRecycleServiceAction_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceEntity))]
		public virtual EntityCollection<RecycleServiceEntity> RecycleServiceCollectionViaRecycleServiceAction
		{
			get
			{
				if(_recycleServiceCollectionViaRecycleServiceAction==null)
				{
					_recycleServiceCollectionViaRecycleServiceAction = new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory)));
					_recycleServiceCollectionViaRecycleServiceAction.IsReadOnly=true;
				}
				return _recycleServiceCollectionViaRecycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleTypeEntity))]
		public virtual EntityCollection<RecycleTypeEntity> RecycleTypeCollectionViaRecycleServiceAction
		{
			get
			{
				if(_recycleTypeCollectionViaRecycleServiceAction==null)
				{
					_recycleTypeCollectionViaRecycleServiceAction = new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory)));
					_recycleTypeCollectionViaRecycleServiceAction.IsReadOnly=true;
				}
				return _recycleTypeCollectionViaRecycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleTypeEntity))]
		public virtual EntityCollection<RecycleTypeEntity> RecycleTypeCollectionViaRecycleServiceAction_
		{
			get
			{
				if(_recycleTypeCollectionViaRecycleServiceAction_==null)
				{
					_recycleTypeCollectionViaRecycleServiceAction_ = new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory)));
					_recycleTypeCollectionViaRecycleServiceAction_.IsReadOnly=true;
				}
				return _recycleTypeCollectionViaRecycleServiceAction_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				if(_serviceLocationCollectionViaDeepFryerServiceChangeLog==null)
				{
					_serviceLocationCollectionViaDeepFryerServiceChangeLog = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaDeepFryerServiceChangeLog.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaDeepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets / sets related entity of type 'UserTypeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual UserTypeEntity UserType
		{
			get
			{
				return _userType;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUserType(value);
				}
				else
				{
					if(value==null)
					{
						if(_userType != null)
						{
							_userType.UnsetRelatedEntity(this, "User");
						}
					}
					else
					{
						if(_userType!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "User");
						}
					}
				}
			}
		}

	
		
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the Reliant.RenuOil.DAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)Reliant.RenuOil.DAL.EntityType.UserEntity; }
		}
		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
