using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ColeKine;
using ColeKine.Modelos;

namespace ColeKineWebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ApplicationDbContext db = new ApplicationDbContext();
           
                if (db.Sexos.Any())
                {
                    InicializarSexo(db);
                }
               
            
        }

        private void InicializarSexo(ApplicationDbContext db)
        {
            Sexo sexo = new Sexo{Nombre = "Femenino"};
            Sexo sexo2 = new Sexo{Nombre = "Masculino"};
            Sexo sexo3 = new Sexo{Nombre = "Otro"};

            db.Sexos.Add(sexo);
            db.Sexos.Add(sexo2);
            db.Sexos.Add(sexo3);

            db.SaveChanges();
        }
    }
}
