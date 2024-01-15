using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Birth_Registration_System.Controllers
{
    public class CityCorporationController : ApiController
    {
        [Route("api/citycorporation")]
        [HttpGet]
        public HttpResponseMessage GetCityCorporation()
        {
            var data = CityCorporationService.GetCityCorporation();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/citycorporation/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = CityCorporationService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/citycorporation/add")]
        [HttpPost]
        public HttpResponseMessage Add(CityCorporationDTO city_corporation)
        {
            var data = CityCorporationService.Add(city_corporation);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    Message = "Successfully created"
                });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, new
                {
                    Message = "Unsuccessfully created"
                });
            }
        }

        [Route("api/citycorporation/update")]
        [HttpPost]
        public HttpResponseMessage Update(CityCorporationDTO city_corporation)
        {
            var data = CityCorporationService.Update(city_corporation);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    Message = "Successfully updated"
                });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, new
                {
                    Message = "Unsuccessfully updated"
                });
            }
        }

        [Route("api/citycorporation/delete/{id}")]
        [HttpPost]
        public HttpResponseMessage Delete(int id)
        {
            var data = CityCorporationService.Delete(id);
            if (data)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    Message = "Successfully deleted"
                });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, new
                {
                    Message = "Unsuccessfully deleted"
                });
            }
        }
    }
}
