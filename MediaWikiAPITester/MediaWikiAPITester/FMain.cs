using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWikiAPITester
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSendToAPI_Click(object sender, EventArgs e)
        {
            rtbResponse.Clear();

            if(tbxApiUrl.Text.StartsWith("http"))
            {
                try
                {
                    rtbResponse.Text = GetWebResponseString(tbxApiUrl.Text, BuildParameterDictionary());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("URL doesn't has http:// or https://", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnAddParameter_Click(object sender, EventArgs e)
        {
            string parameterName = tbxParameterName.Text;
            string parameterValue = tbxParameterValue.Text;

            if(!string.IsNullOrEmpty(parameterName) && !string.IsNullOrEmpty(parameterValue))
            {
                lvParameters.Items.Add(parameterName).SubItems.Add(parameterValue);
            }

            tbxParameterName.Clear();
            tbxParameterValue.Clear();

            tbxParameterName.Focus();
        }

        private void BtnRemoveParameter_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedListViewItemCollection = lvParameters.SelectedItems;

            foreach (ListViewItem listViewItem in selectedListViewItemCollection)
            {
                lvParameters.Items.Remove(listViewItem);
            }
        }

        private Dictionary<string, string> BuildParameterDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            foreach(ListViewItem listViewItem in lvParameters.Items)
            {
                dictionary.Add(listViewItem.Text, listViewItem.SubItems[1].Text);
            }

            return dictionary;
        }

        private string GetWebResponseString(string url, Dictionary<string, string> parameters, string requestMethod = WebRequestMethods.Http.Post)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("Parameter 'url' is empty");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("Parameter 'parameters' is null");
            }
            if (string.IsNullOrEmpty(requestMethod))
            {
                throw new ArgumentNullException("Parameter 'requestMethod' is null");
            }

            string responseString = String.Empty;

            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add(HttpRequestHeader.UserAgent, GetUserAgentString());

                switch (requestMethod)
                {
                    case WebRequestMethods.Http.Post:
                        NameValueCollection nvc = new NameValueCollection();
                        parameters.ToList().ForEach(item =>
                        {
                            nvc.Add(item.Key, item.Value);
                        });
                        byte[] webResponse = webClient.UploadValues(url, nvc);
                        responseString = Encoding.Default.GetString(webResponse);
                        break;

                    default:
                        throw new ArgumentException(String.Format("The requestMethod '{0}' is not supported.", requestMethod));
                }
            }

            return responseString;
        }

        private string GetUserAgentString()
        {
            StringBuilder @string = new StringBuilder();

            @string.Append("MediaWikiAPITester/")
                   .Append(GetAssemblyFileVersion())
                   .Append(" ")
                   .Append("(https://github.com/alxhu-dev/MediaWikiAPITester)");

            return @string.ToString();
        }
        private string GetAssemblyFileVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }

        private void TbxParameterValue_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnAddParameter_Click(sender, null);
            }
            
        }

        private void LvParameters_DoubleClick(object sender, EventArgs e)
        {
            foreach(ListViewItem listViewItem in lvParameters.SelectedItems)
            {
                tbxParameterName.Text = listViewItem.Text;
                tbxParameterValue.Text = listViewItem.SubItems[1].Text;
            }

            BtnRemoveParameter_Click(sender, null);

            tbxParameterValue.Focus();
        }

        private void TbxParameterName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbxParameterValue.Focus();
            }
        }
    }
}
