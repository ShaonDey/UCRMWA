﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace UniversityCourseResultManagementWebApp.Gateway
{
    public class Gateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["UCRMSWA_DB"].ConnectionString;

        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public String Query { get; set; }

        public Gateway()
        {
            Connection = new SqlConnection(connectionString);
            Command = new SqlCommand();

        }
    }
}