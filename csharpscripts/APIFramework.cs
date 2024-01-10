<NewDataSet>
  <CSCODETAB>
    <Script_x0020_Content>using System;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.CSharp;

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
       public static DataTable UpdateTable(DataTable T1,string s1,string s2,string s3,string s4,ref string s5,string s6)
        {
            DataTable RES = new DataTable();
            RES.Columns.Add("employee_name");
            RES.Columns.Add("employee_salary");
            RES.Columns.Add("employee_age");
            
            try
            {
                string jsonbeautify = s5;
                var obj1 = JObject.Parse(jsonbeautify);
                JArray items = (JArray)obj1["data"];
                int dcount =items.Count;
                
                for(int i=0;i&lt;dcount;i++)
                {
                    DataRow DR = RES.NewRow();
                    DR["employee_name"] = obj1["data"][i]["employee_name"].ToString();
                    DR["employee_salary"] = obj1["data"][i]["employee_salary"].ToString();
                    DR["employee_age"] = obj1["data"][i]["employee_age"].ToString();
                    
                    RES.Rows.Add(DR);
                }
                File.AppendAllText(s6,"Successful" + "\r\n");
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
                File.AppendAllText(s6,"ERROR:  "+ E.Message + "\r\n");
            }
            return (RES);
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
Newtonsoft.Json.dll
netstandard.dll
Microsoft.Csharp.dll
</Script_x0020_Reference>
    <Script_x0020_NameSpace>NSUpdateTable</Script_x0020_NameSpace>
    <Script_x0020_Class>CSUpdateTable</Script_x0020_Class>
    <Script_x0020_Function>UpdateTable</Script_x0020_Function>
  </CSCODETAB>
</NewDataSet>