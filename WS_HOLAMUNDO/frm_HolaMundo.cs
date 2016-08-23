using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WS_HOLAMUNDO
{
    public partial class frm_HolaMundo : Form
    {
        public frm_HolaMundo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WS_HOLAMUNDO_NOKeepAlive ws = new WS_HOLAMUNDO_NOKeepAlive();
            ws.Credentials = new System.Net.NetworkCredential("WS_RO", "LograZenyata17-0");
            ws.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap11;
            string ws_output;
            ws_output = ws.WS_HOLAMUNDO(txt_UserName.Text);
            btn_Currito.Text = ws_output;
            ws.Dispose();
        }
    }
    public class WS_HOLAMUNDO_NOKeepAlive : WS_HOLAMUNDO_DESA.WS_HOLAMUNDOService
    {
        protected override System.Net.WebRequest GetWebRequest(Uri uri)
        {
            System.Net.HttpWebRequest webRequest =
               (System.Net.HttpWebRequest)base.GetWebRequest(uri);
            webRequest.KeepAlive = false;
            return webRequest;
        }
    }

}