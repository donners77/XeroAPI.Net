﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace XeroApi.Model.Reporting
{
    public abstract class DynamicReportBase
    {
        protected const string ReportDateFormatString = "yyyy-MM-dd";

        /// <summary>
        /// Gets the query string param collection.
        /// </summary>
        /// <returns></returns>
        internal NameValueCollection GetQueryStringParamCollection()
        {
            NameValueCollection queryStringParams = new NameValueCollection();
            GenerateQuerystringParams(queryStringParams);
            return queryStringParams;
        }

        /// <summary>
        /// Generates the querystring params.
        /// </summary>
        /// <param name="queryStringParams">The query string params.</param>
        internal abstract void GenerateQuerystringParams(NameValueCollection queryStringParams);

        /// <summary>
        /// Gets the name of the report.
        /// </summary>
        /// <value>The name of the report.</value>
        internal string ReportName
        {
            get
            {
                Type thisType = this.GetType();
                return thisType.Name.Replace("Report", string.Empty);
            }
        }
    }
}
