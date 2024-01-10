<NewDataSet>
  <CSCODETAB>
    <Script_x0020_Content>using System;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

using System.IO;


namespace NSUpdateTable
{ 
    public class CSUpdateTable
    { 
       //Return value from Eval Code will be assigned to column
       public static void Main()
       {
       }
       public static DataTable UpdateTable(DataTable T1,string s1,string s2,string s3,string s4,ref string s5,string s6)
        {
            //NL,FL,TX,CA,NE,MA,PA
            switch(s6)
            {
                case "NY":
                    s5 = "New York";
                    break;
                case "FL":
                    s5 = "Florida";
                    break;
                case "TX":
                    s5 = "Texas";
                    break;
                case "CA":
                    s5 = "California";
                    break;
                case "NE":
                    s5 ="Nebraska";
                    break;
                case "MA":
                    s5 ="Massachusetts";
                    break;
                case "PA":
                    s5 = "Pennsylvania";
                    break;
            }
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
  </CSCODETAB>
</NewDataSet>