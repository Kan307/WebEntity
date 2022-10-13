using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEntity
{
    public partial class EFTest01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string content = "";

            //①コンテキストクラスのインスタンスを作成
            using (var context = new MyModel())
            {
                //②従業員一覧を取得
                var employees = context.Employees;

                //③従業員一人ひとりを処理
                foreach(var employee in employees)
                {
                    //④情報を文字列にして連結
                    content += string.Format("Id: {0},Name: {1},DepartmentName: {2}" +
                        "<br />", employee.EmployeeID,employee.Name,
                        employee.Department.Name);

                }

                //文字列を画面に表示
                Label1.Text = content;
            }



        }

    }
}