﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace DB2DataContext
{
	public partial class TESTDATADB : LinqToDB.Data.DataConnection
	{
		public ITable<DB2ADMIN_ALLTYPE>           ALLTYPES            { get { return this.GetTable<DB2ADMIN_ALLTYPE>(); } }
		public ITable<DB2ADMIN_Child>             Children            { get { return this.GetTable<DB2ADMIN_Child>(); } }
		public ITable<DB2ADMIN_Doctor>            Doctors             { get { return this.GetTable<DB2ADMIN_Doctor>(); } }
		public ITable<DB2ADMIN_GrandChild>        GrandChildren       { get { return this.GetTable<DB2ADMIN_GrandChild>(); } }
		public ITable<DB2ADMIN_InheritanceChild>  InheritanceChildren { get { return this.GetTable<DB2ADMIN_InheritanceChild>(); } }
		public ITable<DB2ADMIN_InheritanceParent> InheritanceParents  { get { return this.GetTable<DB2ADMIN_InheritanceParent>(); } }
		public ITable<DB2ADMIN_KeepIdentityTest>  KeepIdentityTests   { get { return this.GetTable<DB2ADMIN_KeepIdentityTest>(); } }
		public ITable<DB2ADMIN_LinqDataType>      LinqDataTypes       { get { return this.GetTable<DB2ADMIN_LinqDataType>(); } }
		public ITable<DB2ADMIN_MASTERTABLE>       Mastertables        { get { return this.GetTable<DB2ADMIN_MASTERTABLE>(); } }
		public ITable<DB2ADMIN_Parent>            Parents             { get { return this.GetTable<DB2ADMIN_Parent>(); } }
		public ITable<DB2ADMIN_Patient>           Patients            { get { return this.GetTable<DB2ADMIN_Patient>(); } }
		public ITable<DB2ADMIN_Person>            People              { get { return this.GetTable<DB2ADMIN_Person>(); } }
		public ITable<DB2ADMIN_PERSONVIEW>        Personviews         { get { return this.GetTable<DB2ADMIN_PERSONVIEW>(); } }
		public ITable<DB2ADMIN_SLAVETABLE>        Slavetables         { get { return this.GetTable<DB2ADMIN_SLAVETABLE>(); } }
		public ITable<DB2ADMIN_Test>              Tests               { get { return this.GetTable<DB2ADMIN_Test>(); } }
		public ITable<DB2ADMIN_TestIdentity>      TestIdentities      { get { return this.GetTable<DB2ADMIN_TestIdentity>(); } }
		public ITable<DB2ADMIN_TestIdTrun>        TestIdTruns         { get { return this.GetTable<DB2ADMIN_TestIdTrun>(); } }
		public ITable<DB2ADMIN_Testmerge1>        Testmerge1          { get { return this.GetTable<DB2ADMIN_Testmerge1>(); } }
		public ITable<DB2ADMIN_TestMerge1>        TestMerge1          { get { return this.GetTable<DB2ADMIN_TestMerge1>(); } }
		public ITable<DB2ADMIN_Testmerge2>        Testmerge2          { get { return this.GetTable<DB2ADMIN_Testmerge2>(); } }
		public ITable<DB2ADMIN_TestMerge2>        TestMerge2          { get { return this.GetTable<DB2ADMIN_TestMerge2>(); } }

		public TESTDATADB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TESTDATADB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();
	}

	[Table(Schema="DB2ADMIN", Name="ALLTYPES")]
	public partial class DB2ADMIN_ALLTYPE
	{
		[Column(DbType="INTEGER",                  DataType=DataType.Int32),                     PrimaryKey, Identity] public int       ID                { get; set; } // INTEGER
		[Column(DbType="BIGINT",                   DataType=DataType.Int64),                     Nullable            ] public long?     BIGINTDATATYPE    { get; set; } // BIGINT
		[Column(DbType="INTEGER",                  DataType=DataType.Int32),                     Nullable            ] public int?      INTDATATYPE       { get; set; } // INTEGER
		[Column(DbType="SMALLINT",                 DataType=DataType.Int16),                     Nullable            ] public short?    SMALLINTDATATYPE  { get; set; } // SMALLINT
		[Column(DbType="DECIMAL",                  DataType=DataType.Decimal,   Precision=30),   Nullable            ] public decimal?  DECIMALDATATYPE   { get; set; } // DECIMAL
		[Column(DbType="DECFLOAT(16)",             DataType=DataType.Decimal,   Precision=16),   Nullable            ] public decimal?  DECFLOATDATATYPE  { get; set; } // DECFLOAT(16)
		[Column(DbType="REAL",                     DataType=DataType.Single),                    Nullable            ] public float?    REALDATATYPE      { get; set; } // REAL
		[Column(DbType="DOUBLE",                   DataType=DataType.Double),                    Nullable            ] public double?   DOUBLEDATATYPE    { get; set; } // DOUBLE
		[Column(DbType="CHARACTER(1)",             DataType=DataType.Char,      Length=1),       Nullable            ] public char?     CHARDATATYPE      { get; set; } // CHARACTER(1)
		[Column(DbType="CHARACTER(20)",            DataType=DataType.Char,      Length=20),      Nullable            ] public string    CHAR20DATATYPE    { get; set; } // CHARACTER(20)
		[Column(DbType="VARCHAR(20)",              DataType=DataType.VarChar,   Length=20),      Nullable            ] public string    VARCHARDATATYPE   { get; set; } // VARCHAR(20)
		[Column(DbType="CLOB(1048576)",            DataType=DataType.Text,      Length=1048576), Nullable            ] public string    CLOBDATATYPE      { get; set; } // CLOB(1048576)
		[Column(DbType="DBCLOB(100)",              DataType=DataType.Text,      Length=100),     Nullable            ] public string    DBCLOBDATATYPE    { get; set; } // DBCLOB(100)
		[Column(DbType="CHAR (5) FOR BIT DATA",    DataType=DataType.Binary,    Length=5),       Nullable            ] public byte[]    BINARYDATATYPE    { get; set; } // CHAR (5) FOR BIT DATA
		[Column(DbType="VARCHAR (5) FOR BIT DATA", DataType=DataType.VarBinary, Length=5),       Nullable            ] public byte[]    VARBINARYDATATYPE { get; set; } // VARCHAR (5) FOR BIT DATA
		[Column(DbType="BLOB(1048576)",            DataType=DataType.Blob,      Length=1048576), Nullable            ] public byte[]    BLOBDATATYPE      { get; set; } // BLOB(1048576)
		[Column(DbType="GRAPHIC(10)",              DataType=DataType.Text,      Length=10),      Nullable            ] public string    GRAPHICDATATYPE   { get; set; } // GRAPHIC(10)
		[Column(DbType="DATE",                     DataType=DataType.Date),                      Nullable            ] public DateTime? DATEDATATYPE      { get; set; } // DATE
		[Column(DbType="TIME",                     DataType=DataType.Time),                      Nullable            ] public TimeSpan? TIMEDATATYPE      { get; set; } // TIME
		[Column(DbType="TIMESTAMP",                DataType=DataType.Timestamp),                 Nullable            ] public DateTime? TIMESTAMPDATATYPE { get; set; } // TIMESTAMP
		[Column(DbType="XML",                      DataType=DataType.Xml),                       Nullable            ] public string    XMLDATATYPE       { get; set; } // XML
	}

	[Table(Schema="DB2ADMIN", Name="Child")]
	public partial class DB2ADMIN_Child
	{
		[Column(DbType="INTEGER", DataType=DataType.Int32), Nullable] public int? ParentID { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=DataType.Int32), Nullable] public int? ChildID  { get; set; } // INTEGER
	}

	[Table(Schema="DB2ADMIN", Name="Doctor")]
	public partial class DB2ADMIN_Doctor
	{
		[Column(DbType="INTEGER",     DataType=DataType.Int32),              PrimaryKey, NotNull] public int    PersonID { get; set; } // INTEGER
		[Column(DbType="VARCHAR(50)", DataType=DataType.VarChar, Length=50),             NotNull] public string Taxonomy { get; set; } // VARCHAR(50)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="FK_Doctor_Person", BackReferenceName="Doctor")]
		public DB2ADMIN_Person Person { get; set; }

		#endregion
	}

	[Table(Schema="DB2ADMIN", Name="GrandChild")]
	public partial class DB2ADMIN_GrandChild
	{
		[Column(DbType="INTEGER", DataType=DataType.Int32), Nullable] public int? ParentID     { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=DataType.Int32), Nullable] public int? ChildID      { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=DataType.Int32), Nullable] public int? GrandChildID { get; set; } // INTEGER
	}

	[Table(Schema="DB2ADMIN", Name="InheritanceChild")]
	public partial class DB2ADMIN_InheritanceChild
	{
		[Column(DbType="INTEGER",     DataType=DataType.Int32),              PrimaryKey,  NotNull] public int    InheritanceChildId  { get; set; } // INTEGER
		[Column(DbType="INTEGER",     DataType=DataType.Int32),                           NotNull] public int    InheritanceParentId { get; set; } // INTEGER
		[Column(DbType="INTEGER",     DataType=DataType.Int32),                 Nullable         ] public int?   TypeDiscriminator   { get; set; } // INTEGER
		[Column(DbType="VARCHAR(50)", DataType=DataType.VarChar, Length=50),    Nullable         ] public string Name                { get; set; } // VARCHAR(50)
	}

	[Table(Schema="DB2ADMIN", Name="InheritanceParent")]
	public partial class DB2ADMIN_InheritanceParent
	{
		[Column(DbType="INTEGER",     DataType=DataType.Int32),              PrimaryKey,  NotNull] public int    InheritanceParentId { get; set; } // INTEGER
		[Column(DbType="INTEGER",     DataType=DataType.Int32),                 Nullable         ] public int?   TypeDiscriminator   { get; set; } // INTEGER
		[Column(DbType="VARCHAR(50)", DataType=DataType.VarChar, Length=50),    Nullable         ] public string Name                { get; set; } // VARCHAR(50)
	}

	[Table(Schema="DB2ADMIN", Name="KeepIdentityTest")]
	public partial class DB2ADMIN_KeepIdentityTest
	{
		[Column(DbType="INTEGER", DataType=DataType.Int32), PrimaryKey, Identity] public int  ID    { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=DataType.Int32), Nullable            ] public int? Value { get; set; } // INTEGER
	}

	[Table(Schema="DB2ADMIN", Name="LinqDataTypes")]
	public partial class DB2ADMIN_LinqDataType
	{
		[Column(DbType="INTEGER",                DataType=DataType.Int32),                            Nullable] public int?      ID             { get; set; } // INTEGER
		[Column(DbType="DECIMAL(10,4)",          DataType=DataType.Decimal,   Precision=10, Scale=4), Nullable] public decimal?  MoneyValue     { get; set; } // DECIMAL(10,4)
		[Column(DbType="TIMESTAMP",              DataType=DataType.Timestamp),                        Nullable] public DateTime? DateTimeValue  { get; set; } // TIMESTAMP
		[Column(DbType="TIMESTAMP",              DataType=DataType.Timestamp),                        Nullable] public DateTime? DateTimeValue2 { get; set; } // TIMESTAMP
		[Column(DbType="SMALLINT",               DataType=DataType.Int16),                            Nullable] public short?    BoolValue      { get; set; } // SMALLINT
		[Column(DbType="CHAR (16) FOR BIT DATA", DataType=DataType.Binary,    Length=16),             Nullable] public byte[]    GuidValue      { get; set; } // CHAR (16) FOR BIT DATA
		[Column(DbType="BLOB(5000)",             DataType=DataType.Blob,      Length=5000),           Nullable] public byte[]    BinaryValue    { get; set; } // BLOB(5000)
		[Column(DbType="SMALLINT",               DataType=DataType.Int16),                            Nullable] public short?    SmallIntValue  { get; set; } // SMALLINT
		[Column(DbType="INTEGER",                DataType=DataType.Int32),                            Nullable] public int?      IntValue       { get; set; } // INTEGER
		[Column(DbType="BIGINT",                 DataType=DataType.Int64),                            Nullable] public long?     BigIntValue    { get; set; } // BIGINT
		[Column(DbType="VARCHAR(50)",            DataType=DataType.VarChar,   Length=50),             Nullable] public string    StringValue    { get; set; } // VARCHAR(50)
	}

	[Table(Schema="DB2ADMIN", Name="MASTERTABLE")]
	public partial class DB2ADMIN_MASTERTABLE
	{
		[Column(DbType="INTEGER", DataType=DataType.Int32), PrimaryKey(0), NotNull] public int ID1 { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=DataType.Int32), PrimaryKey(1), NotNull] public int ID2 { get; set; } // INTEGER

		#region Associations

		/// <summary>
		/// FK_SLAVETABLE_MASTERTABLE_BackReference
		/// </summary>
		[Association(ThisKey="ID1, ID2", OtherKey="ID222222222222222222222222, ID1", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<DB2ADMIN_SLAVETABLE> Slavetables { get; set; }

		#endregion
	}

	[Table(Schema="DB2ADMIN", Name="Parent")]
	public partial class DB2ADMIN_Parent
	{
		[Column(DbType="INTEGER", DataType=DataType.Int32), Nullable] public int? ParentID { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=DataType.Int32), Nullable] public int? Value1   { get; set; } // INTEGER
	}

	[Table(Schema="DB2ADMIN", Name="Patient")]
	public partial class DB2ADMIN_Patient
	{
		[Column(DbType="INTEGER",      DataType=DataType.Int32),               PrimaryKey, NotNull] public int    PersonID  { get; set; } // INTEGER
		[Column(DbType="VARCHAR(256)", DataType=DataType.VarChar, Length=256),             NotNull] public string Diagnosis { get; set; } // VARCHAR(256)

		#region Associations

		/// <summary>
		/// FK_Patient_Person
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="FK_Patient_Person", BackReferenceName="Patient")]
		public DB2ADMIN_Person Person { get; set; }

		#endregion
	}

	[Table(Schema="DB2ADMIN", Name="Person")]
	public partial class DB2ADMIN_Person
	{
		[Column(DbType="INTEGER",      DataType=DataType.Int32),              PrimaryKey,  Identity] public int    PersonID   { get; set; } // INTEGER
		[Column(DbType="VARCHAR(50)",  DataType=DataType.VarChar, Length=50), NotNull              ] public string FirstName  { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(50)",  DataType=DataType.VarChar, Length=50), NotNull              ] public string LastName   { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(50)",  DataType=DataType.VarChar, Length=50),    Nullable          ] public string MiddleName { get; set; } // VARCHAR(50)
		[Column(DbType="CHARACTER(1)", DataType=DataType.Char,    Length=1),  NotNull              ] public char   Gender     { get; set; } // CHARACTER(1)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public DB2ADMIN_Doctor Doctor { get; set; }

		/// <summary>
		/// FK_Patient_Person_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public DB2ADMIN_Patient Patient { get; set; }

		#endregion
	}

	[Table(Schema="DB2ADMIN", Name="PERSONVIEW", IsView=true)]
	public partial class DB2ADMIN_PERSONVIEW
	{
		[Column(DbType="INTEGER",      DataType=DataType.Int32),              NotNull    ] public int    PersonID   { get; set; } // INTEGER
		[Column(DbType="VARCHAR(50)",  DataType=DataType.VarChar, Length=50), NotNull    ] public string FirstName  { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(50)",  DataType=DataType.VarChar, Length=50), NotNull    ] public string LastName   { get; set; } // VARCHAR(50)
		[Column(DbType="VARCHAR(50)",  DataType=DataType.VarChar, Length=50),    Nullable] public string MiddleName { get; set; } // VARCHAR(50)
		[Column(DbType="CHARACTER(1)", DataType=DataType.Char,    Length=1),  NotNull    ] public char   Gender     { get; set; } // CHARACTER(1)
	}

	[Table(Schema="DB2ADMIN", Name="SLAVETABLE")]
	public partial class DB2ADMIN_SLAVETABLE
	{
		[Column(                                 DbType="INTEGER", DataType=DataType.Int32), NotNull] public int ID1                        { get; set; } // INTEGER
		[Column("ID 2222222222222222222222  22", DbType="INTEGER", DataType=DataType.Int32), NotNull] public int ID222222222222222222222222 { get; set; } // INTEGER
		[Column("ID 2222222222222222",           DbType="INTEGER", DataType=DataType.Int32), NotNull] public int ID2222222222222222         { get; set; } // INTEGER

		#region Associations

		/// <summary>
		/// FK_SLAVETABLE_MASTERTABLE
		/// </summary>
		[Association(ThisKey="ID222222222222222222222222, ID1", OtherKey="ID1, ID2", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_SLAVETABLE_MASTERTABLE", BackReferenceName="Slavetables")]
		public DB2ADMIN_MASTERTABLE MASTERTABLE { get; set; }

		#endregion
	}

	[Table(Schema="DB2ADMIN", Name="Test")]
	public partial class DB2ADMIN_Test
	{
		[Column(DbType="INTEGER", DataType=DataType.Int32), NotNull    ] public int  Id           { get; set; } // INTEGER
		[Column(DbType="INTEGER", DataType=DataType.Int32),    Nullable] public int? TestAnimalId { get; set; } // INTEGER
	}

	[Table(Schema="DB2ADMIN", Name="TestIdentity")]
	public partial class DB2ADMIN_TestIdentity
	{
		[Column(DbType="INTEGER", DataType=DataType.Int32), PrimaryKey, Identity] public int ID { get; set; } // INTEGER
	}

	[Table(Schema="DB2ADMIN", Name="TestIdTrun")]
	public partial class DB2ADMIN_TestIdTrun
	{
		[Column(DbType="INTEGER", DataType=DataType.Int32),                PrimaryKey, Identity] public int     ID     { get; set; } // INTEGER
		[Column(DbType="DECIMAL", DataType=DataType.Decimal, Precision=5), NotNull             ] public decimal Field1 { get; set; } // DECIMAL
	}

	[Table(Schema="DB2ADMIN", Name="testmerge1")]
	public partial class DB2ADMIN_Testmerge1
	{
		[Column("id",     DbType="INTEGER", DataType=DataType.Int32), PrimaryKey,  NotNull] public int  Id     { get; set; } // INTEGER
		[Column("field1", DbType="INTEGER", DataType=DataType.Int32),    Nullable         ] public int? Field1 { get; set; } // INTEGER
		[Column("field2", DbType="INTEGER", DataType=DataType.Int32),    Nullable         ] public int? Field2 { get; set; } // INTEGER
		[Column("field3", DbType="INTEGER", DataType=DataType.Int32),    Nullable         ] public int? Field3 { get; set; } // INTEGER
		[Column("field4", DbType="INTEGER", DataType=DataType.Int32),    Nullable         ] public int? Field4 { get; set; } // INTEGER
		[Column("field5", DbType="INTEGER", DataType=DataType.Int32),    Nullable         ] public int? Field5 { get; set; } // INTEGER
	}

	[Table(Schema="DB2ADMIN", Name="TestMerge1")]
	public partial class DB2ADMIN_TestMerge1
	{
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                             PrimaryKey,  NotNull] public int       Id              { get; set; } // INTEGER
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      Field1          { get; set; } // INTEGER
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      Field2          { get; set; } // INTEGER
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      Field3          { get; set; } // INTEGER
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      Field4          { get; set; } // INTEGER
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      Field5          { get; set; } // INTEGER
		[Column(DbType="BIGINT",                    DataType=DataType.Int64),                                Nullable         ] public long?     FieldInt64      { get; set; } // BIGINT
		[Column(DbType="SMALLINT",                  DataType=DataType.Int16),                                Nullable         ] public short?    FieldBoolean    { get; set; } // SMALLINT
		[Column(DbType="VARCHAR(20)",               DataType=DataType.VarChar,   Length=20),                 Nullable         ] public string    FieldString     { get; set; } // VARCHAR(20)
		[Column(DbType="VARCHAR(80)",               DataType=DataType.VarChar,   Length=80),                 Nullable         ] public string    FieldNString    { get; set; } // VARCHAR(80)
		[Column(DbType="CHARACTER(1)",              DataType=DataType.Char,      Length=1),                  Nullable         ] public char?     FieldChar       { get; set; } // CHARACTER(1)
		[Column(DbType="CHARACTER(4)",              DataType=DataType.Char,      Length=4),                  Nullable         ] public string    FieldNChar      { get; set; } // CHARACTER(4)
		[Column(DbType="REAL",                      DataType=DataType.Single),                               Nullable         ] public float?    FieldFloat      { get; set; } // REAL
		[Column(DbType="DOUBLE",                    DataType=DataType.Double),                               Nullable         ] public double?   FieldDouble     { get; set; } // DOUBLE
		[Column(DbType="TIMESTAMP",                 DataType=DataType.Timestamp),                            Nullable         ] public DateTime? FieldDateTime   { get; set; } // TIMESTAMP
		[Column(DbType="VARCHAR (20) FOR BIT DATA", DataType=DataType.VarBinary, Length=20),                 Nullable         ] public byte[]    FieldBinary     { get; set; } // VARCHAR (20) FOR BIT DATA
		[Column(DbType="CHAR (16) FOR BIT DATA",    DataType=DataType.Binary,    Length=16),                 Nullable         ] public byte[]    FieldGuid       { get; set; } // CHAR (16) FOR BIT DATA
		[Column(DbType="DECIMAL(24,10)",            DataType=DataType.Decimal,   Precision=24, Scale=10),    Nullable         ] public decimal?  FieldDecimal    { get; set; } // DECIMAL(24,10)
		[Column(DbType="DATE",                      DataType=DataType.Date),                                 Nullable         ] public DateTime? FieldDate       { get; set; } // DATE
		[Column(DbType="TIME",                      DataType=DataType.Time),                                 Nullable         ] public TimeSpan? FieldTime       { get; set; } // TIME
		[Column(DbType="VARCHAR(20)",               DataType=DataType.VarChar,   Length=20),                 Nullable         ] public string    FieldEnumString { get; set; } // VARCHAR(20)
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      FieldEnumNumber { get; set; } // INTEGER
	}

	[Table(Schema="DB2ADMIN", Name="testmerge2")]
	public partial class DB2ADMIN_Testmerge2
	{
		[Column("id",     DbType="INTEGER", DataType=DataType.Int32), PrimaryKey,  NotNull] public int  Id     { get; set; } // INTEGER
		[Column("field1", DbType="INTEGER", DataType=DataType.Int32),    Nullable         ] public int? Field1 { get; set; } // INTEGER
		[Column("field2", DbType="INTEGER", DataType=DataType.Int32),    Nullable         ] public int? Field2 { get; set; } // INTEGER
		[Column("field3", DbType="INTEGER", DataType=DataType.Int32),    Nullable         ] public int? Field3 { get; set; } // INTEGER
		[Column("field4", DbType="INTEGER", DataType=DataType.Int32),    Nullable         ] public int? Field4 { get; set; } // INTEGER
		[Column("field5", DbType="INTEGER", DataType=DataType.Int32),    Nullable         ] public int? Field5 { get; set; } // INTEGER
	}

	[Table(Schema="DB2ADMIN", Name="TestMerge2")]
	public partial class DB2ADMIN_TestMerge2
	{
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                             PrimaryKey,  NotNull] public int       Id              { get; set; } // INTEGER
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      Field1          { get; set; } // INTEGER
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      Field2          { get; set; } // INTEGER
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      Field3          { get; set; } // INTEGER
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      Field4          { get; set; } // INTEGER
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      Field5          { get; set; } // INTEGER
		[Column(DbType="BIGINT",                    DataType=DataType.Int64),                                Nullable         ] public long?     FieldInt64      { get; set; } // BIGINT
		[Column(DbType="SMALLINT",                  DataType=DataType.Int16),                                Nullable         ] public short?    FieldBoolean    { get; set; } // SMALLINT
		[Column(DbType="VARCHAR(20)",               DataType=DataType.VarChar,   Length=20),                 Nullable         ] public string    FieldString     { get; set; } // VARCHAR(20)
		[Column(DbType="VARCHAR(80)",               DataType=DataType.VarChar,   Length=80),                 Nullable         ] public string    FieldNString    { get; set; } // VARCHAR(80)
		[Column(DbType="CHARACTER(1)",              DataType=DataType.Char,      Length=1),                  Nullable         ] public char?     FieldChar       { get; set; } // CHARACTER(1)
		[Column(DbType="CHARACTER(4)",              DataType=DataType.Char,      Length=4),                  Nullable         ] public string    FieldNChar      { get; set; } // CHARACTER(4)
		[Column(DbType="REAL",                      DataType=DataType.Single),                               Nullable         ] public float?    FieldFloat      { get; set; } // REAL
		[Column(DbType="DOUBLE",                    DataType=DataType.Double),                               Nullable         ] public double?   FieldDouble     { get; set; } // DOUBLE
		[Column(DbType="TIMESTAMP",                 DataType=DataType.Timestamp),                            Nullable         ] public DateTime? FieldDateTime   { get; set; } // TIMESTAMP
		[Column(DbType="VARCHAR (20) FOR BIT DATA", DataType=DataType.VarBinary, Length=20),                 Nullable         ] public byte[]    FieldBinary     { get; set; } // VARCHAR (20) FOR BIT DATA
		[Column(DbType="CHAR (16) FOR BIT DATA",    DataType=DataType.Binary,    Length=16),                 Nullable         ] public byte[]    FieldGuid       { get; set; } // CHAR (16) FOR BIT DATA
		[Column(DbType="DECIMAL(24,10)",            DataType=DataType.Decimal,   Precision=24, Scale=10),    Nullable         ] public decimal?  FieldDecimal    { get; set; } // DECIMAL(24,10)
		[Column(DbType="DATE",                      DataType=DataType.Date),                                 Nullable         ] public DateTime? FieldDate       { get; set; } // DATE
		[Column(DbType="TIME",                      DataType=DataType.Time),                                 Nullable         ] public TimeSpan? FieldTime       { get; set; } // TIME
		[Column(DbType="VARCHAR(20)",               DataType=DataType.VarChar,   Length=20),                 Nullable         ] public string    FieldEnumString { get; set; } // VARCHAR(20)
		[Column(DbType="INTEGER",                   DataType=DataType.Int32),                                Nullable         ] public int?      FieldEnumNumber { get; set; } // INTEGER
	}

	public static partial class TESTDATADBStoredProcedures
	{
		#region PersonSelectbykey

		public static int PersonSelectbykey(this DataConnection dataConnection, int? ID)
		{
			return dataConnection.ExecuteProc("DB2ADMIN.PERSON_SELECTBYKEY",
				new DataParameter("ID", ID, DataType.Int32));
		}

		#endregion

		#region ADDISSUE792RECORD

		public static int ADDISSUE792RECORD(this DataConnection dataConnection)
		{
			return dataConnection.ExecuteProc("DB2ADMIN.ADDISSUE792RECORD");
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static DB2ADMIN_ALLTYPE Find(this ITable<DB2ADMIN_ALLTYPE> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static DB2ADMIN_Doctor Find(this ITable<DB2ADMIN_Doctor> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static DB2ADMIN_InheritanceChild Find(this ITable<DB2ADMIN_InheritanceChild> table, int InheritanceChildId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceChildId == InheritanceChildId);
		}

		public static DB2ADMIN_InheritanceParent Find(this ITable<DB2ADMIN_InheritanceParent> table, int InheritanceParentId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceParentId == InheritanceParentId);
		}

		public static DB2ADMIN_KeepIdentityTest Find(this ITable<DB2ADMIN_KeepIdentityTest> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static DB2ADMIN_MASTERTABLE Find(this ITable<DB2ADMIN_MASTERTABLE> table, int ID1, int ID2)
		{
			return table.FirstOrDefault(t =>
				t.ID1 == ID1 &&
				t.ID2 == ID2);
		}

		public static DB2ADMIN_Patient Find(this ITable<DB2ADMIN_Patient> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static DB2ADMIN_Person Find(this ITable<DB2ADMIN_Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static DB2ADMIN_TestIdentity Find(this ITable<DB2ADMIN_TestIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static DB2ADMIN_TestIdTrun Find(this ITable<DB2ADMIN_TestIdTrun> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static DB2ADMIN_Testmerge1 Find(this ITable<DB2ADMIN_Testmerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static DB2ADMIN_TestMerge1 Find(this ITable<DB2ADMIN_TestMerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static DB2ADMIN_Testmerge2 Find(this ITable<DB2ADMIN_Testmerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static DB2ADMIN_TestMerge2 Find(this ITable<DB2ADMIN_TestMerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}
	}
}

#pragma warning restore 1591
