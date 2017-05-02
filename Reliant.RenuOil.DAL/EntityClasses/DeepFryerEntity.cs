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
	/// Entity class which represents the entity 'DeepFryer'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DeepFryerEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection	_deepFryerChangeLog;
		private bool	_alwaysFetchDeepFryerChangeLog, _alreadyFetchedDeepFryerChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection	_deepFryerService;
		private bool	_alwaysFetchDeepFryerService, _alreadyFetchedDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection _changeLogCollectionViaDeepFryerChangeLog;
		private bool	_alwaysFetchChangeLogCollectionViaDeepFryerChangeLog, _alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaDeepFryerService;
		private bool	_alwaysFetchEmployeeCollectionViaDeepFryerService, _alreadyFetchedEmployeeCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaDeepFryerService;
		private bool	_alwaysFetchServiceLocationCollectionViaDeepFryerService, _alreadyFetchedServiceLocationCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection _workOrderEmployeeCollectionViaDeepFryerService;
		private bool	_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService, _alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService;
		private Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection _workOrderServiceLocationCollectionViaDeepFryerService;
		private bool	_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService, _alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService;
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
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name DeepFryerChangeLog</summary>
			public static readonly string DeepFryerChangeLog = "DeepFryerChangeLog";
			/// <summary>Member name DeepFryerService</summary>
			public static readonly string DeepFryerService = "DeepFryerService";
			/// <summary>Member name ChangeLogCollectionViaDeepFryerChangeLog</summary>
			public static readonly string ChangeLogCollectionViaDeepFryerChangeLog = "ChangeLogCollectionViaDeepFryerChangeLog";
			/// <summary>Member name EmployeeCollectionViaDeepFryerService</summary>
			public static readonly string EmployeeCollectionViaDeepFryerService = "EmployeeCollectionViaDeepFryerService";
			/// <summary>Member name ServiceLocationCollectionViaDeepFryerService</summary>
			public static readonly string ServiceLocationCollectionViaDeepFryerService = "ServiceLocationCollectionViaDeepFryerService";
			/// <summary>Member name WorkOrderEmployeeCollectionViaDeepFryerService</summary>
			public static readonly string WorkOrderEmployeeCollectionViaDeepFryerService = "WorkOrderEmployeeCollectionViaDeepFryerService";
			/// <summary>Member name WorkOrderServiceLocationCollectionViaDeepFryerService</summary>
			public static readonly string WorkOrderServiceLocationCollectionViaDeepFryerService = "WorkOrderServiceLocationCollectionViaDeepFryerService";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DeepFryerEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public DeepFryerEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		public DeepFryerEntity(System.Int32 deepFryerId)
		{
			InitClassFetch(deepFryerId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public DeepFryerEntity(System.Int32 deepFryerId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(deepFryerId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		/// <param name="validator">The custom validator object for this DeepFryerEntity</param>
		public DeepFryerEntity(System.Int32 deepFryerId, IValidator validator)
		{
			InitClassFetch(deepFryerId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DeepFryerEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_deepFryerChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection)info.GetValue("_deepFryerChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection));
			_alwaysFetchDeepFryerChangeLog = info.GetBoolean("_alwaysFetchDeepFryerChangeLog");
			_alreadyFetchedDeepFryerChangeLog = info.GetBoolean("_alreadyFetchedDeepFryerChangeLog");
			_deepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection)info.GetValue("_deepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection));
			_alwaysFetchDeepFryerService = info.GetBoolean("_alwaysFetchDeepFryerService");
			_alreadyFetchedDeepFryerService = info.GetBoolean("_alreadyFetchedDeepFryerService");
			_changeLogCollectionViaDeepFryerChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection)info.GetValue("_changeLogCollectionViaDeepFryerChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection));
			_alwaysFetchChangeLogCollectionViaDeepFryerChangeLog = info.GetBoolean("_alwaysFetchChangeLogCollectionViaDeepFryerChangeLog");
			_alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog = info.GetBoolean("_alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog");
			_employeeCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchEmployeeCollectionViaDeepFryerService");
			_alreadyFetchedEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaDeepFryerService");
			_serviceLocationCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaDeepFryerService");
			_alreadyFetchedServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaDeepFryerService");
			_workOrderEmployeeCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection)info.GetValue("_workOrderEmployeeCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection));
			_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService");
			_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService");
			_workOrderServiceLocationCollectionViaDeepFryerService = (Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection)info.GetValue("_workOrderServiceLocationCollectionViaDeepFryerService", typeof(Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection));
			_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService");
			_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = info.GetBoolean("_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService");
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
			switch((DeepFryerFieldIndex)fieldIndex)
			{
				case DeepFryerFieldIndex.ServiceLocationId:
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
			_alreadyFetchedDeepFryerChangeLog = (_deepFryerChangeLog.Count > 0);
			_alreadyFetchedDeepFryerService = (_deepFryerService.Count > 0);
			_alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog = (_changeLogCollectionViaDeepFryerChangeLog.Count > 0);
			_alreadyFetchedEmployeeCollectionViaDeepFryerService = (_employeeCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaDeepFryerService = (_serviceLocationCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = (_workOrderEmployeeCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = (_workOrderServiceLocationCollectionViaDeepFryerService.Count > 0);
			_alreadyFetchedServiceLocation = (_serviceLocation != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return DeepFryerEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(DeepFryerEntity.Relations.ServiceLocationEntityUsingServiceLocationId);
					break;
				case "DeepFryerChangeLog":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerChangeLogEntityUsingDeepFryerId);
					break;
				case "DeepFryerService":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId);
					break;
				case "ChangeLogCollectionViaDeepFryerChangeLog":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerChangeLogEntityUsingDeepFryerId, "DeepFryerEntity__", "DeepFryerChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerChangeLogEntity.Relations.ChangeLogEntityUsingChangeLogId, "DeepFryerChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerService":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId, "DeepFryerEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaDeepFryerService":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId, "DeepFryerEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderEmployeeCollectionViaDeepFryerService":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId, "DeepFryerEntity__", "DeepFryerService_", JoinHint.None);
					toReturn.Add(DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, "DeepFryerService_", string.Empty, JoinHint.None);
					break;
				case "WorkOrderServiceLocationCollectionViaDeepFryerService":
					toReturn.Add(DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId, "DeepFryerEntity__", "DeepFryerService_", JoinHint.None);
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
			info.AddValue("_deepFryerChangeLog", (!this.MarkedForDeletion?_deepFryerChangeLog:null));
			info.AddValue("_alwaysFetchDeepFryerChangeLog", _alwaysFetchDeepFryerChangeLog);
			info.AddValue("_alreadyFetchedDeepFryerChangeLog", _alreadyFetchedDeepFryerChangeLog);
			info.AddValue("_deepFryerService", (!this.MarkedForDeletion?_deepFryerService:null));
			info.AddValue("_alwaysFetchDeepFryerService", _alwaysFetchDeepFryerService);
			info.AddValue("_alreadyFetchedDeepFryerService", _alreadyFetchedDeepFryerService);
			info.AddValue("_changeLogCollectionViaDeepFryerChangeLog", (!this.MarkedForDeletion?_changeLogCollectionViaDeepFryerChangeLog:null));
			info.AddValue("_alwaysFetchChangeLogCollectionViaDeepFryerChangeLog", _alwaysFetchChangeLogCollectionViaDeepFryerChangeLog);
			info.AddValue("_alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog", _alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog);
			info.AddValue("_employeeCollectionViaDeepFryerService", (!this.MarkedForDeletion?_employeeCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaDeepFryerService", _alwaysFetchEmployeeCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaDeepFryerService", _alreadyFetchedEmployeeCollectionViaDeepFryerService);
			info.AddValue("_serviceLocationCollectionViaDeepFryerService", (!this.MarkedForDeletion?_serviceLocationCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaDeepFryerService", _alwaysFetchServiceLocationCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaDeepFryerService", _alreadyFetchedServiceLocationCollectionViaDeepFryerService);
			info.AddValue("_workOrderEmployeeCollectionViaDeepFryerService", (!this.MarkedForDeletion?_workOrderEmployeeCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService", _alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService", _alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService);
			info.AddValue("_workOrderServiceLocationCollectionViaDeepFryerService", (!this.MarkedForDeletion?_workOrderServiceLocationCollectionViaDeepFryerService:null));
			info.AddValue("_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService", _alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService);
			info.AddValue("_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService", _alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService);
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
				case "ServiceLocation":
					_alreadyFetchedServiceLocation = true;
					this.ServiceLocation = (ServiceLocationEntity)entity;
					break;
				case "DeepFryerChangeLog":
					_alreadyFetchedDeepFryerChangeLog = true;
					if(entity!=null)
					{
						this.DeepFryerChangeLog.Add((DeepFryerChangeLogEntity)entity);
					}
					break;
				case "DeepFryerService":
					_alreadyFetchedDeepFryerService = true;
					if(entity!=null)
					{
						this.DeepFryerService.Add((DeepFryerServiceEntity)entity);
					}
					break;
				case "ChangeLogCollectionViaDeepFryerChangeLog":
					_alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog = true;
					if(entity!=null)
					{
						this.ChangeLogCollectionViaDeepFryerChangeLog.Add((ChangeLogEntity)entity);
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
				case "ServiceLocation":
					SetupSyncServiceLocation(relatedEntity);
					break;
				case "DeepFryerChangeLog":
					_deepFryerChangeLog.Add((DeepFryerChangeLogEntity)relatedEntity);
					break;
				case "DeepFryerService":
					_deepFryerService.Add((DeepFryerServiceEntity)relatedEntity);
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
				case "DeepFryerChangeLog":
					base.PerformRelatedEntityRemoval(_deepFryerChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "DeepFryerService":
					base.PerformRelatedEntityRemoval(_deepFryerService, relatedEntity, signalRelatedEntityManyToOne);
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


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_deepFryerChangeLog);
			toReturn.Add(_deepFryerService);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerId)
		{
			return FetchUsingPK(deepFryerId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(deepFryerId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(deepFryerId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(deepFryerId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DeepFryerId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DeepFryerFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DeepFryerFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DeepFryerRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'DeepFryerChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection GetMultiDeepFryerChangeLog(bool forceFetch)
		{
			return GetMultiDeepFryerChangeLog(forceFetch, _deepFryerChangeLog.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection GetMultiDeepFryerChangeLog(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiDeepFryerChangeLog(forceFetch, _deepFryerChangeLog.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection GetMultiDeepFryerChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiDeepFryerChangeLog(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection GetMultiDeepFryerChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedDeepFryerChangeLog || forceFetch || _alwaysFetchDeepFryerChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryerChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryerChangeLog);
					}
				}
				_deepFryerChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryerChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryerChangeLog.GetMultiManyToOne(null, this, filter);
				_deepFryerChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryerChangeLog = true;
			}
			return _deepFryerChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryerChangeLog'. These settings will be taken into account
		/// when the property DeepFryerChangeLog is requested or GetMultiDeepFryerChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryerChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryerChangeLog.SortClauses=sortClauses;
			_deepFryerChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_deepFryerService.GetMultiManyToOne(this, null, null, null, null, filter);
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

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLogCollectionViaDeepFryerChangeLog(bool forceFetch)
		{
			return GetMultiChangeLogCollectionViaDeepFryerChangeLog(forceFetch, _changeLogCollectionViaDeepFryerChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection GetMultiChangeLogCollectionViaDeepFryerChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog || forceFetch || _alwaysFetchChangeLogCollectionViaDeepFryerChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_changeLogCollectionViaDeepFryerChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_changeLogCollectionViaDeepFryerChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, ComparisonOperator.Equal, this.DeepFryerId, "DeepFryerEntity__"));
				_changeLogCollectionViaDeepFryerChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_changeLogCollectionViaDeepFryerChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_changeLogCollectionViaDeepFryerChangeLog.GetMulti(filter, GetRelationsForField("ChangeLogCollectionViaDeepFryerChangeLog"));
				_changeLogCollectionViaDeepFryerChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog = true;
			}
			return _changeLogCollectionViaDeepFryerChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'ChangeLogCollectionViaDeepFryerChangeLog'. These settings will be taken into account
		/// when the property ChangeLogCollectionViaDeepFryerChangeLog is requested or GetMultiChangeLogCollectionViaDeepFryerChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersChangeLogCollectionViaDeepFryerChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_changeLogCollectionViaDeepFryerChangeLog.SortClauses=sortClauses;
			_changeLogCollectionViaDeepFryerChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				filter.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, ComparisonOperator.Equal, this.DeepFryerId, "DeepFryerEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, ComparisonOperator.Equal, this.DeepFryerId, "DeepFryerEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, ComparisonOperator.Equal, this.DeepFryerId, "DeepFryerEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(DeepFryerFields.DeepFryerId, ComparisonOperator.Equal, this.DeepFryerId, "DeepFryerEntity__"));
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerEntity.Relations.ServiceLocationEntityUsingServiceLocationId);

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
			DeepFryerDAO dao = (DeepFryerDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_deepFryerChangeLog.ActiveContext = base.ActiveContext;
			_deepFryerService.ActiveContext = base.ActiveContext;
			_changeLogCollectionViaDeepFryerChangeLog.ActiveContext = base.ActiveContext;
			_employeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_workOrderEmployeeCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			_workOrderServiceLocationCollectionViaDeepFryerService.ActiveContext = base.ActiveContext;
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			DeepFryerDAO dao = (DeepFryerDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			DeepFryerDAO dao = (DeepFryerDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.DeepFryerEntity);
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
			toReturn.Add("DeepFryerChangeLog", _deepFryerChangeLog);
			toReturn.Add("DeepFryerService", _deepFryerService);
			toReturn.Add("ChangeLogCollectionViaDeepFryerChangeLog", _changeLogCollectionViaDeepFryerChangeLog);
			toReturn.Add("EmployeeCollectionViaDeepFryerService", _employeeCollectionViaDeepFryerService);
			toReturn.Add("ServiceLocationCollectionViaDeepFryerService", _serviceLocationCollectionViaDeepFryerService);
			toReturn.Add("WorkOrderEmployeeCollectionViaDeepFryerService", _workOrderEmployeeCollectionViaDeepFryerService);
			toReturn.Add("WorkOrderServiceLocationCollectionViaDeepFryerService", _workOrderServiceLocationCollectionViaDeepFryerService);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		/// <param name="validator">The validator object for this DeepFryerEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 deepFryerId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(deepFryerId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_deepFryerChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection(new DeepFryerChangeLogEntityFactory());
			_deepFryerChangeLog.SetContainingEntityInfo(this, "DeepFryer");
			_alwaysFetchDeepFryerChangeLog = false;
			_alreadyFetchedDeepFryerChangeLog = false;
			_deepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceCollection(new DeepFryerServiceEntityFactory());
			_deepFryerService.SetContainingEntityInfo(this, "DeepFryer");
			_alwaysFetchDeepFryerService = false;
			_alreadyFetchedDeepFryerService = false;
			_changeLogCollectionViaDeepFryerChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection(new ChangeLogEntityFactory());
			_alwaysFetchChangeLogCollectionViaDeepFryerChangeLog = false;
			_alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog = false;
			_employeeCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaDeepFryerService = false;
			_alreadyFetchedEmployeeCollectionViaDeepFryerService = false;
			_serviceLocationCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaDeepFryerService = false;
			_alreadyFetchedServiceLocationCollectionViaDeepFryerService = false;
			_workOrderEmployeeCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(new WorkOrderEmployeeEntityFactory());
			_alwaysFetchWorkOrderEmployeeCollectionViaDeepFryerService = false;
			_alreadyFetchedWorkOrderEmployeeCollectionViaDeepFryerService = false;
			_workOrderServiceLocationCollectionViaDeepFryerService = new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(new WorkOrderServiceLocationEntityFactory());
			_alwaysFetchWorkOrderServiceLocationCollectionViaDeepFryerService = false;
			_alreadyFetchedWorkOrderServiceLocationCollectionViaDeepFryerService = false;
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

			_fieldsCustomProperties.Add("DeepFryerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("SizeInGallons", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _serviceLocation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, signalRelatedEntity, "DeepFryer", resetFKFields, new int[] { (int)DeepFryerFieldIndex.ServiceLocationId } );		
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
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerEntity.Relations.ServiceLocationEntityUsingServiceLocationId, true, ref _alreadyFetchedServiceLocation, new string[] {  } );
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
		/// <param name="deepFryerId">PK value for DeepFryer which data should be fetched into this DeepFryer object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 deepFryerId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)DeepFryerFieldIndex.DeepFryerId].ForcedCurrentValueWrite(deepFryerId);
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
			return DAOFactory.CreateDeepFryerDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new DeepFryerEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static DeepFryerRelations Relations
		{
			get	{ return new DeepFryerRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("DeepFryerChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity, 0, null, null, null, "DeepFryerChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("DeepFryerService")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, 0, null, null, null, "DeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChangeLogCollectionViaDeepFryerChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerEntity.Relations.DeepFryerChangeLogEntityUsingDeepFryerId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.ChangeLogEntity, 0, null, null, GetRelationsForField("ChangeLogCollectionViaDeepFryerChangeLog"), "ChangeLogCollectionViaDeepFryerChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerService"), "EmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerService"), "ServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderEmployeeCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, GetRelationsForField("WorkOrderEmployeeCollectionViaDeepFryerService"), "WorkOrderEmployeeCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderServiceLocationCollectionViaDeepFryerService
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerEntity.Relations.DeepFryerServiceEntityUsingDeepFryerId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerService_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, GetRelationsForField("WorkOrderServiceLocationCollectionViaDeepFryerService"), "WorkOrderServiceLocationCollectionViaDeepFryerService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
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
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "DeepFryerEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DeepFryerEntity.CustomProperties;}
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
			get { return DeepFryerEntity.FieldsCustomProperties;}
		}

		/// <summary> The DeepFryerId property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."DeepFryerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DeepFryerId
		{
			get { return (System.Int32)GetValue((int)DeepFryerFieldIndex.DeepFryerId, true); }
			set	{ SetValue((int)DeepFryerFieldIndex.DeepFryerId, value, true); }
		}
		/// <summary> The Name property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)DeepFryerFieldIndex.Name, true); }
			set	{ SetValue((int)DeepFryerFieldIndex.Name, value, true); }
		}
		/// <summary> The Description property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)DeepFryerFieldIndex.Description, true); }
			set	{ SetValue((int)DeepFryerFieldIndex.Description, value, true); }
		}
		/// <summary> The ServiceLocationId property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."ServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ServiceLocationId
		{
			get { return (System.Int32)GetValue((int)DeepFryerFieldIndex.ServiceLocationId, true); }
			set	{ SetValue((int)DeepFryerFieldIndex.ServiceLocationId, value, true); }
		}
		/// <summary> The SizeInGallons property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."SizeInGallons"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Double> SizeInGallons
		{
			get { return (Nullable<System.Double>)GetValue((int)DeepFryerFieldIndex.SizeInGallons, false); }
			set	{ SetValue((int)DeepFryerFieldIndex.SizeInGallons, value, true); }
		}
		/// <summary> The IsActive property of the Entity DeepFryer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryer"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)DeepFryerFieldIndex.IsActive, true); }
			set	{ SetValue((int)DeepFryerFieldIndex.IsActive, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryerChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerChangeLogCollection DeepFryerChangeLog
		{
			get	{ return GetMultiDeepFryerChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerChangeLog. When set to true, DeepFryerChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryerChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerChangeLog
		{
			get	{ return _alwaysFetchDeepFryerChangeLog; }
			set	{ _alwaysFetchDeepFryerChangeLog = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerChangeLog already has been fetched. Setting this property to false when DeepFryerChangeLog has been fetched
		/// will clear the DeepFryerChangeLog collection well. Setting this property to true while DeepFryerChangeLog hasn't been fetched disables lazy loading for DeepFryerChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerChangeLog
		{
			get { return _alreadyFetchedDeepFryerChangeLog;}
			set 
			{
				if(_alreadyFetchedDeepFryerChangeLog && !value && (_deepFryerChangeLog != null))
				{
					_deepFryerChangeLog.Clear();
				}
				_alreadyFetchedDeepFryerChangeLog = value;
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

		/// <summary> Retrieves all related entities of type 'ChangeLogEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChangeLogCollectionViaDeepFryerChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ChangeLogCollection ChangeLogCollectionViaDeepFryerChangeLog
		{
			get { return GetMultiChangeLogCollectionViaDeepFryerChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ChangeLogCollectionViaDeepFryerChangeLog. When set to true, ChangeLogCollectionViaDeepFryerChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChangeLogCollectionViaDeepFryerChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiChangeLogCollectionViaDeepFryerChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChangeLogCollectionViaDeepFryerChangeLog
		{
			get	{ return _alwaysFetchChangeLogCollectionViaDeepFryerChangeLog; }
			set	{ _alwaysFetchChangeLogCollectionViaDeepFryerChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChangeLogCollectionViaDeepFryerChangeLog already has been fetched. Setting this property to false when ChangeLogCollectionViaDeepFryerChangeLog has been fetched
		/// will clear the ChangeLogCollectionViaDeepFryerChangeLog collection well. Setting this property to true while ChangeLogCollectionViaDeepFryerChangeLog hasn't been fetched disables lazy loading for ChangeLogCollectionViaDeepFryerChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChangeLogCollectionViaDeepFryerChangeLog
		{
			get { return _alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog;}
			set 
			{
				if(_alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog && !value && (_changeLogCollectionViaDeepFryerChangeLog != null))
				{
					_changeLogCollectionViaDeepFryerChangeLog.Clear();
				}
				_alreadyFetchedChangeLogCollectionViaDeepFryerChangeLog = value;
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
							_serviceLocation.UnsetRelatedEntity(this, "DeepFryer");
						}
					}
					else
					{
						if(_serviceLocation!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryer");
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity; }
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
