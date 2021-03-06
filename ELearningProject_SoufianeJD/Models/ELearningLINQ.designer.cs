#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ELearningProject_SoufianeJD.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ELearningDB")]
	public partial class ELearningLINQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertstudent(student instance);
    partial void Updatestudent(student instance);
    partial void Deletestudent(student instance);
    partial void Insertcomment(comment instance);
    partial void Updatecomment(comment instance);
    partial void Deletecomment(comment instance);
    partial void Insertteacher(teacher instance);
    partial void Updateteacher(teacher instance);
    partial void Deleteteacher(teacher instance);
    partial void Insertcours(cours instance);
    partial void Updatecours(cours instance);
    partial void Deletecours(cours instance);
    partial void Insertinscription(inscription instance);
    partial void Updateinscription(inscription instance);
    partial void Deleteinscription(inscription instance);
    partial void InsertinscriptionT(inscriptionT instance);
    partial void UpdateinscriptionT(inscriptionT instance);
    partial void DeleteinscriptionT(inscriptionT instance);
    #endregion
		
		public ELearningLINQDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ELearningDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ELearningLINQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ELearningLINQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ELearningLINQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ELearningLINQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<student> students
		{
			get
			{
				return this.GetTable<student>();
			}
		}
		
		public System.Data.Linq.Table<comment> comments
		{
			get
			{
				return this.GetTable<comment>();
			}
		}
		
		public System.Data.Linq.Table<teacher> teachers
		{
			get
			{
				return this.GetTable<teacher>();
			}
		}
		
		public System.Data.Linq.Table<cours> cours
		{
			get
			{
				return this.GetTable<cours>();
			}
		}
		
		public System.Data.Linq.Table<inscription> inscriptions
		{
			get
			{
				return this.GetTable<inscription>();
			}
		}
		
		public System.Data.Linq.Table<inscriptionT> inscriptionTs
		{
			get
			{
				return this.GetTable<inscriptionT>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student")]
	public partial class student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _name;
		
		private string _lastname;
		
		private System.Nullable<int> _level;
		
		private string _pw;
		
		private System.Nullable<int> _status;
		
		private string _email;
		
		private string _img;
		
		private EntitySet<comment> _comments;
		
		private EntitySet<inscription> _inscriptions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OnlevelChanging(System.Nullable<int> value);
    partial void OnlevelChanged();
    partial void OnpwChanging(string value);
    partial void OnpwChanged();
    partial void OnstatusChanging(System.Nullable<int> value);
    partial void OnstatusChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    #endregion
		
		public student()
		{
			this._comments = new EntitySet<comment>(new Action<comment>(this.attach_comments), new Action<comment>(this.detach_comments));
			this._inscriptions = new EntitySet<inscription>(new Action<inscription>(this.attach_inscriptions), new Action<inscription>(this.detach_inscriptions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Char(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="NChar(50)")]
		public string lastname
		{
			get
			{
				return this._lastname;
			}
			set
			{
				if ((this._lastname != value))
				{
					this.OnlastnameChanging(value);
					this.SendPropertyChanging();
					this._lastname = value;
					this.SendPropertyChanged("lastname");
					this.OnlastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[level]", Storage="_level", DbType="Int")]
		public System.Nullable<int> level
		{
			get
			{
				return this._level;
			}
			set
			{
				if ((this._level != value))
				{
					this.OnlevelChanging(value);
					this.SendPropertyChanging();
					this._level = value;
					this.SendPropertyChanged("level");
					this.OnlevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pw", DbType="NChar(50)")]
		public string pw
		{
			get
			{
				return this._pw;
			}
			set
			{
				if ((this._pw != value))
				{
					this.OnpwChanging(value);
					this.SendPropertyChanging();
					this._pw = value;
					this.SendPropertyChanged("pw");
					this.OnpwChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int")]
		public System.Nullable<int> status
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="VarChar(50)")]
		public string img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_comment", Storage="_comments", ThisKey="Id", OtherKey="student")]
		public EntitySet<comment> comments
		{
			get
			{
				return this._comments;
			}
			set
			{
				this._comments.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_inscription", Storage="_inscriptions", ThisKey="Id", OtherKey="student")]
		public EntitySet<inscription> inscriptions
		{
			get
			{
				return this._inscriptions;
			}
			set
			{
				this._inscriptions.Assign(value);
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
		
		private void attach_comments(comment entity)
		{
			this.SendPropertyChanging();
			entity.student1 = this;
		}
		
		private void detach_comments(comment entity)
		{
			this.SendPropertyChanging();
			entity.student1 = null;
		}
		
		private void attach_inscriptions(inscription entity)
		{
			this.SendPropertyChanging();
			entity.student1 = this;
		}
		
		private void detach_inscriptions(inscription entity)
		{
			this.SendPropertyChanging();
			entity.student1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.comments")]
	public partial class comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _student;
		
		private System.Nullable<int> _cours;
		
		private string _body;
		
		private System.Nullable<System.DateTime> _date;
		
		private EntityRef<student> _student1;
		
		private EntityRef<cours> _cours1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnstudentChanging(string value);
    partial void OnstudentChanged();
    partial void OncoursChanging(System.Nullable<int> value);
    partial void OncoursChanged();
    partial void OnbodyChanging(string value);
    partial void OnbodyChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    #endregion
		
		public comment()
		{
			this._student1 = default(EntityRef<student>);
			this._cours1 = default(EntityRef<cours>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_student", DbType="Char(50)")]
		public string student
		{
			get
			{
				return this._student;
			}
			set
			{
				if ((this._student != value))
				{
					if (this._student1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnstudentChanging(value);
					this.SendPropertyChanging();
					this._student = value;
					this.SendPropertyChanged("student");
					this.OnstudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cours", DbType="Int")]
		public System.Nullable<int> cours
		{
			get
			{
				return this._cours;
			}
			set
			{
				if ((this._cours != value))
				{
					if (this._cours1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncoursChanging(value);
					this.SendPropertyChanging();
					this._cours = value;
					this.SendPropertyChanged("cours");
					this.OncoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_body", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string body
		{
			get
			{
				return this._body;
			}
			set
			{
				if ((this._body != value))
				{
					this.OnbodyChanging(value);
					this.SendPropertyChanging();
					this._body = value;
					this.SendPropertyChanged("body");
					this.OnbodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_comment", Storage="_student1", ThisKey="student", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public student student1
		{
			get
			{
				return this._student1.Entity;
			}
			set
			{
				student previousValue = this._student1.Entity;
				if (((previousValue != value) 
							|| (this._student1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._student1.Entity = null;
						previousValue.comments.Remove(this);
					}
					this._student1.Entity = value;
					if ((value != null))
					{
						value.comments.Add(this);
						this._student = value.Id;
					}
					else
					{
						this._student = default(string);
					}
					this.SendPropertyChanged("student1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cours_comment", Storage="_cours1", ThisKey="cours", OtherKey="Id", IsForeignKey=true, DeleteRule="CASCADE")]
		public cours cours1
		{
			get
			{
				return this._cours1.Entity;
			}
			set
			{
				cours previousValue = this._cours1.Entity;
				if (((previousValue != value) 
							|| (this._cours1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._cours1.Entity = null;
						previousValue.comments.Remove(this);
					}
					this._cours1.Entity = value;
					if ((value != null))
					{
						value.comments.Add(this);
						this._cours = value.Id;
					}
					else
					{
						this._cours = default(Nullable<int>);
					}
					this.SendPropertyChanged("cours1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.teacher")]
	public partial class teacher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _name;
		
		private string _lastname;
		
		private string _pw;
		
		private System.Nullable<int> _status;
		
		private string _email;
		
		private string _img;
		
		private EntitySet<inscriptionT> _inscriptionTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OnpwChanging(string value);
    partial void OnpwChanged();
    partial void OnstatusChanging(System.Nullable<int> value);
    partial void OnstatusChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    #endregion
		
		public teacher()
		{
			this._inscriptionTs = new EntitySet<inscriptionT>(new Action<inscriptionT>(this.attach_inscriptionTs), new Action<inscriptionT>(this.detach_inscriptionTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Char(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="NChar(50)")]
		public string lastname
		{
			get
			{
				return this._lastname;
			}
			set
			{
				if ((this._lastname != value))
				{
					this.OnlastnameChanging(value);
					this.SendPropertyChanging();
					this._lastname = value;
					this.SendPropertyChanged("lastname");
					this.OnlastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pw", DbType="NChar(50)")]
		public string pw
		{
			get
			{
				return this._pw;
			}
			set
			{
				if ((this._pw != value))
				{
					this.OnpwChanging(value);
					this.SendPropertyChanging();
					this._pw = value;
					this.SendPropertyChanged("pw");
					this.OnpwChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int")]
		public System.Nullable<int> status
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="VarChar(50)")]
		public string img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="teacher_inscriptionT", Storage="_inscriptionTs", ThisKey="Id", OtherKey="teacher")]
		public EntitySet<inscriptionT> inscriptionTs
		{
			get
			{
				return this._inscriptionTs;
			}
			set
			{
				this._inscriptionTs.Assign(value);
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
		
		private void attach_inscriptionTs(inscriptionT entity)
		{
			this.SendPropertyChanging();
			entity.teacher1 = this;
		}
		
		private void detach_inscriptionTs(inscriptionT entity)
		{
			this.SendPropertyChanging();
			entity.teacher1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cours")]
	public partial class cours : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Description;
		
		private string _Owner;

		public int status = 0;
		
		private string _video;
		
		private string _img;
		
		private string _Level;
		
		private EntitySet<comment> _comments;
		
		private EntitySet<inscription> _inscriptions;
		
		private EntitySet<inscriptionT> _inscriptionTs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnOwnerChanging(string value);
    partial void OnOwnerChanged();
    partial void OnvideoChanging(string value);
    partial void OnvideoChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    partial void OnLevelChanging(string value);
    partial void OnLevelChanged();
    #endregion
		
		public cours()
		{
			this._comments = new EntitySet<comment>(new Action<comment>(this.attach_comments), new Action<comment>(this.detach_comments));
			this._inscriptions = new EntitySet<inscription>(new Action<inscription>(this.attach_inscriptions), new Action<inscription>(this.detach_inscriptions));
			this._inscriptionTs = new EntitySet<inscriptionT>(new Action<inscriptionT>(this.attach_inscriptionTs), new Action<inscriptionT>(this.detach_inscriptionTs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner", DbType="VarChar(50)")]
		public string Owner
		{
			get
			{
				return this._Owner;
			}
			set
			{
				if ((this._Owner != value))
				{
					this.OnOwnerChanging(value);
					this.SendPropertyChanging();
					this._Owner = value;
					this.SendPropertyChanged("Owner");
					this.OnOwnerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_video", DbType="VarChar(100)")]
		public string video
		{
			get
			{
				return this._video;
			}
			set
			{
				if ((this._video != value))
				{
					this.OnvideoChanging(value);
					this.SendPropertyChanging();
					this._video = value;
					this.SendPropertyChanged("video");
					this.OnvideoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="VarChar(50)")]
		public string img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Level]", Storage="_Level", DbType="NChar(10)")]
		public string Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				if ((this._Level != value))
				{
					this.OnLevelChanging(value);
					this.SendPropertyChanging();
					this._Level = value;
					this.SendPropertyChanged("Level");
					this.OnLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cours_comment", Storage="_comments", ThisKey="Id", OtherKey="cours")]
		public EntitySet<comment> comments
		{
			get
			{
				return this._comments;
			}
			set
			{
				this._comments.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cours_inscription", Storage="_inscriptions", ThisKey="Id", OtherKey="cours")]
		public EntitySet<inscription> inscriptions
		{
			get
			{
				return this._inscriptions;
			}
			set
			{
				this._inscriptions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cours_inscriptionT", Storage="_inscriptionTs", ThisKey="Id", OtherKey="cours")]
		public EntitySet<inscriptionT> inscriptionTs
		{
			get
			{
				return this._inscriptionTs;
			}
			set
			{
				this._inscriptionTs.Assign(value);
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
		
		private void attach_comments(comment entity)
		{
			this.SendPropertyChanging();
			entity.cours1 = this;
		}
		
		private void detach_comments(comment entity)
		{
			this.SendPropertyChanging();
			entity.cours1 = null;
		}
		
		private void attach_inscriptions(inscription entity)
		{
			this.SendPropertyChanging();
			entity.cours1 = this;
		}
		
		private void detach_inscriptions(inscription entity)
		{
			this.SendPropertyChanging();
			entity.cours1 = null;
		}
		
		private void attach_inscriptionTs(inscriptionT entity)
		{
			this.SendPropertyChanging();
			entity.cours1 = this;
		}
		
		private void detach_inscriptionTs(inscriptionT entity)
		{
			this.SendPropertyChanging();
			entity.cours1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.inscription")]
	public partial class inscription : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cours;
		
		private string _student;
		
		private EntityRef<cours> _cours1;
		
		private EntityRef<student> _student1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncoursChanging(int value);
    partial void OncoursChanged();
    partial void OnstudentChanging(string value);
    partial void OnstudentChanged();
    #endregion
		
		public inscription()
		{
			this._cours1 = default(EntityRef<cours>);
			this._student1 = default(EntityRef<student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cours", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cours
		{
			get
			{
				return this._cours;
			}
			set
			{
				if ((this._cours != value))
				{
					if (this._cours1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncoursChanging(value);
					this.SendPropertyChanging();
					this._cours = value;
					this.SendPropertyChanged("cours");
					this.OncoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_student", DbType="Char(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string student
		{
			get
			{
				return this._student;
			}
			set
			{
				if ((this._student != value))
				{
					if (this._student1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnstudentChanging(value);
					this.SendPropertyChanging();
					this._student = value;
					this.SendPropertyChanged("student");
					this.OnstudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cours_inscription", Storage="_cours1", ThisKey="cours", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public cours cours1
		{
			get
			{
				return this._cours1.Entity;
			}
			set
			{
				cours previousValue = this._cours1.Entity;
				if (((previousValue != value) 
							|| (this._cours1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._cours1.Entity = null;
						previousValue.inscriptions.Remove(this);
					}
					this._cours1.Entity = value;
					if ((value != null))
					{
						value.inscriptions.Add(this);
						this._cours = value.Id;
					}
					else
					{
						this._cours = default(int);
					}
					this.SendPropertyChanged("cours1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_inscription", Storage="_student1", ThisKey="student", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public student student1
		{
			get
			{
				return this._student1.Entity;
			}
			set
			{
				student previousValue = this._student1.Entity;
				if (((previousValue != value) 
							|| (this._student1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._student1.Entity = null;
						previousValue.inscriptions.Remove(this);
					}
					this._student1.Entity = value;
					if ((value != null))
					{
						value.inscriptions.Add(this);
						this._student = value.Id;
					}
					else
					{
						this._student = default(string);
					}
					this.SendPropertyChanged("student1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.inscriptionT")]
	public partial class inscriptionT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cours;
		
		private string _teacher;
		
		private EntityRef<cours> _cours1;
		
		private EntityRef<teacher> _teacher1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncoursChanging(int value);
    partial void OncoursChanged();
    partial void OnteacherChanging(string value);
    partial void OnteacherChanged();
    #endregion
		
		public inscriptionT()
		{
			this._cours1 = default(EntityRef<cours>);
			this._teacher1 = default(EntityRef<teacher>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cours", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cours
		{
			get
			{
				return this._cours;
			}
			set
			{
				if ((this._cours != value))
				{
					if (this._cours1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncoursChanging(value);
					this.SendPropertyChanging();
					this._cours = value;
					this.SendPropertyChanged("cours");
					this.OncoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_teacher", DbType="Char(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string teacher
		{
			get
			{
				return this._teacher;
			}
			set
			{
				if ((this._teacher != value))
				{
					if (this._teacher1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnteacherChanging(value);
					this.SendPropertyChanging();
					this._teacher = value;
					this.SendPropertyChanged("teacher");
					this.OnteacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cours_inscriptionT", Storage="_cours1", ThisKey="cours", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public cours cours1
		{
			get
			{
				return this._cours1.Entity;
			}
			set
			{
				cours previousValue = this._cours1.Entity;
				if (((previousValue != value) 
							|| (this._cours1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._cours1.Entity = null;
						previousValue.inscriptionTs.Remove(this);
					}
					this._cours1.Entity = value;
					if ((value != null))
					{
						value.inscriptionTs.Add(this);
						this._cours = value.Id;
					}
					else
					{
						this._cours = default(int);
					}
					this.SendPropertyChanged("cours1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="teacher_inscriptionT", Storage="_teacher1", ThisKey="teacher", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public teacher teacher1
		{
			get
			{
				return this._teacher1.Entity;
			}
			set
			{
				teacher previousValue = this._teacher1.Entity;
				if (((previousValue != value) 
							|| (this._teacher1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._teacher1.Entity = null;
						previousValue.inscriptionTs.Remove(this);
					}
					this._teacher1.Entity = value;
					if ((value != null))
					{
						value.inscriptionTs.Add(this);
						this._teacher = value.Id;
					}
					else
					{
						this._teacher = default(string);
					}
					this.SendPropertyChanged("teacher1");
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
}
#pragma warning restore 1591
