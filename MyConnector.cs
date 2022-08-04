using System;

public class MyConnector
{
	public static function IOrganizationService MyConnector()
	{
        string connection =
                "AuthType=OAuth;" +
                "Username=CassioCorrea@Dynacoop339.onmicrosoft.com;" +
                "Password=Dynacoop2022;" +
                "Url=https://org61fc6888.crm2.dynamics.com;" +
                "AppId=ed509dc5-e5bd-4c52-a8c8-d1d2b2d05590;" +
                "RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;";

        CrmServiceClient crmServiceClient = new CrmServiceClient(connection);
        return crmServiceClient.OrganizationWebProxyClient;
    }
}
