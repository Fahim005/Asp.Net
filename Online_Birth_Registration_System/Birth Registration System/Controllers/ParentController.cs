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
    public class ParentController : ApiController
    {
        [Route("api/parent")]
        [HttpGet]
        public HttpResponseMessage GetParent()
        {
            var data = ParentService.GetParent();

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/parent/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = ParentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/parent/add")]
        [HttpPost]
        public HttpResponseMessage Add(ParentDTO parent)
        {
            var data = ParentService.Add(parent);
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

        [Route("api/parent/update")]
        [HttpPost]
        public HttpResponseMessage Update(ParentDTO Parent)
        {
            var data = ParentService.Update(Parent);
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

        [Route("api/parent/delete/{id}")]
        [HttpPost]
        public HttpResponseMessage Delete(int id)
        {
            var data = ParentService.Delete(id);
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
