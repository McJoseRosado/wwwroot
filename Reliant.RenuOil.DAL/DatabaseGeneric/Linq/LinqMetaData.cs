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
using Reliant.RenuOil.DAL.EntityClasses;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.RelationClasses;

namespace Reliant.RenuOil.DAL.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
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
		public DataSource2<AccountEntity> Account
		{
			get { return new DataSource2<AccountEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AccountEmployeeAssignmentEntity instances in the database.</summary>
		public DataSource2<AccountEmployeeAssignmentEntity> AccountEmployeeAssignment
		{
			get { return new DataSource2<AccountEmployeeAssignmentEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AssetCategoryEntity instances in the database.</summary>
		public DataSource2<AssetCategoryEntity> AssetCategory
		{
			get { return new DataSource2<AssetCategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AssetReclamationServiceEntity instances in the database.</summary>
		public DataSource2<AssetReclamationServiceEntity> AssetReclamationService
		{
			get { return new DataSource2<AssetReclamationServiceEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AssetReclamationServiceChangeLogEntity instances in the database.</summary>
		public DataSource2<AssetReclamationServiceChangeLogEntity> AssetReclamationServiceChangeLog
		{
			get { return new DataSource2<AssetReclamationServiceChangeLogEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AssetTypeEntity instances in the database.</summary>
		public DataSource2<AssetTypeEntity> AssetType
		{
			get { return new DataSource2<AssetTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BaleEntity instances in the database.</summary>
		public DataSource2<BaleEntity> Bale
		{
			get { return new DataSource2<BaleEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ChangeLogEntity instances in the database.</summary>
		public DataSource2<ChangeLogEntity> ChangeLog
		{
			get { return new DataSource2<ChangeLogEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ChangeTypeEntity instances in the database.</summary>
		public DataSource2<ChangeTypeEntity> ChangeType
		{
			get { return new DataSource2<ChangeTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DeepFryerEntity instances in the database.</summary>
		public DataSource2<DeepFryerEntity> DeepFryer
		{
			get { return new DataSource2<DeepFryerEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DeepFryerChangeLogEntity instances in the database.</summary>
		public DataSource2<DeepFryerChangeLogEntity> DeepFryerChangeLog
		{
			get { return new DataSource2<DeepFryerChangeLogEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DeepFryerServiceEntity instances in the database.</summary>
		public DataSource2<DeepFryerServiceEntity> DeepFryerService
		{
			get { return new DataSource2<DeepFryerServiceEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DeepFryerServiceChangeLogEntity instances in the database.</summary>
		public DataSource2<DeepFryerServiceChangeLogEntity> DeepFryerServiceChangeLog
		{
			get { return new DataSource2<DeepFryerServiceChangeLogEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DockEntity instances in the database.</summary>
		public DataSource2<DockEntity> Dock
		{
			get { return new DataSource2<DockEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource2<EmployeeEntity> Employee
		{
			get { return new DataSource2<EmployeeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting LoadEntity instances in the database.</summary>
		public DataSource2<LoadEntity> Load
		{
			get { return new DataSource2<LoadEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting MobileDeviceEntity instances in the database.</summary>
		public DataSource2<MobileDeviceEntity> MobileDevice
		{
			get { return new DataSource2<MobileDeviceEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RebateEntity instances in the database.</summary>
		public DataSource2<RebateEntity> Rebate
		{
			get { return new DataSource2<RebateEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RebateTypeEntity instances in the database.</summary>
		public DataSource2<RebateTypeEntity> RebateType
		{
			get { return new DataSource2<RebateTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleServiceEntity instances in the database.</summary>
		public DataSource2<RecycleServiceEntity> RecycleService
		{
			get { return new DataSource2<RecycleServiceEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleServiceActionEntity instances in the database.</summary>
		public DataSource2<RecycleServiceActionEntity> RecycleServiceAction
		{
			get { return new DataSource2<RecycleServiceActionEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleServiceChangeLogEntity instances in the database.</summary>
		public DataSource2<RecycleServiceChangeLogEntity> RecycleServiceChangeLog
		{
			get { return new DataSource2<RecycleServiceChangeLogEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleTypeEntity instances in the database.</summary>
		public DataSource2<RecycleTypeEntity> RecycleType
		{
			get { return new DataSource2<RecycleTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleVendorEntity instances in the database.</summary>
		public DataSource2<RecycleVendorEntity> RecycleVendor
		{
			get { return new DataSource2<RecycleVendorEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RecycleVendorServiceEntity instances in the database.</summary>
		public DataSource2<RecycleVendorServiceEntity> RecycleVendorService
		{
			get { return new DataSource2<RecycleVendorServiceEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceLocationEntity instances in the database.</summary>
		public DataSource2<ServiceLocationEntity> ServiceLocation
		{
			get { return new DataSource2<ServiceLocationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceLocationAssetTypeEntity instances in the database.</summary>
		public DataSource2<ServiceLocationAssetTypeEntity> ServiceLocationAssetType
		{
			get { return new DataSource2<ServiceLocationAssetTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceLocationAssetTypeChangeLogEntity instances in the database.</summary>
		public DataSource2<ServiceLocationAssetTypeChangeLogEntity> ServiceLocationAssetTypeChangeLog
		{
			get { return new DataSource2<ServiceLocationAssetTypeChangeLogEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceLocationEmployeeAssignmentEntity instances in the database.</summary>
		public DataSource2<ServiceLocationEmployeeAssignmentEntity> ServiceLocationEmployeeAssignment
		{
			get { return new DataSource2<ServiceLocationEmployeeAssignmentEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceLocationRecycleTypeEntity instances in the database.</summary>
		public DataSource2<ServiceLocationRecycleTypeEntity> ServiceLocationRecycleType
		{
			get { return new DataSource2<ServiceLocationRecycleTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ServiceTypeEntity instances in the database.</summary>
		public DataSource2<ServiceTypeEntity> ServiceType
		{
			get { return new DataSource2<ServiceTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SettingEntity instances in the database.</summary>
		public DataSource2<SettingEntity> Setting
		{
			get { return new DataSource2<SettingEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting StatusEntity instances in the database.</summary>
		public DataSource2<StatusEntity> Status
		{
			get { return new DataSource2<StatusEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UserEntity instances in the database.</summary>
		public DataSource2<UserEntity> User
		{
			get { return new DataSource2<UserEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UserAccountEntity instances in the database.</summary>
		public DataSource2<UserAccountEntity> UserAccount
		{
			get { return new DataSource2<UserAccountEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UserTypeEntity instances in the database.</summary>
		public DataSource2<UserTypeEntity> UserType
		{
			get { return new DataSource2<UserTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderEntity instances in the database.</summary>
		public DataSource2<WorkOrderEntity> WorkOrder
		{
			get { return new DataSource2<WorkOrderEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderEmployeeEntity instances in the database.</summary>
		public DataSource2<WorkOrderEmployeeEntity> WorkOrderEmployee
		{
			get { return new DataSource2<WorkOrderEmployeeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderServiceLocationEntity instances in the database.</summary>
		public DataSource2<WorkOrderServiceLocationEntity> WorkOrderServiceLocation
		{
			get { return new DataSource2<WorkOrderServiceLocationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		
		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
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

        public object DockWorkers { get; internal set; }
        #endregion
    }
}