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
    public partial class btnGneerate : Form
    {
        PredictionController _controller=new PredictionController();
        public btnGneerate()
        {
            InitializeComponent();
        }


        private void btnGeneratePrd_Click(object sender, EventArgs e)
        {
            int predictedValue=_controller.predictExpense();
           
            lblPrediction.Text = predictedValue.ToString();
            lblPrediction.Visible = true;
        }
    }
}
