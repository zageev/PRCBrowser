namespace BrowserFixed
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonNewTab = new System.Windows.Forms.ToolStripButton();
            this.buttonCloseTab = new System.Windows.Forms.ToolStripButton();
            this.buttonBack = new System.Windows.Forms.ToolStripButton();
            this.buttonForward = new System.Windows.Forms.ToolStripButton();
            this.buttonHome = new System.Windows.Forms.ToolStripButton();
            this.textAdress = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelFavourite = new System.Windows.Forms.ToolStripLabel();
            this.buttonGO = new System.Windows.Forms.ToolStripButton();
            this.buttonAddFav = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonGOFav = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.buttonRemoveFav = new System.Windows.Forms.ToolStripButton();
            this.buttonGOHist = new System.Windows.Forms.ToolStripButton();
            this.comboBoxFav = new System.Windows.Forms.ToolStripComboBox();
            this.comboBoxHist = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNewTab,
            this.buttonCloseTab,
            this.buttonBack,
            this.buttonForward,
            this.buttonHome,
            this.textAdress,
            this.buttonGO,
            this.toolStripSeparator1,
            this.labelFavourite,
            this.buttonAddFav,
            this.buttonRemoveFav,
            this.comboBoxFav,
            this.buttonGOFav,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.comboBoxHist,
            this.buttonGOHist});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1270, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonNewTab
            // 
            this.buttonNewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonNewTab.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewTab.Image")));
            this.buttonNewTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonNewTab.Name = "buttonNewTab";
            this.buttonNewTab.Size = new System.Drawing.Size(23, 22);
            this.buttonNewTab.Text = "toolStripButton1";
            this.buttonNewTab.ToolTipText = "Новая вкладка";
            this.buttonNewTab.Click += new System.EventHandler(this.buttonNewTab_Click);
            // 
            // buttonCloseTab
            // 
            this.buttonCloseTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCloseTab.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseTab.Image")));
            this.buttonCloseTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCloseTab.Name = "buttonCloseTab";
            this.buttonCloseTab.Size = new System.Drawing.Size(23, 22);
            this.buttonCloseTab.Text = "toolStripButton2";
            this.buttonCloseTab.ToolTipText = "Закрыть вкладку";
            this.buttonCloseTab.Click += new System.EventHandler(this.buttonCloseTab_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(23, 22);
            this.buttonBack.Text = "toolStripButton3";
            this.buttonBack.ToolTipText = "Вернуться";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonForward.Image = ((System.Drawing.Image)(resources.GetObject("buttonForward.Image")));
            this.buttonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(23, 22);
            this.buttonForward.Text = "toolStripButton4";
            this.buttonForward.ToolTipText = "Перейти вперёд";
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(23, 22);
            this.buttonHome.Text = "toolStripButton5";
            this.buttonHome.ToolTipText = "Домашняя страница";
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // textAdress
            // 
            this.textAdress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(300, 25);
            this.textAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAdress_KeyPress);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // labelFavourite
            // 
            this.labelFavourite.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFavourite.Name = "labelFavourite";
            this.labelFavourite.Size = new System.Drawing.Size(71, 22);
            this.labelFavourite.Text = "Избранное:";
            // 
            // buttonGO
            // 
            this.buttonGO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonGO.Image = ((System.Drawing.Image)(resources.GetObject("buttonGO.Image")));
            this.buttonGO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(58, 22);
            this.buttonGO.Text = "Перейти";
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // buttonAddFav
            // 
            this.buttonAddFav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddFav.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddFav.Image")));
            this.buttonAddFav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddFav.Name = "buttonAddFav";
            this.buttonAddFav.Size = new System.Drawing.Size(23, 22);
            this.buttonAddFav.Text = "buttonAddFav";
            this.buttonAddFav.ToolTipText = "Добавить закладку";
            this.buttonAddFav.Click += new System.EventHandler(this.buttonAddFav_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonGOFav
            // 
            this.buttonGOFav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonGOFav.Image = ((System.Drawing.Image)(resources.GetObject("buttonGOFav.Image")));
            this.buttonGOFav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonGOFav.Name = "buttonGOFav";
            this.buttonGOFav.Size = new System.Drawing.Size(58, 22);
            this.buttonGOFav.Text = "Перейти";
            this.buttonGOFav.Click += new System.EventHandler(this.buttonGOFav_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel2.Text = "История:";
            // 
            // buttonRemoveFav
            // 
            this.buttonRemoveFav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRemoveFav.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveFav.Image")));
            this.buttonRemoveFav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRemoveFav.Name = "buttonRemoveFav";
            this.buttonRemoveFav.Size = new System.Drawing.Size(23, 22);
            this.buttonRemoveFav.Text = "buttonRemoveFav";
            this.buttonRemoveFav.ToolTipText = "Удалить закладку";
            this.buttonRemoveFav.Click += new System.EventHandler(this.buttonRemoveFav_Click);
            // 
            // buttonGOHist
            // 
            this.buttonGOHist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonGOHist.Image = ((System.Drawing.Image)(resources.GetObject("buttonGOHist.Image")));
            this.buttonGOHist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonGOHist.Name = "buttonGOHist";
            this.buttonGOHist.Size = new System.Drawing.Size(58, 22);
            this.buttonGOHist.Text = "Перейти";
            this.buttonGOHist.Click += new System.EventHandler(this.buttonGOHist_Click);
            // 
            // comboBoxFav
            // 
            this.comboBoxFav.Name = "comboBoxFav";
            this.comboBoxFav.Size = new System.Drawing.Size(200, 25);
            // 
            // comboBoxHist
            // 
            this.comboBoxHist.Name = "comboBoxHist";
            this.comboBoxHist.Size = new System.Drawing.Size(200, 25);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1270, 424);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1262, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(1256, 392);
            this.webBrowser.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonNewTab;
        private System.Windows.Forms.ToolStripButton buttonCloseTab;
        private System.Windows.Forms.ToolStripButton buttonBack;
        private System.Windows.Forms.ToolStripButton buttonForward;
        private System.Windows.Forms.ToolStripButton buttonHome;
        private System.Windows.Forms.ToolStripTextBox textAdress;
        private System.Windows.Forms.ToolStripButton buttonGO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labelFavourite;
        private System.Windows.Forms.ToolStripButton buttonAddFav;
        private System.Windows.Forms.ToolStripButton buttonRemoveFav;
        private System.Windows.Forms.ToolStripComboBox comboBoxFav;
        private System.Windows.Forms.ToolStripButton buttonGOFav;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox comboBoxHist;
        private System.Windows.Forms.ToolStripButton buttonGOHist;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

