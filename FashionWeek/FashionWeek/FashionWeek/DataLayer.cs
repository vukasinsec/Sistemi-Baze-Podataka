﻿using FashionWeek.Entiteti;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Configuration;
using FashionWeek;
using ProdavnicaIgracaka;

namespace FashionWeek;

static class DataLayer
{
    private static ISessionFactory? factory;
    private static object lockObj;

    static DataLayer()
    {
        factory = null;
        lockObj = new object();
    }

    public static ISession? GetSession()
    {
        if (factory == null)
        {
            lock (lockObj)
            {
                if (factory == null)
                {
                    factory = CreateSessionFactory();
                }
            }
        }

        return factory?.OpenSession();
    }

    private static ISessionFactory? CreateSessionFactory()
    {
        try
        {
            // ShowSql prikazuje SQL koji je generisan, ali u .NET Core aplikacijama se prikazuju u konzoli.
            // Ako se aplikacija pokrene sa dotnet bin\Debug\net8.0-windows\ProdavnicaIgracaka.dll, mogu da se vide
            string cs = ConfigurationManager.ConnectionStrings["OracleCS"].ConnectionString;
            var cfg = OracleManagedDataClientConfiguration.Oracle10
                        .ShowSql()
                        .ConnectionString(c => c.Is(cs));

            return FluentNHibernate.Cfg.Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ModnaAgencija>())
                    //.ExposeConfiguration(BuildSchema)
                    .BuildSessionFactory();
        }
        catch (Exception e)
        {
            DialogResult dialogResult = MessageBox.Show(e.FormatExceptionMessage());
            return null;
        }
    }
    
    /*private static void BuildSchema(NHibernate.Cfg.Configuration cfg)
    {
        // Konfiguracija
    }*/
}
