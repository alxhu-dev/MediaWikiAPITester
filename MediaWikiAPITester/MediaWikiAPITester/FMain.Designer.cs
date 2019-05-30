namespace MediaWikiAPITester
{
    partial class FMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendToAPI = new System.Windows.Forms.Button();
            this.lblApiUrl = new System.Windows.Forms.Label();
            this.tbxApiUrl = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.lblParameterName = new System.Windows.Forms.Label();
            this.tbxParameterName = new System.Windows.Forms.TextBox();
            this.tbxParameterValue = new System.Windows.Forms.TextBox();
            this.lblParameterValue = new System.Windows.Forms.Label();
            this.btnAddParameter = new System.Windows.Forms.Button();
            this.lvParameters = new System.Windows.Forms.ListView();
            this.chParameterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chParameterValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveParameter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendToAPI
            // 
            this.btnSendToAPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendToAPI.Location = new System.Drawing.Point(12, 524);
            this.btnSendToAPI.Name = "btnSendToAPI";
            this.btnSendToAPI.Size = new System.Drawing.Size(331, 23);
            this.btnSendToAPI.TabIndex = 1;
            this.btnSendToAPI.Text = "Send to API";
            this.btnSendToAPI.UseVisualStyleBackColor = true;
            this.btnSendToAPI.Click += new System.EventHandler(this.BtnSendToAPI_Click);
            // 
            // lblApiUrl
            // 
            this.lblApiUrl.AutoSize = true;
            this.lblApiUrl.Location = new System.Drawing.Point(9, 30);
            this.lblApiUrl.Name = "lblApiUrl";
            this.lblApiUrl.Size = new System.Drawing.Size(64, 13);
            this.lblApiUrl.TabIndex = 2;
            this.lblApiUrl.Text = "URL of API:";
            // 
            // tbxApiUrl
            // 
            this.tbxApiUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxApiUrl.Location = new System.Drawing.Point(79, 27);
            this.tbxApiUrl.Name = "tbxApiUrl";
            this.tbxApiUrl.Size = new System.Drawing.Size(236, 20);
            this.tbxApiUrl.TabIndex = 2;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(379, 12);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(58, 13);
            this.lblResponse.TabIndex = 5;
            this.lblResponse.Text = "Response:";
            this.lblResponse.Click += new System.EventHandler(this.Label1_Click);
            // 
            // rtbResponse
            // 
            this.rtbResponse.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResponse.Location = new System.Drawing.Point(382, 28);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.ReadOnly = true;
            this.rtbResponse.Size = new System.Drawing.Size(567, 519);
            this.rtbResponse.TabIndex = 4;
            this.rtbResponse.Text = "";
            // 
            // lblParameterName
            // 
            this.lblParameterName.AutoSize = true;
            this.lblParameterName.Location = new System.Drawing.Point(12, 131);
            this.lblParameterName.Name = "lblParameterName";
            this.lblParameterName.Size = new System.Drawing.Size(86, 13);
            this.lblParameterName.TabIndex = 7;
            this.lblParameterName.Text = "ParameterName:";
            this.lblParameterName.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // tbxParameterName
            // 
            this.tbxParameterName.Location = new System.Drawing.Point(104, 128);
            this.tbxParameterName.Name = "tbxParameterName";
            this.tbxParameterName.Size = new System.Drawing.Size(148, 20);
            this.tbxParameterName.TabIndex = 8;
            this.tbxParameterName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxParameterName_KeyDown);
            // 
            // tbxParameterValue
            // 
            this.tbxParameterValue.Location = new System.Drawing.Point(104, 154);
            this.tbxParameterValue.Name = "tbxParameterValue";
            this.tbxParameterValue.Size = new System.Drawing.Size(148, 20);
            this.tbxParameterValue.TabIndex = 10;
            this.tbxParameterValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxParameterValue_KeyDown);
            // 
            // lblParameterValue
            // 
            this.lblParameterValue.AutoSize = true;
            this.lblParameterValue.Location = new System.Drawing.Point(13, 157);
            this.lblParameterValue.Name = "lblParameterValue";
            this.lblParameterValue.Size = new System.Drawing.Size(85, 13);
            this.lblParameterValue.TabIndex = 9;
            this.lblParameterValue.Text = "ParameterValue:";
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.Location = new System.Drawing.Point(258, 127);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(93, 21);
            this.btnAddParameter.TabIndex = 11;
            this.btnAddParameter.Text = "Add";
            this.btnAddParameter.UseVisualStyleBackColor = true;
            this.btnAddParameter.Click += new System.EventHandler(this.BtnAddParameter_Click);
            // 
            // lvParameters
            // 
            this.lvParameters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chParameterName,
            this.chParameterValue});
            this.lvParameters.FullRowSelect = true;
            this.lvParameters.GridLines = true;
            this.lvParameters.HideSelection = false;
            this.lvParameters.Location = new System.Drawing.Point(15, 180);
            this.lvParameters.Name = "lvParameters";
            this.lvParameters.Size = new System.Drawing.Size(328, 324);
            this.lvParameters.TabIndex = 12;
            this.lvParameters.UseCompatibleStateImageBehavior = false;
            this.lvParameters.View = System.Windows.Forms.View.Details;
            this.lvParameters.DoubleClick += new System.EventHandler(this.LvParameters_DoubleClick);
            // 
            // chParameterName
            // 
            this.chParameterName.Text = "Name";
            this.chParameterName.Width = 113;
            // 
            // chParameterValue
            // 
            this.chParameterValue.Text = "Value";
            this.chParameterValue.Width = 171;
            // 
            // btnRemoveParameter
            // 
            this.btnRemoveParameter.Location = new System.Drawing.Point(258, 153);
            this.btnRemoveParameter.Name = "btnRemoveParameter";
            this.btnRemoveParameter.Size = new System.Drawing.Size(93, 21);
            this.btnRemoveParameter.TabIndex = 13;
            this.btnRemoveParameter.Text = "Remove parameter";
            this.btnRemoveParameter.UseVisualStyleBackColor = true;
            this.btnRemoveParameter.Click += new System.EventHandler(this.BtnRemoveParameter_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 559);
            this.Controls.Add(this.btnRemoveParameter);
            this.Controls.Add(this.lvParameters);
            this.Controls.Add(this.btnAddParameter);
            this.Controls.Add(this.tbxParameterValue);
            this.Controls.Add(this.lblParameterValue);
            this.Controls.Add(this.tbxParameterName);
            this.Controls.Add(this.lblParameterName);
            this.Controls.Add(this.tbxApiUrl);
            this.Controls.Add(this.lblApiUrl);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.rtbResponse);
            this.Controls.Add(this.btnSendToAPI);
            this.Name = "FMain";
            this.Text = "MediaWiki API Tester";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxApiUrl;
        private System.Windows.Forms.Label lblApiUrl;
        private System.Windows.Forms.Button btnSendToAPI;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.Label lblParameterName;
        private System.Windows.Forms.TextBox tbxParameterName;
        private System.Windows.Forms.TextBox tbxParameterValue;
        private System.Windows.Forms.Label lblParameterValue;
        private System.Windows.Forms.Button btnAddParameter;
        private System.Windows.Forms.ListView lvParameters;
        private System.Windows.Forms.ColumnHeader chParameterName;
        private System.Windows.Forms.ColumnHeader chParameterValue;
        private System.Windows.Forms.Button btnRemoveParameter;
    }
}

