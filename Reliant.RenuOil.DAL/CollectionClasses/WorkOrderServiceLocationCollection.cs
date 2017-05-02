﻿///////////////////////////////////////////////////////////////
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

	/// <summary>Collection class for storing and retrieving collections of WorkOrderServiceLocationEntity objects. </summary>
	[Serializable]
	public partial class WorkOrderServiceLocationCollection : EntityCollectionBase<WorkOrderServiceLocationEntity>
	{
		/// <summary> CTor</summary>
		public WorkOrderServiceLocationCollection():base(new WorkOrderServiceLocationEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public WorkOrderServiceLocationCollection(IList<WorkOrderServiceLocationEntity> initialContents):base(new WorkOrderServiceLocationEntityFactory())
		{
			AddRange(initialContents);
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public WorkOrderServiceLocationCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected WorkOrderServiceLocationCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}


		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <param name="workOrderInstance">WorkOrderEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity serviceLocationInstance, IEntity workOrderInstance)
		{
			return GetMultiManyToOne(serviceLocationInstance, workOrderInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, null, 0, 0);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <param name="workOrderInstance">WorkOrderEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity serviceLocationInstance, IEntity workOrderInstance, IPredicateExpression filter)
		{
			return GetMultiManyToOne(serviceLocationInstance, workOrderInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <param name="workOrderInstance">WorkOrderEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(IEntity serviceLocationInstance, IEntity workOrderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter)
		{
			return GetMultiManyToOne(serviceLocationInstance, workOrderInstance, maxNumberOfItemsToReturn, sortClauses, filter, 0, 0);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <param name="workOrderInstance">WorkOrderEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToOne(IEntity serviceLocationInstance, IEntity workOrderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter, int pageNumber, int pageSize)
		{
			bool validParameters = false;
			validParameters |= (serviceLocationInstance!=null);
			validParameters |= (workOrderInstance!=null);
			if(!validParameters)
			{
				return GetMulti(filter, maxNumberOfItemsToReturn, sortClauses, null, pageNumber, pageSize);
			}
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetMulti(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, filter, serviceLocationInstance, workOrderInstance, pageNumber, pageSize);
		}

		/// <summary> Deletes from the persistent storage all WorkOrderServiceLocation entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.</summary>
		/// <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		/// <param name="serviceLocationInstance">ServiceLocationEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <param name="workOrderInstance">WorkOrderEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMultiManyToOne(IEntity serviceLocationInstance, IEntity workOrderInstance)
		{
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.DeleteMulti(base.Transaction, serviceLocationInstance, workOrderInstance);
		}

		/// <summary> Updates in the persistent storage all WorkOrderServiceLocation entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.
		/// Which fields are updated in those matching entities depends on which fields are <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. </summary>
		/// <param name="entityWithNewValues">WorkOrderServiceLocationEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="serviceLocationInstance">ServiceLocationEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <param name="workOrderInstance">WorkOrderEntity instance to use as a filter for the WorkOrderServiceLocationEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMultiManyToOne(WorkOrderServiceLocationEntity entityWithNewValues, IEntity serviceLocationInstance, IEntity workOrderInstance)
		{
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.UpdateMulti(entityWithNewValues, base.Transaction, serviceLocationInstance, workOrderInstance);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance)
		{
			return GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(deepFryerInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(deepFryerInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerEntity. 
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
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetMultiUsingDeepFryerCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(deepFryerInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerEntity. 
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
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetMultiUsingDeepFryerCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(IEntity employeeInstance)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(IEntity employeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(employeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
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
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in EmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="employeeInstance">EmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(IEntity employeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingEmployeeCollectionViaDeepFryerService(employeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in EmployeeEntity. 
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
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetMultiUsingEmployeeCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, employeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationAssetTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationAssetTypeInstance">ServiceLocationAssetTypeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationAssetTypeCollectionViaAssetReclamationService(IEntity serviceLocationAssetTypeInstance)
		{
			return GetMultiManyToManyUsingServiceLocationAssetTypeCollectionViaAssetReclamationService(serviceLocationAssetTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationAssetTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationAssetTypeInstance">ServiceLocationAssetTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationAssetTypeCollectionViaAssetReclamationService(IEntity serviceLocationAssetTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationAssetTypeCollectionViaAssetReclamationService(serviceLocationAssetTypeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationAssetTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationAssetTypeInstance">ServiceLocationAssetTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationAssetTypeCollectionViaAssetReclamationService(IEntity serviceLocationAssetTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetMultiUsingServiceLocationAssetTypeCollectionViaAssetReclamationService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationAssetTypeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationAssetTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationAssetTypeInstance">ServiceLocationAssetTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationAssetTypeCollectionViaAssetReclamationService(IEntity serviceLocationAssetTypeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationAssetTypeCollectionViaAssetReclamationService(serviceLocationAssetTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this WorkOrderServiceLocationCollection object all WorkOrderServiceLocationEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationAssetTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationAssetTypeInstance">ServiceLocationAssetTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationAssetTypeCollectionViaAssetReclamationService(IEntity serviceLocationAssetTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetMultiUsingServiceLocationAssetTypeCollectionViaAssetReclamationService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationAssetTypeInstance, prefetchPathToUse);
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
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(WorkOrderServiceLocationFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(WorkOrderServiceLocationFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
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
		public object GetScalar(WorkOrderServiceLocationFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
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
		public object GetScalar(WorkOrderServiceLocationFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
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
		public virtual object GetScalar(WorkOrderServiceLocationFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
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
			WorkOrderServiceLocationDAO dao = DAOFactory.CreateWorkOrderServiceLocationDAO();
			return dao.GetScalar(fields, base.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateWorkOrderServiceLocationDAO();
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
