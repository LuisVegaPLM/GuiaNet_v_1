﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuiaNet.Models
{
    public class sessionresultsofbrands
    {
         #region Constructor
        public sessionresultsofbrands(string Values)
        {
            number = Values;
        }

        #endregion

        #region Member

        private string number;

        #endregion

        #region Properties

        public string Values
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        #endregion
    }
}