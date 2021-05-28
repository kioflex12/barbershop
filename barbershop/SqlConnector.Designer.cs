
namespace barbershop
{
    partial class SqlConnector
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
            this.components = new System.ComponentModel.Container();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DataBaseTextBox = new System.Windows.Forms.TextBox();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.DataBaseLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(63, 27);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(173, 20);
            this.ServerTextBox.TabIndex = 0;
            this.ServerTextBox.Text = "localhost";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(63, 53);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(173, 20);
            this.PortTextBox.TabIndex = 1;
            this.PortTextBox.Text = "3306";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(63, 79);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(173, 20);
            this.UserIDTextBox.TabIndex = 2;
            this.UserIDTextBox.Text = "root";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(63, 105);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(173, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // DataBaseTextBox
            // 
            this.DataBaseTextBox.Location = new System.Drawing.Point(63, 131);
            this.DataBaseTextBox.Name = "DataBaseTextBox";
            this.DataBaseTextBox.Size = new System.Drawing.Size(173, 20);
            this.DataBaseTextBox.TabIndex = 4;
            this.DataBaseTextBox.Text = "barbershop";
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(3, 30);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(38, 13);
            this.ServerLabel.TabIndex = 5;
            this.ServerLabel.Text = "Server";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(3, 56);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 6;
            this.PortLabel.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "UserID";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(3, 108);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(53, 13);
            this.PassLabel.TabIndex = 8;
            this.PassLabel.Text = "Password";
            // 
            // DataBaseLabel
            // 
            this.DataBaseLabel.AutoSize = true;
            this.DataBaseLabel.Location = new System.Drawing.Point(3, 134);
            this.DataBaseLabel.Name = "DataBaseLabel";
            this.DataBaseLabel.Size = new System.Drawing.Size(53, 13);
            this.DataBaseLabel.TabIndex = 9;
            this.DataBaseLabel.Text = "Database";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(166, 204);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(70, 23);
            this.ConnectButton.TabIndex = 10;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SqlConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 239);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.DataBaseLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.DataBaseTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.ServerTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SqlConnector";
            this.Text = "Присоединение к MySQL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SqlConnector_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox DataBaseTextBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label DataBaseLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}