﻿using IMSBusinessLogic;
using IMSCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMS_v1
{
    public partial class PendingOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { BindGdvPendding(); }
        }


        public void BindGdvPendding()
        {


            DataSet ds2 = new DataSet();
            OrderDetails objDetails = new OrderDetails();
            objDetails.OrderRequestBy = Convert.ToInt32(Session["UserID"]);
            objDetails.OrderMode = "Request";
            ds2 = PlaceOrderBLL.GetPenddingOrders(objDetails);

            gdvPendding.DataSource = ds2;
            gdvPendding.DataBind();
        }



        protected void gdvPendding_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvPendding.PageIndex = e.NewPageIndex;
            BindGdvPendding();
        }

       

    }
}