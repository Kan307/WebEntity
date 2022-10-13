using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEntity
{
    public partial class GridViewDataBindingSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// GridViewにデータを供給するメソッド
        /// </summary>
        /// <returns>Personオブジェクトのリスト</returns>
        /// 
        public ICollection<Person> SelectData()
        {
            //Personのリストを作成して返す
            var list = new List<Person>();
            list.Add(new Person() { LastName = "土井", FirstName = "毅" });
            list.Add(new Person() { LastName = "山田", FirstName = "太郎" });
            return list;
        }

        /// <summary>
        /// SelectDataメソッドで返す人物クラス
        /// </summary>
        public class Person
        {
            public string LastName { get; set; } //姓
            public string FirstName { get; set; } //名
        }

    }
}