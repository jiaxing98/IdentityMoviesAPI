using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Security.Claims;

namespace IdentityServer
{
    public class Config
    {
        private const string MOVIE_API = "movieAPI";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email()
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new List<ApiResource>
            {
                new ApiResource(MOVIE_API)
                {
                    UserClaims =
                    {
                        //...optional user claims...
                    },

                    //TCN: this will add the aud claim in the generated JWT token 
                    // https://stackoverflow.com/questions/62930426/missing-aud-claim-in-access-token
                    // https://nestenius.se/2023/02/02/identityserver-identityresource-vs-apiresource-vs-apiscope/

                    Scopes = new List<string>
                    {
                        MOVIE_API
                    },
                },
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope(MOVIE_API, "Movie API"),
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        MOVIE_API
                    }
                }
            };

        public static IEnumerable<TestUser> TestUsers =>
            new List<TestUser>
            {
                new TestUser
                {
                    Username = "admin",
                    Password = "admin",
                    Claims = new List<Claim>
                    {

                    }
                },
            };
    }
}
