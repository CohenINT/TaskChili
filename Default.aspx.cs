using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    public DataTable SearchResTbl
    {
        set { ViewState["_SearchResTb"] = value; }
        get { return (DataTable)ViewState["_SearchResTb"]; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindData();
    }

    private void BindData()
    {
        SearchResTbl = null;
        SearchResTbl = new DataAcces("NAME_OF_YOUR_STORED_PROC", CommandType.StoredProcedure, null, Enums.ExecuteType.DataTable).ResultDataTable;
        GridView1.DataBind();
        

    }

    protected void GridView1_DataBinding(object sender, EventArgs e)
    {
        ((GridView)sender).DataSource = SearchResTbl;
    }
}