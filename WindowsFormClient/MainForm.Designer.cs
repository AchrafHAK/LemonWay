namespace WindowsFormClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Title_Fibonacci = new System.Windows.Forms.Label();
            this.Lbl_Title_XmlToJson = new System.Windows.Forms.Label();
            this.TB_Input_Fibonacci = new System.Windows.Forms.TextBox();
            this.TB_Input_XML = new System.Windows.Forms.RichTextBox();
            this.Btn_Fibonacci = new System.Windows.Forms.Button();
            this.Btn_XmlToJson = new System.Windows.Forms.Button();
            this.Lbl_Output_Fibonacci = new System.Windows.Forms.Label();
            this.Lbl_SubTitle_Fibonacci = new System.Windows.Forms.Label();
            this.Lbl_SubTitle_Xml = new System.Windows.Forms.Label();
            this.TB_Output_JSON = new System.Windows.Forms.RichTextBox();
            this.Lbl_SubTitle_Json = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Title_Fibonacci
            // 
            this.Lbl_Title_Fibonacci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Title_Fibonacci.AutoSize = true;
            this.Lbl_Title_Fibonacci.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Title_Fibonacci.Location = new System.Drawing.Point(260, 5);
            this.Lbl_Title_Fibonacci.Name = "Lbl_Title_Fibonacci";
            this.Lbl_Title_Fibonacci.Size = new System.Drawing.Size(233, 33);
            this.Lbl_Title_Fibonacci.TabIndex = 0;
            this.Lbl_Title_Fibonacci.Text = "Fibonacci Sequence";
            this.Lbl_Title_Fibonacci.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Title_XmlToJson
            // 
            this.Lbl_Title_XmlToJson.AutoSize = true;
            this.Lbl_Title_XmlToJson.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Title_XmlToJson.Location = new System.Drawing.Point(255, 143);
            this.Lbl_Title_XmlToJson.Name = "Lbl_Title_XmlToJson";
            this.Lbl_Title_XmlToJson.Size = new System.Drawing.Size(254, 33);
            this.Lbl_Title_XmlToJson.TabIndex = 1;
            this.Lbl_Title_XmlToJson.Text = "Convert XML to JSON";
            // 
            // TB_Input_Fibonacci
            // 
            this.TB_Input_Fibonacci.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_Input_Fibonacci.Location = new System.Drawing.Point(206, 59);
            this.TB_Input_Fibonacci.Name = "TB_Input_Fibonacci";
            this.TB_Input_Fibonacci.Size = new System.Drawing.Size(62, 33);
            this.TB_Input_Fibonacci.TabIndex = 2;
            // 
            // TB_Input_XML
            // 
            this.TB_Input_XML.Location = new System.Drawing.Point(17, 233);
            this.TB_Input_XML.Name = "TB_Input_XML";
            this.TB_Input_XML.Size = new System.Drawing.Size(251, 196);
            this.TB_Input_XML.TabIndex = 3;
            this.TB_Input_XML.Text = "";
            // 
            // Btn_Fibonacci
            // 
            this.Btn_Fibonacci.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Fibonacci.FlatAppearance.BorderSize = 50;
            this.Btn_Fibonacci.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Fibonacci.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Fibonacci.Location = new System.Drawing.Point(284, 59);
            this.Btn_Fibonacci.Name = "Btn_Fibonacci";
            this.Btn_Fibonacci.Size = new System.Drawing.Size(77, 33);
            this.Btn_Fibonacci.TabIndex = 4;
            this.Btn_Fibonacci.Text = "GO";
            this.Btn_Fibonacci.UseVisualStyleBackColor = false;
            this.Btn_Fibonacci.Click += new System.EventHandler(this.Btn_Fibonacci_Click);
            // 
            // Btn_XmlToJson
            // 
            this.Btn_XmlToJson.AccessibleName = "r";
            this.Btn_XmlToJson.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_XmlToJson.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_XmlToJson.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_XmlToJson.Location = new System.Drawing.Point(284, 306);
            this.Btn_XmlToJson.Name = "Btn_XmlToJson";
            this.Btn_XmlToJson.Size = new System.Drawing.Size(77, 33);
            this.Btn_XmlToJson.TabIndex = 5;
            this.Btn_XmlToJson.Text = "GO";
            this.Btn_XmlToJson.UseVisualStyleBackColor = false;
            this.Btn_XmlToJson.Click += new System.EventHandler(this.Btn_XmlToJson_Click);
            // 
            // Lbl_Output_Fibonacci
            // 
            this.Lbl_Output_Fibonacci.AutoSize = true;
            this.Lbl_Output_Fibonacci.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Output_Fibonacci.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Output_Fibonacci.Location = new System.Drawing.Point(378, 62);
            this.Lbl_Output_Fibonacci.Name = "Lbl_Output_Fibonacci";
            this.Lbl_Output_Fibonacci.Size = new System.Drawing.Size(82, 26);
            this.Lbl_Output_Fibonacci.TabIndex = 6;
            this.Lbl_Output_Fibonacci.Text = "(empty)";
            this.Lbl_Output_Fibonacci.Visible = false;
            // 
            // Lbl_SubTitle_Fibonacci
            // 
            this.Lbl_SubTitle_Fibonacci.AutoSize = true;
            this.Lbl_SubTitle_Fibonacci.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_SubTitle_Fibonacci.Location = new System.Drawing.Point(13, 64);
            this.Lbl_SubTitle_Fibonacci.Name = "Lbl_SubTitle_Fibonacci";
            this.Lbl_SubTitle_Fibonacci.Size = new System.Drawing.Size(187, 23);
            this.Lbl_SubTitle_Fibonacci.TabIndex = 7;
            this.Lbl_SubTitle_Fibonacci.Text = "Please type an integer :";
            // 
            // Lbl_SubTitle_Xml
            // 
            this.Lbl_SubTitle_Xml.AutoSize = true;
            this.Lbl_SubTitle_Xml.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_SubTitle_Xml.Location = new System.Drawing.Point(17, 196);
            this.Lbl_SubTitle_Xml.Name = "Lbl_SubTitle_Xml";
            this.Lbl_SubTitle_Xml.Size = new System.Drawing.Size(247, 23);
            this.Lbl_SubTitle_Xml.TabIndex = 8;
            this.Lbl_SubTitle_Xml.Text = "Pleace type the XML to convert";
            // 
            // TB_Output_JSON
            // 
            this.TB_Output_JSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Output_JSON.Location = new System.Drawing.Point(383, 233);
            this.TB_Output_JSON.Name = "TB_Output_JSON";
            this.TB_Output_JSON.ReadOnly = true;
            this.TB_Output_JSON.Size = new System.Drawing.Size(256, 196);
            this.TB_Output_JSON.TabIndex = 9;
            this.TB_Output_JSON.Text = "";
            // 
            // Lbl_SubTitle_Json
            // 
            this.Lbl_SubTitle_Json.AutoSize = true;
            this.Lbl_SubTitle_Json.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_SubTitle_Json.Location = new System.Drawing.Point(457, 196);
            this.Lbl_SubTitle_Json.Name = "Lbl_SubTitle_Json";
            this.Lbl_SubTitle_Json.Size = new System.Drawing.Size(106, 23);
            this.Lbl_SubTitle_Json.TabIndex = 10;
            this.Lbl_SubTitle_Json.Text = "JSON output";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_SubTitle_Json);
            this.Controls.Add(this.TB_Output_JSON);
            this.Controls.Add(this.Lbl_SubTitle_Xml);
            this.Controls.Add(this.Lbl_SubTitle_Fibonacci);
            this.Controls.Add(this.Lbl_Output_Fibonacci);
            this.Controls.Add(this.Btn_XmlToJson);
            this.Controls.Add(this.Btn_Fibonacci);
            this.Controls.Add(this.TB_Input_XML);
            this.Controls.Add(this.TB_Input_Fibonacci);
            this.Controls.Add(this.Lbl_Title_XmlToJson);
            this.Controls.Add(this.Lbl_Title_Fibonacci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LemonWay Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title_Fibonacci;
        private System.Windows.Forms.Label Lbl_Title_XmlToJson;
        private System.Windows.Forms.TextBox TB_Input_Fibonacci;
        private System.Windows.Forms.RichTextBox TB_Input_XML;
        private System.Windows.Forms.Button Btn_Fibonacci;
        private System.Windows.Forms.Button Btn_XmlToJson;
        private System.Windows.Forms.Label Lbl_Output_Fibonacci;
        private System.Windows.Forms.Label Lbl_SubTitle_Fibonacci;
        private System.Windows.Forms.Label Lbl_SubTitle_Xml;
        private System.Windows.Forms.RichTextBox TB_Output_JSON;
        private System.Windows.Forms.Label Lbl_SubTitle_Json;
    }
}

