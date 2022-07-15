using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Version_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var versions = assembly.GetName().Version;

            richTextBox1.AppendText($"{versions.Major}:{versions.Minor}:{versions.Build}:{versions.Revision}");
            richTextBox1.AppendText(Environment.NewLine);

            System.Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            richTextBox1.AppendText(version.ToString());
            richTextBox1.AppendText(Environment.NewLine);

            label1.Text = version.ToString();

            int day = version.Build;
            System.DateTime dtBuild = (new System.DateTime(2000, 1, 1)).AddDays(day);

            int intSeconds = version.Revision;
            intSeconds = intSeconds * 2;
            dtBuild = dtBuild.AddSeconds(intSeconds);

            System.Globalization.DaylightTime daylingTime = System.TimeZone.CurrentTimeZone.GetDaylightChanges(dtBuild.Year);

            if (System.TimeZone.IsDaylightSavingTime(dtBuild, daylingTime))
            {
                dtBuild = dtBuild.Add(daylingTime.Delta);
            }

            richTextBox1.AppendText(dtBuild.ToString());
            richTextBox1.AppendText(Environment.NewLine);
        }
    }
}
