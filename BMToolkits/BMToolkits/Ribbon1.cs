using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Excel = Microsoft.Office.Interop.Excel;

namespace BMToolkits
{
    public partial class ribbon
    {

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

            //Excel.Worksheet activeSheet = (Excel.Worksheet) Excel.Application.ActiveSheet;

        }


        // Sumarry Invoice From Other Files
        private void otherFiles_Click(object sender, RibbonControlEventArgs e)
        {

        }

        // Summary Invoice From Same Files
        private void sameFiles_Click(object sender, RibbonControlEventArgs e)
        {
            sameFileControl formControl = new sameFileControl();
            formControl.Show();
            
        }
    }
}
