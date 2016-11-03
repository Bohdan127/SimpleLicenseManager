using License.DB;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LicenseManager
{
    public partial class LicensesForm : Form
    {
        private const int IncorrectRowHandle = -2147483647;

        public LicensesForm()
        {
            InitializeComponent();
            Closing += LicensesForm_Closing;
            GotFocus += LicensesForm_GotFocus;
        }

        private void LicensesForm_GotFocus(object sender,
            System.EventArgs e)
        {
            licensesTableAdapter.Fill(visaLicensesDataSet.License);
            customerTableAdapter.Fill(visaLicensesDataSet.Customer);
            repositoryItemLookUpEditCustomerId.DisplayMember = visaLicensesDataSet.Customer.NameColumn.ColumnName;
            repositoryItemLookUpEditCustomerId.ValueMember = visaLicensesDataSet.Customer.IDColumn.ColumnName;
            repositoryItemLookUpEditCustomerId.DataSource = visaLicensesDataSet.Customer;
        }

        public bool ToClose { get; set; }

        private void LicensesForm_Closing(object sender,
            CancelEventArgs e)
        {
            e.Cancel = !ToClose;
            if (!ToClose)
                Hide();
        }

        public virtual void Save()
        {
            ChangeRow();
            licensesTableAdapter.Update(visaLicensesDataSet.License);
        }

        public virtual void Cancel()
        {
            Close();
        }

        private void ChangeRow()
        {
            var rowId = gridView1.FocusedRowHandle;
            gridView1.FocusedRowHandle = IncorrectRowHandle;
            gridView1.Focus();
            gridView1.FocusedRowHandle = rowId;
            gridView1.Focus();
        }

        public virtual void RefreshForm()
        {
            ChangeRow();
            licensesTableAdapter.Fill(visaLicensesDataSet.License);
            gridView1.RefreshData();
        }

        public virtual void Delete()
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        public void AddNew(int customerId)
        {
            var newRow = visaLicensesDataSet.License.NewLicenseRow();

            newRow.Guid = Guid.NewGuid()
                .ToString();
            newRow.CustomerID = customerId;

            visaLicensesDataSet.License.Rows.Add(newRow);
            gridView1.RefreshData();
        }

        public void DeleteAll()
        {
            var count = gridView1.RowCount;
            for (var i = 0;
                i < count;
                i++)
            {
                gridView1.DeleteRow(0);
            }
            gridView1.RefreshData();
        }

        public void CopyKey()
        {
            var row = gridView1.GetFocusedDataRow()
                as LicenseDBDataSet.LicenseRow;
            if (row != null)
                Clipboard.SetText(row.Guid);
        }
    }
}