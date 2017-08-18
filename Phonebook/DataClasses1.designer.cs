﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Phonebook
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PHONEBOOK")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Phonebook.Properties.Settings.Default.PHONEBOOKConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblPhoneBook> tblPhoneBooks
		{
			get
			{
				return this.GetTable<tblPhoneBook>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_view")]
		public ISingleResult<sp_viewResult> sp_view()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_viewResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Insert")]
		public int sp_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string phStudID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string phUsername, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string phPassword, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string phLast_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(40)")] string phFirst_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string phMiddle_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string phAddress, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> phAge, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string phGender, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(15)")] string phContactNum, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> phBirthDate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), phStudID, phUsername, phPassword, phLast_Name, phFirst_Name, phMiddle_Name, phAddress, phAge, phGender, phContactNum, phBirthDate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_StudentID")]
		public int sp_StudentID()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_login")]
		public ISingleResult<sp_loginResult> sp_login([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password);
			return ((ISingleResult<sp_loginResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Search")]
		public ISingleResult<sp_SearchResult> sp_Search([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string phLast_Name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), phLast_Name);
			return ((ISingleResult<sp_SearchResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_mview")]
		public ISingleResult<sp_mviewResult> sp_mview()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_mviewResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_update")]
		public int sp_update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="StudID", DbType="VarChar(50)")] string studID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string phUsername, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(MAX)")] string phPassword, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string phLast_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(40)")] string phFirst_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string phMiddle_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string phAddress, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> phAge, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string phGender, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(15)")] string phContactNum)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), studID, phUsername, phPassword, phLast_Name, phFirst_Name, phMiddle_Name, phAddress, phAge, phGender, phContactNum);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_delete")]
		public int sp_delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string phID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), phID);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblPhoneBook")]
	public partial class tblPhoneBook
	{
		
		private int _phID;
		
		private string _phStudID;
		
		private string _phUsername;
		
		private string _phPassword;
		
		private string _phLast_Name;
		
		private string _phFirst_Name;
		
		private string _phMiddle_Name;
		
		private string _phAddress;
		
		private int _phAge;
		
		private string _phGender;
		
		private string _phContactNum;
		
		private System.DateTime _phBirthDate;
		
		public tblPhoneBook()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int phID
		{
			get
			{
				return this._phID;
			}
			set
			{
				if ((this._phID != value))
				{
					this._phID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phStudID", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string phStudID
		{
			get
			{
				return this._phStudID;
			}
			set
			{
				if ((this._phStudID != value))
				{
					this._phStudID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phUsername", DbType="VarChar(30)")]
		public string phUsername
		{
			get
			{
				return this._phUsername;
			}
			set
			{
				if ((this._phUsername != value))
				{
					this._phUsername = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phPassword", DbType="VarChar(MAX)")]
		public string phPassword
		{
			get
			{
				return this._phPassword;
			}
			set
			{
				if ((this._phPassword != value))
				{
					this._phPassword = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phLast_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string phLast_Name
		{
			get
			{
				return this._phLast_Name;
			}
			set
			{
				if ((this._phLast_Name != value))
				{
					this._phLast_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phFirst_Name", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string phFirst_Name
		{
			get
			{
				return this._phFirst_Name;
			}
			set
			{
				if ((this._phFirst_Name != value))
				{
					this._phFirst_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phMiddle_Name", DbType="VarChar(20)")]
		public string phMiddle_Name
		{
			get
			{
				return this._phMiddle_Name;
			}
			set
			{
				if ((this._phMiddle_Name != value))
				{
					this._phMiddle_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phAddress", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string phAddress
		{
			get
			{
				return this._phAddress;
			}
			set
			{
				if ((this._phAddress != value))
				{
					this._phAddress = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phAge", DbType="Int NOT NULL")]
		public int phAge
		{
			get
			{
				return this._phAge;
			}
			set
			{
				if ((this._phAge != value))
				{
					this._phAge = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phGender", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string phGender
		{
			get
			{
				return this._phGender;
			}
			set
			{
				if ((this._phGender != value))
				{
					this._phGender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phContactNum", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string phContactNum
		{
			get
			{
				return this._phContactNum;
			}
			set
			{
				if ((this._phContactNum != value))
				{
					this._phContactNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phBirthDate", DbType="DateTime NOT NULL")]
		public System.DateTime phBirthDate
		{
			get
			{
				return this._phBirthDate;
			}
			set
			{
				if ((this._phBirthDate != value))
				{
					this._phBirthDate = value;
				}
			}
		}
	}
	
	public partial class sp_viewResult
	{
		
		private int _phID;
		
		private string _phStudID;
		
		private string _phUsername;
		
		private string _phPassword;
		
		private string _phLast_Name;
		
		private string _phFirst_Name;
		
		private string _phMiddle_Name;
		
		private string _phAddress;
		
		private int _phAge;
		
		private string _phGender;
		
		private string _phContactNum;
		
		private System.DateTime _phBirthDate;
		
		public sp_viewResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phID", DbType="Int NOT NULL")]
		public int phID
		{
			get
			{
				return this._phID;
			}
			set
			{
				if ((this._phID != value))
				{
					this._phID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phStudID", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string phStudID
		{
			get
			{
				return this._phStudID;
			}
			set
			{
				if ((this._phStudID != value))
				{
					this._phStudID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phUsername", DbType="VarChar(30)")]
		public string phUsername
		{
			get
			{
				return this._phUsername;
			}
			set
			{
				if ((this._phUsername != value))
				{
					this._phUsername = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phPassword", DbType="VarChar(30)")]
		public string phPassword
		{
			get
			{
				return this._phPassword;
			}
			set
			{
				if ((this._phPassword != value))
				{
					this._phPassword = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phLast_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string phLast_Name
		{
			get
			{
				return this._phLast_Name;
			}
			set
			{
				if ((this._phLast_Name != value))
				{
					this._phLast_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phFirst_Name", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string phFirst_Name
		{
			get
			{
				return this._phFirst_Name;
			}
			set
			{
				if ((this._phFirst_Name != value))
				{
					this._phFirst_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phMiddle_Name", DbType="VarChar(20)")]
		public string phMiddle_Name
		{
			get
			{
				return this._phMiddle_Name;
			}
			set
			{
				if ((this._phMiddle_Name != value))
				{
					this._phMiddle_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phAddress", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string phAddress
		{
			get
			{
				return this._phAddress;
			}
			set
			{
				if ((this._phAddress != value))
				{
					this._phAddress = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phAge", DbType="Int NOT NULL")]
		public int phAge
		{
			get
			{
				return this._phAge;
			}
			set
			{
				if ((this._phAge != value))
				{
					this._phAge = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phGender", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string phGender
		{
			get
			{
				return this._phGender;
			}
			set
			{
				if ((this._phGender != value))
				{
					this._phGender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phContactNum", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string phContactNum
		{
			get
			{
				return this._phContactNum;
			}
			set
			{
				if ((this._phContactNum != value))
				{
					this._phContactNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phBirthDate", DbType="DateTime NOT NULL")]
		public System.DateTime phBirthDate
		{
			get
			{
				return this._phBirthDate;
			}
			set
			{
				if ((this._phBirthDate != value))
				{
					this._phBirthDate = value;
				}
			}
		}
	}
	
	public partial class sp_loginResult
	{
		
		private string _phUsername;
		
		private string _phPassword;
		
		public sp_loginResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phUsername", DbType="VarChar(30)")]
		public string phUsername
		{
			get
			{
				return this._phUsername;
			}
			set
			{
				if ((this._phUsername != value))
				{
					this._phUsername = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phPassword", DbType="VarChar(MAX)")]
		public string phPassword
		{
			get
			{
				return this._phPassword;
			}
			set
			{
				if ((this._phPassword != value))
				{
					this._phPassword = value;
				}
			}
		}
	}
	
	public partial class sp_SearchResult
	{
		
		private string _Student_ID;
		
		private string _Username;
		
		private string _Last_Name;
		
		private string _First_Name;
		
		private string _Middle_Name;
		
		private string _Address;
		
		private int _Age;
		
		private string _Gender;
		
		private string _Contact_Number;
		
		private System.DateTime _Birthdate;
		
		public sp_SearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Student ID]", Storage="_Student_ID", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Student_ID
		{
			get
			{
				return this._Student_ID;
			}
			set
			{
				if ((this._Student_ID != value))
				{
					this._Student_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(30)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Last Name]", Storage="_Last_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this._Last_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[First Name]", Storage="_First_Name", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this._First_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Middle Name]", Storage="_Middle_Name", DbType="VarChar(20)")]
		public string Middle_Name
		{
			get
			{
				return this._Middle_Name;
			}
			set
			{
				if ((this._Middle_Name != value))
				{
					this._Middle_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int NOT NULL")]
		public int Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this._Age = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Contact Number]", Storage="_Contact_Number", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string Contact_Number
		{
			get
			{
				return this._Contact_Number;
			}
			set
			{
				if ((this._Contact_Number != value))
				{
					this._Contact_Number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthdate", DbType="DateTime NOT NULL")]
		public System.DateTime Birthdate
		{
			get
			{
				return this._Birthdate;
			}
			set
			{
				if ((this._Birthdate != value))
				{
					this._Birthdate = value;
				}
			}
		}
	}
	
	public partial class sp_mviewResult
	{
		
		private string _StudentID;
		
		private string _Username;
		
		private string _Last_Name;
		
		private string _First_Name;
		
		private string _Middle_Name;
		
		private string _Address;
		
		private int _Age;
		
		private string _Gender;
		
		private string _Contact_Number;
		
		private System.DateTime _Birthdate;
		
		public sp_mviewResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentID", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string StudentID
		{
			get
			{
				return this._StudentID;
			}
			set
			{
				if ((this._StudentID != value))
				{
					this._StudentID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(30)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Last Name]", Storage="_Last_Name", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this._Last_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[First Name]", Storage="_First_Name", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this._First_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Middle Name]", Storage="_Middle_Name", DbType="VarChar(20)")]
		public string Middle_Name
		{
			get
			{
				return this._Middle_Name;
			}
			set
			{
				if ((this._Middle_Name != value))
				{
					this._Middle_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int NOT NULL")]
		public int Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this._Age = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Contact Number]", Storage="_Contact_Number", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string Contact_Number
		{
			get
			{
				return this._Contact_Number;
			}
			set
			{
				if ((this._Contact_Number != value))
				{
					this._Contact_Number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthdate", DbType="DateTime NOT NULL")]
		public System.DateTime Birthdate
		{
			get
			{
				return this._Birthdate;
			}
			set
			{
				if ((this._Birthdate != value))
				{
					this._Birthdate = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
