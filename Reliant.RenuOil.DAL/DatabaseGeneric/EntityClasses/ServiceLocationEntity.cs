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
	/// Entity class which represents the entity 'ServiceLocation'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ServiceLocationEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<DeepFryerEntity> _deepFryer;
		private EntityCollection<DeepFryerServiceEntity> _deepFryerService;
		private EntityCollection<DeepFryerServiceChangeLogEntity> _deepFryerServiceChangeLog;
		private EntityCollection<ServiceLocationAssetTypeEntity> _serviceLocationAssetType;
		private EntityCollection<ServiceLocationEmployeeAssignmentEntity> _serviceLocationEmployeeAssignment;
		private EntityCollection<ServiceLocationRecycleTypeEntity> _serviceLocationRecycleType;
		private EntityCollection<WorkOrderEmployeeEntity> _workOrderEmployee;
		private EntityCollection<WorkOrderServiceLocationEntity> _workOrderServiceLocation;
		private EntityCollection<AssetTypeEntity> _assetTypeCollectionViaServiceLocationAssetTypeId;
		private EntityCollection<DeepFryerEntity> _deepFryerCollectionViaDeepFryerService;
		private EntityCollection<DeepFryerServiceEntity> _deepFryerServiceCollectionViaDeepFryerServiceChangeLog;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaServiceLocationEmployeeAssignment__;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaServiceLocationEmployeeAssignment_;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaServiceLocationEmployeeAssignment_____;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaServiceLocationEmployeeAssignment____;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaServiceLocationEmployeeAssignment______;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaServiceLocationEmployeeAssignment___;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaServiceLocationEmployeeAssignment;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaDeepFryerService;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaDeepFryerServiceChangeLog_;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaDeepFryerServiceChangeLog;
		private EntityCollection<RecycleTypeEntity> _recycleTypeCollectionViaServiceLocationRecycleType;
		private EntityCollection<UserEntity> _userCollectionViaDeepFryerServiceChangeLog;
		private EntityCollection<WorkOrderEntity> _workOrderCollectionViaWorkOrderEmployee;
		private EntityCollection<WorkOrderEntity> _workOrderCollectionViaWorkOrderServiceLocation;
		private EntityCollection<WorkOrderEmployeeEntity> _workOrderEmployeeCollectionViaDeepFryerService;
		private EntityCollection<WorkOrderServiceLocationEntity> _workOrderServiceLocationCollectionViaDeepFryerService;
		private AccountEntity _account;
		private ServiceTypeEntity _serviceType;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Account</summary>
			public static readonly string Account = "Account";
			/// <summary>Member name ServiceType</summary>
			public static readonly string ServiceType = "ServiceType";
			/// <summary>Member name DeepFryer</summary>
			public static readonly string DeepFryer = "DeepFryer";
			/// <summary>Member name DeepFryerService</summary>
			public static readonly string DeepFryerService = "DeepFryerService";
			/// <summary>Member name DeepFryerServiceChangeLog</summary>
			public static readonly string DeepFryerServiceChangeLog = "DeepFryerServiceChangeLog";
			/// <summary>Member name ServiceLocationAssetType</summary>
			public static readonly string ServiceLocationAssetType = "ServiceLocationAssetType";
			/// <summary>Member name ServiceLocationEmployeeAssignment</summary>
			public static readonly string ServiceLocationEmployeeAssignment = "ServiceLocationEmployeeAssignment";
			/// <summary>Member name ServiceLocationRecycleType</summary>
			public static readonly string ServiceLocationRecycleType = "ServiceLocationRecycleType";
			/// <summary>Member name WorkOrderEmployee</summary>
			public static readonly string WorkOrderEmployee = "WorkOrderEmployee";
			/// <summary>Member name WorkOrderServiceLocation</summary>
			public static readonly string WorkOrderServiceLocation = "WorkOrderServiceLocation";
			/// <summary>Member name AssetTypeCollectionViaServiceLocationAssetTypeId</summary>
			public static readonly string AssetTypeCollectionViaServiceLocationAssetTypeId = "AssetTypeCollectionViaServiceLocationAssetTypeId";
			/// <summary>Member name DeepFryerCollectionViaDeepFryerService</summary>
			public static readonly string DeepFryerCollectionViaDeepFryerService = "DeepFryerCollectionViaDeepFryerService";
			/// <summary>Member name DeepFryerServiceCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string DeepFryerServiceCollectionViaDeepFryerServiceChangeLog = "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaServiceLocationEmployeeAssignment__</summary>
			public static readonly string EmployeeCollectionViaServiceLocationEmployeeAssignment__ = "EmployeeCollectionViaServiceLocationEmployeeAssignment__";
			/// <summary>Member name EmployeeCollectionViaServiceLocationEmployeeAssignment_</summary>
			public static readonly string EmployeeCollectionViaServiceLocationEmployeeAssignment_ = "EmployeeCollectionViaServiceLocationEmployeeAssignment_";
			/// <summary>Member name EmployeeCollectionViaServiceLocationEmployeeAssignment_____</summary>
			public static readonly string EmployeeCollectionViaServiceLocationEmployeeAssignment_____ = "EmployeeCollectionViaServiceLocationEmployeeAssignment_____";
			/// <summary>Member name EmployeeCollectionViaServiceLocationEmployeeAssignment____</summary>
			public static readonly string EmployeeCollectionViaServiceLocationEmployeeAssignment____ = "EmployeeCollectionViaServiceLocationEmployeeAssignment____";
			/// <summary>Member name EmployeeCollectionViaServiceLocationEmployeeAssignment______</summary>
			public static readonly string EmployeeCollectionViaServiceLocationEmployeeAssignment______ = "EmployeeCollectionViaServiceLocationEmployeeAssignment______";
			/// <summary>Member name EmployeeCollectionViaServiceLocationEmployeeAssignment___</summary>
			public static readonly string EmployeeCollectionViaServiceLocationEmployeeAssignment___ = "EmployeeCollectionViaServiceLocationEmployeeAssignment___";
			/// <summary>Member name EmployeeCollectionViaServiceLocationEmployeeAssignment</summary>
			public static readonly string EmployeeCollectionViaServiceLocationEmployeeAssignment = "EmployeeCollectionViaServiceLocationEmployeeAssignment";
			/// <summary>Member name EmployeeCollectionViaDeepFryerService</summary>
			public static readonly string EmployeeCollectionViaDeepFryerService = "EmployeeCollectionViaDeepFryerService";
			/// <summary>Member name EmployeeCollectionViaDeepFryerServiceChangeLog_</summary>
			public static readonly string EmployeeCollectionViaDeepFryerServiceChangeLog_ = "EmployeeCollectionViaDeepFryerServiceChangeLog_";
			/// <summary>Member name EmployeeCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string EmployeeCollectionViaDeepFryerServiceChangeLog = "EmployeeCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name RecycleTypeCollectionViaServiceLocationRecycleType</summary>
			public static readonly string RecycleTypeCollectionViaServiceLocationRecycleType = "RecycleTypeCollectionViaServiceLocationRecycleType";
			/// <summary>Member name UserCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string UserCollectionViaDeepFryerServiceChangeLog = "UserCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name WorkOrderCollectionViaWorkOrderEmployee</summary>
			public static readonly string WorkOrderCollectionViaWorkOrderEmployee = "WorkOrderCollectionViaWorkOrderEmployee";
			/// <summary>Member name WorkOrderCollectionViaWorkOrderServiceLocation</summary>
			public static readonly string WorkOrderCollectionViaWorkOrderServiceLocation = "WorkOrderCollectionViaWorkOrderServiceLocation";
			/// <summary>Member name WorkOrderEmployeeCollectionViaDeepFryerService</summary>
			public static readonly string WorkOrderEmployeeCollectionViaDeepFryerService = "WorkOrderEmployeeCollectionViaDeepFryerService";
			/// <summary>Member name WorkOrderServiceLocationCollectionViaDeepFryerService</summary>
			public static readonly string WorkOrderServiceLocationCollectionViaDeepFryerService = "WorkOrderServiceLocationCollectionViaDeepFryerService";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ServiceLocationEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public ServiceLocationEntity():base("ServiceLocationEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ServiceLocationEntity(IEntityFields2 fields):base("ServiceLocationEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ServiceLocationEntity</param>
		public ServiceLocationEntity(IValidator validator):base("ServiceLocationEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ServiceLocationEntity(System.Int32 serviceLocationId):base("ServiceLocationEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.ServiceLocationId = serviceLocationId;
		}

		/// <summary> CTor</summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		/// <param name="validator">The custom validator object for this ServiceLocationEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ServiceLocationEntity(System.Int32 serviceLocationId, IValidator validator):base("ServiceLocationEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.ServiceLocationId = serviceLocationId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ServiceLocationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_deepFryer = (EntityCollection<DeepFryerEntity>)info.GetValue("_deepFryer", typeof(EntityCollection<DeepFryerEntity>));
				_deepFryerService = (EntityCollection<DeepFryerServiceEntity>)info.GetValue("_deepFryerService", typeof(EntityCollection<DeepFryerServiceEntity>));
				_deepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceChangeLogEntity>)info.GetValue("_deepFryerServiceChangeLog", typeof(EntityCollection<DeepFryerServiceChangeLogEntity>));
				_serviceLocationAssetType = (EntityCollection<ServiceLocationAssetTypeEntity>)info.GetValue("_serviceLocationAssetType", typeof(EntityCollection<ServiceLocationAssetTypeEntity>));
				_serviceLocationEmployeeAssignment = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>)info.GetValue("_serviceLocationEmployeeAssignment", typeof(EntityCollection<ServiceLocationEmployeeAssignmentEntity>));
				_serviceLocationRecycleType = (EntityCollection<ServiceLocationRecycleTypeEntity>)info.GetValue("_serviceLocationRecycleType", typeof(EntityCollection<ServiceLocationRecycleTypeEntity>));
				_workOrderEmployee = (EntityCollection<WorkOrderEmployeeEntity>)info.GetValue("_workOrderEmployee", typeof(EntityCollection<WorkOrderEmployeeEntity>));
				_workOrderServiceLocation = (EntityCollection<WorkOrderServiceLocationEntity>)info.GetValue("_workOrderServiceLocation", typeof(EntityCollection<WorkOrderServiceLocationEntity>));
				_assetTypeCollectionViaServiceLocationAssetTypeId = (EntityCollection<AssetTypeEntity>)info.GetValue("_assetTypeCollectionViaServiceLocationAssetTypeId", typeof(EntityCollection<AssetTypeEntity>));
				_deepFryerCollectionViaDeepFryerService = (EntityCollection<DeepFryerEntity>)info.GetValue("_deepFryerCollectionViaDeepFryerService", typeof(EntityCollection<DeepFryerEntity>));
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceEntity>)info.GetValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<DeepFryerServiceEntity>));
				_employeeCollectionViaServiceLocationEmployeeAssignment__ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment__", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaServiceLocationEmployeeAssignment_ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment_", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaServiceLocationEmployeeAssignment_____ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment_____", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaServiceLocationEmployeeAssignment____ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment____", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaServiceLocationEmployeeAssignment______ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment______", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaServiceLocationEmployeeAssignment___ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment___", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaServiceLocationEmployeeAssignment = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaDeepFryerService = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaDeepFryerService", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog_", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaDeepFryerServiceChangeLog = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<EmployeeEntity>));
				_recycleTypeCollectionViaServiceLocationRecycleType = (EntityCollection<RecycleTypeEntity>)info.GetValue("_recycleTypeCollectionViaServiceLocationRecycleType", typeof(EntityCollection<RecycleTypeEntity>));
				_userCollectionViaDeepFryerServiceChangeLog = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<UserEntity>));
				_workOrderCollectionViaWorkOrderEmployee = (EntityCollection<WorkOrderEntity>)info.GetValue("_workOrderCollectionViaWorkOrderEmployee", typeof(EntityCollection<WorkOrderEntity>));
				_workOrderCollectionViaWorkOrderServiceLocation = (EntityCollection<WorkOrderEntity>)info.GetValue("_workOrderCollectionViaWorkOrderServiceLocation", typeof(EntityCollection<WorkOrderEntity>));
				_workOrderEmployeeCollectionViaDeepFryerService = (EntityCollection<WorkOrderEmployeeEntity>)info.GetValue("_workOrderEmployeeCollectionViaDeepFryerService", typeof(EntityCollection<WorkOrderEmployeeEntity>));
				_workOrderServiceLocationCollectionViaDeepFryerService = (EntityCollection<WorkOrderServiceLocationEntity>)info.GetValue("_workOrderServiceLocationCollectionViaDeepFryerService", typeof(EntityCollection<WorkOrderServiceLocationEntity>));
				_account = (AccountEntity)info.GetValue("_account", typeof(AccountEntity));
				if(_account!=null)
				{
					_account.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_serviceType = (ServiceTypeEntity)info.GetValue("_serviceType", typeof(ServiceTypeEntity));
				if(_serviceType!=null)
				{
					_serviceType.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((ServiceLocationFieldIndex)fieldIndex)
			{
				case ServiceLocationFieldIndex.AccountId:
					DesetupSyncAccount(true, false);
					break;
				case ServiceLocationFieldIndex.ServiceTypeId:
					DesetupSyncServiceType(true, false);
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
				case "Account":
					this.Account = (AccountEntity)entity;
					break;
				case "ServiceType":
					this.ServiceType = (ServiceTypeEntity)entity;
					break;
				case "DeepFryer":
					this.DeepFryer.Add((DeepFryerEntity)entity);
					break;
				case "DeepFryerService":
					this.DeepFryerService.Add((DeepFryerServiceEntity)entity);
					break;
				case "DeepFryerServiceChangeLog":
					this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)entity);
					break;
				case "ServiceLocationAssetType":
					this.ServiceLocationAssetType.Add((ServiceLocationAssetTypeEntity)entity);
					break;
				case "ServiceLocationEmployeeAssignment":
					this.ServiceLocationEmployeeAssignment.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					break;
				case "ServiceLocationRecycleType":
					this.ServiceLocationRecycleType.Add((ServiceLocationRecycleTypeEntity)entity);
					break;
				case "WorkOrderEmployee":
					this.WorkOrderEmployee.Add((WorkOrderEmployeeEntity)entity);
					break;
				case "WorkOrderServiceLocation":
					this.WorkOrderServiceLocation.Add((WorkOrderServiceLocationEntity)entity);
					break;
				case "AssetTypeCollectionViaServiceLocationAssetTypeId":
					this.AssetTypeCollectionViaServiceLocationAssetTypeId.IsReadOnly = false;
					this.AssetTypeCollectionViaServiceLocationAssetTypeId.Add((AssetTypeEntity)entity);
					this.AssetTypeCollectionViaServiceLocationAssetTypeId.IsReadOnly = true;
					break;
				case "DeepFryerCollectionViaDeepFryerService":
					this.DeepFryerCollectionViaDeepFryerService.IsReadOnly = false;
					this.DeepFryerCollectionViaDeepFryerService.Add((DeepFryerEntity)entity);
					this.DeepFryerCollectionViaDeepFryerService.IsReadOnly = true;
					break;
				case "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog":
					this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog.Add((DeepFryerServiceEntity)entity);
					this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment__":
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment__.IsReadOnly = false;
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment__.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment__.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment_":
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment_.IsReadOnly = false;
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment_.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment_.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment_____":
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment_____.IsReadOnly = false;
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment_____.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment_____.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment____":
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment____.IsReadOnly = false;
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment____.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment____.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment______":
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment______.IsReadOnly = false;
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment______.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment______.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment___":
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment___.IsReadOnly = false;
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment___.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment___.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment":
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment.IsReadOnly = false;
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaServiceLocationEmployeeAssignment.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaDeepFryerService":
					this.EmployeeCollectionViaDeepFryerService.IsReadOnly = false;
					this.EmployeeCollectionViaDeepFryerService.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaDeepFryerService.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog_":
					this.EmployeeCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = false;
					this.EmployeeCollectionViaDeepFryerServiceChangeLog_.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog":
					this.EmployeeCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.EmployeeCollectionViaDeepFryerServiceChangeLog.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
					break;
				case "RecycleTypeCollectionViaServiceLocationRecycleType":
					this.RecycleTypeCollectionViaServiceLocationRecycleType.IsReadOnly = false;
					this.RecycleTypeCollectionViaServiceLocationRecycleType.Add((RecycleTypeEntity)entity);
					this.RecycleTypeCollectionViaServiceLocationRecycleType.IsReadOnly = true;
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog":
					this.UserCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.UserCollectionViaDeepFryerServiceChangeLog.Add((UserEntity)entity);
					this.UserCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
					break;
				case "WorkOrderCollectionViaWorkOrderEmployee":
					this.WorkOrderCollectionViaWorkOrderEmployee.IsReadOnly = false;
					this.WorkOrderCollectionViaWorkOrderEmployee.Add((WorkOrderEntity)entity);
					this.WorkOrderCollectionViaWorkOrderEmployee.IsReadOnly = true;
					break;
				case "WorkOrderCollectionViaWorkOrderServiceLocation":
					this.WorkOrderCollectionViaWorkOrderServiceLocation.IsReadOnly = false;
					this.WorkOrderCollectionViaWorkOrderServiceLocation.Add((WorkOrderEntity)entity);
					this.WorkOrderCollectionViaWorkOrderServiceLocation.IsReadOnly = true;
					break;
				case "WorkOrderEmployeeCollectionViaDeepFryerService":
					this.WorkOrderEmployeeCollectionViaDeepFryerService.IsReadOnly = false;
					this.WorkOrderEmployeeCollectionViaDeepFryerService.Add((WorkOrderEmployeeEntity)entity);
					this.WorkOrderEmployeeCollectionViaDeepFryerService.IsReadOnly = true;
					break;
				case "WorkOrderServiceLocationCollectionViaDeepFryerService":
					this.WorkOrderServiceLocationCollectionViaDeepFryerService.IsReadOnly = false;
					this.WorkOrderServiceLocationCollectionViaDeepFryerService.Add((WorkOrderServiceLocationEntity)entity);
					this.WorkOrderServiceLocationCollectionViaDeepFryerService.IsReadOnly = true;
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
			return ServiceLocationEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Account":
					toReturn.Add(ServiceLocationEntity.Relations.AccountEntityUsingAccountId);
					break;
				case "ServiceType":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceTypeEntityUsingServiceTypeId);
					break;
				case "DeepFryer":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerEntityUsingServiceLocationId);
					break;
				case "DeepFryerService":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId);
					break;
				case "DeepFryerServiceChangeLog":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId);
					break;
				case "ServiceLocationAssetType":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationId);
					break;
				case "ServiceLocationEmployeeAssignment":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId);
					break;
				case "ServiceLocationRecycleType":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationRecycleTypeEntityUsingServiceLocationId);
					break;
				case "WorkOrderEmployee":
					toReturn.Add(ServiceLocationEntity.Relations.WorkOrderEmployeeEntityUsingEmployeeId);
					break;
				case "WorkOrderServiceLocation":
					toReturn.Add(ServiceLocationEntity.Relations.WorkOrderServiceLocationEntityUsingServiceLocationId);
					break;
				case "AssetTypeCollectionViaServiceLocationAssetTypeId":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationId, "ServiceLocationEntity__", "ServiceLocationAssetType_", JoinHint.None);
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.AssetTypeEntityUsingAssetTypeId, "ServiceLocationAssetType_", string.Empty, JoinHint.None);
					break;
				case "DeepFryerCollectionViaDeepFryerService":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId, "ServiceLocationEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId, "ServiceLocationEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.DeepFryerServiceEntityUsingDeepFryerServiceId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment__":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId, "ServiceLocationEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingWednesday, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment_":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId, "ServiceLocationEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingTuesday, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment_____":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId, "ServiceLocationEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSaturday, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment____":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId, "ServiceLocationEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingFriday, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment______":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId, "ServiceLocationEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSunday, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment___":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId, "ServiceLocationEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingThursday, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId, "ServiceLocationEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.EmployeeEntityUsingMonday, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerService":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId, "ServiceLocationEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog_":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId, "ServiceLocationEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingServicedBy, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId, "ServiceLocationEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaServiceLocationRecycleType":
					toReturn.Add(ServiceLocationEntity.Relations.ServiceLocationRecycleTypeEntityUsingServiceLocationId, "ServiceLocationEntity__", "ServiceLocationRecycleType_", JoinHint.None);
					toReturn.Add(ServiceLocationRecycleTypeEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "ServiceLocationRecycleType_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId, "ServiceLocationEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderCollectionViaWorkOrderEmployee":
					toReturn.Add(ServiceLocationEntity.Relations.WorkOrderEmployeeEntityUsingEmployeeId, "ServiceLocationEntity__", "WorkOrderEmployee_", JoinHint.None);
					toReturn.Add(WorkOrderEmployeeEntity.Relations.WorkOrderEntityUsingWorkOrderId, "WorkOrderEmployee_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderCollectionViaWorkOrderServiceLocation":
					toReturn.Add(ServiceLocationEntity.Relations.WorkOrderServiceLocationEntityUsingServiceLocationId, "ServiceLocationEntity__", "WorkOrderServiceLocation_", JoinHint.None);
					toReturn.Add(WorkOrderServiceLocationEntity.Relations.WorkOrderEntityUsingWorkOrderId, "WorkOrderServiceLocation_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderEmployeeCollectionViaDeepFryerService":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId, "ServiceLocationEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderServiceLocationCollectionViaDeepFryerService":
					toReturn.Add(ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId, "ServiceLocationEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
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
				case "Account":
					SetupSyncAccount(relatedEntity);
					break;
				case "ServiceType":
					SetupSyncServiceType(relatedEntity);
					break;
				case "DeepFryer":
					this.DeepFryer.Add((DeepFryerEntity)relatedEntity);
					break;
				case "DeepFryerService":
					this.DeepFryerService.Add((DeepFryerServiceEntity)relatedEntity);
					break;
				case "DeepFryerServiceChangeLog":
					this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)relatedEntity);
					break;
				case "ServiceLocationAssetType":
					this.ServiceLocationAssetType.Add((ServiceLocationAssetTypeEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment":
					this.ServiceLocationEmployeeAssignment.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationRecycleType":
					this.ServiceLocationRecycleType.Add((ServiceLocationRecycleTypeEntity)relatedEntity);
					break;
				case "WorkOrderEmployee":
					this.WorkOrderEmployee.Add((WorkOrderEmployeeEntity)relatedEntity);
					break;
				case "WorkOrderServiceLocation":
					this.WorkOrderServiceLocation.Add((WorkOrderServiceLocationEntity)relatedEntity);
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
				case "Account":
					DesetupSyncAccount(false, true);
					break;
				case "ServiceType":
					DesetupSyncServiceType(false, true);
					break;
				case "DeepFryer":
					base.PerformRelatedEntityRemoval(this.DeepFryer, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerService":
					base.PerformRelatedEntityRemoval(this.DeepFryerService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerServiceChangeLog":
					base.PerformRelatedEntityRemoval(this.DeepFryerServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationAssetType":
					base.PerformRelatedEntityRemoval(this.ServiceLocationAssetType, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment":
					base.PerformRelatedEntityRemoval(this.ServiceLocationEmployeeAssignment, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationRecycleType":
					base.PerformRelatedEntityRemoval(this.ServiceLocationRecycleType, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrderEmployee":
					base.PerformRelatedEntityRemoval(this.WorkOrderEmployee, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrderServiceLocation":
					base.PerformRelatedEntityRemoval(this.WorkOrderServiceLocation, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_account!=null)
			{
				toReturn.Add(_account);
			}
			if(_serviceType!=null)
			{
				toReturn.Add(_serviceType);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.DeepFryer);
			toReturn.Add(this.DeepFryerService);
			toReturn.Add(this.DeepFryerServiceChangeLog);
			toReturn.Add(this.ServiceLocationAssetType);
			toReturn.Add(this.ServiceLocationEmployeeAssignment);
			toReturn.Add(this.ServiceLocationRecycleType);
			toReturn.Add(this.WorkOrderEmployee);
			toReturn.Add(this.WorkOrderServiceLocation);

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
				info.AddValue("_deepFryer", ((_deepFryer!=null) && (_deepFryer.Count>0) && !this.MarkedForDeletion)?_deepFryer:null);
				info.AddValue("_deepFryerService", ((_deepFryerService!=null) && (_deepFryerService.Count>0) && !this.MarkedForDeletion)?_deepFryerService:null);
				info.AddValue("_deepFryerServiceChangeLog", ((_deepFryerServiceChangeLog!=null) && (_deepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_deepFryerServiceChangeLog:null);
				info.AddValue("_serviceLocationAssetType", ((_serviceLocationAssetType!=null) && (_serviceLocationAssetType.Count>0) && !this.MarkedForDeletion)?_serviceLocationAssetType:null);
				info.AddValue("_serviceLocationEmployeeAssignment", ((_serviceLocationEmployeeAssignment!=null) && (_serviceLocationEmployeeAssignment.Count>0) && !this.MarkedForDeletion)?_serviceLocationEmployeeAssignment:null);
				info.AddValue("_serviceLocationRecycleType", ((_serviceLocationRecycleType!=null) && (_serviceLocationRecycleType.Count>0) && !this.MarkedForDeletion)?_serviceLocationRecycleType:null);
				info.AddValue("_workOrderEmployee", ((_workOrderEmployee!=null) && (_workOrderEmployee.Count>0) && !this.MarkedForDeletion)?_workOrderEmployee:null);
				info.AddValue("_workOrderServiceLocation", ((_workOrderServiceLocation!=null) && (_workOrderServiceLocation.Count>0) && !this.MarkedForDeletion)?_workOrderServiceLocation:null);
				info.AddValue("_assetTypeCollectionViaServiceLocationAssetTypeId", ((_assetTypeCollectionViaServiceLocationAssetTypeId!=null) && (_assetTypeCollectionViaServiceLocationAssetTypeId.Count>0) && !this.MarkedForDeletion)?_assetTypeCollectionViaServiceLocationAssetTypeId:null);
				info.AddValue("_deepFryerCollectionViaDeepFryerService", ((_deepFryerCollectionViaDeepFryerService!=null) && (_deepFryerCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_deepFryerCollectionViaDeepFryerService:null);
				info.AddValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", ((_deepFryerServiceCollectionViaDeepFryerServiceChangeLog!=null) && (_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_deepFryerServiceCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment__", ((_employeeCollectionViaServiceLocationEmployeeAssignment__!=null) && (_employeeCollectionViaServiceLocationEmployeeAssignment__.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaServiceLocationEmployeeAssignment__:null);
				info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment_", ((_employeeCollectionViaServiceLocationEmployeeAssignment_!=null) && (_employeeCollectionViaServiceLocationEmployeeAssignment_.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaServiceLocationEmployeeAssignment_:null);
				info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment_____", ((_employeeCollectionViaServiceLocationEmployeeAssignment_____!=null) && (_employeeCollectionViaServiceLocationEmployeeAssignment_____.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaServiceLocationEmployeeAssignment_____:null);
				info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment____", ((_employeeCollectionViaServiceLocationEmployeeAssignment____!=null) && (_employeeCollectionViaServiceLocationEmployeeAssignment____.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaServiceLocationEmployeeAssignment____:null);
				info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment______", ((_employeeCollectionViaServiceLocationEmployeeAssignment______!=null) && (_employeeCollectionViaServiceLocationEmployeeAssignment______.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaServiceLocationEmployeeAssignment______:null);
				info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment___", ((_employeeCollectionViaServiceLocationEmployeeAssignment___!=null) && (_employeeCollectionViaServiceLocationEmployeeAssignment___.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaServiceLocationEmployeeAssignment___:null);
				info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment", ((_employeeCollectionViaServiceLocationEmployeeAssignment!=null) && (_employeeCollectionViaServiceLocationEmployeeAssignment.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaServiceLocationEmployeeAssignment:null);
				info.AddValue("_employeeCollectionViaDeepFryerService", ((_employeeCollectionViaDeepFryerService!=null) && (_employeeCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaDeepFryerService:null);
				info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog_", ((_employeeCollectionViaDeepFryerServiceChangeLog_!=null) && (_employeeCollectionViaDeepFryerServiceChangeLog_.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaDeepFryerServiceChangeLog_:null);
				info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog", ((_employeeCollectionViaDeepFryerServiceChangeLog!=null) && (_employeeCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_recycleTypeCollectionViaServiceLocationRecycleType", ((_recycleTypeCollectionViaServiceLocationRecycleType!=null) && (_recycleTypeCollectionViaServiceLocationRecycleType.Count>0) && !this.MarkedForDeletion)?_recycleTypeCollectionViaServiceLocationRecycleType:null);
				info.AddValue("_userCollectionViaDeepFryerServiceChangeLog", ((_userCollectionViaDeepFryerServiceChangeLog!=null) && (_userCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_userCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_workOrderCollectionViaWorkOrderEmployee", ((_workOrderCollectionViaWorkOrderEmployee!=null) && (_workOrderCollectionViaWorkOrderEmployee.Count>0) && !this.MarkedForDeletion)?_workOrderCollectionViaWorkOrderEmployee:null);
				info.AddValue("_workOrderCollectionViaWorkOrderServiceLocation", ((_workOrderCollectionViaWorkOrderServiceLocation!=null) && (_workOrderCollectionViaWorkOrderServiceLocation.Count>0) && !this.MarkedForDeletion)?_workOrderCollectionViaWorkOrderServiceLocation:null);
				info.AddValue("_workOrderEmployeeCollectionViaDeepFryerService", ((_workOrderEmployeeCollectionViaDeepFryerService!=null) && (_workOrderEmployeeCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_workOrderEmployeeCollectionViaDeepFryerService:null);
				info.AddValue("_workOrderServiceLocationCollectionViaDeepFryerService", ((_workOrderServiceLocationCollectionViaDeepFryerService!=null) && (_workOrderServiceLocationCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_workOrderServiceLocationCollectionViaDeepFryerService:null);
				info.AddValue("_account", (!this.MarkedForDeletion?_account:null));
				info.AddValue("_serviceType", (!this.MarkedForDeletion?_serviceType:null));

			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ServiceLocationFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ServiceLocationFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ServiceLocationRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryer' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryer()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.RelocatedToServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceChangeLogFields.RelocatedToServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationAssetType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationAssetType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationEmployeeAssignment()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationEmployeeAssignmentFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationRecycleType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationRecycleType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationRecycleTypeFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderEmployee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderEmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.ServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AssetType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAssetTypeCollectionViaServiceLocationAssetTypeId()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AssetTypeCollectionViaServiceLocationAssetTypeId"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryer' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DeepFryerCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerServiceCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaServiceLocationEmployeeAssignment__()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaServiceLocationEmployeeAssignment__"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaServiceLocationEmployeeAssignment_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaServiceLocationEmployeeAssignment_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaServiceLocationEmployeeAssignment_____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaServiceLocationEmployeeAssignment_____"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaServiceLocationEmployeeAssignment____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaServiceLocationEmployeeAssignment____"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaServiceLocationEmployeeAssignment______()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaServiceLocationEmployeeAssignment______"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaServiceLocationEmployeeAssignment___()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaServiceLocationEmployeeAssignment___"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaServiceLocationEmployeeAssignment()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaServiceLocationEmployeeAssignment"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaDeepFryerServiceChangeLog_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaDeepFryerServiceChangeLog_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleTypeCollectionViaServiceLocationRecycleType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleTypeCollectionViaServiceLocationRecycleType"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrder' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderCollectionViaWorkOrderEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WorkOrderCollectionViaWorkOrderEmployee"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrder' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderCollectionViaWorkOrderServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WorkOrderCollectionViaWorkOrderServiceLocation"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderEmployee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderEmployeeCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WorkOrderEmployeeCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderServiceLocationCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WorkOrderServiceLocationCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, null, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'Account' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccount()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entity of type 'ServiceType' to this entity. Use DataAccessAdapter.FetchNewEntity() to fetch this related entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceTypeFields.ServiceTypeId, null, ComparisonOperator.Equal, this.ServiceTypeId));
			return bucket;
		}

	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._deepFryer);
			collectionsQueue.Enqueue(this._deepFryerService);
			collectionsQueue.Enqueue(this._deepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._serviceLocationAssetType);
			collectionsQueue.Enqueue(this._serviceLocationEmployeeAssignment);
			collectionsQueue.Enqueue(this._serviceLocationRecycleType);
			collectionsQueue.Enqueue(this._workOrderEmployee);
			collectionsQueue.Enqueue(this._workOrderServiceLocation);
			collectionsQueue.Enqueue(this._assetTypeCollectionViaServiceLocationAssetTypeId);
			collectionsQueue.Enqueue(this._deepFryerCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._employeeCollectionViaServiceLocationEmployeeAssignment__);
			collectionsQueue.Enqueue(this._employeeCollectionViaServiceLocationEmployeeAssignment_);
			collectionsQueue.Enqueue(this._employeeCollectionViaServiceLocationEmployeeAssignment_____);
			collectionsQueue.Enqueue(this._employeeCollectionViaServiceLocationEmployeeAssignment____);
			collectionsQueue.Enqueue(this._employeeCollectionViaServiceLocationEmployeeAssignment______);
			collectionsQueue.Enqueue(this._employeeCollectionViaServiceLocationEmployeeAssignment___);
			collectionsQueue.Enqueue(this._employeeCollectionViaServiceLocationEmployeeAssignment);
			collectionsQueue.Enqueue(this._employeeCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._employeeCollectionViaDeepFryerServiceChangeLog_);
			collectionsQueue.Enqueue(this._employeeCollectionViaDeepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._recycleTypeCollectionViaServiceLocationRecycleType);
			collectionsQueue.Enqueue(this._userCollectionViaDeepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._workOrderCollectionViaWorkOrderEmployee);
			collectionsQueue.Enqueue(this._workOrderCollectionViaWorkOrderServiceLocation);
			collectionsQueue.Enqueue(this._workOrderEmployeeCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._workOrderServiceLocationCollectionViaDeepFryerService);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._deepFryer = (EntityCollection<DeepFryerEntity>) collectionsQueue.Dequeue();
			this._deepFryerService = (EntityCollection<DeepFryerServiceEntity>) collectionsQueue.Dequeue();
			this._deepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._serviceLocationAssetType = (EntityCollection<ServiceLocationAssetTypeEntity>) collectionsQueue.Dequeue();
			this._serviceLocationEmployeeAssignment = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._serviceLocationRecycleType = (EntityCollection<ServiceLocationRecycleTypeEntity>) collectionsQueue.Dequeue();
			this._workOrderEmployee = (EntityCollection<WorkOrderEmployeeEntity>) collectionsQueue.Dequeue();
			this._workOrderServiceLocation = (EntityCollection<WorkOrderServiceLocationEntity>) collectionsQueue.Dequeue();
			this._assetTypeCollectionViaServiceLocationAssetTypeId = (EntityCollection<AssetTypeEntity>) collectionsQueue.Dequeue();
			this._deepFryerCollectionViaDeepFryerService = (EntityCollection<DeepFryerEntity>) collectionsQueue.Dequeue();
			this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaServiceLocationEmployeeAssignment__ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaServiceLocationEmployeeAssignment_ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaServiceLocationEmployeeAssignment_____ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaServiceLocationEmployeeAssignment____ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaServiceLocationEmployeeAssignment______ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaServiceLocationEmployeeAssignment___ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaServiceLocationEmployeeAssignment = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaDeepFryerService = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaDeepFryerServiceChangeLog = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._recycleTypeCollectionViaServiceLocationRecycleType = (EntityCollection<RecycleTypeEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaDeepFryerServiceChangeLog = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._workOrderCollectionViaWorkOrderEmployee = (EntityCollection<WorkOrderEntity>) collectionsQueue.Dequeue();
			this._workOrderCollectionViaWorkOrderServiceLocation = (EntityCollection<WorkOrderEntity>) collectionsQueue.Dequeue();
			this._workOrderEmployeeCollectionViaDeepFryerService = (EntityCollection<WorkOrderEmployeeEntity>) collectionsQueue.Dequeue();
			this._workOrderServiceLocationCollectionViaDeepFryerService = (EntityCollection<WorkOrderServiceLocationEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._deepFryer != null)
			{
				return true;
			}
			if (this._deepFryerService != null)
			{
				return true;
			}
			if (this._deepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._serviceLocationAssetType != null)
			{
				return true;
			}
			if (this._serviceLocationEmployeeAssignment != null)
			{
				return true;
			}
			if (this._serviceLocationRecycleType != null)
			{
				return true;
			}
			if (this._workOrderEmployee != null)
			{
				return true;
			}
			if (this._workOrderServiceLocation != null)
			{
				return true;
			}
			if (this._assetTypeCollectionViaServiceLocationAssetTypeId != null)
			{
				return true;
			}
			if (this._deepFryerCollectionViaDeepFryerService != null)
			{
				return true;
			}
			if (this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._employeeCollectionViaServiceLocationEmployeeAssignment__ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaServiceLocationEmployeeAssignment_ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaServiceLocationEmployeeAssignment_____ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaServiceLocationEmployeeAssignment____ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaServiceLocationEmployeeAssignment______ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaServiceLocationEmployeeAssignment___ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaServiceLocationEmployeeAssignment != null)
			{
				return true;
			}
			if (this._employeeCollectionViaDeepFryerService != null)
			{
				return true;
			}
			if (this._employeeCollectionViaDeepFryerServiceChangeLog_ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaDeepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._recycleTypeCollectionViaServiceLocationRecycleType != null)
			{
				return true;
			}
			if (this._userCollectionViaDeepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._workOrderCollectionViaWorkOrderEmployee != null)
			{
				return true;
			}
			if (this._workOrderCollectionViaWorkOrderServiceLocation != null)
			{
				return true;
			}
			if (this._workOrderEmployeeCollectionViaDeepFryerService != null)
			{
				return true;
			}
			if (this._workOrderServiceLocationCollectionViaDeepFryerService != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationRecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationRecycleTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))) : null);
		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Account", _account);
			toReturn.Add("ServiceType", _serviceType);
			toReturn.Add("DeepFryer", _deepFryer);
			toReturn.Add("DeepFryerService", _deepFryerService);
			toReturn.Add("DeepFryerServiceChangeLog", _deepFryerServiceChangeLog);
			toReturn.Add("ServiceLocationAssetType", _serviceLocationAssetType);
			toReturn.Add("ServiceLocationEmployeeAssignment", _serviceLocationEmployeeAssignment);
			toReturn.Add("ServiceLocationRecycleType", _serviceLocationRecycleType);
			toReturn.Add("WorkOrderEmployee", _workOrderEmployee);
			toReturn.Add("WorkOrderServiceLocation", _workOrderServiceLocation);
			toReturn.Add("AssetTypeCollectionViaServiceLocationAssetTypeId", _assetTypeCollectionViaServiceLocationAssetTypeId);
			toReturn.Add("DeepFryerCollectionViaDeepFryerService", _deepFryerCollectionViaDeepFryerService);
			toReturn.Add("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog", _deepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaServiceLocationEmployeeAssignment__", _employeeCollectionViaServiceLocationEmployeeAssignment__);
			toReturn.Add("EmployeeCollectionViaServiceLocationEmployeeAssignment_", _employeeCollectionViaServiceLocationEmployeeAssignment_);
			toReturn.Add("EmployeeCollectionViaServiceLocationEmployeeAssignment_____", _employeeCollectionViaServiceLocationEmployeeAssignment_____);
			toReturn.Add("EmployeeCollectionViaServiceLocationEmployeeAssignment____", _employeeCollectionViaServiceLocationEmployeeAssignment____);
			toReturn.Add("EmployeeCollectionViaServiceLocationEmployeeAssignment______", _employeeCollectionViaServiceLocationEmployeeAssignment______);
			toReturn.Add("EmployeeCollectionViaServiceLocationEmployeeAssignment___", _employeeCollectionViaServiceLocationEmployeeAssignment___);
			toReturn.Add("EmployeeCollectionViaServiceLocationEmployeeAssignment", _employeeCollectionViaServiceLocationEmployeeAssignment);
			toReturn.Add("EmployeeCollectionViaDeepFryerService", _employeeCollectionViaDeepFryerService);
			toReturn.Add("EmployeeCollectionViaDeepFryerServiceChangeLog_", _employeeCollectionViaDeepFryerServiceChangeLog_);
			toReturn.Add("EmployeeCollectionViaDeepFryerServiceChangeLog", _employeeCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("RecycleTypeCollectionViaServiceLocationRecycleType", _recycleTypeCollectionViaServiceLocationRecycleType);
			toReturn.Add("UserCollectionViaDeepFryerServiceChangeLog", _userCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("WorkOrderCollectionViaWorkOrderEmployee", _workOrderCollectionViaWorkOrderEmployee);
			toReturn.Add("WorkOrderCollectionViaWorkOrderServiceLocation", _workOrderCollectionViaWorkOrderServiceLocation);
			toReturn.Add("WorkOrderEmployeeCollectionViaDeepFryerService", _workOrderEmployeeCollectionViaDeepFryerService);
			toReturn.Add("WorkOrderServiceLocationCollectionViaDeepFryerService", _workOrderServiceLocationCollectionViaDeepFryerService);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_deepFryer!=null)
			{
				_deepFryer.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerService!=null)
			{
				_deepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerServiceChangeLog!=null)
			{
				_deepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationAssetType!=null)
			{
				_serviceLocationAssetType.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationEmployeeAssignment!=null)
			{
				_serviceLocationEmployeeAssignment.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationRecycleType!=null)
			{
				_serviceLocationRecycleType.ActiveContext = base.ActiveContext;
			}
			if(_workOrderEmployee!=null)
			{
				_workOrderEmployee.ActiveContext = base.ActiveContext;
			}
			if(_workOrderServiceLocation!=null)
			{
				_workOrderServiceLocation.ActiveContext = base.ActiveContext;
			}
			if(_assetTypeCollectionViaServiceLocationAssetTypeId!=null)
			{
				_assetTypeCollectionViaServiceLocationAssetTypeId.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerCollectionViaDeepFryerService!=null)
			{
				_deepFryerCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerServiceCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaServiceLocationEmployeeAssignment__!=null)
			{
				_employeeCollectionViaServiceLocationEmployeeAssignment__.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaServiceLocationEmployeeAssignment_!=null)
			{
				_employeeCollectionViaServiceLocationEmployeeAssignment_.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaServiceLocationEmployeeAssignment_____!=null)
			{
				_employeeCollectionViaServiceLocationEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaServiceLocationEmployeeAssignment____!=null)
			{
				_employeeCollectionViaServiceLocationEmployeeAssignment____.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaServiceLocationEmployeeAssignment______!=null)
			{
				_employeeCollectionViaServiceLocationEmployeeAssignment______.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaServiceLocationEmployeeAssignment___!=null)
			{
				_employeeCollectionViaServiceLocationEmployeeAssignment___.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaServiceLocationEmployeeAssignment!=null)
			{
				_employeeCollectionViaServiceLocationEmployeeAssignment.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaDeepFryerService!=null)
			{
				_employeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaDeepFryerServiceChangeLog_!=null)
			{
				_employeeCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_employeeCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_recycleTypeCollectionViaServiceLocationRecycleType!=null)
			{
				_recycleTypeCollectionViaServiceLocationRecycleType.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_userCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_workOrderCollectionViaWorkOrderEmployee!=null)
			{
				_workOrderCollectionViaWorkOrderEmployee.ActiveContext = base.ActiveContext;
			}
			if(_workOrderCollectionViaWorkOrderServiceLocation!=null)
			{
				_workOrderCollectionViaWorkOrderServiceLocation.ActiveContext = base.ActiveContext;
			}
			if(_workOrderEmployeeCollectionViaDeepFryerService!=null)
			{
				_workOrderEmployeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_workOrderServiceLocationCollectionViaDeepFryerService!=null)
			{
				_workOrderServiceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_account!=null)
			{
				_account.ActiveContext = base.ActiveContext;
			}
			if(_serviceType!=null)
			{
				_serviceType.ActiveContext = base.ActiveContext;
			}

		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_deepFryer = null;
			_deepFryerService = null;
			_deepFryerServiceChangeLog = null;
			_serviceLocationAssetType = null;
			_serviceLocationEmployeeAssignment = null;
			_serviceLocationRecycleType = null;
			_workOrderEmployee = null;
			_workOrderServiceLocation = null;
			_assetTypeCollectionViaServiceLocationAssetTypeId = null;
			_deepFryerCollectionViaDeepFryerService = null;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = null;
			_employeeCollectionViaServiceLocationEmployeeAssignment__ = null;
			_employeeCollectionViaServiceLocationEmployeeAssignment_ = null;
			_employeeCollectionViaServiceLocationEmployeeAssignment_____ = null;
			_employeeCollectionViaServiceLocationEmployeeAssignment____ = null;
			_employeeCollectionViaServiceLocationEmployeeAssignment______ = null;
			_employeeCollectionViaServiceLocationEmployeeAssignment___ = null;
			_employeeCollectionViaServiceLocationEmployeeAssignment = null;
			_employeeCollectionViaDeepFryerService = null;
			_employeeCollectionViaDeepFryerServiceChangeLog_ = null;
			_employeeCollectionViaDeepFryerServiceChangeLog = null;
			_recycleTypeCollectionViaServiceLocationRecycleType = null;
			_userCollectionViaDeepFryerServiceChangeLog = null;
			_workOrderCollectionViaWorkOrderEmployee = null;
			_workOrderCollectionViaWorkOrderServiceLocation = null;
			_workOrderEmployeeCollectionViaDeepFryerService = null;
			_workOrderServiceLocationCollectionViaDeepFryerService = null;
			_account = null;
			_serviceType = null;

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

			_fieldsCustomProperties.Add("ServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Address1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Address2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("State", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IntlState", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ZipCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MainContact", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Notes", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ordinal", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _account</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAccount(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", ServiceLocationEntity.Relations.AccountEntityUsingAccountId, true, signalRelatedEntity, "ServiceLocation", resetFKFields, new int[] { (int)ServiceLocationFieldIndex.AccountId } );		
			_account = null;
		}

		/// <summary> setups the sync logic for member _account</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAccount(IEntity2 relatedEntity)
		{
			if(_account!=relatedEntity)
			{
				DesetupSyncAccount(true, true);
				_account = (AccountEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", ServiceLocationEntity.Relations.AccountEntityUsingAccountId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAccountPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _serviceType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceType, new PropertyChangedEventHandler( OnServiceTypePropertyChanged ), "ServiceType", ServiceLocationEntity.Relations.ServiceTypeEntityUsingServiceTypeId, true, signalRelatedEntity, "ServiceLocation", resetFKFields, new int[] { (int)ServiceLocationFieldIndex.ServiceTypeId } );		
			_serviceType = null;
		}

		/// <summary> setups the sync logic for member _serviceType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncServiceType(IEntity2 relatedEntity)
		{
			if(_serviceType!=relatedEntity)
			{
				DesetupSyncServiceType(true, true);
				_serviceType = (ServiceTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceType, new PropertyChangedEventHandler( OnServiceTypePropertyChanged ), "ServiceType", ServiceLocationEntity.Relations.ServiceTypeEntityUsingServiceTypeId, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnServiceTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ServiceLocationEntity</param>
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
		public  static ServiceLocationRelations Relations
		{
			get	{ return new ServiceLocationRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryer
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))),
					(IEntityRelation)GetRelationsForField("DeepFryer")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, null, null, "DeepFryer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerService
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))),
					(IEntityRelation)GetRelationsForField("DeepFryerService")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, null, null, "DeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("DeepFryerServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, 0, null, null, null, null, "DeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationAssetType
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetType")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, null, null, "ServiceLocationAssetType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationEmployeeAssignment
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, null, "ServiceLocationEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationRecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationRecycleType
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationRecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationRecycleTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationRecycleType")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationRecycleTypeEntity, 0, null, null, null, null, "ServiceLocationRecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderEmployee
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))),
					(IEntityRelation)GetRelationsForField("WorkOrderEmployee")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, null, null, "WorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderServiceLocation
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))),
					(IEntityRelation)GetRelationsForField("WorkOrderServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, null, null, "WorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAssetTypeCollectionViaServiceLocationAssetTypeId
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationAssetType_");
				return new PrefetchPathElement2(new EntityCollection<AssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity, 0, null, null, GetRelationsForField("AssetTypeCollectionViaServiceLocationAssetTypeId"), null, "AssetTypeCollectionViaServiceLocationAssetTypeId", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, GetRelationsForField("DeepFryerCollectionViaDeepFryerService"), null, "DeepFryerCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerServiceCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, GetRelationsForField("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog"), null, "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment__
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment__"), null, "EmployeeCollectionViaServiceLocationEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment_
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment_"), null, "EmployeeCollectionViaServiceLocationEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment_____
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment_____"), null, "EmployeeCollectionViaServiceLocationEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment____
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment____"), null, "EmployeeCollectionViaServiceLocationEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment______
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment______"), null, "EmployeeCollectionViaServiceLocationEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment___
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment___"), null, "EmployeeCollectionViaServiceLocationEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment"), null, "EmployeeCollectionViaServiceLocationEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerService"), null, "EmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog_"), null, "EmployeeCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog"), null, "EmployeeCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleTypeCollectionViaServiceLocationRecycleType
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationRecycleTypeEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationRecycleType_");
				return new PrefetchPathElement2(new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaServiceLocationRecycleType"), null, "RecycleTypeCollectionViaServiceLocationRecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog"), null, "UserCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderCollectionViaWorkOrderEmployee
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.WorkOrderEmployeeEntityUsingEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrderEmployee_");
				return new PrefetchPathElement2(new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, GetRelationsForField("WorkOrderCollectionViaWorkOrderEmployee"), null, "WorkOrderCollectionViaWorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderCollectionViaWorkOrderServiceLocation
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.WorkOrderServiceLocationEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrderServiceLocation_");
				return new PrefetchPathElement2(new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, GetRelationsForField("WorkOrderCollectionViaWorkOrderServiceLocation"), null, "WorkOrderCollectionViaWorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, GetRelationsForField("WorkOrderEmployeeCollectionViaDeepFryerService"), null, "WorkOrderEmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, GetRelationsForField("WorkOrderServiceLocationCollectionViaDeepFryerService"), null, "WorkOrderServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccount
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))),
					(IEntityRelation)GetRelationsForField("Account")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, null, null, "Account", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceType
		{
			get
			{
				return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceType")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, 0, null, null, null, null, "ServiceType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ServiceLocationEntity.CustomProperties;}
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
			get { return ServiceLocationEntity.FieldsCustomProperties;}
		}

		/// <summary> The ServiceLocationId property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."ServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ServiceLocationId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationFieldIndex.ServiceLocationId, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.ServiceLocationId, value); }
		}

		/// <summary> The AccountId property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationFieldIndex.AccountId, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.AccountId, value); }
		}

		/// <summary> The Name property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.Name, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Name, value); }
		}

		/// <summary> The Address1 property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Address1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address1
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.Address1, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Address1, value); }
		}

		/// <summary> The Address2 property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Address2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address2
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.Address2, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Address2, value); }
		}

		/// <summary> The City property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.City, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.City, value); }
		}

		/// <summary> The State property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."State"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String State
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.State, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.State, value); }
		}

		/// <summary> The IntlState property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."IntlState"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String IntlState
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.IntlState, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.IntlState, value); }
		}

		/// <summary> The ZipCode property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."ZipCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ZipCode
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.ZipCode, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.ZipCode, value); }
		}

		/// <summary> The Phone property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.Phone, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Phone, value); }
		}

		/// <summary> The MainContact property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."MainContact"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MainContact
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.MainContact, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.MainContact, value); }
		}

		/// <summary> The Notes property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.Notes, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Notes, value); }
		}

		/// <summary> The ServiceTypeId property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."ServiceTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ServiceTypeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationFieldIndex.ServiceTypeId, false); }
			set	{ SetValue((int)ServiceLocationFieldIndex.ServiceTypeId, value); }
		}

		/// <summary> The IsActive property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsActive
		{
			get { return (Nullable<System.Boolean>)GetValue((int)ServiceLocationFieldIndex.IsActive, false); }
			set	{ SetValue((int)ServiceLocationFieldIndex.IsActive, value); }
		}

		/// <summary> The Ordinal property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Ordinal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Ordinal
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationFieldIndex.Ordinal, false); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Ordinal, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerEntity))]
		public virtual EntityCollection<DeepFryerEntity> DeepFryer
		{
			get
			{
				if(_deepFryer==null)
				{
					_deepFryer = new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory)));
					_deepFryer.SetContainingEntityInfo(this, "ServiceLocation");
				}
				return _deepFryer;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerServiceEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerServiceEntity))]
		public virtual EntityCollection<DeepFryerServiceEntity> DeepFryerService
		{
			get
			{
				if(_deepFryerService==null)
				{
					_deepFryerService = new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory)));
					_deepFryerService.SetContainingEntityInfo(this, "ServiceLocation");
				}
				return _deepFryerService;
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
					_deepFryerServiceChangeLog.SetContainingEntityInfo(this, "ServiceLocation");
				}
				return _deepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationAssetTypeEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationAssetTypeEntity))]
		public virtual EntityCollection<ServiceLocationAssetTypeEntity> ServiceLocationAssetType
		{
			get
			{
				if(_serviceLocationAssetType==null)
				{
					_serviceLocationAssetType = new EntityCollection<ServiceLocationAssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationAssetTypeEntityFactory)));
					_serviceLocationAssetType.SetContainingEntityInfo(this, "ServiceLocation");
				}
				return _serviceLocationAssetType;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEmployeeAssignmentEntity))]
		public virtual EntityCollection<ServiceLocationEmployeeAssignmentEntity> ServiceLocationEmployeeAssignment
		{
			get
			{
				if(_serviceLocationEmployeeAssignment==null)
				{
					_serviceLocationEmployeeAssignment = new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory)));
					_serviceLocationEmployeeAssignment.SetContainingEntityInfo(this, "ServiceLocation");
				}
				return _serviceLocationEmployeeAssignment;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationRecycleTypeEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationRecycleTypeEntity))]
		public virtual EntityCollection<ServiceLocationRecycleTypeEntity> ServiceLocationRecycleType
		{
			get
			{
				if(_serviceLocationRecycleType==null)
				{
					_serviceLocationRecycleType = new EntityCollection<ServiceLocationRecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationRecycleTypeEntityFactory)));
					_serviceLocationRecycleType.SetContainingEntityInfo(this, "ServiceLocation");
				}
				return _serviceLocationRecycleType;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEmployeeEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderEmployeeEntity))]
		public virtual EntityCollection<WorkOrderEmployeeEntity> WorkOrderEmployee
		{
			get
			{
				if(_workOrderEmployee==null)
				{
					_workOrderEmployee = new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory)));
					_workOrderEmployee.SetContainingEntityInfo(this, "ServiceLocation");
				}
				return _workOrderEmployee;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderServiceLocationEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderServiceLocationEntity))]
		public virtual EntityCollection<WorkOrderServiceLocationEntity> WorkOrderServiceLocation
		{
			get
			{
				if(_workOrderServiceLocation==null)
				{
					_workOrderServiceLocation = new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory)));
					_workOrderServiceLocation.SetContainingEntityInfo(this, "ServiceLocation");
				}
				return _workOrderServiceLocation;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AssetTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AssetTypeEntity))]
		public virtual EntityCollection<AssetTypeEntity> AssetTypeCollectionViaServiceLocationAssetTypeId
		{
			get
			{
				if(_assetTypeCollectionViaServiceLocationAssetTypeId==null)
				{
					_assetTypeCollectionViaServiceLocationAssetTypeId = new EntityCollection<AssetTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetTypeEntityFactory)));
					_assetTypeCollectionViaServiceLocationAssetTypeId.IsReadOnly=true;
				}
				return _assetTypeCollectionViaServiceLocationAssetTypeId;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerEntity))]
		public virtual EntityCollection<DeepFryerEntity> DeepFryerCollectionViaDeepFryerService
		{
			get
			{
				if(_deepFryerCollectionViaDeepFryerService==null)
				{
					_deepFryerCollectionViaDeepFryerService = new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory)));
					_deepFryerCollectionViaDeepFryerService.IsReadOnly=true;
				}
				return _deepFryerCollectionViaDeepFryerService;
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
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaServiceLocationEmployeeAssignment__
		{
			get
			{
				if(_employeeCollectionViaServiceLocationEmployeeAssignment__==null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment__ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaServiceLocationEmployeeAssignment__.IsReadOnly=true;
				}
				return _employeeCollectionViaServiceLocationEmployeeAssignment__;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaServiceLocationEmployeeAssignment_
		{
			get
			{
				if(_employeeCollectionViaServiceLocationEmployeeAssignment_==null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment_ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaServiceLocationEmployeeAssignment_.IsReadOnly=true;
				}
				return _employeeCollectionViaServiceLocationEmployeeAssignment_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaServiceLocationEmployeeAssignment_____
		{
			get
			{
				if(_employeeCollectionViaServiceLocationEmployeeAssignment_____==null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment_____ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaServiceLocationEmployeeAssignment_____.IsReadOnly=true;
				}
				return _employeeCollectionViaServiceLocationEmployeeAssignment_____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaServiceLocationEmployeeAssignment____
		{
			get
			{
				if(_employeeCollectionViaServiceLocationEmployeeAssignment____==null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment____ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaServiceLocationEmployeeAssignment____.IsReadOnly=true;
				}
				return _employeeCollectionViaServiceLocationEmployeeAssignment____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaServiceLocationEmployeeAssignment______
		{
			get
			{
				if(_employeeCollectionViaServiceLocationEmployeeAssignment______==null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment______ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaServiceLocationEmployeeAssignment______.IsReadOnly=true;
				}
				return _employeeCollectionViaServiceLocationEmployeeAssignment______;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaServiceLocationEmployeeAssignment___
		{
			get
			{
				if(_employeeCollectionViaServiceLocationEmployeeAssignment___==null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment___ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaServiceLocationEmployeeAssignment___.IsReadOnly=true;
				}
				return _employeeCollectionViaServiceLocationEmployeeAssignment___;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaServiceLocationEmployeeAssignment
		{
			get
			{
				if(_employeeCollectionViaServiceLocationEmployeeAssignment==null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaServiceLocationEmployeeAssignment.IsReadOnly=true;
				}
				return _employeeCollectionViaServiceLocationEmployeeAssignment;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaDeepFryerService
		{
			get
			{
				if(_employeeCollectionViaDeepFryerService==null)
				{
					_employeeCollectionViaDeepFryerService = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaDeepFryerService.IsReadOnly=true;
				}
				return _employeeCollectionViaDeepFryerService;
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

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleTypeEntity))]
		public virtual EntityCollection<RecycleTypeEntity> RecycleTypeCollectionViaServiceLocationRecycleType
		{
			get
			{
				if(_recycleTypeCollectionViaServiceLocationRecycleType==null)
				{
					_recycleTypeCollectionViaServiceLocationRecycleType = new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory)));
					_recycleTypeCollectionViaServiceLocationRecycleType.IsReadOnly=true;
				}
				return _recycleTypeCollectionViaServiceLocationRecycleType;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				if(_userCollectionViaDeepFryerServiceChangeLog==null)
				{
					_userCollectionViaDeepFryerServiceChangeLog = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaDeepFryerServiceChangeLog.IsReadOnly=true;
				}
				return _userCollectionViaDeepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderEntity))]
		public virtual EntityCollection<WorkOrderEntity> WorkOrderCollectionViaWorkOrderEmployee
		{
			get
			{
				if(_workOrderCollectionViaWorkOrderEmployee==null)
				{
					_workOrderCollectionViaWorkOrderEmployee = new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory)));
					_workOrderCollectionViaWorkOrderEmployee.IsReadOnly=true;
				}
				return _workOrderCollectionViaWorkOrderEmployee;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderEntity))]
		public virtual EntityCollection<WorkOrderEntity> WorkOrderCollectionViaWorkOrderServiceLocation
		{
			get
			{
				if(_workOrderCollectionViaWorkOrderServiceLocation==null)
				{
					_workOrderCollectionViaWorkOrderServiceLocation = new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory)));
					_workOrderCollectionViaWorkOrderServiceLocation.IsReadOnly=true;
				}
				return _workOrderCollectionViaWorkOrderServiceLocation;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderEmployeeEntity))]
		public virtual EntityCollection<WorkOrderEmployeeEntity> WorkOrderEmployeeCollectionViaDeepFryerService
		{
			get
			{
				if(_workOrderEmployeeCollectionViaDeepFryerService==null)
				{
					_workOrderEmployeeCollectionViaDeepFryerService = new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory)));
					_workOrderEmployeeCollectionViaDeepFryerService.IsReadOnly=true;
				}
				return _workOrderEmployeeCollectionViaDeepFryerService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderServiceLocationEntity))]
		public virtual EntityCollection<WorkOrderServiceLocationEntity> WorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				if(_workOrderServiceLocationCollectionViaDeepFryerService==null)
				{
					_workOrderServiceLocationCollectionViaDeepFryerService = new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory)));
					_workOrderServiceLocationCollectionViaDeepFryerService.IsReadOnly=true;
				}
				return _workOrderServiceLocationCollectionViaDeepFryerService;
			}
		}

		/// <summary> Gets / sets related entity of type 'AccountEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual AccountEntity Account
		{
			get
			{
				return _account;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAccount(value);
				}
				else
				{
					if(value==null)
					{
						if(_account != null)
						{
							_account.UnsetRelatedEntity(this, "ServiceLocation");
						}
					}
					else
					{
						if(_account!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocation");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ServiceTypeEntity' which has to be set using a fetch action earlier. If no related entity
		/// is set for this property, null is returned. This property is not visible in databound grids.</summary>
		[Browsable(false)]
		public virtual ServiceTypeEntity ServiceType
		{
			get
			{
				return _serviceType;
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncServiceType(value);
				}
				else
				{
					if(value==null)
					{
						if(_serviceType != null)
						{
							_serviceType.UnsetRelatedEntity(this, "ServiceLocation");
						}
					}
					else
					{
						if(_serviceType!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "ServiceLocation");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity; }
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
