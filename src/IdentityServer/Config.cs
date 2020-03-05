// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                new ApiResource("api1", "Development API"), 
            };
        
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "Client",

                    //using clientid/client secret for authentication, since there is no actual interactive user
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    // scopes that client may access
                    AllowedScopes =
                    {
                        "api1"
                    }
                }, 
            };
        
    }
}