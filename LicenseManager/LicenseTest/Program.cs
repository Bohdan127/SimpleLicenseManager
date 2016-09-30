using License.Logic;

namespace LicenseTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var licenseForm = new LicenseForm();
            if (!licenseForm.CheckInstance("licenseKeySavedFromPreviousStarting"))
                licenseForm.ShowDialog();
            var id = LicenseForm.GetMotherBoardId();
        }
    }
}
