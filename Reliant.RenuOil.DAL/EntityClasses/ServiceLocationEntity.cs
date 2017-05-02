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
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.DaoClasses;
using Reliant.RenuOil.DAL.RelationClasses;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'ServiceLocation'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ServiceLocationEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection	_deepFryer;
		private bool	_alwaysFetchDeepFryer, _alreadyFetchedDeepFryer;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection	_deepFryerService;
		private bool	_alwaysFetchDeepFryerService, _alreadyFetchedDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection	_deepFryerServiceChangeLog;
		private bool	_alwaysFetchDeepFryerServiceChangeLog, _alreadyFetchedDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection	_serviceLocationAssetType;
		private bool	_alwaysFetchServiceLocationAssetType, _alreadyFetchedServiceLocationAssetType;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection	_serviceLocationEmployeeAssignment;
		private bool	_alwaysFetchServiceLocationEmployeeAssignment, _alreadyFetchedServiceLocationEmployeeAssignment;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection	_serviceLocationRecycleType;
		private bool	_alwaysFetchServiceLocationRecycleType, _alreadyFetchedServiceLocationRecycleType;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection	_workOrderEmployee;
		private bool	_alwaysFetchWorkOrderEmployee, _alreadyFetchedWorkOrderEmployee;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection	_workOrderServiceLocation;
		private bool	_alwaysFetchWorkOrderServiceLocation, _alreadyFetchedWorkOrderServiceLocation;
		private Reliant.RenuOil.DAL.CollectionClasses.AssetTypeCollection _assetTypeCollectionViaServiceLocationAssetTypeId;
		private bool	_alwaysFetchAssetTypeCollectionViaServiceLocationAssetTypeId, _alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection _deepFryerCollectionViaDeepFryerService;
		private bool	_alwaysFetchDeepFryerCollectionViaDeepFryerService, _alreadyFetchedDeepFryerCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection _deepFryerServiceCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaServiceLocationEmployeeAssignment__;
		private bool	_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment__, _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaServiceLocationEmployeeAssignment_;
		private bool	_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_, _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaServiceLocationEmployeeAssignment_____;
		private bool	_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_____, _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaServiceLocationEmployeeAssignment____;
		private bool	_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment____, _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaServiceLocationEmployeeAssignment______;
		private bool	_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment______, _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaServiceLocationEmployeeAssignment___;
		private bool	_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment___, _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaServiceLocationEmployeeAssignment;
		private bool	_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment, _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaDeepFryerService;
		private bool	_alwaysFetchEmployeeCollectionViaDeepFryerService, _alreadyFetchedEmployeeCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaDeepFryerServiceChangeLog_;
		private bool	_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_, _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection _recycleTypeCollectionViaServiceLocationRecycleType;
		private bool	_alwaysFetchRecycleTypeCollectionViaServiceLocationRecycleType, _alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection _workOrderCollectionViaWorkOrderEmployee;
		private bool	_alwaysFetchWorkOrderCollectionViaWorkOrderEmployee, _alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection _workOrderCollectionViaWorkOrderServiceLocation;
		private bool	_alwaysFetchWorkOrderCollectionViaWorkOrderServiceLocation, _alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection _workOrderEmployeeCollectionViaDeepFryerService;
		private bool	_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService, _alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection _workOrderServiceLocationCollectionViaDeepFryerService;
		private bool	_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService, _alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService;
		private AccountEntity _account;
		private bool	_alwaysFetchAccount, _alreadyFetchedAccount, _accountReturnsNewIfNotFound;
		private ServiceTypeEntity _serviceType;
		private bool	_alwaysFetchServiceType, _alreadyFetchedServiceType, _serviceTypeReturnsNewIfNotFound;

		
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
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ServiceLocationEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ServiceLocationEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		public ServiceLocationEntity(System.Int32 serviceLocationId)
		{
			InitClassFetch(serviceLocationId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ServiceLocationEntity(System.Int32 serviceLocationId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(serviceLocationId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		/// <param name="validator">The custom validator object for this ServiceLocationEntity</param>
		public ServiceLocationEntity(System.Int32 serviceLocationId, IValidator validator)
		{
			InitClassFetch(serviceLocationId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ServiceLocationEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_deepFryer = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection)info.GetValue("_deepFryer", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection));
			_alwaysFetchDeepFryer = info.GetBoolean("_alwaysFetchDeepFryer");
			_alreadyFetchedDeepFryer = info.GetBoolean("_alreadyFetchedDeepFryer");
			_deepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection)info.GetValue("_deepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection));
			_alwaysFetchDeepFryerService = info.GetBoolean("_alwaysFetchDeepFryerService");
			_alreadyFetchedDeepFryerService = info.GetBoolean("_alreadyFetchedDeepFryerService");
			_deepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection)info.GetValue("_deepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection));
			_alwaysFetchDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchDeepFryerServiceChangeLog");
			_alreadyFetchedDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedDeepFryerServiceChangeLog");
			_serviceLocationAssetType = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection)info.GetValue("_serviceLocationAssetType", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection));
			_alwaysFetchServiceLocationAssetType = info.GetBoolean("_alwaysFetchServiceLocationAssetType");
			_alreadyFetchedServiceLocationAssetType = info.GetBoolean("_alreadyFetchedServiceLocationAssetType");
			_serviceLocationEmployeeAssignment = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection)info.GetValue("_serviceLocationEmployeeAssignment", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection));
			_alwaysFetchServiceLocationEmployeeAssignment = info.GetBoolean("_alwaysFetchServiceLocationEmployeeAssignment");
			_alreadyFetchedServiceLocationEmployeeAssignment = info.GetBoolean("_alreadyFetchedServiceLocationEmployeeAssignment");
			_serviceLocationRecycleType = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection)info.GetValue("_serviceLocationRecycleType", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection));
			_alwaysFetchServiceLocationRecycleType = info.GetBoolean("_alwaysFetchServiceLocationRecycleType");
			_alreadyFetchedServiceLocationRecycleType = info.GetBoolean("_alreadyFetchedServiceLocationRecycleType");
			_workOrderEmployee = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection)info.GetValue("_workOrderEmployee", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection));
			_alwaysFetchWorkOrderEmployee = info.GetBoolean("_alwaysFetchWorkOrderEmployee");
			_alreadyFetchedWorkOrderEmployee = info.GetBoolean("_alreadyFetchedWorkOrderEmployee");
			_workOrderServiceLocation = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection)info.GetValue("_workOrderServiceLocation", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection));
			_alwaysFetchWorkOrderServiceLocation = info.GetBoolean("_alwaysFetchWorkOrderServiceLocation");
			_alreadyFetchedWorkOrderServiceLocation = info.GetBoolean("_alreadyFetchedWorkOrderServiceLocation");
			_assetTypeCollectionViaServiceLocationAssetTypeId = (Reliant.RenuOil.DAL.CollectionClasses.AssetTypeCollection)info.GetValue("_assetTypeCollectionViaServiceLocationAssetTypeId", typeof(Reliant.RenuOil.DAL.CollectionClasses.AssetTypeCollection));
			_alwaysFetchAssetTypeCollectionViaServiceLocationAssetTypeId = info.GetBoolean("_alwaysFetchAssetTypeCollectionViaServiceLocationAssetTypeId");
			_alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId = info.GetBoolean("_alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId");
			_deepFryerCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection)info.GetValue("_deepFryerCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection));
			_alwaysFetchDeepFryerCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchDeepFryerCollectionViaDeepFryerService");
			_alreadyFetchedDeepFryerCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedDeepFryerCollectionViaDeepFryerService");
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection)info.GetValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection));
			_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog");
			_employeeCollectionViaServiceLocationEmployeeAssignment__ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment__", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment__ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment__");
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__");
			_employeeCollectionViaServiceLocationEmployeeAssignment_ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment_", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_");
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_");
			_employeeCollectionViaServiceLocationEmployeeAssignment_____ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment_____", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_____ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_____");
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____");
			_employeeCollectionViaServiceLocationEmployeeAssignment____ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment____", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment____ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment____");
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____");
			_employeeCollectionViaServiceLocationEmployeeAssignment______ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment______", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment______ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment______");
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______");
			_employeeCollectionViaServiceLocationEmployeeAssignment___ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment___", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment___ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment___");
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___");
			_employeeCollectionViaServiceLocationEmployeeAssignment = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaServiceLocationEmployeeAssignment", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment = info.GetBoolean("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment");
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment");
			_employeeCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchEmployeeCollectionViaDeepFryerService");
			_alreadyFetchedEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaDeepFryerService");
			_employeeCollectionViaDeepFryerServiceChangeLog_ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog_", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_");
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_");
			_employeeCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog");
			_recycleTypeCollectionViaServiceLocationRecycleType = (Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection)info.GetValue("_recycleTypeCollectionViaServiceLocationRecycleType", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection));
			_alwaysFetchRecycleTypeCollectionViaServiceLocationRecycleType = info.GetBoolean("_alwaysFetchRecycleTypeCollectionViaServiceLocationRecycleType");
			_alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType = info.GetBoolean("_alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType");
			_userCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog");
			_workOrderCollectionViaWorkOrderEmployee = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection)info.GetValue("_workOrderCollectionViaWorkOrderEmployee", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection));
			_alwaysFetchWorkOrderCollectionViaWorkOrderEmployee = info.GetBoolean("_alwaysFetchWorkOrderCollectionViaWorkOrderEmployee");
			_alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee = info.GetBoolean("_alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee");
			_workOrderCollectionViaWorkOrderServiceLocation = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection)info.GetValue("_workOrderCollectionViaWorkOrderServiceLocation", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection));
			_alwaysFetchWorkOrderCollectionViaWorkOrderServiceLocation = info.GetBoolean("_alwaysFetchWorkOrderCollectionViaWorkOrderServiceLocation");
			_alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation = info.GetBoolean("_alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation");
			_workOrderEmployeeCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection)info.GetValue("_workOrderEmployeeCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection));
			_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService");
			_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService");
			_workOrderServiceLocationCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection)info.GetValue("_workOrderServiceLocationCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection));
			_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService");
			_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService");
			_account = (AccountEntity)info.GetValue("_account", typeof(AccountEntity));
			if(_account!=null)
			{
				_account.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_accountReturnsNewIfNotFound = info.GetBoolean("_accountReturnsNewIfNotFound");
			_alwaysFetchAccount = info.GetBoolean("_alwaysFetchAccount");
			_alreadyFetchedAccount = info.GetBoolean("_alreadyFetchedAccount");
			_serviceType = (ServiceTypeEntity)info.GetValue("_serviceType", typeof(ServiceTypeEntity));
			if(_serviceType!=null)
			{
				_serviceType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_serviceTypeReturnsNewIfNotFound = info.GetBoolean("_serviceTypeReturnsNewIfNotFound");
			_alwaysFetchServiceType = info.GetBoolean("_alwaysFetchServiceType");
			_alreadyFetchedServiceType = info.GetBoolean("_alreadyFetchedServiceType");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
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
					_alreadyFetchedAccount = false;
					break;
				case ServiceLocationFieldIndex.ServiceTypeId:
					DesetupSyncServiceType(true, false);
					_alreadyFetchedServiceType = false;
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
		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedDeepFryer = (_deepFryer.Count > 0);
			_alreadyFetchedDeepFryerService = (_deepFryerService.Count > 0);
			_alreadyFetchedDeepFryerServiceChangeLog = (_deepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedServiceLocationAssetType = (_serviceLocationAssetType.Count > 0);
			_alreadyFetchedServiceLocationEmployeeAssignment = (_serviceLocationEmployeeAssignment.Count > 0);
			_alreadyFetchedServiceLocationRecycleType = (_serviceLocationRecycleType.Count > 0);
			_alreadyFetchedWorkOrderEmployee = (_workOrderEmployee.Count > 0);
			_alreadyFetchedWorkOrderServiceLocation = (_workOrderServiceLocation.Count > 0);
			_alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId = (_assetTypeCollectionViaServiceLocationAssetTypeId.Count > 0);
			_alreadyFetchedDeepFryerCollectionViaDeepFryerService = (_deepFryerCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = (_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__ = (_employeeCollectionViaServiceLocationEmployeeAssignment__.Count > 0);
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_ = (_employeeCollectionViaServiceLocationEmployeeAssignment_.Count > 0);
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____ = (_employeeCollectionViaServiceLocationEmployeeAssignment_____.Count > 0);
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____ = (_employeeCollectionViaServiceLocationEmployeeAssignment____.Count > 0);
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______ = (_employeeCollectionViaServiceLocationEmployeeAssignment______.Count > 0);
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___ = (_employeeCollectionViaServiceLocationEmployeeAssignment___.Count > 0);
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment = (_employeeCollectionViaServiceLocationEmployeeAssignment.Count > 0);
			_alreadyFetchedEmployeeCollectionViaDeepFryerService = (_employeeCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = (_employeeCollectionViaDeepFryerServiceChangeLog_.Count > 0);
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = (_employeeCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType = (_recycleTypeCollectionViaServiceLocationRecycleType.Count > 0);
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = (_userCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee = (_workOrderCollectionViaWorkOrderEmployee.Count > 0);
			_alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation = (_workOrderCollectionViaWorkOrderServiceLocation.Count > 0);
			_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = (_workOrderEmployeeCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = (_workOrderServiceLocationCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedAccount = (_account != null);
			_alreadyFetchedServiceType = (_serviceType != null);

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



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_deepFryer", (!this.MarkedForDeletion?_deepFryer:null));
			info.AddValue("_alwaysFetchDeepFryer", _alwaysFetchDeepFryer);
			info.AddValue("_alreadyFetchedDeepFryer", _alreadyFetchedDeepFryer);
			info.AddValue("_deepFryerService", (!this.MarkedForDeletion?_deepFryerService:null));
			info.AddValue("_alwaysFetchDeepFryerService", _alwaysFetchDeepFryerService);
			info.AddValue("_alreadyFetchedDeepFryerService", _alreadyFetchedDeepFryerService);
			info.AddValue("_deepFryerServiceChangeLog", (!this.MarkedForDeletion?_deepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchDeepFryerServiceChangeLog", _alwaysFetchDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedDeepFryerServiceChangeLog", _alreadyFetchedDeepFryerServiceChangeLog);
			info.AddValue("_serviceLocationAssetType", (!this.MarkedForDeletion?_serviceLocationAssetType:null));
			info.AddValue("_alwaysFetchServiceLocationAssetType", _alwaysFetchServiceLocationAssetType);
			info.AddValue("_alreadyFetchedServiceLocationAssetType", _alreadyFetchedServiceLocationAssetType);
			info.AddValue("_serviceLocationEmployeeAssignment", (!this.MarkedForDeletion?_serviceLocationEmployeeAssignment:null));
			info.AddValue("_alwaysFetchServiceLocationEmployeeAssignment", _alwaysFetchServiceLocationEmployeeAssignment);
			info.AddValue("_alreadyFetchedServiceLocationEmployeeAssignment", _alreadyFetchedServiceLocationEmployeeAssignment);
			info.AddValue("_serviceLocationRecycleType", (!this.MarkedForDeletion?_serviceLocationRecycleType:null));
			info.AddValue("_alwaysFetchServiceLocationRecycleType", _alwaysFetchServiceLocationRecycleType);
			info.AddValue("_alreadyFetchedServiceLocationRecycleType", _alreadyFetchedServiceLocationRecycleType);
			info.AddValue("_workOrderEmployee", (!this.MarkedForDeletion?_workOrderEmployee:null));
			info.AddValue("_alwaysFetchWorkOrderEmployee", _alwaysFetchWorkOrderEmployee);
			info.AddValue("_alreadyFetchedWorkOrderEmployee", _alreadyFetchedWorkOrderEmployee);
			info.AddValue("_workOrderServiceLocation", (!this.MarkedForDeletion?_workOrderServiceLocation:null));
			info.AddValue("_alwaysFetchWorkOrderServiceLocation", _alwaysFetchWorkOrderServiceLocation);
			info.AddValue("_alreadyFetchedWorkOrderServiceLocation", _alreadyFetchedWorkOrderServiceLocation);
			info.AddValue("_assetTypeCollectionViaServiceLocationAssetTypeId", (!this.MarkedForDeletion?_assetTypeCollectionViaServiceLocationAssetTypeId:null));
			info.AddValue("_alwaysFetchAssetTypeCollectionViaServiceLocationAssetTypeId", _alwaysFetchAssetTypeCollectionViaServiceLocationAssetTypeId);
			info.AddValue("_alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId", _alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId);
			info.AddValue("_deepFryerCollectionViaDeepFryerService", (!this.MarkedForDeletion?_deepFryerCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchDeepFryerCollectionViaDeepFryerService", _alwaysFetchDeepFryerCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedDeepFryerCollectionViaDeepFryerService", _alreadyFetchedDeepFryerCollectionViaDeepFryerService);
			info.AddValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_deepFryerServiceCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog", _alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment__", (!this.MarkedForDeletion?_employeeCollectionViaServiceLocationEmployeeAssignment__:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment__", _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment__);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__", _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__);
			info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment_", (!this.MarkedForDeletion?_employeeCollectionViaServiceLocationEmployeeAssignment_:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_", _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_", _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_);
			info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment_____", (!this.MarkedForDeletion?_employeeCollectionViaServiceLocationEmployeeAssignment_____:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_____", _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_____);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____", _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____);
			info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment____", (!this.MarkedForDeletion?_employeeCollectionViaServiceLocationEmployeeAssignment____:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment____", _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment____);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____", _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____);
			info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment______", (!this.MarkedForDeletion?_employeeCollectionViaServiceLocationEmployeeAssignment______:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment______", _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment______);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______", _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______);
			info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment___", (!this.MarkedForDeletion?_employeeCollectionViaServiceLocationEmployeeAssignment___:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment___", _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment___);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___", _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___);
			info.AddValue("_employeeCollectionViaServiceLocationEmployeeAssignment", (!this.MarkedForDeletion?_employeeCollectionViaServiceLocationEmployeeAssignment:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment", _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment", _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment);
			info.AddValue("_employeeCollectionViaDeepFryerService", (!this.MarkedForDeletion?_employeeCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaDeepFryerService", _alwaysFetchEmployeeCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaDeepFryerService", _alreadyFetchedEmployeeCollectionViaDeepFryerService);
			info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog_", (!this.MarkedForDeletion?_employeeCollectionViaDeepFryerServiceChangeLog_:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_", _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_", _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_employeeCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog", _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_recycleTypeCollectionViaServiceLocationRecycleType", (!this.MarkedForDeletion?_recycleTypeCollectionViaServiceLocationRecycleType:null));
			info.AddValue("_alwaysFetchRecycleTypeCollectionViaServiceLocationRecycleType", _alwaysFetchRecycleTypeCollectionViaServiceLocationRecycleType);
			info.AddValue("_alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType", _alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType);
			info.AddValue("_userCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_userCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog", _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_workOrderCollectionViaWorkOrderEmployee", (!this.MarkedForDeletion?_workOrderCollectionViaWorkOrderEmployee:null));
			info.AddValue("_alwaysFetchWorkOrderCollectionViaWorkOrderEmployee", _alwaysFetchWorkOrderCollectionViaWorkOrderEmployee);
			info.AddValue("_alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee", _alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee);
			info.AddValue("_workOrderCollectionViaWorkOrderServiceLocation", (!this.MarkedForDeletion?_workOrderCollectionViaWorkOrderServiceLocation:null));
			info.AddValue("_alwaysFetchWorkOrderCollectionViaWorkOrderServiceLocation", _alwaysFetchWorkOrderCollectionViaWorkOrderServiceLocation);
			info.AddValue("_alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation", _alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation);
			info.AddValue("_workOrderEmployeeCollectionViaDeepFryerService", (!this.MarkedForDeletion?_workOrderEmployeeCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService", _alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService", _alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService);
			info.AddValue("_workOrderServiceLocationCollectionViaDeepFryerService", (!this.MarkedForDeletion?_workOrderServiceLocationCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService", _alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService", _alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService);
			info.AddValue("_account", (!this.MarkedForDeletion?_account:null));
			info.AddValue("_accountReturnsNewIfNotFound", _accountReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAccount", _alwaysFetchAccount);
			info.AddValue("_alreadyFetchedAccount", _alreadyFetchedAccount);
			info.AddValue("_serviceType", (!this.MarkedForDeletion?_serviceType:null));
			info.AddValue("_serviceTypeReturnsNewIfNotFound", _serviceTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchServiceType", _alwaysFetchServiceType);
			info.AddValue("_alreadyFetchedServiceType", _alreadyFetchedServiceType);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "Account":
					_alreadyFetchedAccount = true;
					this.Account = (AccountEntity)entity;
					break;
				case "ServiceType":
					_alreadyFetchedServiceType = true;
					this.ServiceType = (ServiceTypeEntity)entity;
					break;
				case "DeepFryer":
					_alreadyFetchedDeepFryer = true;
					if(entity!=null)
					{
						this.DeepFryer.Add((DeepFryerEntity)entity);
					}
					break;
				case "DeepFryerService":
					_alreadyFetchedDeepFryerService = true;
					if(entity!=null)
					{
						this.DeepFryerService.Add((DeepFryerServiceEntity)entity);
					}
					break;
				case "DeepFryerServiceChangeLog":
					_alreadyFetchedDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)entity);
					}
					break;
				case "ServiceLocationAssetType":
					_alreadyFetchedServiceLocationAssetType = true;
					if(entity!=null)
					{
						this.ServiceLocationAssetType.Add((ServiceLocationAssetTypeEntity)entity);
					}
					break;
				case "ServiceLocationEmployeeAssignment":
					_alreadyFetchedServiceLocationEmployeeAssignment = true;
					if(entity!=null)
					{
						this.ServiceLocationEmployeeAssignment.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					}
					break;
				case "ServiceLocationRecycleType":
					_alreadyFetchedServiceLocationRecycleType = true;
					if(entity!=null)
					{
						this.ServiceLocationRecycleType.Add((ServiceLocationRecycleTypeEntity)entity);
					}
					break;
				case "WorkOrderEmployee":
					_alreadyFetchedWorkOrderEmployee = true;
					if(entity!=null)
					{
						this.WorkOrderEmployee.Add((WorkOrderEmployeeEntity)entity);
					}
					break;
				case "WorkOrderServiceLocation":
					_alreadyFetchedWorkOrderServiceLocation = true;
					if(entity!=null)
					{
						this.WorkOrderServiceLocation.Add((WorkOrderServiceLocationEntity)entity);
					}
					break;
				case "AssetTypeCollectionViaServiceLocationAssetTypeId":
					_alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId = true;
					if(entity!=null)
					{
						this.AssetTypeCollectionViaServiceLocationAssetTypeId.Add((AssetTypeEntity)entity);
					}
					break;
				case "DeepFryerCollectionViaDeepFryerService":
					_alreadyFetchedDeepFryerCollectionViaDeepFryerService = true;
					if(entity!=null)
					{
						this.DeepFryerCollectionViaDeepFryerService.Add((DeepFryerEntity)entity);
					}
					break;
				case "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog.Add((DeepFryerServiceEntity)entity);
					}
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment__":
					_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaServiceLocationEmployeeAssignment__.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment_":
					_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaServiceLocationEmployeeAssignment_.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment_____":
					_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaServiceLocationEmployeeAssignment_____.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment____":
					_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaServiceLocationEmployeeAssignment____.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment______":
					_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaServiceLocationEmployeeAssignment______.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment___":
					_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaServiceLocationEmployeeAssignment___.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaServiceLocationEmployeeAssignment":
					_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaServiceLocationEmployeeAssignment.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaDeepFryerService":
					_alreadyFetchedEmployeeCollectionViaDeepFryerService = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaDeepFryerService.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog_":
					_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaDeepFryerServiceChangeLog_.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaDeepFryerServiceChangeLog.Add((EmployeeEntity)entity);
					}
					break;
				case "RecycleTypeCollectionViaServiceLocationRecycleType":
					_alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType = true;
					if(entity!=null)
					{
						this.RecycleTypeCollectionViaServiceLocationRecycleType.Add((RecycleTypeEntity)entity);
					}
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.UserCollectionViaDeepFryerServiceChangeLog.Add((UserEntity)entity);
					}
					break;
				case "WorkOrderCollectionViaWorkOrderEmployee":
					_alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee = true;
					if(entity!=null)
					{
						this.WorkOrderCollectionViaWorkOrderEmployee.Add((WorkOrderEntity)entity);
					}
					break;
				case "WorkOrderCollectionViaWorkOrderServiceLocation":
					_alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation = true;
					if(entity!=null)
					{
						this.WorkOrderCollectionViaWorkOrderServiceLocation.Add((WorkOrderEntity)entity);
					}
					break;
				case "WorkOrderEmployeeCollectionViaDeepFryerService":
					_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = true;
					if(entity!=null)
					{
						this.WorkOrderEmployeeCollectionViaDeepFryerService.Add((WorkOrderEmployeeEntity)entity);
					}
					break;
				case "WorkOrderServiceLocationCollectionViaDeepFryerService":
					_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = true;
					if(entity!=null)
					{
						this.WorkOrderServiceLocationCollectionViaDeepFryerService.Add((WorkOrderServiceLocationEntity)entity);
					}
					break;

				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
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
					_deepFryer.Add((DeepFryerEntity)relatedEntity);
					break;
				case "DeepFryerService":
					_deepFryerService.Add((DeepFryerServiceEntity)relatedEntity);
					break;
				case "DeepFryerServiceChangeLog":
					_deepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)relatedEntity);
					break;
				case "ServiceLocationAssetType":
					_serviceLocationAssetType.Add((ServiceLocationAssetTypeEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment":
					_serviceLocationEmployeeAssignment.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationRecycleType":
					_serviceLocationRecycleType.Add((ServiceLocationRecycleTypeEntity)relatedEntity);
					break;
				case "WorkOrderEmployee":
					_workOrderEmployee.Add((WorkOrderEmployeeEntity)relatedEntity);
					break;
				case "WorkOrderServiceLocation":
					_workOrderServiceLocation.Add((WorkOrderServiceLocationEntity)relatedEntity);
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
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
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
					base.PerformRelatedEntityRemoval(_deepFryer, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerService":
					base.PerformRelatedEntityRemoval(_deepFryerService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerServiceChangeLog":
					base.PerformRelatedEntityRemoval(_deepFryerServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationAssetType":
					base.PerformRelatedEntityRemoval(_serviceLocationAssetType, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment":
					base.PerformRelatedEntityRemoval(_serviceLocationEmployeeAssignment, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationRecycleType":
					base.PerformRelatedEntityRemoval(_serviceLocationRecycleType, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrderEmployee":
					base.PerformRelatedEntityRemoval(_workOrderEmployee, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrderServiceLocation":
					base.PerformRelatedEntityRemoval(_workOrderServiceLocation, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
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
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_deepFryer);
			toReturn.Add(_deepFryerService);
			toReturn.Add(_deepFryerServiceChangeLog);
			toReturn.Add(_serviceLocationAssetType);
			toReturn.Add(_serviceLocationEmployeeAssignment);
			toReturn.Add(_serviceLocationRecycleType);
			toReturn.Add(_workOrderEmployee);
			toReturn.Add(_workOrderServiceLocation);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationId)
		{
			return FetchUsingPK(serviceLocationId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(serviceLocationId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(serviceLocationId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(serviceLocationId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ServiceLocationId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
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


		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection GetMultiDeepFryer(bool forceFetch)
		{
			return GetMultiDeepFryer(forceFetch, _deepFryer.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection GetMultiDeepFryer(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiDeepFryer(forceFetch, _deepFryer.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection GetMultiDeepFryer(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiDeepFryer(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection GetMultiDeepFryer(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedDeepFryer || forceFetch || _alwaysFetchDeepFryer) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryer.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryer);
					}
				}
				_deepFryer.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryer.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryer.GetMultiManyToOne(this, filter);
				_deepFryer.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryer = true;
			}
			return _deepFryer;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryer'. These settings will be taken into account
		/// when the property DeepFryer is requested or GetMultiDeepFryer is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryer(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryer.SortClauses=sortClauses;
			_deepFryer.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection GetMultiDeepFryerService(bool forceFetch)
		{
			return GetMultiDeepFryerService(forceFetch, _deepFryerService.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection GetMultiDeepFryerService(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiDeepFryerService(forceFetch, _deepFryerService.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection GetMultiDeepFryerService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiDeepFryerService(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection GetMultiDeepFryerService(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedDeepFryerService || forceFetch || _alwaysFetchDeepFryerService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryerService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryerService);
					}
				}
				_deepFryerService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryerService.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryerService.GetMultiManyToOne(null, null, this, null, null, filter);
				_deepFryerService.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryerService = true;
			}
			return _deepFryerService;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryerService'. These settings will be taken into account
		/// when the property DeepFryerService is requested or GetMultiDeepFryerService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryerService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryerService.SortClauses=sortClauses;
			_deepFryerService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerServiceChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog(bool forceFetch)
		{
			return GetMultiDeepFryerServiceChangeLog(forceFetch, _deepFryerServiceChangeLog.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerServiceChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiDeepFryerServiceChangeLog(forceFetch, _deepFryerServiceChangeLog.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiDeepFryerServiceChangeLog(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedDeepFryerServiceChangeLog || forceFetch || _alwaysFetchDeepFryerServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryerServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryerServiceChangeLog);
					}
				}
				_deepFryerServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryerServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryerServiceChangeLog.GetMultiManyToOne(null, null, null, this, null, filter);
				_deepFryerServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryerServiceChangeLog = true;
			}
			return _deepFryerServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryerServiceChangeLog'. These settings will be taken into account
		/// when the property DeepFryerServiceChangeLog is requested or GetMultiDeepFryerServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryerServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryerServiceChangeLog.SortClauses=sortClauses;
			_deepFryerServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationAssetTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetType(bool forceFetch)
		{
			return GetMultiServiceLocationAssetType(forceFetch, _serviceLocationAssetType.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationAssetTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetType(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationAssetType(forceFetch, _serviceLocationAssetType.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetType(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationAssetType(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetType(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationAssetType || forceFetch || _alwaysFetchServiceLocationAssetType) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationAssetType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationAssetType);
					}
				}
				_serviceLocationAssetType.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationAssetType.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationAssetType.GetMultiManyToOne(null, this, filter);
				_serviceLocationAssetType.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationAssetType = true;
			}
			return _serviceLocationAssetType;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationAssetType'. These settings will be taken into account
		/// when the property ServiceLocationAssetType is requested or GetMultiServiceLocationAssetType is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationAssetType(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationAssetType.SortClauses=sortClauses;
			_serviceLocationAssetType.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment(bool forceFetch)
		{
			return GetMultiServiceLocationEmployeeAssignment(forceFetch, _serviceLocationEmployeeAssignment.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationEmployeeAssignment(forceFetch, _serviceLocationEmployeeAssignment.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationEmployeeAssignment(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationEmployeeAssignment || forceFetch || _alwaysFetchServiceLocationEmployeeAssignment) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationEmployeeAssignment.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationEmployeeAssignment);
					}
				}
				_serviceLocationEmployeeAssignment.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationEmployeeAssignment.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationEmployeeAssignment.GetMultiManyToOne(null, null, null, null, null, null, null, this, filter);
				_serviceLocationEmployeeAssignment.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationEmployeeAssignment = true;
			}
			return _serviceLocationEmployeeAssignment;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationEmployeeAssignment'. These settings will be taken into account
		/// when the property ServiceLocationEmployeeAssignment is requested or GetMultiServiceLocationEmployeeAssignment is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationEmployeeAssignment(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationEmployeeAssignment.SortClauses=sortClauses;
			_serviceLocationEmployeeAssignment.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationRecycleTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationRecycleTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection GetMultiServiceLocationRecycleType(bool forceFetch)
		{
			return GetMultiServiceLocationRecycleType(forceFetch, _serviceLocationRecycleType.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationRecycleTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationRecycleTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection GetMultiServiceLocationRecycleType(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationRecycleType(forceFetch, _serviceLocationRecycleType.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationRecycleTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection GetMultiServiceLocationRecycleType(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationRecycleType(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationRecycleTypeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection GetMultiServiceLocationRecycleType(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationRecycleType || forceFetch || _alwaysFetchServiceLocationRecycleType) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationRecycleType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationRecycleType);
					}
				}
				_serviceLocationRecycleType.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationRecycleType.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationRecycleType.GetMultiManyToOne(null, this, filter);
				_serviceLocationRecycleType.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationRecycleType = true;
			}
			return _serviceLocationRecycleType;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationRecycleType'. These settings will be taken into account
		/// when the property ServiceLocationRecycleType is requested or GetMultiServiceLocationRecycleType is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationRecycleType(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationRecycleType.SortClauses=sortClauses;
			_serviceLocationRecycleType.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployee(bool forceFetch)
		{
			return GetMultiWorkOrderEmployee(forceFetch, _workOrderEmployee.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployee(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiWorkOrderEmployee(forceFetch, _workOrderEmployee.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployee(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiWorkOrderEmployee(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployee(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrderEmployee || forceFetch || _alwaysFetchWorkOrderEmployee) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderEmployee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderEmployee);
					}
				}
				_workOrderEmployee.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderEmployee.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderEmployee.GetMultiManyToOne(this, null, filter);
				_workOrderEmployee.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderEmployee = true;
			}
			return _workOrderEmployee;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderEmployee'. These settings will be taken into account
		/// when the property WorkOrderEmployee is requested or GetMultiWorkOrderEmployee is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderEmployee(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderEmployee.SortClauses=sortClauses;
			_workOrderEmployee.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocation(bool forceFetch)
		{
			return GetMultiWorkOrderServiceLocation(forceFetch, _workOrderServiceLocation.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocation(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiWorkOrderServiceLocation(forceFetch, _workOrderServiceLocation.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiWorkOrderServiceLocation(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrderServiceLocation || forceFetch || _alwaysFetchWorkOrderServiceLocation) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderServiceLocation.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderServiceLocation);
					}
				}
				_workOrderServiceLocation.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderServiceLocation.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderServiceLocation.GetMultiManyToOne(this, null, filter);
				_workOrderServiceLocation.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderServiceLocation = true;
			}
			return _workOrderServiceLocation;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderServiceLocation'. These settings will be taken into account
		/// when the property WorkOrderServiceLocation is requested or GetMultiWorkOrderServiceLocation is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderServiceLocation(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderServiceLocation.SortClauses=sortClauses;
			_workOrderServiceLocation.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AssetTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AssetTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AssetTypeCollection GetMultiAssetTypeCollectionViaServiceLocationAssetTypeId(bool forceFetch)
		{
			return GetMultiAssetTypeCollectionViaServiceLocationAssetTypeId(forceFetch, _assetTypeCollectionViaServiceLocationAssetTypeId.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AssetTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AssetTypeCollection GetMultiAssetTypeCollectionViaServiceLocationAssetTypeId(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId || forceFetch || _alwaysFetchAssetTypeCollectionViaServiceLocationAssetTypeId) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_assetTypeCollectionViaServiceLocationAssetTypeId.ParticipatesInTransaction)
					{
						base.Transaction.Add(_assetTypeCollectionViaServiceLocationAssetTypeId);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_assetTypeCollectionViaServiceLocationAssetTypeId.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_assetTypeCollectionViaServiceLocationAssetTypeId.EntityFactoryToUse = entityFactoryToUse;
				}
				_assetTypeCollectionViaServiceLocationAssetTypeId.GetMulti(filter, GetRelationsForField("AssetTypeCollectionViaServiceLocationAssetTypeId"));
				_assetTypeCollectionViaServiceLocationAssetTypeId.SuppressClearInGetMulti=false;
				_alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId = true;
			}
			return _assetTypeCollectionViaServiceLocationAssetTypeId;
		}

		/// <summary> Sets the collection parameters for the collection for 'AssetTypeCollectionViaServiceLocationAssetTypeId'. These settings will be taken into account
		/// when the property AssetTypeCollectionViaServiceLocationAssetTypeId is requested or GetMultiAssetTypeCollectionViaServiceLocationAssetTypeId is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAssetTypeCollectionViaServiceLocationAssetTypeId(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_assetTypeCollectionViaServiceLocationAssetTypeId.SortClauses=sortClauses;
			_assetTypeCollectionViaServiceLocationAssetTypeId.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection GetMultiDeepFryerCollectionViaDeepFryerService(bool forceFetch)
		{
			return GetMultiDeepFryerCollectionViaDeepFryerService(forceFetch, _deepFryerCollectionViaDeepFryerService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection GetMultiDeepFryerCollectionViaDeepFryerService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDeepFryerCollectionViaDeepFryerService || forceFetch || _alwaysFetchDeepFryerCollectionViaDeepFryerService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryerCollectionViaDeepFryerService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryerCollectionViaDeepFryerService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_deepFryerCollectionViaDeepFryerService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryerCollectionViaDeepFryerService.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryerCollectionViaDeepFryerService.GetMulti(filter, GetRelationsForField("DeepFryerCollectionViaDeepFryerService"));
				_deepFryerCollectionViaDeepFryerService.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryerCollectionViaDeepFryerService = true;
			}
			return _deepFryerCollectionViaDeepFryerService;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryerCollectionViaDeepFryerService'. These settings will be taken into account
		/// when the property DeepFryerCollectionViaDeepFryerService is requested or GetMultiDeepFryerCollectionViaDeepFryerService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryerCollectionViaDeepFryerService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryerCollectionViaDeepFryerService.SortClauses=sortClauses;
			_deepFryerCollectionViaDeepFryerService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(bool forceFetch)
		{
			return GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(forceFetch, _deepFryerServiceCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog || forceFetch || _alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryerServiceCollectionViaDeepFryerServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.GetMulti(filter, GetRelationsForField("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog"));
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = true;
			}
			return _deepFryerServiceCollectionViaDeepFryerServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryerServiceCollectionViaDeepFryerServiceChangeLog'. These settings will be taken into account
		/// when the property DeepFryerServiceCollectionViaDeepFryerServiceChangeLog is requested or GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.SortClauses=sortClauses;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment__(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment__(forceFetch, _employeeCollectionViaServiceLocationEmployeeAssignment__.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__ || forceFetch || _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment__) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaServiceLocationEmployeeAssignment__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaServiceLocationEmployeeAssignment__);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_employeeCollectionViaServiceLocationEmployeeAssignment__.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment__.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaServiceLocationEmployeeAssignment__.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment__"));
				_employeeCollectionViaServiceLocationEmployeeAssignment__.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__ = true;
			}
			return _employeeCollectionViaServiceLocationEmployeeAssignment__;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaServiceLocationEmployeeAssignment__'. These settings will be taken into account
		/// when the property EmployeeCollectionViaServiceLocationEmployeeAssignment__ is requested or GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment__ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaServiceLocationEmployeeAssignment__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaServiceLocationEmployeeAssignment__.SortClauses=sortClauses;
			_employeeCollectionViaServiceLocationEmployeeAssignment__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_(forceFetch, _employeeCollectionViaServiceLocationEmployeeAssignment_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_ || forceFetch || _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaServiceLocationEmployeeAssignment_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaServiceLocationEmployeeAssignment_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_employeeCollectionViaServiceLocationEmployeeAssignment_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment_.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaServiceLocationEmployeeAssignment_.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment_"));
				_employeeCollectionViaServiceLocationEmployeeAssignment_.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_ = true;
			}
			return _employeeCollectionViaServiceLocationEmployeeAssignment_;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaServiceLocationEmployeeAssignment_'. These settings will be taken into account
		/// when the property EmployeeCollectionViaServiceLocationEmployeeAssignment_ is requested or GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaServiceLocationEmployeeAssignment_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaServiceLocationEmployeeAssignment_.SortClauses=sortClauses;
			_employeeCollectionViaServiceLocationEmployeeAssignment_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_____(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_____(forceFetch, _employeeCollectionViaServiceLocationEmployeeAssignment_____.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____ || forceFetch || _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaServiceLocationEmployeeAssignment_____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaServiceLocationEmployeeAssignment_____);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_employeeCollectionViaServiceLocationEmployeeAssignment_____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment_____.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaServiceLocationEmployeeAssignment_____.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment_____"));
				_employeeCollectionViaServiceLocationEmployeeAssignment_____.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____ = true;
			}
			return _employeeCollectionViaServiceLocationEmployeeAssignment_____;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaServiceLocationEmployeeAssignment_____'. These settings will be taken into account
		/// when the property EmployeeCollectionViaServiceLocationEmployeeAssignment_____ is requested or GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaServiceLocationEmployeeAssignment_____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaServiceLocationEmployeeAssignment_____.SortClauses=sortClauses;
			_employeeCollectionViaServiceLocationEmployeeAssignment_____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment____(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment____(forceFetch, _employeeCollectionViaServiceLocationEmployeeAssignment____.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____ || forceFetch || _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaServiceLocationEmployeeAssignment____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaServiceLocationEmployeeAssignment____);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_employeeCollectionViaServiceLocationEmployeeAssignment____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment____.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaServiceLocationEmployeeAssignment____.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment____"));
				_employeeCollectionViaServiceLocationEmployeeAssignment____.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____ = true;
			}
			return _employeeCollectionViaServiceLocationEmployeeAssignment____;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaServiceLocationEmployeeAssignment____'. These settings will be taken into account
		/// when the property EmployeeCollectionViaServiceLocationEmployeeAssignment____ is requested or GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaServiceLocationEmployeeAssignment____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaServiceLocationEmployeeAssignment____.SortClauses=sortClauses;
			_employeeCollectionViaServiceLocationEmployeeAssignment____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment______(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment______(forceFetch, _employeeCollectionViaServiceLocationEmployeeAssignment______.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment______(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______ || forceFetch || _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment______) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaServiceLocationEmployeeAssignment______.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaServiceLocationEmployeeAssignment______);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_employeeCollectionViaServiceLocationEmployeeAssignment______.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment______.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaServiceLocationEmployeeAssignment______.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment______"));
				_employeeCollectionViaServiceLocationEmployeeAssignment______.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______ = true;
			}
			return _employeeCollectionViaServiceLocationEmployeeAssignment______;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaServiceLocationEmployeeAssignment______'. These settings will be taken into account
		/// when the property EmployeeCollectionViaServiceLocationEmployeeAssignment______ is requested or GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment______ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaServiceLocationEmployeeAssignment______(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaServiceLocationEmployeeAssignment______.SortClauses=sortClauses;
			_employeeCollectionViaServiceLocationEmployeeAssignment______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment___(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment___(forceFetch, _employeeCollectionViaServiceLocationEmployeeAssignment___.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___ || forceFetch || _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment___) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaServiceLocationEmployeeAssignment___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaServiceLocationEmployeeAssignment___);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_employeeCollectionViaServiceLocationEmployeeAssignment___.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment___.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaServiceLocationEmployeeAssignment___.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment___"));
				_employeeCollectionViaServiceLocationEmployeeAssignment___.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___ = true;
			}
			return _employeeCollectionViaServiceLocationEmployeeAssignment___;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaServiceLocationEmployeeAssignment___'. These settings will be taken into account
		/// when the property EmployeeCollectionViaServiceLocationEmployeeAssignment___ is requested or GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment___ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaServiceLocationEmployeeAssignment___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaServiceLocationEmployeeAssignment___.SortClauses=sortClauses;
			_employeeCollectionViaServiceLocationEmployeeAssignment___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment(forceFetch, _employeeCollectionViaServiceLocationEmployeeAssignment.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment || forceFetch || _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaServiceLocationEmployeeAssignment.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaServiceLocationEmployeeAssignment);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_employeeCollectionViaServiceLocationEmployeeAssignment.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaServiceLocationEmployeeAssignment.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment"));
				_employeeCollectionViaServiceLocationEmployeeAssignment.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment = true;
			}
			return _employeeCollectionViaServiceLocationEmployeeAssignment;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaServiceLocationEmployeeAssignment'. These settings will be taken into account
		/// when the property EmployeeCollectionViaServiceLocationEmployeeAssignment is requested or GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaServiceLocationEmployeeAssignment(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaServiceLocationEmployeeAssignment.SortClauses=sortClauses;
			_employeeCollectionViaServiceLocationEmployeeAssignment.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaDeepFryerService(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaDeepFryerService(forceFetch, _employeeCollectionViaDeepFryerService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaDeepFryerService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaDeepFryerService || forceFetch || _alwaysFetchEmployeeCollectionViaDeepFryerService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaDeepFryerService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaDeepFryerService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_employeeCollectionViaDeepFryerService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaDeepFryerService.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaDeepFryerService.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaDeepFryerService"));
				_employeeCollectionViaDeepFryerService.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaDeepFryerService = true;
			}
			return _employeeCollectionViaDeepFryerService;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaDeepFryerService'. These settings will be taken into account
		/// when the property EmployeeCollectionViaDeepFryerService is requested or GetMultiEmployeeCollectionViaDeepFryerService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaDeepFryerService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaDeepFryerService.SortClauses=sortClauses;
			_employeeCollectionViaDeepFryerService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_(forceFetch, _employeeCollectionViaDeepFryerServiceChangeLog_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ || forceFetch || _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaDeepFryerServiceChangeLog_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaDeepFryerServiceChangeLog_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_employeeCollectionViaDeepFryerServiceChangeLog_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaDeepFryerServiceChangeLog_.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaDeepFryerServiceChangeLog_.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog_"));
				_employeeCollectionViaDeepFryerServiceChangeLog_.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = true;
			}
			return _employeeCollectionViaDeepFryerServiceChangeLog_;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaDeepFryerServiceChangeLog_'. These settings will be taken into account
		/// when the property EmployeeCollectionViaDeepFryerServiceChangeLog_ is requested or GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaDeepFryerServiceChangeLog_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaDeepFryerServiceChangeLog_.SortClauses=sortClauses;
			_employeeCollectionViaDeepFryerServiceChangeLog_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog(forceFetch, _employeeCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog || forceFetch || _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaDeepFryerServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaDeepFryerServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_employeeCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaDeepFryerServiceChangeLog.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog"));
				_employeeCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = true;
			}
			return _employeeCollectionViaDeepFryerServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaDeepFryerServiceChangeLog'. These settings will be taken into account
		/// when the property EmployeeCollectionViaDeepFryerServiceChangeLog is requested or GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaDeepFryerServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaDeepFryerServiceChangeLog.SortClauses=sortClauses;
			_employeeCollectionViaDeepFryerServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaServiceLocationRecycleType(bool forceFetch)
		{
			return GetMultiRecycleTypeCollectionViaServiceLocationRecycleType(forceFetch, _recycleTypeCollectionViaServiceLocationRecycleType.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaServiceLocationRecycleType(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType || forceFetch || _alwaysFetchRecycleTypeCollectionViaServiceLocationRecycleType) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleTypeCollectionViaServiceLocationRecycleType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleTypeCollectionViaServiceLocationRecycleType);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_recycleTypeCollectionViaServiceLocationRecycleType.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleTypeCollectionViaServiceLocationRecycleType.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleTypeCollectionViaServiceLocationRecycleType.GetMulti(filter, GetRelationsForField("RecycleTypeCollectionViaServiceLocationRecycleType"));
				_recycleTypeCollectionViaServiceLocationRecycleType.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType = true;
			}
			return _recycleTypeCollectionViaServiceLocationRecycleType;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleTypeCollectionViaServiceLocationRecycleType'. These settings will be taken into account
		/// when the property RecycleTypeCollectionViaServiceLocationRecycleType is requested or GetMultiRecycleTypeCollectionViaServiceLocationRecycleType is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleTypeCollectionViaServiceLocationRecycleType(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleTypeCollectionViaServiceLocationRecycleType.SortClauses=sortClauses;
			_recycleTypeCollectionViaServiceLocationRecycleType.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaDeepFryerServiceChangeLog(bool forceFetch)
		{
			return GetMultiUserCollectionViaDeepFryerServiceChangeLog(forceFetch, _userCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog || forceFetch || _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaDeepFryerServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaDeepFryerServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_userCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaDeepFryerServiceChangeLog.GetMulti(filter, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog"));
				_userCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = true;
			}
			return _userCollectionViaDeepFryerServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaDeepFryerServiceChangeLog'. These settings will be taken into account
		/// when the property UserCollectionViaDeepFryerServiceChangeLog is requested or GetMultiUserCollectionViaDeepFryerServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaDeepFryerServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaDeepFryerServiceChangeLog.SortClauses=sortClauses;
			_userCollectionViaDeepFryerServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrderCollectionViaWorkOrderEmployee(bool forceFetch)
		{
			return GetMultiWorkOrderCollectionViaWorkOrderEmployee(forceFetch, _workOrderCollectionViaWorkOrderEmployee.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrderCollectionViaWorkOrderEmployee(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee || forceFetch || _alwaysFetchWorkOrderCollectionViaWorkOrderEmployee) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderCollectionViaWorkOrderEmployee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderCollectionViaWorkOrderEmployee);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_workOrderCollectionViaWorkOrderEmployee.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderCollectionViaWorkOrderEmployee.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderCollectionViaWorkOrderEmployee.GetMulti(filter, GetRelationsForField("WorkOrderCollectionViaWorkOrderEmployee"));
				_workOrderCollectionViaWorkOrderEmployee.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee = true;
			}
			return _workOrderCollectionViaWorkOrderEmployee;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderCollectionViaWorkOrderEmployee'. These settings will be taken into account
		/// when the property WorkOrderCollectionViaWorkOrderEmployee is requested or GetMultiWorkOrderCollectionViaWorkOrderEmployee is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderCollectionViaWorkOrderEmployee(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderCollectionViaWorkOrderEmployee.SortClauses=sortClauses;
			_workOrderCollectionViaWorkOrderEmployee.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrderCollectionViaWorkOrderServiceLocation(bool forceFetch)
		{
			return GetMultiWorkOrderCollectionViaWorkOrderServiceLocation(forceFetch, _workOrderCollectionViaWorkOrderServiceLocation.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrderCollectionViaWorkOrderServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation || forceFetch || _alwaysFetchWorkOrderCollectionViaWorkOrderServiceLocation) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderCollectionViaWorkOrderServiceLocation.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderCollectionViaWorkOrderServiceLocation);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_workOrderCollectionViaWorkOrderServiceLocation.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderCollectionViaWorkOrderServiceLocation.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderCollectionViaWorkOrderServiceLocation.GetMulti(filter, GetRelationsForField("WorkOrderCollectionViaWorkOrderServiceLocation"));
				_workOrderCollectionViaWorkOrderServiceLocation.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation = true;
			}
			return _workOrderCollectionViaWorkOrderServiceLocation;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderCollectionViaWorkOrderServiceLocation'. These settings will be taken into account
		/// when the property WorkOrderCollectionViaWorkOrderServiceLocation is requested or GetMultiWorkOrderCollectionViaWorkOrderServiceLocation is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderCollectionViaWorkOrderServiceLocation(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderCollectionViaWorkOrderServiceLocation.SortClauses=sortClauses;
			_workOrderCollectionViaWorkOrderServiceLocation.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployeeCollectionViaDeepFryerService(bool forceFetch)
		{
			return GetMultiWorkOrderEmployeeCollectionViaDeepFryerService(forceFetch, _workOrderEmployeeCollectionViaDeepFryerService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployeeCollectionViaDeepFryerService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService || forceFetch || _alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderEmployeeCollectionViaDeepFryerService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderEmployeeCollectionViaDeepFryerService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_workOrderEmployeeCollectionViaDeepFryerService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderEmployeeCollectionViaDeepFryerService.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderEmployeeCollectionViaDeepFryerService.GetMulti(filter, GetRelationsForField("WorkOrderEmployeeCollectionViaDeepFryerService"));
				_workOrderEmployeeCollectionViaDeepFryerService.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = true;
			}
			return _workOrderEmployeeCollectionViaDeepFryerService;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderEmployeeCollectionViaDeepFryerService'. These settings will be taken into account
		/// when the property WorkOrderEmployeeCollectionViaDeepFryerService is requested or GetMultiWorkOrderEmployeeCollectionViaDeepFryerService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderEmployeeCollectionViaDeepFryerService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderEmployeeCollectionViaDeepFryerService.SortClauses=sortClauses;
			_workOrderEmployeeCollectionViaDeepFryerService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocationCollectionViaDeepFryerService(bool forceFetch)
		{
			return GetMultiWorkOrderServiceLocationCollectionViaDeepFryerService(forceFetch, _workOrderServiceLocationCollectionViaDeepFryerService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocationCollectionViaDeepFryerService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService || forceFetch || _alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderServiceLocationCollectionViaDeepFryerService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderServiceLocationCollectionViaDeepFryerService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationFields.ServiceLocationId, ComparisonOperator.Equal, this.ServiceLocationId, "ServiceLocationEntity__"));
				_workOrderServiceLocationCollectionViaDeepFryerService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderServiceLocationCollectionViaDeepFryerService.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderServiceLocationCollectionViaDeepFryerService.GetMulti(filter, GetRelationsForField("WorkOrderServiceLocationCollectionViaDeepFryerService"));
				_workOrderServiceLocationCollectionViaDeepFryerService.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = true;
			}
			return _workOrderServiceLocationCollectionViaDeepFryerService;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderServiceLocationCollectionViaDeepFryerService'. These settings will be taken into account
		/// when the property WorkOrderServiceLocationCollectionViaDeepFryerService is requested or GetMultiWorkOrderServiceLocationCollectionViaDeepFryerService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderServiceLocationCollectionViaDeepFryerService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderServiceLocationCollectionViaDeepFryerService.SortClauses=sortClauses;
			_workOrderServiceLocationCollectionViaDeepFryerService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'AccountEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AccountEntity' which is related to this entity.</returns>
		public AccountEntity GetSingleAccount()
		{
			return GetSingleAccount(false);
		}

		/// <summary> Retrieves the related entity of type 'AccountEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AccountEntity' which is related to this entity.</returns>
		public virtual AccountEntity GetSingleAccount(bool forceFetch)
		{
			if( ( !_alreadyFetchedAccount || forceFetch || _alwaysFetchAccount) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ServiceLocationEntity.Relations.AccountEntityUsingAccountId);

				AccountEntity newEntity = new AccountEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.AccountId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (AccountEntity)base.ActiveContext.Get(newEntity);
					}
					this.Account = newEntity;
				}
				else
				{
					if(_accountReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_account == null)))
						{
							this.Account = newEntity;
						}
					}
					else
					{
						this.Account = null;
					}
				}
				_alreadyFetchedAccount = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _account;
		}

		/// <summary> Retrieves the related entity of type 'ServiceTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ServiceTypeEntity' which is related to this entity.</returns>
		public ServiceTypeEntity GetSingleServiceType()
		{
			return GetSingleServiceType(false);
		}

		/// <summary> Retrieves the related entity of type 'ServiceTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ServiceTypeEntity' which is related to this entity.</returns>
		public virtual ServiceTypeEntity GetSingleServiceType(bool forceFetch)
		{
			if( ( !_alreadyFetchedServiceType || forceFetch || _alwaysFetchServiceType) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ServiceLocationEntity.Relations.ServiceTypeEntityUsingServiceTypeId);

				ServiceTypeEntity newEntity = new ServiceTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ServiceTypeId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ServiceTypeEntity)base.ActiveContext.Get(newEntity);
					}
					this.ServiceType = newEntity;
				}
				else
				{
					if(_serviceTypeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_serviceType == null)))
						{
							this.ServiceType = newEntity;
						}
					}
					else
					{
						this.ServiceType = null;
					}
				}
				_alreadyFetchedServiceType = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _serviceType;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ServiceLocationDAO dao = (ServiceLocationDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_deepFryer.ActiveContext = base.ActiveContext;
			_deepFryerService.ActiveContext = base.ActiveContext;
			_deepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_serviceLocationAssetType.ActiveContext = base.ActiveContext;
			_serviceLocationEmployeeAssignment.ActiveContext = base.ActiveContext;
			_serviceLocationRecycleType.ActiveContext = base.ActiveContext;
			_workOrderEmployee.ActiveContext = base.ActiveContext;
			_workOrderServiceLocation.ActiveContext = base.ActiveContext;
			_assetTypeCollectionViaServiceLocationAssetTypeId.ActiveContext = base.ActiveContext;
			_deepFryerCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_employeeCollectionViaServiceLocationEmployeeAssignment__.ActiveContext = base.ActiveContext;
			_employeeCollectionViaServiceLocationEmployeeAssignment_.ActiveContext = base.ActiveContext;
			_employeeCollectionViaServiceLocationEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			_employeeCollectionViaServiceLocationEmployeeAssignment____.ActiveContext = base.ActiveContext;
			_employeeCollectionViaServiceLocationEmployeeAssignment______.ActiveContext = base.ActiveContext;
			_employeeCollectionViaServiceLocationEmployeeAssignment___.ActiveContext = base.ActiveContext;
			_employeeCollectionViaServiceLocationEmployeeAssignment.ActiveContext = base.ActiveContext;
			_employeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_employeeCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			_employeeCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_recycleTypeCollectionViaServiceLocationRecycleType.ActiveContext = base.ActiveContext;
			_userCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_workOrderCollectionViaWorkOrderEmployee.ActiveContext = base.ActiveContext;
			_workOrderCollectionViaWorkOrderServiceLocation.ActiveContext = base.ActiveContext;
			_workOrderEmployeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_workOrderServiceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			if(_account!=null)
			{
				_account.ActiveContext = base.ActiveContext;
			}
			if(_serviceType!=null)
			{
				_serviceType.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ServiceLocationDAO dao = (ServiceLocationDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ServiceLocationDAO dao = (ServiceLocationDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity);
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

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
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		/// <param name="validator">The validator object for this ServiceLocationEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 serviceLocationId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(serviceLocationId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_deepFryer = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(new DeepFryerEntityFactory());
			_deepFryer.SetContainingEntityInfo(this, "ServiceLocation");
			_alwaysFetchDeepFryer = false;
			_alreadyFetchedDeepFryer = false;
			_deepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(new DeepFryerServiceEntityFactory());
			_deepFryerService.SetContainingEntityInfo(this, "ServiceLocation");
			_alwaysFetchDeepFryerService = false;
			_alreadyFetchedDeepFryerService = false;
			_deepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection(new DeepFryerServiceChangeLogEntityFactory());
			_deepFryerServiceChangeLog.SetContainingEntityInfo(this, "ServiceLocation");
			_alwaysFetchDeepFryerServiceChangeLog = false;
			_alreadyFetchedDeepFryerServiceChangeLog = false;
			_serviceLocationAssetType = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection(new ServiceLocationAssetTypeEntityFactory());
			_serviceLocationAssetType.SetContainingEntityInfo(this, "ServiceLocation");
			_alwaysFetchServiceLocationAssetType = false;
			_alreadyFetchedServiceLocationAssetType = false;
			_serviceLocationEmployeeAssignment = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(new ServiceLocationEmployeeAssignmentEntityFactory());
			_serviceLocationEmployeeAssignment.SetContainingEntityInfo(this, "ServiceLocation");
			_alwaysFetchServiceLocationEmployeeAssignment = false;
			_alreadyFetchedServiceLocationEmployeeAssignment = false;
			_serviceLocationRecycleType = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection(new ServiceLocationRecycleTypeEntityFactory());
			_serviceLocationRecycleType.SetContainingEntityInfo(this, "ServiceLocation");
			_alwaysFetchServiceLocationRecycleType = false;
			_alreadyFetchedServiceLocationRecycleType = false;
			_workOrderEmployee = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(new WorkOrderEmployeeEntityFactory());
			_workOrderEmployee.SetContainingEntityInfo(this, "ServiceLocation");
			_alwaysFetchWorkOrderEmployee = false;
			_alreadyFetchedWorkOrderEmployee = false;
			_workOrderServiceLocation = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(new WorkOrderServiceLocationEntityFactory());
			_workOrderServiceLocation.SetContainingEntityInfo(this, "ServiceLocation");
			_alwaysFetchWorkOrderServiceLocation = false;
			_alreadyFetchedWorkOrderServiceLocation = false;
			_assetTypeCollectionViaServiceLocationAssetTypeId = new Reliant.RenuOil.DAL.CollectionClasses.AssetTypeCollection(new AssetTypeEntityFactory());
			_alwaysFetchAssetTypeCollectionViaServiceLocationAssetTypeId = false;
			_alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId = false;
			_deepFryerCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(new DeepFryerEntityFactory());
			_alwaysFetchDeepFryerCollectionViaDeepFryerService = false;
			_alreadyFetchedDeepFryerCollectionViaDeepFryerService = false;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(new DeepFryerServiceEntityFactory());
			_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = false;
			_employeeCollectionViaServiceLocationEmployeeAssignment__ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment__ = false;
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__ = false;
			_employeeCollectionViaServiceLocationEmployeeAssignment_ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_ = false;
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_ = false;
			_employeeCollectionViaServiceLocationEmployeeAssignment_____ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_____ = false;
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____ = false;
			_employeeCollectionViaServiceLocationEmployeeAssignment____ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment____ = false;
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____ = false;
			_employeeCollectionViaServiceLocationEmployeeAssignment______ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment______ = false;
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______ = false;
			_employeeCollectionViaServiceLocationEmployeeAssignment___ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment___ = false;
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___ = false;
			_employeeCollectionViaServiceLocationEmployeeAssignment = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment = false;
			_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment = false;
			_employeeCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaDeepFryerService = false;
			_alreadyFetchedEmployeeCollectionViaDeepFryerService = false;
			_employeeCollectionViaDeepFryerServiceChangeLog_ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_ = false;
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = false;
			_employeeCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = false;
			_recycleTypeCollectionViaServiceLocationRecycleType = new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(new RecycleTypeEntityFactory());
			_alwaysFetchRecycleTypeCollectionViaServiceLocationRecycleType = false;
			_alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType = false;
			_userCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = false;
			_workOrderCollectionViaWorkOrderEmployee = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection(new WorkOrderEntityFactory());
			_alwaysFetchWorkOrderCollectionViaWorkOrderEmployee = false;
			_alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee = false;
			_workOrderCollectionViaWorkOrderServiceLocation = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection(new WorkOrderEntityFactory());
			_alwaysFetchWorkOrderCollectionViaWorkOrderServiceLocation = false;
			_alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation = false;
			_workOrderEmployeeCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(new WorkOrderEmployeeEntityFactory());
			_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService = false;
			_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = false;
			_workOrderServiceLocationCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(new WorkOrderServiceLocationEntityFactory());
			_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService = false;
			_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = false;
			_account = null;
			_accountReturnsNewIfNotFound = true;
			_alwaysFetchAccount = false;
			_alreadyFetchedAccount = false;
			_serviceType = null;
			_serviceTypeReturnsNewIfNotFound = true;
			_alwaysFetchServiceType = false;
			_alreadyFetchedServiceType = false;


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
		private void SetupSyncAccount(IEntity relatedEntity)
		{
			if(_account!=relatedEntity)
			{		
				DesetupSyncAccount(true, true);
				_account = (AccountEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", ServiceLocationEntity.Relations.AccountEntityUsingAccountId, true, ref _alreadyFetchedAccount, new string[] {  } );
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
		private void SetupSyncServiceType(IEntity relatedEntity)
		{
			if(_serviceType!=relatedEntity)
			{		
				DesetupSyncServiceType(true, true);
				_serviceType = (ServiceTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceType, new PropertyChangedEventHandler( OnServiceTypePropertyChanged ), "ServiceType", ServiceLocationEntity.Relations.ServiceTypeEntityUsingServiceTypeId, true, ref _alreadyFetchedServiceType, new string[] {  } );
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


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="serviceLocationId">PK value for ServiceLocation which data should be fetched into this ServiceLocation object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 serviceLocationId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ServiceLocationFieldIndex.ServiceLocationId].ForcedCurrentValueWrite(serviceLocationId);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (base.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateServiceLocationDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ServiceLocationEntityFactory();
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


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryer
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(),
					(IEntityRelation)GetRelationsForField("DeepFryer")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, null, "DeepFryer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerService
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(),
					(IEntityRelation)GetRelationsForField("DeepFryerService")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, null, "DeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("DeepFryerServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, 0, null, null, null, "DeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationAssetType
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetType")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, null, "ServiceLocationAssetType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationEmployeeAssignment
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, "ServiceLocationEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationRecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationRecycleType
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationRecycleType")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationRecycleTypeEntity, 0, null, null, null, "ServiceLocationRecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderEmployee
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrderEmployee")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, null, "WorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderServiceLocation
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrderServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, null, "WorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAssetTypeCollectionViaServiceLocationAssetTypeId
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationAssetType_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AssetTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity, 0, null, null, GetRelationsForField("AssetTypeCollectionViaServiceLocationAssetTypeId"), "AssetTypeCollectionViaServiceLocationAssetTypeId", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, GetRelationsForField("DeepFryerCollectionViaDeepFryerService"), "DeepFryerCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerServiceCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, GetRelationsForField("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog"), "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment__
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment__"), "EmployeeCollectionViaServiceLocationEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment_
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment_"), "EmployeeCollectionViaServiceLocationEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment_____
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment_____"), "EmployeeCollectionViaServiceLocationEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment____
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment____"), "EmployeeCollectionViaServiceLocationEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment______
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment______"), "EmployeeCollectionViaServiceLocationEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment___
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment___"), "EmployeeCollectionViaServiceLocationEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaServiceLocationEmployeeAssignment
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaServiceLocationEmployeeAssignment"), "EmployeeCollectionViaServiceLocationEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerService"), "EmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog_"), "EmployeeCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog"), "EmployeeCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleTypeCollectionViaServiceLocationRecycleType
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.ServiceLocationRecycleTypeEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationRecycleType_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaServiceLocationRecycleType"), "RecycleTypeCollectionViaServiceLocationRecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceChangeLogEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog"), "UserCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderCollectionViaWorkOrderEmployee
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.WorkOrderEmployeeEntityUsingEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrderEmployee_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, GetRelationsForField("WorkOrderCollectionViaWorkOrderEmployee"), "WorkOrderCollectionViaWorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderCollectionViaWorkOrderServiceLocation
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.WorkOrderServiceLocationEntityUsingServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrderServiceLocation_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, GetRelationsForField("WorkOrderCollectionViaWorkOrderServiceLocation"), "WorkOrderCollectionViaWorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, GetRelationsForField("WorkOrderEmployeeCollectionViaDeepFryerService"), "WorkOrderEmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationEntity.Relations.DeepFryerServiceEntityUsingRelocatedToServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, GetRelationsForField("WorkOrderServiceLocationCollectionViaDeepFryerService"), "WorkOrderServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccount
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(),
					(IEntityRelation)GetRelationsForField("Account")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, null, "Account", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceType
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection(),
					(IEntityRelation)GetRelationsForField("ServiceType")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, 0, null, null, null, "ServiceType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ServiceLocationEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ServiceLocationEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
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
			set	{ SetValue((int)ServiceLocationFieldIndex.ServiceLocationId, value, true); }
		}
		/// <summary> The AccountId property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationFieldIndex.AccountId, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.AccountId, value, true); }
		}
		/// <summary> The Name property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.Name, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Name, value, true); }
		}
		/// <summary> The Address1 property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Address1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address1
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.Address1, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Address1, value, true); }
		}
		/// <summary> The Address2 property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Address2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address2
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.Address2, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Address2, value, true); }
		}
		/// <summary> The City property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.City, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.City, value, true); }
		}
		/// <summary> The State property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."State"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String State
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.State, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.State, value, true); }
		}
		/// <summary> The IntlState property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."IntlState"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String IntlState
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.IntlState, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.IntlState, value, true); }
		}
		/// <summary> The ZipCode property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."ZipCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ZipCode
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.ZipCode, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.ZipCode, value, true); }
		}
		/// <summary> The Phone property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.Phone, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Phone, value, true); }
		}
		/// <summary> The MainContact property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."MainContact"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MainContact
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.MainContact, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.MainContact, value, true); }
		}
		/// <summary> The Notes property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)ServiceLocationFieldIndex.Notes, true); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Notes, value, true); }
		}
		/// <summary> The ServiceTypeId property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."ServiceTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ServiceTypeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationFieldIndex.ServiceTypeId, false); }
			set	{ SetValue((int)ServiceLocationFieldIndex.ServiceTypeId, value, true); }
		}
		/// <summary> The IsActive property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> IsActive
		{
			get { return (Nullable<System.Boolean>)GetValue((int)ServiceLocationFieldIndex.IsActive, false); }
			set	{ SetValue((int)ServiceLocationFieldIndex.IsActive, value, true); }
		}
		/// <summary> The Ordinal property of the Entity ServiceLocation<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocation"."Ordinal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Ordinal
		{
			get { return (Nullable<System.Int32>)GetValue((int)ServiceLocationFieldIndex.Ordinal, false); }
			set	{ SetValue((int)ServiceLocationFieldIndex.Ordinal, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection DeepFryer
		{
			get	{ return GetMultiDeepFryer(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryer. When set to true, DeepFryer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryer is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryer(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryer
		{
			get	{ return _alwaysFetchDeepFryer; }
			set	{ _alwaysFetchDeepFryer = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryer already has been fetched. Setting this property to false when DeepFryer has been fetched
		/// will clear the DeepFryer collection well. Setting this property to true while DeepFryer hasn't been fetched disables lazy loading for DeepFryer</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryer
		{
			get { return _alreadyFetchedDeepFryer;}
			set 
			{
				if(_alreadyFetchedDeepFryer && !value && (_deepFryer != null))
				{
					_deepFryer.Clear();
				}
				_alreadyFetchedDeepFryer = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryerService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection DeepFryerService
		{
			get	{ return GetMultiDeepFryerService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerService. When set to true, DeepFryerService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerService is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryerService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerService
		{
			get	{ return _alwaysFetchDeepFryerService; }
			set	{ _alwaysFetchDeepFryerService = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerService already has been fetched. Setting this property to false when DeepFryerService has been fetched
		/// will clear the DeepFryerService collection well. Setting this property to true while DeepFryerService hasn't been fetched disables lazy loading for DeepFryerService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerService
		{
			get { return _alreadyFetchedDeepFryerService;}
			set 
			{
				if(_alreadyFetchedDeepFryerService && !value && (_deepFryerService != null))
				{
					_deepFryerService.Clear();
				}
				_alreadyFetchedDeepFryerService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryerServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection DeepFryerServiceChangeLog
		{
			get	{ return GetMultiDeepFryerServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerServiceChangeLog. When set to true, DeepFryerServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryerServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerServiceChangeLog
		{
			get	{ return _alwaysFetchDeepFryerServiceChangeLog; }
			set	{ _alwaysFetchDeepFryerServiceChangeLog = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerServiceChangeLog already has been fetched. Setting this property to false when DeepFryerServiceChangeLog has been fetched
		/// will clear the DeepFryerServiceChangeLog collection well. Setting this property to true while DeepFryerServiceChangeLog hasn't been fetched disables lazy loading for DeepFryerServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerServiceChangeLog
		{
			get { return _alreadyFetchedDeepFryerServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedDeepFryerServiceChangeLog && !value && (_deepFryerServiceChangeLog != null))
				{
					_deepFryerServiceChangeLog.Clear();
				}
				_alreadyFetchedDeepFryerServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationAssetType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection ServiceLocationAssetType
		{
			get	{ return GetMultiServiceLocationAssetType(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationAssetType. When set to true, ServiceLocationAssetType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationAssetType is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationAssetType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationAssetType
		{
			get	{ return _alwaysFetchServiceLocationAssetType; }
			set	{ _alwaysFetchServiceLocationAssetType = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationAssetType already has been fetched. Setting this property to false when ServiceLocationAssetType has been fetched
		/// will clear the ServiceLocationAssetType collection well. Setting this property to true while ServiceLocationAssetType hasn't been fetched disables lazy loading for ServiceLocationAssetType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationAssetType
		{
			get { return _alreadyFetchedServiceLocationAssetType;}
			set 
			{
				if(_alreadyFetchedServiceLocationAssetType && !value && (_serviceLocationAssetType != null))
				{
					_serviceLocationAssetType.Clear();
				}
				_alreadyFetchedServiceLocationAssetType = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationEmployeeAssignment()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection ServiceLocationEmployeeAssignment
		{
			get	{ return GetMultiServiceLocationEmployeeAssignment(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationEmployeeAssignment. When set to true, ServiceLocationEmployeeAssignment is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationEmployeeAssignment is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationEmployeeAssignment(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationEmployeeAssignment
		{
			get	{ return _alwaysFetchServiceLocationEmployeeAssignment; }
			set	{ _alwaysFetchServiceLocationEmployeeAssignment = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationEmployeeAssignment already has been fetched. Setting this property to false when ServiceLocationEmployeeAssignment has been fetched
		/// will clear the ServiceLocationEmployeeAssignment collection well. Setting this property to true while ServiceLocationEmployeeAssignment hasn't been fetched disables lazy loading for ServiceLocationEmployeeAssignment</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationEmployeeAssignment
		{
			get { return _alreadyFetchedServiceLocationEmployeeAssignment;}
			set 
			{
				if(_alreadyFetchedServiceLocationEmployeeAssignment && !value && (_serviceLocationEmployeeAssignment != null))
				{
					_serviceLocationEmployeeAssignment.Clear();
				}
				_alreadyFetchedServiceLocationEmployeeAssignment = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationRecycleTypeEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationRecycleType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection ServiceLocationRecycleType
		{
			get	{ return GetMultiServiceLocationRecycleType(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationRecycleType. When set to true, ServiceLocationRecycleType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationRecycleType is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationRecycleType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationRecycleType
		{
			get	{ return _alwaysFetchServiceLocationRecycleType; }
			set	{ _alwaysFetchServiceLocationRecycleType = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationRecycleType already has been fetched. Setting this property to false when ServiceLocationRecycleType has been fetched
		/// will clear the ServiceLocationRecycleType collection well. Setting this property to true while ServiceLocationRecycleType hasn't been fetched disables lazy loading for ServiceLocationRecycleType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationRecycleType
		{
			get { return _alreadyFetchedServiceLocationRecycleType;}
			set 
			{
				if(_alreadyFetchedServiceLocationRecycleType && !value && (_serviceLocationRecycleType != null))
				{
					_serviceLocationRecycleType.Clear();
				}
				_alreadyFetchedServiceLocationRecycleType = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection WorkOrderEmployee
		{
			get	{ return GetMultiWorkOrderEmployee(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderEmployee. When set to true, WorkOrderEmployee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderEmployee is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderEmployee
		{
			get	{ return _alwaysFetchWorkOrderEmployee; }
			set	{ _alwaysFetchWorkOrderEmployee = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderEmployee already has been fetched. Setting this property to false when WorkOrderEmployee has been fetched
		/// will clear the WorkOrderEmployee collection well. Setting this property to true while WorkOrderEmployee hasn't been fetched disables lazy loading for WorkOrderEmployee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderEmployee
		{
			get { return _alreadyFetchedWorkOrderEmployee;}
			set 
			{
				if(_alreadyFetchedWorkOrderEmployee && !value && (_workOrderEmployee != null))
				{
					_workOrderEmployee.Clear();
				}
				_alreadyFetchedWorkOrderEmployee = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection WorkOrderServiceLocation
		{
			get	{ return GetMultiWorkOrderServiceLocation(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderServiceLocation. When set to true, WorkOrderServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderServiceLocation
		{
			get	{ return _alwaysFetchWorkOrderServiceLocation; }
			set	{ _alwaysFetchWorkOrderServiceLocation = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderServiceLocation already has been fetched. Setting this property to false when WorkOrderServiceLocation has been fetched
		/// will clear the WorkOrderServiceLocation collection well. Setting this property to true while WorkOrderServiceLocation hasn't been fetched disables lazy loading for WorkOrderServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderServiceLocation
		{
			get { return _alreadyFetchedWorkOrderServiceLocation;}
			set 
			{
				if(_alreadyFetchedWorkOrderServiceLocation && !value && (_workOrderServiceLocation != null))
				{
					_workOrderServiceLocation.Clear();
				}
				_alreadyFetchedWorkOrderServiceLocation = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AssetTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAssetTypeCollectionViaServiceLocationAssetTypeId()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AssetTypeCollection AssetTypeCollectionViaServiceLocationAssetTypeId
		{
			get { return GetMultiAssetTypeCollectionViaServiceLocationAssetTypeId(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AssetTypeCollectionViaServiceLocationAssetTypeId. When set to true, AssetTypeCollectionViaServiceLocationAssetTypeId is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AssetTypeCollectionViaServiceLocationAssetTypeId is accessed. You can always execute
		/// a forced fetch by calling GetMultiAssetTypeCollectionViaServiceLocationAssetTypeId(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAssetTypeCollectionViaServiceLocationAssetTypeId
		{
			get	{ return _alwaysFetchAssetTypeCollectionViaServiceLocationAssetTypeId; }
			set	{ _alwaysFetchAssetTypeCollectionViaServiceLocationAssetTypeId = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AssetTypeCollectionViaServiceLocationAssetTypeId already has been fetched. Setting this property to false when AssetTypeCollectionViaServiceLocationAssetTypeId has been fetched
		/// will clear the AssetTypeCollectionViaServiceLocationAssetTypeId collection well. Setting this property to true while AssetTypeCollectionViaServiceLocationAssetTypeId hasn't been fetched disables lazy loading for AssetTypeCollectionViaServiceLocationAssetTypeId</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId
		{
			get { return _alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId;}
			set 
			{
				if(_alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId && !value && (_assetTypeCollectionViaServiceLocationAssetTypeId != null))
				{
					_assetTypeCollectionViaServiceLocationAssetTypeId.Clear();
				}
				_alreadyFetchedAssetTypeCollectionViaServiceLocationAssetTypeId = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'DeepFryerEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryerCollectionViaDeepFryerService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection DeepFryerCollectionViaDeepFryerService
		{
			get { return GetMultiDeepFryerCollectionViaDeepFryerService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerCollectionViaDeepFryerService. When set to true, DeepFryerCollectionViaDeepFryerService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerCollectionViaDeepFryerService is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryerCollectionViaDeepFryerService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerCollectionViaDeepFryerService
		{
			get	{ return _alwaysFetchDeepFryerCollectionViaDeepFryerService; }
			set	{ _alwaysFetchDeepFryerCollectionViaDeepFryerService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerCollectionViaDeepFryerService already has been fetched. Setting this property to false when DeepFryerCollectionViaDeepFryerService has been fetched
		/// will clear the DeepFryerCollectionViaDeepFryerService collection well. Setting this property to true while DeepFryerCollectionViaDeepFryerService hasn't been fetched disables lazy loading for DeepFryerCollectionViaDeepFryerService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerCollectionViaDeepFryerService
		{
			get { return _alreadyFetchedDeepFryerCollectionViaDeepFryerService;}
			set 
			{
				if(_alreadyFetchedDeepFryerCollectionViaDeepFryerService && !value && (_deepFryerCollectionViaDeepFryerService != null))
				{
					_deepFryerCollectionViaDeepFryerService.Clear();
				}
				_alreadyFetchedDeepFryerCollectionViaDeepFryerService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection DeepFryerServiceCollectionViaDeepFryerServiceChangeLog
		{
			get { return GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerServiceCollectionViaDeepFryerServiceChangeLog. When set to true, DeepFryerServiceCollectionViaDeepFryerServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerServiceCollectionViaDeepFryerServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog
		{
			get	{ return _alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog; }
			set	{ _alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerServiceCollectionViaDeepFryerServiceChangeLog already has been fetched. Setting this property to false when DeepFryerServiceCollectionViaDeepFryerServiceChangeLog has been fetched
		/// will clear the DeepFryerServiceCollectionViaDeepFryerServiceChangeLog collection well. Setting this property to true while DeepFryerServiceCollectionViaDeepFryerServiceChangeLog hasn't been fetched disables lazy loading for DeepFryerServiceCollectionViaDeepFryerServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog
		{
			get { return _alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog && !value && (_deepFryerServiceCollectionViaDeepFryerServiceChangeLog != null))
				{
					_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.Clear();
				}
				_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaServiceLocationEmployeeAssignment__
		{
			get { return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment__(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaServiceLocationEmployeeAssignment__. When set to true, EmployeeCollectionViaServiceLocationEmployeeAssignment__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaServiceLocationEmployeeAssignment__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment__(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment__
		{
			get	{ return _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment__; }
			set	{ _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment__ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaServiceLocationEmployeeAssignment__ already has been fetched. Setting this property to false when EmployeeCollectionViaServiceLocationEmployeeAssignment__ has been fetched
		/// will clear the EmployeeCollectionViaServiceLocationEmployeeAssignment__ collection well. Setting this property to true while EmployeeCollectionViaServiceLocationEmployeeAssignment__ hasn't been fetched disables lazy loading for EmployeeCollectionViaServiceLocationEmployeeAssignment__</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__
		{
			get { return _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__ && !value && (_employeeCollectionViaServiceLocationEmployeeAssignment__ != null))
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment__.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment__ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaServiceLocationEmployeeAssignment_
		{
			get { return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaServiceLocationEmployeeAssignment_. When set to true, EmployeeCollectionViaServiceLocationEmployeeAssignment_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaServiceLocationEmployeeAssignment_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_
		{
			get	{ return _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_; }
			set	{ _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaServiceLocationEmployeeAssignment_ already has been fetched. Setting this property to false when EmployeeCollectionViaServiceLocationEmployeeAssignment_ has been fetched
		/// will clear the EmployeeCollectionViaServiceLocationEmployeeAssignment_ collection well. Setting this property to true while EmployeeCollectionViaServiceLocationEmployeeAssignment_ hasn't been fetched disables lazy loading for EmployeeCollectionViaServiceLocationEmployeeAssignment_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_
		{
			get { return _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_ && !value && (_employeeCollectionViaServiceLocationEmployeeAssignment_ != null))
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment_.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaServiceLocationEmployeeAssignment_____
		{
			get { return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaServiceLocationEmployeeAssignment_____. When set to true, EmployeeCollectionViaServiceLocationEmployeeAssignment_____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaServiceLocationEmployeeAssignment_____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment_____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_____
		{
			get	{ return _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_____; }
			set	{ _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment_____ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaServiceLocationEmployeeAssignment_____ already has been fetched. Setting this property to false when EmployeeCollectionViaServiceLocationEmployeeAssignment_____ has been fetched
		/// will clear the EmployeeCollectionViaServiceLocationEmployeeAssignment_____ collection well. Setting this property to true while EmployeeCollectionViaServiceLocationEmployeeAssignment_____ hasn't been fetched disables lazy loading for EmployeeCollectionViaServiceLocationEmployeeAssignment_____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____
		{
			get { return _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____ && !value && (_employeeCollectionViaServiceLocationEmployeeAssignment_____ != null))
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment_____.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment_____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaServiceLocationEmployeeAssignment____
		{
			get { return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaServiceLocationEmployeeAssignment____. When set to true, EmployeeCollectionViaServiceLocationEmployeeAssignment____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaServiceLocationEmployeeAssignment____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment____
		{
			get	{ return _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment____; }
			set	{ _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment____ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaServiceLocationEmployeeAssignment____ already has been fetched. Setting this property to false when EmployeeCollectionViaServiceLocationEmployeeAssignment____ has been fetched
		/// will clear the EmployeeCollectionViaServiceLocationEmployeeAssignment____ collection well. Setting this property to true while EmployeeCollectionViaServiceLocationEmployeeAssignment____ hasn't been fetched disables lazy loading for EmployeeCollectionViaServiceLocationEmployeeAssignment____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____
		{
			get { return _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____ && !value && (_employeeCollectionViaServiceLocationEmployeeAssignment____ != null))
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment____.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment______()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaServiceLocationEmployeeAssignment______
		{
			get { return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment______(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaServiceLocationEmployeeAssignment______. When set to true, EmployeeCollectionViaServiceLocationEmployeeAssignment______ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaServiceLocationEmployeeAssignment______ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment______(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment______
		{
			get	{ return _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment______; }
			set	{ _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment______ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaServiceLocationEmployeeAssignment______ already has been fetched. Setting this property to false when EmployeeCollectionViaServiceLocationEmployeeAssignment______ has been fetched
		/// will clear the EmployeeCollectionViaServiceLocationEmployeeAssignment______ collection well. Setting this property to true while EmployeeCollectionViaServiceLocationEmployeeAssignment______ hasn't been fetched disables lazy loading for EmployeeCollectionViaServiceLocationEmployeeAssignment______</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______
		{
			get { return _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______ && !value && (_employeeCollectionViaServiceLocationEmployeeAssignment______ != null))
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment______.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment______ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaServiceLocationEmployeeAssignment___
		{
			get { return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment___(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaServiceLocationEmployeeAssignment___. When set to true, EmployeeCollectionViaServiceLocationEmployeeAssignment___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaServiceLocationEmployeeAssignment___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment___(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment___
		{
			get	{ return _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment___; }
			set	{ _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment___ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaServiceLocationEmployeeAssignment___ already has been fetched. Setting this property to false when EmployeeCollectionViaServiceLocationEmployeeAssignment___ has been fetched
		/// will clear the EmployeeCollectionViaServiceLocationEmployeeAssignment___ collection well. Setting this property to true while EmployeeCollectionViaServiceLocationEmployeeAssignment___ hasn't been fetched disables lazy loading for EmployeeCollectionViaServiceLocationEmployeeAssignment___</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___
		{
			get { return _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___ && !value && (_employeeCollectionViaServiceLocationEmployeeAssignment___ != null))
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment___.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment___ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaServiceLocationEmployeeAssignment
		{
			get { return GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaServiceLocationEmployeeAssignment. When set to true, EmployeeCollectionViaServiceLocationEmployeeAssignment is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaServiceLocationEmployeeAssignment is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaServiceLocationEmployeeAssignment(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment
		{
			get	{ return _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment; }
			set	{ _alwaysFetchEmployeeCollectionViaServiceLocationEmployeeAssignment = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaServiceLocationEmployeeAssignment already has been fetched. Setting this property to false when EmployeeCollectionViaServiceLocationEmployeeAssignment has been fetched
		/// will clear the EmployeeCollectionViaServiceLocationEmployeeAssignment collection well. Setting this property to true while EmployeeCollectionViaServiceLocationEmployeeAssignment hasn't been fetched disables lazy loading for EmployeeCollectionViaServiceLocationEmployeeAssignment</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment
		{
			get { return _alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment && !value && (_employeeCollectionViaServiceLocationEmployeeAssignment != null))
				{
					_employeeCollectionViaServiceLocationEmployeeAssignment.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaServiceLocationEmployeeAssignment = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaDeepFryerService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaDeepFryerService
		{
			get { return GetMultiEmployeeCollectionViaDeepFryerService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaDeepFryerService. When set to true, EmployeeCollectionViaDeepFryerService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaDeepFryerService is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaDeepFryerService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaDeepFryerService
		{
			get	{ return _alwaysFetchEmployeeCollectionViaDeepFryerService; }
			set	{ _alwaysFetchEmployeeCollectionViaDeepFryerService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaDeepFryerService already has been fetched. Setting this property to false when EmployeeCollectionViaDeepFryerService has been fetched
		/// will clear the EmployeeCollectionViaDeepFryerService collection well. Setting this property to true while EmployeeCollectionViaDeepFryerService hasn't been fetched disables lazy loading for EmployeeCollectionViaDeepFryerService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaDeepFryerService
		{
			get { return _alreadyFetchedEmployeeCollectionViaDeepFryerService;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaDeepFryerService && !value && (_employeeCollectionViaDeepFryerService != null))
				{
					_employeeCollectionViaDeepFryerService.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaDeepFryerService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get { return GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaDeepFryerServiceChangeLog_. When set to true, EmployeeCollectionViaDeepFryerServiceChangeLog_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaDeepFryerServiceChangeLog_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get	{ return _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_; }
			set	{ _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaDeepFryerServiceChangeLog_ already has been fetched. Setting this property to false when EmployeeCollectionViaDeepFryerServiceChangeLog_ has been fetched
		/// will clear the EmployeeCollectionViaDeepFryerServiceChangeLog_ collection well. Setting this property to true while EmployeeCollectionViaDeepFryerServiceChangeLog_ hasn't been fetched disables lazy loading for EmployeeCollectionViaDeepFryerServiceChangeLog_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get { return _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ && !value && (_employeeCollectionViaDeepFryerServiceChangeLog_ != null))
				{
					_employeeCollectionViaDeepFryerServiceChangeLog_.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get { return GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaDeepFryerServiceChangeLog. When set to true, EmployeeCollectionViaDeepFryerServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaDeepFryerServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get	{ return _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog; }
			set	{ _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaDeepFryerServiceChangeLog already has been fetched. Setting this property to false when EmployeeCollectionViaDeepFryerServiceChangeLog has been fetched
		/// will clear the EmployeeCollectionViaDeepFryerServiceChangeLog collection well. Setting this property to true while EmployeeCollectionViaDeepFryerServiceChangeLog hasn't been fetched disables lazy loading for EmployeeCollectionViaDeepFryerServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get { return _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog && !value && (_employeeCollectionViaDeepFryerServiceChangeLog != null))
				{
					_employeeCollectionViaDeepFryerServiceChangeLog.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleTypeCollectionViaServiceLocationRecycleType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection RecycleTypeCollectionViaServiceLocationRecycleType
		{
			get { return GetMultiRecycleTypeCollectionViaServiceLocationRecycleType(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleTypeCollectionViaServiceLocationRecycleType. When set to true, RecycleTypeCollectionViaServiceLocationRecycleType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleTypeCollectionViaServiceLocationRecycleType is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleTypeCollectionViaServiceLocationRecycleType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleTypeCollectionViaServiceLocationRecycleType
		{
			get	{ return _alwaysFetchRecycleTypeCollectionViaServiceLocationRecycleType; }
			set	{ _alwaysFetchRecycleTypeCollectionViaServiceLocationRecycleType = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleTypeCollectionViaServiceLocationRecycleType already has been fetched. Setting this property to false when RecycleTypeCollectionViaServiceLocationRecycleType has been fetched
		/// will clear the RecycleTypeCollectionViaServiceLocationRecycleType collection well. Setting this property to true while RecycleTypeCollectionViaServiceLocationRecycleType hasn't been fetched disables lazy loading for RecycleTypeCollectionViaServiceLocationRecycleType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType
		{
			get { return _alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType;}
			set 
			{
				if(_alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType && !value && (_recycleTypeCollectionViaServiceLocationRecycleType != null))
				{
					_recycleTypeCollectionViaServiceLocationRecycleType.Clear();
				}
				_alreadyFetchedRecycleTypeCollectionViaServiceLocationRecycleType = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaDeepFryerServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaDeepFryerServiceChangeLog
		{
			get { return GetMultiUserCollectionViaDeepFryerServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaDeepFryerServiceChangeLog. When set to true, UserCollectionViaDeepFryerServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaDeepFryerServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaDeepFryerServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaDeepFryerServiceChangeLog
		{
			get	{ return _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog; }
			set	{ _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaDeepFryerServiceChangeLog already has been fetched. Setting this property to false when UserCollectionViaDeepFryerServiceChangeLog has been fetched
		/// will clear the UserCollectionViaDeepFryerServiceChangeLog collection well. Setting this property to true while UserCollectionViaDeepFryerServiceChangeLog hasn't been fetched disables lazy loading for UserCollectionViaDeepFryerServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaDeepFryerServiceChangeLog
		{
			get { return _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog && !value && (_userCollectionViaDeepFryerServiceChangeLog != null))
				{
					_userCollectionViaDeepFryerServiceChangeLog.Clear();
				}
				_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderCollectionViaWorkOrderEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection WorkOrderCollectionViaWorkOrderEmployee
		{
			get { return GetMultiWorkOrderCollectionViaWorkOrderEmployee(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderCollectionViaWorkOrderEmployee. When set to true, WorkOrderCollectionViaWorkOrderEmployee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderCollectionViaWorkOrderEmployee is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderCollectionViaWorkOrderEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderCollectionViaWorkOrderEmployee
		{
			get	{ return _alwaysFetchWorkOrderCollectionViaWorkOrderEmployee; }
			set	{ _alwaysFetchWorkOrderCollectionViaWorkOrderEmployee = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderCollectionViaWorkOrderEmployee already has been fetched. Setting this property to false when WorkOrderCollectionViaWorkOrderEmployee has been fetched
		/// will clear the WorkOrderCollectionViaWorkOrderEmployee collection well. Setting this property to true while WorkOrderCollectionViaWorkOrderEmployee hasn't been fetched disables lazy loading for WorkOrderCollectionViaWorkOrderEmployee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderCollectionViaWorkOrderEmployee
		{
			get { return _alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee;}
			set 
			{
				if(_alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee && !value && (_workOrderCollectionViaWorkOrderEmployee != null))
				{
					_workOrderCollectionViaWorkOrderEmployee.Clear();
				}
				_alreadyFetchedWorkOrderCollectionViaWorkOrderEmployee = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderCollectionViaWorkOrderServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection WorkOrderCollectionViaWorkOrderServiceLocation
		{
			get { return GetMultiWorkOrderCollectionViaWorkOrderServiceLocation(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderCollectionViaWorkOrderServiceLocation. When set to true, WorkOrderCollectionViaWorkOrderServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderCollectionViaWorkOrderServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderCollectionViaWorkOrderServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderCollectionViaWorkOrderServiceLocation
		{
			get	{ return _alwaysFetchWorkOrderCollectionViaWorkOrderServiceLocation; }
			set	{ _alwaysFetchWorkOrderCollectionViaWorkOrderServiceLocation = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderCollectionViaWorkOrderServiceLocation already has been fetched. Setting this property to false when WorkOrderCollectionViaWorkOrderServiceLocation has been fetched
		/// will clear the WorkOrderCollectionViaWorkOrderServiceLocation collection well. Setting this property to true while WorkOrderCollectionViaWorkOrderServiceLocation hasn't been fetched disables lazy loading for WorkOrderCollectionViaWorkOrderServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation
		{
			get { return _alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation;}
			set 
			{
				if(_alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation && !value && (_workOrderCollectionViaWorkOrderServiceLocation != null))
				{
					_workOrderCollectionViaWorkOrderServiceLocation.Clear();
				}
				_alreadyFetchedWorkOrderCollectionViaWorkOrderServiceLocation = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderEmployeeCollectionViaDeepFryerService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection WorkOrderEmployeeCollectionViaDeepFryerService
		{
			get { return GetMultiWorkOrderEmployeeCollectionViaDeepFryerService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderEmployeeCollectionViaDeepFryerService. When set to true, WorkOrderEmployeeCollectionViaDeepFryerService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderEmployeeCollectionViaDeepFryerService is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderEmployeeCollectionViaDeepFryerService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService
		{
			get	{ return _alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService; }
			set	{ _alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderEmployeeCollectionViaDeepFryerService already has been fetched. Setting this property to false when WorkOrderEmployeeCollectionViaDeepFryerService has been fetched
		/// will clear the WorkOrderEmployeeCollectionViaDeepFryerService collection well. Setting this property to true while WorkOrderEmployeeCollectionViaDeepFryerService hasn't been fetched disables lazy loading for WorkOrderEmployeeCollectionViaDeepFryerService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService
		{
			get { return _alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService;}
			set 
			{
				if(_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService && !value && (_workOrderEmployeeCollectionViaDeepFryerService != null))
				{
					_workOrderEmployeeCollectionViaDeepFryerService.Clear();
				}
				_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderServiceLocationCollectionViaDeepFryerService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection WorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get { return GetMultiWorkOrderServiceLocationCollectionViaDeepFryerService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderServiceLocationCollectionViaDeepFryerService. When set to true, WorkOrderServiceLocationCollectionViaDeepFryerService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderServiceLocationCollectionViaDeepFryerService is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderServiceLocationCollectionViaDeepFryerService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get	{ return _alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService; }
			set	{ _alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderServiceLocationCollectionViaDeepFryerService already has been fetched. Setting this property to false when WorkOrderServiceLocationCollectionViaDeepFryerService has been fetched
		/// will clear the WorkOrderServiceLocationCollectionViaDeepFryerService collection well. Setting this property to true while WorkOrderServiceLocationCollectionViaDeepFryerService hasn't been fetched disables lazy loading for WorkOrderServiceLocationCollectionViaDeepFryerService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get { return _alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService;}
			set 
			{
				if(_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService && !value && (_workOrderServiceLocationCollectionViaDeepFryerService != null))
				{
					_workOrderServiceLocationCollectionViaDeepFryerService.Clear();
				}
				_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'AccountEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAccount()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AccountEntity Account
		{
			get	{ return GetSingleAccount(false); }
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
							((IEntity)value).SetRelatedEntity(this, "ServiceLocation");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Account. When set to true, Account is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Account is accessed. You can always execute
		/// a forced fetch by calling GetSingleAccount(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccount
		{
			get	{ return _alwaysFetchAccount; }
			set	{ _alwaysFetchAccount = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Account already has been fetched. Setting this property to false when Account has been fetched
		/// will set Account to null as well. Setting this property to true while Account hasn't been fetched disables lazy loading for Account</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccount
		{
			get { return _alreadyFetchedAccount;}
			set 
			{
				if(_alreadyFetchedAccount && !value)
				{
					this.Account = null;
				}
				_alreadyFetchedAccount = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Account is not found
		/// in the database. When set to true, Account will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool AccountReturnsNewIfNotFound
		{
			get	{ return _accountReturnsNewIfNotFound; }
			set { _accountReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ServiceTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleServiceType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ServiceTypeEntity ServiceType
		{
			get	{ return GetSingleServiceType(false); }
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
							((IEntity)value).SetRelatedEntity(this, "ServiceLocation");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceType. When set to true, ServiceType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceType is accessed. You can always execute
		/// a forced fetch by calling GetSingleServiceType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceType
		{
			get	{ return _alwaysFetchServiceType; }
			set	{ _alwaysFetchServiceType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceType already has been fetched. Setting this property to false when ServiceType has been fetched
		/// will set ServiceType to null as well. Setting this property to true while ServiceType hasn't been fetched disables lazy loading for ServiceType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceType
		{
			get { return _alreadyFetchedServiceType;}
			set 
			{
				if(_alreadyFetchedServiceType && !value)
				{
					this.ServiceType = null;
				}
				_alreadyFetchedServiceType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ServiceType is not found
		/// in the database. When set to true, ServiceType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ServiceTypeReturnsNewIfNotFound
		{
			get	{ return _serviceTypeReturnsNewIfNotFound; }
			set { _serviceTypeReturnsNewIfNotFound = value; }	
		}



		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
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
