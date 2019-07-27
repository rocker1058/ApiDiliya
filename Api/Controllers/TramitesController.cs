using ServicioApiTramites.Models;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Net;

using System.Net.Http;

using System.Web.Http;



namespace ServicioApiTramites.Controllers

{

    public class TramitesController : ApiController

    {

        List<Tramite> listaTramites = new List<Tramite>();



        public TramitesController()

        {

            Tramite p = new Tramite { IdTramite = 1, Nombre = «Lucia», Email = «lucia@gmail.com», Edad = 19 };

            this.listaTramites.Add(p);

            p = new Tramite { IdTramite = 2, Nombre = «Adrian», Email = «adrian@gmail.com», Edad = 24 };

            this.listaTramites.Add(p);

            p = new Tramite { IdTramite = 3, Nombre = «Alejandro», Email = «alejandro@gmail.com», Edad = 21 };

            this.listaTramites.Add(p);

            p = new Tramite { IdTramite = 4, Nombre = «Sara», Email = «sara@gmail.com», Edad = 17 };

            this.listaTramites.Add(p);

        }

        // GET api/<controller>

        public List<Tramite> GetTramites()

        {

            return this.listaTramites;

        }

        // GET api/<controller>/9

        public Tramite GetTramite(int id)

        {

            Tramite p = this.listaTramites.Find(z => z.IdTramite == id);

            return p;

        }

    }

}