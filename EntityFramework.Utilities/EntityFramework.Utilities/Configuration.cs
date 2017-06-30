using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework.Utilities
{
    public static class Configuration
    {
        static Configuration(){
            Providers = new List<IQueryProvider>();
            Providers.Add(new SqlQueryProvider());

            Log = m => { };

            DisableDefaultFallback = true;
        
        }

        /// <summary>
        /// Add, Remove or replace query provider by modifing this collection
        /// </summary>
        public static ICollection<IQueryProvider> Providers { get; set; }

        /// <summary>
        /// Allows you to hook in a logger to see debug messages for example
        /// </summary>
        public static Action<string> Log { get; set; }

        /// <summary>
        /// If you want an exception to be thrown if the provider doesn't support the operation set this to true. 
        /// Otherwise it will fall back to the default EF behaviour meaning a performance penalty
        /// </summary>
        public static bool DisableDefaultFallback { get; set; }

        /// <summary>
        /// Gets or sets the SQL bulk copy options.
        /// </summary>
        /// <value>
        /// The SQL bulk copy options.
        /// </value>
        public static System.Data.SqlClient.SqlBulkCopyOptions SqlBulkCopyOptions { get; set; }

        /// <summary>
        /// Number of seconds for the operation to complete before it times out.
        /// The default is 30 seconds. A value of 0 indicates no limit; the bulk copy will wait indefinitely.
        /// </summary>
        /// <value>
        /// The bulk copy timeout.
        /// </value>
        public static int? BulkCopyTimeout { get; set; }

    }
}
