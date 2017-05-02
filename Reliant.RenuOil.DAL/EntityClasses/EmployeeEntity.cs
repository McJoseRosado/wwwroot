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
	/// Entity class which represents the entity 'Employee'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class EmployeeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection	_accountEmployeeAssignment____;
		private bool	_alwaysFetchAccountEmployeeAssignment____, _alreadyFetchedAccountEmployeeAssignment____;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection	_accountEmployeeAssignment_____;
		private bool	_alwaysFetchAccountEmployeeAssignment_____, _alreadyFetchedAccountEmployeeAssignment_____;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection	_accountEmployeeAssignment______;
		private bool	_alwaysFetchAccountEmployeeAssignment______, _alreadyFetchedAccountEmployeeAssignment______;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection	_accountEmployeeAssignment___;
		private bool	_alwaysFetchAccountEmployeeAssignment___, _alreadyFetchedAccountEmployeeAssignment___;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection	_accountEmployeeAssignment;
		private bool	_alwaysFetchAccountEmployeeAssignment, _alreadyFetchedAccountEmployeeAssignment;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection	_accountEmployeeAssignment_;
		private bool	_alwaysFetchAccountEmployeeAssignment_, _alreadyFetchedAccountEmployeeAssignment_;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection	_accountEmployeeAssignment__;
		private bool	_alwaysFetchAccountEmployeeAssignment__, _alreadyFetchedAccountEmployeeAssignment__;
		private Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection	_assetReclamationServiceChangeLog;
		private bool	_alwaysFetchAssetReclamationServiceChangeLog, _alreadyFetchedAssetReclamationServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection	_deepFryerService;
		private bool	_alwaysFetchDeepFryerService, _alreadyFetchedDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection	_deepFryerServiceChangeLog_;
		private bool	_alwaysFetchDeepFryerServiceChangeLog_, _alreadyFetchedDeepFryerServiceChangeLog_;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection	_deepFryerServiceChangeLog;
		private bool	_alwaysFetchDeepFryerServiceChangeLog, _alreadyFetchedDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.LoadCollection	_load;
		private bool	_alwaysFetchLoad, _alreadyFetchedLoad;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection	_recycleServiceAction_;
		private bool	_alwaysFetchRecycleServiceAction_, _alreadyFetchedRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection	_recycleServiceAction;
		private bool	_alwaysFetchRecycleServiceAction, _alreadyFetchedRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection	_recycleServiceChangeLog;
		private bool	_alwaysFetchRecycleServiceChangeLog, _alreadyFetchedRecycleServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection	_serviceLocationEmployeeAssignment____;
		private bool	_alwaysFetchServiceLocationEmployeeAssignment____, _alreadyFetchedServiceLocationEmployeeAssignment____;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection	_serviceLocationEmployeeAssignment_____;
		private bool	_alwaysFetchServiceLocationEmployeeAssignment_____, _alreadyFetchedServiceLocationEmployeeAssignment_____;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection	_serviceLocationEmployeeAssignment______;
		private bool	_alwaysFetchServiceLocationEmployeeAssignment______, _alreadyFetchedServiceLocationEmployeeAssignment______;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection	_serviceLocationEmployeeAssignment___;
		private bool	_alwaysFetchServiceLocationEmployeeAssignment___, _alreadyFetchedServiceLocationEmployeeAssignment___;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection	_serviceLocationEmployeeAssignment;
		private bool	_alwaysFetchServiceLocationEmployeeAssignment, _alreadyFetchedServiceLocationEmployeeAssignment;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection	_serviceLocationEmployeeAssignment_;
		private bool	_alwaysFetchServiceLocationEmployeeAssignment_, _alreadyFetchedServiceLocationEmployeeAssignment_;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection	_serviceLocationEmployeeAssignment__;
		private bool	_alwaysFetchServiceLocationEmployeeAssignment__, _alreadyFetchedServiceLocationEmployeeAssignment__;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection	_workOrder;
		private bool	_alwaysFetchWorkOrder, _alreadyFetchedWorkOrder;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaAccountEmployeeAssignment_____;
		private bool	_alwaysFetchAccountCollectionViaAccountEmployeeAssignment_____, _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaAccountEmployeeAssignment____;
		private bool	_alwaysFetchAccountCollectionViaAccountEmployeeAssignment____, _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaWorkOrder;
		private bool	_alwaysFetchAccountCollectionViaWorkOrder, _alreadyFetchedAccountCollectionViaWorkOrder;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaAccountEmployeeAssignment______;
		private bool	_alwaysFetchAccountCollectionViaAccountEmployeeAssignment______, _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaAccountEmployeeAssignment_;
		private bool	_alwaysFetchAccountCollectionViaAccountEmployeeAssignment_, _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaAccountEmployeeAssignment;
		private bool	_alwaysFetchAccountCollectionViaAccountEmployeeAssignment, _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaAccountEmployeeAssignment___;
		private bool	_alwaysFetchAccountCollectionViaAccountEmployeeAssignment___, _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaAccountEmployeeAssignment__;
		private bool	_alwaysFetchAccountCollectionViaAccountEmployeeAssignment__, _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__;
		private Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection _assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog;
		private bool	_alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog, _alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection _deepFryerCollectionViaDeepFryerService;
		private bool	_alwaysFetchDeepFryerCollectionViaDeepFryerService, _alreadyFetchedDeepFryerCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection _deepFryerServiceCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection _deepFryerServiceCollectionViaDeepFryerServiceChangeLog_;
		private bool	_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_, _alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection _recycleServiceCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction, _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection _recycleServiceCollectionViaRecycleServiceChangeLog;
		private bool	_alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog, _alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection _recycleServiceCollectionViaRecycleServiceAction_;
		private bool	_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_, _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection _recycleTypeCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction, _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection _recycleTypeCollectionViaRecycleServiceAction_;
		private bool	_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_, _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaServiceLocationEmployeeAssignment_;
		private bool	_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_, _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaServiceLocationEmployeeAssignment;
		private bool	_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment, _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaServiceLocationEmployeeAssignment_____;
		private bool	_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_____, _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaDeepFryerService;
		private bool	_alwaysFetchServiceLocationCollectionViaDeepFryerService, _alreadyFetchedServiceLocationCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaServiceLocationEmployeeAssignment______;
		private bool	_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment______, _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaServiceLocationEmployeeAssignment____;
		private bool	_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment____, _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaServiceLocationEmployeeAssignment__;
		private bool	_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment__, _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaServiceLocationEmployeeAssignment___;
		private bool	_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment___, _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaDeepFryerServiceChangeLog_;
		private bool	_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog_, _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection _serviceTypeCollectionViaWorkOrder;
		private bool	_alwaysFetchServiceTypeCollectionViaWorkOrder, _alreadyFetchedServiceTypeCollectionViaWorkOrder;
		private Reliant.RenuOil.DAL.CollectionClasses.StatusCollection _statusCollectionViaLoad;
		private bool	_alwaysFetchStatusCollectionViaLoad, _alreadyFetchedStatusCollectionViaLoad;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaDeepFryerServiceChangeLog_;
		private bool	_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog_, _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRecycleServiceAction___;
		private bool	_alwaysFetchUserCollectionViaRecycleServiceAction___, _alreadyFetchedUserCollectionViaRecycleServiceAction___;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaAssetReclamationServiceChangeLog;
		private bool	_alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog, _alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRecycleServiceChangeLog;
		private bool	_alwaysFetchUserCollectionViaRecycleServiceChangeLog, _alreadyFetchedUserCollectionViaRecycleServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRecycleServiceAction_;
		private bool	_alwaysFetchUserCollectionViaRecycleServiceAction_, _alreadyFetchedUserCollectionViaRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRecycleServiceAction__;
		private bool	_alwaysFetchUserCollectionViaRecycleServiceAction__, _alreadyFetchedUserCollectionViaRecycleServiceAction__;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchUserCollectionViaRecycleServiceAction, _alreadyFetchedUserCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection _workOrderEmployeeCollectionViaDeepFryerService;
		private bool	_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService, _alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection _workOrderServiceLocationCollectionViaDeepFryerService;
		private bool	_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService, _alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService;


		
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
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public EmployeeEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		public EmployeeEntity(System.Int32 employeeId)
		{
			InitClassFetch(employeeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public EmployeeEntity(System.Int32 employeeId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(employeeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(System.Int32 employeeId, IValidator validator)
		{
			InitClassFetch(employeeId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_accountEmployeeAssignment____ = (Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection)info.GetValue("_accountEmployeeAssignment____", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection));
			_alwaysFetchAccountEmployeeAssignment____ = info.GetBoolean("_alwaysFetchAccountEmployeeAssignment____");
			_alreadyFetchedAccountEmployeeAssignment____ = info.GetBoolean("_alreadyFetchedAccountEmployeeAssignment____");
			_accountEmployeeAssignment_____ = (Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection)info.GetValue("_accountEmployeeAssignment_____", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection));
			_alwaysFetchAccountEmployeeAssignment_____ = info.GetBoolean("_alwaysFetchAccountEmployeeAssignment_____");
			_alreadyFetchedAccountEmployeeAssignment_____ = info.GetBoolean("_alreadyFetchedAccountEmployeeAssignment_____");
			_accountEmployeeAssignment______ = (Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection)info.GetValue("_accountEmployeeAssignment______", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection));
			_alwaysFetchAccountEmployeeAssignment______ = info.GetBoolean("_alwaysFetchAccountEmployeeAssignment______");
			_alreadyFetchedAccountEmployeeAssignment______ = info.GetBoolean("_alreadyFetchedAccountEmployeeAssignment______");
			_accountEmployeeAssignment___ = (Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection)info.GetValue("_accountEmployeeAssignment___", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection));
			_alwaysFetchAccountEmployeeAssignment___ = info.GetBoolean("_alwaysFetchAccountEmployeeAssignment___");
			_alreadyFetchedAccountEmployeeAssignment___ = info.GetBoolean("_alreadyFetchedAccountEmployeeAssignment___");
			_accountEmployeeAssignment = (Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection)info.GetValue("_accountEmployeeAssignment", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection));
			_alwaysFetchAccountEmployeeAssignment = info.GetBoolean("_alwaysFetchAccountEmployeeAssignment");
			_alreadyFetchedAccountEmployeeAssignment = info.GetBoolean("_alreadyFetchedAccountEmployeeAssignment");
			_accountEmployeeAssignment_ = (Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection)info.GetValue("_accountEmployeeAssignment_", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection));
			_alwaysFetchAccountEmployeeAssignment_ = info.GetBoolean("_alwaysFetchAccountEmployeeAssignment_");
			_alreadyFetchedAccountEmployeeAssignment_ = info.GetBoolean("_alreadyFetchedAccountEmployeeAssignment_");
			_accountEmployeeAssignment__ = (Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection)info.GetValue("_accountEmployeeAssignment__", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection));
			_alwaysFetchAccountEmployeeAssignment__ = info.GetBoolean("_alwaysFetchAccountEmployeeAssignment__");
			_alreadyFetchedAccountEmployeeAssignment__ = info.GetBoolean("_alreadyFetchedAccountEmployeeAssignment__");
			_assetReclamationServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection)info.GetValue("_assetReclamationServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection));
			_alwaysFetchAssetReclamationServiceChangeLog = info.GetBoolean("_alwaysFetchAssetReclamationServiceChangeLog");
			_alreadyFetchedAssetReclamationServiceChangeLog = info.GetBoolean("_alreadyFetchedAssetReclamationServiceChangeLog");
			_deepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection)info.GetValue("_deepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection));
			_alwaysFetchDeepFryerService = info.GetBoolean("_alwaysFetchDeepFryerService");
			_alreadyFetchedDeepFryerService = info.GetBoolean("_alreadyFetchedDeepFryerService");
			_deepFryerServiceChangeLog_ = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection)info.GetValue("_deepFryerServiceChangeLog_", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection));
			_alwaysFetchDeepFryerServiceChangeLog_ = info.GetBoolean("_alwaysFetchDeepFryerServiceChangeLog_");
			_alreadyFetchedDeepFryerServiceChangeLog_ = info.GetBoolean("_alreadyFetchedDeepFryerServiceChangeLog_");
			_deepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection)info.GetValue("_deepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection));
			_alwaysFetchDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchDeepFryerServiceChangeLog");
			_alreadyFetchedDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedDeepFryerServiceChangeLog");
			_load = (Reliant.RenuOil.DAL.CollectionClasses.LoadCollection)info.GetValue("_load", typeof(Reliant.RenuOil.DAL.CollectionClasses.LoadCollection));
			_alwaysFetchLoad = info.GetBoolean("_alwaysFetchLoad");
			_alreadyFetchedLoad = info.GetBoolean("_alreadyFetchedLoad");
			_recycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection)info.GetValue("_recycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection));
			_alwaysFetchRecycleServiceAction_ = info.GetBoolean("_alwaysFetchRecycleServiceAction_");
			_alreadyFetchedRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedRecycleServiceAction_");
			_recycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection)info.GetValue("_recycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection));
			_alwaysFetchRecycleServiceAction = info.GetBoolean("_alwaysFetchRecycleServiceAction");
			_alreadyFetchedRecycleServiceAction = info.GetBoolean("_alreadyFetchedRecycleServiceAction");
			_recycleServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection)info.GetValue("_recycleServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection));
			_alwaysFetchRecycleServiceChangeLog = info.GetBoolean("_alwaysFetchRecycleServiceChangeLog");
			_alreadyFetchedRecycleServiceChangeLog = info.GetBoolean("_alreadyFetchedRecycleServiceChangeLog");
			_serviceLocationEmployeeAssignment____ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection)info.GetValue("_serviceLocationEmployeeAssignment____", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection));
			_alwaysFetchServiceLocationEmployeeAssignment____ = info.GetBoolean("_alwaysFetchServiceLocationEmployeeAssignment____");
			_alreadyFetchedServiceLocationEmployeeAssignment____ = info.GetBoolean("_alreadyFetchedServiceLocationEmployeeAssignment____");
			_serviceLocationEmployeeAssignment_____ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection)info.GetValue("_serviceLocationEmployeeAssignment_____", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection));
			_alwaysFetchServiceLocationEmployeeAssignment_____ = info.GetBoolean("_alwaysFetchServiceLocationEmployeeAssignment_____");
			_alreadyFetchedServiceLocationEmployeeAssignment_____ = info.GetBoolean("_alreadyFetchedServiceLocationEmployeeAssignment_____");
			_serviceLocationEmployeeAssignment______ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection)info.GetValue("_serviceLocationEmployeeAssignment______", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection));
			_alwaysFetchServiceLocationEmployeeAssignment______ = info.GetBoolean("_alwaysFetchServiceLocationEmployeeAssignment______");
			_alreadyFetchedServiceLocationEmployeeAssignment______ = info.GetBoolean("_alreadyFetchedServiceLocationEmployeeAssignment______");
			_serviceLocationEmployeeAssignment___ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection)info.GetValue("_serviceLocationEmployeeAssignment___", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection));
			_alwaysFetchServiceLocationEmployeeAssignment___ = info.GetBoolean("_alwaysFetchServiceLocationEmployeeAssignment___");
			_alreadyFetchedServiceLocationEmployeeAssignment___ = info.GetBoolean("_alreadyFetchedServiceLocationEmployeeAssignment___");
			_serviceLocationEmployeeAssignment = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection)info.GetValue("_serviceLocationEmployeeAssignment", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection));
			_alwaysFetchServiceLocationEmployeeAssignment = info.GetBoolean("_alwaysFetchServiceLocationEmployeeAssignment");
			_alreadyFetchedServiceLocationEmployeeAssignment = info.GetBoolean("_alreadyFetchedServiceLocationEmployeeAssignment");
			_serviceLocationEmployeeAssignment_ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection)info.GetValue("_serviceLocationEmployeeAssignment_", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection));
			_alwaysFetchServiceLocationEmployeeAssignment_ = info.GetBoolean("_alwaysFetchServiceLocationEmployeeAssignment_");
			_alreadyFetchedServiceLocationEmployeeAssignment_ = info.GetBoolean("_alreadyFetchedServiceLocationEmployeeAssignment_");
			_serviceLocationEmployeeAssignment__ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection)info.GetValue("_serviceLocationEmployeeAssignment__", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection));
			_alwaysFetchServiceLocationEmployeeAssignment__ = info.GetBoolean("_alwaysFetchServiceLocationEmployeeAssignment__");
			_alreadyFetchedServiceLocationEmployeeAssignment__ = info.GetBoolean("_alreadyFetchedServiceLocationEmployeeAssignment__");
			_workOrder = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection)info.GetValue("_workOrder", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection));
			_alwaysFetchWorkOrder = info.GetBoolean("_alwaysFetchWorkOrder");
			_alreadyFetchedWorkOrder = info.GetBoolean("_alreadyFetchedWorkOrder");
			_accountCollectionViaAccountEmployeeAssignment_____ = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaAccountEmployeeAssignment_____", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment_____ = info.GetBoolean("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment_____");
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____ = info.GetBoolean("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____");
			_accountCollectionViaAccountEmployeeAssignment____ = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaAccountEmployeeAssignment____", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment____ = info.GetBoolean("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment____");
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____ = info.GetBoolean("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____");
			_accountCollectionViaWorkOrder = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaWorkOrder", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaWorkOrder = info.GetBoolean("_alwaysFetchAccountCollectionViaWorkOrder");
			_alreadyFetchedAccountCollectionViaWorkOrder = info.GetBoolean("_alreadyFetchedAccountCollectionViaWorkOrder");
			_accountCollectionViaAccountEmployeeAssignment______ = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaAccountEmployeeAssignment______", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment______ = info.GetBoolean("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment______");
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______ = info.GetBoolean("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______");
			_accountCollectionViaAccountEmployeeAssignment_ = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaAccountEmployeeAssignment_", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment_ = info.GetBoolean("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment_");
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_ = info.GetBoolean("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_");
			_accountCollectionViaAccountEmployeeAssignment = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaAccountEmployeeAssignment", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment = info.GetBoolean("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment");
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment = info.GetBoolean("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment");
			_accountCollectionViaAccountEmployeeAssignment___ = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaAccountEmployeeAssignment___", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment___ = info.GetBoolean("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment___");
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___ = info.GetBoolean("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___");
			_accountCollectionViaAccountEmployeeAssignment__ = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaAccountEmployeeAssignment__", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment__ = info.GetBoolean("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment__");
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__ = info.GetBoolean("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__");
			_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection)info.GetValue("_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection));
			_alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog");
			_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog");
			_deepFryerCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection)info.GetValue("_deepFryerCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection));
			_alwaysFetchDeepFryerCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchDeepFryerCollectionViaDeepFryerService");
			_alreadyFetchedDeepFryerCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedDeepFryerCollectionViaDeepFryerService");
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection)info.GetValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection));
			_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog");
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection)info.GetValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection));
			_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_");
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_");
			_recycleServiceCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection)info.GetValue("_recycleServiceCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection));
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction");
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction");
			_recycleServiceCollectionViaRecycleServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection)info.GetValue("_recycleServiceCollectionViaRecycleServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection));
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog");
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog");
			_recycleServiceCollectionViaRecycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection)info.GetValue("_recycleServiceCollectionViaRecycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection));
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_ = info.GetBoolean("_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_");
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_");
			_recycleTypeCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection)info.GetValue("_recycleTypeCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection));
			_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction");
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction");
			_recycleTypeCollectionViaRecycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection)info.GetValue("_recycleTypeCollectionViaRecycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection));
			_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_ = info.GetBoolean("_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_");
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_");
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment_", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_ = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_");
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_ = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_");
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment");
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment");
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_____");
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____");
			_serviceLocationCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog");
			_serviceLocationCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaDeepFryerService");
			_alreadyFetchedServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaDeepFryerService");
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment______ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment______", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment______ = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment______");
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______ = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______");
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment____ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment____", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment____ = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment____");
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____ = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____");
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment__ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment__", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment__ = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment__");
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__ = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__");
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment___ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment___", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment___ = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment___");
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___ = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___");
			_serviceLocationCollectionViaDeepFryerServiceChangeLog_ = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog_", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog_");
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_");
			_serviceTypeCollectionViaWorkOrder = (Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection)info.GetValue("_serviceTypeCollectionViaWorkOrder", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection));
			_alwaysFetchServiceTypeCollectionViaWorkOrder = info.GetBoolean("_alwaysFetchServiceTypeCollectionViaWorkOrder");
			_alreadyFetchedServiceTypeCollectionViaWorkOrder = info.GetBoolean("_alreadyFetchedServiceTypeCollectionViaWorkOrder");
			_statusCollectionViaLoad = (Reliant.RenuOil.DAL.CollectionClasses.StatusCollection)info.GetValue("_statusCollectionViaLoad", typeof(Reliant.RenuOil.DAL.CollectionClasses.StatusCollection));
			_alwaysFetchStatusCollectionViaLoad = info.GetBoolean("_alwaysFetchStatusCollectionViaLoad");
			_alreadyFetchedStatusCollectionViaLoad = info.GetBoolean("_alreadyFetchedStatusCollectionViaLoad");
			_userCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog");
			_userCollectionViaDeepFryerServiceChangeLog_ = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaDeepFryerServiceChangeLog_", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog_");
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_");
			_userCollectionViaRecycleServiceAction___ = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRecycleServiceAction___", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRecycleServiceAction___ = info.GetBoolean("_alwaysFetchUserCollectionViaRecycleServiceAction___");
			_alreadyFetchedUserCollectionViaRecycleServiceAction___ = info.GetBoolean("_alreadyFetchedUserCollectionViaRecycleServiceAction___");
			_userCollectionViaAssetReclamationServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaAssetReclamationServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog");
			_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog");
			_userCollectionViaRecycleServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRecycleServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alwaysFetchUserCollectionViaRecycleServiceChangeLog");
			_alreadyFetchedUserCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alreadyFetchedUserCollectionViaRecycleServiceChangeLog");
			_userCollectionViaRecycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRecycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRecycleServiceAction_ = info.GetBoolean("_alwaysFetchUserCollectionViaRecycleServiceAction_");
			_alreadyFetchedUserCollectionViaRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedUserCollectionViaRecycleServiceAction_");
			_userCollectionViaRecycleServiceAction__ = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRecycleServiceAction__", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRecycleServiceAction__ = info.GetBoolean("_alwaysFetchUserCollectionViaRecycleServiceAction__");
			_alreadyFetchedUserCollectionViaRecycleServiceAction__ = info.GetBoolean("_alreadyFetchedUserCollectionViaRecycleServiceAction__");
			_userCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchUserCollectionViaRecycleServiceAction");
			_alreadyFetchedUserCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedUserCollectionViaRecycleServiceAction");
			_workOrderEmployeeCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection)info.GetValue("_workOrderEmployeeCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection));
			_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService");
			_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService");
			_workOrderServiceLocationCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection)info.GetValue("_workOrderServiceLocationCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection));
			_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService");
			_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
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
		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedAccountEmployeeAssignment____ = (_accountEmployeeAssignment____.Count > 0);
			_alreadyFetchedAccountEmployeeAssignment_____ = (_accountEmployeeAssignment_____.Count > 0);
			_alreadyFetchedAccountEmployeeAssignment______ = (_accountEmployeeAssignment______.Count > 0);
			_alreadyFetchedAccountEmployeeAssignment___ = (_accountEmployeeAssignment___.Count > 0);
			_alreadyFetchedAccountEmployeeAssignment = (_accountEmployeeAssignment.Count > 0);
			_alreadyFetchedAccountEmployeeAssignment_ = (_accountEmployeeAssignment_.Count > 0);
			_alreadyFetchedAccountEmployeeAssignment__ = (_accountEmployeeAssignment__.Count > 0);
			_alreadyFetchedAssetReclamationServiceChangeLog = (_assetReclamationServiceChangeLog.Count > 0);
			_alreadyFetchedDeepFryerService = (_deepFryerService.Count > 0);
			_alreadyFetchedDeepFryerServiceChangeLog_ = (_deepFryerServiceChangeLog_.Count > 0);
			_alreadyFetchedDeepFryerServiceChangeLog = (_deepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedLoad = (_load.Count > 0);
			_alreadyFetchedRecycleServiceAction_ = (_recycleServiceAction_.Count > 0);
			_alreadyFetchedRecycleServiceAction = (_recycleServiceAction.Count > 0);
			_alreadyFetchedRecycleServiceChangeLog = (_recycleServiceChangeLog.Count > 0);
			_alreadyFetchedServiceLocationEmployeeAssignment____ = (_serviceLocationEmployeeAssignment____.Count > 0);
			_alreadyFetchedServiceLocationEmployeeAssignment_____ = (_serviceLocationEmployeeAssignment_____.Count > 0);
			_alreadyFetchedServiceLocationEmployeeAssignment______ = (_serviceLocationEmployeeAssignment______.Count > 0);
			_alreadyFetchedServiceLocationEmployeeAssignment___ = (_serviceLocationEmployeeAssignment___.Count > 0);
			_alreadyFetchedServiceLocationEmployeeAssignment = (_serviceLocationEmployeeAssignment.Count > 0);
			_alreadyFetchedServiceLocationEmployeeAssignment_ = (_serviceLocationEmployeeAssignment_.Count > 0);
			_alreadyFetchedServiceLocationEmployeeAssignment__ = (_serviceLocationEmployeeAssignment__.Count > 0);
			_alreadyFetchedWorkOrder = (_workOrder.Count > 0);
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____ = (_accountCollectionViaAccountEmployeeAssignment_____.Count > 0);
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____ = (_accountCollectionViaAccountEmployeeAssignment____.Count > 0);
			_alreadyFetchedAccountCollectionViaWorkOrder = (_accountCollectionViaWorkOrder.Count > 0);
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______ = (_accountCollectionViaAccountEmployeeAssignment______.Count > 0);
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_ = (_accountCollectionViaAccountEmployeeAssignment_.Count > 0);
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment = (_accountCollectionViaAccountEmployeeAssignment.Count > 0);
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___ = (_accountCollectionViaAccountEmployeeAssignment___.Count > 0);
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__ = (_accountCollectionViaAccountEmployeeAssignment__.Count > 0);
			_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = (_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.Count > 0);
			_alreadyFetchedDeepFryerCollectionViaDeepFryerService = (_deepFryerCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = (_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = (_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.Count > 0);
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = (_recycleServiceCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog = (_recycleServiceCollectionViaRecycleServiceChangeLog.Count > 0);
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ = (_recycleServiceCollectionViaRecycleServiceAction_.Count > 0);
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = (_recycleTypeCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ = (_recycleTypeCollectionViaRecycleServiceAction_.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_ = (_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment = (_serviceLocationCollectionViaServiceLocationEmployeeAssignment.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ = (_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = (_serviceLocationCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaDeepFryerService = (_serviceLocationCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______ = (_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____ = (_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__ = (_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___ = (_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_ = (_serviceLocationCollectionViaDeepFryerServiceChangeLog_.Count > 0);
			_alreadyFetchedServiceTypeCollectionViaWorkOrder = (_serviceTypeCollectionViaWorkOrder.Count > 0);
			_alreadyFetchedStatusCollectionViaLoad = (_statusCollectionViaLoad.Count > 0);
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = (_userCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_ = (_userCollectionViaDeepFryerServiceChangeLog_.Count > 0);
			_alreadyFetchedUserCollectionViaRecycleServiceAction___ = (_userCollectionViaRecycleServiceAction___.Count > 0);
			_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog = (_userCollectionViaAssetReclamationServiceChangeLog.Count > 0);
			_alreadyFetchedUserCollectionViaRecycleServiceChangeLog = (_userCollectionViaRecycleServiceChangeLog.Count > 0);
			_alreadyFetchedUserCollectionViaRecycleServiceAction_ = (_userCollectionViaRecycleServiceAction_.Count > 0);
			_alreadyFetchedUserCollectionViaRecycleServiceAction__ = (_userCollectionViaRecycleServiceAction__.Count > 0);
			_alreadyFetchedUserCollectionViaRecycleServiceAction = (_userCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = (_workOrderEmployeeCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = (_workOrderServiceLocationCollectionViaDeepFryerService.Count > 0);


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



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_accountEmployeeAssignment____", (!this.MarkedForDeletion?_accountEmployeeAssignment____:null));
			info.AddValue("_alwaysFetchAccountEmployeeAssignment____", _alwaysFetchAccountEmployeeAssignment____);
			info.AddValue("_alreadyFetchedAccountEmployeeAssignment____", _alreadyFetchedAccountEmployeeAssignment____);
			info.AddValue("_accountEmployeeAssignment_____", (!this.MarkedForDeletion?_accountEmployeeAssignment_____:null));
			info.AddValue("_alwaysFetchAccountEmployeeAssignment_____", _alwaysFetchAccountEmployeeAssignment_____);
			info.AddValue("_alreadyFetchedAccountEmployeeAssignment_____", _alreadyFetchedAccountEmployeeAssignment_____);
			info.AddValue("_accountEmployeeAssignment______", (!this.MarkedForDeletion?_accountEmployeeAssignment______:null));
			info.AddValue("_alwaysFetchAccountEmployeeAssignment______", _alwaysFetchAccountEmployeeAssignment______);
			info.AddValue("_alreadyFetchedAccountEmployeeAssignment______", _alreadyFetchedAccountEmployeeAssignment______);
			info.AddValue("_accountEmployeeAssignment___", (!this.MarkedForDeletion?_accountEmployeeAssignment___:null));
			info.AddValue("_alwaysFetchAccountEmployeeAssignment___", _alwaysFetchAccountEmployeeAssignment___);
			info.AddValue("_alreadyFetchedAccountEmployeeAssignment___", _alreadyFetchedAccountEmployeeAssignment___);
			info.AddValue("_accountEmployeeAssignment", (!this.MarkedForDeletion?_accountEmployeeAssignment:null));
			info.AddValue("_alwaysFetchAccountEmployeeAssignment", _alwaysFetchAccountEmployeeAssignment);
			info.AddValue("_alreadyFetchedAccountEmployeeAssignment", _alreadyFetchedAccountEmployeeAssignment);
			info.AddValue("_accountEmployeeAssignment_", (!this.MarkedForDeletion?_accountEmployeeAssignment_:null));
			info.AddValue("_alwaysFetchAccountEmployeeAssignment_", _alwaysFetchAccountEmployeeAssignment_);
			info.AddValue("_alreadyFetchedAccountEmployeeAssignment_", _alreadyFetchedAccountEmployeeAssignment_);
			info.AddValue("_accountEmployeeAssignment__", (!this.MarkedForDeletion?_accountEmployeeAssignment__:null));
			info.AddValue("_alwaysFetchAccountEmployeeAssignment__", _alwaysFetchAccountEmployeeAssignment__);
			info.AddValue("_alreadyFetchedAccountEmployeeAssignment__", _alreadyFetchedAccountEmployeeAssignment__);
			info.AddValue("_assetReclamationServiceChangeLog", (!this.MarkedForDeletion?_assetReclamationServiceChangeLog:null));
			info.AddValue("_alwaysFetchAssetReclamationServiceChangeLog", _alwaysFetchAssetReclamationServiceChangeLog);
			info.AddValue("_alreadyFetchedAssetReclamationServiceChangeLog", _alreadyFetchedAssetReclamationServiceChangeLog);
			info.AddValue("_deepFryerService", (!this.MarkedForDeletion?_deepFryerService:null));
			info.AddValue("_alwaysFetchDeepFryerService", _alwaysFetchDeepFryerService);
			info.AddValue("_alreadyFetchedDeepFryerService", _alreadyFetchedDeepFryerService);
			info.AddValue("_deepFryerServiceChangeLog_", (!this.MarkedForDeletion?_deepFryerServiceChangeLog_:null));
			info.AddValue("_alwaysFetchDeepFryerServiceChangeLog_", _alwaysFetchDeepFryerServiceChangeLog_);
			info.AddValue("_alreadyFetchedDeepFryerServiceChangeLog_", _alreadyFetchedDeepFryerServiceChangeLog_);
			info.AddValue("_deepFryerServiceChangeLog", (!this.MarkedForDeletion?_deepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchDeepFryerServiceChangeLog", _alwaysFetchDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedDeepFryerServiceChangeLog", _alreadyFetchedDeepFryerServiceChangeLog);
			info.AddValue("_load", (!this.MarkedForDeletion?_load:null));
			info.AddValue("_alwaysFetchLoad", _alwaysFetchLoad);
			info.AddValue("_alreadyFetchedLoad", _alreadyFetchedLoad);
			info.AddValue("_recycleServiceAction_", (!this.MarkedForDeletion?_recycleServiceAction_:null));
			info.AddValue("_alwaysFetchRecycleServiceAction_", _alwaysFetchRecycleServiceAction_);
			info.AddValue("_alreadyFetchedRecycleServiceAction_", _alreadyFetchedRecycleServiceAction_);
			info.AddValue("_recycleServiceAction", (!this.MarkedForDeletion?_recycleServiceAction:null));
			info.AddValue("_alwaysFetchRecycleServiceAction", _alwaysFetchRecycleServiceAction);
			info.AddValue("_alreadyFetchedRecycleServiceAction", _alreadyFetchedRecycleServiceAction);
			info.AddValue("_recycleServiceChangeLog", (!this.MarkedForDeletion?_recycleServiceChangeLog:null));
			info.AddValue("_alwaysFetchRecycleServiceChangeLog", _alwaysFetchRecycleServiceChangeLog);
			info.AddValue("_alreadyFetchedRecycleServiceChangeLog", _alreadyFetchedRecycleServiceChangeLog);
			info.AddValue("_serviceLocationEmployeeAssignment____", (!this.MarkedForDeletion?_serviceLocationEmployeeAssignment____:null));
			info.AddValue("_alwaysFetchServiceLocationEmployeeAssignment____", _alwaysFetchServiceLocationEmployeeAssignment____);
			info.AddValue("_alreadyFetchedServiceLocationEmployeeAssignment____", _alreadyFetchedServiceLocationEmployeeAssignment____);
			info.AddValue("_serviceLocationEmployeeAssignment_____", (!this.MarkedForDeletion?_serviceLocationEmployeeAssignment_____:null));
			info.AddValue("_alwaysFetchServiceLocationEmployeeAssignment_____", _alwaysFetchServiceLocationEmployeeAssignment_____);
			info.AddValue("_alreadyFetchedServiceLocationEmployeeAssignment_____", _alreadyFetchedServiceLocationEmployeeAssignment_____);
			info.AddValue("_serviceLocationEmployeeAssignment______", (!this.MarkedForDeletion?_serviceLocationEmployeeAssignment______:null));
			info.AddValue("_alwaysFetchServiceLocationEmployeeAssignment______", _alwaysFetchServiceLocationEmployeeAssignment______);
			info.AddValue("_alreadyFetchedServiceLocationEmployeeAssignment______", _alreadyFetchedServiceLocationEmployeeAssignment______);
			info.AddValue("_serviceLocationEmployeeAssignment___", (!this.MarkedForDeletion?_serviceLocationEmployeeAssignment___:null));
			info.AddValue("_alwaysFetchServiceLocationEmployeeAssignment___", _alwaysFetchServiceLocationEmployeeAssignment___);
			info.AddValue("_alreadyFetchedServiceLocationEmployeeAssignment___", _alreadyFetchedServiceLocationEmployeeAssignment___);
			info.AddValue("_serviceLocationEmployeeAssignment", (!this.MarkedForDeletion?_serviceLocationEmployeeAssignment:null));
			info.AddValue("_alwaysFetchServiceLocationEmployeeAssignment", _alwaysFetchServiceLocationEmployeeAssignment);
			info.AddValue("_alreadyFetchedServiceLocationEmployeeAssignment", _alreadyFetchedServiceLocationEmployeeAssignment);
			info.AddValue("_serviceLocationEmployeeAssignment_", (!this.MarkedForDeletion?_serviceLocationEmployeeAssignment_:null));
			info.AddValue("_alwaysFetchServiceLocationEmployeeAssignment_", _alwaysFetchServiceLocationEmployeeAssignment_);
			info.AddValue("_alreadyFetchedServiceLocationEmployeeAssignment_", _alreadyFetchedServiceLocationEmployeeAssignment_);
			info.AddValue("_serviceLocationEmployeeAssignment__", (!this.MarkedForDeletion?_serviceLocationEmployeeAssignment__:null));
			info.AddValue("_alwaysFetchServiceLocationEmployeeAssignment__", _alwaysFetchServiceLocationEmployeeAssignment__);
			info.AddValue("_alreadyFetchedServiceLocationEmployeeAssignment__", _alreadyFetchedServiceLocationEmployeeAssignment__);
			info.AddValue("_workOrder", (!this.MarkedForDeletion?_workOrder:null));
			info.AddValue("_alwaysFetchWorkOrder", _alwaysFetchWorkOrder);
			info.AddValue("_alreadyFetchedWorkOrder", _alreadyFetchedWorkOrder);
			info.AddValue("_accountCollectionViaAccountEmployeeAssignment_____", (!this.MarkedForDeletion?_accountCollectionViaAccountEmployeeAssignment_____:null));
			info.AddValue("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment_____", _alwaysFetchAccountCollectionViaAccountEmployeeAssignment_____);
			info.AddValue("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____", _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____);
			info.AddValue("_accountCollectionViaAccountEmployeeAssignment____", (!this.MarkedForDeletion?_accountCollectionViaAccountEmployeeAssignment____:null));
			info.AddValue("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment____", _alwaysFetchAccountCollectionViaAccountEmployeeAssignment____);
			info.AddValue("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____", _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____);
			info.AddValue("_accountCollectionViaWorkOrder", (!this.MarkedForDeletion?_accountCollectionViaWorkOrder:null));
			info.AddValue("_alwaysFetchAccountCollectionViaWorkOrder", _alwaysFetchAccountCollectionViaWorkOrder);
			info.AddValue("_alreadyFetchedAccountCollectionViaWorkOrder", _alreadyFetchedAccountCollectionViaWorkOrder);
			info.AddValue("_accountCollectionViaAccountEmployeeAssignment______", (!this.MarkedForDeletion?_accountCollectionViaAccountEmployeeAssignment______:null));
			info.AddValue("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment______", _alwaysFetchAccountCollectionViaAccountEmployeeAssignment______);
			info.AddValue("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______", _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______);
			info.AddValue("_accountCollectionViaAccountEmployeeAssignment_", (!this.MarkedForDeletion?_accountCollectionViaAccountEmployeeAssignment_:null));
			info.AddValue("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment_", _alwaysFetchAccountCollectionViaAccountEmployeeAssignment_);
			info.AddValue("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_", _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_);
			info.AddValue("_accountCollectionViaAccountEmployeeAssignment", (!this.MarkedForDeletion?_accountCollectionViaAccountEmployeeAssignment:null));
			info.AddValue("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment", _alwaysFetchAccountCollectionViaAccountEmployeeAssignment);
			info.AddValue("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment", _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment);
			info.AddValue("_accountCollectionViaAccountEmployeeAssignment___", (!this.MarkedForDeletion?_accountCollectionViaAccountEmployeeAssignment___:null));
			info.AddValue("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment___", _alwaysFetchAccountCollectionViaAccountEmployeeAssignment___);
			info.AddValue("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___", _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___);
			info.AddValue("_accountCollectionViaAccountEmployeeAssignment__", (!this.MarkedForDeletion?_accountCollectionViaAccountEmployeeAssignment__:null));
			info.AddValue("_alwaysFetchAccountCollectionViaAccountEmployeeAssignment__", _alwaysFetchAccountCollectionViaAccountEmployeeAssignment__);
			info.AddValue("_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__", _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__);
			info.AddValue("_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", (!this.MarkedForDeletion?_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog:null));
			info.AddValue("_alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", _alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", _alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_deepFryerCollectionViaDeepFryerService", (!this.MarkedForDeletion?_deepFryerCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchDeepFryerCollectionViaDeepFryerService", _alwaysFetchDeepFryerCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedDeepFryerCollectionViaDeepFryerService", _alreadyFetchedDeepFryerCollectionViaDeepFryerService);
			info.AddValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_deepFryerServiceCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog", _alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_", (!this.MarkedForDeletion?_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_:null));
			info.AddValue("_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_", _alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_", _alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_recycleServiceCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_recycleServiceCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction", _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction", _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction);
			info.AddValue("_recycleServiceCollectionViaRecycleServiceChangeLog", (!this.MarkedForDeletion?_recycleServiceCollectionViaRecycleServiceChangeLog:null));
			info.AddValue("_alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog", _alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog);
			info.AddValue("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog", _alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog);
			info.AddValue("_recycleServiceCollectionViaRecycleServiceAction_", (!this.MarkedForDeletion?_recycleServiceCollectionViaRecycleServiceAction_:null));
			info.AddValue("_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_", _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_);
			info.AddValue("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_", _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_);
			info.AddValue("_recycleTypeCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_recycleTypeCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction", _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction", _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction);
			info.AddValue("_recycleTypeCollectionViaRecycleServiceAction_", (!this.MarkedForDeletion?_recycleTypeCollectionViaRecycleServiceAction_:null));
			info.AddValue("_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_", _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_);
			info.AddValue("_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_", _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_);
			info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment_", (!this.MarkedForDeletion?_serviceLocationCollectionViaServiceLocationEmployeeAssignment_:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_", _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_", _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_);
			info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment", (!this.MarkedForDeletion?_serviceLocationCollectionViaServiceLocationEmployeeAssignment:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment", _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment", _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment);
			info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____", (!this.MarkedForDeletion?_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_____", _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_____);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____", _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____);
			info.AddValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_serviceLocationCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog", _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_serviceLocationCollectionViaDeepFryerService", (!this.MarkedForDeletion?_serviceLocationCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaDeepFryerService", _alwaysFetchServiceLocationCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaDeepFryerService", _alreadyFetchedServiceLocationCollectionViaDeepFryerService);
			info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment______", (!this.MarkedForDeletion?_serviceLocationCollectionViaServiceLocationEmployeeAssignment______:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment______", _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment______);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______", _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______);
			info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment____", (!this.MarkedForDeletion?_serviceLocationCollectionViaServiceLocationEmployeeAssignment____:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment____", _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment____);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____", _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____);
			info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment__", (!this.MarkedForDeletion?_serviceLocationCollectionViaServiceLocationEmployeeAssignment__:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment__", _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment__);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__", _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__);
			info.AddValue("_serviceLocationCollectionViaServiceLocationEmployeeAssignment___", (!this.MarkedForDeletion?_serviceLocationCollectionViaServiceLocationEmployeeAssignment___:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment___", _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment___);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___", _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___);
			info.AddValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog_", (!this.MarkedForDeletion?_serviceLocationCollectionViaDeepFryerServiceChangeLog_:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog_", _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_", _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_serviceTypeCollectionViaWorkOrder", (!this.MarkedForDeletion?_serviceTypeCollectionViaWorkOrder:null));
			info.AddValue("_alwaysFetchServiceTypeCollectionViaWorkOrder", _alwaysFetchServiceTypeCollectionViaWorkOrder);
			info.AddValue("_alreadyFetchedServiceTypeCollectionViaWorkOrder", _alreadyFetchedServiceTypeCollectionViaWorkOrder);
			info.AddValue("_statusCollectionViaLoad", (!this.MarkedForDeletion?_statusCollectionViaLoad:null));
			info.AddValue("_alwaysFetchStatusCollectionViaLoad", _alwaysFetchStatusCollectionViaLoad);
			info.AddValue("_alreadyFetchedStatusCollectionViaLoad", _alreadyFetchedStatusCollectionViaLoad);
			info.AddValue("_userCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_userCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog", _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_userCollectionViaDeepFryerServiceChangeLog_", (!this.MarkedForDeletion?_userCollectionViaDeepFryerServiceChangeLog_:null));
			info.AddValue("_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog_", _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_", _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_userCollectionViaRecycleServiceAction___", (!this.MarkedForDeletion?_userCollectionViaRecycleServiceAction___:null));
			info.AddValue("_alwaysFetchUserCollectionViaRecycleServiceAction___", _alwaysFetchUserCollectionViaRecycleServiceAction___);
			info.AddValue("_alreadyFetchedUserCollectionViaRecycleServiceAction___", _alreadyFetchedUserCollectionViaRecycleServiceAction___);
			info.AddValue("_userCollectionViaAssetReclamationServiceChangeLog", (!this.MarkedForDeletion?_userCollectionViaAssetReclamationServiceChangeLog:null));
			info.AddValue("_alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog", _alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog", _alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_userCollectionViaRecycleServiceChangeLog", (!this.MarkedForDeletion?_userCollectionViaRecycleServiceChangeLog:null));
			info.AddValue("_alwaysFetchUserCollectionViaRecycleServiceChangeLog", _alwaysFetchUserCollectionViaRecycleServiceChangeLog);
			info.AddValue("_alreadyFetchedUserCollectionViaRecycleServiceChangeLog", _alreadyFetchedUserCollectionViaRecycleServiceChangeLog);
			info.AddValue("_userCollectionViaRecycleServiceAction_", (!this.MarkedForDeletion?_userCollectionViaRecycleServiceAction_:null));
			info.AddValue("_alwaysFetchUserCollectionViaRecycleServiceAction_", _alwaysFetchUserCollectionViaRecycleServiceAction_);
			info.AddValue("_alreadyFetchedUserCollectionViaRecycleServiceAction_", _alreadyFetchedUserCollectionViaRecycleServiceAction_);
			info.AddValue("_userCollectionViaRecycleServiceAction__", (!this.MarkedForDeletion?_userCollectionViaRecycleServiceAction__:null));
			info.AddValue("_alwaysFetchUserCollectionViaRecycleServiceAction__", _alwaysFetchUserCollectionViaRecycleServiceAction__);
			info.AddValue("_alreadyFetchedUserCollectionViaRecycleServiceAction__", _alreadyFetchedUserCollectionViaRecycleServiceAction__);
			info.AddValue("_userCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_userCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchUserCollectionViaRecycleServiceAction", _alwaysFetchUserCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedUserCollectionViaRecycleServiceAction", _alreadyFetchedUserCollectionViaRecycleServiceAction);
			info.AddValue("_workOrderEmployeeCollectionViaDeepFryerService", (!this.MarkedForDeletion?_workOrderEmployeeCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService", _alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService", _alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService);
			info.AddValue("_workOrderServiceLocationCollectionViaDeepFryerService", (!this.MarkedForDeletion?_workOrderServiceLocationCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService", _alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService", _alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService);


			
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

				case "AccountEmployeeAssignment____":
					_alreadyFetchedAccountEmployeeAssignment____ = true;
					if(entity!=null)
					{
						this.AccountEmployeeAssignment____.Add((AccountEmployeeAssignmentEntity)entity);
					}
					break;
				case "AccountEmployeeAssignment_____":
					_alreadyFetchedAccountEmployeeAssignment_____ = true;
					if(entity!=null)
					{
						this.AccountEmployeeAssignment_____.Add((AccountEmployeeAssignmentEntity)entity);
					}
					break;
				case "AccountEmployeeAssignment______":
					_alreadyFetchedAccountEmployeeAssignment______ = true;
					if(entity!=null)
					{
						this.AccountEmployeeAssignment______.Add((AccountEmployeeAssignmentEntity)entity);
					}
					break;
				case "AccountEmployeeAssignment___":
					_alreadyFetchedAccountEmployeeAssignment___ = true;
					if(entity!=null)
					{
						this.AccountEmployeeAssignment___.Add((AccountEmployeeAssignmentEntity)entity);
					}
					break;
				case "AccountEmployeeAssignment":
					_alreadyFetchedAccountEmployeeAssignment = true;
					if(entity!=null)
					{
						this.AccountEmployeeAssignment.Add((AccountEmployeeAssignmentEntity)entity);
					}
					break;
				case "AccountEmployeeAssignment_":
					_alreadyFetchedAccountEmployeeAssignment_ = true;
					if(entity!=null)
					{
						this.AccountEmployeeAssignment_.Add((AccountEmployeeAssignmentEntity)entity);
					}
					break;
				case "AccountEmployeeAssignment__":
					_alreadyFetchedAccountEmployeeAssignment__ = true;
					if(entity!=null)
					{
						this.AccountEmployeeAssignment__.Add((AccountEmployeeAssignmentEntity)entity);
					}
					break;
				case "AssetReclamationServiceChangeLog":
					_alreadyFetchedAssetReclamationServiceChangeLog = true;
					if(entity!=null)
					{
						this.AssetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)entity);
					}
					break;
				case "DeepFryerService":
					_alreadyFetchedDeepFryerService = true;
					if(entity!=null)
					{
						this.DeepFryerService.Add((DeepFryerServiceEntity)entity);
					}
					break;
				case "DeepFryerServiceChangeLog_":
					_alreadyFetchedDeepFryerServiceChangeLog_ = true;
					if(entity!=null)
					{
						this.DeepFryerServiceChangeLog_.Add((DeepFryerServiceChangeLogEntity)entity);
					}
					break;
				case "DeepFryerServiceChangeLog":
					_alreadyFetchedDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)entity);
					}
					break;
				case "Load":
					_alreadyFetchedLoad = true;
					if(entity!=null)
					{
						this.Load.Add((LoadEntity)entity);
					}
					break;
				case "RecycleServiceAction_":
					_alreadyFetchedRecycleServiceAction_ = true;
					if(entity!=null)
					{
						this.RecycleServiceAction_.Add((RecycleServiceActionEntity)entity);
					}
					break;
				case "RecycleServiceAction":
					_alreadyFetchedRecycleServiceAction = true;
					if(entity!=null)
					{
						this.RecycleServiceAction.Add((RecycleServiceActionEntity)entity);
					}
					break;
				case "RecycleServiceChangeLog":
					_alreadyFetchedRecycleServiceChangeLog = true;
					if(entity!=null)
					{
						this.RecycleServiceChangeLog.Add((RecycleServiceChangeLogEntity)entity);
					}
					break;
				case "ServiceLocationEmployeeAssignment____":
					_alreadyFetchedServiceLocationEmployeeAssignment____ = true;
					if(entity!=null)
					{
						this.ServiceLocationEmployeeAssignment____.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					}
					break;
				case "ServiceLocationEmployeeAssignment_____":
					_alreadyFetchedServiceLocationEmployeeAssignment_____ = true;
					if(entity!=null)
					{
						this.ServiceLocationEmployeeAssignment_____.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					}
					break;
				case "ServiceLocationEmployeeAssignment______":
					_alreadyFetchedServiceLocationEmployeeAssignment______ = true;
					if(entity!=null)
					{
						this.ServiceLocationEmployeeAssignment______.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					}
					break;
				case "ServiceLocationEmployeeAssignment___":
					_alreadyFetchedServiceLocationEmployeeAssignment___ = true;
					if(entity!=null)
					{
						this.ServiceLocationEmployeeAssignment___.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					}
					break;
				case "ServiceLocationEmployeeAssignment":
					_alreadyFetchedServiceLocationEmployeeAssignment = true;
					if(entity!=null)
					{
						this.ServiceLocationEmployeeAssignment.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					}
					break;
				case "ServiceLocationEmployeeAssignment_":
					_alreadyFetchedServiceLocationEmployeeAssignment_ = true;
					if(entity!=null)
					{
						this.ServiceLocationEmployeeAssignment_.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					}
					break;
				case "ServiceLocationEmployeeAssignment__":
					_alreadyFetchedServiceLocationEmployeeAssignment__ = true;
					if(entity!=null)
					{
						this.ServiceLocationEmployeeAssignment__.Add((ServiceLocationEmployeeAssignmentEntity)entity);
					}
					break;
				case "WorkOrder":
					_alreadyFetchedWorkOrder = true;
					if(entity!=null)
					{
						this.WorkOrder.Add((WorkOrderEntity)entity);
					}
					break;
				case "AccountCollectionViaAccountEmployeeAssignment_____":
					_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____ = true;
					if(entity!=null)
					{
						this.AccountCollectionViaAccountEmployeeAssignment_____.Add((AccountEntity)entity);
					}
					break;
				case "AccountCollectionViaAccountEmployeeAssignment____":
					_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____ = true;
					if(entity!=null)
					{
						this.AccountCollectionViaAccountEmployeeAssignment____.Add((AccountEntity)entity);
					}
					break;
				case "AccountCollectionViaWorkOrder":
					_alreadyFetchedAccountCollectionViaWorkOrder = true;
					if(entity!=null)
					{
						this.AccountCollectionViaWorkOrder.Add((AccountEntity)entity);
					}
					break;
				case "AccountCollectionViaAccountEmployeeAssignment______":
					_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______ = true;
					if(entity!=null)
					{
						this.AccountCollectionViaAccountEmployeeAssignment______.Add((AccountEntity)entity);
					}
					break;
				case "AccountCollectionViaAccountEmployeeAssignment_":
					_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_ = true;
					if(entity!=null)
					{
						this.AccountCollectionViaAccountEmployeeAssignment_.Add((AccountEntity)entity);
					}
					break;
				case "AccountCollectionViaAccountEmployeeAssignment":
					_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment = true;
					if(entity!=null)
					{
						this.AccountCollectionViaAccountEmployeeAssignment.Add((AccountEntity)entity);
					}
					break;
				case "AccountCollectionViaAccountEmployeeAssignment___":
					_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___ = true;
					if(entity!=null)
					{
						this.AccountCollectionViaAccountEmployeeAssignment___.Add((AccountEntity)entity);
					}
					break;
				case "AccountCollectionViaAccountEmployeeAssignment__":
					_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__ = true;
					if(entity!=null)
					{
						this.AccountCollectionViaAccountEmployeeAssignment__.Add((AccountEntity)entity);
					}
					break;
				case "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog":
					_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = true;
					if(entity!=null)
					{
						this.AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.Add((AssetReclamationServiceEntity)entity);
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
				case "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_":
					_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = true;
					if(entity!=null)
					{
						this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_.Add((DeepFryerServiceEntity)entity);
					}
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction":
					_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = true;
					if(entity!=null)
					{
						this.RecycleServiceCollectionViaRecycleServiceAction.Add((RecycleServiceEntity)entity);
					}
					break;
				case "RecycleServiceCollectionViaRecycleServiceChangeLog":
					_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog = true;
					if(entity!=null)
					{
						this.RecycleServiceCollectionViaRecycleServiceChangeLog.Add((RecycleServiceEntity)entity);
					}
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction_":
					_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ = true;
					if(entity!=null)
					{
						this.RecycleServiceCollectionViaRecycleServiceAction_.Add((RecycleServiceEntity)entity);
					}
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction":
					_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = true;
					if(entity!=null)
					{
						this.RecycleTypeCollectionViaRecycleServiceAction.Add((RecycleTypeEntity)entity);
					}
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction_":
					_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ = true;
					if(entity!=null)
					{
						this.RecycleTypeCollectionViaRecycleServiceAction_.Add((RecycleTypeEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_":
					_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_ = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment_.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment":
					_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____":
					_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaDeepFryerService":
					_alreadyFetchedServiceLocationCollectionViaDeepFryerService = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaDeepFryerService.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment______":
					_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______ = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment______.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment____":
					_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____ = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment____.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment__":
					_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__ = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment__.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaServiceLocationEmployeeAssignment___":
					_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___ = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaServiceLocationEmployeeAssignment___.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog_":
					_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_ = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaDeepFryerServiceChangeLog_.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceTypeCollectionViaWorkOrder":
					_alreadyFetchedServiceTypeCollectionViaWorkOrder = true;
					if(entity!=null)
					{
						this.ServiceTypeCollectionViaWorkOrder.Add((ServiceTypeEntity)entity);
					}
					break;
				case "StatusCollectionViaLoad":
					_alreadyFetchedStatusCollectionViaLoad = true;
					if(entity!=null)
					{
						this.StatusCollectionViaLoad.Add((StatusEntity)entity);
					}
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.UserCollectionViaDeepFryerServiceChangeLog.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog_":
					_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_ = true;
					if(entity!=null)
					{
						this.UserCollectionViaDeepFryerServiceChangeLog_.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaRecycleServiceAction___":
					_alreadyFetchedUserCollectionViaRecycleServiceAction___ = true;
					if(entity!=null)
					{
						this.UserCollectionViaRecycleServiceAction___.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaAssetReclamationServiceChangeLog":
					_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog = true;
					if(entity!=null)
					{
						this.UserCollectionViaAssetReclamationServiceChangeLog.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaRecycleServiceChangeLog":
					_alreadyFetchedUserCollectionViaRecycleServiceChangeLog = true;
					if(entity!=null)
					{
						this.UserCollectionViaRecycleServiceChangeLog.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaRecycleServiceAction_":
					_alreadyFetchedUserCollectionViaRecycleServiceAction_ = true;
					if(entity!=null)
					{
						this.UserCollectionViaRecycleServiceAction_.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaRecycleServiceAction__":
					_alreadyFetchedUserCollectionViaRecycleServiceAction__ = true;
					if(entity!=null)
					{
						this.UserCollectionViaRecycleServiceAction__.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaRecycleServiceAction":
					_alreadyFetchedUserCollectionViaRecycleServiceAction = true;
					if(entity!=null)
					{
						this.UserCollectionViaRecycleServiceAction.Add((UserEntity)entity);
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

				case "AccountEmployeeAssignment____":
					_accountEmployeeAssignment____.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment_____":
					_accountEmployeeAssignment_____.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment______":
					_accountEmployeeAssignment______.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment___":
					_accountEmployeeAssignment___.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment":
					_accountEmployeeAssignment.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment_":
					_accountEmployeeAssignment_.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AccountEmployeeAssignment__":
					_accountEmployeeAssignment__.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "AssetReclamationServiceChangeLog":
					_assetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)relatedEntity);
					break;
				case "DeepFryerService":
					_deepFryerService.Add((DeepFryerServiceEntity)relatedEntity);
					break;
				case "DeepFryerServiceChangeLog_":
					_deepFryerServiceChangeLog_.Add((DeepFryerServiceChangeLogEntity)relatedEntity);
					break;
				case "DeepFryerServiceChangeLog":
					_deepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)relatedEntity);
					break;
				case "Load":
					_load.Add((LoadEntity)relatedEntity);
					break;
				case "RecycleServiceAction_":
					_recycleServiceAction_.Add((RecycleServiceActionEntity)relatedEntity);
					break;
				case "RecycleServiceAction":
					_recycleServiceAction.Add((RecycleServiceActionEntity)relatedEntity);
					break;
				case "RecycleServiceChangeLog":
					_recycleServiceChangeLog.Add((RecycleServiceChangeLogEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment____":
					_serviceLocationEmployeeAssignment____.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment_____":
					_serviceLocationEmployeeAssignment_____.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment______":
					_serviceLocationEmployeeAssignment______.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment___":
					_serviceLocationEmployeeAssignment___.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment":
					_serviceLocationEmployeeAssignment.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment_":
					_serviceLocationEmployeeAssignment_.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "ServiceLocationEmployeeAssignment__":
					_serviceLocationEmployeeAssignment__.Add((ServiceLocationEmployeeAssignmentEntity)relatedEntity);
					break;
				case "WorkOrder":
					_workOrder.Add((WorkOrderEntity)relatedEntity);
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

				case "AccountEmployeeAssignment____":
					base.PerformRelatedEntityRemoval(_accountEmployeeAssignment____, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment_____":
					base.PerformRelatedEntityRemoval(_accountEmployeeAssignment_____, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment______":
					base.PerformRelatedEntityRemoval(_accountEmployeeAssignment______, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment___":
					base.PerformRelatedEntityRemoval(_accountEmployeeAssignment___, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment":
					base.PerformRelatedEntityRemoval(_accountEmployeeAssignment, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment_":
					base.PerformRelatedEntityRemoval(_accountEmployeeAssignment_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AccountEmployeeAssignment__":
					base.PerformRelatedEntityRemoval(_accountEmployeeAssignment__, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "AssetReclamationServiceChangeLog":
					base.PerformRelatedEntityRemoval(_assetReclamationServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerService":
					base.PerformRelatedEntityRemoval(_deepFryerService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerServiceChangeLog_":
					base.PerformRelatedEntityRemoval(_deepFryerServiceChangeLog_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerServiceChangeLog":
					base.PerformRelatedEntityRemoval(_deepFryerServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Load":
					base.PerformRelatedEntityRemoval(_load, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleServiceAction_":
					base.PerformRelatedEntityRemoval(_recycleServiceAction_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleServiceAction":
					base.PerformRelatedEntityRemoval(_recycleServiceAction, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleServiceChangeLog":
					base.PerformRelatedEntityRemoval(_recycleServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment____":
					base.PerformRelatedEntityRemoval(_serviceLocationEmployeeAssignment____, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment_____":
					base.PerformRelatedEntityRemoval(_serviceLocationEmployeeAssignment_____, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment______":
					base.PerformRelatedEntityRemoval(_serviceLocationEmployeeAssignment______, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment___":
					base.PerformRelatedEntityRemoval(_serviceLocationEmployeeAssignment___, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment":
					base.PerformRelatedEntityRemoval(_serviceLocationEmployeeAssignment, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment_":
					base.PerformRelatedEntityRemoval(_serviceLocationEmployeeAssignment_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationEmployeeAssignment__":
					base.PerformRelatedEntityRemoval(_serviceLocationEmployeeAssignment__, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrder":
					base.PerformRelatedEntityRemoval(_workOrder, relatedEntity, signalRelatedEntityManyToOne);
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



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_accountEmployeeAssignment____);
			toReturn.Add(_accountEmployeeAssignment_____);
			toReturn.Add(_accountEmployeeAssignment______);
			toReturn.Add(_accountEmployeeAssignment___);
			toReturn.Add(_accountEmployeeAssignment);
			toReturn.Add(_accountEmployeeAssignment_);
			toReturn.Add(_accountEmployeeAssignment__);
			toReturn.Add(_assetReclamationServiceChangeLog);
			toReturn.Add(_deepFryerService);
			toReturn.Add(_deepFryerServiceChangeLog_);
			toReturn.Add(_deepFryerServiceChangeLog);
			toReturn.Add(_load);
			toReturn.Add(_recycleServiceAction_);
			toReturn.Add(_recycleServiceAction);
			toReturn.Add(_recycleServiceChangeLog);
			toReturn.Add(_serviceLocationEmployeeAssignment____);
			toReturn.Add(_serviceLocationEmployeeAssignment_____);
			toReturn.Add(_serviceLocationEmployeeAssignment______);
			toReturn.Add(_serviceLocationEmployeeAssignment___);
			toReturn.Add(_serviceLocationEmployeeAssignment);
			toReturn.Add(_serviceLocationEmployeeAssignment_);
			toReturn.Add(_serviceLocationEmployeeAssignment__);
			toReturn.Add(_workOrder);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId)
		{
			return FetchUsingPK(employeeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(employeeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(employeeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(employeeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.EmployeeId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
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


		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment____(bool forceFetch)
		{
			return GetMultiAccountEmployeeAssignment____(forceFetch, _accountEmployeeAssignment____.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment____(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAccountEmployeeAssignment____(forceFetch, _accountEmployeeAssignment____.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAccountEmployeeAssignment____(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment____(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAccountEmployeeAssignment____ || forceFetch || _alwaysFetchAccountEmployeeAssignment____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountEmployeeAssignment____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountEmployeeAssignment____);
					}
				}
				_accountEmployeeAssignment____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountEmployeeAssignment____.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountEmployeeAssignment____.GetMultiManyToOne(null, this, null, null, null, null, null, null, filter);
				_accountEmployeeAssignment____.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountEmployeeAssignment____ = true;
			}
			return _accountEmployeeAssignment____;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountEmployeeAssignment____'. These settings will be taken into account
		/// when the property AccountEmployeeAssignment____ is requested or GetMultiAccountEmployeeAssignment____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountEmployeeAssignment____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountEmployeeAssignment____.SortClauses=sortClauses;
			_accountEmployeeAssignment____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment_____(bool forceFetch)
		{
			return GetMultiAccountEmployeeAssignment_____(forceFetch, _accountEmployeeAssignment_____.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment_____(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAccountEmployeeAssignment_____(forceFetch, _accountEmployeeAssignment_____.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment_____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAccountEmployeeAssignment_____(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment_____(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAccountEmployeeAssignment_____ || forceFetch || _alwaysFetchAccountEmployeeAssignment_____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountEmployeeAssignment_____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountEmployeeAssignment_____);
					}
				}
				_accountEmployeeAssignment_____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountEmployeeAssignment_____.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountEmployeeAssignment_____.GetMultiManyToOne(null, null, this, null, null, null, null, null, filter);
				_accountEmployeeAssignment_____.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountEmployeeAssignment_____ = true;
			}
			return _accountEmployeeAssignment_____;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountEmployeeAssignment_____'. These settings will be taken into account
		/// when the property AccountEmployeeAssignment_____ is requested or GetMultiAccountEmployeeAssignment_____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountEmployeeAssignment_____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountEmployeeAssignment_____.SortClauses=sortClauses;
			_accountEmployeeAssignment_____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment______(bool forceFetch)
		{
			return GetMultiAccountEmployeeAssignment______(forceFetch, _accountEmployeeAssignment______.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment______(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAccountEmployeeAssignment______(forceFetch, _accountEmployeeAssignment______.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment______(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAccountEmployeeAssignment______(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment______(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAccountEmployeeAssignment______ || forceFetch || _alwaysFetchAccountEmployeeAssignment______) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountEmployeeAssignment______.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountEmployeeAssignment______);
					}
				}
				_accountEmployeeAssignment______.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountEmployeeAssignment______.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountEmployeeAssignment______.GetMultiManyToOne(null, null, null, this, null, null, null, null, filter);
				_accountEmployeeAssignment______.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountEmployeeAssignment______ = true;
			}
			return _accountEmployeeAssignment______;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountEmployeeAssignment______'. These settings will be taken into account
		/// when the property AccountEmployeeAssignment______ is requested or GetMultiAccountEmployeeAssignment______ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountEmployeeAssignment______(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountEmployeeAssignment______.SortClauses=sortClauses;
			_accountEmployeeAssignment______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment___(bool forceFetch)
		{
			return GetMultiAccountEmployeeAssignment___(forceFetch, _accountEmployeeAssignment___.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment___(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAccountEmployeeAssignment___(forceFetch, _accountEmployeeAssignment___.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAccountEmployeeAssignment___(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment___(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAccountEmployeeAssignment___ || forceFetch || _alwaysFetchAccountEmployeeAssignment___) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountEmployeeAssignment___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountEmployeeAssignment___);
					}
				}
				_accountEmployeeAssignment___.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountEmployeeAssignment___.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountEmployeeAssignment___.GetMultiManyToOne(null, null, null, null, this, null, null, null, filter);
				_accountEmployeeAssignment___.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountEmployeeAssignment___ = true;
			}
			return _accountEmployeeAssignment___;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountEmployeeAssignment___'. These settings will be taken into account
		/// when the property AccountEmployeeAssignment___ is requested or GetMultiAccountEmployeeAssignment___ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountEmployeeAssignment___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountEmployeeAssignment___.SortClauses=sortClauses;
			_accountEmployeeAssignment___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment(bool forceFetch)
		{
			return GetMultiAccountEmployeeAssignment(forceFetch, _accountEmployeeAssignment.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAccountEmployeeAssignment(forceFetch, _accountEmployeeAssignment.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAccountEmployeeAssignment(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAccountEmployeeAssignment || forceFetch || _alwaysFetchAccountEmployeeAssignment) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountEmployeeAssignment.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountEmployeeAssignment);
					}
				}
				_accountEmployeeAssignment.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountEmployeeAssignment.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountEmployeeAssignment.GetMultiManyToOne(null, null, null, null, null, this, null, null, filter);
				_accountEmployeeAssignment.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountEmployeeAssignment = true;
			}
			return _accountEmployeeAssignment;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountEmployeeAssignment'. These settings will be taken into account
		/// when the property AccountEmployeeAssignment is requested or GetMultiAccountEmployeeAssignment is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountEmployeeAssignment(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountEmployeeAssignment.SortClauses=sortClauses;
			_accountEmployeeAssignment.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment_(bool forceFetch)
		{
			return GetMultiAccountEmployeeAssignment_(forceFetch, _accountEmployeeAssignment_.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment_(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAccountEmployeeAssignment_(forceFetch, _accountEmployeeAssignment_.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAccountEmployeeAssignment_(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAccountEmployeeAssignment_ || forceFetch || _alwaysFetchAccountEmployeeAssignment_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountEmployeeAssignment_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountEmployeeAssignment_);
					}
				}
				_accountEmployeeAssignment_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountEmployeeAssignment_.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountEmployeeAssignment_.GetMultiManyToOne(null, null, null, null, null, null, this, null, filter);
				_accountEmployeeAssignment_.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountEmployeeAssignment_ = true;
			}
			return _accountEmployeeAssignment_;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountEmployeeAssignment_'. These settings will be taken into account
		/// when the property AccountEmployeeAssignment_ is requested or GetMultiAccountEmployeeAssignment_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountEmployeeAssignment_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountEmployeeAssignment_.SortClauses=sortClauses;
			_accountEmployeeAssignment_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment__(bool forceFetch)
		{
			return GetMultiAccountEmployeeAssignment__(forceFetch, _accountEmployeeAssignment__.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AccountEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment__(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAccountEmployeeAssignment__(forceFetch, _accountEmployeeAssignment__.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAccountEmployeeAssignment__(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection GetMultiAccountEmployeeAssignment__(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAccountEmployeeAssignment__ || forceFetch || _alwaysFetchAccountEmployeeAssignment__) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountEmployeeAssignment__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountEmployeeAssignment__);
					}
				}
				_accountEmployeeAssignment__.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountEmployeeAssignment__.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountEmployeeAssignment__.GetMultiManyToOne(null, null, null, null, null, null, null, this, filter);
				_accountEmployeeAssignment__.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountEmployeeAssignment__ = true;
			}
			return _accountEmployeeAssignment__;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountEmployeeAssignment__'. These settings will be taken into account
		/// when the property AccountEmployeeAssignment__ is requested or GetMultiAccountEmployeeAssignment__ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountEmployeeAssignment__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountEmployeeAssignment__.SortClauses=sortClauses;
			_accountEmployeeAssignment__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AssetReclamationServiceChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection GetMultiAssetReclamationServiceChangeLog(bool forceFetch)
		{
			return GetMultiAssetReclamationServiceChangeLog(forceFetch, _assetReclamationServiceChangeLog.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AssetReclamationServiceChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection GetMultiAssetReclamationServiceChangeLog(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAssetReclamationServiceChangeLog(forceFetch, _assetReclamationServiceChangeLog.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection GetMultiAssetReclamationServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAssetReclamationServiceChangeLog(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection GetMultiAssetReclamationServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAssetReclamationServiceChangeLog || forceFetch || _alwaysFetchAssetReclamationServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_assetReclamationServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_assetReclamationServiceChangeLog);
					}
				}
				_assetReclamationServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_assetReclamationServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_assetReclamationServiceChangeLog.GetMultiManyToOne(null, this, null, filter);
				_assetReclamationServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedAssetReclamationServiceChangeLog = true;
			}
			return _assetReclamationServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'AssetReclamationServiceChangeLog'. These settings will be taken into account
		/// when the property AssetReclamationServiceChangeLog is requested or GetMultiAssetReclamationServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAssetReclamationServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_assetReclamationServiceChangeLog.SortClauses=sortClauses;
			_assetReclamationServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_deepFryerService.GetMultiManyToOne(null, this, null, null, null, filter);
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
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog_(bool forceFetch)
		{
			return GetMultiDeepFryerServiceChangeLog_(forceFetch, _deepFryerServiceChangeLog_.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerServiceChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog_(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiDeepFryerServiceChangeLog_(forceFetch, _deepFryerServiceChangeLog_.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiDeepFryerServiceChangeLog_(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedDeepFryerServiceChangeLog_ || forceFetch || _alwaysFetchDeepFryerServiceChangeLog_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryerServiceChangeLog_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryerServiceChangeLog_);
					}
				}
				_deepFryerServiceChangeLog_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryerServiceChangeLog_.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryerServiceChangeLog_.GetMultiManyToOne(null, this, null, null, null, filter);
				_deepFryerServiceChangeLog_.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryerServiceChangeLog_ = true;
			}
			return _deepFryerServiceChangeLog_;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryerServiceChangeLog_'. These settings will be taken into account
		/// when the property DeepFryerServiceChangeLog_ is requested or GetMultiDeepFryerServiceChangeLog_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryerServiceChangeLog_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryerServiceChangeLog_.SortClauses=sortClauses;
			_deepFryerServiceChangeLog_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_deepFryerServiceChangeLog.GetMultiManyToOne(null, null, this, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'LoadEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LoadEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.LoadCollection GetMultiLoad(bool forceFetch)
		{
			return GetMultiLoad(forceFetch, _load.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LoadEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'LoadEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.LoadCollection GetMultiLoad(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiLoad(forceFetch, _load.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'LoadEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.LoadCollection GetMultiLoad(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiLoad(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LoadEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.LoadCollection GetMultiLoad(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedLoad || forceFetch || _alwaysFetchLoad) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_load.ParticipatesInTransaction)
					{
						base.Transaction.Add(_load);
					}
				}
				_load.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_load.EntityFactoryToUse = entityFactoryToUse;
				}
				_load.GetMultiManyToOne(this, null, filter);
				_load.SuppressClearInGetMulti=false;
				_alreadyFetchedLoad = true;
			}
			return _load;
		}

		/// <summary> Sets the collection parameters for the collection for 'Load'. These settings will be taken into account
		/// when the property Load is requested or GetMultiLoad is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersLoad(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_load.SortClauses=sortClauses;
			_load.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceActionEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceActionEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection GetMultiRecycleServiceAction_(bool forceFetch)
		{
			return GetMultiRecycleServiceAction_(forceFetch, _recycleServiceAction_.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceActionEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceActionEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection GetMultiRecycleServiceAction_(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiRecycleServiceAction_(forceFetch, _recycleServiceAction_.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceActionEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection GetMultiRecycleServiceAction_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiRecycleServiceAction_(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceActionEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection GetMultiRecycleServiceAction_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedRecycleServiceAction_ || forceFetch || _alwaysFetchRecycleServiceAction_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleServiceAction_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleServiceAction_);
					}
				}
				_recycleServiceAction_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleServiceAction_.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleServiceAction_.GetMultiManyToOne(null, this, null, null, null, null, filter);
				_recycleServiceAction_.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleServiceAction_ = true;
			}
			return _recycleServiceAction_;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleServiceAction_'. These settings will be taken into account
		/// when the property RecycleServiceAction_ is requested or GetMultiRecycleServiceAction_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleServiceAction_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleServiceAction_.SortClauses=sortClauses;
			_recycleServiceAction_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceActionEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceActionEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection GetMultiRecycleServiceAction(bool forceFetch)
		{
			return GetMultiRecycleServiceAction(forceFetch, _recycleServiceAction.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceActionEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceActionEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection GetMultiRecycleServiceAction(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiRecycleServiceAction(forceFetch, _recycleServiceAction.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceActionEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection GetMultiRecycleServiceAction(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiRecycleServiceAction(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceActionEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection GetMultiRecycleServiceAction(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedRecycleServiceAction || forceFetch || _alwaysFetchRecycleServiceAction) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleServiceAction.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleServiceAction);
					}
				}
				_recycleServiceAction.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleServiceAction.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleServiceAction.GetMultiManyToOne(this, null, null, null, null, null, filter);
				_recycleServiceAction.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleServiceAction = true;
			}
			return _recycleServiceAction;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleServiceAction'. These settings will be taken into account
		/// when the property RecycleServiceAction is requested or GetMultiRecycleServiceAction is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleServiceAction(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleServiceAction.SortClauses=sortClauses;
			_recycleServiceAction.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection GetMultiRecycleServiceChangeLog(bool forceFetch)
		{
			return GetMultiRecycleServiceChangeLog(forceFetch, _recycleServiceChangeLog.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection GetMultiRecycleServiceChangeLog(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiRecycleServiceChangeLog(forceFetch, _recycleServiceChangeLog.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection GetMultiRecycleServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiRecycleServiceChangeLog(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection GetMultiRecycleServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedRecycleServiceChangeLog || forceFetch || _alwaysFetchRecycleServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleServiceChangeLog);
					}
				}
				_recycleServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleServiceChangeLog.GetMultiManyToOne(this, null, null, filter);
				_recycleServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleServiceChangeLog = true;
			}
			return _recycleServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleServiceChangeLog'. These settings will be taken into account
		/// when the property RecycleServiceChangeLog is requested or GetMultiRecycleServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleServiceChangeLog.SortClauses=sortClauses;
			_recycleServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment____(bool forceFetch)
		{
			return GetMultiServiceLocationEmployeeAssignment____(forceFetch, _serviceLocationEmployeeAssignment____.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment____(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationEmployeeAssignment____(forceFetch, _serviceLocationEmployeeAssignment____.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationEmployeeAssignment____(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment____(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationEmployeeAssignment____ || forceFetch || _alwaysFetchServiceLocationEmployeeAssignment____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationEmployeeAssignment____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationEmployeeAssignment____);
					}
				}
				_serviceLocationEmployeeAssignment____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationEmployeeAssignment____.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationEmployeeAssignment____.GetMultiManyToOne(this, null, null, null, null, null, null, null, filter);
				_serviceLocationEmployeeAssignment____.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationEmployeeAssignment____ = true;
			}
			return _serviceLocationEmployeeAssignment____;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationEmployeeAssignment____'. These settings will be taken into account
		/// when the property ServiceLocationEmployeeAssignment____ is requested or GetMultiServiceLocationEmployeeAssignment____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationEmployeeAssignment____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationEmployeeAssignment____.SortClauses=sortClauses;
			_serviceLocationEmployeeAssignment____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment_____(bool forceFetch)
		{
			return GetMultiServiceLocationEmployeeAssignment_____(forceFetch, _serviceLocationEmployeeAssignment_____.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment_____(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationEmployeeAssignment_____(forceFetch, _serviceLocationEmployeeAssignment_____.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment_____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationEmployeeAssignment_____(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment_____(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationEmployeeAssignment_____ || forceFetch || _alwaysFetchServiceLocationEmployeeAssignment_____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationEmployeeAssignment_____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationEmployeeAssignment_____);
					}
				}
				_serviceLocationEmployeeAssignment_____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationEmployeeAssignment_____.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationEmployeeAssignment_____.GetMultiManyToOne(null, this, null, null, null, null, null, null, filter);
				_serviceLocationEmployeeAssignment_____.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationEmployeeAssignment_____ = true;
			}
			return _serviceLocationEmployeeAssignment_____;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationEmployeeAssignment_____'. These settings will be taken into account
		/// when the property ServiceLocationEmployeeAssignment_____ is requested or GetMultiServiceLocationEmployeeAssignment_____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationEmployeeAssignment_____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationEmployeeAssignment_____.SortClauses=sortClauses;
			_serviceLocationEmployeeAssignment_____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment______(bool forceFetch)
		{
			return GetMultiServiceLocationEmployeeAssignment______(forceFetch, _serviceLocationEmployeeAssignment______.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment______(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationEmployeeAssignment______(forceFetch, _serviceLocationEmployeeAssignment______.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment______(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationEmployeeAssignment______(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment______(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationEmployeeAssignment______ || forceFetch || _alwaysFetchServiceLocationEmployeeAssignment______) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationEmployeeAssignment______.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationEmployeeAssignment______);
					}
				}
				_serviceLocationEmployeeAssignment______.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationEmployeeAssignment______.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationEmployeeAssignment______.GetMultiManyToOne(null, null, this, null, null, null, null, null, filter);
				_serviceLocationEmployeeAssignment______.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationEmployeeAssignment______ = true;
			}
			return _serviceLocationEmployeeAssignment______;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationEmployeeAssignment______'. These settings will be taken into account
		/// when the property ServiceLocationEmployeeAssignment______ is requested or GetMultiServiceLocationEmployeeAssignment______ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationEmployeeAssignment______(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationEmployeeAssignment______.SortClauses=sortClauses;
			_serviceLocationEmployeeAssignment______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment___(bool forceFetch)
		{
			return GetMultiServiceLocationEmployeeAssignment___(forceFetch, _serviceLocationEmployeeAssignment___.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment___(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationEmployeeAssignment___(forceFetch, _serviceLocationEmployeeAssignment___.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationEmployeeAssignment___(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment___(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationEmployeeAssignment___ || forceFetch || _alwaysFetchServiceLocationEmployeeAssignment___) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationEmployeeAssignment___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationEmployeeAssignment___);
					}
				}
				_serviceLocationEmployeeAssignment___.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationEmployeeAssignment___.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationEmployeeAssignment___.GetMultiManyToOne(null, null, null, this, null, null, null, null, filter);
				_serviceLocationEmployeeAssignment___.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationEmployeeAssignment___ = true;
			}
			return _serviceLocationEmployeeAssignment___;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationEmployeeAssignment___'. These settings will be taken into account
		/// when the property ServiceLocationEmployeeAssignment___ is requested or GetMultiServiceLocationEmployeeAssignment___ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationEmployeeAssignment___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationEmployeeAssignment___.SortClauses=sortClauses;
			_serviceLocationEmployeeAssignment___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_serviceLocationEmployeeAssignment.GetMultiManyToOne(null, null, null, null, this, null, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment_(bool forceFetch)
		{
			return GetMultiServiceLocationEmployeeAssignment_(forceFetch, _serviceLocationEmployeeAssignment_.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment_(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationEmployeeAssignment_(forceFetch, _serviceLocationEmployeeAssignment_.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationEmployeeAssignment_(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationEmployeeAssignment_ || forceFetch || _alwaysFetchServiceLocationEmployeeAssignment_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationEmployeeAssignment_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationEmployeeAssignment_);
					}
				}
				_serviceLocationEmployeeAssignment_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationEmployeeAssignment_.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationEmployeeAssignment_.GetMultiManyToOne(null, null, null, null, null, this, null, null, filter);
				_serviceLocationEmployeeAssignment_.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationEmployeeAssignment_ = true;
			}
			return _serviceLocationEmployeeAssignment_;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationEmployeeAssignment_'. These settings will be taken into account
		/// when the property ServiceLocationEmployeeAssignment_ is requested or GetMultiServiceLocationEmployeeAssignment_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationEmployeeAssignment_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationEmployeeAssignment_.SortClauses=sortClauses;
			_serviceLocationEmployeeAssignment_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment__(bool forceFetch)
		{
			return GetMultiServiceLocationEmployeeAssignment__(forceFetch, _serviceLocationEmployeeAssignment__.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEmployeeAssignmentEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment__(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationEmployeeAssignment__(forceFetch, _serviceLocationEmployeeAssignment__.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationEmployeeAssignment__(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection GetMultiServiceLocationEmployeeAssignment__(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationEmployeeAssignment__ || forceFetch || _alwaysFetchServiceLocationEmployeeAssignment__) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationEmployeeAssignment__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationEmployeeAssignment__);
					}
				}
				_serviceLocationEmployeeAssignment__.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationEmployeeAssignment__.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationEmployeeAssignment__.GetMultiManyToOne(null, null, null, null, null, null, this, null, filter);
				_serviceLocationEmployeeAssignment__.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationEmployeeAssignment__ = true;
			}
			return _serviceLocationEmployeeAssignment__;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationEmployeeAssignment__'. These settings will be taken into account
		/// when the property ServiceLocationEmployeeAssignment__ is requested or GetMultiServiceLocationEmployeeAssignment__ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationEmployeeAssignment__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationEmployeeAssignment__.SortClauses=sortClauses;
			_serviceLocationEmployeeAssignment__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch)
		{
			return GetMultiWorkOrder(forceFetch, _workOrder.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiWorkOrder(forceFetch, _workOrder.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiWorkOrder(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrder);
					}
				}
				_workOrder.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrder.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrder.GetMultiManyToOne(null, this, null, filter);
				_workOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrder = true;
			}
			return _workOrder;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrder'. These settings will be taken into account
		/// when the property WorkOrder is requested or GetMultiWorkOrder is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrder(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrder.SortClauses=sortClauses;
			_workOrder.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment_____(bool forceFetch)
		{
			return GetMultiAccountCollectionViaAccountEmployeeAssignment_____(forceFetch, _accountCollectionViaAccountEmployeeAssignment_____.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment_____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____ || forceFetch || _alwaysFetchAccountCollectionViaAccountEmployeeAssignment_____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaAccountEmployeeAssignment_____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaAccountEmployeeAssignment_____);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_accountCollectionViaAccountEmployeeAssignment_____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaAccountEmployeeAssignment_____.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaAccountEmployeeAssignment_____.GetMulti(filter, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment_____"));
				_accountCollectionViaAccountEmployeeAssignment_____.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____ = true;
			}
			return _accountCollectionViaAccountEmployeeAssignment_____;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaAccountEmployeeAssignment_____'. These settings will be taken into account
		/// when the property AccountCollectionViaAccountEmployeeAssignment_____ is requested or GetMultiAccountCollectionViaAccountEmployeeAssignment_____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaAccountEmployeeAssignment_____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaAccountEmployeeAssignment_____.SortClauses=sortClauses;
			_accountCollectionViaAccountEmployeeAssignment_____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment____(bool forceFetch)
		{
			return GetMultiAccountCollectionViaAccountEmployeeAssignment____(forceFetch, _accountCollectionViaAccountEmployeeAssignment____.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____ || forceFetch || _alwaysFetchAccountCollectionViaAccountEmployeeAssignment____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaAccountEmployeeAssignment____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaAccountEmployeeAssignment____);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_accountCollectionViaAccountEmployeeAssignment____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaAccountEmployeeAssignment____.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaAccountEmployeeAssignment____.GetMulti(filter, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment____"));
				_accountCollectionViaAccountEmployeeAssignment____.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____ = true;
			}
			return _accountCollectionViaAccountEmployeeAssignment____;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaAccountEmployeeAssignment____'. These settings will be taken into account
		/// when the property AccountCollectionViaAccountEmployeeAssignment____ is requested or GetMultiAccountCollectionViaAccountEmployeeAssignment____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaAccountEmployeeAssignment____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaAccountEmployeeAssignment____.SortClauses=sortClauses;
			_accountCollectionViaAccountEmployeeAssignment____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaWorkOrder(bool forceFetch)
		{
			return GetMultiAccountCollectionViaWorkOrder(forceFetch, _accountCollectionViaWorkOrder.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaWorkOrder || forceFetch || _alwaysFetchAccountCollectionViaWorkOrder) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaWorkOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaWorkOrder);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_accountCollectionViaWorkOrder.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaWorkOrder.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaWorkOrder.GetMulti(filter, GetRelationsForField("AccountCollectionViaWorkOrder"));
				_accountCollectionViaWorkOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaWorkOrder = true;
			}
			return _accountCollectionViaWorkOrder;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaWorkOrder'. These settings will be taken into account
		/// when the property AccountCollectionViaWorkOrder is requested or GetMultiAccountCollectionViaWorkOrder is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaWorkOrder(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaWorkOrder.SortClauses=sortClauses;
			_accountCollectionViaWorkOrder.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment______(bool forceFetch)
		{
			return GetMultiAccountCollectionViaAccountEmployeeAssignment______(forceFetch, _accountCollectionViaAccountEmployeeAssignment______.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment______(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______ || forceFetch || _alwaysFetchAccountCollectionViaAccountEmployeeAssignment______) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaAccountEmployeeAssignment______.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaAccountEmployeeAssignment______);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_accountCollectionViaAccountEmployeeAssignment______.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaAccountEmployeeAssignment______.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaAccountEmployeeAssignment______.GetMulti(filter, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment______"));
				_accountCollectionViaAccountEmployeeAssignment______.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______ = true;
			}
			return _accountCollectionViaAccountEmployeeAssignment______;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaAccountEmployeeAssignment______'. These settings will be taken into account
		/// when the property AccountCollectionViaAccountEmployeeAssignment______ is requested or GetMultiAccountCollectionViaAccountEmployeeAssignment______ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaAccountEmployeeAssignment______(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaAccountEmployeeAssignment______.SortClauses=sortClauses;
			_accountCollectionViaAccountEmployeeAssignment______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment_(bool forceFetch)
		{
			return GetMultiAccountCollectionViaAccountEmployeeAssignment_(forceFetch, _accountCollectionViaAccountEmployeeAssignment_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_ || forceFetch || _alwaysFetchAccountCollectionViaAccountEmployeeAssignment_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaAccountEmployeeAssignment_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaAccountEmployeeAssignment_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_accountCollectionViaAccountEmployeeAssignment_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaAccountEmployeeAssignment_.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaAccountEmployeeAssignment_.GetMulti(filter, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment_"));
				_accountCollectionViaAccountEmployeeAssignment_.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_ = true;
			}
			return _accountCollectionViaAccountEmployeeAssignment_;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaAccountEmployeeAssignment_'. These settings will be taken into account
		/// when the property AccountCollectionViaAccountEmployeeAssignment_ is requested or GetMultiAccountCollectionViaAccountEmployeeAssignment_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaAccountEmployeeAssignment_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaAccountEmployeeAssignment_.SortClauses=sortClauses;
			_accountCollectionViaAccountEmployeeAssignment_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment(bool forceFetch)
		{
			return GetMultiAccountCollectionViaAccountEmployeeAssignment(forceFetch, _accountCollectionViaAccountEmployeeAssignment.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment || forceFetch || _alwaysFetchAccountCollectionViaAccountEmployeeAssignment) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaAccountEmployeeAssignment.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaAccountEmployeeAssignment);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_accountCollectionViaAccountEmployeeAssignment.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaAccountEmployeeAssignment.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaAccountEmployeeAssignment.GetMulti(filter, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment"));
				_accountCollectionViaAccountEmployeeAssignment.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment = true;
			}
			return _accountCollectionViaAccountEmployeeAssignment;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaAccountEmployeeAssignment'. These settings will be taken into account
		/// when the property AccountCollectionViaAccountEmployeeAssignment is requested or GetMultiAccountCollectionViaAccountEmployeeAssignment is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaAccountEmployeeAssignment(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaAccountEmployeeAssignment.SortClauses=sortClauses;
			_accountCollectionViaAccountEmployeeAssignment.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment___(bool forceFetch)
		{
			return GetMultiAccountCollectionViaAccountEmployeeAssignment___(forceFetch, _accountCollectionViaAccountEmployeeAssignment___.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___ || forceFetch || _alwaysFetchAccountCollectionViaAccountEmployeeAssignment___) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaAccountEmployeeAssignment___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaAccountEmployeeAssignment___);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_accountCollectionViaAccountEmployeeAssignment___.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaAccountEmployeeAssignment___.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaAccountEmployeeAssignment___.GetMulti(filter, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment___"));
				_accountCollectionViaAccountEmployeeAssignment___.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___ = true;
			}
			return _accountCollectionViaAccountEmployeeAssignment___;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaAccountEmployeeAssignment___'. These settings will be taken into account
		/// when the property AccountCollectionViaAccountEmployeeAssignment___ is requested or GetMultiAccountCollectionViaAccountEmployeeAssignment___ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaAccountEmployeeAssignment___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaAccountEmployeeAssignment___.SortClauses=sortClauses;
			_accountCollectionViaAccountEmployeeAssignment___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment__(bool forceFetch)
		{
			return GetMultiAccountCollectionViaAccountEmployeeAssignment__(forceFetch, _accountCollectionViaAccountEmployeeAssignment__.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaAccountEmployeeAssignment__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__ || forceFetch || _alwaysFetchAccountCollectionViaAccountEmployeeAssignment__) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaAccountEmployeeAssignment__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaAccountEmployeeAssignment__);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_accountCollectionViaAccountEmployeeAssignment__.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaAccountEmployeeAssignment__.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaAccountEmployeeAssignment__.GetMulti(filter, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment__"));
				_accountCollectionViaAccountEmployeeAssignment__.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__ = true;
			}
			return _accountCollectionViaAccountEmployeeAssignment__;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaAccountEmployeeAssignment__'. These settings will be taken into account
		/// when the property AccountCollectionViaAccountEmployeeAssignment__ is requested or GetMultiAccountCollectionViaAccountEmployeeAssignment__ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaAccountEmployeeAssignment__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaAccountEmployeeAssignment__.SortClauses=sortClauses;
			_accountCollectionViaAccountEmployeeAssignment__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AssetReclamationServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection GetMultiAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(bool forceFetch)
		{
			return GetMultiAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(forceFetch, _assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection GetMultiAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog || forceFetch || _alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.GetMulti(filter, GetRelationsForField("AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog"));
				_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = true;
			}
			return _assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog'. These settings will be taken into account
		/// when the property AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog is requested or GetMultiAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.SortClauses=sortClauses;
			_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
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

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(bool forceFetch)
		{
			return GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(forceFetch, _deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ || forceFetch || _alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.GetMulti(filter, GetRelationsForField("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_"));
				_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = true;
			}
			return _deepFryerServiceCollectionViaDeepFryerServiceChangeLog_;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_'. These settings will be taken into account
		/// when the property DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ is requested or GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.SortClauses=sortClauses;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection GetMultiRecycleServiceCollectionViaRecycleServiceAction(bool forceFetch)
		{
			return GetMultiRecycleServiceCollectionViaRecycleServiceAction(forceFetch, _recycleServiceCollectionViaRecycleServiceAction.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection GetMultiRecycleServiceCollectionViaRecycleServiceAction(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction || forceFetch || _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleServiceCollectionViaRecycleServiceAction.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleServiceCollectionViaRecycleServiceAction);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_recycleServiceCollectionViaRecycleServiceAction.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleServiceCollectionViaRecycleServiceAction.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleServiceCollectionViaRecycleServiceAction.GetMulti(filter, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction"));
				_recycleServiceCollectionViaRecycleServiceAction.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = true;
			}
			return _recycleServiceCollectionViaRecycleServiceAction;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleServiceCollectionViaRecycleServiceAction'. These settings will be taken into account
		/// when the property RecycleServiceCollectionViaRecycleServiceAction is requested or GetMultiRecycleServiceCollectionViaRecycleServiceAction is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleServiceCollectionViaRecycleServiceAction(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleServiceCollectionViaRecycleServiceAction.SortClauses=sortClauses;
			_recycleServiceCollectionViaRecycleServiceAction.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection GetMultiRecycleServiceCollectionViaRecycleServiceChangeLog(bool forceFetch)
		{
			return GetMultiRecycleServiceCollectionViaRecycleServiceChangeLog(forceFetch, _recycleServiceCollectionViaRecycleServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection GetMultiRecycleServiceCollectionViaRecycleServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog || forceFetch || _alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleServiceCollectionViaRecycleServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleServiceCollectionViaRecycleServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_recycleServiceCollectionViaRecycleServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleServiceCollectionViaRecycleServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleServiceCollectionViaRecycleServiceChangeLog.GetMulti(filter, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceChangeLog"));
				_recycleServiceCollectionViaRecycleServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog = true;
			}
			return _recycleServiceCollectionViaRecycleServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleServiceCollectionViaRecycleServiceChangeLog'. These settings will be taken into account
		/// when the property RecycleServiceCollectionViaRecycleServiceChangeLog is requested or GetMultiRecycleServiceCollectionViaRecycleServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleServiceCollectionViaRecycleServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleServiceCollectionViaRecycleServiceChangeLog.SortClauses=sortClauses;
			_recycleServiceCollectionViaRecycleServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection GetMultiRecycleServiceCollectionViaRecycleServiceAction_(bool forceFetch)
		{
			return GetMultiRecycleServiceCollectionViaRecycleServiceAction_(forceFetch, _recycleServiceCollectionViaRecycleServiceAction_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection GetMultiRecycleServiceCollectionViaRecycleServiceAction_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ || forceFetch || _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleServiceCollectionViaRecycleServiceAction_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleServiceCollectionViaRecycleServiceAction_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_recycleServiceCollectionViaRecycleServiceAction_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleServiceCollectionViaRecycleServiceAction_.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleServiceCollectionViaRecycleServiceAction_.GetMulti(filter, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction_"));
				_recycleServiceCollectionViaRecycleServiceAction_.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ = true;
			}
			return _recycleServiceCollectionViaRecycleServiceAction_;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleServiceCollectionViaRecycleServiceAction_'. These settings will be taken into account
		/// when the property RecycleServiceCollectionViaRecycleServiceAction_ is requested or GetMultiRecycleServiceCollectionViaRecycleServiceAction_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleServiceCollectionViaRecycleServiceAction_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleServiceCollectionViaRecycleServiceAction_.SortClauses=sortClauses;
			_recycleServiceCollectionViaRecycleServiceAction_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaRecycleServiceAction(bool forceFetch)
		{
			return GetMultiRecycleTypeCollectionViaRecycleServiceAction(forceFetch, _recycleTypeCollectionViaRecycleServiceAction.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaRecycleServiceAction(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction || forceFetch || _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleTypeCollectionViaRecycleServiceAction.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleTypeCollectionViaRecycleServiceAction);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_recycleTypeCollectionViaRecycleServiceAction.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleTypeCollectionViaRecycleServiceAction.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleTypeCollectionViaRecycleServiceAction.GetMulti(filter, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction"));
				_recycleTypeCollectionViaRecycleServiceAction.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = true;
			}
			return _recycleTypeCollectionViaRecycleServiceAction;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleTypeCollectionViaRecycleServiceAction'. These settings will be taken into account
		/// when the property RecycleTypeCollectionViaRecycleServiceAction is requested or GetMultiRecycleTypeCollectionViaRecycleServiceAction is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleTypeCollectionViaRecycleServiceAction(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleTypeCollectionViaRecycleServiceAction.SortClauses=sortClauses;
			_recycleTypeCollectionViaRecycleServiceAction.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaRecycleServiceAction_(bool forceFetch)
		{
			return GetMultiRecycleTypeCollectionViaRecycleServiceAction_(forceFetch, _recycleTypeCollectionViaRecycleServiceAction_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaRecycleServiceAction_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ || forceFetch || _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleTypeCollectionViaRecycleServiceAction_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleTypeCollectionViaRecycleServiceAction_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_recycleTypeCollectionViaRecycleServiceAction_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleTypeCollectionViaRecycleServiceAction_.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleTypeCollectionViaRecycleServiceAction_.GetMulti(filter, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction_"));
				_recycleTypeCollectionViaRecycleServiceAction_.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ = true;
			}
			return _recycleTypeCollectionViaRecycleServiceAction_;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleTypeCollectionViaRecycleServiceAction_'. These settings will be taken into account
		/// when the property RecycleTypeCollectionViaRecycleServiceAction_ is requested or GetMultiRecycleTypeCollectionViaRecycleServiceAction_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleTypeCollectionViaRecycleServiceAction_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleTypeCollectionViaRecycleServiceAction_.SortClauses=sortClauses;
			_recycleTypeCollectionViaRecycleServiceAction_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_(forceFetch, _serviceLocationCollectionViaServiceLocationEmployeeAssignment_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_ || forceFetch || _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaServiceLocationEmployeeAssignment_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment_"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_ = true;
			}
			return _serviceLocationCollectionViaServiceLocationEmployeeAssignment_;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaServiceLocationEmployeeAssignment_'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment_ is requested or GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaServiceLocationEmployeeAssignment_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.SortClauses=sortClauses;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment(forceFetch, _serviceLocationCollectionViaServiceLocationEmployeeAssignment.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment || forceFetch || _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaServiceLocationEmployeeAssignment.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaServiceLocationEmployeeAssignment);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment = true;
			}
			return _serviceLocationCollectionViaServiceLocationEmployeeAssignment;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaServiceLocationEmployeeAssignment'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment is requested or GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaServiceLocationEmployeeAssignment(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment.SortClauses=sortClauses;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(forceFetch, _serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ || forceFetch || _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ = true;
			}
			return _serviceLocationCollectionViaServiceLocationEmployeeAssignment_____;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ is requested or GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.SortClauses=sortClauses;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog(forceFetch, _serviceLocationCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog || forceFetch || _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaDeepFryerServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaDeepFryerServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceLocationCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaDeepFryerServiceChangeLog.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog"));
				_serviceLocationCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = true;
			}
			return _serviceLocationCollectionViaDeepFryerServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaDeepFryerServiceChangeLog'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaDeepFryerServiceChangeLog is requested or GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaDeepFryerServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaDeepFryerServiceChangeLog.SortClauses=sortClauses;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaDeepFryerService(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaDeepFryerService(forceFetch, _serviceLocationCollectionViaDeepFryerService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaDeepFryerService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaDeepFryerService || forceFetch || _alwaysFetchServiceLocationCollectionViaDeepFryerService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaDeepFryerService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaDeepFryerService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceLocationCollectionViaDeepFryerService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaDeepFryerService.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaDeepFryerService.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaDeepFryerService"));
				_serviceLocationCollectionViaDeepFryerService.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaDeepFryerService = true;
			}
			return _serviceLocationCollectionViaDeepFryerService;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaDeepFryerService'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaDeepFryerService is requested or GetMultiServiceLocationCollectionViaDeepFryerService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaDeepFryerService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaDeepFryerService.SortClauses=sortClauses;
			_serviceLocationCollectionViaDeepFryerService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment______(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment______(forceFetch, _serviceLocationCollectionViaServiceLocationEmployeeAssignment______.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment______(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______ || forceFetch || _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment______) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaServiceLocationEmployeeAssignment______);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment______"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______ = true;
			}
			return _serviceLocationCollectionViaServiceLocationEmployeeAssignment______;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaServiceLocationEmployeeAssignment______'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment______ is requested or GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment______ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaServiceLocationEmployeeAssignment______(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.SortClauses=sortClauses;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment____(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment____(forceFetch, _serviceLocationCollectionViaServiceLocationEmployeeAssignment____.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____ || forceFetch || _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaServiceLocationEmployeeAssignment____);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment____"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____ = true;
			}
			return _serviceLocationCollectionViaServiceLocationEmployeeAssignment____;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaServiceLocationEmployeeAssignment____'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment____ is requested or GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaServiceLocationEmployeeAssignment____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.SortClauses=sortClauses;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment__(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment__(forceFetch, _serviceLocationCollectionViaServiceLocationEmployeeAssignment__.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__ || forceFetch || _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment__) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaServiceLocationEmployeeAssignment__);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment__"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__ = true;
			}
			return _serviceLocationCollectionViaServiceLocationEmployeeAssignment__;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaServiceLocationEmployeeAssignment__'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment__ is requested or GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment__ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaServiceLocationEmployeeAssignment__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.SortClauses=sortClauses;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment___(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment___(forceFetch, _serviceLocationCollectionViaServiceLocationEmployeeAssignment___.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___ || forceFetch || _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment___) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaServiceLocationEmployeeAssignment___);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment___"));
				_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___ = true;
			}
			return _serviceLocationCollectionViaServiceLocationEmployeeAssignment___;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaServiceLocationEmployeeAssignment___'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment___ is requested or GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment___ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaServiceLocationEmployeeAssignment___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.SortClauses=sortClauses;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog_(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog_(forceFetch, _serviceLocationCollectionViaDeepFryerServiceChangeLog_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_ || forceFetch || _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaDeepFryerServiceChangeLog_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaDeepFryerServiceChangeLog_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceLocationCollectionViaDeepFryerServiceChangeLog_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaDeepFryerServiceChangeLog_.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaDeepFryerServiceChangeLog_.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog_"));
				_serviceLocationCollectionViaDeepFryerServiceChangeLog_.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_ = true;
			}
			return _serviceLocationCollectionViaDeepFryerServiceChangeLog_;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaDeepFryerServiceChangeLog_'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaDeepFryerServiceChangeLog_ is requested or GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaDeepFryerServiceChangeLog_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaDeepFryerServiceChangeLog_.SortClauses=sortClauses;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection GetMultiServiceTypeCollectionViaWorkOrder(bool forceFetch)
		{
			return GetMultiServiceTypeCollectionViaWorkOrder(forceFetch, _serviceTypeCollectionViaWorkOrder.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection GetMultiServiceTypeCollectionViaWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceTypeCollectionViaWorkOrder || forceFetch || _alwaysFetchServiceTypeCollectionViaWorkOrder) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceTypeCollectionViaWorkOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceTypeCollectionViaWorkOrder);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_serviceTypeCollectionViaWorkOrder.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceTypeCollectionViaWorkOrder.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceTypeCollectionViaWorkOrder.GetMulti(filter, GetRelationsForField("ServiceTypeCollectionViaWorkOrder"));
				_serviceTypeCollectionViaWorkOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceTypeCollectionViaWorkOrder = true;
			}
			return _serviceTypeCollectionViaWorkOrder;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceTypeCollectionViaWorkOrder'. These settings will be taken into account
		/// when the property ServiceTypeCollectionViaWorkOrder is requested or GetMultiServiceTypeCollectionViaWorkOrder is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceTypeCollectionViaWorkOrder(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceTypeCollectionViaWorkOrder.SortClauses=sortClauses;
			_serviceTypeCollectionViaWorkOrder.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'StatusEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StatusEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.StatusCollection GetMultiStatusCollectionViaLoad(bool forceFetch)
		{
			return GetMultiStatusCollectionViaLoad(forceFetch, _statusCollectionViaLoad.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'StatusEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.StatusCollection GetMultiStatusCollectionViaLoad(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedStatusCollectionViaLoad || forceFetch || _alwaysFetchStatusCollectionViaLoad) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_statusCollectionViaLoad.ParticipatesInTransaction)
					{
						base.Transaction.Add(_statusCollectionViaLoad);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_statusCollectionViaLoad.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_statusCollectionViaLoad.EntityFactoryToUse = entityFactoryToUse;
				}
				_statusCollectionViaLoad.GetMulti(filter, GetRelationsForField("StatusCollectionViaLoad"));
				_statusCollectionViaLoad.SuppressClearInGetMulti=false;
				_alreadyFetchedStatusCollectionViaLoad = true;
			}
			return _statusCollectionViaLoad;
		}

		/// <summary> Sets the collection parameters for the collection for 'StatusCollectionViaLoad'. These settings will be taken into account
		/// when the property StatusCollectionViaLoad is requested or GetMultiStatusCollectionViaLoad is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStatusCollectionViaLoad(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_statusCollectionViaLoad.SortClauses=sortClauses;
			_statusCollectionViaLoad.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
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

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaDeepFryerServiceChangeLog_(bool forceFetch)
		{
			return GetMultiUserCollectionViaDeepFryerServiceChangeLog_(forceFetch, _userCollectionViaDeepFryerServiceChangeLog_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaDeepFryerServiceChangeLog_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_ || forceFetch || _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaDeepFryerServiceChangeLog_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaDeepFryerServiceChangeLog_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_userCollectionViaDeepFryerServiceChangeLog_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaDeepFryerServiceChangeLog_.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaDeepFryerServiceChangeLog_.GetMulti(filter, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog_"));
				_userCollectionViaDeepFryerServiceChangeLog_.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_ = true;
			}
			return _userCollectionViaDeepFryerServiceChangeLog_;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaDeepFryerServiceChangeLog_'. These settings will be taken into account
		/// when the property UserCollectionViaDeepFryerServiceChangeLog_ is requested or GetMultiUserCollectionViaDeepFryerServiceChangeLog_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaDeepFryerServiceChangeLog_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaDeepFryerServiceChangeLog_.SortClauses=sortClauses;
			_userCollectionViaDeepFryerServiceChangeLog_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRecycleServiceAction___(bool forceFetch)
		{
			return GetMultiUserCollectionViaRecycleServiceAction___(forceFetch, _userCollectionViaRecycleServiceAction___.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRecycleServiceAction___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaRecycleServiceAction___ || forceFetch || _alwaysFetchUserCollectionViaRecycleServiceAction___) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaRecycleServiceAction___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaRecycleServiceAction___);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_userCollectionViaRecycleServiceAction___.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaRecycleServiceAction___.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaRecycleServiceAction___.GetMulti(filter, GetRelationsForField("UserCollectionViaRecycleServiceAction___"));
				_userCollectionViaRecycleServiceAction___.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaRecycleServiceAction___ = true;
			}
			return _userCollectionViaRecycleServiceAction___;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaRecycleServiceAction___'. These settings will be taken into account
		/// when the property UserCollectionViaRecycleServiceAction___ is requested or GetMultiUserCollectionViaRecycleServiceAction___ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaRecycleServiceAction___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaRecycleServiceAction___.SortClauses=sortClauses;
			_userCollectionViaRecycleServiceAction___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaAssetReclamationServiceChangeLog(bool forceFetch)
		{
			return GetMultiUserCollectionViaAssetReclamationServiceChangeLog(forceFetch, _userCollectionViaAssetReclamationServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaAssetReclamationServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog || forceFetch || _alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaAssetReclamationServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaAssetReclamationServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_userCollectionViaAssetReclamationServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaAssetReclamationServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaAssetReclamationServiceChangeLog.GetMulti(filter, GetRelationsForField("UserCollectionViaAssetReclamationServiceChangeLog"));
				_userCollectionViaAssetReclamationServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog = true;
			}
			return _userCollectionViaAssetReclamationServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaAssetReclamationServiceChangeLog'. These settings will be taken into account
		/// when the property UserCollectionViaAssetReclamationServiceChangeLog is requested or GetMultiUserCollectionViaAssetReclamationServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaAssetReclamationServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaAssetReclamationServiceChangeLog.SortClauses=sortClauses;
			_userCollectionViaAssetReclamationServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRecycleServiceChangeLog(bool forceFetch)
		{
			return GetMultiUserCollectionViaRecycleServiceChangeLog(forceFetch, _userCollectionViaRecycleServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRecycleServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaRecycleServiceChangeLog || forceFetch || _alwaysFetchUserCollectionViaRecycleServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaRecycleServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaRecycleServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_userCollectionViaRecycleServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaRecycleServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaRecycleServiceChangeLog.GetMulti(filter, GetRelationsForField("UserCollectionViaRecycleServiceChangeLog"));
				_userCollectionViaRecycleServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaRecycleServiceChangeLog = true;
			}
			return _userCollectionViaRecycleServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaRecycleServiceChangeLog'. These settings will be taken into account
		/// when the property UserCollectionViaRecycleServiceChangeLog is requested or GetMultiUserCollectionViaRecycleServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaRecycleServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaRecycleServiceChangeLog.SortClauses=sortClauses;
			_userCollectionViaRecycleServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRecycleServiceAction_(bool forceFetch)
		{
			return GetMultiUserCollectionViaRecycleServiceAction_(forceFetch, _userCollectionViaRecycleServiceAction_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRecycleServiceAction_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaRecycleServiceAction_ || forceFetch || _alwaysFetchUserCollectionViaRecycleServiceAction_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaRecycleServiceAction_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaRecycleServiceAction_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_userCollectionViaRecycleServiceAction_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaRecycleServiceAction_.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaRecycleServiceAction_.GetMulti(filter, GetRelationsForField("UserCollectionViaRecycleServiceAction_"));
				_userCollectionViaRecycleServiceAction_.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaRecycleServiceAction_ = true;
			}
			return _userCollectionViaRecycleServiceAction_;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaRecycleServiceAction_'. These settings will be taken into account
		/// when the property UserCollectionViaRecycleServiceAction_ is requested or GetMultiUserCollectionViaRecycleServiceAction_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaRecycleServiceAction_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaRecycleServiceAction_.SortClauses=sortClauses;
			_userCollectionViaRecycleServiceAction_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRecycleServiceAction__(bool forceFetch)
		{
			return GetMultiUserCollectionViaRecycleServiceAction__(forceFetch, _userCollectionViaRecycleServiceAction__.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRecycleServiceAction__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaRecycleServiceAction__ || forceFetch || _alwaysFetchUserCollectionViaRecycleServiceAction__) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaRecycleServiceAction__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaRecycleServiceAction__);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_userCollectionViaRecycleServiceAction__.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaRecycleServiceAction__.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaRecycleServiceAction__.GetMulti(filter, GetRelationsForField("UserCollectionViaRecycleServiceAction__"));
				_userCollectionViaRecycleServiceAction__.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaRecycleServiceAction__ = true;
			}
			return _userCollectionViaRecycleServiceAction__;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaRecycleServiceAction__'. These settings will be taken into account
		/// when the property UserCollectionViaRecycleServiceAction__ is requested or GetMultiUserCollectionViaRecycleServiceAction__ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaRecycleServiceAction__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaRecycleServiceAction__.SortClauses=sortClauses;
			_userCollectionViaRecycleServiceAction__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRecycleServiceAction(bool forceFetch)
		{
			return GetMultiUserCollectionViaRecycleServiceAction(forceFetch, _userCollectionViaRecycleServiceAction.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRecycleServiceAction(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaRecycleServiceAction || forceFetch || _alwaysFetchUserCollectionViaRecycleServiceAction) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaRecycleServiceAction.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaRecycleServiceAction);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
				_userCollectionViaRecycleServiceAction.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaRecycleServiceAction.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaRecycleServiceAction.GetMulti(filter, GetRelationsForField("UserCollectionViaRecycleServiceAction"));
				_userCollectionViaRecycleServiceAction.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaRecycleServiceAction = true;
			}
			return _userCollectionViaRecycleServiceAction;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaRecycleServiceAction'. These settings will be taken into account
		/// when the property UserCollectionViaRecycleServiceAction is requested or GetMultiUserCollectionViaRecycleServiceAction is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaRecycleServiceAction(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaRecycleServiceAction.SortClauses=sortClauses;
			_userCollectionViaRecycleServiceAction.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, ComparisonOperator.Equal, this.EmployeeId, "EmployeeEntity__"));
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



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			EmployeeDAO dao = (EmployeeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_accountEmployeeAssignment____.ActiveContext = base.ActiveContext;
			_accountEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			_accountEmployeeAssignment______.ActiveContext = base.ActiveContext;
			_accountEmployeeAssignment___.ActiveContext = base.ActiveContext;
			_accountEmployeeAssignment.ActiveContext = base.ActiveContext;
			_accountEmployeeAssignment_.ActiveContext = base.ActiveContext;
			_accountEmployeeAssignment__.ActiveContext = base.ActiveContext;
			_assetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			_deepFryerService.ActiveContext = base.ActiveContext;
			_deepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			_deepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_load.ActiveContext = base.ActiveContext;
			_recycleServiceAction_.ActiveContext = base.ActiveContext;
			_recycleServiceAction.ActiveContext = base.ActiveContext;
			_recycleServiceChangeLog.ActiveContext = base.ActiveContext;
			_serviceLocationEmployeeAssignment____.ActiveContext = base.ActiveContext;
			_serviceLocationEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			_serviceLocationEmployeeAssignment______.ActiveContext = base.ActiveContext;
			_serviceLocationEmployeeAssignment___.ActiveContext = base.ActiveContext;
			_serviceLocationEmployeeAssignment.ActiveContext = base.ActiveContext;
			_serviceLocationEmployeeAssignment_.ActiveContext = base.ActiveContext;
			_serviceLocationEmployeeAssignment__.ActiveContext = base.ActiveContext;
			_workOrder.ActiveContext = base.ActiveContext;
			_accountCollectionViaAccountEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			_accountCollectionViaAccountEmployeeAssignment____.ActiveContext = base.ActiveContext;
			_accountCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			_accountCollectionViaAccountEmployeeAssignment______.ActiveContext = base.ActiveContext;
			_accountCollectionViaAccountEmployeeAssignment_.ActiveContext = base.ActiveContext;
			_accountCollectionViaAccountEmployeeAssignment.ActiveContext = base.ActiveContext;
			_accountCollectionViaAccountEmployeeAssignment___.ActiveContext = base.ActiveContext;
			_accountCollectionViaAccountEmployeeAssignment__.ActiveContext = base.ActiveContext;
			_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			_deepFryerCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			_recycleServiceCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_recycleServiceCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			_recycleServiceCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			_recycleTypeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_recycleTypeCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			_serviceTypeCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			_statusCollectionViaLoad.ActiveContext = base.ActiveContext;
			_userCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_userCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			_userCollectionViaRecycleServiceAction___.ActiveContext = base.ActiveContext;
			_userCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			_userCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			_userCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			_userCollectionViaRecycleServiceAction__.ActiveContext = base.ActiveContext;
			_userCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_workOrderEmployeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_workOrderServiceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			EmployeeDAO dao = (EmployeeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			EmployeeDAO dao = (EmployeeDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.EmployeeEntity);
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
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 employeeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(employeeId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_accountEmployeeAssignment____ = new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(new AccountEmployeeAssignmentEntityFactory());
			_accountEmployeeAssignment____.SetContainingEntityInfo(this, "Employee____");
			_alwaysFetchAccountEmployeeAssignment____ = false;
			_alreadyFetchedAccountEmployeeAssignment____ = false;
			_accountEmployeeAssignment_____ = new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(new AccountEmployeeAssignmentEntityFactory());
			_accountEmployeeAssignment_____.SetContainingEntityInfo(this, "Employee_____");
			_alwaysFetchAccountEmployeeAssignment_____ = false;
			_alreadyFetchedAccountEmployeeAssignment_____ = false;
			_accountEmployeeAssignment______ = new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(new AccountEmployeeAssignmentEntityFactory());
			_accountEmployeeAssignment______.SetContainingEntityInfo(this, "Employee______");
			_alwaysFetchAccountEmployeeAssignment______ = false;
			_alreadyFetchedAccountEmployeeAssignment______ = false;
			_accountEmployeeAssignment___ = new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(new AccountEmployeeAssignmentEntityFactory());
			_accountEmployeeAssignment___.SetContainingEntityInfo(this, "Employee___");
			_alwaysFetchAccountEmployeeAssignment___ = false;
			_alreadyFetchedAccountEmployeeAssignment___ = false;
			_accountEmployeeAssignment = new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(new AccountEmployeeAssignmentEntityFactory());
			_accountEmployeeAssignment.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchAccountEmployeeAssignment = false;
			_alreadyFetchedAccountEmployeeAssignment = false;
			_accountEmployeeAssignment_ = new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(new AccountEmployeeAssignmentEntityFactory());
			_accountEmployeeAssignment_.SetContainingEntityInfo(this, "Employee_");
			_alwaysFetchAccountEmployeeAssignment_ = false;
			_alreadyFetchedAccountEmployeeAssignment_ = false;
			_accountEmployeeAssignment__ = new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(new AccountEmployeeAssignmentEntityFactory());
			_accountEmployeeAssignment__.SetContainingEntityInfo(this, "Employee__");
			_alwaysFetchAccountEmployeeAssignment__ = false;
			_alreadyFetchedAccountEmployeeAssignment__ = false;
			_assetReclamationServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection(new AssetReclamationServiceChangeLogEntityFactory());
			_assetReclamationServiceChangeLog.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchAssetReclamationServiceChangeLog = false;
			_alreadyFetchedAssetReclamationServiceChangeLog = false;
			_deepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(new DeepFryerServiceEntityFactory());
			_deepFryerService.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchDeepFryerService = false;
			_alreadyFetchedDeepFryerService = false;
			_deepFryerServiceChangeLog_ = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection(new DeepFryerServiceChangeLogEntityFactory());
			_deepFryerServiceChangeLog_.SetContainingEntityInfo(this, "Employee_");
			_alwaysFetchDeepFryerServiceChangeLog_ = false;
			_alreadyFetchedDeepFryerServiceChangeLog_ = false;
			_deepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection(new DeepFryerServiceChangeLogEntityFactory());
			_deepFryerServiceChangeLog.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchDeepFryerServiceChangeLog = false;
			_alreadyFetchedDeepFryerServiceChangeLog = false;
			_load = new Reliant.RenuOil.DAL.CollectionClasses.LoadCollection(new LoadEntityFactory());
			_load.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchLoad = false;
			_alreadyFetchedLoad = false;
			_recycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection(new RecycleServiceActionEntityFactory());
			_recycleServiceAction_.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchRecycleServiceAction_ = false;
			_alreadyFetchedRecycleServiceAction_ = false;
			_recycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection(new RecycleServiceActionEntityFactory());
			_recycleServiceAction.SetContainingEntityInfo(this, "Employee_");
			_alwaysFetchRecycleServiceAction = false;
			_alreadyFetchedRecycleServiceAction = false;
			_recycleServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection(new RecycleServiceChangeLogEntityFactory());
			_recycleServiceChangeLog.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchRecycleServiceChangeLog = false;
			_alreadyFetchedRecycleServiceChangeLog = false;
			_serviceLocationEmployeeAssignment____ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(new ServiceLocationEmployeeAssignmentEntityFactory());
			_serviceLocationEmployeeAssignment____.SetContainingEntityInfo(this, "Employee____");
			_alwaysFetchServiceLocationEmployeeAssignment____ = false;
			_alreadyFetchedServiceLocationEmployeeAssignment____ = false;
			_serviceLocationEmployeeAssignment_____ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(new ServiceLocationEmployeeAssignmentEntityFactory());
			_serviceLocationEmployeeAssignment_____.SetContainingEntityInfo(this, "Employee_____");
			_alwaysFetchServiceLocationEmployeeAssignment_____ = false;
			_alreadyFetchedServiceLocationEmployeeAssignment_____ = false;
			_serviceLocationEmployeeAssignment______ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(new ServiceLocationEmployeeAssignmentEntityFactory());
			_serviceLocationEmployeeAssignment______.SetContainingEntityInfo(this, "Employee______");
			_alwaysFetchServiceLocationEmployeeAssignment______ = false;
			_alreadyFetchedServiceLocationEmployeeAssignment______ = false;
			_serviceLocationEmployeeAssignment___ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(new ServiceLocationEmployeeAssignmentEntityFactory());
			_serviceLocationEmployeeAssignment___.SetContainingEntityInfo(this, "Employee___");
			_alwaysFetchServiceLocationEmployeeAssignment___ = false;
			_alreadyFetchedServiceLocationEmployeeAssignment___ = false;
			_serviceLocationEmployeeAssignment = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(new ServiceLocationEmployeeAssignmentEntityFactory());
			_serviceLocationEmployeeAssignment.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchServiceLocationEmployeeAssignment = false;
			_alreadyFetchedServiceLocationEmployeeAssignment = false;
			_serviceLocationEmployeeAssignment_ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(new ServiceLocationEmployeeAssignmentEntityFactory());
			_serviceLocationEmployeeAssignment_.SetContainingEntityInfo(this, "Employee_");
			_alwaysFetchServiceLocationEmployeeAssignment_ = false;
			_alreadyFetchedServiceLocationEmployeeAssignment_ = false;
			_serviceLocationEmployeeAssignment__ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(new ServiceLocationEmployeeAssignmentEntityFactory());
			_serviceLocationEmployeeAssignment__.SetContainingEntityInfo(this, "Employee__");
			_alwaysFetchServiceLocationEmployeeAssignment__ = false;
			_alreadyFetchedServiceLocationEmployeeAssignment__ = false;
			_workOrder = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection(new WorkOrderEntityFactory());
			_workOrder.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchWorkOrder = false;
			_alreadyFetchedWorkOrder = false;
			_accountCollectionViaAccountEmployeeAssignment_____ = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment_____ = false;
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____ = false;
			_accountCollectionViaAccountEmployeeAssignment____ = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment____ = false;
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____ = false;
			_accountCollectionViaWorkOrder = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaWorkOrder = false;
			_alreadyFetchedAccountCollectionViaWorkOrder = false;
			_accountCollectionViaAccountEmployeeAssignment______ = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment______ = false;
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______ = false;
			_accountCollectionViaAccountEmployeeAssignment_ = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment_ = false;
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_ = false;
			_accountCollectionViaAccountEmployeeAssignment = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment = false;
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment = false;
			_accountCollectionViaAccountEmployeeAssignment___ = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment___ = false;
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___ = false;
			_accountCollectionViaAccountEmployeeAssignment__ = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaAccountEmployeeAssignment__ = false;
			_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__ = false;
			_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection(new AssetReclamationServiceEntityFactory());
			_alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = false;
			_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = false;
			_deepFryerCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(new DeepFryerEntityFactory());
			_alwaysFetchDeepFryerCollectionViaDeepFryerService = false;
			_alreadyFetchedDeepFryerCollectionViaDeepFryerService = false;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(new DeepFryerServiceEntityFactory());
			_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = false;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(new DeepFryerServiceEntityFactory());
			_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = false;
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = false;
			_recycleServiceCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(new RecycleServiceEntityFactory());
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction = false;
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = false;
			_recycleServiceCollectionViaRecycleServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(new RecycleServiceEntityFactory());
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog = false;
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog = false;
			_recycleServiceCollectionViaRecycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(new RecycleServiceEntityFactory());
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_ = false;
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ = false;
			_recycleTypeCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(new RecycleTypeEntityFactory());
			_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction = false;
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = false;
			_recycleTypeCollectionViaRecycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(new RecycleTypeEntityFactory());
			_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_ = false;
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ = false;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_ = false;
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_ = false;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment = false;
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment = false;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ = false;
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ = false;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = false;
			_serviceLocationCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaDeepFryerService = false;
			_alreadyFetchedServiceLocationCollectionViaDeepFryerService = false;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment______ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment______ = false;
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______ = false;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment____ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment____ = false;
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____ = false;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment__ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment__ = false;
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__ = false;
			_serviceLocationCollectionViaServiceLocationEmployeeAssignment___ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment___ = false;
			_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___ = false;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog_ = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog_ = false;
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_ = false;
			_serviceTypeCollectionViaWorkOrder = new Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection(new ServiceTypeEntityFactory());
			_alwaysFetchServiceTypeCollectionViaWorkOrder = false;
			_alreadyFetchedServiceTypeCollectionViaWorkOrder = false;
			_statusCollectionViaLoad = new Reliant.RenuOil.DAL.CollectionClasses.StatusCollection(new StatusEntityFactory());
			_alwaysFetchStatusCollectionViaLoad = false;
			_alreadyFetchedStatusCollectionViaLoad = false;
			_userCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = false;
			_userCollectionViaDeepFryerServiceChangeLog_ = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog_ = false;
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_ = false;
			_userCollectionViaRecycleServiceAction___ = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRecycleServiceAction___ = false;
			_alreadyFetchedUserCollectionViaRecycleServiceAction___ = false;
			_userCollectionViaAssetReclamationServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog = false;
			_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog = false;
			_userCollectionViaRecycleServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRecycleServiceChangeLog = false;
			_alreadyFetchedUserCollectionViaRecycleServiceChangeLog = false;
			_userCollectionViaRecycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRecycleServiceAction_ = false;
			_alreadyFetchedUserCollectionViaRecycleServiceAction_ = false;
			_userCollectionViaRecycleServiceAction__ = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRecycleServiceAction__ = false;
			_alreadyFetchedUserCollectionViaRecycleServiceAction__ = false;
			_userCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRecycleServiceAction = false;
			_alreadyFetchedUserCollectionViaRecycleServiceAction = false;
			_workOrderEmployeeCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(new WorkOrderEmployeeEntityFactory());
			_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService = false;
			_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = false;
			_workOrderServiceLocationCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(new WorkOrderServiceLocationEntityFactory());
			_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService = false;
			_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = false;



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




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 employeeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)EmployeeFieldIndex.EmployeeId].ForcedCurrentValueWrite(employeeId);
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
			return DAOFactory.CreateEmployeeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new EmployeeEntityFactory();
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


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountEmployeeAssignment____
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment____")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, "AccountEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountEmployeeAssignment_____
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment_____")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, "AccountEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountEmployeeAssignment______
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment______")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, "AccountEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountEmployeeAssignment___
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment___")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, "AccountEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountEmployeeAssignment
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, "AccountEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountEmployeeAssignment_
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment_")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, "AccountEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountEmployeeAssignment__
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment__")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, "AccountEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AssetReclamationServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAssetReclamationServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("AssetReclamationServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceChangeLogEntity, 0, null, null, null, "AssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("DeepFryerService")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, null, "DeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerServiceChangeLog_
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("DeepFryerServiceChangeLog_")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, 0, null, null, null, "DeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("DeepFryerServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, 0, null, null, null, "DeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Load' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLoad
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.LoadCollection(),
					(IEntityRelation)GetRelationsForField("Load")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.LoadEntity, 0, null, null, null, "Load", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleServiceAction' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceAction_
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection(),
					(IEntityRelation)GetRelationsForField("RecycleServiceAction_")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, "RecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleServiceAction' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceAction
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection(),
					(IEntityRelation)GetRelationsForField("RecycleServiceAction")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, "RecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("RecycleServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceChangeLogEntity, 0, null, null, null, "RecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationEmployeeAssignment____
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment____")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, "ServiceLocationEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationEmployeeAssignment_____
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment_____")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, "ServiceLocationEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationEmployeeAssignment______
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment______")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, "ServiceLocationEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationEmployeeAssignment___
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment___")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, "ServiceLocationEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, "ServiceLocationEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationEmployeeAssignment_
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment_")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, "ServiceLocationEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationEmployeeAssignment__
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationEmployeeAssignment__")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity, 0, null, null, null, "ServiceLocationEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrder
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaAccountEmployeeAssignment_____
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingTuesday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment_____"), "AccountCollectionViaAccountEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaAccountEmployeeAssignment____
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingThursday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment____"), "AccountCollectionViaAccountEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.WorkOrderEntityUsingTechnicianId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaWorkOrder"), "AccountCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaAccountEmployeeAssignment______
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingWednesday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment______"), "AccountCollectionViaAccountEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaAccountEmployeeAssignment_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingMonday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment_"), "AccountCollectionViaAccountEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaAccountEmployeeAssignment
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingFriday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment"), "AccountCollectionViaAccountEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaAccountEmployeeAssignment___
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingSunday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment___"), "AccountCollectionViaAccountEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaAccountEmployeeAssignment__
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AccountEmployeeAssignmentEntityUsingSaturday;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaAccountEmployeeAssignment__"), "AccountCollectionViaAccountEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AssetReclamationService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, 0, null, null, GetRelationsForField("AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog"), "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, GetRelationsForField("DeepFryerCollectionViaDeepFryerService"), "DeepFryerCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerServiceCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, GetRelationsForField("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog"), "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingServicedBy;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, GetRelationsForField("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_"), "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction"), "RecycleServiceCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceChangeLog"), "RecycleServiceCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction_"), "RecycleServiceCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleTypeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction"), "RecycleTypeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleTypeCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction_"), "RecycleTypeCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingTuesday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment_"), "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingMonday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment"), "ServiceLocationCollectionViaServiceLocationEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment_____
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingSaturday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____"), "ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog"), "ServiceLocationCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerService"), "ServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment______
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingSunday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment______"), "ServiceLocationCollectionViaServiceLocationEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment____
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingFriday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment____"), "ServiceLocationCollectionViaServiceLocationEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment__
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingWednesday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment__"), "ServiceLocationCollectionViaServiceLocationEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaServiceLocationEmployeeAssignment___
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.ServiceLocationEmployeeAssignmentEntityUsingThursday;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationEmployeeAssignment___"), "ServiceLocationCollectionViaServiceLocationEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingServicedBy;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog_"), "ServiceLocationCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceTypeCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.WorkOrderEntityUsingTechnicianId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, 0, null, null, GetRelationsForField("ServiceTypeCollectionViaWorkOrder"), "ServiceTypeCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Status' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathStatusCollectionViaLoad
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.LoadEntityUsingEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "Load_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.StatusCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.StatusEntity, 0, null, null, GetRelationsForField("StatusCollectionViaLoad"), "StatusCollectionViaLoad", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog"), "UserCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceChangeLogEntityUsingServicedBy;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog_"), "UserCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRecycleServiceAction___
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction___"), "UserCollectionViaRecycleServiceAction___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaAssetReclamationServiceChangeLog"), "UserCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceChangeLog"), "UserCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingActionEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction_"), "UserCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRecycleServiceAction__
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction__"), "UserCollectionViaRecycleServiceAction__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.RecycleServiceActionEntityUsingLastChangedByEmployeeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction"), "UserCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, GetRelationsForField("WorkOrderEmployeeCollectionViaDeepFryerService"), "WorkOrderEmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = EmployeeEntity.Relations.DeepFryerServiceEntityUsingServicedby;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, GetRelationsForField("WorkOrderServiceLocationCollectionViaDeepFryerService"), "WorkOrderServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "EmployeeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return EmployeeEntity.CustomProperties;}
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
			set	{ SetValue((int)EmployeeFieldIndex.EmployeeId, value, true); }
		}
		/// <summary> The FirstName property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.FirstName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.FirstName, value, true); }
		}
		/// <summary> The MiddleName property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."MiddleName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MiddleName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.MiddleName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.MiddleName, value, true); }
		}
		/// <summary> The LastName property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.LastName, true); }
			set	{ SetValue((int)EmployeeFieldIndex.LastName, value, true); }
		}
		/// <summary> The Username property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Username"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Username
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Username, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Username, value, true); }
		}
		/// <summary> The Password property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): Binary, 0, 0, 16<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Password
		{
			get { return (System.Byte[])GetValue((int)EmployeeFieldIndex.Password, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Password, value, true); }
		}
		/// <summary> The Ssn property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."SSN"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 9<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Ssn
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Ssn, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Ssn, value, true); }
		}
		/// <summary> The EmployeeNo property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."EmployeeNo"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmployeeNo
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.EmployeeNo, true); }
			set	{ SetValue((int)EmployeeFieldIndex.EmployeeNo, value, true); }
		}
		/// <summary> The DateOfBirth property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."DateOfBirth"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateOfBirth
		{
			get { return (Nullable<System.DateTime>)GetValue((int)EmployeeFieldIndex.DateOfBirth, false); }
			set	{ SetValue((int)EmployeeFieldIndex.DateOfBirth, value, true); }
		}
		/// <summary> The Address1 property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Address1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address1
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Address1, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Address1, value, true); }
		}
		/// <summary> The Address2 property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Address2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address2
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Address2, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Address2, value, true); }
		}
		/// <summary> The City property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.City, true); }
			set	{ SetValue((int)EmployeeFieldIndex.City, value, true); }
		}
		/// <summary> The State property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."State"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String State
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.State, true); }
			set	{ SetValue((int)EmployeeFieldIndex.State, value, true); }
		}
		/// <summary> The IntlState property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."IntlState"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String IntlState
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.IntlState, true); }
			set	{ SetValue((int)EmployeeFieldIndex.IntlState, value, true); }
		}
		/// <summary> The ZipCode property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."ZipCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ZipCode
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.ZipCode, true); }
			set	{ SetValue((int)EmployeeFieldIndex.ZipCode, value, true); }
		}
		/// <summary> The Phone property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Phone, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Phone, value, true); }
		}
		/// <summary> The Mobile property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."Mobile"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Mobile
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Mobile, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Mobile, value, true); }
		}
		/// <summary> The EmailAddress property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."EmailAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmailAddress
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.EmailAddress, true); }
			set	{ SetValue((int)EmployeeFieldIndex.EmailAddress, value, true); }
		}
		/// <summary> The AssignOilService property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."AssignOilService"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> AssignOilService
		{
			get { return (Nullable<System.Boolean>)GetValue((int)EmployeeFieldIndex.AssignOilService, false); }
			set	{ SetValue((int)EmployeeFieldIndex.AssignOilService, value, true); }
		}
		/// <summary> The AssignRecycleService property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."AssignRecycleService"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> AssignRecycleService
		{
			get { return (Nullable<System.Boolean>)GetValue((int)EmployeeFieldIndex.AssignRecycleService, false); }
			set	{ SetValue((int)EmployeeFieldIndex.AssignRecycleService, value, true); }
		}
		/// <summary> The IsActive property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.IsActive, true); }
			set	{ SetValue((int)EmployeeFieldIndex.IsActive, value, true); }
		}
		/// <summary> The IsEnabled property of the Entity Employee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Employee"."IsEnabled"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsEnabled
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.IsEnabled, true); }
			set	{ SetValue((int)EmployeeFieldIndex.IsEnabled, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountEmployeeAssignment____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection AccountEmployeeAssignment____
		{
			get	{ return GetMultiAccountEmployeeAssignment____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountEmployeeAssignment____. When set to true, AccountEmployeeAssignment____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountEmployeeAssignment____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountEmployeeAssignment____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountEmployeeAssignment____
		{
			get	{ return _alwaysFetchAccountEmployeeAssignment____; }
			set	{ _alwaysFetchAccountEmployeeAssignment____ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountEmployeeAssignment____ already has been fetched. Setting this property to false when AccountEmployeeAssignment____ has been fetched
		/// will clear the AccountEmployeeAssignment____ collection well. Setting this property to true while AccountEmployeeAssignment____ hasn't been fetched disables lazy loading for AccountEmployeeAssignment____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountEmployeeAssignment____
		{
			get { return _alreadyFetchedAccountEmployeeAssignment____;}
			set 
			{
				if(_alreadyFetchedAccountEmployeeAssignment____ && !value && (_accountEmployeeAssignment____ != null))
				{
					_accountEmployeeAssignment____.Clear();
				}
				_alreadyFetchedAccountEmployeeAssignment____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountEmployeeAssignment_____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection AccountEmployeeAssignment_____
		{
			get	{ return GetMultiAccountEmployeeAssignment_____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountEmployeeAssignment_____. When set to true, AccountEmployeeAssignment_____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountEmployeeAssignment_____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountEmployeeAssignment_____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountEmployeeAssignment_____
		{
			get	{ return _alwaysFetchAccountEmployeeAssignment_____; }
			set	{ _alwaysFetchAccountEmployeeAssignment_____ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountEmployeeAssignment_____ already has been fetched. Setting this property to false when AccountEmployeeAssignment_____ has been fetched
		/// will clear the AccountEmployeeAssignment_____ collection well. Setting this property to true while AccountEmployeeAssignment_____ hasn't been fetched disables lazy loading for AccountEmployeeAssignment_____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountEmployeeAssignment_____
		{
			get { return _alreadyFetchedAccountEmployeeAssignment_____;}
			set 
			{
				if(_alreadyFetchedAccountEmployeeAssignment_____ && !value && (_accountEmployeeAssignment_____ != null))
				{
					_accountEmployeeAssignment_____.Clear();
				}
				_alreadyFetchedAccountEmployeeAssignment_____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountEmployeeAssignment______()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection AccountEmployeeAssignment______
		{
			get	{ return GetMultiAccountEmployeeAssignment______(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountEmployeeAssignment______. When set to true, AccountEmployeeAssignment______ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountEmployeeAssignment______ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountEmployeeAssignment______(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountEmployeeAssignment______
		{
			get	{ return _alwaysFetchAccountEmployeeAssignment______; }
			set	{ _alwaysFetchAccountEmployeeAssignment______ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountEmployeeAssignment______ already has been fetched. Setting this property to false when AccountEmployeeAssignment______ has been fetched
		/// will clear the AccountEmployeeAssignment______ collection well. Setting this property to true while AccountEmployeeAssignment______ hasn't been fetched disables lazy loading for AccountEmployeeAssignment______</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountEmployeeAssignment______
		{
			get { return _alreadyFetchedAccountEmployeeAssignment______;}
			set 
			{
				if(_alreadyFetchedAccountEmployeeAssignment______ && !value && (_accountEmployeeAssignment______ != null))
				{
					_accountEmployeeAssignment______.Clear();
				}
				_alreadyFetchedAccountEmployeeAssignment______ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountEmployeeAssignment___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection AccountEmployeeAssignment___
		{
			get	{ return GetMultiAccountEmployeeAssignment___(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountEmployeeAssignment___. When set to true, AccountEmployeeAssignment___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountEmployeeAssignment___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountEmployeeAssignment___(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountEmployeeAssignment___
		{
			get	{ return _alwaysFetchAccountEmployeeAssignment___; }
			set	{ _alwaysFetchAccountEmployeeAssignment___ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountEmployeeAssignment___ already has been fetched. Setting this property to false when AccountEmployeeAssignment___ has been fetched
		/// will clear the AccountEmployeeAssignment___ collection well. Setting this property to true while AccountEmployeeAssignment___ hasn't been fetched disables lazy loading for AccountEmployeeAssignment___</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountEmployeeAssignment___
		{
			get { return _alreadyFetchedAccountEmployeeAssignment___;}
			set 
			{
				if(_alreadyFetchedAccountEmployeeAssignment___ && !value && (_accountEmployeeAssignment___ != null))
				{
					_accountEmployeeAssignment___.Clear();
				}
				_alreadyFetchedAccountEmployeeAssignment___ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountEmployeeAssignment()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection AccountEmployeeAssignment
		{
			get	{ return GetMultiAccountEmployeeAssignment(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountEmployeeAssignment. When set to true, AccountEmployeeAssignment is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountEmployeeAssignment is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountEmployeeAssignment(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountEmployeeAssignment
		{
			get	{ return _alwaysFetchAccountEmployeeAssignment; }
			set	{ _alwaysFetchAccountEmployeeAssignment = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountEmployeeAssignment already has been fetched. Setting this property to false when AccountEmployeeAssignment has been fetched
		/// will clear the AccountEmployeeAssignment collection well. Setting this property to true while AccountEmployeeAssignment hasn't been fetched disables lazy loading for AccountEmployeeAssignment</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountEmployeeAssignment
		{
			get { return _alreadyFetchedAccountEmployeeAssignment;}
			set 
			{
				if(_alreadyFetchedAccountEmployeeAssignment && !value && (_accountEmployeeAssignment != null))
				{
					_accountEmployeeAssignment.Clear();
				}
				_alreadyFetchedAccountEmployeeAssignment = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountEmployeeAssignment_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection AccountEmployeeAssignment_
		{
			get	{ return GetMultiAccountEmployeeAssignment_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountEmployeeAssignment_. When set to true, AccountEmployeeAssignment_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountEmployeeAssignment_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountEmployeeAssignment_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountEmployeeAssignment_
		{
			get	{ return _alwaysFetchAccountEmployeeAssignment_; }
			set	{ _alwaysFetchAccountEmployeeAssignment_ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountEmployeeAssignment_ already has been fetched. Setting this property to false when AccountEmployeeAssignment_ has been fetched
		/// will clear the AccountEmployeeAssignment_ collection well. Setting this property to true while AccountEmployeeAssignment_ hasn't been fetched disables lazy loading for AccountEmployeeAssignment_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountEmployeeAssignment_
		{
			get { return _alreadyFetchedAccountEmployeeAssignment_;}
			set 
			{
				if(_alreadyFetchedAccountEmployeeAssignment_ && !value && (_accountEmployeeAssignment_ != null))
				{
					_accountEmployeeAssignment_.Clear();
				}
				_alreadyFetchedAccountEmployeeAssignment_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountEmployeeAssignment__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection AccountEmployeeAssignment__
		{
			get	{ return GetMultiAccountEmployeeAssignment__(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountEmployeeAssignment__. When set to true, AccountEmployeeAssignment__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountEmployeeAssignment__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountEmployeeAssignment__(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountEmployeeAssignment__
		{
			get	{ return _alwaysFetchAccountEmployeeAssignment__; }
			set	{ _alwaysFetchAccountEmployeeAssignment__ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountEmployeeAssignment__ already has been fetched. Setting this property to false when AccountEmployeeAssignment__ has been fetched
		/// will clear the AccountEmployeeAssignment__ collection well. Setting this property to true while AccountEmployeeAssignment__ hasn't been fetched disables lazy loading for AccountEmployeeAssignment__</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountEmployeeAssignment__
		{
			get { return _alreadyFetchedAccountEmployeeAssignment__;}
			set 
			{
				if(_alreadyFetchedAccountEmployeeAssignment__ && !value && (_accountEmployeeAssignment__ != null))
				{
					_accountEmployeeAssignment__.Clear();
				}
				_alreadyFetchedAccountEmployeeAssignment__ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAssetReclamationServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection AssetReclamationServiceChangeLog
		{
			get	{ return GetMultiAssetReclamationServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AssetReclamationServiceChangeLog. When set to true, AssetReclamationServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AssetReclamationServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiAssetReclamationServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAssetReclamationServiceChangeLog
		{
			get	{ return _alwaysFetchAssetReclamationServiceChangeLog; }
			set	{ _alwaysFetchAssetReclamationServiceChangeLog = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AssetReclamationServiceChangeLog already has been fetched. Setting this property to false when AssetReclamationServiceChangeLog has been fetched
		/// will clear the AssetReclamationServiceChangeLog collection well. Setting this property to true while AssetReclamationServiceChangeLog hasn't been fetched disables lazy loading for AssetReclamationServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAssetReclamationServiceChangeLog
		{
			get { return _alreadyFetchedAssetReclamationServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedAssetReclamationServiceChangeLog && !value && (_assetReclamationServiceChangeLog != null))
				{
					_assetReclamationServiceChangeLog.Clear();
				}
				_alreadyFetchedAssetReclamationServiceChangeLog = value;
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryerServiceChangeLog_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection DeepFryerServiceChangeLog_
		{
			get	{ return GetMultiDeepFryerServiceChangeLog_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerServiceChangeLog_. When set to true, DeepFryerServiceChangeLog_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerServiceChangeLog_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryerServiceChangeLog_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerServiceChangeLog_
		{
			get	{ return _alwaysFetchDeepFryerServiceChangeLog_; }
			set	{ _alwaysFetchDeepFryerServiceChangeLog_ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerServiceChangeLog_ already has been fetched. Setting this property to false when DeepFryerServiceChangeLog_ has been fetched
		/// will clear the DeepFryerServiceChangeLog_ collection well. Setting this property to true while DeepFryerServiceChangeLog_ hasn't been fetched disables lazy loading for DeepFryerServiceChangeLog_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerServiceChangeLog_
		{
			get { return _alreadyFetchedDeepFryerServiceChangeLog_;}
			set 
			{
				if(_alreadyFetchedDeepFryerServiceChangeLog_ && !value && (_deepFryerServiceChangeLog_ != null))
				{
					_deepFryerServiceChangeLog_.Clear();
				}
				_alreadyFetchedDeepFryerServiceChangeLog_ = value;
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
		/// <summary> Retrieves all related entities of type 'LoadEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLoad()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.LoadCollection Load
		{
			get	{ return GetMultiLoad(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Load. When set to true, Load is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Load is accessed. You can always execute
		/// a forced fetch by calling GetMultiLoad(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLoad
		{
			get	{ return _alwaysFetchLoad; }
			set	{ _alwaysFetchLoad = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Load already has been fetched. Setting this property to false when Load has been fetched
		/// will clear the Load collection well. Setting this property to true while Load hasn't been fetched disables lazy loading for Load</summary>
		[Browsable(false)]
		public bool AlreadyFetchedLoad
		{
			get { return _alreadyFetchedLoad;}
			set 
			{
				if(_alreadyFetchedLoad && !value && (_load != null))
				{
					_load.Clear();
				}
				_alreadyFetchedLoad = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleServiceActionEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleServiceAction_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection RecycleServiceAction_
		{
			get	{ return GetMultiRecycleServiceAction_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleServiceAction_. When set to true, RecycleServiceAction_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleServiceAction_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleServiceAction_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleServiceAction_
		{
			get	{ return _alwaysFetchRecycleServiceAction_; }
			set	{ _alwaysFetchRecycleServiceAction_ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleServiceAction_ already has been fetched. Setting this property to false when RecycleServiceAction_ has been fetched
		/// will clear the RecycleServiceAction_ collection well. Setting this property to true while RecycleServiceAction_ hasn't been fetched disables lazy loading for RecycleServiceAction_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleServiceAction_
		{
			get { return _alreadyFetchedRecycleServiceAction_;}
			set 
			{
				if(_alreadyFetchedRecycleServiceAction_ && !value && (_recycleServiceAction_ != null))
				{
					_recycleServiceAction_.Clear();
				}
				_alreadyFetchedRecycleServiceAction_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleServiceActionEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleServiceAction()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection RecycleServiceAction
		{
			get	{ return GetMultiRecycleServiceAction(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleServiceAction. When set to true, RecycleServiceAction is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleServiceAction is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleServiceAction(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleServiceAction
		{
			get	{ return _alwaysFetchRecycleServiceAction; }
			set	{ _alwaysFetchRecycleServiceAction = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleServiceAction already has been fetched. Setting this property to false when RecycleServiceAction has been fetched
		/// will clear the RecycleServiceAction collection well. Setting this property to true while RecycleServiceAction hasn't been fetched disables lazy loading for RecycleServiceAction</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleServiceAction
		{
			get { return _alreadyFetchedRecycleServiceAction;}
			set 
			{
				if(_alreadyFetchedRecycleServiceAction && !value && (_recycleServiceAction != null))
				{
					_recycleServiceAction.Clear();
				}
				_alreadyFetchedRecycleServiceAction = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection RecycleServiceChangeLog
		{
			get	{ return GetMultiRecycleServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleServiceChangeLog. When set to true, RecycleServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleServiceChangeLog
		{
			get	{ return _alwaysFetchRecycleServiceChangeLog; }
			set	{ _alwaysFetchRecycleServiceChangeLog = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleServiceChangeLog already has been fetched. Setting this property to false when RecycleServiceChangeLog has been fetched
		/// will clear the RecycleServiceChangeLog collection well. Setting this property to true while RecycleServiceChangeLog hasn't been fetched disables lazy loading for RecycleServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleServiceChangeLog
		{
			get { return _alreadyFetchedRecycleServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedRecycleServiceChangeLog && !value && (_recycleServiceChangeLog != null))
				{
					_recycleServiceChangeLog.Clear();
				}
				_alreadyFetchedRecycleServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationEmployeeAssignment____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection ServiceLocationEmployeeAssignment____
		{
			get	{ return GetMultiServiceLocationEmployeeAssignment____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationEmployeeAssignment____. When set to true, ServiceLocationEmployeeAssignment____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationEmployeeAssignment____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationEmployeeAssignment____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationEmployeeAssignment____
		{
			get	{ return _alwaysFetchServiceLocationEmployeeAssignment____; }
			set	{ _alwaysFetchServiceLocationEmployeeAssignment____ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationEmployeeAssignment____ already has been fetched. Setting this property to false when ServiceLocationEmployeeAssignment____ has been fetched
		/// will clear the ServiceLocationEmployeeAssignment____ collection well. Setting this property to true while ServiceLocationEmployeeAssignment____ hasn't been fetched disables lazy loading for ServiceLocationEmployeeAssignment____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationEmployeeAssignment____
		{
			get { return _alreadyFetchedServiceLocationEmployeeAssignment____;}
			set 
			{
				if(_alreadyFetchedServiceLocationEmployeeAssignment____ && !value && (_serviceLocationEmployeeAssignment____ != null))
				{
					_serviceLocationEmployeeAssignment____.Clear();
				}
				_alreadyFetchedServiceLocationEmployeeAssignment____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationEmployeeAssignment_____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection ServiceLocationEmployeeAssignment_____
		{
			get	{ return GetMultiServiceLocationEmployeeAssignment_____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationEmployeeAssignment_____. When set to true, ServiceLocationEmployeeAssignment_____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationEmployeeAssignment_____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationEmployeeAssignment_____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationEmployeeAssignment_____
		{
			get	{ return _alwaysFetchServiceLocationEmployeeAssignment_____; }
			set	{ _alwaysFetchServiceLocationEmployeeAssignment_____ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationEmployeeAssignment_____ already has been fetched. Setting this property to false when ServiceLocationEmployeeAssignment_____ has been fetched
		/// will clear the ServiceLocationEmployeeAssignment_____ collection well. Setting this property to true while ServiceLocationEmployeeAssignment_____ hasn't been fetched disables lazy loading for ServiceLocationEmployeeAssignment_____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationEmployeeAssignment_____
		{
			get { return _alreadyFetchedServiceLocationEmployeeAssignment_____;}
			set 
			{
				if(_alreadyFetchedServiceLocationEmployeeAssignment_____ && !value && (_serviceLocationEmployeeAssignment_____ != null))
				{
					_serviceLocationEmployeeAssignment_____.Clear();
				}
				_alreadyFetchedServiceLocationEmployeeAssignment_____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationEmployeeAssignment______()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection ServiceLocationEmployeeAssignment______
		{
			get	{ return GetMultiServiceLocationEmployeeAssignment______(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationEmployeeAssignment______. When set to true, ServiceLocationEmployeeAssignment______ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationEmployeeAssignment______ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationEmployeeAssignment______(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationEmployeeAssignment______
		{
			get	{ return _alwaysFetchServiceLocationEmployeeAssignment______; }
			set	{ _alwaysFetchServiceLocationEmployeeAssignment______ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationEmployeeAssignment______ already has been fetched. Setting this property to false when ServiceLocationEmployeeAssignment______ has been fetched
		/// will clear the ServiceLocationEmployeeAssignment______ collection well. Setting this property to true while ServiceLocationEmployeeAssignment______ hasn't been fetched disables lazy loading for ServiceLocationEmployeeAssignment______</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationEmployeeAssignment______
		{
			get { return _alreadyFetchedServiceLocationEmployeeAssignment______;}
			set 
			{
				if(_alreadyFetchedServiceLocationEmployeeAssignment______ && !value && (_serviceLocationEmployeeAssignment______ != null))
				{
					_serviceLocationEmployeeAssignment______.Clear();
				}
				_alreadyFetchedServiceLocationEmployeeAssignment______ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationEmployeeAssignment___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection ServiceLocationEmployeeAssignment___
		{
			get	{ return GetMultiServiceLocationEmployeeAssignment___(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationEmployeeAssignment___. When set to true, ServiceLocationEmployeeAssignment___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationEmployeeAssignment___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationEmployeeAssignment___(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationEmployeeAssignment___
		{
			get	{ return _alwaysFetchServiceLocationEmployeeAssignment___; }
			set	{ _alwaysFetchServiceLocationEmployeeAssignment___ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationEmployeeAssignment___ already has been fetched. Setting this property to false when ServiceLocationEmployeeAssignment___ has been fetched
		/// will clear the ServiceLocationEmployeeAssignment___ collection well. Setting this property to true while ServiceLocationEmployeeAssignment___ hasn't been fetched disables lazy loading for ServiceLocationEmployeeAssignment___</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationEmployeeAssignment___
		{
			get { return _alreadyFetchedServiceLocationEmployeeAssignment___;}
			set 
			{
				if(_alreadyFetchedServiceLocationEmployeeAssignment___ && !value && (_serviceLocationEmployeeAssignment___ != null))
				{
					_serviceLocationEmployeeAssignment___.Clear();
				}
				_alreadyFetchedServiceLocationEmployeeAssignment___ = value;
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
		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationEmployeeAssignment_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection ServiceLocationEmployeeAssignment_
		{
			get	{ return GetMultiServiceLocationEmployeeAssignment_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationEmployeeAssignment_. When set to true, ServiceLocationEmployeeAssignment_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationEmployeeAssignment_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationEmployeeAssignment_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationEmployeeAssignment_
		{
			get	{ return _alwaysFetchServiceLocationEmployeeAssignment_; }
			set	{ _alwaysFetchServiceLocationEmployeeAssignment_ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationEmployeeAssignment_ already has been fetched. Setting this property to false when ServiceLocationEmployeeAssignment_ has been fetched
		/// will clear the ServiceLocationEmployeeAssignment_ collection well. Setting this property to true while ServiceLocationEmployeeAssignment_ hasn't been fetched disables lazy loading for ServiceLocationEmployeeAssignment_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationEmployeeAssignment_
		{
			get { return _alreadyFetchedServiceLocationEmployeeAssignment_;}
			set 
			{
				if(_alreadyFetchedServiceLocationEmployeeAssignment_ && !value && (_serviceLocationEmployeeAssignment_ != null))
				{
					_serviceLocationEmployeeAssignment_.Clear();
				}
				_alreadyFetchedServiceLocationEmployeeAssignment_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEmployeeAssignmentEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationEmployeeAssignment__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationEmployeeAssignmentCollection ServiceLocationEmployeeAssignment__
		{
			get	{ return GetMultiServiceLocationEmployeeAssignment__(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationEmployeeAssignment__. When set to true, ServiceLocationEmployeeAssignment__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationEmployeeAssignment__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationEmployeeAssignment__(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationEmployeeAssignment__
		{
			get	{ return _alwaysFetchServiceLocationEmployeeAssignment__; }
			set	{ _alwaysFetchServiceLocationEmployeeAssignment__ = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationEmployeeAssignment__ already has been fetched. Setting this property to false when ServiceLocationEmployeeAssignment__ has been fetched
		/// will clear the ServiceLocationEmployeeAssignment__ collection well. Setting this property to true while ServiceLocationEmployeeAssignment__ hasn't been fetched disables lazy loading for ServiceLocationEmployeeAssignment__</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationEmployeeAssignment__
		{
			get { return _alreadyFetchedServiceLocationEmployeeAssignment__;}
			set 
			{
				if(_alreadyFetchedServiceLocationEmployeeAssignment__ && !value && (_serviceLocationEmployeeAssignment__ != null))
				{
					_serviceLocationEmployeeAssignment__.Clear();
				}
				_alreadyFetchedServiceLocationEmployeeAssignment__ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection WorkOrder
		{
			get	{ return GetMultiWorkOrder(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrder. When set to true, WorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrder
		{
			get	{ return _alwaysFetchWorkOrder; }
			set	{ _alwaysFetchWorkOrder = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrder already has been fetched. Setting this property to false when WorkOrder has been fetched
		/// will clear the WorkOrder collection well. Setting this property to true while WorkOrder hasn't been fetched disables lazy loading for WorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrder
		{
			get { return _alreadyFetchedWorkOrder;}
			set 
			{
				if(_alreadyFetchedWorkOrder && !value && (_workOrder != null))
				{
					_workOrder.Clear();
				}
				_alreadyFetchedWorkOrder = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaAccountEmployeeAssignment_____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaAccountEmployeeAssignment_____
		{
			get { return GetMultiAccountCollectionViaAccountEmployeeAssignment_____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaAccountEmployeeAssignment_____. When set to true, AccountCollectionViaAccountEmployeeAssignment_____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaAccountEmployeeAssignment_____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaAccountEmployeeAssignment_____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaAccountEmployeeAssignment_____
		{
			get	{ return _alwaysFetchAccountCollectionViaAccountEmployeeAssignment_____; }
			set	{ _alwaysFetchAccountCollectionViaAccountEmployeeAssignment_____ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaAccountEmployeeAssignment_____ already has been fetched. Setting this property to false when AccountCollectionViaAccountEmployeeAssignment_____ has been fetched
		/// will clear the AccountCollectionViaAccountEmployeeAssignment_____ collection well. Setting this property to true while AccountCollectionViaAccountEmployeeAssignment_____ hasn't been fetched disables lazy loading for AccountCollectionViaAccountEmployeeAssignment_____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____
		{
			get { return _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____ && !value && (_accountCollectionViaAccountEmployeeAssignment_____ != null))
				{
					_accountCollectionViaAccountEmployeeAssignment_____.Clear();
				}
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaAccountEmployeeAssignment____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaAccountEmployeeAssignment____
		{
			get { return GetMultiAccountCollectionViaAccountEmployeeAssignment____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaAccountEmployeeAssignment____. When set to true, AccountCollectionViaAccountEmployeeAssignment____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaAccountEmployeeAssignment____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaAccountEmployeeAssignment____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaAccountEmployeeAssignment____
		{
			get	{ return _alwaysFetchAccountCollectionViaAccountEmployeeAssignment____; }
			set	{ _alwaysFetchAccountCollectionViaAccountEmployeeAssignment____ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaAccountEmployeeAssignment____ already has been fetched. Setting this property to false when AccountCollectionViaAccountEmployeeAssignment____ has been fetched
		/// will clear the AccountCollectionViaAccountEmployeeAssignment____ collection well. Setting this property to true while AccountCollectionViaAccountEmployeeAssignment____ hasn't been fetched disables lazy loading for AccountCollectionViaAccountEmployeeAssignment____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaAccountEmployeeAssignment____
		{
			get { return _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____ && !value && (_accountCollectionViaAccountEmployeeAssignment____ != null))
				{
					_accountCollectionViaAccountEmployeeAssignment____.Clear();
				}
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaWorkOrder
		{
			get { return GetMultiAccountCollectionViaWorkOrder(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaWorkOrder. When set to true, AccountCollectionViaWorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaWorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaWorkOrder
		{
			get	{ return _alwaysFetchAccountCollectionViaWorkOrder; }
			set	{ _alwaysFetchAccountCollectionViaWorkOrder = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaWorkOrder already has been fetched. Setting this property to false when AccountCollectionViaWorkOrder has been fetched
		/// will clear the AccountCollectionViaWorkOrder collection well. Setting this property to true while AccountCollectionViaWorkOrder hasn't been fetched disables lazy loading for AccountCollectionViaWorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaWorkOrder
		{
			get { return _alreadyFetchedAccountCollectionViaWorkOrder;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaWorkOrder && !value && (_accountCollectionViaWorkOrder != null))
				{
					_accountCollectionViaWorkOrder.Clear();
				}
				_alreadyFetchedAccountCollectionViaWorkOrder = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaAccountEmployeeAssignment______()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaAccountEmployeeAssignment______
		{
			get { return GetMultiAccountCollectionViaAccountEmployeeAssignment______(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaAccountEmployeeAssignment______. When set to true, AccountCollectionViaAccountEmployeeAssignment______ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaAccountEmployeeAssignment______ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaAccountEmployeeAssignment______(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaAccountEmployeeAssignment______
		{
			get	{ return _alwaysFetchAccountCollectionViaAccountEmployeeAssignment______; }
			set	{ _alwaysFetchAccountCollectionViaAccountEmployeeAssignment______ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaAccountEmployeeAssignment______ already has been fetched. Setting this property to false when AccountCollectionViaAccountEmployeeAssignment______ has been fetched
		/// will clear the AccountCollectionViaAccountEmployeeAssignment______ collection well. Setting this property to true while AccountCollectionViaAccountEmployeeAssignment______ hasn't been fetched disables lazy loading for AccountCollectionViaAccountEmployeeAssignment______</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaAccountEmployeeAssignment______
		{
			get { return _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______ && !value && (_accountCollectionViaAccountEmployeeAssignment______ != null))
				{
					_accountCollectionViaAccountEmployeeAssignment______.Clear();
				}
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment______ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaAccountEmployeeAssignment_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaAccountEmployeeAssignment_
		{
			get { return GetMultiAccountCollectionViaAccountEmployeeAssignment_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaAccountEmployeeAssignment_. When set to true, AccountCollectionViaAccountEmployeeAssignment_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaAccountEmployeeAssignment_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaAccountEmployeeAssignment_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaAccountEmployeeAssignment_
		{
			get	{ return _alwaysFetchAccountCollectionViaAccountEmployeeAssignment_; }
			set	{ _alwaysFetchAccountCollectionViaAccountEmployeeAssignment_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaAccountEmployeeAssignment_ already has been fetched. Setting this property to false when AccountCollectionViaAccountEmployeeAssignment_ has been fetched
		/// will clear the AccountCollectionViaAccountEmployeeAssignment_ collection well. Setting this property to true while AccountCollectionViaAccountEmployeeAssignment_ hasn't been fetched disables lazy loading for AccountCollectionViaAccountEmployeeAssignment_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaAccountEmployeeAssignment_
		{
			get { return _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_ && !value && (_accountCollectionViaAccountEmployeeAssignment_ != null))
				{
					_accountCollectionViaAccountEmployeeAssignment_.Clear();
				}
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaAccountEmployeeAssignment()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaAccountEmployeeAssignment
		{
			get { return GetMultiAccountCollectionViaAccountEmployeeAssignment(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaAccountEmployeeAssignment. When set to true, AccountCollectionViaAccountEmployeeAssignment is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaAccountEmployeeAssignment is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaAccountEmployeeAssignment(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaAccountEmployeeAssignment
		{
			get	{ return _alwaysFetchAccountCollectionViaAccountEmployeeAssignment; }
			set	{ _alwaysFetchAccountCollectionViaAccountEmployeeAssignment = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaAccountEmployeeAssignment already has been fetched. Setting this property to false when AccountCollectionViaAccountEmployeeAssignment has been fetched
		/// will clear the AccountCollectionViaAccountEmployeeAssignment collection well. Setting this property to true while AccountCollectionViaAccountEmployeeAssignment hasn't been fetched disables lazy loading for AccountCollectionViaAccountEmployeeAssignment</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaAccountEmployeeAssignment
		{
			get { return _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment && !value && (_accountCollectionViaAccountEmployeeAssignment != null))
				{
					_accountCollectionViaAccountEmployeeAssignment.Clear();
				}
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaAccountEmployeeAssignment___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaAccountEmployeeAssignment___
		{
			get { return GetMultiAccountCollectionViaAccountEmployeeAssignment___(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaAccountEmployeeAssignment___. When set to true, AccountCollectionViaAccountEmployeeAssignment___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaAccountEmployeeAssignment___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaAccountEmployeeAssignment___(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaAccountEmployeeAssignment___
		{
			get	{ return _alwaysFetchAccountCollectionViaAccountEmployeeAssignment___; }
			set	{ _alwaysFetchAccountCollectionViaAccountEmployeeAssignment___ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaAccountEmployeeAssignment___ already has been fetched. Setting this property to false when AccountCollectionViaAccountEmployeeAssignment___ has been fetched
		/// will clear the AccountCollectionViaAccountEmployeeAssignment___ collection well. Setting this property to true while AccountCollectionViaAccountEmployeeAssignment___ hasn't been fetched disables lazy loading for AccountCollectionViaAccountEmployeeAssignment___</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaAccountEmployeeAssignment___
		{
			get { return _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___ && !value && (_accountCollectionViaAccountEmployeeAssignment___ != null))
				{
					_accountCollectionViaAccountEmployeeAssignment___.Clear();
				}
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment___ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaAccountEmployeeAssignment__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaAccountEmployeeAssignment__
		{
			get { return GetMultiAccountCollectionViaAccountEmployeeAssignment__(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaAccountEmployeeAssignment__. When set to true, AccountCollectionViaAccountEmployeeAssignment__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaAccountEmployeeAssignment__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaAccountEmployeeAssignment__(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaAccountEmployeeAssignment__
		{
			get	{ return _alwaysFetchAccountCollectionViaAccountEmployeeAssignment__; }
			set	{ _alwaysFetchAccountCollectionViaAccountEmployeeAssignment__ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaAccountEmployeeAssignment__ already has been fetched. Setting this property to false when AccountCollectionViaAccountEmployeeAssignment__ has been fetched
		/// will clear the AccountCollectionViaAccountEmployeeAssignment__ collection well. Setting this property to true while AccountCollectionViaAccountEmployeeAssignment__ hasn't been fetched disables lazy loading for AccountCollectionViaAccountEmployeeAssignment__</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaAccountEmployeeAssignment__
		{
			get { return _alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__ && !value && (_accountCollectionViaAccountEmployeeAssignment__ != null))
				{
					_accountCollectionViaAccountEmployeeAssignment__.Clear();
				}
				_alreadyFetchedAccountCollectionViaAccountEmployeeAssignment__ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog
		{
			get { return GetMultiAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog. When set to true, AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog
		{
			get	{ return _alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog; }
			set	{ _alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog already has been fetched. Setting this property to false when AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog has been fetched
		/// will clear the AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog collection well. Setting this property to true while AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog hasn't been fetched disables lazy loading for AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog
		{
			get { return _alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog && !value && (_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog != null))
				{
					_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.Clear();
				}
				_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = value;
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
		/// <summary> Retrieves all related entities of type 'DeepFryerServiceEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_
		{
			get { return GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_. When set to true, DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_
		{
			get	{ return _alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_; }
			set	{ _alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ already has been fetched. Setting this property to false when DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ has been fetched
		/// will clear the DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ collection well. Setting this property to true while DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ hasn't been fetched disables lazy loading for DeepFryerServiceCollectionViaDeepFryerServiceChangeLog_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_
		{
			get { return _alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_;}
			set 
			{
				if(_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ && !value && (_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_ != null))
				{
					_deepFryerServiceCollectionViaDeepFryerServiceChangeLog_.Clear();
				}
				_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleServiceCollectionViaRecycleServiceAction()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection RecycleServiceCollectionViaRecycleServiceAction
		{
			get { return GetMultiRecycleServiceCollectionViaRecycleServiceAction(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleServiceCollectionViaRecycleServiceAction. When set to true, RecycleServiceCollectionViaRecycleServiceAction is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleServiceCollectionViaRecycleServiceAction is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleServiceCollectionViaRecycleServiceAction(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleServiceCollectionViaRecycleServiceAction
		{
			get	{ return _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction; }
			set	{ _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleServiceCollectionViaRecycleServiceAction already has been fetched. Setting this property to false when RecycleServiceCollectionViaRecycleServiceAction has been fetched
		/// will clear the RecycleServiceCollectionViaRecycleServiceAction collection well. Setting this property to true while RecycleServiceCollectionViaRecycleServiceAction hasn't been fetched disables lazy loading for RecycleServiceCollectionViaRecycleServiceAction</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleServiceCollectionViaRecycleServiceAction
		{
			get { return _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction;}
			set 
			{
				if(_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction && !value && (_recycleServiceCollectionViaRecycleServiceAction != null))
				{
					_recycleServiceCollectionViaRecycleServiceAction.Clear();
				}
				_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleServiceCollectionViaRecycleServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection RecycleServiceCollectionViaRecycleServiceChangeLog
		{
			get { return GetMultiRecycleServiceCollectionViaRecycleServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleServiceCollectionViaRecycleServiceChangeLog. When set to true, RecycleServiceCollectionViaRecycleServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleServiceCollectionViaRecycleServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleServiceCollectionViaRecycleServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog
		{
			get	{ return _alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog; }
			set	{ _alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleServiceCollectionViaRecycleServiceChangeLog already has been fetched. Setting this property to false when RecycleServiceCollectionViaRecycleServiceChangeLog has been fetched
		/// will clear the RecycleServiceCollectionViaRecycleServiceChangeLog collection well. Setting this property to true while RecycleServiceCollectionViaRecycleServiceChangeLog hasn't been fetched disables lazy loading for RecycleServiceCollectionViaRecycleServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog
		{
			get { return _alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog && !value && (_recycleServiceCollectionViaRecycleServiceChangeLog != null))
				{
					_recycleServiceCollectionViaRecycleServiceChangeLog.Clear();
				}
				_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleServiceCollectionViaRecycleServiceAction_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection RecycleServiceCollectionViaRecycleServiceAction_
		{
			get { return GetMultiRecycleServiceCollectionViaRecycleServiceAction_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleServiceCollectionViaRecycleServiceAction_. When set to true, RecycleServiceCollectionViaRecycleServiceAction_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleServiceCollectionViaRecycleServiceAction_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleServiceCollectionViaRecycleServiceAction_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleServiceCollectionViaRecycleServiceAction_
		{
			get	{ return _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_; }
			set	{ _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleServiceCollectionViaRecycleServiceAction_ already has been fetched. Setting this property to false when RecycleServiceCollectionViaRecycleServiceAction_ has been fetched
		/// will clear the RecycleServiceCollectionViaRecycleServiceAction_ collection well. Setting this property to true while RecycleServiceCollectionViaRecycleServiceAction_ hasn't been fetched disables lazy loading for RecycleServiceCollectionViaRecycleServiceAction_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_
		{
			get { return _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_;}
			set 
			{
				if(_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ && !value && (_recycleServiceCollectionViaRecycleServiceAction_ != null))
				{
					_recycleServiceCollectionViaRecycleServiceAction_.Clear();
				}
				_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleTypeCollectionViaRecycleServiceAction()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection RecycleTypeCollectionViaRecycleServiceAction
		{
			get { return GetMultiRecycleTypeCollectionViaRecycleServiceAction(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleTypeCollectionViaRecycleServiceAction. When set to true, RecycleTypeCollectionViaRecycleServiceAction is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleTypeCollectionViaRecycleServiceAction is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleTypeCollectionViaRecycleServiceAction(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleTypeCollectionViaRecycleServiceAction
		{
			get	{ return _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction; }
			set	{ _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleTypeCollectionViaRecycleServiceAction already has been fetched. Setting this property to false when RecycleTypeCollectionViaRecycleServiceAction has been fetched
		/// will clear the RecycleTypeCollectionViaRecycleServiceAction collection well. Setting this property to true while RecycleTypeCollectionViaRecycleServiceAction hasn't been fetched disables lazy loading for RecycleTypeCollectionViaRecycleServiceAction</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleTypeCollectionViaRecycleServiceAction
		{
			get { return _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction;}
			set 
			{
				if(_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction && !value && (_recycleTypeCollectionViaRecycleServiceAction != null))
				{
					_recycleTypeCollectionViaRecycleServiceAction.Clear();
				}
				_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleTypeCollectionViaRecycleServiceAction_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection RecycleTypeCollectionViaRecycleServiceAction_
		{
			get { return GetMultiRecycleTypeCollectionViaRecycleServiceAction_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleTypeCollectionViaRecycleServiceAction_. When set to true, RecycleTypeCollectionViaRecycleServiceAction_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleTypeCollectionViaRecycleServiceAction_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleTypeCollectionViaRecycleServiceAction_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleTypeCollectionViaRecycleServiceAction_
		{
			get	{ return _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_; }
			set	{ _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleTypeCollectionViaRecycleServiceAction_ already has been fetched. Setting this property to false when RecycleTypeCollectionViaRecycleServiceAction_ has been fetched
		/// will clear the RecycleTypeCollectionViaRecycleServiceAction_ collection well. Setting this property to true while RecycleTypeCollectionViaRecycleServiceAction_ hasn't been fetched disables lazy loading for RecycleTypeCollectionViaRecycleServiceAction_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_
		{
			get { return _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_;}
			set 
			{
				if(_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ && !value && (_recycleTypeCollectionViaRecycleServiceAction_ != null))
				{
					_recycleTypeCollectionViaRecycleServiceAction_.Clear();
				}
				_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaServiceLocationEmployeeAssignment_
		{
			get { return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaServiceLocationEmployeeAssignment_. When set to true, ServiceLocationCollectionViaServiceLocationEmployeeAssignment_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaServiceLocationEmployeeAssignment_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_; }
			set	{ _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment_ already has been fetched. Setting this property to false when ServiceLocationCollectionViaServiceLocationEmployeeAssignment_ has been fetched
		/// will clear the ServiceLocationCollectionViaServiceLocationEmployeeAssignment_ collection well. Setting this property to true while ServiceLocationCollectionViaServiceLocationEmployeeAssignment_ hasn't been fetched disables lazy loading for ServiceLocationCollectionViaServiceLocationEmployeeAssignment_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_
		{
			get { return _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_ && !value && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment_ != null))
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment_.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaServiceLocationEmployeeAssignment
		{
			get { return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaServiceLocationEmployeeAssignment. When set to true, ServiceLocationCollectionViaServiceLocationEmployeeAssignment is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaServiceLocationEmployeeAssignment is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment; }
			set	{ _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment already has been fetched. Setting this property to false when ServiceLocationCollectionViaServiceLocationEmployeeAssignment has been fetched
		/// will clear the ServiceLocationCollectionViaServiceLocationEmployeeAssignment collection well. Setting this property to true while ServiceLocationCollectionViaServiceLocationEmployeeAssignment hasn't been fetched disables lazy loading for ServiceLocationCollectionViaServiceLocationEmployeeAssignment</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment
		{
			get { return _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment && !value && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment != null))
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____
		{
			get { return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____. When set to true, ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_____
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_____; }
			set	{ _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ already has been fetched. Setting this property to false when ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ has been fetched
		/// will clear the ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ collection well. Setting this property to true while ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ hasn't been fetched disables lazy loading for ServiceLocationCollectionViaServiceLocationEmployeeAssignment_____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____
		{
			get { return _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ && !value && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____ != null))
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment_____.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment_____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get { return GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaDeepFryerServiceChangeLog. When set to true, ServiceLocationCollectionViaDeepFryerServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaDeepFryerServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog; }
			set	{ _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaDeepFryerServiceChangeLog already has been fetched. Setting this property to false when ServiceLocationCollectionViaDeepFryerServiceChangeLog has been fetched
		/// will clear the ServiceLocationCollectionViaDeepFryerServiceChangeLog collection well. Setting this property to true while ServiceLocationCollectionViaDeepFryerServiceChangeLog hasn't been fetched disables lazy loading for ServiceLocationCollectionViaDeepFryerServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get { return _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog && !value && (_serviceLocationCollectionViaDeepFryerServiceChangeLog != null))
				{
					_serviceLocationCollectionViaDeepFryerServiceChangeLog.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaDeepFryerService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaDeepFryerService
		{
			get { return GetMultiServiceLocationCollectionViaDeepFryerService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaDeepFryerService. When set to true, ServiceLocationCollectionViaDeepFryerService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaDeepFryerService is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaDeepFryerService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaDeepFryerService
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaDeepFryerService; }
			set	{ _alwaysFetchServiceLocationCollectionViaDeepFryerService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaDeepFryerService already has been fetched. Setting this property to false when ServiceLocationCollectionViaDeepFryerService has been fetched
		/// will clear the ServiceLocationCollectionViaDeepFryerService collection well. Setting this property to true while ServiceLocationCollectionViaDeepFryerService hasn't been fetched disables lazy loading for ServiceLocationCollectionViaDeepFryerService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaDeepFryerService
		{
			get { return _alreadyFetchedServiceLocationCollectionViaDeepFryerService;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaDeepFryerService && !value && (_serviceLocationCollectionViaDeepFryerService != null))
				{
					_serviceLocationCollectionViaDeepFryerService.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaDeepFryerService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment______()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaServiceLocationEmployeeAssignment______
		{
			get { return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment______(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaServiceLocationEmployeeAssignment______. When set to true, ServiceLocationCollectionViaServiceLocationEmployeeAssignment______ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaServiceLocationEmployeeAssignment______ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment______(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment______
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment______; }
			set	{ _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment______ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment______ already has been fetched. Setting this property to false when ServiceLocationCollectionViaServiceLocationEmployeeAssignment______ has been fetched
		/// will clear the ServiceLocationCollectionViaServiceLocationEmployeeAssignment______ collection well. Setting this property to true while ServiceLocationCollectionViaServiceLocationEmployeeAssignment______ hasn't been fetched disables lazy loading for ServiceLocationCollectionViaServiceLocationEmployeeAssignment______</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______
		{
			get { return _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______ && !value && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment______ != null))
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment______.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment______ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaServiceLocationEmployeeAssignment____
		{
			get { return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaServiceLocationEmployeeAssignment____. When set to true, ServiceLocationCollectionViaServiceLocationEmployeeAssignment____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaServiceLocationEmployeeAssignment____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment____
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment____; }
			set	{ _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment____ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment____ already has been fetched. Setting this property to false when ServiceLocationCollectionViaServiceLocationEmployeeAssignment____ has been fetched
		/// will clear the ServiceLocationCollectionViaServiceLocationEmployeeAssignment____ collection well. Setting this property to true while ServiceLocationCollectionViaServiceLocationEmployeeAssignment____ hasn't been fetched disables lazy loading for ServiceLocationCollectionViaServiceLocationEmployeeAssignment____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____
		{
			get { return _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____ && !value && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment____ != null))
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment____.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaServiceLocationEmployeeAssignment__
		{
			get { return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment__(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaServiceLocationEmployeeAssignment__. When set to true, ServiceLocationCollectionViaServiceLocationEmployeeAssignment__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaServiceLocationEmployeeAssignment__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment__(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment__
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment__; }
			set	{ _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment__ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment__ already has been fetched. Setting this property to false when ServiceLocationCollectionViaServiceLocationEmployeeAssignment__ has been fetched
		/// will clear the ServiceLocationCollectionViaServiceLocationEmployeeAssignment__ collection well. Setting this property to true while ServiceLocationCollectionViaServiceLocationEmployeeAssignment__ hasn't been fetched disables lazy loading for ServiceLocationCollectionViaServiceLocationEmployeeAssignment__</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__
		{
			get { return _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__ && !value && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment__ != null))
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment__.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment__ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaServiceLocationEmployeeAssignment___
		{
			get { return GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment___(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaServiceLocationEmployeeAssignment___. When set to true, ServiceLocationCollectionViaServiceLocationEmployeeAssignment___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaServiceLocationEmployeeAssignment___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaServiceLocationEmployeeAssignment___(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment___
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment___; }
			set	{ _alwaysFetchServiceLocationCollectionViaServiceLocationEmployeeAssignment___ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaServiceLocationEmployeeAssignment___ already has been fetched. Setting this property to false when ServiceLocationCollectionViaServiceLocationEmployeeAssignment___ has been fetched
		/// will clear the ServiceLocationCollectionViaServiceLocationEmployeeAssignment___ collection well. Setting this property to true while ServiceLocationCollectionViaServiceLocationEmployeeAssignment___ hasn't been fetched disables lazy loading for ServiceLocationCollectionViaServiceLocationEmployeeAssignment___</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___
		{
			get { return _alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___ && !value && (_serviceLocationCollectionViaServiceLocationEmployeeAssignment___ != null))
				{
					_serviceLocationCollectionViaServiceLocationEmployeeAssignment___.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaServiceLocationEmployeeAssignment___ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaDeepFryerServiceChangeLog_
		{
			get { return GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaDeepFryerServiceChangeLog_. When set to true, ServiceLocationCollectionViaDeepFryerServiceChangeLog_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaDeepFryerServiceChangeLog_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog_
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog_; }
			set	{ _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaDeepFryerServiceChangeLog_ already has been fetched. Setting this property to false when ServiceLocationCollectionViaDeepFryerServiceChangeLog_ has been fetched
		/// will clear the ServiceLocationCollectionViaDeepFryerServiceChangeLog_ collection well. Setting this property to true while ServiceLocationCollectionViaDeepFryerServiceChangeLog_ hasn't been fetched disables lazy loading for ServiceLocationCollectionViaDeepFryerServiceChangeLog_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_
		{
			get { return _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_ && !value && (_serviceLocationCollectionViaDeepFryerServiceChangeLog_ != null))
				{
					_serviceLocationCollectionViaDeepFryerServiceChangeLog_.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceTypeCollectionViaWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection ServiceTypeCollectionViaWorkOrder
		{
			get { return GetMultiServiceTypeCollectionViaWorkOrder(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceTypeCollectionViaWorkOrder. When set to true, ServiceTypeCollectionViaWorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceTypeCollectionViaWorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceTypeCollectionViaWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceTypeCollectionViaWorkOrder
		{
			get	{ return _alwaysFetchServiceTypeCollectionViaWorkOrder; }
			set	{ _alwaysFetchServiceTypeCollectionViaWorkOrder = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceTypeCollectionViaWorkOrder already has been fetched. Setting this property to false when ServiceTypeCollectionViaWorkOrder has been fetched
		/// will clear the ServiceTypeCollectionViaWorkOrder collection well. Setting this property to true while ServiceTypeCollectionViaWorkOrder hasn't been fetched disables lazy loading for ServiceTypeCollectionViaWorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceTypeCollectionViaWorkOrder
		{
			get { return _alreadyFetchedServiceTypeCollectionViaWorkOrder;}
			set 
			{
				if(_alreadyFetchedServiceTypeCollectionViaWorkOrder && !value && (_serviceTypeCollectionViaWorkOrder != null))
				{
					_serviceTypeCollectionViaWorkOrder.Clear();
				}
				_alreadyFetchedServiceTypeCollectionViaWorkOrder = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'StatusEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStatusCollectionViaLoad()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.StatusCollection StatusCollectionViaLoad
		{
			get { return GetMultiStatusCollectionViaLoad(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for StatusCollectionViaLoad. When set to true, StatusCollectionViaLoad is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StatusCollectionViaLoad is accessed. You can always execute
		/// a forced fetch by calling GetMultiStatusCollectionViaLoad(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchStatusCollectionViaLoad
		{
			get	{ return _alwaysFetchStatusCollectionViaLoad; }
			set	{ _alwaysFetchStatusCollectionViaLoad = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property StatusCollectionViaLoad already has been fetched. Setting this property to false when StatusCollectionViaLoad has been fetched
		/// will clear the StatusCollectionViaLoad collection well. Setting this property to true while StatusCollectionViaLoad hasn't been fetched disables lazy loading for StatusCollectionViaLoad</summary>
		[Browsable(false)]
		public bool AlreadyFetchedStatusCollectionViaLoad
		{
			get { return _alreadyFetchedStatusCollectionViaLoad;}
			set 
			{
				if(_alreadyFetchedStatusCollectionViaLoad && !value && (_statusCollectionViaLoad != null))
				{
					_statusCollectionViaLoad.Clear();
				}
				_alreadyFetchedStatusCollectionViaLoad = value;
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
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaDeepFryerServiceChangeLog_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaDeepFryerServiceChangeLog_
		{
			get { return GetMultiUserCollectionViaDeepFryerServiceChangeLog_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaDeepFryerServiceChangeLog_. When set to true, UserCollectionViaDeepFryerServiceChangeLog_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaDeepFryerServiceChangeLog_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaDeepFryerServiceChangeLog_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaDeepFryerServiceChangeLog_
		{
			get	{ return _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog_; }
			set	{ _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaDeepFryerServiceChangeLog_ already has been fetched. Setting this property to false when UserCollectionViaDeepFryerServiceChangeLog_ has been fetched
		/// will clear the UserCollectionViaDeepFryerServiceChangeLog_ collection well. Setting this property to true while UserCollectionViaDeepFryerServiceChangeLog_ hasn't been fetched disables lazy loading for UserCollectionViaDeepFryerServiceChangeLog_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_
		{
			get { return _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_ && !value && (_userCollectionViaDeepFryerServiceChangeLog_ != null))
				{
					_userCollectionViaDeepFryerServiceChangeLog_.Clear();
				}
				_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaRecycleServiceAction___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaRecycleServiceAction___
		{
			get { return GetMultiUserCollectionViaRecycleServiceAction___(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaRecycleServiceAction___. When set to true, UserCollectionViaRecycleServiceAction___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaRecycleServiceAction___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaRecycleServiceAction___(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaRecycleServiceAction___
		{
			get	{ return _alwaysFetchUserCollectionViaRecycleServiceAction___; }
			set	{ _alwaysFetchUserCollectionViaRecycleServiceAction___ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaRecycleServiceAction___ already has been fetched. Setting this property to false when UserCollectionViaRecycleServiceAction___ has been fetched
		/// will clear the UserCollectionViaRecycleServiceAction___ collection well. Setting this property to true while UserCollectionViaRecycleServiceAction___ hasn't been fetched disables lazy loading for UserCollectionViaRecycleServiceAction___</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaRecycleServiceAction___
		{
			get { return _alreadyFetchedUserCollectionViaRecycleServiceAction___;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaRecycleServiceAction___ && !value && (_userCollectionViaRecycleServiceAction___ != null))
				{
					_userCollectionViaRecycleServiceAction___.Clear();
				}
				_alreadyFetchedUserCollectionViaRecycleServiceAction___ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaAssetReclamationServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaAssetReclamationServiceChangeLog
		{
			get { return GetMultiUserCollectionViaAssetReclamationServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaAssetReclamationServiceChangeLog. When set to true, UserCollectionViaAssetReclamationServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaAssetReclamationServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaAssetReclamationServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaAssetReclamationServiceChangeLog
		{
			get	{ return _alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog; }
			set	{ _alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaAssetReclamationServiceChangeLog already has been fetched. Setting this property to false when UserCollectionViaAssetReclamationServiceChangeLog has been fetched
		/// will clear the UserCollectionViaAssetReclamationServiceChangeLog collection well. Setting this property to true while UserCollectionViaAssetReclamationServiceChangeLog hasn't been fetched disables lazy loading for UserCollectionViaAssetReclamationServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog
		{
			get { return _alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog && !value && (_userCollectionViaAssetReclamationServiceChangeLog != null))
				{
					_userCollectionViaAssetReclamationServiceChangeLog.Clear();
				}
				_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaRecycleServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaRecycleServiceChangeLog
		{
			get { return GetMultiUserCollectionViaRecycleServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaRecycleServiceChangeLog. When set to true, UserCollectionViaRecycleServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaRecycleServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaRecycleServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaRecycleServiceChangeLog
		{
			get	{ return _alwaysFetchUserCollectionViaRecycleServiceChangeLog; }
			set	{ _alwaysFetchUserCollectionViaRecycleServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaRecycleServiceChangeLog already has been fetched. Setting this property to false when UserCollectionViaRecycleServiceChangeLog has been fetched
		/// will clear the UserCollectionViaRecycleServiceChangeLog collection well. Setting this property to true while UserCollectionViaRecycleServiceChangeLog hasn't been fetched disables lazy loading for UserCollectionViaRecycleServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaRecycleServiceChangeLog
		{
			get { return _alreadyFetchedUserCollectionViaRecycleServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaRecycleServiceChangeLog && !value && (_userCollectionViaRecycleServiceChangeLog != null))
				{
					_userCollectionViaRecycleServiceChangeLog.Clear();
				}
				_alreadyFetchedUserCollectionViaRecycleServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaRecycleServiceAction_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaRecycleServiceAction_
		{
			get { return GetMultiUserCollectionViaRecycleServiceAction_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaRecycleServiceAction_. When set to true, UserCollectionViaRecycleServiceAction_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaRecycleServiceAction_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaRecycleServiceAction_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaRecycleServiceAction_
		{
			get	{ return _alwaysFetchUserCollectionViaRecycleServiceAction_; }
			set	{ _alwaysFetchUserCollectionViaRecycleServiceAction_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaRecycleServiceAction_ already has been fetched. Setting this property to false when UserCollectionViaRecycleServiceAction_ has been fetched
		/// will clear the UserCollectionViaRecycleServiceAction_ collection well. Setting this property to true while UserCollectionViaRecycleServiceAction_ hasn't been fetched disables lazy loading for UserCollectionViaRecycleServiceAction_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaRecycleServiceAction_
		{
			get { return _alreadyFetchedUserCollectionViaRecycleServiceAction_;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaRecycleServiceAction_ && !value && (_userCollectionViaRecycleServiceAction_ != null))
				{
					_userCollectionViaRecycleServiceAction_.Clear();
				}
				_alreadyFetchedUserCollectionViaRecycleServiceAction_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaRecycleServiceAction__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaRecycleServiceAction__
		{
			get { return GetMultiUserCollectionViaRecycleServiceAction__(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaRecycleServiceAction__. When set to true, UserCollectionViaRecycleServiceAction__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaRecycleServiceAction__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaRecycleServiceAction__(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaRecycleServiceAction__
		{
			get	{ return _alwaysFetchUserCollectionViaRecycleServiceAction__; }
			set	{ _alwaysFetchUserCollectionViaRecycleServiceAction__ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaRecycleServiceAction__ already has been fetched. Setting this property to false when UserCollectionViaRecycleServiceAction__ has been fetched
		/// will clear the UserCollectionViaRecycleServiceAction__ collection well. Setting this property to true while UserCollectionViaRecycleServiceAction__ hasn't been fetched disables lazy loading for UserCollectionViaRecycleServiceAction__</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaRecycleServiceAction__
		{
			get { return _alreadyFetchedUserCollectionViaRecycleServiceAction__;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaRecycleServiceAction__ && !value && (_userCollectionViaRecycleServiceAction__ != null))
				{
					_userCollectionViaRecycleServiceAction__.Clear();
				}
				_alreadyFetchedUserCollectionViaRecycleServiceAction__ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaRecycleServiceAction()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaRecycleServiceAction
		{
			get { return GetMultiUserCollectionViaRecycleServiceAction(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaRecycleServiceAction. When set to true, UserCollectionViaRecycleServiceAction is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaRecycleServiceAction is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaRecycleServiceAction(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaRecycleServiceAction
		{
			get	{ return _alwaysFetchUserCollectionViaRecycleServiceAction; }
			set	{ _alwaysFetchUserCollectionViaRecycleServiceAction = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaRecycleServiceAction already has been fetched. Setting this property to false when UserCollectionViaRecycleServiceAction has been fetched
		/// will clear the UserCollectionViaRecycleServiceAction collection well. Setting this property to true while UserCollectionViaRecycleServiceAction hasn't been fetched disables lazy loading for UserCollectionViaRecycleServiceAction</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaRecycleServiceAction
		{
			get { return _alreadyFetchedUserCollectionViaRecycleServiceAction;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaRecycleServiceAction && !value && (_userCollectionViaRecycleServiceAction != null))
				{
					_userCollectionViaRecycleServiceAction.Clear();
				}
				_alreadyFetchedUserCollectionViaRecycleServiceAction = value;
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
