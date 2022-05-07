﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MadOnMVCBatch.UserDefinedControls
{
    public static class MyControl
    {
        public static IHtmlString MyLabel(string content)
        {
            string htmlstring = String.Format("<label>{0}</label>", content);
            return new HtmlString(htmlstring);
        }

        public static IHtmlString createUrControl(this HtmlHelper helper, string content)
        {
            string htmlstring = "<input type=" + content + ">";
            return new HtmlString(htmlstring);
        }
        public static IHtmlString createUrControl(this HtmlHelper helper, string content,string color)
        {
            string htmlstring = "<input type=" + content +" style=color:"+color+">";
            return new HtmlString(htmlstring);
        }
    }
}