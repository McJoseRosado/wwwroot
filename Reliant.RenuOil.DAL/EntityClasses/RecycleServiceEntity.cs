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
	/// Entity class which represents the entity 'RecycleService'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class RecycleServiceEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection	_recycleServiceAction;
		private bool	_alwaysFetchRecycleServiceAction, _alreadyFetchedRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection	_recycleServiceChangeLog;
		private bool	_alwaysFetchRecycleServiceChangeLog, _alreadyFetchedRecycleServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaRecycleServiceChangeLog;
		private bool	_alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog, _alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchEmployeeCollectionViaRecycleServiceAction, _alreadyFetchedEmployeeCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaRecycleServiceAction_;
		private bool	_alwaysFetchEmployeeCollectionViaRecycleServiceAction_, _alreadyFetchedEmployeeCollectionViaRecycleServiceAction_;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection _recycleTypeCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction, _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRecycleServiceChangeLog;
		private bool	_alwaysFetchUserCollectionViaRecycleServiceChangeLog, _alreadyFetchedUserCollectionViaRecycleServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRecycleServiceAction;
		private bool	_alwaysFetchUserCollectionViaRecycleServiceAction, _alreadyFetchedUserCollectionViaRecycleServiceAction;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRecycleServiceAction_;
		private bool	_alwaysFetchUserCollectionViaRecycleServiceAction_, _alreadyFetchedUserCollectionViaRecycleServiceAction_;
		private WorkOrderEmployeeEntity _workOrderEmployee;
		private bool	_alwaysFetchWorkOrderEmployee, _alreadyFetchedWorkOrderEmployee, _workOrderEmployeeReturnsNewIfNotFound;
		private WorkOrderServiceLocationEntity _workOrderServiceLocation;
		private bool	_alwaysFetchWorkOrderServiceLocation, _alreadyFetchedWorkOrderServiceLocation, _workOrderServiceLocationReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name WorkOrderEmployee</summary>
			public static readonly string WorkOrderEmployee = "WorkOrderEmployee";
			/// <summary>Member name WorkOrderServiceLocation</summary>
			public static readonly string WorkOrderServiceLocation = "WorkOrderServiceLocation";
			/// <summary>Member name RecycleServiceAction</summary>
			public static readonly string RecycleServiceAction = "RecycleServiceAction";
			/// <summary>Member name RecycleServiceChangeLog</summary>
			public static readonly string RecycleServiceChangeLog = "RecycleServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceChangeLog</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceChangeLog = "EmployeeCollectionViaRecycleServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceAction</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceAction = "EmployeeCollectionViaRecycleServiceAction";
			/// <summary>Member name EmployeeCollectionViaRecycleServiceAction_</summary>
			public static readonly string EmployeeCollectionViaRecycleServiceAction_ = "EmployeeCollectionViaRecycleServiceAction_";
			/// <summary>Member name RecycleTypeCollectionViaRecycleServiceAction</summary>
			public static readonly string RecycleTypeCollectionViaRecycleServiceAction = "RecycleTypeCollectionViaRecycleServiceAction";
			/// <summary>Member name UserCollectionViaRecycleServiceChangeLog</summary>
			public static readonly string UserCollectionViaRecycleServiceChangeLog = "UserCollectionViaRecycleServiceChangeLog";
			/// <summary>Member name UserCollectionViaRecycleServiceAction</summary>
			public static readonly string UserCollectionViaRecycleServiceAction = "UserCollectionViaRecycleServiceAction";
			/// <summary>Member name UserCollectionViaRecycleServiceAction_</summary>
			public static readonly string UserCollectionViaRecycleServiceAction_ = "UserCollectionViaRecycleServiceAction_";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RecycleServiceEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public RecycleServiceEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		public RecycleServiceEntity(System.Int32 recycleServiceId)
		{
			InitClassFetch(recycleServiceId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public RecycleServiceEntity(System.Int32 recycleServiceId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(recycleServiceId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		/// <param name="validator">The custom validator object for this RecycleServiceEntity</param>
		public RecycleServiceEntity(System.Int32 recycleServiceId, IValidator validator)
		{
			InitClassFetch(recycleServiceId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RecycleServiceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_recycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection)info.GetValue("_recycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection));
			_alwaysFetchRecycleServiceAction = info.GetBoolean("_alwaysFetchRecycleServiceAction");
			_alreadyFetchedRecycleServiceAction = info.GetBoolean("_alreadyFetchedRecycleServiceAction");
			_recycleServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection)info.GetValue("_recycleServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection));
			_alwaysFetchRecycleServiceChangeLog = info.GetBoolean("_alwaysFetchRecycleServiceChangeLog");
			_alreadyFetchedRecycleServiceChangeLog = info.GetBoolean("_alreadyFetchedRecycleServiceChangeLog");
			_employeeCollectionViaRecycleServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaRecycleServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog");
			_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog");
			_employeeCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchEmployeeCollectionViaRecycleServiceAction");
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction");
			_employeeCollectionViaRecycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaRecycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction_ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaRecycleServiceAction_");
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_");
			_recycleTypeCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection)info.GetValue("_recycleTypeCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection));
			_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction");
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction");
			_userCollectionViaRecycleServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRecycleServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alwaysFetchUserCollectionViaRecycleServiceChangeLog");
			_alreadyFetchedUserCollectionViaRecycleServiceChangeLog = info.GetBoolean("_alreadyFetchedUserCollectionViaRecycleServiceChangeLog");
			_userCollectionViaRecycleServiceAction = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRecycleServiceAction", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRecycleServiceAction = info.GetBoolean("_alwaysFetchUserCollectionViaRecycleServiceAction");
			_alreadyFetchedUserCollectionViaRecycleServiceAction = info.GetBoolean("_alreadyFetchedUserCollectionViaRecycleServiceAction");
			_userCollectionViaRecycleServiceAction_ = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRecycleServiceAction_", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRecycleServiceAction_ = info.GetBoolean("_alwaysFetchUserCollectionViaRecycleServiceAction_");
			_alreadyFetchedUserCollectionViaRecycleServiceAction_ = info.GetBoolean("_alreadyFetchedUserCollectionViaRecycleServiceAction_");
			_workOrderEmployee = (WorkOrderEmployeeEntity)info.GetValue("_workOrderEmployee", typeof(WorkOrderEmployeeEntity));
			if(_workOrderEmployee!=null)
			{
				_workOrderEmployee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_workOrderEmployeeReturnsNewIfNotFound = info.GetBoolean("_workOrderEmployeeReturnsNewIfNotFound");
			_alwaysFetchWorkOrderEmployee = info.GetBoolean("_alwaysFetchWorkOrderEmployee");
			_alreadyFetchedWorkOrderEmployee = info.GetBoolean("_alreadyFetchedWorkOrderEmployee");
			_workOrderServiceLocation = (WorkOrderServiceLocationEntity)info.GetValue("_workOrderServiceLocation", typeof(WorkOrderServiceLocationEntity));
			if(_workOrderServiceLocation!=null)
			{
				_workOrderServiceLocation.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_workOrderServiceLocationReturnsNewIfNotFound = info.GetBoolean("_workOrderServiceLocationReturnsNewIfNotFound");
			_alwaysFetchWorkOrderServiceLocation = info.GetBoolean("_alwaysFetchWorkOrderServiceLocation");
			_alreadyFetchedWorkOrderServiceLocation = info.GetBoolean("_alreadyFetchedWorkOrderServiceLocation");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((RecycleServiceFieldIndex)fieldIndex)
			{
				case RecycleServiceFieldIndex.WorkOrderServiceLocationId:
					DesetupSyncWorkOrderEmployee(true, false);
					_alreadyFetchedWorkOrderEmployee = false;
					DesetupSyncWorkOrderServiceLocation(true, false);
					_alreadyFetchedWorkOrderServiceLocation = false;
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
			_alreadyFetchedRecycleServiceAction = (_recycleServiceAction.Count > 0);
			_alreadyFetchedRecycleServiceChangeLog = (_recycleServiceChangeLog.Count > 0);
			_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog = (_employeeCollectionViaRecycleServiceChangeLog.Count > 0);
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = (_employeeCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = (_employeeCollectionViaRecycleServiceAction_.Count > 0);
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = (_recycleTypeCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedUserCollectionViaRecycleServiceChangeLog = (_userCollectionViaRecycleServiceChangeLog.Count > 0);
			_alreadyFetchedUserCollectionViaRecycleServiceAction = (_userCollectionViaRecycleServiceAction.Count > 0);
			_alreadyFetchedUserCollectionViaRecycleServiceAction_ = (_userCollectionViaRecycleServiceAction_.Count > 0);
			_alreadyFetchedWorkOrderEmployee = (_workOrderEmployee != null);
			_alreadyFetchedWorkOrderServiceLocation = (_workOrderServiceLocation != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return RecycleServiceEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "WorkOrderEmployee":
					toReturn.Add(RecycleServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);
					break;
				case "WorkOrderServiceLocation":
					toReturn.Add(RecycleServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);
					break;
				case "RecycleServiceAction":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId);
					break;
				case "RecycleServiceChangeLog":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceChangeLogEntityUsingRecycleServiceId);
					break;
				case "EmployeeCollectionViaRecycleServiceChangeLog":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceChangeLogEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceChangeLog_", JoinHint.None);
					toReturn.Add(RecycleServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, "RecycleServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceAction":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingLastChangedByEmployeeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaRecycleServiceAction_":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.EmployeeEntityUsingActionEmployeeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceChangeLog":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceChangeLogEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceChangeLog_", JoinHint.None);
					toReturn.Add(RecycleServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "RecycleServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceAction":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingActionUserId, "RecycleServiceAction_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRecycleServiceAction_":
					toReturn.Add(RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId, "RecycleServiceEntity__", "RecycleServiceAction_", JoinHint.None);
					toReturn.Add(RecycleServiceActionEntity.Relations.UserEntityUsingLastChangedByUserId, "RecycleServiceAction_", string.Empty, JoinHint.None);
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
			info.AddValue("_recycleServiceAction", (!this.MarkedForDeletion?_recycleServiceAction:null));
			info.AddValue("_alwaysFetchRecycleServiceAction", _alwaysFetchRecycleServiceAction);
			info.AddValue("_alreadyFetchedRecycleServiceAction", _alreadyFetchedRecycleServiceAction);
			info.AddValue("_recycleServiceChangeLog", (!this.MarkedForDeletion?_recycleServiceChangeLog:null));
			info.AddValue("_alwaysFetchRecycleServiceChangeLog", _alwaysFetchRecycleServiceChangeLog);
			info.AddValue("_alreadyFetchedRecycleServiceChangeLog", _alreadyFetchedRecycleServiceChangeLog);
			info.AddValue("_employeeCollectionViaRecycleServiceChangeLog", (!this.MarkedForDeletion?_employeeCollectionViaRecycleServiceChangeLog:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog", _alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog", _alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog);
			info.AddValue("_employeeCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_employeeCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaRecycleServiceAction", _alwaysFetchEmployeeCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction", _alreadyFetchedEmployeeCollectionViaRecycleServiceAction);
			info.AddValue("_employeeCollectionViaRecycleServiceAction_", (!this.MarkedForDeletion?_employeeCollectionViaRecycleServiceAction_:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaRecycleServiceAction_", _alwaysFetchEmployeeCollectionViaRecycleServiceAction_);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_", _alreadyFetchedEmployeeCollectionViaRecycleServiceAction_);
			info.AddValue("_recycleTypeCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_recycleTypeCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction", _alwaysFetchRecycleTypeCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction", _alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction);
			info.AddValue("_userCollectionViaRecycleServiceChangeLog", (!this.MarkedForDeletion?_userCollectionViaRecycleServiceChangeLog:null));
			info.AddValue("_alwaysFetchUserCollectionViaRecycleServiceChangeLog", _alwaysFetchUserCollectionViaRecycleServiceChangeLog);
			info.AddValue("_alreadyFetchedUserCollectionViaRecycleServiceChangeLog", _alreadyFetchedUserCollectionViaRecycleServiceChangeLog);
			info.AddValue("_userCollectionViaRecycleServiceAction", (!this.MarkedForDeletion?_userCollectionViaRecycleServiceAction:null));
			info.AddValue("_alwaysFetchUserCollectionViaRecycleServiceAction", _alwaysFetchUserCollectionViaRecycleServiceAction);
			info.AddValue("_alreadyFetchedUserCollectionViaRecycleServiceAction", _alreadyFetchedUserCollectionViaRecycleServiceAction);
			info.AddValue("_userCollectionViaRecycleServiceAction_", (!this.MarkedForDeletion?_userCollectionViaRecycleServiceAction_:null));
			info.AddValue("_alwaysFetchUserCollectionViaRecycleServiceAction_", _alwaysFetchUserCollectionViaRecycleServiceAction_);
			info.AddValue("_alreadyFetchedUserCollectionViaRecycleServiceAction_", _alreadyFetchedUserCollectionViaRecycleServiceAction_);
			info.AddValue("_workOrderEmployee", (!this.MarkedForDeletion?_workOrderEmployee:null));
			info.AddValue("_workOrderEmployeeReturnsNewIfNotFound", _workOrderEmployeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchWorkOrderEmployee", _alwaysFetchWorkOrderEmployee);
			info.AddValue("_alreadyFetchedWorkOrderEmployee", _alreadyFetchedWorkOrderEmployee);
			info.AddValue("_workOrderServiceLocation", (!this.MarkedForDeletion?_workOrderServiceLocation:null));
			info.AddValue("_workOrderServiceLocationReturnsNewIfNotFound", _workOrderServiceLocationReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchWorkOrderServiceLocation", _alwaysFetchWorkOrderServiceLocation);
			info.AddValue("_alreadyFetchedWorkOrderServiceLocation", _alreadyFetchedWorkOrderServiceLocation);

			
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
				case "WorkOrderEmployee":
					_alreadyFetchedWorkOrderEmployee = true;
					this.WorkOrderEmployee = (WorkOrderEmployeeEntity)entity;
					break;
				case "WorkOrderServiceLocation":
					_alreadyFetchedWorkOrderServiceLocation = true;
					this.WorkOrderServiceLocation = (WorkOrderServiceLocationEntity)entity;
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
				case "EmployeeCollectionViaRecycleServiceChangeLog":
					_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaRecycleServiceChangeLog.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaRecycleServiceAction":
					_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaRecycleServiceAction.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaRecycleServiceAction_":
					_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaRecycleServiceAction_.Add((EmployeeEntity)entity);
					}
					break;
				case "RecycleTypeCollectionViaRecycleServiceAction":
					_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = true;
					if(entity!=null)
					{
						this.RecycleTypeCollectionViaRecycleServiceAction.Add((RecycleTypeEntity)entity);
					}
					break;
				case "UserCollectionViaRecycleServiceChangeLog":
					_alreadyFetchedUserCollectionViaRecycleServiceChangeLog = true;
					if(entity!=null)
					{
						this.UserCollectionViaRecycleServiceChangeLog.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaRecycleServiceAction":
					_alreadyFetchedUserCollectionViaRecycleServiceAction = true;
					if(entity!=null)
					{
						this.UserCollectionViaRecycleServiceAction.Add((UserEntity)entity);
					}
					break;
				case "UserCollectionViaRecycleServiceAction_":
					_alreadyFetchedUserCollectionViaRecycleServiceAction_ = true;
					if(entity!=null)
					{
						this.UserCollectionViaRecycleServiceAction_.Add((UserEntity)entity);
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
				case "WorkOrderEmployee":
					SetupSyncWorkOrderEmployee(relatedEntity);
					break;
				case "WorkOrderServiceLocation":
					SetupSyncWorkOrderServiceLocation(relatedEntity);
					break;
				case "RecycleServiceAction":
					_recycleServiceAction.Add((RecycleServiceActionEntity)relatedEntity);
					break;
				case "RecycleServiceChangeLog":
					_recycleServiceChangeLog.Add((RecycleServiceChangeLogEntity)relatedEntity);
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
				case "WorkOrderEmployee":
					DesetupSyncWorkOrderEmployee(false, true);
					break;
				case "WorkOrderServiceLocation":
					DesetupSyncWorkOrderServiceLocation(false, true);
					break;
				case "RecycleServiceAction":
					base.PerformRelatedEntityRemoval(_recycleServiceAction, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleServiceChangeLog":
					base.PerformRelatedEntityRemoval(_recycleServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_workOrderEmployee!=null)
			{
				toReturn.Add(_workOrderEmployee);
			}
			if(_workOrderServiceLocation!=null)
			{
				toReturn.Add(_workOrderServiceLocation);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_recycleServiceAction);
			toReturn.Add(_recycleServiceChangeLog);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleServiceId)
		{
			return FetchUsingPK(recycleServiceId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleServiceId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(recycleServiceId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(recycleServiceId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 recycleServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(recycleServiceId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.RecycleServiceId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(RecycleServiceFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(RecycleServiceFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new RecycleServiceRelations().GetAllRelations();
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
				_recycleServiceAction.GetMultiManyToOne(null, null, this, null, null, null, filter);
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
				_recycleServiceChangeLog.GetMultiManyToOne(null, this, null, filter);
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
				filter.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RecycleServiceFields.RecycleServiceId, ComparisonOperator.Equal, this.RecycleServiceId, "RecycleServiceEntity__"));
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

		/// <summary> Retrieves the related entity of type 'WorkOrderEmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'WorkOrderEmployeeEntity' which is related to this entity.</returns>
		public WorkOrderEmployeeEntity GetSingleWorkOrderEmployee()
		{
			return GetSingleWorkOrderEmployee(false);
		}

		/// <summary> Retrieves the related entity of type 'WorkOrderEmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'WorkOrderEmployeeEntity' which is related to this entity.</returns>
		public virtual WorkOrderEmployeeEntity GetSingleWorkOrderEmployee(bool forceFetch)
		{
			if( ( !_alreadyFetchedWorkOrderEmployee || forceFetch || _alwaysFetchWorkOrderEmployee) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);

				WorkOrderEmployeeEntity newEntity = new WorkOrderEmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.WorkOrderServiceLocationId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (WorkOrderEmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.WorkOrderEmployee = newEntity;
				}
				else
				{
					if(_workOrderEmployeeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_workOrderEmployee == null)))
						{
							this.WorkOrderEmployee = newEntity;
						}
					}
					else
					{
						this.WorkOrderEmployee = null;
					}
				}
				_alreadyFetchedWorkOrderEmployee = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _workOrderEmployee;
		}

		/// <summary> Retrieves the related entity of type 'WorkOrderServiceLocationEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'WorkOrderServiceLocationEntity' which is related to this entity.</returns>
		public WorkOrderServiceLocationEntity GetSingleWorkOrderServiceLocation()
		{
			return GetSingleWorkOrderServiceLocation(false);
		}

		/// <summary> Retrieves the related entity of type 'WorkOrderServiceLocationEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'WorkOrderServiceLocationEntity' which is related to this entity.</returns>
		public virtual WorkOrderServiceLocationEntity GetSingleWorkOrderServiceLocation(bool forceFetch)
		{
			if( ( !_alreadyFetchedWorkOrderServiceLocation || forceFetch || _alwaysFetchWorkOrderServiceLocation) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(RecycleServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);

				WorkOrderServiceLocationEntity newEntity = new WorkOrderServiceLocationEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.WorkOrderServiceLocationId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (WorkOrderServiceLocationEntity)base.ActiveContext.Get(newEntity);
					}
					this.WorkOrderServiceLocation = newEntity;
				}
				else
				{
					if(_workOrderServiceLocationReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_workOrderServiceLocation == null)))
						{
							this.WorkOrderServiceLocation = newEntity;
						}
					}
					else
					{
						this.WorkOrderServiceLocation = null;
					}
				}
				_alreadyFetchedWorkOrderServiceLocation = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _workOrderServiceLocation;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			RecycleServiceDAO dao = (RecycleServiceDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_recycleServiceAction.ActiveContext = base.ActiveContext;
			_recycleServiceChangeLog.ActiveContext = base.ActiveContext;
			_employeeCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			_employeeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_employeeCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			_recycleTypeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_userCollectionViaRecycleServiceChangeLog.ActiveContext = base.ActiveContext;
			_userCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			_userCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			if(_workOrderEmployee!=null)
			{
				_workOrderEmployee.ActiveContext = base.ActiveContext;
			}
			if(_workOrderServiceLocation!=null)
			{
				_workOrderServiceLocation.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			RecycleServiceDAO dao = (RecycleServiceDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			RecycleServiceDAO dao = (RecycleServiceDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity);
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
			toReturn.Add("WorkOrderEmployee", _workOrderEmployee);
			toReturn.Add("WorkOrderServiceLocation", _workOrderServiceLocation);
			toReturn.Add("RecycleServiceAction", _recycleServiceAction);
			toReturn.Add("RecycleServiceChangeLog", _recycleServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaRecycleServiceChangeLog", _employeeCollectionViaRecycleServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaRecycleServiceAction", _employeeCollectionViaRecycleServiceAction);
			toReturn.Add("EmployeeCollectionViaRecycleServiceAction_", _employeeCollectionViaRecycleServiceAction_);
			toReturn.Add("RecycleTypeCollectionViaRecycleServiceAction", _recycleTypeCollectionViaRecycleServiceAction);
			toReturn.Add("UserCollectionViaRecycleServiceChangeLog", _userCollectionViaRecycleServiceChangeLog);
			toReturn.Add("UserCollectionViaRecycleServiceAction", _userCollectionViaRecycleServiceAction);
			toReturn.Add("UserCollectionViaRecycleServiceAction_", _userCollectionViaRecycleServiceAction_);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		/// <param name="validator">The validator object for this RecycleServiceEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 recycleServiceId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(recycleServiceId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_recycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection(new RecycleServiceActionEntityFactory());
			_recycleServiceAction.SetContainingEntityInfo(this, "RecycleService");
			_alwaysFetchRecycleServiceAction = false;
			_alreadyFetchedRecycleServiceAction = false;
			_recycleServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceChangeLogCollection(new RecycleServiceChangeLogEntityFactory());
			_recycleServiceChangeLog.SetContainingEntityInfo(this, "RecycleService");
			_alwaysFetchRecycleServiceChangeLog = false;
			_alreadyFetchedRecycleServiceChangeLog = false;
			_employeeCollectionViaRecycleServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaRecycleServiceChangeLog = false;
			_alreadyFetchedEmployeeCollectionViaRecycleServiceChangeLog = false;
			_employeeCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction = false;
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction = false;
			_employeeCollectionViaRecycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaRecycleServiceAction_ = false;
			_alreadyFetchedEmployeeCollectionViaRecycleServiceAction_ = false;
			_recycleTypeCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(new RecycleTypeEntityFactory());
			_alwaysFetchRecycleTypeCollectionViaRecycleServiceAction = false;
			_alreadyFetchedRecycleTypeCollectionViaRecycleServiceAction = false;
			_userCollectionViaRecycleServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRecycleServiceChangeLog = false;
			_alreadyFetchedUserCollectionViaRecycleServiceChangeLog = false;
			_userCollectionViaRecycleServiceAction = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRecycleServiceAction = false;
			_alreadyFetchedUserCollectionViaRecycleServiceAction = false;
			_userCollectionViaRecycleServiceAction_ = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRecycleServiceAction_ = false;
			_alreadyFetchedUserCollectionViaRecycleServiceAction_ = false;
			_workOrderEmployee = null;
			_workOrderEmployeeReturnsNewIfNotFound = true;
			_alwaysFetchWorkOrderEmployee = false;
			_alreadyFetchedWorkOrderEmployee = false;
			_workOrderServiceLocation = null;
			_workOrderServiceLocationReturnsNewIfNotFound = true;
			_alwaysFetchWorkOrderServiceLocation = false;
			_alreadyFetchedWorkOrderServiceLocation = false;


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

			_fieldsCustomProperties.Add("RecycleServiceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("WorkOrderServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NumberOfBales", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NumberOfBags", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("BalesWeight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("BagsWeight", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _workOrderEmployee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrderEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", RecycleServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "RecycleService", resetFKFields, new int[] { (int)RecycleServiceFieldIndex.WorkOrderServiceLocationId } );		
			_workOrderEmployee = null;
		}
		
		/// <summary> setups the sync logic for member _workOrderEmployee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrderEmployee(IEntity relatedEntity)
		{
			if(_workOrderEmployee!=relatedEntity)
			{		
				DesetupSyncWorkOrderEmployee(true, true);
				_workOrderEmployee = (WorkOrderEmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", RecycleServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, ref _alreadyFetchedWorkOrderEmployee, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWorkOrderEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _workOrderServiceLocation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrderServiceLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", RecycleServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "RecycleService", resetFKFields, new int[] { (int)RecycleServiceFieldIndex.WorkOrderServiceLocationId } );		
			_workOrderServiceLocation = null;
		}
		
		/// <summary> setups the sync logic for member _workOrderServiceLocation</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrderServiceLocation(IEntity relatedEntity)
		{
			if(_workOrderServiceLocation!=relatedEntity)
			{		
				DesetupSyncWorkOrderServiceLocation(true, true);
				_workOrderServiceLocation = (WorkOrderServiceLocationEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", RecycleServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, ref _alreadyFetchedWorkOrderServiceLocation, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWorkOrderServiceLocationPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="recycleServiceId">PK value for RecycleService which data should be fetched into this RecycleService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 recycleServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)RecycleServiceFieldIndex.RecycleServiceId].ForcedCurrentValueWrite(recycleServiceId);
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
			return DAOFactory.CreateRecycleServiceDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new RecycleServiceEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static RecycleServiceRelations Relations
		{
			get	{ return new RecycleServiceRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleServiceAction' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleServiceAction
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceActionCollection(),
					(IEntityRelation)GetRelationsForField("RecycleServiceAction")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, "RecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("RecycleServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceChangeLogEntity, 0, null, null, null, "RecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceChangeLogEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceChangeLog"), "EmployeeCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction"), "EmployeeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction_"), "EmployeeCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleTypeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleServiceAction"), "RecycleTypeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRecycleServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceChangeLogEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceChangeLog"), "UserCollectionViaRecycleServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction"), "UserCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleServiceEntity.Relations.RecycleServiceActionEntityUsingRecycleServiceId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction_"), "UserCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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
					(IEntityRelation)GetRelationsForField("WorkOrderEmployee")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, null, "WorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("WorkOrderServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, null, "WorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "RecycleServiceEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return RecycleServiceEntity.CustomProperties;}
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
			get { return RecycleServiceEntity.FieldsCustomProperties;}
		}

		/// <summary> The RecycleServiceId property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."RecycleServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 RecycleServiceId
		{
			get { return (System.Int32)GetValue((int)RecycleServiceFieldIndex.RecycleServiceId, true); }
			set	{ SetValue((int)RecycleServiceFieldIndex.RecycleServiceId, value, true); }
		}
		/// <summary> The WorkOrderServiceLocationId property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."WorkOrderServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 WorkOrderServiceLocationId
		{
			get { return (System.Int32)GetValue((int)RecycleServiceFieldIndex.WorkOrderServiceLocationId, true); }
			set	{ SetValue((int)RecycleServiceFieldIndex.WorkOrderServiceLocationId, value, true); }
		}
		/// <summary> The NumberOfBales property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."NumberOfBales"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> NumberOfBales
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceFieldIndex.NumberOfBales, false); }
			set	{ SetValue((int)RecycleServiceFieldIndex.NumberOfBales, value, true); }
		}
		/// <summary> The NumberOfBags property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."NumberOfBags"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> NumberOfBags
		{
			get { return (Nullable<System.Int32>)GetValue((int)RecycleServiceFieldIndex.NumberOfBags, false); }
			set	{ SetValue((int)RecycleServiceFieldIndex.NumberOfBags, value, true); }
		}
		/// <summary> The BalesWeight property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."BalesWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> BalesWeight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RecycleServiceFieldIndex.BalesWeight, false); }
			set	{ SetValue((int)RecycleServiceFieldIndex.BalesWeight, value, true); }
		}
		/// <summary> The BagsWeight property of the Entity RecycleService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleService"."BagsWeight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> BagsWeight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RecycleServiceFieldIndex.BagsWeight, false); }
			set	{ SetValue((int)RecycleServiceFieldIndex.BagsWeight, value, true); }
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

		/// <summary> Gets / sets related entity of type 'WorkOrderEmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleWorkOrderEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual WorkOrderEmployeeEntity WorkOrderEmployee
		{
			get	{ return GetSingleWorkOrderEmployee(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncWorkOrderEmployee(value);
				}
				else
				{
					if(value==null)
					{
						if(_workOrderEmployee != null)
						{
							_workOrderEmployee.UnsetRelatedEntity(this, "RecycleService");
						}
					}
					else
					{
						if(_workOrderEmployee!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderEmployee. When set to true, WorkOrderEmployee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderEmployee is accessed. You can always execute
		/// a forced fetch by calling GetSingleWorkOrderEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderEmployee
		{
			get	{ return _alwaysFetchWorkOrderEmployee; }
			set	{ _alwaysFetchWorkOrderEmployee = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderEmployee already has been fetched. Setting this property to false when WorkOrderEmployee has been fetched
		/// will set WorkOrderEmployee to null as well. Setting this property to true while WorkOrderEmployee hasn't been fetched disables lazy loading for WorkOrderEmployee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderEmployee
		{
			get { return _alreadyFetchedWorkOrderEmployee;}
			set 
			{
				if(_alreadyFetchedWorkOrderEmployee && !value)
				{
					this.WorkOrderEmployee = null;
				}
				_alreadyFetchedWorkOrderEmployee = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property WorkOrderEmployee is not found
		/// in the database. When set to true, WorkOrderEmployee will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool WorkOrderEmployeeReturnsNewIfNotFound
		{
			get	{ return _workOrderEmployeeReturnsNewIfNotFound; }
			set { _workOrderEmployeeReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'WorkOrderServiceLocationEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleWorkOrderServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual WorkOrderServiceLocationEntity WorkOrderServiceLocation
		{
			get	{ return GetSingleWorkOrderServiceLocation(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncWorkOrderServiceLocation(value);
				}
				else
				{
					if(value==null)
					{
						if(_workOrderServiceLocation != null)
						{
							_workOrderServiceLocation.UnsetRelatedEntity(this, "RecycleService");
						}
					}
					else
					{
						if(_workOrderServiceLocation!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "RecycleService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderServiceLocation. When set to true, WorkOrderServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetSingleWorkOrderServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderServiceLocation
		{
			get	{ return _alwaysFetchWorkOrderServiceLocation; }
			set	{ _alwaysFetchWorkOrderServiceLocation = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderServiceLocation already has been fetched. Setting this property to false when WorkOrderServiceLocation has been fetched
		/// will set WorkOrderServiceLocation to null as well. Setting this property to true while WorkOrderServiceLocation hasn't been fetched disables lazy loading for WorkOrderServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderServiceLocation
		{
			get { return _alreadyFetchedWorkOrderServiceLocation;}
			set 
			{
				if(_alreadyFetchedWorkOrderServiceLocation && !value)
				{
					this.WorkOrderServiceLocation = null;
				}
				_alreadyFetchedWorkOrderServiceLocation = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property WorkOrderServiceLocation is not found
		/// in the database. When set to true, WorkOrderServiceLocation will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool WorkOrderServiceLocationReturnsNewIfNotFound
		{
			get	{ return _workOrderServiceLocationReturnsNewIfNotFound; }
			set { _workOrderServiceLocationReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity; }
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
