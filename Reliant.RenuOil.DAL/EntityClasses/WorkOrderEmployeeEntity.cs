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
	/// Entity class which represents the entity 'WorkOrderEmployee'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class WorkOrderEmployeeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection	_assetReclamationService;
		private bool	_alwaysFetchAssetReclamationService, _alreadyFetchedAssetReclamationService;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection	_deepFryerService;
		private bool	_alwaysFetchDeepFryerService, _alreadyFetchedDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection	_recycleService;
		private bool	_alwaysFetchRecycleService, _alreadyFetchedRecycleService;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection _deepFryerCollectionViaDeepFryerService;
		private bool	_alwaysFetchDeepFryerCollectionViaDeepFryerService, _alreadyFetchedDeepFryerCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaDeepFryerService;
		private bool	_alwaysFetchEmployeeCollectionViaDeepFryerService, _alreadyFetchedEmployeeCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaDeepFryerService;
		private bool	_alwaysFetchServiceLocationCollectionViaDeepFryerService, _alreadyFetchedServiceLocationCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection _serviceLocationAssetTypeCollectionViaAssetReclamationService;
		private bool	_alwaysFetchServiceLocationAssetTypeCollectionViaAssetReclamationService, _alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService;
		private ServiceLocationEntity _serviceLocation;
		private bool	_alwaysFetchServiceLocation, _alreadyFetchedServiceLocation, _serviceLocationReturnsNewIfNotFound;
		private WorkOrderEntity _workOrder;
		private bool	_alwaysFetchWorkOrder, _alreadyFetchedWorkOrder, _workOrderReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name WorkOrder</summary>
			public static readonly string WorkOrder = "WorkOrder";
			/// <summary>Member name AssetReclamationService</summary>
			public static readonly string AssetReclamationService = "AssetReclamationService";
			/// <summary>Member name DeepFryerService</summary>
			public static readonly string DeepFryerService = "DeepFryerService";
			/// <summary>Member name RecycleService</summary>
			public static readonly string RecycleService = "RecycleService";
			/// <summary>Member name DeepFryerCollectionViaDeepFryerService</summary>
			public static readonly string DeepFryerCollectionViaDeepFryerService = "DeepFryerCollectionViaDeepFryerService";
			/// <summary>Member name EmployeeCollectionViaDeepFryerService</summary>
			public static readonly string EmployeeCollectionViaDeepFryerService = "EmployeeCollectionViaDeepFryerService";
			/// <summary>Member name ServiceLocationCollectionViaDeepFryerService</summary>
			public static readonly string ServiceLocationCollectionViaDeepFryerService = "ServiceLocationCollectionViaDeepFryerService";
			/// <summary>Member name ServiceLocationAssetTypeCollectionViaAssetReclamationService</summary>
			public static readonly string ServiceLocationAssetTypeCollectionViaAssetReclamationService = "ServiceLocationAssetTypeCollectionViaAssetReclamationService";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static WorkOrderEmployeeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public WorkOrderEmployeeEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="workOrderEmployeeId">PK value for WorkOrderEmployee which data should be fetched into this WorkOrderEmployee object</param>
		public WorkOrderEmployeeEntity(System.Int32 workOrderEmployeeId)
		{
			InitClassFetch(workOrderEmployeeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="workOrderEmployeeId">PK value for WorkOrderEmployee which data should be fetched into this WorkOrderEmployee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public WorkOrderEmployeeEntity(System.Int32 workOrderEmployeeId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(workOrderEmployeeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="workOrderEmployeeId">PK value for WorkOrderEmployee which data should be fetched into this WorkOrderEmployee object</param>
		/// <param name="validator">The custom validator object for this WorkOrderEmployeeEntity</param>
		public WorkOrderEmployeeEntity(System.Int32 workOrderEmployeeId, IValidator validator)
		{
			InitClassFetch(workOrderEmployeeId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected WorkOrderEmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_assetReclamationService = (Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection)info.GetValue("_assetReclamationService", typeof(Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection));
			_alwaysFetchAssetReclamationService = info.GetBoolean("_alwaysFetchAssetReclamationService");
			_alreadyFetchedAssetReclamationService = info.GetBoolean("_alreadyFetchedAssetReclamationService");
			_deepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection)info.GetValue("_deepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection));
			_alwaysFetchDeepFryerService = info.GetBoolean("_alwaysFetchDeepFryerService");
			_alreadyFetchedDeepFryerService = info.GetBoolean("_alreadyFetchedDeepFryerService");
			_recycleService = (Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection)info.GetValue("_recycleService", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection));
			_alwaysFetchRecycleService = info.GetBoolean("_alwaysFetchRecycleService");
			_alreadyFetchedRecycleService = info.GetBoolean("_alreadyFetchedRecycleService");
			_deepFryerCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection)info.GetValue("_deepFryerCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection));
			_alwaysFetchDeepFryerCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchDeepFryerCollectionViaDeepFryerService");
			_alreadyFetchedDeepFryerCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedDeepFryerCollectionViaDeepFryerService");
			_employeeCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchEmployeeCollectionViaDeepFryerService");
			_alreadyFetchedEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaDeepFryerService");
			_serviceLocationCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaDeepFryerService");
			_alreadyFetchedServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaDeepFryerService");
			_serviceLocationAssetTypeCollectionViaAssetReclamationService = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection)info.GetValue("_serviceLocationAssetTypeCollectionViaAssetReclamationService", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection));
			_alwaysFetchServiceLocationAssetTypeCollectionViaAssetReclamationService = info.GetBoolean("_alwaysFetchServiceLocationAssetTypeCollectionViaAssetReclamationService");
			_alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService = info.GetBoolean("_alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService");
			_serviceLocation = (ServiceLocationEntity)info.GetValue("_serviceLocation", typeof(ServiceLocationEntity));
			if(_serviceLocation!=null)
			{
				_serviceLocation.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_serviceLocationReturnsNewIfNotFound = info.GetBoolean("_serviceLocationReturnsNewIfNotFound");
			_alwaysFetchServiceLocation = info.GetBoolean("_alwaysFetchServiceLocation");
			_alreadyFetchedServiceLocation = info.GetBoolean("_alreadyFetchedServiceLocation");
			_workOrder = (WorkOrderEntity)info.GetValue("_workOrder", typeof(WorkOrderEntity));
			if(_workOrder!=null)
			{
				_workOrder.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_workOrderReturnsNewIfNotFound = info.GetBoolean("_workOrderReturnsNewIfNotFound");
			_alwaysFetchWorkOrder = info.GetBoolean("_alwaysFetchWorkOrder");
			_alreadyFetchedWorkOrder = info.GetBoolean("_alreadyFetchedWorkOrder");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((WorkOrderEmployeeFieldIndex)fieldIndex)
			{
				case WorkOrderEmployeeFieldIndex.WorkOrderId:
					DesetupSyncWorkOrder(true, false);
					_alreadyFetchedWorkOrder = false;
					break;
				case WorkOrderEmployeeFieldIndex.EmployeeId:
					DesetupSyncServiceLocation(true, false);
					_alreadyFetchedServiceLocation = false;
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
			_alreadyFetchedDeepFryerService = (_deepFryerService.Count > 0);
			_alreadyFetchedRecycleService = (_recycleService.Count > 0);
			_alreadyFetchedDeepFryerCollectionViaDeepFryerService = (_deepFryerCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedEmployeeCollectionViaDeepFryerService = (_employeeCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaDeepFryerService = (_serviceLocationCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService = (_serviceLocationAssetTypeCollectionViaAssetReclamationService.Count > 0);
			_alreadyFetchedServiceLocation = (_serviceLocation != null);
			_alreadyFetchedWorkOrder = (_workOrder != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return WorkOrderEmployeeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ServiceLocation":
					toReturn.Add(WorkOrderEmployeeEntity.Relations.ServiceLocationEntityUsingEmployeeId);
					break;
				case "WorkOrder":
					toReturn.Add(WorkOrderEmployeeEntity.Relations.WorkOrderEntityUsingWorkOrderId);
					break;
				case "AssetReclamationService":
					toReturn.Add(WorkOrderEmployeeEntity.Relations.AssetReclamationServiceEntityUsingWorkOrderServiceLocationId);
					break;
				case "DeepFryerService":
					toReturn.Add(WorkOrderEmployeeEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId);
					break;
				case "RecycleService":
					toReturn.Add(WorkOrderEmployeeEntity.Relations.RecycleServiceEntityUsingWorkOrderServiceLocationId);
					break;
				case "DeepFryerCollectionViaDeepFryerService":
					toReturn.Add(WorkOrderEmployeeEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId, "WorkOrderEmployeeEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerService":
					toReturn.Add(WorkOrderEmployeeEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId, "WorkOrderEmployeeEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaDeepFryerService":
					toReturn.Add(WorkOrderEmployeeEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId, "WorkOrderEmployeeEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationAssetTypeCollectionViaAssetReclamationService":
					toReturn.Add(WorkOrderEmployeeEntity.Relations.AssetReclamationServiceEntityUsingWorkOrderServiceLocationId, "WorkOrderEmployeeEntity__", "AssetReclamationService_", JoinHint.None);
					toReturn.Add(AssetReclamationServiceEntity.Relations.ServiceLocationAssetTypeEntityUsingServiceLocationAssetTypeId, "AssetReclamationService_", string.Empty, JoinHint.None);
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
			info.AddValue("_deepFryerService", (!this.MarkedForDeletion?_deepFryerService:null));
			info.AddValue("_alwaysFetchDeepFryerService", _alwaysFetchDeepFryerService);
			info.AddValue("_alreadyFetchedDeepFryerService", _alreadyFetchedDeepFryerService);
			info.AddValue("_recycleService", (!this.MarkedForDeletion?_recycleService:null));
			info.AddValue("_alwaysFetchRecycleService", _alwaysFetchRecycleService);
			info.AddValue("_alreadyFetchedRecycleService", _alreadyFetchedRecycleService);
			info.AddValue("_deepFryerCollectionViaDeepFryerService", (!this.MarkedForDeletion?_deepFryerCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchDeepFryerCollectionViaDeepFryerService", _alwaysFetchDeepFryerCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedDeepFryerCollectionViaDeepFryerService", _alreadyFetchedDeepFryerCollectionViaDeepFryerService);
			info.AddValue("_employeeCollectionViaDeepFryerService", (!this.MarkedForDeletion?_employeeCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaDeepFryerService", _alwaysFetchEmployeeCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaDeepFryerService", _alreadyFetchedEmployeeCollectionViaDeepFryerService);
			info.AddValue("_serviceLocationCollectionViaDeepFryerService", (!this.MarkedForDeletion?_serviceLocationCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaDeepFryerService", _alwaysFetchServiceLocationCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaDeepFryerService", _alreadyFetchedServiceLocationCollectionViaDeepFryerService);
			info.AddValue("_serviceLocationAssetTypeCollectionViaAssetReclamationService", (!this.MarkedForDeletion?_serviceLocationAssetTypeCollectionViaAssetReclamationService:null));
			info.AddValue("_alwaysFetchServiceLocationAssetTypeCollectionViaAssetReclamationService", _alwaysFetchServiceLocationAssetTypeCollectionViaAssetReclamationService);
			info.AddValue("_alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService", _alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService);
			info.AddValue("_serviceLocation", (!this.MarkedForDeletion?_serviceLocation:null));
			info.AddValue("_serviceLocationReturnsNewIfNotFound", _serviceLocationReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchServiceLocation", _alwaysFetchServiceLocation);
			info.AddValue("_alreadyFetchedServiceLocation", _alreadyFetchedServiceLocation);
			info.AddValue("_workOrder", (!this.MarkedForDeletion?_workOrder:null));
			info.AddValue("_workOrderReturnsNewIfNotFound", _workOrderReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchWorkOrder", _alwaysFetchWorkOrder);
			info.AddValue("_alreadyFetchedWorkOrder", _alreadyFetchedWorkOrder);

			
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
				case "ServiceLocation":
					_alreadyFetchedServiceLocation = true;
					this.ServiceLocation = (ServiceLocationEntity)entity;
					break;
				case "WorkOrder":
					_alreadyFetchedWorkOrder = true;
					this.WorkOrder = (WorkOrderEntity)entity;
					break;
				case "AssetReclamationService":
					_alreadyFetchedAssetReclamationService = true;
					if(entity!=null)
					{
						this.AssetReclamationService.Add((AssetReclamationServiceEntity)entity);
					}
					break;
				case "DeepFryerService":
					_alreadyFetchedDeepFryerService = true;
					if(entity!=null)
					{
						this.DeepFryerService.Add((DeepFryerServiceEntity)entity);
					}
					break;
				case "RecycleService":
					_alreadyFetchedRecycleService = true;
					if(entity!=null)
					{
						this.RecycleService.Add((RecycleServiceEntity)entity);
					}
					break;
				case "DeepFryerCollectionViaDeepFryerService":
					_alreadyFetchedDeepFryerCollectionViaDeepFryerService = true;
					if(entity!=null)
					{
						this.DeepFryerCollectionViaDeepFryerService.Add((DeepFryerEntity)entity);
					}
					break;
				case "EmployeeCollectionViaDeepFryerService":
					_alreadyFetchedEmployeeCollectionViaDeepFryerService = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaDeepFryerService.Add((EmployeeEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaDeepFryerService":
					_alreadyFetchedServiceLocationCollectionViaDeepFryerService = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaDeepFryerService.Add((ServiceLocationEntity)entity);
					}
					break;
				case "ServiceLocationAssetTypeCollectionViaAssetReclamationService":
					_alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService = true;
					if(entity!=null)
					{
						this.ServiceLocationAssetTypeCollectionViaAssetReclamationService.Add((ServiceLocationAssetTypeEntity)entity);
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
				case "ServiceLocation":
					SetupSyncServiceLocation(relatedEntity);
					break;
				case "WorkOrder":
					SetupSyncWorkOrder(relatedEntity);
					break;
				case "AssetReclamationService":
					_assetReclamationService.Add((AssetReclamationServiceEntity)relatedEntity);
					break;
				case "DeepFryerService":
					_deepFryerService.Add((DeepFryerServiceEntity)relatedEntity);
					break;
				case "RecycleService":
					_recycleService.Add((RecycleServiceEntity)relatedEntity);
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
				case "ServiceLocation":
					DesetupSyncServiceLocation(false, true);
					break;
				case "WorkOrder":
					DesetupSyncWorkOrder(false, true);
					break;
				case "AssetReclamationService":
					base.PerformRelatedEntityRemoval(_assetReclamationService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerService":
					base.PerformRelatedEntityRemoval(_deepFryerService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleService":
					base.PerformRelatedEntityRemoval(_recycleService, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_serviceLocation!=null)
			{
				toReturn.Add(_serviceLocation);
			}
			if(_workOrder!=null)
			{
				toReturn.Add(_workOrder);
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
			toReturn.Add(_deepFryerService);
			toReturn.Add(_recycleService);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderEmployeeId">PK value for WorkOrderEmployee which data should be fetched into this WorkOrderEmployee object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderEmployeeId)
		{
			return FetchUsingPK(workOrderEmployeeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderEmployeeId">PK value for WorkOrderEmployee which data should be fetched into this WorkOrderEmployee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderEmployeeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(workOrderEmployeeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderEmployeeId">PK value for WorkOrderEmployee which data should be fetched into this WorkOrderEmployee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderEmployeeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(workOrderEmployeeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="workOrderEmployeeId">PK value for WorkOrderEmployee which data should be fetched into this WorkOrderEmployee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderEmployeeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(workOrderEmployeeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.WorkOrderEmployeeId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(WorkOrderEmployeeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(WorkOrderEmployeeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new WorkOrderEmployeeRelations().GetAllRelations();
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
				_assetReclamationService.GetMultiManyToOne(null, this, null, filter);
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
				_deepFryerService.GetMultiManyToOne(null, null, null, this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection GetMultiRecycleService(bool forceFetch)
		{
			return GetMultiRecycleService(forceFetch, _recycleService.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'RecycleServiceEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection GetMultiRecycleService(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiRecycleService(forceFetch, _recycleService.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection GetMultiRecycleService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiRecycleService(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection GetMultiRecycleService(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedRecycleService || forceFetch || _alwaysFetchRecycleService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_recycleService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_recycleService);
					}
				}
				_recycleService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_recycleService.EntityFactoryToUse = entityFactoryToUse;
				}
				_recycleService.GetMultiManyToOne(this, null, filter);
				_recycleService.SuppressClearInGetMulti=false;
				_alreadyFetchedRecycleService = true;
			}
			return _recycleService;
		}

		/// <summary> Sets the collection parameters for the collection for 'RecycleService'. These settings will be taken into account
		/// when the property RecycleService is requested or GetMultiRecycleService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRecycleService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_recycleService.SortClauses=sortClauses;
			_recycleService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(WorkOrderEmployeeFields.WorkOrderEmployeeId, ComparisonOperator.Equal, this.WorkOrderEmployeeId, "WorkOrderEmployeeEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(WorkOrderEmployeeFields.WorkOrderEmployeeId, ComparisonOperator.Equal, this.WorkOrderEmployeeId, "WorkOrderEmployeeEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(WorkOrderEmployeeFields.WorkOrderEmployeeId, ComparisonOperator.Equal, this.WorkOrderEmployeeId, "WorkOrderEmployeeEntity__"));
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

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationAssetTypeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetTypeCollectionViaAssetReclamationService(bool forceFetch)
		{
			return GetMultiServiceLocationAssetTypeCollectionViaAssetReclamationService(forceFetch, _serviceLocationAssetTypeCollectionViaAssetReclamationService.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection GetMultiServiceLocationAssetTypeCollectionViaAssetReclamationService(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService || forceFetch || _alwaysFetchServiceLocationAssetTypeCollectionViaAssetReclamationService) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationAssetTypeCollectionViaAssetReclamationService.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationAssetTypeCollectionViaAssetReclamationService);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(WorkOrderEmployeeFields.WorkOrderEmployeeId, ComparisonOperator.Equal, this.WorkOrderEmployeeId, "WorkOrderEmployeeEntity__"));
				_serviceLocationAssetTypeCollectionViaAssetReclamationService.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationAssetTypeCollectionViaAssetReclamationService.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationAssetTypeCollectionViaAssetReclamationService.GetMulti(filter, GetRelationsForField("ServiceLocationAssetTypeCollectionViaAssetReclamationService"));
				_serviceLocationAssetTypeCollectionViaAssetReclamationService.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService = true;
			}
			return _serviceLocationAssetTypeCollectionViaAssetReclamationService;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationAssetTypeCollectionViaAssetReclamationService'. These settings will be taken into account
		/// when the property ServiceLocationAssetTypeCollectionViaAssetReclamationService is requested or GetMultiServiceLocationAssetTypeCollectionViaAssetReclamationService is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationAssetTypeCollectionViaAssetReclamationService(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationAssetTypeCollectionViaAssetReclamationService.SortClauses=sortClauses;
			_serviceLocationAssetTypeCollectionViaAssetReclamationService.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(WorkOrderEmployeeEntity.Relations.ServiceLocationEntityUsingEmployeeId);

				ServiceLocationEntity newEntity = new ServiceLocationEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.EmployeeId);
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

		/// <summary> Retrieves the related entity of type 'WorkOrderEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'WorkOrderEntity' which is related to this entity.</returns>
		public WorkOrderEntity GetSingleWorkOrder()
		{
			return GetSingleWorkOrder(false);
		}

		/// <summary> Retrieves the related entity of type 'WorkOrderEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'WorkOrderEntity' which is related to this entity.</returns>
		public virtual WorkOrderEntity GetSingleWorkOrder(bool forceFetch)
		{
			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(WorkOrderEmployeeEntity.Relations.WorkOrderEntityUsingWorkOrderId);

				WorkOrderEntity newEntity = new WorkOrderEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.WorkOrderId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (WorkOrderEntity)base.ActiveContext.Get(newEntity);
					}
					this.WorkOrder = newEntity;
				}
				else
				{
					if(_workOrderReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_workOrder == null)))
						{
							this.WorkOrder = newEntity;
						}
					}
					else
					{
						this.WorkOrder = null;
					}
				}
				_alreadyFetchedWorkOrder = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _workOrder;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			WorkOrderEmployeeDAO dao = (WorkOrderEmployeeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_assetReclamationService.ActiveContext = base.ActiveContext;
			_deepFryerService.ActiveContext = base.ActiveContext;
			_recycleService.ActiveContext = base.ActiveContext;
			_deepFryerCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_employeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_serviceLocationAssetTypeCollectionViaAssetReclamationService.ActiveContext = base.ActiveContext;
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
			}
			if(_workOrder!=null)
			{
				_workOrder.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			WorkOrderEmployeeDAO dao = (WorkOrderEmployeeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			WorkOrderEmployeeDAO dao = (WorkOrderEmployeeDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity);
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
			toReturn.Add("ServiceLocation", _serviceLocation);
			toReturn.Add("WorkOrder", _workOrder);
			toReturn.Add("AssetReclamationService", _assetReclamationService);
			toReturn.Add("DeepFryerService", _deepFryerService);
			toReturn.Add("RecycleService", _recycleService);
			toReturn.Add("DeepFryerCollectionViaDeepFryerService", _deepFryerCollectionViaDeepFryerService);
			toReturn.Add("EmployeeCollectionViaDeepFryerService", _employeeCollectionViaDeepFryerService);
			toReturn.Add("ServiceLocationCollectionViaDeepFryerService", _serviceLocationCollectionViaDeepFryerService);
			toReturn.Add("ServiceLocationAssetTypeCollectionViaAssetReclamationService", _serviceLocationAssetTypeCollectionViaAssetReclamationService);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="workOrderEmployeeId">PK value for WorkOrderEmployee which data should be fetched into this WorkOrderEmployee object</param>
		/// <param name="validator">The validator object for this WorkOrderEmployeeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 workOrderEmployeeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(workOrderEmployeeId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_assetReclamationService = new Reliant.RenuOil.DAL.CollectionClasses.AssetReclamationServiceCollection(new AssetReclamationServiceEntityFactory());
			_assetReclamationService.SetContainingEntityInfo(this, "WorkOrderEmployee");
			_alwaysFetchAssetReclamationService = false;
			_alreadyFetchedAssetReclamationService = false;
			_deepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(new DeepFryerServiceEntityFactory());
			_deepFryerService.SetContainingEntityInfo(this, "WorkOrderEmployee");
			_alwaysFetchDeepFryerService = false;
			_alreadyFetchedDeepFryerService = false;
			_recycleService = new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(new RecycleServiceEntityFactory());
			_recycleService.SetContainingEntityInfo(this, "WorkOrderEmployee");
			_alwaysFetchRecycleService = false;
			_alreadyFetchedRecycleService = false;
			_deepFryerCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(new DeepFryerEntityFactory());
			_alwaysFetchDeepFryerCollectionViaDeepFryerService = false;
			_alreadyFetchedDeepFryerCollectionViaDeepFryerService = false;
			_employeeCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaDeepFryerService = false;
			_alreadyFetchedEmployeeCollectionViaDeepFryerService = false;
			_serviceLocationCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaDeepFryerService = false;
			_alreadyFetchedServiceLocationCollectionViaDeepFryerService = false;
			_serviceLocationAssetTypeCollectionViaAssetReclamationService = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection(new ServiceLocationAssetTypeEntityFactory());
			_alwaysFetchServiceLocationAssetTypeCollectionViaAssetReclamationService = false;
			_alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService = false;
			_serviceLocation = null;
			_serviceLocationReturnsNewIfNotFound = true;
			_alwaysFetchServiceLocation = false;
			_alreadyFetchedServiceLocation = false;
			_workOrder = null;
			_workOrderReturnsNewIfNotFound = true;
			_alwaysFetchWorkOrder = false;
			_alreadyFetchedWorkOrder = false;


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

			_fieldsCustomProperties.Add("WorkOrderEmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("WorkOrderId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("EmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Notes", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("UncategorizedItems", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _serviceLocation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", WorkOrderEmployeeEntity.Relations.ServiceLocationEntityUsingEmployeeId, true, signalRelatedEntity, "WorkOrderEmployee", resetFKFields, new int[] { (int)WorkOrderEmployeeFieldIndex.EmployeeId } );		
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
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", WorkOrderEmployeeEntity.Relations.ServiceLocationEntityUsingEmployeeId, true, ref _alreadyFetchedServiceLocation, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _workOrder</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrder(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", WorkOrderEmployeeEntity.Relations.WorkOrderEntityUsingWorkOrderId, true, signalRelatedEntity, "WorkOrderEmployee", resetFKFields, new int[] { (int)WorkOrderEmployeeFieldIndex.WorkOrderId } );		
			_workOrder = null;
		}
		
		/// <summary> setups the sync logic for member _workOrder</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrder(IEntity relatedEntity)
		{
			if(_workOrder!=relatedEntity)
			{		
				DesetupSyncWorkOrder(true, true);
				_workOrder = (WorkOrderEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", WorkOrderEmployeeEntity.Relations.WorkOrderEntityUsingWorkOrderId, true, ref _alreadyFetchedWorkOrder, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWorkOrderPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="workOrderEmployeeId">PK value for WorkOrderEmployee which data should be fetched into this WorkOrderEmployee object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 workOrderEmployeeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)WorkOrderEmployeeFieldIndex.WorkOrderEmployeeId].ForcedCurrentValueWrite(workOrderEmployeeId);
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
			return DAOFactory.CreateWorkOrderEmployeeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new WorkOrderEmployeeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static WorkOrderEmployeeRelations Relations
		{
			get	{ return new WorkOrderEmployeeRelations(); }
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
					(IEntityRelation)GetRelationsForField("AssetReclamationService")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity, 0, null, null, null, "AssetReclamationService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("DeepFryerService")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, null, "DeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleService
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection(),
					(IEntityRelation)GetRelationsForField("RecycleService")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, null, "RecycleService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderEmployeeEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, GetRelationsForField("DeepFryerCollectionViaDeepFryerService"), "DeepFryerCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderEmployeeEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerService"), "EmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderEmployeeEntity.Relations.DeepFryerServiceEntityUsingWorkOrderServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerService"), "ServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocationAssetType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationAssetTypeCollectionViaAssetReclamationService
		{
			get
			{
				IEntityRelation intermediateRelation = WorkOrderEmployeeEntity.Relations.AssetReclamationServiceEntityUsingWorkOrderServiceLocationId;
				intermediateRelation.SetAliases(string.Empty, "AssetReclamationService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity, 0, null, null, GetRelationsForField("ServiceLocationAssetTypeCollectionViaAssetReclamationService"), "ServiceLocationAssetTypeCollectionViaAssetReclamationService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
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
					(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "WorkOrderEmployeeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return WorkOrderEmployeeEntity.CustomProperties;}
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
			get { return WorkOrderEmployeeEntity.FieldsCustomProperties;}
		}

		/// <summary> The WorkOrderEmployeeId property of the Entity WorkOrderEmployee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrderServiceLocation"."WorkOrderServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 WorkOrderEmployeeId
		{
			get { return (System.Int32)GetValue((int)WorkOrderEmployeeFieldIndex.WorkOrderEmployeeId, true); }
			set	{ SetValue((int)WorkOrderEmployeeFieldIndex.WorkOrderEmployeeId, value, true); }
		}
		/// <summary> The WorkOrderId property of the Entity WorkOrderEmployee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrderServiceLocation"."WorkOrderId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 WorkOrderId
		{
			get { return (System.Int32)GetValue((int)WorkOrderEmployeeFieldIndex.WorkOrderId, true); }
			set	{ SetValue((int)WorkOrderEmployeeFieldIndex.WorkOrderId, value, true); }
		}
		/// <summary> The EmployeeId property of the Entity WorkOrderEmployee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrderServiceLocation"."ServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 EmployeeId
		{
			get { return (System.Int32)GetValue((int)WorkOrderEmployeeFieldIndex.EmployeeId, true); }
			set	{ SetValue((int)WorkOrderEmployeeFieldIndex.EmployeeId, value, true); }
		}
		/// <summary> The Notes property of the Entity WorkOrderEmployee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrderServiceLocation"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)WorkOrderEmployeeFieldIndex.Notes, true); }
			set	{ SetValue((int)WorkOrderEmployeeFieldIndex.Notes, value, true); }
		}
		/// <summary> The UncategorizedItems property of the Entity WorkOrderEmployee<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "WorkOrderServiceLocation"."UncategorizedItems"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String UncategorizedItems
		{
			get { return (System.String)GetValue((int)WorkOrderEmployeeFieldIndex.UncategorizedItems, true); }
			set	{ SetValue((int)WorkOrderEmployeeFieldIndex.UncategorizedItems, value, true); }
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
		/// <summary> Retrieves all related entities of type 'RecycleServiceEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecycleService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.RecycleServiceCollection RecycleService
		{
			get	{ return GetMultiRecycleService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RecycleService. When set to true, RecycleService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RecycleService is accessed. You can always execute
		/// a forced fetch by calling GetMultiRecycleService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRecycleService
		{
			get	{ return _alwaysFetchRecycleService; }
			set	{ _alwaysFetchRecycleService = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property RecycleService already has been fetched. Setting this property to false when RecycleService has been fetched
		/// will clear the RecycleService collection well. Setting this property to true while RecycleService hasn't been fetched disables lazy loading for RecycleService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRecycleService
		{
			get { return _alreadyFetchedRecycleService;}
			set 
			{
				if(_alreadyFetchedRecycleService && !value && (_recycleService != null))
				{
					_recycleService.Clear();
				}
				_alreadyFetchedRecycleService = value;
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
		/// <summary> Retrieves all related entities of type 'ServiceLocationAssetTypeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationAssetTypeCollectionViaAssetReclamationService()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationAssetTypeCollection ServiceLocationAssetTypeCollectionViaAssetReclamationService
		{
			get { return GetMultiServiceLocationAssetTypeCollectionViaAssetReclamationService(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationAssetTypeCollectionViaAssetReclamationService. When set to true, ServiceLocationAssetTypeCollectionViaAssetReclamationService is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationAssetTypeCollectionViaAssetReclamationService is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationAssetTypeCollectionViaAssetReclamationService(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationAssetTypeCollectionViaAssetReclamationService
		{
			get	{ return _alwaysFetchServiceLocationAssetTypeCollectionViaAssetReclamationService; }
			set	{ _alwaysFetchServiceLocationAssetTypeCollectionViaAssetReclamationService = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationAssetTypeCollectionViaAssetReclamationService already has been fetched. Setting this property to false when ServiceLocationAssetTypeCollectionViaAssetReclamationService has been fetched
		/// will clear the ServiceLocationAssetTypeCollectionViaAssetReclamationService collection well. Setting this property to true while ServiceLocationAssetTypeCollectionViaAssetReclamationService hasn't been fetched disables lazy loading for ServiceLocationAssetTypeCollectionViaAssetReclamationService</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService
		{
			get { return _alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService;}
			set 
			{
				if(_alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService && !value && (_serviceLocationAssetTypeCollectionViaAssetReclamationService != null))
				{
					_serviceLocationAssetTypeCollectionViaAssetReclamationService.Clear();
				}
				_alreadyFetchedServiceLocationAssetTypeCollectionViaAssetReclamationService = value;
			}
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
							_serviceLocation.UnsetRelatedEntity(this, "WorkOrderEmployee");
						}
					}
					else
					{
						if(_serviceLocation!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "WorkOrderEmployee");
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
		/// <summary> Gets / sets related entity of type 'WorkOrderEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual WorkOrderEntity WorkOrder
		{
			get	{ return GetSingleWorkOrder(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncWorkOrder(value);
				}
				else
				{
					if(value==null)
					{
						if(_workOrder != null)
						{
							_workOrder.UnsetRelatedEntity(this, "WorkOrderEmployee");
						}
					}
					else
					{
						if(_workOrder!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "WorkOrderEmployee");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrder. When set to true, WorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetSingleWorkOrder(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrder
		{
			get	{ return _alwaysFetchWorkOrder; }
			set	{ _alwaysFetchWorkOrder = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrder already has been fetched. Setting this property to false when WorkOrder has been fetched
		/// will set WorkOrder to null as well. Setting this property to true while WorkOrder hasn't been fetched disables lazy loading for WorkOrder</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrder
		{
			get { return _alreadyFetchedWorkOrder;}
			set 
			{
				if(_alreadyFetchedWorkOrder && !value)
				{
					this.WorkOrder = null;
				}
				_alreadyFetchedWorkOrder = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property WorkOrder is not found
		/// in the database. When set to true, WorkOrder will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool WorkOrderReturnsNewIfNotFound
		{
			get	{ return _workOrderReturnsNewIfNotFound; }
			set { _workOrderReturnsNewIfNotFound = value; }	
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity; }
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
