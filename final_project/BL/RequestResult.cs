﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RequestResult
    {
        public bool Status { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }
}
