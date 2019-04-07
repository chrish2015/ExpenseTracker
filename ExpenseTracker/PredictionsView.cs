using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class PredictionsView : Form
    {
        private readonly PredictionController _controller=new PredictionController();
        public PredictionsView()
        {
            InitializeComponent();
        }


        private void btnGeneratePrd_Click(object sender, EventArgs e)
        {
            DateTime dateTime=dateTimePicker1.Value;
            int predictedValue=_controller.CalculatePredictions(dateTime);
            
            lblPrediction.Text = predictedValue.ToString();
            lblPrediction.Visible = true;
        }
    }
}
