﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HttpAuth.Controllers {
    public class AccountController : ApiController {
        public string Get() {

            return "test";
        }

        [HttpGet]
        public void Register() {
            int i = 5;
            int t = i;
        }
    }
}
