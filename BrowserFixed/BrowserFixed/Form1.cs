using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserFixed
{

    public partial class Form1 : Form
    {
        int tabNum = 0;
        int historyLine = 0;
        int favLine = 0;
        ArrayList history = new ArrayList();
        ArrayList favourite = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.ya.ru");
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
            DateTime dateTime = DateTime.Now;
            int year = dateTime.Year;
            int month = dateTime.Month;
            int day = dateTime.Day;
            int hour = dateTime.Hour;
            int minute = dateTime.Minute;
            history.Add(day + "." + month + "." + year + " " + hour + ":" + minute + " " + webBrowser.Url.ToString());
            comboBoxHist.Items.Add(history[historyLine].ToString());
            historyLine += 1;
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
                web.Navigate(textAdress.Text);
        }
        WebBrowser webTab = null;
        private void buttonNewTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Новая вкладка";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.ya.ru");
            textAdress.Text = "https://www.ya.ru";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }
        private void buttonCloseTab_Click(object sender, EventArgs e)
        {
            if (tabControl.Controls.Count > 1)
            {
                tabControl.Controls.RemoveAt(tabControl.SelectedIndex);
                tabControl.SelectTab(tabControl.TabCount - 1);
            }
            else
            {
                Application.Exit();
            }
        }
        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webTab.DocumentTitle;
            DateTime dateTime = DateTime.Now;
            int year = dateTime.Year;
            int month = dateTime.Month;
            int day = dateTime.Day;
            int hour = dateTime.Hour;
            int minute = dateTime.Minute;
            history.Add(day + "." + month + "." + year + " " + hour + ":" + minute + " " + webTab.Url.ToString());
            comboBoxHist.Items.Add(history[historyLine].ToString());
            historyLine += 1;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                {
                    web.GoBack();
                }
            }
        }
        private void buttonForward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                {
                    web.GoForward();
                }
            }
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.GoHome();
                textAdress.Text = web.Url.AbsoluteUri.ToString();
            }
        }
        private void textAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(textAdress.Text);
                }
            }
        }
        private void buttonGOHist_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null && comboBoxHist.Text != "")
            {
                textAdress.Text = comboBoxHist.Text.Split(' ')[2];
                web.Navigate(textAdress.Text);
                comboBoxHist.Text = null;
            }
        }

        private void buttonAddFav_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (!(favourite.Contains(web.Url.ToString())))
                {
                    favourite.Add(web.Url.ToString());
                    comboBoxFav.Items.Add(favourite[favLine].ToString());
                    favLine += 1;
                }
            }
        }
        private void buttonRemoveFav_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (favourite.Contains(web.Url.ToString()))
                {
                    favourite.Remove(web.Url.ToString());
                    favLine -= 1;
                    comboBoxFav.Items.Remove(web.Url.ToString());
                }
            }
        }
        private void buttonGOFav_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null && comboBoxFav.Text != "")
            {
                textAdress.Text = comboBoxFav.Text;
                web.Navigate(comboBoxFav.Text);
                comboBoxFav.Text = null;
            }
        }
    }
}
