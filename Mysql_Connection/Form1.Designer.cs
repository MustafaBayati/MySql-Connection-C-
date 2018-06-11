namespace Mysql_Connection
{
    partial class DB_Connection
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
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.database = new System.Windows.Forms.ComboBox();
            this.server = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(361, 56);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(121, 23);
            this.connect.TabIndex = 6;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DataBases :";
            // 
            // database
            // 
            this.database.FormattingEnabled = true;
            this.database.Location = new System.Drawing.Point(361, 29);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(121, 21);
            this.database.TabIndex = 5;
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(99, 32);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(121, 20);
            this.server.TabIndex = 1;
            this.server.Text = "localhost";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(99, 61);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(121, 20);
            this.username.TabIndex = 2;
            this.username.Text = "root";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(99, 88);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(121, 20);
            this.password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password :";
            // 
            // checkConnection
            // 
            this.checkConnection.Location = new System.Drawing.Point(99, 114);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(121, 23);
            this.checkConnection.TabIndex = 4;
            this.checkConnection.Text = "Check Connection";
            this.checkConnection.UseVisualStyleBackColor = true;
            this.checkConnection.Click += new System.EventHandler(this.checkConnection_Click);
            // 
            // DB_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 168);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.server);
            this.Controls.Add(this.database);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect);
            this.MaximizeBox = false;
            this.Name = "DB_Connection";
            this.Text = "MySql Connection";
            this.Load += new System.EventHandler(this.DB_Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox database;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkConnection;
    }
}

