using Microsoft.PowerBI.Api.V2.Models;
using System;
using System.Collections.Generic;

namespace PowerBIEmbedded_AppOwnsData.Models
{
    public class EmbedConfig
    {
        public string Id { get; set; }

        public string EmbedUrl { get; set; }

        public EmbedToken EmbedToken { get; set; }

        
        public List<Employee> Employees { get; set; }
        public List<string> ReportName { get; set; }
        
        public int MinutesToExpiration
        {
            get
            {
                //var minutesToExpiration = EmbedToken.Expiration.Value - DateTime.UtcNow;
                return DateTime.UtcNow.Minute;
            }
        }

        public string ErrorMessage { get; internal set; }
    }
}