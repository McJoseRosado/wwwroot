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
	/// Entity class which represents the entity 'Account'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AccountEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection	_accountEmployeeAssignment;
		private bool	_alwaysFetchAccountEmployeeAssignment, _alreadyFetchedAccountEmployeeAssignment;
		private Reliant.RenuOil.DAL.CollectionClasses.BaleCollection	_bale;
		private bool	_alwaysFetchBale, _alreadyFetchedBale;
		private Reliant.RenuOil.DAL.CollectionClasses.RebateCollection	_rebate;
		private bool	_alwaysFetchRebate, _alreadyFetchedRebate;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection	_recycleVendorService;
		private bool	_alwaysFetchRecycleVendorService, _alreadyFetchedRecycleVendorService;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection	_serviceLocation;
		private bool	_alwaysFetchServiceLocation, _alreadyFetchedServiceLocation;
		private Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection	_userAccount;
		private bool	_alwaysFetchUserAccount, _alreadyFetchedUserAccount;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection	_workOrder;
		private bool	_alwaysFetchWorkOrder, _alreadyFetchedWorkOrder;
		private Reliant.RenuOil.DAL.CollectionClasses.DockCollection _dockCollectionViaBale;
		private bool	_alwaysFetchDockCollectionViaBale, _alreadyFetchedDockCollectionViaBale;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaAccountEmployeeAssignment_____;
		private bool	_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_____, _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaAccountEmployeeAssignment______;
		private bool	_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment______, _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaWorkOrder;
		private bool	_alwaysFetchEmployeeCollectionViaWorkOrder, _alreadyFetchedEmployeeCollectionViaWorkOrder;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaAccountEmployeeAssignment____;
		private bool	_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment____, _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaAccountEmployeeAssignment_;
		private bool	_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_, _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaAccountEmployeeAssignment;
		private bool	_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment, _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaAccountEmployeeAssignment___;
		private bool	_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment___, _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaAccountEmployeeAssignment__;
		private bool	_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment__, _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__;
		private Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection _rebateTypeCollectionViaRebate;
		private bool	_alwaysFetchRebateTypeCollectionViaRebate, _alreadyFetchedRebateTypeCollectionViaRebate;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection _recycleTypeCollectionViaRecycleVendorService;
		private bool	_alwaysFetchRecycleTypeCollectionViaRecycleVendorService, _alreadyFetchedRecycleTypeCollectionViaRecycleVendorService;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection _recycleTypeCollectionViaBale;
		private bool	_alwaysFetchRecycleTypeCollectionViaBale, _alreadyFetchedRecycleTypeCollectionViaBale;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection _recycleVendorCollectionViaRecycleVendorService;
		private bool	_alwaysFetchRecycleVendorCollectionViaRecycleVendorService, _alreadyFetchedRecycleVendorCollectionViaRecycleVendorService;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection _serviceTypeCollectionViaWorkOrder;
		private bool	_alwaysFetchServiceTypeCollectionViaWorkOrder, _alreadyFetchedServiceTypeCollectionViaWorkOrder;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection _serviceTypeCollectionViaServiceLocation;
		private bool	_alwaysFetchServiceTypeCollectionViaServiceLocation, _alreadyFetchedServiceTypeCollectionViaServiceLocation;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRebate;
		private bool	_alwaysFetchUserCollectionViaRebate, _alreadyFetchedUserCollectionViaRebate;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaUserAccount;
		private bool	_alwaysFetchUserCollectionViaUserAccount, _alreadyFetchedUserCollectionViaUserAccount;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name AccountEmployeeAssignment</summary>
			public static readonly string AccountEmployeeAssignment = "AccountEmployeeAssignment";
			/// <summary>Member name Bale</summary>
			public static readonly string Bale = "Bale";
			/// <summary>Member name Rebate</summary>
			public static readonly string Rebate = "Rebate";
			/// <summary>Member name RecycleVendorService</summary>
			public static readonly string RecycleVendorService = "RecycleVendorService";
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name UserAccount</summary>
			public static readonly string UserAccount = "UserAccount";
			/// <summary>Member name WorkOrder</summary>
			public static readonly string WorkOrder = "WorkOrder";
			/// <summary>Member name DockCollectionViaBale</summary>
			public static readonly string DockCollectionViaBale = "DockCollectionViaBale";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment_____</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment_____ = "EmployeeCollectionViaAccountEmployeeAssignment_____";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment______</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment______ = "EmployeeCollectionViaAccountEmployeeAssignment______";
			/// <summary>Member name EmployeeCollectionViaWorkOrder</summary>
			public static readonly string EmployeeCollectionViaWorkOrder = "EmployeeCollectionViaWorkOrder";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment____</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment____ = "EmployeeCollectionViaAccountEmployeeAssignment____";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment_</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment_ = "EmployeeCollectionViaAccountEmployeeAssignment_";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment = "EmployeeCollectionViaAccountEmployeeAssignment";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment___</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment___ = "EmployeeCollectionViaAccountEmployeeAssignment___";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment__</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment__ = "EmployeeCollectionViaAccountEmployeeAssignment__";
			/// <summary>Member name RebateTypeCollectionViaRebate</summary>
			public static readonly string RebateTypeCollectionViaRebate = "RebateTypeCollectionViaRebate";
			/// <summary>Member name RecycleTypeCollectionViaRecycleVendorService</summary>
			public static readonly string RecycleTypeCollectionViaRecycleVendorService = "RecycleTypeCollectionViaRecycleVendorService";
			/// <summary>Member name RecycleTypeCollectionViaBale</summary>
			public static readonly string RecycleTypeCollectionViaBale = "RecycleTypeCollectionViaBale";
			/// <summary>Member name RecycleVendorCollectionViaRecycleVendorService</summary>
			public static readonly string RecycleVendorCollectionViaRecycleVendorService = "RecycleVendorCollectionViaRecycleVendorService";
			/// <summary>Member name ServiceTypeCollectionViaWorkOrder</summary>
			public static readonly string ServiceTypeCollectionViaWorkOrder = "ServiceTypeCollectionViaWorkOrder";
			/// <summary>Member name ServiceTypeCollectionViaServiceLocation</summary>
			public static readonly string ServiceTypeCollectionViaServiceLocation = "ServiceTypeCollectionViaServiceLocation";
			/// <summary>Member name UserCollectionViaRebate</summary>
			public static readonly string UserCollectionViaRebate = "UserCollectionViaRebate";
			/// <summary>Member name UserCollectionViaUserAccount</summary>
			public static readonly string UserCollectionViaUserAccount = "UserCollectionViaUserAccount";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AccountEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AccountEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		public AccountEntity(System.Int32 accountId)
		{
			InitClassFetch(accountId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AccountEntity(System.Int32 accountId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(accountId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		/// <param name="validator">The custom validator object for this AccountEntity</param>
		public AccountEntity(System.Int32 accountId, IValidator validator)
		{
			InitClassFetch(accountId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AccountEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_accountEmployeeAssignment = (Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection)info.GetValue("_accountEmployeeAssignment", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection));
			_alwaysFetchAccountEmployeeAssignment = info.GetBoolean("_alwaysFetchAccountEmployeeAssignment");
			_alreadyFetchedAccountEmployeeAssignment = info.GetBoolean("_alreadyFetchedAccountEmployeeAssignment");
			_bale = (Reliant.RenuOil.DAL.CollectionClasses.BaleCollection)info.GetValue("_bale", typeof(Reliant.RenuOil.DAL.CollectionClasses.BaleCollection));
			_alwaysFetchBale = info.GetBoolean("_alwaysFetchBale");
			_alreadyFetchedBale = info.GetBoolean("_alreadyFetchedBale");
			_rebate = (Reliant.RenuOil.DAL.CollectionClasses.RebateCollection)info.GetValue("_rebate", typeof(Reliant.RenuOil.DAL.CollectionClasses.RebateCollection));
			_alwaysFetchRebate = info.GetBoolean("_alwaysFetchRebate");
			_alreadyFetchedRebate = info.GetBoolean("_alreadyFetchedRebate");
			_recycleVendorService = (Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection)info.GetValue("_recycleVendorService", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection));
			_alwaysFetchRecycleVendorService = info.GetBoolean("_alwaysFetchRecycleVendorService");
			_alreadyFetchedRecycleVendorService = info.GetBoolean("_alreadyFetchedRecycleVendorService");
			_serviceLocation = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocation", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocation = info.GetBoolean("_alwaysFetchServiceLocation");
			_alreadyFetchedServiceLocation = info.GetBoolean("_alreadyFetchedServiceLocation");
			_userAccount = (Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection)info.GetValue("_userAccount", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection));
			_alwaysFetchUserAccount = info.GetBoolean("_alwaysFetchUserAccount");
			_alreadyFetchedUserAccount = info.GetBoolean("_alreadyFetchedUserAccount");
			_workOrder = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection)info.GetValue("_workOrder", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection));
			_alwaysFetchWorkOrder = info.GetBoolean("_alwaysFetchWorkOrder");
			_alreadyFetchedWorkOrder = info.GetBoolean("_alreadyFetchedWorkOrder");
			_dockCollectionViaBale = (Reliant.RenuOil.DAL.CollectionClasses.DockCollection)info.GetValue("_dockCollectionViaBale", typeof(Reliant.RenuOil.DAL.CollectionClasses.DockCollection));
			_alwaysFetchDockCollectionViaBale = info.GetBoolean("_alwaysFetchDockCollectionViaBale");
			_alreadyFetchedDockCollectionViaBale = info.GetBoolean("_alreadyFetchedDockCollectionViaBale");
			_employeeCollectionViaAccountEmployeeAssignment_____ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment_____", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_____ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_____");
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____");
			_employeeCollectionViaAccountEmployeeAssignment______ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment______", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment______ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment______");
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______");
			_employeeCollectionViaWorkOrder = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaWorkOrder", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaWorkOrder = info.GetBoolean("_alwaysFetchEmployeeCollectionViaWorkOrder");
			_alreadyFetchedEmployeeCollectionViaWorkOrder = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaWorkOrder");
			_employeeCollectionViaAccountEmployeeAssignment____ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment____", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment____ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment____");
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____");
			_employeeCollectionViaAccountEmployeeAssignment_ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment_", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_");
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_");
			_employeeCollectionViaAccountEmployeeAssignment = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment = info.GetBoolean("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment");
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment");
			_employeeCollectionViaAccountEmployeeAssignment___ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment___", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment___ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment___");
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___");
			_employeeCollectionViaAccountEmployeeAssignment__ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment__", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment__ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment__");
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__");
			_rebateTypeCollectionViaRebate = (Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection)info.GetValue("_rebateTypeCollectionViaRebate", typeof(Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection));
			_alwaysFetchRebateTypeCollectionViaRebate = info.GetBoolean("_alwaysFetchRebateTypeCollectionViaRebate");
			_alreadyFetchedRebateTypeCollectionViaRebate = info.GetBoolean("_alreadyFetchedRebateTypeCollectionViaRebate");
			_recycleTypeCollectionViaRecycleVendorService = (Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection)info.GetValue("_recycleTypeCollectionViaRecycleVendorService", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection));
			_alwaysFetchRecycleTypeCollectionViaRecycleVendorService = info.GetBoolean("_alwaysFetchRecycleTypeCollectionViaRecycleVendorService");
			_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = info.GetBoolean("_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService");
			_recycleTypeCollectionViaBale = (Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection)info.GetValue("_recycleTypeCollectionViaBale", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection));
			_alwaysFetchRecycleTypeCollectionViaBale = info.GetBoolean("_alwaysFetchRecycleTypeCollectionViaBale");
			_alreadyFetchedRecycleTypeCollectionViaBale = info.GetBoolean("_alreadyFetchedRecycleTypeCollectionViaBale");
			_recycleVendorCollectionViaRecycleVendorService = (Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection)info.GetValue("_recycleVendorCollectionViaRecycleVendorService", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection));
			_alwaysFetchRecycleVendorCollectionViaRecycleVendorService = info.GetBoolean("_alwaysFetchRecycleVendorCollectionViaRecycleVendorService");
			_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService = info.GetBoolean("_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService");
			_serviceTypeCollectionViaWorkOrder = (Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection)info.GetValue("_serviceTypeCollectionViaWorkOrder", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection));
			_alwaysFetchServiceTypeCollectionViaWorkOrder = info.GetBoolean("_alwaysFetchServiceTypeCollectionViaWorkOrder");
			_alreadyFetchedServiceTypeCollectionViaWorkOrder = info.GetBoolean("_alreadyFetchedServiceTypeCollectionViaWorkOrder");
			_serviceTypeCollectionViaServiceLocation = (Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection)info.GetValue("_serviceTypeCollectionViaServiceLocation", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection));
			_alwaysFetchServiceTypeCollectionViaServiceLocation = info.GetBoolean("_alwaysFetchServiceTypeCollectionViaServiceLocation");
			_alreadyFetchedServiceTypeCollectionViaServiceLocation = info.GetBoolean("_alreadyFetchedServiceTypeCollectionViaServiceLocation");
			_userCollectionViaRebate = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRebate", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRebate = info.GetBoolean("_alwaysFetchUserCollectionViaRebate");
			_alreadyFetchedUserCollectionViaRebate = info.GetBoolean("_alreadyFetchedUserCollectionViaRebate");
			_userCollectionViaUserAccount = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaUserAccount", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaUserAccount = info.GetBoolean("_alwaysFetchUserCollectionViaUserAccount");
			_alreadyFetchedUserCollectionViaUserAccount = info.GetBoolean("_alreadyFetchedUserCollectionViaUserAccount");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AccountFieldIndex)fieldIndex)
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
			_alreadyFetchedAccountEmployeeAssignment = (_accountEmployeeAssignment.Count > 0);
			_alreadyFetchedBale = (_bale.Count > 0);
			_alreadyFetchedRebate = (_rebate.Count > 0);
			_alreadyFetchedRecycleVendorService = (_recycleVendorService.Count > 0);
			_alreadyFetchedServiceLocation = (_serviceLocation.Count > 0);
			_alreadyFetchedUserAccount = (_userAccount.Count > 0);
			_alreadyFetchedWorkOrder = (_workOrder.Count > 0);
			_alreadyFetchedDockCollectionViaBale = (_dockCollectionViaBale.Count > 0);
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____ = (_employeeCollectionViaAccountEmployeeAssignment_____.Count > 0);
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______ = (_employeeCollectionViaAccountEmployeeAssignment______.Count > 0);
			_alreadyFetchedEmployeeCollectionViaWorkOrder = (_employeeCollectionViaWorkOrder.Count > 0);
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____ = (_employeeCollectionViaAccountEmployeeAssignment____.Count > 0);
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_ = (_employeeCollectionViaAccountEmployeeAssignment_.Count > 0);
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment = (_employeeCollectionViaAccountEmployeeAssignment.Count > 0);
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___ = (_employeeCollectionViaAccountEmployeeAssignment___.Count > 0);
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__ = (_employeeCollectionViaAccountEmployeeAssignment__.Count > 0);
			_alreadyFetchedRebateTypeCollectionViaRebate = (_rebateTypeCollectionViaRebate.Count > 0);
			_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = (_recycleTypeCollectionViaRecycleVendorService.Count > 0);
			_alreadyFetchedRecycleTypeCollectionViaBale = (_recycleTypeCollectionViaBale.Count > 0);
			_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService = (_recycleVendorCollectionViaRecycleVendorService.Count > 0);
			_alreadyFetchedServiceTypeCollectionViaWorkOrder = (_serviceTypeCollectionViaWorkOrder.Count > 0);
			_alreadyFetchedServiceTypeCollectionViaServiceLocation = (_serviceTypeCollectionViaServiceLocation.Count > 0);
			_alreadyFetchedUserCollectionViaRebate = (_userCollectionViaRebate.Count > 0);
			_alreadyFetchedUserCollectionViaUserAccount = (_userCollectionViaUserAccount.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return AccountEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "AccountEmployeeAssignment":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId);
					break;
				case "Bale":
					toReturn.Add(AccountEntity.Relations.BaleEntityUsingAccountId);
					break;
				case "Rebate":
					toReturn.Add(AccountEntity.Relations.RebateEntityUsingAccountId);
					break;
				case "RecycleVendorService":
					toReturn.Add(AccountEntity.Relations.RecycleVendorServiceEntityUsingAccountId);
					break;
				case "ServiceLocation":
					toReturn.Add(AccountEntity.Relations.ServiceLocationEntityUsingAccountId);
					break;
				case "UserAccount":
					toReturn.Add(AccountEntity.Relations.UserAccountEntityUsingAccountId);
					break;
				case "WorkOrder":
					toReturn.Add(AccountEntity.Relations.WorkOrderEntityUsingAccountId);
					break;
				case "DockCollectionViaBale":
					toReturn.Add(AccountEntity.Relations.BaleEntityUsingAccountId, "AccountEntity__", "Bale_", JoinHint.None);
					toReturn.Add(BaleEntity.Relations.DockEntityUsingDockId, "Bale_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment_____":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingTuesday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment______":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingWednesday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaWorkOrder":
					toReturn.Add(AccountEntity.Relations.WorkOrderEntityUsingAccountId, "AccountEntity__", "WorkOrder_", JoinHint.None);
					toReturn.Add(WorkOrderEntity.Relations.EmployeeEntityUsingTechnicianId, "WorkOrder_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment____":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingThursday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment_":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingMonday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingFriday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment___":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSunday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment__":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSaturday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "RebateTypeCollectionViaRebate":
					toReturn.Add(AccountEntity.Relations.RebateEntityUsingAccountId, "AccountEntity__", "Rebate_", JoinHint.None);
					toReturn.Add(RebateEntity.Relations.RebateTypeEntityUsingRebateTypeId, "Rebate_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaRecycleVendorService":
					toReturn.Add(AccountEntity.Relations.RecycleVendorServiceEntityUsingAccountId, "AccountEntity__", "RecycleVendorService_", JoinHint.None);
					toReturn.Add(RecycleVendorServiceEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "RecycleVendorService_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaBale":
					toReturn.Add(AccountEntity.Relations.BaleEntityUsingAccountId, "AccountEntity__", "Bale_", JoinHint.None);
					toReturn.Add(BaleEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "Bale_", string.Empty, JoinHint.None);
					break;
				case "RecycleVendorCollectionViaRecycleVendorService":
					toReturn.Add(AccountEntity.Relations.RecycleVendorServiceEntityUsingAccountId, "AccountEntity__", "RecycleVendorService_", JoinHint.None);
					toReturn.Add(RecycleVendorServiceEntity.Relations.RecycleVendorEntityUsingRecycleVendorId, "RecycleVendorService_", string.Empty, JoinHint.None);
					break;
				case "ServiceTypeCollectionViaWorkOrder":
					toReturn.Add(AccountEntity.Relations.WorkOrderEntityUsingAccountId, "AccountEntity__", "WorkOrder_", JoinHint.None);
					toReturn.Add(WorkOrderEntity.Relations.ServiceTypeEntityUsingServiceTypeId, "WorkOrder_", string.Empty, JoinHint.None);
					break;
				case "ServiceTypeCollectionViaServiceLocation":
					toReturn.Add(AccountEntity.Relations.ServiceLocationEntityUsingAccountId, "AccountEntity__", "ServiceLocation_", JoinHint.None);
					toReturn.Add(ServiceLocationEntity.Relations.ServiceTypeEntityUsingServiceTypeId, "ServiceLocation_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRebate":
					toReturn.Add(AccountEntity.Relations.RebateEntityUsingAccountId, "AccountEntity__", "Rebate_", JoinHint.None);
					toReturn.Add(RebateEntity.Relations.UserEntityUsingEnteredByUserId, "Rebate_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaUserAccount":
					toReturn.Add(AccountEntity.Relations.UserAccountEntityUsingAccountId, "AccountEntity__", "UserAccount_", JoinHint.None);
					toReturn.Add(UserAccountEntity.Relations.UserEntityUsingUserId, "UserAccount_", string.Empty, JoinHint.None);
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
			info.AddValue("_accountEmployeeAssignment", (!this.MarkedForDeletion?_accountEmployeeAssignment:null));
			info.AddValue("_alwaysFetchAccountEmployeeAssignment", _alwaysFetchAccountEmployeeAssignment);
			info.AddValue("_alreadyFetchedAccountEmployeeAssignment", _alreadyFetchedAccountEmployeeAssignment);
			info.AddValue("_bale", (!this.MarkedForDeletion?_bale:null));
			info.AddValue("_alwaysFetchBale", _alwaysFetchBale);
			info.AddValue("_alreadyFetchedBale", _alreadyFetchedBale);
			info.AddValue("_rebate", (!this.MarkedForDeletion?_rebate:null));
			info.AddValue("_alwaysFetchRebate", _alwaysFetchRebate);
			info.AddValue("_alreadyFetchedRebate", _alreadyFetchedRebate);
			info.AddValue("_recycleVendorService", (!this.MarkedForDeletion?_recycleVendorService:null));
			info.AddValue("_alwaysFetchRecycleVendorService", _alwaysFetchRecycleVendorService);
			info.AddValue("_alreadyFetchedRecycleVendorService", _alreadyFetchedRecycleVendorService);
			info.AddValue("_serviceLocation", (!this.MarkedForDeletion?_serviceLocation:null));
			info.AddValue("_alwaysFetchServiceLocation", _alwaysFetchServiceLocation);
			info.AddValue("_alreadyFetchedServiceLocation", _alreadyFetchedServiceLocation);
			info.AddValue("_userAccount", (!this.MarkedForDeletion?_userAccount:null));
			info.AddValue("_alwaysFetchUserAccount", _alwaysFetchUserAccount);
			info.AddValue("_alreadyFetchedUserAccount", _alreadyFetchedUserAccount);
			info.AddValue("_workOrder", (!this.MarkedForDeletion?_workOrder:null));
			info.AddValue("_alwaysFetchWorkOrder", _alwaysFetchWorkOrder);
			info.AddValue("_alreadyFetchedWorkOrder", _alreadyFetchedWorkOrder);
			info.AddValue("_dockCollectionViaBale", (!this.MarkedForDeletion?_dockCollectionViaBale:null));
			info.AddValue("_alwaysFetchDockCollectionViaBale", _alwaysFetchDockCollectionViaBale);
			info.AddValue("_alreadyFetchedDockCollectionViaBale", _alreadyFetchedDockCollectionViaBale);
			info.AddValue("_employeeCollectionViaAccountEmployeeAssignment_____", (!this.MarkedForDeletion?_employeeCollectionViaAccountEmployeeAssignment_____:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_____", _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_____);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____", _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____);
			info.AddValue("_employeeCollectionViaAccountEmployeeAssignment______", (!this.MarkedForDeletion?_employeeCollectionViaAccountEmployeeAssignment______:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment______", _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment______);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______", _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______);
			info.AddValue("_employeeCollectionViaWorkOrder", (!this.MarkedForDeletion?_employeeCollectionViaWorkOrder:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaWorkOrder", _alwaysFetchEmployeeCollectionViaWorkOrder);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaWorkOrder", _alreadyFetchedEmployeeCollectionViaWorkOrder);
			info.AddValue("_employeeCollectionViaAccountEmployeeAssignment____", (!this.MarkedForDeletion?_employeeCollectionViaAccountEmployeeAssignment____:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment____", _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment____);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____", _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____);
			info.AddValue("_employeeCollectionViaAccountEmployeeAssignment_", (!this.MarkedForDeletion?_employeeCollectionViaAccountEmployeeAssignment_:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_", _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_", _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_);
			info.AddValue("_employeeCollectionViaAccountEmployeeAssignment", (!this.MarkedForDeletion?_employeeCollectionViaAccountEmployeeAssignment:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment", _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment", _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment);
			info.AddValue("_employeeCollectionViaAccountEmployeeAssignment___", (!this.MarkedForDeletion?_employeeCollectionViaAccountEmployeeAssignment___:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment___", _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment___);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___", _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___);
			info.AddValue("_employeeCollectionViaAccountEmployeeAssignment__", (!this.MarkedForDeletion?_employeeCollectionViaAccountEmployeeAssignment__:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment__", _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment__);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__", _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__);
			info.AddValue("_rebateTypeCollectionViaRebate", (!this.MarkedForDeletion?_rebateTypeCollectionViaRebate:null));
			info.AddValue("_alwaysFetchRebateTypeCollectionViaRebate", _alwaysFetchRebateTypeCollectionViaRebate);
			info.AddValue("_alreadyFetchedRebateTypeCollectionViaRebate", _alreadyFetchedRebateTypeCollectionViaRebate);
			info.AddValue("_recycleTypeCollectionViaRecycleVendorService", (!this.MarkedForDeletion?_recycleTypeCollectionViaRecycleVendorService:null));
			info.AddValue("_alwaysFetchRecycleTypeCollectionViaRecycleVendorService", _alwaysFetchRecycleTypeCollectionViaRecycleVendorService);
			info.AddValue("_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService", _alreadyFetchedRecycleTypeCollectionViaRecycleVendorService);
			info.AddValue("_recycleTypeCollectionViaBale", (!this.MarkedForDeletion?_recycleTypeCollectionViaBale:null));
			info.AddValue("_alwaysFetchRecycleTypeCollectionViaBale", _alwaysFetchRecycleTypeCollectionViaBale);
			info.AddValue("_alreadyFetchedRecycleTypeCollectionViaBale", _alreadyFetchedRecycleTypeCollectionViaBale);
			info.AddValue("_recycleVendorCollectionViaRecycleVendorService", (!this.MarkedForDeletion?_recycleVendorCollectionViaRecycleVendorService:null));
			info.AddValue("_alwaysFetchRecycleVendorCollectionViaRecycleVendorService", _alwaysFetchRecycleVendorCollectionViaRecycleVendorService);
			info.AddValue("_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService", _alreadyFetchedRecycleVendorCollectionViaRecycleVendorService);
			info.AddValue("_serviceTypeCollectionViaWorkOrder", (!this.MarkedForDeletion?_serviceTypeCollectionViaWorkOrder:null));
			info.AddValue("_alwaysFetchServiceTypeCollectionViaWorkOrder", _alwaysFetchServiceTypeCollectionViaWorkOrder);
			info.AddValue("_alreadyFetchedServiceTypeCollectionViaWorkOrder", _alreadyFetchedServiceTypeCollectionViaWorkOrder);
			info.AddValue("_serviceTypeCollectionViaServiceLocation", (!this.MarkedForDeletion?_serviceTypeCollectionViaServiceLocation:null));
			info.AddValue("_alwaysFetchServiceTypeCollectionViaServiceLocation", _alwaysFetchServiceTypeCollectionViaServiceLocation);
			info.AddValue("_alreadyFetchedServiceTypeCollectionViaServiceLocation", _alreadyFetchedServiceTypeCollectionViaServiceLocation);
			info.AddValue("_userCollectionViaRebate", (!this.MarkedForDeletion?_userCollectionViaRebate:null));
			info.AddValue("_alwaysFetchUserCollectionViaRebate", _alwaysFetchUserCollectionViaRebate);
			info.AddValue("_alreadyFetchedUserCollectionViaRebate", _alreadyFetchedUserCollectionViaRebate);
			info.AddValue("_userCollectionViaUserAccount", (!this.MarkedForDeletion?_userCollectionViaUserAccount:null));
			info.AddValue("_alwaysFetchUserCollectionViaUserAccount", _alwaysFetchUserCollectionViaUserAccount);
			info.AddValue("_alreadyFetchedUserCollectionViaUserAccount", _alreadyFetchedUserCollectionViaUserAccount);


			
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

				case "AccountEmployeeAssignment":
					_alreadyFetchedAccountEmployeeAssignment = true;
					if(entity!=null)
					{
						this.AccountEmployeeAssignment.Add((AccountEmployeeAssignmentEntity)entity);
					}
					break;
				case "Bale":
					_alreadyFetchedBale = true;
					if(entity!=null)
					{
						this.Bale.Add((BaleEntity)entity);
					}
					break;
				case "Rebate":
					_alreadyFetchedRebate = true;
					if(entity!=null)
					{
						this.Rebate.Add((RebateEntity)entity);
					}
					break;
				case "RecycleVendorService":
					_alreadyFetchedRecycleVendorService = true;
					if(entity!=null)
					{
						this.RecycleVendorService.Add((RecycleVendorServiceEntity)entity);
					}
					break;
				case "ServiceLocation":
					_alreadyFetchedServiceLocation = true;
					if(entity!=null)
					{
						this.ServiceLocation.Add((ServiceLocationEntity)entity);
					}
					break;
				case "UserAccount":
					_alreadyFetchedUserAccount = true;
					if(entity!=null)
					{
						this.UserAccount.Add((UserAccountEntity)entity);
					}
					break;
				case "WorkOrder":
					_alreadyFetchedWorkOrder = true;
					if(entity!=null)
					{
						this.WorkOrder.Add((WorkOrderEntity)entity);
					}
					break;
				case "DockCollectionViaBale":
					_alreadyFetchedDockCollectionViaBale = true;
					if(entity!=null)
					{
						this.DockCollectionViaBale.Add((DockEntity)entity);
					}
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment_____":
					_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaAccountEmployeeAssignment_____.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment______":
					_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaAccountEmployeeAssignment______.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaWorkOrder":
					_alreadyFetchedEmployeeCollectionViaWorkOrder = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaWorkOrder.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment____":
					_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaAccountEmployeeAssignment____.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment_":
					_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaAccountEmployeeAssignment_.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment":
					_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaAccountEmployeeAssignment.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment___":
					_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaAccountEmployeeAssignment___.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment__":
					_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaAccountEmployeeAssignment__.Add((EmployeeEntity)entity);
					}
					break;
				case "RebateTypeCollectionViaRebate":
					_alreadyFetchedRebateTypeCollectionViaRebate = true;
					if(entity!=null)
					{
						this.RebateTypeCollectionViaRebate.Add((RebateTypeEntity)entity);
					}
					break;
				case "RecycleTypeCollectionViaRecycleVendorService":
					_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = true;
					if(entity!=null)
					{
						this.RecycleTypeCollectionViaRecycleVendorService.Add((RecycleTypeEntity)entity);
					}
					break;
				case "RecycleTypeCollectionViaBale":
					_alreadyFetchedRecycleTypeCollectionViaBale = true;
					if(entity!=null)
					{
						this.RecycleTypeCollectionViaBale.Add((RecycleTypeEntity)entity);
					}
					break;
				case "RecycleVendorCollectionViaRecycleVendorService":
					_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService = true;
					if(entity!=null)
					{
						this.RecycleVendorCollectionViaRecycleVendorService.Add((RecycleVendorEntity)entity);
					}
					break;
				case "ServiceTypeCollectionViaWorkOrder":
					_alreadyFetchedServiceTypeCollectionViaWorkOrder = true;
					if(entity!=null)
					{
						this.ServiceTypeCollectionViaWorkOrder.Add((ServiceTypeEntity)entity);
					}
					break;
				case "ServiceTypeCollectionViaServiceLocation":
					_alreadyFetchedServiceTypeCollectionViaServiceLocation = true;
					if(entity!=null)
					{
						this.ServiceTypeCollectionViaServiceLocation.Add((ServiceTypeEntity)entity);
					}
					break;
				case "UserCollectionViaRebate":
					_alreadyFetchedUserCollectionViaRebate = true;
					if(entity!=null)
					{
						this.UserCollectionViaRebate.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaUserAccount":
					_alreadyFetchedUserCollectionViaUserAccount = true;
					if(entity!=null)
					{
						this.UserCollectionViaUserAccount.Add((UserEntity)entity);
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

				case "AccountEmployeeAssignment":
					_accountEmployeeAssignment.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "Bale":
					_bale.Add((BaleEntity)relatedEntity);
					break;
				case "Rebate":
					_rebate.Add((RebateEntity)relatedEntity);
					break;
				case "RecycleVendorService":
					_recycleVendorService.Add((RecycleVendorServiceEntity)relatedEntity);
					break;
				case "ServiceLocation":
					_serviceLocation.Add((ServiceLocationEntity)relatedEntity);
					break;
				case "UserAccount":
					_userAccount.Add((UserAccountEntity)relatedEntity);
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

				case "AccountEmployeeAssignment":
					base.PerformRelatedEntityRemoval(_accountEmployeeAssignment, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Bale":
					base.PerformRelatedEntityRemoval(_bale, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Rebate":
					base.PerformRelatedEntityRemoval(_rebate, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleVendorService":
					base.PerformRelatedEntityRemoval(_recycleVendorService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocation":
					base.PerformRelatedEntityRemoval(_serviceLocation, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "UserAccount":
					base.PerformRelatedEntityRemoval(_userAccount, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_accountEmployeeAssignment);
			toReturn.Add(_bale);
			toReturn.Add(_rebate);
			toReturn.Add(_recycleVendorService);
			toReturn.Add(_serviceLocation);
			toReturn.Add(_userAccount);
			toReturn.Add(_workOrder);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 accountId)
		{
			return FetchUsingPK(accountId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 accountId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(accountId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 accountId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(accountId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 accountId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(accountId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AccountId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(AccountFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(AccountFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new AccountRelations().GetAllRelations();
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
				_accountEmployeeAssignment.GetMultiManyToOne(this, null, null, null, null, null, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'BaleEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BaleEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.BaleCollection GetMultiBale(bool forceFetch)
		{
			return GetMultiBale(forceFetch, _bale.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BaleEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BaleEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.BaleCollection GetMultiBale(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBale(forceFetch, _bale.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BaleEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.BaleCollection GetMultiBale(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBale(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BaleEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.BaleCollection GetMultiBale(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBale || forceFetch || _alwaysFetchBale) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_bale.ParticipatesInTransaction)
					{
						base.Transaction.Add(_bale);
					}
				}
				_bale.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_bale.EntityFactoryToUse = entityFactoryToUse;
				}
				_bale.GetMultiManyToOne(this, null, null, filter);
				_bale.SuppressClearInGetMulti=false;
				_alreadyFetchedBale = true;
			}
			return _bale;
		}

		/// <summary> Sets the collection parameters for the collection for 'Bale'. These settings will be taken into account
		/// when the property Bale is requested or GetMultiBale is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBale(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_bale.SortClauses=sortClauses;
			_bale.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_rebate.GetMultiManyToOne(this, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'RecycleVendorServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleVendorServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection GetMultiRecycleVendorService(bool forceFetch)
		{
			return GetMultiRecycleVendorService(forceFetch, _recycleVendorService.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleVendorServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'RecycleVendorServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection GetMultiRecycleVendorService(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiRecycleVendorService(forceFetch, _recycleVendorService.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'RecycleVendorServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection GetMultiRecycleVendorService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiRecycleVendorService(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleVendorServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection GetMultiRecycleVendorService(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedRecycleVendorService || forceFetch || _alwaysFetchRecycleVendorService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleVendorService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleVendorService);
					}
				}
				_recycleVendorService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleVendorService.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleVendorService.GetMultiManyToOne(this, null, null, filter);
				_recycleVendorService.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleVendorService = true;
			}
			return _recycleVendorService;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleVendorService'. These settings will be taken into account
		/// when the property RecycleVendorService is requested or GetMultiRecycleVendorService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleVendorService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleVendorService.SortClauses=sortClauses;
			_recycleVendorService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocation(bool forceFetch)
		{
			return GetMultiServiceLocation(forceFetch, _serviceLocation.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocation(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocation(forceFetch, _serviceLocation.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocation(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocation || forceFetch || _alwaysFetchServiceLocation) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocation.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocation);
					}
				}
				_serviceLocation.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocation.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocation.GetMultiManyToOne(this, null, filter);
				_serviceLocation.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocation = true;
			}
			return _serviceLocation;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocation'. These settings will be taken into account
		/// when the property ServiceLocation is requested or GetMultiServiceLocation is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocation(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocation.SortClauses=sortClauses;
			_serviceLocation.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_userAccount.GetMultiManyToOne(this, null, filter);
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
				_workOrder.GetMultiManyToOne(this, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'DockEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DockEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DockCollection GetMultiDockCollectionViaBale(bool forceFetch)
		{
			return GetMultiDockCollectionViaBale(forceFetch, _dockCollectionViaBale.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'DockEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DockCollection GetMultiDockCollectionViaBale(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDockCollectionViaBale || forceFetch || _alwaysFetchDockCollectionViaBale) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_dockCollectionViaBale.ParticipatesInTransaction)
					{
						base.Transaction.Add(_dockCollectionViaBale);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_dockCollectionViaBale.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_dockCollectionViaBale.EntityFactoryToUse = entityFactoryToUse;
				}
				_dockCollectionViaBale.GetMulti(filter, GetRelationsForField("DockCollectionViaBale"));
				_dockCollectionViaBale.SuppressClearInGetMulti=false;
				_alreadyFetchedDockCollectionViaBale = true;
			}
			return _dockCollectionViaBale;
		}

		/// <summary> Sets the collection parameters for the collection for 'DockCollectionViaBale'. These settings will be taken into account
		/// when the property DockCollectionViaBale is requested or GetMultiDockCollectionViaBale is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDockCollectionViaBale(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_dockCollectionViaBale.SortClauses=sortClauses;
			_dockCollectionViaBale.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment_____(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaAccountEmployeeAssignment_____(forceFetch, _employeeCollectionViaAccountEmployeeAssignment_____.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment_____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____ || forceFetch || _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaAccountEmployeeAssignment_____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaAccountEmployeeAssignment_____);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_employeeCollectionViaAccountEmployeeAssignment_____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaAccountEmployeeAssignment_____.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaAccountEmployeeAssignment_____.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment_____"));
				_employeeCollectionViaAccountEmployeeAssignment_____.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____ = true;
			}
			return _employeeCollectionViaAccountEmployeeAssignment_____;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaAccountEmployeeAssignment_____'. These settings will be taken into account
		/// when the property EmployeeCollectionViaAccountEmployeeAssignment_____ is requested or GetMultiEmployeeCollectionViaAccountEmployeeAssignment_____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaAccountEmployeeAssignment_____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaAccountEmployeeAssignment_____.SortClauses=sortClauses;
			_employeeCollectionViaAccountEmployeeAssignment_____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment______(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaAccountEmployeeAssignment______(forceFetch, _employeeCollectionViaAccountEmployeeAssignment______.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment______(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______ || forceFetch || _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment______) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaAccountEmployeeAssignment______.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaAccountEmployeeAssignment______);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_employeeCollectionViaAccountEmployeeAssignment______.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaAccountEmployeeAssignment______.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaAccountEmployeeAssignment______.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment______"));
				_employeeCollectionViaAccountEmployeeAssignment______.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______ = true;
			}
			return _employeeCollectionViaAccountEmployeeAssignment______;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaAccountEmployeeAssignment______'. These settings will be taken into account
		/// when the property EmployeeCollectionViaAccountEmployeeAssignment______ is requested or GetMultiEmployeeCollectionViaAccountEmployeeAssignment______ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaAccountEmployeeAssignment______(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaAccountEmployeeAssignment______.SortClauses=sortClauses;
			_employeeCollectionViaAccountEmployeeAssignment______.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaWorkOrder(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaWorkOrder(forceFetch, _employeeCollectionViaWorkOrder.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaWorkOrder || forceFetch || _alwaysFetchEmployeeCollectionViaWorkOrder) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaWorkOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaWorkOrder);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_employeeCollectionViaWorkOrder.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaWorkOrder.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaWorkOrder.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaWorkOrder"));
				_employeeCollectionViaWorkOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaWorkOrder = true;
			}
			return _employeeCollectionViaWorkOrder;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaWorkOrder'. These settings will be taken into account
		/// when the property EmployeeCollectionViaWorkOrder is requested or GetMultiEmployeeCollectionViaWorkOrder is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaWorkOrder(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaWorkOrder.SortClauses=sortClauses;
			_employeeCollectionViaWorkOrder.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment____(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaAccountEmployeeAssignment____(forceFetch, _employeeCollectionViaAccountEmployeeAssignment____.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____ || forceFetch || _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment____) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaAccountEmployeeAssignment____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaAccountEmployeeAssignment____);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_employeeCollectionViaAccountEmployeeAssignment____.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaAccountEmployeeAssignment____.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaAccountEmployeeAssignment____.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment____"));
				_employeeCollectionViaAccountEmployeeAssignment____.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____ = true;
			}
			return _employeeCollectionViaAccountEmployeeAssignment____;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaAccountEmployeeAssignment____'. These settings will be taken into account
		/// when the property EmployeeCollectionViaAccountEmployeeAssignment____ is requested or GetMultiEmployeeCollectionViaAccountEmployeeAssignment____ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaAccountEmployeeAssignment____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaAccountEmployeeAssignment____.SortClauses=sortClauses;
			_employeeCollectionViaAccountEmployeeAssignment____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment_(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaAccountEmployeeAssignment_(forceFetch, _employeeCollectionViaAccountEmployeeAssignment_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_ || forceFetch || _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaAccountEmployeeAssignment_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaAccountEmployeeAssignment_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_employeeCollectionViaAccountEmployeeAssignment_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaAccountEmployeeAssignment_.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaAccountEmployeeAssignment_.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment_"));
				_employeeCollectionViaAccountEmployeeAssignment_.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_ = true;
			}
			return _employeeCollectionViaAccountEmployeeAssignment_;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaAccountEmployeeAssignment_'. These settings will be taken into account
		/// when the property EmployeeCollectionViaAccountEmployeeAssignment_ is requested or GetMultiEmployeeCollectionViaAccountEmployeeAssignment_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaAccountEmployeeAssignment_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaAccountEmployeeAssignment_.SortClauses=sortClauses;
			_employeeCollectionViaAccountEmployeeAssignment_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaAccountEmployeeAssignment(forceFetch, _employeeCollectionViaAccountEmployeeAssignment.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment || forceFetch || _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaAccountEmployeeAssignment.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaAccountEmployeeAssignment);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_employeeCollectionViaAccountEmployeeAssignment.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaAccountEmployeeAssignment.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaAccountEmployeeAssignment.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment"));
				_employeeCollectionViaAccountEmployeeAssignment.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment = true;
			}
			return _employeeCollectionViaAccountEmployeeAssignment;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaAccountEmployeeAssignment'. These settings will be taken into account
		/// when the property EmployeeCollectionViaAccountEmployeeAssignment is requested or GetMultiEmployeeCollectionViaAccountEmployeeAssignment is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaAccountEmployeeAssignment(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaAccountEmployeeAssignment.SortClauses=sortClauses;
			_employeeCollectionViaAccountEmployeeAssignment.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment___(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaAccountEmployeeAssignment___(forceFetch, _employeeCollectionViaAccountEmployeeAssignment___.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___ || forceFetch || _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment___) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaAccountEmployeeAssignment___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaAccountEmployeeAssignment___);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_employeeCollectionViaAccountEmployeeAssignment___.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaAccountEmployeeAssignment___.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaAccountEmployeeAssignment___.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment___"));
				_employeeCollectionViaAccountEmployeeAssignment___.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___ = true;
			}
			return _employeeCollectionViaAccountEmployeeAssignment___;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaAccountEmployeeAssignment___'. These settings will be taken into account
		/// when the property EmployeeCollectionViaAccountEmployeeAssignment___ is requested or GetMultiEmployeeCollectionViaAccountEmployeeAssignment___ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaAccountEmployeeAssignment___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaAccountEmployeeAssignment___.SortClauses=sortClauses;
			_employeeCollectionViaAccountEmployeeAssignment___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment__(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaAccountEmployeeAssignment__(forceFetch, _employeeCollectionViaAccountEmployeeAssignment__.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaAccountEmployeeAssignment__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__ || forceFetch || _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment__) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaAccountEmployeeAssignment__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaAccountEmployeeAssignment__);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_employeeCollectionViaAccountEmployeeAssignment__.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaAccountEmployeeAssignment__.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaAccountEmployeeAssignment__.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment__"));
				_employeeCollectionViaAccountEmployeeAssignment__.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__ = true;
			}
			return _employeeCollectionViaAccountEmployeeAssignment__;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaAccountEmployeeAssignment__'. These settings will be taken into account
		/// when the property EmployeeCollectionViaAccountEmployeeAssignment__ is requested or GetMultiEmployeeCollectionViaAccountEmployeeAssignment__ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaAccountEmployeeAssignment__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaAccountEmployeeAssignment__.SortClauses=sortClauses;
			_employeeCollectionViaAccountEmployeeAssignment__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
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

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaRecycleVendorService(bool forceFetch)
		{
			return GetMultiRecycleTypeCollectionViaRecycleVendorService(forceFetch, _recycleTypeCollectionViaRecycleVendorService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaRecycleVendorService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService || forceFetch || _alwaysFetchRecycleTypeCollectionViaRecycleVendorService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleTypeCollectionViaRecycleVendorService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleTypeCollectionViaRecycleVendorService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_recycleTypeCollectionViaRecycleVendorService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleTypeCollectionViaRecycleVendorService.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleTypeCollectionViaRecycleVendorService.GetMulti(filter, GetRelationsForField("RecycleTypeCollectionViaRecycleVendorService"));
				_recycleTypeCollectionViaRecycleVendorService.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = true;
			}
			return _recycleTypeCollectionViaRecycleVendorService;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleTypeCollectionViaRecycleVendorService'. These settings will be taken into account
		/// when the property RecycleTypeCollectionViaRecycleVendorService is requested or GetMultiRecycleTypeCollectionViaRecycleVendorService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleTypeCollectionViaRecycleVendorService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleTypeCollectionViaRecycleVendorService.SortClauses=sortClauses;
			_recycleTypeCollectionViaRecycleVendorService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaBale(bool forceFetch)
		{
			return GetMultiRecycleTypeCollectionViaBale(forceFetch, _recycleTypeCollectionViaBale.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection GetMultiRecycleTypeCollectionViaBale(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRecycleTypeCollectionViaBale || forceFetch || _alwaysFetchRecycleTypeCollectionViaBale) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleTypeCollectionViaBale.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleTypeCollectionViaBale);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_recycleTypeCollectionViaBale.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleTypeCollectionViaBale.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleTypeCollectionViaBale.GetMulti(filter, GetRelationsForField("RecycleTypeCollectionViaBale"));
				_recycleTypeCollectionViaBale.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleTypeCollectionViaBale = true;
			}
			return _recycleTypeCollectionViaBale;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleTypeCollectionViaBale'. These settings will be taken into account
		/// when the property RecycleTypeCollectionViaBale is requested or GetMultiRecycleTypeCollectionViaBale is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleTypeCollectionViaBale(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleTypeCollectionViaBale.SortClauses=sortClauses;
			_recycleTypeCollectionViaBale.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RecycleVendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleVendorEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection GetMultiRecycleVendorCollectionViaRecycleVendorService(bool forceFetch)
		{
			return GetMultiRecycleVendorCollectionViaRecycleVendorService(forceFetch, _recycleVendorCollectionViaRecycleVendorService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'RecycleVendorEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection GetMultiRecycleVendorCollectionViaRecycleVendorService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService || forceFetch || _alwaysFetchRecycleVendorCollectionViaRecycleVendorService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleVendorCollectionViaRecycleVendorService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleVendorCollectionViaRecycleVendorService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_recycleVendorCollectionViaRecycleVendorService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleVendorCollectionViaRecycleVendorService.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleVendorCollectionViaRecycleVendorService.GetMulti(filter, GetRelationsForField("RecycleVendorCollectionViaRecycleVendorService"));
				_recycleVendorCollectionViaRecycleVendorService.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService = true;
			}
			return _recycleVendorCollectionViaRecycleVendorService;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleVendorCollectionViaRecycleVendorService'. These settings will be taken into account
		/// when the property RecycleVendorCollectionViaRecycleVendorService is requested or GetMultiRecycleVendorCollectionViaRecycleVendorService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleVendorCollectionViaRecycleVendorService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleVendorCollectionViaRecycleVendorService.SortClauses=sortClauses;
			_recycleVendorCollectionViaRecycleVendorService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
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

		/// <summary> Retrieves all related entities of type 'ServiceTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection GetMultiServiceTypeCollectionViaServiceLocation(bool forceFetch)
		{
			return GetMultiServiceTypeCollectionViaServiceLocation(forceFetch, _serviceTypeCollectionViaServiceLocation.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection GetMultiServiceTypeCollectionViaServiceLocation(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceTypeCollectionViaServiceLocation || forceFetch || _alwaysFetchServiceTypeCollectionViaServiceLocation) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceTypeCollectionViaServiceLocation.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceTypeCollectionViaServiceLocation);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_serviceTypeCollectionViaServiceLocation.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceTypeCollectionViaServiceLocation.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceTypeCollectionViaServiceLocation.GetMulti(filter, GetRelationsForField("ServiceTypeCollectionViaServiceLocation"));
				_serviceTypeCollectionViaServiceLocation.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceTypeCollectionViaServiceLocation = true;
			}
			return _serviceTypeCollectionViaServiceLocation;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceTypeCollectionViaServiceLocation'. These settings will be taken into account
		/// when the property ServiceTypeCollectionViaServiceLocation is requested or GetMultiServiceTypeCollectionViaServiceLocation is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceTypeCollectionViaServiceLocation(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceTypeCollectionViaServiceLocation.SortClauses=sortClauses;
			_serviceTypeCollectionViaServiceLocation.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRebate(bool forceFetch)
		{
			return GetMultiUserCollectionViaRebate(forceFetch, _userCollectionViaRebate.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaRebate(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaRebate || forceFetch || _alwaysFetchUserCollectionViaRebate) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaRebate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaRebate);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_userCollectionViaRebate.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaRebate.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaRebate.GetMulti(filter, GetRelationsForField("UserCollectionViaRebate"));
				_userCollectionViaRebate.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaRebate = true;
			}
			return _userCollectionViaRebate;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaRebate'. These settings will be taken into account
		/// when the property UserCollectionViaRebate is requested or GetMultiUserCollectionViaRebate is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaRebate(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaRebate.SortClauses=sortClauses;
			_userCollectionViaRebate.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaUserAccount(bool forceFetch)
		{
			return GetMultiUserCollectionViaUserAccount(forceFetch, _userCollectionViaUserAccount.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaUserAccount(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaUserAccount || forceFetch || _alwaysFetchUserCollectionViaUserAccount) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaUserAccount.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaUserAccount);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(AccountFields.AccountId, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
				_userCollectionViaUserAccount.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaUserAccount.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaUserAccount.GetMulti(filter, GetRelationsForField("UserCollectionViaUserAccount"));
				_userCollectionViaUserAccount.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaUserAccount = true;
			}
			return _userCollectionViaUserAccount;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaUserAccount'. These settings will be taken into account
		/// when the property UserCollectionViaUserAccount is requested or GetMultiUserCollectionViaUserAccount is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaUserAccount(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaUserAccount.SortClauses=sortClauses;
			_userCollectionViaUserAccount.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			AccountDAO dao = (AccountDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_accountEmployeeAssignment.ActiveContext = base.ActiveContext;
			_bale.ActiveContext = base.ActiveContext;
			_rebate.ActiveContext = base.ActiveContext;
			_recycleVendorService.ActiveContext = base.ActiveContext;
			_serviceLocation.ActiveContext = base.ActiveContext;
			_userAccount.ActiveContext = base.ActiveContext;
			_workOrder.ActiveContext = base.ActiveContext;
			_dockCollectionViaBale.ActiveContext = base.ActiveContext;
			_employeeCollectionViaAccountEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			_employeeCollectionViaAccountEmployeeAssignment______.ActiveContext = base.ActiveContext;
			_employeeCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			_employeeCollectionViaAccountEmployeeAssignment____.ActiveContext = base.ActiveContext;
			_employeeCollectionViaAccountEmployeeAssignment_.ActiveContext = base.ActiveContext;
			_employeeCollectionViaAccountEmployeeAssignment.ActiveContext = base.ActiveContext;
			_employeeCollectionViaAccountEmployeeAssignment___.ActiveContext = base.ActiveContext;
			_employeeCollectionViaAccountEmployeeAssignment__.ActiveContext = base.ActiveContext;
			_rebateTypeCollectionViaRebate.ActiveContext = base.ActiveContext;
			_recycleTypeCollectionViaRecycleVendorService.ActiveContext = base.ActiveContext;
			_recycleTypeCollectionViaBale.ActiveContext = base.ActiveContext;
			_recycleVendorCollectionViaRecycleVendorService.ActiveContext = base.ActiveContext;
			_serviceTypeCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			_serviceTypeCollectionViaServiceLocation.ActiveContext = base.ActiveContext;
			_userCollectionViaRebate.ActiveContext = base.ActiveContext;
			_userCollectionViaUserAccount.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			AccountDAO dao = (AccountDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			AccountDAO dao = (AccountDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.AccountEntity);
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

			toReturn.Add("AccountEmployeeAssignment", _accountEmployeeAssignment);
			toReturn.Add("Bale", _bale);
			toReturn.Add("Rebate", _rebate);
			toReturn.Add("RecycleVendorService", _recycleVendorService);
			toReturn.Add("ServiceLocation", _serviceLocation);
			toReturn.Add("UserAccount", _userAccount);
			toReturn.Add("WorkOrder", _workOrder);
			toReturn.Add("DockCollectionViaBale", _dockCollectionViaBale);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment_____", _employeeCollectionViaAccountEmployeeAssignment_____);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment______", _employeeCollectionViaAccountEmployeeAssignment______);
			toReturn.Add("EmployeeCollectionViaWorkOrder", _employeeCollectionViaWorkOrder);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment____", _employeeCollectionViaAccountEmployeeAssignment____);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment_", _employeeCollectionViaAccountEmployeeAssignment_);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment", _employeeCollectionViaAccountEmployeeAssignment);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment___", _employeeCollectionViaAccountEmployeeAssignment___);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment__", _employeeCollectionViaAccountEmployeeAssignment__);
			toReturn.Add("RebateTypeCollectionViaRebate", _rebateTypeCollectionViaRebate);
			toReturn.Add("RecycleTypeCollectionViaRecycleVendorService", _recycleTypeCollectionViaRecycleVendorService);
			toReturn.Add("RecycleTypeCollectionViaBale", _recycleTypeCollectionViaBale);
			toReturn.Add("RecycleVendorCollectionViaRecycleVendorService", _recycleVendorCollectionViaRecycleVendorService);
			toReturn.Add("ServiceTypeCollectionViaWorkOrder", _serviceTypeCollectionViaWorkOrder);
			toReturn.Add("ServiceTypeCollectionViaServiceLocation", _serviceTypeCollectionViaServiceLocation);
			toReturn.Add("UserCollectionViaRebate", _userCollectionViaRebate);
			toReturn.Add("UserCollectionViaUserAccount", _userCollectionViaUserAccount);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		/// <param name="validator">The validator object for this AccountEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 accountId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(accountId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_accountEmployeeAssignment = new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(new AccountEmployeeAssignmentEntityFactory());
			_accountEmployeeAssignment.SetContainingEntityInfo(this, "Account");
			_alwaysFetchAccountEmployeeAssignment = false;
			_alreadyFetchedAccountEmployeeAssignment = false;
			_bale = new Reliant.RenuOil.DAL.CollectionClasses.BaleCollection(new BaleEntityFactory());
			_bale.SetContainingEntityInfo(this, "Account");
			_alwaysFetchBale = false;
			_alreadyFetchedBale = false;
			_rebate = new Reliant.RenuOil.DAL.CollectionClasses.RebateCollection(new RebateEntityFactory());
			_rebate.SetContainingEntityInfo(this, "Account");
			_alwaysFetchRebate = false;
			_alreadyFetchedRebate = false;
			_recycleVendorService = new Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection(new RecycleVendorServiceEntityFactory());
			_recycleVendorService.SetContainingEntityInfo(this, "Account");
			_alwaysFetchRecycleVendorService = false;
			_alreadyFetchedRecycleVendorService = false;
			_serviceLocation = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_serviceLocation.SetContainingEntityInfo(this, "Account");
			_alwaysFetchServiceLocation = false;
			_alreadyFetchedServiceLocation = false;
			_userAccount = new Reliant.RenuOil.DAL.CollectionClasses.UserAccountCollection(new UserAccountEntityFactory());
			_userAccount.SetContainingEntityInfo(this, "Account");
			_alwaysFetchUserAccount = false;
			_alreadyFetchedUserAccount = false;
			_workOrder = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderCollection(new WorkOrderEntityFactory());
			_workOrder.SetContainingEntityInfo(this, "Account");
			_alwaysFetchWorkOrder = false;
			_alreadyFetchedWorkOrder = false;
			_dockCollectionViaBale = new Reliant.RenuOil.DAL.CollectionClasses.DockCollection(new DockEntityFactory());
			_alwaysFetchDockCollectionViaBale = false;
			_alreadyFetchedDockCollectionViaBale = false;
			_employeeCollectionViaAccountEmployeeAssignment_____ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_____ = false;
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____ = false;
			_employeeCollectionViaAccountEmployeeAssignment______ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment______ = false;
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______ = false;
			_employeeCollectionViaWorkOrder = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaWorkOrder = false;
			_alreadyFetchedEmployeeCollectionViaWorkOrder = false;
			_employeeCollectionViaAccountEmployeeAssignment____ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment____ = false;
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____ = false;
			_employeeCollectionViaAccountEmployeeAssignment_ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_ = false;
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_ = false;
			_employeeCollectionViaAccountEmployeeAssignment = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment = false;
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment = false;
			_employeeCollectionViaAccountEmployeeAssignment___ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment___ = false;
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___ = false;
			_employeeCollectionViaAccountEmployeeAssignment__ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment__ = false;
			_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__ = false;
			_rebateTypeCollectionViaRebate = new Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection(new RebateTypeEntityFactory());
			_alwaysFetchRebateTypeCollectionViaRebate = false;
			_alreadyFetchedRebateTypeCollectionViaRebate = false;
			_recycleTypeCollectionViaRecycleVendorService = new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(new RecycleTypeEntityFactory());
			_alwaysFetchRecycleTypeCollectionViaRecycleVendorService = false;
			_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = false;
			_recycleTypeCollectionViaBale = new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(new RecycleTypeEntityFactory());
			_alwaysFetchRecycleTypeCollectionViaBale = false;
			_alreadyFetchedRecycleTypeCollectionViaBale = false;
			_recycleVendorCollectionViaRecycleVendorService = new Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection(new RecycleVendorEntityFactory());
			_alwaysFetchRecycleVendorCollectionViaRecycleVendorService = false;
			_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService = false;
			_serviceTypeCollectionViaWorkOrder = new Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection(new ServiceTypeEntityFactory());
			_alwaysFetchServiceTypeCollectionViaWorkOrder = false;
			_alreadyFetchedServiceTypeCollectionViaWorkOrder = false;
			_serviceTypeCollectionViaServiceLocation = new Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection(new ServiceTypeEntityFactory());
			_alwaysFetchServiceTypeCollectionViaServiceLocation = false;
			_alreadyFetchedServiceTypeCollectionViaServiceLocation = false;
			_userCollectionViaRebate = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRebate = false;
			_alreadyFetchedUserCollectionViaRebate = false;
			_userCollectionViaUserAccount = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaUserAccount = false;
			_alreadyFetchedUserCollectionViaUserAccount = false;



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

			_fieldsCustomProperties.Add("AccountId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountNo", fieldHashtable);
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

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MainContact", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Notes", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 accountId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)AccountFieldIndex.AccountId].ForcedCurrentValueWrite(accountId);
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
			return DAOFactory.CreateAccountDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AccountEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AccountRelations Relations
		{
			get	{ return new AccountRelations(); }
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
		public static IPrefetchPathElement PrefetchPathAccountEmployeeAssignment
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountEmployeeAssignmentCollection(),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, "AccountEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Bale' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBale
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.BaleCollection(),
					(IEntityRelation)GetRelationsForField("Bale")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.BaleEntity, 0, null, null, null, "Bale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("Rebate")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RebateEntity, 0, null, null, null, "Rebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleVendorService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleVendorService
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection(),
					(IEntityRelation)GetRelationsForField("RecycleVendorService")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity, 0, null, null, null, "RecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocation
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("UserAccount")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.UserAccountEntity, 0, null, null, null, "UserAccount", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Dock' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDockCollectionViaBale
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.BaleEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "Bale_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DockCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.DockEntity, 0, null, null, GetRelationsForField("DockCollectionViaBale"), "DockCollectionViaBale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment_____
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment_____"), "EmployeeCollectionViaAccountEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment______
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment______"), "EmployeeCollectionViaAccountEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.WorkOrderEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaWorkOrder"), "EmployeeCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment____
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment____"), "EmployeeCollectionViaAccountEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment_
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment_"), "EmployeeCollectionViaAccountEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment"), "EmployeeCollectionViaAccountEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment___
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment___"), "EmployeeCollectionViaAccountEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment__
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment__"), "EmployeeCollectionViaAccountEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RebateType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRebateTypeCollectionViaRebate
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.RebateEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "Rebate_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RebateTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RebateTypeEntity, 0, null, null, GetRelationsForField("RebateTypeCollectionViaRebate"), "RebateTypeCollectionViaRebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleTypeCollectionViaRecycleVendorService
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.RecycleVendorServiceEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "RecycleVendorService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleVendorService"), "RecycleTypeCollectionViaRecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleTypeCollectionViaBale
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.BaleEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "Bale_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaBale"), "RecycleTypeCollectionViaBale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleVendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleVendorCollectionViaRecycleVendorService
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.RecycleVendorServiceEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "RecycleVendorService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity, 0, null, null, GetRelationsForField("RecycleVendorCollectionViaRecycleVendorService"), "RecycleVendorCollectionViaRecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceTypeCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.WorkOrderEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, 0, null, null, GetRelationsForField("ServiceTypeCollectionViaWorkOrder"), "ServiceTypeCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceTypeCollectionViaServiceLocation
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.ServiceLocationEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocation_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, 0, null, null, GetRelationsForField("ServiceTypeCollectionViaServiceLocation"), "ServiceTypeCollectionViaServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRebate
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.RebateEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "Rebate_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRebate"), "UserCollectionViaRebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaUserAccount
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.UserAccountEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "UserAccount_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaUserAccount"), "UserCollectionViaUserAccount", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "AccountEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return AccountEntity.CustomProperties;}
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
			get { return AccountEntity.FieldsCustomProperties;}
		}

		/// <summary> The AccountId property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)AccountFieldIndex.AccountId, true); }
			set	{ SetValue((int)AccountFieldIndex.AccountId, value, true); }
		}
		/// <summary> The Name property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.Name, true); }
			set	{ SetValue((int)AccountFieldIndex.Name, value, true); }
		}
		/// <summary> The AccountNo property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."AccountNo"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AccountNo
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.AccountNo, true); }
			set	{ SetValue((int)AccountFieldIndex.AccountNo, value, true); }
		}
		/// <summary> The Address1 property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."Address1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address1
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.Address1, true); }
			set	{ SetValue((int)AccountFieldIndex.Address1, value, true); }
		}
		/// <summary> The Address2 property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."Address2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address2
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.Address2, true); }
			set	{ SetValue((int)AccountFieldIndex.Address2, value, true); }
		}
		/// <summary> The City property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.City, true); }
			set	{ SetValue((int)AccountFieldIndex.City, value, true); }
		}
		/// <summary> The State property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."State"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String State
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.State, true); }
			set	{ SetValue((int)AccountFieldIndex.State, value, true); }
		}
		/// <summary> The IntlState property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."IntlState"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String IntlState
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.IntlState, true); }
			set	{ SetValue((int)AccountFieldIndex.IntlState, value, true); }
		}
		/// <summary> The ZipCode property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."ZipCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ZipCode
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.ZipCode, true); }
			set	{ SetValue((int)AccountFieldIndex.ZipCode, value, true); }
		}
		/// <summary> The Phone property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.Phone, true); }
			set	{ SetValue((int)AccountFieldIndex.Phone, value, true); }
		}
		/// <summary> The IsActive property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)AccountFieldIndex.IsActive, true); }
			set	{ SetValue((int)AccountFieldIndex.IsActive, value, true); }
		}
		/// <summary> The MainContact property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."MainContact"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MainContact
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.MainContact, true); }
			set	{ SetValue((int)AccountFieldIndex.MainContact, value, true); }
		}
		/// <summary> The Notes property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.Notes, true); }
			set	{ SetValue((int)AccountFieldIndex.Notes, value, true); }
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
		/// <summary> Retrieves all related entities of type 'BaleEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBale()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.BaleCollection Bale
		{
			get	{ return GetMultiBale(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Bale. When set to true, Bale is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Bale is accessed. You can always execute
		/// a forced fetch by calling GetMultiBale(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBale
		{
			get	{ return _alwaysFetchBale; }
			set	{ _alwaysFetchBale = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Bale already has been fetched. Setting this property to false when Bale has been fetched
		/// will clear the Bale collection well. Setting this property to true while Bale hasn't been fetched disables lazy loading for Bale</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBale
		{
			get { return _alreadyFetchedBale;}
			set 
			{
				if(_alreadyFetchedBale && !value && (_bale != null))
				{
					_bale.Clear();
				}
				_alreadyFetchedBale = value;
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
		/// <summary> Retrieves all related entities of type 'RecycleVendorServiceEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleVendorService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection RecycleVendorService
		{
			get	{ return GetMultiRecycleVendorService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleVendorService. When set to true, RecycleVendorService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleVendorService is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleVendorService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleVendorService
		{
			get	{ return _alwaysFetchRecycleVendorService; }
			set	{ _alwaysFetchRecycleVendorService = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleVendorService already has been fetched. Setting this property to false when RecycleVendorService has been fetched
		/// will clear the RecycleVendorService collection well. Setting this property to true while RecycleVendorService hasn't been fetched disables lazy loading for RecycleVendorService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleVendorService
		{
			get { return _alreadyFetchedRecycleVendorService;}
			set 
			{
				if(_alreadyFetchedRecycleVendorService && !value && (_recycleVendorService != null))
				{
					_recycleVendorService.Clear();
				}
				_alreadyFetchedRecycleVendorService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocation
		{
			get	{ return GetMultiServiceLocation(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocation. When set to true, ServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocation
		{
			get	{ return _alwaysFetchServiceLocation; }
			set	{ _alwaysFetchServiceLocation = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocation already has been fetched. Setting this property to false when ServiceLocation has been fetched
		/// will clear the ServiceLocation collection well. Setting this property to true while ServiceLocation hasn't been fetched disables lazy loading for ServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocation
		{
			get { return _alreadyFetchedServiceLocation;}
			set 
			{
				if(_alreadyFetchedServiceLocation && !value && (_serviceLocation != null))
				{
					_serviceLocation.Clear();
				}
				_alreadyFetchedServiceLocation = value;
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

		/// <summary> Retrieves all related entities of type 'DockEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDockCollectionViaBale()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DockCollection DockCollectionViaBale
		{
			get { return GetMultiDockCollectionViaBale(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DockCollectionViaBale. When set to true, DockCollectionViaBale is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DockCollectionViaBale is accessed. You can always execute
		/// a forced fetch by calling GetMultiDockCollectionViaBale(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDockCollectionViaBale
		{
			get	{ return _alwaysFetchDockCollectionViaBale; }
			set	{ _alwaysFetchDockCollectionViaBale = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DockCollectionViaBale already has been fetched. Setting this property to false when DockCollectionViaBale has been fetched
		/// will clear the DockCollectionViaBale collection well. Setting this property to true while DockCollectionViaBale hasn't been fetched disables lazy loading for DockCollectionViaBale</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDockCollectionViaBale
		{
			get { return _alreadyFetchedDockCollectionViaBale;}
			set 
			{
				if(_alreadyFetchedDockCollectionViaBale && !value && (_dockCollectionViaBale != null))
				{
					_dockCollectionViaBale.Clear();
				}
				_alreadyFetchedDockCollectionViaBale = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaAccountEmployeeAssignment_____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaAccountEmployeeAssignment_____
		{
			get { return GetMultiEmployeeCollectionViaAccountEmployeeAssignment_____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaAccountEmployeeAssignment_____. When set to true, EmployeeCollectionViaAccountEmployeeAssignment_____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaAccountEmployeeAssignment_____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaAccountEmployeeAssignment_____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_____
		{
			get	{ return _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_____; }
			set	{ _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_____ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaAccountEmployeeAssignment_____ already has been fetched. Setting this property to false when EmployeeCollectionViaAccountEmployeeAssignment_____ has been fetched
		/// will clear the EmployeeCollectionViaAccountEmployeeAssignment_____ collection well. Setting this property to true while EmployeeCollectionViaAccountEmployeeAssignment_____ hasn't been fetched disables lazy loading for EmployeeCollectionViaAccountEmployeeAssignment_____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____
		{
			get { return _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____ && !value && (_employeeCollectionViaAccountEmployeeAssignment_____ != null))
				{
					_employeeCollectionViaAccountEmployeeAssignment_____.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaAccountEmployeeAssignment______()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaAccountEmployeeAssignment______
		{
			get { return GetMultiEmployeeCollectionViaAccountEmployeeAssignment______(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaAccountEmployeeAssignment______. When set to true, EmployeeCollectionViaAccountEmployeeAssignment______ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaAccountEmployeeAssignment______ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaAccountEmployeeAssignment______(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaAccountEmployeeAssignment______
		{
			get	{ return _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment______; }
			set	{ _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment______ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaAccountEmployeeAssignment______ already has been fetched. Setting this property to false when EmployeeCollectionViaAccountEmployeeAssignment______ has been fetched
		/// will clear the EmployeeCollectionViaAccountEmployeeAssignment______ collection well. Setting this property to true while EmployeeCollectionViaAccountEmployeeAssignment______ hasn't been fetched disables lazy loading for EmployeeCollectionViaAccountEmployeeAssignment______</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______
		{
			get { return _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______ && !value && (_employeeCollectionViaAccountEmployeeAssignment______ != null))
				{
					_employeeCollectionViaAccountEmployeeAssignment______.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment______ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaWorkOrder
		{
			get { return GetMultiEmployeeCollectionViaWorkOrder(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaWorkOrder. When set to true, EmployeeCollectionViaWorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaWorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaWorkOrder
		{
			get	{ return _alwaysFetchEmployeeCollectionViaWorkOrder; }
			set	{ _alwaysFetchEmployeeCollectionViaWorkOrder = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaWorkOrder already has been fetched. Setting this property to false when EmployeeCollectionViaWorkOrder has been fetched
		/// will clear the EmployeeCollectionViaWorkOrder collection well. Setting this property to true while EmployeeCollectionViaWorkOrder hasn't been fetched disables lazy loading for EmployeeCollectionViaWorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaWorkOrder
		{
			get { return _alreadyFetchedEmployeeCollectionViaWorkOrder;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaWorkOrder && !value && (_employeeCollectionViaWorkOrder != null))
				{
					_employeeCollectionViaWorkOrder.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaWorkOrder = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaAccountEmployeeAssignment____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaAccountEmployeeAssignment____
		{
			get { return GetMultiEmployeeCollectionViaAccountEmployeeAssignment____(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaAccountEmployeeAssignment____. When set to true, EmployeeCollectionViaAccountEmployeeAssignment____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaAccountEmployeeAssignment____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaAccountEmployeeAssignment____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaAccountEmployeeAssignment____
		{
			get	{ return _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment____; }
			set	{ _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment____ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaAccountEmployeeAssignment____ already has been fetched. Setting this property to false when EmployeeCollectionViaAccountEmployeeAssignment____ has been fetched
		/// will clear the EmployeeCollectionViaAccountEmployeeAssignment____ collection well. Setting this property to true while EmployeeCollectionViaAccountEmployeeAssignment____ hasn't been fetched disables lazy loading for EmployeeCollectionViaAccountEmployeeAssignment____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____
		{
			get { return _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____ && !value && (_employeeCollectionViaAccountEmployeeAssignment____ != null))
				{
					_employeeCollectionViaAccountEmployeeAssignment____.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment____ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaAccountEmployeeAssignment_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaAccountEmployeeAssignment_
		{
			get { return GetMultiEmployeeCollectionViaAccountEmployeeAssignment_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaAccountEmployeeAssignment_. When set to true, EmployeeCollectionViaAccountEmployeeAssignment_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaAccountEmployeeAssignment_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaAccountEmployeeAssignment_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_
		{
			get	{ return _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_; }
			set	{ _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaAccountEmployeeAssignment_ already has been fetched. Setting this property to false when EmployeeCollectionViaAccountEmployeeAssignment_ has been fetched
		/// will clear the EmployeeCollectionViaAccountEmployeeAssignment_ collection well. Setting this property to true while EmployeeCollectionViaAccountEmployeeAssignment_ hasn't been fetched disables lazy loading for EmployeeCollectionViaAccountEmployeeAssignment_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_
		{
			get { return _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_ && !value && (_employeeCollectionViaAccountEmployeeAssignment_ != null))
				{
					_employeeCollectionViaAccountEmployeeAssignment_.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaAccountEmployeeAssignment()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaAccountEmployeeAssignment
		{
			get { return GetMultiEmployeeCollectionViaAccountEmployeeAssignment(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaAccountEmployeeAssignment. When set to true, EmployeeCollectionViaAccountEmployeeAssignment is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaAccountEmployeeAssignment is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaAccountEmployeeAssignment(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaAccountEmployeeAssignment
		{
			get	{ return _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment; }
			set	{ _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaAccountEmployeeAssignment already has been fetched. Setting this property to false when EmployeeCollectionViaAccountEmployeeAssignment has been fetched
		/// will clear the EmployeeCollectionViaAccountEmployeeAssignment collection well. Setting this property to true while EmployeeCollectionViaAccountEmployeeAssignment hasn't been fetched disables lazy loading for EmployeeCollectionViaAccountEmployeeAssignment</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment
		{
			get { return _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment && !value && (_employeeCollectionViaAccountEmployeeAssignment != null))
				{
					_employeeCollectionViaAccountEmployeeAssignment.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaAccountEmployeeAssignment___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaAccountEmployeeAssignment___
		{
			get { return GetMultiEmployeeCollectionViaAccountEmployeeAssignment___(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaAccountEmployeeAssignment___. When set to true, EmployeeCollectionViaAccountEmployeeAssignment___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaAccountEmployeeAssignment___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaAccountEmployeeAssignment___(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaAccountEmployeeAssignment___
		{
			get	{ return _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment___; }
			set	{ _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment___ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaAccountEmployeeAssignment___ already has been fetched. Setting this property to false when EmployeeCollectionViaAccountEmployeeAssignment___ has been fetched
		/// will clear the EmployeeCollectionViaAccountEmployeeAssignment___ collection well. Setting this property to true while EmployeeCollectionViaAccountEmployeeAssignment___ hasn't been fetched disables lazy loading for EmployeeCollectionViaAccountEmployeeAssignment___</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___
		{
			get { return _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___ && !value && (_employeeCollectionViaAccountEmployeeAssignment___ != null))
				{
					_employeeCollectionViaAccountEmployeeAssignment___.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment___ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaAccountEmployeeAssignment__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaAccountEmployeeAssignment__
		{
			get { return GetMultiEmployeeCollectionViaAccountEmployeeAssignment__(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaAccountEmployeeAssignment__. When set to true, EmployeeCollectionViaAccountEmployeeAssignment__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaAccountEmployeeAssignment__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaAccountEmployeeAssignment__(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaAccountEmployeeAssignment__
		{
			get	{ return _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment__; }
			set	{ _alwaysFetchEmployeeCollectionViaAccountEmployeeAssignment__ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaAccountEmployeeAssignment__ already has been fetched. Setting this property to false when EmployeeCollectionViaAccountEmployeeAssignment__ has been fetched
		/// will clear the EmployeeCollectionViaAccountEmployeeAssignment__ collection well. Setting this property to true while EmployeeCollectionViaAccountEmployeeAssignment__ hasn't been fetched disables lazy loading for EmployeeCollectionViaAccountEmployeeAssignment__</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__
		{
			get { return _alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__ && !value && (_employeeCollectionViaAccountEmployeeAssignment__ != null))
				{
					_employeeCollectionViaAccountEmployeeAssignment__.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaAccountEmployeeAssignment__ = value;
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
		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleTypeCollectionViaRecycleVendorService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection RecycleTypeCollectionViaRecycleVendorService
		{
			get { return GetMultiRecycleTypeCollectionViaRecycleVendorService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleTypeCollectionViaRecycleVendorService. When set to true, RecycleTypeCollectionViaRecycleVendorService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleTypeCollectionViaRecycleVendorService is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleTypeCollectionViaRecycleVendorService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleTypeCollectionViaRecycleVendorService
		{
			get	{ return _alwaysFetchRecycleTypeCollectionViaRecycleVendorService; }
			set	{ _alwaysFetchRecycleTypeCollectionViaRecycleVendorService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleTypeCollectionViaRecycleVendorService already has been fetched. Setting this property to false when RecycleTypeCollectionViaRecycleVendorService has been fetched
		/// will clear the RecycleTypeCollectionViaRecycleVendorService collection well. Setting this property to true while RecycleTypeCollectionViaRecycleVendorService hasn't been fetched disables lazy loading for RecycleTypeCollectionViaRecycleVendorService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleTypeCollectionViaRecycleVendorService
		{
			get { return _alreadyFetchedRecycleTypeCollectionViaRecycleVendorService;}
			set 
			{
				if(_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService && !value && (_recycleTypeCollectionViaRecycleVendorService != null))
				{
					_recycleTypeCollectionViaRecycleVendorService.Clear();
				}
				_alreadyFetchedRecycleTypeCollectionViaRecycleVendorService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleTypeCollectionViaBale()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection RecycleTypeCollectionViaBale
		{
			get { return GetMultiRecycleTypeCollectionViaBale(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleTypeCollectionViaBale. When set to true, RecycleTypeCollectionViaBale is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleTypeCollectionViaBale is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleTypeCollectionViaBale(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleTypeCollectionViaBale
		{
			get	{ return _alwaysFetchRecycleTypeCollectionViaBale; }
			set	{ _alwaysFetchRecycleTypeCollectionViaBale = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleTypeCollectionViaBale already has been fetched. Setting this property to false when RecycleTypeCollectionViaBale has been fetched
		/// will clear the RecycleTypeCollectionViaBale collection well. Setting this property to true while RecycleTypeCollectionViaBale hasn't been fetched disables lazy loading for RecycleTypeCollectionViaBale</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleTypeCollectionViaBale
		{
			get { return _alreadyFetchedRecycleTypeCollectionViaBale;}
			set 
			{
				if(_alreadyFetchedRecycleTypeCollectionViaBale && !value && (_recycleTypeCollectionViaBale != null))
				{
					_recycleTypeCollectionViaBale.Clear();
				}
				_alreadyFetchedRecycleTypeCollectionViaBale = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RecycleVendorEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleVendorCollectionViaRecycleVendorService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection RecycleVendorCollectionViaRecycleVendorService
		{
			get { return GetMultiRecycleVendorCollectionViaRecycleVendorService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleVendorCollectionViaRecycleVendorService. When set to true, RecycleVendorCollectionViaRecycleVendorService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleVendorCollectionViaRecycleVendorService is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleVendorCollectionViaRecycleVendorService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleVendorCollectionViaRecycleVendorService
		{
			get	{ return _alwaysFetchRecycleVendorCollectionViaRecycleVendorService; }
			set	{ _alwaysFetchRecycleVendorCollectionViaRecycleVendorService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleVendorCollectionViaRecycleVendorService already has been fetched. Setting this property to false when RecycleVendorCollectionViaRecycleVendorService has been fetched
		/// will clear the RecycleVendorCollectionViaRecycleVendorService collection well. Setting this property to true while RecycleVendorCollectionViaRecycleVendorService hasn't been fetched disables lazy loading for RecycleVendorCollectionViaRecycleVendorService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleVendorCollectionViaRecycleVendorService
		{
			get { return _alreadyFetchedRecycleVendorCollectionViaRecycleVendorService;}
			set 
			{
				if(_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService && !value && (_recycleVendorCollectionViaRecycleVendorService != null))
				{
					_recycleVendorCollectionViaRecycleVendorService.Clear();
				}
				_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService = value;
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
		/// <summary> Retrieves all related entities of type 'ServiceTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceTypeCollectionViaServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceTypeCollection ServiceTypeCollectionViaServiceLocation
		{
			get { return GetMultiServiceTypeCollectionViaServiceLocation(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceTypeCollectionViaServiceLocation. When set to true, ServiceTypeCollectionViaServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceTypeCollectionViaServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceTypeCollectionViaServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceTypeCollectionViaServiceLocation
		{
			get	{ return _alwaysFetchServiceTypeCollectionViaServiceLocation; }
			set	{ _alwaysFetchServiceTypeCollectionViaServiceLocation = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceTypeCollectionViaServiceLocation already has been fetched. Setting this property to false when ServiceTypeCollectionViaServiceLocation has been fetched
		/// will clear the ServiceTypeCollectionViaServiceLocation collection well. Setting this property to true while ServiceTypeCollectionViaServiceLocation hasn't been fetched disables lazy loading for ServiceTypeCollectionViaServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceTypeCollectionViaServiceLocation
		{
			get { return _alreadyFetchedServiceTypeCollectionViaServiceLocation;}
			set 
			{
				if(_alreadyFetchedServiceTypeCollectionViaServiceLocation && !value && (_serviceTypeCollectionViaServiceLocation != null))
				{
					_serviceTypeCollectionViaServiceLocation.Clear();
				}
				_alreadyFetchedServiceTypeCollectionViaServiceLocation = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaRebate()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaRebate
		{
			get { return GetMultiUserCollectionViaRebate(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaRebate. When set to true, UserCollectionViaRebate is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaRebate is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaRebate(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaRebate
		{
			get	{ return _alwaysFetchUserCollectionViaRebate; }
			set	{ _alwaysFetchUserCollectionViaRebate = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaRebate already has been fetched. Setting this property to false when UserCollectionViaRebate has been fetched
		/// will clear the UserCollectionViaRebate collection well. Setting this property to true while UserCollectionViaRebate hasn't been fetched disables lazy loading for UserCollectionViaRebate</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaRebate
		{
			get { return _alreadyFetchedUserCollectionViaRebate;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaRebate && !value && (_userCollectionViaRebate != null))
				{
					_userCollectionViaRebate.Clear();
				}
				_alreadyFetchedUserCollectionViaRebate = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaUserAccount()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaUserAccount
		{
			get { return GetMultiUserCollectionViaUserAccount(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaUserAccount. When set to true, UserCollectionViaUserAccount is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaUserAccount is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaUserAccount(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaUserAccount
		{
			get	{ return _alwaysFetchUserCollectionViaUserAccount; }
			set	{ _alwaysFetchUserCollectionViaUserAccount = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaUserAccount already has been fetched. Setting this property to false when UserCollectionViaUserAccount has been fetched
		/// will clear the UserCollectionViaUserAccount collection well. Setting this property to true while UserCollectionViaUserAccount hasn't been fetched disables lazy loading for UserCollectionViaUserAccount</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaUserAccount
		{
			get { return _alreadyFetchedUserCollectionViaUserAccount;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaUserAccount && !value && (_userCollectionViaUserAccount != null))
				{
					_userCollectionViaUserAccount.Clear();
				}
				_alreadyFetchedUserCollectionViaUserAccount = value;
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.AccountEntity; }
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
