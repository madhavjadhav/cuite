﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinButton
    /// </summary>
    public class CUITe_WinButton : CUITe_WinControl<WinButton>
    {
        public CUITe_WinButton() : base() { }
        public CUITe_WinButton(string sSearchParameters) : base(sSearchParameters) { }

        public string DisplayText 
        { 
            get { return this.UnWrap().DisplayText; } 
        }

        public string Shortcut 
        { 
            get { return this.UnWrap().Shortcut; } 
        }
    }
}