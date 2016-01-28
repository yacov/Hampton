using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace Siute_1638_Events_Initial_IEP
{

    public class CleanUPNotYetReady : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"New Coded Step")]
        public void CleanUPNotYetReady_CodedStep()
        {
            
            
            
            HtmlTable grid = Pages.AccelifyEliAaron.EventsTable;
            var myList = new List<string>();
            double r = grid.Rows.Count;
            var item = "";
            
            
                  for (int i = 1; i < (r-1); i++)
                  {
                      HtmlTableRow row = grid.Rows[i];
                    if (row.TextContent == "Initial IEP"){}
                HtmlTableCell cell = row.Cells[5];
                      item = cell.TextContent;
                    alreadyExist = myList.Contains(item);  
                    if (alreadyExist=true) {}
                    else {myList.Add(cell.TextContent);}
                  
                    
                    //Log.WriteLine("Full Name added is "+myList[]);
                    
                    
                  }
            SetExtractedValue("ProviderFullName", myList);
                  
        }
    }
}
