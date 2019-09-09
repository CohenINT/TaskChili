using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            SearchResTbl = new DataAcces("general_proc", CommandType.StoredProcedure, null, Enums.ExecuteType.DataTable).ResultDataTable;
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


        //when click sort on some column
        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            SqlParameter[] _params;
            
            switch (e.SortExpression)
            {
                case "ItameRank":

                    _params =new SqlParameter[]{ new SqlParameter("@sortExpression", "ItameRank")};
                    SearchResTbl = null;
                    SearchResTbl = new DataAcces("sort_proc", CommandType.StoredProcedure, _params, Enums.ExecuteType.DataTable).ResultDataTable;//call the procedure with the parameter of the specific column to sort
                    GridView1.DataBind();

                    break;

                case "ItameCode":

                    _params = new SqlParameter[] { new SqlParameter("@sortExpression", "ItameCode") };
                    SearchResTbl = null;
                    SearchResTbl = new DataAcces("sort_proc", CommandType.StoredProcedure, _params, Enums.ExecuteType.DataTable).ResultDataTable;//call the procedure with the parameter of the specific column to sort
                    GridView1.DataBind();

                    break;

                case "ItemDesc":

                    _params = new SqlParameter[] { new SqlParameter("@sortExpression", "ItemDesc") };
                    SearchResTbl = null;
                    SearchResTbl = new DataAcces("sort_proc", CommandType.StoredProcedure, _params, Enums.ExecuteType.DataTable).ResultDataTable;//call the procedure with the parameter of the specific column to sort
                    GridView1.DataBind();

                    break;

                case "TotalSales":

                    _params = new SqlParameter[] { new SqlParameter("@sortExpression", "TotalSales") };
                    SearchResTbl = null;
                    SearchResTbl = new DataAcces("sort_proc", CommandType.StoredProcedure, _params, Enums.ExecuteType.DataTable).ResultDataTable;//call the procedure with the parameter of the specific column to sort
                    GridView1.DataBind();

                    break;


                case "StoreCode":

                    _params = new SqlParameter[] { new SqlParameter("@sortExpression", "StoreCode") };
                    SearchResTbl = null;
                    SearchResTbl = new DataAcces("sort_proc", CommandType.StoredProcedure, _params, Enums.ExecuteType.DataTable).ResultDataTable;//call the procedure with the parameter of the specific column to sort
                    GridView1.DataBind();

                    break;


                case "StoreDesc":

                    _params = new SqlParameter[] { new SqlParameter("@sortExpression", "StoreDesc") };
                    SearchResTbl = null;
                    SearchResTbl = new DataAcces("sort_proc", CommandType.StoredProcedure, _params, Enums.ExecuteType.DataTable).ResultDataTable;//call the procedure with the parameter of the specific column to sort
                    GridView1.DataBind();

                    break;


                case "TotalStoreSales":

                    _params = new SqlParameter[] { new SqlParameter("@sortExpression", "TotalStoreSales") };
                    SearchResTbl = null;
                    SearchResTbl = new DataAcces("sort_proc", CommandType.StoredProcedure, _params, Enums.ExecuteType.DataTable).ResultDataTable;//call the procedure with the parameter of the specific column to sort
                    GridView1.DataBind();

                    break;







                default:
                    break;
            }


        }

        
        protected void btn_filter_Click(object sender, EventArgs e)
        {


            SearchResTbl = null;
            SearchResTbl = new DataAcces("filter_proc", CommandType.StoredProcedure, new SqlParameter[] { new SqlParameter("@filter_word", txt_filter.Text) }, Enums.ExecuteType.DataTable).ResultDataTable;
            GridView1.DataBind();
        }
    }
}