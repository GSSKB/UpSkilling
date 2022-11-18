/*using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Students_Data
{
    public partial class Student_data : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ArrayList studentdata = new ArrayList();
                try
                {
                    int index = 0;
                    Char[] sep = { ',' };

                    string[] lines = File.ReadAllLines("D:\\.NET\\Student1\\Customer\\bin\\Debug\\sai.txt");
                    foreach (string line in lines)

                    {

                        if (index == 0)
                        {
                            index++;
                            continue;
                        }
                        string[] data = line.Split(sep);

                        studentdata.Add(data);
                    }

                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("The file was not found on your selected path");
                    Console.WriteLine(ex.Message);
                }
                foreach (string[] student in studentdata)
                {
                    //foreach(string stu in student)
                    for (int i = 0; i < student.Length; i++)
                    {
                        //Console.WriteLine(student[i].ToString());
                        ListBox1.Items.Add(student[i]);
                    }

                }
            }

        }
    }
}*/