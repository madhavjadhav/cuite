﻿using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlCustom : HtmlControl<CUITControls.HtmlCustom>
    {
        public HtmlCustom(string tagName)
        {
            Initialize(tagName);
        }

        public HtmlCustom(string tagName, string searchParameters)
            : base(searchParameters)
        {
            Initialize(tagName);
        }

        public void Initialize(string tagName)
        {
            SearchProperties.Add(CUITControls.HtmlControl.PropertyNames.TagName, tagName, PropertyExpressionOperator.EqualTo);
        }
    }
}