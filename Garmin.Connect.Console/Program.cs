using Garmin.Connect;
using Garmin.Connect.Auth;

var login = "username";
var password = "password";
var authParameters = new BasicAuthParameters(login, password);

var client = new GarminConnectClient(new GarminConnectContext(new HttpClient(), authParameters));

var profile = await client.GetSocialProfile();

Console.WriteLine(profile.GarminGuid);
