using System.Collections.Generic;
using System.Web;
using System.Web.ModelBinding;

namespace WebApplication2
{
    public class DB
    {
        private static List<BE> _list
        {
            get
            {
                if (HttpContext.Current.Session["BE"] == null)
                    HttpContext.Current.Session["BE"] = new List<BE>();
                return (List<BE>)HttpContext.Current.Session["BE"];
            }
        }

        public static List<BE> List()
        {
            return _list;
        }

        public static void Save(BE o)
        {
            _list.Add(o);
        }
    }
}