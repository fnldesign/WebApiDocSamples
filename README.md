# Web API - Documentation - Samples
Tests with Web API - API Documentation Tools - API Help Pages and Swagger

## Swagger - API Documentation ##
Swagger is a API Documentation Tool, intagrated on Visual Studio by Nuget Packages

See more at [Swagger](http://swagger.io/) website.

I´m using [Swashbuckle](https://github.com/SEEK-Jobs/Swashbuckle) Visual Studio Nuget Package

To see a tutorial using .NET Web API and Swagger see more at [Swashbuckle GitHub Repo](https://github.com/SEEK-Jobs/Swashbuckle) 

*See Swagger UI in action bellow*
![Swagger UI](https://github.com/fnldesign/WebApiDocSamples/blob/master/WebApiDocsSamples/Images-Doc/SwaggerUI.png "Swagger UI API Documentation Screenshot")


## .NET Web API - Help Pages ##
.NET Web API - Help Pages is a collection of Views to Genarate API Help Pages

I´m using [WebApiTestClient](https://nuget.org/packages/WebApiTestClient) too, to add a Test Client on API Help Pages.
If you want, you see how to add *WebApiTestClient* into this tutorial [Adding a simple Test Client to ASP.NET Web API Help Page](https://blogs.msdn.microsoft.com/yaohuang1/2012/12/02/adding-a-simple-test-client-to-asp-net-web-api-help-page/)

See more at [HelpPages on Microsoft Website](https://docs.microsoft.com/en-us/aspnet/web-api/overview/getting-started-with-aspnet-web-api/creating-api-help-pages).
This MS Blog Post is usefull too [Introducing the ASP.NET Web API Help Page](https://blogs.msdn.microsoft.com/yaohuang1/2012/08/15/introducing-the-asp-net-web-api-help-page-preview/).

*See Web API Test Client bellow*
![Web Api Test Client](https://github.com/fnldesign/WebApiDocSamples/blob/master/WebApiDocsSamples/Images-Doc/WebApiTestClient.png "Web Api Test Client Screenshot")

## On the Code ##
Swashbuckle Configurations
---

To enable Swagger to use XmlDoc, use
`c.IncludeXmlComments(GetXmlCommentsPath());`

I suggested to place XmlDoc in *App_Data* Folder above a sample of `GetXmlCommentsPath()` method
```
   private static string GetXmlCommentsPath()
   {            
            var basePath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/");
            var xmlDocPath = System.IO.Path.Combine(basePath, "XmlDocument.xml");
            return xmlDocPath;
   }
```

Sample Web API v2 Controller to documentation
---

Sample code - XmlDoc to Genarate API Doc
```
        /// <summary>
        /// Obtêm todos os produtos
        /// </summary>
        /// <returns>Retorna uma lista com todos os produtos</returns>
        public List<Models.Produto> Get()
        {
            return produtos;
        }
```     
