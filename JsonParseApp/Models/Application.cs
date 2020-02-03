﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using JsonParseApp.Models.DpacDb;

namespace JsonParseApp.Models
{
    public class Application
    {
        public string ApplicationId { get; set; }

        public string ErrorMessage { get; set; }
        public Application()
        {
                
        }

        public bool CreateApplicationId()
        {
            using (var newCont = new DPACEntities())
            {
                string endFormat = "00000";
                DateTime moment = DateTime.Now;
                string appLoanIdFormat = "AN" + moment.Year + "-";
                try
                {
                    var num = newCont.FMS_UpdateAppNumberNext(appLoanIdFormat);
                    var n = num.SingleOrDefault().Value.ToString();
                    string id = appLoanIdFormat + endFormat.Substring(0, endFormat.Length - n.Length) + n;
                    this.ApplicationId = id;
                    return true;
                }
                catch (DbEntityValidationException e)
                {
                    this.ErrorMessage = e.Message;
                    return false; 
                }


            }

        }
    }
}