namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Anket = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.surnamerror = new System.Windows.Forms.Label();
            this.Errorname = new System.Windows.Forms.Label();
            this.Elaveet = new System.Windows.Forms.Button();
            this.deyis = new System.Windows.Forms.Button();
            this.T_txt = new System.Windows.Forms.TextBox();
            this.E_txt = new System.Windows.Forms.TextBox();
            this.SN_txt = new System.Windows.Forms.TextBox();
            this.N_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surname_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.filename_txt = new System.Windows.Forms.TextBox();
            this.Anket.SuspendLayout();
            this.SuspendLayout();
            // 
            // Anket
            // 
            this.Anket.BackColor = System.Drawing.Color.Transparent;
            this.Anket.Controls.Add(this.dateTimePicker1);
            this.Anket.Controls.Add(this.phone_lbl);
            this.Anket.Controls.Add(this.email_lbl);
            this.Anket.Controls.Add(this.surnamerror);
            this.Anket.Controls.Add(this.Errorname);
            this.Anket.Controls.Add(this.Elaveet);
            this.Anket.Controls.Add(this.deyis);
            this.Anket.Controls.Add(this.T_txt);
            this.Anket.Controls.Add(this.E_txt);
            this.Anket.Controls.Add(this.SN_txt);
            this.Anket.Controls.Add(this.N_txt);
            this.Anket.Controls.Add(this.label5);
            this.Anket.Controls.Add(this.label4);
            this.Anket.Controls.Add(this.label3);
            this.Anket.Controls.Add(this.surname_lbl);
            this.Anket.Controls.Add(this.label1);
            this.Anket.Location = new System.Drawing.Point(12, 12);
            this.Anket.Name = "Anket";
            this.Anket.Size = new System.Drawing.Size(430, 433);
            this.Anket.TabIndex = 0;
            this.Anket.TabStop = false;
            this.Anket.Text = "groupBox1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // phone_lbl
            // 
            this.phone_lbl.ForeColor = System.Drawing.Color.Red;
            this.phone_lbl.Location = new System.Drawing.Point(107, 179);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(254, 15);
            this.phone_lbl.TabIndex = 15;
            this.phone_lbl.Text = " Telefonu duzgun daxil edin";
            this.phone_lbl.Visible = false;
            // 
            // email_lbl
            // 
            this.email_lbl.ForeColor = System.Drawing.Color.Red;
            this.email_lbl.Location = new System.Drawing.Point(107, 141);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(254, 15);
            this.email_lbl.TabIndex = 14;
            this.email_lbl.Text = " Emaili duzgun daxil edin";
            this.email_lbl.Visible = false;
            // 
            // surnamerror
            // 
            this.surnamerror.ForeColor = System.Drawing.Color.Red;
            this.surnamerror.Location = new System.Drawing.Point(107, 100);
            this.surnamerror.Name = "surnamerror";
            this.surnamerror.Size = new System.Drawing.Size(254, 15);
            this.surnamerror.TabIndex = 13;
            this.surnamerror.Text = " Soyadinizi duzgun daxil edin";
            this.surnamerror.Visible = false;
            // 
            // Errorname
            // 
            this.Errorname.ForeColor = System.Drawing.Color.Red;
            this.Errorname.Location = new System.Drawing.Point(107, 56);
            this.Errorname.Name = "Errorname";
            this.Errorname.Size = new System.Drawing.Size(254, 15);
            this.Errorname.TabIndex = 12;
            this.Errorname.Text = "Adininzi duzgun daxil edin";
            this.Errorname.Visible = false;
            // 
            // Elaveet
            // 
            this.Elaveet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Elaveet.Location = new System.Drawing.Point(259, 362);
            this.Elaveet.Name = "Elaveet";
            this.Elaveet.Size = new System.Drawing.Size(86, 49);
            this.Elaveet.TabIndex = 11;
            this.Elaveet.Tag = "add";
            this.Elaveet.Text = "Elave et";
            this.Elaveet.UseVisualStyleBackColor = true;
            this.Elaveet.Click += new System.EventHandler(this.Button_Click);
            // 
            // deyis
            // 
            this.deyis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deyis.Location = new System.Drawing.Point(259, 292);
            this.deyis.Name = "deyis";
            this.deyis.Size = new System.Drawing.Size(86, 49);
            this.deyis.TabIndex = 10;
            this.deyis.Tag = "Res";
            this.deyis.Text = "Deyis";
            this.deyis.UseVisualStyleBackColor = true;
            this.deyis.Visible = false;
            this.deyis.Click += new System.EventHandler(this.Button_Click);
            // 
            // T_txt
            // 
            this.T_txt.Location = new System.Drawing.Point(107, 159);
            this.T_txt.Name = "T_txt";
            this.T_txt.Size = new System.Drawing.Size(254, 23);
            this.T_txt.TabIndex = 8;
            this.T_txt.Tag = "tel";
            // 
            // E_txt
            // 
            this.E_txt.Location = new System.Drawing.Point(107, 118);
            this.E_txt.Name = "E_txt";
            this.E_txt.Size = new System.Drawing.Size(254, 23);
            this.E_txt.TabIndex = 7;
            // 
            // SN_txt
            // 
            this.SN_txt.Location = new System.Drawing.Point(107, 74);
            this.SN_txt.Name = "SN_txt";
            this.SN_txt.Size = new System.Drawing.Size(254, 23);
            this.SN_txt.TabIndex = 6;
            this.SN_txt.Tag = "";
            this.SN_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // N_txt
            // 
            this.N_txt.Location = new System.Drawing.Point(107, 31);
            this.N_txt.Name = "N_txt";
            this.N_txt.Size = new System.Drawing.Size(254, 23);
            this.N_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dogum";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // surname_lbl
            // 
            this.surname_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surname_lbl.Location = new System.Drawing.Point(6, 74);
            this.surname_lbl.Name = "surname_lbl";
            this.surname_lbl.Size = new System.Drawing.Size(57, 23);
            this.surname_lbl.TabIndex = 1;
            this.surname_lbl.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.listBox1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Linen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(471, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 349);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(471, 389);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 56);
            this.button3.TabIndex = 2;
            this.button3.Tag = "save";
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_load.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btn_load.FlatAppearance.BorderSize = 2;
            this.btn_load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btn_load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(581, 389);
            this.btn_load.Margin = new System.Windows.Forms.Padding(0);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(160, 56);
            this.btn_load.TabIndex = 3;
            this.btn_load.Tag = "load";
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.Button_Click);
            // 
            // filename_txt
            // 
            this.filename_txt.Location = new System.Drawing.Point(471, 363);
            this.filename_txt.Name = "filename_txt";
            this.filename_txt.PlaceholderText = "File name";
            this.filename_txt.Size = new System.Drawing.Size(270, 23);
            this.filename_txt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.filename_txt);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Anket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Anket.ResumeLayout(false);
            this.Anket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Anket;
        private Label label1;
        private Button Elaveet;
        private Button deyis;
        private TextBox T_txt;
        private TextBox E_txt;
        private TextBox SN_txt;
        private TextBox N_txt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label surname_lbl;
        private ListBox listBox1;
        private Button button3;
        private Button btn_load;
        private TextBox filename_txt;
        private Label phone_lbl;
        private Label email_lbl;
        private Label surnamerror;
        private Label Errorname;
        private DateTimePicker dateTimePicker1;
    }
}