using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Domain_Group_Finder
{
    public class MainFormController
    {
        private MainForm _form;
        public string LookupMessage { get; set; }

        public void InitializeForm( MainForm form )
        {
            _form = form;
        }

        public void SetDomainServer()
        {
            using (var inputForm = new InputForm()
            {
                Title = "Select Domain Server...",
                Prompt = "Enter the name of the domain server.",
                InputValue = Settings.Default.DomainServer
            })
            {
                if (DialogResult.OK == inputForm.ShowDialog())
                    if (!string.IsNullOrEmpty(inputForm.InputValue))
                    {
                        Settings.Default.DomainServer = inputForm.InputValue;
                        Settings.Default.Save();
                    }
            }
        }

        public List<string> LookupUserGroups( string username, int flags )
        {
            var userGroups = new List<string>();
            int entriesRead;
            int totalEntries;
            IntPtr intPtr;

            var errorCode = Netapi32.NetUserGetGroups(
                Settings.Default.DomainServer, username, flags,
                out intPtr, 1024, out entriesRead, out totalEntries);

            if (errorCode == 0)
            {
                LookupMessage = "Successful";
            }
            else
            {
                LookupMessage = "Username or computer not found";
            }
            if (flags > 1)
                LookupMessage = "Flags can only be 0 or 1";

            if (entriesRead > 0)
            {
                Netapi32.LOCALGROUP_USERS_INFO_0[] RetGroups = new Netapi32.LOCALGROUP_USERS_INFO_0[entriesRead];
                IntPtr iter = intPtr;
                for (int i = 0; i < entriesRead; i++)
                {
                    RetGroups[i] = (Netapi32.LOCALGROUP_USERS_INFO_0)Marshal.PtrToStructure(iter, typeof(Netapi32.LOCALGROUP_USERS_INFO_0));
                    iter = (IntPtr)((int)iter + Marshal.SizeOf(typeof(Netapi32.LOCALGROUP_USERS_INFO_0)));
                    userGroups.Add(RetGroups[i].groupname);
                }
                Netapi32.NetApiBufferFree(intPtr);
            }
            return userGroups;
        }

        internal void LookupUserGroups()
        {
            var loginName = _form.txtDomainAccountName.Text;
            var sTemp = loginName.Split('\\');
            var userName = sTemp[sTemp.GetUpperBound(0)];

            var networkGroups = LookupUserGroups(userName, 0);
            SetUserDomainGroups(networkGroups);
        }

        private void SetUserDomainGroups( List<string> networkGroups )
        {
            _form.lstDomainGroups.Items.Clear();
            foreach (var group in networkGroups)
            {
                _form.lstDomainGroups.Items.Add(group);
            }
        }

    }
}