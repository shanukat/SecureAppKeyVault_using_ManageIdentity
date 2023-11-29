# Build an ASP.NET Core application to secure sensitive information using Azure App Service, Managed Identity and Azure Key Vault

This sample is an ASP.NET Core WebAPI application designed to access key Vault.
<ul>
 <li>Securely build, deploy and run an App Service</li>
 <li>Securely store secrets in Key Vault</li>
 <li>Securely use Key Vault secrets as Application Settings values with Key Vault reference strings</li>
 <li>Use Managed Identity to securely access Key Vault secrets from App Services</li>
</ul>


### Architecture diagram:
 
![architecture_diagram](https://github.com/shanukat/SecureAppKeyVault_using_ManageIdentity/assets/3465126/ce65a09b-9661-4e62-ba54-aec664551c05)


## Flow of manage identity process
 ![prerequistic](https://github.com/shanukat/SecureAppKeyVault_using_ManageIdentity/assets/3465126/9fed1044-7682-4a7e-bec5-df8948947d9b)
 
### Prerequisites
<ul>
 <li>Install the Azure CLI to run the application on your local development machine</li>
 <li>If you don't have an Azure subscription, create a free account before you begin.</li>
 <li>Visual Studio 2022</li>
</ul>

### Grant yourself data plane access to the Key Vault
##### Step 1: Set access policy

<ul>
 <li>Go to the Azure Portal and log in using your Azure account</li>
 <li>Create Azure App Service</li>
 <li>Enable the System-assigned manage identity </li>
 <li>Set up the secret</li>
 <li>Create Access policy</li>
</ul>

##### Step 2:
<ul>
 <li>Copy and save Key Vault Url.</li>
 <li>Install the NuGet Packages</li>
 <ul style="disc">
  <li>To work with AzureKeyVault, need to install  microsoft.Extensions.Azure and Azure.Security.KeyVault.Secrets packages</li>
 </ul>
</ul>


### Run the application
<ul>
 <li>Clone the repo to your development machine.</li>
 <ul>
  <li>git clone https://github.com/shanukat/SecureAppKeyVault_using_ManageIdentity.git</li>
 </ul>
 <li>To run the sample, this solution requires a Key Vault URL to be stored in an AppSettings file and Create Azure App Service, then grant the access policy by Step 1: Set access policy.</li>
 <li>Execute the Application using POSTMAN</li>
</ul>

![screenshot1](https://github.com/shanukat/SecureAppKeyVault_using_ManageIdentity/assets/3465126/486ac471-7854-4749-b9fd-829a86dfc9f5)
 
### Deploy the Web App to Azure
<ul>
 <li>Deploy your app to Azure App Service to publish the Web App to Azure.</li>
 <li>After you deploy it, browse to the web app. You should see the secret on the web page.</li>
</ul>





