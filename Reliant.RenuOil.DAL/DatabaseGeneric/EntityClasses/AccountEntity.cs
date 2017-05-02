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
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Entity class which represents the entity 'Account'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AccountEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<AccountEmployeeAssignmentEntity> _accountEmployeeAssignment;
		private EntityCollection<BaleEntity> _bale;
		private EntityCollection<RebateEntity> _rebate;
		private EntityCollection<RecycleVendorServiceEntity> _recycleVendorService;
		private EntityCollection<ServiceLocationEntity> _serviceLocation;
		private EntityCollection<UserAccountEntity> _userAccount;
		private EntityCollection<WorkOrderEntity> _workOrder;
		private EntityCollection<DockEntity> _dockCollectionViaBale;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaAccountEmployeeAssignment_____;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaAccountEmployeeAssignment______;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaWorkOrder;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaAccountEmployeeAssignment____;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaAccountEmployeeAssignment_;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaAccountEmployeeAssignment;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaAccountEmployeeAssignment___;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaAccountEmployeeAssignment__;
		private EntityCollection<RebateTypeEntity> _rebateTypeCollectionViaRebate;
		private EntityCollection<RecycleTypeEntity> _recycleTypeCollectionViaRecycleVendorService;
		private EntityCollection<RecycleTypeEntity> _recycleTypeCollectionViaBale;
		private EntityCollection<RecycleVendorEntity> _recycleVendorCollectionViaRecycleVendorService;
		private EntityCollection<ServiceTypeEntity> _serviceTypeCollectionViaWorkOrder;
		private EntityCollection<ServiceTypeEntity> _serviceTypeCollectionViaServiceLocation;
		private EntityCollection<UserEntity> _userCollectionViaRebate;
		private EntityCollection<UserEntity> _userCollectionViaUserAccount;


		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{

			/// <summary>Member name AccountEmployeeAssignment</summary>
			public static readonly string AccountEmployeeAssignment = "AccountEmployeeAssignment";
			/// <summary>Member name Bale</summary>
			public static readonly string Bale = "Bale";
			/// <summary>Member name Rebate</summary>
			public static readonly string Rebate = "Rebate";
			/// <summary>Member name RecycleVendorService</summary>
			public static readonly string RecycleVendorService = "RecycleVendorService";
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name UserAccount</summary>
			public static readonly string UserAccount = "UserAccount";
			/// <summary>Member name WorkOrder</summary>
			public static readonly string WorkOrder = "WorkOrder";
			/// <summary>Member name DockCollectionViaBale</summary>
			public static readonly string DockCollectionViaBale = "DockCollectionViaBale";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment_____</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment_____ = "EmployeeCollectionViaAccountEmployeeAssignment_____";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment______</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment______ = "EmployeeCollectionViaAccountEmployeeAssignment______";
			/// <summary>Member name EmployeeCollectionViaWorkOrder</summary>
			public static readonly string EmployeeCollectionViaWorkOrder = "EmployeeCollectionViaWorkOrder";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment____</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment____ = "EmployeeCollectionViaAccountEmployeeAssignment____";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment_</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment_ = "EmployeeCollectionViaAccountEmployeeAssignment_";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment = "EmployeeCollectionViaAccountEmployeeAssignment";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment___</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment___ = "EmployeeCollectionViaAccountEmployeeAssignment___";
			/// <summary>Member name EmployeeCollectionViaAccountEmployeeAssignment__</summary>
			public static readonly string EmployeeCollectionViaAccountEmployeeAssignment__ = "EmployeeCollectionViaAccountEmployeeAssignment__";
			/// <summary>Member name RebateTypeCollectionViaRebate</summary>
			public static readonly string RebateTypeCollectionViaRebate = "RebateTypeCollectionViaRebate";
			/// <summary>Member name RecycleTypeCollectionViaRecycleVendorService</summary>
			public static readonly string RecycleTypeCollectionViaRecycleVendorService = "RecycleTypeCollectionViaRecycleVendorService";
			/// <summary>Member name RecycleTypeCollectionViaBale</summary>
			public static readonly string RecycleTypeCollectionViaBale = "RecycleTypeCollectionViaBale";
			/// <summary>Member name RecycleVendorCollectionViaRecycleVendorService</summary>
			public static readonly string RecycleVendorCollectionViaRecycleVendorService = "RecycleVendorCollectionViaRecycleVendorService";
			/// <summary>Member name ServiceTypeCollectionViaWorkOrder</summary>
			public static readonly string ServiceTypeCollectionViaWorkOrder = "ServiceTypeCollectionViaWorkOrder";
			/// <summary>Member name ServiceTypeCollectionViaServiceLocation</summary>
			public static readonly string ServiceTypeCollectionViaServiceLocation = "ServiceTypeCollectionViaServiceLocation";
			/// <summary>Member name UserCollectionViaRebate</summary>
			public static readonly string UserCollectionViaRebate = "UserCollectionViaRebate";
			/// <summary>Member name UserCollectionViaUserAccount</summary>
			public static readonly string UserCollectionViaUserAccount = "UserCollectionViaUserAccount";

		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AccountEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary> CTor</summary>
		public AccountEntity():base("AccountEntity")
		{
			InitClassEmpty(null, CreateFields());
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AccountEntity(IEntityFields2 fields):base("AccountEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AccountEntity</param>
		public AccountEntity(IValidator validator):base("AccountEntity")
		{
			InitClassEmpty(validator, CreateFields());
		}
				

		/// <summary> CTor</summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AccountEntity(System.Int32 accountId):base("AccountEntity")
		{
			InitClassEmpty(null, CreateFields());
			this.AccountId = accountId;
		}

		/// <summary> CTor</summary>
		/// <param name="accountId">PK value for Account which data should be fetched into this Account object</param>
		/// <param name="validator">The custom validator object for this AccountEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public AccountEntity(System.Int32 accountId, IValidator validator):base("AccountEntity")
		{
			InitClassEmpty(validator, CreateFields());
			this.AccountId = accountId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected AccountEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_accountEmployeeAssignment = (EntityCollection<AccountEmployeeAssignmentEntity>)info.GetValue("_accountEmployeeAssignment", typeof(EntityCollection<AccountEmployeeAssignmentEntity>));
				_bale = (EntityCollection<BaleEntity>)info.GetValue("_bale", typeof(EntityCollection<BaleEntity>));
				_rebate = (EntityCollection<RebateEntity>)info.GetValue("_rebate", typeof(EntityCollection<RebateEntity>));
				_recycleVendorService = (EntityCollection<RecycleVendorServiceEntity>)info.GetValue("_recycleVendorService", typeof(EntityCollection<RecycleVendorServiceEntity>));
				_serviceLocation = (EntityCollection<ServiceLocationEntity>)info.GetValue("_serviceLocation", typeof(EntityCollection<ServiceLocationEntity>));
				_userAccount = (EntityCollection<UserAccountEntity>)info.GetValue("_userAccount", typeof(EntityCollection<UserAccountEntity>));
				_workOrder = (EntityCollection<WorkOrderEntity>)info.GetValue("_workOrder", typeof(EntityCollection<WorkOrderEntity>));
				_dockCollectionViaBale = (EntityCollection<DockEntity>)info.GetValue("_dockCollectionViaBale", typeof(EntityCollection<DockEntity>));
				_employeeCollectionViaAccountEmployeeAssignment_____ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment_____", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaAccountEmployeeAssignment______ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment______", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaWorkOrder = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaWorkOrder", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaAccountEmployeeAssignment____ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment____", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaAccountEmployeeAssignment_ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment_", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaAccountEmployeeAssignment = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaAccountEmployeeAssignment___ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment___", typeof(EntityCollection<EmployeeEntity>));
				_employeeCollectionViaAccountEmployeeAssignment__ = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaAccountEmployeeAssignment__", typeof(EntityCollection<EmployeeEntity>));
				_rebateTypeCollectionViaRebate = (EntityCollection<RebateTypeEntity>)info.GetValue("_rebateTypeCollectionViaRebate", typeof(EntityCollection<RebateTypeEntity>));
				_recycleTypeCollectionViaRecycleVendorService = (EntityCollection<RecycleTypeEntity>)info.GetValue("_recycleTypeCollectionViaRecycleVendorService", typeof(EntityCollection<RecycleTypeEntity>));
				_recycleTypeCollectionViaBale = (EntityCollection<RecycleTypeEntity>)info.GetValue("_recycleTypeCollectionViaBale", typeof(EntityCollection<RecycleTypeEntity>));
				_recycleVendorCollectionViaRecycleVendorService = (EntityCollection<RecycleVendorEntity>)info.GetValue("_recycleVendorCollectionViaRecycleVendorService", typeof(EntityCollection<RecycleVendorEntity>));
				_serviceTypeCollectionViaWorkOrder = (EntityCollection<ServiceTypeEntity>)info.GetValue("_serviceTypeCollectionViaWorkOrder", typeof(EntityCollection<ServiceTypeEntity>));
				_serviceTypeCollectionViaServiceLocation = (EntityCollection<ServiceTypeEntity>)info.GetValue("_serviceTypeCollectionViaServiceLocation", typeof(EntityCollection<ServiceTypeEntity>));
				_userCollectionViaRebate = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaRebate", typeof(EntityCollection<UserEntity>));
				_userCollectionViaUserAccount = (EntityCollection<UserEntity>)info.GetValue("_userCollectionViaUserAccount", typeof(EntityCollection<UserEntity>));


				base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AccountFieldIndex)fieldIndex)
			{
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
				
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity2 entity)
		{
			switch(propertyName)
			{

				case "AccountEmployeeAssignment":
					this.AccountEmployeeAssignment.Add((AccountEmployeeAssignmentEntity)entity);
					break;
				case "Bale":
					this.Bale.Add((BaleEntity)entity);
					break;
				case "Rebate":
					this.Rebate.Add((RebateEntity)entity);
					break;
				case "RecycleVendorService":
					this.RecycleVendorService.Add((RecycleVendorServiceEntity)entity);
					break;
				case "ServiceLocation":
					this.ServiceLocation.Add((ServiceLocationEntity)entity);
					break;
				case "UserAccount":
					this.UserAccount.Add((UserAccountEntity)entity);
					break;
				case "WorkOrder":
					this.WorkOrder.Add((WorkOrderEntity)entity);
					break;
				case "DockCollectionViaBale":
					this.DockCollectionViaBale.IsReadOnly = false;
					this.DockCollectionViaBale.Add((DockEntity)entity);
					this.DockCollectionViaBale.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment_____":
					this.EmployeeCollectionViaAccountEmployeeAssignment_____.IsReadOnly = false;
					this.EmployeeCollectionViaAccountEmployeeAssignment_____.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaAccountEmployeeAssignment_____.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment______":
					this.EmployeeCollectionViaAccountEmployeeAssignment______.IsReadOnly = false;
					this.EmployeeCollectionViaAccountEmployeeAssignment______.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaAccountEmployeeAssignment______.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaWorkOrder":
					this.EmployeeCollectionViaWorkOrder.IsReadOnly = false;
					this.EmployeeCollectionViaWorkOrder.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaWorkOrder.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment____":
					this.EmployeeCollectionViaAccountEmployeeAssignment____.IsReadOnly = false;
					this.EmployeeCollectionViaAccountEmployeeAssignment____.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaAccountEmployeeAssignment____.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment_":
					this.EmployeeCollectionViaAccountEmployeeAssignment_.IsReadOnly = false;
					this.EmployeeCollectionViaAccountEmployeeAssignment_.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaAccountEmployeeAssignment_.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment":
					this.EmployeeCollectionViaAccountEmployeeAssignment.IsReadOnly = false;
					this.EmployeeCollectionViaAccountEmployeeAssignment.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaAccountEmployeeAssignment.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment___":
					this.EmployeeCollectionViaAccountEmployeeAssignment___.IsReadOnly = false;
					this.EmployeeCollectionViaAccountEmployeeAssignment___.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaAccountEmployeeAssignment___.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment__":
					this.EmployeeCollectionViaAccountEmployeeAssignment__.IsReadOnly = false;
					this.EmployeeCollectionViaAccountEmployeeAssignment__.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaAccountEmployeeAssignment__.IsReadOnly = true;
					break;
				case "RebateTypeCollectionViaRebate":
					this.RebateTypeCollectionViaRebate.IsReadOnly = false;
					this.RebateTypeCollectionViaRebate.Add((RebateTypeEntity)entity);
					this.RebateTypeCollectionViaRebate.IsReadOnly = true;
					break;
				case "RecycleTypeCollectionViaRecycleVendorService":
					this.RecycleTypeCollectionViaRecycleVendorService.IsReadOnly = false;
					this.RecycleTypeCollectionViaRecycleVendorService.Add((RecycleTypeEntity)entity);
					this.RecycleTypeCollectionViaRecycleVendorService.IsReadOnly = true;
					break;
				case "RecycleTypeCollectionViaBale":
					this.RecycleTypeCollectionViaBale.IsReadOnly = false;
					this.RecycleTypeCollectionViaBale.Add((RecycleTypeEntity)entity);
					this.RecycleTypeCollectionViaBale.IsReadOnly = true;
					break;
				case "RecycleVendorCollectionViaRecycleVendorService":
					this.RecycleVendorCollectionViaRecycleVendorService.IsReadOnly = false;
					this.RecycleVendorCollectionViaRecycleVendorService.Add((RecycleVendorEntity)entity);
					this.RecycleVendorCollectionViaRecycleVendorService.IsReadOnly = true;
					break;
				case "ServiceTypeCollectionViaWorkOrder":
					this.ServiceTypeCollectionViaWorkOrder.IsReadOnly = false;
					this.ServiceTypeCollectionViaWorkOrder.Add((ServiceTypeEntity)entity);
					this.ServiceTypeCollectionViaWorkOrder.IsReadOnly = true;
					break;
				case "ServiceTypeCollectionViaServiceLocation":
					this.ServiceTypeCollectionViaServiceLocation.IsReadOnly = false;
					this.ServiceTypeCollectionViaServiceLocation.Add((ServiceTypeEntity)entity);
					this.ServiceTypeCollectionViaServiceLocation.IsReadOnly = true;
					break;
				case "UserCollectionViaRebate":
					this.UserCollectionViaRebate.IsReadOnly = false;
					this.UserCollectionViaRebate.Add((UserEntity)entity);
					this.UserCollectionViaRebate.IsReadOnly = true;
					break;
				case "UserCollectionViaUserAccount":
					this.UserCollectionViaUserAccount.IsReadOnly = false;
					this.UserCollectionViaUserAccount.Add((UserEntity)entity);
					this.UserCollectionViaUserAccount.IsReadOnly = true;
					break;

				default:
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return AccountEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "AccountEmployeeAssignment":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId);
					break;
				case "Bale":
					toReturn.Add(AccountEntity.Relations.BaleEntityUsingAccountId);
					break;
				case "Rebate":
					toReturn.Add(AccountEntity.Relations.RebateEntityUsingAccountId);
					break;
				case "RecycleVendorService":
					toReturn.Add(AccountEntity.Relations.RecycleVendorServiceEntityUsingAccountId);
					break;
				case "ServiceLocation":
					toReturn.Add(AccountEntity.Relations.ServiceLocationEntityUsingAccountId);
					break;
				case "UserAccount":
					toReturn.Add(AccountEntity.Relations.UserAccountEntityUsingAccountId);
					break;
				case "WorkOrder":
					toReturn.Add(AccountEntity.Relations.WorkOrderEntityUsingAccountId);
					break;
				case "DockCollectionViaBale":
					toReturn.Add(AccountEntity.Relations.BaleEntityUsingAccountId, "AccountEntity__", "Bale_", JoinHint.None);
					toReturn.Add(BaleEntity.Relations.DockEntityUsingDockId, "Bale_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment_____":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingTuesday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment______":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingWednesday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaWorkOrder":
					toReturn.Add(AccountEntity.Relations.WorkOrderEntityUsingAccountId, "AccountEntity__", "WorkOrder_", JoinHint.None);
					toReturn.Add(WorkOrderEntity.Relations.EmployeeEntityUsingTechnicianId, "WorkOrder_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment____":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingThursday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment_":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingMonday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingFriday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment___":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSunday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaAccountEmployeeAssignment__":
					toReturn.Add(AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId, "AccountEntity__", "AccountEmployeeAssignment_", JoinHint.None);
					toReturn.Add(AccountEmployeeAssignmentEntity.Relations.EmployeeEntityUsingSaturday, "AccountEmployeeAssignment_", string.Empty, JoinHint.None);
					break;
				case "RebateTypeCollectionViaRebate":
					toReturn.Add(AccountEntity.Relations.RebateEntityUsingAccountId, "AccountEntity__", "Rebate_", JoinHint.None);
					toReturn.Add(RebateEntity.Relations.RebateTypeEntityUsingRebateTypeId, "Rebate_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaRecycleVendorService":
					toReturn.Add(AccountEntity.Relations.RecycleVendorServiceEntityUsingAccountId, "AccountEntity__", "RecycleVendorService_", JoinHint.None);
					toReturn.Add(RecycleVendorServiceEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "RecycleVendorService_", string.Empty, JoinHint.None);
					break;
				case "RecycleTypeCollectionViaBale":
					toReturn.Add(AccountEntity.Relations.BaleEntityUsingAccountId, "AccountEntity__", "Bale_", JoinHint.None);
					toReturn.Add(BaleEntity.Relations.RecycleTypeEntityUsingRecycleTypeId, "Bale_", string.Empty, JoinHint.None);
					break;
				case "RecycleVendorCollectionViaRecycleVendorService":
					toReturn.Add(AccountEntity.Relations.RecycleVendorServiceEntityUsingAccountId, "AccountEntity__", "RecycleVendorService_", JoinHint.None);
					toReturn.Add(RecycleVendorServiceEntity.Relations.RecycleVendorEntityUsingRecycleVendorId, "RecycleVendorService_", string.Empty, JoinHint.None);
					break;
				case "ServiceTypeCollectionViaWorkOrder":
					toReturn.Add(AccountEntity.Relations.WorkOrderEntityUsingAccountId, "AccountEntity__", "WorkOrder_", JoinHint.None);
					toReturn.Add(WorkOrderEntity.Relations.ServiceTypeEntityUsingServiceTypeId, "WorkOrder_", string.Empty, JoinHint.None);
					break;
				case "ServiceTypeCollectionViaServiceLocation":
					toReturn.Add(AccountEntity.Relations.ServiceLocationEntityUsingAccountId, "AccountEntity__", "ServiceLocation_", JoinHint.None);
					toReturn.Add(ServiceLocationEntity.Relations.ServiceTypeEntityUsingServiceTypeId, "ServiceLocation_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaRebate":
					toReturn.Add(AccountEntity.Relations.RebateEntityUsingAccountId, "AccountEntity__", "Rebate_", JoinHint.None);
					toReturn.Add(RebateEntity.Relations.UserEntityUsingEnteredByUserId, "Rebate_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaUserAccount":
					toReturn.Add(AccountEntity.Relations.UserAccountEntityUsingAccountId, "AccountEntity__", "UserAccount_", JoinHint.None);
					toReturn.Add(UserAccountEntity.Relations.UserEntityUsingUserId, "UserAccount_", string.Empty, JoinHint.None);
					break;

				default:

					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it
		/// will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckOneWayRelations(string propertyName)
		{
			// use template trick to calculate the # of single-sided / oneway relations
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));


				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity2 relatedEntity, string fieldName)
		{
			switch(fieldName)
			{

				case "AccountEmployeeAssignment":
					this.AccountEmployeeAssignment.Add((AccountEmployeeAssignmentEntity)relatedEntity);
					break;
				case "Bale":
					this.Bale.Add((BaleEntity)relatedEntity);
					break;
				case "Rebate":
					this.Rebate.Add((RebateEntity)relatedEntity);
					break;
				case "RecycleVendorService":
					this.RecycleVendorService.Add((RecycleVendorServiceEntity)relatedEntity);
					break;
				case "ServiceLocation":
					this.ServiceLocation.Add((ServiceLocationEntity)relatedEntity);
					break;
				case "UserAccount":
					this.UserAccount.Add((UserAccountEntity)relatedEntity);
					break;
				case "WorkOrder":
					this.WorkOrder.Add((WorkOrderEntity)relatedEntity);
					break;

				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity2 relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{

				case "AccountEmployeeAssignment":
					base.PerformRelatedEntityRemoval(this.AccountEmployeeAssignment, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Bale":
					base.PerformRelatedEntityRemoval(this.Bale, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Rebate":
					base.PerformRelatedEntityRemoval(this.Rebate, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RecycleVendorService":
					base.PerformRelatedEntityRemoval(this.RecycleVendorService, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ServiceLocation":
					base.PerformRelatedEntityRemoval(this.ServiceLocation, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "UserAccount":
					base.PerformRelatedEntityRemoval(this.UserAccount, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrder":
					base.PerformRelatedEntityRemoval(this.WorkOrder, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		public override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();


			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. The contents of the ArrayList is used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		public override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.AccountEmployeeAssignment);
			toReturn.Add(this.Bale);
			toReturn.Add(this.Rebate);
			toReturn.Add(this.RecycleVendorService);
			toReturn.Add(this.ServiceLocation);
			toReturn.Add(this.UserAccount);
			toReturn.Add(this.WorkOrder);

			return toReturn;
		}
		


		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_accountEmployeeAssignment", ((_accountEmployeeAssignment!=null) && (_accountEmployeeAssignment.Count>0) && !this.MarkedForDeletion)?_accountEmployeeAssignment:null);
				info.AddValue("_bale", ((_bale!=null) && (_bale.Count>0) && !this.MarkedForDeletion)?_bale:null);
				info.AddValue("_rebate", ((_rebate!=null) && (_rebate.Count>0) && !this.MarkedForDeletion)?_rebate:null);
				info.AddValue("_recycleVendorService", ((_recycleVendorService!=null) && (_recycleVendorService.Count>0) && !this.MarkedForDeletion)?_recycleVendorService:null);
				info.AddValue("_serviceLocation", ((_serviceLocation!=null) && (_serviceLocation.Count>0) && !this.MarkedForDeletion)?_serviceLocation:null);
				info.AddValue("_userAccount", ((_userAccount!=null) && (_userAccount.Count>0) && !this.MarkedForDeletion)?_userAccount:null);
				info.AddValue("_workOrder", ((_workOrder!=null) && (_workOrder.Count>0) && !this.MarkedForDeletion)?_workOrder:null);
				info.AddValue("_dockCollectionViaBale", ((_dockCollectionViaBale!=null) && (_dockCollectionViaBale.Count>0) && !this.MarkedForDeletion)?_dockCollectionViaBale:null);
				info.AddValue("_employeeCollectionViaAccountEmployeeAssignment_____", ((_employeeCollectionViaAccountEmployeeAssignment_____!=null) && (_employeeCollectionViaAccountEmployeeAssignment_____.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaAccountEmployeeAssignment_____:null);
				info.AddValue("_employeeCollectionViaAccountEmployeeAssignment______", ((_employeeCollectionViaAccountEmployeeAssignment______!=null) && (_employeeCollectionViaAccountEmployeeAssignment______.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaAccountEmployeeAssignment______:null);
				info.AddValue("_employeeCollectionViaWorkOrder", ((_employeeCollectionViaWorkOrder!=null) && (_employeeCollectionViaWorkOrder.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaWorkOrder:null);
				info.AddValue("_employeeCollectionViaAccountEmployeeAssignment____", ((_employeeCollectionViaAccountEmployeeAssignment____!=null) && (_employeeCollectionViaAccountEmployeeAssignment____.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaAccountEmployeeAssignment____:null);
				info.AddValue("_employeeCollectionViaAccountEmployeeAssignment_", ((_employeeCollectionViaAccountEmployeeAssignment_!=null) && (_employeeCollectionViaAccountEmployeeAssignment_.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaAccountEmployeeAssignment_:null);
				info.AddValue("_employeeCollectionViaAccountEmployeeAssignment", ((_employeeCollectionViaAccountEmployeeAssignment!=null) && (_employeeCollectionViaAccountEmployeeAssignment.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaAccountEmployeeAssignment:null);
				info.AddValue("_employeeCollectionViaAccountEmployeeAssignment___", ((_employeeCollectionViaAccountEmployeeAssignment___!=null) && (_employeeCollectionViaAccountEmployeeAssignment___.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaAccountEmployeeAssignment___:null);
				info.AddValue("_employeeCollectionViaAccountEmployeeAssignment__", ((_employeeCollectionViaAccountEmployeeAssignment__!=null) && (_employeeCollectionViaAccountEmployeeAssignment__.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaAccountEmployeeAssignment__:null);
				info.AddValue("_rebateTypeCollectionViaRebate", ((_rebateTypeCollectionViaRebate!=null) && (_rebateTypeCollectionViaRebate.Count>0) && !this.MarkedForDeletion)?_rebateTypeCollectionViaRebate:null);
				info.AddValue("_recycleTypeCollectionViaRecycleVendorService", ((_recycleTypeCollectionViaRecycleVendorService!=null) && (_recycleTypeCollectionViaRecycleVendorService.Count>0) && !this.MarkedForDeletion)?_recycleTypeCollectionViaRecycleVendorService:null);
				info.AddValue("_recycleTypeCollectionViaBale", ((_recycleTypeCollectionViaBale!=null) && (_recycleTypeCollectionViaBale.Count>0) && !this.MarkedForDeletion)?_recycleTypeCollectionViaBale:null);
				info.AddValue("_recycleVendorCollectionViaRecycleVendorService", ((_recycleVendorCollectionViaRecycleVendorService!=null) && (_recycleVendorCollectionViaRecycleVendorService.Count>0) && !this.MarkedForDeletion)?_recycleVendorCollectionViaRecycleVendorService:null);
				info.AddValue("_serviceTypeCollectionViaWorkOrder", ((_serviceTypeCollectionViaWorkOrder!=null) && (_serviceTypeCollectionViaWorkOrder.Count>0) && !this.MarkedForDeletion)?_serviceTypeCollectionViaWorkOrder:null);
				info.AddValue("_serviceTypeCollectionViaServiceLocation", ((_serviceTypeCollectionViaServiceLocation!=null) && (_serviceTypeCollectionViaServiceLocation.Count>0) && !this.MarkedForDeletion)?_serviceTypeCollectionViaServiceLocation:null);
				info.AddValue("_userCollectionViaRebate", ((_userCollectionViaRebate!=null) && (_userCollectionViaRebate.Count>0) && !this.MarkedForDeletion)?_userCollectionViaRebate:null);
				info.AddValue("_userCollectionViaUserAccount", ((_userCollectionViaUserAccount!=null) && (_userCollectionViaUserAccount.Count>0) && !this.MarkedForDeletion)?_userCollectionViaUserAccount:null);


			}
			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}

		/// <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(AccountFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(AccountFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new AccountRelations().GetAllRelations();
		}
		

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'AccountEmployeeAssignment' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccountEmployeeAssignment()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountEmployeeAssignmentFields.AccountId, null, ComparisonOperator.Equal, this.AccountId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Bale' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBale()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BaleFields.AccountId, null, ComparisonOperator.Equal, this.AccountId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Rebate' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRebate()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RebateFields.AccountId, null, ComparisonOperator.Equal, this.AccountId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleVendorService' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleVendorService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RecycleVendorServiceFields.AccountId, null, ComparisonOperator.Equal, this.AccountId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceLocation' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ServiceLocationFields.AccountId, null, ComparisonOperator.Equal, this.AccountId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'UserAccount' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserAccount()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UserAccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'WorkOrder' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderFields.AccountId, null, ComparisonOperator.Equal, this.AccountId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Dock' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDockCollectionViaBale()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("DockCollectionViaBale"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaAccountEmployeeAssignment_____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaAccountEmployeeAssignment_____"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaAccountEmployeeAssignment______()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaAccountEmployeeAssignment______"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaWorkOrder"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaAccountEmployeeAssignment____()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaAccountEmployeeAssignment____"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaAccountEmployeeAssignment_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaAccountEmployeeAssignment_"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaAccountEmployeeAssignment()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaAccountEmployeeAssignment"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaAccountEmployeeAssignment___()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaAccountEmployeeAssignment___"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'Employee' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaAccountEmployeeAssignment__()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaAccountEmployeeAssignment__"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RebateType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRebateTypeCollectionViaRebate()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RebateTypeCollectionViaRebate"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleTypeCollectionViaRecycleVendorService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleTypeCollectionViaRecycleVendorService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleTypeCollectionViaBale()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleTypeCollectionViaBale"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'RecycleVendor' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecycleVendorCollectionViaRecycleVendorService()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("RecycleVendorCollectionViaRecycleVendorService"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceTypeCollectionViaWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceTypeCollectionViaWorkOrder"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'ServiceType' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoServiceTypeCollectionViaServiceLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ServiceTypeCollectionViaServiceLocation"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaRebate()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaRebate"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch
		/// the related entities of type 'User' to this entity. Use DataAccessAdapter.FetchEntityCollection() to fetch these related entities.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUserCollectionViaUserAccount()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("UserCollectionViaUserAccount"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AccountFields.AccountId, null, ComparisonOperator.Equal, this.AccountId, "AccountEntity__"));
			return bucket;
		}


	
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.AccountEntity);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(AccountEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._accountEmployeeAssignment);
			collectionsQueue.Enqueue(this._bale);
			collectionsQueue.Enqueue(this._rebate);
			collectionsQueue.Enqueue(this._recycleVendorService);
			collectionsQueue.Enqueue(this._serviceLocation);
			collectionsQueue.Enqueue(this._userAccount);
			collectionsQueue.Enqueue(this._workOrder);
			collectionsQueue.Enqueue(this._dockCollectionViaBale);
			collectionsQueue.Enqueue(this._employeeCollectionViaAccountEmployeeAssignment_____);
			collectionsQueue.Enqueue(this._employeeCollectionViaAccountEmployeeAssignment______);
			collectionsQueue.Enqueue(this._employeeCollectionViaWorkOrder);
			collectionsQueue.Enqueue(this._employeeCollectionViaAccountEmployeeAssignment____);
			collectionsQueue.Enqueue(this._employeeCollectionViaAccountEmployeeAssignment_);
			collectionsQueue.Enqueue(this._employeeCollectionViaAccountEmployeeAssignment);
			collectionsQueue.Enqueue(this._employeeCollectionViaAccountEmployeeAssignment___);
			collectionsQueue.Enqueue(this._employeeCollectionViaAccountEmployeeAssignment__);
			collectionsQueue.Enqueue(this._rebateTypeCollectionViaRebate);
			collectionsQueue.Enqueue(this._recycleTypeCollectionViaRecycleVendorService);
			collectionsQueue.Enqueue(this._recycleTypeCollectionViaBale);
			collectionsQueue.Enqueue(this._recycleVendorCollectionViaRecycleVendorService);
			collectionsQueue.Enqueue(this._serviceTypeCollectionViaWorkOrder);
			collectionsQueue.Enqueue(this._serviceTypeCollectionViaServiceLocation);
			collectionsQueue.Enqueue(this._userCollectionViaRebate);
			collectionsQueue.Enqueue(this._userCollectionViaUserAccount);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._accountEmployeeAssignment = (EntityCollection<AccountEmployeeAssignmentEntity>) collectionsQueue.Dequeue();
			this._bale = (EntityCollection<BaleEntity>) collectionsQueue.Dequeue();
			this._rebate = (EntityCollection<RebateEntity>) collectionsQueue.Dequeue();
			this._recycleVendorService = (EntityCollection<RecycleVendorServiceEntity>) collectionsQueue.Dequeue();
			this._serviceLocation = (EntityCollection<ServiceLocationEntity>) collectionsQueue.Dequeue();
			this._userAccount = (EntityCollection<UserAccountEntity>) collectionsQueue.Dequeue();
			this._workOrder = (EntityCollection<WorkOrderEntity>) collectionsQueue.Dequeue();
			this._dockCollectionViaBale = (EntityCollection<DockEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaAccountEmployeeAssignment_____ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaAccountEmployeeAssignment______ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaWorkOrder = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaAccountEmployeeAssignment____ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaAccountEmployeeAssignment_ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaAccountEmployeeAssignment = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaAccountEmployeeAssignment___ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaAccountEmployeeAssignment__ = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._rebateTypeCollectionViaRebate = (EntityCollection<RebateTypeEntity>) collectionsQueue.Dequeue();
			this._recycleTypeCollectionViaRecycleVendorService = (EntityCollection<RecycleTypeEntity>) collectionsQueue.Dequeue();
			this._recycleTypeCollectionViaBale = (EntityCollection<RecycleTypeEntity>) collectionsQueue.Dequeue();
			this._recycleVendorCollectionViaRecycleVendorService = (EntityCollection<RecycleVendorEntity>) collectionsQueue.Dequeue();
			this._serviceTypeCollectionViaWorkOrder = (EntityCollection<ServiceTypeEntity>) collectionsQueue.Dequeue();
			this._serviceTypeCollectionViaServiceLocation = (EntityCollection<ServiceTypeEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaRebate = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
			this._userCollectionViaUserAccount = (EntityCollection<UserEntity>) collectionsQueue.Dequeue();
		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			if (this._accountEmployeeAssignment != null)
			{
				return true;
			}
			if (this._bale != null)
			{
				return true;
			}
			if (this._rebate != null)
			{
				return true;
			}
			if (this._recycleVendorService != null)
			{
				return true;
			}
			if (this._serviceLocation != null)
			{
				return true;
			}
			if (this._userAccount != null)
			{
				return true;
			}
			if (this._workOrder != null)
			{
				return true;
			}
			if (this._dockCollectionViaBale != null)
			{
				return true;
			}
			if (this._employeeCollectionViaAccountEmployeeAssignment_____ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaAccountEmployeeAssignment______ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaWorkOrder != null)
			{
				return true;
			}
			if (this._employeeCollectionViaAccountEmployeeAssignment____ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaAccountEmployeeAssignment_ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaAccountEmployeeAssignment != null)
			{
				return true;
			}
			if (this._employeeCollectionViaAccountEmployeeAssignment___ != null)
			{
				return true;
			}
			if (this._employeeCollectionViaAccountEmployeeAssignment__ != null)
			{
				return true;
			}
			if (this._rebateTypeCollectionViaRebate != null)
			{
				return true;
			}
			if (this._recycleTypeCollectionViaRecycleVendorService != null)
			{
				return true;
			}
			if (this._recycleTypeCollectionViaBale != null)
			{
				return true;
			}
			if (this._recycleVendorCollectionViaRecycleVendorService != null)
			{
				return true;
			}
			if (this._serviceTypeCollectionViaWorkOrder != null)
			{
				return true;
			}
			if (this._serviceTypeCollectionViaServiceLocation != null)
			{
				return true;
			}
			if (this._userCollectionViaRebate != null)
			{
				return true;
			}
			if (this._userCollectionViaUserAccount != null)
			{
				return true;
			}
			return base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BaleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaleEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RebateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleVendorServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorServiceEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserAccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserAccountEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DockEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DockEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RebateTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RecycleVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ServiceTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))) : null);
		}
#endif
		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();

			toReturn.Add("AccountEmployeeAssignment", _accountEmployeeAssignment);
			toReturn.Add("Bale", _bale);
			toReturn.Add("Rebate", _rebate);
			toReturn.Add("RecycleVendorService", _recycleVendorService);
			toReturn.Add("ServiceLocation", _serviceLocation);
			toReturn.Add("UserAccount", _userAccount);
			toReturn.Add("WorkOrder", _workOrder);
			toReturn.Add("DockCollectionViaBale", _dockCollectionViaBale);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment_____", _employeeCollectionViaAccountEmployeeAssignment_____);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment______", _employeeCollectionViaAccountEmployeeAssignment______);
			toReturn.Add("EmployeeCollectionViaWorkOrder", _employeeCollectionViaWorkOrder);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment____", _employeeCollectionViaAccountEmployeeAssignment____);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment_", _employeeCollectionViaAccountEmployeeAssignment_);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment", _employeeCollectionViaAccountEmployeeAssignment);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment___", _employeeCollectionViaAccountEmployeeAssignment___);
			toReturn.Add("EmployeeCollectionViaAccountEmployeeAssignment__", _employeeCollectionViaAccountEmployeeAssignment__);
			toReturn.Add("RebateTypeCollectionViaRebate", _rebateTypeCollectionViaRebate);
			toReturn.Add("RecycleTypeCollectionViaRecycleVendorService", _recycleTypeCollectionViaRecycleVendorService);
			toReturn.Add("RecycleTypeCollectionViaBale", _recycleTypeCollectionViaBale);
			toReturn.Add("RecycleVendorCollectionViaRecycleVendorService", _recycleVendorCollectionViaRecycleVendorService);
			toReturn.Add("ServiceTypeCollectionViaWorkOrder", _serviceTypeCollectionViaWorkOrder);
			toReturn.Add("ServiceTypeCollectionViaServiceLocation", _serviceTypeCollectionViaServiceLocation);
			toReturn.Add("UserCollectionViaRebate", _userCollectionViaRebate);
			toReturn.Add("UserCollectionViaUserAccount", _userCollectionViaUserAccount);

			return toReturn;
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			if(_accountEmployeeAssignment!=null)
			{
				_accountEmployeeAssignment.ActiveContext = base.ActiveContext;
			}
			if(_bale!=null)
			{
				_bale.ActiveContext = base.ActiveContext;
			}
			if(_rebate!=null)
			{
				_rebate.ActiveContext = base.ActiveContext;
			}
			if(_recycleVendorService!=null)
			{
				_recycleVendorService.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
			}
			if(_userAccount!=null)
			{
				_userAccount.ActiveContext = base.ActiveContext;
			}
			if(_workOrder!=null)
			{
				_workOrder.ActiveContext = base.ActiveContext;
			}
			if(_dockCollectionViaBale!=null)
			{
				_dockCollectionViaBale.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaAccountEmployeeAssignment_____!=null)
			{
				_employeeCollectionViaAccountEmployeeAssignment_____.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaAccountEmployeeAssignment______!=null)
			{
				_employeeCollectionViaAccountEmployeeAssignment______.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaWorkOrder!=null)
			{
				_employeeCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaAccountEmployeeAssignment____!=null)
			{
				_employeeCollectionViaAccountEmployeeAssignment____.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaAccountEmployeeAssignment_!=null)
			{
				_employeeCollectionViaAccountEmployeeAssignment_.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaAccountEmployeeAssignment!=null)
			{
				_employeeCollectionViaAccountEmployeeAssignment.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaAccountEmployeeAssignment___!=null)
			{
				_employeeCollectionViaAccountEmployeeAssignment___.ActiveContext = base.ActiveContext;
			}
			if(_employeeCollectionViaAccountEmployeeAssignment__!=null)
			{
				_employeeCollectionViaAccountEmployeeAssignment__.ActiveContext = base.ActiveContext;
			}
			if(_rebateTypeCollectionViaRebate!=null)
			{
				_rebateTypeCollectionViaRebate.ActiveContext = base.ActiveContext;
			}
			if(_recycleTypeCollectionViaRecycleVendorService!=null)
			{
				_recycleTypeCollectionViaRecycleVendorService.ActiveContext = base.ActiveContext;
			}
			if(_recycleTypeCollectionViaBale!=null)
			{
				_recycleTypeCollectionViaBale.ActiveContext = base.ActiveContext;
			}
			if(_recycleVendorCollectionViaRecycleVendorService!=null)
			{
				_recycleVendorCollectionViaRecycleVendorService.ActiveContext = base.ActiveContext;
			}
			if(_serviceTypeCollectionViaWorkOrder!=null)
			{
				_serviceTypeCollectionViaWorkOrder.ActiveContext = base.ActiveContext;
			}
			if(_serviceTypeCollectionViaServiceLocation!=null)
			{
				_serviceTypeCollectionViaServiceLocation.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaRebate!=null)
			{
				_userCollectionViaRebate.ActiveContext = base.ActiveContext;
			}
			if(_userCollectionViaUserAccount!=null)
			{
				_userCollectionViaUserAccount.ActiveContext = base.ActiveContext;
			}


		}

		/// <summary> Initializes the class members</summary>
		protected virtual void InitClassMembers()
		{

			_accountEmployeeAssignment = null;
			_bale = null;
			_rebate = null;
			_recycleVendorService = null;
			_serviceLocation = null;
			_userAccount = null;
			_workOrder = null;
			_dockCollectionViaBale = null;
			_employeeCollectionViaAccountEmployeeAssignment_____ = null;
			_employeeCollectionViaAccountEmployeeAssignment______ = null;
			_employeeCollectionViaWorkOrder = null;
			_employeeCollectionViaAccountEmployeeAssignment____ = null;
			_employeeCollectionViaAccountEmployeeAssignment_ = null;
			_employeeCollectionViaAccountEmployeeAssignment = null;
			_employeeCollectionViaAccountEmployeeAssignment___ = null;
			_employeeCollectionViaAccountEmployeeAssignment__ = null;
			_rebateTypeCollectionViaRebate = null;
			_recycleTypeCollectionViaRecycleVendorService = null;
			_recycleTypeCollectionViaBale = null;
			_recycleVendorCollectionViaRecycleVendorService = null;
			_serviceTypeCollectionViaWorkOrder = null;
			_serviceTypeCollectionViaServiceLocation = null;
			_userCollectionViaRebate = null;
			_userCollectionViaUserAccount = null;


			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AccountNo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Address1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Address2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("State", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IntlState", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ZipCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Phone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("IsActive", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MainContact", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Notes", fieldHashtable);
		}
		#endregion



		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this AccountEntity</param>
		/// <param name="fields">Fields of this entity</param>
		protected virtual void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			base.Fields = fields;
			base.IsNew=true;
			base.Validator = validator;
			InitClassMembers();

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AccountRelations Relations
		{
			get	{ return new AccountRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AccountEmployeeAssignment' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccountEmployeeAssignment
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory))),
					(IEntityRelation)GetRelationsForField("AccountEmployeeAssignment")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.AccountEmployeeAssignmentEntity, 0, null, null, null, null, "AccountEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Bale' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBale
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<BaleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaleEntityFactory))),
					(IEntityRelation)GetRelationsForField("Bale")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.BaleEntity, 0, null, null, null, null, "Bale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Rebate' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRebate
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RebateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateEntityFactory))),
					(IEntityRelation)GetRelationsForField("Rebate")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RebateEntity, 0, null, null, null, null, "Rebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleVendorService' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleVendorService
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<RecycleVendorServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorServiceEntityFactory))),
					(IEntityRelation)GetRelationsForField("RecycleVendorService")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorServiceEntity, 0, null, null, null, null, "RecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceLocation
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory))),
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UserAccount' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserAccount
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<UserAccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserAccountEntityFactory))),
					(IEntityRelation)GetRelationsForField("UserAccount")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.UserAccountEntity, 0, null, null, null, null, "UserAccount", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}
		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrder' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrder
		{
			get
			{
				return new PrefetchPathElement2( new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))),
					(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEntity, 0, null, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Dock' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDockCollectionViaBale
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.BaleEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "Bale_");
				return new PrefetchPathElement2(new EntityCollection<DockEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DockEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.DockEntity, 0, null, null, GetRelationsForField("DockCollectionViaBale"), null, "DockCollectionViaBale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment_____
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment_____"), null, "EmployeeCollectionViaAccountEmployeeAssignment_____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment______
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment______"), null, "EmployeeCollectionViaAccountEmployeeAssignment______", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.WorkOrderEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaWorkOrder"), null, "EmployeeCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment____
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment____"), null, "EmployeeCollectionViaAccountEmployeeAssignment____", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment_
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment_"), null, "EmployeeCollectionViaAccountEmployeeAssignment_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment"), null, "EmployeeCollectionViaAccountEmployeeAssignment", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment___
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment___"), null, "EmployeeCollectionViaAccountEmployeeAssignment___", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaAccountEmployeeAssignment__
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.AccountEmployeeAssignmentEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "AccountEmployeeAssignment_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaAccountEmployeeAssignment__"), null, "EmployeeCollectionViaAccountEmployeeAssignment__", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RebateType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRebateTypeCollectionViaRebate
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.RebateEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "Rebate_");
				return new PrefetchPathElement2(new EntityCollection<RebateTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RebateTypeEntity, 0, null, null, GetRelationsForField("RebateTypeCollectionViaRebate"), null, "RebateTypeCollectionViaRebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleTypeCollectionViaRecycleVendorService
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.RecycleVendorServiceEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "RecycleVendorService_");
				return new PrefetchPathElement2(new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaRecycleVendorService"), null, "RecycleTypeCollectionViaRecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleTypeCollectionViaBale
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.BaleEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "Bale_");
				return new PrefetchPathElement2(new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleTypeEntity, 0, null, null, GetRelationsForField("RecycleTypeCollectionViaBale"), null, "RecycleTypeCollectionViaBale", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RecycleVendor' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecycleVendorCollectionViaRecycleVendorService
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.RecycleVendorServiceEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "RecycleVendorService_");
				return new PrefetchPathElement2(new EntityCollection<RecycleVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.RecycleVendorEntity, 0, null, null, GetRelationsForField("RecycleVendorCollectionViaRecycleVendorService"), null, "RecycleVendorCollectionViaRecycleVendorService", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceTypeCollectionViaWorkOrder
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.WorkOrderEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "WorkOrder_");
				return new PrefetchPathElement2(new EntityCollection<ServiceTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, 0, null, null, GetRelationsForField("ServiceTypeCollectionViaWorkOrder"), null, "ServiceTypeCollectionViaWorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ServiceType' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathServiceTypeCollectionViaServiceLocation
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.ServiceLocationEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "ServiceLocation_");
				return new PrefetchPathElement2(new EntityCollection<ServiceTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceTypeEntity, 0, null, null, GetRelationsForField("ServiceTypeCollectionViaServiceLocation"), null, "ServiceTypeCollectionViaServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaRebate
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.RebateEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "Rebate_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaRebate"), null, "UserCollectionViaRebate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath2 instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUserCollectionViaUserAccount
		{
			get
			{
				IEntityRelation intermediateRelation = AccountEntity.Relations.UserAccountEntityUsingAccountId;
				intermediateRelation.SetAliases(string.Empty, "UserAccount_");
				return new PrefetchPathElement2(new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory))), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.AccountEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaUserAccount"), null, "UserCollectionViaUserAccount", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}



		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return AccountEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value
		/// pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return AccountEntity.FieldsCustomProperties;}
		}

		/// <summary> The AccountId property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."AccountId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AccountId
		{
			get { return (System.Int32)GetValue((int)AccountFieldIndex.AccountId, true); }
			set	{ SetValue((int)AccountFieldIndex.AccountId, value); }
		}

		/// <summary> The Name property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.Name, true); }
			set	{ SetValue((int)AccountFieldIndex.Name, value); }
		}

		/// <summary> The AccountNo property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."AccountNo"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AccountNo
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.AccountNo, true); }
			set	{ SetValue((int)AccountFieldIndex.AccountNo, value); }
		}

		/// <summary> The Address1 property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."Address1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address1
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.Address1, true); }
			set	{ SetValue((int)AccountFieldIndex.Address1, value); }
		}

		/// <summary> The Address2 property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."Address2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address2
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.Address2, true); }
			set	{ SetValue((int)AccountFieldIndex.Address2, value); }
		}

		/// <summary> The City property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.City, true); }
			set	{ SetValue((int)AccountFieldIndex.City, value); }
		}

		/// <summary> The State property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."State"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String State
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.State, true); }
			set	{ SetValue((int)AccountFieldIndex.State, value); }
		}

		/// <summary> The IntlState property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."IntlState"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String IntlState
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.IntlState, true); }
			set	{ SetValue((int)AccountFieldIndex.IntlState, value); }
		}

		/// <summary> The ZipCode property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."ZipCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ZipCode
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.ZipCode, true); }
			set	{ SetValue((int)AccountFieldIndex.ZipCode, value); }
		}

		/// <summary> The Phone property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.Phone, true); }
			set	{ SetValue((int)AccountFieldIndex.Phone, value); }
		}

		/// <summary> The IsActive property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."IsActive"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsActive
		{
			get { return (System.Boolean)GetValue((int)AccountFieldIndex.IsActive, true); }
			set	{ SetValue((int)AccountFieldIndex.IsActive, value); }
		}

		/// <summary> The MainContact property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."MainContact"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MainContact
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.MainContact, true); }
			set	{ SetValue((int)AccountFieldIndex.MainContact, value); }
		}

		/// <summary> The Notes property of the Entity Account<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "Account"."Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Notes
		{
			get { return (System.String)GetValue((int)AccountFieldIndex.Notes, true); }
			set	{ SetValue((int)AccountFieldIndex.Notes, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AccountEmployeeAssignmentEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(AccountEmployeeAssignmentEntity))]
		public virtual EntityCollection<AccountEmployeeAssignmentEntity> AccountEmployeeAssignment
		{
			get
			{
				if(_accountEmployeeAssignment==null)
				{
					_accountEmployeeAssignment = new EntityCollection<AccountEmployeeAssignmentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AccountEmployeeAssignmentEntityFactory)));
					_accountEmployeeAssignment.SetContainingEntityInfo(this, "Account");
				}
				return _accountEmployeeAssignment;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BaleEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(BaleEntity))]
		public virtual EntityCollection<BaleEntity> Bale
		{
			get
			{
				if(_bale==null)
				{
					_bale = new EntityCollection<BaleEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BaleEntityFactory)));
					_bale.SetContainingEntityInfo(this, "Account");
				}
				return _bale;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RebateEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RebateEntity))]
		public virtual EntityCollection<RebateEntity> Rebate
		{
			get
			{
				if(_rebate==null)
				{
					_rebate = new EntityCollection<RebateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateEntityFactory)));
					_rebate.SetContainingEntityInfo(this, "Account");
				}
				return _rebate;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleVendorServiceEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleVendorServiceEntity))]
		public virtual EntityCollection<RecycleVendorServiceEntity> RecycleVendorService
		{
			get
			{
				if(_recycleVendorService==null)
				{
					_recycleVendorService = new EntityCollection<RecycleVendorServiceEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorServiceEntityFactory)));
					_recycleVendorService.SetContainingEntityInfo(this, "Account");
				}
				return _recycleVendorService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceLocationEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceLocationEntity))]
		public virtual EntityCollection<ServiceLocationEntity> ServiceLocation
		{
			get
			{
				if(_serviceLocation==null)
				{
					_serviceLocation = new EntityCollection<ServiceLocationEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceLocationEntityFactory)));
					_serviceLocation.SetContainingEntityInfo(this, "Account");
				}
				return _serviceLocation;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserAccountEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserAccountEntity))]
		public virtual EntityCollection<UserAccountEntity> UserAccount
		{
			get
			{
				if(_userAccount==null)
				{
					_userAccount = new EntityCollection<UserAccountEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserAccountEntityFactory)));
					_userAccount.SetContainingEntityInfo(this, "Account");
				}
				return _userAccount;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEntity' which are related to this entity via a relation of type '1:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(WorkOrderEntity))]
		public virtual EntityCollection<WorkOrderEntity> WorkOrder
		{
			get
			{
				if(_workOrder==null)
				{
					_workOrder = new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory)));
					_workOrder.SetContainingEntityInfo(this, "Account");
				}
				return _workOrder;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DockEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(DockEntity))]
		public virtual EntityCollection<DockEntity> DockCollectionViaBale
		{
			get
			{
				if(_dockCollectionViaBale==null)
				{
					_dockCollectionViaBale = new EntityCollection<DockEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DockEntityFactory)));
					_dockCollectionViaBale.IsReadOnly=true;
				}
				return _dockCollectionViaBale;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaAccountEmployeeAssignment_____
		{
			get
			{
				if(_employeeCollectionViaAccountEmployeeAssignment_____==null)
				{
					_employeeCollectionViaAccountEmployeeAssignment_____ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaAccountEmployeeAssignment_____.IsReadOnly=true;
				}
				return _employeeCollectionViaAccountEmployeeAssignment_____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaAccountEmployeeAssignment______
		{
			get
			{
				if(_employeeCollectionViaAccountEmployeeAssignment______==null)
				{
					_employeeCollectionViaAccountEmployeeAssignment______ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaAccountEmployeeAssignment______.IsReadOnly=true;
				}
				return _employeeCollectionViaAccountEmployeeAssignment______;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaWorkOrder
		{
			get
			{
				if(_employeeCollectionViaWorkOrder==null)
				{
					_employeeCollectionViaWorkOrder = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaWorkOrder.IsReadOnly=true;
				}
				return _employeeCollectionViaWorkOrder;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaAccountEmployeeAssignment____
		{
			get
			{
				if(_employeeCollectionViaAccountEmployeeAssignment____==null)
				{
					_employeeCollectionViaAccountEmployeeAssignment____ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaAccountEmployeeAssignment____.IsReadOnly=true;
				}
				return _employeeCollectionViaAccountEmployeeAssignment____;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaAccountEmployeeAssignment_
		{
			get
			{
				if(_employeeCollectionViaAccountEmployeeAssignment_==null)
				{
					_employeeCollectionViaAccountEmployeeAssignment_ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaAccountEmployeeAssignment_.IsReadOnly=true;
				}
				return _employeeCollectionViaAccountEmployeeAssignment_;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaAccountEmployeeAssignment
		{
			get
			{
				if(_employeeCollectionViaAccountEmployeeAssignment==null)
				{
					_employeeCollectionViaAccountEmployeeAssignment = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaAccountEmployeeAssignment.IsReadOnly=true;
				}
				return _employeeCollectionViaAccountEmployeeAssignment;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaAccountEmployeeAssignment___
		{
			get
			{
				if(_employeeCollectionViaAccountEmployeeAssignment___==null)
				{
					_employeeCollectionViaAccountEmployeeAssignment___ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaAccountEmployeeAssignment___.IsReadOnly=true;
				}
				return _employeeCollectionViaAccountEmployeeAssignment___;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaAccountEmployeeAssignment__
		{
			get
			{
				if(_employeeCollectionViaAccountEmployeeAssignment__==null)
				{
					_employeeCollectionViaAccountEmployeeAssignment__ = new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory)));
					_employeeCollectionViaAccountEmployeeAssignment__.IsReadOnly=true;
				}
				return _employeeCollectionViaAccountEmployeeAssignment__;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RebateTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RebateTypeEntity))]
		public virtual EntityCollection<RebateTypeEntity> RebateTypeCollectionViaRebate
		{
			get
			{
				if(_rebateTypeCollectionViaRebate==null)
				{
					_rebateTypeCollectionViaRebate = new EntityCollection<RebateTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RebateTypeEntityFactory)));
					_rebateTypeCollectionViaRebate.IsReadOnly=true;
				}
				return _rebateTypeCollectionViaRebate;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleTypeEntity))]
		public virtual EntityCollection<RecycleTypeEntity> RecycleTypeCollectionViaRecycleVendorService
		{
			get
			{
				if(_recycleTypeCollectionViaRecycleVendorService==null)
				{
					_recycleTypeCollectionViaRecycleVendorService = new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory)));
					_recycleTypeCollectionViaRecycleVendorService.IsReadOnly=true;
				}
				return _recycleTypeCollectionViaRecycleVendorService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleTypeEntity))]
		public virtual EntityCollection<RecycleTypeEntity> RecycleTypeCollectionViaBale
		{
			get
			{
				if(_recycleTypeCollectionViaBale==null)
				{
					_recycleTypeCollectionViaBale = new EntityCollection<RecycleTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleTypeEntityFactory)));
					_recycleTypeCollectionViaBale.IsReadOnly=true;
				}
				return _recycleTypeCollectionViaBale;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RecycleVendorEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(RecycleVendorEntity))]
		public virtual EntityCollection<RecycleVendorEntity> RecycleVendorCollectionViaRecycleVendorService
		{
			get
			{
				if(_recycleVendorCollectionViaRecycleVendorService==null)
				{
					_recycleVendorCollectionViaRecycleVendorService = new EntityCollection<RecycleVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RecycleVendorEntityFactory)));
					_recycleVendorCollectionViaRecycleVendorService.IsReadOnly=true;
				}
				return _recycleVendorCollectionViaRecycleVendorService;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceTypeEntity))]
		public virtual EntityCollection<ServiceTypeEntity> ServiceTypeCollectionViaWorkOrder
		{
			get
			{
				if(_serviceTypeCollectionViaWorkOrder==null)
				{
					_serviceTypeCollectionViaWorkOrder = new EntityCollection<ServiceTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory)));
					_serviceTypeCollectionViaWorkOrder.IsReadOnly=true;
				}
				return _serviceTypeCollectionViaWorkOrder;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ServiceTypeEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(ServiceTypeEntity))]
		public virtual EntityCollection<ServiceTypeEntity> ServiceTypeCollectionViaServiceLocation
		{
			get
			{
				if(_serviceTypeCollectionViaServiceLocation==null)
				{
					_serviceTypeCollectionViaServiceLocation = new EntityCollection<ServiceTypeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ServiceTypeEntityFactory)));
					_serviceTypeCollectionViaServiceLocation.IsReadOnly=true;
				}
				return _serviceTypeCollectionViaServiceLocation;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaRebate
		{
			get
			{
				if(_userCollectionViaRebate==null)
				{
					_userCollectionViaRebate = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaRebate.IsReadOnly=true;
				}
				return _userCollectionViaRebate;
			}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'UserEntity' which are related to this entity via a relation of type 'm:n'.
		/// If the EntityCollection hasn't been fetched yet, the collection returned will be empty.</summary>
		[TypeContainedAttribute(typeof(UserEntity))]
		public virtual EntityCollection<UserEntity> UserCollectionViaUserAccount
		{
			get
			{
				if(_userCollectionViaUserAccount==null)
				{
					_userCollectionViaUserAccount = new EntityCollection<UserEntity>(EntityFactoryCache2.GetEntityFactory(typeof(UserEntityFactory)));
					_userCollectionViaUserAccount.IsReadOnly=true;
				}
				return _userCollectionViaUserAccount;
			}
		}


	
		
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the Reliant.RenuOil.DAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)Reliant.RenuOil.DAL.EntityType.AccountEntity; }
		}
		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
