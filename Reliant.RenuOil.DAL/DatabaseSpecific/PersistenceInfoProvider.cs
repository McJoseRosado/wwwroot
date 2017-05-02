///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.DatabaseSpecific
{
	/// <summary>
	/// Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal sealed class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			base.InitClass((39 + 0));
			InitAccountEntityMappings();
			InitAccountEmployeeAssignmentEntityMappings();
			InitAssetCategoryEntityMappings();
			InitAssetReclamationServiceEntityMappings();
			InitAssetReclamationServiceChangeLogEntityMappings();
			InitAssetTypeEntityMappings();
			InitBaleEntityMappings();
			InitChangeLogEntityMappings();
			InitChangeTypeEntityMappings();
			InitDeepFryerEntityMappings();
			InitDeepFryerChangeLogEntityMappings();
			InitDeepFryerServiceEntityMappings();
			InitDeepFryerServiceChangeLogEntityMappings();
			InitDockEntityMappings();
			InitEmployeeEntityMappings();
			InitLoadEntityMappings();
			InitMobileDeviceEntityMappings();
			InitRebateEntityMappings();
			InitRebateTypeEntityMappings();
			InitRecycleServiceEntityMappings();
			InitRecycleServiceActionEntityMappings();
			InitRecycleServiceChangeLogEntityMappings();
			InitRecycleTypeEntityMappings();
			InitRecycleVendorEntityMappings();
			InitRecycleVendorServiceEntityMappings();
			InitServiceLocationEntityMappings();
			InitServiceLocationAssetTypeEntityMappings();
			InitServiceLocationAssetTypeChangeLogEntityMappings();
			InitServiceLocationEmployeeAssignmentEntityMappings();
			InitServiceLocationRecycleTypeEntityMappings();
			InitServiceTypeEntityMappings();
			InitSettingEntityMappings();
			InitStatusEntityMappings();
			InitUserEntityMappings();
			InitUserAccountEntityMappings();
			InitUserTypeEntityMappings();
			InitWorkOrderEntityMappings();
			InitWorkOrderEmployeeEntityMappings();
			InitWorkOrderServiceLocationEntityMappings();

		}


		/// <summary>Inits AccountEntity's mappings</summary>
		private void InitAccountEntityMappings()
		{
			base.AddElementMapping( "AccountEntity", "RenuOil", @"dbo", "Account", 13 );
			base.AddElementFieldMapping( "AccountEntity", "AccountId", "AccountId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AccountEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "AccountEntity", "AccountNo", "AccountNo", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "AccountEntity", "Address1", "Address1", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "AccountEntity", "Address2", "Address2", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "AccountEntity", "City", "City", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "AccountEntity", "State", "State", true, (int)SqlDbType.NVarChar, 2, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "AccountEntity", "IntlState", "IntlState", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "AccountEntity", "ZipCode", "ZipCode", true, (int)SqlDbType.NVarChar, 10, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "AccountEntity", "Phone", "Phone", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "AccountEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 10 );
			base.AddElementFieldMapping( "AccountEntity", "MainContact", "MainContact", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "AccountEntity", "Notes", "Notes", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 12 );
		}
		/// <summary>Inits AccountEmployeeAssignmentEntity's mappings</summary>
		private void InitAccountEmployeeAssignmentEntityMappings()
		{
			base.AddElementMapping( "AccountEmployeeAssignmentEntity", "RenuOil", @"dbo", "AccountEmployeeAssignment", 9 );
			base.AddElementFieldMapping( "AccountEmployeeAssignmentEntity", "AccountEmployeeAssignmentId", "AccountEmployeeAssignmentId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AccountEmployeeAssignmentEntity", "AccountId", "AccountId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "AccountEmployeeAssignmentEntity", "Monday", "Monday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "AccountEmployeeAssignmentEntity", "Tuesday", "Tuesday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "AccountEmployeeAssignmentEntity", "Wednesday", "Wednesday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "AccountEmployeeAssignmentEntity", "Thursday", "Thursday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "AccountEmployeeAssignmentEntity", "Friday", "Friday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "AccountEmployeeAssignmentEntity", "Saturday", "Saturday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "AccountEmployeeAssignmentEntity", "Sunday", "Sunday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
		}
		/// <summary>Inits AssetCategoryEntity's mappings</summary>
		private void InitAssetCategoryEntityMappings()
		{
			base.AddElementMapping( "AssetCategoryEntity", "RenuOil", @"dbo", "AssetCategory", 5 );
			base.AddElementFieldMapping( "AssetCategoryEntity", "AssetCategoryId", "AssetCategoryId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AssetCategoryEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "AssetCategoryEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "AssetCategoryEntity", "SpanishLabel", "SpanishLabel", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "AssetCategoryEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
		}
		/// <summary>Inits AssetReclamationServiceEntity's mappings</summary>
		private void InitAssetReclamationServiceEntityMappings()
		{
			base.AddElementMapping( "AssetReclamationServiceEntity", "RenuOil", @"dbo", "AssetReclamationService", 4 );
			base.AddElementFieldMapping( "AssetReclamationServiceEntity", "AssetReclamationServiceId", "AssetReclamationServiceId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AssetReclamationServiceEntity", "WorkOrderServiceLocationId", "WorkOrderServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "AssetReclamationServiceEntity", "ServiceLocationAssetTypeId", "ServiceLocationAssetTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "AssetReclamationServiceEntity", "Quantity", "Quantity", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
		}
		/// <summary>Inits AssetReclamationServiceChangeLogEntity's mappings</summary>
		private void InitAssetReclamationServiceChangeLogEntityMappings()
		{
			base.AddElementMapping( "AssetReclamationServiceChangeLogEntity", "RenuOil", @"dbo", "AssetReclamationServiceChangeLog", 6 );
			base.AddElementFieldMapping( "AssetReclamationServiceChangeLogEntity", "AssetReclamationServiceChangeLogId", "AssetReclamationServiceChangeLogId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AssetReclamationServiceChangeLogEntity", "AssetReclamationServiceId", "AssetReclamationServiceId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "AssetReclamationServiceChangeLogEntity", "ChangeDate", "ChangeDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "AssetReclamationServiceChangeLogEntity", "Quantity", "Quantity", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "AssetReclamationServiceChangeLogEntity", "EnteredByEmployeeId", "EnteredByEmployeeId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "AssetReclamationServiceChangeLogEntity", "EnteredByUserId", "EnteredByUserId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
		}
		/// <summary>Inits AssetTypeEntity's mappings</summary>
		private void InitAssetTypeEntityMappings()
		{
			base.AddElementMapping( "AssetTypeEntity", "RenuOil", @"dbo", "AssetType", 6 );
			base.AddElementFieldMapping( "AssetTypeEntity", "AssetTypeId", "AssetTypeId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "AssetTypeEntity", "AssetCategoryId", "AssetCategoryId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "AssetTypeEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "AssetTypeEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "AssetTypeEntity", "SpanishLabel", "SpanishLabel", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "AssetTypeEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
		}
		/// <summary>Inits BaleEntity's mappings</summary>
		private void InitBaleEntityMappings()
		{
			base.AddElementMapping( "BaleEntity", "RenuOil", @"dbo", "Bale", 10 );
			base.AddElementFieldMapping( "BaleEntity", "BaleId", "BaleId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "BaleEntity", "AccountId", "AccountId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "BaleEntity", "DockId", "DockId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "BaleEntity", "RecycleTypeId", "RecycleTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "BaleEntity", "InitWeight", "InitWeight", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "BaleEntity", "CreatedDate", "CreatedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "BaleEntity", "WarehouseWeight", "WarehouseWeight", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "BaleEntity", "FinalWeight", "FinalWeight", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "BaleEntity", "Notes", "Notes", true, (int)SqlDbType.NVarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "BaleEntity", "LoadId", "LoadId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 9 );
		}
		/// <summary>Inits ChangeLogEntity's mappings</summary>
		private void InitChangeLogEntityMappings()
		{
			base.AddElementMapping( "ChangeLogEntity", "RenuOil", @"dbo", "ChangeLog", 4 );
			base.AddElementFieldMapping( "ChangeLogEntity", "ChangeLogId", "ChangeLogId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ChangeLogEntity", "ChangeTypeId", "ChangeTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ChangeLogEntity", "UserId", "UserId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "ChangeLogEntity", "ChangeDate", "ChangeDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits ChangeTypeEntity's mappings</summary>
		private void InitChangeTypeEntityMappings()
		{
			base.AddElementMapping( "ChangeTypeEntity", "RenuOil", @"dbo", "ChangeType", 3 );
			base.AddElementFieldMapping( "ChangeTypeEntity", "ChangeTypeId", "ChangeTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ChangeTypeEntity", "Name", "Name", false, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ChangeTypeEntity", "Description", "Description", false, (int)SqlDbType.VarChar, 200, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits DeepFryerEntity's mappings</summary>
		private void InitDeepFryerEntityMappings()
		{
			base.AddElementMapping( "DeepFryerEntity", "RenuOil", @"dbo", "DeepFryer", 6 );
			base.AddElementFieldMapping( "DeepFryerEntity", "DeepFryerId", "DeepFryerId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "DeepFryerEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DeepFryerEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DeepFryerEntity", "ServiceLocationId", "ServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "DeepFryerEntity", "SizeInGallons", "SizeInGallons", true, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 4 );
			base.AddElementFieldMapping( "DeepFryerEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
		}
		/// <summary>Inits DeepFryerChangeLogEntity's mappings</summary>
		private void InitDeepFryerChangeLogEntityMappings()
		{
			base.AddElementMapping( "DeepFryerChangeLogEntity", "RenuOil", @"dbo", "DeepFryerChangeLog", 3 );
			base.AddElementFieldMapping( "DeepFryerChangeLogEntity", "DeepFryerChangeLogId", "DeepFryerChangeLogId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "DeepFryerChangeLogEntity", "DeepFryerId", "DeepFryerId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "DeepFryerChangeLogEntity", "ChangeLogId", "ChangeLogId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits DeepFryerServiceEntity's mappings</summary>
		private void InitDeepFryerServiceEntityMappings()
		{
			base.AddElementMapping( "DeepFryerServiceEntity", "RenuOil", @"dbo", "DeepFryerService", 13 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "DeepFryerServiceId", "DeepFryerServiceId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "DeepFryerId", "DeepFryerId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "WorkOrderServiceLocationId", "WorkOrderServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "Filtered", "Filtered", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "Discarded", "Discarded", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "Relocated", "Relocated", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "Cleaned", "Cleaned", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "RelocatedToFryerId", "RelocatedToFryerId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "RelocatedToServiceLocationId", "RelocatedToServiceLocationId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "RelocatedToOther", "RelocatedToOther", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "AssignedTo", "AssignedTo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "Servicedby", "Servicedby", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 11 );
			base.AddElementFieldMapping( "DeepFryerServiceEntity", "NoService", "NoService", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 12 );
		}
		/// <summary>Inits DeepFryerServiceChangeLogEntity's mappings</summary>
		private void InitDeepFryerServiceChangeLogEntityMappings()
		{
			base.AddElementMapping( "DeepFryerServiceChangeLogEntity", "RenuOil", @"dbo", "DeepFryerServiceChangeLog", 14 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "DeepFryerServiceChangeLogId", "DeepFryerServiceChangeLogId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "DeepFryerServiceId", "DeepFryerServiceId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "ChangeDate", "ChangeDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "Filtered", "Filtered", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "Discarded", "Discarded", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "Relocated", "Relocated", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "Cleaned", "Cleaned", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "RelocatedToFryerId", "RelocatedToFryerId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "RelocatedToServiceLocationId", "RelocatedToServiceLocationId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "RelocatedToOther", "RelocatedToOther", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "AssignedTo", "AssignedTo", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "ServicedBy", "ServicedBy", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 11 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "EnteredByEmployeeId", "EnteredByEmployeeId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 12 );
			base.AddElementFieldMapping( "DeepFryerServiceChangeLogEntity", "EnteredByUserId", "EnteredByUserId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
		}
		/// <summary>Inits DockEntity's mappings</summary>
		private void InitDockEntityMappings()
		{
			base.AddElementMapping( "DockEntity", "RenuOil", @"dbo", "Dock", 3 );
			base.AddElementFieldMapping( "DockEntity", "DockId", "DockId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "DockEntity", "AccountId", "AccountId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "DockEntity", "DockName", "DockName", false, (int)SqlDbType.NVarChar, 40, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			base.AddElementMapping( "EmployeeEntity", "RenuOil", @"dbo", "Employee", 22 );
			base.AddElementFieldMapping( "EmployeeEntity", "EmployeeId", "EmployeeId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "EmployeeEntity", "FirstName", "FirstName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "EmployeeEntity", "MiddleName", "MiddleName", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "EmployeeEntity", "LastName", "LastName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "EmployeeEntity", "Username", "Username", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "EmployeeEntity", "Password", "Password", true, (int)SqlDbType.Binary, 16, 0, 0, false, "", null, typeof(System.Byte[]), 5 );
			base.AddElementFieldMapping( "EmployeeEntity", "Ssn", "SSN", true, (int)SqlDbType.NVarChar, 9, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "EmployeeEntity", "EmployeeNo", "EmployeeNo", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "EmployeeEntity", "DateOfBirth", "DateOfBirth", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "EmployeeEntity", "Address1", "Address1", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "EmployeeEntity", "Address2", "Address2", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "EmployeeEntity", "City", "City", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "EmployeeEntity", "State", "State", true, (int)SqlDbType.NVarChar, 2, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "EmployeeEntity", "IntlState", "IntlState", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "EmployeeEntity", "ZipCode", "ZipCode", true, (int)SqlDbType.NVarChar, 10, 0, 0, false, "", null, typeof(System.String), 14 );
			base.AddElementFieldMapping( "EmployeeEntity", "Phone", "Phone", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 15 );
			base.AddElementFieldMapping( "EmployeeEntity", "Mobile", "Mobile", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 16 );
			base.AddElementFieldMapping( "EmployeeEntity", "EmailAddress", "EmailAddress", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 17 );
			base.AddElementFieldMapping( "EmployeeEntity", "AssignOilService", "AssignOilService", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 18 );
			base.AddElementFieldMapping( "EmployeeEntity", "AssignRecycleService", "AssignRecycleService", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 19 );
			base.AddElementFieldMapping( "EmployeeEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 20 );
			base.AddElementFieldMapping( "EmployeeEntity", "IsEnabled", "IsEnabled", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 21 );
		}
		/// <summary>Inits LoadEntity's mappings</summary>
		private void InitLoadEntityMappings()
		{
			base.AddElementMapping( "LoadEntity", "RenuOil", @"dbo", "Load", 4 );
			base.AddElementFieldMapping( "LoadEntity", "LoadId", "LoadId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "LoadEntity", "EmployeeId", "EmployeeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "LoadEntity", "Date", "Date", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "LoadEntity", "StatusId", "StatusId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
		}
		/// <summary>Inits MobileDeviceEntity's mappings</summary>
		private void InitMobileDeviceEntityMappings()
		{
			base.AddElementMapping( "MobileDeviceEntity", "RenuOil", @"dbo", "MobileDevice", 5 );
			base.AddElementFieldMapping( "MobileDeviceEntity", "MobileDeviceId", "MobileDeviceId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "MobileDeviceEntity", "DeviceToken", "DeviceToken", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, "", null, typeof(System.Guid), 1 );
			base.AddElementFieldMapping( "MobileDeviceEntity", "TokenExpiration", "TokenExpiration", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "MobileDeviceEntity", "CurrentEmployeeId", "CurrentEmployeeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "MobileDeviceEntity", "IsEnabled", "IsEnabled", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
		}
		/// <summary>Inits RebateEntity's mappings</summary>
		private void InitRebateEntityMappings()
		{
			base.AddElementMapping( "RebateEntity", "RenuOil", @"dbo", "Rebate", 7 );
			base.AddElementFieldMapping( "RebateEntity", "RebateId", "RebateId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "RebateEntity", "RebateTypeId", "RebateTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "RebateEntity", "RebateDate", "RebateDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "RebateEntity", "AccountId", "AccountId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "RebateEntity", "Amount", "Amount", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 4 );
			base.AddElementFieldMapping( "RebateEntity", "EnteredByUserId", "EnteredByUserId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "RebateEntity", "EnteredDate", "EnteredDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
		}
		/// <summary>Inits RebateTypeEntity's mappings</summary>
		private void InitRebateTypeEntityMappings()
		{
			base.AddElementMapping( "RebateTypeEntity", "RenuOil", @"dbo", "RebateType", 3 );
			base.AddElementFieldMapping( "RebateTypeEntity", "RebateTypeId", "RebateTypeId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "RebateTypeEntity", "Name", "Name", false, (int)SqlDbType.VarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "RebateTypeEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
		}
		/// <summary>Inits RecycleServiceEntity's mappings</summary>
		private void InitRecycleServiceEntityMappings()
		{
			base.AddElementMapping( "RecycleServiceEntity", "RenuOil", @"dbo", "RecycleService", 6 );
			base.AddElementFieldMapping( "RecycleServiceEntity", "RecycleServiceId", "RecycleServiceId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "RecycleServiceEntity", "WorkOrderServiceLocationId", "WorkOrderServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "RecycleServiceEntity", "NumberOfBales", "NumberOfBales", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "RecycleServiceEntity", "NumberOfBags", "NumberOfBags", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "RecycleServiceEntity", "BalesWeight", "BalesWeight", true, (int)SqlDbType.Decimal, 0, 2, 10, false, "", null, typeof(System.Decimal), 4 );
			base.AddElementFieldMapping( "RecycleServiceEntity", "BagsWeight", "BagsWeight", true, (int)SqlDbType.Decimal, 0, 2, 10, false, "", null, typeof(System.Decimal), 5 );
		}
		/// <summary>Inits RecycleServiceActionEntity's mappings</summary>
		private void InitRecycleServiceActionEntityMappings()
		{
			base.AddElementMapping( "RecycleServiceActionEntity", "RenuOil", @"dbo", "RecycleServiceAction", 14 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "RecycleServiceActionId", "RecycleServiceActionId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "ActionTime", "ActionTime", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "NumberOfBales", "NumberOfBales", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "NumberOfBags", "NumberOfBags", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "BalesWeight", "BalesWeight", true, (int)SqlDbType.Decimal, 0, 2, 10, false, "", null, typeof(System.Decimal), 4 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "BagsWeight", "BagsWeight", true, (int)SqlDbType.Decimal, 0, 2, 10, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "RecycleServiceId", "RecycleServiceId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "RecycleTypeId", "RecycleTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "ActionUserId", "ActionUserId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "LastChangedByUserId", "LastChangedByUserId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 9 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "LastChangedDate", "LastChangedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "ActionType", "ActionType", false, (int)SqlDbType.VarChar, 1, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "ActionEmployeeId", "ActionEmployeeId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 12 );
			base.AddElementFieldMapping( "RecycleServiceActionEntity", "LastChangedByEmployeeId", "LastChangedByEmployeeId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
		}
		/// <summary>Inits RecycleServiceChangeLogEntity's mappings</summary>
		private void InitRecycleServiceChangeLogEntityMappings()
		{
			base.AddElementMapping( "RecycleServiceChangeLogEntity", "RenuOil", @"dbo", "RecycleServiceChangeLog", 9 );
			base.AddElementFieldMapping( "RecycleServiceChangeLogEntity", "RecycleServiceChangeLogId", "RecycleServiceChangeLogId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "RecycleServiceChangeLogEntity", "RecycleServiceId", "RecycleServiceId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "RecycleServiceChangeLogEntity", "ChangeDate", "ChangeDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "RecycleServiceChangeLogEntity", "NumberOfBales", "NumberOfBales", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "RecycleServiceChangeLogEntity", "NumberOfBags", "NumberOfBags", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "RecycleServiceChangeLogEntity", "BalesWeight", "BalesWeight", true, (int)SqlDbType.Decimal, 0, 2, 10, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "RecycleServiceChangeLogEntity", "BagsWeight", "BagsWeight", true, (int)SqlDbType.Decimal, 0, 2, 10, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "RecycleServiceChangeLogEntity", "EnteredByEmployeeId", "EnteredByEmployeeId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "RecycleServiceChangeLogEntity", "EnteredByUserId", "EnteredByUserId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
		}
		/// <summary>Inits RecycleTypeEntity's mappings</summary>
		private void InitRecycleTypeEntityMappings()
		{
			base.AddElementMapping( "RecycleTypeEntity", "RenuOil", @"dbo", "RecycleType", 5 );
			base.AddElementFieldMapping( "RecycleTypeEntity", "RecycleTypeId", "RecycleTypeId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "RecycleTypeEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "RecycleTypeEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "RecycleTypeEntity", "SpanishLabel", "SpanishLabel", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "RecycleTypeEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
		}
		/// <summary>Inits RecycleVendorEntity's mappings</summary>
		private void InitRecycleVendorEntityMappings()
		{
			base.AddElementMapping( "RecycleVendorEntity", "RenuOil", @"dbo", "RecycleVendor", 4 );
			base.AddElementFieldMapping( "RecycleVendorEntity", "RecycleVendorId", "RecycleVendorId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "RecycleVendorEntity", "Type", "Type", false, (int)SqlDbType.VarChar, 1, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "RecycleVendorEntity", "Name", "Name", false, (int)SqlDbType.VarChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "RecycleVendorEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
		}
		/// <summary>Inits RecycleVendorServiceEntity's mappings</summary>
		private void InitRecycleVendorServiceEntityMappings()
		{
			base.AddElementMapping( "RecycleVendorServiceEntity", "RenuOil", @"dbo", "RecycleVendorService", 8 );
			base.AddElementFieldMapping( "RecycleVendorServiceEntity", "RecycleVendorServiceId", "RecycleVendorServiceId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "RecycleVendorServiceEntity", "ServiceDate", "ServiceDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "RecycleVendorServiceEntity", "RecycleTypeId", "RecycleTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "RecycleVendorServiceEntity", "RecycleVendorId", "RecycleVendorId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "RecycleVendorServiceEntity", "Weight", "Weight", false, (int)SqlDbType.Decimal, 0, 2, 10, false, "", null, typeof(System.Decimal), 4 );
			base.AddElementFieldMapping( "RecycleVendorServiceEntity", "AccountId", "AccountId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "RecycleVendorServiceEntity", "TotalMonthlyWeight", "TotalMonthlyWeight", false, (int)SqlDbType.Decimal, 0, 2, 10, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "RecycleVendorServiceEntity", "TotalMonthlyPulls", "TotalMonthlyPulls", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
		}
		/// <summary>Inits ServiceLocationEntity's mappings</summary>
		private void InitServiceLocationEntityMappings()
		{
			base.AddElementMapping( "ServiceLocationEntity", "RenuOil", @"dbo", "ServiceLocation", 15 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "ServiceLocationId", "ServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "AccountId", "AccountId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "Address1", "Address1", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "Address2", "Address2", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "City", "City", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "State", "State", true, (int)SqlDbType.NVarChar, 2, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "IntlState", "IntlState", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "ZipCode", "ZipCode", true, (int)SqlDbType.NVarChar, 10, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "Phone", "Phone", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "MainContact", "MainContact", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "Notes", "Notes", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "ServiceTypeId", "ServiceTypeId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 12 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "IsActive", "IsActive", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 13 );
			base.AddElementFieldMapping( "ServiceLocationEntity", "Ordinal", "Ordinal", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 14 );
		}
		/// <summary>Inits ServiceLocationAssetTypeEntity's mappings</summary>
		private void InitServiceLocationAssetTypeEntityMappings()
		{
			base.AddElementMapping( "ServiceLocationAssetTypeEntity", "RenuOil", @"dbo", "ServiceLocationAssetType", 4 );
			base.AddElementFieldMapping( "ServiceLocationAssetTypeEntity", "ServiceLocationAssetTypeId", "ServiceLocationAssetTypeId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ServiceLocationAssetTypeEntity", "ServiceLocationId", "ServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ServiceLocationAssetTypeEntity", "AssetTypeId", "AssetTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "ServiceLocationAssetTypeEntity", "PricePerUnit", "PricePerUnit", false, (int)SqlDbType.Money, 0, 4, 19, false, "", null, typeof(System.Decimal), 3 );
		}
		/// <summary>Inits ServiceLocationAssetTypeChangeLogEntity's mappings</summary>
		private void InitServiceLocationAssetTypeChangeLogEntityMappings()
		{
			base.AddElementMapping( "ServiceLocationAssetTypeChangeLogEntity", "RenuOil", @"dbo", "ServiceLocationAssetTypeChangeLog", 3 );
			base.AddElementFieldMapping( "ServiceLocationAssetTypeChangeLogEntity", "ServiceLocationAssetTypeChangeLogId", "ServiceLocationAssetTypeChangeLogId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ServiceLocationAssetTypeChangeLogEntity", "ServiceLocationAssetTypeId", "ServiceLocationAssetTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ServiceLocationAssetTypeChangeLogEntity", "ChangeLogId", "ChangeLogId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits ServiceLocationEmployeeAssignmentEntity's mappings</summary>
		private void InitServiceLocationEmployeeAssignmentEntityMappings()
		{
			base.AddElementMapping( "ServiceLocationEmployeeAssignmentEntity", "RenuOil", @"dbo", "ServiceLocationEmployeeAssignment", 9 );
			base.AddElementFieldMapping( "ServiceLocationEmployeeAssignmentEntity", "ServiceLocationEmployeeAssignmentId", "ServiceLocationEmployeeAssignmentId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ServiceLocationEmployeeAssignmentEntity", "ServiceLocationId", "ServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ServiceLocationEmployeeAssignmentEntity", "Monday", "Monday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "ServiceLocationEmployeeAssignmentEntity", "Tuesday", "Tuesday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "ServiceLocationEmployeeAssignmentEntity", "Wednesday", "Wednesday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "ServiceLocationEmployeeAssignmentEntity", "Thursday", "Thursday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "ServiceLocationEmployeeAssignmentEntity", "Friday", "Friday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "ServiceLocationEmployeeAssignmentEntity", "Saturday", "Saturday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "ServiceLocationEmployeeAssignmentEntity", "Sunday", "Sunday", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
		}
		/// <summary>Inits ServiceLocationRecycleTypeEntity's mappings</summary>
		private void InitServiceLocationRecycleTypeEntityMappings()
		{
			base.AddElementMapping( "ServiceLocationRecycleTypeEntity", "RenuOil", @"dbo", "ServiceLocationRecycleType", 4 );
			base.AddElementFieldMapping( "ServiceLocationRecycleTypeEntity", "ServiceLocationRecycleTypeId", "ServiceLocationRecycleTypeId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ServiceLocationRecycleTypeEntity", "RecycleTypeId", "RecycleTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ServiceLocationRecycleTypeEntity", "ServiceLocationId", "ServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "ServiceLocationRecycleTypeEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
		}
		/// <summary>Inits ServiceTypeEntity's mappings</summary>
		private void InitServiceTypeEntityMappings()
		{
			base.AddElementMapping( "ServiceTypeEntity", "RenuOil", @"dbo", "ServiceType", 3 );
			base.AddElementFieldMapping( "ServiceTypeEntity", "ServiceTypeId", "ServiceTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ServiceTypeEntity", "Name", "Name", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ServiceTypeEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits SettingEntity's mappings</summary>
		private void InitSettingEntityMappings()
		{
			base.AddElementMapping( "SettingEntity", "RenuOil", @"dbo", "Setting", 6 );
			base.AddElementFieldMapping( "SettingEntity", "SettingId", "SettingId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "SettingEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "SettingEntity", "IntValue", "IntValue", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "SettingEntity", "DecimalValue", "DecimalValue", true, (int)SqlDbType.Decimal, 0, 0, 18, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "SettingEntity", "BoolValue", "BoolValue", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "SettingEntity", "StringValue", "StringValue", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits StatusEntity's mappings</summary>
		private void InitStatusEntityMappings()
		{
			base.AddElementMapping( "StatusEntity", "RenuOil", @"dbo", "Status", 2 );
			base.AddElementFieldMapping( "StatusEntity", "StatusId", "StatusId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "StatusEntity", "StatusName", "StatusName", false, (int)SqlDbType.NChar, 10, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			base.AddElementMapping( "UserEntity", "RenuOil", @"dbo", "User", 10 );
			base.AddElementFieldMapping( "UserEntity", "UserId", "UserId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "UserEntity", "Username", "Username", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "UserEntity", "Password", "Password", true, (int)SqlDbType.Binary, 16, 0, 0, false, "", null, typeof(System.Byte[]), 2 );
			base.AddElementFieldMapping( "UserEntity", "FirstName", "FirstName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "UserEntity", "MiddleName", "MiddleName", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "UserEntity", "LastName", "LastName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "UserEntity", "UserTypeId", "UserTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "UserEntity", "IsActive", "IsActive", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 7 );
			base.AddElementFieldMapping( "UserEntity", "IsEnabled", "IsEnabled", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			base.AddElementFieldMapping( "UserEntity", "EmailAddress", "EmailAddress", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
		}
		/// <summary>Inits UserAccountEntity's mappings</summary>
		private void InitUserAccountEntityMappings()
		{
			base.AddElementMapping( "UserAccountEntity", "RenuOil", @"dbo", "UserAccount", 3 );
			base.AddElementFieldMapping( "UserAccountEntity", "UserAccountId", "UserAccountId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "UserAccountEntity", "UserId", "UserId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "UserAccountEntity", "AccountId", "AccountId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits UserTypeEntity's mappings</summary>
		private void InitUserTypeEntityMappings()
		{
			base.AddElementMapping( "UserTypeEntity", "RenuOil", @"dbo", "UserType", 3 );
			base.AddElementFieldMapping( "UserTypeEntity", "UserTypeId", "UserTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "UserTypeEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "UserTypeEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits WorkOrderEntity's mappings</summary>
		private void InitWorkOrderEntityMappings()
		{
			base.AddElementMapping( "WorkOrderEntity", "RenuOil", @"dbo", "WorkOrder", 10 );
			base.AddElementFieldMapping( "WorkOrderEntity", "WorkOrderId", "WorkOrderId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "WorkOrderEntity", "AccountId", "AccountId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "WorkOrderEntity", "AppointmentDate", "AppointmentDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "WorkOrderEntity", "AppointmentTime", "AppointmentTime", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "WorkOrderEntity", "ServiceTypeId", "ServiceTypeId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "WorkOrderEntity", "Notes", "Notes", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "WorkOrderEntity", "IsComplete", "IsComplete", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 6 );
			base.AddElementFieldMapping( "WorkOrderEntity", "IsActive", "IsActive", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 7 );
			base.AddElementFieldMapping( "WorkOrderEntity", "Signature", "Signature", true, (int)SqlDbType.VarChar, 2147483647, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "WorkOrderEntity", "TechnicianId", "TechnicianId", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 9 );
		}
		/// <summary>Inits WorkOrderEmployeeEntity's mappings</summary>
		private void InitWorkOrderEmployeeEntityMappings()
		{
			base.AddElementMapping( "WorkOrderEmployeeEntity", "RenuOil", @"dbo", "WorkOrderServiceLocation", 5 );
			base.AddElementFieldMapping( "WorkOrderEmployeeEntity", "WorkOrderEmployeeId", "WorkOrderServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "WorkOrderEmployeeEntity", "WorkOrderId", "WorkOrderId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "WorkOrderEmployeeEntity", "EmployeeId", "ServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "WorkOrderEmployeeEntity", "Notes", "Notes", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "WorkOrderEmployeeEntity", "UncategorizedItems", "UncategorizedItems", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 4 );
		}
		/// <summary>Inits WorkOrderServiceLocationEntity's mappings</summary>
		private void InitWorkOrderServiceLocationEntityMappings()
		{
			base.AddElementMapping( "WorkOrderServiceLocationEntity", "RenuOil", @"dbo", "WorkOrderServiceLocation", 5 );
			base.AddElementFieldMapping( "WorkOrderServiceLocationEntity", "WorkOrderServiceLocationId", "WorkOrderServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "WorkOrderServiceLocationEntity", "WorkOrderId", "WorkOrderId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "WorkOrderServiceLocationEntity", "ServiceLocationId", "ServiceLocationId", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "WorkOrderServiceLocationEntity", "Notes", "Notes", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "WorkOrderServiceLocationEntity", "UncategorizedItems", "UncategorizedItems", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 4 );
		}

	}
}













