using System;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        #region PriceMethods
        public static IHtmlString DisplayPriceStatic(double price) //Tratar de no usarlo
        {
            return new HtmlString(GetHtmlForPrice(price));
        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            return new HtmlString(GetHtmlForPrice(price));
        }

        private static string GetHtmlForPrice(double price)
        {
            return price == 0.00 ? "<span>Free!!!</span>" : $"<span>{price.ToString("C")}</span>";
        }
        #endregion

        #region DateMethods
        private static string GetHtmlForDateOrNull(DateTime? createDate)
        {
            return createDate.HasValue ? $"<span>{createDate.Value.ToString("dd-MM-yyyy")}</span>": "<span>None</span>";
        }

        public static IHtmlString DisplayDateOrNullStatic(DateTime? createDate)
        {
            return new HtmlString(GetDateHtml(createDate));
        }
        
        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? createDate)
        {
            return new HtmlString(GetDateHtml(createDate));
        }

        private static string GetDateHtml(DateTime? createDate)
        {
            return createDate.HasValue ? $"<span>{createDate.Value.ToString("dd-MM-yyyy")}</span>" : "<span>None</span>";
        }
        #endregion 
    }
}
