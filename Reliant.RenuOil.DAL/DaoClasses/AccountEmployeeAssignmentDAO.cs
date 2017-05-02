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
using System.Data.Common;
using System.Collections;

using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.CollectionClasses;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL;

using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE.SqlServer;


namespace Reliant.RenuOil.DAL.DaoClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// General DAO class for the AccountEmployeeAssignment Entity. It will perform database oriented actions for
	/// a entity of type 'AccountEmployeeAssignmentEntity'. This DAO works on an EntityFields object. 
	/// </summary>
	public partial class AccountEmployeeAssignmentDAO : DaoBase
	{
		/// <summary>CTor</summary>
		public AccountEmployeeAssignmentDAO() : base(InheritanceInfoProviderSingleton.GetInstance(), new DynamicQueryEngine(), InheritanceHierarchyType.None, "AccountEmployeeAssignmentEntity", new AccountEmployeeAssignmentEntityFactory())
		{
		}
		
		/// <summary>CTor</summary>
		/// <param name="inheritanceInfoProviderToUse">Inheritance info provider to use.</param>
		/// <param name="dqeToUse">Dqe to use.</param>
		/// <param name="typeOfInheritance">Type of inheritance.</param>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="entityFactory">Entity factory.</param>
		internal AccountEmployeeAssignmentDAO(IInheritanceInfoProvider inheritanceInfoProviderToUse, DynamicQueryEngineBase dqeToUse, InheritanceHierarchyType typeOfInheritance, string entityName, IEntityFactory entityFactory) : base(inheritanceInfoProviderToUse, dqeToUse, typeOfInheritance, entityName, entityFactory)
		{
		}


		/// <summary>
		/// Retrieves in the calling AccountEmployeeAssignmentCollection object all AccountEmployeeAssignmentEntity objects which have data in common
		/// with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		/// </summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		/// If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. 
		/// When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <param name="accountInstance">AccountEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to return</param>
		/// <param name="employee____Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to return</param>
		/// <param name="employee_____Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to return</param>
		/// <param name="employee______Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to return</param>
		/// <param name="employee___Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to return</param>
		/// <param name="employeeInstance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to return</param>
		/// <param name="employee_Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to return</param>
		/// <param name="employee__Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to return</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		public bool GetMulti(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IPredicateExpression filter, IEntity accountInstance, IEntity employee____Instance, IEntity employee_____Instance, IEntity employee______Instance, IEntity employee___Instance, IEntity employeeInstance, IEntity employee_Instance, IEntity employee__Instance, int pageNumber, int pageSize)
		{
			base.EntityFactoryToUse = entityFactoryToUse;
			IEntityFields fieldsToReturn = EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity);
			IPredicateExpression selectFilter = CreateFilterUsingForeignKeys(accountInstance, employee____Instance, employee_____Instance, employee______Instance, employee___Instance, employeeInstance, employee_Instance, employee__Instance, fieldsToReturn);
			if(filter!=null)
			{
				selectFilter.AddWithAnd(filter);
			}
			return base.PerformGetMultiAction(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, selectFilter, null, null, null, pageNumber, pageSize);
		}

		/// <summary>
		/// Retrieves entities of the type 'AccountEmployeeAssignmentEntity' in a datatable which match the specified filter. 
		/// It will always create a new connection to the database.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		/// If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. 
		/// When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>a filled datatable if succeeded, false otherwise</returns>
		public virtual DataTable GetMultiAsDataTable(long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicate selectFilter, IRelationCollection relations, int pageNumber, int pageSize)
		{
			return base.PerformGetMultiAsDataTableAction(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, pageNumber, pageSize);
		}

	
		/// <summary>
		/// Deletes from the persistent storage all 'AccountEmployeeAssignment' entities which have data in common
		/// with the specified related Entities. If one is omitted, that entity is not used as a filter. 
		/// </summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="accountInstance">AccountEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to delete</param>
		/// <param name="employee____Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to delete</param>
		/// <param name="employee_____Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to delete</param>
		/// <param name="employee______Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to delete</param>
		/// <param name="employee___Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to delete</param>
		/// <param name="employeeInstance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to delete</param>
		/// <param name="employee_Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to delete</param>
		/// <param name="employee__Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to delete</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMulti(ITransaction containingTransaction, IEntity accountInstance, IEntity employee____Instance, IEntity employee_____Instance, IEntity employee______Instance, IEntity employee___Instance, IEntity employeeInstance, IEntity employee_Instance, IEntity employee__Instance)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity);
			IPredicateExpression deleteFilter = CreateFilterUsingForeignKeys(accountInstance, employee____Instance, employee_____Instance, employee______Instance, employee___Instance, employeeInstance, employee_Instance, employee__Instance, fields);
			return base.DeleteMulti(containingTransaction, deleteFilter);
		}

		/// <summary>
		/// Updates all entities of the same type or subtype of the entity <i>entityWithNewValues</i> directly in the persistent storage if they match the filter
		/// supplied in <i>filterBucket</i>. Only the fields changed in entityWithNewValues are updated for these fields. Entities of a subtype of the type
		/// of <i>entityWithNewValues</i> which are affected by the filterBucket's filter will thus also be updated. 
		/// </summary>
		/// <param name="entityWithNewValues">IEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="accountInstance">AccountEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to update</param>
		/// <param name="employee____Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to update</param>
		/// <param name="employee_____Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to update</param>
		/// <param name="employee______Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to update</param>
		/// <param name="employee___Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to update</param>
		/// <param name="employeeInstance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to update</param>
		/// <param name="employee_Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to update</param>
		/// <param name="employee__Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects to update</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(IEntity entityWithNewValues, ITransaction containingTransaction, IEntity accountInstance, IEntity employee____Instance, IEntity employee_____Instance, IEntity employee______Instance, IEntity employee___Instance, IEntity employeeInstance, IEntity employee_Instance, IEntity employee__Instance)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity);
			IPredicateExpression updateFilter = CreateFilterUsingForeignKeys(accountInstance, employee____Instance, employee_____Instance, employee______Instance, employee___Instance, employeeInstance, employee_Instance, employee__Instance, fields);
			return base.UpdateMulti(entityWithNewValues, containingTransaction, updateFilter);
		}
	

		/// <summary>
		/// Determines the connection to use. If transaction to use is null, a new connection is created, otherwise the connection of the transaction is used.
		/// </summary>
		/// <param name="transactionToUse">Transaction to use.</param>
		/// <returns>a ready to use connection object.</returns>
		protected override IDbConnection DetermineConnectionToUse(ITransaction transactionToUse)
		{
			return DbUtils.DetermineConnectionToUse(transactionToUse);
		}
		
		/// <summary>
		/// Creates a new ADO.NET data adapter.
		/// </summary>
		/// <returns>ready to use ADO.NET data-adapter</returns>
		protected override DbDataAdapter CreateDataAdapter()
		{
			return DbUtils.CreateDataAdapter();
		}


		/// <summary>
		/// Creates a PredicateExpression which should be used as a filter when any combination of available foreign keys is specified.
		/// </summary>
		/// <param name="accountInstance">AccountEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects</param>
		/// <param name="employee____Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects</param>
		/// <param name="employee_____Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects</param>
		/// <param name="employee______Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects</param>
		/// <param name="employee___Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects</param>
		/// <param name="employeeInstance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects</param>
		/// <param name="employee_Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects</param>
		/// <param name="employee__Instance">EmployeeEntity instance to use as a filter for the AccountEmployeeAssignmentEntity objects</param>
		/// <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the fieldset of the target entity.</param>
		/// <returns>A ready to use PredicateExpression based on the passed in foreign key value holders.</returns>
		private IPredicateExpression CreateFilterUsingForeignKeys(IEntity accountInstance, IEntity employee____Instance, IEntity employee_____Instance, IEntity employee______Instance, IEntity employee___Instance, IEntity employeeInstance, IEntity employee_Instance, IEntity employee__Instance, IEntityFields fieldsToReturn)
		{
			IPredicateExpression selectFilter = new PredicateExpression();
			
			if(accountInstance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)AccountEmployeeAssignmentFieldIndex.AccountId], ComparisonOperator.Equal, ((AccountEntity)accountInstance).AccountId));
			}
			if(employee____Instance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)AccountEmployeeAssignmentFieldIndex.Thursday], ComparisonOperator.Equal, ((EmployeeEntity)employee____Instance).EmployeeId));
			}
			if(employee_____Instance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)AccountEmployeeAssignmentFieldIndex.Tuesday], ComparisonOperator.Equal, ((EmployeeEntity)employee_____Instance).EmployeeId));
			}
			if(employee______Instance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)AccountEmployeeAssignmentFieldIndex.Wednesday], ComparisonOperator.Equal, ((EmployeeEntity)employee______Instance).EmployeeId));
			}
			if(employee___Instance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)AccountEmployeeAssignmentFieldIndex.Sunday], ComparisonOperator.Equal, ((EmployeeEntity)employee___Instance).EmployeeId));
			}
			if(employeeInstance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)AccountEmployeeAssignmentFieldIndex.Friday], ComparisonOperator.Equal, ((EmployeeEntity)employeeInstance).EmployeeId));
			}
			if(employee_Instance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)AccountEmployeeAssignmentFieldIndex.Monday], ComparisonOperator.Equal, ((EmployeeEntity)employee_Instance).EmployeeId));
			}
			if(employee__Instance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)AccountEmployeeAssignmentFieldIndex.Saturday], ComparisonOperator.Equal, ((EmployeeEntity)employee__Instance).EmployeeId));
			}
			return selectFilter;
		}

		#region Custom DAO code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
