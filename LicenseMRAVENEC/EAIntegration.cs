using System;

namespace LicenseMRAVENEC
{
    public class EAIntegration
    {
        public string EA_Connect(EA.Repository Repository) => "";

        public void EA_Disconnect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }


        private const string ValidLicense = "{MRAVENEC}";
        private const string SharedAddinName = "Mravenc License";
        private const string LicenseDescription = "Mravenc License Test";

        public bool IsEnteredValidLicense { get; private set; }

        public bool EA_AddinLicenseValidate(EA.Repository Repository, string AddinKey)
        {
            IsEnteredValidLicense = AddinKey == ValidLicense;
            return IsEnteredValidLicense;
        }

        public string EA_AddinLicenseGetDescription(EA.Repository Repository, string AddinKey) => LicenseDescription;
        public string EA_GetSharedAddinName(EA.Repository Repository) => SharedAddinName;
    }
}
