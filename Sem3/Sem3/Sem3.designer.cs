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

namespace Sem3
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WCF_QLKH")]
	public partial class Sem3DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChiTiet(ChiTiet instance);
    partial void UpdateChiTiet(ChiTiet instance);
    partial void DeleteChiTiet(ChiTiet instance);
    partial void InsertDanhMuc(DanhMuc instance);
    partial void UpdateDanhMuc(DanhMuc instance);
    partial void DeleteDanhMuc(DanhMuc instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    #endregion
		
		public Sem3DataContext() : 
				base(global::Sem3.Properties.Settings.Default.WCF_QLKHConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Sem3DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Sem3DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Sem3DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Sem3DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChiTiet> ChiTiets
		{
			get
			{
				return this.GetTable<ChiTiet>();
			}
		}
		
		public System.Data.Linq.Table<DanhMuc> DanhMucs
		{
			get
			{
				return this.GetTable<DanhMuc>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTiet")]
	public partial class ChiTiet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _orderId;
		
		private int _proId;
		
		private System.Nullable<int> _quantity;
		
		private System.Nullable<double> _price;
		
		private System.Nullable<double> _totalPrice;
		
		private EntityRef<HoaDon> _HoaDon;
		
		private EntityRef<SanPham> _SanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnorderIdChanging(string value);
    partial void OnorderIdChanged();
    partial void OnproIdChanging(int value);
    partial void OnproIdChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    partial void OnpriceChanging(System.Nullable<double> value);
    partial void OnpriceChanged();
    partial void OntotalPriceChanging(System.Nullable<double> value);
    partial void OntotalPriceChanged();
    #endregion
		
		public ChiTiet()
		{
			this._HoaDon = default(EntityRef<HoaDon>);
			this._SanPham = default(EntityRef<SanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderId", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string orderId
		{
			get
			{
				return this._orderId;
			}
			set
			{
				if ((this._orderId != value))
				{
					if (this._HoaDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnorderIdChanging(value);
					this.SendPropertyChanging();
					this._orderId = value;
					this.SendPropertyChanged("orderId");
					this.OnorderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_proId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int proId
		{
			get
			{
				return this._proId;
			}
			set
			{
				if ((this._proId != value))
				{
					if (this._SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproIdChanging(value);
					this.SendPropertyChanging();
					this._proId = value;
					this.SendPropertyChanged("proId");
					this.OnproIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Float")]
		public System.Nullable<double> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalPrice", DbType="Float")]
		public System.Nullable<double> totalPrice
		{
			get
			{
				return this._totalPrice;
			}
			set
			{
				if ((this._totalPrice != value))
				{
					this.OntotalPriceChanging(value);
					this.SendPropertyChanging();
					this._totalPrice = value;
					this.SendPropertyChanged("totalPrice");
					this.OntotalPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_ChiTiet", Storage="_HoaDon", ThisKey="orderId", OtherKey="id", IsForeignKey=true)]
		public HoaDon HoaDon
		{
			get
			{
				return this._HoaDon.Entity;
			}
			set
			{
				HoaDon previousValue = this._HoaDon.Entity;
				if (((previousValue != value) 
							|| (this._HoaDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HoaDon.Entity = null;
						previousValue.ChiTiets.Remove(this);
					}
					this._HoaDon.Entity = value;
					if ((value != null))
					{
						value.ChiTiets.Add(this);
						this._orderId = value.id;
					}
					else
					{
						this._orderId = default(string);
					}
					this.SendPropertyChanged("HoaDon");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_ChiTiet", Storage="_SanPham", ThisKey="proId", OtherKey="id", IsForeignKey=true)]
		public SanPham SanPham
		{
			get
			{
				return this._SanPham.Entity;
			}
			set
			{
				SanPham previousValue = this._SanPham.Entity;
				if (((previousValue != value) 
							|| (this._SanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SanPham.Entity = null;
						previousValue.ChiTiets.Remove(this);
					}
					this._SanPham.Entity = value;
					if ((value != null))
					{
						value.ChiTiets.Add(this);
						this._proId = value.id;
					}
					else
					{
						this._proId = default(int);
					}
					this.SendPropertyChanged("SanPham");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DanhMuc")]
	public partial class DanhMuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<bool> _status;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnstatusChanging(System.Nullable<bool> value);
    partial void OnstatusChanged();
    #endregion
		
		public DanhMuc()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(200)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit")]
		public System.Nullable<bool> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_SanPham", Storage="_SanPhams", ThisKey="id", OtherKey="catId")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private System.Nullable<int> _empId;
		
		private System.Nullable<System.DateTime> _created_at;
		
		private string _customer;
		
		private System.Nullable<double> _totalPrice;
		
		private EntitySet<ChiTiet> _ChiTiets;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnempIdChanging(System.Nullable<int> value);
    partial void OnempIdChanged();
    partial void Oncreated_atChanging(System.Nullable<System.DateTime> value);
    partial void Oncreated_atChanged();
    partial void OncustomerChanging(string value);
    partial void OncustomerChanged();
    partial void OntotalPriceChanging(System.Nullable<double> value);
    partial void OntotalPriceChanged();
    #endregion
		
		public HoaDon()
		{
			this._ChiTiets = new EntitySet<ChiTiet>(new Action<ChiTiet>(this.attach_ChiTiets), new Action<ChiTiet>(this.detach_ChiTiets));
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empId", DbType="Int")]
		public System.Nullable<int> empId
		{
			get
			{
				return this._empId;
			}
			set
			{
				if ((this._empId != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnempIdChanging(value);
					this.SendPropertyChanging();
					this._empId = value;
					this.SendPropertyChanged("empId");
					this.OnempIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_at", DbType="DateTime")]
		public System.Nullable<System.DateTime> created_at
		{
			get
			{
				return this._created_at;
			}
			set
			{
				if ((this._created_at != value))
				{
					this.Oncreated_atChanging(value);
					this.SendPropertyChanging();
					this._created_at = value;
					this.SendPropertyChanged("created_at");
					this.Oncreated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer", DbType="NVarChar(200)")]
		public string customer
		{
			get
			{
				return this._customer;
			}
			set
			{
				if ((this._customer != value))
				{
					this.OncustomerChanging(value);
					this.SendPropertyChanging();
					this._customer = value;
					this.SendPropertyChanged("customer");
					this.OncustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_totalPrice", DbType="Float")]
		public System.Nullable<double> totalPrice
		{
			get
			{
				return this._totalPrice;
			}
			set
			{
				if ((this._totalPrice != value))
				{
					this.OntotalPriceChanging(value);
					this.SendPropertyChanging();
					this._totalPrice = value;
					this.SendPropertyChanged("totalPrice");
					this.OntotalPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_ChiTiet", Storage="_ChiTiets", ThisKey="id", OtherKey="orderId")]
		public EntitySet<ChiTiet> ChiTiets
		{
			get
			{
				return this._ChiTiets;
			}
			set
			{
				this._ChiTiets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_HoaDon", Storage="_NhanVien", ThisKey="empId", OtherKey="id", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._empId = value.id;
					}
					else
					{
						this._empId = default(Nullable<int>);
					}
					this.SendPropertyChanged("NhanVien");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = this;
		}
		
		private void detach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _username;
		
		private string _password;
		
		private System.Nullable<System.DateTime> _birthday;
		
		private string _phone;
		
		private string _address;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnbirthdayChanging(System.Nullable<System.DateTime> value);
    partial void OnbirthdayChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    #endregion
		
		public NhanVien()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(200)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthday", DbType="Date")]
		public System.Nullable<System.DateTime> birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if ((this._birthday != value))
				{
					this.OnbirthdayChanging(value);
					this.SendPropertyChanging();
					this._birthday = value;
					this.SendPropertyChanged("birthday");
					this.OnbirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(20)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(200)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_HoaDon", Storage="_HoaDons", ThisKey="id", OtherKey="empId")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<int> _catId;
		
		private System.Nullable<double> _price;
		
		private System.Nullable<int> _quantity;
		
		private string _description;
		
		private System.Nullable<bool> _status;
		
		private EntitySet<ChiTiet> _ChiTiets;
		
		private EntityRef<DanhMuc> _DanhMuc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncatIdChanging(System.Nullable<int> value);
    partial void OncatIdChanged();
    partial void OnpriceChanging(System.Nullable<double> value);
    partial void OnpriceChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnstatusChanging(System.Nullable<bool> value);
    partial void OnstatusChanged();
    #endregion
		
		public SanPham()
		{
			this._ChiTiets = new EntitySet<ChiTiet>(new Action<ChiTiet>(this.attach_ChiTiets), new Action<ChiTiet>(this.detach_ChiTiets));
			this._DanhMuc = default(EntityRef<DanhMuc>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(200)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_catId", DbType="Int")]
		public System.Nullable<int> catId
		{
			get
			{
				return this._catId;
			}
			set
			{
				if ((this._catId != value))
				{
					if (this._DanhMuc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncatIdChanging(value);
					this.SendPropertyChanging();
					this._catId = value;
					this.SendPropertyChanged("catId");
					this.OncatIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Float")]
		public System.Nullable<double> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int")]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(200)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit")]
		public System.Nullable<bool> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_ChiTiet", Storage="_ChiTiets", ThisKey="id", OtherKey="proId")]
		public EntitySet<ChiTiet> ChiTiets
		{
			get
			{
				return this._ChiTiets;
			}
			set
			{
				this._ChiTiets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_SanPham", Storage="_DanhMuc", ThisKey="catId", OtherKey="id", IsForeignKey=true)]
		public DanhMuc DanhMuc
		{
			get
			{
				return this._DanhMuc.Entity;
			}
			set
			{
				DanhMuc previousValue = this._DanhMuc.Entity;
				if (((previousValue != value) 
							|| (this._DanhMuc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DanhMuc.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._DanhMuc.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._catId = value.id;
					}
					else
					{
						this._catId = default(Nullable<int>);
					}
					this.SendPropertyChanged("DanhMuc");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = this;
		}
		
		private void detach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = null;
		}
	}
}
#pragma warning restore 1591