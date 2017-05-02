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

using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.FactoryClasses
{
	/// <summary>
	/// Factory class for IEntityField2 instances, used in IEntityFields2 instances.
	/// </summary>
	public partial class EntityFieldFactory
	{
		/// <summary> Private CTor, no instantiation possible.</summary>
		private EntityFieldFactory()
		{
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the AccountEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(AccountFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("AccountEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the AccountEmployeeAssignmentEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(AccountEmployeeAssignmentFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("AccountEmployeeAssignmentEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the AssetCategoryEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(AssetCategoryFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("AssetCategoryEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the AssetReclamationServiceEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(AssetReclamationServiceFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("AssetReclamationServiceEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the AssetReclamationServiceChangeLogEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(AssetReclamationServiceChangeLogFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("AssetReclamationServiceChangeLogEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the AssetTypeEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(AssetTypeFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("AssetTypeEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the BaleEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(BaleFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("BaleEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ChangeLogEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ChangeLogFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ChangeLogEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ChangeTypeEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ChangeTypeFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ChangeTypeEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the DeepFryerEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(DeepFryerFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("DeepFryerEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the DeepFryerChangeLogEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(DeepFryerChangeLogFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("DeepFryerChangeLogEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the DeepFryerServiceEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(DeepFryerServiceFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("DeepFryerServiceEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the DeepFryerServiceChangeLogEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(DeepFryerServiceChangeLogFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("DeepFryerServiceChangeLogEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the DockEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(DockFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("DockEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the EmployeeEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(EmployeeFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("EmployeeEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the LoadEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(LoadFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("LoadEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the MobileDeviceEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(MobileDeviceFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("MobileDeviceEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the RebateEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(RebateFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("RebateEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the RebateTypeEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(RebateTypeFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("RebateTypeEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the RecycleServiceEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(RecycleServiceFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("RecycleServiceEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the RecycleServiceActionEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(RecycleServiceActionFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("RecycleServiceActionEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the RecycleServiceChangeLogEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(RecycleServiceChangeLogFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("RecycleServiceChangeLogEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the RecycleTypeEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(RecycleTypeFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("RecycleTypeEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the RecycleVendorEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(RecycleVendorFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("RecycleVendorEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the RecycleVendorServiceEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(RecycleVendorServiceFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("RecycleVendorServiceEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ServiceLocationEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ServiceLocationFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ServiceLocationEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ServiceLocationAssetTypeEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ServiceLocationAssetTypeFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ServiceLocationAssetTypeEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ServiceLocationAssetTypeChangeLogEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ServiceLocationAssetTypeChangeLogFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ServiceLocationAssetTypeChangeLogEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ServiceLocationEmployeeAssignmentEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ServiceLocationEmployeeAssignmentFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ServiceLocationEmployeeAssignmentEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ServiceLocationRecycleTypeEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ServiceLocationRecycleTypeFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ServiceLocationRecycleTypeEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ServiceTypeEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ServiceTypeFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ServiceTypeEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the SettingEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(SettingFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("SettingEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the StatusEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(StatusFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("StatusEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the UserEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(UserFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("UserEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the UserAccountEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(UserAccountFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("UserAccountEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the UserTypeEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(UserTypeFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("UserTypeEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the WorkOrderEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(WorkOrderFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("WorkOrderEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the WorkOrderEmployeeEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(WorkOrderEmployeeFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("WorkOrderEmployeeEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the WorkOrderServiceLocationEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(WorkOrderServiceLocationFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("WorkOrderServiceLocationEntity", (int)fieldIndex));
		}


		/// <summary>Creates a new IEntityField2 instance, which represents the field objectName.fieldName</summary>
		/// <param name="objectName">the name of the object the field belongs to, like CustomerEntity or OrdersTypedView</param>
		/// <param name="fieldName">the name of the field to create</param>
		public static IEntityField2 Create(string objectName, string fieldName)
        {
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(objectName, fieldName));
        }

		#region Included Code

		#endregion
	}
}
