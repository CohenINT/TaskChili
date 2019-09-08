<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
       





            <asp:GridView ID="GridView1" runat="server" ViewStateMode="Enabled" EnableViewState="true" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" 
                DataKeyNames="ItameCode" OnDataBinding="GridView1_DataBinding">
                <Columns>
                    <asp:BoundField HeaderText="דירוג המוצר" DataField="ItameRank" SortExpression="ItameRank" />
                    <asp:BoundField HeaderText="מק''ט" DataField="ItameCode" SortExpression="ItameCode" />
                    <asp:BoundField HeaderText="תאור מוצר" DataField="ItemDesc" SortExpression="ItemDesc" />
                    <asp:BoundField HeaderText="סך היקף מכירות המוצר ברשת" DataField="TotalSales" SortExpression="TotalSales" />
                    <asp:BoundField HeaderText="קוד חנות" DataField="StoreCode" SortExpression="StoreCode" />
                    <asp:BoundField HeaderText="שם חנות" DataField="StoreDesc" SortExpression="StoreDesc" />
                    <asp:BoundField HeaderText="היקף מכירות המוצר בחנות" DataField="TotalStoreSales" SortExpression="TotalStoreSales" />
                </Columns>
                <EmptyDataTemplate>
                    <label>- no data -</label>
                </EmptyDataTemplate>                
            </asp:GridView>





        </div>
    </form>
</body>
</html>
