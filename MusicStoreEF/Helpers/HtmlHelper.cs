using MusicStoreEF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;

namespace MusicStoreEF.Helpers
{
    public static class HtmlHelper
    {
        public static MvcHtmlString ToCommaSeparatedLinks(this ICollection<Artist> artists, RequestContext requestContext)
        {
            var urlHelper = new UrlHelper(requestContext);
            var sb = new StringBuilder();
            for (int i = 0; i < artists.Count; i++)
            {
                sb.Append("<a href=");
                sb.Append(urlHelper.Action("Index", "Artist", new { id = artists.ElementAt(i).Id }));
                sb.Append(">");
                sb.Append(artists.ElementAt(i).Name);
                sb.Append("</a>");
                if (i < artists.Count - 1)
                {
                    sb.Append(", ");
                }
            }

            return new MvcHtmlString(sb.ToString());
        }
    }
}