﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyectoFinal
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NotasBD")]
	public partial class NoteBDDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    partial void InsertMaterias(Materias instance);
    partial void UpdateMaterias(Materias instance);
    partial void DeleteMaterias(Materias instance);
    partial void InsertNotas(Notas instance);
    partial void UpdateNotas(Notas instance);
    partial void DeleteNotas(Notas instance);
    #endregion
		
		public NoteBDDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NotasBDConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NoteBDDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NoteBDDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NoteBDDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NoteBDDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
		
		public System.Data.Linq.Table<Materias> Materias
		{
			get
			{
				return this.GetTable<Materias>();
			}
		}
		
		public System.Data.Linq.Table<Notas> Notas
		{
			get
			{
				return this.GetTable<Notas>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.selectNote")]
		public ISingleResult<selectNoteResult> selectNote([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string user, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string msj)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), user, msj);
			return ((ISingleResult<selectNoteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.deleteNote")]
		public int deleteNote([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string user, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string msj)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), user, msj);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.eraseNote")]
		public int eraseNote([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string msj)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), title, msj);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _NombreUser;
		
		private string _Clave;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnNombreUserChanging(string value);
    partial void OnNombreUserChanged();
    partial void OnClaveChanging(string value);
    partial void OnClaveChanged();
    #endregion
		
		public Usuarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreUser", DbType="VarChar(30)")]
		public string NombreUser
		{
			get
			{
				return this._NombreUser;
			}
			set
			{
				if ((this._NombreUser != value))
				{
					this.OnNombreUserChanging(value);
					this.SendPropertyChanging();
					this._NombreUser = value;
					this.SendPropertyChanged("NombreUser");
					this.OnNombreUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Clave", DbType="VarChar(15)")]
		public string Clave
		{
			get
			{
				return this._Clave;
			}
			set
			{
				if ((this._Clave != value))
				{
					this.OnClaveChanging(value);
					this.SendPropertyChanging();
					this._Clave = value;
					this.SendPropertyChanged("Clave");
					this.OnClaveChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Materias")]
	public partial class Materias : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MateriaId;
		
		private string _NombreMateria;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMateriaIdChanging(string value);
    partial void OnMateriaIdChanged();
    partial void OnNombreMateriaChanging(string value);
    partial void OnNombreMateriaChanged();
    #endregion
		
		public Materias()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MateriaId", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MateriaId
		{
			get
			{
				return this._MateriaId;
			}
			set
			{
				if ((this._MateriaId != value))
				{
					this.OnMateriaIdChanging(value);
					this.SendPropertyChanging();
					this._MateriaId = value;
					this.SendPropertyChanged("MateriaId");
					this.OnMateriaIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreMateria", DbType="VarChar(30)")]
		public string NombreMateria
		{
			get
			{
				return this._NombreMateria;
			}
			set
			{
				if ((this._NombreMateria != value))
				{
					this.OnNombreMateriaChanging(value);
					this.SendPropertyChanging();
					this._NombreMateria = value;
					this.SendPropertyChanged("NombreMateria");
					this.OnNombreMateriaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Notas")]
	public partial class Notas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Numero;
		
		private string _Titulo;
		
		private string _Descripcion;
		
		private string _NombreMateria;
		
		private string _NombreUser;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNumeroChanging(int value);
    partial void OnNumeroChanged();
    partial void OnTituloChanging(string value);
    partial void OnTituloChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    partial void OnNombreMateriaChanging(string value);
    partial void OnNombreMateriaChanged();
    partial void OnNombreUserChanging(string value);
    partial void OnNombreUserChanged();
    #endregion
		
		public Notas()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numero", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Numero
		{
			get
			{
				return this._Numero;
			}
			set
			{
				if ((this._Numero != value))
				{
					this.OnNumeroChanging(value);
					this.SendPropertyChanging();
					this._Numero = value;
					this.SendPropertyChanged("Numero");
					this.OnNumeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Titulo", DbType="VarChar(30)")]
		public string Titulo
		{
			get
			{
				return this._Titulo;
			}
			set
			{
				if ((this._Titulo != value))
				{
					this.OnTituloChanging(value);
					this.SendPropertyChanging();
					this._Titulo = value;
					this.SendPropertyChanged("Titulo");
					this.OnTituloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(150)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreMateria", DbType="VarChar(30)")]
		public string NombreMateria
		{
			get
			{
				return this._NombreMateria;
			}
			set
			{
				if ((this._NombreMateria != value))
				{
					this.OnNombreMateriaChanging(value);
					this.SendPropertyChanging();
					this._NombreMateria = value;
					this.SendPropertyChanged("NombreMateria");
					this.OnNombreMateriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreUser", DbType="VarChar(30)")]
		public string NombreUser
		{
			get
			{
				return this._NombreUser;
			}
			set
			{
				if ((this._NombreUser != value))
				{
					this.OnNombreUserChanging(value);
					this.SendPropertyChanging();
					this._NombreUser = value;
					this.SendPropertyChanged("NombreUser");
					this.OnNombreUserChanged();
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
	
	public partial class selectNoteResult
	{
		
		private int _Numero;
		
		private string _Titulo;
		
		private string _Descripcion;
		
		private string _NombreMateria;
		
		private string _NombreUser;
		
		public selectNoteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numero", DbType="Int NOT NULL")]
		public int Numero
		{
			get
			{
				return this._Numero;
			}
			set
			{
				if ((this._Numero != value))
				{
					this._Numero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Titulo", DbType="VarChar(30)")]
		public string Titulo
		{
			get
			{
				return this._Titulo;
			}
			set
			{
				if ((this._Titulo != value))
				{
					this._Titulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(150)")]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreMateria", DbType="VarChar(30)")]
		public string NombreMateria
		{
			get
			{
				return this._NombreMateria;
			}
			set
			{
				if ((this._NombreMateria != value))
				{
					this._NombreMateria = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreUser", DbType="VarChar(30)")]
		public string NombreUser
		{
			get
			{
				return this._NombreUser;
			}
			set
			{
				if ((this._NombreUser != value))
				{
					this._NombreUser = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
