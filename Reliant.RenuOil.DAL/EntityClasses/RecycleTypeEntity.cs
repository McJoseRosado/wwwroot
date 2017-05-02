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
	/// Entity class which represents the entity 'RecycleType'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class RecycleTypeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.BaleCollection	_bale;
		private bool	_alwaysFetchBale, _alreadyFetchedBale;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection	_recycleServiceAction;
		private bool	_alwaysFetchRecycleServiceAction, _alreadyFetchedRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection	_recycleVendorService;
		private bool	_alwaysFetchRecycleVendorService, _alreadyFetchedRecycleVendorService;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection	_serviceLocationRecycleType;
		private bool	_alwaysFetchServiceLocationRecycleType, _alreadyFetchedServiceLocationRecycleType;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaRecycleVendorService;
		private bool	_alwaysFetchAccountCollectionViaRecycleVendorService, _alreadyFetchedAccountCollectionViaRecycleVendorService;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaBale;
		private bool	_alwaysFetchAccountCollectionViaBale, _alreadyFetchedAccountCollectionViaBale;
		private Reliant.RenuOil.DAL.CollectionClasses.DockCollection _dockCollectionViaBale;
		private bool	_alwaysFetchDockCollectionViaBale, _alreadyFetchedDockCollectionViaBale;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaRecycleServiceAction_;
		private bool	_alwaysFetchEmployeeCollectionViaRecycleServiceAction_, _alreadyFetchedEmployeeCollectionViaRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchEmployeeCollectionViaRecycleServiceAction, _alreadyFetchedEmployeeCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection _recycleServiceCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction, _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection _recycleVendorCollectionViaRecycleVendorService;
		private bool	_alwaysFetchRecycleVendorCollectionViaRecycleVendorService, _alreadyFetchedRecycleVendorCollectionViaRecycleVendorService;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaServiceLocationRecycleType;
		private bool	_alwaysFetchServiceLocationCollectionViaServiceLocationRecycleType, _alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRecycleServiceAction_;
		private bool	_alwaysFetchUserCollectionViaRecycleServiceAction_, _alreadyFetchedUserCollectionViaRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchUserCollectionViaRecycleServiceAction, _alreadyFetchedUserCollectionViaRecycleServiceAction;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name Bale</summary>
			public static readonly string Bale = "Bale";
			/// <summary>Member name RecycleServiceAction</summary>
			public static readonly string RecycleServiceAction = "RecycleServiceAction";
			/// <summary>Member name RecycleVendorService</summary>
			public static readonly string RecycleVendorService = "RecycleVendorService";
			/// <summary>Member name ServiceLocationRecycleType</summary>
			public static readonly string ServiceLocationRecycleType = "ServiceLocationRecycleType";
			/// <summary>Member name AccountCollectionViaRecycleVendorService</summary>
			public static readonly string AccountCollectionViaRecycleVendorService = "AccountCollectionViaRecycleVendorService";
			/// <summary>Member name AccountCollectionViaBale</summary>
			public static readonly string AccountCollectionViaBale = "AccountCollectionViaBale";
			/// <summary>Member name DockCollectionViaBale</summary>
			public static readonly string DockCollectionViaBale = "DockCollectionViaBale";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceAction_</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceAction_ = "EmployeeCollectionViaRecycleServiceAction_";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceAction</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceAction = "EmployeeCollectionViaRecycleServiceAction";
			/// <summary>Member name RecycleServiceCollectionViaRecycleServiceAction</summary>
			public static readonly string RecycleServiceCollectionViaRecycleServiceAction = "RecycleServiceCollectionViaRecycleServiceAction";
			/// <summary>Member name RecycleVendorCollectionViaRecycleVendorService</summary>
			public static readonly string RecycleVendorCollectionViaRecycleVendorService = "RecycleVendorCollectionViaRecycleVendorService";
			/// <summary>Member name ServiceLocationCollectionViaServiceLocationRecycleType</summary>
			public static readonly string ServiceLocationCollectionViaServiceLocationRecycleType = "ServiceLocationCollectionViaServiceLocationRecycleType";
			/// <summary>Member name UserCollectionViaRecycleServiceAction_</summary>
			public static readonly string UserCollectionViaRecycleServiceAction_ = "UserCollectionViaRecycleServiceAction_";
			/// <summary>Member name UserCollectionViaRecycleServiceAction</summary>
			public static readonly string UserCollectionViaRecycleServiceAction = "UserCollectionViaRecycleServiceAction";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RecycleTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public RecycleTypeEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		public RecycleTypeEntity(System.Int32 recycleTypeId)
		{
			InitClassFetch(recycleTypeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public RecycleTypeEntity(System.Int32 recycleTypeId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(recycleTypeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		/// <param name="validator">The custom validator object for this RecycleTypeEntity</param>
		public RecycleTypeEntity(System.Int32 recycleTypeId, IValidator validator)
		{
			InitClassFetch(recycleTypeId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RecycleTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_bale = (Reliant.RenuOil.DAL.CollectionClasses.BaleCollection)info.GetValue("_bale", typeof(Reliant.RenuOil.DAL.CollectionClasses.BaleCollection));
			_alwaysFetchBale = info.GetBoolean("_alwaysFetchBale");
			_alreadyFetchedBale = info.GetBoolean("_alreadyFetchedBale");
			_recycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection)info.GetValue("_recycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection));
			_alwaysFetchRecycleServiceAction = info.GetBoolean("_alwaysFetchRecycleServiceAction");
			_alreadyFetchedRecycleServiceAction = info.GetBoolean("_alreadyFetchedRecycleServiceAction");
			_recycleVendorService = (Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection)info.GetValue("_recycleVendorService", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection));
			_alwaysFetchRecycleVendorService = info.GetBoolean("_alwaysFetchRecycleVendorService");
			_alreadyFetchedRecycleVendorService = info.GetBoolean("_alreadyFetchedRecycleVendorService");
			_serviceLocationRecycleType = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection)info.GetValue("_serviceLocationRecycleType", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection));
			_alwaysFetchServiceLocationRecycleType = info.GetBoolean("_alwaysFetchServiceLocationRecycleType");
			_alreadyFetchedServiceLocationRecycleType = info.GetBoolean("_alreadyFetchedServiceLocationRecycleType");
			_accountCollectionViaRecycleVendorService = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaRecycleVendorService", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaRecycleVendorService = info.GetBoolean("_alwaysFetchAccountCollectionViaRecycleVendorService");
			_alreadyFetchedAccountCollectionViaRecycleVendorService = info.GetBoolean("_alreadyFetchedAccountCollectionViaRecycleVendorService");
			_accountCollectionViaBale = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaBale", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaBale = info.GetBoolean("_alwaysFetchAccountCollectionViaBale");
			_alreadyFetchedAccountCollectionViaBale = info.GetBoolean("_alreadyFetchedAccountCollectionViaBale");
			_dockCollectionViaBale = (Reliant.RenuOil.DAL.CollectionClasses.DockCollection)info.GetValue("_dockCollectionViaBale", typeof(Reliant.RenuOil.DAL.CollectionClasses.DockCollection));
			_alwaysFetchDockCollectionViaBale = info.GetBoolean("_alwaysFetchDockCollectionViaBale");
			_alreadyFetchedDockCollectionViaBale = info.GetBoolean("_alreadyFetchedDockCollectionViaBale");
			_employeeCollectionViaRecycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaRecycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction_ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaRecycleServiceAction_");
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_");
			_employeeCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchEmployeeCollectionViaRecycleServiceAction");
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction");
			_recycleServiceCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection)info.GetValue("_recycleServiceCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection));
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction");
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction");
			_recycleVendorCollectionViaRecycleVendorService = (Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection)info.GetValue("_recycleVendorCollectionViaRecycleVendorService", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection));
			_alwaysFetchRecycleVendorCollectionViaRecycleVendorService = info.GetBoolean("_alwaysFetchRecycleVendorCollectionViaRecycleVendorService");
			_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService = info.GetBoolean("_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService");
			_serviceLocationCollectionViaServiceLocationRecycleType = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaServiceLocationRecycleType", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaServiceLocationRecycleType = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaServiceLocationRecycleType");
			_alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType");
			_userCollectionViaRecycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRecycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRecycleServiceAction_ = info.GetBoolean("_alwaysFetchUserCollectionViaRecycleServiceAction_");
			_alreadyFetchedUserCollectionViaRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedUserCollectionViaRecycleServiceAction_");
			_userCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchUserCollectionViaRecycleServiceAction");
			_alreadyFetchedUserCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedUserCollectionViaRecycleServiceAction");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((RecycleTypeFieldIndex)fieldIndex)
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
			_alreadyFetchedBale = (_bale.Count > 0);
			_alreadyFetchedRecycleServiceAction = (_recycleServiceAction.Count > 0);
			_alreadyFetchedRecycleVendorService = (_recycleVendorService.Count > 0);
			_alreadyFetchedServiceLocationRecycleType = (_serviceLocationRecycleType.Count > 0);
			_alreadyFetchedAccountCollectionViaRecycleVendorService = (_accountCollectionViaRecycleVendorService.Count > 0);
			_alreadyFetchedAccountCollectionViaBale = (_accountCollectionViaBale.Count > 0);
			_alreadyFetchedDockCollectionViaBale = (_dockCollectionViaBale.Count > 0);
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = (_employeeCollectionViaRecycleServiceAction_.Count > 0);
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = (_employeeCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = (_recycleServiceCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService = (_recycleVendorCollectionViaRecycleVendorService.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType = (_serviceLocationCollectionViaServiceLocationRecycleType.Count > 0);
			_alreadyFetchedUserCollectionViaRecycleServiceAction_ = (_userCollectionViaRecycleServiceAction_.Count > 0);
			_alreadyFetchedUserCollectionViaRecycleServiceAction = (_userCollectionViaRecycleServiceAction.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return RecycleTypeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "Bale":
					toReturn.Add(RecycleTypeEntity.Relations.BaleEntityUsingRecycleTypeId);
					break;
				case "RecycleServiceAction":
					toReturn.Add(RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId);
					break;
				case "RecycleVendorService":
					toReturn.Add(RecycleTypeEntity.Relations.RecycleVendorServiceEntityUsingRecycleTypeId);
					break;
				case "ServiceLocationRecycleType":
					toReturn.Add(RecycleTypeEntity.Relations.ServiceLocationRecycleTypeEntityUsingRecycleTypeId);
					break;
				case "AccountCollectionViaRecycleVendorService":
					toReturn.Add(RecycleTypeEntity.Relations.RecycleVendorServiceEntityUsingRecycleTypeId, "RecycleTypeEntity__", "RecycleVendorService_", JoinHint.None);
					toReturn.Add(RecycleVendorServiceEntity.Relations.AccountEntityUsingAccountId, "RecycleVendorService_", string.Empty, JoinHint.None);
					break;
				case "AccountCollectionViaBale":
					toReturn.Add(RecycleTypeEntity.Relations.BaleEntityUsingRecycleTypeId, "RecycleTypeEntity__", "Bale_", JoinHint.None);
					toReturn.Add(BaleEntity.Relations.AccountEntityUsingAccountId, "Bale_", string.Empty, JoinHint.None);
					break;
				case "DockCollectionViaBale":
					toReturn.Add(RecycleTypeEntity.Relations.BaleEntityUsingRecycleTypeId, "RecycleTypeEntity__", "Bale_", JoinHint.None);
					toReturn.Add(BaleEntity.Relations.DockEntityUsingDockId, "Bale_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceAction_":
					toReturn.Add(RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId, "RecycleTypeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingActionEmployeeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceAction":
					toReturn.Add(RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId, "RecycleTypeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingLastChangedByEmployeeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction":
					toReturn.Add(RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId, "RecycleTypeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleServiceEntityUsingRecycleServiceId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "RecycleVendorCollectionViaRecycleVendorService":
					toReturn.Add(RecycleTypeEntity.Relations.RecycleVendorServiceEntityUsingRecycleTypeId, "RecycleTypeEntity__", "RecycleVendorService_", JoinHint.None);
					toReturn.Add(RecycleVendorServiceEntity.Relations.RecycleVendorEntityUsingRecycleVendorId, "RecycleVendorService_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaServiceLocationRecycleType":
					toReturn.Add(RecycleTypeEntity.Relations.ServiceLocationRecycleTypeEntityUsingRecycleTypeId, "RecycleTypeEntity__", "ServiceLocationRecycleType_", JoinHint.None);
					toReturn.Add(ServiceLocationRecycleTypeEntity.Relations.ServiceLocationEntityUsingServiceLocationId, "ServiceLocationRecycleType_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceAction_":
					toReturn.Add(RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId, "RecycleTypeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingLastChangedByUserId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceAction":
					toReturn.Add(RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId, "RecycleTypeEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingActionUserId, "RecycleServiceAction_", string.Empty, JoinHint.None);
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
			info.AddValue("_bale", (!this.MarkedForDeletion?_bale:null));
			info.AddValue("_alwaysFetchBale", _alwaysFetchBale);
			info.AddValue("_alreadyFetchedBale", _alreadyFetchedBale);
			info.AddValue("_recycleServiceAction", (!this.MarkedForDeletion?_recycleServiceAction:null));
			info.AddValue("_alwaysFetchRecycleServiceAction", _alwaysFetchRecycleServiceAction);
			info.AddValue("_alreadyFetchedRecycleServiceAction", _alreadyFetchedRecycleServiceAction);
			info.AddValue("_recycleVendorService", (!this.MarkedForDeletion?_recycleVendorService:null));
			info.AddValue("_alwaysFetchRecycleVendorService", _alwaysFetchRecycleVendorService);
			info.AddValue("_alreadyFetchedRecycleVendorService", _alreadyFetchedRecycleVendorService);
			info.AddValue("_serviceLocationRecycleType", (!this.MarkedForDeletion?_serviceLocationRecycleType:null));
			info.AddValue("_alwaysFetchServiceLocationRecycleType", _alwaysFetchServiceLocationRecycleType);
			info.AddValue("_alreadyFetchedServiceLocationRecycleType", _alreadyFetchedServiceLocationRecycleType);
			info.AddValue("_accountCollectionViaRecycleVendorService", (!this.MarkedForDeletion?_accountCollectionViaRecycleVendorService:null));
			info.AddValue("_alwaysFetchAccountCollectionViaRecycleVendorService", _alwaysFetchAccountCollectionViaRecycleVendorService);
			info.AddValue("_alreadyFetchedAccountCollectionViaRecycleVendorService", _alreadyFetchedAccountCollectionViaRecycleVendorService);
			info.AddValue("_accountCollectionViaBale", (!this.MarkedForDeletion?_accountCollectionViaBale:null));
			info.AddValue("_alwaysFetchAccountCollectionViaBale", _alwaysFetchAccountCollectionViaBale);
			info.AddValue("_alreadyFetchedAccountCollectionViaBale", _alreadyFetchedAccountCollectionViaBale);
			info.AddValue("_dockCollectionViaBale", (!this.MarkedForDeletion?_dockCollectionViaBale:null));
			info.AddValue("_alwaysFetchDockCollectionViaBale", _alwaysFetchDockCollectionViaBale);
			info.AddValue("_alreadyFetchedDockCollectionViaBale", _alreadyFetchedDockCollectionViaBale);
			info.AddValue("_employeeCollectionViaRecycleServiceAction_", (!this.MarkedForDeletion?_employeeCollectionViaRecycleServiceAction_:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaRecycleServiceAction_", _alwaysFetchEmployeeCollectionViaRecycleServiceAction_);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_", _alreadyFetchedEmployeeCollectionViaRecycleServiceAction_);
			info.AddValue("_employeeCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_employeeCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaRecycleServiceAction", _alwaysFetchEmployeeCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction", _alreadyFetchedEmployeeCollectionViaRecycleServiceAction);
			info.AddValue("_recycleServiceCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_recycleServiceCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction", _alwaysFetchRecycleServiceCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction", _alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction);
			info.AddValue("_recycleVendorCollectionViaRecycleVendorService", (!this.MarkedForDeletion?_recycleVendorCollectionViaRecycleVendorService:null));
			info.AddValue("_alwaysFetchRecycleVendorCollectionViaRecycleVendorService", _alwaysFetchRecycleVendorCollectionViaRecycleVendorService);
			info.AddValue("_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService", _alreadyFetchedRecycleVendorCollectionViaRecycleVendorService);
			info.AddValue("_serviceLocationCollectionViaServiceLocationRecycleType", (!this.MarkedForDeletion?_serviceLocationCollectionViaServiceLocationRecycleType:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaServiceLocationRecycleType", _alwaysFetchServiceLocationCollectionViaServiceLocationRecycleType);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType", _alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType);
			info.AddValue("_userCollectionViaRecycleServiceAction_", (!this.MarkedForDeletion?_userCollectionViaRecycleServiceAction_:null));
			info.AddValue("_alwaysFetchUserCollectionViaRecycleServiceAction_", _alwaysFetchUserCollectionViaRecycleServiceAction_);
			info.AddValue("_alreadyFetchedUserCollectionViaRecycleServiceAction_", _alreadyFetchedUserCollectionViaRecycleServiceAction_);
			info.AddValue("_userCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_userCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchUserCollectionViaRecycleServiceAction", _alwaysFetchUserCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedUserCollectionViaRecycleServiceAction", _alreadyFetchedUserCollectionViaRecycleServiceAction);


			
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

				case "Bale":
					_alreadyFetchedBale = true;
					if(entity!=null)
					{
						this.Bale.Add((BaleEntity)entity);
					}
					break;
				case "RecycleServiceAction":
					_alreadyFetchedRecycleServiceAction = true;
					if(entity!=null)
					{
						this.RecycleServiceAction.Add((RecycleServiceActionEntity)entity);
					}
					break;
				case "RecycleVendorService":
					_alreadyFetchedRecycleVendorService = true;
					if(entity!=null)
					{
						this.RecycleVendorService.Add((RecycleVendorServiceEntity)entity);
					}
					break;
				case "ServiceLocationRecycleType":
					_alreadyFetchedServiceLocationRecycleType = true;
					if(entity!=null)
					{
						this.ServiceLocationRecycleType.Add((ServiceLocationRecycleTypeEntity)entity);
					}
					break;
				case "AccountCollectionViaRecycleVendorService":
					_alreadyFetchedAccountCollectionViaRecycleVendorService = true;
					if(entity!=null)
					{
						this.AccountCollectionViaRecycleVendorService.Add((AccountEntity)entity);
					}
					break;
				case "AccountCollectionViaBale":
					_alreadyFetchedAccountCollectionViaBale = true;
					if(entity!=null)
					{
						this.AccountCollectionViaBale.Add((AccountEntity)entity);
					}
					break;
				case "DockCollectionViaBale":
					_alreadyFetchedDockCollectionViaBale = true;
					if(entity!=null)
					{
						this.DockCollectionViaBale.Add((DockEntity)entity);
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
				case "RecycleServiceCollectionViaRecycleServiceAction":
					_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = true;
					if(entity!=null)
					{
						this.RecycleServiceCollectionViaRecycleServiceAction.Add((RecycleServiceEntity)entity);
					}
					break;
				case "RecycleVendorCollectionViaRecycleVendorService":
					_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService = true;
					if(entity!=null)
					{
						this.RecycleVendorCollectionViaRecycleVendorService.Add((RecycleVendorEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaServiceLocationRecycleType":
					_alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaServiceLocationRecycleType.Add((ServiceLocationEntity)entity);
					}
					break;
				case "UserCollectionViaRecycleServiceAction_":
					_alreadyFetchedUserCollectionViaRecycleServiceAction_ = true;
					if(entity!=null)
					{
						this.UserCollectionViaRecycleServiceAction_.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaRecycleServiceAction":
					_alreadyFetchedUserCollectionViaRecycleServiceAction = true;
					if(entity!=null)
					{
						this.UserCollectionViaRecycleServiceAction.Add((UserEntity)entity);
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

				case "Bale":
					_bale.Add((BaleEntity)relatedEntity);
					break;
				case "RecycleServiceAction":
					_recycleServiceAction.Add((RecycleServiceActionEntity)relatedEntity);
					break;
				case "RecycleVendorService":
					_recycleVendorService.Add((RecycleVendorServiceEntity)relatedEntity);
					break;
				case "ServiceLocationRecycleType":
					_serviceLocationRecycleType.Add((ServiceLocationRecycleTypeEntity)relatedEntity);
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

				case "Bale":
					base.PerformRelatedEntityRemoval(_bale, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleServiceAction":
					base.PerformRelatedEntityRemoval(_recycleServiceAction, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleVendorService":
					base.PerformRelatedEntityRemoval(_recycleVendorService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationRecycleType":
					base.PerformRelatedEntityRemoval(_serviceLocationRecycleType, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_bale);
			toReturn.Add(_recycleServiceAction);
			toReturn.Add(_recycleVendorService);
			toReturn.Add(_serviceLocationRecycleType);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleTypeId)
		{
			return FetchUsingPK(recycleTypeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleTypeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(recycleTypeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(recycleTypeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(recycleTypeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.RecycleTypeId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(RecycleTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(RecycleTypeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new RecycleTypeRelations().GetAllRelations();
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
				_bale.GetMultiManyToOne(null, null, this, filter);
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
				_recycleServiceAction.GetMultiManyToOne(null, null, null, this, null, null, filter);
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
				_recycleVendorService.GetMultiManyToOne(null, this, null, filter);
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
				_serviceLocationRecycleType.GetMultiManyToOne(this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaRecycleVendorService(bool forceFetch)
		{
			return GetMultiAccountCollectionViaRecycleVendorService(forceFetch, _accountCollectionViaRecycleVendorService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaRecycleVendorService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaRecycleVendorService || forceFetch || _alwaysFetchAccountCollectionViaRecycleVendorService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaRecycleVendorService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaRecycleVendorService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
				_accountCollectionViaRecycleVendorService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaRecycleVendorService.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaRecycleVendorService.GetMulti(filter, GetRelationsForField("AccountCollectionViaRecycleVendorService"));
				_accountCollectionViaRecycleVendorService.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaRecycleVendorService = true;
			}
			return _accountCollectionViaRecycleVendorService;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaRecycleVendorService'. These settings will be taken into account
		/// when the property AccountCollectionViaRecycleVendorService is requested or GetMultiAccountCollectionViaRecycleVendorService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaRecycleVendorService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaRecycleVendorService.SortClauses=sortClauses;
			_accountCollectionViaRecycleVendorService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AccountEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaBale(bool forceFetch)
		{
			return GetMultiAccountCollectionViaBale(forceFetch, _accountCollectionViaBale.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AccountCollection GetMultiAccountCollectionViaBale(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAccountCollectionViaBale || forceFetch || _alwaysFetchAccountCollectionViaBale) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_accountCollectionViaBale.ParticipatesInTransaction)
					{
						base.Transaction.Add(_accountCollectionViaBale);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
				_accountCollectionViaBale.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_accountCollectionViaBale.EntityFactoryToUse = entityFactoryToUse;
				}
				_accountCollectionViaBale.GetMulti(filter, GetRelationsForField("AccountCollectionViaBale"));
				_accountCollectionViaBale.SuppressClearInGetMulti=false;
				_alreadyFetchedAccountCollectionViaBale = true;
			}
			return _accountCollectionViaBale;
		}

		/// <summary> Sets the collection parameters for the collection for 'AccountCollectionViaBale'. These settings will be taken into account
		/// when the property AccountCollectionViaBale is requested or GetMultiAccountCollectionViaBale is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAccountCollectionViaBale(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_accountCollectionViaBale.SortClauses=sortClauses;
			_accountCollectionViaBale.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
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

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationRecycleType(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaServiceLocationRecycleType(forceFetch, _serviceLocationCollectionViaServiceLocationRecycleType.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaServiceLocationRecycleType(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType || forceFetch || _alwaysFetchServiceLocationCollectionViaServiceLocationRecycleType) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaServiceLocationRecycleType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaServiceLocationRecycleType);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
				_serviceLocationCollectionViaServiceLocationRecycleType.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaServiceLocationRecycleType.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaServiceLocationRecycleType.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaServiceLocationRecycleType"));
				_serviceLocationCollectionViaServiceLocationRecycleType.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType = true;
			}
			return _serviceLocationCollectionViaServiceLocationRecycleType;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaServiceLocationRecycleType'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaServiceLocationRecycleType is requested or GetMultiServiceLocationCollectionViaServiceLocationRecycleType is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaServiceLocationRecycleType(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaServiceLocationRecycleType.SortClauses=sortClauses;
			_serviceLocationCollectionViaServiceLocationRecycleType.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
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



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			RecycleTypeDAO dao = (RecycleTypeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_bale.ActiveContext = base.ActiveContext;
			_recycleServiceAction.ActiveContext = base.ActiveContext;
			_recycleVendorService.ActiveContext = base.ActiveContext;
			_serviceLocationRecycleType.ActiveContext = base.ActiveContext;
			_accountCollectionViaRecycleVendorService.ActiveContext = base.ActiveContext;
			_accountCollectionViaBale.ActiveContext = base.ActiveContext;
			_dockCollectionViaBale.ActiveContext = base.ActiveContext;
			_employeeCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			_employeeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_recycleServiceCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_recycleVendorCollectionViaRecycleVendorService.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaServiceLocationRecycleType.ActiveContext = base.ActiveContext;
			_userCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			_userCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			RecycleTypeDAO dao = (RecycleTypeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			RecycleTypeDAO dao = (RecycleTypeDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity);
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

			toReturn.Add("Bale", _bale);
			toReturn.Add("RecycleServiceAction", _recycleServiceAction);
			toReturn.Add("RecycleVendorService", _recycleVendorService);
			toReturn.Add("ServiceLocationRecycleType", _serviceLocationRecycleType);
			toReturn.Add("AccountCollectionViaRecycleVendorService", _accountCollectionViaRecycleVendorService);
			toReturn.Add("AccountCollectionViaBale", _accountCollectionViaBale);
			toReturn.Add("DockCollectionViaBale", _dockCollectionViaBale);
			toReturn.Add("EmployeeCollectionViaRecycleServiceAction_", _employeeCollectionViaRecycleServiceAction_);
			toReturn.Add("EmployeeCollectionViaRecycleServiceAction", _employeeCollectionViaRecycleServiceAction);
			toReturn.Add("RecycleServiceCollectionViaRecycleServiceAction", _recycleServiceCollectionViaRecycleServiceAction);
			toReturn.Add("RecycleVendorCollectionViaRecycleVendorService", _recycleVendorCollectionViaRecycleVendorService);
			toReturn.Add("ServiceLocationCollectionViaServiceLocationRecycleType", _serviceLocationCollectionViaServiceLocationRecycleType);
			toReturn.Add("UserCollectionViaRecycleServiceAction_", _userCollectionViaRecycleServiceAction_);
			toReturn.Add("UserCollectionViaRecycleServiceAction", _userCollectionViaRecycleServiceAction);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		/// <param name="validator">The validator object for this RecycleTypeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 recycleTypeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(recycleTypeId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_bale = new Reliant.RenuOil.DAL.CollectionClasses.BaleCollection(new BaleEntityFactory());
			_bale.SetContainingEntityInfo(this, "RecycleType");
			_alwaysFetchBale = false;
			_alreadyFetchedBale = false;
			_recycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection(new RecycleServiceActionEntityFactory());
			_recycleServiceAction.SetContainingEntityInfo(this, "RecycleType");
			_alwaysFetchRecycleServiceAction = false;
			_alreadyFetchedRecycleServiceAction = false;
			_recycleVendorService = new Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorServiceCollection(new RecycleVendorServiceEntityFactory());
			_recycleVendorService.SetContainingEntityInfo(this, "RecycleType");
			_alwaysFetchRecycleVendorService = false;
			_alreadyFetchedRecycleVendorService = false;
			_serviceLocationRecycleType = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationRecycleTypeCollection(new ServiceLocationRecycleTypeEntityFactory());
			_serviceLocationRecycleType.SetContainingEntityInfo(this, "RecycleType");
			_alwaysFetchServiceLocationRecycleType = false;
			_alreadyFetchedServiceLocationRecycleType = false;
			_accountCollectionViaRecycleVendorService = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaRecycleVendorService = false;
			_alreadyFetchedAccountCollectionViaRecycleVendorService = false;
			_accountCollectionViaBale = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaBale = false;
			_alreadyFetchedAccountCollectionViaBale = false;
			_dockCollectionViaBale = new Reliant.RenuOil.DAL.CollectionClasses.DockCollection(new DockEntityFactory());
			_alwaysFetchDockCollectionViaBale = false;
			_alreadyFetchedDockCollectionViaBale = false;
			_employeeCollectionViaRecycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction_ = false;
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = false;
			_employeeCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction = false;
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = false;
			_recycleServiceCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(new RecycleServiceEntityFactory());
			_alwaysFetchRecycleServiceCollectionViaRecycleServiceAction = false;
			_alreadyFetchedRecycleServiceCollectionViaRecycleServiceAction = false;
			_recycleVendorCollectionViaRecycleVendorService = new Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection(new RecycleVendorEntityFactory());
			_alwaysFetchRecycleVendorCollectionViaRecycleVendorService = false;
			_alreadyFetchedRecycleVendorCollectionViaRecycleVendorService = false;
			_serviceLocationCollectionViaServiceLocationRecycleType = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaServiceLocationRecycleType = false;
			_alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType = false;
			_userCollectionViaRecycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRecycleServiceAction_ = false;
			_alreadyFetchedUserCollectionViaRecycleServiceAction_ = false;
			_userCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRecycleServiceAction = false;
			_alreadyFetchedUserCollectionViaRecycleServiceAction = false;



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

			_fieldsCustomProperties.Add("RecycleTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("SpanishLabel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 recycleTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)RecycleTypeFieldIndex.RecycleTypeId].ForcedCurrentValueWrite(recycleTypeId);
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
			return DAOFactory.CreateRecycleTypeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new RecycleTypeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static RecycleTypeRelations Relations
		{
			get	{ return new RecycleTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Bale' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBale
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.BaleCollection(),
					(IEntityRelation)GetRelationsForField("Bale")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.BaleEntity, 0, null, null, null, "Bale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("RecycleServiceAction")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, "RecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("RecycleVendorService")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity, 0, null, null, null, "RecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("ServiceLocationRecycleType")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationRecycleTypeEntity, 0, null, null, null, "ServiceLocationRecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaRecycleVendorService
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleVendorServiceEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleVendorService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaRecycleVendorService"), "AccountCollectionViaRecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaBale
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.BaleEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "Bale_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaBale"), "AccountCollectionViaBale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Dock' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDockCollectionViaBale
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.BaleEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "Bale_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DockCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.DockEntity, 0, null, null, GetRelationsForField("DockCollectionViaBale"), "DockCollectionViaBale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction_"), "EmployeeCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction"), "EmployeeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction"), "RecycleServiceCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleVendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleVendorCollectionViaRecycleVendorService
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleVendorServiceEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleVendorService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleVendorCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity, 0, null, null, GetRelationsForField("RecycleVendorCollectionViaRecycleVendorService"), "RecycleVendorCollectionViaRecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaServiceLocationRecycleType
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.ServiceLocationRecycleTypeEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationRecycleType_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationRecycleType"), "ServiceLocationCollectionViaServiceLocationRecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction_"), "UserCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction"), "UserCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "RecycleTypeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return RecycleTypeEntity.CustomProperties;}
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
			get { return RecycleTypeEntity.FieldsCustomProperties;}
		}

		/// <summary> The RecycleTypeId property of the Entity RecycleType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleType"."RecycleTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 RecycleTypeId
		{
			get { return (System.Int32)GetValue((int)RecycleTypeFieldIndex.RecycleTypeId, true); }
			set	{ SetValue((int)RecycleTypeFieldIndex.RecycleTypeId, value, true); }
		}
		/// <summary> The Name property of the Entity RecycleType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)RecycleTypeFieldIndex.Name, true); }
			set	{ SetValue((int)RecycleTypeFieldIndex.Name, value, true); }
		}
		/// <summary> The Description property of the Entity RecycleType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleType"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)RecycleTypeFieldIndex.Description, true); }
			set	{ SetValue((int)RecycleTypeFieldIndex.Description, value, true); }
		}
		/// <summary> The SpanishLabel property of the Entity RecycleType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleType"."SpanishLabel"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String SpanishLabel
		{
			get { return (System.String)GetValue((int)RecycleTypeFieldIndex.SpanishLabel, true); }
			set	{ SetValue((int)RecycleTypeFieldIndex.SpanishLabel, value, true); }
		}
		/// <summary> The IsActive property of the Entity RecycleType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleType"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)RecycleTypeFieldIndex.IsActive, true); }
			set	{ SetValue((int)RecycleTypeFieldIndex.IsActive, value, true); }
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

		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaRecycleVendorService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaRecycleVendorService
		{
			get { return GetMultiAccountCollectionViaRecycleVendorService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaRecycleVendorService. When set to true, AccountCollectionViaRecycleVendorService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaRecycleVendorService is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaRecycleVendorService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaRecycleVendorService
		{
			get	{ return _alwaysFetchAccountCollectionViaRecycleVendorService; }
			set	{ _alwaysFetchAccountCollectionViaRecycleVendorService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaRecycleVendorService already has been fetched. Setting this property to false when AccountCollectionViaRecycleVendorService has been fetched
		/// will clear the AccountCollectionViaRecycleVendorService collection well. Setting this property to true while AccountCollectionViaRecycleVendorService hasn't been fetched disables lazy loading for AccountCollectionViaRecycleVendorService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaRecycleVendorService
		{
			get { return _alreadyFetchedAccountCollectionViaRecycleVendorService;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaRecycleVendorService && !value && (_accountCollectionViaRecycleVendorService != null))
				{
					_accountCollectionViaRecycleVendorService.Clear();
				}
				_alreadyFetchedAccountCollectionViaRecycleVendorService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'AccountEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAccountCollectionViaBale()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AccountCollection AccountCollectionViaBale
		{
			get { return GetMultiAccountCollectionViaBale(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AccountCollectionViaBale. When set to true, AccountCollectionViaBale is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AccountCollectionViaBale is accessed. You can always execute
		/// a forced fetch by calling GetMultiAccountCollectionViaBale(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAccountCollectionViaBale
		{
			get	{ return _alwaysFetchAccountCollectionViaBale; }
			set	{ _alwaysFetchAccountCollectionViaBale = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AccountCollectionViaBale already has been fetched. Setting this property to false when AccountCollectionViaBale has been fetched
		/// will clear the AccountCollectionViaBale collection well. Setting this property to true while AccountCollectionViaBale hasn't been fetched disables lazy loading for AccountCollectionViaBale</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAccountCollectionViaBale
		{
			get { return _alreadyFetchedAccountCollectionViaBale;}
			set 
			{
				if(_alreadyFetchedAccountCollectionViaBale && !value && (_accountCollectionViaBale != null))
				{
					_accountCollectionViaBale.Clear();
				}
				_alreadyFetchedAccountCollectionViaBale = value;
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
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaServiceLocationRecycleType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaServiceLocationRecycleType
		{
			get { return GetMultiServiceLocationCollectionViaServiceLocationRecycleType(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaServiceLocationRecycleType. When set to true, ServiceLocationCollectionViaServiceLocationRecycleType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaServiceLocationRecycleType is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaServiceLocationRecycleType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaServiceLocationRecycleType
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaServiceLocationRecycleType; }
			set	{ _alwaysFetchServiceLocationCollectionViaServiceLocationRecycleType = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaServiceLocationRecycleType already has been fetched. Setting this property to false when ServiceLocationCollectionViaServiceLocationRecycleType has been fetched
		/// will clear the ServiceLocationCollectionViaServiceLocationRecycleType collection well. Setting this property to true while ServiceLocationCollectionViaServiceLocationRecycleType hasn't been fetched disables lazy loading for ServiceLocationCollectionViaServiceLocationRecycleType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType
		{
			get { return _alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType && !value && (_serviceLocationCollectionViaServiceLocationRecycleType != null))
				{
					_serviceLocationCollectionViaServiceLocationRecycleType.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaServiceLocationRecycleType = value;
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity; }
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
