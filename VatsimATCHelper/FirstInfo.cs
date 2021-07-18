using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatsimATCHelper
{
    public partial class FirstInfo : Form
    {
        public FirstInfo()
        {
            PilotData pd = new PilotData();

            InitializeComponent();

            CallSignTB.Text = "EX) KAL1234";
            CallSignTB.ForeColor = Color.Gray;

            DepartureTB.Text = "EX) INCHEON INTL AIRPORT";
            DepartureTB.ForeColor = Color.Gray;

            DepICAOTB.Text = "EX) RKSI";
            DepICAOTB.ForeColor = Color.Gray;

            ArrivalTB.Text = "EX) JEJU INTL AIRPORT";
            ArrivalTB.ForeColor = Color.Gray;

            ArrICAOTB.Text = "EX) RKPC";
            ArrICAOTB.ForeColor = Color.Gray;
        }

        #region TextBox Hint

        private void CallSignTB_Enter(object sender, EventArgs e)
        {
            if (CallSignTB.Text == "EX) KAL1234")
            {
                CallSignTB.Text = "";
                CallSignTB.ForeColor = Color.Black;
            }
        }

        private void CallSignTB_Leave(object sender, EventArgs e)
        {
            if (CallSignTB.Text == "")
            {
                CallSignTB.Text = "EX) KAL1234";
                CallSignTB.ForeColor = Color.Gray;
            }
        }

        private void DepartureTB_Enter(object sender, EventArgs e)
        {
            if (DepartureTB.Text == "EX) INCHEON INTL AIRPORT")
            {
                DepartureTB.Text = "";
                DepartureTB.ForeColor = Color.Black;
            }
        }

        private void DepartureTB_Leave(object sender, EventArgs e)
        {
            if (DepartureTB.Text == "")
            {
                DepartureTB.Text = "EX) INCHEON INTL AIRPORT";
                DepartureTB.ForeColor = Color.Gray;
            }
        }

        private void DepICAOTB_Enter(object sender, EventArgs e)
        {
            if (DepICAOTB.Text == "EX) RKSI")
            {
                DepICAOTB.Text = "";
                DepICAOTB.ForeColor = Color.Black;
            }
        }

        private void DepICAOTB_Leave(object sender, EventArgs e)
        {
            if (DepICAOTB.Text == "")
            {
                DepICAOTB.Text = "EX) RKSI";
                DepICAOTB.ForeColor = Color.Gray;
            }
        }

        private void ArrivalTB_Enter(object sender, EventArgs e)
        {
            if (ArrivalTB.Text == "EX) JEJU INTL AIRPORT")
            {
                ArrivalTB.Text = "";
                ArrivalTB.ForeColor = Color.Black;
            }
        }

        private void ArrivalTB_Leave(object sender, EventArgs e)
        {
            if (ArrivalTB.Text == "")
            {
                ArrivalTB.Text = "EX) JEJU INTL AIRPORT";
                ArrivalTB.ForeColor = Color.Gray;
            }
        }

        private void ArrICAOTB_Enter(object sender, EventArgs e)
        {
            if (ArrICAOTB.Text == "EX) RKPC")
            {
                ArrICAOTB.Text = "";
                ArrICAOTB.ForeColor = Color.Black;
            }
        }

        private void ArrICAOTB_Leave(object sender, EventArgs e)
        {
            if (ArrICAOTB.Text == "")
            {
                ArrICAOTB.Text = "EX) RKPC";
                ArrICAOTB.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void startButton_Click(object sender, EventArgs e)
        {

        }
    }
}
