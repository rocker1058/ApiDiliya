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

            Tramite p = new Tramite { IdTramite = 1, Nombre = «Lucia», Email = «lucia@gmail.com», Cedula = 19111 };

            this.listaTramites.Add(p);

            p = new Tramite { IdTramite = 2, Nombre = «Adrian», Email = «adrian@gmail.com», Cedula = 24111 };

            this.listaTramites.Add(p);

            p = new Tramite { IdTramite = 3, Nombre = «Alejandro», Email = «alejandro@gmail.com», Cedula = 21111 };

            this.listaTramites.Add(p);

            p = new Tramite { IdTramite = 4, Nombre = «Sara», Email = «sara@gmail.com», Cedula = 17111 };

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