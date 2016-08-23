using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#if DEBUG
using PKG_WS_CMBD.PKG_WS_CMBD_DESA;
using PKG_WS_CMBD.PKG_WS_UPDX_DESA;

#endif
#if !DEBUG
using PKG_WS_CMBD.PKG_WS_CMBD_PROD;
using PKG_WS_CMBD.PKG_WS_UPDX_DESA;

#endif

namespace PKG_WS_CMBD
{
    public partial class frm_WS_CMBD : Form
    {
        System.Xml.XmlElement ws_result;
        string p_campos;
        string p_quiensoy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public frm_WS_CMBD()
        {
            InitializeComponent();
        }

        private void btn_EPISODIOS_POR_NUHSA_Click(object sender, EventArgs e)
        {
            PKG_WS_CMBD_NOKeepAlive ws = ws_pre();
            WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT ws_output = new WS001_EPISODIOS_POR_NUHSAInputP_RESULTADOXMLTYPEOUT();
            WS001_EPISODIOS_POR_NUHSAInputP_CAMPOSVARCHAR2OUT ws_lista_campos = new WS001_EPISODIOS_POR_NUHSAInputP_CAMPOSVARCHAR2OUT();
            ws_result = ws.WS001_EPISODIOS_POR_NUHSA(
                ws_output, System.Security.Principal.WindowsIdentity.GetCurrent().Name, txt_NUHSA.Text, ws_lista_campos, out p_campos);
            lbl_Campos.Text = p_campos;
            ws_post(ws);
        }

        private void btn_EPISODIOS_POR_NHIST_Click(object sender, EventArgs e)
        {
            PKG_WS_CMBD_NOKeepAlive ws = ws_pre();
            WS002_EPISODIOS_POR_NHISTInputP_RESULTADOXMLTYPEOUT ws_output = new WS002_EPISODIOS_POR_NHISTInputP_RESULTADOXMLTYPEOUT();
            WS002_EPISODIOS_POR_NHISTInputP_CAMPOSVARCHAR2OUT ws_lista_campos = new WS002_EPISODIOS_POR_NHISTInputP_CAMPOSVARCHAR2OUT();
            ws_result = ws.WS002_EPISODIOS_POR_NHIST(
                ws_output, p_quiensoy, txt_NHIST.Text, ws_lista_campos, out p_campos);
            lbl_Campos.Text = p_campos;
            ws_post(ws);
        }

        private void btn_EPISODIOS_POR_DNI_Click(object sender, EventArgs e)
        {
            PKG_WS_CMBD_NOKeepAlive ws = ws_pre();
            WS003_EPISODIOS_POR_NDNIInputP_RESULTADOXMLTYPEOUT ws_output = new WS003_EPISODIOS_POR_NDNIInputP_RESULTADOXMLTYPEOUT();
            WS003_EPISODIOS_POR_NDNIInputP_CAMPOSVARCHAR2OUT ws_lista_campos = new WS003_EPISODIOS_POR_NDNIInputP_CAMPOSVARCHAR2OUT();
            ws_result = ws.WS003_EPISODIOS_POR_NDNI(
                ws_output, p_quiensoy, txt_DNI.Text, ws_lista_campos, out p_campos);
            lbl_Campos.Text = p_campos;
            ws_post(ws);
        }

        private void btn_EPISODIO_POR_NADMI_Click(object sender, EventArgs e)
        {
            PKG_WS_CMBD_NOKeepAlive ws = ws_pre();
            WS005_EPISODIO_POR_NADMIInputP_RESULTADOXMLTYPEOUT ws_output = new  WS005_EPISODIO_POR_NADMIInputP_RESULTADOXMLTYPEOUT();
            WS005_EPISODIO_POR_NADMIInputP_CAMPOSVARCHAR2OUT ws_lista_campos = new WS005_EPISODIO_POR_NADMIInputP_CAMPOSVARCHAR2OUT();
            ws_result = ws.WS005_EPISODIO_POR_NADMI(
                ws_output, p_quiensoy, Convert.ToDouble(txt_NADMI.Text), ws_lista_campos, out p_campos);
            lbl_Campos.Text = p_campos;
            ws_post(ws);
        }

        private void btn_LISTA_SERVICIOS_Click(object sender, EventArgs e)
        {
            PKG_WS_CMBD_NOKeepAlive ws = ws_pre();
            WS006_LISTA_SERVICIOSInputP_RESULTADOXMLTYPEOUT ws_output = new WS006_LISTA_SERVICIOSInputP_RESULTADOXMLTYPEOUT();
            WS006_LISTA_SERVICIOSInputP_CAMPOSVARCHAR2OUT ws_lista_campos = new WS006_LISTA_SERVICIOSInputP_CAMPOSVARCHAR2OUT();
            ws_result = ws.WS006_LISTA_SERVICIOS(ws_output, p_quiensoy, ws_lista_campos, out p_campos);
            lbl_Campos.Text = p_campos;
            ws_post(ws);
        }

        private void btn_EPISODIOS_POR_SERVICIO_Click(object sender, EventArgs e)
        {
            PKG_WS_CMBD_NOKeepAlive ws = ws_pre();
            WS007_EPISODIOS_POR_SERVICIOInputP_RESULTADOXMLTYPEOUT ws_output = new WS007_EPISODIOS_POR_SERVICIOInputP_RESULTADOXMLTYPEOUT();
            WS007_EPISODIOS_POR_SERVICIOInputP_CAMPOSVARCHAR2OUT ws_lista_campos = new WS007_EPISODIOS_POR_SERVICIOInputP_CAMPOSVARCHAR2OUT();
            ws_result = ws.WS007_EPISODIOS_POR_SERVICIO(txt_SERVICIO.Text, ws_output, p_quiensoy, ws_lista_campos, out p_campos);
            ws_post(ws);
        }

        private PKG_WS_CMBD_NOKeepAlive ws_pre()
        {
            lbl_Campos.Text = "";
            txt_RESULTADO.Text = "";
            PKG_WS_CMBD_NOKeepAlive ws = new PKG_WS_CMBD_NOKeepAlive();
            frm_WS_CMBD.ActiveForm.Text = ws.Url;
            ws.Credentials = new System.Net.NetworkCredential("WS_RO", "LograZenyata17-0");
            ws.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap11;

            return ws;
        }

        private void ws_post(PKG_WS_CMBD_NOKeepAlive ws)
        {
            txt_RESULTADO.Text = ws_result.OuterXml.ToString().Replace("\n", "\r\n");
            ws.Dispose();
        }

        private void btn_ACTUALIZA_DOC_SINO_Click(object sender, EventArgs e)
        {
            PKG_WS_UPDX_NOKeepAlive ws = ws_rw_pre();
            WS001_MODIFICA_COD_SINOInputP_RESULTADOXMLTYPEOUT ws_output = new WS001_MODIFICA_COD_SINOInputP_RESULTADOXMLTYPEOUT();
            WS001_MODIFICA_COD_SINOInputP_CAMPOSVARCHAR2OUT ws_lista_campos = new WS001_MODIFICA_COD_SINOInputP_CAMPOSVARCHAR2OUT();
            ws_result = ws.WS001_MODIFICA_COD_SINO(ws_output, p_quiensoy, Convert.ToDouble(txt_ADMISION_ID.Text), ws_lista_campos, out p_campos);
            ws_rw_post(ws);
        }
        private PKG_WS_UPDX_NOKeepAlive ws_rw_pre()
        {
            lbl_Campos.Text = "";
            txt_RESULTADO.Text = "";
            PKG_WS_UPDX_NOKeepAlive ws = new PKG_WS_UPDX_NOKeepAlive();
            frm_WS_CMBD.ActiveForm.Text = ws.Url;
            ws.Credentials = new System.Net.NetworkCredential("WS_RO", "LograZenyata17-0");
            ws.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap11;

            return ws;
        }

        private void ws_rw_post(PKG_WS_UPDX_NOKeepAlive ws)
        {
            txt_RESULTADO.Text = ws_result.OuterXml.ToString().Replace("\n", "\r\n");
            ws.Dispose();
        }

    }

#if DEBUG
    public class PKG_WS_CMBD_NOKeepAlive : PKG_WS_CMBDService
#endif

#if !DEBUG
    public class PKG_WS_CMBD_NOKeepAlive : PKG_WS_CMBDService
#endif
    {
        protected override System.Net.WebRequest GetWebRequest(Uri uri)
        {
            System.Net.HttpWebRequest webRequest =
               (System.Net.HttpWebRequest)base.GetWebRequest(uri);
            webRequest.KeepAlive = false;
            return webRequest;
        }
    }
#if DEBUG
    public class PKG_WS_UPDX_NOKeepAlive : PKG_WS_UPDXService
#endif

#if !DEBUG
    public class PKG_WS_UPDX_NOKeepAlive : PKG_WS_UPDXService
#endif
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