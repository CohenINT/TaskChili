<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>



    <link href="css/bootstrap.css" rel="stylesheet" />


</head>
<body>
    <form id="form1" runat="server">
        <div>
         





            <asp:GridView ID="GridView1" runat="server" ViewStateMode="Enabled" EnableViewState="true" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" 
                DataKeyNames="ItameCode" AllowSorting="true" OnSorting="GridView1_Sorting" OnDataBinding="GridView1_DataBinding">
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

           <br />
            <asp:TextBox runat="server" ID="txt_filter"></asp:TextBox>
            <asp:Button OnClick="btn_filter_Click" runat="server" Width="220px"  ID="btn_filter" Text="סינון"/>
            


        </div>
    </form>

    <script src="js/jquery-3.4.1.js"></script>
    <script src="js/bootstrap.js"></script>

</body>
</html>
