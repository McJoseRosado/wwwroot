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

namespace Reliant.RenuOil.DAL
{

	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Account.
	/// </summary>
	public enum AccountFieldIndex:int
	{
		///<summary>AccountId. </summary>
		AccountId,
		///<summary>Name. </summary>
		Name,
		///<summary>AccountNo. </summary>
		AccountNo,
		///<summary>Address1. </summary>
		Address1,
		///<summary>Address2. </summary>
		Address2,
		///<summary>City. </summary>
		City,
		///<summary>State. </summary>
		State,
		///<summary>IntlState. </summary>
		IntlState,
		///<summary>ZipCode. </summary>
		ZipCode,
		///<summary>Phone. </summary>
		Phone,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>MainContact. </summary>
		MainContact,
		///<summary>Notes. </summary>
		Notes,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AccountEmployeeAssignment.
	/// </summary>
	public enum AccountEmployeeAssignmentFieldIndex:int
	{
		///<summary>AccountEmployeeAssignmentId. </summary>
		AccountEmployeeAssignmentId,
		///<summary>AccountId. </summary>
		AccountId,
		///<summary>Monday. </summary>
		Monday,
		///<summary>Tuesday. </summary>
		Tuesday,
		///<summary>Wednesday. </summary>
		Wednesday,
		///<summary>Thursday. </summary>
		Thursday,
		///<summary>Friday. </summary>
		Friday,
		///<summary>Saturday. </summary>
		Saturday,
		///<summary>Sunday. </summary>
		Sunday,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AssetCategory.
	/// </summary>
	public enum AssetCategoryFieldIndex:int
	{
		///<summary>AssetCategoryId. </summary>
		AssetCategoryId,
		///<summary>Name. </summary>
		Name,
		///<summary>Description. </summary>
		Description,
		///<summary>SpanishLabel. </summary>
		SpanishLabel,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AssetReclamationService.
	/// </summary>
	public enum AssetReclamationServiceFieldIndex:int
	{
		///<summary>AssetReclamationServiceId. </summary>
		AssetReclamationServiceId,
		///<summary>WorkOrderServiceLocationId. </summary>
		WorkOrderServiceLocationId,
		///<summary>ServiceLocationAssetTypeId. </summary>
		ServiceLocationAssetTypeId,
		///<summary>Quantity. </summary>
		Quantity,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AssetReclamationServiceChangeLog.
	/// </summary>
	public enum AssetReclamationServiceChangeLogFieldIndex:int
	{
		///<summary>AssetReclamationServiceChangeLogId. </summary>
		AssetReclamationServiceChangeLogId,
		///<summary>AssetReclamationServiceId. </summary>
		AssetReclamationServiceId,
		///<summary>ChangeDate. </summary>
		ChangeDate,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>EnteredByEmployeeId. </summary>
		EnteredByEmployeeId,
		///<summary>EnteredByUserId. </summary>
		EnteredByUserId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AssetType.
	/// </summary>
	public enum AssetTypeFieldIndex:int
	{
		///<summary>AssetTypeId. </summary>
		AssetTypeId,
		///<summary>AssetCategoryId. </summary>
		AssetCategoryId,
		///<summary>Name. </summary>
		Name,
		///<summary>Description. </summary>
		Description,
		///<summary>SpanishLabel. </summary>
		SpanishLabel,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Bale.
	/// </summary>
	public enum BaleFieldIndex:int
	{
		///<summary>BaleId. </summary>
		BaleId,
		///<summary>AccountId. </summary>
		AccountId,
		///<summary>DockId. </summary>
		DockId,
		///<summary>RecycleTypeId. </summary>
		RecycleTypeId,
		///<summary>InitWeight. </summary>
		InitWeight,
		///<summary>CreatedDate. </summary>
		CreatedDate,
		///<summary>WarehouseWeight. </summary>
		WarehouseWeight,
		///<summary>FinalWeight. </summary>
		FinalWeight,
		///<summary>Notes. </summary>
		Notes,
		///<summary>LoadId. </summary>
		LoadId,
		///<summary>BaleNumber. </summary>
		BaleNumber,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ChangeLog.
	/// </summary>
	public enum ChangeLogFieldIndex:int
	{
		///<summary>ChangeLogId. </summary>
		ChangeLogId,
		///<summary>ChangeTypeId. </summary>
		ChangeTypeId,
		///<summary>UserId. </summary>
		UserId,
		///<summary>ChangeDate. </summary>
		ChangeDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ChangeType.
	/// </summary>
	public enum ChangeTypeFieldIndex:int
	{
		///<summary>ChangeTypeId. </summary>
		ChangeTypeId,
		///<summary>Name. </summary>
		Name,
		///<summary>Description. </summary>
		Description,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DeepFryer.
	/// </summary>
	public enum DeepFryerFieldIndex:int
	{
		///<summary>DeepFryerId. </summary>
		DeepFryerId,
		///<summary>Name. </summary>
		Name,
		///<summary>Description. </summary>
		Description,
		///<summary>ServiceLocationId. </summary>
		ServiceLocationId,
		///<summary>SizeInGallons. </summary>
		SizeInGallons,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DeepFryerChangeLog.
	/// </summary>
	public enum DeepFryerChangeLogFieldIndex:int
	{
		///<summary>DeepFryerChangeLogId. </summary>
		DeepFryerChangeLogId,
		///<summary>DeepFryerId. </summary>
		DeepFryerId,
		///<summary>ChangeLogId. </summary>
		ChangeLogId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DeepFryerService.
	/// </summary>
	public enum DeepFryerServiceFieldIndex:int
	{
		///<summary>DeepFryerServiceId. </summary>
		DeepFryerServiceId,
		///<summary>DeepFryerId. </summary>
		DeepFryerId,
		///<summary>WorkOrderServiceLocationId. </summary>
		WorkOrderServiceLocationId,
		///<summary>Filtered. </summary>
		Filtered,
		///<summary>Discarded. </summary>
		Discarded,
		///<summary>Relocated. </summary>
		Relocated,
		///<summary>Cleaned. </summary>
		Cleaned,
		///<summary>RelocatedToFryerId. </summary>
		RelocatedToFryerId,
		///<summary>RelocatedToServiceLocationId. </summary>
		RelocatedToServiceLocationId,
		///<summary>RelocatedToOther. </summary>
		RelocatedToOther,
		///<summary>AssignedTo. </summary>
		AssignedTo,
		///<summary>Servicedby. </summary>
		Servicedby,
		///<summary>NoService. </summary>
		NoService,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DeepFryerServiceChangeLog.
	/// </summary>
	public enum DeepFryerServiceChangeLogFieldIndex:int
	{
		///<summary>DeepFryerServiceChangeLogId. </summary>
		DeepFryerServiceChangeLogId,
		///<summary>DeepFryerServiceId. </summary>
		DeepFryerServiceId,
		///<summary>ChangeDate. </summary>
		ChangeDate,
		///<summary>Filtered. </summary>
		Filtered,
		///<summary>Discarded. </summary>
		Discarded,
		///<summary>Relocated. </summary>
		Relocated,
		///<summary>Cleaned. </summary>
		Cleaned,
		///<summary>RelocatedToFryerId. </summary>
		RelocatedToFryerId,
		///<summary>RelocatedToServiceLocationId. </summary>
		RelocatedToServiceLocationId,
		///<summary>RelocatedToOther. </summary>
		RelocatedToOther,
		///<summary>AssignedTo. </summary>
		AssignedTo,
		///<summary>ServicedBy. </summary>
		ServicedBy,
		///<summary>EnteredByEmployeeId. </summary>
		EnteredByEmployeeId,
		///<summary>EnteredByUserId. </summary>
		EnteredByUserId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Dock.
	/// </summary>
	public enum DockFieldIndex:int
	{
		///<summary>DockId. </summary>
		DockId,
		///<summary>AccountId. </summary>
		AccountId,
		///<summary>DockName. </summary>
		DockName,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ElmahError.
	/// </summary>
	public enum ElmahErrorFieldIndex:int
	{
		///<summary>ErrorId. </summary>
		ErrorId,
		///<summary>Application. </summary>
		Application,
		///<summary>Host. </summary>
		Host,
		///<summary>Type. </summary>
		Type,
		///<summary>Source. </summary>
		Source,
		///<summary>Message. </summary>
		Message,
		///<summary>User. </summary>
		User,
		///<summary>StatusCode. </summary>
		StatusCode,
		///<summary>TimeUtc. </summary>
		TimeUtc,
		///<summary>Sequence. </summary>
		Sequence,
		///<summary>AllXml. </summary>
		AllXml,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Employee.
	/// </summary>
	public enum EmployeeFieldIndex:int
	{
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>MiddleName. </summary>
		MiddleName,
		///<summary>LastName. </summary>
		LastName,
		///<summary>Username. </summary>
		Username,
		///<summary>Password. </summary>
		Password,
		///<summary>Ssn. </summary>
		Ssn,
		///<summary>EmployeeNo. </summary>
		EmployeeNo,
		///<summary>DateOfBirth. </summary>
		DateOfBirth,
		///<summary>Address1. </summary>
		Address1,
		///<summary>Address2. </summary>
		Address2,
		///<summary>City. </summary>
		City,
		///<summary>State. </summary>
		State,
		///<summary>IntlState. </summary>
		IntlState,
		///<summary>ZipCode. </summary>
		ZipCode,
		///<summary>Phone. </summary>
		Phone,
		///<summary>Mobile. </summary>
		Mobile,
		///<summary>EmailAddress. </summary>
		EmailAddress,
		///<summary>AssignOilService. </summary>
		AssignOilService,
		///<summary>AssignRecycleService. </summary>
		AssignRecycleService,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>IsEnabled. </summary>
		IsEnabled,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Load.
	/// </summary>
	public enum LoadFieldIndex:int
	{
		///<summary>LoadId. </summary>
		LoadId,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>Date. </summary>
		Date,
		///<summary>StatusId. </summary>
		StatusId,
		///<summary>LoadNumber. </summary>
		LoadNumber,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MobileDevice.
	/// </summary>
	public enum MobileDeviceFieldIndex:int
	{
		///<summary>MobileDeviceId. </summary>
		MobileDeviceId,
		///<summary>DeviceToken. </summary>
		DeviceToken,
		///<summary>TokenExpiration. </summary>
		TokenExpiration,
		///<summary>CurrentEmployeeId. </summary>
		CurrentEmployeeId,
		///<summary>IsEnabled. </summary>
		IsEnabled,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Rebate.
	/// </summary>
	public enum RebateFieldIndex:int
	{
		///<summary>RebateId. </summary>
		RebateId,
		///<summary>RebateTypeId. </summary>
		RebateTypeId,
		///<summary>RebateDate. </summary>
		RebateDate,
		///<summary>AccountId. </summary>
		AccountId,
		///<summary>Amount. </summary>
		Amount,
		///<summary>EnteredByUserId. </summary>
		EnteredByUserId,
		///<summary>EnteredDate. </summary>
		EnteredDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RebateType.
	/// </summary>
	public enum RebateTypeFieldIndex:int
	{
		///<summary>RebateTypeId. </summary>
		RebateTypeId,
		///<summary>Name. </summary>
		Name,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RecycleService.
	/// </summary>
	public enum RecycleServiceFieldIndex:int
	{
		///<summary>RecycleServiceId. </summary>
		RecycleServiceId,
		///<summary>WorkOrderServiceLocationId. </summary>
		WorkOrderServiceLocationId,
		///<summary>NumberOfBales. </summary>
		NumberOfBales,
		///<summary>NumberOfBags. </summary>
		NumberOfBags,
		///<summary>BalesWeight. </summary>
		BalesWeight,
		///<summary>BagsWeight. </summary>
		BagsWeight,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RecycleServiceAction.
	/// </summary>
	public enum RecycleServiceActionFieldIndex:int
	{
		///<summary>RecycleServiceActionId. </summary>
		RecycleServiceActionId,
		///<summary>ActionTime. </summary>
		ActionTime,
		///<summary>NumberOfBales. </summary>
		NumberOfBales,
		///<summary>NumberOfBags. </summary>
		NumberOfBags,
		///<summary>BalesWeight. </summary>
		BalesWeight,
		///<summary>BagsWeight. </summary>
		BagsWeight,
		///<summary>RecycleServiceId. </summary>
		RecycleServiceId,
		///<summary>RecycleTypeId. </summary>
		RecycleTypeId,
		///<summary>ActionUserId. </summary>
		ActionUserId,
		///<summary>LastChangedByUserId. </summary>
		LastChangedByUserId,
		///<summary>LastChangedDate. </summary>
		LastChangedDate,
		///<summary>ActionType. </summary>
		ActionType,
		///<summary>ActionEmployeeId. </summary>
		ActionEmployeeId,
		///<summary>LastChangedByEmployeeId. </summary>
		LastChangedByEmployeeId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RecycleServiceChangeLog.
	/// </summary>
	public enum RecycleServiceChangeLogFieldIndex:int
	{
		///<summary>RecycleServiceChangeLogId. </summary>
		RecycleServiceChangeLogId,
		///<summary>RecycleServiceId. </summary>
		RecycleServiceId,
		///<summary>ChangeDate. </summary>
		ChangeDate,
		///<summary>NumberOfBales. </summary>
		NumberOfBales,
		///<summary>NumberOfBags. </summary>
		NumberOfBags,
		///<summary>BalesWeight. </summary>
		BalesWeight,
		///<summary>BagsWeight. </summary>
		BagsWeight,
		///<summary>EnteredByEmployeeId. </summary>
		EnteredByEmployeeId,
		///<summary>EnteredByUserId. </summary>
		EnteredByUserId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RecycleType.
	/// </summary>
	public enum RecycleTypeFieldIndex:int
	{
		///<summary>RecycleTypeId. </summary>
		RecycleTypeId,
		///<summary>Name. </summary>
		Name,
		///<summary>Description. </summary>
		Description,
		///<summary>SpanishLabel. </summary>
		SpanishLabel,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RecycleVendor.
	/// </summary>
	public enum RecycleVendorFieldIndex:int
	{
		///<summary>RecycleVendorId. </summary>
		RecycleVendorId,
		///<summary>Type. </summary>
		Type,
		///<summary>Name. </summary>
		Name,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RecycleVendorService.
	/// </summary>
	public enum RecycleVendorServiceFieldIndex:int
	{
		///<summary>RecycleVendorServiceId. </summary>
		RecycleVendorServiceId,
		///<summary>ServiceDate. </summary>
		ServiceDate,
		///<summary>RecycleTypeId. </summary>
		RecycleTypeId,
		///<summary>RecycleVendorId. </summary>
		RecycleVendorId,
		///<summary>Weight. </summary>
		Weight,
		///<summary>AccountId. </summary>
		AccountId,
		///<summary>TotalMonthlyWeight. </summary>
		TotalMonthlyWeight,
		///<summary>TotalMonthlyPulls. </summary>
		TotalMonthlyPulls,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ServiceLocation.
	/// </summary>
	public enum ServiceLocationFieldIndex:int
	{
		///<summary>ServiceLocationId. </summary>
		ServiceLocationId,
		///<summary>AccountId. </summary>
		AccountId,
		///<summary>Name. </summary>
		Name,
		///<summary>Address1. </summary>
		Address1,
		///<summary>Address2. </summary>
		Address2,
		///<summary>City. </summary>
		City,
		///<summary>State. </summary>
		State,
		///<summary>IntlState. </summary>
		IntlState,
		///<summary>ZipCode. </summary>
		ZipCode,
		///<summary>Phone. </summary>
		Phone,
		///<summary>MainContact. </summary>
		MainContact,
		///<summary>Notes. </summary>
		Notes,
		///<summary>ServiceTypeId. </summary>
		ServiceTypeId,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>Ordinal. </summary>
		Ordinal,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ServiceLocationAssetType.
	/// </summary>
	public enum ServiceLocationAssetTypeFieldIndex:int
	{
		///<summary>ServiceLocationAssetTypeId. </summary>
		ServiceLocationAssetTypeId,
		///<summary>ServiceLocationId. </summary>
		ServiceLocationId,
		///<summary>AssetTypeId. </summary>
		AssetTypeId,
		///<summary>PricePerUnit. </summary>
		PricePerUnit,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ServiceLocationAssetTypeChangeLog.
	/// </summary>
	public enum ServiceLocationAssetTypeChangeLogFieldIndex:int
	{
		///<summary>ServiceLocationAssetTypeChangeLogId. </summary>
		ServiceLocationAssetTypeChangeLogId,
		///<summary>ServiceLocationAssetTypeId. </summary>
		ServiceLocationAssetTypeId,
		///<summary>ChangeLogId. </summary>
		ChangeLogId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ServiceLocationEmployeeAssignment.
	/// </summary>
	public enum ServiceLocationEmployeeAssignmentFieldIndex:int
	{
		///<summary>ServiceLocationEmployeeAssignmentId. </summary>
		ServiceLocationEmployeeAssignmentId,
		///<summary>ServiceLocationId. </summary>
		ServiceLocationId,
		///<summary>Monday. </summary>
		Monday,
		///<summary>Tuesday. </summary>
		Tuesday,
		///<summary>Wednesday. </summary>
		Wednesday,
		///<summary>Thursday. </summary>
		Thursday,
		///<summary>Friday. </summary>
		Friday,
		///<summary>Saturday. </summary>
		Saturday,
		///<summary>Sunday. </summary>
		Sunday,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ServiceLocationRecycleType.
	/// </summary>
	public enum ServiceLocationRecycleTypeFieldIndex:int
	{
		///<summary>ServiceLocationRecycleTypeId. </summary>
		ServiceLocationRecycleTypeId,
		///<summary>RecycleTypeId. </summary>
		RecycleTypeId,
		///<summary>ServiceLocationId. </summary>
		ServiceLocationId,
		///<summary>IsActive. </summary>
		IsActive,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ServiceType.
	/// </summary>
	public enum ServiceTypeFieldIndex:int
	{
		///<summary>ServiceTypeId. </summary>
		ServiceTypeId,
		///<summary>Name. </summary>
		Name,
		///<summary>Description. </summary>
		Description,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Setting.
	/// </summary>
	public enum SettingFieldIndex:int
	{
		///<summary>SettingId. </summary>
		SettingId,
		///<summary>Name. </summary>
		Name,
		///<summary>IntValue. </summary>
		IntValue,
		///<summary>DecimalValue. </summary>
		DecimalValue,
		///<summary>BoolValue. </summary>
		BoolValue,
		///<summary>StringValue. </summary>
		StringValue,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Status.
	/// </summary>
	public enum StatusFieldIndex:int
	{
		///<summary>StatusId. </summary>
		StatusId,
		///<summary>StatusName. </summary>
		StatusName,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: User.
	/// </summary>
	public enum UserFieldIndex:int
	{
		///<summary>UserId. </summary>
		UserId,
		///<summary>Username. </summary>
		Username,
		///<summary>Password. </summary>
		Password,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>MiddleName. </summary>
		MiddleName,
		///<summary>LastName. </summary>
		LastName,
		///<summary>UserTypeId. </summary>
		UserTypeId,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>IsEnabled. </summary>
		IsEnabled,
		///<summary>EmailAddress. </summary>
		EmailAddress,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UserAccount.
	/// </summary>
	public enum UserAccountFieldIndex:int
	{
		///<summary>UserAccountId. </summary>
		UserAccountId,
		///<summary>UserId. </summary>
		UserId,
		///<summary>AccountId. </summary>
		AccountId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UserType.
	/// </summary>
	public enum UserTypeFieldIndex:int
	{
		///<summary>UserTypeId. </summary>
		UserTypeId,
		///<summary>Name. </summary>
		Name,
		///<summary>Description. </summary>
		Description,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WorkOrder.
	/// </summary>
	public enum WorkOrderFieldIndex:int
	{
		///<summary>WorkOrderId. </summary>
		WorkOrderId,
		///<summary>AccountId. </summary>
		AccountId,
		///<summary>AppointmentDate. </summary>
		AppointmentDate,
		///<summary>AppointmentTime. </summary>
		AppointmentTime,
		///<summary>ServiceTypeId. </summary>
		ServiceTypeId,
		///<summary>Notes. </summary>
		Notes,
		///<summary>IsComplete. </summary>
		IsComplete,
		///<summary>IsActive. </summary>
		IsActive,
		///<summary>Signature. </summary>
		Signature,
		///<summary>TechnicianId. </summary>
		TechnicianId,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WorkOrderEmployee.
	/// </summary>
	public enum WorkOrderEmployeeFieldIndex:int
	{
		///<summary>WorkOrderEmployeeId. </summary>
		WorkOrderEmployeeId,
		///<summary>WorkOrderId. </summary>
		WorkOrderId,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>Notes. </summary>
		Notes,
		///<summary>UncategorizedItems. </summary>
		UncategorizedItems,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WorkOrderServiceLocation.
	/// </summary>
	public enum WorkOrderServiceLocationFieldIndex:int
	{
		///<summary>WorkOrderServiceLocationId. </summary>
		WorkOrderServiceLocationId,
		///<summary>WorkOrderId. </summary>
		WorkOrderId,
		///<summary>ServiceLocationId. </summary>
		ServiceLocationId,
		///<summary>Notes. </summary>
		Notes,
		///<summary>UncategorizedItems. </summary>
		UncategorizedItems,
		/// <summary></summary>
		AmountOfFields
	}





	/// <summary>
	/// Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.
	/// </summary>
	public enum EntityType:int
	{
		///<summary>Account</summary>
		AccountEntity,
		///<summary>AccountEmployeeAssignment</summary>
		AccountEmployeeAssignmentEntity,
		///<summary>AssetCategory</summary>
		AssetCategoryEntity,
		///<summary>AssetReclamationService</summary>
		AssetReclamationServiceEntity,
		///<summary>AssetReclamationServiceChangeLog</summary>
		AssetReclamationServiceChangeLogEntity,
		///<summary>AssetType</summary>
		AssetTypeEntity,
		///<summary>Bale</summary>
		BaleEntity,
		///<summary>ChangeLog</summary>
		ChangeLogEntity,
		///<summary>ChangeType</summary>
		ChangeTypeEntity,
		///<summary>DeepFryer</summary>
		DeepFryerEntity,
		///<summary>DeepFryerChangeLog</summary>
		DeepFryerChangeLogEntity,
		///<summary>DeepFryerService</summary>
		DeepFryerServiceEntity,
		///<summary>DeepFryerServiceChangeLog</summary>
		DeepFryerServiceChangeLogEntity,
		///<summary>Dock</summary>
		DockEntity,
		///<summary>ElmahError</summary>
		ElmahErrorEntity,
		///<summary>Employee</summary>
		EmployeeEntity,
		///<summary>Load</summary>
		LoadEntity,
		///<summary>MobileDevice</summary>
		MobileDeviceEntity,
		///<summary>Rebate</summary>
		RebateEntity,
		///<summary>RebateType</summary>
		RebateTypeEntity,
		///<summary>RecycleService</summary>
		RecycleServiceEntity,
		///<summary>RecycleServiceAction</summary>
		RecycleServiceActionEntity,
		///<summary>RecycleServiceChangeLog</summary>
		RecycleServiceChangeLogEntity,
		///<summary>RecycleType</summary>
		RecycleTypeEntity,
		///<summary>RecycleVendor</summary>
		RecycleVendorEntity,
		///<summary>RecycleVendorService</summary>
		RecycleVendorServiceEntity,
		///<summary>ServiceLocation</summary>
		ServiceLocationEntity,
		///<summary>ServiceLocationAssetType</summary>
		ServiceLocationAssetTypeEntity,
		///<summary>ServiceLocationAssetTypeChangeLog</summary>
		ServiceLocationAssetTypeChangeLogEntity,
		///<summary>ServiceLocationEmployeeAssignment</summary>
		ServiceLocationEmployeeAssignmentEntity,
		///<summary>ServiceLocationRecycleType</summary>
		ServiceLocationRecycleTypeEntity,
		///<summary>ServiceType</summary>
		ServiceTypeEntity,
		///<summary>Setting</summary>
		SettingEntity,
		///<summary>Status</summary>
		StatusEntity,
		///<summary>User</summary>
		UserEntity,
		///<summary>UserAccount</summary>
		UserAccountEntity,
		///<summary>UserType</summary>
		UserTypeEntity,
		///<summary>WorkOrder</summary>
		WorkOrderEntity,
		///<summary>WorkOrderEmployee</summary>
		WorkOrderEmployeeEntity,
		///<summary>WorkOrderServiceLocation</summary>
		WorkOrderServiceLocationEntity
	}




	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}


