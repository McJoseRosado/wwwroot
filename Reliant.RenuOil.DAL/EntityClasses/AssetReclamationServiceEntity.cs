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
	/// Entity class which represents the entity 'AssetReclamationService'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AssetReclamationServiceEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection	_assetReclamationServiceChangeLog;
		private bool	_alwaysFetchAssetReclamationServiceChangeLog, _alreadyFetchedAssetReclamationServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaAssetReclamationServiceChangeLog;
		private bool	_alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog, _alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaAssetReclamationServiceChangeLog;
		private bool	_alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog, _alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog;
		private ServiceLocationAssetTypeEntity _serviceLocationAssetType;
		private bool	_alwaysFetchServiceLocationAssetType, _alreadyFetchedServiceLocationAssetType, _serviceLocationAssetTypeReturnsNewIfNotFound;
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
			/// <summary>Member name ServiceLocationAssetType</summary>
			public static readonly string ServiceLocationAssetType = "ServiceLocationAssetType";
			/// <summary>Member name WorkOrderEmployee</summary>
			public static readonly string WorkOrderEmployee = "WorkOrderEmployee";
			/// <summary>Member name WorkOrderServiceLocation</summary>
			public static readonly string WorkOrderServiceLocation = "WorkOrderServiceLocation";
			/// <summary>Member name AssetReclamationServiceChangeLog</summary>
			public static readonly string AssetReclamationServiceChangeLog = "AssetReclamationServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaAssetReclamationServiceChangeLog</summary>
			public static readonly string EmployeeCollectionViaAssetReclamationServiceChangeLog = "EmployeeCollectionViaAssetReclamationServiceChangeLog";
			/// <summary>Member name UserCollectionViaAssetReclamationServiceChangeLog</summary>
			public static readonly string UserCollectionViaAssetReclamationServiceChangeLog = "UserCollectionViaAssetReclamationServiceChangeLog";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AssetReclamationServiceEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AssetReclamationServiceEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		public AssetReclamationServiceEntity(System.Int32 assetReclamationServiceId)
		{
			InitClassFetch(assetReclamationServiceId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AssetReclamationServiceEntity(System.Int32 assetReclamationServiceId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(assetReclamationServiceId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		/// <param name="validator">The custom validator object for this AssetReclamationServiceEntity</param>
		public AssetReclamationServiceEntity(System.Int32 assetReclamationServiceId, IValidator validator)
		{
			InitClassFetch(assetReclamationServiceId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AssetReclamationServiceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_assetReclamationServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection)info.GetValue("_assetReclamationServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection));
			_alwaysFetchAssetReclamationServiceChangeLog = info.GetBoolean("_alwaysFetchAssetReclamationServiceChangeLog");
			_alreadyFetchedAssetReclamationServiceChangeLog = info.GetBoolean("_alreadyFetchedAssetReclamationServiceChangeLog");
			_employeeCollectionViaAssetReclamationServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaAssetReclamationServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog");
			_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog");
			_userCollectionViaAssetReclamationServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaAssetReclamationServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog");
			_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog = info.GetBoolean("_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog");
			_serviceLocationAssetType = (ServiceLocationAssetTypeEntity)info.GetValue("_serviceLocationAssetType", typeof(ServiceLocationAssetTypeEntity));
			if(_serviceLocationAssetType!=null)
			{
				_serviceLocationAssetType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_serviceLocationAssetTypeReturnsNewIfNotFound = info.GetBoolean("_serviceLocationAssetTypeReturnsNewIfNotFound");
			_alwaysFetchServiceLocationAssetType = info.GetBoolean("_alwaysFetchServiceLocationAssetType");
			_alreadyFetchedServiceLocationAssetType = info.GetBoolean("_alreadyFetchedServiceLocationAssetType");
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
			switch((AssetReclamationServiceFieldIndex)fieldIndex)
			{
				case AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId:
					DesetupSyncWorkOrderEmployee(true, false);
					_alreadyFetchedWorkOrderEmployee = false;
					DesetupSyncWorkOrderServiceLocation(true, false);
					_alreadyFetchedWorkOrderServiceLocation = false;
					break;
				case AssetReclamationServiceFieldIndex.ServiceLocationAssetTypeId:
					DesetupSyncServiceLocationAssetType(true, false);
					_alreadyFetchedServiceLocationAssetType = false;
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
			_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog = (_employeeCollectionViaAssetReclamationServiceChangeLog.Count > 0);
			_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog = (_userCollectionViaAssetReclamationServiceChangeLog.Count > 0);
			_alreadyFetchedServiceLocationAssetType = (_serviceLocationAssetType != null);
			_alreadyFetchedWorkOrderEmployee = (_workOrderEmployee != null);
			_alreadyFetchedWorkOrderServiceLocation = (_workOrderServiceLocation != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return AssetReclamationServiceEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ServiceLocationAssetType":
					toReturn.Add(AssetReclamationServiceEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId);
					break;
				case "WorkOrderEmployee":
					toReturn.Add(AssetReclamationServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);
					break;
				case "WorkOrderServiceLocation":
					toReturn.Add(AssetReclamationServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);
					break;
				case "AssetReclamationServiceChangeLog":
					toReturn.Add(AssetReclamationServiceEntity.Relations.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId);
					break;
				case "EmployeeCollectionViaAssetReclamationServiceChangeLog":
					toReturn.Add(AssetReclamationServiceEntity.Relations.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId, "AssetReclamationServiceEntity__", "AssetReclamationServiceChangeLog_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, "AssetReclamationServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaAssetReclamationServiceChangeLog":
					toReturn.Add(AssetReclamationServiceEntity.Relations.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId, "AssetReclamationServiceEntity__", "AssetReclamationServiceChangeLog_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "AssetReclamationServiceChangeLog_", string.Empty, JoinHint.None);
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
			info.AddValue("_employeeCollectionViaAssetReclamationServiceChangeLog", (!this.MarkedForDeletion?_employeeCollectionViaAssetReclamationServiceChangeLog:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog", _alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog", _alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_userCollectionViaAssetReclamationServiceChangeLog", (!this.MarkedForDeletion?_userCollectionViaAssetReclamationServiceChangeLog:null));
			info.AddValue("_alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog", _alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog", _alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog);
			info.AddValue("_serviceLocationAssetType", (!this.MarkedForDeletion?_serviceLocationAssetType:null));
			info.AddValue("_serviceLocationAssetTypeReturnsNewIfNotFound", _serviceLocationAssetTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchServiceLocationAssetType", _alwaysFetchServiceLocationAssetType);
			info.AddValue("_alreadyFetchedServiceLocationAssetType", _alreadyFetchedServiceLocationAssetType);
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
				case "ServiceLocationAssetType":
					_alreadyFetchedServiceLocationAssetType = true;
					this.ServiceLocationAssetType = (ServiceLocationAssetTypeEntity)entity;
					break;
				case "WorkOrderEmployee":
					_alreadyFetchedWorkOrderEmployee = true;
					this.WorkOrderEmployee = (WorkOrderEmployeeEntity)entity;
					break;
				case "WorkOrderServiceLocation":
					_alreadyFetchedWorkOrderServiceLocation = true;
					this.WorkOrderServiceLocation = (WorkOrderServiceLocationEntity)entity;
					break;
				case "AssetReclamationServiceChangeLog":
					_alreadyFetchedAssetReclamationServiceChangeLog = true;
					if(entity!=null)
					{
						this.AssetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)entity);
					}
					break;
				case "EmployeeCollectionViaAssetReclamationServiceChangeLog":
					_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaAssetReclamationServiceChangeLog.Add((EmployeeEntity)entity);
					}
					break;
				case "UserCollectionViaAssetReclamationServiceChangeLog":
					_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog = true;
					if(entity!=null)
					{
						this.UserCollectionViaAssetReclamationServiceChangeLog.Add((UserEntity)entity);
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
				case "ServiceLocationAssetType":
					SetupSyncServiceLocationAssetType(relatedEntity);
					break;
				case "WorkOrderEmployee":
					SetupSyncWorkOrderEmployee(relatedEntity);
					break;
				case "WorkOrderServiceLocation":
					SetupSyncWorkOrderServiceLocation(relatedEntity);
					break;
				case "AssetReclamationServiceChangeLog":
					_assetReclamationServiceChangeLog.Add((AssetReclamationServiceChangeLogEntity)relatedEntity);
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
				case "ServiceLocationAssetType":
					DesetupSyncServiceLocationAssetType(false, true);
					break;
				case "WorkOrderEmployee":
					DesetupSyncWorkOrderEmployee(false, true);
					break;
				case "WorkOrderServiceLocation":
					DesetupSyncWorkOrderServiceLocation(false, true);
					break;
				case "AssetReclamationServiceChangeLog":
					base.PerformRelatedEntityRemoval(_assetReclamationServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_serviceLocationAssetType!=null)
			{
				toReturn.Add(_serviceLocationAssetType);
			}
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
			toReturn.Add(_assetReclamationServiceChangeLog);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 assetReclamationServiceId)
		{
			return FetchUsingPK(assetReclamationServiceId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 assetReclamationServiceId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(assetReclamationServiceId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 assetReclamationServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(assetReclamationServiceId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 assetReclamationServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(assetReclamationServiceId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AssetReclamationServiceId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(AssetReclamationServiceFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(AssetReclamationServiceFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new AssetReclamationServiceRelations().GetAllRelations();
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
				_assetReclamationServiceChangeLog.GetMultiManyToOne(this, null, null, filter);
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
				filter.Add(new FieldCompareValuePredicate(AssetReclamationServiceFields.AssetReclamationServiceId, ComparisonOperator.Equal, this.AssetReclamationServiceId, "AssetReclamationServiceEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(AssetReclamationServiceFields.AssetReclamationServiceId, ComparisonOperator.Equal, this.AssetReclamationServiceId, "AssetReclamationServiceEntity__"));
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

		/// <summary> Retrieves the related entity of type 'ServiceLocationAssetTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ServiceLocationAssetTypeEntity' which is related to this entity.</returns>
		public ServiceLocationAssetTypeEntity GetSingleServiceLocationAssetType()
		{
			return GetSingleServiceLocationAssetType(false);
		}

		/// <summary> Retrieves the related entity of type 'ServiceLocationAssetTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ServiceLocationAssetTypeEntity' which is related to this entity.</returns>
		public virtual ServiceLocationAssetTypeEntity GetSingleServiceLocationAssetType(bool forceFetch)
		{
			if( ( !_alreadyFetchedServiceLocationAssetType || forceFetch || _alwaysFetchServiceLocationAssetType) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AssetReclamationServiceEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId);

				ServiceLocationAssetTypeEntity newEntity = new ServiceLocationAssetTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ServiceLocationAssetTypeId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ServiceLocationAssetTypeEntity)base.ActiveContext.Get(newEntity);
					}
					this.ServiceLocationAssetType = newEntity;
				}
				else
				{
					if(_serviceLocationAssetTypeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_serviceLocationAssetType == null)))
						{
							this.ServiceLocationAssetType = newEntity;
						}
					}
					else
					{
						this.ServiceLocationAssetType = null;
					}
				}
				_alreadyFetchedServiceLocationAssetType = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _serviceLocationAssetType;
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AssetReclamationServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);

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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(AssetReclamationServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);

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
			AssetReclamationServiceDAO dao = (AssetReclamationServiceDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_assetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			_employeeCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			_userCollectionViaAssetReclamationServiceChangeLog.ActiveContext = base.ActiveContext;
			if(_serviceLocationAssetType!=null)
			{
				_serviceLocationAssetType.ActiveContext = base.ActiveContext;
			}
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
			AssetReclamationServiceDAO dao = (AssetReclamationServiceDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			AssetReclamationServiceDAO dao = (AssetReclamationServiceDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity);
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
			toReturn.Add("ServiceLocationAssetType", _serviceLocationAssetType);
			toReturn.Add("WorkOrderEmployee", _workOrderEmployee);
			toReturn.Add("WorkOrderServiceLocation", _workOrderServiceLocation);
			toReturn.Add("AssetReclamationServiceChangeLog", _assetReclamationServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaAssetReclamationServiceChangeLog", _employeeCollectionViaAssetReclamationServiceChangeLog);
			toReturn.Add("UserCollectionViaAssetReclamationServiceChangeLog", _userCollectionViaAssetReclamationServiceChangeLog);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		/// <param name="validator">The validator object for this AssetReclamationServiceEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 assetReclamationServiceId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(assetReclamationServiceId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_assetReclamationServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceChangeLogCollection(new AssetReclamationServiceChangeLogEntityFactory());
			_assetReclamationServiceChangeLog.SetContainingEntityInfo(this, "AssetReclamationService");
			_alwaysFetchAssetReclamationServiceChangeLog = false;
			_alreadyFetchedAssetReclamationServiceChangeLog = false;
			_employeeCollectionViaAssetReclamationServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaAssetReclamationServiceChangeLog = false;
			_alreadyFetchedEmployeeCollectionViaAssetReclamationServiceChangeLog = false;
			_userCollectionViaAssetReclamationServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaAssetReclamationServiceChangeLog = false;
			_alreadyFetchedUserCollectionViaAssetReclamationServiceChangeLog = false;
			_serviceLocationAssetType = null;
			_serviceLocationAssetTypeReturnsNewIfNotFound = true;
			_alwaysFetchServiceLocationAssetType = false;
			_alreadyFetchedServiceLocationAssetType = false;
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

			_fieldsCustomProperties.Add("AssetReclamationServiceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("WorkOrderServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceLocationAssetTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Quantity", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _serviceLocationAssetType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocationAssetType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocationAssetType, new PropertyChangedEventHandler( OnServiceLocationAssetTypePropertyChanged ), "ServiceLocationAssetType", AssetReclamationServiceEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, true, signalRelatedEntity, "AssetReclamationService", resetFKFields, new int[] { (int)AssetReclamationServiceFieldIndex.ServiceLocationAssetTypeId } );		
			_serviceLocationAssetType = null;
		}
		
		/// <summary> setups the sync logic for member _serviceLocationAssetType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncServiceLocationAssetType(IEntity relatedEntity)
		{
			if(_serviceLocationAssetType!=relatedEntity)
			{		
				DesetupSyncServiceLocationAssetType(true, true);
				_serviceLocationAssetType = (ServiceLocationAssetTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceLocationAssetType, new PropertyChangedEventHandler( OnServiceLocationAssetTypePropertyChanged ), "ServiceLocationAssetType", AssetReclamationServiceEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, true, ref _alreadyFetchedServiceLocationAssetType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnServiceLocationAssetTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _workOrderEmployee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrderEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", AssetReclamationServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "AssetReclamationService", resetFKFields, new int[] { (int)AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", AssetReclamationServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, ref _alreadyFetchedWorkOrderEmployee, new string[] {  } );
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
			base.PerformDesetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", AssetReclamationServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "AssetReclamationService", resetFKFields, new int[] { (int)AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", AssetReclamationServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, ref _alreadyFetchedWorkOrderServiceLocation, new string[] {  } );
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
		/// <param name="assetReclamationServiceId">PK value for AssetReclamationService which data should be fetched into this AssetReclamationService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 assetReclamationServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)AssetReclamationServiceFieldIndex.AssetReclamationServiceId].ForcedCurrentValueWrite(assetReclamationServiceId);
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
			return DAOFactory.CreateAssetReclamationServiceDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AssetReclamationServiceEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AssetReclamationServiceRelations Relations
		{
			get	{ return new AssetReclamationServiceRelations(); }
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
					(IEntityRelation)GetRelationsForField("AssetReclamationServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceChangeLogEntity, 0, null, null, null, "AssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = AssetReclamationServiceEntity.Relations.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAssetReclamationServiceChangeLog"), "EmployeeCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaAssetReclamationServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = AssetReclamationServiceEntity.Relations.AssetReclamationServiceChangeLogEntityUsingAssetReclamationServiceId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaAssetReclamationServiceChangeLog"), "UserCollectionViaAssetReclamationServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetType")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, null, "ServiceLocationAssetType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("WorkOrderEmployee")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, null, "WorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("WorkOrderServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, null, "WorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "AssetReclamationServiceEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return AssetReclamationServiceEntity.CustomProperties;}
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
			get { return AssetReclamationServiceEntity.FieldsCustomProperties;}
		}

		/// <summary> The AssetReclamationServiceId property of the Entity AssetReclamationService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetReclamationService"."AssetReclamationServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AssetReclamationServiceId
		{
			get { return (System.Int32)GetValue((int)AssetReclamationServiceFieldIndex.AssetReclamationServiceId, true); }
			set	{ SetValue((int)AssetReclamationServiceFieldIndex.AssetReclamationServiceId, value, true); }
		}
		/// <summary> The WorkOrderServiceLocationId property of the Entity AssetReclamationService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetReclamationService"."WorkOrderServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 WorkOrderServiceLocationId
		{
			get { return (System.Int32)GetValue((int)AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId, true); }
			set	{ SetValue((int)AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId, value, true); }
		}
		/// <summary> The ServiceLocationAssetTypeId property of the Entity AssetReclamationService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetReclamationService"."ServiceLocationAssetTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceLocationAssetTypeId
		{
			get { return (System.Int32)GetValue((int)AssetReclamationServiceFieldIndex.ServiceLocationAssetTypeId, true); }
			set	{ SetValue((int)AssetReclamationServiceFieldIndex.ServiceLocationAssetTypeId, value, true); }
		}
		/// <summary> The Quantity property of the Entity AssetReclamationService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "AssetReclamationService"."Quantity"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Quantity
		{
			get { return (System.Int32)GetValue((int)AssetReclamationServiceFieldIndex.Quantity, true); }
			set	{ SetValue((int)AssetReclamationServiceFieldIndex.Quantity, value, true); }
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

		/// <summary> Gets / sets related entity of type 'ServiceLocationAssetTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleServiceLocationAssetType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ServiceLocationAssetTypeEntity ServiceLocationAssetType
		{
			get	{ return GetSingleServiceLocationAssetType(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncServiceLocationAssetType(value);
				}
				else
				{
					if(value==null)
					{
						if(_serviceLocationAssetType != null)
						{
							_serviceLocationAssetType.UnsetRelatedEntity(this, "AssetReclamationService");
						}
					}
					else
					{
						if(_serviceLocationAssetType!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AssetReclamationService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationAssetType. When set to true, ServiceLocationAssetType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationAssetType is accessed. You can always execute
		/// a forced fetch by calling GetSingleServiceLocationAssetType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationAssetType
		{
			get	{ return _alwaysFetchServiceLocationAssetType; }
			set	{ _alwaysFetchServiceLocationAssetType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationAssetType already has been fetched. Setting this property to false when ServiceLocationAssetType has been fetched
		/// will set ServiceLocationAssetType to null as well. Setting this property to true while ServiceLocationAssetType hasn't been fetched disables lazy loading for ServiceLocationAssetType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationAssetType
		{
			get { return _alreadyFetchedServiceLocationAssetType;}
			set 
			{
				if(_alreadyFetchedServiceLocationAssetType && !value)
				{
					this.ServiceLocationAssetType = null;
				}
				_alreadyFetchedServiceLocationAssetType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ServiceLocationAssetType is not found
		/// in the database. When set to true, ServiceLocationAssetType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ServiceLocationAssetTypeReturnsNewIfNotFound
		{
			get	{ return _serviceLocationAssetTypeReturnsNewIfNotFound; }
			set { _serviceLocationAssetTypeReturnsNewIfNotFound = value; }	
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
							_workOrderEmployee.UnsetRelatedEntity(this, "AssetReclamationService");
						}
					}
					else
					{
						if(_workOrderEmployee!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AssetReclamationService");
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
							_workOrderServiceLocation.UnsetRelatedEntity(this, "AssetReclamationService");
						}
					}
					else
					{
						if(_workOrderServiceLocation!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "AssetReclamationService");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity; }
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
