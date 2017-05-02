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
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Entity class which represents the entity 'RecycleType'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class RecycleTypeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<BaleEntity> _bale;
		private EntityCollection<RecycleServiceActionEntity> _recycleServiceAction;
		private EntityCollection<RecycleVendorServiceEntity> _recycleVendorService;
		private EntityCollection<ServiceLocationRecycleTypeEntity> _serviceLocationRecycleType;
		private EntityCollection<AccountEntity> _accountCollectionViaRecycleVendorService;
		private EntityCollection<AccountEntity> _accountCollectionViaBale;
		private EntityCollection<DockEntity> _dockCollectionViaBale;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaRecycleServiceAction_;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaRecycleServiceAction;
		private EntityCollection<RecycleServiceEntity> _recycleServiceCollectionViaRecycleServiceAction;
		private EntityCollection<RecycleVendorEntity> _recycleVendorCollectionViaRecycleVendorService;
		private EntityCollection<ServiceLocationEntity> _serviceLocationCollectionViaServiceLocationRecycleType;
		private EntityCollection<UserEntity> _userCollectionViaRecycleServiceAction_;
		private EntityCollection<UserEntity> _userCollectionViaRecycleServiceAction;


		
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
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RecycleTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public RecycleTypeEntity():base("RecycleTypeEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RecycleTypeEntity(IEntityFields2 fields):base("RecycleTypeEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RecycleTypeEntity</param>
		public RecycleTypeEntity(IValidator validator):base("RecycleTypeEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RecycleTypeEntity(System.Int32 recycleTypeId):base("RecycleTypeEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.RecycleTypeId = recycleTypeId;
		}

		/// <summary> CTor</summary>
		/// <param name="recycleTypeId">PK value for RecycleType which data should be fetched into this RecycleType object</param>
		/// <param name="validator">The custom validator object for this RecycleTypeEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RecycleTypeEntity(System.Int32 recycleTypeId, IValidator validator):base("RecycleTypeEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.RecycleTypeId = recycleTypeId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected RecycleTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_bale = (EntityCollection<BaleEntity>)info.GetValue("_bale", typeof(EntityCollection<BaleEntity>));
				_recycleServiceAction = (EntityCollection<RecycleServiceActionEntity>)info.GetValue("_recycleServiceAction", typeof(EntityCollection<RecycleServiceActionEntity>));
				_recycleVendorService = (EntityCollection<RecycleVendorServiceEntity>)info.GetValue("_recycleVendorService", typeof(EntityCollection<RecycleVendorServiceEntity>));
				_serviceLocationRecycleType = (EntityCollection<ServiceLocationRecycleTypeEntity>)info.GetValue("_serviceLocationRecycleType", typeof(EntityCollection<ServiceLocationRecycleTypeEntity>));
				_accountCollectionViaRecycleVendorService = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaRecycleVendorService", typeof(EntityCollection<AccountEntity>));
				_accountCollectionViaBale = (EntityCollection<AccountEntity>)info.GetValue("_accountCollectionViaBale", typeof(EntityCollection<AccountEntity>));
				_dockCollectionViaBale = (EntityCollection<DockEntity>)info.GetValue("_dockCollectionViaBale", typeof(EntityCollection<DockEntity>));
				_employeeCollectionViaRecycleServiceAction_ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaRecycleServiceAction_", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaRecycleServiceAction = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaRecycleServiceAction", typeof(EntityCollection<EmployeeEntity>));
				_recycleServiceCollectionViaRecycleServiceAction = (EntityCollection<RecycleServiceEntity>)info.GetValue("_recycleServiceCollectionViaRecycleServiceAction", typeof(EntityCollection<RecycleServiceEntity>));
				_recycleVendorCollectionViaRecycleVendorService = (EntityCollection<RecycleVendorEntity>)info.GetValue("_recycleVendorCollectionViaRecycleVendorService", typeof(EntityCollection<RecycleVendorEntity>));
				_serviceLocationCollectionViaServiceLocationRecycleType = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocationCollectionViaServiceLocationRecycleType", typeof(EntityCollection<ServiceLocationEntity>));
				_userCollectionViaRecycleServiceAction_ = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRecycleServiceAction_", typeof(EntityCollection<UserEntity>));
				_userCollectionViaRecycleServiceAction = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRecycleServiceAction", typeof(EntityCollection<UserEntity>));


				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
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
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{

				case "Bale":
					this.Bale.Add((BaleEntity)entity);
					break;
				case "RecycleServiceAction":
					this.RecycleServiceAction.Add((RecycleServiceActionEntity)entity);
					break;
				case "RecycleVendorService":
					this.RecycleVendorService.Add((RecycleVendorServiceEntity)entity);
					break;
				case "ServiceLocationRecycleType":
					this.ServiceLocationRecycleType.Add((ServiceLocationRecycleTypeEntity)entity);
					break;
				case "AccountCollectionViaRecycleVendorService":
					this.AccountCollectionViaRecycleVendorService.IsReadOnly = false;
					this.AccountCollectionViaRecycleVendorService.Add((AccountEntity)entity);
					this.AccountCollectionViaRecycleVendorService.IsReadOnly = true;
					break;
				case "AccountCollectionViaBale":
					this.AccountCollectionViaBale.IsReadOnly = false;
					this.AccountCollectionViaBale.Add((AccountEntity)entity);
					this.AccountCollectionViaBale.IsReadOnly = true;
					break;
				case "DockCollectionViaBale":
					this.DockCollectionViaBale.IsReadOnly = false;
					this.DockCollectionViaBale.Add((DockEntity)entity);
					this.DockCollectionViaBale.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaRecycleServiceAction_":
					this.EmployeeCollectionViaRecycleServiceAction_.IsReadOnly = false;
					this.EmployeeCollectionViaRecycleServiceAction_.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaRecycleServiceAction_.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaRecycleServiceAction":
					this.EmployeeCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.EmployeeCollectionViaRecycleServiceAction.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaRecycleServiceAction.IsReadOnly = true;
					break;
				case "RecycleServiceCollectionViaRecycleServiceAction":
					this.RecycleServiceCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.RecycleServiceCollectionViaRecycleServiceAction.Add((RecycleServiceEntity)entity);
					this.RecycleServiceCollectionViaRecycleServiceAction.IsReadOnly = true;
					break;
				case "RecycleVendorCollectionViaRecycleVendorService":
					this.RecycleVendorCollectionViaRecycleVendorService.IsReadOnly = false;
					this.RecycleVendorCollectionViaRecycleVendorService.Add((RecycleVendorEntity)entity);
					this.RecycleVendorCollectionViaRecycleVendorService.IsReadOnly = true;
					break;
				case "ServiceLocationCollectionViaServiceLocationRecycleType":
					this.ServiceLocationCollectionViaServiceLocationRecycleType.IsReadOnly = false;
					this.ServiceLocationCollectionViaServiceLocationRecycleType.Add((ServiceLocationEntity)entity);
					this.ServiceLocationCollectionViaServiceLocationRecycleType.IsReadOnly = true;
					break;
				case "UserCollectionViaRecycleServiceAction_":
					this.UserCollectionViaRecycleServiceAction_.IsReadOnly = false;
					this.UserCollectionViaRecycleServiceAction_.Add((UserEntity)entity);
					this.UserCollectionViaRecycleServiceAction_.IsReadOnly = true;
					break;
				case "UserCollectionViaRecycleServiceAction":
					this.UserCollectionViaRecycleServiceAction.IsReadOnly = false;
					this.UserCollectionViaRecycleServiceAction.Add((UserEntity)entity);
					this.UserCollectionViaRecycleServiceAction.IsReadOnly = true;
					break;

				default:
					break;
			}
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
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it
		/// will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckOneWayRelations(string propertyName)
		{
			// use template trick to calculate the # of single-sided / oneway relations
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));


				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{

				case "Bale":
					this.Bale.Add((BaleEntity)relatedEntity);
					break;
				case "RecycleServiceAction":
					this.RecycleServiceAction.Add((RecycleServiceActionEntity)relatedEntity);
					break;
				case "RecycleVendorService":
					this.RecycleVendorService.Add((RecycleVendorServiceEntity)relatedEntity);
					break;
				case "ServiceLocationRecycleType":
					this.ServiceLocationRecycleType.Add((ServiceLocationRecycleTypeEntity)relatedEntity);
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
		public override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{

				case "Bale":
					base.PerformRelatedEntityRemoval(this.Bale, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleServiceAction":
					base.PerformRelatedEntityRemoval(this.RecycleServiceAction, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleVendorService":
					base.PerformRelatedEntityRemoval(this.RecycleVendorService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocationRecycleType":
					base.PerformRelatedEntityRemoval(this.ServiceLocationRecycleType, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();


			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.Bale);
			toReturn.Add(this.RecycleServiceAction);
			toReturn.Add(this.RecycleVendorService);
			toReturn.Add(this.ServiceLocationRecycleType);

			return toReturn;
		}
		


		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_bale", ((_bale!=null) && (_bale.Count>0) && !this.MarkedForDeletion)?_bale:null);
				info.AddValue("_recycleServiceAction", ((_recycleServiceAction!=null) && (_recycleServiceAction.Count>0) && !this.MarkedForDeletion)?_recycleServiceAction:null);
				info.AddValue("_recycleVendorService", ((_recycleVendorService!=null) && (_recycleVendorService.Count>0) && !this.MarkedForDeletion)?_recycleVendorService:null);
				info.AddValue("_serviceLocationRecycleType", ((_serviceLocationRecycleType!=null) && (_serviceLocationRecycleType.Count>0) && !this.MarkedForDeletion)?_serviceLocationRecycleType:null);
				info.AddValue("_accountCollectionViaRecycleVendorService", ((_accountCollectionViaRecycleVendorService!=null) && (_accountCollectionViaRecycleVendorService.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaRecycleVendorService:null);
				info.AddValue("_accountCollectionViaBale", ((_accountCollectionViaBale!=null) && (_accountCollectionViaBale.Count>0) && !this.MarkedForDeletion)?_accountCollectionViaBale:null);
				info.AddValue("_dockCollectionViaBale", ((_dockCollectionViaBale!=null) && (_dockCollectionViaBale.Count>0) && !this.MarkedForDeletion)?_dockCollectionViaBale:null);
				info.AddValue("_employeeCollectionViaRecycleServiceAction_", ((_employeeCollectionViaRecycleServiceAction_!=null) && (_employeeCollectionViaRecycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaRecycleServiceAction_:null);
				info.AddValue("_employeeCollectionViaRecycleServiceAction", ((_employeeCollectionViaRecycleServiceAction!=null) && (_employeeCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaRecycleServiceAction:null);
				info.AddValue("_recycleServiceCollectionViaRecycleServiceAction", ((_recycleServiceCollectionViaRecycleServiceAction!=null) && (_recycleServiceCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_recycleServiceCollectionViaRecycleServiceAction:null);
				info.AddValue("_recycleVendorCollectionViaRecycleVendorService", ((_recycleVendorCollectionViaRecycleVendorService!=null) && (_recycleVendorCollectionViaRecycleVendorService.Count>0) && !this.MarkedForDeletion)?_recycleVendorCollectionViaRecycleVendorService:null);
				info.AddValue("_serviceLocationCollectionViaServiceLocationRecycleType", ((_serviceLocationCollectionViaServiceLocationRecycleType!=null) && (_serviceLocationCollectionViaServiceLocationRecycleType.Count>0) && !this.MarkedForDeletion)?_serviceLocationCollectionViaServiceLocationRecycleType:null);
				info.AddValue("_userCollectionViaRecycleServiceAction_", ((_userCollectionViaRecycleServiceAction_!=null) && (_userCollectionViaRecycleServiceAction_.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRecycleServiceAction_:null);
				info.AddValue("_userCollectionViaRecycleServiceAction", ((_userCollectionViaRecycleServiceAction!=null) && (_userCollectionViaRecycleServiceAction.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRecycleServiceAction:null);


			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
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
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Bale' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBale()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BaleFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleServiceAction' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleServiceActionFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleVendorService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleVendorService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleVendorServiceFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocationRecycleType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationRecycleType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationRecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaRecycleVendorService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaRecycleVendorService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Account' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountCollectionViaBale()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("AccountCollectionViaBale"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Dock' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDockCollectionViaBale()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DockCollectionViaBale"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaRecycleServiceAction_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleServiceCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleServiceCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleVendor' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleVendorCollectionViaRecycleVendorService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleVendorCollectionViaRecycleVendorService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocationCollectionViaServiceLocationRecycleType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceLocationCollectionViaServiceLocationRecycleType"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRecycleServiceAction_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRecycleServiceAction_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRecycleServiceAction()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRecycleServiceAction"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleTypeFields.RecycleTypeId, null, ComparisonOperator.Equal, this.RecycleTypeId, "RecycleTypeEntity__"));
			return bucket;
		}


	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._bale);
			collectionsQueue.Enqueue(this._recycleServiceAction);
			collectionsQueue.Enqueue(this._recycleVendorService);
			collectionsQueue.Enqueue(this._serviceLocationRecycleType);
			collectionsQueue.Enqueue(this._accountCollectionViaRecycleVendorService);
			collectionsQueue.Enqueue(this._accountCollectionViaBale);
			collectionsQueue.Enqueue(this._dockCollectionViaBale);
			collectionsQueue.Enqueue(this._employeeCollectionViaRecycleServiceAction_);
			collectionsQueue.Enqueue(this._employeeCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._recycleServiceCollectionViaRecycleServiceAction);
			collectionsQueue.Enqueue(this._recycleVendorCollectionViaRecycleVendorService);
			collectionsQueue.Enqueue(this._serviceLocationCollectionViaServiceLocationRecycleType);
			collectionsQueue.Enqueue(this._userCollectionViaRecycleServiceAction_);
			collectionsQueue.Enqueue(this._userCollectionViaRecycleServiceAction);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._bale = (EntityCollection<BaleEntity>) collectionsQueue.Dequeue();
			this._recycleServiceAction = (EntityCollection<RecycleServiceActionEntity>) collectionsQueue.Dequeue();
			this._recycleVendorService = (EntityCollection<RecycleVendorServiceEntity>) collectionsQueue.Dequeue();
			this._serviceLocationRecycleType = (EntityCollection<ServiceLocationRecycleTypeEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaRecycleVendorService = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._accountCollectionViaBale = (EntityCollection<AccountEntity>) collectionsQueue.Dequeue();
			this._dockCollectionViaBale = (EntityCollection<DockEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaRecycleServiceAction_ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaRecycleServiceAction = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._recycleServiceCollectionViaRecycleServiceAction = (EntityCollection<RecycleServiceEntity>) collectionsQueue.Dequeue();
			this._recycleVendorCollectionViaRecycleVendorService = (EntityCollection<RecycleVendorEntity>) collectionsQueue.Dequeue();
			this._serviceLocationCollectionViaServiceLocationRecycleType = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRecycleServiceAction_ = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRecycleServiceAction = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._bale != null)
			{
				return true;
			}
			if (this._recycleServiceAction != null)
			{
				return true;
			}
			if (this._recycleVendorService != null)
			{
				return true;
			}
			if (this._serviceLocationRecycleType != null)
			{
				return true;
			}
			if (this._accountCollectionViaRecycleVendorService != null)
			{
				return true;
			}
			if (this._accountCollectionViaBale != null)
			{
				return true;
			}
			if (this._dockCollectionViaBale != null)
			{
				return true;
			}
			if (this._employeeCollectionViaRecycleServiceAction_ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaRecycleServiceAction != null)
			{
				return true;
			}
			if (this._recycleServiceCollectionViaRecycleServiceAction != null)
			{
				return true;
			}
			if (this._recycleVendorCollectionViaRecycleVendorService != null)
			{
				return true;
			}
			if (this._serviceLocationCollectionViaServiceLocationRecycleType != null)
			{
				return true;
			}
			if (this._userCollectionViaRecycleServiceAction_ != null)
			{
				return true;
			}
			if (this._userCollectionViaRecycleServiceAction != null)
			{
				return true;
			}
			return base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BaleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaleEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleVendorServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationRecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationRecycleTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DockEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DockEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
		}
#endif
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
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_bale!=null)
			{
				_bale.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceAction!=null)
			{
				_recycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_recycleVendorService!=null)
			{
				_recycleVendorService.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationRecycleType!=null)
			{
				_serviceLocationRecycleType.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaRecycleVendorService!=null)
			{
				_accountCollectionViaRecycleVendorService.ActiveContext = base.ActiveContext;
			}
			if(_accountCollectionViaBale!=null)
			{
				_accountCollectionViaBale.ActiveContext = base.ActiveContext;
			}
			if(_dockCollectionViaBale!=null)
			{
				_dockCollectionViaBale.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaRecycleServiceAction_!=null)
			{
				_employeeCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaRecycleServiceAction!=null)
			{
				_employeeCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_recycleServiceCollectionViaRecycleServiceAction!=null)
			{
				_recycleServiceCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}
			if(_recycleVendorCollectionViaRecycleVendorService!=null)
			{
				_recycleVendorCollectionViaRecycleVendorService.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocationCollectionViaServiceLocationRecycleType!=null)
			{
				_serviceLocationCollectionViaServiceLocationRecycleType.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRecycleServiceAction_!=null)
			{
				_userCollectionViaRecycleServiceAction_.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRecycleServiceAction!=null)
			{
				_userCollectionViaRecycleServiceAction.ActiveContext = base.ActiveContext;
			}


		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_bale = null;
			_recycleServiceAction = null;
			_recycleVendorService = null;
			_serviceLocationRecycleType = null;
			_accountCollectionViaRecycleVendorService = null;
			_accountCollectionViaBale = null;
			_dockCollectionViaBale = null;
			_employeeCollectionViaRecycleServiceAction_ = null;
			_employeeCollectionViaRecycleServiceAction = null;
			_recycleServiceCollectionViaRecycleServiceAction = null;
			_recycleVendorCollectionViaRecycleVendorService = null;
			_serviceLocationCollectionViaServiceLocationRecycleType = null;
			_userCollectionViaRecycleServiceAction_ = null;
			_userCollectionViaRecycleServiceAction = null;


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



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this RecycleTypeEntity</param>
		/// <param name="fields">Fields of this entity</param>
		protected virtual void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			base.Fields = fields;
			base.IsNew=true;
			base.Validator = validator;
			InitClassMembers();

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
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

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Bale' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBale
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<BaleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaleEntityFactory))),
					(IEntityRelation)GetRelationsForField("Bale")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.BaleEntity, 0, null, null, null, null, "Bale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleServiceAction' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceAction
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleServiceAction")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity, 0, null, null, null, null, "RecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleVendorService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleVendorService
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RecycleVendorServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorServiceEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleVendorService")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity, 0, null, null, null, null, "RecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocationRecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationRecycleType
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationRecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationRecycleTypeEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocationRecycleType")[0], (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationRecycleTypeEntity, 0, null, null, null, null, "ServiceLocationRecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaRecycleVendorService
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleVendorServiceEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleVendorService_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaRecycleVendorService"), null, "AccountCollectionViaRecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountCollectionViaBale
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.BaleEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "Bale_");
				return new PrefetchPathElement2(new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaBale"), null, "AccountCollectionViaBale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Dock' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDockCollectionViaBale
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.BaleEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "Bale_");
				return new PrefetchPathElement2(new EntityCollection<DockEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DockEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.DockEntity, 0, null, null, GetRelationsForField("DockCollectionViaBale"), null, "DockCollectionViaBale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction_"), null, "EmployeeCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaRecycleServiceAction"), null, "EmployeeCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleServiceCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity, 0, null, null, GetRelationsForField("RecycleServiceCollectionViaRecycleServiceAction"), null, "RecycleServiceCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleVendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleVendorCollectionViaRecycleVendorService
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleVendorServiceEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleVendorService_");
				return new PrefetchPathElement2(new EntityCollection<RecycleVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity, 0, null, null, GetRelationsForField("RecycleVendorCollectionViaRecycleVendorService"), null, "RecycleVendorCollectionViaRecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocationCollectionViaServiceLocationRecycleType
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.ServiceLocationRecycleTypeEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocationRecycleType_");
				return new PrefetchPathElement2(new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaServiceLocationRecycleType"), null, "ServiceLocationCollectionViaServiceLocationRecycleType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRecycleServiceAction_
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction_"), null, "UserCollectionViaRecycleServiceAction_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRecycleServiceAction
		{
			get
			{
				IEntityRelation intermediateRelation = RecycleTypeEntity.Relations.RecycleServiceActionEntityUsingRecycleTypeId;
				intermediateRelation.SetAliases(string.Empty, "RecycleServiceAction_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRecycleServiceAction"), null, "UserCollectionViaRecycleServiceAction", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return RecycleTypeEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value
		/// pairs. </summary>
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
			set	{ SetValue((int)RecycleTypeFieldIndex.RecycleTypeId, value); }
		}

		/// <summary> The Name property of the Entity RecycleType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)RecycleTypeFieldIndex.Name, true); }
			set	{ SetValue((int)RecycleTypeFieldIndex.Name, value); }
		}

		/// <summary> The Description property of the Entity RecycleType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleType"."Description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)RecycleTypeFieldIndex.Description, true); }
			set	{ SetValue((int)RecycleTypeFieldIndex.Description, value); }
		}

		/// <summary> The SpanishLabel property of the Entity RecycleType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleType"."SpanishLabel"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String SpanishLabel
		{
			get { return (System.String)GetValue((int)RecycleTypeFieldIndex.SpanishLabel, true); }
			set	{ SetValue((int)RecycleTypeFieldIndex.SpanishLabel, value); }
		}

		/// <summary> The IsActive property of the Entity RecycleType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RecycleType"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)RecycleTypeFieldIndex.IsActive, true); }
			set	{ SetValue((int)RecycleTypeFieldIndex.IsActive, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BaleEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(BaleEntity))]
		public virtual EntityCollection<BaleEntity> Bale
		{
			get
			{
				if(_bale==null)
				{
					_bale = new EntityCollection<BaleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaleEntityFactory)));
					_bale.SetContainingEntityInfo(this, "RecycleType");
				}
				return _bale;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceActionEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceActionEntity))]
		public virtual EntityCollection<RecycleServiceActionEntity> RecycleServiceAction
		{
			get
			{
				if(_recycleServiceAction==null)
				{
					_recycleServiceAction = new EntityCollection<RecycleServiceActionEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceActionEntityFactory)));
					_recycleServiceAction.SetContainingEntityInfo(this, "RecycleType");
				}
				return _recycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleVendorServiceEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleVendorServiceEntity))]
		public virtual EntityCollection<RecycleVendorServiceEntity> RecycleVendorService
		{
			get
			{
				if(_recycleVendorService==null)
				{
					_recycleVendorService = new EntityCollection<RecycleVendorServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorServiceEntityFactory)));
					_recycleVendorService.SetContainingEntityInfo(this, "RecycleType");
				}
				return _recycleVendorService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationRecycleTypeEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationRecycleTypeEntity))]
		public virtual EntityCollection<ServiceLocationRecycleTypeEntity> ServiceLocationRecycleType
		{
			get
			{
				if(_serviceLocationRecycleType==null)
				{
					_serviceLocationRecycleType = new EntityCollection<ServiceLocationRecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationRecycleTypeEntityFactory)));
					_serviceLocationRecycleType.SetContainingEntityInfo(this, "RecycleType");
				}
				return _serviceLocationRecycleType;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaRecycleVendorService
		{
			get
			{
				if(_accountCollectionViaRecycleVendorService==null)
				{
					_accountCollectionViaRecycleVendorService = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaRecycleVendorService.IsReadOnly=true;
				}
				return _accountCollectionViaRecycleVendorService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEntity))]
		public virtual EntityCollection<AccountEntity> AccountCollectionViaBale
		{
			get
			{
				if(_accountCollectionViaBale==null)
				{
					_accountCollectionViaBale = new EntityCollection<AccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory)));
					_accountCollectionViaBale.IsReadOnly=true;
				}
				return _accountCollectionViaBale;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DockEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DockEntity))]
		public virtual EntityCollection<DockEntity> DockCollectionViaBale
		{
			get
			{
				if(_dockCollectionViaBale==null)
				{
					_dockCollectionViaBale = new EntityCollection<DockEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DockEntityFactory)));
					_dockCollectionViaBale.IsReadOnly=true;
				}
				return _dockCollectionViaBale;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaRecycleServiceAction_
		{
			get
			{
				if(_employeeCollectionViaRecycleServiceAction_==null)
				{
					_employeeCollectionViaRecycleServiceAction_ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaRecycleServiceAction_.IsReadOnly=true;
				}
				return _employeeCollectionViaRecycleServiceAction_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaRecycleServiceAction
		{
			get
			{
				if(_employeeCollectionViaRecycleServiceAction==null)
				{
					_employeeCollectionViaRecycleServiceAction = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaRecycleServiceAction.IsReadOnly=true;
				}
				return _employeeCollectionViaRecycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleServiceEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleServiceEntity))]
		public virtual EntityCollection<RecycleServiceEntity> RecycleServiceCollectionViaRecycleServiceAction
		{
			get
			{
				if(_recycleServiceCollectionViaRecycleServiceAction==null)
				{
					_recycleServiceCollectionViaRecycleServiceAction = new EntityCollection<RecycleServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleServiceEntityFactory)));
					_recycleServiceCollectionViaRecycleServiceAction.IsReadOnly=true;
				}
				return _recycleServiceCollectionViaRecycleServiceAction;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleVendorEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleVendorEntity))]
		public virtual EntityCollection<RecycleVendorEntity> RecycleVendorCollectionViaRecycleVendorService
		{
			get
			{
				if(_recycleVendorCollectionViaRecycleVendorService==null)
				{
					_recycleVendorCollectionViaRecycleVendorService = new EntityCollection<RecycleVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorEntityFactory)));
					_recycleVendorCollectionViaRecycleVendorService.IsReadOnly=true;
				}
				return _recycleVendorCollectionViaRecycleVendorService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocationCollectionViaServiceLocationRecycleType
		{
			get
			{
				if(_serviceLocationCollectionViaServiceLocationRecycleType==null)
				{
					_serviceLocationCollectionViaServiceLocationRecycleType = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocationCollectionViaServiceLocationRecycleType.IsReadOnly=true;
				}
				return _serviceLocationCollectionViaServiceLocationRecycleType;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRecycleServiceAction_
		{
			get
			{
				if(_userCollectionViaRecycleServiceAction_==null)
				{
					_userCollectionViaRecycleServiceAction_ = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRecycleServiceAction_.IsReadOnly=true;
				}
				return _userCollectionViaRecycleServiceAction_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRecycleServiceAction
		{
			get
			{
				if(_userCollectionViaRecycleServiceAction==null)
				{
					_userCollectionViaRecycleServiceAction = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRecycleServiceAction.IsReadOnly=true;
				}
				return _userCollectionViaRecycleServiceAction;
			}
		}


	
		
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
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
