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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>
	/// Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal sealed class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private FieldInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			base.InitClass( (39 + 0));
			InitAccountEntityInfos();
			InitAccountEmployeeAssignmentEntityInfos();
			InitAssetCategoryEntityInfos();
			InitAssetReclamationServiceEntityInfos();
			InitAssetReclamationServiceChangeLogEntityInfos();
			InitAssetTypeEntityInfos();
			InitBaleEntityInfos();
			InitChangeLogEntityInfos();
			InitChangeTypeEntityInfos();
			InitDeepFryerEntityInfos();
			InitDeepFryerChangeLogEntityInfos();
			InitDeepFryerServiceEntityInfos();
			InitDeepFryerServiceChangeLogEntityInfos();
			InitDockEntityInfos();
			InitEmployeeEntityInfos();
			InitLoadEntityInfos();
			InitMobileDeviceEntityInfos();
			InitRebateEntityInfos();
			InitRebateTypeEntityInfos();
			InitRecycleServiceEntityInfos();
			InitRecycleServiceActionEntityInfos();
			InitRecycleServiceChangeLogEntityInfos();
			InitRecycleTypeEntityInfos();
			InitRecycleVendorEntityInfos();
			InitRecycleVendorServiceEntityInfos();
			InitServiceLocationEntityInfos();
			InitServiceLocationAssetTypeEntityInfos();
			InitServiceLocationAssetTypeChangeLogEntityInfos();
			InitServiceLocationEmployeeAssignmentEntityInfos();
			InitServiceLocationRecycleTypeEntityInfos();
			InitServiceTypeEntityInfos();
			InitSettingEntityInfos();
			InitStatusEntityInfos();
			InitUserEntityInfos();
			InitUserAccountEntityInfos();
			InitUserTypeEntityInfos();
			InitWorkOrderEntityInfos();
			InitWorkOrderEmployeeEntityInfos();
			InitWorkOrderServiceLocationEntityInfos();

			base.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AccountEntity's FieldInfo objects</summary>
		private void InitAccountEntityInfos()
		{
			base.AddElementFieldInfo("AccountEntity", "AccountId", typeof(System.Int32), true, false, true, false,  (int)AccountFieldIndex.AccountId, 0, 0, 10);
			base.AddElementFieldInfo("AccountEntity", "Name", typeof(System.String), false, false, false, false,  (int)AccountFieldIndex.Name, 100, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "AccountNo", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.AccountNo, 50, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "Address1", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.Address1, 100, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "Address2", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.Address2, 100, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "City", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.City, 100, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "State", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.State, 2, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "IntlState", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.IntlState, 50, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "ZipCode", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.ZipCode, 10, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "Phone", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.Phone, 50, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)AccountFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "MainContact", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.MainContact, 100, 0, 0);
			base.AddElementFieldInfo("AccountEntity", "Notes", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.Notes, 500, 0, 0);
		}
		/// <summary>Inits AccountEmployeeAssignmentEntity's FieldInfo objects</summary>
		private void InitAccountEmployeeAssignmentEntityInfos()
		{
			base.AddElementFieldInfo("AccountEmployeeAssignmentEntity", "AccountEmployeeAssignmentId", typeof(System.Int32), true, false, true, false,  (int)AccountEmployeeAssignmentFieldIndex.AccountEmployeeAssignmentId, 0, 0, 10);
			base.AddElementFieldInfo("AccountEmployeeAssignmentEntity", "AccountId", typeof(System.Int32), false, true, false, false,  (int)AccountEmployeeAssignmentFieldIndex.AccountId, 0, 0, 10);
			base.AddElementFieldInfo("AccountEmployeeAssignmentEntity", "Monday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AccountEmployeeAssignmentFieldIndex.Monday, 0, 0, 10);
			base.AddElementFieldInfo("AccountEmployeeAssignmentEntity", "Tuesday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AccountEmployeeAssignmentFieldIndex.Tuesday, 0, 0, 10);
			base.AddElementFieldInfo("AccountEmployeeAssignmentEntity", "Wednesday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AccountEmployeeAssignmentFieldIndex.Wednesday, 0, 0, 10);
			base.AddElementFieldInfo("AccountEmployeeAssignmentEntity", "Thursday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AccountEmployeeAssignmentFieldIndex.Thursday, 0, 0, 10);
			base.AddElementFieldInfo("AccountEmployeeAssignmentEntity", "Friday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AccountEmployeeAssignmentFieldIndex.Friday, 0, 0, 10);
			base.AddElementFieldInfo("AccountEmployeeAssignmentEntity", "Saturday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AccountEmployeeAssignmentFieldIndex.Saturday, 0, 0, 10);
			base.AddElementFieldInfo("AccountEmployeeAssignmentEntity", "Sunday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AccountEmployeeAssignmentFieldIndex.Sunday, 0, 0, 10);
		}
		/// <summary>Inits AssetCategoryEntity's FieldInfo objects</summary>
		private void InitAssetCategoryEntityInfos()
		{
			base.AddElementFieldInfo("AssetCategoryEntity", "AssetCategoryId", typeof(System.Int32), true, false, true, false,  (int)AssetCategoryFieldIndex.AssetCategoryId, 0, 0, 10);
			base.AddElementFieldInfo("AssetCategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)AssetCategoryFieldIndex.Name, 100, 0, 0);
			base.AddElementFieldInfo("AssetCategoryEntity", "Description", typeof(System.String), false, false, false, true,  (int)AssetCategoryFieldIndex.Description, 100, 0, 0);
			base.AddElementFieldInfo("AssetCategoryEntity", "SpanishLabel", typeof(System.String), false, false, false, true,  (int)AssetCategoryFieldIndex.SpanishLabel, 100, 0, 0);
			base.AddElementFieldInfo("AssetCategoryEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)AssetCategoryFieldIndex.IsActive, 0, 0, 0);
		}
		/// <summary>Inits AssetReclamationServiceEntity's FieldInfo objects</summary>
		private void InitAssetReclamationServiceEntityInfos()
		{
			base.AddElementFieldInfo("AssetReclamationServiceEntity", "AssetReclamationServiceId", typeof(System.Int32), true, false, true, false,  (int)AssetReclamationServiceFieldIndex.AssetReclamationServiceId, 0, 0, 10);
			base.AddElementFieldInfo("AssetReclamationServiceEntity", "WorkOrderServiceLocationId", typeof(System.Int32), false, true, false, false,  (int)AssetReclamationServiceFieldIndex.WorkOrderServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("AssetReclamationServiceEntity", "ServiceLocationAssetTypeId", typeof(System.Int32), false, true, false, false,  (int)AssetReclamationServiceFieldIndex.ServiceLocationAssetTypeId, 0, 0, 10);
			base.AddElementFieldInfo("AssetReclamationServiceEntity", "Quantity", typeof(System.Int32), false, false, false, false,  (int)AssetReclamationServiceFieldIndex.Quantity, 0, 0, 10);
		}
		/// <summary>Inits AssetReclamationServiceChangeLogEntity's FieldInfo objects</summary>
		private void InitAssetReclamationServiceChangeLogEntityInfos()
		{
			base.AddElementFieldInfo("AssetReclamationServiceChangeLogEntity", "AssetReclamationServiceChangeLogId", typeof(System.Int32), true, false, true, false,  (int)AssetReclamationServiceChangeLogFieldIndex.AssetReclamationServiceChangeLogId, 0, 0, 10);
			base.AddElementFieldInfo("AssetReclamationServiceChangeLogEntity", "AssetReclamationServiceId", typeof(System.Int32), false, true, false, false,  (int)AssetReclamationServiceChangeLogFieldIndex.AssetReclamationServiceId, 0, 0, 10);
			base.AddElementFieldInfo("AssetReclamationServiceChangeLogEntity", "ChangeDate", typeof(System.DateTime), false, false, false, false,  (int)AssetReclamationServiceChangeLogFieldIndex.ChangeDate, 0, 0, 0);
			base.AddElementFieldInfo("AssetReclamationServiceChangeLogEntity", "Quantity", typeof(Nullable<System.Int32>), false, false, false, true,  (int)AssetReclamationServiceChangeLogFieldIndex.Quantity, 0, 0, 10);
			base.AddElementFieldInfo("AssetReclamationServiceChangeLogEntity", "EnteredByEmployeeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AssetReclamationServiceChangeLogFieldIndex.EnteredByEmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("AssetReclamationServiceChangeLogEntity", "EnteredByUserId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)AssetReclamationServiceChangeLogFieldIndex.EnteredByUserId, 0, 0, 10);
		}
		/// <summary>Inits AssetTypeEntity's FieldInfo objects</summary>
		private void InitAssetTypeEntityInfos()
		{
			base.AddElementFieldInfo("AssetTypeEntity", "AssetTypeId", typeof(System.Int32), true, false, true, false,  (int)AssetTypeFieldIndex.AssetTypeId, 0, 0, 10);
			base.AddElementFieldInfo("AssetTypeEntity", "AssetCategoryId", typeof(System.Int32), false, true, false, false,  (int)AssetTypeFieldIndex.AssetCategoryId, 0, 0, 10);
			base.AddElementFieldInfo("AssetTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)AssetTypeFieldIndex.Name, 100, 0, 0);
			base.AddElementFieldInfo("AssetTypeEntity", "Description", typeof(System.String), false, false, false, true,  (int)AssetTypeFieldIndex.Description, 100, 0, 0);
			base.AddElementFieldInfo("AssetTypeEntity", "SpanishLabel", typeof(System.String), false, false, false, true,  (int)AssetTypeFieldIndex.SpanishLabel, 100, 0, 0);
			base.AddElementFieldInfo("AssetTypeEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)AssetTypeFieldIndex.IsActive, 0, 0, 0);
		}
		/// <summary>Inits BaleEntity's FieldInfo objects</summary>
		private void InitBaleEntityInfos()
		{
			base.AddElementFieldInfo("BaleEntity", "BaleId", typeof(System.Int32), true, false, true, false,  (int)BaleFieldIndex.BaleId, 0, 0, 10);
			base.AddElementFieldInfo("BaleEntity", "AccountId", typeof(System.Int32), false, true, false, false,  (int)BaleFieldIndex.AccountId, 0, 0, 10);
			base.AddElementFieldInfo("BaleEntity", "DockId", typeof(System.Int32), false, true, false, false,  (int)BaleFieldIndex.DockId, 0, 0, 10);
			base.AddElementFieldInfo("BaleEntity", "RecycleTypeId", typeof(System.Int32), false, true, false, false,  (int)BaleFieldIndex.RecycleTypeId, 0, 0, 10);
			base.AddElementFieldInfo("BaleEntity", "InitWeight", typeof(Nullable<System.Int32>), false, false, false, true,  (int)BaleFieldIndex.InitWeight, 0, 0, 10);
			base.AddElementFieldInfo("BaleEntity", "CreatedDate", typeof(System.DateTime), false, false, false, false,  (int)BaleFieldIndex.CreatedDate, 0, 0, 0);
			base.AddElementFieldInfo("BaleEntity", "WarehouseWeight", typeof(Nullable<System.Int32>), false, false, false, true,  (int)BaleFieldIndex.WarehouseWeight, 0, 0, 10);
			base.AddElementFieldInfo("BaleEntity", "FinalWeight", typeof(Nullable<System.Int32>), false, false, false, true,  (int)BaleFieldIndex.FinalWeight, 0, 0, 10);
			base.AddElementFieldInfo("BaleEntity", "Notes", typeof(System.String), false, false, false, true,  (int)BaleFieldIndex.Notes, 2147483647, 0, 0);
			base.AddElementFieldInfo("BaleEntity", "LoadId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)BaleFieldIndex.LoadId, 0, 0, 10);
		}
		/// <summary>Inits ChangeLogEntity's FieldInfo objects</summary>
		private void InitChangeLogEntityInfos()
		{
			base.AddElementFieldInfo("ChangeLogEntity", "ChangeLogId", typeof(System.Int32), true, false, true, false,  (int)ChangeLogFieldIndex.ChangeLogId, 0, 0, 10);
			base.AddElementFieldInfo("ChangeLogEntity", "ChangeTypeId", typeof(System.Int32), false, true, false, false,  (int)ChangeLogFieldIndex.ChangeTypeId, 0, 0, 10);
			base.AddElementFieldInfo("ChangeLogEntity", "UserId", typeof(System.Int32), false, true, false, false,  (int)ChangeLogFieldIndex.UserId, 0, 0, 10);
			base.AddElementFieldInfo("ChangeLogEntity", "ChangeDate", typeof(System.DateTime), false, false, false, false,  (int)ChangeLogFieldIndex.ChangeDate, 0, 0, 0);
		}
		/// <summary>Inits ChangeTypeEntity's FieldInfo objects</summary>
		private void InitChangeTypeEntityInfos()
		{
			base.AddElementFieldInfo("ChangeTypeEntity", "ChangeTypeId", typeof(System.Int32), true, false, false, false,  (int)ChangeTypeFieldIndex.ChangeTypeId, 0, 0, 10);
			base.AddElementFieldInfo("ChangeTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)ChangeTypeFieldIndex.Name, 100, 0, 0);
			base.AddElementFieldInfo("ChangeTypeEntity", "Description", typeof(System.String), false, false, false, false,  (int)ChangeTypeFieldIndex.Description, 200, 0, 0);
		}
		/// <summary>Inits DeepFryerEntity's FieldInfo objects</summary>
		private void InitDeepFryerEntityInfos()
		{
			base.AddElementFieldInfo("DeepFryerEntity", "DeepFryerId", typeof(System.Int32), true, false, true, false,  (int)DeepFryerFieldIndex.DeepFryerId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerEntity", "Name", typeof(System.String), false, false, false, false,  (int)DeepFryerFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("DeepFryerEntity", "Description", typeof(System.String), false, false, false, true,  (int)DeepFryerFieldIndex.Description, 100, 0, 0);
			base.AddElementFieldInfo("DeepFryerEntity", "ServiceLocationId", typeof(System.Int32), false, true, false, false,  (int)DeepFryerFieldIndex.ServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerEntity", "SizeInGallons", typeof(Nullable<System.Double>), false, false, false, true,  (int)DeepFryerFieldIndex.SizeInGallons, 0, 0, 38);
			base.AddElementFieldInfo("DeepFryerEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)DeepFryerFieldIndex.IsActive, 0, 0, 0);
		}
		/// <summary>Inits DeepFryerChangeLogEntity's FieldInfo objects</summary>
		private void InitDeepFryerChangeLogEntityInfos()
		{
			base.AddElementFieldInfo("DeepFryerChangeLogEntity", "DeepFryerChangeLogId", typeof(System.Int32), true, false, true, false,  (int)DeepFryerChangeLogFieldIndex.DeepFryerChangeLogId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerChangeLogEntity", "DeepFryerId", typeof(System.Int32), false, true, false, false,  (int)DeepFryerChangeLogFieldIndex.DeepFryerId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerChangeLogEntity", "ChangeLogId", typeof(System.Int32), false, true, false, false,  (int)DeepFryerChangeLogFieldIndex.ChangeLogId, 0, 0, 10);
		}
		/// <summary>Inits DeepFryerServiceEntity's FieldInfo objects</summary>
		private void InitDeepFryerServiceEntityInfos()
		{
			base.AddElementFieldInfo("DeepFryerServiceEntity", "DeepFryerServiceId", typeof(System.Int32), true, false, true, false,  (int)DeepFryerServiceFieldIndex.DeepFryerServiceId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "DeepFryerId", typeof(System.Int32), false, true, false, false,  (int)DeepFryerServiceFieldIndex.DeepFryerId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "WorkOrderServiceLocationId", typeof(System.Int32), false, true, false, false,  (int)DeepFryerServiceFieldIndex.WorkOrderServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "Filtered", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DeepFryerServiceFieldIndex.Filtered, 0, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "Discarded", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DeepFryerServiceFieldIndex.Discarded, 0, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "Relocated", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DeepFryerServiceFieldIndex.Relocated, 0, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "Cleaned", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DeepFryerServiceFieldIndex.Cleaned, 0, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "RelocatedToFryerId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DeepFryerServiceFieldIndex.RelocatedToFryerId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "RelocatedToServiceLocationId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)DeepFryerServiceFieldIndex.RelocatedToServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "RelocatedToOther", typeof(System.String), false, false, false, true,  (int)DeepFryerServiceFieldIndex.RelocatedToOther, 50, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "AssignedTo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DeepFryerServiceFieldIndex.AssignedTo, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "Servicedby", typeof(Nullable<System.Int32>), false, true, false, true,  (int)DeepFryerServiceFieldIndex.Servicedby, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceEntity", "NoService", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DeepFryerServiceFieldIndex.NoService, 0, 0, 0);
		}
		/// <summary>Inits DeepFryerServiceChangeLogEntity's FieldInfo objects</summary>
		private void InitDeepFryerServiceChangeLogEntityInfos()
		{
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "DeepFryerServiceChangeLogId", typeof(System.Int32), true, false, true, false,  (int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceChangeLogId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "DeepFryerServiceId", typeof(System.Int32), false, true, false, false,  (int)DeepFryerServiceChangeLogFieldIndex.DeepFryerServiceId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "ChangeDate", typeof(System.DateTime), false, false, false, false,  (int)DeepFryerServiceChangeLogFieldIndex.ChangeDate, 0, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "Filtered", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.Filtered, 0, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "Discarded", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.Discarded, 0, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "Relocated", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.Relocated, 0, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "Cleaned", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.Cleaned, 0, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "RelocatedToFryerId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.RelocatedToFryerId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "RelocatedToServiceLocationId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.RelocatedToServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "RelocatedToOther", typeof(System.String), false, false, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.RelocatedToOther, 50, 0, 0);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "AssignedTo", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.AssignedTo, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "ServicedBy", typeof(Nullable<System.Int32>), false, true, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.ServicedBy, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "EnteredByEmployeeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.EnteredByEmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("DeepFryerServiceChangeLogEntity", "EnteredByUserId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)DeepFryerServiceChangeLogFieldIndex.EnteredByUserId, 0, 0, 10);
		}
		/// <summary>Inits DockEntity's FieldInfo objects</summary>
		private void InitDockEntityInfos()
		{
			base.AddElementFieldInfo("DockEntity", "DockId", typeof(System.Int32), true, false, true, false,  (int)DockFieldIndex.DockId, 0, 0, 10);
			base.AddElementFieldInfo("DockEntity", "AccountId", typeof(System.Int32), false, false, false, false,  (int)DockFieldIndex.AccountId, 0, 0, 10);
			base.AddElementFieldInfo("DockEntity", "DockName", typeof(System.String), false, false, false, false,  (int)DockFieldIndex.DockName, 40, 0, 0);
		}
		/// <summary>Inits EmployeeEntity's FieldInfo objects</summary>
		private void InitEmployeeEntityInfos()
		{
			base.AddElementFieldInfo("EmployeeEntity", "EmployeeId", typeof(System.Int32), true, false, true, false,  (int)EmployeeFieldIndex.EmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("EmployeeEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.FirstName, 50, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "MiddleName", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.MiddleName, 50, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "LastName", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.LastName, 50, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "Username", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Username, 50, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "Password", typeof(System.Byte[]), false, false, false, true,  (int)EmployeeFieldIndex.Password, 16, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "Ssn", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Ssn, 9, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "EmployeeNo", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.EmployeeNo, 50, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "DateOfBirth", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeFieldIndex.DateOfBirth, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "Address1", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Address1, 100, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "Address2", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Address2, 100, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "City", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.City, 100, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "State", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.State, 2, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "IntlState", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.IntlState, 50, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "ZipCode", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.ZipCode, 10, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "Phone", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Phone, 50, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "Mobile", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.Mobile, 50, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "EmailAddress", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.EmailAddress, 100, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "AssignOilService", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)EmployeeFieldIndex.AssignOilService, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "AssignRecycleService", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)EmployeeFieldIndex.AssignRecycleService, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("EmployeeEntity", "IsEnabled", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.IsEnabled, 0, 0, 0);
		}
		/// <summary>Inits LoadEntity's FieldInfo objects</summary>
		private void InitLoadEntityInfos()
		{
			base.AddElementFieldInfo("LoadEntity", "LoadId", typeof(System.Int32), true, false, true, false,  (int)LoadFieldIndex.LoadId, 0, 0, 10);
			base.AddElementFieldInfo("LoadEntity", "EmployeeId", typeof(System.Int32), false, true, false, false,  (int)LoadFieldIndex.EmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("LoadEntity", "Date", typeof(System.DateTime), false, false, false, false,  (int)LoadFieldIndex.Date, 0, 0, 0);
			base.AddElementFieldInfo("LoadEntity", "StatusId", typeof(System.Int32), false, true, false, false,  (int)LoadFieldIndex.StatusId, 0, 0, 10);
		}
		/// <summary>Inits MobileDeviceEntity's FieldInfo objects</summary>
		private void InitMobileDeviceEntityInfos()
		{
			base.AddElementFieldInfo("MobileDeviceEntity", "MobileDeviceId", typeof(System.Int32), true, false, true, false,  (int)MobileDeviceFieldIndex.MobileDeviceId, 0, 0, 10);
			base.AddElementFieldInfo("MobileDeviceEntity", "DeviceToken", typeof(System.Guid), false, false, false, false,  (int)MobileDeviceFieldIndex.DeviceToken, 0, 0, 0);
			base.AddElementFieldInfo("MobileDeviceEntity", "TokenExpiration", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)MobileDeviceFieldIndex.TokenExpiration, 0, 0, 0);
			base.AddElementFieldInfo("MobileDeviceEntity", "CurrentEmployeeId", typeof(System.Int32), false, false, false, false,  (int)MobileDeviceFieldIndex.CurrentEmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("MobileDeviceEntity", "IsEnabled", typeof(System.Boolean), false, false, false, false,  (int)MobileDeviceFieldIndex.IsEnabled, 0, 0, 0);
		}
		/// <summary>Inits RebateEntity's FieldInfo objects</summary>
		private void InitRebateEntityInfos()
		{
			base.AddElementFieldInfo("RebateEntity", "RebateId", typeof(System.Int32), true, false, true, false,  (int)RebateFieldIndex.RebateId, 0, 0, 10);
			base.AddElementFieldInfo("RebateEntity", "RebateTypeId", typeof(System.Int32), false, true, false, false,  (int)RebateFieldIndex.RebateTypeId, 0, 0, 10);
			base.AddElementFieldInfo("RebateEntity", "RebateDate", typeof(System.DateTime), false, false, false, false,  (int)RebateFieldIndex.RebateDate, 0, 0, 0);
			base.AddElementFieldInfo("RebateEntity", "AccountId", typeof(System.Int32), false, true, false, false,  (int)RebateFieldIndex.AccountId, 0, 0, 10);
			base.AddElementFieldInfo("RebateEntity", "Amount", typeof(System.Decimal), false, false, false, false,  (int)RebateFieldIndex.Amount, 0, 4, 19);
			base.AddElementFieldInfo("RebateEntity", "EnteredByUserId", typeof(System.Int32), false, true, false, false,  (int)RebateFieldIndex.EnteredByUserId, 0, 0, 10);
			base.AddElementFieldInfo("RebateEntity", "EnteredDate", typeof(System.DateTime), false, false, false, false,  (int)RebateFieldIndex.EnteredDate, 0, 0, 0);
		}
		/// <summary>Inits RebateTypeEntity's FieldInfo objects</summary>
		private void InitRebateTypeEntityInfos()
		{
			base.AddElementFieldInfo("RebateTypeEntity", "RebateTypeId", typeof(System.Int32), true, false, true, false,  (int)RebateTypeFieldIndex.RebateTypeId, 0, 0, 10);
			base.AddElementFieldInfo("RebateTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)RebateTypeFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("RebateTypeEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)RebateTypeFieldIndex.IsActive, 0, 0, 0);
		}
		/// <summary>Inits RecycleServiceEntity's FieldInfo objects</summary>
		private void InitRecycleServiceEntityInfos()
		{
			base.AddElementFieldInfo("RecycleServiceEntity", "RecycleServiceId", typeof(System.Int32), true, false, true, false,  (int)RecycleServiceFieldIndex.RecycleServiceId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceEntity", "WorkOrderServiceLocationId", typeof(System.Int32), false, true, false, false,  (int)RecycleServiceFieldIndex.WorkOrderServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceEntity", "NumberOfBales", typeof(Nullable<System.Int32>), false, false, false, true,  (int)RecycleServiceFieldIndex.NumberOfBales, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceEntity", "NumberOfBags", typeof(Nullable<System.Int32>), false, false, false, true,  (int)RecycleServiceFieldIndex.NumberOfBags, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceEntity", "BalesWeight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)RecycleServiceFieldIndex.BalesWeight, 0, 2, 10);
			base.AddElementFieldInfo("RecycleServiceEntity", "BagsWeight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)RecycleServiceFieldIndex.BagsWeight, 0, 2, 10);
		}
		/// <summary>Inits RecycleServiceActionEntity's FieldInfo objects</summary>
		private void InitRecycleServiceActionEntityInfos()
		{
			base.AddElementFieldInfo("RecycleServiceActionEntity", "RecycleServiceActionId", typeof(System.Int32), true, false, true, false,  (int)RecycleServiceActionFieldIndex.RecycleServiceActionId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "ActionTime", typeof(System.DateTime), false, false, false, false,  (int)RecycleServiceActionFieldIndex.ActionTime, 0, 0, 0);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "NumberOfBales", typeof(Nullable<System.Int32>), false, false, false, true,  (int)RecycleServiceActionFieldIndex.NumberOfBales, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "NumberOfBags", typeof(Nullable<System.Int32>), false, false, false, true,  (int)RecycleServiceActionFieldIndex.NumberOfBags, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "BalesWeight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)RecycleServiceActionFieldIndex.BalesWeight, 0, 2, 10);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "BagsWeight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)RecycleServiceActionFieldIndex.BagsWeight, 0, 2, 10);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "RecycleServiceId", typeof(System.Int32), false, true, false, false,  (int)RecycleServiceActionFieldIndex.RecycleServiceId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "RecycleTypeId", typeof(System.Int32), false, true, false, false,  (int)RecycleServiceActionFieldIndex.RecycleTypeId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "ActionUserId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)RecycleServiceActionFieldIndex.ActionUserId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "LastChangedByUserId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)RecycleServiceActionFieldIndex.LastChangedByUserId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "LastChangedDate", typeof(System.DateTime), false, false, false, false,  (int)RecycleServiceActionFieldIndex.LastChangedDate, 0, 0, 0);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "ActionType", typeof(System.String), false, false, false, false,  (int)RecycleServiceActionFieldIndex.ActionType, 1, 0, 0);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "ActionEmployeeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)RecycleServiceActionFieldIndex.ActionEmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceActionEntity", "LastChangedByEmployeeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)RecycleServiceActionFieldIndex.LastChangedByEmployeeId, 0, 0, 10);
		}
		/// <summary>Inits RecycleServiceChangeLogEntity's FieldInfo objects</summary>
		private void InitRecycleServiceChangeLogEntityInfos()
		{
			base.AddElementFieldInfo("RecycleServiceChangeLogEntity", "RecycleServiceChangeLogId", typeof(System.Int32), true, false, true, false,  (int)RecycleServiceChangeLogFieldIndex.RecycleServiceChangeLogId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceChangeLogEntity", "RecycleServiceId", typeof(System.Int32), false, true, false, false,  (int)RecycleServiceChangeLogFieldIndex.RecycleServiceId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceChangeLogEntity", "ChangeDate", typeof(System.DateTime), false, false, false, false,  (int)RecycleServiceChangeLogFieldIndex.ChangeDate, 0, 0, 0);
			base.AddElementFieldInfo("RecycleServiceChangeLogEntity", "NumberOfBales", typeof(Nullable<System.Int32>), false, false, false, true,  (int)RecycleServiceChangeLogFieldIndex.NumberOfBales, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceChangeLogEntity", "NumberOfBags", typeof(Nullable<System.Int32>), false, false, false, true,  (int)RecycleServiceChangeLogFieldIndex.NumberOfBags, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceChangeLogEntity", "BalesWeight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)RecycleServiceChangeLogFieldIndex.BalesWeight, 0, 2, 10);
			base.AddElementFieldInfo("RecycleServiceChangeLogEntity", "BagsWeight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)RecycleServiceChangeLogFieldIndex.BagsWeight, 0, 2, 10);
			base.AddElementFieldInfo("RecycleServiceChangeLogEntity", "EnteredByEmployeeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)RecycleServiceChangeLogFieldIndex.EnteredByEmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleServiceChangeLogEntity", "EnteredByUserId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)RecycleServiceChangeLogFieldIndex.EnteredByUserId, 0, 0, 10);
		}
		/// <summary>Inits RecycleTypeEntity's FieldInfo objects</summary>
		private void InitRecycleTypeEntityInfos()
		{
			base.AddElementFieldInfo("RecycleTypeEntity", "RecycleTypeId", typeof(System.Int32), true, false, true, false,  (int)RecycleTypeFieldIndex.RecycleTypeId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)RecycleTypeFieldIndex.Name, 100, 0, 0);
			base.AddElementFieldInfo("RecycleTypeEntity", "Description", typeof(System.String), false, false, false, true,  (int)RecycleTypeFieldIndex.Description, 100, 0, 0);
			base.AddElementFieldInfo("RecycleTypeEntity", "SpanishLabel", typeof(System.String), false, false, false, true,  (int)RecycleTypeFieldIndex.SpanishLabel, 100, 0, 0);
			base.AddElementFieldInfo("RecycleTypeEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)RecycleTypeFieldIndex.IsActive, 0, 0, 0);
		}
		/// <summary>Inits RecycleVendorEntity's FieldInfo objects</summary>
		private void InitRecycleVendorEntityInfos()
		{
			base.AddElementFieldInfo("RecycleVendorEntity", "RecycleVendorId", typeof(System.Int32), true, false, true, false,  (int)RecycleVendorFieldIndex.RecycleVendorId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleVendorEntity", "Type", typeof(System.String), false, false, false, false,  (int)RecycleVendorFieldIndex.Type, 1, 0, 0);
			base.AddElementFieldInfo("RecycleVendorEntity", "Name", typeof(System.String), false, false, false, false,  (int)RecycleVendorFieldIndex.Name, 100, 0, 0);
			base.AddElementFieldInfo("RecycleVendorEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)RecycleVendorFieldIndex.IsActive, 0, 0, 0);
		}
		/// <summary>Inits RecycleVendorServiceEntity's FieldInfo objects</summary>
		private void InitRecycleVendorServiceEntityInfos()
		{
			base.AddElementFieldInfo("RecycleVendorServiceEntity", "RecycleVendorServiceId", typeof(System.Int32), true, false, true, false,  (int)RecycleVendorServiceFieldIndex.RecycleVendorServiceId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleVendorServiceEntity", "ServiceDate", typeof(System.DateTime), false, false, false, false,  (int)RecycleVendorServiceFieldIndex.ServiceDate, 0, 0, 0);
			base.AddElementFieldInfo("RecycleVendorServiceEntity", "RecycleTypeId", typeof(System.Int32), false, true, false, false,  (int)RecycleVendorServiceFieldIndex.RecycleTypeId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleVendorServiceEntity", "RecycleVendorId", typeof(System.Int32), false, true, false, false,  (int)RecycleVendorServiceFieldIndex.RecycleVendorId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleVendorServiceEntity", "Weight", typeof(System.Decimal), false, false, false, false,  (int)RecycleVendorServiceFieldIndex.Weight, 0, 2, 10);
			base.AddElementFieldInfo("RecycleVendorServiceEntity", "AccountId", typeof(System.Int32), false, true, false, false,  (int)RecycleVendorServiceFieldIndex.AccountId, 0, 0, 10);
			base.AddElementFieldInfo("RecycleVendorServiceEntity", "TotalMonthlyWeight", typeof(System.Decimal), false, false, false, false,  (int)RecycleVendorServiceFieldIndex.TotalMonthlyWeight, 0, 2, 10);
			base.AddElementFieldInfo("RecycleVendorServiceEntity", "TotalMonthlyPulls", typeof(System.Int32), false, false, false, false,  (int)RecycleVendorServiceFieldIndex.TotalMonthlyPulls, 0, 0, 10);
		}
		/// <summary>Inits ServiceLocationEntity's FieldInfo objects</summary>
		private void InitServiceLocationEntityInfos()
		{
			base.AddElementFieldInfo("ServiceLocationEntity", "ServiceLocationId", typeof(System.Int32), true, false, true, false,  (int)ServiceLocationFieldIndex.ServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEntity", "AccountId", typeof(System.Int32), false, true, false, false,  (int)ServiceLocationFieldIndex.AccountId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEntity", "Name", typeof(System.String), false, false, false, false,  (int)ServiceLocationFieldIndex.Name, 100, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "Address1", typeof(System.String), false, false, false, true,  (int)ServiceLocationFieldIndex.Address1, 100, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "Address2", typeof(System.String), false, false, false, true,  (int)ServiceLocationFieldIndex.Address2, 100, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "City", typeof(System.String), false, false, false, true,  (int)ServiceLocationFieldIndex.City, 100, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "State", typeof(System.String), false, false, false, true,  (int)ServiceLocationFieldIndex.State, 2, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "IntlState", typeof(System.String), false, false, false, true,  (int)ServiceLocationFieldIndex.IntlState, 50, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "ZipCode", typeof(System.String), false, false, false, true,  (int)ServiceLocationFieldIndex.ZipCode, 10, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "Phone", typeof(System.String), false, false, false, true,  (int)ServiceLocationFieldIndex.Phone, 50, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "MainContact", typeof(System.String), false, false, false, true,  (int)ServiceLocationFieldIndex.MainContact, 100, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "Notes", typeof(System.String), false, false, false, true,  (int)ServiceLocationFieldIndex.Notes, 500, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "ServiceTypeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ServiceLocationFieldIndex.ServiceTypeId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEntity", "IsActive", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ServiceLocationFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("ServiceLocationEntity", "Ordinal", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ServiceLocationFieldIndex.Ordinal, 0, 0, 10);
		}
		/// <summary>Inits ServiceLocationAssetTypeEntity's FieldInfo objects</summary>
		private void InitServiceLocationAssetTypeEntityInfos()
		{
			base.AddElementFieldInfo("ServiceLocationAssetTypeEntity", "ServiceLocationAssetTypeId", typeof(System.Int32), true, false, true, false,  (int)ServiceLocationAssetTypeFieldIndex.ServiceLocationAssetTypeId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationAssetTypeEntity", "ServiceLocationId", typeof(System.Int32), false, true, false, false,  (int)ServiceLocationAssetTypeFieldIndex.ServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationAssetTypeEntity", "AssetTypeId", typeof(System.Int32), false, true, false, false,  (int)ServiceLocationAssetTypeFieldIndex.AssetTypeId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationAssetTypeEntity", "PricePerUnit", typeof(System.Decimal), false, false, false, false,  (int)ServiceLocationAssetTypeFieldIndex.PricePerUnit, 0, 4, 19);
		}
		/// <summary>Inits ServiceLocationAssetTypeChangeLogEntity's FieldInfo objects</summary>
		private void InitServiceLocationAssetTypeChangeLogEntityInfos()
		{
			base.AddElementFieldInfo("ServiceLocationAssetTypeChangeLogEntity", "ServiceLocationAssetTypeChangeLogId", typeof(System.Int32), true, false, true, false,  (int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeChangeLogId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationAssetTypeChangeLogEntity", "ServiceLocationAssetTypeId", typeof(System.Int32), false, true, false, false,  (int)ServiceLocationAssetTypeChangeLogFieldIndex.ServiceLocationAssetTypeId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationAssetTypeChangeLogEntity", "ChangeLogId", typeof(System.Int32), false, true, false, false,  (int)ServiceLocationAssetTypeChangeLogFieldIndex.ChangeLogId, 0, 0, 10);
		}
		/// <summary>Inits ServiceLocationEmployeeAssignmentEntity's FieldInfo objects</summary>
		private void InitServiceLocationEmployeeAssignmentEntityInfos()
		{
			base.AddElementFieldInfo("ServiceLocationEmployeeAssignmentEntity", "ServiceLocationEmployeeAssignmentId", typeof(System.Int32), true, false, true, false,  (int)ServiceLocationEmployeeAssignmentFieldIndex.ServiceLocationEmployeeAssignmentId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEmployeeAssignmentEntity", "ServiceLocationId", typeof(System.Int32), false, true, false, false,  (int)ServiceLocationEmployeeAssignmentFieldIndex.ServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEmployeeAssignmentEntity", "Monday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ServiceLocationEmployeeAssignmentFieldIndex.Monday, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEmployeeAssignmentEntity", "Tuesday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ServiceLocationEmployeeAssignmentFieldIndex.Tuesday, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEmployeeAssignmentEntity", "Wednesday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ServiceLocationEmployeeAssignmentFieldIndex.Wednesday, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEmployeeAssignmentEntity", "Thursday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ServiceLocationEmployeeAssignmentFieldIndex.Thursday, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEmployeeAssignmentEntity", "Friday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ServiceLocationEmployeeAssignmentFieldIndex.Friday, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEmployeeAssignmentEntity", "Saturday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ServiceLocationEmployeeAssignmentFieldIndex.Saturday, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationEmployeeAssignmentEntity", "Sunday", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ServiceLocationEmployeeAssignmentFieldIndex.Sunday, 0, 0, 10);
		}
		/// <summary>Inits ServiceLocationRecycleTypeEntity's FieldInfo objects</summary>
		private void InitServiceLocationRecycleTypeEntityInfos()
		{
			base.AddElementFieldInfo("ServiceLocationRecycleTypeEntity", "ServiceLocationRecycleTypeId", typeof(System.Int32), true, false, true, false,  (int)ServiceLocationRecycleTypeFieldIndex.ServiceLocationRecycleTypeId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationRecycleTypeEntity", "RecycleTypeId", typeof(System.Int32), false, true, false, false,  (int)ServiceLocationRecycleTypeFieldIndex.RecycleTypeId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationRecycleTypeEntity", "ServiceLocationId", typeof(System.Int32), false, true, false, false,  (int)ServiceLocationRecycleTypeFieldIndex.ServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceLocationRecycleTypeEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)ServiceLocationRecycleTypeFieldIndex.IsActive, 0, 0, 0);
		}
		/// <summary>Inits ServiceTypeEntity's FieldInfo objects</summary>
		private void InitServiceTypeEntityInfos()
		{
			base.AddElementFieldInfo("ServiceTypeEntity", "ServiceTypeId", typeof(System.Int32), true, false, false, false,  (int)ServiceTypeFieldIndex.ServiceTypeId, 0, 0, 10);
			base.AddElementFieldInfo("ServiceTypeEntity", "Name", typeof(System.String), false, false, false, true,  (int)ServiceTypeFieldIndex.Name, 100, 0, 0);
			base.AddElementFieldInfo("ServiceTypeEntity", "Description", typeof(System.String), false, false, false, true,  (int)ServiceTypeFieldIndex.Description, 100, 0, 0);
		}
		/// <summary>Inits SettingEntity's FieldInfo objects</summary>
		private void InitSettingEntityInfos()
		{
			base.AddElementFieldInfo("SettingEntity", "SettingId", typeof(System.Int32), true, false, false, false,  (int)SettingFieldIndex.SettingId, 0, 0, 10);
			base.AddElementFieldInfo("SettingEntity", "Name", typeof(System.String), false, false, false, false,  (int)SettingFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("SettingEntity", "IntValue", typeof(Nullable<System.Int32>), false, false, false, true,  (int)SettingFieldIndex.IntValue, 0, 0, 10);
			base.AddElementFieldInfo("SettingEntity", "DecimalValue", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SettingFieldIndex.DecimalValue, 0, 0, 18);
			base.AddElementFieldInfo("SettingEntity", "BoolValue", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)SettingFieldIndex.BoolValue, 0, 0, 0);
			base.AddElementFieldInfo("SettingEntity", "StringValue", typeof(System.String), false, false, false, true,  (int)SettingFieldIndex.StringValue, 100, 0, 0);
		}
		/// <summary>Inits StatusEntity's FieldInfo objects</summary>
		private void InitStatusEntityInfos()
		{
			base.AddElementFieldInfo("StatusEntity", "StatusId", typeof(System.Int32), true, false, true, false,  (int)StatusFieldIndex.StatusId, 0, 0, 10);
			base.AddElementFieldInfo("StatusEntity", "StatusName", typeof(System.String), false, false, false, false,  (int)StatusFieldIndex.StatusName, 10, 0, 0);
		}
		/// <summary>Inits UserEntity's FieldInfo objects</summary>
		private void InitUserEntityInfos()
		{
			base.AddElementFieldInfo("UserEntity", "UserId", typeof(System.Int32), true, false, true, false,  (int)UserFieldIndex.UserId, 0, 0, 10);
			base.AddElementFieldInfo("UserEntity", "Username", typeof(System.String), false, false, false, true,  (int)UserFieldIndex.Username, 50, 0, 0);
			base.AddElementFieldInfo("UserEntity", "Password", typeof(System.Byte[]), false, false, false, true,  (int)UserFieldIndex.Password, 16, 0, 0);
			base.AddElementFieldInfo("UserEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.FirstName, 50, 0, 0);
			base.AddElementFieldInfo("UserEntity", "MiddleName", typeof(System.String), false, false, false, true,  (int)UserFieldIndex.MiddleName, 50, 0, 0);
			base.AddElementFieldInfo("UserEntity", "LastName", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.LastName, 50, 0, 0);
			base.AddElementFieldInfo("UserEntity", "UserTypeId", typeof(System.Int32), false, true, false, false,  (int)UserFieldIndex.UserTypeId, 0, 0, 10);
			base.AddElementFieldInfo("UserEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)UserFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("UserEntity", "IsEnabled", typeof(System.Boolean), false, false, false, false,  (int)UserFieldIndex.IsEnabled, 0, 0, 0);
			base.AddElementFieldInfo("UserEntity", "EmailAddress", typeof(System.String), false, false, false, true,  (int)UserFieldIndex.EmailAddress, 50, 0, 0);
		}
		/// <summary>Inits UserAccountEntity's FieldInfo objects</summary>
		private void InitUserAccountEntityInfos()
		{
			base.AddElementFieldInfo("UserAccountEntity", "UserAccountId", typeof(System.Int32), true, false, true, false,  (int)UserAccountFieldIndex.UserAccountId, 0, 0, 10);
			base.AddElementFieldInfo("UserAccountEntity", "UserId", typeof(System.Int32), false, true, false, false,  (int)UserAccountFieldIndex.UserId, 0, 0, 10);
			base.AddElementFieldInfo("UserAccountEntity", "AccountId", typeof(System.Int32), false, true, false, false,  (int)UserAccountFieldIndex.AccountId, 0, 0, 10);
		}
		/// <summary>Inits UserTypeEntity's FieldInfo objects</summary>
		private void InitUserTypeEntityInfos()
		{
			base.AddElementFieldInfo("UserTypeEntity", "UserTypeId", typeof(System.Int32), true, false, false, false,  (int)UserTypeFieldIndex.UserTypeId, 0, 0, 10);
			base.AddElementFieldInfo("UserTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)UserTypeFieldIndex.Name, 50, 0, 0);
			base.AddElementFieldInfo("UserTypeEntity", "Description", typeof(System.String), false, false, false, true,  (int)UserTypeFieldIndex.Description, 100, 0, 0);
		}
		/// <summary>Inits WorkOrderEntity's FieldInfo objects</summary>
		private void InitWorkOrderEntityInfos()
		{
			base.AddElementFieldInfo("WorkOrderEntity", "WorkOrderId", typeof(System.Int32), true, false, true, false,  (int)WorkOrderFieldIndex.WorkOrderId, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderEntity", "AccountId", typeof(System.Int32), false, true, false, false,  (int)WorkOrderFieldIndex.AccountId, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderEntity", "AppointmentDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderFieldIndex.AppointmentDate, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderEntity", "AppointmentTime", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)WorkOrderFieldIndex.AppointmentTime, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderEntity", "ServiceTypeId", typeof(System.Int32), false, true, false, false,  (int)WorkOrderFieldIndex.ServiceTypeId, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderEntity", "Notes", typeof(System.String), false, false, false, true,  (int)WorkOrderFieldIndex.Notes, 500, 0, 0);
			base.AddElementFieldInfo("WorkOrderEntity", "IsComplete", typeof(System.Boolean), false, false, false, false,  (int)WorkOrderFieldIndex.IsComplete, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderEntity", "IsActive", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)WorkOrderFieldIndex.IsActive, 0, 0, 0);
			base.AddElementFieldInfo("WorkOrderEntity", "Signature", typeof(System.String), false, false, false, true,  (int)WorkOrderFieldIndex.Signature, 2147483647, 0, 0);
			base.AddElementFieldInfo("WorkOrderEntity", "TechnicianId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)WorkOrderFieldIndex.TechnicianId, 0, 0, 10);
		}
		/// <summary>Inits WorkOrderEmployeeEntity's FieldInfo objects</summary>
		private void InitWorkOrderEmployeeEntityInfos()
		{
			base.AddElementFieldInfo("WorkOrderEmployeeEntity", "WorkOrderEmployeeId", typeof(System.Int32), true, false, true, false,  (int)WorkOrderEmployeeFieldIndex.WorkOrderEmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderEmployeeEntity", "WorkOrderId", typeof(System.Int32), false, true, false, false,  (int)WorkOrderEmployeeFieldIndex.WorkOrderId, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderEmployeeEntity", "EmployeeId", typeof(System.Int32), false, true, false, false,  (int)WorkOrderEmployeeFieldIndex.EmployeeId, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderEmployeeEntity", "Notes", typeof(System.String), false, false, false, true,  (int)WorkOrderEmployeeFieldIndex.Notes, 500, 0, 0);
			base.AddElementFieldInfo("WorkOrderEmployeeEntity", "UncategorizedItems", typeof(System.String), false, false, false, true,  (int)WorkOrderEmployeeFieldIndex.UncategorizedItems, 500, 0, 0);
		}
		/// <summary>Inits WorkOrderServiceLocationEntity's FieldInfo objects</summary>
		private void InitWorkOrderServiceLocationEntityInfos()
		{
			base.AddElementFieldInfo("WorkOrderServiceLocationEntity", "WorkOrderServiceLocationId", typeof(System.Int32), true, false, true, false,  (int)WorkOrderServiceLocationFieldIndex.WorkOrderServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderServiceLocationEntity", "WorkOrderId", typeof(System.Int32), false, true, false, false,  (int)WorkOrderServiceLocationFieldIndex.WorkOrderId, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderServiceLocationEntity", "ServiceLocationId", typeof(System.Int32), false, true, false, false,  (int)WorkOrderServiceLocationFieldIndex.ServiceLocationId, 0, 0, 10);
			base.AddElementFieldInfo("WorkOrderServiceLocationEntity", "Notes", typeof(System.String), false, false, false, true,  (int)WorkOrderServiceLocationFieldIndex.Notes, 500, 0, 0);
			base.AddElementFieldInfo("WorkOrderServiceLocationEntity", "UncategorizedItems", typeof(System.String), false, false, false, true,  (int)WorkOrderServiceLocationFieldIndex.UncategorizedItems, 500, 0, 0);
		}
		
	}
}




