<NewDataSet>
  <CSCODETAB>
    <Script_x0020_Content>using System;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

using System.IO;

//Return value from Eval Code will be assigned to column
//DataTable T1: Whatever Data in Bottom Grid Of Query 1
//string s1   : Credential&gt; User Name
//string s2   : Credential&gt; Password
//string s3   : Credential&gt; User Name
//string s4   : Credential&gt; Password

namespace NSUpdateTable
{ 
    public class CSUpdateTable
    { 
       //Return value from Eval Code will be assigned to column
       public static void Main()
       {
       }
       public static DataTable UpdateTable(DataTable T1,string s1,string s2,string s3,string s4,ref string s5,string s6,string s7)
        {
            MessageBox.Show(s6 + "\r\n\r\n\r\n" + s7);
            return (T1);
        } 
    } 
}
</Script_x0020_Content>
    <Script_x0020_Reference>system.dll
system.IO.dll
system.data.dll
system.xml.dll
System.Runtime.Dll
system.drawing.dll
system.Console.dll
system.Private.Corelib.dll
</Script_x0020_Reference>
    <Script_x0020_NameSpace>NSUpdateTable</Script_x0020_NameSpace>
    <Script_x0020_Class>CSUpdateTable</Script_x0020_Class>
    <Script_x0020_Function>UpdateTable</Script_x0020_Function>
  </CSCODETAB>
</NewDataSet>