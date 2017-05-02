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
	/// Entity class which represents the entity 'Employee'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class EmployeeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<AccountEmployeeAssignmentEntity> _accountEmployeeAssignment____;
		private EntityCollection<AccountEmployeeAssignmentEntity> _accountEmployeeAssignment_____;
		private EntityCollection<AccountEmployeeAssignmentEntity> _accountEmployeeAssignment______;
		private EntityCollection<AccountEmployeeAssignmentEntity> _accountEmployeeAssignment___;
		private EntityCollection<AccountEmployeeAssignmentEntity> _accountEmployeeAssignment;
		private EntityCollection<AccountEmployeeAssignmentEntity> _accountEmployeeAssignment_;
		private EntityCollection<AccountEmployeeAssignmentEntity> _accountEmployeeAssignment__;
		private EntityCollection<AssetReclamationServiceChangeLogEntity> _assetReclamationServiceChangeLog;
		private EntityCollection<DeepFryerServiceEntity> _deepFryerService;
		private EntityCollection<DeepFryerServiceChangeLogEntity> _deepFryerServiceChangeLog_;
		private EntityCollection<DeepFryerServiceChangeLogEntity> _deepFryerServiceChangeLog;
		private EntityCollection<LoadEntity> _load;
		private EntityCollection<RecycleServiceActionEntity> _recycleServiceAction_;
		private EntityCollection<RecycleServiceActionEntity> _recycleServiceAction;
		private EntityCollection<RecycleServiceChangeLogEntity> _recycleServiceChangeLog;
		private EntityCollection<ServiceLocationEmployeeAssignmentEntity> _serviceLocationEmployeeAssignment____;
		private EntityCollection<ServiceLocationEmployeeAssignmentEntity> _serviceLocationEmployeeAssignment_____;
		private EntityCollection<ServiceLocationEmployeeAssignmentEntity> _serviceLocationEmployeeAssignment______;
		private EntityCollection<ServiceLocationEmployeeAssignmentEntity> _serviceLocationEmployeeAssignment___;
		private EntityCollection<ServiceLocationEmployeeAssignmentEntity> _serviceLocationEmployeeAssignment;
		private EntityCollection<ServiceLocationEmployeeAssignmentEntity> _serviceLocationEmployeeAssignment_;
		private EntityCollection<ServiceLocationEmployeeAssignmentEntity> _serviceLocationEmployeeAssignment__;
		private EntityCollection<WorkOrderEntity> _workOrder;
		private EntityCollection<AccountEntity> _accountCollectionViaAccountEmployeeAssignment_____;
		private EntityCollection<AccountEntity> _accountCollectionViaAccountEmployeeAssignment____;
		private EntityCollection<AccountEntity> _accountCollectionViaWorkOrder;
		private EntityCollection<AccountEntity> _accountCollectionViaAccountEmployeeAssignment______;
		private EntityCollection<AccountEntity> _accountCollectionViaAccountEmployeeAssignment_;
		private EntityCollection<AccountEntity> _accountCollectionViaAccountEmployeeAssignment;
		private EntityCollection<AccountEntity> _accountCollectionViaAccountEmployeeAssignment___;
		private EntityCollection<AccountEntity> _accountCollectionViaAccountEmployeeAssignment__;
		private EntityCollection<AssetReclamationServiceEntity> _assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog;
		private EntityCollection<DeepFryerEntity> _deepFryerCollectionViaDeepFryerService;
		private EntityCollection<DeepFryerServiceEntity> _deepFryerServiceCollectionViaDeepFryerServiceChangeLog;
		private EntityCollection<DeepFryerServiceEntity> _deepFryerServiceCollectionViaDeepFryerServiceChangeLog_;
		private EntityCollection<RecycleServiceEntity> _recycleServiceCollectionViaRecycleServiceAction;
		private EntityCollection<RecycleServiceEntity> _recycleServiceCollectionViaRecycleServiceChangeLog;
		private EntityCollection<RecycleServiceEntity> _recycleServiceCollectionViaRecycleServiceAction_;
		private EntityCollection<RecycleTypeEntity> _recycleTypeCollectionViaRecycleServiceAction;
		private EntityCollection<RecycleTypeEntity> _recycleTypeCollectionViaRecycleServiceAction_;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaServiceLocationEmployeeAssignment_;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaServiceLocationEmployeeAssignment;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaServiceLocationEmployeeAssignment_____;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaDeepFryerServiceChangeLog;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaDeepFryerService;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaServiceLocationEmployeeAssignment______;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaServiceLocationEmployeeAssignment____;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaServiceLocationEmployeeAssignment__;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaServiceLocationEmployeeAssignment___;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaDeepFryerServiceChangeLog_;
		private EntityCollection<ServiceTypeEntity> _serviceTypeCollectionViaWorkOrder;
		private EntityCollection<StatusEntity> _statusCollectionViaLoad;
		private EntityCollection<UserEntity> _userCollectionViaDeepFryerServiceChangeLog;
		private EntityCollection<UserEntity> _userCollectionViaDeepFryerServiceChangeLog_;
		private EntityCollection<UserEntity> _userCollectionViaRecycleServiceAction___;
		private EntityCollection<UserEntity> _userCollectionViaAssetReclamationServiceChangeLog;
		private EntityCollection<UserEntity> _userCollectionViaRecycleServiceChangeLog;
		private EntityCollection<UserEntity> _userCollectionViaRecycleServiceAction_;
		private EntityCollection<UserEntity> _userCollectionViaRecycleServiceAction__;
		private EntityCollection<UserEntity> _userCollectionViaRecycleServiceAction;
		private EntityCollection<WorkOrderEmployeeEntity> _workOrderEmployeeCollectionViaDeepFryerService;
		private EntityCollection<WorkOrderServiceLocationEntity> _workOrderServiceLocationCollectionViaDeepFryerService;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name AccountEmployeeAssignment____</summary>
			public static readonly string AccountEmployeeAssignment____ = "AccountEmployeeAssignment____";
			/// <summary>Member name AccountEmployeeAssignment_____</summary>
			public static readonly string AccountEmployeeAssignment_____ = "AccountEmployeeAssignment_____";
			/// <summary>Member name AccountEmployeeAssignment______</summary>
			public static readonly string AccountEmployeeAssignment______ = "AccountEmployeeAssignment______";
			/// <summary>Member name AccountEmployeeAssignment___</summary>
			public static readonly string AccountEmployeeAssignment___ = "AccountEmployeeAssignment___";
			/// <summary>Member name AccountEmployeeAssignment</summary>
			public static readonly string AccountEmployeeAssignment = "AccountEmployeeAssignment";
			/// <summary>Member name AccountEmployeeAssignment_</summary>
			public static readonly string AccountEmployeeAssignment_ = "AccountEmployeeAssignment_";
			/// <summary>Member name AccountEmployeeAssignment__</summary>
			public static readonly string AccountEmployeeAssignment__ = "AccountEmployeeAssignment__";
			/// <summary>Member name AssetReclamationServiceChangeLog</summary>
			public static readonly string AssetReclamationServiceChangeLog = "AssetReclamationServiceChangeLog";
			/// <summary>Member name DeepFryerService</summary>
			public static readonly string DeepFryerService = "DeepFryerService";
			/// <summary>Member name DeepFryerServiceChangeLog_</summary>
			public static readonly string DeepFryerServiceChangeLog_ = "DeepFryerServiceChangeLog_";
			/// <summary>Member name DeepFryerServiceChangeLog</summary>
			public static readonly string DeepFryerServiceChangeLog = "DeepFryerServiceChangeLog";
			/// <summary>Member name Load</summary>
			public static readonly string Load = "Load";
			/// <summary>Member name RecycleServiceAction_</summary>
			public static readonly string RecycleServiceAction_ = "RecycleServiceAction_";
			/// <summary>Member name RecycleServiceAction</summary>
			public static readonly string RecycleServiceAction = "RecycleServiceAction";
			/// <summary>Member name RecycleServiceChangeLog</summary>
			public static readonly string RecycleServiceChangeLog = "RecycleServiceChangeLog";
			/// <summary>Member name ServiceLocationEmployeeAssignment____</summary>
			public static readonly string ServiceLocationEmployeeAssignment____ = "ServiceLocationEmployeeAssignment____";
			/// <summary>Member name ServiceLocationEmployeeAssignment_____</summary>
			public static readonly string ServiceLocationEmployeeAssignment_____ = "ServiceLocationEmployeeAssignment_____";
			/// <summary>Member name ServiceLocationEmployeeAssignment______</summary>
			public static readonly string ServiceLocationEmployeeAssignment______ = "ServiceLocationEmployeeAssignment______";
			/// <summary>Member name ServiceLocationEmployeeAssignment___</summary>
			public static readonly string ServiceLocationEmployeeAssignment___ = "ServiceLocationEmployeeAssignment___";
			/// <summary>Member name ServiceLocationEmployeeAssignment</summary>
			public static readonly string ServiceLocationEmployeeAssignment = "ServiceLocationEmployeeAssignment";
			/// <summary>Member name ServiceLocationEmployeeAssignment_</summary>
			public static readonly string ServiceLocationEmployeeAssignment_ = "ServiceLocationEmployeeAssignment_";
			/// <summary>Member name ServiceLocationEmployeeAssignment__</summary>
			public static readonly string ServiceLocationEmployeeAssignment__ = "ServiceLocationEmployeeAssignment__";
			/// <summary>Member name WorkOrder</summary>
			public static readonly string WorkOrder = "WorkOrder";
			/// <summary>Member name AccountCollectionViaAccountEmployeeAssignment_____</summary>
			public static readonly string AccountCollectionViaAccountEmployeeAssignment_____ = "AccountCollectionViaAccountEmployeeAssignment_____";
			/// <summary>Member name AccountCollectionViaAccountEmployeeAssignment____</summary>
			public static readonly string AccountCollectionViaAccountEmployeeAssignment____ = "AccountCollectionViaAccountEmployeeAssignment____";
			/// <summary>Member name AccountCollectionViaWorkOrder</summary>
			public static readonly string AccountCollectionViaWorkOrder = "AccountCollectionViaWorkOrder";
			/// <summary>Member name AccountCollectionViaAccountEmployeeAssignment______</summary>
			public static readonly string AccountCollectionViaAccountEmployeeAssignment______ = "AccountCollectionViaAccountEmployeeAssignment______";
			/// <summary>Member name AccountCollectionViaAccountEmployeeAssignment_</summary>
			public static readonly string AccountCollectionViaAccountEmployeeAssignment_ = "AccountCollectionViaAccountEmployeeAssignment_";
			/// <summary>Member name AccountCollectionViaAccountEmployeeAssignment</summary>
			public static readonly string AccountCollectionViaAccountEmployeeAssignment = "AccountCollectionViaAccountEmployeeAssignment";
			/// <summary>Member name AccountCollectionViaAccountEmployeeAssignment___</summary>
			public static readonly string AccountCollectionViaAccountEmployeeAssignment___ = "AccountCollectionViaAccountEmployeeAssignment___";
			/// <summary>Member name AccountCollectionViaAccountEmployeeAssignment__</summary>
			public static readonly string AccountCollectionViaAccountEmployeeAssignment__ = "AccountCollectionViaAccountEmployeeAssignment__";
			/// <summary>Member name AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog</summary>
			public static readonly string AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog";
			/// <summary>Member name DeepFryerCollectionViaDeepFryerService</summary>
			public static readonly string DeepFryerCollectionViaDeepFryerService = "DeepFryerCollectionViaDeepFryerService";
			/// <summary>Member name DeepFryerServiceCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string DeepFryerServiceCollectionViaDeepFryerServiceChangeLog = "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_</summary>
			public static readonly string DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_";
			/// <summary>Member name RecycleServiceCollectionViaRecycleServiceAction</summary>
			public static readonly string RecycleServiceCollectionViaRecycleServiceAction = "RecycleServiceCollectionViaRecycleServiceAction";
			/// <summary>Member name RecycleServiceCollectionViaRecycleServiceChangeLog</summary>
			public static readonly string RecycleServiceCollectionViaRecycleServiceChangeLog = "RecycleServiceCollectionViaRecycleServiceChangeLog";
			/// <summary>Member name RecycleServiceCollectionViaRecycleServiceAction_</summary>
			public static readonly string RecycleServiceCollectionViaRecycleServiceAction_ = "RecycleServiceCollectionViaRecycleServiceAction_";
			/// <summary>Member name RecycleTypeCollectionViaRecycleServiceAction</summary>
			public static readonly string RecycleTypeCollectionViaRecycleServiceAction = "RecycleTypeCollectionViaRecycleServiceAction";
			/// <summary>Member name RecycleTypeCollectionViaRecycleServiceAction_</summary>
			public static readonly string RecycleTypeCollectionViaRecycleServiceAction_ = "RecycleTypeCollectionViaRecycleServiceAction_";
			/// <summary>Member name ServiceLocationCollectionViaServiceLocationEmployeeAssignment_</summary>
			public static readonly string ServiceLocationCollectionViaServiceLocationEmployeeAssignment_ = "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_";
			/// <summary>Member name ServiceLocationCollectionViaServiceLocationEmployeeAssignment</summary>
			public static readonly string ServiceLocationCollectionViaServiceLocationEmployeeAssignment = "ServiceLocationCollectionViaServiceLocationEmployeeAssignment";
			/// <summary>Member name ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____</summary>
			public static readonly string ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ = "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____";
			/// <summary>Member name ServiceLocationCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string ServiceLocationCollectionViaDeepFryerServiceChangeLog = "ServiceLocationCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name ServiceLocationCollectionViaDeepFryerService</summary>
			public static readonly string ServiceLocationCollectionViaDeepFryerService = "ServiceLocationCollectionViaDeepFryerService";
			/// <summary>Member name ServiceLocationCollectionViaServiceLocationEmployeeAssignment______</summary>
			public static readonly string ServiceLocationCollectionViaServiceLocationEmployeeAssignment______ = "ServiceLocationCollectionViaServiceLocationEmployeeAssignment______";
			/// <summary>Member name ServiceLocationCollectionViaServiceLocationEmployeeAssignment____</summary>
			public static readonly string ServiceLocationCollectionViaServiceLocationEmployeeAssignment____ = "ServiceLocationCollectionViaServiceLocationEmployeeAssignment____";
			/// <summary>Member name ServiceLocationCollectionViaServiceLocationEmployeeAssignment__</summary>
			public static readonly string ServiceLocationCollectionViaServiceLocationEmployeeAssignment__ = "ServiceLocationCollectionViaServiceLocationEmployeeAssignment__";
			/// <summary>Member name ServiceLocationCollectionViaServiceLocationEmployeeAssignment___</summary>
			public static readonly string ServiceLocationCollectionViaServiceLocationEmployeeAssignment___ = "ServiceLocationCollectionViaServiceLocationEmployeeAssignment___";
			/// <summary>Member name ServiceLocationCollectionViaDeepFryerServiceChangeLog_</summary>
			public static readonly string ServiceLocationCollectionViaDeepFryerServiceChangeLog_ = "ServiceLocationCollectionViaDeepFryerServiceChangeLog_";
			/// <summary>Member name ServiceTypeCollectionViaWorkOrder</summary>
			public static readonly string ServiceTypeCollectionViaWorkOrder = "ServiceTypeCollectionViaWorkOrder";
			/// <summary>Member name StatusCollectionViaLoad</summary>
			public static readonly string StatusCollectionViaLoad = "StatusCollectionViaLoad";
			/// <summary>Member name UserCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string UserCollectionViaDeepFryerServiceChangeLog = "UserCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name UserCollectionViaDeepFryerServiceChangeLog_</summary>
			public static readonly string UserCollectionViaDeepFryerServiceChangeLog_ = "UserCollectionViaDeepFryerServiceChangeLog_";
			/// <summary>Member name UserCollectionViaRecycleServiceAction___</summary>
			public static readonly string UserCollectionViaRecycleServiceAction___ = "UserCollectionViaRecycleServiceAction___";
			/// <summary>Member name UserCollectionViaAssetReclamationServiceChangeLog</summary>
			public static readonly string UserCollectionViaAssetReclamationServiceChangeLog = "UserCollectionViaAssetReclamationServiceChangeLog";
			/// <summary>Member name UserCollectionViaRecycleServiceChangeLog</summary>
			public static readonly string UserCollectionViaRecycleServiceChangeLog = "UserCollectionViaRecycleServiceChangeLog";
			/// <summary>Member name UserCollectionViaRecycleServiceAction_</summary>
			public static readonly string UserCollectionViaRecycleServiceAction_ = "UserCollectionViaRecycleServiceAction_";
			/// <summary>Member name UserCollectionViaRecycleServiceAction__</summary>
			public static readonly string UserCollectionViaRecycleServiceAction__ = "UserCollectionViaRecycleServiceAction__";
			/// <summary>Member name UserCollectionViaRecycleServiceAction</summary>
			public static readonly string UserCollectionViaRecycleServiceAction = "UserCollectionViaRecycleServiceAction";
			/// <summary>Member name WorkOrderEmployeeCollectionViaDeepFryerService</summary>
			public static readonly string WorkOrderEmployeeCollectionViaDeepFryerService = "WorkOrderEmployeeCollectionViaDeepFryerService";
			/// <summary>Member name WorkOrderServiceLocationCollectionViaDeepFryerService</summary>
			public static readonly string WorkOrderServiceLocationCollectionViaDeepFryerService = "WorkOrderServiceLocationCollectionViaDeepFryerService";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public EmployeeEntity():base("EmployeeEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public EmployeeEntity(IEntityFields2 fields):base("EmployeeEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(IValidator validator):base("EmployeeEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public EmployeeEntity(System.Int32 employeeId):base("EmployeeEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.EmployeeId = employeeId;
		}

		/// <summary> CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public EmployeeEntity(System.Int32 employeeId, IValidator validator):base("EmployeeEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.EmployeeId = employeeId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_accountEmployeeAssignment____ = (EntityCollection<AccountEmployeeAssignmentEntity>)info.GetValue("_accountEmployeeAssignment____", typeof(EntityCollection<AccountEmployeeAssignmentEntity>));
				_accountEmployeeAssignment_____ = (EntityCollection<AccountEmployeeAssignmentEntity>)info.GetValue("_accountEmployeeAssignment_____", typeof(EntityCollection<AccountEmployeeAssignmentEntity>));
				_accountEmployeeAssignment______ = (EntityCollection<AccountEmployeeAssignmentEntity>)info.GetValue("_accountEmployeeAssignment______", typeof(EntityCollection<AccountEmployeeAssignmentEntity>));
				_accountEmployeeAssignment___ = (EntityCollection<AccountEmployeeAssignmentEntity>)info.GetValue("_accountEmployeeAssignment___", typeof(EntityCollection<AccountEmployeeAssignmentEntity>));
				_accountEmployeeAssignment = (EntityCollection<AccountEmployeeAssignmentEntity>)info.GetValue("_accountEmployeeAssignment", typeof(EntityCollection<AccountEmployeeAssignmentEntity>));
				_accountEmployeeAssignment_ = (EntityCollection<AccountEmployeeAssignmentEntity>)info.GetValue("_accountEmployeeAssignment_", typeof(EntityCollection<AccountEmployeeAssignmentEntity>));
				_accountEmployeeAssignment__ = (EntityCollection<AccountEmployeeAssignmentEntity>)info.GetValue("_accountEmployeeAssignment__", typeof(EntityCollection<AccountEmployeeAssignmentEntity>));
				_assetReclamationServiceChangeLog = (EntityCollection<AssetReclamationServiceChangeLogEntity>)info.GetValue("_assetReclamationServiceChangeLog", typeof(EntityCollection<AssetReclamationServiceChangeLogEntity>));
				_deepFryerService = (EntityCollection<DeepFryerServiceEntity>)info.GetValue("_deepFryerService", typeof(EntityCollection<DeepFryerServiceEntity>));
				_deepFryerServiceChangeLog_ = (EntityCollection<DeepFryerServiceChangeLogEntity>)info.GetValue("_deepFryerServiceChangeLog_", typeof(EntityCollection<DeepFryerServiceChangeLogEntity>));
				_deepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceChangeLogEntity>)info.GetValue("_deepFryerServiceChangeLog", typeof(EntityCollection<DeepFryerServiceChangeLogEntity>));
				_load = (EntityCollection<LoadEntity>)info.GetValue("_load", typeof(EntityCollection<LoadEntity>));
				_recycleServiceAction_ = (EntityCollection<RecycleServiceActionEntity>)info.GetValue("_recycleServiceAction_", typeof(EntityCollection<RecycleServiceActionEntity>));
				_recycleServiceAction = (EntityCollection<RecycleServiceActionEntity>)info.GetValue("_recycleServiceAction", typeof(EntityCollection<RecycleServiceActionEntity>));
				_recycleServiceChangeLog = (EntityCollection<RecycleServiceChangeLogEntity>)info.GetValue("_recycleServiceChangeLog", typeof(EntityCollection<RecycleServiceChangeLogEntity>));
				_serviceLocationEmployeeAssignment____ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>)info.GetValue("_serviceLocationEmployeeAssignment____", typeof(EntityCollection<ServiceLocationEmployeeAssignmentEntity>));
				_serviceLocationEmployeeAssignment_____ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>)info.GetValue("_serviceLocationEmployeeAssignment_____", typeof(EntityCollection<ServiceLocationEmployeeAssignmentEntity>));
				_serviceLocationEmployeeAssignment______ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>)info.GetValue("_serviceLocationEmployeeAssignment______", typeof(EntityCollection<ServiceLocationEmployeeAssignmentEntity>));
				_serviceLocationEmployeeAssignment___ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>)info.GetValue("_serviceLocationEmployeeAssignment___", typeof(EntityCollection<ServiceLocationEmployeeAssignmentEntity>));
				_serviceLocationEmployeeAssignment = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>)info.GetValue("_serviceLocationEmployeeAssignment", typeof(EntityCollection<ServiceLocationEmployeeAssignmentEntity>));
				_serviceLocationEmployeeAssignment_ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>)info.GetValue("_serviceLocationEmployeeAssignment_", typeof(EntityCollection<ServiceLocationEmployeeAssignmentEntity>));
				_serviceLocationEmployeeAssignment__ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>)info.GetValue("_serviceLocationEmployeeAssignment__", typeof(EntityCollection<ServiceLocationEmployeeAssignmentEntity>));
				_workOrder = (EntityCollection<WorkOrderEntity>)info.GetValue("_workOrder", typeof(EntityCollection<WorkOrderEntity>));
				_accountCollectionViaAccountEmployeeAssignment_____ = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaAccountEmployeeAssignment_____", typeof(EntityCollection<AccountEntity>));
				_accountCollectionViaAccountEmployeeAssignment____ = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaAccountEmployeeAssignment____", typeof(EntityCollection<AccountEntity>));
				_accountCollectionViaWorkOrder = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaWorkOrder", typeof(EntityCollection<AccountEntity>));
				_accountCollectionViaAccountEmployeeAssignment______ = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaAccountEmployeeAssignment______", typeof(EntityCollection<AccountEntity>));
				_accountCollectionViaAccountEmployeeAssignment_ = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaAccountEmployeeAssignment_", typeof(EntityCollection<AccountEntity>));
				_accountCollectionViaAccountEmployeeAssignment = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaAccountEmployeeAssignment", typeof(EntityCollection<AccountEntity>));
				_accountCollectionViaAccountEmployeeAssignment___ = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaAccountEmployeeAssignment___", typeof(EntityCollection<AccountEntity>));
				_accountCollectionViaAccountEmployeeAssignment__ = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaAccountEmployeeAssignment__", typeof(EntityCollection<AccountEntity>));
				_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<AssetReclamationServiceEntity>)info.GetValue("_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", typeof(EntityCollection<AssetReclamationServiceEntity>));
				_deepFryerCollectionViaDeepFryerService = (EntityCollection<DeepFryerEntity>)info.GetValue("_deepFryerCollectionViaDeepFryerService", typeof(EntityCollection<DeepFryerEntity>));
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceEntity>)info.GetValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<DeepFryerServiceEntity>));
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<DeepFryerServiceEntity>)info.GetValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_", typeof(EntityCollection<DeepFryerServiceEntity>));
				_recycleServiceCollectionViaRecycleServiceAction = (EntityCollection<RecycleServiceEntity>)info.GetValue("_recycleServiceCollectionViaRecycleServiceAction", typeof(EntityCollection<RecycleServiceEntity>));
				_recycleServiceCollectionViaRecycleServiceChangeLog = (EntityCollection<RecycleServiceEntity>)info.GetValue("_recycleServiceCollectionViaRecycleServiceChangeLog", typeof(EntityCollection<RecycleServiceEntity>));
				_recycleServiceCollectionViaRecycleServiceAction_ = (EntityCollection<RecycleServiceEntity>)info.GetValue("_recycleServiceCollectionViaRecycleServiceAction_", typeof(EntityCollection<RecycleServiceEntity>));
				_recycleTypeCollectionViaRecycleServiceAction = (EntityCollection<RecycleTypeEntity>)info.GetValue("_recycleTypeCollectionViaRecycleServiceAction", typeof(EntityCollection<RecycleTypeEntity>));
				_recycleTypeCollectionViaRecycleServiceAction_ = (EntityCollection<RecycleTypeEntity>)info.GetValue("_recycleTypeCollectionViaRecycleServiceAction_", typeof(EntityCollection<RecycleTypeEntity>));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment_ = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment_", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____ = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationCollectionViaDeepFryerServiceChangeLog = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationCollectionViaDeepFryerService = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaDeepFryerService", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment______ = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment______", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment____ = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment____", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment__ = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment__", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment___ = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment___", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceLocationCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog_", typeof(EntityCollection<ServiceLocationEntity>));
				_serviceTypeCollectionViaWorkOrder = (EntityCollection<ServiceTypeEntity>)info.GetValue("_serviceTypeCollectionViaWorkOrder", typeof(EntityCollection<ServiceTypeEntity>));
				_statusCollectionViaLoad = (EntityCollection<StatusEntity>)info.GetValue("_statusCollectionViaLoad", typeof(EntityCollection<StatusEntity>));
				_userCollectionViaDeepFryerServiceChangeLog = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaDeepFryerServiceChangeLog", typeof(EntityCollection<UserEntity>));
				_userCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaDeepFryerServiceChangeLog_", typeof(EntityCollection<UserEntity>));
				_userCollectionViaRecycleServiceAction___ = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRecycleServiceAction___", typeof(EntityCollection<UserEntity>));
				_userCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaAssetReclamationServiceChangeLog", typeof(EntityCollection<UserEntity>));
				_userCollectionViaRecycleServiceChangeLog = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRecycleServiceChangeLog", typeof(EntityCollection<UserEntity>));
				_userCollectionViaRecycleServiceAction_ = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRecycleServiceAction_", typeof(EntityCollection<UserEntity>));
				_userCollectionViaRecycleServiceAction__ = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRecycleServiceAction__", typeof(EntityCollection<UserEntity>));
				_userCollectionViaRecycleServiceAction = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRecycleServiceAction", typeof(EntityCollection<UserEntity>));
				_workOrderEmployeeCollectionViaDeepFryerService = (EntityCollection<WorkOrderEmployeeEntity>)info.GetValue("_workOrderEmployeeCollectionViaDeepFryerService", typeof(EntityCollection<WorkOrderEmployeeEntity>));
				_workOrderServiceLocationCollectionViaDeepFryerService = (EntityCollection<WorkOrderServiceLocationEntity>)info.GetValue("_workOrderServiceLocationCollectionViaDeepFryerService", typeof(EntityCollection<WorkOrderServiceLocationEntity>));


				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((EmployeeFieldIndex)fieldIndex)
			{
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

				case "AccountEmployeeAssignment____":
					this.AccountEmployeeAssignment____.Add((AccountEmployeeAssignmentEntity)entity);
					break;
				case "AccountEmployeeAssignment_____":
					this.AccountEmployeeAssignment_____.Add((AccountEmployeeAssignmentEntity)entity);
					break;
				case "AccountEmployeeAssignment______":
					this.AccountEmployeeAssignment______.Add((AccountEmployeeAssignmentEntity)entity);
					break;
				case "AccountEmployeeAssignment___":
					this.AccountEmployeeAssignment___.Add((AccountEmployeeAssignmentEntity)entity);
					break;
				case "AccountEmployeeAssignment":
					this.AccountEmployeeAssignment.Add((AccountEmployeeAssignmentEntity)entity);
					break;
				case "AccountEmployeeAssignment_":
					this.AccountEmployeeAssignment_.Add((AccountEmployeeAssignmentEntity)entity);
					break;
				case "AccountEmployeeAssignment__":
					this.AccountEmployeeAssignment__.Add((AccountEmployeeAssignmentEntity)entity);
					break;
				case "AssetReclamationServiceChangeLog":
					this.AssetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)entity);
					break;
				case "DeepFryerService":
					this.DeepFryerService.Add((DeepFryerServiceEntity)entity);
					break;
				case "DeepFryerServiceChangeLog_":
					this.DeepFryerServiceChangeLog_.Add((DeepFryerServiceChangeLogEntity)entity);
					break;
				case "DeepFryerServiceChangeLog":
					this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)entity);
					break;
				case "Load":
					this.Load.Add((LoadEntity)entity);
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
				case "ServiceLocationEmployeeAssignment____":
					this.ServiceLocationEmployeeAssignment____.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					break;
				case "ServiceLocationEmployeeAssignment_____":
					this.ServiceLocationEmployeeAssignment_____.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					break;
				case "ServiceLocationEmployeeAssignment______":
					this.ServiceLocationEmployeeAssignment______.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					break;
				case "ServiceLocationEmployeeAssignment___":
					this.ServiceLocationEmployeeAssignment___.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					break;
				case "ServiceLocationEmployeeAssignment":
					this.ServiceLocationEmployeeAssignment.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					break;
				case "ServiceLocationEmployeeAssignment_":
					this.ServiceLocationEmployeeAssignment_.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					break;
				case "ServiceLocationEmployeeAssignment__":
					this.ServiceLocationEmployeeAssignment__.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					break;
				case "WorkOrder":
					this.WorkOrder.Add((WorkOrderEntity)entity);
					break;
				case "AccountCollectionViaAccountEmployeeAssignment_____":
					this.AccountCollectionViaAccountEmployeeAssignment_____.IsReadOnly = false;
					this.AccountCollectionViaAccountEmployeeAssignment_____.Add((AccountEntity)entity);
					this.AccountCollectionViaAccountEmployeeAssignment_____.IsReadOnly = true;
					break;
				case "AccountCollectionViaAccountEmployeeAssignment____":
					this.AccountCollectionViaAccountEmployeeAssignment____.IsReadOnly = false;
					this.AccountCollectionViaAccountEmployeeAssignment____.Add((AccountEntity)entity);
					this.AccountCollectionViaAccountEmployeeAssignment____.IsReadOnly = true;
					break;
				case "AccountCollectionViaWorkOrder":
					this.AccountCollectionViaWorkOrder.IsReadOnly = false;
					this.AccountCollectionViaWorkOrder.Add((AccountEntity)entity);
					this.AccountCollectionViaWorkOrder.IsReadOnly = true;
					break;
				case "AccountCollectionViaAccountEmployeeAssignment______":
					this.AccountCollectionViaAccountEmployeeAssignment______.IsReadOnly = false;
					this.AccountCollectionViaAccountEmployeeAssignment______.Add((AccountEntity)entity);
					this.AccountCollectionViaAccountEmployeeAssignment______.IsReadOnly = true;
					break;
				case "AccountCollectionViaAccountEmployeeAssignment_":
					this.AccountCollectionViaAccountEmployeeAssignment_.IsReadOnly = false;
					this.AccountCollectionViaAccountEmployeeAssignment_.Add((AccountEntity)entity);
					this.AccountCollectionViaAccountEmployeeAssignment_.IsReadOnly = true;
					break;
				case "AccountCollectionViaAccountEmployeeAssignment":
					this.AccountCollectionViaAccountEmployeeAssignment.IsReadOnly = false;
					this.AccountCollectionViaAccountEmployeeAssignment.Add((AccountEntity)entity);
					this.AccountCollectionViaAccountEmployeeAssignment.IsReadOnly = true;
					break;
				case "AccountCollectionViaAccountEmployeeAssignment___":
					this.AccountCollectionViaAccountEmployeeAssignment___.IsReadOnly = false;
					this.AccountCollectionViaAccountEmployeeAssignment___.Add((AccountEntity)entity);
					this.AccountCollectionViaAccountEmployeeAssignment___.IsReadOnly = true;
					break;
				case "AccountCollectionViaAccountEmployeeAssignment__":
					this.AccountCollectionViaAccountEmployeeAssignment__.IsReadOnly = false;
					this.AccountCollectionViaAccountEmployeeAssignment__.Add((AccountEntity)entity);
					this.AccountCollectionViaAccountEmployeeAssignment__.IsReadOnly = true;
					break;
				case "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog":
					this.AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = false;
					this.AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.Add((AssetReclamationServiceEntity)entity);
					this.AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = true;
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
				case "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_":
					this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = false;
					this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_.Add((DeepFryerServiceEntity)entity);
					this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = true;
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction":
					this.RecycleServiceCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.RecycleServiceCollectionViaRecycleServiceAction.Add((RecycleServiceEntity)entity);
					this.RecycleServiceCollectionViaRecycleServiceAction.IsReadOnly = true;
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
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_":
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment_.IsReadOnly = false;
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment_.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment_.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment":
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment.IsReadOnly = false;
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____":
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____.IsReadOnly = false;
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog":
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaDeepFryerService":
					this.ServiceLocationCollectionViaDeepFryerService.IsReadOnly = false;
					this.ServiceLocationCollectionViaDeepFryerService.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaDeepFryerService.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment______":
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment______.IsReadOnly = false;
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment______.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment______.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment____":
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment____.IsReadOnly = false;
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment____.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment____.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment__":
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment__.IsReadOnly = false;
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment__.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment__.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment___":
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment___.IsReadOnly = false;
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment___.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment___.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog_":
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = false;
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog_.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = true;
					break;
				case "ServiceTypeCollectionViaWorkOrder":
					this.ServiceTypeCollectionViaWorkOrder.IsReadOnly = false;
					this.ServiceTypeCollectionViaWorkOrder.Add((ServiceTypeEntity)entity);
					this.ServiceTypeCollectionViaWorkOrder.IsReadOnly = true;
					break;
				case "StatusCollectionViaLoad":
					this.StatusCollectionViaLoad.IsReadOnly = false;
					this.StatusCollectionViaLoad.Add((StatusEntity)entity);
					this.StatusCollectionViaLoad.IsReadOnly = true;
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog":
					this.UserCollectionViaDeepFryerServiceChangeLog.IsReadOnly = false;
					this.UserCollectionViaDeepFryerServiceChangeLog.Add((UserEntity)entity);
					this.UserCollectionViaDeepFryerServiceChangeLog.IsReadOnly = true;
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog_":
					this.UserCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = false;
					this.UserCollectionViaDeepFryerServiceChangeLog_.Add((UserEntity)entity);
					this.UserCollectionViaDeepFryerServiceChangeLog_.IsReadOnly = true;
					break;
				case "UserCollectionViaRecycleServiceAction___":
					this.UserCollectionViaRecycleServiceAction___.IsReadOnly = false;
					this.UserCollectionViaRecycleServiceAction___.Add((UserEntity)entity);
					this.UserCollectionViaRecycleServiceAction___.IsReadOnly = true;
					break;
				case "UserCollectionViaAssetReclamationServiceChangeLog":
					this.UserCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = false;
					this.UserCollectionViaAssetReclamationServiceChangeLog.Add((UserEntity)entity);
					this.UserCollectionViaAssetReclamationServiceChangeLog.IsReadOnly = true;
					break;
				case "UserCollectionViaRecycleServiceChangeLog":
					this.UserCollectionViaRecycleServiceChangeLog.IsReadOnly = false;
					this.UserCollectionViaRecycleServiceChangeLog.Add((UserEntity)entity);
					this.UserCollectionViaRecycleServiceChangeLog.IsReadOnly = true;
					break;
				case "UserCollectionViaRecycleServiceAction_":
					this.UserCollectionViaRecycleServiceAction_.IsReadOnly = false;
					this.UserCollectionViaRecycleServiceAction_.Add((UserEntity)entity);
					this.UserCollectionViaRecycleServiceAction_.IsReadOnly = true;
					break;
				case "UserCollectionViaRecycleServiceAction__":
					this.UserCollectionViaRecycleServiceAction__.IsReadOnly = false;
					this.UserCollectionViaRecycleServiceAction__.Add((UserEntity)entity);
					this.UserCollectionViaRecycleServiceAction__.IsReadOnly = true;
					break;
				case "UserCollectionViaRecycleServiceAction":
					this.UserCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.UserCollectionViaRecycleServiceAction.Add((UserEntity)entity);
					this.UserCollectionViaRecycleServiceAction.IsReadOnly = true;
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
			return EmployeeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "AccountEmployeeAssignment____":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingThursday);
					break;
				case "AccountEmployeeAssignment_____":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingTuesday);
					break;
				case "AccountEmployeeAssignment______":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingWednesday);
					break;
				case "AccountEmployeeAssignment___":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingSunday);
					break;
				case "AccountEmployeeAssignment":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingFriday);
					break;
				case "AccountEmployeeAssignment_":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingMonday);
					break;
				case "AccountEmployeeAssignment__":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingSaturday);
					break;
				case "AssetReclamationServiceChangeLog":
					toReturn.Add(EmployeeEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByEmployeeId);
					break;
				case "DeepFryerService":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby);
					break;
				case "DeepFryerServiceChangeLog_":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingServicedBy);
					break;
				case "DeepFryerServiceChangeLog":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId);
					break;
				case "Load":
					toReturn.Add(EmployeeEntity.Relations.LoadEntityUsingEmployeeId);
					break;
				case "RecycleServiceAction_":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId);
					break;
				case "RecycleServiceAction":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId);
					break;
				case "RecycleServiceChangeLog":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByEmployeeId);
					break;
				case "ServiceLocationEmployeeAssignment____":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingFriday);
					break;
				case "ServiceLocationEmployeeAssignment_____":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingSaturday);
					break;
				case "ServiceLocationEmployeeAssignment______":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingSunday);
					break;
				case "ServiceLocationEmployeeAssignment___":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingThursday);
					break;
				case "ServiceLocationEmployeeAssignment":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingMonday);
					break;
				case "ServiceLocationEmployeeAssignment_":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingTuesday);
					break;
				case "ServiceLocationEmployeeAssignment__":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingWednesday);
					break;
				case "WorkOrder":
					toReturn.Add(EmployeeEntity.Relations.WorkOrderEntityUsingTechnicianId);
					break;
				case "AccountCollectionViaAccountEmployeeAssignment_____":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingTuesday, "EmployeeEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "AccountCollectionViaAccountEmployeeAssignment____":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingThursday, "EmployeeEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "AccountCollectionViaWorkOrder":
					toReturn.Add(EmployeeEntity.Relations.WorkOrderEntityUsingTechnicianId, "EmployeeEntity__", "WorkOrder_", JoinHint.None);
					toReturn.Add(WorkOrderEntity.Relations.AccountEntityUsingAccountId, "WorkOrder_", string.Empty, JoinHint.None);
					break;
				case "AccountCollectionViaAccountEmployeeAssignment______":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingWednesday, "EmployeeEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "AccountCollectionViaAccountEmployeeAssignment_":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingMonday, "EmployeeEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "AccountCollectionViaAccountEmployeeAssignment":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingFriday, "EmployeeEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "AccountCollectionViaAccountEmployeeAssignment___":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingSunday, "EmployeeEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "AccountCollectionViaAccountEmployeeAssignment__":
					toReturn.Add(EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingSaturday, "EmployeeEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog":
					toReturn.Add(EmployeeEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByEmployeeId, "EmployeeEntity__", "AssetReclamationServiceChangeLog_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceChangeLogEntity.Relations.AssetReclamationServiceEntityUsingAssetReclamationServiceId, "AssetReclamationServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "DeepFryerCollectionViaDeepFryerService":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby, "EmployeeEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId, "EmployeeEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.DeepFryerServiceEntityUsingDeepFryerServiceId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingServicedBy, "EmployeeEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.DeepFryerServiceEntityUsingDeepFryerServiceId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId, "EmployeeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleServiceEntityUsingRecycleServiceId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "RecycleServiceCollectionViaRecycleServiceChangeLog":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByEmployeeId, "EmployeeEntity__", "RecycleServiceChangeLog_", JoinHint.None);
					toReturn.Add(RecycleServiceChangeLogEntity.Relations.RecycleServiceEntityUsingRecycleServiceId, "RecycleServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction_":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId, "EmployeeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleServiceEntityUsingRecycleServiceId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId, "EmployeeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction_":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId, "EmployeeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingTuesday, "EmployeeEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingMonday, "EmployeeEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingSaturday, "EmployeeEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId, "EmployeeEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaDeepFryerService":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby, "EmployeeEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment______":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingSunday, "EmployeeEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment____":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingFriday, "EmployeeEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment__":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingWednesday, "EmployeeEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment___":
					toReturn.Add(EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingThursday, "EmployeeEntity__", "ServiceLocationEmployeeAssignment_", JoinHint.None);
					toReturn.Add(ServiceLocationEmployeeAssignmentEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "ServiceLocationEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog_":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingServicedBy, "EmployeeEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "ServiceTypeCollectionViaWorkOrder":
					toReturn.Add(EmployeeEntity.Relations.WorkOrderEntityUsingTechnicianId, "EmployeeEntity__", "WorkOrder_", JoinHint.None);
					toReturn.Add(WorkOrderEntity.Relations.ServiceTypeEntityUsingServiceTypeId, "WorkOrder_", string.Empty, JoinHint.None);
					break;
				case "StatusCollectionViaLoad":
					toReturn.Add(EmployeeEntity.Relations.LoadEntityUsingEmployeeId, "EmployeeEntity__", "Load_", JoinHint.None);
					toReturn.Add(LoadEntity.Relations.StatusEntityUsingStatusId, "Load_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId, "EmployeeEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog_":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingServicedBy, "EmployeeEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceAction___":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId, "EmployeeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingLastChangedByUserId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaAssetReclamationServiceChangeLog":
					toReturn.Add(EmployeeEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByEmployeeId, "EmployeeEntity__", "AssetReclamationServiceChangeLog_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "AssetReclamationServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceChangeLog":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByEmployeeId, "EmployeeEntity__", "RecycleServiceChangeLog_", JoinHint.None);
					toReturn.Add(RecycleServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "RecycleServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceAction_":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId, "EmployeeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingActionUserId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceAction__":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId, "EmployeeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingLastChangedByUserId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceAction":
					toReturn.Add(EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId, "EmployeeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingActionUserId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderEmployeeCollectionViaDeepFryerService":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby, "EmployeeEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderServiceLocationCollectionViaDeepFryerService":
					toReturn.Add(EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby, "EmployeeEntity__", "DeepFryerService_", JoinHint.None);
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

				case "AccountEmployeeAssignment____":
					this.AccountEmployeeAssignment____.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment_____":
					this.AccountEmployeeAssignment_____.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment______":
					this.AccountEmployeeAssignment______.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment___":
					this.AccountEmployeeAssignment___.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment":
					this.AccountEmployeeAssignment.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment_":
					this.AccountEmployeeAssignment_.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment__":
					this.AccountEmployeeAssignment__.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AssetReclamationServiceChangeLog":
					this.AssetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)relatedEntity);
					break;
				case "DeepFryerService":
					this.DeepFryerService.Add((DeepFryerServiceEntity)relatedEntity);
					break;
				case "DeepFryerServiceChangeLog_":
					this.DeepFryerServiceChangeLog_.Add((DeepFryerServiceChangeLogEntity)relatedEntity);
					break;
				case "DeepFryerServiceChangeLog":
					this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)relatedEntity);
					break;
				case "Load":
					this.Load.Add((LoadEntity)relatedEntity);
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
				case "ServiceLocationEmployeeAssignment____":
					this.ServiceLocationEmployeeAssignment____.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment_____":
					this.ServiceLocationEmployeeAssignment_____.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment______":
					this.ServiceLocationEmployeeAssignment______.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment___":
					this.ServiceLocationEmployeeAssignment___.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment":
					this.ServiceLocationEmployeeAssignment.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment_":
					this.ServiceLocationEmployeeAssignment_.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment__":
					this.ServiceLocationEmployeeAssignment__.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "WorkOrder":
					this.WorkOrder.Add((WorkOrderEntity)relatedEntity);
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

				case "AccountEmployeeAssignment____":
					base.PerformRelatedEntityRemoval(this.AccountEmployeeAssignment____, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment_____":
					base.PerformRelatedEntityRemoval(this.AccountEmployeeAssignment_____, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment______":
					base.PerformRelatedEntityRemoval(this.AccountEmployeeAssignment______, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment___":
					base.PerformRelatedEntityRemoval(this.AccountEmployeeAssignment___, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment":
					base.PerformRelatedEntityRemoval(this.AccountEmployeeAssignment, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment_":
					base.PerformRelatedEntityRemoval(this.AccountEmployeeAssignment_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment__":
					base.PerformRelatedEntityRemoval(this.AccountEmployeeAssignment__, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AssetReclamationServiceChangeLog":
					base.PerformRelatedEntityRemoval(this.AssetReclamationServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerService":
					base.PerformRelatedEntityRemoval(this.DeepFryerService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerServiceChangeLog_":
					base.PerformRelatedEntityRemoval(this.DeepFryerServiceChangeLog_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerServiceChangeLog":
					base.PerformRelatedEntityRemoval(this.DeepFryerServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Load":
					base.PerformRelatedEntityRemoval(this.Load, relatedEntity, signalRelatedEntityManyToOne);
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
				case "ServiceLocationEmployeeAssignment____":
					base.PerformRelatedEntityRemoval(this.ServiceLocationEmployeeAssignment____, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment_____":
					base.PerformRelatedEntityRemoval(this.ServiceLocationEmployeeAssignment_____, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment______":
					base.PerformRelatedEntityRemoval(this.ServiceLocationEmployeeAssignment______, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment___":
					base.PerformRelatedEntityRemoval(this.ServiceLocationEmployeeAssignment___, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment":
					base.PerformRelatedEntityRemoval(this.ServiceLocationEmployeeAssignment, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment_":
					base.PerformRelatedEntityRemoval(this.ServiceLocationEmployeeAssignment_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment__":
					base.PerformRelatedEntityRemoval(this.ServiceLocationEmployeeAssignment__, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrder":
					base.PerformRelatedEntityRemoval(this.WorkOrder, relatedEntity, signalRelatedEntityManyToOne);
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


			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.AccountEmployeeAssignment____);
			toReturn.Add(this.AccountEmployeeAssignment_____);
			toReturn.Add(this.AccountEmployeeAssignment______);
			toReturn.Add(this.AccountEmployeeAssignment___);
			toReturn.Add(this.AccountEmployeeAssignment);
			toReturn.Add(this.AccountEmployeeAssignment_);
			toReturn.Add(this.AccountEmployeeAssignment__);
			toReturn.Add(this.AssetReclamationServiceChangeLog);
			toReturn.Add(this.DeepFryerService);
			toReturn.Add(this.DeepFryerServiceChangeLog_);
			toReturn.Add(this.DeepFryerServiceChangeLog);
			toReturn.Add(this.Load);
			toReturn.Add(this.RecycleServiceAction_);
			toReturn.Add(this.RecycleServiceAction);
			toReturn.Add(this.RecycleServiceChangeLog);
			toReturn.Add(this.ServiceLocationEmployeeAssignment____);
			toReturn.Add(this.ServiceLocationEmployeeAssignment_____);
			toReturn.Add(this.ServiceLocationEmployeeAssignment______);
			toReturn.Add(this.ServiceLocationEmployeeAssignment___);
			toReturn.Add(this.ServiceLocationEmployeeAssignment);
			toReturn.Add(this.ServiceLocationEmployeeAssignment_);
			toReturn.Add(this.ServiceLocationEmployeeAssignment__);
			toReturn.Add(this.WorkOrder);

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
				info.AddValue("_accountEmployeeAssignment____", ((_accountEmployeeAssignment____!=null) && (_accountEmployeeAssignment____.Count>0) && !this.MarkedForDeletion)?_accountEmployeeAssignment____:null);
				info.AddValue("_accountEmployeeAssignment_____", ((_accountEmployeeAssignment_____!=null) && (_accountEmployeeAssignment_____.Count>0) && !this.MarkedForDeletion)?_accountEmployeeAssignment_____:null);
				info.AddValue("_accountEmployeeAssignment______", ((_accountEmployeeAssignment______!=null) && (_accountEmployeeAssignment______.Count>0) && !this.MarkedForDeletion)?_accountEmployeeAssignment______:null);
				info.AddValue("_accountEmployeeAssignment___", ((_accountEmployeeAssignment___!=null) && (_accountEmployeeAssignment___.Count>0) && !this.MarkedForDeletion)?_accountEmployeeAssignment___:null);
				info.AddValue("_accountEmployeeAssignment", ((_accountEmployeeAssignment!=null) && (_accountEmployeeAssignment.Count>0) && !this.MarkedForDeletion)?_accountEmployeeAssignment:null);
				info.AddValue("_accountEmployeeAssignment_", ((_accountEmployeeAssignment_!=null) && (_accountEmployeeAssignment_.Count>0) && !this.MarkedForDeletion)?_accountEmployeeAssignment_:null);
				info.AddValue("_accountEmployeeAssignment__", ((_accountEmployeeAssignment__!=null) && (_accountEmployeeAssignment__.Count>0) && !this.MarkedForDeletion)?_accountEmployeeAssignment__:null);
				info.AddValue("_assetReclamationServiceChangeLog", ((_assetReclamationServiceChangeLog!=null) && (_assetReclamationServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_assetReclamationServiceChangeLog:null);
				info.AddValue("_deepFryerService", ((_deepFryerService!=null) && (_deepFryerService.Count>0) && !this.MarkedForDeletion)?_deepFryerService:null);
				info.AddValue("_deepFryerServiceChangeLog_", ((_deepFryerServiceChangeLog_!=null) && (_deepFryerServiceChangeLog_.Count>0) && !this.MarkedForDeletion)?_deepFryerServiceChangeLog_:null);
				info.AddValue("_deepFryerServiceChangeLog", ((_deepFryerServiceChangeLog!=null) && (_deepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_deepFryerServiceChangeLog:null);
				info.AddValue("_load", ((_load!=null) && (_load.Count>0) && !this.MarkedForDeletion)?_load:null);
				info.AddValue("_recycleServiceAction_", ((_recycleServiceAction_!=null) && (_recycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_recycleServiceAction_:null);
				info.AddValue("_recycleServiceAction", ((_recycleServiceAction!=null) && (_recycleServiceAction.Count>0) && !this.MarkedForDeletion)?_recycleServiceAction:null);
				info.AddValue("_recycleServiceChangeLog", ((_recycleServiceChangeLog!=null) && (_recycleServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_recycleServiceChangeLog:null);
				info.AddValue("_serviceLocationEmployeeAssignment____", ((_serviceLocationEmployeeAssignment____!=null) && (_serviceLocationEmployeeAssignment____.Count>0) && !this.MarkedForDeletion)?_serviceLocationEmployeeAssignment____:null);
				info.AddValue("_serviceLocationEmployeeAssignment_____", ((_serviceLocationEmployeeAssignment_____!=null) && (_serviceLocationEmployeeAssignment_____.Count>0) && !this.MarkedForDeletion)?_serviceLocationEmployeeAssignment_____:null);
				info.AddValue("_serviceLocationEmployeeAssignment______", ((_serviceLocationEmployeeAssignment______!=null) && (_serviceLocationEmployeeAssignment______.Count>0) && !this.MarkedForDeletion)?_serviceLocationEmployeeAssignment______:null);
				info.AddValue("_serviceLocationEmployeeAssignment___", ((_serviceLocationEmployeeAssignment___!=null) && (_serviceLocationEmployeeAssignment___.Count>0) && !this.MarkedForDeletion)?_serviceLocationEmployeeAssignment___:null);
				info.AddValue("_serviceLocationEmployeeAssignment", ((_serviceLocationEmployeeAssignment!=null) && (_serviceLocationEmployeeAssignment.Count>0) && !this.MarkedForDeletion)?_serviceLocationEmployeeAssignment:null);
				info.AddValue("_serviceLocationEmployeeAssignment_", ((_serviceLocationEmployeeAssignment_!=null) && (_serviceLocationEmployeeAssignment_.Count>0) && !this.MarkedForDeletion)?_serviceLocationEmployeeAssignment_:null);
				info.AddValue("_serviceLocationEmployeeAssignment__", ((_serviceLocationEmployeeAssignment__!=null) && (_serviceLocationEmployeeAssignment__.Count>0) && !this.MarkedForDeletion)?_serviceLocationEmployeeAssignment__:null);
				info.AddValue("_workOrder", ((_workOrder!=null) && (_workOrder.Count>0) && !this.MarkedForDeletion)?_workOrder:null);
				info.AddValue("_accountCollectionViaAccountEmployeeAssignment_____", ((_accountCollectionViaAccountEmployeeAssignment_____!=null) && (_accountCollectionViaAccountEmployeeAssignment_____.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaAccountEmployeeAssignment_____:null);
				info.AddValue("_accountCollectionViaAccountEmployeeAssignment____", ((_accountCollectionViaAccountEmployeeAssignment____!=null) && (_accountCollectionViaAccountEmployeeAssignment____.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaAccountEmployeeAssignment____:null);
				info.AddValue("_accountCollectionViaWorkOrder", ((_accountCollectionViaWorkOrder!=null) && (_accountCollectionViaWorkOrder.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaWorkOrder:null);
				info.AddValue("_accountCollectionViaAccountEmployeeAssignment______", ((_accountCollectionViaAccountEmployeeAssignment______!=null) && (_accountCollectionViaAccountEmployeeAssignment______.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaAccountEmployeeAssignment______:null);
				info.AddValue("_accountCollectionViaAccountEmployeeAssignment_", ((_accountCollectionViaAccountEmployeeAssignment_!=null) && (_accountCollectionViaAccountEmployeeAssignment_.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaAccountEmployeeAssignment_:null);
				info.AddValue("_accountCollectionViaAccountEmployeeAssignment", ((_accountCollectionViaAccountEmployeeAssignment!=null) && (_accountCollectionViaAccountEmployeeAssignment.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaAccountEmployeeAssignment:null);
				info.AddValue("_accountCollectionViaAccountEmployeeAssignment___", ((_accountCollectionViaAccountEmployeeAssignment___!=null) && (_accountCollectionViaAccountEmployeeAssignment___.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaAccountEmployeeAssignment___:null);
				info.AddValue("_accountCollectionViaAccountEmployeeAssignment__", ((_accountCollectionViaAccountEmployeeAssignment__!=null) && (_accountCollectionViaAccountEmployeeAssignment__.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaAccountEmployeeAssignment__:null);
				info.AddValue("_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", ((_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog!=null) && (_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog:null);
				info.AddValue("_deepFryerCollectionViaDeepFryerService", ((_deepFryerCollectionViaDeepFryerService!=null) && (_deepFryerCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_deepFryerCollectionViaDeepFryerService:null);
				info.AddValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", ((_deepFryerServiceCollectionViaDeepFryerServiceChangeLog!=null) && (_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_deepFryerServiceCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_", ((_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_!=null) && (_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.Count>0) && !this.MarkedForDeletion)?_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_:null);
				info.AddValue("_recycleServiceCollectionViaRecycleServiceAction", ((_recycleServiceCollectionViaRecycleServiceAction!=null) && (_recycleServiceCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_recycleServiceCollectionViaRecycleServiceAction:null);
				info.AddValue("_recycleServiceCollectionViaRecycleServiceChangeLog", ((_recycleServiceCollectionViaRecycleServiceChangeLog!=null) && (_recycleServiceCollectionViaRecycleServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_recycleServiceCollectionViaRecycleServiceChangeLog:null);
				info.AddValue("_recycleServiceCollectionViaRecycleServiceAction_", ((_recycleServiceCollectionViaRecycleServiceAction_!=null) && (_recycleServiceCollectionViaRecycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_recycleServiceCollectionViaRecycleServiceAction_:null);
				info.AddValue("_recycleTypeCollectionViaRecycleServiceAction", ((_recycleTypeCollectionViaRecycleServiceAction!=null) && (_recycleTypeCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_recycleTypeCollectionViaRecycleServiceAction:null);
				info.AddValue("_recycleTypeCollectionViaRecycleServiceAction_", ((_recycleTypeCollectionViaRecycleServiceAction_!=null) && (_recycleTypeCollectionViaRecycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_recycleTypeCollectionViaRecycleServiceAction_:null);
				info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment_", ((_serviceLocationCollectionViaServiceLocationEmployeeAssignment_!=null) && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaServiceLocationEmployeeAssignment_:null);
				info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment", ((_serviceLocationCollectionViaServiceLocationEmployeeAssignment!=null) && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaServiceLocationEmployeeAssignment:null);
				info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____", ((_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____!=null) && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____:null);
				info.AddValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", ((_serviceLocationCollectionViaDeepFryerServiceChangeLog!=null) && (_serviceLocationCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_serviceLocationCollectionViaDeepFryerService", ((_serviceLocationCollectionViaDeepFryerService!=null) && (_serviceLocationCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaDeepFryerService:null);
				info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment______", ((_serviceLocationCollectionViaServiceLocationEmployeeAssignment______!=null) && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaServiceLocationEmployeeAssignment______:null);
				info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment____", ((_serviceLocationCollectionViaServiceLocationEmployeeAssignment____!=null) && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaServiceLocationEmployeeAssignment____:null);
				info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment__", ((_serviceLocationCollectionViaServiceLocationEmployeeAssignment__!=null) && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaServiceLocationEmployeeAssignment__:null);
				info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment___", ((_serviceLocationCollectionViaServiceLocationEmployeeAssignment___!=null) && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaServiceLocationEmployeeAssignment___:null);
				info.AddValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog_", ((_serviceLocationCollectionViaDeepFryerServiceChangeLog_!=null) && (_serviceLocationCollectionViaDeepFryerServiceChangeLog_.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaDeepFryerServiceChangeLog_:null);
				info.AddValue("_serviceTypeCollectionViaWorkOrder", ((_serviceTypeCollectionViaWorkOrder!=null) && (_serviceTypeCollectionViaWorkOrder.Count>0) && !this.MarkedForDeletion)?_serviceTypeCollectionViaWorkOrder:null);
				info.AddValue("_statusCollectionViaLoad", ((_statusCollectionViaLoad!=null) && (_statusCollectionViaLoad.Count>0) && !this.MarkedForDeletion)?_statusCollectionViaLoad:null);
				info.AddValue("_userCollectionViaDeepFryerServiceChangeLog", ((_userCollectionViaDeepFryerServiceChangeLog!=null) && (_userCollectionViaDeepFryerServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_userCollectionViaDeepFryerServiceChangeLog:null);
				info.AddValue("_userCollectionViaDeepFryerServiceChangeLog_", ((_userCollectionViaDeepFryerServiceChangeLog_!=null) && (_userCollectionViaDeepFryerServiceChangeLog_.Count>0) && !this.MarkedForDeletion)?_userCollectionViaDeepFryerServiceChangeLog_:null);
				info.AddValue("_userCollectionViaRecycleServiceAction___", ((_userCollectionViaRecycleServiceAction___!=null) && (_userCollectionViaRecycleServiceAction___.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRecycleServiceAction___:null);
				info.AddValue("_userCollectionViaAssetReclamationServiceChangeLog", ((_userCollectionViaAssetReclamationServiceChangeLog!=null) && (_userCollectionViaAssetReclamationServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_userCollectionViaAssetReclamationServiceChangeLog:null);
				info.AddValue("_userCollectionViaRecycleServiceChangeLog", ((_userCollectionViaRecycleServiceChangeLog!=null) && (_userCollectionViaRecycleServiceChangeLog.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRecycleServiceChangeLog:null);
				info.AddValue("_userCollectionViaRecycleServiceAction_", ((_userCollectionViaRecycleServiceAction_!=null) && (_userCollectionViaRecycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRecycleServiceAction_:null);
				info.AddValue("_userCollectionViaRecycleServiceAction__", ((_userCollectionViaRecycleServiceAction__!=null) && (_userCollectionViaRecycleServiceAction__.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRecycleServiceAction__:null);
				info.AddValue("_userCollectionViaRecycleServiceAction", ((_userCollectionViaRecycleServiceAction!=null) && (_userCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRecycleServiceAction:null);
				info.AddValue("_workOrderEmployeeCollectionViaDeepFryerService", ((_workOrderEmployeeCollectionViaDeepFryerService!=null) && (_workOrderEmployeeCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_workOrderEmployeeCollectionViaDeepFryerService:null);
				info.AddValue("_workOrderServiceLocationCollectionViaDeepFryerService", ((_workOrderServiceLocationCollectionViaDeepFryerService!=null) && (_workOrderServiceLocationCollectionViaDeepFryerService.Count>0) && !this.MarkedForDeletion)?_workOrderServiceLocationCollectionViaDeepFryerService:null);


			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(EmployeeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(EmployeeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new EmployeeRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AccountEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountEmployeeAssignment____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountEmployeeAssignmentFields.Thursday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AccountEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountEmployeeAssignment_____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountEmployeeAssignmentFields.Tuesday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AccountEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountEmployeeAssignment______()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountEmployeeAssignmentFields.Wednesday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AccountEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountEmployeeAssignment___()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountEmployeeAssignmentFields.Sunday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AccountEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountEmployeeAssignment()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountEmployeeAssignmentFields.Friday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AccountEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountEmployeeAssignment_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountEmployeeAssignmentFields.Monday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AccountEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountEmployeeAssignment__()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountEmployeeAssignmentFields.Saturday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AssetReclamationServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAssetReclamationServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AssetReclamationServiceChangeLogFields.EnteredByEmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.Servicedby, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerServiceChangeLog_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceChangeLogFields.ServicedBy, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DeepFryerServiceChangeLogFields.EnteredByEmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Load' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoLoad()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(LoadFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleServiceAction' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceActionFields.ActionEmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleServiceAction' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceActionFields.LastChangedByEmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleServiceChangeLog' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceChangeLogFields.EnteredByEmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationEmployeeAssignment____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationEmployeeAssignmentFields.Friday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationEmployeeAssignment_____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationEmployeeAssignmentFields.Saturday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationEmployeeAssignment______()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationEmployeeAssignmentFields.Sunday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationEmployeeAssignment___()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationEmployeeAssignmentFields.Thursday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationEmployeeAssignment()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationEmployeeAssignmentFields.Monday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationEmployeeAssignment_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationEmployeeAssignmentFields.Tuesday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationEmployeeAssignment__()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationEmployeeAssignmentFields.Wednesday, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrder' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderFields.TechnicianId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaAccountEmployeeAssignment_____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaAccountEmployeeAssignment_____"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaAccountEmployeeAssignment____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaAccountEmployeeAssignment____"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaWorkOrder"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaAccountEmployeeAssignment______()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaAccountEmployeeAssignment______"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaAccountEmployeeAssignment_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaAccountEmployeeAssignment_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaAccountEmployeeAssignment()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaAccountEmployeeAssignment"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaAccountEmployeeAssignment___()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaAccountEmployeeAssignment___"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaAccountEmployeeAssignment__()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaAccountEmployeeAssignment__"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AssetReclamationService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryer' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DeepFryerCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerServiceCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'DeepFryerService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleServiceCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceCollectionViaRecycleServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleServiceCollectionViaRecycleServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceCollectionViaRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleServiceCollectionViaRecycleServiceAction_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleTypeCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleTypeCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleTypeCollectionViaRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleTypeCollectionViaRecycleServiceAction_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaServiceLocationEmployeeAssignment_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaServiceLocationEmployeeAssignment_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaServiceLocationEmployeeAssignment()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaServiceLocationEmployeeAssignment"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaServiceLocationEmployeeAssignment_____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaServiceLocationEmployeeAssignment______()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaServiceLocationEmployeeAssignment______"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaServiceLocationEmployeeAssignment____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaServiceLocationEmployeeAssignment____"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaServiceLocationEmployeeAssignment__()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaServiceLocationEmployeeAssignment__"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaServiceLocationEmployeeAssignment___()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaServiceLocationEmployeeAssignment___"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaDeepFryerServiceChangeLog_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaDeepFryerServiceChangeLog_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceTypeCollectionViaWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceTypeCollectionViaWorkOrder"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Status' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStatusCollectionViaLoad()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("StatusCollectionViaLoad"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaDeepFryerServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaDeepFryerServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaDeepFryerServiceChangeLog_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaDeepFryerServiceChangeLog_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRecycleServiceAction___()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRecycleServiceAction___"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaAssetReclamationServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaAssetReclamationServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRecycleServiceChangeLog()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRecycleServiceChangeLog"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRecycleServiceAction_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRecycleServiceAction__()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRecycleServiceAction__"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderEmployee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderEmployeeCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WorkOrderEmployeeCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrderServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderServiceLocationCollectionViaDeepFryerService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("WorkOrderServiceLocationCollectionViaDeepFryerService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
			return bucket;
		}


	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.EmployeeEntity);
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
			return EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._accountEmployeeAssignment____);
			collectionsQueue.Enqueue(this._accountEmployeeAssignment_____);
			collectionsQueue.Enqueue(this._accountEmployeeAssignment______);
			collectionsQueue.Enqueue(this._accountEmployeeAssignment___);
			collectionsQueue.Enqueue(this._accountEmployeeAssignment);
			collectionsQueue.Enqueue(this._accountEmployeeAssignment_);
			collectionsQueue.Enqueue(this._accountEmployeeAssignment__);
			collectionsQueue.Enqueue(this._assetReclamationServiceChangeLog);
			collectionsQueue.Enqueue(this._deepFryerService);
			collectionsQueue.Enqueue(this._deepFryerServiceChangeLog_);
			collectionsQueue.Enqueue(this._deepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._load);
			collectionsQueue.Enqueue(this._recycleServiceAction_);
			collectionsQueue.Enqueue(this._recycleServiceAction);
			collectionsQueue.Enqueue(this._recycleServiceChangeLog);
			collectionsQueue.Enqueue(this._serviceLocationEmployeeAssignment____);
			collectionsQueue.Enqueue(this._serviceLocationEmployeeAssignment_____);
			collectionsQueue.Enqueue(this._serviceLocationEmployeeAssignment______);
			collectionsQueue.Enqueue(this._serviceLocationEmployeeAssignment___);
			collectionsQueue.Enqueue(this._serviceLocationEmployeeAssignment);
			collectionsQueue.Enqueue(this._serviceLocationEmployeeAssignment_);
			collectionsQueue.Enqueue(this._serviceLocationEmployeeAssignment__);
			collectionsQueue.Enqueue(this._workOrder);
			collectionsQueue.Enqueue(this._accountCollectionViaAccountEmployeeAssignment_____);
			collectionsQueue.Enqueue(this._accountCollectionViaAccountEmployeeAssignment____);
			collectionsQueue.Enqueue(this._accountCollectionViaWorkOrder);
			collectionsQueue.Enqueue(this._accountCollectionViaAccountEmployeeAssignment______);
			collectionsQueue.Enqueue(this._accountCollectionViaAccountEmployeeAssignment_);
			collectionsQueue.Enqueue(this._accountCollectionViaAccountEmployeeAssignment);
			collectionsQueue.Enqueue(this._accountCollectionViaAccountEmployeeAssignment___);
			collectionsQueue.Enqueue(this._accountCollectionViaAccountEmployeeAssignment__);
			collectionsQueue.Enqueue(this._assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog);
			collectionsQueue.Enqueue(this._deepFryerCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog_);
			collectionsQueue.Enqueue(this._recycleServiceCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._recycleServiceCollectionViaRecycleServiceChangeLog);
			collectionsQueue.Enqueue(this._recycleServiceCollectionViaRecycleServiceAction_);
			collectionsQueue.Enqueue(this._recycleTypeCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._recycleTypeCollectionViaRecycleServiceAction_);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaServiceLocationEmployeeAssignment_);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaServiceLocationEmployeeAssignment);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaServiceLocationEmployeeAssignment_____);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaDeepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaServiceLocationEmployeeAssignment______);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaServiceLocationEmployeeAssignment____);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaServiceLocationEmployeeAssignment__);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaServiceLocationEmployeeAssignment___);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaDeepFryerServiceChangeLog_);
			collectionsQueue.Enqueue(this._serviceTypeCollectionViaWorkOrder);
			collectionsQueue.Enqueue(this._statusCollectionViaLoad);
			collectionsQueue.Enqueue(this._userCollectionViaDeepFryerServiceChangeLog);
			collectionsQueue.Enqueue(this._userCollectionViaDeepFryerServiceChangeLog_);
			collectionsQueue.Enqueue(this._userCollectionViaRecycleServiceAction___);
			collectionsQueue.Enqueue(this._userCollectionViaAssetReclamationServiceChangeLog);
			collectionsQueue.Enqueue(this._userCollectionViaRecycleServiceChangeLog);
			collectionsQueue.Enqueue(this._userCollectionViaRecycleServiceAction_);
			collectionsQueue.Enqueue(this._userCollectionViaRecycleServiceAction__);
			collectionsQueue.Enqueue(this._userCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._workOrderEmployeeCollectionViaDeepFryerService);
			collectionsQueue.Enqueue(this._workOrderServiceLocationCollectionViaDeepFryerService);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._accountEmployeeAssignment____ = (EntityCollection<AccountEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._accountEmployeeAssignment_____ = (EntityCollection<AccountEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._accountEmployeeAssignment______ = (EntityCollection<AccountEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._accountEmployeeAssignment___ = (EntityCollection<AccountEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._accountEmployeeAssignment = (EntityCollection<AccountEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._accountEmployeeAssignment_ = (EntityCollection<AccountEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._accountEmployeeAssignment__ = (EntityCollection<AccountEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._assetReclamationServiceChangeLog = (EntityCollection<AssetReclamationServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._deepFryerService = (EntityCollection<DeepFryerServiceEntity>) collectionsQueue.Dequeue();
			this._deepFryerServiceChangeLog_ = (EntityCollection<DeepFryerServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._deepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._load = (EntityCollection<LoadEntity>) collectionsQueue.Dequeue();
			this._recycleServiceAction_ = (EntityCollection<RecycleServiceActionEntity>) collectionsQueue.Dequeue();
			this._recycleServiceAction = (EntityCollection<RecycleServiceActionEntity>) collectionsQueue.Dequeue();
			this._recycleServiceChangeLog = (EntityCollection<RecycleServiceChangeLogEntity>) collectionsQueue.Dequeue();
			this._serviceLocationEmployeeAssignment____ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._serviceLocationEmployeeAssignment_____ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._serviceLocationEmployeeAssignment______ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._serviceLocationEmployeeAssignment___ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._serviceLocationEmployeeAssignment = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._serviceLocationEmployeeAssignment_ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._serviceLocationEmployeeAssignment__ = (EntityCollection<ServiceLocationEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._workOrder = (EntityCollection<WorkOrderEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaAccountEmployeeAssignment_____ = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaAccountEmployeeAssignment____ = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaWorkOrder = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaAccountEmployeeAssignment______ = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaAccountEmployeeAssignment_ = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaAccountEmployeeAssignment = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaAccountEmployeeAssignment___ = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaAccountEmployeeAssignment__ = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<AssetReclamationServiceEntity>) collectionsQueue.Dequeue();
			this._deepFryerCollectionViaDeepFryerService = (EntityCollection<DeepFryerEntity>) collectionsQueue.Dequeue();
			this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog = (EntityCollection<DeepFryerServiceEntity>) collectionsQueue.Dequeue();
			this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<DeepFryerServiceEntity>) collectionsQueue.Dequeue();
			this._recycleServiceCollectionViaRecycleServiceAction = (EntityCollection<RecycleServiceEntity>) collectionsQueue.Dequeue();
			this._recycleServiceCollectionViaRecycleServiceChangeLog = (EntityCollection<RecycleServiceEntity>) collectionsQueue.Dequeue();
			this._recycleServiceCollectionViaRecycleServiceAction_ = (EntityCollection<RecycleServiceEntity>) collectionsQueue.Dequeue();
			this._recycleTypeCollectionViaRecycleServiceAction = (EntityCollection<RecycleTypeEntity>) collectionsQueue.Dequeue();
			this._recycleTypeCollectionViaRecycleServiceAction_ = (EntityCollection<RecycleTypeEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaServiceLocationEmployeeAssignment_ = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaServiceLocationEmployeeAssignment = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaServiceLocationEmployeeAssignment_____ = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaDeepFryerServiceChangeLog = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaDeepFryerService = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaServiceLocationEmployeeAssignment______ = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaServiceLocationEmployeeAssignment____ = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaServiceLocationEmployeeAssignment__ = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaServiceLocationEmployeeAssignment___ = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._serviceTypeCollectionViaWorkOrder = (EntityCollection<ServiceTypeEntity>) collectionsQueue.Dequeue();
			this._statusCollectionViaLoad = (EntityCollection<StatusEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaDeepFryerServiceChangeLog = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaDeepFryerServiceChangeLog_ = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRecycleServiceAction___ = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaAssetReclamationServiceChangeLog = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRecycleServiceChangeLog = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRecycleServiceAction_ = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRecycleServiceAction__ = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRecycleServiceAction = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._workOrderEmployeeCollectionViaDeepFryerService = (EntityCollection<WorkOrderEmployeeEntity>) collectionsQueue.Dequeue();
			this._workOrderServiceLocationCollectionViaDeepFryerService = (EntityCollection<WorkOrderServiceLocationEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._accountEmployeeAssignment____ != null)
			{
				return true;
			}
			if (this._accountEmployeeAssignment_____ != null)
			{
				return true;
			}
			if (this._accountEmployeeAssignment______ != null)
			{
				return true;
			}
			if (this._accountEmployeeAssignment___ != null)
			{
				return true;
			}
			if (this._accountEmployeeAssignment != null)
			{
				return true;
			}
			if (this._accountEmployeeAssignment_ != null)
			{
				return true;
			}
			if (this._accountEmployeeAssignment__ != null)
			{
				return true;
			}
			if (this._assetReclamationServiceChangeLog != null)
			{
				return true;
			}
			if (this._deepFryerService != null)
			{
				return true;
			}
			if (this._deepFryerServiceChangeLog_ != null)
			{
				return true;
			}
			if (this._deepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._load != null)
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
			if (this._serviceLocationEmployeeAssignment____ != null)
			{
				return true;
			}
			if (this._serviceLocationEmployeeAssignment_____ != null)
			{
				return true;
			}
			if (this._serviceLocationEmployeeAssignment______ != null)
			{
				return true;
			}
			if (this._serviceLocationEmployeeAssignment___ != null)
			{
				return true;
			}
			if (this._serviceLocationEmployeeAssignment != null)
			{
				return true;
			}
			if (this._serviceLocationEmployeeAssignment_ != null)
			{
				return true;
			}
			if (this._serviceLocationEmployeeAssignment__ != null)
			{
				return true;
			}
			if (this._workOrder != null)
			{
				return true;
			}
			if (this._accountCollectionViaAccountEmployeeAssignment_____ != null)
			{
				return true;
			}
			if (this._accountCollectionViaAccountEmployeeAssignment____ != null)
			{
				return true;
			}
			if (this._accountCollectionViaWorkOrder != null)
			{
				return true;
			}
			if (this._accountCollectionViaAccountEmployeeAssignment______ != null)
			{
				return true;
			}
			if (this._accountCollectionViaAccountEmployeeAssignment_ != null)
			{
				return true;
			}
			if (this._accountCollectionViaAccountEmployeeAssignment != null)
			{
				return true;
			}
			if (this._accountCollectionViaAccountEmployeeAssignment___ != null)
			{
				return true;
			}
			if (this._accountCollectionViaAccountEmployeeAssignment__ != null)
			{
				return true;
			}
			if (this._assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog != null)
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
			if (this._deepFryerServiceCollectionViaDeepFryerServiceChangeLog_ != null)
			{
				return true;
			}
			if (this._recycleServiceCollectionViaRecycleServiceAction != null)
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
			if (this._recycleTypeCollectionViaRecycleServiceAction != null)
			{
				return true;
			}
			if (this._recycleTypeCollectionViaRecycleServiceAction_ != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaServiceLocationEmployeeAssignment_ != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaServiceLocationEmployeeAssignment != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaServiceLocationEmployeeAssignment_____ != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaDeepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaDeepFryerService != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaServiceLocationEmployeeAssignment______ != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaServiceLocationEmployeeAssignment____ != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaServiceLocationEmployeeAssignment__ != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaServiceLocationEmployeeAssignment___ != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaDeepFryerServiceChangeLog_ != null)
			{
				return true;
			}
			if (this._serviceTypeCollectionViaWorkOrder != null)
			{
				return true;
			}
			if (this._statusCollectionViaLoad != null)
			{
				return true;
			}
			if (this._userCollectionViaDeepFryerServiceChangeLog != null)
			{
				return true;
			}
			if (this._userCollectionViaDeepFryerServiceChangeLog_ != null)
			{
				return true;
			}
			if (this._userCollectionViaRecycleServiceAction___ != null)
			{
				return true;
			}
			if (this._userCollectionViaAssetReclamationServiceChangeLog != null)
			{
				return true;
			}
			if (this._userCollectionViaRecycleServiceChangeLog != null)
			{
				return true;
			}
			if (this._userCollectionViaRecycleServiceAction_ != null)
			{
				return true;
			}
			if (this._userCollectionViaRecycleServiceAction__ != null)
			{
				return true;
			}
			if (this._userCollectionViaRecycleServiceAction != null)
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
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AssetReclamationServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<LoadEntity>(EntityFactoryCache2.GetEntityFactory(typeof(LoadEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceChangeLogEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AssetReclamationServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<StatusEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StatusEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
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

			toReturn.Add("AccountEmployeeAssignment____", _accountEmployeeAssignment____);
			toReturn.Add("AccountEmployeeAssignment_____", _accountEmployeeAssignment_____);
			toReturn.Add("AccountEmployeeAssignment______", _accountEmployeeAssignment______);
			toReturn.Add("AccountEmployeeAssignment___", _accountEmployeeAssignment___);
			toReturn.Add("AccountEmployeeAssignment", _accountEmployeeAssignment);
			toReturn.Add("AccountEmployeeAssignment_", _accountEmployeeAssignment_);
			toReturn.Add("AccountEmployeeAssignment__", _accountEmployeeAssignment__);
			toReturn.Add("AssetReclamationServiceChangeLog", _assetReclamationServiceChangeLog);
			toReturn.Add("DeepFryerService", _deepFryerService);
			toReturn.Add("DeepFryerServiceChangeLog_", _deepFryerServiceChangeLog_);
			toReturn.Add("DeepFryerServiceChangeLog", _deepFryerServiceChangeLog);
			toReturn.Add("Load", _load);
			toReturn.Add("RecycleServiceAction_", _recycleServiceAction_);
			toReturn.Add("RecycleServiceAction", _recycleServiceAction);
			toReturn.Add("RecycleServiceChangeLog", _recycleServiceChangeLog);
			toReturn.Add("ServiceLocationEmployeeAssignment____", _serviceLocationEmployeeAssignment____);
			toReturn.Add("ServiceLocationEmployeeAssignment_____", _serviceLocationEmployeeAssignment_____);
			toReturn.Add("ServiceLocationEmployeeAssignment______", _serviceLocationEmployeeAssignment______);
			toReturn.Add("ServiceLocationEmployeeAssignment___", _serviceLocationEmployeeAssignment___);
			toReturn.Add("ServiceLocationEmployeeAssignment", _serviceLocationEmployeeAssignment);
			toReturn.Add("ServiceLocationEmployeeAssignment_", _serviceLocationEmployeeAssignment_);
			toReturn.Add("ServiceLocationEmployeeAssignment__", _serviceLocationEmployeeAssignment__);
			toReturn.Add("WorkOrder", _workOrder);
			toReturn.Add("AccountCollectionViaAccountEmployeeAssignment_____", _accountCollectionViaAccountEmployeeAssignment_____);
			toReturn.Add("AccountCollectionViaAccountEmployeeAssignment____", _accountCollectionViaAccountEmployeeAssignment____);
			toReturn.Add("AccountCollectionViaWorkOrder", _accountCollectionViaWorkOrder);
			toReturn.Add("AccountCollectionViaAccountEmployeeAssignment______", _accountCollectionViaAccountEmployeeAssignment______);
			toReturn.Add("AccountCollectionViaAccountEmployeeAssignment_", _accountCollectionViaAccountEmployeeAssignment_);
			toReturn.Add("AccountCollectionViaAccountEmployeeAssignment", _accountCollectionViaAccountEmployeeAssignment);
			toReturn.Add("AccountCollectionViaAccountEmployeeAssignment___", _accountCollectionViaAccountEmployeeAssignment___);
			toReturn.Add("AccountCollectionViaAccountEmployeeAssignment__", _accountCollectionViaAccountEmployeeAssignment__);
			toReturn.Add("AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", _assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog);
			toReturn.Add("DeepFryerCollectionViaDeepFryerService", _deepFryerCollectionViaDeepFryerService);
			toReturn.Add("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog", _deepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_", _deepFryerServiceCollectionViaDeepFryerServiceChangeLog_);
			toReturn.Add("RecycleServiceCollectionViaRecycleServiceAction", _recycleServiceCollectionViaRecycleServiceAction);
			toReturn.Add("RecycleServiceCollectionViaRecycleServiceChangeLog", _recycleServiceCollectionViaRecycleServiceChangeLog);
			toReturn.Add("RecycleServiceCollectionViaRecycleServiceAction_", _recycleServiceCollectionViaRecycleServiceAction_);
			toReturn.Add("RecycleTypeCollectionViaRecycleServiceAction", _recycleTypeCollectionViaRecycleServiceAction);
			toReturn.Add("RecycleTypeCollectionViaRecycleServiceAction_", _recycleTypeCollectionViaRecycleServiceAction_);
			toReturn.Add("ServiceLocationCollectionViaServiceLocationEmployeeAssignment_", _serviceLocationCollectionViaServiceLocationEmployeeAssignment_);
			toReturn.Add("ServiceLocationCollectionViaServiceLocationEmployeeAssignment", _serviceLocationCollectionViaServiceLocationEmployeeAssignment);
			toReturn.Add("ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____", _serviceLocationCollectionViaServiceLocationEmployeeAssignment_____);
			toReturn.Add("ServiceLocationCollectionViaDeepFryerServiceChangeLog", _serviceLocationCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("ServiceLocationCollectionViaDeepFryerService", _serviceLocationCollectionViaDeepFryerService);
			toReturn.Add("ServiceLocationCollectionViaServiceLocationEmployeeAssignment______", _serviceLocationCollectionViaServiceLocationEmployeeAssignment______);
			toReturn.Add("ServiceLocationCollectionViaServiceLocationEmployeeAssignment____", _serviceLocationCollectionViaServiceLocationEmployeeAssignment____);
			toReturn.Add("ServiceLocationCollectionViaServiceLocationEmployeeAssignment__", _serviceLocationCollectionViaServiceLocationEmployeeAssignment__);
			toReturn.Add("ServiceLocationCollectionViaServiceLocationEmployeeAssignment___", _serviceLocationCollectionViaServiceLocationEmployeeAssignment___);
			toReturn.Add("ServiceLocationCollectionViaDeepFryerServiceChangeLog_", _serviceLocationCollectionViaDeepFryerServiceChangeLog_);
			toReturn.Add("ServiceTypeCollectionViaWorkOrder", _serviceTypeCollectionViaWorkOrder);
			toReturn.Add("StatusCollectionViaLoad", _statusCollectionViaLoad);
			toReturn.Add("UserCollectionViaDeepFryerServiceChangeLog", _userCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("UserCollectionViaDeepFryerServiceChangeLog_", _userCollectionViaDeepFryerServiceChangeLog_);
			toReturn.Add("UserCollectionViaRecycleServiceAction___", _userCollectionViaRecycleServiceAction___);
			toReturn.Add("UserCollectionViaAssetReclamationServiceChangeLog", _userCollectionViaAssetReclamationServiceChangeLog);
			toReturn.Add("UserCollectionViaRecycleServiceChangeLog", _userCollectionViaRecycleServiceChangeLog);
			toReturn.Add("UserCollectionViaRecycleServiceAction_", _userCollectionViaRecycleServiceAction_);
			toReturn.Add("UserCollectionViaRecycleServiceAction__", _userCollectionViaRecycleServiceAction__);
			toReturn.Add("UserCollectionViaRecycleServiceAction", _userCollectionViaRecycleServiceAction);
			toReturn.Add("WorkOrderEmployeeCollectionViaDeepFryerService", _workOrderEmployeeCollectionViaDeepFryerService);
			toReturn.Add("WorkOrderServiceLocationCollectionViaDeepFryerService", _workOrderServiceLocationCollectionViaDeepFryerService);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_accountEmployeeAssignment____!=null)
			{
				_accountEmployeeAssignment____.ActiveContext = base.ActiveContext;
			}
			if(_accountEmployeeAssignment_____!=null)
			{
				_accountEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			}
			if(_accountEmployeeAssignment______!=null)
			{
				_accountEmployeeAssignment______.ActiveContext = base.ActiveContext;
			}
			if(_accountEmployeeAssignment___!=null)
			{
				_accountEmployeeAssignment___.ActiveContext = base.ActiveContext;
			}
			if(_accountEmployeeAssignment!=null)
			{
				_accountEmployeeAssignment.ActiveContext = base.ActiveContext;
			}
			if(_accountEmployeeAssignment_!=null)
			{
				_accountEmployeeAssignment_.ActiveContext = base.ActiveContext;
			}
			if(_accountEmployeeAssignment__!=null)
			{
				_accountEmployeeAssignment__.ActiveContext = base.ActiveContext;
			}
			if(_assetReclamationServiceChangeLog!=null)
			{
				_assetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerService!=null)
			{
				_deepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerServiceChangeLog_!=null)
			{
				_deepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerServiceChangeLog!=null)
			{
				_deepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_load!=null)
			{
				_load.ActiveContext = base.ActiveContext;
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
			if(_serviceLocationEmployeeAssignment____!=null)
			{
				_serviceLocationEmployeeAssignment____.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationEmployeeAssignment_____!=null)
			{
				_serviceLocationEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationEmployeeAssignment______!=null)
			{
				_serviceLocationEmployeeAssignment______.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationEmployeeAssignment___!=null)
			{
				_serviceLocationEmployeeAssignment___.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationEmployeeAssignment!=null)
			{
				_serviceLocationEmployeeAssignment.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationEmployeeAssignment_!=null)
			{
				_serviceLocationEmployeeAssignment_.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationEmployeeAssignment__!=null)
			{
				_serviceLocationEmployeeAssignment__.ActiveContext = base.ActiveContext;
			}
			if(_workOrder!=null)
			{
				_workOrder.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaAccountEmployeeAssignment_____!=null)
			{
				_accountCollectionViaAccountEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaAccountEmployeeAssignment____!=null)
			{
				_accountCollectionViaAccountEmployeeAssignment____.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaWorkOrder!=null)
			{
				_accountCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaAccountEmployeeAssignment______!=null)
			{
				_accountCollectionViaAccountEmployeeAssignment______.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaAccountEmployeeAssignment_!=null)
			{
				_accountCollectionViaAccountEmployeeAssignment_.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaAccountEmployeeAssignment!=null)
			{
				_accountCollectionViaAccountEmployeeAssignment.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaAccountEmployeeAssignment___!=null)
			{
				_accountCollectionViaAccountEmployeeAssignment___.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaAccountEmployeeAssignment__!=null)
			{
				_accountCollectionViaAccountEmployeeAssignment__.ActiveContext = base.ActiveContext;
			}
			if(_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog!=null)
			{
				_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerCollectionViaDeepFryerService!=null)
			{
				_deepFryerCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerServiceCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_!=null)
			{
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceCollectionViaRecycleServiceAction!=null)
			{
				_recycleServiceCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceCollectionViaRecycleServiceChangeLog!=null)
			{
				_recycleServiceCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceCollectionViaRecycleServiceAction_!=null)
			{
				_recycleServiceCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			}
			if(_recycleTypeCollectionViaRecycleServiceAction!=null)
			{
				_recycleTypeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_recycleTypeCollectionViaRecycleServiceAction_!=null)
			{
				_recycleTypeCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment_!=null)
			{
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment!=null)
			{
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____!=null)
			{
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_serviceLocationCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaDeepFryerService!=null)
			{
				_serviceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment______!=null)
			{
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment____!=null)
			{
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment__!=null)
			{
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment___!=null)
			{
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaDeepFryerServiceChangeLog_!=null)
			{
				_serviceLocationCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			}
			if(_serviceTypeCollectionViaWorkOrder!=null)
			{
				_serviceTypeCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			}
			if(_statusCollectionViaLoad!=null)
			{
				_statusCollectionViaLoad.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaDeepFryerServiceChangeLog!=null)
			{
				_userCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaDeepFryerServiceChangeLog_!=null)
			{
				_userCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRecycleServiceAction___!=null)
			{
				_userCollectionViaRecycleServiceAction___.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaAssetReclamationServiceChangeLog!=null)
			{
				_userCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRecycleServiceChangeLog!=null)
			{
				_userCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRecycleServiceAction_!=null)
			{
				_userCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRecycleServiceAction__!=null)
			{
				_userCollectionViaRecycleServiceAction__.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRecycleServiceAction!=null)
			{
				_userCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_workOrderEmployeeCollectionViaDeepFryerService!=null)
			{
				_workOrderEmployeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}
			if(_workOrderServiceLocationCollectionViaDeepFryerService!=null)
			{
				_workOrderServiceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			}


		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_accountEmployeeAssignment____ = null;
			_accountEmployeeAssignment_____ = null;
			_accountEmployeeAssignment______ = null;
			_accountEmployeeAssignment___ = null;
			_accountEmployeeAssignment = null;
			_accountEmployeeAssignment_ = null;
			_accountEmployeeAssignment__ = null;
			_assetReclamationServiceChangeLog = null;
			_deepFryerService = null;
			_deepFryerServiceChangeLog_ = null;
			_deepFryerServiceChangeLog = null;
			_load = null;
			_recycleServiceAction_ = null;
			_recycleServiceAction = null;
			_recycleServiceChangeLog = null;
			_serviceLocationEmployeeAssignment____ = null;
			_serviceLocationEmployeeAssignment_____ = null;
			_serviceLocationEmployeeAssignment______ = null;
			_serviceLocationEmployeeAssignment___ = null;
			_serviceLocationEmployeeAssignment = null;
			_serviceLocationEmployeeAssignment_ = null;
			_serviceLocationEmployeeAssignment__ = null;
			_workOrder = null;
			_accountCollectionViaAccountEmployeeAssignment_____ = null;
			_accountCollectionViaAccountEmployeeAssignment____ = null;
			_accountCollectionViaWorkOrder = null;
			_accountCollectionViaAccountEmployeeAssignment______ = null;
			_accountCollectionViaAccountEmployeeAssignment_ = null;
			_accountCollectionViaAccountEmployeeAssignment = null;
			_accountCollectionViaAccountEmployeeAssignment___ = null;
			_accountCollectionViaAccountEmployeeAssignment__ = null;
			_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = null;
			_deepFryerCollectionViaDeepFryerService = null;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = null;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = null;
			_recycleServiceCollectionViaRecycleServiceAction = null;
			_recycleServiceCollectionViaRecycleServiceChangeLog = null;
			_recycleServiceCollectionViaRecycleServiceAction_ = null;
			_recycleTypeCollectionViaRecycleServiceAction = null;
			_recycleTypeCollectionViaRecycleServiceAction_ = null;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_ = null;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment = null;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____ = null;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog = null;
			_serviceLocationCollectionViaDeepFryerService = null;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment______ = null;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment____ = null;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment__ = null;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment___ = null;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog_ = null;
			_serviceTypeCollectionViaWorkOrder = null;
			_statusCollectionViaLoad = null;
			_userCollectionViaDeepFryerServiceChangeLog = null;
			_userCollectionViaDeepFryerServiceChangeLog_ = null;
			_userCollectionViaRecycleServiceAction___ = null;
			_userCollectionViaAssetReclamationServiceChangeLog = null;
			_userCollectionViaRecycleServiceChangeLog = null;
			_userCollectionViaRecycleServiceAction_ = null;
			_userCollectionViaRecycleServiceAction__ = null;
			_userCollectionViaRecycleServiceAction = null;
			_workOrderEmployeeCollectionViaDeepFryerService = null;
			_workOrderServiceLocationCollectionViaDeepFryerService = null;


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

			_fieldsCustomProperties.Add("EmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MiddleName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Username", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Password", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Ssn", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EmployeeNo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DateOfBirth", fieldHashtable);
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

			_fieldsCustomProperties.Add("Mobile", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EmailAddress", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AssignOilService", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AssignRecycleService", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsEnabled", fieldHashtable);
		}
		#endregion



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
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
		public  static EmployeeRelations Relations
		{
			get	{ return new EmployeeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountEmployeeAssignment____
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment____")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, null, "AccountEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountEmployeeAssignment_____
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment_____")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, null, "AccountEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountEmployeeAssignment______
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment______")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, null, "AccountEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountEmployeeAssignment___
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment___")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, null, "AccountEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountEmployeeAssignment
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, null, "AccountEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountEmployeeAssignment_
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment_")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, null, "AccountEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountEmployeeAssignment__
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment__")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, null, "AccountEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AssetReclamationServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAssetReclamationServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AssetReclamationServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("AssetReclamationServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceChangeLogEntity, 0, null, null, null, null, "AssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("DeepFryerService")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, null, null, "DeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerServiceChangeLog_
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory))),
					(IEntityRelation)GetRelationsForField("DeepFryerServiceChangeLog_")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, 0, null, null, null, null, "DeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("DeepFryerServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, 0, null, null, null, null, "DeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Load' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathLoad
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<LoadEntity>(EntityFactoryCache2.GetEntityFactory(typeof(LoadEntityFactory))),
					(IEntityRelation)GetRelationsForField("Load")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.LoadEntity, 0, null, null, null, null, "Load", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("RecycleServiceAction_")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, null, "RecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("RecycleServiceAction")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, null, "RecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("RecycleServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceChangeLogEntity, 0, null, null, null, null, "RecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationEmployeeAssignment____
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment____")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, null, "ServiceLocationEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationEmployeeAssignment_____
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment_____")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, null, "ServiceLocationEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationEmployeeAssignment______
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment______")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, null, "ServiceLocationEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationEmployeeAssignment___
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment___")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, null, "ServiceLocationEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, null, "ServiceLocationEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationEmployeeAssignment_
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment_")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, null, "ServiceLocationEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationEmployeeAssignment__
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment__")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, null, "ServiceLocationEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrder
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))),
					(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaAccountEmployeeAssignment_____
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingTuesday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment_____"), null, "AccountCollectionViaAccountEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaAccountEmployeeAssignment____
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingThursday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment____"), null, "AccountCollectionViaAccountEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.WorkOrderEntityUsingTechnicianId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaWorkOrder"), null, "AccountCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaAccountEmployeeAssignment______
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingWednesday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment______"), null, "AccountCollectionViaAccountEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaAccountEmployeeAssignment_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingMonday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment_"), null, "AccountCollectionViaAccountEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaAccountEmployeeAssignment
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingFriday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment"), null, "AccountCollectionViaAccountEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaAccountEmployeeAssignment___
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingSunday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment___"), null, "AccountCollectionViaAccountEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaAccountEmployeeAssignment__
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingSaturday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment__"), null, "AccountCollectionViaAccountEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AssetReclamationService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<AssetReclamationServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AssetReclamationServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, 0, null, null, GetRelationsForField("AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog"), null, "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<DeepFryerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, GetRelationsForField("DeepFryerCollectionViaDeepFryerService"), null, "DeepFryerCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerServiceCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, GetRelationsForField("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog"), null, "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingServicedBy;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, GetRelationsForField("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_"), null, "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction"), null, "RecycleServiceCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceChangeLog"), null, "RecycleServiceCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction_"), null, "RecycleServiceCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleTypeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction"), null, "RecycleTypeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleTypeCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction_"), null, "RecycleTypeCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingTuesday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment_"), null, "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingMonday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment"), null, "ServiceLocationCollectionViaServiceLocationEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment_____
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingSaturday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____"), null, "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog"), null, "ServiceLocationCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerService"), null, "ServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment______
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingSunday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment______"), null, "ServiceLocationCollectionViaServiceLocationEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment____
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingFriday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment____"), null, "ServiceLocationCollectionViaServiceLocationEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment__
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingWednesday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment__"), null, "ServiceLocationCollectionViaServiceLocationEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment___
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingThursday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment___"), null, "ServiceLocationCollectionViaServiceLocationEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingServicedBy;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog_"), null, "ServiceLocationCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceTypeCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.WorkOrderEntityUsingTechnicianId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement2(new EntityCollection<ServiceTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, 0, null, null, GetRelationsForField("ServiceTypeCollectionViaWorkOrder"), null, "ServiceTypeCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Status' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStatusCollectionViaLoad
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.LoadEntityUsingEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "Load_");
				return new PrefetchPathElement2(new EntityCollection<StatusEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StatusEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.StatusEntity, 0, null, null, GetRelationsForField("StatusCollectionViaLoad"), null, "StatusCollectionViaLoad", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog"), null, "UserCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingServicedBy;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog_"), null, "UserCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRecycleServiceAction___
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction___"), null, "UserCollectionViaRecycleServiceAction___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaAssetReclamationServiceChangeLog"), null, "UserCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceChangeLog"), null, "UserCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction_"), null, "UserCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRecycleServiceAction__
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction__"), null, "UserCollectionViaRecycleServiceAction__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction"), null, "UserCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<WorkOrderEmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, GetRelationsForField("WorkOrderEmployeeCollectionViaDeepFryerService"), null, "WorkOrderEmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement2(new EntityCollection<WorkOrderServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, GetRelationsForField("WorkOrderServiceLocationCollectionViaDeepFryerService"), null, "WorkOrderServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return EmployeeEntity.CustomProperties;}
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
			get { return EmployeeEntity.FieldsCustomProperties;}
		}

		/// <summary> The EmployeeId property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."EmployeeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 EmployeeId
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.EmployeeId, true); }
			set	{ SetValue((int)EmployeeFieldIndex.EmployeeId, value); }
		}

		/// <summary> The FirstName property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.FirstName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.FirstName, value); }
		}

		/// <summary> The MiddleName property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."MiddleName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MiddleName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.MiddleName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.MiddleName, value); }
		}

		/// <summary> The LastName property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.LastName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.LastName, value); }
		}

		/// <summary> The Username property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Username"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Username
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Username, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Username, value); }
		}

		/// <summary> The Password property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): Binary, 0, 0, 16<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Password
		{
			get { return (System.Byte[])GetValue((int)EmployeeFieldIndex.Password, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Password, value); }
		}

		/// <summary> The Ssn property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."SSN"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 9<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Ssn
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Ssn, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Ssn, value); }
		}

		/// <summary> The EmployeeNo property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."EmployeeNo"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmployeeNo
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.EmployeeNo, true); }
			set	{ SetValue((int)EmployeeFieldIndex.EmployeeNo, value); }
		}

		/// <summary> The DateOfBirth property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."DateOfBirth"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateOfBirth
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeeFieldIndex.DateOfBirth, false); }
			set	{ SetValue((int)EmployeeFieldIndex.DateOfBirth, value); }
		}

		/// <summary> The Address1 property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Address1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address1
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Address1, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Address1, value); }
		}

		/// <summary> The Address2 property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Address2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address2
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Address2, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Address2, value); }
		}

		/// <summary> The City property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.City, true); }
			set	{ SetValue((int)EmployeeFieldIndex.City, value); }
		}

		/// <summary> The State property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."State"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String State
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.State, true); }
			set	{ SetValue((int)EmployeeFieldIndex.State, value); }
		}

		/// <summary> The IntlState property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."IntlState"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String IntlState
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.IntlState, true); }
			set	{ SetValue((int)EmployeeFieldIndex.IntlState, value); }
		}

		/// <summary> The ZipCode property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."ZipCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ZipCode
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.ZipCode, true); }
			set	{ SetValue((int)EmployeeFieldIndex.ZipCode, value); }
		}

		/// <summary> The Phone property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Phone, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Phone, value); }
		}

		/// <summary> The Mobile property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Mobile"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Mobile
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Mobile, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Mobile, value); }
		}

		/// <summary> The EmailAddress property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."EmailAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmailAddress
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.EmailAddress, true); }
			set	{ SetValue((int)EmployeeFieldIndex.EmailAddress, value); }
		}

		/// <summary> The AssignOilService property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."AssignOilService"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> AssignOilService
		{
			get { return (Nullable<System.Boolean>)GetValue((int)EmployeeFieldIndex.AssignOilService, false); }
			set	{ SetValue((int)EmployeeFieldIndex.AssignOilService, value); }
		}

		/// <summary> The AssignRecycleService property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."AssignRecycleService"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> AssignRecycleService
		{
			get { return (Nullable<System.Boolean>)GetValue((int)EmployeeFieldIndex.AssignRecycleService, false); }
			set	{ SetValue((int)EmployeeFieldIndex.AssignRecycleService, value); }
		}

		/// <summary> The IsActive property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.IsActive, true); }
			set	{ SetValue((int)EmployeeFieldIndex.IsActive, value); }
		}

		/// <summary> The IsEnabled property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."IsEnabled"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsEnabled
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.IsEnabled, true); }
			set	{ SetValue((int)EmployeeFieldIndex.IsEnabled, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEmployeeAssignmentEntity))]
		public virtual EntityCollection<AccountEmployeeAssignmentEntity> AccountEmployeeAssignment____
		{
			get
			{
				if(_accountEmployeeAssignment____==null)
				{
					_accountEmployeeAssignment____ = new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory)));
					_accountEmployeeAssignment____.SetContainingEntityInfo(this, "Employee____");
				}
				return _accountEmployeeAssignment____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEmployeeAssignmentEntity))]
		public virtual EntityCollection<AccountEmployeeAssignmentEntity> AccountEmployeeAssignment_____
		{
			get
			{
				if(_accountEmployeeAssignment_____==null)
				{
					_accountEmployeeAssignment_____ = new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory)));
					_accountEmployeeAssignment_____.SetContainingEntityInfo(this, "Employee_____");
				}
				return _accountEmployeeAssignment_____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEmployeeAssignmentEntity))]
		public virtual EntityCollection<AccountEmployeeAssignmentEntity> AccountEmployeeAssignment______
		{
			get
			{
				if(_accountEmployeeAssignment______==null)
				{
					_accountEmployeeAssignment______ = new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory)));
					_accountEmployeeAssignment______.SetContainingEntityInfo(this, "Employee______");
				}
				return _accountEmployeeAssignment______;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEmployeeAssignmentEntity))]
		public virtual EntityCollection<AccountEmployeeAssignmentEntity> AccountEmployeeAssignment___
		{
			get
			{
				if(_accountEmployeeAssignment___==null)
				{
					_accountEmployeeAssignment___ = new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory)));
					_accountEmployeeAssignment___.SetContainingEntityInfo(this, "Employee___");
				}
				return _accountEmployeeAssignment___;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEmployeeAssignmentEntity))]
		public virtual EntityCollection<AccountEmployeeAssignmentEntity> AccountEmployeeAssignment
		{
			get
			{
				if(_accountEmployeeAssignment==null)
				{
					_accountEmployeeAssignment = new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory)));
					_accountEmployeeAssignment.SetContainingEntityInfo(this, "Employee");
				}
				return _accountEmployeeAssignment;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEmployeeAssignmentEntity))]
		public virtual EntityCollection<AccountEmployeeAssignmentEntity> AccountEmployeeAssignment_
		{
			get
			{
				if(_accountEmployeeAssignment_==null)
				{
					_accountEmployeeAssignment_ = new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory)));
					_accountEmployeeAssignment_.SetContainingEntityInfo(this, "Employee_");
				}
				return _accountEmployeeAssignment_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEmployeeAssignmentEntity))]
		public virtual EntityCollection<AccountEmployeeAssignmentEntity> AccountEmployeeAssignment__
		{
			get
			{
				if(_accountEmployeeAssignment__==null)
				{
					_accountEmployeeAssignment__ = new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory)));
					_accountEmployeeAssignment__.SetContainingEntityInfo(this, "Employee__");
				}
				return _accountEmployeeAssignment__;
			}
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
					_assetReclamationServiceChangeLog.SetContainingEntityInfo(this, "Employee");
				}
				return _assetReclamationServiceChangeLog;
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
					_deepFryerService.SetContainingEntityInfo(this, "Employee");
				}
				return _deepFryerService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerServiceChangeLogEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerServiceChangeLogEntity))]
		public virtual EntityCollection<DeepFryerServiceChangeLogEntity> DeepFryerServiceChangeLog_
		{
			get
			{
				if(_deepFryerServiceChangeLog_==null)
				{
					_deepFryerServiceChangeLog_ = new EntityCollection<DeepFryerServiceChangeLogEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceChangeLogEntityFactory)));
					_deepFryerServiceChangeLog_.SetContainingEntityInfo(this, "Employee_");
				}
				return _deepFryerServiceChangeLog_;
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
					_deepFryerServiceChangeLog.SetContainingEntityInfo(this, "Employee");
				}
				return _deepFryerServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'LoadEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(LoadEntity))]
		public virtual EntityCollection<LoadEntity> Load
		{
			get
			{
				if(_load==null)
				{
					_load = new EntityCollection<LoadEntity>(EntityFactoryCache2.GetEntityFactory(typeof(LoadEntityFactory)));
					_load.SetContainingEntityInfo(this, "Employee");
				}
				return _load;
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
					_recycleServiceAction_.SetContainingEntityInfo(this, "Employee");
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
					_recycleServiceAction.SetContainingEntityInfo(this, "Employee_");
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
					_recycleServiceChangeLog.SetContainingEntityInfo(this, "Employee");
				}
				return _recycleServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEmployeeAssignmentEntity))]
		public virtual EntityCollection<ServiceLocationEmployeeAssignmentEntity> ServiceLocationEmployeeAssignment____
		{
			get
			{
				if(_serviceLocationEmployeeAssignment____==null)
				{
					_serviceLocationEmployeeAssignment____ = new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory)));
					_serviceLocationEmployeeAssignment____.SetContainingEntityInfo(this, "Employee____");
				}
				return _serviceLocationEmployeeAssignment____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEmployeeAssignmentEntity))]
		public virtual EntityCollection<ServiceLocationEmployeeAssignmentEntity> ServiceLocationEmployeeAssignment_____
		{
			get
			{
				if(_serviceLocationEmployeeAssignment_____==null)
				{
					_serviceLocationEmployeeAssignment_____ = new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory)));
					_serviceLocationEmployeeAssignment_____.SetContainingEntityInfo(this, "Employee_____");
				}
				return _serviceLocationEmployeeAssignment_____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEmployeeAssignmentEntity))]
		public virtual EntityCollection<ServiceLocationEmployeeAssignmentEntity> ServiceLocationEmployeeAssignment______
		{
			get
			{
				if(_serviceLocationEmployeeAssignment______==null)
				{
					_serviceLocationEmployeeAssignment______ = new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory)));
					_serviceLocationEmployeeAssignment______.SetContainingEntityInfo(this, "Employee______");
				}
				return _serviceLocationEmployeeAssignment______;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEmployeeAssignmentEntity))]
		public virtual EntityCollection<ServiceLocationEmployeeAssignmentEntity> ServiceLocationEmployeeAssignment___
		{
			get
			{
				if(_serviceLocationEmployeeAssignment___==null)
				{
					_serviceLocationEmployeeAssignment___ = new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory)));
					_serviceLocationEmployeeAssignment___.SetContainingEntityInfo(this, "Employee___");
				}
				return _serviceLocationEmployeeAssignment___;
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
					_serviceLocationEmployeeAssignment.SetContainingEntityInfo(this, "Employee");
				}
				return _serviceLocationEmployeeAssignment;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEmployeeAssignmentEntity))]
		public virtual EntityCollection<ServiceLocationEmployeeAssignmentEntity> ServiceLocationEmployeeAssignment_
		{
			get
			{
				if(_serviceLocationEmployeeAssignment_==null)
				{
					_serviceLocationEmployeeAssignment_ = new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory)));
					_serviceLocationEmployeeAssignment_.SetContainingEntityInfo(this, "Employee_");
				}
				return _serviceLocationEmployeeAssignment_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEmployeeAssignmentEntity))]
		public virtual EntityCollection<ServiceLocationEmployeeAssignmentEntity> ServiceLocationEmployeeAssignment__
		{
			get
			{
				if(_serviceLocationEmployeeAssignment__==null)
				{
					_serviceLocationEmployeeAssignment__ = new EntityCollection<ServiceLocationEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEmployeeAssignmentEntityFactory)));
					_serviceLocationEmployeeAssignment__.SetContainingEntityInfo(this, "Employee__");
				}
				return _serviceLocationEmployeeAssignment__;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderEntity))]
		public virtual EntityCollection<WorkOrderEntity> WorkOrder
		{
			get
			{
				if(_workOrder==null)
				{
					_workOrder = new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory)));
					_workOrder.SetContainingEntityInfo(this, "Employee");
				}
				return _workOrder;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaAccountEmployeeAssignment_____
		{
			get
			{
				if(_accountCollectionViaAccountEmployeeAssignment_____==null)
				{
					_accountCollectionViaAccountEmployeeAssignment_____ = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaAccountEmployeeAssignment_____.IsReadOnly=true;
				}
				return _accountCollectionViaAccountEmployeeAssignment_____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaAccountEmployeeAssignment____
		{
			get
			{
				if(_accountCollectionViaAccountEmployeeAssignment____==null)
				{
					_accountCollectionViaAccountEmployeeAssignment____ = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaAccountEmployeeAssignment____.IsReadOnly=true;
				}
				return _accountCollectionViaAccountEmployeeAssignment____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaWorkOrder
		{
			get
			{
				if(_accountCollectionViaWorkOrder==null)
				{
					_accountCollectionViaWorkOrder = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaWorkOrder.IsReadOnly=true;
				}
				return _accountCollectionViaWorkOrder;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaAccountEmployeeAssignment______
		{
			get
			{
				if(_accountCollectionViaAccountEmployeeAssignment______==null)
				{
					_accountCollectionViaAccountEmployeeAssignment______ = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaAccountEmployeeAssignment______.IsReadOnly=true;
				}
				return _accountCollectionViaAccountEmployeeAssignment______;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaAccountEmployeeAssignment_
		{
			get
			{
				if(_accountCollectionViaAccountEmployeeAssignment_==null)
				{
					_accountCollectionViaAccountEmployeeAssignment_ = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaAccountEmployeeAssignment_.IsReadOnly=true;
				}
				return _accountCollectionViaAccountEmployeeAssignment_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaAccountEmployeeAssignment
		{
			get
			{
				if(_accountCollectionViaAccountEmployeeAssignment==null)
				{
					_accountCollectionViaAccountEmployeeAssignment = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaAccountEmployeeAssignment.IsReadOnly=true;
				}
				return _accountCollectionViaAccountEmployeeAssignment;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaAccountEmployeeAssignment___
		{
			get
			{
				if(_accountCollectionViaAccountEmployeeAssignment___==null)
				{
					_accountCollectionViaAccountEmployeeAssignment___ = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaAccountEmployeeAssignment___.IsReadOnly=true;
				}
				return _accountCollectionViaAccountEmployeeAssignment___;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaAccountEmployeeAssignment__
		{
			get
			{
				if(_accountCollectionViaAccountEmployeeAssignment__==null)
				{
					_accountCollectionViaAccountEmployeeAssignment__ = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaAccountEmployeeAssignment__.IsReadOnly=true;
				}
				return _accountCollectionViaAccountEmployeeAssignment__;
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

		/// <summary> Gets the EntityCollection with the related entities of type 'DeepFryerServiceEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DeepFryerServiceEntity))]
		public virtual EntityCollection<DeepFryerServiceEntity> DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				if(_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_==null)
				{
					_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = new EntityCollection<DeepFryerServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DeepFryerServiceEntityFactory)));
					_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.IsReadOnly=true;
				}
				return _deepFryerServiceCollectionViaDeepFryerServiceChangeLog_;
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
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaServiceLocationEmployeeAssignment_
		{
			get
			{
				if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment_==null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment_ = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaServiceLocationEmployeeAssignment_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaServiceLocationEmployeeAssignment
		{
			get
			{
				if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment==null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaServiceLocationEmployeeAssignment;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____
		{
			get
			{
				if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____==null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____ = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaServiceLocationEmployeeAssignment_____;
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

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				if(_serviceLocationCollectionViaDeepFryerService==null)
				{
					_serviceLocationCollectionViaDeepFryerService = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaDeepFryerService.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaDeepFryerService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaServiceLocationEmployeeAssignment______
		{
			get
			{
				if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment______==null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment______ = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaServiceLocationEmployeeAssignment______;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaServiceLocationEmployeeAssignment____
		{
			get
			{
				if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment____==null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment____ = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaServiceLocationEmployeeAssignment____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaServiceLocationEmployeeAssignment__
		{
			get
			{
				if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment__==null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment__ = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaServiceLocationEmployeeAssignment__;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaServiceLocationEmployeeAssignment___
		{
			get
			{
				if(_serviceLocationCollectionViaServiceLocationEmployeeAssignment___==null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment___ = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaServiceLocationEmployeeAssignment___;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				if(_serviceLocationCollectionViaDeepFryerServiceChangeLog_==null)
				{
					_serviceLocationCollectionViaDeepFryerServiceChangeLog_ = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaDeepFryerServiceChangeLog_.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaDeepFryerServiceChangeLog_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceTypeEntity))]
		public virtual EntityCollection<ServiceTypeEntity> ServiceTypeCollectionViaWorkOrder
		{
			get
			{
				if(_serviceTypeCollectionViaWorkOrder==null)
				{
					_serviceTypeCollectionViaWorkOrder = new EntityCollection<ServiceTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory)));
					_serviceTypeCollectionViaWorkOrder.IsReadOnly=true;
				}
				return _serviceTypeCollectionViaWorkOrder;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'StatusEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(StatusEntity))]
		public virtual EntityCollection<StatusEntity> StatusCollectionViaLoad
		{
			get
			{
				if(_statusCollectionViaLoad==null)
				{
					_statusCollectionViaLoad = new EntityCollection<StatusEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StatusEntityFactory)));
					_statusCollectionViaLoad.IsReadOnly=true;
				}
				return _statusCollectionViaLoad;
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

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				if(_userCollectionViaDeepFryerServiceChangeLog_==null)
				{
					_userCollectionViaDeepFryerServiceChangeLog_ = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaDeepFryerServiceChangeLog_.IsReadOnly=true;
				}
				return _userCollectionViaDeepFryerServiceChangeLog_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRecycleServiceAction___
		{
			get
			{
				if(_userCollectionViaRecycleServiceAction___==null)
				{
					_userCollectionViaRecycleServiceAction___ = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRecycleServiceAction___.IsReadOnly=true;
				}
				return _userCollectionViaRecycleServiceAction___;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				if(_userCollectionViaAssetReclamationServiceChangeLog==null)
				{
					_userCollectionViaAssetReclamationServiceChangeLog = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaAssetReclamationServiceChangeLog.IsReadOnly=true;
				}
				return _userCollectionViaAssetReclamationServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRecycleServiceChangeLog
		{
			get
			{
				if(_userCollectionViaRecycleServiceChangeLog==null)
				{
					_userCollectionViaRecycleServiceChangeLog = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRecycleServiceChangeLog.IsReadOnly=true;
				}
				return _userCollectionViaRecycleServiceChangeLog;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRecycleServiceAction_
		{
			get
			{
				if(_userCollectionViaRecycleServiceAction_==null)
				{
					_userCollectionViaRecycleServiceAction_ = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRecycleServiceAction_.IsReadOnly=true;
				}
				return _userCollectionViaRecycleServiceAction_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRecycleServiceAction__
		{
			get
			{
				if(_userCollectionViaRecycleServiceAction__==null)
				{
					_userCollectionViaRecycleServiceAction__ = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRecycleServiceAction__.IsReadOnly=true;
				}
				return _userCollectionViaRecycleServiceAction__;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRecycleServiceAction
		{
			get
			{
				if(_userCollectionViaRecycleServiceAction==null)
				{
					_userCollectionViaRecycleServiceAction = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRecycleServiceAction.IsReadOnly=true;
				}
				return _userCollectionViaRecycleServiceAction;
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity; }
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
