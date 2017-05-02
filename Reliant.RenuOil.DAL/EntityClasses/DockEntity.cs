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
	/// Entity class which represents the entity 'Dock'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DockEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.BaleCollection	_bale;
		private bool	_alwaysFetchBale, _alreadyFetchedBale;
		private Reliant.RenuOil.DAL.CollectionClasses.AccountCollection _accountCollectionViaBale;
		private bool	_alwaysFetchAccountCollectionViaBale, _alreadyFetchedAccountCollectionViaBale;
		private Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection _recycleTypeCollectionViaBale;
		private bool	_alwaysFetchRecycleTypeCollectionViaBale, _alreadyFetchedRecycleTypeCollectionViaBale;


		
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
			/// <summary>Member name AccountCollectionViaBale</summary>
			public static readonly string AccountCollectionViaBale = "AccountCollectionViaBale";
			/// <summary>Member name RecycleTypeCollectionViaBale</summary>
			public static readonly string RecycleTypeCollectionViaBale = "RecycleTypeCollectionViaBale";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DockEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public DockEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="dockId">PK value for Dock which data should be fetched into this Dock object</param>
		public DockEntity(System.Int32 dockId)
		{
			InitClassFetch(dockId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="dockId">PK value for Dock which data should be fetched into this Dock object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public DockEntity(System.Int32 dockId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(dockId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="dockId">PK value for Dock which data should be fetched into this Dock object</param>
		/// <param name="validator">The custom validator object for this DockEntity</param>
		public DockEntity(System.Int32 dockId, IValidator validator)
		{
			InitClassFetch(dockId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DockEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_bale = (Reliant.RenuOil.DAL.CollectionClasses.BaleCollection)info.GetValue("_bale", typeof(Reliant.RenuOil.DAL.CollectionClasses.BaleCollection));
			_alwaysFetchBale = info.GetBoolean("_alwaysFetchBale");
			_alreadyFetchedBale = info.GetBoolean("_alreadyFetchedBale");
			_accountCollectionViaBale = (Reliant.RenuOil.DAL.CollectionClasses.AccountCollection)info.GetValue("_accountCollectionViaBale", typeof(Reliant.RenuOil.DAL.CollectionClasses.AccountCollection));
			_alwaysFetchAccountCollectionViaBale = info.GetBoolean("_alwaysFetchAccountCollectionViaBale");
			_alreadyFetchedAccountCollectionViaBale = info.GetBoolean("_alreadyFetchedAccountCollectionViaBale");
			_recycleTypeCollectionViaBale = (Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection)info.GetValue("_recycleTypeCollectionViaBale", typeof(Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection));
			_alwaysFetchRecycleTypeCollectionViaBale = info.GetBoolean("_alwaysFetchRecycleTypeCollectionViaBale");
			_alreadyFetchedRecycleTypeCollectionViaBale = info.GetBoolean("_alreadyFetchedRecycleTypeCollectionViaBale");


			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((DockFieldIndex)fieldIndex)
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
			_alreadyFetchedAccountCollectionViaBale = (_accountCollectionViaBale.Count > 0);
			_alreadyFetchedRecycleTypeCollectionViaBale = (_recycleTypeCollectionViaBale.Count > 0);


		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return DockEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(DockEntity.Relations.BaleEntityUsingDockId);
					break;
				case "AccountCollectionViaBale":
					toReturn.Add(DockEntity.Relations.BaleEntityUsingDockId, "DockEntity__", "Bale_", JoinHint.None);
					toReturn.Add(BaleEntity.Relations.AccountEntityUsingAccountId, "Bale_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaBale":
					toReturn.Add(DockEntity.Relations.BaleEntityUsingDockId, "DockEntity__", "Bale_", JoinHint.None);
					toReturn.Add(BaleEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "Bale_", string.Empty, JoinHint.None);
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
			info.AddValue("_accountCollectionViaBale", (!this.MarkedForDeletion?_accountCollectionViaBale:null));
			info.AddValue("_alwaysFetchAccountCollectionViaBale", _alwaysFetchAccountCollectionViaBale);
			info.AddValue("_alreadyFetchedAccountCollectionViaBale", _alreadyFetchedAccountCollectionViaBale);
			info.AddValue("_recycleTypeCollectionViaBale", (!this.MarkedForDeletion?_recycleTypeCollectionViaBale:null));
			info.AddValue("_alwaysFetchRecycleTypeCollectionViaBale", _alwaysFetchRecycleTypeCollectionViaBale);
			info.AddValue("_alreadyFetchedRecycleTypeCollectionViaBale", _alreadyFetchedRecycleTypeCollectionViaBale);


			
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
				case "AccountCollectionViaBale":
					_alreadyFetchedAccountCollectionViaBale = true;
					if(entity!=null)
					{
						this.AccountCollectionViaBale.Add((AccountEntity)entity);
					}
					break;
				case "RecycleTypeCollectionViaBale":
					_alreadyFetchedRecycleTypeCollectionViaBale = true;
					if(entity!=null)
					{
						this.RecycleTypeCollectionViaBale.Add((RecycleTypeEntity)entity);
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

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dockId">PK value for Dock which data should be fetched into this Dock object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 dockId)
		{
			return FetchUsingPK(dockId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dockId">PK value for Dock which data should be fetched into this Dock object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 dockId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(dockId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dockId">PK value for Dock which data should be fetched into this Dock object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 dockId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(dockId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dockId">PK value for Dock which data should be fetched into this Dock object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 dockId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(dockId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DockId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DockFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DockFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DockRelations().GetAllRelations();
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
				_bale.GetMultiManyToOne(null, this, null, filter);
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
				filter.Add(new FieldCompareValuePredicate(DockFields.DockId, ComparisonOperator.Equal, this.DockId, "DockEntity__"));
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
				filter.Add(new FieldCompareValuePredicate(DockFields.DockId, ComparisonOperator.Equal, this.DockId, "DockEntity__"));
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



		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			DockDAO dao = (DockDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_bale.ActiveContext = base.ActiveContext;
			_accountCollectionViaBale.ActiveContext = base.ActiveContext;
			_recycleTypeCollectionViaBale.ActiveContext = base.ActiveContext;



		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			DockDAO dao = (DockDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			DockDAO dao = (DockDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.DockEntity);
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
			toReturn.Add("AccountCollectionViaBale", _accountCollectionViaBale);
			toReturn.Add("RecycleTypeCollectionViaBale", _recycleTypeCollectionViaBale);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="dockId">PK value for Dock which data should be fetched into this Dock object</param>
		/// <param name="validator">The validator object for this DockEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 dockId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(dockId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_bale = new Reliant.RenuOil.DAL.CollectionClasses.BaleCollection(new BaleEntityFactory());
			_bale.SetContainingEntityInfo(this, "Dock");
			_alwaysFetchBale = false;
			_alreadyFetchedBale = false;
			_accountCollectionViaBale = new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(new AccountEntityFactory());
			_alwaysFetchAccountCollectionViaBale = false;
			_alreadyFetchedAccountCollectionViaBale = false;
			_recycleTypeCollectionViaBale = new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(new RecycleTypeEntityFactory());
			_alwaysFetchRecycleTypeCollectionViaBale = false;
			_alreadyFetchedRecycleTypeCollectionViaBale = false;



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

			_fieldsCustomProperties.Add("DockId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DockName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="dockId">PK value for Dock which data should be fetched into this Dock object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 dockId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)DockFieldIndex.DockId].ForcedCurrentValueWrite(dockId);
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
			return DAOFactory.CreateDockDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new DockEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static DockRelations Relations
		{
			get	{ return new DockRelations(); }
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
					(IEntityRelation)GetRelationsForField("Bale")[0], (int)Reliant.RenuOil.DAL.EntityType.DockEntity, (int)Reliant.RenuOil.DAL.EntityType.BaleEntity, 0, null, null, null, "Bale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Account' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAccountCollectionViaBale
		{
			get
			{
				IEntityRelation intermediateRelation = DockEntity.Relations.BaleEntityUsingDockId;
				intermediateRelation.SetAliases(string.Empty, "Bale_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.AccountCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DockEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, 0, null, null, GetRelationsForField("AccountCollectionViaBale"), "AccountCollectionViaBale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRecycleTypeCollectionViaBale
		{
			get
			{
				IEntityRelation intermediateRelation = DockEntity.Relations.BaleEntityUsingDockId;
				intermediateRelation.SetAliases(string.Empty, "Bale_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.RecycleTypeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DockEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaBale"), "RecycleTypeCollectionViaBale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "DockEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DockEntity.CustomProperties;}
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
			get { return DockEntity.FieldsCustomProperties;}
		}

		/// <summary> The DockId property of the Entity Dock<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dock"."DockId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DockId
		{
			get { return (System.Int32)GetValue((int)DockFieldIndex.DockId, true); }
			set	{ SetValue((int)DockFieldIndex.DockId, value, true); }
		}
		/// <summary> The AccountId property of the Entity Dock<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dock"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)DockFieldIndex.AccountId, true); }
			set	{ SetValue((int)DockFieldIndex.AccountId, value, true); }
		}
		/// <summary> The DockName property of the Entity Dock<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dock"."DockName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String DockName
		{
			get { return (System.String)GetValue((int)DockFieldIndex.DockName, true); }
			set	{ SetValue((int)DockFieldIndex.DockName, value, true); }
		}
		/// <summary> The IsActive property of the Entity Dock<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Dock"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)DockFieldIndex.IsActive, true); }
			set	{ SetValue((int)DockFieldIndex.IsActive, value, true); }
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
			get { return (int)Reliant.RenuOil.DAL.EntityType.DockEntity; }
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
