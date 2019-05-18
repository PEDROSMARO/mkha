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

namespace WcfPaperDemo
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="papersindex")]
	public partial class PaperindexDataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertjournal(journal instance);
    partial void Updatejournal(journal instance);
    partial void Deletejournal(journal instance);
    partial void InsertPaper(Paper instance);
    partial void UpdatePaper(Paper instance);
    partial void DeletePaper(Paper instance);
    #endregion
		
		public PaperindexDataClassDataContext() : 
				base(global::WcfPaperDemo.Properties.Settings.Default.papersindexConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PaperindexDataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PaperindexDataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PaperindexDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PaperindexDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<journal> journals
		{
			get
			{
				return this.GetTable<journal>();
			}
		}
		
		public System.Data.Linq.Table<Auther> Authers
		{
			get
			{
				return this.GetTable<Auther>();
			}
		}
		
		public System.Data.Linq.Table<Paper> Papers
		{
			get
			{
				return this.GetTable<Paper>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.journal")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class journal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _jouID;
		
		private string _journalTitle;
		
		private string _joucity;
		
		private string _jousubject;
		
		private System.Nullable<int> _jouclass;
		
		private EntitySet<Paper> _Papers;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnjouIDChanging(int value);
    partial void OnjouIDChanged();
    partial void OnjournalTitleChanging(string value);
    partial void OnjournalTitleChanged();
    partial void OnjoucityChanging(string value);
    partial void OnjoucityChanged();
    partial void OnjousubjectChanging(string value);
    partial void OnjousubjectChanged();
    partial void OnjouclassChanging(System.Nullable<int> value);
    partial void OnjouclassChanged();
    #endregion
		
		public journal()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jouID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int jouID
		{
			get
			{
				return this._jouID;
			}
			set
			{
				if ((this._jouID != value))
				{
					this.OnjouIDChanging(value);
					this.SendPropertyChanging();
					this._jouID = value;
					this.SendPropertyChanged("jouID");
					this.OnjouIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_journalTitle", DbType="NChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string journalTitle
		{
			get
			{
				return this._journalTitle;
			}
			set
			{
				if ((this._journalTitle != value))
				{
					this.OnjournalTitleChanging(value);
					this.SendPropertyChanging();
					this._journalTitle = value;
					this.SendPropertyChanged("journalTitle");
					this.OnjournalTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_joucity", DbType="NChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string joucity
		{
			get
			{
				return this._joucity;
			}
			set
			{
				if ((this._joucity != value))
				{
					this.OnjoucityChanging(value);
					this.SendPropertyChanging();
					this._joucity = value;
					this.SendPropertyChanged("joucity");
					this.OnjoucityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jousubject", DbType="NChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string jousubject
		{
			get
			{
				return this._jousubject;
			}
			set
			{
				if ((this._jousubject != value))
				{
					this.OnjousubjectChanging(value);
					this.SendPropertyChanging();
					this._jousubject = value;
					this.SendPropertyChanged("jousubject");
					this.OnjousubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jouclass", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public System.Nullable<int> jouclass
		{
			get
			{
				return this._jouclass;
			}
			set
			{
				if ((this._jouclass != value))
				{
					this.OnjouclassChanging(value);
					this.SendPropertyChanging();
					this._jouclass = value;
					this.SendPropertyChanged("jouclass");
					this.OnjouclassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="journal_Paper", Storage="_Papers", ThisKey="journalTitle", OtherKey="jouTitle")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6, EmitDefaultValue=false)]
		public EntitySet<Paper> Papers
		{
			get
			{
				if ((this.serializing 
							&& (this._Papers.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Papers;
			}
			set
			{
				this._Papers.Assign(value);
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
		
		private void attach_Papers(Paper entity)
		{
			this.SendPropertyChanging();
			entity.journal = this;
		}
		
		private void detach_Papers(Paper entity)
		{
			this.SendPropertyChanging();
			entity.journal = null;
		}
		
		private void Initialize()
		{
			this._Papers = new EntitySet<Paper>(new Action<Paper>(this.attach_Papers), new Action<Paper>(this.detach_Papers));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Auther")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Auther
	{
		
		private int _auhterid;
		
		private System.Nullable<int> _autherpaperid;
		
		private string _authername;
		
		private System.Nullable<System.DateTime> _autherpaperyear;
		
		private System.Nullable<int> _autherpaperjournalclass;
		
		public Auther()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_auhterid", DbType="Int NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int auhterid
		{
			get
			{
				return this._auhterid;
			}
			set
			{
				if ((this._auhterid != value))
				{
					this._auhterid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autherpaperid", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public System.Nullable<int> autherpaperid
		{
			get
			{
				return this._autherpaperid;
			}
			set
			{
				if ((this._autherpaperid != value))
				{
					this._autherpaperid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authername", DbType="NChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string authername
		{
			get
			{
				return this._authername;
			}
			set
			{
				if ((this._authername != value))
				{
					this._authername = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autherpaperyear", DbType="Date")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.Nullable<System.DateTime> autherpaperyear
		{
			get
			{
				return this._autherpaperyear;
			}
			set
			{
				if ((this._autherpaperyear != value))
				{
					this._autherpaperyear = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autherpaperjournalclass", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public System.Nullable<int> autherpaperjournalclass
		{
			get
			{
				return this._autherpaperjournalclass;
			}
			set
			{
				if ((this._autherpaperjournalclass != value))
				{
					this._autherpaperjournalclass = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Paper")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Paper : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _paperId;
		
		private string _papTitle;
		
		private string _jouTitle;
		
		private System.Nullable<int> _issunumber;
		
		private System.Nullable<int> _volumenumber;
		
		private System.Nullable<int> _NumoFAuther;
		
		private string _Authers;
		
		private System.Nullable<int> _FirstPagePaper;
		
		private System.Nullable<int> _LastpagePaper;
		
		private string _abstract;
		
		private string _Keywords;
		
		private System.Nullable<int> _Yearofpub;
		
		private EntityRef<journal> _journal;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpaperIdChanging(int value);
    partial void OnpaperIdChanged();
    partial void OnpapTitleChanging(string value);
    partial void OnpapTitleChanged();
    partial void OnjouTitleChanging(string value);
    partial void OnjouTitleChanged();
    partial void OnissunumberChanging(System.Nullable<int> value);
    partial void OnissunumberChanged();
    partial void OnvolumenumberChanging(System.Nullable<int> value);
    partial void OnvolumenumberChanged();
    partial void OnNumoFAutherChanging(System.Nullable<int> value);
    partial void OnNumoFAutherChanged();
    partial void OnAuthersChanging(string value);
    partial void OnAuthersChanged();
    partial void OnFirstPagePaperChanging(System.Nullable<int> value);
    partial void OnFirstPagePaperChanged();
    partial void OnLastpagePaperChanging(System.Nullable<int> value);
    partial void OnLastpagePaperChanged();
    partial void OnabstractChanging(string value);
    partial void OnabstractChanged();
    partial void OnKeywordsChanging(string value);
    partial void OnKeywordsChanged();
    partial void OnYearofpubChanging(System.Nullable<int> value);
    partial void OnYearofpubChanged();
    #endregion
		
		public Paper()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paperId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int paperId
		{
			get
			{
				return this._paperId;
			}
			set
			{
				if ((this._paperId != value))
				{
					this.OnpaperIdChanging(value);
					this.SendPropertyChanging();
					this._paperId = value;
					this.SendPropertyChanged("paperId");
					this.OnpaperIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_papTitle", DbType="NChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string papTitle
		{
			get
			{
				return this._papTitle;
			}
			set
			{
				if ((this._papTitle != value))
				{
					this.OnpapTitleChanging(value);
					this.SendPropertyChanging();
					this._papTitle = value;
					this.SendPropertyChanged("papTitle");
					this.OnpapTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jouTitle", DbType="NChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string jouTitle
		{
			get
			{
				return this._jouTitle;
			}
			set
			{
				if ((this._jouTitle != value))
				{
					if (this._journal.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnjouTitleChanging(value);
					this.SendPropertyChanging();
					this._jouTitle = value;
					this.SendPropertyChanged("jouTitle");
					this.OnjouTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_issunumber", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.Nullable<int> issunumber
		{
			get
			{
				return this._issunumber;
			}
			set
			{
				if ((this._issunumber != value))
				{
					this.OnissunumberChanging(value);
					this.SendPropertyChanging();
					this._issunumber = value;
					this.SendPropertyChanged("issunumber");
					this.OnissunumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_volumenumber", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public System.Nullable<int> volumenumber
		{
			get
			{
				return this._volumenumber;
			}
			set
			{
				if ((this._volumenumber != value))
				{
					this.OnvolumenumberChanging(value);
					this.SendPropertyChanging();
					this._volumenumber = value;
					this.SendPropertyChanged("volumenumber");
					this.OnvolumenumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumoFAuther", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public System.Nullable<int> NumoFAuther
		{
			get
			{
				return this._NumoFAuther;
			}
			set
			{
				if ((this._NumoFAuther != value))
				{
					this.OnNumoFAutherChanging(value);
					this.SendPropertyChanging();
					this._NumoFAuther = value;
					this.SendPropertyChanged("NumoFAuther");
					this.OnNumoFAutherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Authers", DbType="NChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public string Authers
		{
			get
			{
				return this._Authers;
			}
			set
			{
				if ((this._Authers != value))
				{
					this.OnAuthersChanging(value);
					this.SendPropertyChanging();
					this._Authers = value;
					this.SendPropertyChanged("Authers");
					this.OnAuthersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstPagePaper", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public System.Nullable<int> FirstPagePaper
		{
			get
			{
				return this._FirstPagePaper;
			}
			set
			{
				if ((this._FirstPagePaper != value))
				{
					this.OnFirstPagePaperChanging(value);
					this.SendPropertyChanging();
					this._FirstPagePaper = value;
					this.SendPropertyChanged("FirstPagePaper");
					this.OnFirstPagePaperChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastpagePaper", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9)]
		public System.Nullable<int> LastpagePaper
		{
			get
			{
				return this._LastpagePaper;
			}
			set
			{
				if ((this._LastpagePaper != value))
				{
					this.OnLastpagePaperChanging(value);
					this.SendPropertyChanging();
					this._LastpagePaper = value;
					this.SendPropertyChanged("LastpagePaper");
					this.OnLastpagePaperChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="abstract", Storage="_abstract", DbType="NChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=10)]
		public string @abstract
		{
			get
			{
				return this._abstract;
			}
			set
			{
				if ((this._abstract != value))
				{
					this.OnabstractChanging(value);
					this.SendPropertyChanging();
					this._abstract = value;
					this.SendPropertyChanged("@abstract");
					this.OnabstractChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Keywords", DbType="NChar(10)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=11)]
		public string Keywords
		{
			get
			{
				return this._Keywords;
			}
			set
			{
				if ((this._Keywords != value))
				{
					this.OnKeywordsChanging(value);
					this.SendPropertyChanging();
					this._Keywords = value;
					this.SendPropertyChanged("Keywords");
					this.OnKeywordsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Yearofpub", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=12)]
		public System.Nullable<int> Yearofpub
		{
			get
			{
				return this._Yearofpub;
			}
			set
			{
				if ((this._Yearofpub != value))
				{
					this.OnYearofpubChanging(value);
					this.SendPropertyChanging();
					this._Yearofpub = value;
					this.SendPropertyChanged("Yearofpub");
					this.OnYearofpubChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="journal_Paper", Storage="_journal", ThisKey="jouTitle", OtherKey="journalTitle", IsForeignKey=true)]
		public journal journal
		{
			get
			{
				return this._journal.Entity;
			}
			set
			{
				journal previousValue = this._journal.Entity;
				if (((previousValue != value) 
							|| (this._journal.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._journal.Entity = null;
						previousValue.Papers.Remove(this);
					}
					this._journal.Entity = value;
					if ((value != null))
					{
						value.Papers.Add(this);
						this._jouTitle = value.journalTitle;
					}
					else
					{
						this._jouTitle = default(string);
					}
					this.SendPropertyChanged("journal");
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
		
		private void Initialize()
		{
			this._journal = default(EntityRef<journal>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
}
#pragma warning restore 1591
