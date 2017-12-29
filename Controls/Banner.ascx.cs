﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_Banner : System.Web.UI.UserControl
{
  protected void Page_Load(object sender, EventArgs e)
  {
    
  }

  public Direction DisplayDirection { get; set; }

  public string NavigateUrl
  {
    get
    {
      object _navigateUrl = ViewState["NavigateUrl"];
      if (_navigateUrl != null)
      {
        return (string)_navigateUrl;
      }
      else
      {
        return "http://p2p.wrox.com"; // Return a default value
      }
    }
    set
    {
      ViewState["NavigateUrl"] = value;
    }
  }

}