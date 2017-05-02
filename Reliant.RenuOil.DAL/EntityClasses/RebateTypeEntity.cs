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
	/// Entity class which represents the entity 'RebateType'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class RebateTypeEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.RebateCollection	_rebate;
		private bool	_alwaysFetchRebate, _alreadyFetchedRebate;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaRebate;
		private bool	_alwaysFetchAccountCollectionViaRebate, _alreadyFetchedAccountCollectionViaRebate;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaRebate;
		private bool	_alwaysFetchUserCollectionViaRebate, _alreadyFetchedUserCollectionViaRebate;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name Rebate</summary>
			public static readonly string Rebate = "Rebate";
			/// <summary>Member name AccountCollectionViaRebate</summary>
			public static readonly string AccountCollectionViaRebate = "AccountCollectionViaRebate";
			/// <summary>Member name UserCollectionViaRebate</summary>
			public static readonly string UserCollectionViaRebate = "UserCollectionViaRebate";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RebateTypeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public RebateTypeEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="rebateTypeId">PK value for RebateType which data should be fetched into this RebateType object</param>
		public RebateTypeEntity(System.Int32 rebateTypeId)
		{
			InitClassFetch(rebateTypeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="rebateTypeId">PK value for RebateType which data should be fetched into this RebateType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public RebateTypeEntity(System.Int32 rebateTypeId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(rebateTypeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="rebateTypeId">PK value for RebateType which data should be fetched into this RebateType object</param>
		/// <param name="validator">The custom validator object for this RebateTypeEntity</param>
		public RebateTypeEntity(System.Int32 rebateTypeId, IValidator validator)
		{
			InitClassFetch(rebateTypeId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected RebateTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_rebate = (Reliant.RenuOil.DAL.CollectionClasses.RebateCollection)info.GetValue("_rebate", typeof(Reliant.RenuOil.DAL.CollectionClasses.RebateCollection));
			_alwaysFetchRebate = info.GetBoolean("_alwaysFetchRebate");
			_alreadyFetchedRebate = info.GetBoolean("_alreadyFetchedRebate");
			_accountCollectionViaRebate = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaRebate", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaRebate = info.GetBoolean("_alwaysFetchAccountCollectionViaRebate");
			_alreadyFetchedAccountCollectionViaRebate = info.GetBoolean("_alreadyFetchedAccountCollectionViaRebate");
			_userCollectionViaRebate = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaRebate", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaRebate = info.GetBoolean("_alwaysFetchUserCollectionViaRebate");
			_alreadyFetchedUserCollectionViaRebate = info.GetBoolean("_alreadyFetchedUserCollectionViaRebate");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((RebateTypeFieldIndex)fieldIndex)
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
			_alreadyFetchedRebate = (_rebate.Count > 0);
			_alreadyFetchedAccountCollectionViaRebate = (_accountCollectionViaRebate.Count > 0);
			_alreadyFetchedUserCollectionViaRebate = (_userCollectionViaRebate.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return RebateTypeEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "Rebate":
					toReturn.Add(RebateTypeEntity.Relations.RebateEntityUsingRebateTypeId);
					break;
				case "AccountCollectionViaRebate":
					toReturn.Add(RebateTypeEntity.Relations.RebateEntityUsingRebateTypeId, "RebateTypeEntity__", "Rebate_", JoinHint.None);
					toReturn.Add(RebateEntity.Relations.AccountEntityUsingAccountId, "Rebate_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRebate":
					toReturn.Add(RebateTypeEntity.Relations.RebateEntityUsingRebateTypeId, "RebateTypeEntity__", "Rebate_", JoinHint.None);
					toReturn.Add(RebateEntity.Relations.UserEntityUsingEnteredByUserId, "Rebate_", string.Empty, JoinHint.None);
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
			info.AddValue("_rebate", (!this.MarkedForDeletion?_rebate:null));
			info.AddValue("_alwaysFetchRebate", _alwaysFetchRebate);
			info.AddValue("_alreadyFetchedRebate", _alreadyFetchedRebate);
			info.AddValue("_accountCollectionViaRebate", (!this.MarkedForDeletion?_accountCollectionViaRebate:null));
			info.AddValue("_alwaysFetchAccountCollectionViaRebate", _alwaysFetchAccountCollectionViaRebate);
			info.AddValue("_alreadyFetchedAccountCollectionViaRebate", _alreadyFetchedAccountCollectionViaRebate);
			info.AddValue("_userCollectionViaRebate", (!this.MarkedForDeletion?_userCollectionViaRebate:null));
			info.AddValue("_alwaysFetchUserCollectionViaRebate", _alwaysFetchUserCollectionViaRebate);
			info.AddValue("_alreadyFetchedUserCollectionViaRebate", _alreadyFetchedUserCollectionViaRebate);


			
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

				case "Rebate":
					_alreadyFetchedRebate = true;
					if(entity!=null)
					{
						this.Rebate.Add((RebateEntity)entity);
					}
					break;
				case "AccountCollectionViaRebate":
					_alreadyFetchedAccountCollectionViaRebate = true;
					if(entity!=null)
					{
						this.AccountCollectionViaRebate.Add((AccountEntity)entity);
					}
					break;
				case "UserCollectionViaRebate":
					_alreadyFetchedUserCollectionViaRebate = true;
					if(entity!=null)
					{
						this.UserCollectionViaRebate.Add((UserEntity)entity);
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

				case "Rebate":
					_rebate.Add((RebateEntity)relatedEntity);
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

				case "Rebate":
					base.PerformRelatedEntityRemoval(_rebate, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_rebate);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="rebateTypeId">PK value for RebateType which data should be fetched into this RebateType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 rebateTypeId)
		{
			return FetchUsingPK(rebateTypeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="rebateTypeId">PK value for RebateType which data should be fetched into this RebateType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 rebateTypeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(rebateTypeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="rebateTypeId">PK value for RebateType which data should be fetched into this RebateType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 rebateTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(rebateTypeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="rebateTypeId">PK value for RebateType which data should be fetched into this RebateType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 rebateTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(rebateTypeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.RebateTypeId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(RebateTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(RebateTypeFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new RebateTypeRelations().GetAllRelations();
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
				_rebate.GetMultiManyToOne(null, this, null, filter);
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
				filter.Add(new FieldCompareValuePredicate(RebateTypeFields.RebateTypeId, ComparisonOperator.Equal, this.RebateTypeId, "RebateTypeEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(RebateTypeFields.RebateTypeId, ComparisonOperator.Equal, this.RebateTypeId, "RebateTypeEntity__"));
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



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			RebateTypeDAO dao = (RebateTypeDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_rebate.ActiveContext = base.ActiveContext;
			_accountCollectionViaRebate.ActiveContext = base.ActiveContext;
			_userCollectionViaRebate.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			RebateTypeDAO dao = (RebateTypeDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			RebateTypeDAO dao = (RebateTypeDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.RebateTypeEntity);
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

			toReturn.Add("Rebate", _rebate);
			toReturn.Add("AccountCollectionViaRebate", _accountCollectionViaRebate);
			toReturn.Add("UserCollectionViaRebate", _userCollectionViaRebate);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="rebateTypeId">PK value for RebateType which data should be fetched into this RebateType object</param>
		/// <param name="validator">The validator object for this RebateTypeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 rebateTypeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(rebateTypeId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_rebate = new Reliant.RenuOil.DAL.CollectionClasses.RebateCollection(new RebateEntityFactory());
			_rebate.SetContainingEntityInfo(this, "RebateType");
			_alwaysFetchRebate = false;
			_alreadyFetchedRebate = false;
			_accountCollectionViaRebate = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaRebate = false;
			_alreadyFetchedAccountCollectionViaRebate = false;
			_userCollectionViaRebate = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaRebate = false;
			_alreadyFetchedUserCollectionViaRebate = false;



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

			_fieldsCustomProperties.Add("RebateTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="rebateTypeId">PK value for RebateType which data should be fetched into this RebateType object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 rebateTypeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)RebateTypeFieldIndex.RebateTypeId].ForcedCurrentValueWrite(rebateTypeId);
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
			return DAOFactory.CreateRebateTypeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new RebateTypeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static RebateTypeRelations Relations
		{
			get	{ return new RebateTypeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Rebate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRebate
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RebateCollection(),
					(IEntityRelation)GetRelationsForField("Rebate")[0], (int)Reliant.RenuOil.DAL.EntityType.RebateTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.RebateEntity, 0, null, null, null, "Rebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaRebate
		{
			get
			{
				IEntityRelation intermediateRelation = RebateTypeEntity.Relations.RebateEntityUsingRebateTypeId;
				intermediateRelation.SetAliases(string.Empty, "Rebate_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RebateTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaRebate"), "AccountCollectionViaRebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaRebate
		{
			get
			{
				IEntityRelation intermediateRelation = RebateTypeEntity.Relations.RebateEntityUsingRebateTypeId;
				intermediateRelation.SetAliases(string.Empty, "Rebate_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.RebateTypeEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRebate"), "UserCollectionViaRebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "RebateTypeEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return RebateTypeEntity.CustomProperties;}
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
			get { return RebateTypeEntity.FieldsCustomProperties;}
		}

		/// <summary> The RebateTypeId property of the Entity RebateType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RebateType"."RebateTypeId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 RebateTypeId
		{
			get { return (System.Int32)GetValue((int)RebateTypeFieldIndex.RebateTypeId, true); }
			set	{ SetValue((int)RebateTypeFieldIndex.RebateTypeId, value, true); }
		}
		/// <summary> The Name property of the Entity RebateType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RebateType"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)RebateTypeFieldIndex.Name, true); }
			set	{ SetValue((int)RebateTypeFieldIndex.Name, value, true); }
		}
		/// <summary> The IsActive property of the Entity RebateType<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "RebateType"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)RebateTypeFieldIndex.IsActive, true); }
			set	{ SetValue((int)RebateTypeFieldIndex.IsActive, value, true); }
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.RebateTypeEntity; }
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
