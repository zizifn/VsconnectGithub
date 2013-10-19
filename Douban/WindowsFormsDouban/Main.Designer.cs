namespace WindowsFormsDouban
{
    using System.Reflection;
    using System.Windows.Forms;
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wbDouban = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            TrySetSuppressScriptErrors(wbDouban, true);
            // 
            // wbDouban
            // 
            this.wbDouban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbDouban.Location = new System.Drawing.Point(0, 0);
            this.wbDouban.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDouban.Name = "wbDouban";
            this.wbDouban.ScrollBarsEnabled = false;
            this.wbDouban.Size = new System.Drawing.Size(284, 261);
            this.wbDouban.TabIndex = 0;
            this.wbDouban.Url = new System.Uri("http://douban.fm/radio", System.UriKind.Absolute);
            this.wbDouban.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbDouban_DocumentCompleted);
            this.wbDouban.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbDouban_Navigated);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.wbDouban);
            this.Name = "Main";
            this.Text = "douban";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
        

        }


        private  bool TrySetSuppressScriptErrors(WebBrowser webBrowser, bool value)
        {
            FieldInfo field = typeof(WebBrowser).GetField("axIWebBrowser2", BindingFlags.Instance | BindingFlags.NonPublic);
            if (field != null)
            {
                object axIWebBrowser2 = field.GetValue(webBrowser);
                if (axIWebBrowser2 != null)
                {
                    axIWebBrowser2.GetType().InvokeMember("Silent", BindingFlags.SetProperty, null, axIWebBrowser2, new object[] { value });
                    return true;
                }
            }

            return false;
        }
        #endregion

        private System.Windows.Forms.WebBrowser wbDouban;
    }
}

