
namespace barbershop
{
    partial class InsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertForm));
            this.SaveButton = new System.Windows.Forms.Button();
            this.InsertDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InsertDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.errorProvider.SetError(this.SaveButton, resources.GetString("SaveButton.Error"));
            this.errorProvider.SetIconAlignment(this.SaveButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("SaveButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.SaveButton, ((int)(resources.GetObject("SaveButton.IconPadding"))));
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // InsertDataGridView
            // 
            resources.ApplyResources(this.InsertDataGridView, "InsertDataGridView");
            this.InsertDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.errorProvider.SetError(this.InsertDataGridView, resources.GetString("InsertDataGridView.Error"));
            this.errorProvider.SetIconAlignment(this.InsertDataGridView, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("InsertDataGridView.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.InsertDataGridView, ((int)(resources.GetObject("InsertDataGridView.IconPadding"))));
            this.InsertDataGridView.Name = "InsertDataGridView";
            this.InsertDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.InsertDataGridView_CellValueChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // InsertForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InsertDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Name = "InsertForm";
            ((System.ComponentModel.ISupportInitialize)(this.InsertDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView InsertDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}