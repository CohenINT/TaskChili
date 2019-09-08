using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;

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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();

        }
    }
}