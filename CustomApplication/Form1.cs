using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpUpdate;
using System.Reflection;
namespace CustomApplication
{
    public partial class Form1 : Form ,ISharpUpdatable
    {
        private SharpUpdater updater;
        public Form1()
        {
            InitializeComponent();
            this.lblVersion.Text = this.ApplicationAssembly.GetName().Version.ToString();
            updater = new SharpUpdater(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }

        public string ApplicationName
        {
            get { return "CustomApplication"; }
        }

        public string ApplicationID
        {
            get { return "CustomApplication"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return  Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://www.bigbirdutilities.com/auto/pp-production/project.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
