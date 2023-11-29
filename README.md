Build an ASP.NET Core application to secure sensitive information using Azure App Service, Managed Identity and Azure Key Vault

This sample is an ASP.NET Core WebAPI application designed to access key Vault.
	Securely build, deploy and run an App Service
	Securely store secrets in Key Vault
	Securely use Key Vault secrets as Application Settings values with Key Vault reference strings
	Use Managed Identity to securely access Key Vault secrets from App Services


Architecture diagram:
 





Flow of manage identity process
 
Prerequisites
	Install the Azure CLI to run the application on your local development machine
	If you don't have an Azure subscription, create a free account before you begin.
	Visual Studio 2022
Grant yourself data plane access to the Key Vault
Step 1: Set access policy
•	Go to the Azure Portal and log in using your Azure account
•	Create Azure App Service
•	Enable the System-assigned manage identity
•	Set up the secret
•	Create Access policy

Step 2: 
•	Copy and save Key Vault Url.
•	Install the NuGet Packages
	To work with AzureKeyVault, need to install  microsoft.Extensions.Azure and Azure.Security.KeyVault.Secrets packages

Run the application
•	Clone the repo to your development machine.
     git clone https://github.com/shanukat/SecureAppKeyVault_using_ManageIdentity.git
•	To run the sample, this solution requires a Key Vault URL to be stored in an AppSettings file and Create Azure App Service, then grant the access policy by Step 1: Set access policy.
•	Execute the Application using POSTMAN
 
Deploy the Web App to Azure
•	Deploy your app to Azure App Service to publish the Web App to Azure.
•	After you deploy it, browse to the web app. You should see the secret on the web page.




