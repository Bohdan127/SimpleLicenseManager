﻿using DevExpress.XtraEditors;
using GlobalResources;
using License.DB;
using License.DB.LicenseDBDataSetTableAdapters;
using NLog;
using System;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ToolsPortable;

namespace License.Logic
{
    public partial class LicenseForm : Form
    {
        private static readonly Logger _logger =
            LogManager.GetCurrentClassLogger();

        private readonly LicenseTableAdapter _licenseTableAdapter =
            new LicenseTableAdapter();

        private readonly LicenseDBDataSet _licenseDbDataSet =
            new LicenseDBDataSet();

        public LicenseForm(string systemName, System.Resources.ResourceManager resManager)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _licenseTableAdapter.Fill(_licenseDbDataSet.License);
            ResManager.RegisterResource(systemName, resManager);

            applyButton.Text = ResManager.GetString(ResKeys.LicenseForm_RegButton); //"Зарегистрировать";
            Text = ResManager.GetString(ResKeys.LicenseForm_Title); //"Пожалуйста впишите лицензионный ключ";
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public bool IsWrong { get; set; }
        public bool IsUsed { get; set; }
        public bool IsRegistered { get; set; }

        public string LicenseKey => textEdit1.EditValue.ToString();

        public bool CheckInstance(string guid)
        {
            textEdit1.EditValue = guid;
            return CheckIsRegistered();
        }

        protected bool CheckIsRegistered()
        {
            var bRes = true;

            var isMatched =
                Regex.IsMatch(
                    textEdit1.EditValue.ConvertToStringOrNull() ?? string.Empty,
                    textEdit1.Properties.Mask.EditMask);

            if (isMatched)
            {
                LicenseDBDataSet.LicenseRow inst = null;

                for (var j = 0;
                    j < 3;
                    j++)
                {
                    try
                    {
                        inst = _licenseDbDataSet.License.Rows.Cast<LicenseDBDataSet.LicenseRow>()
                            .FirstOrDefault(
                                i => i.Guid == textEdit1.EditValue.ToString());
                        break;
                    }
                    catch (Exception ex)
                    {
                        _logger.Error(ex.Message);
                        _logger.Error(ex.StackTrace);
                    }
                }
                if (inst != null)
                {
                    if (!inst.Available)
                    {
                        XtraMessageBox.Show(
                           ResManager.GetString(ResKeys.Key_NotActive),
                           "Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        bRes = false;
                    }
                    else if ((inst["PcName"] as string).IsBlank())
                    {
                        inst.PcName = GetMotherBoardId();
                        _licenseTableAdapter.Update(inst);
                    }
                    else if (inst["PcName"] as string != GetMotherBoardId())
                    {
                        bRes = false;
                        XtraMessageBox.Show(
                            ResManager.GetString(ResKeys.Key_Used),
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bRes = false;
                    XtraMessageBox.Show(
                        ResManager.GetString(ResKeys.KeyNotFound),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            IsRegistered = bRes;
            return bRes;
        }

        public static string GetMotherBoardId()
        {
            var scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
            scope.Connect();
            var wmiClass = new ManagementObject(scope, new ManagementPath("Win32_BaseBoard.Tag=\"Base Board\""), new ObjectGetOptions());

            var property = wmiClass.Properties.Cast<PropertyData>()
                .FirstOrDefault(propData => propData.Name == "SerialNumber");
            return property?.Value.ToString();
        }

        private void applyButton_Click(object sender,
            EventArgs e)
        {
            if (CheckIsRegistered())
            {
                Close();
            }
        }
    }
}