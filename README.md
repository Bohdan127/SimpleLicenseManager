# SimpleLicenseManager
Simple license manager application for short and quicly intergation to any windows desktop application

For using we should simple  add next rows into your program at Shown event:

LicenseForm licenseForm = new LicenseForm();
if (!licenseForm.CheckInstance("licenseKeySavedFromPreviousStarting"))
  licenseForm.ShowDialog();
if (!licenseForm.IsRegistered)
Close();

This will check your key which was saved from previous app session. If it is incorrect or empty we will show our form for inserting your GUID key, generated  in LicenseManager program or by your hand and saved in DB.

Before using, please change and recompice License.csproj. At this project you should set your License.Properties.Settings.LicenseDBConnectionString for your DB.
Also for testing you can use mine DB in gear.host but for fully using your app better to have your own)))

LicenseManager is only in Russian Language for now, but in the nearest future will be multilanguages.
