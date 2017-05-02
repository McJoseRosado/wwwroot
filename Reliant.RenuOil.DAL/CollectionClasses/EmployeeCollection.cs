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

	/// <summary>Collection class for storing and retrieving collections of EmployeeEntity objects. </summary>
	[Serializable]
	public partial class EmployeeCollection : EntityCollectionBase<EmployeeEntity>
	{
		/// <summary> CTor</summary>
		public EmployeeCollection():base(new EmployeeEntityFactory())
		{
		}

		/// <summary> CTor</summary>
		/// <param name="initialContents">The initial contents of this collection.</param>
		public EmployeeCollection(IList<EmployeeEntity> initialContents):base(new EmployeeEntityFactory())
		{
			AddRange(initialContents);
		}

		/// <summary> CTor</summary>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public EmployeeCollection(IEntityFactory entityFactoryToUse):base(entityFactoryToUse)
		{
		}

		/// <summary> Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EmployeeCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}



		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_____(IEntity accountInstance)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_____(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_____(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_____(accountInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_____(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment_____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_____(IEntity accountInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_____(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_____(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment_____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment____(IEntity accountInstance)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment____(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment____(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment____(accountInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment____(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment____(IEntity accountInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment____(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment____(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaWorkOrder(IEntity accountInstance)
		{
			return GetMultiManyToManyUsingAccountCollectionViaWorkOrder(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaWorkOrder(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAccountCollectionViaWorkOrder(accountInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAccountCollectionViaWorkOrder(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaWorkOrder(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaWorkOrder(IEntity accountInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAccountCollectionViaWorkOrder(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaWorkOrder(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaWorkOrder(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment______(IEntity accountInstance)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment______(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment______(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment______(accountInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment______(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment______(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment______(IEntity accountInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment______(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment______(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment______(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_(IEntity accountInstance)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_(accountInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_(IEntity accountInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment_(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment(IEntity accountInstance)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment(accountInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment(IEntity accountInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment___(IEntity accountInstance)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment___(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment___(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment___(accountInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment___(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment___(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment___(IEntity accountInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment___(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment___(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment___(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment__(IEntity accountInstance)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment__(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment__(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment__(accountInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment__(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment__(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment__(IEntity accountInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment__(accountInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AccountEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="accountInstance">AccountEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAccountCollectionViaAccountEmployeeAssignment__(IEntity accountInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAccountCollectionViaAccountEmployeeAssignment__(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, accountInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in AssetReclamationServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="assetReclamationServiceInstance">AssetReclamationServiceEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(IEntity assetReclamationServiceInstance)
		{
			return GetMultiManyToManyUsingAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(assetReclamationServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AssetReclamationServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="assetReclamationServiceInstance">AssetReclamationServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(IEntity assetReclamationServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(assetReclamationServiceInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AssetReclamationServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="assetReclamationServiceInstance">AssetReclamationServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(IEntity assetReclamationServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, assetReclamationServiceInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in AssetReclamationServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="assetReclamationServiceInstance">AssetReclamationServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(IEntity assetReclamationServiceInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(assetReclamationServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in AssetReclamationServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="assetReclamationServiceInstance">AssetReclamationServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(IEntity assetReclamationServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingAssetReclamationServiceCollectionViaAssetReclamationServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, assetReclamationServiceInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance)
		{
			return GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(deepFryerInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(deepFryerInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingDeepFryerCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in DeepFryerEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerInstance">DeepFryerEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(IEntity deepFryerInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingDeepFryerCollectionViaDeepFryerService(deepFryerInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingDeepFryerCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(IEntity deepFryerServiceInstance)
		{
			return GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(deepFryerServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(IEntity deepFryerServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(deepFryerServiceInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerServiceInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(IEntity deepFryerServiceInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(deepFryerServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerServiceInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(IEntity deepFryerServiceInstance)
		{
			return GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(deepFryerServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(IEntity deepFryerServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(deepFryerServiceInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(IEntity deepFryerServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerServiceInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(IEntity deepFryerServiceInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(deepFryerServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in DeepFryerServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="deepFryerServiceInstance">DeepFryerServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(IEntity deepFryerServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingDeepFryerServiceCollectionViaDeepFryerServiceChangeLog_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, deepFryerServiceInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction(IEntity recycleServiceInstance)
		{
			return GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction(recycleServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction(IEntity recycleServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction(recycleServiceInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction(IEntity recycleServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingRecycleServiceCollectionViaRecycleServiceAction(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleServiceInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction(IEntity recycleServiceInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction(recycleServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction(IEntity recycleServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingRecycleServiceCollectionViaRecycleServiceAction(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleServiceInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceChangeLog(IEntity recycleServiceInstance)
		{
			return GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceChangeLog(recycleServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceChangeLog(IEntity recycleServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceChangeLog(recycleServiceInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceChangeLog(IEntity recycleServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingRecycleServiceCollectionViaRecycleServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleServiceInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceChangeLog(IEntity recycleServiceInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceChangeLog(recycleServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceChangeLog(IEntity recycleServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingRecycleServiceCollectionViaRecycleServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleServiceInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction_(IEntity recycleServiceInstance)
		{
			return GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction_(recycleServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction_(IEntity recycleServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction_(recycleServiceInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction_(IEntity recycleServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingRecycleServiceCollectionViaRecycleServiceAction_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleServiceInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction_(IEntity recycleServiceInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction_(recycleServiceInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleServiceEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleServiceInstance">RecycleServiceEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleServiceCollectionViaRecycleServiceAction_(IEntity recycleServiceInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingRecycleServiceCollectionViaRecycleServiceAction_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleServiceInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction(IEntity recycleTypeInstance)
		{
			return GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction(recycleTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction(IEntity recycleTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction(recycleTypeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction(IEntity recycleTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingRecycleTypeCollectionViaRecycleServiceAction(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleTypeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction(IEntity recycleTypeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction(recycleTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction(IEntity recycleTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingRecycleTypeCollectionViaRecycleServiceAction(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleTypeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction_(IEntity recycleTypeInstance)
		{
			return GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction_(recycleTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction_(IEntity recycleTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction_(recycleTypeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction_(IEntity recycleTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingRecycleTypeCollectionViaRecycleServiceAction_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleTypeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction_(IEntity recycleTypeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction_(recycleTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in RecycleTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="recycleTypeInstance">RecycleTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingRecycleTypeCollectionViaRecycleServiceAction_(IEntity recycleTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingRecycleTypeCollectionViaRecycleServiceAction_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, recycleTypeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment_____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerService(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment______(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment______(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment______(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment______(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment______(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment______(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment______(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment______(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment______(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment______(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment____(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment____(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment____(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment____(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment____(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment____(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment____(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment____(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment__(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment__(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment__(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment__(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment__(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment__(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment__(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment__(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment__(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment__(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment___(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment___(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment___(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment___(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment___(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment___(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment___(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment___(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment___(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaServiceLocationEmployeeAssignment___(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog_(IEntity serviceLocationInstance)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog_(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog_(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog_(serviceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog_(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaDeepFryerServiceChangeLog_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog_(IEntity serviceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog_(serviceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceLocationInstance">ServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceLocationCollectionViaDeepFryerServiceChangeLog_(IEntity serviceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceLocationCollectionViaDeepFryerServiceChangeLog_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceLocationInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in ServiceTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceTypeInstance">ServiceTypeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceTypeCollectionViaWorkOrder(IEntity serviceTypeInstance)
		{
			return GetMultiManyToManyUsingServiceTypeCollectionViaWorkOrder(serviceTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceTypeInstance">ServiceTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceTypeCollectionViaWorkOrder(IEntity serviceTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingServiceTypeCollectionViaWorkOrder(serviceTypeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceTypeInstance">ServiceTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingServiceTypeCollectionViaWorkOrder(IEntity serviceTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceTypeCollectionViaWorkOrder(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceTypeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in ServiceTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceTypeInstance">ServiceTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceTypeCollectionViaWorkOrder(IEntity serviceTypeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingServiceTypeCollectionViaWorkOrder(serviceTypeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in ServiceTypeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="serviceTypeInstance">ServiceTypeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingServiceTypeCollectionViaWorkOrder(IEntity serviceTypeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingServiceTypeCollectionViaWorkOrder(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, serviceTypeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in StatusEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="statusInstance">StatusEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingStatusCollectionViaLoad(IEntity statusInstance)
		{
			return GetMultiManyToManyUsingStatusCollectionViaLoad(statusInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in StatusEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="statusInstance">StatusEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingStatusCollectionViaLoad(IEntity statusInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingStatusCollectionViaLoad(statusInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in StatusEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="statusInstance">StatusEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingStatusCollectionViaLoad(IEntity statusInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingStatusCollectionViaLoad(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, statusInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in StatusEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="statusInstance">StatusEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingStatusCollectionViaLoad(IEntity statusInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingStatusCollectionViaLoad(statusInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in StatusEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="statusInstance">StatusEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingStatusCollectionViaLoad(IEntity statusInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingStatusCollectionViaLoad(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, statusInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(IEntity userInstance)
		{
			return GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(userInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(IEntity userInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaDeepFryerServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog_(IEntity userInstance)
		{
			return GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog_(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog_(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog_(userInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog_(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaDeepFryerServiceChangeLog_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog_(IEntity userInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog_(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaDeepFryerServiceChangeLog_(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaDeepFryerServiceChangeLog_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction___(IEntity userInstance)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction___(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction___(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction___(userInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction___(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaRecycleServiceAction___(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction___(IEntity userInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction___(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction___(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaRecycleServiceAction___(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaAssetReclamationServiceChangeLog(IEntity userInstance)
		{
			return GetMultiManyToManyUsingUserCollectionViaAssetReclamationServiceChangeLog(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaAssetReclamationServiceChangeLog(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUserCollectionViaAssetReclamationServiceChangeLog(userInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUserCollectionViaAssetReclamationServiceChangeLog(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaAssetReclamationServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaAssetReclamationServiceChangeLog(IEntity userInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUserCollectionViaAssetReclamationServiceChangeLog(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaAssetReclamationServiceChangeLog(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaAssetReclamationServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceChangeLog(IEntity userInstance)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceChangeLog(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceChangeLog(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceChangeLog(userInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceChangeLog(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaRecycleServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceChangeLog(IEntity userInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceChangeLog(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceChangeLog(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaRecycleServiceChangeLog(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction_(IEntity userInstance)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction_(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction_(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction_(userInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction_(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaRecycleServiceAction_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction_(IEntity userInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction_(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction_(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaRecycleServiceAction_(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction__(IEntity userInstance)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction__(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction__(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction__(userInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction__(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaRecycleServiceAction__(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction__(IEntity userInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction__(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction__(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaRecycleServiceAction__(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction(IEntity userInstance)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction(userInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public virtual bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, int pageNumber, int pageSize)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaRecycleServiceAction(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction(IEntity userInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction(userInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in UserEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="userInstance">UserEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUserCollectionViaRecycleServiceAction(IEntity userInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPrefetchPath prefetchPathToUse)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingUserCollectionViaRecycleServiceAction(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, userInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in WorkOrderEmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderEmployeeInstance">WorkOrderEmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(IEntity workOrderEmployeeInstance)
		{
			return GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(workOrderEmployeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderEmployeeInstance">WorkOrderEmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(IEntity workOrderEmployeeInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(workOrderEmployeeInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEmployeeEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingWorkOrderEmployeeCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderEmployeeInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in WorkOrderEmployeeEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderEmployeeInstance">WorkOrderEmployeeEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(IEntity workOrderEmployeeInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingWorkOrderEmployeeCollectionViaDeepFryerService(workOrderEmployeeInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderEmployeeEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingWorkOrderEmployeeCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderEmployeeInstance, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  Relation of type 'm:n' with the passed in WorkOrderServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderServiceLocationInstance">WorkOrderServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(IEntity workOrderServiceLocationInstance)
		{
			return GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(workOrderServiceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, 0, 0);
		}
		
		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderServiceLocationInstance">WorkOrderServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(IEntity workOrderServiceLocationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(workOrderServiceLocationInstance, maxNumberOfItemsToReturn, sortClauses, 0, 0);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderServiceLocationEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiUsingWorkOrderServiceLocationCollectionViaDeepFryerService(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, workOrderServiceLocationInstance, pageNumber, pageSize);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a Relation of type 'm:n' with the passed in WorkOrderServiceLocationEntity. 
		/// All current elements in the collection are removed from the collection.</summary>
		/// <param name="workOrderServiceLocationInstance">WorkOrderServiceLocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(IEntity workOrderServiceLocationInstance, IPrefetchPath prefetchPathToUse)
		{
			return GetMultiManyToManyUsingWorkOrderServiceLocationCollectionViaDeepFryerService(workOrderServiceLocationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses, prefetchPathToUse);
		}

		/// <summary> Retrieves in this EmployeeCollection object all EmployeeEntity objects which are related via a  relation of type 'm:n' with the passed in WorkOrderServiceLocationEntity. 
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}


		
		/// <summary> Gets a scalar value, calculated with the aggregate. the field index specified is the field the aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(EmployeeFieldIndex fieldIndex, AggregateFunction aggregateToApply)
		{
			return GetScalar(fieldIndex, null, aggregateToApply, null, null, null);
		}

		/// <summary> Gets a scalar value, calculated with the aggregate and expression specified. the field index specified is the field the expression and aggregate are applied on.</summary>
		/// <param name="fieldIndex">Field index of field to which to apply the aggregate function and expression</param>
		/// <param name="expressionToExecute">The expression to execute. Can be null</param>
		/// <param name="aggregateToApply">Aggregate function to apply. </param>
		/// <returns>the scalar value requested</returns>
		public object GetScalar(EmployeeFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply)
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
		public object GetScalar(EmployeeFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter)
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
		public object GetScalar(EmployeeFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IGroupByCollection groupByClause)
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
		public virtual object GetScalar(EmployeeFieldIndex fieldIndex, IExpression expressionToExecute, AggregateFunction aggregateToApply, IPredicate filter, IRelationCollection relations, IGroupByCollection groupByClause)
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.GetScalar(fields, base.Transaction, filter, relations, groupByClause);
		}
		
		/// <summary>Creats a new DAO instance so code which is in the base class can still use the proper DAO object.</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateEmployeeDAO();
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
