//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3615
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("A0600_EF.Sample", "main_id_cons", "test_main", global::System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(A0600_EF.Sample.test_main), "test_sub", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(A0600_EF.Sample.test_sub))]

// 原始文件名: Test.ObjectLayer.cs
// 生成日期: 2010-12-16 22:19:13
namespace A0600_EF.Sample
{
    
    /// <summary>
    /// 架构中不存在 TestContext 的注释。
    /// </summary>
    public partial class TestContext : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// 请使用应用程序配置文件的“TestContext”部分中的连接字符串初始化新 TestContext 对象。
        /// </summary>
        public TestContext() : 
                base("name=TestContext", "TestContext")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// 初始化新的 TestContext 对象。
        /// </summary>
        public TestContext(string connectionString) : 
                base(connectionString, "TestContext")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// 初始化新的 TestContext 对象。
        /// </summary>
        public TestContext(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "TestContext")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// 架构中不存在 test_main 的注释。
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<test_main> test_main
        {
            get
            {
                if ((this._test_main == null))
                {
                    this._test_main = base.CreateQuery<test_main>("[test_main]");
                }
                return this._test_main;
            }
        }
        private global::System.Data.Objects.ObjectQuery<test_main> _test_main;
        /// <summary>
        /// 架构中不存在 test_sub 的注释。
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<test_sub> test_sub
        {
            get
            {
                if ((this._test_sub == null))
                {
                    this._test_sub = base.CreateQuery<test_sub>("[test_sub]");
                }
                return this._test_sub;
            }
        }
        private global::System.Data.Objects.ObjectQuery<test_sub> _test_sub;
        /// <summary>
        /// 架构中不存在 test_main 的注释。
        /// </summary>
        public void AddTotest_main(test_main test_main)
        {
            base.AddObject("test_main", test_main);
        }
        /// <summary>
        /// 架构中不存在 test_sub 的注释。
        /// </summary>
        public void AddTotest_sub(test_sub test_sub)
        {
            base.AddObject("test_sub", test_sub);
        }
    }
    /// <summary>
    /// 架构中不存在 A0600_EF.Sample.test_main 的注释。
    /// </summary>
    /// <KeyProperties>
    /// id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="A0600_EF.Sample", Name="test_main")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class test_main : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// 创建新的 test_main 对象。
        /// </summary>
        /// <param name="id">id 的初始值。</param>
        public static test_main Createtest_main(int id)
        {
            test_main test_main = new test_main();
            test_main.id = id;
            return test_main;
        }
        /// <summary>
        /// 架构中不存在属性 id 的注释。
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                this.OnidChanging(value);
                this.ReportPropertyChanging("id");
                this._id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("id");
                this.OnidChanged();
            }
        }
        private int _id;
        partial void OnidChanging(int value);
        partial void OnidChanged();
        /// <summary>
        /// 架构中不存在属性 value 的注释。
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string value
        {
            get
            {
                return this._value;
            }
            set
            {
                this.OnvalueChanging(value);
                this.ReportPropertyChanging("value");
                this._value = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("value");
                this.OnvalueChanged();
            }
        }
        private string _value;
        partial void OnvalueChanging(string value);
        partial void OnvalueChanged();
        /// <summary>
        /// 架构中不存在 test_sub 的注释。
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("A0600_EF.Sample", "main_id_cons", "test_sub")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<test_sub> test_sub
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<test_sub>("A0600_EF.Sample.main_id_cons", "test_sub");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<test_sub>("A0600_EF.Sample.main_id_cons", "test_sub", value);
                }
            }
        }
    }
    /// <summary>
    /// 架构中不存在 A0600_EF.Sample.test_sub 的注释。
    /// </summary>
    /// <KeyProperties>
    /// id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="A0600_EF.Sample", Name="test_sub")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class test_sub : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// 创建新的 test_sub 对象。
        /// </summary>
        /// <param name="id">id 的初始值。</param>
        public static test_sub Createtest_sub(int id)
        {
            test_sub test_sub = new test_sub();
            test_sub.id = id;
            return test_sub;
        }
        /// <summary>
        /// 架构中不存在属性 id 的注释。
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                this.OnidChanging(value);
                this.ReportPropertyChanging("id");
                this._id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("id");
                this.OnidChanged();
            }
        }
        private int _id;
        partial void OnidChanging(int value);
        partial void OnidChanged();
        /// <summary>
        /// 架构中不存在属性 value 的注释。
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string value
        {
            get
            {
                return this._value;
            }
            set
            {
                this.OnvalueChanging(value);
                this.ReportPropertyChanging("value");
                this._value = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("value");
                this.OnvalueChanged();
            }
        }
        private string _value;
        partial void OnvalueChanging(string value);
        partial void OnvalueChanged();
        /// <summary>
        /// 架构中不存在 test_main 的注释。
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("A0600_EF.Sample", "main_id_cons", "test_main")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public test_main test_main
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<test_main>("A0600_EF.Sample.main_id_cons", "test_main").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<test_main>("A0600_EF.Sample.main_id_cons", "test_main").Value = value;
            }
        }
        /// <summary>
        /// 架构中不存在 test_main 的注释。
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<test_main> test_mainReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<test_main>("A0600_EF.Sample.main_id_cons", "test_main");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<test_main>("A0600_EF.Sample.main_id_cons", "test_main", value);
                }
            }
        }
    }
}
