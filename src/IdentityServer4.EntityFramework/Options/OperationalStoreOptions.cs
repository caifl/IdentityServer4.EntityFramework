// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


namespace IdentityServer4.EntityFramework.Options
{
    public class OperationalStoreOptions
    {
        public string DefaultSchema { get; set; } = null;

        /// <summary>
        /// Get or set table name prefix.
        /// </summary>
        public string TablePrefix { get; set; }

        public TableConfiguration PersistedGrants { get; set; } = new TableConfiguration("PersistedGrants");
    }
}