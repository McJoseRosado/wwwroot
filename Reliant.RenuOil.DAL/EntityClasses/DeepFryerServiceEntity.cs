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
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using Reliant.RenuOil.DAL;
using Reliant.RenuOil.DAL.FactoryClasses;
using Reliant.RenuOil.DAL.DaoClasses;
using Reliant.RenuOil.DAL.RelationClasses;
using Reliant.RenuOil.DAL.HelperClasses;
using Reliant.RenuOil.DAL.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Reliant.RenuOil.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'DeepFryerService'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DeepFryerServiceEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection	_deepFryerServiceChangeLog;
		private bool	_alwaysFetchDeepFryerServiceChangeLog, _alreadyFetchedDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaDeepFryerServiceChangeLog_;
		private bool	_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_, _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_;
		private Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection _employeeCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection _serviceLocationCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog;
		private Reliant.RenuOil.DAL.CollectionClasses.UserCollection _userCollectionViaDeepFryerServiceChangeLog;
		private bool	_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog, _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog;
		private DeepFryerEntity _deepFryer;
		private bool	_alwaysFetchDeepFryer, _alreadyFetchedDeepFryer, _deepFryerReturnsNewIfNotFound;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee, _employeeReturnsNewIfNotFound;
		private ServiceLocationEntity _serviceLocation;
		private bool	_alwaysFetchServiceLocation, _alreadyFetchedServiceLocation, _serviceLocationReturnsNewIfNotFound;
		private WorkOrderEmployeeEntity _workOrderEmployee;
		private bool	_alwaysFetchWorkOrderEmployee, _alreadyFetchedWorkOrderEmployee, _workOrderEmployeeReturnsNewIfNotFound;
		private WorkOrderServiceLocationEntity _workOrderServiceLocation;
		private bool	_alwaysFetchWorkOrderServiceLocation, _alreadyFetchedWorkOrderServiceLocation, _workOrderServiceLocationReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name DeepFryer</summary>
			public static readonly string DeepFryer = "DeepFryer";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name ServiceLocation</summary>
			public static readonly string ServiceLocation = "ServiceLocation";
			/// <summary>Member name WorkOrderEmployee</summary>
			public static readonly string WorkOrderEmployee = "WorkOrderEmployee";
			/// <summary>Member name WorkOrderServiceLocation</summary>
			public static readonly string WorkOrderServiceLocation = "WorkOrderServiceLocation";
			/// <summary>Member name DeepFryerServiceChangeLog</summary>
			public static readonly string DeepFryerServiceChangeLog = "DeepFryerServiceChangeLog";
			/// <summary>Member name EmployeeCollectionViaDeepFryerServiceChangeLog_</summary>
			public static readonly string EmployeeCollectionViaDeepFryerServiceChangeLog_ = "EmployeeCollectionViaDeepFryerServiceChangeLog_";
			/// <summary>Member name EmployeeCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string EmployeeCollectionViaDeepFryerServiceChangeLog = "EmployeeCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name ServiceLocationCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string ServiceLocationCollectionViaDeepFryerServiceChangeLog = "ServiceLocationCollectionViaDeepFryerServiceChangeLog";
			/// <summary>Member name UserCollectionViaDeepFryerServiceChangeLog</summary>
			public static readonly string UserCollectionViaDeepFryerServiceChangeLog = "UserCollectionViaDeepFryerServiceChangeLog";

		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DeepFryerServiceEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public DeepFryerServiceEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		public DeepFryerServiceEntity(System.Int32 deepFryerServiceId)
		{
			InitClassFetch(deepFryerServiceId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public DeepFryerServiceEntity(System.Int32 deepFryerServiceId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(deepFryerServiceId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		/// <param name="validator">The custom validator object for this DeepFryerServiceEntity</param>
		public DeepFryerServiceEntity(System.Int32 deepFryerServiceId, IValidator validator)
		{
			InitClassFetch(deepFryerServiceId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DeepFryerServiceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_deepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection)info.GetValue("_deepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection));
			_alwaysFetchDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchDeepFryerServiceChangeLog");
			_alreadyFetchedDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedDeepFryerServiceChangeLog");
			_employeeCollectionViaDeepFryerServiceChangeLog_ = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog_", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_");
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_");
			_employeeCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection)info.GetValue("_employeeCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection));
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog");
			_serviceLocationCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection)info.GetValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection));
			_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog");
			_userCollectionViaDeepFryerServiceChangeLog = (Reliant.RenuOil.DAL.CollectionClasses.UserCollection)info.GetValue("_userCollectionViaDeepFryerServiceChangeLog", typeof(Reliant.RenuOil.DAL.CollectionClasses.UserCollection));
			_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog");
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = info.GetBoolean("_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog");
			_deepFryer = (DeepFryerEntity)info.GetValue("_deepFryer", typeof(DeepFryerEntity));
			if(_deepFryer!=null)
			{
				_deepFryer.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_deepFryerReturnsNewIfNotFound = info.GetBoolean("_deepFryerReturnsNewIfNotFound");
			_alwaysFetchDeepFryer = info.GetBoolean("_alwaysFetchDeepFryer");
			_alreadyFetchedDeepFryer = info.GetBoolean("_alreadyFetchedDeepFryer");
			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_employeeReturnsNewIfNotFound = info.GetBoolean("_employeeReturnsNewIfNotFound");
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");
			_serviceLocation = (ServiceLocationEntity)info.GetValue("_serviceLocation", typeof(ServiceLocationEntity));
			if(_serviceLocation!=null)
			{
				_serviceLocation.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_serviceLocationReturnsNewIfNotFound = info.GetBoolean("_serviceLocationReturnsNewIfNotFound");
			_alwaysFetchServiceLocation = info.GetBoolean("_alwaysFetchServiceLocation");
			_alreadyFetchedServiceLocation = info.GetBoolean("_alreadyFetchedServiceLocation");
			_workOrderEmployee = (WorkOrderEmployeeEntity)info.GetValue("_workOrderEmployee", typeof(WorkOrderEmployeeEntity));
			if(_workOrderEmployee!=null)
			{
				_workOrderEmployee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_workOrderEmployeeReturnsNewIfNotFound = info.GetBoolean("_workOrderEmployeeReturnsNewIfNotFound");
			_alwaysFetchWorkOrderEmployee = info.GetBoolean("_alwaysFetchWorkOrderEmployee");
			_alreadyFetchedWorkOrderEmployee = info.GetBoolean("_alreadyFetchedWorkOrderEmployee");
			_workOrderServiceLocation = (WorkOrderServiceLocationEntity)info.GetValue("_workOrderServiceLocation", typeof(WorkOrderServiceLocationEntity));
			if(_workOrderServiceLocation!=null)
			{
				_workOrderServiceLocation.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_workOrderServiceLocationReturnsNewIfNotFound = info.GetBoolean("_workOrderServiceLocationReturnsNewIfNotFound");
			_alwaysFetchWorkOrderServiceLocation = info.GetBoolean("_alwaysFetchWorkOrderServiceLocation");
			_alreadyFetchedWorkOrderServiceLocation = info.GetBoolean("_alreadyFetchedWorkOrderServiceLocation");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((DeepFryerServiceFieldIndex)fieldIndex)
			{
				case DeepFryerServiceFieldIndex.DeepFryerId:
					DesetupSyncDeepFryer(true, false);
					_alreadyFetchedDeepFryer = false;
					break;
				case DeepFryerServiceFieldIndex.WorkOrderServiceLocationId:
					DesetupSyncWorkOrderEmployee(true, false);
					_alreadyFetchedWorkOrderEmployee = false;
					DesetupSyncWorkOrderServiceLocation(true, false);
					_alreadyFetchedWorkOrderServiceLocation = false;
					break;
				case DeepFryerServiceFieldIndex.RelocatedToServiceLocationId:
					DesetupSyncServiceLocation(true, false);
					_alreadyFetchedServiceLocation = false;
					break;
				case DeepFryerServiceFieldIndex.Servicedby:
					DesetupSyncEmployee(true, false);
					_alreadyFetchedEmployee = false;
					break;
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
		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedDeepFryerServiceChangeLog = (_deepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = (_employeeCollectionViaDeepFryerServiceChangeLog_.Count > 0);
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = (_employeeCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = (_serviceLocationCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = (_userCollectionViaDeepFryerServiceChangeLog.Count > 0);
			_alreadyFetchedDeepFryer = (_deepFryer != null);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedServiceLocation = (_serviceLocation != null);
			_alreadyFetchedWorkOrderEmployee = (_workOrderEmployee != null);
			_alreadyFetchedWorkOrderServiceLocation = (_workOrderServiceLocation != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return DeepFryerServiceEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "DeepFryer":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId);
					break;
				case "Employee":
					toReturn.Add(DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby);
					break;
				case "ServiceLocation":
					toReturn.Add(DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId);
					break;
				case "WorkOrderEmployee":
					toReturn.Add(DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);
					break;
				case "WorkOrderServiceLocation":
					toReturn.Add(DeepFryerServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);
					break;
				case "DeepFryerServiceChangeLog":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId);
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog_":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId, "DeepFryerServiceEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingServicedBy, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId, "DeepFryerServiceEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.EmployeeEntityUsingEnteredByEmployeeId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId, "DeepFryerServiceEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog":
					toReturn.Add(DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId, "DeepFryerServiceEntity__", "DeepFryerServiceChangeLog_", JoinHint.None);
					toReturn.Add(DeepFryerServiceChangeLogEntity.Relations.UserEntityUsingEnteredByUserId, "DeepFryerServiceChangeLog_", string.Empty, JoinHint.None);
					break;

				default:

					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_deepFryerServiceChangeLog", (!this.MarkedForDeletion?_deepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchDeepFryerServiceChangeLog", _alwaysFetchDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedDeepFryerServiceChangeLog", _alreadyFetchedDeepFryerServiceChangeLog);
			info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog_", (!this.MarkedForDeletion?_employeeCollectionViaDeepFryerServiceChangeLog_:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_", _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_", _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_);
			info.AddValue("_employeeCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_employeeCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog", _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_serviceLocationCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_serviceLocationCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog", _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_userCollectionViaDeepFryerServiceChangeLog", (!this.MarkedForDeletion?_userCollectionViaDeepFryerServiceChangeLog:null));
			info.AddValue("_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog", _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog", _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog);
			info.AddValue("_deepFryer", (!this.MarkedForDeletion?_deepFryer:null));
			info.AddValue("_deepFryerReturnsNewIfNotFound", _deepFryerReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchDeepFryer", _alwaysFetchDeepFryer);
			info.AddValue("_alreadyFetchedDeepFryer", _alreadyFetchedDeepFryer);
			info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			info.AddValue("_employeeReturnsNewIfNotFound", _employeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_serviceLocation", (!this.MarkedForDeletion?_serviceLocation:null));
			info.AddValue("_serviceLocationReturnsNewIfNotFound", _serviceLocationReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchServiceLocation", _alwaysFetchServiceLocation);
			info.AddValue("_alreadyFetchedServiceLocation", _alreadyFetchedServiceLocation);
			info.AddValue("_workOrderEmployee", (!this.MarkedForDeletion?_workOrderEmployee:null));
			info.AddValue("_workOrderEmployeeReturnsNewIfNotFound", _workOrderEmployeeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchWorkOrderEmployee", _alwaysFetchWorkOrderEmployee);
			info.AddValue("_alreadyFetchedWorkOrderEmployee", _alreadyFetchedWorkOrderEmployee);
			info.AddValue("_workOrderServiceLocation", (!this.MarkedForDeletion?_workOrderServiceLocation:null));
			info.AddValue("_workOrderServiceLocationReturnsNewIfNotFound", _workOrderServiceLocationReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchWorkOrderServiceLocation", _alwaysFetchWorkOrderServiceLocation);
			info.AddValue("_alreadyFetchedWorkOrderServiceLocation", _alreadyFetchedWorkOrderServiceLocation);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "DeepFryer":
					_alreadyFetchedDeepFryer = true;
					this.DeepFryer = (DeepFryerEntity)entity;
					break;
				case "Employee":
					_alreadyFetchedEmployee = true;
					this.Employee = (EmployeeEntity)entity;
					break;
				case "ServiceLocation":
					_alreadyFetchedServiceLocation = true;
					this.ServiceLocation = (ServiceLocationEntity)entity;
					break;
				case "WorkOrderEmployee":
					_alreadyFetchedWorkOrderEmployee = true;
					this.WorkOrderEmployee = (WorkOrderEmployeeEntity)entity;
					break;
				case "WorkOrderServiceLocation":
					_alreadyFetchedWorkOrderServiceLocation = true;
					this.WorkOrderServiceLocation = (WorkOrderServiceLocationEntity)entity;
					break;
				case "DeepFryerServiceChangeLog":
					_alreadyFetchedDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.DeepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)entity);
					}
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog_":
					_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaDeepFryerServiceChangeLog_.Add((EmployeeEntity)entity);
					}
					break;
				case "EmployeeCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.EmployeeCollectionViaDeepFryerServiceChangeLog.Add((EmployeeEntity)entity);
					}
					break;
				case "ServiceLocationCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.ServiceLocationCollectionViaDeepFryerServiceChangeLog.Add((ServiceLocationEntity)entity);
					}
					break;
				case "UserCollectionViaDeepFryerServiceChangeLog":
					_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = true;
					if(entity!=null)
					{
						this.UserCollectionViaDeepFryerServiceChangeLog.Add((UserEntity)entity);
					}
					break;

				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "DeepFryer":
					SetupSyncDeepFryer(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "ServiceLocation":
					SetupSyncServiceLocation(relatedEntity);
					break;
				case "WorkOrderEmployee":
					SetupSyncWorkOrderEmployee(relatedEntity);
					break;
				case "WorkOrderServiceLocation":
					SetupSyncWorkOrderServiceLocation(relatedEntity);
					break;
				case "DeepFryerServiceChangeLog":
					_deepFryerServiceChangeLog.Add((DeepFryerServiceChangeLogEntity)relatedEntity);
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
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "DeepFryer":
					DesetupSyncDeepFryer(false, true);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "ServiceLocation":
					DesetupSyncServiceLocation(false, true);
					break;
				case "WorkOrderEmployee":
					DesetupSyncWorkOrderEmployee(false, true);
					break;
				case "WorkOrderServiceLocation":
					DesetupSyncWorkOrderServiceLocation(false, true);
					break;
				case "DeepFryerServiceChangeLog":
					base.PerformRelatedEntityRemoval(_deepFryerServiceChangeLog, relatedEntity, signalRelatedEntityManyToOne);
					break;

				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_deepFryer!=null)
			{
				toReturn.Add(_deepFryer);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_serviceLocation!=null)
			{
				toReturn.Add(_serviceLocation);
			}
			if(_workOrderEmployee!=null)
			{
				toReturn.Add(_workOrderEmployee);
			}
			if(_workOrderServiceLocation!=null)
			{
				toReturn.Add(_workOrderServiceLocation);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_deepFryerServiceChangeLog);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerServiceId)
		{
			return FetchUsingPK(deepFryerServiceId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerServiceId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(deepFryerServiceId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(deepFryerServiceId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 deepFryerServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(deepFryerServiceId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DeepFryerServiceId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(DeepFryerServiceFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(DeepFryerServiceFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new DeepFryerServiceRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerServiceChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog(bool forceFetch)
		{
			return GetMultiDeepFryerServiceChangeLog(forceFetch, _deepFryerServiceChangeLog.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'DeepFryerServiceChangeLogEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiDeepFryerServiceChangeLog(forceFetch, _deepFryerServiceChangeLog.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiDeepFryerServiceChangeLog(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection GetMultiDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedDeepFryerServiceChangeLog || forceFetch || _alwaysFetchDeepFryerServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_deepFryerServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_deepFryerServiceChangeLog);
					}
				}
				_deepFryerServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_deepFryerServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_deepFryerServiceChangeLog.GetMultiManyToOne(this, null, null, null, null, filter);
				_deepFryerServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedDeepFryerServiceChangeLog = true;
			}
			return _deepFryerServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'DeepFryerServiceChangeLog'. These settings will be taken into account
		/// when the property DeepFryerServiceChangeLog is requested or GetMultiDeepFryerServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDeepFryerServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_deepFryerServiceChangeLog.SortClauses=sortClauses;
			_deepFryerServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_(forceFetch, _employeeCollectionViaDeepFryerServiceChangeLog_.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ || forceFetch || _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaDeepFryerServiceChangeLog_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaDeepFryerServiceChangeLog_);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.DeepFryerServiceId, ComparisonOperator.Equal, this.DeepFryerServiceId, "DeepFryerServiceEntity__"));
				_employeeCollectionViaDeepFryerServiceChangeLog_.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaDeepFryerServiceChangeLog_.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaDeepFryerServiceChangeLog_.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog_"));
				_employeeCollectionViaDeepFryerServiceChangeLog_.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = true;
			}
			return _employeeCollectionViaDeepFryerServiceChangeLog_;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaDeepFryerServiceChangeLog_'. These settings will be taken into account
		/// when the property EmployeeCollectionViaDeepFryerServiceChangeLog_ is requested or GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_ is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaDeepFryerServiceChangeLog_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaDeepFryerServiceChangeLog_.SortClauses=sortClauses;
			_employeeCollectionViaDeepFryerServiceChangeLog_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog(bool forceFetch)
		{
			return GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog(forceFetch, _employeeCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog || forceFetch || _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeCollectionViaDeepFryerServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeCollectionViaDeepFryerServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.DeepFryerServiceId, ComparisonOperator.Equal, this.DeepFryerServiceId, "DeepFryerServiceEntity__"));
				_employeeCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_employeeCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_employeeCollectionViaDeepFryerServiceChangeLog.GetMulti(filter, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog"));
				_employeeCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = true;
			}
			return _employeeCollectionViaDeepFryerServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'EmployeeCollectionViaDeepFryerServiceChangeLog'. These settings will be taken into account
		/// when the property EmployeeCollectionViaDeepFryerServiceChangeLog is requested or GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeCollectionViaDeepFryerServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeCollectionViaDeepFryerServiceChangeLog.SortClauses=sortClauses;
			_employeeCollectionViaDeepFryerServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ServiceLocationEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog(bool forceFetch)
		{
			return GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog(forceFetch, _serviceLocationCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog || forceFetch || _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_serviceLocationCollectionViaDeepFryerServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_serviceLocationCollectionViaDeepFryerServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.DeepFryerServiceId, ComparisonOperator.Equal, this.DeepFryerServiceId, "DeepFryerServiceEntity__"));
				_serviceLocationCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_serviceLocationCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_serviceLocationCollectionViaDeepFryerServiceChangeLog.GetMulti(filter, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog"));
				_serviceLocationCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = true;
			}
			return _serviceLocationCollectionViaDeepFryerServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'ServiceLocationCollectionViaDeepFryerServiceChangeLog'. These settings will be taken into account
		/// when the property ServiceLocationCollectionViaDeepFryerServiceChangeLog is requested or GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersServiceLocationCollectionViaDeepFryerServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_serviceLocationCollectionViaDeepFryerServiceChangeLog.SortClauses=sortClauses;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UserEntity'</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaDeepFryerServiceChangeLog(bool forceFetch)
		{
			return GetMultiUserCollectionViaDeepFryerServiceChangeLog(forceFetch, _userCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse);
		}

		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Reliant.RenuOil.DAL.CollectionClasses.UserCollection GetMultiUserCollectionViaDeepFryerServiceChangeLog(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog || forceFetch || _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_userCollectionViaDeepFryerServiceChangeLog.ParticipatesInTransaction)
					{
						base.Transaction.Add(_userCollectionViaDeepFryerServiceChangeLog);
					}
				}
				IPredicateExpression filter = new PredicateExpression();
				filter.Add(new FieldCompareValuePredicate(DeepFryerServiceFields.DeepFryerServiceId, ComparisonOperator.Equal, this.DeepFryerServiceId, "DeepFryerServiceEntity__"));
				_userCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_userCollectionViaDeepFryerServiceChangeLog.EntityFactoryToUse = entityFactoryToUse;
				}
				_userCollectionViaDeepFryerServiceChangeLog.GetMulti(filter, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog"));
				_userCollectionViaDeepFryerServiceChangeLog.SuppressClearInGetMulti=false;
				_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = true;
			}
			return _userCollectionViaDeepFryerServiceChangeLog;
		}

		/// <summary> Sets the collection parameters for the collection for 'UserCollectionViaDeepFryerServiceChangeLog'. These settings will be taken into account
		/// when the property UserCollectionViaDeepFryerServiceChangeLog is requested or GetMultiUserCollectionViaDeepFryerServiceChangeLog is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUserCollectionViaDeepFryerServiceChangeLog(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_userCollectionViaDeepFryerServiceChangeLog.SortClauses=sortClauses;
			_userCollectionViaDeepFryerServiceChangeLog.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'DeepFryerEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'DeepFryerEntity' which is related to this entity.</returns>
		public DeepFryerEntity GetSingleDeepFryer()
		{
			return GetSingleDeepFryer(false);
		}

		/// <summary> Retrieves the related entity of type 'DeepFryerEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'DeepFryerEntity' which is related to this entity.</returns>
		public virtual DeepFryerEntity GetSingleDeepFryer(bool forceFetch)
		{
			if( ( !_alreadyFetchedDeepFryer || forceFetch || _alwaysFetchDeepFryer) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId);

				DeepFryerEntity newEntity = new DeepFryerEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.DeepFryerId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (DeepFryerEntity)base.ActiveContext.Get(newEntity);
					}
					this.DeepFryer = newEntity;
				}
				else
				{
					if(_deepFryerReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_deepFryer == null)))
						{
							this.DeepFryer = newEntity;
						}
					}
					else
					{
						this.DeepFryer = null;
					}
				}
				_alreadyFetchedDeepFryer = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _deepFryer;
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public EmployeeEntity GetSingleEmployee()
		{
			return GetSingleEmployee(false);
		}

		/// <summary> Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee(bool forceFetch)
		{
			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby);

				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.Servicedby.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (EmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.Employee = newEntity;
				}
				else
				{
					if(_employeeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_employee == null)))
						{
							this.Employee = newEntity;
						}
					}
					else
					{
						this.Employee = null;
					}
				}
				_alreadyFetchedEmployee = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _employee;
		}

		/// <summary> Retrieves the related entity of type 'ServiceLocationEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ServiceLocationEntity' which is related to this entity.</returns>
		public ServiceLocationEntity GetSingleServiceLocation()
		{
			return GetSingleServiceLocation(false);
		}

		/// <summary> Retrieves the related entity of type 'ServiceLocationEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ServiceLocationEntity' which is related to this entity.</returns>
		public virtual ServiceLocationEntity GetSingleServiceLocation(bool forceFetch)
		{
			if( ( !_alreadyFetchedServiceLocation || forceFetch || _alwaysFetchServiceLocation) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId);

				ServiceLocationEntity newEntity = new ServiceLocationEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.RelocatedToServiceLocationId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ServiceLocationEntity)base.ActiveContext.Get(newEntity);
					}
					this.ServiceLocation = newEntity;
				}
				else
				{
					if(_serviceLocationReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_serviceLocation == null)))
						{
							this.ServiceLocation = newEntity;
						}
					}
					else
					{
						this.ServiceLocation = null;
					}
				}
				_alreadyFetchedServiceLocation = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _serviceLocation;
		}

		/// <summary> Retrieves the related entity of type 'WorkOrderEmployeeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'WorkOrderEmployeeEntity' which is related to this entity.</returns>
		public WorkOrderEmployeeEntity GetSingleWorkOrderEmployee()
		{
			return GetSingleWorkOrderEmployee(false);
		}

		/// <summary> Retrieves the related entity of type 'WorkOrderEmployeeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'WorkOrderEmployeeEntity' which is related to this entity.</returns>
		public virtual WorkOrderEmployeeEntity GetSingleWorkOrderEmployee(bool forceFetch)
		{
			if( ( !_alreadyFetchedWorkOrderEmployee || forceFetch || _alwaysFetchWorkOrderEmployee) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId);

				WorkOrderEmployeeEntity newEntity = new WorkOrderEmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.WorkOrderServiceLocationId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (WorkOrderEmployeeEntity)base.ActiveContext.Get(newEntity);
					}
					this.WorkOrderEmployee = newEntity;
				}
				else
				{
					if(_workOrderEmployeeReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_workOrderEmployee == null)))
						{
							this.WorkOrderEmployee = newEntity;
						}
					}
					else
					{
						this.WorkOrderEmployee = null;
					}
				}
				_alreadyFetchedWorkOrderEmployee = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _workOrderEmployee;
		}

		/// <summary> Retrieves the related entity of type 'WorkOrderServiceLocationEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'WorkOrderServiceLocationEntity' which is related to this entity.</returns>
		public WorkOrderServiceLocationEntity GetSingleWorkOrderServiceLocation()
		{
			return GetSingleWorkOrderServiceLocation(false);
		}

		/// <summary> Retrieves the related entity of type 'WorkOrderServiceLocationEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'WorkOrderServiceLocationEntity' which is related to this entity.</returns>
		public virtual WorkOrderServiceLocationEntity GetSingleWorkOrderServiceLocation(bool forceFetch)
		{
			if( ( !_alreadyFetchedWorkOrderServiceLocation || forceFetch || _alwaysFetchWorkOrderServiceLocation) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(DeepFryerServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId);

				WorkOrderServiceLocationEntity newEntity = new WorkOrderServiceLocationEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.WorkOrderServiceLocationId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (WorkOrderServiceLocationEntity)base.ActiveContext.Get(newEntity);
					}
					this.WorkOrderServiceLocation = newEntity;
				}
				else
				{
					if(_workOrderServiceLocationReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_workOrderServiceLocation == null)))
						{
							this.WorkOrderServiceLocation = newEntity;
						}
					}
					else
					{
						this.WorkOrderServiceLocation = null;
					}
				}
				_alreadyFetchedWorkOrderServiceLocation = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _workOrderServiceLocation;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			DeepFryerServiceDAO dao = (DeepFryerServiceDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_deepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_employeeCollectionViaDeepFryerServiceChangeLog_.ActiveContext = base.ActiveContext;
			_employeeCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			_userCollectionViaDeepFryerServiceChangeLog.ActiveContext = base.ActiveContext;
			if(_deepFryer!=null)
			{
				_deepFryer.ActiveContext = base.ActiveContext;
			}
			if(_employee!=null)
			{
				_employee.ActiveContext = base.ActiveContext;
			}
			if(_serviceLocation!=null)
			{
				_serviceLocation.ActiveContext = base.ActiveContext;
			}
			if(_workOrderEmployee!=null)
			{
				_workOrderEmployee.ActiveContext = base.ActiveContext;
			}
			if(_workOrderServiceLocation!=null)
			{
				_workOrderServiceLocation.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			DeepFryerServiceDAO dao = (DeepFryerServiceDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			DeepFryerServiceDAO dao = (DeepFryerServiceDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity);
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("DeepFryer", _deepFryer);
			toReturn.Add("Employee", _employee);
			toReturn.Add("ServiceLocation", _serviceLocation);
			toReturn.Add("WorkOrderEmployee", _workOrderEmployee);
			toReturn.Add("WorkOrderServiceLocation", _workOrderServiceLocation);
			toReturn.Add("DeepFryerServiceChangeLog", _deepFryerServiceChangeLog);
			toReturn.Add("EmployeeCollectionViaDeepFryerServiceChangeLog_", _employeeCollectionViaDeepFryerServiceChangeLog_);
			toReturn.Add("EmployeeCollectionViaDeepFryerServiceChangeLog", _employeeCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("ServiceLocationCollectionViaDeepFryerServiceChangeLog", _serviceLocationCollectionViaDeepFryerServiceChangeLog);
			toReturn.Add("UserCollectionViaDeepFryerServiceChangeLog", _userCollectionViaDeepFryerServiceChangeLog);

			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		/// <param name="validator">The validator object for this DeepFryerServiceEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 deepFryerServiceId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(deepFryerServiceId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_deepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection(new DeepFryerServiceChangeLogEntityFactory());
			_deepFryerServiceChangeLog.SetContainingEntityInfo(this, "DeepFryerService");
			_alwaysFetchDeepFryerServiceChangeLog = false;
			_alreadyFetchedDeepFryerServiceChangeLog = false;
			_employeeCollectionViaDeepFryerServiceChangeLog_ = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_ = false;
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = false;
			_employeeCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(new EmployeeEntityFactory());
			_alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = false;
			_serviceLocationCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(new ServiceLocationEntityFactory());
			_alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = false;
			_userCollectionViaDeepFryerServiceChangeLog = new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(new UserEntityFactory());
			_alwaysFetchUserCollectionViaDeepFryerServiceChangeLog = false;
			_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = false;
			_deepFryer = null;
			_deepFryerReturnsNewIfNotFound = true;
			_alwaysFetchDeepFryer = false;
			_alreadyFetchedDeepFryer = false;
			_employee = null;
			_employeeReturnsNewIfNotFound = true;
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_serviceLocation = null;
			_serviceLocationReturnsNewIfNotFound = true;
			_alwaysFetchServiceLocation = false;
			_alreadyFetchedServiceLocation = false;
			_workOrderEmployee = null;
			_workOrderEmployeeReturnsNewIfNotFound = true;
			_alwaysFetchWorkOrderEmployee = false;
			_alreadyFetchedWorkOrderEmployee = false;
			_workOrderServiceLocation = null;
			_workOrderServiceLocationReturnsNewIfNotFound = true;
			_alwaysFetchWorkOrderServiceLocation = false;
			_alreadyFetchedWorkOrderServiceLocation = false;


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

			_fieldsCustomProperties.Add("DeepFryerServiceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DeepFryerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("WorkOrderServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Filtered", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Discarded", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Relocated", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Cleaned", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RelocatedToFryerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RelocatedToServiceLocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("RelocatedToOther", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("AssignedTo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Servicedby", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NoService", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _deepFryer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncDeepFryer(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _deepFryer, new PropertyChangedEventHandler( OnDeepFryerPropertyChanged ), "DeepFryer", DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId, true, signalRelatedEntity, "DeepFryerService", resetFKFields, new int[] { (int)DeepFryerServiceFieldIndex.DeepFryerId } );		
			_deepFryer = null;
		}
		
		/// <summary> setups the sync logic for member _deepFryer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDeepFryer(IEntity relatedEntity)
		{
			if(_deepFryer!=relatedEntity)
			{		
				DesetupSyncDeepFryer(true, true);
				_deepFryer = (DeepFryerEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _deepFryer, new PropertyChangedEventHandler( OnDeepFryerPropertyChanged ), "DeepFryer", DeepFryerServiceEntity.Relations.DeepFryerEntityUsingDeepFryerId, true, ref _alreadyFetchedDeepFryer, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDeepFryerPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby, true, signalRelatedEntity, "DeepFryerService", resetFKFields, new int[] { (int)DeepFryerServiceFieldIndex.Servicedby } );		
			_employee = null;
		}
		
		/// <summary> setups the sync logic for member _employee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntity relatedEntity)
		{
			if(_employee!=relatedEntity)
			{		
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", DeepFryerServiceEntity.Relations.EmployeeEntityUsingServicedby, true, ref _alreadyFetchedEmployee, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _serviceLocation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncServiceLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, true, signalRelatedEntity, "DeepFryerService", resetFKFields, new int[] { (int)DeepFryerServiceFieldIndex.RelocatedToServiceLocationId } );		
			_serviceLocation = null;
		}
		
		/// <summary> setups the sync logic for member _serviceLocation</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncServiceLocation(IEntity relatedEntity)
		{
			if(_serviceLocation!=relatedEntity)
			{		
				DesetupSyncServiceLocation(true, true);
				_serviceLocation = (ServiceLocationEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _serviceLocation, new PropertyChangedEventHandler( OnServiceLocationPropertyChanged ), "ServiceLocation", DeepFryerServiceEntity.Relations.ServiceLocationEntityUsingRelocatedToServiceLocationId, true, ref _alreadyFetchedServiceLocation, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnServiceLocationPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _workOrderEmployee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrderEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "DeepFryerService", resetFKFields, new int[] { (int)DeepFryerServiceFieldIndex.WorkOrderServiceLocationId } );		
			_workOrderEmployee = null;
		}
		
		/// <summary> setups the sync logic for member _workOrderEmployee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrderEmployee(IEntity relatedEntity)
		{
			if(_workOrderEmployee!=relatedEntity)
			{		
				DesetupSyncWorkOrderEmployee(true, true);
				_workOrderEmployee = (WorkOrderEmployeeEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _workOrderEmployee, new PropertyChangedEventHandler( OnWorkOrderEmployeePropertyChanged ), "WorkOrderEmployee", DeepFryerServiceEntity.Relations.WorkOrderEmployeeEntityUsingWorkOrderServiceLocationId, true, ref _alreadyFetchedWorkOrderEmployee, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWorkOrderEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _workOrderServiceLocation</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrderServiceLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", DeepFryerServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, signalRelatedEntity, "DeepFryerService", resetFKFields, new int[] { (int)DeepFryerServiceFieldIndex.WorkOrderServiceLocationId } );		
			_workOrderServiceLocation = null;
		}
		
		/// <summary> setups the sync logic for member _workOrderServiceLocation</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrderServiceLocation(IEntity relatedEntity)
		{
			if(_workOrderServiceLocation!=relatedEntity)
			{		
				DesetupSyncWorkOrderServiceLocation(true, true);
				_workOrderServiceLocation = (WorkOrderServiceLocationEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _workOrderServiceLocation, new PropertyChangedEventHandler( OnWorkOrderServiceLocationPropertyChanged ), "WorkOrderServiceLocation", DeepFryerServiceEntity.Relations.WorkOrderServiceLocationEntityUsingWorkOrderServiceLocationId, true, ref _alreadyFetchedWorkOrderServiceLocation, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWorkOrderServiceLocationPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="deepFryerServiceId">PK value for DeepFryerService which data should be fetched into this DeepFryerService object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 deepFryerServiceId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)DeepFryerServiceFieldIndex.DeepFryerServiceId].ForcedCurrentValueWrite(deepFryerServiceId);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (base.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateDeepFryerServiceDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new DeepFryerServiceEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static DeepFryerServiceRelations Relations
		{
			get	{ return new DeepFryerServiceRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryerServiceChangeLog' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryerServiceChangeLog
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection(),
					(IEntityRelation)GetRelationsForField("DeepFryerServiceChangeLog")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceChangeLogEntity, 0, null, null, null, "DeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog_"), "EmployeeCollectionViaDeepFryerServiceChangeLog_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaDeepFryerServiceChangeLog"), "EmployeeCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, GetRelationsForField("ServiceLocationCollectionViaDeepFryerServiceChangeLog"), "ServiceLocationCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUserCollectionViaDeepFryerServiceChangeLog
		{
			get
			{
				IEntityRelation intermediateRelation = DeepFryerServiceEntity.Relations.DeepFryerServiceChangeLogEntityUsingDeepFryerServiceId;
				intermediateRelation.SetAliases(string.Empty, "DeepFryerServiceChangeLog_");
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.UserCollection(), intermediateRelation,
					(int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.UserEntity, 0, null, null, GetRelationsForField("UserCollectionViaDeepFryerServiceChangeLog"), "UserCollectionViaDeepFryerServiceChangeLog", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DeepFryer' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDeepFryer
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.DeepFryerCollection(),
					(IEntityRelation)GetRelationsForField("DeepFryer")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.DeepFryerEntity, 0, null, null, null, "DeepFryer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Employee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEmployee
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection(),
					(IEntityRelation)GetRelationsForField("Employee")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.EmployeeEntity, 0, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathServiceLocation
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection(),
					(IEntityRelation)GetRelationsForField("ServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.ServiceLocationEntity, 0, null, null, null, "ServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderEmployee' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderEmployee
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderEmployeeCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrderEmployee")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderEmployeeEntity, 0, null, null, null, "WorkOrderEmployee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'WorkOrderServiceLocation' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathWorkOrderServiceLocation
		{
			get
			{
				return new PrefetchPathElement(new Reliant.RenuOil.DAL.CollectionClasses.WorkOrderServiceLocationCollection(),
					(IEntityRelation)GetRelationsForField("WorkOrderServiceLocation")[0], (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity, (int)Reliant.RenuOil.DAL.EntityType.WorkOrderServiceLocationEntity, 0, null, null, null, "WorkOrderServiceLocation", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "DeepFryerServiceEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return DeepFryerServiceEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
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
			get { return DeepFryerServiceEntity.FieldsCustomProperties;}
		}

		/// <summary> The DeepFryerServiceId property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."DeepFryerServiceId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DeepFryerServiceId
		{
			get { return (System.Int32)GetValue((int)DeepFryerServiceFieldIndex.DeepFryerServiceId, true); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.DeepFryerServiceId, value, true); }
		}
		/// <summary> The DeepFryerId property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."DeepFryerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DeepFryerId
		{
			get { return (System.Int32)GetValue((int)DeepFryerServiceFieldIndex.DeepFryerId, true); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.DeepFryerId, value, true); }
		}
		/// <summary> The WorkOrderServiceLocationId property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."WorkOrderServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 WorkOrderServiceLocationId
		{
			get { return (System.Int32)GetValue((int)DeepFryerServiceFieldIndex.WorkOrderServiceLocationId, true); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.WorkOrderServiceLocationId, value, true); }
		}
		/// <summary> The Filtered property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."Filtered"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Filtered
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceFieldIndex.Filtered, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.Filtered, value, true); }
		}
		/// <summary> The Discarded property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."Discarded"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Discarded
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceFieldIndex.Discarded, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.Discarded, value, true); }
		}
		/// <summary> The Relocated property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."Relocated"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Relocated
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceFieldIndex.Relocated, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.Relocated, value, true); }
		}
		/// <summary> The Cleaned property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."Cleaned"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> Cleaned
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceFieldIndex.Cleaned, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.Cleaned, value, true); }
		}
		/// <summary> The RelocatedToFryerId property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."RelocatedToFryerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> RelocatedToFryerId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceFieldIndex.RelocatedToFryerId, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.RelocatedToFryerId, value, true); }
		}
		/// <summary> The RelocatedToServiceLocationId property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."RelocatedToServiceLocationId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> RelocatedToServiceLocationId
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceFieldIndex.RelocatedToServiceLocationId, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.RelocatedToServiceLocationId, value, true); }
		}
		/// <summary> The RelocatedToOther property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."RelocatedToOther"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RelocatedToOther
		{
			get { return (System.String)GetValue((int)DeepFryerServiceFieldIndex.RelocatedToOther, true); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.RelocatedToOther, value, true); }
		}
		/// <summary> The AssignedTo property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."AssignedTo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> AssignedTo
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceFieldIndex.AssignedTo, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.AssignedTo, value, true); }
		}
		/// <summary> The Servicedby property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."Servicedby"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Servicedby
		{
			get { return (Nullable<System.Int32>)GetValue((int)DeepFryerServiceFieldIndex.Servicedby, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.Servicedby, value, true); }
		}
		/// <summary> The NoService property of the Entity DeepFryerService<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "DeepFryerService"."NoService"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Boolean> NoService
		{
			get { return (Nullable<System.Boolean>)GetValue((int)DeepFryerServiceFieldIndex.NoService, false); }
			set	{ SetValue((int)DeepFryerServiceFieldIndex.NoService, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'DeepFryerServiceChangeLogEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDeepFryerServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.DeepFryerServiceChangeLogCollection DeepFryerServiceChangeLog
		{
			get	{ return GetMultiDeepFryerServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryerServiceChangeLog. When set to true, DeepFryerServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryerServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiDeepFryerServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryerServiceChangeLog
		{
			get	{ return _alwaysFetchDeepFryerServiceChangeLog; }
			set	{ _alwaysFetchDeepFryerServiceChangeLog = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryerServiceChangeLog already has been fetched. Setting this property to false when DeepFryerServiceChangeLog has been fetched
		/// will clear the DeepFryerServiceChangeLog collection well. Setting this property to true while DeepFryerServiceChangeLog hasn't been fetched disables lazy loading for DeepFryerServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryerServiceChangeLog
		{
			get { return _alreadyFetchedDeepFryerServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedDeepFryerServiceChangeLog && !value && (_deepFryerServiceChangeLog != null))
				{
					_deepFryerServiceChangeLog.Clear();
				}
				_alreadyFetchedDeepFryerServiceChangeLog = value;
			}
		}

		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get { return GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaDeepFryerServiceChangeLog_. When set to true, EmployeeCollectionViaDeepFryerServiceChangeLog_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaDeepFryerServiceChangeLog_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog_(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get	{ return _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_; }
			set	{ _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog_ = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaDeepFryerServiceChangeLog_ already has been fetched. Setting this property to false when EmployeeCollectionViaDeepFryerServiceChangeLog_ has been fetched
		/// will clear the EmployeeCollectionViaDeepFryerServiceChangeLog_ collection well. Setting this property to true while EmployeeCollectionViaDeepFryerServiceChangeLog_ hasn't been fetched disables lazy loading for EmployeeCollectionViaDeepFryerServiceChangeLog_</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_
		{
			get { return _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ && !value && (_employeeCollectionViaDeepFryerServiceChangeLog_ != null))
				{
					_employeeCollectionViaDeepFryerServiceChangeLog_.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog_ = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.EmployeeCollection EmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get { return GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EmployeeCollectionViaDeepFryerServiceChangeLog. When set to true, EmployeeCollectionViaDeepFryerServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeCollectionViaDeepFryerServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeCollectionViaDeepFryerServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get	{ return _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog; }
			set	{ _alwaysFetchEmployeeCollectionViaDeepFryerServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property EmployeeCollectionViaDeepFryerServiceChangeLog already has been fetched. Setting this property to false when EmployeeCollectionViaDeepFryerServiceChangeLog has been fetched
		/// will clear the EmployeeCollectionViaDeepFryerServiceChangeLog collection well. Setting this property to true while EmployeeCollectionViaDeepFryerServiceChangeLog hasn't been fetched disables lazy loading for EmployeeCollectionViaDeepFryerServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog
		{
			get { return _alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog && !value && (_employeeCollectionViaDeepFryerServiceChangeLog != null))
				{
					_employeeCollectionViaDeepFryerServiceChangeLog.Clear();
				}
				_alreadyFetchedEmployeeCollectionViaDeepFryerServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ServiceLocationEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.ServiceLocationCollection ServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get { return GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocationCollectionViaDeepFryerServiceChangeLog. When set to true, ServiceLocationCollectionViaDeepFryerServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocationCollectionViaDeepFryerServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiServiceLocationCollectionViaDeepFryerServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get	{ return _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog; }
			set	{ _alwaysFetchServiceLocationCollectionViaDeepFryerServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocationCollectionViaDeepFryerServiceChangeLog already has been fetched. Setting this property to false when ServiceLocationCollectionViaDeepFryerServiceChangeLog has been fetched
		/// will clear the ServiceLocationCollectionViaDeepFryerServiceChangeLog collection well. Setting this property to true while ServiceLocationCollectionViaDeepFryerServiceChangeLog hasn't been fetched disables lazy loading for ServiceLocationCollectionViaDeepFryerServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog
		{
			get { return _alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog && !value && (_serviceLocationCollectionViaDeepFryerServiceChangeLog != null))
				{
					_serviceLocationCollectionViaDeepFryerServiceChangeLog.Clear();
				}
				_alreadyFetchedServiceLocationCollectionViaDeepFryerServiceChangeLog = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'UserEntity' using a relation of type 'm:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUserCollectionViaDeepFryerServiceChangeLog()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Reliant.RenuOil.DAL.CollectionClasses.UserCollection UserCollectionViaDeepFryerServiceChangeLog
		{
			get { return GetMultiUserCollectionViaDeepFryerServiceChangeLog(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for UserCollectionViaDeepFryerServiceChangeLog. When set to true, UserCollectionViaDeepFryerServiceChangeLog is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserCollectionViaDeepFryerServiceChangeLog is accessed. You can always execute
		/// a forced fetch by calling GetMultiUserCollectionViaDeepFryerServiceChangeLog(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUserCollectionViaDeepFryerServiceChangeLog
		{
			get	{ return _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog; }
			set	{ _alwaysFetchUserCollectionViaDeepFryerServiceChangeLog = value; }
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property UserCollectionViaDeepFryerServiceChangeLog already has been fetched. Setting this property to false when UserCollectionViaDeepFryerServiceChangeLog has been fetched
		/// will clear the UserCollectionViaDeepFryerServiceChangeLog collection well. Setting this property to true while UserCollectionViaDeepFryerServiceChangeLog hasn't been fetched disables lazy loading for UserCollectionViaDeepFryerServiceChangeLog</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUserCollectionViaDeepFryerServiceChangeLog
		{
			get { return _alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog;}
			set 
			{
				if(_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog && !value && (_userCollectionViaDeepFryerServiceChangeLog != null))
				{
					_userCollectionViaDeepFryerServiceChangeLog.Clear();
				}
				_alreadyFetchedUserCollectionViaDeepFryerServiceChangeLog = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'DeepFryerEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleDeepFryer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual DeepFryerEntity DeepFryer
		{
			get	{ return GetSingleDeepFryer(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncDeepFryer(value);
				}
				else
				{
					if(value==null)
					{
						if(_deepFryer != null)
						{
							_deepFryer.UnsetRelatedEntity(this, "DeepFryerService");
						}
					}
					else
					{
						if(_deepFryer!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for DeepFryer. When set to true, DeepFryer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time DeepFryer is accessed. You can always execute
		/// a forced fetch by calling GetSingleDeepFryer(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDeepFryer
		{
			get	{ return _alwaysFetchDeepFryer; }
			set	{ _alwaysFetchDeepFryer = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property DeepFryer already has been fetched. Setting this property to false when DeepFryer has been fetched
		/// will set DeepFryer to null as well. Setting this property to true while DeepFryer hasn't been fetched disables lazy loading for DeepFryer</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDeepFryer
		{
			get { return _alreadyFetchedDeepFryer;}
			set 
			{
				if(_alreadyFetchedDeepFryer && !value)
				{
					this.DeepFryer = null;
				}
				_alreadyFetchedDeepFryer = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property DeepFryer is not found
		/// in the database. When set to true, DeepFryer will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool DeepFryerReturnsNewIfNotFound
		{
			get	{ return _deepFryerReturnsNewIfNotFound; }
			set { _deepFryerReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get	{ return GetSingleEmployee(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee != null)
						{
							_employee.UnsetRelatedEntity(this, "DeepFryerService");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee
		{
			get	{ return _alwaysFetchEmployee; }
			set	{ _alwaysFetchEmployee = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Employee already has been fetched. Setting this property to false when Employee has been fetched
		/// will set Employee to null as well. Setting this property to true while Employee hasn't been fetched disables lazy loading for Employee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEmployee
		{
			get { return _alreadyFetchedEmployee;}
			set 
			{
				if(_alreadyFetchedEmployee && !value)
				{
					this.Employee = null;
				}
				_alreadyFetchedEmployee = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Employee is not found
		/// in the database. When set to true, Employee will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool EmployeeReturnsNewIfNotFound
		{
			get	{ return _employeeReturnsNewIfNotFound; }
			set { _employeeReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'ServiceLocationEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ServiceLocationEntity ServiceLocation
		{
			get	{ return GetSingleServiceLocation(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncServiceLocation(value);
				}
				else
				{
					if(value==null)
					{
						if(_serviceLocation != null)
						{
							_serviceLocation.UnsetRelatedEntity(this, "DeepFryerService");
						}
					}
					else
					{
						if(_serviceLocation!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ServiceLocation. When set to true, ServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetSingleServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchServiceLocation
		{
			get	{ return _alwaysFetchServiceLocation; }
			set	{ _alwaysFetchServiceLocation = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ServiceLocation already has been fetched. Setting this property to false when ServiceLocation has been fetched
		/// will set ServiceLocation to null as well. Setting this property to true while ServiceLocation hasn't been fetched disables lazy loading for ServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedServiceLocation
		{
			get { return _alreadyFetchedServiceLocation;}
			set 
			{
				if(_alreadyFetchedServiceLocation && !value)
				{
					this.ServiceLocation = null;
				}
				_alreadyFetchedServiceLocation = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ServiceLocation is not found
		/// in the database. When set to true, ServiceLocation will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ServiceLocationReturnsNewIfNotFound
		{
			get	{ return _serviceLocationReturnsNewIfNotFound; }
			set { _serviceLocationReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'WorkOrderEmployeeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleWorkOrderEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual WorkOrderEmployeeEntity WorkOrderEmployee
		{
			get	{ return GetSingleWorkOrderEmployee(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncWorkOrderEmployee(value);
				}
				else
				{
					if(value==null)
					{
						if(_workOrderEmployee != null)
						{
							_workOrderEmployee.UnsetRelatedEntity(this, "DeepFryerService");
						}
					}
					else
					{
						if(_workOrderEmployee!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderEmployee. When set to true, WorkOrderEmployee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderEmployee is accessed. You can always execute
		/// a forced fetch by calling GetSingleWorkOrderEmployee(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderEmployee
		{
			get	{ return _alwaysFetchWorkOrderEmployee; }
			set	{ _alwaysFetchWorkOrderEmployee = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderEmployee already has been fetched. Setting this property to false when WorkOrderEmployee has been fetched
		/// will set WorkOrderEmployee to null as well. Setting this property to true while WorkOrderEmployee hasn't been fetched disables lazy loading for WorkOrderEmployee</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderEmployee
		{
			get { return _alreadyFetchedWorkOrderEmployee;}
			set 
			{
				if(_alreadyFetchedWorkOrderEmployee && !value)
				{
					this.WorkOrderEmployee = null;
				}
				_alreadyFetchedWorkOrderEmployee = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property WorkOrderEmployee is not found
		/// in the database. When set to true, WorkOrderEmployee will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool WorkOrderEmployeeReturnsNewIfNotFound
		{
			get	{ return _workOrderEmployeeReturnsNewIfNotFound; }
			set { _workOrderEmployeeReturnsNewIfNotFound = value; }	
		}
		/// <summary> Gets / sets related entity of type 'WorkOrderServiceLocationEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleWorkOrderServiceLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual WorkOrderServiceLocationEntity WorkOrderServiceLocation
		{
			get	{ return GetSingleWorkOrderServiceLocation(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncWorkOrderServiceLocation(value);
				}
				else
				{
					if(value==null)
					{
						if(_workOrderServiceLocation != null)
						{
							_workOrderServiceLocation.UnsetRelatedEntity(this, "DeepFryerService");
						}
					}
					else
					{
						if(_workOrderServiceLocation!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "DeepFryerService");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for WorkOrderServiceLocation. When set to true, WorkOrderServiceLocation is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderServiceLocation is accessed. You can always execute
		/// a forced fetch by calling GetSingleWorkOrderServiceLocation(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderServiceLocation
		{
			get	{ return _alwaysFetchWorkOrderServiceLocation; }
			set	{ _alwaysFetchWorkOrderServiceLocation = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property WorkOrderServiceLocation already has been fetched. Setting this property to false when WorkOrderServiceLocation has been fetched
		/// will set WorkOrderServiceLocation to null as well. Setting this property to true while WorkOrderServiceLocation hasn't been fetched disables lazy loading for WorkOrderServiceLocation</summary>
		[Browsable(false)]
		public bool AlreadyFetchedWorkOrderServiceLocation
		{
			get { return _alreadyFetchedWorkOrderServiceLocation;}
			set 
			{
				if(_alreadyFetchedWorkOrderServiceLocation && !value)
				{
					this.WorkOrderServiceLocation = null;
				}
				_alreadyFetchedWorkOrderServiceLocation = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property WorkOrderServiceLocation is not found
		/// in the database. When set to true, WorkOrderServiceLocation will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool WorkOrderServiceLocationReturnsNewIfNotFound
		{
			get	{ return _workOrderServiceLocationReturnsNewIfNotFound; }
			set { _workOrderServiceLocationReturnsNewIfNotFound = value; }	
		}



		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the Reliant.RenuOil.DAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)Reliant.RenuOil.DAL.EntityType.DeepFryerServiceEntity; }
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
