﻿using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Birth_Registration_System.Controllers
{
    public class AdminController : ApiController
    {
        [Route("api/admins")]
        [HttpGet]
        public HttpResponseMessage GetAdmins()
        {
            var data = AdminService.GetAdmins();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/admin/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id) {
            var data = AdminService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/admin/add")]
        [HttpPost]
        public HttpResponseMessage Add(AdminDTO admin)
        {
            var data = AdminService.Add(admin);
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

        [Route("api/admin/update")]
        [HttpPost]
        public HttpResponseMessage Update(AdminDTO admin)
        {
            var data = AdminService.Update(admin);
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

        [Route("api/admin/delete/{id}")]
        [HttpPost]
        public HttpResponseMessage Delete(int id)
        {
            var data = AdminService.Delete(id);
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
