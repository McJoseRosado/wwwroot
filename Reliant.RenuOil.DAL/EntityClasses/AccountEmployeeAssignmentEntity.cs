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
	/// Entity class which represents the entity 'AccountEmployeeAssignment'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AccountEmployeeAssignmentEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private AccountEntity _account;
		private bool	_alwaysFetchAccount, _alreadyFetchedAccount, _accountReturnsNewIfNotFound;
		private EmployeeEntity _employee____;
		private bool	_alwaysFetchEmployee____, _alreadyFetchedEmployee____, _employee____ReturnsNewIfNotFound;
		private EmployeeEntity _employee_____;
		private bool	_alwaysFetchEmployee_____, _alreadyFetchedEmployee_____, _employee_____ReturnsNewIfNotFound;
		private EmployeeEntity _employee______;
		private bool	_alwaysFetchEmployee______, _alreadyFetchedEmployee______, _employee______ReturnsNewIfNotFound;
		private EmployeeEntity _employee___;
		private bool	_alwaysFetchEmployee___, _alreadyFetchedEmployee___, _employee___ReturnsNewIfNotFound;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee, _employeeReturnsNewIfNotFound;
		private EmployeeEntity _employee_;
		private bool	_alwaysFetchEmployee_, _alreadyFetchedEmployee_, _employee_ReturnsNewIfNotFound;
		private EmployeeEntity _employee__;
		private bool	_alwaysFetchEmployee__, _alreadyFetchedEmployee__, _employee__ReturnsNewIfNotFound;

		
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
			/// <summary>Member name Employee____</summary>
			public static readonly string Employee____ = "Employee____";
			/// <summary>Member name Employee_____</summary>
			public static readonly string Employee_____ = "Employee_____";
			/// <summary>Member name Employee______</summary>
			public static readonly string Employee______ = "Employee______";
			/// <summary>Member name Employee___</summary>
			public static readonly string Employee___ = "Employee___";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name Employee_</summary>
			public static readonly string Employee_ = "Employee_";
			/// <summary>Member name Employee__</summary>
			public static readonly string Employee__ = "Employee__";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AccountEmployeeAssignmentEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AccountEmployeeAssignmentEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="accountEmployeeAssignmentId">PK value for AccountEmployeeAssignment which data should be fetched into this AccountEmployeeAssignment object</param>
		public AccountEmployeeAssignmentEntity(System.Int32 accountEmployeeAssignmentId)
		{
			InitClassFetch(accountEmployeeAssignmentId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="accountEmployeeAssignmentId">PK value for AccountEmployeeAssignment which data should be fetched into this AccountEmployeeAssignment object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AccountEmployeeAssignmentEntity(System.Int32 accountEmployeeAssignmentId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(accountEmployeeAssignmentId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="accountEmployeeAssignmentId">PK value for AccountEmployeeAssignment which data should be fetched into this AccountEmployeeAssignment object</param>
		/// <param name="validator">The custom validator object for this AccountEmployeeAssignmentEntity</param>
		public AccountEmployeeAssignmentEntity(System.Int32 accountEmployeeAssignmentId, IValidator validator)
		{
			InitClassFetch(accountEmployeeAssignmentId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AccountEmployeeAssignmentEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_account = (AccountEntity)info.GetValue("_account", typeof(AccountEntity));
			if(_account!=null)
			{
				_account.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_accountReturnsNewIfNotFound = info.GetBoolean("_accountReturnsNewIfNotFound");
			_alwaysFetchAccount = info.GetBoolean("_alwaysFetchAccount");
			_alreadyFetchedAccount = info.GetBoolean("_alreadyFetchedAccount");
			_employee____ = (EmployeeEntity)info.GetValue("_employee____", typeof(EmployeeEntity));
			if(_employee____!=null)
			{
				_employee____.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employee____ReturnsNewIfNotFound = info.GetBoolean("_employee____ReturnsNewIfNotFound");
			_alwaysFetchEmployee____ = info.GetBoolean("_alwaysFetchEmployee____");
			_alreadyFetchedEmployee____ = info.GetBoolean("_alreadyFetchedEmployee____");
			_employee_____ = (EmployeeEntity)info.GetValue("_employee_____", typeof(EmployeeEntity));
			if(_employee_____!=null)
			{
				_employee_____.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employee_____ReturnsNewIfNotFound = info.GetBoolean("_employee_____ReturnsNewIfNotFound");
			_alwaysFetchEmployee_____ = info.GetBoolean("_alwaysFetchEmployee_____");
			_alreadyFetchedEmployee_____ = info.GetBoolean("_alreadyFetchedEmployee_____");
			_employee______ = (EmployeeEntity)info.GetValue("_employee______", typeof(EmployeeEntity));
			if(_employee______!=null)
			{
				_employee______.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employee______ReturnsNewIfNotFound = info.GetBoolean("_employee______ReturnsNewIfNotFound");
			_alwaysFetchEmployee______ = info.GetBoolean("_alwaysFetchEmployee______");
			_alreadyFetchedEmployee______ = info.GetBoolean("_alreadyFetchedEmployee______");
			_employee___ = (EmployeeEntity)info.GetValue("_employee___", typeof(EmployeeEntity));
			if(_employee___!=null)
			{
				_employee___.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employee___ReturnsNewIfNotFound = info.GetBoolean("_employee___ReturnsNewIfNotFound");
			_alwaysFetchEmployee___ = info.GetBoolean("_alwaysFetchEmployee___");
			_alreadyFetchedEmployee___ = info.GetBoolean("_alreadyFetchedEmployee___");
			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeeReturnsNewIfNotFound = info.GetBoolean("_employeeReturnsNewIfNotFound");
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");
			_employee_ = (EmployeeEntity)info.GetValue("_employee_", typeof(EmployeeEntity));
			if(_employee_!=null)
			{
				_employee_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employee_ReturnsNewIfNotFound = info.GetBoolean("_employee_ReturnsNewIfNotFound");
			_alwaysFetchEmployee_ = info.GetBoolean("_alwaysFetchEmployee_");
			_alreadyFetchedEmployee_ = info.GetBoolean("_alreadyFetchedEmployee_");
			_employee__ = (EmployeeEntity)info.GetValue("_employee__", typeof(EmployeeEntity));
			if(_employee__!=null)
			{
				_employee__.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employee__ReturnsNewIfNotFound = info.GetBoolean("_employee__ReturnsNewIfNotFound");
			_alwaysFetchEmployee__ = info.GetBoolean("_alwaysFetchEmployee__");
			_alreadyFetchedEmployee__ = info.GetBoolean("_alreadyFetchedEmployee__");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AccountEmployeeAssignmentFieldIndex)fieldIndex)
			{
				case AccountEmployeeAssignmentFieldIndex.AccountId:
					DesetupSyncAccount(true, false);
					_alreadyFetchedAccount = false;
					break;
				case AccountEmployeeAssignmentFieldIndex.Monday:
					DesetupSyncEmployee_(true, false);
					_alreadyFetchedEmployee_ = false;
					break;
				case AccountEmployeeAssignmentFieldIndex.Tuesday:
					DesetupSyncEmployee_____(true, false);
					_alreadyFetchedEmployee_____ = false;
					break;
				case AccountEmployeeAssignmentFieldIndex.Wednesday:
					DesetupSyncEmployee______(true, false);
					_alreadyFetchedEmployee______ = false;
					break;
				case AccountEmployeeAssignmentFieldIndex.Thursday:
					DesetupSyncEmployee____(true, false);
					_alreadyFetchedEmployee____ = false;
					break;
				case AccountEmployeeAssignmentFieldIndex.Friday:
					DesetupSyncEmployee(true, false);
					_alreadyFetchedEmployee = false;
					break;
				case AccountEmployeeAssignmentFieldIndex.Saturday:
					DesetupSyncEmployee__(true, false);
					_alreadyFetchedEmployee__ = false;
					break;
				case AccountEmployeeAssignmentFieldIndex.Sunday:
					DesetupSyncEmployee___(true, false);
					_alreadyFetchedEmployee___ = false;
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


			_alreadyFetchedAccount = (_account != null);
			_alreadyFetchedEmployee____ = (_employee____ != null);
			_alreadyFetchedEmployee_____ = (_employee_____ != null);
			_alreadyFetchedEmployee______ = (_employee______ != null);
			_alreadyFetchedEmployee___ = (_employee___ != null);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedEmployee_ = (_employee_ != null);
			_alreadyFetchedEmployee__ = (_employee__ != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return AccountEmployeeAssignmentEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId);
					break;
				case "Employee____":
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingThursday);
					break;
				case "Employee_____":
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingTuesday);
					break;
				case "Employee______":
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingWednesday);
					break;
				case "Employee___":
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSunday);
					break;
				case "Employee":
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingFriday);
					break;
				case "Employee_":
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingMonday);
					break;
				case "Employee__":
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSaturday);
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


			info.AddValue("_account", (!this.MarkedForDeletion?_account:null));
			info.AddValue("_accountReturnsNewIfNotFound", _accountReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAccount", _alwaysFetchAccount);
			info.AddValue("_alreadyFetchedAccount", _alreadyFetchedAccount);
			info.AddValue("_employee____", (!this.MarkedForDeletion?_employee____:null));
			info.AddValue("_employee____ReturnsNewIfNotFound", _employee____ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee____", _alwaysFetchEmployee____);
			info.AddValue("_alreadyFetchedEmployee____", _alreadyFetchedEmployee____);
			info.AddValue("_employee_____", (!this.MarkedForDeletion?_employee_____:null));
			info.AddValue("_employee_____ReturnsNewIfNotFound", _employee_____ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee_____", _alwaysFetchEmployee_____);
			info.AddValue("_alreadyFetchedEmployee_____", _alreadyFetchedEmployee_____);
			info.AddValue("_employee______", (!this.MarkedForDeletion?_employee______:null));
			info.AddValue("_employee______ReturnsNewIfNotFound", _employee______ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee______", _alwaysFetchEmployee______);
			info.AddValue("_alreadyFetchedEmployee______", _alreadyFetchedEmployee______);
			info.AddValue("_employee___", (!this.MarkedForDeletion?_employee___:null));
			info.AddValue("_employee___ReturnsNewIfNotFound", _employee___ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee___", _alwaysFetchEmployee___);
			info.AddValue("_alreadyFetchedEmployee___", _alreadyFetchedEmployee___);
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_employeeReturnsNewIfNotFound", _employeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_employee_", (!this.MarkedForDeletion?_employee_:null));
			info.AddValue("_employee_ReturnsNewIfNotFound", _employee_ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee_", _alwaysFetchEmployee_);
			info.AddValue("_alreadyFetchedEmployee_", _alreadyFetchedEmployee_);
			info.AddValue("_employee__", (!this.MarkedForDeletion?_employee__:null));
			info.AddValue("_employee__ReturnsNewIfNotFound", _employee__ReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee__", _alwaysFetchEmployee__);
			info.AddValue("_alreadyFetchedEmployee__", _alreadyFetchedEmployee__);

			
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
				case "Employee____":
					_alreadyFetchedEmployee____ = true;
					this.Employee____ = (EmployeeEntity)entity;
					break;
				case "Employee_____":
					_alreadyFetchedEmployee_____ = true;
					this.Employee_____ = (EmployeeEntity)entity;
					break;
				case "Employee______":
					_alreadyFetchedEmployee______ = true;
					this.Employee______ = (EmployeeEntity)entity;
					break;
				case "Employee___":
					_alreadyFetchedEmployee___ = true;
					this.Employee___ = (EmployeeEntity)entity;
					break;
				case "Employee":
					_alreadyFetchedEmployee = true;
					this.Employee = (EmployeeEntity)entity;
					break;
				case "Employee_":
					_alreadyFetchedEmployee_ = true;
					this.Employee_ = (EmployeeEntity)entity;
					break;
				case "Employee__":
					_alreadyFetchedEmployee__ = true;
					this.Employee__ = (EmployeeEntity)entity;
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
				case "Employee____":
					SetupSyncEmployee____(relatedEntity);
					break;
				case "Employee_____":
					SetupSyncEmployee_____(relatedEntity);
					break;
				case "Employee______":
					SetupSyncEmployee______(relatedEntity);
					break;
				case "Employee___":
					SetupSyncEmployee___(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "Employee_":
					SetupSyncEmployee_(relatedEntity);
					break;
				case "Employee__":
					SetupSyncEmployee__(relatedEntity);
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
				case "Employee____":
					DesetupSyncEmployee____(false, true);
					break;
				case "Employee_____":
					DesetupSyncEmployee_____(false, true);
					break;
				case "Employee______":
					DesetupSyncEmployee______(false, true);
					break;
				case "Employee___":
					DesetupSyncEmployee___(false, true);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "Employee_":
					DesetupSyncEmployee_(false, true);
					break;
				case "Employee__":
					DesetupSyncEmployee__(false, true);
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
			if(_employee____!=null)
			{
				toReturn.Add(_employee____);
			}
			if(_employee_____!=null)
			{
				toReturn.Add(_employee_____);
			}
			if(_employee______!=null)
			{
				toReturn.Add(_employee______);
			}
			if(_employee___!=null)
			{
				toReturn.Add(_employee___);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_employee_!=null)
			{
				toReturn.Add(_employee_);
			}
			if(_employee__!=null)
			{
				toReturn.Add(_employee__);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="accountEmployeeAssignmentId">PK value for AccountEmployeeAssignment which data should be fetched into this AccountEmployeeAssignment object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 accountEmployeeAssignmentId)
		{
			return FetchUsingPK(accountEmployeeAssignmentId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="accountEmployeeAssignmentId">PK value for AccountEmployeeAssignment which data should be fetched into this AccountEmployeeAssignment object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 accountEmployeeAssignmentId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(accountEmployeeAssignmentId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="accountEmployeeAssignmentId">PK value for AccountEmployeeAssignment which data should be fetched into this AccountEmployeeAssignment object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 accountEmployeeAssignmentId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(accountEmployeeAssignmentId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="accountEmployeeAssignmentId">PK value for AccountEmployeeAssignment which data should be fetched into this AccountEmployeeAssignment object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 accountEmployeeAssignmentId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(accountEmployeeAssignmentId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AccountEmployeeAssignmentId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(AccountEmployeeAssignmentFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(AccountEmployeeAssignmentFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new AccountEmployeeAssignmentRelations().GetAllRelations();
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId);

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

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee____()
		{
			return GetSingleEmployee____(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee____(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee____ || forceFetch || _alwaysFetchEmployee____) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingThursday);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.Thursday.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee____ = newEntity;
				}
				else
				{
					if(_employee____ReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee____ == null)))
						{
							this.Employee____ = newEntity;
						}
					}
					else
					{
						this.Employee____ = null;
					}
				}
				_alreadyFetchedEmployee____ = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _employee____;
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee_____()
		{
			return GetSingleEmployee_____(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee_____(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee_____ || forceFetch || _alwaysFetchEmployee_____) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingTuesday);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.Tuesday.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee_____ = newEntity;
				}
				else
				{
					if(_employee_____ReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee_____ == null)))
						{
							this.Employee_____ = newEntity;
						}
					}
					else
					{
						this.Employee_____ = null;
					}
				}
				_alreadyFetchedEmployee_____ = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _employee_____;
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee______()
		{
			return GetSingleEmployee______(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee______(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee______ || forceFetch || _alwaysFetchEmployee______) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingWednesday);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.Wednesday.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee______ = newEntity;
				}
				else
				{
					if(_employee______ReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee______ == null)))
						{
							this.Employee______ = newEntity;
						}
					}
					else
					{
						this.Employee______ = null;
					}
				}
				_alreadyFetchedEmployee______ = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _employee______;
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee___()
		{
			return GetSingleEmployee___(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee___(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee___ || forceFetch || _alwaysFetchEmployee___) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSunday);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.Sunday.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee___ = newEntity;
				}
				else
				{
					if(_employee___ReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee___ == null)))
						{
							this.Employee___ = newEntity;
						}
					}
					else
					{
						this.Employee___ = null;
					}
				}
				_alreadyFetchedEmployee___ = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _employee___;
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee()
		{
			return GetSingleEmployee(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingFriday);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.Friday.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee = newEntity;
				}
				else
				{
					if(_employeeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee == null)))
						{
							this.Employee = newEntity;
						}
					}
					else
					{
						this.Employee = null;
					}
				}
				_alreadyFetchedEmployee = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _employee;
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee_()
		{
			return GetSingleEmployee_(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee_(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee_ || forceFetch || _alwaysFetchEmployee_) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingMonday);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.Monday.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee_ = newEntity;
				}
				else
				{
					if(_employee_ReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee_ == null)))
						{
							this.Employee_ = newEntity;
						}
					}
					else
					{
						this.Employee_ = null;
					}
				}
				_alreadyFetchedEmployee_ = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _employee_;
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee__()
		{
			return GetSingleEmployee__(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee__(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee__ || forceFetch || _alwaysFetchEmployee__) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSaturday);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.Saturday.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee__ = newEntity;
				}
				else
				{
					if(_employee__ReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee__ == null)))
						{
							this.Employee__ = newEntity;
						}
					}
					else
					{
						this.Employee__ = null;
					}
				}
				_alreadyFetchedEmployee__ = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _employee__;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			AccountEmployeeAssignmentDAO dao = (AccountEmployeeAssignmentDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_account!=null)
			{
				_account.ActiveContext = base.ActiveContext;
			}
			if(_employee____!=null)
			{
				_employee____.ActiveContext = base.ActiveContext;
			}
			if(_employee_____!=null)
			{
				_employee_____.ActiveContext = base.ActiveContext;
			}
			if(_employee______!=null)
			{
				_employee______.ActiveContext = base.ActiveContext;
			}
			if(_employee___!=null)
			{
				_employee___.ActiveContext = base.ActiveContext;
			}
			if(_employee!=null)
			{
				_employee.ActiveContext = base.ActiveContext;
			}
			if(_employee_!=null)
			{
				_employee_.ActiveContext = base.ActiveContext;
			}
			if(_employee__!=null)
			{
				_employee__.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			AccountEmployeeAssignmentDAO dao = (AccountEmployeeAssignmentDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			AccountEmployeeAssignmentDAO dao = (AccountEmployeeAssignmentDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity);
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
			toReturn.Add("Employee____", _employee____);
			toReturn.Add("Employee_____", _employee_____);
			toReturn.Add("Employee______", _employee______);
			toReturn.Add("Employee___", _employee___);
			toReturn.Add("Employee", _employee);
			toReturn.Add("Employee_", _employee_);
			toReturn.Add("Employee__", _employee__);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="accountEmployeeAssignmentId">PK value for AccountEmployeeAssignment which data should be fetched into this AccountEmployeeAssignment object</param>
		/// <param name="validator">The validator object for this AccountEmployeeAssignmentEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 accountEmployeeAssignmentId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(accountEmployeeAssignmentId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_account = null;
			_accountReturnsNewIfNotFound = true;
			_alwaysFetchAccount = false;
			_alreadyFetchedAccount = false;
			_employee____ = null;
			_employee____ReturnsNewIfNotFound = true;
			_alwaysFetchEmployee____ = false;
			_alreadyFetchedEmployee____ = false;
			_employee_____ = null;
			_employee_____ReturnsNewIfNotFound = true;
			_alwaysFetchEmployee_____ = false;
			_alreadyFetchedEmployee_____ = false;
			_employee______ = null;
			_employee______ReturnsNewIfNotFound = true;
			_alwaysFetchEmployee______ = false;
			_alreadyFetchedEmployee______ = false;
			_employee___ = null;
			_employee___ReturnsNewIfNotFound = true;
			_alwaysFetchEmployee___ = false;
			_alreadyFetchedEmployee___ = false;
			_employee = null;
			_employeeReturnsNewIfNotFound = true;
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_employee_ = null;
			_employee_ReturnsNewIfNotFound = true;
			_alwaysFetchEmployee_ = false;
			_alreadyFetchedEmployee_ = false;
			_employee__ = null;
			_employee__ReturnsNewIfNotFound = true;
			_alwaysFetchEmployee__ = false;
			_alreadyFetchedEmployee__ = false;


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

			_fieldsCustomProperties.Add("AccountEmployeeAssignmentId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Monday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Tuesday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Wednesday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Thursday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Friday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Saturday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Sunday", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _account</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAccount(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId, true, signalRelatedEntity, "AccountEmployeeAssignment", resetFKFields, new int[] { (int)AccountEmployeeAssignmentFieldIndex.AccountId } );		
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
				base.PerformSetupSyncRelatedEntity( _account, new PropertyChangedEventHandler( OnAccountPropertyChanged ), "Account", AccountEmployeeAssignmentEntity.Relations.AccountEntityUsingAccountId, true, ref _alreadyFetchedAccount, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _employee____</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee____(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee____, new PropertyChangedEventHandler( OnEmployee____PropertyChanged ), "Employee____", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingThursday, true, signalRelatedEntity, "AccountEmployeeAssignment____", resetFKFields, new int[] { (int)AccountEmployeeAssignmentFieldIndex.Thursday } );		
			_employee____ = null;
		}
		
		/// <summary> setups the sync logic for member _employee____</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee____(IEntity relatedEntity)
		{
			if(_employee____!=relatedEntity)
			{		
				DesetupSyncEmployee____(true, true);
				_employee____ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee____, new PropertyChangedEventHandler( OnEmployee____PropertyChanged ), "Employee____", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingThursday, true, ref _alreadyFetchedEmployee____, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee____PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee_____</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee_____(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee_____, new PropertyChangedEventHandler( OnEmployee_____PropertyChanged ), "Employee_____", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingTuesday, true, signalRelatedEntity, "AccountEmployeeAssignment_____", resetFKFields, new int[] { (int)AccountEmployeeAssignmentFieldIndex.Tuesday } );		
			_employee_____ = null;
		}
		
		/// <summary> setups the sync logic for member _employee_____</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee_____(IEntity relatedEntity)
		{
			if(_employee_____!=relatedEntity)
			{		
				DesetupSyncEmployee_____(true, true);
				_employee_____ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee_____, new PropertyChangedEventHandler( OnEmployee_____PropertyChanged ), "Employee_____", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingTuesday, true, ref _alreadyFetchedEmployee_____, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee_____PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee______</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee______(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee______, new PropertyChangedEventHandler( OnEmployee______PropertyChanged ), "Employee______", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingWednesday, true, signalRelatedEntity, "AccountEmployeeAssignment______", resetFKFields, new int[] { (int)AccountEmployeeAssignmentFieldIndex.Wednesday } );		
			_employee______ = null;
		}
		
		/// <summary> setups the sync logic for member _employee______</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee______(IEntity relatedEntity)
		{
			if(_employee______!=relatedEntity)
			{		
				DesetupSyncEmployee______(true, true);
				_employee______ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee______, new PropertyChangedEventHandler( OnEmployee______PropertyChanged ), "Employee______", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingWednesday, true, ref _alreadyFetchedEmployee______, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee______PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee___</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee___(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee___, new PropertyChangedEventHandler( OnEmployee___PropertyChanged ), "Employee___", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSunday, true, signalRelatedEntity, "AccountEmployeeAssignment___", resetFKFields, new int[] { (int)AccountEmployeeAssignmentFieldIndex.Sunday } );		
			_employee___ = null;
		}
		
		/// <summary> setups the sync logic for member _employee___</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee___(IEntity relatedEntity)
		{
			if(_employee___!=relatedEntity)
			{		
				DesetupSyncEmployee___(true, true);
				_employee___ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee___, new PropertyChangedEventHandler( OnEmployee___PropertyChanged ), "Employee___", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSunday, true, ref _alreadyFetchedEmployee___, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee___PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingFriday, true, signalRelatedEntity, "AccountEmployeeAssignment", resetFKFields, new int[] { (int)AccountEmployeeAssignmentFieldIndex.Friday } );		
			_employee = null;
		}
		
		/// <summary> setups the sync logic for member _employee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntity relatedEntity)
		{
			if(_employee!=relatedEntity)
			{		
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingFriday, true, ref _alreadyFetchedEmployee, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee_(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee_, new PropertyChangedEventHandler( OnEmployee_PropertyChanged ), "Employee_", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingMonday, true, signalRelatedEntity, "AccountEmployeeAssignment_", resetFKFields, new int[] { (int)AccountEmployeeAssignmentFieldIndex.Monday } );		
			_employee_ = null;
		}
		
		/// <summary> setups the sync logic for member _employee_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee_(IEntity relatedEntity)
		{
			if(_employee_!=relatedEntity)
			{		
				DesetupSyncEmployee_(true, true);
				_employee_ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee_, new PropertyChangedEventHandler( OnEmployee_PropertyChanged ), "Employee_", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingMonday, true, ref _alreadyFetchedEmployee_, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee__</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee__(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee__, new PropertyChangedEventHandler( OnEmployee__PropertyChanged ), "Employee__", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSaturday, true, signalRelatedEntity, "AccountEmployeeAssignment__", resetFKFields, new int[] { (int)AccountEmployeeAssignmentFieldIndex.Saturday } );		
			_employee__ = null;
		}
		
		/// <summary> setups the sync logic for member _employee__</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee__(IEntity relatedEntity)
		{
			if(_employee__!=relatedEntity)
			{		
				DesetupSyncEmployee__(true, true);
				_employee__ = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee__, new PropertyChangedEventHandler( OnEmployee__PropertyChanged ), "Employee__", AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSaturday, true, ref _alreadyFetchedEmployee__, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployee__PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="accountEmployeeAssignmentId">PK value for AccountEmployeeAssignment which data should be fetched into this AccountEmployeeAssignment object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 accountEmployeeAssignmentId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)AccountEmployeeAssignmentFieldIndex.AccountEmployeeAssignmentId].ForcedCurrentValueWrite(accountEmployeeAssignmentId);
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
			return DAOFactory.CreateAccountEmployeeAssignmentDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AccountEmployeeAssignmentEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AccountEmployeeAssignmentRelations Relations
		{
			get	{ return new AccountEmployeeAssignmentRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccount
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(),
					(IEntityRelation)GetRelationsForField("Account")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, null, "Account", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee____
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee____")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee_____
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee_____")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee______
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee______")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee___
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee___")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee_
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee_")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee__
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee__")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "AccountEmployeeAssignmentEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return AccountEmployeeAssignmentEntity.CustomProperties;}
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
			get { return AccountEmployeeAssignmentEntity.FieldsCustomProperties;}
		}

		/// <summary> The AccountEmployeeAssignmentId property of the Entity AccountEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AccountEmployeeAssignment"."AccountEmployeeAssignmentId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AccountEmployeeAssignmentId
		{
			get { return (System.Int32)GetValue((int)AccountEmployeeAssignmentFieldIndex.AccountEmployeeAssignmentId, true); }
			set	{ SetValue((int)AccountEmployeeAssignmentFieldIndex.AccountEmployeeAssignmentId, value, true); }
		}
		/// <summary> The AccountId property of the Entity AccountEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AccountEmployeeAssignment"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)AccountEmployeeAssignmentFieldIndex.AccountId, true); }
			set	{ SetValue((int)AccountEmployeeAssignmentFieldIndex.AccountId, value, true); }
		}
		/// <summary> The Monday property of the Entity AccountEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AccountEmployeeAssignment"."Monday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Monday
		{
			get { return (Nullable<System.Int32>)GetValue((int)AccountEmployeeAssignmentFieldIndex.Monday, false); }
			set	{ SetValue((int)AccountEmployeeAssignmentFieldIndex.Monday, value, true); }
		}
		/// <summary> The Tuesday property of the Entity AccountEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AccountEmployeeAssignment"."Tuesday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Tuesday
		{
			get { return (Nullable<System.Int32>)GetValue((int)AccountEmployeeAssignmentFieldIndex.Tuesday, false); }
			set	{ SetValue((int)AccountEmployeeAssignmentFieldIndex.Tuesday, value, true); }
		}
		/// <summary> The Wednesday property of the Entity AccountEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AccountEmployeeAssignment"."Wednesday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Wednesday
		{
			get { return (Nullable<System.Int32>)GetValue((int)AccountEmployeeAssignmentFieldIndex.Wednesday, false); }
			set	{ SetValue((int)AccountEmployeeAssignmentFieldIndex.Wednesday, value, true); }
		}
		/// <summary> The Thursday property of the Entity AccountEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AccountEmployeeAssignment"."Thursday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Thursday
		{
			get { return (Nullable<System.Int32>)GetValue((int)AccountEmployeeAssignmentFieldIndex.Thursday, false); }
			set	{ SetValue((int)AccountEmployeeAssignmentFieldIndex.Thursday, value, true); }
		}
		/// <summary> The Friday property of the Entity AccountEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AccountEmployeeAssignment"."Friday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Friday
		{
			get { return (Nullable<System.Int32>)GetValue((int)AccountEmployeeAssignmentFieldIndex.Friday, false); }
			set	{ SetValue((int)AccountEmployeeAssignmentFieldIndex.Friday, value, true); }
		}
		/// <summary> The Saturday property of the Entity AccountEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AccountEmployeeAssignment"."Saturday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Saturday
		{
			get { return (Nullable<System.Int32>)GetValue((int)AccountEmployeeAssignmentFieldIndex.Saturday, false); }
			set	{ SetValue((int)AccountEmployeeAssignmentFieldIndex.Saturday, value, true); }
		}
		/// <summary> The Sunday property of the Entity AccountEmployeeAssignment<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AccountEmployeeAssignment"."Sunday"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Sunday
		{
			get { return (Nullable<System.Int32>)GetValue((int)AccountEmployeeAssignmentFieldIndex.Sunday, false); }
			set	{ SetValue((int)AccountEmployeeAssignmentFieldIndex.Sunday, value, true); }
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
							_account.UnsetRelatedEntity(this, "AccountEmployeeAssignment");
						}
					}
					else
					{
						if(_account!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AccountEmployeeAssignment");
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
		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee____
		{
			get	{ return GetSingleEmployee____(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee____(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee____ != null)
						{
							_employee____.UnsetRelatedEntity(this, "AccountEmployeeAssignment____");
						}
					}
					else
					{
						if(_employee____!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AccountEmployeeAssignment____");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee____. When set to true, Employee____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee____ is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee____
		{
			get	{ return _alwaysFetchEmployee____; }
			set	{ _alwaysFetchEmployee____ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee____ already has been fetched. Setting this property to false when Employee____ has been fetched
		/// will set Employee____ to null as well. Setting this property to true while Employee____ hasn't been fetched disables lazy loading for Employee____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee____
		{
			get { return _alreadyFetchedEmployee____;}
			set 
			{
				if(_alreadyFetchedEmployee____ && !value)
				{
					this.Employee____ = null;
				}
				_alreadyFetchedEmployee____ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee____ is not found
		/// in the database. When set to true, Employee____ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Employee____ReturnsNewIfNotFound
		{
			get	{ return _employee____ReturnsNewIfNotFound; }
			set { _employee____ReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee_____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee_____
		{
			get	{ return GetSingleEmployee_____(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee_____(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee_____ != null)
						{
							_employee_____.UnsetRelatedEntity(this, "AccountEmployeeAssignment_____");
						}
					}
					else
					{
						if(_employee_____!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AccountEmployeeAssignment_____");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee_____. When set to true, Employee_____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee_____ is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee_____(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee_____
		{
			get	{ return _alwaysFetchEmployee_____; }
			set	{ _alwaysFetchEmployee_____ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee_____ already has been fetched. Setting this property to false when Employee_____ has been fetched
		/// will set Employee_____ to null as well. Setting this property to true while Employee_____ hasn't been fetched disables lazy loading for Employee_____</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee_____
		{
			get { return _alreadyFetchedEmployee_____;}
			set 
			{
				if(_alreadyFetchedEmployee_____ && !value)
				{
					this.Employee_____ = null;
				}
				_alreadyFetchedEmployee_____ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee_____ is not found
		/// in the database. When set to true, Employee_____ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Employee_____ReturnsNewIfNotFound
		{
			get	{ return _employee_____ReturnsNewIfNotFound; }
			set { _employee_____ReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee______()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee______
		{
			get	{ return GetSingleEmployee______(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee______(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee______ != null)
						{
							_employee______.UnsetRelatedEntity(this, "AccountEmployeeAssignment______");
						}
					}
					else
					{
						if(_employee______!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AccountEmployeeAssignment______");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee______. When set to true, Employee______ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee______ is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee______(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee______
		{
			get	{ return _alwaysFetchEmployee______; }
			set	{ _alwaysFetchEmployee______ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee______ already has been fetched. Setting this property to false when Employee______ has been fetched
		/// will set Employee______ to null as well. Setting this property to true while Employee______ hasn't been fetched disables lazy loading for Employee______</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee______
		{
			get { return _alreadyFetchedEmployee______;}
			set 
			{
				if(_alreadyFetchedEmployee______ && !value)
				{
					this.Employee______ = null;
				}
				_alreadyFetchedEmployee______ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee______ is not found
		/// in the database. When set to true, Employee______ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Employee______ReturnsNewIfNotFound
		{
			get	{ return _employee______ReturnsNewIfNotFound; }
			set { _employee______ReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee___
		{
			get	{ return GetSingleEmployee___(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee___(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee___ != null)
						{
							_employee___.UnsetRelatedEntity(this, "AccountEmployeeAssignment___");
						}
					}
					else
					{
						if(_employee___!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AccountEmployeeAssignment___");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee___. When set to true, Employee___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee___ is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee___(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee___
		{
			get	{ return _alwaysFetchEmployee___; }
			set	{ _alwaysFetchEmployee___ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee___ already has been fetched. Setting this property to false when Employee___ has been fetched
		/// will set Employee___ to null as well. Setting this property to true while Employee___ hasn't been fetched disables lazy loading for Employee___</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee___
		{
			get { return _alreadyFetchedEmployee___;}
			set 
			{
				if(_alreadyFetchedEmployee___ && !value)
				{
					this.Employee___ = null;
				}
				_alreadyFetchedEmployee___ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee___ is not found
		/// in the database. When set to true, Employee___ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Employee___ReturnsNewIfNotFound
		{
			get	{ return _employee___ReturnsNewIfNotFound; }
			set { _employee___ReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get	{ return GetSingleEmployee(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee != null)
						{
							_employee.UnsetRelatedEntity(this, "AccountEmployeeAssignment");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AccountEmployeeAssignment");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee
		{
			get	{ return _alwaysFetchEmployee; }
			set	{ _alwaysFetchEmployee = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee already has been fetched. Setting this property to false when Employee has been fetched
		/// will set Employee to null as well. Setting this property to true while Employee hasn't been fetched disables lazy loading for Employee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee
		{
			get { return _alreadyFetchedEmployee;}
			set 
			{
				if(_alreadyFetchedEmployee && !value)
				{
					this.Employee = null;
				}
				_alreadyFetchedEmployee = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee is not found
		/// in the database. When set to true, Employee will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool EmployeeReturnsNewIfNotFound
		{
			get	{ return _employeeReturnsNewIfNotFound; }
			set { _employeeReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee_
		{
			get	{ return GetSingleEmployee_(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee_(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee_ != null)
						{
							_employee_.UnsetRelatedEntity(this, "AccountEmployeeAssignment_");
						}
					}
					else
					{
						if(_employee_!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AccountEmployeeAssignment_");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee_. When set to true, Employee_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee_
		{
			get	{ return _alwaysFetchEmployee_; }
			set	{ _alwaysFetchEmployee_ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee_ already has been fetched. Setting this property to false when Employee_ has been fetched
		/// will set Employee_ to null as well. Setting this property to true while Employee_ hasn't been fetched disables lazy loading for Employee_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee_
		{
			get { return _alreadyFetchedEmployee_;}
			set 
			{
				if(_alreadyFetchedEmployee_ && !value)
				{
					this.Employee_ = null;
				}
				_alreadyFetchedEmployee_ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee_ is not found
		/// in the database. When set to true, Employee_ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Employee_ReturnsNewIfNotFound
		{
			get	{ return _employee_ReturnsNewIfNotFound; }
			set { _employee_ReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee__
		{
			get	{ return GetSingleEmployee__(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee__(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee__ != null)
						{
							_employee__.UnsetRelatedEntity(this, "AccountEmployeeAssignment__");
						}
					}
					else
					{
						if(_employee__!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AccountEmployeeAssignment__");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee__. When set to true, Employee__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee__ is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee__(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee__
		{
			get	{ return _alwaysFetchEmployee__; }
			set	{ _alwaysFetchEmployee__ = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee__ already has been fetched. Setting this property to false when Employee__ has been fetched
		/// will set Employee__ to null as well. Setting this property to true while Employee__ hasn't been fetched disables lazy loading for Employee__</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee__
		{
			get { return _alreadyFetchedEmployee__;}
			set 
			{
				if(_alreadyFetchedEmployee__ && !value)
				{
					this.Employee__ = null;
				}
				_alreadyFetchedEmployee__ = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee__ is not found
		/// in the database. When set to true, Employee__ will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool Employee__ReturnsNewIfNotFound
		{
			get	{ return _employee__ReturnsNewIfNotFound; }
			set { _employee__ReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity; }
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
