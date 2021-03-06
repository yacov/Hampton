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

    public class FillServicesAndLRE : BaseWebAiiTest
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
    
        //[CodedStep(@"Click 'SelectSpan'")]
        //public void FillServicesAndLRE_CodedStep()
        //{
            //// Click 'SelectSpan1'
            //Pages.AccelifyInitialIEPFor18.SelectSpan1.Click(false);
            
        //}
    
        //[CodedStep(@"Click 'SpecialListItem'")]
        //public void FillServicesAndLRE_CodedStep1()
        //{
            //// Click 'SpecialListItem'
            //Pages.AccelifyInitialIEPFor18.SpecialListItem.Click(false);
            
        //}
    }
}
