using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebEntity
{
    public class CustomSeedInitializer : DropCreateDatabaseAlways<MyModel>
    {
        protected override void Seed(MyModel context)
        {
            base.Seed(context);

            //以降にcontextを使って初期データを投入するロジックを記す

            var department1 = new Department()
            {
                Name = "営業1課"
            };

            var department2 = new Department()
            {
                Name = "営業2課"
            };

            var department3 = new Department()
            {
                Name = "海外営業部"
            };


            var employee1 = new Employee()
            {
                Name = "土井",
                Birthday = DateTime.Parse("1987-10-25"),
                Department = department1
            };

            var employee2 = new Employee()
            {
                Name = "中村",
                Birthday = DateTime.Parse("1975-9-2"),
                Department = department1
            };

            var employee3 = new Employee()
            {
                Name = "川口",
                Birthday = DateTime.Parse("1975-11-20"),
                Department = department2
            };

            var employee4 = new Employee()
            {
                Name = "田中",
                Birthday = DateTime.Parse("1986-12-1"),
                Department = department2
            };

            var employee5 = new Employee()
            {
                Name = "石川",
                Birthday = DateTime.Parse("1985-5-2"),
                Department = department3
            };

            var employee6 = new Employee()
            {
                Name = "関根",
                Birthday = DateTime.Parse("1996-7-12"),
                Department = department3
            };

            //従業員の追加
            context.Employees.Add(employee1);
            context.Employees.Add(employee2);
            context.Employees.Add(employee3);
            context.Employees.Add(employee4);
            context.Employees.Add(employee5);
            context.Employees.Add(employee6);

            //データベースへ反映
            context.SaveChanges();
        }
        
    }
}