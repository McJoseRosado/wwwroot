///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.Linq
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.DaoClasses;
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.RelationClasses;

namespace Reliant.RenuOil.DAL.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public class LinqMetaData : ILinqMetaData
	{
		#region Class Member Declarations
		private ITransaction _transactionToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the transaction object to use empty. This is ok if you're not executing queries created with this
		/// meta data inside a transaction. If you're executing the queries created with this meta-data inside a transaction, either set the Transaction property
		/// on the IQueryable.Provider instance of the created LLBLGenProQuery object prior to execution or use the ctor which accepts a transaction object.</summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse) : this(transactionToUse, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse, FunctionMappingStore customFunctionMappings)
		{
			_transactionToUse = transactionToUse;
			_customFunctionMappings = customFunctionMappings;
		}
		
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((Reliant.RenuOil.DAL.EntityType)typeOfEntity)
			{
				case Reliant.RenuOil.DAL.EntityType.AccountEntity:
					toReturn = this.Account;
					break;
				case Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity:
					toReturn = this.AccountEmployeeAssignment;
					break;
				case Reliant.RenuOil.DAL.EntityType.AssetCategoryEntity:
					toReturn = this.AssetCategory;
					break;
				case Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceEntity:
					toReturn = this.AssetReclamationService;
					break;
				case Reliant.RenuOil.DAL.EntityType.AssetReclamationServiceChangeLogEntity:
					toReturn = this.AssetReclamationServiceChangeLog;
					break;
				case Reliant.RenuOil.DAL.EntityType.AssetTypeEntity:
					toReturn = this.AssetType;
					break;
				case Reliant.RenuOil.DAL.EntityType.BaleEntity:
					toReturn = this.Bale;
					break;
				case Reliant.RenuOil.DAL.EntityType.ChangeLogEntity:
					toReturn = this.ChangeLog;
					break;
				case Reliant.RenuOil.DAL.EntityType.ChangeTypeEntity:
					toReturn = this.ChangeType;
					break;
				case Reliant.RenuOil.DAL.EntityType.DeepFryerEntity:
					toReturn = this.DeepFryer;
					break;
				case Reliant.RenuOil.DAL.EntityType.DeepFryerChangeLogEntity:
					toReturn = this.DeepFryerChangeLog;
					break;
				case Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity:
					toReturn = this.DeepFryerService;
					break;
				case Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity:
					toReturn = this.DeepFryerServiceChangeLog;
					break;
				case Reliant.RenuOil.DAL.EntityType.DockEntity:
					toReturn = this.Dock;
					break;
				case Reliant.RenuOil.DAL.EntityType.ElmahErrorEntity:
					toReturn = this.ElmahError;
					break;
				case Reliant.RenuOil.DAL.EntityType.EmployeeEntity:
					toReturn = this.Employee;
					break;
				case Reliant.RenuOil.DAL.EntityType.LoadEntity:
					toReturn = this.Load;
					break;
				case Reliant.RenuOil.DAL.EntityType.MobileDeviceEntity:
					toReturn = this.MobileDevice;
					break;
				case Reliant.RenuOil.DAL.EntityType.RebateEntity:
					toReturn = this.Rebate;
					break;
				case Reliant.RenuOil.DAL.EntityType.RebateTypeEntity:
					toReturn = this.RebateType;
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleServiceEntity:
					toReturn = this.RecycleService;
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleServiceActionEntity:
					toReturn = this.RecycleServiceAction;
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleServiceChangeLogEntity:
					toReturn = this.RecycleServiceChangeLog;
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity:
					toReturn = this.RecycleType;
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity:
					toReturn = this.RecycleVendor;
					break;
				case Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity:
					toReturn = this.RecycleVendorService;
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity:
					toReturn = this.ServiceLocation;
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeEntity:
					toReturn = this.ServiceLocationAssetType;
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceLocationAssetTypeChangeLogEntity:
					toReturn = this.ServiceLocationAssetTypeChangeLog;
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceLocationEmployeeAssignmentEntity:
					toReturn = this.ServiceLocationEmployeeAssignment;
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceLocationRecycleTypeEntity:
					toReturn = this.ServiceLocationRecycleType;
					break;
				case Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity:
					toReturn = this.ServiceType;
					break;
				case Reliant.RenuOil.DAL.EntityType.SettingEntity:
					toReturn = this.Setting;
					break;
				case Reliant.RenuOil.DAL.EntityType.StatusEntity:
					toReturn = this.Status;
					break;
				case Reliant.RenuOil.DAL.EntityType.UserEntity:
					toReturn = this.User;
					break;
				case Reliant.RenuOil.DAL.EntityType.UserAccountEntity:
					toReturn = this.UserAccount;
					break;
				case Reliant.RenuOil.DAL.EntityType.UserTypeEntity:
					toReturn = this.UserType;
					break;
				case Reliant.RenuOil.DAL.EntityType.WorkOrderEntity:
					toReturn = this.WorkOrder;
					break;
				case Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity:
					toReturn = this.WorkOrderEmployee;
					break;
				case Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity:
					toReturn = this.WorkOrderServiceLocation;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting AccountEntity instances in the database.</summary>
		public DataSource<AccountEntity> Account
		{
			get { return new DataSource<AccountEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AccountEmployeeAssignmentEntity instances in the database.</summary>
		public DataSource<AccountEmployeeAssignmentEntity> AccountEmployeeAssignment
		{
			get { return new DataSource<AccountEmployeeAssignmentEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AssetCategoryEntity instances in the database.</summary>
		public DataSource<AssetCategoryEntity> AssetCategory
		{
			get { return new DataSource<AssetCategoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AssetReclamationServiceEntity instances in the database.</summary>
		public DataSource<AssetReclamationServiceEntity> AssetReclamationService
		{
			get { return new DataSource<AssetReclamationServiceEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AssetReclamationServiceChangeLogEntity instances in the database.</summary>
		public DataSource<AssetReclamationServiceChangeLogEntity> AssetReclamationServiceChangeLog
		{
			get { return new DataSource<AssetReclamationServiceChangeLogEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AssetTypeEntity instances in the database.</summary>
		public DataSource<AssetTypeEntity> AssetType
		{
			get { return new DataSource<AssetTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BaleEntity instances in the database.</summary>
		public DataSource<BaleEntity> Bale
		{
			get { return new DataSource<BaleEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ChangeLogEntity instances in the database.</summary>
		public DataSource<ChangeLogEntity> ChangeLog
		{
			get { return new DataSource<ChangeLogEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ChangeTypeEntity instances in the database.</summary>
		public DataSource<ChangeTypeEntity> ChangeType
		{
			get { return new DataSource<ChangeTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DeepFryerEntity instances in the database.</summary>
		public DataSource<DeepFryerEntity> DeepFryer
		{
			get { return new DataSource<DeepFryerEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DeepFryerChangeLogEntity instances in the database.</summary>
		public DataSource<DeepFryerChangeLogEntity> DeepFryerChangeLog
		{
			get { return new DataSource<DeepFryerChangeLogEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DeepFryerServiceEntity instances in the database.</summary>
		public DataSource<DeepFryerServiceEntity> DeepFryerService
		{
			get { return new DataSource<DeepFryerServiceEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DeepFryerServiceChangeLogEntity instances in the database.</summary>
		public DataSource<DeepFryerServiceChangeLogEntity> DeepFryerServiceChangeLog
		{
			get { return new DataSource<DeepFryerServiceChangeLogEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DockEntity instances in the database.</summary>
		public DataSource<DockEntity> Dock
		{
			get { return new DataSource<DockEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ElmahErrorEntity instances in the database.</summary>
		public DataSource<ElmahErrorEntity> ElmahError
		{
			get { return new DataSource<ElmahErrorEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource<EmployeeEntity> Employee
		{
			get { return new DataSource<EmployeeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LoadEntity instances in the database.</summary>
		public DataSource<LoadEntity> Load
		{
			get { return new DataSource<LoadEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting MobileDeviceEntity instances in the database.</summary>
		public DataSource<MobileDeviceEntity> MobileDevice
		{
			get { return new DataSource<MobileDeviceEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RebateEntity instances in the database.</summary>
		public DataSource<RebateEntity> Rebate
		{
			get { return new DataSource<RebateEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RebateTypeEntity instances in the database.</summary>
		public DataSource<RebateTypeEntity> RebateType
		{
			get { return new DataSource<RebateTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleServiceEntity instances in the database.</summary>
		public DataSource<RecycleServiceEntity> RecycleService
		{
			get { return new DataSource<RecycleServiceEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleServiceActionEntity instances in the database.</summary>
		public DataSource<RecycleServiceActionEntity> RecycleServiceAction
		{
			get { return new DataSource<RecycleServiceActionEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleServiceChangeLogEntity instances in the database.</summary>
		public DataSource<RecycleServiceChangeLogEntity> RecycleServiceChangeLog
		{
			get { return new DataSource<RecycleServiceChangeLogEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleTypeEntity instances in the database.</summary>
		public DataSource<RecycleTypeEntity> RecycleType
		{
			get { return new DataSource<RecycleTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleVendorEntity instances in the database.</summary>
		public DataSource<RecycleVendorEntity> RecycleVendor
		{
			get { return new DataSource<RecycleVendorEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleVendorServiceEntity instances in the database.</summary>
		public DataSource<RecycleVendorServiceEntity> RecycleVendorService
		{
			get { return new DataSource<RecycleVendorServiceEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceLocationEntity instances in the database.</summary>
		public DataSource<ServiceLocationEntity> ServiceLocation
		{
			get { return new DataSource<ServiceLocationEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceLocationAssetTypeEntity instances in the database.</summary>
		public DataSource<ServiceLocationAssetTypeEntity> ServiceLocationAssetType
		{
			get { return new DataSource<ServiceLocationAssetTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceLocationAssetTypeChangeLogEntity instances in the database.</summary>
		public DataSource<ServiceLocationAssetTypeChangeLogEntity> ServiceLocationAssetTypeChangeLog
		{
			get { return new DataSource<ServiceLocationAssetTypeChangeLogEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceLocationEmployeeAssignmentEntity instances in the database.</summary>
		public DataSource<ServiceLocationEmployeeAssignmentEntity> ServiceLocationEmployeeAssignment
		{
			get { return new DataSource<ServiceLocationEmployeeAssignmentEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceLocationRecycleTypeEntity instances in the database.</summary>
		public DataSource<ServiceLocationRecycleTypeEntity> ServiceLocationRecycleType
		{
			get { return new DataSource<ServiceLocationRecycleTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceTypeEntity instances in the database.</summary>
		public DataSource<ServiceTypeEntity> ServiceType
		{
			get { return new DataSource<ServiceTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SettingEntity instances in the database.</summary>
		public DataSource<SettingEntity> Setting
		{
			get { return new DataSource<SettingEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting StatusEntity instances in the database.</summary>
		public DataSource<StatusEntity> Status
		{
			get { return new DataSource<StatusEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting UserEntity instances in the database.</summary>
		public DataSource<UserEntity> User
		{
			get { return new DataSource<UserEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting UserAccountEntity instances in the database.</summary>
		public DataSource<UserAccountEntity> UserAccount
		{
			get { return new DataSource<UserAccountEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting UserTypeEntity instances in the database.</summary>
		public DataSource<UserTypeEntity> UserType
		{
			get { return new DataSource<UserTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderEntity instances in the database.</summary>
		public DataSource<WorkOrderEntity> WorkOrder
		{
			get { return new DataSource<WorkOrderEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderEmployeeEntity instances in the database.</summary>
		public DataSource<WorkOrderEmployeeEntity> WorkOrderEmployee
		{
			get { return new DataSource<WorkOrderEmployeeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderServiceLocationEntity instances in the database.</summary>
		public DataSource<WorkOrderServiceLocationEntity> WorkOrderServiceLocation
		{
			get { return new DataSource<WorkOrderServiceLocationEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		#region Class Property Declarations
		/// <summary> Gets / sets the ITransaction to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public ITransaction TransactionToUse
		{
			get { return _transactionToUse;}
			set { _transactionToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}