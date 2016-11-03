using GlobalResources.uk_UA;
using License.Logic;

namespace LicenseTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var licenseForm = new LicenseForm("uk_UA", uk_UA.ResourceManager);
            if (!licenseForm.CheckInstance("0790c516-22ac-480d-94b1-b68a225c93d6"))
                licenseForm.ShowDialog();
            var id = LicenseForm.GetMotherBoardId();
        }
    }
}
