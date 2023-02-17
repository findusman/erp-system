using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace PRESENTATION_LAYER.IMS_PRESENTATION_LAYER.Message
{
    class Message
    {
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
                                   + " where phone  = '"+ phone + "'";
                    if (status != "ok")
                    {

                        MessageBox.Show("Message is not sent, there's a problem with service provider. Contact Them");
                        return;
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
