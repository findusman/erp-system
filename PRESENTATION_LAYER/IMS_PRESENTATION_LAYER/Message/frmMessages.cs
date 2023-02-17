//using RestSharp;
using System;
using System.Data;
using System.Windows.Forms;
using System.Net;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Message
{
    public partial class frmMessages : Form
    {
        public frmMessages()
        {
            InitializeComponent();

            var dataset = getList();
            GridControl_messages.DataSource = dataset.Tables[0];
            GridView_Messages.PopulateColumns();
            GridView_Messages.BestFitColumns();
        }

        DAL.DALCustome dal = new DAL.DALCustome();
        DataSet getList()
        {



            return dal.selection("select * from TBL_Messages");

        }

        string updateList(string query)
        {
            return dal.ins_del_upd(query);

        }

        string sendMessage(string phone, string message)
        {
            ServicePointManager.Expect100Continue = true;
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            System.Net.WebClient client = new System.Net.WebClient();
            string str = client.DownloadString("http://fastsmsalerts.com/quicksms?id=dmlubricant&pass=Pinnacle@89&mask=DM LUBRICNT&to=" + phone + "&portable&lang=english&msg=" + message);
            //string str = client.DownloadString("http://fastsmsalerts.com/quicksms?id=dmlubricant&pass=Pinnacle@89&mask=DM LUBRICNT&to=923208400261&portable&lang=english&msg=" + message);

            if (str.Contains("Message Sent to"))
            {

                return "ok";

            }
            else return "not sent";
            //var client = new RestClient("http://fastsmsalerts.com/quicksms?id=dmlubricant&pass=Pinnacle%4089&mask=DM%20LUBRICNT&to="+
            //phone + "&portable=&lang=english&msg=" + message);
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("postman-token", "3df1ed9a-47f1-c2a2-ca98-c205b05591f9");
            //request.AddHeader("cache-control", "no-cache");
            //IRestResponse response = client.Execute(request);

            return "ok";
        }

        public void startSendingMessage()
        {
            string todayDate = DateTime.Now.ToString("dd-MM-yyyy");

            var dataset = getList();
            if (dataset == null)
            {
                MessageBox.Show("There's a problem software sending messages");
                return;

            }

            foreach (DataRow dr in dataset.Tables[0].Rows)
            {

                string phone = dr["phone"].ToString();
                int daysLimit = Convert.ToInt16(dr["days_limit"]);
                DateTime next_message_send_date = Convert.ToDateTime(dr["next_message_send_date"]);
                string message = dr["message"].ToString();
                DateTime Next_next_message_send_date = next_message_send_date.AddDays(daysLimit);

                if (next_message_send_date.ToString("dd-MM-yyyy") == todayDate || next_message_send_date.Date <= DateTime.Now.Date)
                {
                    string status = sendMessage(phone, message);
                    string query = "update TBL_Messages set status ='" + status + "', next_message_send_date = '" + Next_next_message_send_date + "', last_message_sent = '" + DateTime.Now + "'"
                                   + " where phone  = '" + phone + "'";
                    if (status != "ok")
                    {

                        MessageBox.Show("Message is not sent, there's a problem." + Environment.NewLine + Environment.NewLine +  phone + Environment.NewLine + Environment.NewLine + message);
                        //return;
                    }
                    else
                    {

                        if (updateList(query) != "ok")
                        {
                            MessageBox.Show("There's a problem software sending messages");
                            return;
                        }
                    }

                }



            }




        }

    }
}
