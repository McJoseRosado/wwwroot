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
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
#if !CF
using System.Runtime.Serialization;
#endif

using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.DaoClasses;
using Reliant.RenuOil.DAL.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.CollectionClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Collection class for storing and retrieving collections of ServiceLocationEntity objects. </summary>
	[Serializable]
	public partial class ServiceLocationCollection : EntityCollectionBase<ServiceLocationEntity>
	{
		/// <summary> CTor</summary>
		public ServiceLocationCollection():base(new ServiceLocationEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public ServiceLocationCollection(IList<ServiceLocationEntity> initialContents):base(new ServiceLocationEntityFactory())
		{
			AddRange(initialContents);
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ServiceLocationCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ServiceLocationCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}


		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <param name="serviceTypeInstance">ServiceTypeEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity accountInstance, IEntity serviceTypeInstance)
		{
			return GetMultiManyToOne(accountInstance, serviceTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, null, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <param name="serviceTypeInstance">ServiceTypeEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity accountInstance, IEntity serviceTypeInstance, IPredicateExpression filter)
		{
			return GetMultiManyToOne(accountInstance, serviceTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <param name="serviceTypeInstance">ServiceTypeEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity accountInstance, IEntity serviceTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter)
		{
			return GetMultiManyToOne(accountInstance, serviceTypeInstance, maxNumberOfItemsToReturn, sortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <param name="serviceTypeInstance">ServiceTypeEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToOne(IEntity accountInstance, IEntity serviceTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter, int pageNumber, int pageSize)
		{
			bool validParameters = false;
			validParameters |= (accountInstance!=null);
			validParameters |= (serviceTypeInstance!=null);
			if(!validParameters)
			{
				return GetMulti(filter, maxNumberOfItemsToReturn, sortClauses, null, pageNumber, pageSize);
			}
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMulti(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, filter, accountInstance, serviceTypeInstance, pageNumber, pageSize);
		}

		/// <summary> Deletes from the persistent storage all ServiceLocation entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.</summary>
		/// <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		/// <param name="accountInstance">AccountEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <param name="serviceTypeInstance">ServiceTypeEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMultiManyToOne(IEntity accountInstance, IEntity serviceTypeInstance)
		{
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.DeleteMulti(base.Transaction, accountInstance, serviceTypeInstance);
		}

		/// <summary> Updates in the persistent storage all ServiceLocation entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.
		/// Which fields are updated in those matching entities depends on which fields are <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">ServiceLocationEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="accountInstance">AccountEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <param name="serviceTypeInstance">ServiceTypeEntity instance to use as a filter for the ServiceLocationEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMultiManyToOne(ServiceLocationEntity entityWithNewValues, IEntity accountInstance, IEntity serviceTypeInstance)
		{
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.UpdateMulti(entityWithNewValues, base.Transaction, accountInstance, serviceTypeInstance);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in AssetTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="assetTypeInstance">AssetTypeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAssetTypeCollectionViaServiceLocationAssetTypeId(IEntity assetTypeInstance)
		{
			return GetMultiManyToManyUsingAssetTypeCollectionViaServiceLocationAssetTypeId(assetTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in AssetTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="assetTypeInstance">AssetTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAssetTypeCollectionViaServiceLocationAssetTypeId(IEntity assetTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAssetTypeCollectionViaServiceLocationAssetTypeId(assetTypeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in AssetTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="assetTypeInstance">AssetTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAssetTypeCollectionViaServiceLocationAssetTypeId(IEntity assetTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingAssetTypeCollectionViaServiceLocationAssetTypeId(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, assetTypeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in AssetTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="assetTypeInstance">AssetTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAssetTypeCollectionViaServiceLocationAssetTypeId(IEntity assetTypeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAssetTypeCollectionViaServiceLocationAssetTypeId(assetTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in AssetTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="assetTypeInstance">AssetTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAssetTypeCollectionViaServiceLocationAssetTypeId(IEntity assetTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingAssetTypeCollectionViaServiceLocationAssetTypeId(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, assetTypeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance)
		{
			return GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(deepFryerInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(deepFryerInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingDeepFryerCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(deepFryerInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingDeepFryerCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(IEntity deepFryerServiceInstance)
		{
			return GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(deepFryerServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(IEntity deepFryerServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(deepFryerServiceInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(IEntity deepFryerServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerServiceInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(IEntity deepFryerServiceInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(deepFryerServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(IEntity deepFryerServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerServiceInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment__(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment__(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment__(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment__(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment__(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment__(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment__(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment__(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment__(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment__(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_____(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_____(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_____(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_____(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_____(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_____(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_____(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_____(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment_____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment____(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment____(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment____(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment____(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment____(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment____(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment____(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment____(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment______(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment______(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment______(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment______(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment______(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment______(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment______(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment______(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment______(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment______(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment___(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment___(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment___(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment___(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment___(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment___(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment___(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment___(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment___(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment___(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaServiceLocationEmployeeAssignment(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaServiceLocationEmployeeAssignment(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog_(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog_(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog_(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog_(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog_(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaDeepFryerServiceChangeLog_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog_(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog_(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog_(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaDeepFryerServiceChangeLog_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerServiceChangeLog(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaServiceLocationRecycleType(IEntity recycleTypeInstance)
		{
			return GetMultiManyToManyUsingRecycleTypeCollectionViaServiceLocationRecycleType(recycleTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaServiceLocationRecycleType(IEntity recycleTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingRecycleTypeCollectionViaServiceLocationRecycleType(recycleTypeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingRecycleTypeCollectionViaServiceLocationRecycleType(IEntity recycleTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingRecycleTypeCollectionViaServiceLocationRecycleType(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleTypeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaServiceLocationRecycleType(IEntity recycleTypeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingRecycleTypeCollectionViaServiceLocationRecycleType(recycleTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaServiceLocationRecycleType(IEntity recycleTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingRecycleTypeCollectionViaServiceLocationRecycleType(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleTypeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(IEntity userInstance)
		{
			return GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(userInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingUserCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(IEntity userInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingUserCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in WorkOrderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderInstance">WorkOrderEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderEmployee(IEntity workOrderInstance)
		{
			return GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderEmployee(workOrderInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderInstance">WorkOrderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderEmployee(IEntity workOrderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderEmployee(workOrderInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderInstance">WorkOrderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderEmployee(IEntity workOrderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingWorkOrderCollectionViaWorkOrderEmployee(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in WorkOrderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderInstance">WorkOrderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderEmployee(IEntity workOrderInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderEmployee(workOrderInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderInstance">WorkOrderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderEmployee(IEntity workOrderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingWorkOrderCollectionViaWorkOrderEmployee(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in WorkOrderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderInstance">WorkOrderEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderServiceLocation(IEntity workOrderInstance)
		{
			return GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderServiceLocation(workOrderInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderInstance">WorkOrderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderServiceLocation(IEntity workOrderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderServiceLocation(workOrderInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderInstance">WorkOrderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderServiceLocation(IEntity workOrderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingWorkOrderCollectionViaWorkOrderServiceLocation(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in WorkOrderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderInstance">WorkOrderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderServiceLocation(IEntity workOrderInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderServiceLocation(workOrderInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderInstance">WorkOrderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderCollectionViaWorkOrderServiceLocation(IEntity workOrderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingWorkOrderCollectionViaWorkOrderServiceLocation(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in WorkOrderEmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderEmployeeInstance">WorkOrderEmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(IEntity workOrderEmployeeInstance)
		{
			return GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(workOrderEmployeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderEmployeeInstance">WorkOrderEmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(IEntity workOrderEmployeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(workOrderEmployeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderEmployeeInstance">WorkOrderEmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(IEntity workOrderEmployeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingWorkOrderEmployeeCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderEmployeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in WorkOrderEmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderEmployeeInstance">WorkOrderEmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(IEntity workOrderEmployeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(workOrderEmployeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderEmployeeInstance">WorkOrderEmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(IEntity workOrderEmployeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingWorkOrderEmployeeCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderEmployeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in WorkOrderServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderServiceLocationInstance">WorkOrderServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(IEntity workOrderServiceLocationInstance)
		{
			return GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(workOrderServiceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderServiceLocationInstance">WorkOrderServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(IEntity workOrderServiceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(workOrderServiceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderServiceLocationInstance">WorkOrderServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(IEntity workOrderServiceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingWorkOrderServiceLocationCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderServiceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in WorkOrderServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderServiceLocationInstance">WorkOrderServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(IEntity workOrderServiceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(workOrderServiceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this ServiceLocationCollection object all ServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderServiceLocationInstance">WorkOrderServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(IEntity workOrderServiceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiUsingWorkOrderServiceLocationCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderServiceLocationInstance, prefetchPathToUse);
		}


		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, null, 0, 0);
		}

		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations)
		{
			return GetMultiAsDataTable(selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, 0, 0);
		}
		
		/// <summary> Retrieves Entity rows in a datatable which match the specified filter. It will always create a new connection to the database.</summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations, int pageNumber, int pageSize)
		{
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ServiceLocationFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ServiceLocationFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are
		/// applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ServiceLocationFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, filter, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(ServiceLocationFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
		{
			return GetScalar(fieldIndex, expressionToExecute, aggregateToApply, filter, null, groupByClause);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <param name="filter">The filter to apply to retrieve the scalar</param>
		/// <param name="relations">The relations to walk</param>
		/// <param name="groupByClause">The groupby clause to apply to retrieve the scalar</param>
		/// <returns>the scalar value requested</returns>
		public virtual object GetScalar(ServiceLocationFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
		{
			EntityFields fields = new EntityFields(1);
			fields[0] = EntityFieldFactory.Create(fieldIndex);
			if((fields[0].ExpressionToApply == null) || (expressionToExecute != null))
			{
				fields[0].ExpressionToApply = expressionToExecute;
			}
			if((fields[0].AggregateFunctionToApply == AggregateFunction.None) || (aggregateToApply != AggregateFunction.None))
			{
				fields[0].AggregateFunctionToApply = aggregateToApply;
			}
			ServiceLocationDAO dao = DAOFactory.CreateServiceLocationDAO();
			return dao.GetScalar(fields, base.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateServiceLocationDAO();
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}


		#region Custom EntityCollection code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCollectionCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
