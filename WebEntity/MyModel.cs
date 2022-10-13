using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Xml;

namespace WebEntity
{
    public class MyModel : DbContext
    {
        // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'MyModel' 
        // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
        // の 'WebEntity.MyModel' データベースを対象としています。 
        // 
        // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
        // アプリケーション構成ファイルで 'MyModel' 接続文字列を変更してください。
        public MyModel()
            //: base("name=MyModel")
            : base("name=MyConnection1")
        {
        }

        // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }



    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    //①社員エンティティクラス
    public class Employee
    {

        //②社員ID。主キー
        public int EmployeeID{ get; set; }

        //③名前（最大長50文字）
        [StringLength(50)]
        public String Name { get; set; }

        //④誕生日 
        public DateTime Birthday{ get; set; }

        //⑤今期売上
        public decimal Sales{ get; set; }

        //⑥電話番号（最大長50文字）
        [StringLength(50)]
        public String TelMo { get; set; }

        //⑦性別（true:男性。　False：女性。）
        public bool Sex { get; set; }

        //⑧課ID
        public int DepartmentId { get; set; }

        //⑨所属する課のエンティティ
        public virtual Department Department { get; set; }

    }

    //部門エンティティクラス
    public class Department
    {

        //主キー
        public int DepartmentId { get; set; }

        //部門名
        [StringLength(50)]
        public String Name { get; set; }

        //①従業員リスト
        public virtual ICollection<Employee> Employees { get; set; }

    }
}