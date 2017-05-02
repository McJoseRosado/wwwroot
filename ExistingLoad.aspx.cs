using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace RenuOil
{
    public partial class ExistingLoad : System.Web.UI.Page
    {
        public DataTable ExistingLoadsData;
        protected void Page_Load(object sender, EventArgs e)
        {
            ExistingLoadsData = new DataTable("ExistingLoads");


            ExistingLoadsData.Columns.Add("LoadDate", typeof(DateTime));
            ExistingLoadsData.Columns.Add("Driver", typeof(string));
            ExistingLoadsData.Columns.Add("LoadNumber", typeof(int));
            
           
            ExistingLoadsData.Rows.Add(new DateTime(2016,1,14), "Jonathan", "2");
            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 14), "Billy", "1");
            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 14), "Jonathan", "1");
            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 13), "Steven", "4");
            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 13), "Jonathan", "5");
            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 13), "Michael", "3");

           
            //RGExisitingLoads.DataSource = ExistingLoadsData;
            GVExisitingLoads.DataSource = ExistingLoadsData;
            GVExisitingLoads.DataBind();

        }

        protected void RGExisitingLoads_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            //RGExisitingLoads.DataSource = SqlDataSource1;
        }
        public DataTable GetDataTable(string query)
        {
            ExistingLoadsData = new DataTable("ExistingLoads");


            ExistingLoadsData.Columns.Add("Date", typeof(DateTime));
            ExistingLoadsData.Columns.Add("Driver", typeof(string));
            ExistingLoadsData.Columns.Add("Load", typeof(int));


            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 14), "Jonathan", "2");
            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 14), "Billy", "1");
            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 14), "Jonathan", "1");
            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 13), "Steven", "4");
            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 13), "Jonathan", "5");
            ExistingLoadsData.Rows.Add(new DateTime(2016, 1, 13), "Michael", "3");
            return ExistingLoadsData;
        }

        protected void RGExisitingLoads_UpdateCommand(object source, GridCommandEventArgs e)
        {
            //Console.WriteLine(e.Item.Cells[0].Text);
            Console.WriteLine(" Table to be updated: " + e.Item.OwnerTableView.DataMember );
            GridEditableItem editedItem = e.Item as GridEditableItem;
            GridEditManager editMan = editedItem.EditManager;
            int targetId = 0;
            string Driver = string.Empty;
            foreach (GridColumn column in e.Item.OwnerTableView.RenderColumns)
            {
                if (column is IGridEditableColumn)
                {
                    IGridEditableColumn editableCol = (column as IGridEditableColumn);
                    if (editableCol.IsEditable)
                    {
                        IGridColumnEditor editor = editMan.GetColumnEditor(editableCol);
                        string editorText = "unknown";
                        object editorValue = null;
                        if (editor is GridTextColumnEditor)
                        {
                            if (editableCol.Column.OrderIndex == 0)
                            editorText = (editor as GridTextColumnEditor).Text;
                            editorValue = (editor as GridTextColumnEditor).Text;
                            if (editableCol.Column.OrderIndex == 0)
                            {
                                targetId = int.Parse(editorText);
                            }
                            else if
                                (editableCol.Column.OrderIndex == 2)
                            {
                                Driver = editorText;
                            }
                        }
                        if (editor is GridBoolColumnEditor)
                        {
                            editorText = (editor as GridBoolColumnEditor).Value.ToString();
                            editorValue = (editor as GridBoolColumnEditor).Value;
                        }
                        if (editor is GridDropDownColumnEditor)
                        {
                            editorText = (editor as GridDropDownColumnEditor).SelectedText + "; " +
                             (editor as GridDropDownColumnEditor).SelectedValue;
                            editorValue = (editor as GridDropDownColumnEditor).SelectedValue;
                        }
                        try
                        {
                            //SqlDataSource1.UpdateParameters.Add("LoadId", targetId.ToString());
                            //SqlDataSource1.UpdateParameters.Add("Driver", Driver);
                            ////SqlDataSource1.UpdateParameters.Add("Driver", Driver);
                            //SqlDataSource1.Update();
                            // DataRow[] changedRows = this.GridSource.Select("OrderID = " + editedItem.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["OrderID"].ToString());
                           // changedRows[0][column.UniqueName] = editorValue;
                           // this.GridSource.AcceptChanges();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unable to set value of column '" + column.UniqueName  + "  "  + ex.Message);
                            e.Canceled = true;
                            break;
                        }
                    }
                }
            }
            //SqlDataSource1.UpdateParameters.Add("LoadId", targetId.ToString());
           // SqlDataSource1.UpdateParameters.Add("Driver", Driver);
            //SqlDataSource1.UpdateParameters.Add("Driver", Driver);
            //SqlDataSource1.Update();
        }
    }
}