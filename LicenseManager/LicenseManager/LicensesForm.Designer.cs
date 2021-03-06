﻿using License.DB;
using License.DB.LicenseDBDataSetTableAdapters;

namespace LicenseManager
{
    partial class LicensesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            //please don't touch it
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch
            {
                //ignore
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.licensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visaLicensesDataSet = new License.DB.LicenseDBDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditReadOnly = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvailable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemToggleSwitchAvailable = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.colEstimationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditEstimationTime = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.licensesTableAdapter = new License.DB.LicenseDBDataSetTableAdapters.LicenseTableAdapter();
            customerTableAdapter = new CustomerTableAdapter();
            this.repositoryItemLookUpEditCustomerId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visaLicensesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditReadOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitchAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditEstimationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditEstimationTime.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCustomerId)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.licensesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEditReadOnly,
            this.repositoryItemToggleSwitchAvailable,
            this.repositoryItemDateEditEstimationTime,
            this.repositoryItemLookUpEditCustomerId});
            this.gridControl1.Size = new System.Drawing.Size(674, 283);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // licensesBindingSource
            // 
            this.licensesBindingSource.DataMember = "License";
            this.licensesBindingSource.DataSource = this.visaLicensesDataSet;
            // 
            // visaLicensesDataSet
            // 
            this.visaLicensesDataSet.DataSetName = "VisaLicensesDataSet";
            this.visaLicensesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGuid,
            this.colPcName,
            this.colCustomerID,
            this.colAvailable,
            this.colEstimationTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colGuid
            // 
            this.colGuid.ColumnEdit = this.repositoryItemTextEditReadOnly;
            this.colGuid.FieldName = "Guid";
            this.colGuid.Name = "colGuid";
            this.colGuid.Visible = true;
            this.colGuid.VisibleIndex = 0;
            // 
            // repositoryItemTextEditReadOnly
            // 
            this.repositoryItemTextEditReadOnly.AutoHeight = false;
            this.repositoryItemTextEditReadOnly.Name = "repositoryItemTextEditReadOnly";
            this.repositoryItemTextEditReadOnly.ReadOnly = true;
            // 
            // colPcName
            // 
            this.colPcName.ColumnEdit = this.repositoryItemTextEditReadOnly;
            this.colPcName.FieldName = "PcName";
            this.colPcName.Name = "colPcName";
            this.colPcName.Visible = true;
            this.colPcName.VisibleIndex = 1;
            // 
            // colCustomerID
            // 
            this.colCustomerID.ColumnEdit = this.repositoryItemLookUpEditCustomerId;
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 2;
            // 
            // colAvailable
            // 
            this.colAvailable.ColumnEdit = this.repositoryItemToggleSwitchAvailable;
            this.colAvailable.FieldName = "Available";
            this.colAvailable.Name = "colAvailable";
            this.colAvailable.Visible = true;
            this.colAvailable.VisibleIndex = 3;
            // 
            // repositoryItemToggleSwitchAvailable
            // 
            this.repositoryItemToggleSwitchAvailable.AutoHeight = false;
            this.repositoryItemToggleSwitchAvailable.Name = "repositoryItemToggleSwitchAvailable";
            this.repositoryItemToggleSwitchAvailable.OffText = "Off";
            this.repositoryItemToggleSwitchAvailable.OnText = "On";
            // 
            // colEstimationTime
            // 
            this.colEstimationTime.ColumnEdit = this.repositoryItemDateEditEstimationTime;
            this.colEstimationTime.FieldName = "EstimationTime";
            this.colEstimationTime.Name = "colEstimationTime";
            this.colEstimationTime.Visible = true;
            this.colEstimationTime.VisibleIndex = 4;
            // 
            // repositoryItemDateEditEstimationTime
            // 
            this.repositoryItemDateEditEstimationTime.AutoHeight = false;
            this.repositoryItemDateEditEstimationTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditEstimationTime.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditEstimationTime.Name = "repositoryItemDateEditEstimationTime";
            // 
            // licensesTableAdapter
            // 
            this.licensesTableAdapter.ClearBeforeFill = true;
            //
            // customerTableAdapter
            //
            customerTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryItemLookUpEditCustomerId
            // 
            this.repositoryItemLookUpEditCustomerId.AutoHeight = false;
            this.repositoryItemLookUpEditCustomerId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditCustomerId.Name = "repositoryItemLookUpEditCustomerId";
            this.repositoryItemLookUpEditCustomerId.ReadOnly = true;
            // 
            // LicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 283);
            this.Controls.Add(this.gridControl1);
            this.Name = "LicensesForm";
            this.Text = "LicensesForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visaLicensesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditReadOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitchAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditEstimationTime.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditEstimationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCustomerId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private LicenseDBDataSet visaLicensesDataSet;
        private System.Windows.Forms.BindingSource licensesBindingSource;
        private LicenseTableAdapter licensesTableAdapter;
        private CustomerTableAdapter customerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGuid;
        private DevExpress.XtraGrid.Columns.GridColumn colPcName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colAvailable;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitchAvailable;
        private DevExpress.XtraGrid.Columns.GridColumn colEstimationTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditEstimationTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditCustomerId;
    }
}