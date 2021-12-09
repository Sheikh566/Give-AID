using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Give_AID.Models
{
    public class TestEvent
    {
        public string event_title { get; set; }
        public System.DateTime event_date { get; set; }
        public EventPoster event_poster { get; set; }
        public string event_description { get; set; }
    }

    public class EventPoster
    { 
        public HttpPostedFileBase rawFile { get; set; } 
        public string event_poster { get; set; }
        public string title { get; set; }
    }

}