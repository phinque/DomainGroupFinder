using System;
using System.Runtime.InteropServices;

namespace Domain_Group_Finder
{
    public class Netapi32
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct LOCALGROUP_USERS_INFO_0
        {
            public string groupname;
        }


        [DllImport("Netapi32.dll", SetLastError = true)]
        public static extern int NetUserGetGroups
            ( [MarshalAs(UnmanagedType.LPWStr)] string servername,
            [MarshalAs(UnmanagedType.LPWStr)] string username,
            int level,
            out IntPtr bufptr,
            int prefmaxlen,
            out int entriesread,
            out int totalentries );

        [DllImport("Netapi32.dll", SetLastError = true)]
        public static extern int NetApiBufferFree( IntPtr Buffer );
    }
}