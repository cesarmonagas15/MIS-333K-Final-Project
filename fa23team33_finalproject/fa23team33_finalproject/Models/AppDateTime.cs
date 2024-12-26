using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace fa23team33_finalproject.Models
{
    public class AppDateTime
    {
        private readonly DateTime currentDateTime;

        public AppDateTime()
        {
            currentDateTime = DateTime.Now;
        }
    }
}
