using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripButton newButton = new ToolStripButton("New");
            ToolStripButton openButton = new ToolStripButton("Open");
            ToolStripButton saveButton = new ToolStripButton("Save");
            toolStrip1.Items.Add(newButton);
            toolStrip1.Items.Add(openButton);
            toolStrip1.Items.Add(saveButton);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
