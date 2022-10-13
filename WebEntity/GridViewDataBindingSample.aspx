<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewDataBindingSample.aspx.cs" Inherits="WebEntity.GridViewDataBindingSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<asp:GridView ID="GridView1" runat="server" SelectMethod="SelectData" AutoGenerateColumns="false">
    <Columns>
        <asp:TemplateField HeaderText="姓">
            <ItemTemplate>
                <%#: Eval("LastName") %>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="名">
            <ItemTemplate>
                <%#: Eval("FirstName") %>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
    
    </div>
    </form>
</body>
</html>
