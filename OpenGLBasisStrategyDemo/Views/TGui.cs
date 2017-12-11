using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenGLBasisStrategyDemo.Views
{
    public partial class TGui : Form
    {
        TView oglView = new TView();

        public TGui()
        {
            InitializeComponent();

            oglView.Dock = DockStyle.Fill;
            pnlTGui.Controls.Add(oglView);

            pnlTGui.Focus();
        }
    }
}
