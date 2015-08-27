﻿using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlDocument : HtmlControl<CUITControls.HtmlDocument>
    {
        public HtmlDocument()
        {
        }

        public HtmlDocument(string searchParameters)
            : base(searchParameters)
        {
        }
    }
}