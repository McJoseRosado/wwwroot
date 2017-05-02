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
	/// Entity class which represents the entity 'ServiceLocationAssetType'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ServiceLocationAssetTypeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection	_assetReclamationService;
		private bool	_alwaysFetchAssetReclamationService, _alreadyFetchedAssetReclamationService;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection	_serviceLocationAssetTypeChangeLog;
		private bool	_alwaysFetchServiceLocationAssetTypeChangeLog, _alreadyFetchedServiceLocationAssetTypeChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection _changeLogCollectionViaServiceLocationAssetTypeChangeLog;
		private bool	_alwaysFetchChangeLogCollectionViaServiceLocationAssetTypeChangeLog, _alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection _workOrderEmployeeCollectionViaAssetReclamationService;
		private bool	_alwaysFetchWorkOrderEmployeeCollectionViaAssetReclamationService, _alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection _workOrderServiceLocationCollectionViaAssetReclamationService;
		private bool	_alwaysFetchWorkOrderServiceLocationCollectionViaAssetReclamationService, _alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService;
		private AssetTypeEntity _assetType;
		private bool	_alwaysFetchAssetType, _alreadyFetchedAssetType, _assetTypeReturnsNewIfNotFound;
		private ServiceLocationEntity _serviceLocation;
		private bool	_alwaysFetchServiceLocation, _alreadyFetchedServiceLocation, _serviceLocationReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name AssetType</summary>
			public static readonly string AssetType = "AssetType";
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name AssetReclamationService</summary>
			public static readonly string AssetReclamationService = "AssetReclamationService";
			/// <summary>Member name ServiceLocationAssetTypeChangeLog</summary>
			public static readonly string ServiceLocationAssetTypeChangeLog = "ServiceLocationAssetTypeChangeLog";
			/// <summary>Member name ChangeLogCollectionViaServiceLocationAssetTypeChangeLog</summary>
			public static readonly string ChangeLogCollectionViaServiceLocationAssetTypeChangeLog = "ChangeLogCollectionViaServiceLocationAssetTypeChangeLog";
			/// <summary>Member name WorkOrderEmployeeCollectionViaAssetReclamationService</summary>
			public static readonly string WorkOrderEmployeeCollectionViaAssetReclamationService = "WorkOrderEmployeeCollectionViaAssetReclamationService";
			/// <summary>Member name WorkOrderServiceLocationCollectionViaAssetReclamationService</summary>
			public static readonly string WorkOrderServiceLocationCollectionViaAssetReclamationService = "WorkOrderServiceLocationCollectionViaAssetReclamationService";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ServiceLocationAssetTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ServiceLocationAssetTypeEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		public ServiceLocationAssetTypeEntity(System.Int32 serviceLocationAssetTypeId)
		{
			InitClassFetch(serviceLocationAssetTypeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ServiceLocationAssetTypeEntity(System.Int32 serviceLocationAssetTypeId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(serviceLocationAssetTypeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		/// <param name="validator">The custom validator object for this ServiceLocationAssetTypeEntity</param>
		public ServiceLocationAssetTypeEntity(System.Int32 serviceLocationAssetTypeId, IValidator validator)
		{
			InitClassFetch(serviceLocationAssetTypeId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ServiceLocationAssetTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_assetReclamationService = (Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection)info.GetValue("_assetReclamationService", typeof(Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection));
			_alwaysFetchAssetReclamationService = info.GetBoolean("_alwaysFetchAssetReclamationService");
			_alreadyFetchedAssetReclamationService = info.GetBoolean("_alreadyFetchedAssetReclamationService");
			_serviceLocationAssetTypeChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection)info.GetValue("_serviceLocationAssetTypeChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection));
			_alwaysFetchServiceLocationAssetTypeChangeLog = info.GetBoolean("_alwaysFetchServiceLocationAssetTypeChangeLog");
			_alreadyFetchedServiceLocationAssetTypeChangeLog = info.GetBoolean("_alreadyFetchedServiceLocationAssetTypeChangeLog");
			_changeLogCollectionViaServiceLocationAssetTypeChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection)info.GetValue("_changeLogCollectionViaServiceLocationAssetTypeChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection));
			_alwaysFetchChangeLogCollectionViaServiceLocationAssetTypeChangeLog = info.GetBoolean("_alwaysFetchChangeLogCollectionViaServiceLocationAssetTypeChangeLog");
			_alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog = info.GetBoolean("_alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog");
			_workOrderEmployeeCollectionViaAssetReclamationService = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection)info.GetValue("_workOrderEmployeeCollectionViaAssetReclamationService", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection));
			_alwaysFetchWorkOrderEmployeeCollectionViaAssetReclamationService = info.GetBoolean("_alwaysFetchWorkOrderEmployeeCollectionViaAssetReclamationService");
			_alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService = info.GetBoolean("_alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService");
			_workOrderServiceLocationCollectionViaAssetReclamationService = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection)info.GetValue("_workOrderServiceLocationCollectionViaAssetReclamationService", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection));
			_alwaysFetchWorkOrderServiceLocationCollectionViaAssetReclamationService = info.GetBoolean("_alwaysFetchWorkOrderServiceLocationCollectionViaAssetReclamationService");
			_alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService = info.GetBoolean("_alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService");
			_assetType = (AssetTypeEntity)info.GetValue("_assetType", typeof(AssetTypeEntity));
			if(_assetType!=null)
			{
				_assetType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_assetTypeReturnsNewIfNotFound = info.GetBoolean("_assetTypeReturnsNewIfNotFound");
			_alwaysFetchAssetType = info.GetBoolean("_alwaysFetchAssetType");
			_alreadyFetchedAssetType = info.GetBoolean("_alreadyFetchedAssetType");
			_serviceLocation = (ServiceLocationEntity)info.GetValue("_serviceLocation", typeof(ServiceLocationEntity));
			if(_serviceLocation!=null)
			{
				_serviceLocation.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_serviceLocationReturnsNewIfNotFound = info.GetBoolean("_serviceLocationReturnsNewIfNotFound");
			_alwaysFetchServiceLocation = info.GetBoolean("_alwaysFetchServiceLocation");
			_alreadyFetchedServiceLocation = info.GetBoolean("_alreadyFetchedServiceLocation");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ServiceLocationAssetTypeFieldIndex)fieldIndex)
			{
				case ServiceLocationAssetTypeFieldIndex.ServiceLocationId:
					DesetupSyncServiceLocation(true, false);
					_alreadyFetchedServiceLocation = false;
					break;
				case ServiceLocationAssetTypeFieldIndex.AssetTypeId:
					DesetupSyncAssetType(true, false);
					_alreadyFetchedAssetType = false;
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
			_alreadyFetchedAssetReclamationService = (_assetReclamationService.Count > 0);
			_alreadyFetchedServiceLocationAssetTypeChangeLog = (_serviceLocationAssetTypeChangeLog.Count > 0);
			_alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog = (_changeLogCollectionViaServiceLocationAssetTypeChangeLog.Count > 0);
			_alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService = (_workOrderEmployeeCollectionViaAssetReclamationService.Count > 0);
			_alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService = (_workOrderServiceLocationCollectionViaAssetReclamationService.Count > 0);
			_alreadyFetchedAssetType = (_assetType != null);
			_alreadyFetchedServiceLocation = (_serviceLocation != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ServiceLocationAssetTypeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "AssetType":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.AssetTypeEntityUsingAssetTypeId);
					break;
				case "ServiceLocation":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.ServiceLocationEntityUsingServiceLocationId);
					break;
				case "AssetReclamationService":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingServiceLocationAssetTypeId);
					break;
				case "ChangeLogCollectionViaServiceLocationAssetTypeChangeLog":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__", "ServiceLocationAssetTypeChangeLog_", JoinHint.None);
					toReturn.Add(ServiceLocationAssetTypeChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId, "ServiceLocationAssetTypeChangeLog_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderEmployeeCollectionViaAssetReclamationService":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__", "AssetReclamationService_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, "AssetReclamationService_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderServiceLocationCollectionViaAssetReclamationService":
					toReturn.Add(ServiceLocationAssetTypeEntity.Relations.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__", "AssetReclamationService_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, "AssetReclamationService_", string.Empty, JoinHint.None);
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
			info.AddValue("_assetReclamationService", (!this.MarkedForDeletion?_assetReclamationService:null));
			info.AddValue("_alwaysFetchAssetReclamationService", _alwaysFetchAssetReclamationService);
			info.AddValue("_alreadyFetchedAssetReclamationService", _alreadyFetchedAssetReclamationService);
			info.AddValue("_serviceLocationAssetTypeChangeLog", (!this.MarkedForDeletion?_serviceLocationAssetTypeChangeLog:null));
			info.AddValue("_alwaysFetchServiceLocationAssetTypeChangeLog", _alwaysFetchServiceLocationAssetTypeChangeLog);
			info.AddValue("_alreadyFetchedServiceLocationAssetTypeChangeLog", _alreadyFetchedServiceLocationAssetTypeChangeLog);
			info.AddValue("_changeLogCollectionViaServiceLocationAssetTypeChangeLog", (!this.MarkedForDeletion?_changeLogCollectionViaServiceLocationAssetTypeChangeLog:null));
			info.AddValue("_alwaysFetchChangeLogCollectionViaServiceLocationAssetTypeChangeLog", _alwaysFetchChangeLogCollectionViaServiceLocationAssetTypeChangeLog);
			info.AddValue("_alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog", _alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog);
			info.AddValue("_workOrderEmployeeCollectionViaAssetReclamationService", (!this.MarkedForDeletion?_workOrderEmployeeCollectionViaAssetReclamationService:null));
			info.AddValue("_alwaysFetchWorkOrderEmployeeCollectionViaAssetReclamationService", _alwaysFetchWorkOrderEmployeeCollectionViaAssetReclamationService);
			info.AddValue("_alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService", _alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService);
			info.AddValue("_workOrderServiceLocationCollectionViaAssetReclamationService", (!this.MarkedForDeletion?_workOrderServiceLocationCollectionViaAssetReclamationService:null));
			info.AddValue("_alwaysFetchWorkOrderServiceLocationCollectionViaAssetReclamationService", _alwaysFetchWorkOrderServiceLocationCollectionViaAssetReclamationService);
			info.AddValue("_alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService", _alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService);
			info.AddValue("_assetType", (!this.MarkedForDeletion?_assetType:null));
			info.AddValue("_assetTypeReturnsNewIfNotFound", _assetTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAssetType", _alwaysFetchAssetType);
			info.AddValue("_alreadyFetchedAssetType", _alreadyFetchedAssetType);
			info.AddValue("_serviceLocation", (!this.MarkedForDeletion?_serviceLocation:null));
			info.AddValue("_serviceLocationReturnsNewIfNotFound", _serviceLocationReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchServiceLocation", _alwaysFetchServiceLocation);
			info.AddValue("_alreadyFetchedServiceLocation", _alreadyFetchedServiceLocation);

			
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
				case "AssetType":
					_alreadyFetchedAssetType = true;
					this.AssetType = (AssetTypeEntity)entity;
					break;
				case "ServiceLocation":
					_alreadyFetchedServiceLocation = true;
					this.ServiceLocation = (ServiceLocationEntity)entity;
					break;
				case "AssetReclamationService":
					_alreadyFetchedAssetReclamationService = true;
					if(entity!=null)
					{
						this.AssetReclamationService.Add((AssetReclamationServiceEntity)entity);
					}
					break;
				case "ServiceLocationAssetTypeChangeLog":
					_alreadyFetchedServiceLocationAssetTypeChangeLog = true;
					if(entity!=null)
					{
						this.ServiceLocationAssetTypeChangeLog.Add((ServiceLocationAssetTypeChangeLogEntity)entity);
					}
					break;
				case "ChangeLogCollectionViaServiceLocationAssetTypeChangeLog":
					_alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog = true;
					if(entity!=null)
					{
						this.ChangeLogCollectionViaServiceLocationAssetTypeChangeLog.Add((ChangeLogEntity)entity);
					}
					break;
				case "WorkOrderEmployeeCollectionViaAssetReclamationService":
					_alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService = true;
					if(entity!=null)
					{
						this.WorkOrderEmployeeCollectionViaAssetReclamationService.Add((WorkOrderEmployeeEntity)entity);
					}
					break;
				case "WorkOrderServiceLocationCollectionViaAssetReclamationService":
					_alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService = true;
					if(entity!=null)
					{
						this.WorkOrderServiceLocationCollectionViaAssetReclamationService.Add((WorkOrderServiceLocationEntity)entity);
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
				case "AssetType":
					SetupSyncAssetType(relatedEntity);
					break;
				case "ServiceLocation":
					SetupSyncServiceLocation(relatedEntity);
					break;
				case "AssetReclamationService":
					_assetReclamationService.Add((AssetReclamationServiceEntity)relatedEntity);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					_serviceLocationAssetTypeChangeLog.Add((ServiceLocationAssetTypeChangeLogEntity)relatedEntity);
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
				case "AssetType":
					DesetupSyncAssetType(false, true);
					break;
				case "ServiceLocation":
					DesetupSyncServiceLocation(false, true);
					break;
				case "AssetReclamationService":
					base.PerformRelatedEntityRemoval(_assetReclamationService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationAssetTypeChangeLog":
					base.PerformRelatedEntityRemoval(_serviceLocationAssetTypeChangeLog, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_assetType!=null)
			{
				toReturn.Add(_assetType);
			}
			if(_serviceLocation!=null)
			{
				toReturn.Add(_serviceLocation);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_assetReclamationService);
			toReturn.Add(_serviceLocationAssetTypeChangeLog);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationAssetTypeId)
		{
			return FetchUsingPK(serviceLocationAssetTypeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationAssetTypeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(serviceLocationAssetTypeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationAssetTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(serviceLocationAssetTypeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 serviceLocationAssetTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(serviceLocationAssetTypeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ServiceLocationAssetTypeId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ServiceLocationAssetTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ServiceLocationAssetTypeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ServiceLocationAssetTypeRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AssetReclamationServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection GetMultiAssetReclamationService(bool forceFetch)
		{
			return GetMultiAssetReclamationService(forceFetch, _assetReclamationService.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AssetReclamationServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection GetMultiAssetReclamationService(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAssetReclamationService(forceFetch, _assetReclamationService.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection GetMultiAssetReclamationService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAssetReclamationService(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection GetMultiAssetReclamationService(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAssetReclamationService || forceFetch || _alwaysFetchAssetReclamationService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_assetReclamationService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_assetReclamationService);
					}
				}
				_assetReclamationService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_assetReclamationService.EntityFactoryToUse = entityFactoryToUse;
				}
				_assetReclamationService.GetMultiManyToOne(this, null, null, filter);
				_assetReclamationService.SuppressClearInGetMulti=false;
				_alreadyFetchedAssetReclamationService = true;
			}
			return _assetReclamationService;
		}

		/// <summary> Sets the collection parameters for the collection for 'AssetReclamationService'. These settings will be taken into account
		/// when the property AssetReclamationService is requested or GetMultiAssetReclamationService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAssetReclamationService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_assetReclamationService.SortClauses=sortClauses;
			_assetReclamationService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationAssetTypeChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection GetMultiServiceLocationAssetTypeChangeLog(bool forceFetch)
		{
			return GetMultiServiceLocationAssetTypeChangeLog(forceFetch, _serviceLocationAssetTypeChangeLog.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationAssetTypeChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection GetMultiServiceLocationAssetTypeChangeLog(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiServiceLocationAssetTypeChangeLog(forceFetch, _serviceLocationAssetTypeChangeLog.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection GetMultiServiceLocationAssetTypeChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiServiceLocationAssetTypeChangeLog(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection GetMultiServiceLocationAssetTypeChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedServiceLocationAssetTypeChangeLog || forceFetch || _alwaysFetchServiceLocationAssetTypeChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationAssetTypeChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationAssetTypeChangeLog);
					}
				}
				_serviceLocationAssetTypeChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationAssetTypeChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationAssetTypeChangeLog.GetMultiManyToOne(null, this, filter);
				_serviceLocationAssetTypeChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationAssetTypeChangeLog = true;
			}
			return _serviceLocationAssetTypeChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationAssetTypeChangeLog'. These settings will be taken into account
		/// when the property ServiceLocationAssetTypeChangeLog is requested or GetMultiServiceLocationAssetTypeChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationAssetTypeChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationAssetTypeChangeLog.SortClauses=sortClauses;
			_serviceLocationAssetTypeChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLogCollectionViaServiceLocationAssetTypeChangeLog(bool forceFetch)
		{
			return GetMultiChangeLogCollectionViaServiceLocationAssetTypeChangeLog(forceFetch, _changeLogCollectionViaServiceLocationAssetTypeChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLogCollectionViaServiceLocationAssetTypeChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog || forceFetch || _alwaysFetchChangeLogCollectionViaServiceLocationAssetTypeChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_changeLogCollectionViaServiceLocationAssetTypeChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_changeLogCollectionViaServiceLocationAssetTypeChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, ComparisonOperator.Equal, this.ServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__"));
				_changeLogCollectionViaServiceLocationAssetTypeChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_changeLogCollectionViaServiceLocationAssetTypeChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_changeLogCollectionViaServiceLocationAssetTypeChangeLog.GetMulti(filter, GetRelationsForField("ChangeLogCollectionViaServiceLocationAssetTypeChangeLog"));
				_changeLogCollectionViaServiceLocationAssetTypeChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog = true;
			}
			return _changeLogCollectionViaServiceLocationAssetTypeChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'ChangeLogCollectionViaServiceLocationAssetTypeChangeLog'. These settings will be taken into account
		/// when the property ChangeLogCollectionViaServiceLocationAssetTypeChangeLog is requested or GetMultiChangeLogCollectionViaServiceLocationAssetTypeChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersChangeLogCollectionViaServiceLocationAssetTypeChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_changeLogCollectionViaServiceLocationAssetTypeChangeLog.SortClauses=sortClauses;
			_changeLogCollectionViaServiceLocationAssetTypeChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployeeCollectionViaAssetReclamationService(bool forceFetch)
		{
			return GetMultiWorkOrderEmployeeCollectionViaAssetReclamationService(forceFetch, _workOrderEmployeeCollectionViaAssetReclamationService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection GetMultiWorkOrderEmployeeCollectionViaAssetReclamationService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService || forceFetch || _alwaysFetchWorkOrderEmployeeCollectionViaAssetReclamationService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderEmployeeCollectionViaAssetReclamationService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderEmployeeCollectionViaAssetReclamationService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, ComparisonOperator.Equal, this.ServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__"));
				_workOrderEmployeeCollectionViaAssetReclamationService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderEmployeeCollectionViaAssetReclamationService.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderEmployeeCollectionViaAssetReclamationService.GetMulti(filter, GetRelationsForField("WorkOrderEmployeeCollectionViaAssetReclamationService"));
				_workOrderEmployeeCollectionViaAssetReclamationService.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService = true;
			}
			return _workOrderEmployeeCollectionViaAssetReclamationService;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderEmployeeCollectionViaAssetReclamationService'. These settings will be taken into account
		/// when the property WorkOrderEmployeeCollectionViaAssetReclamationService is requested or GetMultiWorkOrderEmployeeCollectionViaAssetReclamationService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderEmployeeCollectionViaAssetReclamationService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderEmployeeCollectionViaAssetReclamationService.SortClauses=sortClauses;
			_workOrderEmployeeCollectionViaAssetReclamationService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocationCollectionViaAssetReclamationService(bool forceFetch)
		{
			return GetMultiWorkOrderServiceLocationCollectionViaAssetReclamationService(forceFetch, _workOrderServiceLocationCollectionViaAssetReclamationService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection GetMultiWorkOrderServiceLocationCollectionViaAssetReclamationService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService || forceFetch || _alwaysFetchWorkOrderServiceLocationCollectionViaAssetReclamationService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderServiceLocationCollectionViaAssetReclamationService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderServiceLocationCollectionViaAssetReclamationService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(ServiceLocationAssetTypeFields.ServiceLocationAssetTypeId, ComparisonOperator.Equal, this.ServiceLocationAssetTypeId, "ServiceLocationAssetTypeEntity__"));
				_workOrderServiceLocationCollectionViaAssetReclamationService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_workOrderServiceLocationCollectionViaAssetReclamationService.EntityFactoryToUse = entityFactoryToUse;
				}
				_workOrderServiceLocationCollectionViaAssetReclamationService.GetMulti(filter, GetRelationsForField("WorkOrderServiceLocationCollectionViaAssetReclamationService"));
				_workOrderServiceLocationCollectionViaAssetReclamationService.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService = true;
			}
			return _workOrderServiceLocationCollectionViaAssetReclamationService;
		}

		/// <summary> Sets the collection parameters for the collection for 'WorkOrderServiceLocationCollectionViaAssetReclamationService'. These settings will be taken into account
		/// when the property WorkOrderServiceLocationCollectionViaAssetReclamationService is requested or GetMultiWorkOrderServiceLocationCollectionViaAssetReclamationService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderServiceLocationCollectionViaAssetReclamationService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderServiceLocationCollectionViaAssetReclamationService.SortClauses=sortClauses;
			_workOrderServiceLocationCollectionViaAssetReclamationService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'AssetTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AssetTypeEntity' which is related to this entity.</returns>
		public AssetTypeEntity GetSingleAssetType()
		{
			return GetSingleAssetType(false);
		}

		/// <summary> Retrieves the related entity of type 'AssetTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AssetTypeEntity' which is related to this entity.</returns>
		public virtual AssetTypeEntity GetSingleAssetType(bool forceFetch)
		{
			if( ( !_alreadyFetchedAssetType || forceFetch || _alwaysFetchAssetType) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ServiceLocationAssetTypeEntity.Relations.AssetTypeEntityUsingAssetTypeId);

				AssetTypeEntity newEntity = new AssetTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.AssetTypeId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (AssetTypeEntity)base.ActiveContext.Get(newEntity);
					}
					this.AssetType = newEntity;
				}
				else
				{
					if(_assetTypeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_assetType == null)))
						{
							this.AssetType = newEntity;
						}
					}
					else
					{
						this.AssetType = null;
					}
				}
				_alreadyFetchedAssetType = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _assetType;
		}

		/// <summary> Retrieves the related entity of type 'ServiceLocationEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ServiceLocationEntity' which is related to this entity.</returns>
		public ServiceLocationEntity GetSingleServiceLocation()
		{
			return GetSingleServiceLocation(false);
		}

		/// <summary> Retrieves the related entity of type 'ServiceLocationEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ServiceLocationEntity' which is related to this entity.</returns>
		public virtual ServiceLocationEntity GetSingleServiceLocation(bool forceFetch)
		{
			if( ( !_alreadyFetchedServiceLocation || forceFetch || _alwaysFetchServiceLocation) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ServiceLocationAssetTypeEntity.Relations.ServiceLocationEntityUsingServiceLocationId);

				ServiceLocationEntity newEntity = new ServiceLocationEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ServiceLocationId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ServiceLocationEntity)base.ActiveContext.Get(newEntity);
					}
					this.ServiceLocation = newEntity;
				}
				else
				{
					if(_serviceLocationReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_serviceLocation == null)))
						{
							this.ServiceLocation = newEntity;
						}
					}
					else
					{
						this.ServiceLocation = null;
					}
				}
				_alreadyFetchedServiceLocation = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _serviceLocation;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ServiceLocationAssetTypeDAO dao = (ServiceLocationAssetTypeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_assetReclamationService.ActiveContext = base.ActiveContext;
			_serviceLocationAssetTypeChangeLog.ActiveContext = base.ActiveContext;
			_changeLogCollectionViaServiceLocationAssetTypeChangeLog.ActiveContext = base.ActiveContext;
			_workOrderEmployeeCollectionViaAssetReclamationService.ActiveContext = base.ActiveContext;
			_workOrderServiceLocationCollectionViaAssetReclamationService.ActiveContext = base.ActiveContext;
			if(_assetType!=null)
			{
				_assetType.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ServiceLocationAssetTypeDAO dao = (ServiceLocationAssetTypeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ServiceLocationAssetTypeDAO dao = (ServiceLocationAssetTypeDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity);
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
			toReturn.Add("AssetType", _assetType);
			toReturn.Add("ServiceLocation", _serviceLocation);
			toReturn.Add("AssetReclamationService", _assetReclamationService);
			toReturn.Add("ServiceLocationAssetTypeChangeLog", _serviceLocationAssetTypeChangeLog);
			toReturn.Add("ChangeLogCollectionViaServiceLocationAssetTypeChangeLog", _changeLogCollectionViaServiceLocationAssetTypeChangeLog);
			toReturn.Add("WorkOrderEmployeeCollectionViaAssetReclamationService", _workOrderEmployeeCollectionViaAssetReclamationService);
			toReturn.Add("WorkOrderServiceLocationCollectionViaAssetReclamationService", _workOrderServiceLocationCollectionViaAssetReclamationService);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		/// <param name="validator">The validator object for this ServiceLocationAssetTypeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 serviceLocationAssetTypeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(serviceLocationAssetTypeId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_assetReclamationService = new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection(new AssetReclamationServiceEntityFactory());
			_assetReclamationService.SetContainingEntityInfo(this, "ServiceLocationAssetType");
			_alwaysFetchAssetReclamationService = false;
			_alreadyFetchedAssetReclamationService = false;
			_serviceLocationAssetTypeChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection(new ServiceLocationAssetTypeChangeLogEntityFactory());
			_serviceLocationAssetTypeChangeLog.SetContainingEntityInfo(this, "ServiceLocationAssetType");
			_alwaysFetchServiceLocationAssetTypeChangeLog = false;
			_alreadyFetchedServiceLocationAssetTypeChangeLog = false;
			_changeLogCollectionViaServiceLocationAssetTypeChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection(new ChangeLogEntityFactory());
			_alwaysFetchChangeLogCollectionViaServiceLocationAssetTypeChangeLog = false;
			_alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog = false;
			_workOrderEmployeeCollectionViaAssetReclamationService = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(new WorkOrderEmployeeEntityFactory());
			_alwaysFetchWorkOrderEmployeeCollectionViaAssetReclamationService = false;
			_alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService = false;
			_workOrderServiceLocationCollectionViaAssetReclamationService = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(new WorkOrderServiceLocationEntityFactory());
			_alwaysFetchWorkOrderServiceLocationCollectionViaAssetReclamationService = false;
			_alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService = false;
			_assetType = null;
			_assetTypeReturnsNewIfNotFound = true;
			_alwaysFetchAssetType = false;
			_alreadyFetchedAssetType = false;
			_serviceLocation = null;
			_serviceLocationReturnsNewIfNotFound = true;
			_alwaysFetchServiceLocation = false;
			_alreadyFetchedServiceLocation = false;


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

			_fieldsCustomProperties.Add("ServiceLocationAssetTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AssetTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("PricePerUnit", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _assetType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAssetType(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _assetType, new PropertyChangedEventHandler( OnAssetTypePropertyChanged ), "AssetType", ServiceLocationAssetTypeEntity.Relations.AssetTypeEntityUsingAssetTypeId, true, signalRelatedEntity, "ServiceLocationAssetTypeId", resetFKFields, new int[] { (int)ServiceLocationAssetTypeFieldIndex.AssetTypeId } );		
			_assetType = null;
		}
		
		/// <summary> setups the sync logic for member _assetType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAssetType(IEntity relatedEntity)
		{
			if(_assetType!=relatedEntity)
			{		
				DesetupSyncAssetType(true, true);
				_assetType = (AssetTypeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _assetType, new PropertyChangedEventHandler( OnAssetTypePropertyChanged ), "AssetType", ServiceLocationAssetTypeEntity.Relations.AssetTypeEntityUsingAssetTypeId, true, ref _alreadyFetchedAssetType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAssetTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _serviceLocation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", ServiceLocationAssetTypeEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, signalRelatedEntity, "ServiceLocationAssetType", resetFKFields, new int[] { (int)ServiceLocationAssetTypeFieldIndex.ServiceLocationId } );		
			_serviceLocation = null;
		}
		
		/// <summary> setups the sync logic for member _serviceLocation</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncServiceLocation(IEntity relatedEntity)
		{
			if(_serviceLocation!=relatedEntity)
			{		
				DesetupSyncServiceLocation(true, true);
				_serviceLocation = (ServiceLocationEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", ServiceLocationAssetTypeEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, ref _alreadyFetchedServiceLocation, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnServiceLocationPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="serviceLocationAssetTypeId">PK value for ServiceLocationAssetType which data should be fetched into this ServiceLocationAssetType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 serviceLocationAssetTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ServiceLocationAssetTypeFieldIndex.ServiceLocationAssetTypeId].ForcedCurrentValueWrite(serviceLocationAssetTypeId);
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
			return DAOFactory.CreateServiceLocationAssetTypeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ServiceLocationAssetTypeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ServiceLocationAssetTypeRelations Relations
		{
			get	{ return new ServiceLocationAssetTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AssetReclamationService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAssetReclamationService
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection(),
					(IEntityRelation)GetRelationsForField("AssetReclamationService")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, 0, null, null, null, "AssetReclamationService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetTypeChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationAssetTypeChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocationAssetTypeChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity, 0, null, null, null, "ServiceLocationAssetTypeChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChangeLogCollectionViaServiceLocationAssetTypeChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationAssetTypeEntity.Relations.ServiceLocationAssetTypeChangeLogEntityUsingServiceLocationAssetTypeId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationAssetTypeChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, 0, null, null, GetRelationsForField("ChangeLogCollectionViaServiceLocationAssetTypeChangeLog"), "ChangeLogCollectionViaServiceLocationAssetTypeChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderEmployeeCollectionViaAssetReclamationService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationAssetTypeEntity.Relations.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, GetRelationsForField("WorkOrderEmployeeCollectionViaAssetReclamationService"), "WorkOrderEmployeeCollectionViaAssetReclamationService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderServiceLocationCollectionViaAssetReclamationService
		{
			get
			{
				IEntityRelation intermediateRelation = ServiceLocationAssetTypeEntity.Relations.AssetReclamationServiceEntityUsingServiceLocationAssetTypeId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, GetRelationsForField("WorkOrderServiceLocationCollectionViaAssetReclamationService"), "WorkOrderServiceLocationCollectionViaAssetReclamationService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAssetType
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AssetTypeCollection(),
					(IEntityRelation)GetRelationsForField("AssetType")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetTypeEntity, 0, null, null, null, "AssetType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ServiceLocationAssetTypeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ServiceLocationAssetTypeEntity.CustomProperties;}
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
			get { return ServiceLocationAssetTypeEntity.FieldsCustomProperties;}
		}

		/// <summary> The ServiceLocationAssetTypeId property of the Entity ServiceLocationAssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetType"."ServiceLocationAssetTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ServiceLocationAssetTypeId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeFieldIndex.ServiceLocationAssetTypeId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeFieldIndex.ServiceLocationAssetTypeId, value, true); }
		}
		/// <summary> The ServiceLocationId property of the Entity ServiceLocationAssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetType"."ServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceLocationId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeFieldIndex.ServiceLocationId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeFieldIndex.ServiceLocationId, value, true); }
		}
		/// <summary> The AssetTypeId property of the Entity ServiceLocationAssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetType"."AssetTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AssetTypeId
		{
			get { return (System.Int32)GetValue((int)ServiceLocationAssetTypeFieldIndex.AssetTypeId, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeFieldIndex.AssetTypeId, value, true); }
		}
		/// <summary> The PricePerUnit property of the Entity ServiceLocationAssetType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ServiceLocationAssetType"."PricePerUnit"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal PricePerUnit
		{
			get { return (System.Decimal)GetValue((int)ServiceLocationAssetTypeFieldIndex.PricePerUnit, true); }
			set	{ SetValue((int)ServiceLocationAssetTypeFieldIndex.PricePerUnit, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'AssetReclamationServiceEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAssetReclamationService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection AssetReclamationService
		{
			get	{ return GetMultiAssetReclamationService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AssetReclamationService. When set to true, AssetReclamationService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AssetReclamationService is accessed. You can always execute
		/// a forced fetch by calling GetMultiAssetReclamationService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAssetReclamationService
		{
			get	{ return _alwaysFetchAssetReclamationService; }
			set	{ _alwaysFetchAssetReclamationService = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AssetReclamationService already has been fetched. Setting this property to false when AssetReclamationService has been fetched
		/// will clear the AssetReclamationService collection well. Setting this property to true while AssetReclamationService hasn't been fetched disables lazy loading for AssetReclamationService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAssetReclamationService
		{
			get { return _alreadyFetchedAssetReclamationService;}
			set 
			{
				if(_alreadyFetchedAssetReclamationService && !value && (_assetReclamationService != null))
				{
					_assetReclamationService.Clear();
				}
				_alreadyFetchedAssetReclamationService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationAssetTypeChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeChangeLogCollection ServiceLocationAssetTypeChangeLog
		{
			get	{ return GetMultiServiceLocationAssetTypeChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationAssetTypeChangeLog. When set to true, ServiceLocationAssetTypeChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationAssetTypeChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationAssetTypeChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationAssetTypeChangeLog
		{
			get	{ return _alwaysFetchServiceLocationAssetTypeChangeLog; }
			set	{ _alwaysFetchServiceLocationAssetTypeChangeLog = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationAssetTypeChangeLog already has been fetched. Setting this property to false when ServiceLocationAssetTypeChangeLog has been fetched
		/// will clear the ServiceLocationAssetTypeChangeLog collection well. Setting this property to true while ServiceLocationAssetTypeChangeLog hasn't been fetched disables lazy loading for ServiceLocationAssetTypeChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationAssetTypeChangeLog
		{
			get { return _alreadyFetchedServiceLocationAssetTypeChangeLog;}
			set 
			{
				if(_alreadyFetchedServiceLocationAssetTypeChangeLog && !value && (_serviceLocationAssetTypeChangeLog != null))
				{
					_serviceLocationAssetTypeChangeLog.Clear();
				}
				_alreadyFetchedServiceLocationAssetTypeChangeLog = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChangeLogCollectionViaServiceLocationAssetTypeChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection ChangeLogCollectionViaServiceLocationAssetTypeChangeLog
		{
			get { return GetMultiChangeLogCollectionViaServiceLocationAssetTypeChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ChangeLogCollectionViaServiceLocationAssetTypeChangeLog. When set to true, ChangeLogCollectionViaServiceLocationAssetTypeChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChangeLogCollectionViaServiceLocationAssetTypeChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiChangeLogCollectionViaServiceLocationAssetTypeChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChangeLogCollectionViaServiceLocationAssetTypeChangeLog
		{
			get	{ return _alwaysFetchChangeLogCollectionViaServiceLocationAssetTypeChangeLog; }
			set	{ _alwaysFetchChangeLogCollectionViaServiceLocationAssetTypeChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChangeLogCollectionViaServiceLocationAssetTypeChangeLog already has been fetched. Setting this property to false when ChangeLogCollectionViaServiceLocationAssetTypeChangeLog has been fetched
		/// will clear the ChangeLogCollectionViaServiceLocationAssetTypeChangeLog collection well. Setting this property to true while ChangeLogCollectionViaServiceLocationAssetTypeChangeLog hasn't been fetched disables lazy loading for ChangeLogCollectionViaServiceLocationAssetTypeChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog
		{
			get { return _alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog;}
			set 
			{
				if(_alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog && !value && (_changeLogCollectionViaServiceLocationAssetTypeChangeLog != null))
				{
					_changeLogCollectionViaServiceLocationAssetTypeChangeLog.Clear();
				}
				_alreadyFetchedChangeLogCollectionViaServiceLocationAssetTypeChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderEmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderEmployeeCollectionViaAssetReclamationService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection WorkOrderEmployeeCollectionViaAssetReclamationService
		{
			get { return GetMultiWorkOrderEmployeeCollectionViaAssetReclamationService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderEmployeeCollectionViaAssetReclamationService. When set to true, WorkOrderEmployeeCollectionViaAssetReclamationService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderEmployeeCollectionViaAssetReclamationService is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderEmployeeCollectionViaAssetReclamationService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderEmployeeCollectionViaAssetReclamationService
		{
			get	{ return _alwaysFetchWorkOrderEmployeeCollectionViaAssetReclamationService; }
			set	{ _alwaysFetchWorkOrderEmployeeCollectionViaAssetReclamationService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderEmployeeCollectionViaAssetReclamationService already has been fetched. Setting this property to false when WorkOrderEmployeeCollectionViaAssetReclamationService has been fetched
		/// will clear the WorkOrderEmployeeCollectionViaAssetReclamationService collection well. Setting this property to true while WorkOrderEmployeeCollectionViaAssetReclamationService hasn't been fetched disables lazy loading for WorkOrderEmployeeCollectionViaAssetReclamationService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService
		{
			get { return _alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService;}
			set 
			{
				if(_alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService && !value && (_workOrderEmployeeCollectionViaAssetReclamationService != null))
				{
					_workOrderEmployeeCollectionViaAssetReclamationService.Clear();
				}
				_alreadyFetchedWorkOrderEmployeeCollectionViaAssetReclamationService = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'WorkOrderServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderServiceLocationCollectionViaAssetReclamationService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection WorkOrderServiceLocationCollectionViaAssetReclamationService
		{
			get { return GetMultiWorkOrderServiceLocationCollectionViaAssetReclamationService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderServiceLocationCollectionViaAssetReclamationService. When set to true, WorkOrderServiceLocationCollectionViaAssetReclamationService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderServiceLocationCollectionViaAssetReclamationService is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderServiceLocationCollectionViaAssetReclamationService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderServiceLocationCollectionViaAssetReclamationService
		{
			get	{ return _alwaysFetchWorkOrderServiceLocationCollectionViaAssetReclamationService; }
			set	{ _alwaysFetchWorkOrderServiceLocationCollectionViaAssetReclamationService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderServiceLocationCollectionViaAssetReclamationService already has been fetched. Setting this property to false when WorkOrderServiceLocationCollectionViaAssetReclamationService has been fetched
		/// will clear the WorkOrderServiceLocationCollectionViaAssetReclamationService collection well. Setting this property to true while WorkOrderServiceLocationCollectionViaAssetReclamationService hasn't been fetched disables lazy loading for WorkOrderServiceLocationCollectionViaAssetReclamationService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService
		{
			get { return _alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService;}
			set 
			{
				if(_alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService && !value && (_workOrderServiceLocationCollectionViaAssetReclamationService != null))
				{
					_workOrderServiceLocationCollectionViaAssetReclamationService.Clear();
				}
				_alreadyFetchedWorkOrderServiceLocationCollectionViaAssetReclamationService = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'AssetTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAssetType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AssetTypeEntity AssetType
		{
			get	{ return GetSingleAssetType(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAssetType(value);
				}
				else
				{
					if(value==null)
					{
						if(_assetType != null)
						{
							_assetType.UnsetRelatedEntity(this, "ServiceLocationAssetTypeId");
						}
					}
					else
					{
						if(_assetType!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ServiceLocationAssetTypeId");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for AssetType. When set to true, AssetType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AssetType is accessed. You can always execute
		/// a forced fetch by calling GetSingleAssetType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAssetType
		{
			get	{ return _alwaysFetchAssetType; }
			set	{ _alwaysFetchAssetType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AssetType already has been fetched. Setting this property to false when AssetType has been fetched
		/// will set AssetType to null as well. Setting this property to true while AssetType hasn't been fetched disables lazy loading for AssetType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAssetType
		{
			get { return _alreadyFetchedAssetType;}
			set 
			{
				if(_alreadyFetchedAssetType && !value)
				{
					this.AssetType = null;
				}
				_alreadyFetchedAssetType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property AssetType is not found
		/// in the database. When set to true, AssetType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool AssetTypeReturnsNewIfNotFound
		{
			get	{ return _assetTypeReturnsNewIfNotFound; }
			set { _assetTypeReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ServiceLocationEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ServiceLocationEntity ServiceLocation
		{
			get	{ return GetSingleServiceLocation(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncServiceLocation(value);
				}
				else
				{
					if(value==null)
					{
						if(_serviceLocation != null)
						{
							_serviceLocation.UnsetRelatedEntity(this, "ServiceLocationAssetType");
						}
					}
					else
					{
						if(_serviceLocation!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ServiceLocationAssetType");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocation. When set to true, ServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetSingleServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocation
		{
			get	{ return _alwaysFetchServiceLocation; }
			set	{ _alwaysFetchServiceLocation = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocation already has been fetched. Setting this property to false when ServiceLocation has been fetched
		/// will set ServiceLocation to null as well. Setting this property to true while ServiceLocation hasn't been fetched disables lazy loading for ServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocation
		{
			get { return _alreadyFetchedServiceLocation;}
			set 
			{
				if(_alreadyFetchedServiceLocation && !value)
				{
					this.ServiceLocation = null;
				}
				_alreadyFetchedServiceLocation = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ServiceLocation is not found
		/// in the database. When set to true, ServiceLocation will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ServiceLocationReturnsNewIfNotFound
		{
			get	{ return _serviceLocationReturnsNewIfNotFound; }
			set { _serviceLocationReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity; }
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
