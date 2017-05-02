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
	/// Entity class which represents the entity 'User'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class UserEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection	_assetReclamationServiceChangeLog;
		private bool	_alwaysFetchAssetReclamationServiceChangeLog, _alreadyFetchedAssetReclamationServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection	_changeLog;
		private bool	_alwaysFetchChangeLog, _alreadyFetchedChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection	_deepFryerServiceChangeLog;
		private bool	_alwaysFetchDeepFryerServiceChangeLog, _alreadyFetchedDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.RebateCollection	_rebate;
		private bool	_alwaysFetchRebate, _alreadyFetchedRebate;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection	_recycleServiceAction_;
		private bool	_alwaysFetchRecycleServiceAction_, _alreadyFetchedRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection	_recycleServiceAction;
		private bool	_alwaysFetchRecycleServiceAction, _alreadyFetchedRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection	_recycleServiceChangeLog;
		private bool	_alwaysFetchRecycleServiceChangeLog, _alreadyFetchedRecycleServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection	_userAccount;
		private bool	_alwaysFetchUserAccount, _alreadyFetchedUserAccount;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaRebate;
		private bool	_alwaysFetchAccountCollectionViaRebate, _alreadyFetchedAccountCollectionViaRebate;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaUserAccount;
		private bool	_alwaysFetchAccountCollectionViaUserAccount, _alreadyFetchedAccountCollectionViaUserAccount;
		private Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection _assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog;
		private bool	_alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog, _alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.ChangeTypeCollection _changeTypeCollectionViaChangeLog;
		private bool	_alwaysFetchChangeTypeCollectionViaChangeLog, _alreadyFetchedChangeTypeCollectionViaChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection _deepFryerServiceCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaRecycleServiceAction_;
		private bool	_alwaysFetchEmployeeCollectionViaRecycleServiceAction_, _alreadyFetchedEmployeeCollectionViaRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchEmployeeCollectionViaRecycleServiceAction, _alreadyFetchedEmployeeCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaRecycleServiceChangeLog;
		private bool	_alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog, _alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaRecycleServiceAction___;
		private bool	_alwaysFetchEmployeeCollectionViaRecycleServiceAction___, _alreadyFetchedEmployeeCollectionViaRecycleServiceAction___;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaRecycleServiceAction__;
		private bool	_alwaysFetchEmployeeCollectionViaRecycleServiceAction__, _alreadyFetchedEmployeeCollectionViaRecycleServiceAction__;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaDeepFryerServiceChangeLog_;
		private bool	_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_, _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaAssetReclamationServiceChangeLog;
		private bool	_alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog, _alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection _rebateTypeCollectionViaRebate;
		private bool	_alwaysFetchRebateTypeCollectionViaRebate, _alreadyFetchedRebateTypeCollectionViaRebate;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection _recycleServiceCollectionViaRecycleServiceChangeLog;
		private bool	_alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog, _alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection _recycleServiceCollectionViaRecycleServiceAction_;
		private bool	_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_, _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection _recycleServiceCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction, _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection _recycleTypeCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction, _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection _recycleTypeCollectionViaRecycleServiceAction_;
		private bool	_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_, _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog;
		private UserTypeEntity _userType;
		private bool	_alwaysFetchUserType, _alreadyFetchedUserType, _userTypeReturnsNewIfNotFound;

		
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
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static UserEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public UserEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		public UserEntity(System.Int32 userId)
		{
			InitClassFetch(userId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public UserEntity(System.Int32 userId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(userId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The custom validator object for this UserEntity</param>
		public UserEntity(System.Int32 userId, IValidator validator)
		{
			InitClassFetch(userId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_assetReclamationServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection)info.GetValue("_assetReclamationServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection));
			_alwaysFetchAssetReclamationServiceChangeLog = info.GetBoolean("_alwaysFetchAssetReclamationServiceChangeLog");
			_alreadyFetchedAssetReclamationServiceChangeLog = info.GetBoolean("_alreadyFetchedAssetReclamationServiceChangeLog");
			_changeLog = (Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection)info.GetValue("_changeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection));
			_alwaysFetchChangeLog = info.GetBoolean("_alwaysFetchChangeLog");
			_alreadyFetchedChangeLog = info.GetBoolean("_alreadyFetchedChangeLog");
			_deepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection)info.GetValue("_deepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection));
			_alwaysFetchDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchDeepFryerServiceChangeLog");
			_alreadyFetchedDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedDeepFryerServiceChangeLog");
			_rebate = (Reliant.RenuOil.DAL.CollectionClasses.RebateCollection)info.GetValue("_rebate", typeof(Reliant.RenuOil.DAL.CollectionClasses.RebateCollection));
			_alwaysFetchRebate = info.GetBoolean("_alwaysFetchRebate");
			_alreadyFetchedRebate = info.GetBoolean("_alreadyFetchedRebate");
			_recycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection)info.GetValue("_recycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection));
			_alwaysFetchRecycleServiceAction_ = info.GetBoolean("_alwaysFetchRecycleServiceAction_");
			_alreadyFetchedRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedRecycleServiceAction_");
			_recycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection)info.GetValue("_recycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection));
			_alwaysFetchRecycleServiceAction = info.GetBoolean("_alwaysFetchRecycleServiceAction");
			_alreadyFetchedRecycleServiceAction = info.GetBoolean("_alreadyFetchedRecycleServiceAction");
			_recycleServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection)info.GetValue("_recycleServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection));
			_alwaysFetchRecycleServiceChangeLog = info.GetBoolean("_alwaysFetchRecycleServiceChangeLog");
			_alreadyFetchedRecycleServiceChangeLog = info.GetBoolean("_alreadyFetchedRecycleServiceChangeLog");
			_userAccount = (Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection)info.GetValue("_userAccount", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection));
			_alwaysFetchUserAccount = info.GetBoolean("_alwaysFetchUserAccount");
			_alreadyFetchedUserAccount = info.GetBoolean("_alreadyFetchedUserAccount");
			_accountCollectionViaRebate = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaRebate", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaRebate = info.GetBoolean("_alwaysFetchAccountCollectionViaRebate");
			_alreadyFetchedAccountCollectionViaRebate = info.GetBoolean("_alreadyFetchedAccountCollectionViaRebate");
			_accountCollectionViaUserAccount = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaUserAccount", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaUserAccount = info.GetBoolean("_alwaysFetchAccountCollectionViaUserAccount");
			_alreadyFetchedAccountCollectionViaUserAccount = info.GetBoolean("_alreadyFetchedAccountCollectionViaUserAccount");
			_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection)info.GetValue("_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection));
			_alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog");
			_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog");
			_changeTypeCollectionViaChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.ChangeTypeCollection)info.GetValue("_changeTypeCollectionViaChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ChangeTypeCollection));
			_alwaysFetchChangeTypeCollectionViaChangeLog = info.GetBoolean("_alwaysFetchChangeTypeCollectionViaChangeLog");
			_alreadyFetchedChangeTypeCollectionViaChangeLog = info.GetBoolean("_alreadyFetchedChangeTypeCollectionViaChangeLog");
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection)info.GetValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection));
			_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog");
			_employeeCollectionViaRecycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaRecycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction_ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaRecycleServiceAction_");
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_");
			_employeeCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchEmployeeCollectionViaRecycleServiceAction");
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction");
			_employeeCollectionViaRecycleServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaRecycleServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog");
			_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog");
			_employeeCollectionViaRecycleServiceAction___ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaRecycleServiceAction___", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction___ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaRecycleServiceAction___");
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction___ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction___");
			_employeeCollectionViaRecycleServiceAction__ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaRecycleServiceAction__", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction__ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaRecycleServiceAction__");
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction__ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction__");
			_employeeCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog");
			_employeeCollectionViaDeepFryerServiceChangeLog_ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog_", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_");
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_");
			_employeeCollectionViaAssetReclamationServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaAssetReclamationServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog");
			_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog");
			_rebateTypeCollectionViaRebate = (Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection)info.GetValue("_rebateTypeCollectionViaRebate", typeof(Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection));
			_alwaysFetchRebateTypeCollectionViaRebate = info.GetBoolean("_alwaysFetchRebateTypeCollectionViaRebate");
			_alreadyFetchedRebateTypeCollectionViaRebate = info.GetBoolean("_alreadyFetchedRebateTypeCollectionViaRebate");
			_recycleServiceCollectionViaRecycleServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection)info.GetValue("_recycleServiceCollectionViaRecycleServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection));
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog");
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog");
			_recycleServiceCollectionViaRecycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection)info.GetValue("_recycleServiceCollectionViaRecycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection));
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_ = info.GetBoolean("_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_");
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_");
			_recycleServiceCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection)info.GetValue("_recycleServiceCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection));
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction");
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction");
			_recycleTypeCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection)info.GetValue("_recycleTypeCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection));
			_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction");
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction");
			_recycleTypeCollectionViaRecycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection)info.GetValue("_recycleTypeCollectionViaRecycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection));
			_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_ = info.GetBoolean("_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_");
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_");
			_serviceLocationCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog");
			_userType = (UserTypeEntity)info.GetValue("_userType", typeof(UserTypeEntity));
			if(_userType!=null)
			{
				_userType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_userTypeReturnsNewIfNotFound = info.GetBoolean("_userTypeReturnsNewIfNotFound");
			_alwaysFetchUserType = info.GetBoolean("_alwaysFetchUserType");
			_alreadyFetchedUserType = info.GetBoolean("_alreadyFetchedUserType");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
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
					_alreadyFetchedUserType = false;
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
			_alreadyFetchedAssetReclamationServiceChangeLog = (_assetReclamationServiceChangeLog.Count > 0);
			_alreadyFetchedChangeLog = (_changeLog.Count > 0);
			_alreadyFetchedDeepFryerServiceChangeLog = (_deepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedRebate = (_rebate.Count > 0);
			_alreadyFetchedRecycleServiceAction_ = (_recycleServiceAction_.Count > 0);
			_alreadyFetchedRecycleServiceAction = (_recycleServiceAction.Count > 0);
			_alreadyFetchedRecycleServiceChangeLog = (_recycleServiceChangeLog.Count > 0);
			_alreadyFetchedUserAccount = (_userAccount.Count > 0);
			_alreadyFetchedAccountCollectionViaRebate = (_accountCollectionViaRebate.Count > 0);
			_alreadyFetchedAccountCollectionViaUserAccount = (_accountCollectionViaUserAccount.Count > 0);
			_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = (_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.Count > 0);
			_alreadyFetchedChangeTypeCollectionViaChangeLog = (_changeTypeCollectionViaChangeLog.Count > 0);
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = (_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = (_employeeCollectionViaRecycleServiceAction_.Count > 0);
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = (_employeeCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog = (_employeeCollectionViaRecycleServiceChangeLog.Count > 0);
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction___ = (_employeeCollectionViaRecycleServiceAction___.Count > 0);
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction__ = (_employeeCollectionViaRecycleServiceAction__.Count > 0);
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = (_employeeCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = (_employeeCollectionViaDeepFryerServiceChangeLog_.Count > 0);
			_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog = (_employeeCollectionViaAssetReclamationServiceChangeLog.Count > 0);
			_alreadyFetchedRebateTypeCollectionViaRebate = (_rebateTypeCollectionViaRebate.Count > 0);
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog = (_recycleServiceCollectionViaRecycleServiceChangeLog.Count > 0);
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ = (_recycleServiceCollectionViaRecycleServiceAction_.Count > 0);
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = (_recycleServiceCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = (_recycleTypeCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ = (_recycleTypeCollectionViaRecycleServiceAction_.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = (_serviceLocationCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedUserType = (_userType != null);

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



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_assetReclamationServiceChangeLog", (!this.MarkedForDeletion?_assetReclamationServiceChangeLog:null));
			info.AddValue("_alwaysFetchAssetReclamationServiceChangeLog", _alwaysFetchAssetReclamationServiceChangeLog);
			info.AddValue("_alreadyFetchedAssetReclamationServiceChangeLog", _alreadyFetchedAssetReclamationServiceChangeLog);
			info.AddValue("_changeLog", (!this.MarkedForDeletion?_changeLog:null));
			info.AddValue("_alwaysFetchChangeLog", _alwaysFetchChangeLog);
			info.AddValue("_alreadyFetchedChangeLog", _alreadyFetchedChangeLog);
			info.AddValue("_deepFryerServiceChangeLog", (!this.MarkedForDeletion?_deepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchDeepFryerServiceChangeLog", _alwaysFetchDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedDeepFryerServiceChangeLog", _alreadyFetchedDeepFryerServiceChangeLog);
			info.AddValue("_rebate", (!this.MarkedForDeletion?_rebate:null));
			info.AddValue("_alwaysFetchRebate", _alwaysFetchRebate);
			info.AddValue("_alreadyFetchedRebate", _alreadyFetchedRebate);
			info.AddValue("_recycleServiceAction_", (!this.MarkedForDeletion?_recycleServiceAction_:null));
			info.AddValue("_alwaysFetchRecycleServiceAction_", _alwaysFetchRecycleServiceAction_);
			info.AddValue("_alreadyFetchedRecycleServiceAction_", _alreadyFetchedRecycleServiceAction_);
			info.AddValue("_recycleServiceAction", (!this.MarkedForDeletion?_recycleServiceAction:null));
			info.AddValue("_alwaysFetchRecycleServiceAction", _alwaysFetchRecycleServiceAction);
			info.AddValue("_alreadyFetchedRecycleServiceAction", _alreadyFetchedRecycleServiceAction);
			info.AddValue("_recycleServiceChangeLog", (!this.MarkedForDeletion?_recycleServiceChangeLog:null));
			info.AddValue("_alwaysFetchRecycleServiceChangeLog", _alwaysFetchRecycleServiceChangeLog);
			info.AddValue("_alreadyFetchedRecycleServiceChangeLog", _alreadyFetchedRecycleServiceChangeLog);
			info.AddValue("_userAccount", (!this.MarkedForDeletion?_userAccount:null));
			info.AddValue("_alwaysFetchUserAccount", _alwaysFetchUserAccount);
			info.AddValue("_alreadyFetchedUserAccount", _alreadyFetchedUserAccount);
			info.AddValue("_accountCollectionViaRebate", (!this.MarkedForDeletion?_accountCollectionViaRebate:null));
			info.AddValue("_alwaysFetchAccountCollectionViaRebate", _alwaysFetchAccountCollectionViaRebate);
			info.AddValue("_alreadyFetchedAccountCollectionViaRebate", _alreadyFetchedAccountCollectionViaRebate);
			info.AddValue("_accountCollectionViaUserAccount", (!this.MarkedForDeletion?_accountCollectionViaUserAccount:null));
			info.AddValue("_alwaysFetchAccountCollectionViaUserAccount", _alwaysFetchAccountCollectionViaUserAccount);
			info.AddValue("_alreadyFetchedAccountCollectionViaUserAccount", _alreadyFetchedAccountCollectionViaUserAccount);
			info.AddValue("_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", (!this.MarkedForDeletion?_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog:null));
			info.AddValue("_alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", _alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", _alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_changeTypeCollectionViaChangeLog", (!this.MarkedForDeletion?_changeTypeCollectionViaChangeLog:null));
			info.AddValue("_alwaysFetchChangeTypeCollectionViaChangeLog", _alwaysFetchChangeTypeCollectionViaChangeLog);
			info.AddValue("_alreadyFetchedChangeTypeCollectionViaChangeLog", _alreadyFetchedChangeTypeCollectionViaChangeLog);
			info.AddValue("_deepFryerServiceCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_deepFryerServiceCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog", _alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_employeeCollectionViaRecycleServiceAction_", (!this.MarkedForDeletion?_employeeCollectionViaRecycleServiceAction_:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaRecycleServiceAction_", _alwaysFetchEmployeeCollectionViaRecycleServiceAction_);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_", _alreadyFetchedEmployeeCollectionViaRecycleServiceAction_);
			info.AddValue("_employeeCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_employeeCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaRecycleServiceAction", _alwaysFetchEmployeeCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction", _alreadyFetchedEmployeeCollectionViaRecycleServiceAction);
			info.AddValue("_employeeCollectionViaRecycleServiceChangeLog", (!this.MarkedForDeletion?_employeeCollectionViaRecycleServiceChangeLog:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog", _alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog", _alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog);
			info.AddValue("_employeeCollectionViaRecycleServiceAction___", (!this.MarkedForDeletion?_employeeCollectionViaRecycleServiceAction___:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaRecycleServiceAction___", _alwaysFetchEmployeeCollectionViaRecycleServiceAction___);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction___", _alreadyFetchedEmployeeCollectionViaRecycleServiceAction___);
			info.AddValue("_employeeCollectionViaRecycleServiceAction__", (!this.MarkedForDeletion?_employeeCollectionViaRecycleServiceAction__:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaRecycleServiceAction__", _alwaysFetchEmployeeCollectionViaRecycleServiceAction__);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction__", _alreadyFetchedEmployeeCollectionViaRecycleServiceAction__);
			info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_employeeCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog", _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog_", (!this.MarkedForDeletion?_employeeCollectionViaDeepFryerServiceChangeLog_:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_", _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_", _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_employeeCollectionViaAssetReclamationServiceChangeLog", (!this.MarkedForDeletion?_employeeCollectionViaAssetReclamationServiceChangeLog:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog", _alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog", _alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_rebateTypeCollectionViaRebate", (!this.MarkedForDeletion?_rebateTypeCollectionViaRebate:null));
			info.AddValue("_alwaysFetchRebateTypeCollectionViaRebate", _alwaysFetchRebateTypeCollectionViaRebate);
			info.AddValue("_alreadyFetchedRebateTypeCollectionViaRebate", _alreadyFetchedRebateTypeCollectionViaRebate);
			info.AddValue("_recycleServiceCollectionViaRecycleServiceChangeLog", (!this.MarkedForDeletion?_recycleServiceCollectionViaRecycleServiceChangeLog:null));
			info.AddValue("_alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog", _alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog);
			info.AddValue("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog", _alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog);
			info.AddValue("_recycleServiceCollectionViaRecycleServiceAction_", (!this.MarkedForDeletion?_recycleServiceCollectionViaRecycleServiceAction_:null));
			info.AddValue("_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_", _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_);
			info.AddValue("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_", _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_);
			info.AddValue("_recycleServiceCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_recycleServiceCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction", _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction", _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction);
			info.AddValue("_recycleTypeCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_recycleTypeCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction", _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction", _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction);
			info.AddValue("_recycleTypeCollectionViaRecycleServiceAction_", (!this.MarkedForDeletion?_recycleTypeCollectionViaRecycleServiceAction_:null));
			info.AddValue("_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_", _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_);
			info.AddValue("_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_", _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_);
			info.AddValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_serviceLocationCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog", _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_userType", (!this.MarkedForDeletion?_userType:null));
			info.AddValue("_userTypeReturnsNewIfNotFound", _userTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUserType", _alwaysFetchUserType);
			info.AddValue("_alreadyFetchedUserType", _alreadyFetchedUserType);

			
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
				case "UserType":
					_alreadyFetchedUserType = true;
					this.UserType = (UserTypeEntity)entity;
					break;
				case "AssetReclamationServiceChangeLog":
					_alreadyFetchedAssetReclamationServiceChangeLog = true;
					if(entity!=null)
					{
						this.AssetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)entity);
					}
					break;
				case "ChangeLog":
					_alreadyFetchedChangeLog = true;
					if(entity!=null)
					{
						this.ChangeLog.Add((ChangeLogEntity)entity);
					}
					break;
				case "DeepFryerServiceChangeLog":
					_alreadyFetchedDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)entity);
					}
					break;
				case "Rebate":
					_alreadyFetchedRebate = true;
					if(entity!=null)
					{
						this.Rebate.Add((RebateEntity)entity);
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
				case "UserAccount":
					_alreadyFetchedUserAccount = true;
					if(entity!=null)
					{
						this.UserAccount.Add((UserAccountEntity)entity);
					}
					break;
				case "AccountCollectionViaRebate":
					_alreadyFetchedAccountCollectionViaRebate = true;
					if(entity!=null)
					{
						this.AccountCollectionViaRebate.Add((AccountEntity)entity);
					}
					break;
				case "AccountCollectionViaUserAccount":
					_alreadyFetchedAccountCollectionViaUserAccount = true;
					if(entity!=null)
					{
						this.AccountCollectionViaUserAccount.Add((AccountEntity)entity);
					}
					break;
				case "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog":
					_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = true;
					if(entity!=null)
					{
						this.AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.Add((AssetReclamationServiceEntity)entity);
					}
					break;
				case "ChangeTypeCollectionViaChangeLog":
					_alreadyFetchedChangeTypeCollectionViaChangeLog = true;
					if(entity!=null)
					{
						this.ChangeTypeCollectionViaChangeLog.Add((ChangeTypeEntity)entity);
					}
					break;
				case "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.DeepFryerServiceCollectionViaDeepFryerServiceChangeLog.Add((DeepFryerServiceEntity)entity);
					}
					break;
				case "EmployeeCollectionViaRecycleServiceAction_":
					_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaRecycleServiceAction_.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaRecycleServiceAction":
					_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaRecycleServiceAction.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaRecycleServiceChangeLog":
					_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaRecycleServiceChangeLog.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaRecycleServiceAction___":
					_alreadyFetchedEmployeeCollectionViaRecycleServiceAction___ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaRecycleServiceAction___.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaRecycleServiceAction__":
					_alreadyFetchedEmployeeCollectionViaRecycleServiceAction__ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaRecycleServiceAction__.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaDeepFryerServiceChangeLog.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog_":
					_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaDeepFryerServiceChangeLog_.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaAssetReclamationServiceChangeLog":
					_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaAssetReclamationServiceChangeLog.Add((EmployeeEntity)entity);
					}
					break;
				case "RebateTypeCollectionViaRebate":
					_alreadyFetchedRebateTypeCollectionViaRebate = true;
					if(entity!=null)
					{
						this.RebateTypeCollectionViaRebate.Add((RebateTypeEntity)entity);
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
				case "RecycleServiceCollectionViaRecycleServiceAction":
					_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = true;
					if(entity!=null)
					{
						this.RecycleServiceCollectionViaRecycleServiceAction.Add((RecycleServiceEntity)entity);
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
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.Add((ServiceLocationEntity)entity);
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
				case "UserType":
					SetupSyncUserType(relatedEntity);
					break;
				case "AssetReclamationServiceChangeLog":
					_assetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)relatedEntity);
					break;
				case "ChangeLog":
					_changeLog.Add((ChangeLogEntity)relatedEntity);
					break;
				case "DeepFryerServiceChangeLog":
					_deepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)relatedEntity);
					break;
				case "Rebate":
					_rebate.Add((RebateEntity)relatedEntity);
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
				case "UserAccount":
					_userAccount.Add((UserAccountEntity)relatedEntity);
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
				case "UserType":
					DesetupSyncUserType(false, true);
					break;
				case "AssetReclamationServiceChangeLog":
					base.PerformRelatedEntityRemoval(_assetReclamationServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ChangeLog":
					base.PerformRelatedEntityRemoval(_changeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerServiceChangeLog":
					base.PerformRelatedEntityRemoval(_deepFryerServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Rebate":
					base.PerformRelatedEntityRemoval(_rebate, relatedEntity, signalRelatedEntityManyToOne);
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
				case "UserAccount":
					base.PerformRelatedEntityRemoval(_userAccount, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_userType!=null)
			{
				toReturn.Add(_userType);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_assetReclamationServiceChangeLog);
			toReturn.Add(_changeLog);
			toReturn.Add(_deepFryerServiceChangeLog);
			toReturn.Add(_rebate);
			toReturn.Add(_recycleServiceAction_);
			toReturn.Add(_recycleServiceAction);
			toReturn.Add(_recycleServiceChangeLog);
			toReturn.Add(_userAccount);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 userId)
		{
			return FetchUsingPK(userId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 userId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(userId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 userId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(userId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 userId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(userId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.UserId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
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
				_assetReclamationServiceChangeLog.GetMultiManyToOne(null, null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLog(bool forceFetch)
		{
			return GetMultiChangeLog(forceFetch, _changeLog.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLog(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiChangeLog(forceFetch, _changeLog.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiChangeLog(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedChangeLog || forceFetch || _alwaysFetchChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_changeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_changeLog);
					}
				}
				_changeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_changeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_changeLog.GetMultiManyToOne(null, this, filter);
				_changeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedChangeLog = true;
			}
			return _changeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'ChangeLog'. These settings will be taken into account
		/// when the property ChangeLog is requested or GetMultiChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_changeLog.SortClauses=sortClauses;
			_changeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_deepFryerServiceChangeLog.GetMultiManyToOne(null, null, null, null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'RebateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RebateEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RebateCollection GetMultiRebate(bool forceFetch)
		{
			return GetMultiRebate(forceFetch, _rebate.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RebateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'RebateEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RebateCollection GetMultiRebate(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiRebate(forceFetch, _rebate.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'RebateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RebateCollection GetMultiRebate(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiRebate(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RebateEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RebateCollection GetMultiRebate(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedRebate || forceFetch || _alwaysFetchRebate) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_rebate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_rebate);
					}
				}
				_rebate.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_rebate.EntityFactoryToUse = entityFactoryToUse;
				}
				_rebate.GetMultiManyToOne(null, null, this, filter);
				_rebate.SuppressClearInGetMulti=false;
				_alreadyFetchedRebate = true;
			}
			return _rebate;
		}

		/// <summary> Sets the collection parameters for the collection for 'Rebate'. These settings will be taken into account
		/// when the property Rebate is requested or GetMultiRebate is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRebate(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_rebate.SortClauses=sortClauses;
			_rebate.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_recycleServiceAction_.GetMultiManyToOne(null, null, null, null, null, this, filter);
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
				_recycleServiceAction.GetMultiManyToOne(null, null, null, null, this, null, filter);
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
				_recycleServiceChangeLog.GetMultiManyToOne(null, null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'UserAccountEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserAccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection GetMultiUserAccount(bool forceFetch)
		{
			return GetMultiUserAccount(forceFetch, _userAccount.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'UserAccountEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'UserAccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection GetMultiUserAccount(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiUserAccount(forceFetch, _userAccount.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'UserAccountEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection GetMultiUserAccount(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiUserAccount(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'UserAccountEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection GetMultiUserAccount(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedUserAccount || forceFetch || _alwaysFetchUserAccount) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userAccount.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userAccount);
					}
				}
				_userAccount.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userAccount.EntityFactoryToUse = entityFactoryToUse;
				}
				_userAccount.GetMultiManyToOne(null, this, filter);
				_userAccount.SuppressClearInGetMulti=false;
				_alreadyFetchedUserAccount = true;
			}
			return _userAccount;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserAccount'. These settings will be taken into account
		/// when the property UserAccount is requested or GetMultiUserAccount is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserAccount(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userAccount.SortClauses=sortClauses;
			_userAccount.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaRebate(bool forceFetch)
		{
			return GetMultiAccountCollectionViaRebate(forceFetch, _accountCollectionViaRebate.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaRebate(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaRebate || forceFetch || _alwaysFetchAccountCollectionViaRebate) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaRebate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaRebate);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
				_accountCollectionViaRebate.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaRebate.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaRebate.GetMulti(filter, GetRelationsForField("AccountCollectionViaRebate"));
				_accountCollectionViaRebate.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaRebate = true;
			}
			return _accountCollectionViaRebate;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaRebate'. These settings will be taken into account
		/// when the property AccountCollectionViaRebate is requested or GetMultiAccountCollectionViaRebate is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaRebate(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaRebate.SortClauses=sortClauses;
			_accountCollectionViaRebate.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaUserAccount(bool forceFetch)
		{
			return GetMultiAccountCollectionViaUserAccount(forceFetch, _accountCollectionViaUserAccount.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaUserAccount(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaUserAccount || forceFetch || _alwaysFetchAccountCollectionViaUserAccount) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaUserAccount.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaUserAccount);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
				_accountCollectionViaUserAccount.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaUserAccount.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaUserAccount.GetMulti(filter, GetRelationsForField("AccountCollectionViaUserAccount"));
				_accountCollectionViaUserAccount.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaUserAccount = true;
			}
			return _accountCollectionViaUserAccount;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaUserAccount'. These settings will be taken into account
		/// when the property AccountCollectionViaUserAccount is requested or GetMultiAccountCollectionViaUserAccount is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaUserAccount(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaUserAccount.SortClauses=sortClauses;
			_accountCollectionViaUserAccount.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
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

		/// <summary> Retrieves all related entities of type 'ChangeTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ChangeTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeTypeCollection GetMultiChangeTypeCollectionViaChangeLog(bool forceFetch)
		{
			return GetMultiChangeTypeCollectionViaChangeLog(forceFetch, _changeTypeCollectionViaChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ChangeTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeTypeCollection GetMultiChangeTypeCollectionViaChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedChangeTypeCollectionViaChangeLog || forceFetch || _alwaysFetchChangeTypeCollectionViaChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_changeTypeCollectionViaChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_changeTypeCollectionViaChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
				_changeTypeCollectionViaChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_changeTypeCollectionViaChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_changeTypeCollectionViaChangeLog.GetMulti(filter, GetRelationsForField("ChangeTypeCollectionViaChangeLog"));
				_changeTypeCollectionViaChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedChangeTypeCollectionViaChangeLog = true;
			}
			return _changeTypeCollectionViaChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'ChangeTypeCollectionViaChangeLog'. These settings will be taken into account
		/// when the property ChangeTypeCollectionViaChangeLog is requested or GetMultiChangeTypeCollectionViaChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersChangeTypeCollectionViaChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_changeTypeCollectionViaChangeLog.SortClauses=sortClauses;
			_changeTypeCollectionViaChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
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
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaRecycleServiceAction_(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaRecycleServiceAction_(forceFetch, _employeeCollectionViaRecycleServiceAction_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaRecycleServiceAction_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ || forceFetch || _alwaysFetchEmployeeCollectionViaRecycleServiceAction_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaRecycleServiceAction_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaRecycleServiceAction_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
				_employeeCollectionViaRecycleServiceAction_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaRecycleServiceAction_.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaRecycleServiceAction_.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction_"));
				_employeeCollectionViaRecycleServiceAction_.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = true;
			}
			return _employeeCollectionViaRecycleServiceAction_;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaRecycleServiceAction_'. These settings will be taken into account
		/// when the property EmployeeCollectionViaRecycleServiceAction_ is requested or GetMultiEmployeeCollectionViaRecycleServiceAction_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaRecycleServiceAction_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaRecycleServiceAction_.SortClauses=sortClauses;
			_employeeCollectionViaRecycleServiceAction_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaRecycleServiceAction(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaRecycleServiceAction(forceFetch, _employeeCollectionViaRecycleServiceAction.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaRecycleServiceAction(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaRecycleServiceAction || forceFetch || _alwaysFetchEmployeeCollectionViaRecycleServiceAction) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaRecycleServiceAction.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaRecycleServiceAction);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
				_employeeCollectionViaRecycleServiceAction.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaRecycleServiceAction.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaRecycleServiceAction.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction"));
				_employeeCollectionViaRecycleServiceAction.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = true;
			}
			return _employeeCollectionViaRecycleServiceAction;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaRecycleServiceAction'. These settings will be taken into account
		/// when the property EmployeeCollectionViaRecycleServiceAction is requested or GetMultiEmployeeCollectionViaRecycleServiceAction is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaRecycleServiceAction(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaRecycleServiceAction.SortClauses=sortClauses;
			_employeeCollectionViaRecycleServiceAction.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaRecycleServiceChangeLog(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaRecycleServiceChangeLog(forceFetch, _employeeCollectionViaRecycleServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaRecycleServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog || forceFetch || _alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaRecycleServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaRecycleServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
				_employeeCollectionViaRecycleServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaRecycleServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaRecycleServiceChangeLog.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaRecycleServiceChangeLog"));
				_employeeCollectionViaRecycleServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog = true;
			}
			return _employeeCollectionViaRecycleServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaRecycleServiceChangeLog'. These settings will be taken into account
		/// when the property EmployeeCollectionViaRecycleServiceChangeLog is requested or GetMultiEmployeeCollectionViaRecycleServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaRecycleServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaRecycleServiceChangeLog.SortClauses=sortClauses;
			_employeeCollectionViaRecycleServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaRecycleServiceAction___(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaRecycleServiceAction___(forceFetch, _employeeCollectionViaRecycleServiceAction___.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaRecycleServiceAction___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaRecycleServiceAction___ || forceFetch || _alwaysFetchEmployeeCollectionViaRecycleServiceAction___) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaRecycleServiceAction___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaRecycleServiceAction___);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
				_employeeCollectionViaRecycleServiceAction___.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaRecycleServiceAction___.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaRecycleServiceAction___.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction___"));
				_employeeCollectionViaRecycleServiceAction___.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaRecycleServiceAction___ = true;
			}
			return _employeeCollectionViaRecycleServiceAction___;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaRecycleServiceAction___'. These settings will be taken into account
		/// when the property EmployeeCollectionViaRecycleServiceAction___ is requested or GetMultiEmployeeCollectionViaRecycleServiceAction___ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaRecycleServiceAction___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaRecycleServiceAction___.SortClauses=sortClauses;
			_employeeCollectionViaRecycleServiceAction___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaRecycleServiceAction__(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaRecycleServiceAction__(forceFetch, _employeeCollectionViaRecycleServiceAction__.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaRecycleServiceAction__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaRecycleServiceAction__ || forceFetch || _alwaysFetchEmployeeCollectionViaRecycleServiceAction__) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaRecycleServiceAction__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaRecycleServiceAction__);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
				_employeeCollectionViaRecycleServiceAction__.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaRecycleServiceAction__.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaRecycleServiceAction__.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction__"));
				_employeeCollectionViaRecycleServiceAction__.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaRecycleServiceAction__ = true;
			}
			return _employeeCollectionViaRecycleServiceAction__;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaRecycleServiceAction__'. These settings will be taken into account
		/// when the property EmployeeCollectionViaRecycleServiceAction__ is requested or GetMultiEmployeeCollectionViaRecycleServiceAction__ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaRecycleServiceAction__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaRecycleServiceAction__.SortClauses=sortClauses;
			_employeeCollectionViaRecycleServiceAction__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
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
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAssetReclamationServiceChangeLog(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaAssetReclamationServiceChangeLog(forceFetch, _employeeCollectionViaAssetReclamationServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAssetReclamationServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog || forceFetch || _alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaAssetReclamationServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaAssetReclamationServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
				_employeeCollectionViaAssetReclamationServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaAssetReclamationServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaAssetReclamationServiceChangeLog.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaAssetReclamationServiceChangeLog"));
				_employeeCollectionViaAssetReclamationServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog = true;
			}
			return _employeeCollectionViaAssetReclamationServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaAssetReclamationServiceChangeLog'. These settings will be taken into account
		/// when the property EmployeeCollectionViaAssetReclamationServiceChangeLog is requested or GetMultiEmployeeCollectionViaAssetReclamationServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaAssetReclamationServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaAssetReclamationServiceChangeLog.SortClauses=sortClauses;
			_employeeCollectionViaAssetReclamationServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RebateTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RebateTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection GetMultiRebateTypeCollectionViaRebate(bool forceFetch)
		{
			return GetMultiRebateTypeCollectionViaRebate(forceFetch, _rebateTypeCollectionViaRebate.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RebateTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection GetMultiRebateTypeCollectionViaRebate(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRebateTypeCollectionViaRebate || forceFetch || _alwaysFetchRebateTypeCollectionViaRebate) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_rebateTypeCollectionViaRebate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_rebateTypeCollectionViaRebate);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
				_rebateTypeCollectionViaRebate.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_rebateTypeCollectionViaRebate.EntityFactoryToUse = entityFactoryToUse;
				}
				_rebateTypeCollectionViaRebate.GetMulti(filter, GetRelationsForField("RebateTypeCollectionViaRebate"));
				_rebateTypeCollectionViaRebate.SuppressClearInGetMulti=false;
				_alreadyFetchedRebateTypeCollectionViaRebate = true;
			}
			return _rebateTypeCollectionViaRebate;
		}

		/// <summary> Sets the collection parameters for the collection for 'RebateTypeCollectionViaRebate'. These settings will be taken into account
		/// when the property RebateTypeCollectionViaRebate is requested or GetMultiRebateTypeCollectionViaRebate is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRebateTypeCollectionViaRebate(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_rebateTypeCollectionViaRebate.SortClauses=sortClauses;
			_rebateTypeCollectionViaRebate.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(UserFields.UserId, ComparisonOperator.Equal, this.UserId, "UserEntity__"));
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

		/// <summary> Retrieves the related entity of type 'UserTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UserTypeEntity' which is related to this entity.</returns>
		public UserTypeEntity GetSingleUserType()
		{
			return GetSingleUserType(false);
		}

		/// <summary> Retrieves the related entity of type 'UserTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UserTypeEntity' which is related to this entity.</returns>
		public virtual UserTypeEntity GetSingleUserType(bool forceFetch)
		{
			if( ( !_alreadyFetchedUserType || forceFetch || _alwaysFetchUserType) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(UserEntity.Relations.UserTypeEntityUsingUserTypeId);

				UserTypeEntity newEntity = new UserTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.UserTypeId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (UserTypeEntity)base.ActiveContext.Get(newEntity);
					}
					this.UserType = newEntity;
				}
				else
				{
					if(_userTypeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_userType == null)))
						{
							this.UserType = newEntity;
						}
					}
					else
					{
						this.UserType = null;
					}
				}
				_alreadyFetchedUserType = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _userType;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			UserDAO dao = (UserDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_assetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			_changeLog.ActiveContext = base.ActiveContext;
			_deepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_rebate.ActiveContext = base.ActiveContext;
			_recycleServiceAction_.ActiveContext = base.ActiveContext;
			_recycleServiceAction.ActiveContext = base.ActiveContext;
			_recycleServiceChangeLog.ActiveContext = base.ActiveContext;
			_userAccount.ActiveContext = base.ActiveContext;
			_accountCollectionViaRebate.ActiveContext = base.ActiveContext;
			_accountCollectionViaUserAccount.ActiveContext = base.ActiveContext;
			_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			_changeTypeCollectionViaChangeLog.ActiveContext = base.ActiveContext;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_employeeCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			_employeeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_employeeCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			_employeeCollectionViaRecycleServiceAction___.ActiveContext = base.ActiveContext;
			_employeeCollectionViaRecycleServiceAction__.ActiveContext = base.ActiveContext;
			_employeeCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_employeeCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			_employeeCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			_rebateTypeCollectionViaRebate.ActiveContext = base.ActiveContext;
			_recycleServiceCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			_recycleServiceCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			_recycleServiceCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_recycleTypeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_recycleTypeCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			if(_userType!=null)
			{
				_userType.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			UserDAO dao = (UserDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			UserDAO dao = (UserDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.UserEntity);
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
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="validator">The validator object for this UserEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 userId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(userId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_assetReclamationServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection(new AssetReclamationServiceChangeLogEntityFactory());
			_assetReclamationServiceChangeLog.SetContainingEntityInfo(this, "User");
			_alwaysFetchAssetReclamationServiceChangeLog = false;
			_alreadyFetchedAssetReclamationServiceChangeLog = false;
			_changeLog = new Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection(new ChangeLogEntityFactory());
			_changeLog.SetContainingEntityInfo(this, "User");
			_alwaysFetchChangeLog = false;
			_alreadyFetchedChangeLog = false;
			_deepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection(new DeepFryerServiceChangeLogEntityFactory());
			_deepFryerServiceChangeLog.SetContainingEntityInfo(this, "User");
			_alwaysFetchDeepFryerServiceChangeLog = false;
			_alreadyFetchedDeepFryerServiceChangeLog = false;
			_rebate = new Reliant.RenuOil.DAL.CollectionClasses.RebateCollection(new RebateEntityFactory());
			_rebate.SetContainingEntityInfo(this, "User");
			_alwaysFetchRebate = false;
			_alreadyFetchedRebate = false;
			_recycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection(new RecycleServiceActionEntityFactory());
			_recycleServiceAction_.SetContainingEntityInfo(this, "User_");
			_alwaysFetchRecycleServiceAction_ = false;
			_alreadyFetchedRecycleServiceAction_ = false;
			_recycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection(new RecycleServiceActionEntityFactory());
			_recycleServiceAction.SetContainingEntityInfo(this, "User");
			_alwaysFetchRecycleServiceAction = false;
			_alreadyFetchedRecycleServiceAction = false;
			_recycleServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection(new RecycleServiceChangeLogEntityFactory());
			_recycleServiceChangeLog.SetContainingEntityInfo(this, "User");
			_alwaysFetchRecycleServiceChangeLog = false;
			_alreadyFetchedRecycleServiceChangeLog = false;
			_userAccount = new Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection(new UserAccountEntityFactory());
			_userAccount.SetContainingEntityInfo(this, "User");
			_alwaysFetchUserAccount = false;
			_alreadyFetchedUserAccount = false;
			_accountCollectionViaRebate = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaRebate = false;
			_alreadyFetchedAccountCollectionViaRebate = false;
			_accountCollectionViaUserAccount = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaUserAccount = false;
			_alreadyFetchedAccountCollectionViaUserAccount = false;
			_assetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection(new AssetReclamationServiceEntityFactory());
			_alwaysFetchAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = false;
			_alreadyFetchedAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog = false;
			_changeTypeCollectionViaChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.ChangeTypeCollection(new ChangeTypeEntityFactory());
			_alwaysFetchChangeTypeCollectionViaChangeLog = false;
			_alreadyFetchedChangeTypeCollectionViaChangeLog = false;
			_deepFryerServiceCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(new DeepFryerServiceEntityFactory());
			_alwaysFetchDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedDeepFryerServiceCollectionViaDeepFryerServiceChangeLog = false;
			_employeeCollectionViaRecycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction_ = false;
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = false;
			_employeeCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction = false;
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = false;
			_employeeCollectionViaRecycleServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog = false;
			_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog = false;
			_employeeCollectionViaRecycleServiceAction___ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction___ = false;
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction___ = false;
			_employeeCollectionViaRecycleServiceAction__ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction__ = false;
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction__ = false;
			_employeeCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = false;
			_employeeCollectionViaDeepFryerServiceChangeLog_ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_ = false;
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = false;
			_employeeCollectionViaAssetReclamationServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog = false;
			_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog = false;
			_rebateTypeCollectionViaRebate = new Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection(new RebateTypeEntityFactory());
			_alwaysFetchRebateTypeCollectionViaRebate = false;
			_alreadyFetchedRebateTypeCollectionViaRebate = false;
			_recycleServiceCollectionViaRecycleServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(new RecycleServiceEntityFactory());
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceChangeLog = false;
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceChangeLog = false;
			_recycleServiceCollectionViaRecycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(new RecycleServiceEntityFactory());
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction_ = false;
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction_ = false;
			_recycleServiceCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(new RecycleServiceEntityFactory());
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction = false;
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = false;
			_recycleTypeCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(new RecycleTypeEntityFactory());
			_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction = false;
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = false;
			_recycleTypeCollectionViaRecycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(new RecycleTypeEntityFactory());
			_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction_ = false;
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction_ = false;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = false;
			_userType = null;
			_userTypeReturnsNewIfNotFound = true;
			_alwaysFetchUserType = false;
			_alreadyFetchedUserType = false;


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
		private void SetupSyncUserType(IEntity relatedEntity)
		{
			if(_userType!=relatedEntity)
			{		
				DesetupSyncUserType(true, true);
				_userType = (UserTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _userType, new PropertyChangedEventHandler( OnUserTypePropertyChanged ), "UserType", UserEntity.Relations.UserTypeEntityUsingUserTypeId, true, ref _alreadyFetchedUserType, new string[] {  } );
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


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="userId">PK value for User which data should be fetched into this User object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 userId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)UserFieldIndex.UserId].ForcedCurrentValueWrite(userId);
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
			return DAOFactory.CreateUserDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new UserEntityFactory();
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


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AssetReclamationServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAssetReclamationServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("AssetReclamationServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceChangeLogEntity, 0, null, null, null, "AssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("ChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, 0, null, null, null, "ChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("DeepFryerServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, 0, null, null, null, "DeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Rebate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRebate
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RebateCollection(),
					(IEntityRelation)GetRelationsForField("Rebate")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RebateEntity, 0, null, null, null, "Rebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("RecycleServiceAction_")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, "RecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("RecycleServiceAction")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, "RecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("RecycleServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceChangeLogEntity, 0, null, null, null, "RecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UserAccount' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserAccount
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection(),
					(IEntityRelation)GetRelationsForField("UserAccount")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.UserAccountEntity, 0, null, null, null, "UserAccount", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaRebate
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RebateEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "Rebate_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaRebate"), "AccountCollectionViaRebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaUserAccount
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.UserAccountEntityUsingUserId;
				intermediateRelation.SetAliases(string.Empty, "UserAccount_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaUserAccount"), "AccountCollectionViaUserAccount", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AssetReclamationService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, 0, null, null, GetRelationsForField("AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog"), "AssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChangeType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChangeTypeCollectionViaChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.ChangeLogEntityUsingUserId;
				intermediateRelation.SetAliases(string.Empty, "ChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ChangeTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity, 0, null, null, GetRelationsForField("ChangeTypeCollectionViaChangeLog"), "ChangeTypeCollectionViaChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerServiceCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, GetRelationsForField("DeepFryerServiceCollectionViaDeepFryerServiceChangeLog"), "DeepFryerServiceCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction_"), "EmployeeCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction"), "EmployeeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceChangeLog"), "EmployeeCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaRecycleServiceAction___
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction___"), "EmployeeCollectionViaRecycleServiceAction___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaRecycleServiceAction__
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction__"), "EmployeeCollectionViaRecycleServiceAction__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog"), "EmployeeCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog_"), "EmployeeCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.AssetReclamationServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAssetReclamationServiceChangeLog"), "EmployeeCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RebateType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRebateTypeCollectionViaRebate
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RebateEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "Rebate_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RebateTypeEntity, 0, null, null, GetRelationsForField("RebateTypeCollectionViaRebate"), "RebateTypeCollectionViaRebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceChangeLog"), "RecycleServiceCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction_"), "RecycleServiceCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction"), "RecycleServiceCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleTypeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingActionUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction"), "RecycleTypeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleTypeCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.RecycleServiceActionEntityUsingLastChangedByUserId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction_"), "RecycleTypeCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = UserEntity.Relations.DeepFryerServiceChangeLogEntityUsingEnteredByUserId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog"), "ServiceLocationCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UserType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserType
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserTypeCollection(),
					(IEntityRelation)GetRelationsForField("UserType")[0], (int)Reliant.RenuOil.DAL.EntityType.UserEntity, (int)Reliant.RenuOil.DAL.EntityType.UserTypeEntity, 0, null, null, null, "UserType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "UserEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return UserEntity.CustomProperties;}
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
			set	{ SetValue((int)UserFieldIndex.UserId, value, true); }
		}
		/// <summary> The Username property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."Username"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Username
		{
			get { return (System.String)GetValue((int)UserFieldIndex.Username, true); }
			set	{ SetValue((int)UserFieldIndex.Username, value, true); }
		}
		/// <summary> The Password property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): Binary, 0, 0, 16<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.Byte[] Password
		{
			get { return (System.Byte[])GetValue((int)UserFieldIndex.Password, true); }
			set	{ SetValue((int)UserFieldIndex.Password, value, true); }
		}
		/// <summary> The FirstName property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.FirstName, true); }
			set	{ SetValue((int)UserFieldIndex.FirstName, value, true); }
		}
		/// <summary> The MiddleName property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."MiddleName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MiddleName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.MiddleName, true); }
			set	{ SetValue((int)UserFieldIndex.MiddleName, value, true); }
		}
		/// <summary> The LastName property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)UserFieldIndex.LastName, true); }
			set	{ SetValue((int)UserFieldIndex.LastName, value, true); }
		}
		/// <summary> The UserTypeId property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."UserTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 UserTypeId
		{
			get { return (System.Int32)GetValue((int)UserFieldIndex.UserTypeId, true); }
			set	{ SetValue((int)UserFieldIndex.UserTypeId, value, true); }
		}
		/// <summary> The IsActive property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsActive, true); }
			set	{ SetValue((int)UserFieldIndex.IsActive, value, true); }
		}
		/// <summary> The IsEnabled property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."IsEnabled"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsEnabled
		{
			get { return (System.Boolean)GetValue((int)UserFieldIndex.IsEnabled, true); }
			set	{ SetValue((int)UserFieldIndex.IsEnabled, value, true); }
		}
		/// <summary> The EmailAddress property of the Entity User<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "User"."EmailAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmailAddress
		{
			get { return (System.String)GetValue((int)UserFieldIndex.EmailAddress, true); }
			set	{ SetValue((int)UserFieldIndex.EmailAddress, value, true); }
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
		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection ChangeLog
		{
			get	{ return GetMultiChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ChangeLog. When set to true, ChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChangeLog
		{
			get	{ return _alwaysFetchChangeLog; }
			set	{ _alwaysFetchChangeLog = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChangeLog already has been fetched. Setting this property to false when ChangeLog has been fetched
		/// will clear the ChangeLog collection well. Setting this property to true while ChangeLog hasn't been fetched disables lazy loading for ChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChangeLog
		{
			get { return _alreadyFetchedChangeLog;}
			set 
			{
				if(_alreadyFetchedChangeLog && !value && (_changeLog != null))
				{
					_changeLog.Clear();
				}
				_alreadyFetchedChangeLog = value;
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
		/// <summary> Retrieves all related entities of type 'RebateEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRebate()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RebateCollection Rebate
		{
			get	{ return GetMultiRebate(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Rebate. When set to true, Rebate is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Rebate is accessed. You can always execute
		/// a forced fetch by calling GetMultiRebate(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRebate
		{
			get	{ return _alwaysFetchRebate; }
			set	{ _alwaysFetchRebate = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Rebate already has been fetched. Setting this property to false when Rebate has been fetched
		/// will clear the Rebate collection well. Setting this property to true while Rebate hasn't been fetched disables lazy loading for Rebate</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRebate
		{
			get { return _alreadyFetchedRebate;}
			set 
			{
				if(_alreadyFetchedRebate && !value && (_rebate != null))
				{
					_rebate.Clear();
				}
				_alreadyFetchedRebate = value;
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
		/// <summary> Retrieves all related entities of type 'UserAccountEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserAccount()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection UserAccount
		{
			get	{ return GetMultiUserAccount(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserAccount. When set to true, UserAccount is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserAccount is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserAccount(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserAccount
		{
			get	{ return _alwaysFetchUserAccount; }
			set	{ _alwaysFetchUserAccount = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserAccount already has been fetched. Setting this property to false when UserAccount has been fetched
		/// will clear the UserAccount collection well. Setting this property to true while UserAccount hasn't been fetched disables lazy loading for UserAccount</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserAccount
		{
			get { return _alreadyFetchedUserAccount;}
			set 
			{
				if(_alreadyFetchedUserAccount && !value && (_userAccount != null))
				{
					_userAccount.Clear();
				}
				_alreadyFetchedUserAccount = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaRebate()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaRebate
		{
			get { return GetMultiAccountCollectionViaRebate(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaRebate. When set to true, AccountCollectionViaRebate is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaRebate is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaRebate(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaRebate
		{
			get	{ return _alwaysFetchAccountCollectionViaRebate; }
			set	{ _alwaysFetchAccountCollectionViaRebate = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaRebate already has been fetched. Setting this property to false when AccountCollectionViaRebate has been fetched
		/// will clear the AccountCollectionViaRebate collection well. Setting this property to true while AccountCollectionViaRebate hasn't been fetched disables lazy loading for AccountCollectionViaRebate</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaRebate
		{
			get { return _alreadyFetchedAccountCollectionViaRebate;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaRebate && !value && (_accountCollectionViaRebate != null))
				{
					_accountCollectionViaRebate.Clear();
				}
				_alreadyFetchedAccountCollectionViaRebate = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaUserAccount()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaUserAccount
		{
			get { return GetMultiAccountCollectionViaUserAccount(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaUserAccount. When set to true, AccountCollectionViaUserAccount is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaUserAccount is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaUserAccount(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaUserAccount
		{
			get	{ return _alwaysFetchAccountCollectionViaUserAccount; }
			set	{ _alwaysFetchAccountCollectionViaUserAccount = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaUserAccount already has been fetched. Setting this property to false when AccountCollectionViaUserAccount has been fetched
		/// will clear the AccountCollectionViaUserAccount collection well. Setting this property to true while AccountCollectionViaUserAccount hasn't been fetched disables lazy loading for AccountCollectionViaUserAccount</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaUserAccount
		{
			get { return _alreadyFetchedAccountCollectionViaUserAccount;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaUserAccount && !value && (_accountCollectionViaUserAccount != null))
				{
					_accountCollectionViaUserAccount.Clear();
				}
				_alreadyFetchedAccountCollectionViaUserAccount = value;
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
		/// <summary> Retrieves all related entities of type 'ChangeTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChangeTypeCollectionViaChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ChangeTypeCollection ChangeTypeCollectionViaChangeLog
		{
			get { return GetMultiChangeTypeCollectionViaChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ChangeTypeCollectionViaChangeLog. When set to true, ChangeTypeCollectionViaChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChangeTypeCollectionViaChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiChangeTypeCollectionViaChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChangeTypeCollectionViaChangeLog
		{
			get	{ return _alwaysFetchChangeTypeCollectionViaChangeLog; }
			set	{ _alwaysFetchChangeTypeCollectionViaChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChangeTypeCollectionViaChangeLog already has been fetched. Setting this property to false when ChangeTypeCollectionViaChangeLog has been fetched
		/// will clear the ChangeTypeCollectionViaChangeLog collection well. Setting this property to true while ChangeTypeCollectionViaChangeLog hasn't been fetched disables lazy loading for ChangeTypeCollectionViaChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChangeTypeCollectionViaChangeLog
		{
			get { return _alreadyFetchedChangeTypeCollectionViaChangeLog;}
			set 
			{
				if(_alreadyFetchedChangeTypeCollectionViaChangeLog && !value && (_changeTypeCollectionViaChangeLog != null))
				{
					_changeTypeCollectionViaChangeLog.Clear();
				}
				_alreadyFetchedChangeTypeCollectionViaChangeLog = value;
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaRecycleServiceAction_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaRecycleServiceAction_
		{
			get { return GetMultiEmployeeCollectionViaRecycleServiceAction_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaRecycleServiceAction_. When set to true, EmployeeCollectionViaRecycleServiceAction_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaRecycleServiceAction_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaRecycleServiceAction_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaRecycleServiceAction_
		{
			get	{ return _alwaysFetchEmployeeCollectionViaRecycleServiceAction_; }
			set	{ _alwaysFetchEmployeeCollectionViaRecycleServiceAction_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaRecycleServiceAction_ already has been fetched. Setting this property to false when EmployeeCollectionViaRecycleServiceAction_ has been fetched
		/// will clear the EmployeeCollectionViaRecycleServiceAction_ collection well. Setting this property to true while EmployeeCollectionViaRecycleServiceAction_ hasn't been fetched disables lazy loading for EmployeeCollectionViaRecycleServiceAction_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaRecycleServiceAction_
		{
			get { return _alreadyFetchedEmployeeCollectionViaRecycleServiceAction_;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ && !value && (_employeeCollectionViaRecycleServiceAction_ != null))
				{
					_employeeCollectionViaRecycleServiceAction_.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaRecycleServiceAction()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaRecycleServiceAction
		{
			get { return GetMultiEmployeeCollectionViaRecycleServiceAction(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaRecycleServiceAction. When set to true, EmployeeCollectionViaRecycleServiceAction is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaRecycleServiceAction is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaRecycleServiceAction(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaRecycleServiceAction
		{
			get	{ return _alwaysFetchEmployeeCollectionViaRecycleServiceAction; }
			set	{ _alwaysFetchEmployeeCollectionViaRecycleServiceAction = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaRecycleServiceAction already has been fetched. Setting this property to false when EmployeeCollectionViaRecycleServiceAction has been fetched
		/// will clear the EmployeeCollectionViaRecycleServiceAction collection well. Setting this property to true while EmployeeCollectionViaRecycleServiceAction hasn't been fetched disables lazy loading for EmployeeCollectionViaRecycleServiceAction</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaRecycleServiceAction
		{
			get { return _alreadyFetchedEmployeeCollectionViaRecycleServiceAction;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaRecycleServiceAction && !value && (_employeeCollectionViaRecycleServiceAction != null))
				{
					_employeeCollectionViaRecycleServiceAction.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaRecycleServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaRecycleServiceChangeLog
		{
			get { return GetMultiEmployeeCollectionViaRecycleServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaRecycleServiceChangeLog. When set to true, EmployeeCollectionViaRecycleServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaRecycleServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaRecycleServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaRecycleServiceChangeLog
		{
			get	{ return _alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog; }
			set	{ _alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaRecycleServiceChangeLog already has been fetched. Setting this property to false when EmployeeCollectionViaRecycleServiceChangeLog has been fetched
		/// will clear the EmployeeCollectionViaRecycleServiceChangeLog collection well. Setting this property to true while EmployeeCollectionViaRecycleServiceChangeLog hasn't been fetched disables lazy loading for EmployeeCollectionViaRecycleServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog
		{
			get { return _alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog && !value && (_employeeCollectionViaRecycleServiceChangeLog != null))
				{
					_employeeCollectionViaRecycleServiceChangeLog.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaRecycleServiceAction___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaRecycleServiceAction___
		{
			get { return GetMultiEmployeeCollectionViaRecycleServiceAction___(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaRecycleServiceAction___. When set to true, EmployeeCollectionViaRecycleServiceAction___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaRecycleServiceAction___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaRecycleServiceAction___(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaRecycleServiceAction___
		{
			get	{ return _alwaysFetchEmployeeCollectionViaRecycleServiceAction___; }
			set	{ _alwaysFetchEmployeeCollectionViaRecycleServiceAction___ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaRecycleServiceAction___ already has been fetched. Setting this property to false when EmployeeCollectionViaRecycleServiceAction___ has been fetched
		/// will clear the EmployeeCollectionViaRecycleServiceAction___ collection well. Setting this property to true while EmployeeCollectionViaRecycleServiceAction___ hasn't been fetched disables lazy loading for EmployeeCollectionViaRecycleServiceAction___</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaRecycleServiceAction___
		{
			get { return _alreadyFetchedEmployeeCollectionViaRecycleServiceAction___;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaRecycleServiceAction___ && !value && (_employeeCollectionViaRecycleServiceAction___ != null))
				{
					_employeeCollectionViaRecycleServiceAction___.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaRecycleServiceAction___ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaRecycleServiceAction__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaRecycleServiceAction__
		{
			get { return GetMultiEmployeeCollectionViaRecycleServiceAction__(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaRecycleServiceAction__. When set to true, EmployeeCollectionViaRecycleServiceAction__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaRecycleServiceAction__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaRecycleServiceAction__(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaRecycleServiceAction__
		{
			get	{ return _alwaysFetchEmployeeCollectionViaRecycleServiceAction__; }
			set	{ _alwaysFetchEmployeeCollectionViaRecycleServiceAction__ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaRecycleServiceAction__ already has been fetched. Setting this property to false when EmployeeCollectionViaRecycleServiceAction__ has been fetched
		/// will clear the EmployeeCollectionViaRecycleServiceAction__ collection well. Setting this property to true while EmployeeCollectionViaRecycleServiceAction__ hasn't been fetched disables lazy loading for EmployeeCollectionViaRecycleServiceAction__</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaRecycleServiceAction__
		{
			get { return _alreadyFetchedEmployeeCollectionViaRecycleServiceAction__;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaRecycleServiceAction__ && !value && (_employeeCollectionViaRecycleServiceAction__ != null))
				{
					_employeeCollectionViaRecycleServiceAction__.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaRecycleServiceAction__ = value;
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaAssetReclamationServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaAssetReclamationServiceChangeLog
		{
			get { return GetMultiEmployeeCollectionViaAssetReclamationServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaAssetReclamationServiceChangeLog. When set to true, EmployeeCollectionViaAssetReclamationServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaAssetReclamationServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaAssetReclamationServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog
		{
			get	{ return _alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog; }
			set	{ _alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaAssetReclamationServiceChangeLog already has been fetched. Setting this property to false when EmployeeCollectionViaAssetReclamationServiceChangeLog has been fetched
		/// will clear the EmployeeCollectionViaAssetReclamationServiceChangeLog collection well. Setting this property to true while EmployeeCollectionViaAssetReclamationServiceChangeLog hasn't been fetched disables lazy loading for EmployeeCollectionViaAssetReclamationServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog
		{
			get { return _alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog && !value && (_employeeCollectionViaAssetReclamationServiceChangeLog != null))
				{
					_employeeCollectionViaAssetReclamationServiceChangeLog.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RebateTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRebateTypeCollectionViaRebate()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection RebateTypeCollectionViaRebate
		{
			get { return GetMultiRebateTypeCollectionViaRebate(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RebateTypeCollectionViaRebate. When set to true, RebateTypeCollectionViaRebate is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RebateTypeCollectionViaRebate is accessed. You can always execute
		/// a forced fetch by calling GetMultiRebateTypeCollectionViaRebate(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRebateTypeCollectionViaRebate
		{
			get	{ return _alwaysFetchRebateTypeCollectionViaRebate; }
			set	{ _alwaysFetchRebateTypeCollectionViaRebate = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RebateTypeCollectionViaRebate already has been fetched. Setting this property to false when RebateTypeCollectionViaRebate has been fetched
		/// will clear the RebateTypeCollectionViaRebate collection well. Setting this property to true while RebateTypeCollectionViaRebate hasn't been fetched disables lazy loading for RebateTypeCollectionViaRebate</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRebateTypeCollectionViaRebate
		{
			get { return _alreadyFetchedRebateTypeCollectionViaRebate;}
			set 
			{
				if(_alreadyFetchedRebateTypeCollectionViaRebate && !value && (_rebateTypeCollectionViaRebate != null))
				{
					_rebateTypeCollectionViaRebate.Clear();
				}
				_alreadyFetchedRebateTypeCollectionViaRebate = value;
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

		/// <summary> Gets / sets related entity of type 'UserTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUserType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UserTypeEntity UserType
		{
			get	{ return GetSingleUserType(false); }
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
							((IEntity)value).SetRelatedEntity(this, "User");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for UserType. When set to true, UserType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserType is accessed. You can always execute
		/// a forced fetch by calling GetSingleUserType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserType
		{
			get	{ return _alwaysFetchUserType; }
			set	{ _alwaysFetchUserType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserType already has been fetched. Setting this property to false when UserType has been fetched
		/// will set UserType to null as well. Setting this property to true while UserType hasn't been fetched disables lazy loading for UserType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserType
		{
			get { return _alreadyFetchedUserType;}
			set 
			{
				if(_alreadyFetchedUserType && !value)
				{
					this.UserType = null;
				}
				_alreadyFetchedUserType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property UserType is not found
		/// in the database. When set to true, UserType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool UserTypeReturnsNewIfNotFound
		{
			get	{ return _userTypeReturnsNewIfNotFound; }
			set { _userTypeReturnsNewIfNotFound = value; }	
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
