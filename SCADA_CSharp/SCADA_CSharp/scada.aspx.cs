using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Timers;
//
using S7.Net;

namespace SCADA_CSharp
{
    public partial class scada : System.Web.UI.Page
    {
        static Plc myPLC;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    myPLC = new Plc(CpuType.S71500, "192.168.2.103", 0, 1); //"192.168.2.103"
                    controllaConnessione(myPLC.IsConnected);
                }
                catch (Exception ex)
                {
                    lblMessaggio.Text = ex.Message;
                }
            }
        }

        protected void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.Open();
                controllaConnessione(myPLC.IsConnected);
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
        }

        protected void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.Close();
                controllaConnessione(myPLC.IsConnected);
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
        }
        private void controllaConnessione(bool isConnected)
        {
            if (isConnected)
            {
                lblConnect.BackColor = System.Drawing.Color.Green;
                lblConnect.Text = "  --connected--  ";
            }
            else
            {
                lblConnect.BackColor = System.Drawing.Color.Red;
                lblConnect.Text = "  --disconnected--  ";
            }
        }

        protected void btnAuto_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.Write("DB1.DBX0.1", true);
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
            startGraphics();
        }

        protected void btnMan_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.Write("DB3.DBX0.2", true);
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
        }

        protected void btnIni1_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.Write("DB2.DBX0.6", true);
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
            startGraphics();
        }

        protected void btnAttesaStop_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.Write("DB2.DBX0.4", true);
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
            startGraphics();
        }
        void startGraphics()
        {
            
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += (Object source, ElapsedEventArgs e) =>
            {

            }

        }

        protected void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.Write("DB3.DBX0.0", true);
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
        }

        protected void btnAttivaEmergenza_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.Write("DB3.DBX0.4", true);
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.Write("DB3.DBX0.3", true);
            }
            catch (Exception ex)
            {
                lblMessaggio.Text = ex.Message;
            }
        }
    }
}