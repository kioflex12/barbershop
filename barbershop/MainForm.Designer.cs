
namespace barbershop
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteClientsButton = new System.Windows.Forms.Button();
            this.ClientsDataGrid = new System.Windows.Forms.DataGridView();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertClientsButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteMastersButton = new System.Windows.Forms.Button();
            this.InsertMastersButton = new System.Windows.Forms.Button();
            this.MastersDataGrid = new System.Windows.Forms.DataGridView();
            this.id_masters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name_master = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_employment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_experiance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeleteServicesButton = new System.Windows.Forms.Button();
            this.InsertServicesButton = new System.Windows.Forms.Button();
            this.ServicesDataGrid = new System.Windows.Forms.DataGridView();
            this.id_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.id_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_service_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_service_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_master_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.InsertOrderButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MastersDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(824, 448);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_SelectionChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteClientsButton);
            this.tabPage1.Controls.Add(this.ClientsDataGrid);
            this.tabPage1.Controls.Add(this.InsertClientsButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteClientsButton
            // 
            this.DeleteClientsButton.Location = new System.Drawing.Point(640, 391);
            this.DeleteClientsButton.Name = "DeleteClientsButton";
            this.DeleteClientsButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteClientsButton.TabIndex = 3;
            this.DeleteClientsButton.Text = "Удалить";
            this.DeleteClientsButton.UseVisualStyleBackColor = true;
            this.DeleteClientsButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClientsDataGrid
            // 
            this.ClientsDataGrid.AllowUserToAddRows = false;
            this.ClientsDataGrid.AllowUserToDeleteRows = false;
            this.ClientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_client,
            this.date_of_birthday,
            this.full_name});
            this.ClientsDataGrid.Location = new System.Drawing.Point(3, 0);
            this.ClientsDataGrid.Name = "ClientsDataGrid";
            this.ClientsDataGrid.ReadOnly = true;
            this.ClientsDataGrid.Size = new System.Drawing.Size(550, 414);
            this.ClientsDataGrid.TabIndex = 2;
            // 
            // id_client
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.id_client.DefaultCellStyle = dataGridViewCellStyle1;
            this.id_client.HeaderText = "ID Клиента";
            this.id_client.Name = "id_client";
            this.id_client.ReadOnly = true;
            // 
            // date_of_birthday
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.date_of_birthday.DefaultCellStyle = dataGridViewCellStyle2;
            this.date_of_birthday.HeaderText = "Дата рождения";
            this.date_of_birthday.Name = "date_of_birthday";
            this.date_of_birthday.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.full_name.HeaderText = "ФИО";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // InsertClientsButton
            // 
            this.InsertClientsButton.Location = new System.Drawing.Point(559, 391);
            this.InsertClientsButton.Name = "InsertClientsButton";
            this.InsertClientsButton.Size = new System.Drawing.Size(75, 23);
            this.InsertClientsButton.TabIndex = 1;
            this.InsertClientsButton.Text = "Добавить";
            this.InsertClientsButton.UseVisualStyleBackColor = true;
            this.InsertClientsButton.Click += new System.EventHandler(this.InsertButon_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeleteMastersButton);
            this.tabPage2.Controls.Add(this.InsertMastersButton);
            this.tabPage2.Controls.Add(this.MastersDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мастера";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeleteMastersButton
            // 
            this.DeleteMastersButton.Location = new System.Drawing.Point(643, 388);
            this.DeleteMastersButton.Name = "DeleteMastersButton";
            this.DeleteMastersButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteMastersButton.TabIndex = 5;
            this.DeleteMastersButton.Text = "Удалить";
            this.DeleteMastersButton.UseVisualStyleBackColor = true;
            this.DeleteMastersButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InsertMastersButton
            // 
            this.InsertMastersButton.Location = new System.Drawing.Point(562, 388);
            this.InsertMastersButton.Name = "InsertMastersButton";
            this.InsertMastersButton.Size = new System.Drawing.Size(75, 23);
            this.InsertMastersButton.TabIndex = 4;
            this.InsertMastersButton.Text = "Добавить";
            this.InsertMastersButton.UseVisualStyleBackColor = true;
            this.InsertMastersButton.Click += new System.EventHandler(this.InsertButon_Click);
            // 
            // MastersDataGrid
            // 
            this.MastersDataGrid.AllowUserToAddRows = false;
            this.MastersDataGrid.AllowUserToDeleteRows = false;
            this.MastersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MastersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_masters,
            this.full_name_master,
            this.adress,
            this.date_of_employment,
            this.work_experiance});
            this.MastersDataGrid.Location = new System.Drawing.Point(3, 3);
            this.MastersDataGrid.Name = "MastersDataGrid";
            this.MastersDataGrid.ReadOnly = true;
            this.MastersDataGrid.Size = new System.Drawing.Size(553, 408);
            this.MastersDataGrid.TabIndex = 1;
            // 
            // id_masters
            // 
            this.id_masters.HeaderText = "ID Мастера";
            this.id_masters.Name = "id_masters";
            this.id_masters.ReadOnly = true;
            // 
            // full_name_master
            // 
            this.full_name_master.HeaderText = "ФИО";
            this.full_name_master.Name = "full_name_master";
            this.full_name_master.ReadOnly = true;
            // 
            // adress
            // 
            this.adress.HeaderText = "Адресс проживания";
            this.adress.Name = "adress";
            this.adress.ReadOnly = true;
            // 
            // date_of_employment
            // 
            this.date_of_employment.HeaderText = "Дата приема на работу";
            this.date_of_employment.Name = "date_of_employment";
            this.date_of_employment.ReadOnly = true;
            // 
            // work_experiance
            // 
            this.work_experiance.HeaderText = "Опыт работы";
            this.work_experiance.Name = "work_experiance";
            this.work_experiance.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DeleteServicesButton);
            this.tabPage3.Controls.Add(this.InsertServicesButton);
            this.tabPage3.Controls.Add(this.ServicesDataGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(816, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Услуги";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DeleteServicesButton
            // 
            this.DeleteServicesButton.Location = new System.Drawing.Point(646, 391);
            this.DeleteServicesButton.Name = "DeleteServicesButton";
            this.DeleteServicesButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteServicesButton.TabIndex = 5;
            this.DeleteServicesButton.Text = "Удалить";
            this.DeleteServicesButton.UseVisualStyleBackColor = true;
            this.DeleteServicesButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InsertServicesButton
            // 
            this.InsertServicesButton.Location = new System.Drawing.Point(565, 391);
            this.InsertServicesButton.Name = "InsertServicesButton";
            this.InsertServicesButton.Size = new System.Drawing.Size(75, 23);
            this.InsertServicesButton.TabIndex = 4;
            this.InsertServicesButton.Text = "Добавить";
            this.InsertServicesButton.UseVisualStyleBackColor = true;
            this.InsertServicesButton.Click += new System.EventHandler(this.InsertButon_Click);
            // 
            // ServicesDataGrid
            // 
            this.ServicesDataGrid.AllowUserToAddRows = false;
            this.ServicesDataGrid.AllowUserToDeleteRows = false;
            this.ServicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_service,
            this.name,
            this.price});
            this.ServicesDataGrid.Location = new System.Drawing.Point(6, 6);
            this.ServicesDataGrid.Name = "ServicesDataGrid";
            this.ServicesDataGrid.ReadOnly = true;
            this.ServicesDataGrid.Size = new System.Drawing.Size(553, 408);
            this.ServicesDataGrid.TabIndex = 0;
            // 
            // id_service
            // 
            this.id_service.HeaderText = "ID Улуги";
            this.id_service.Name = "id_service";
            this.id_service.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Название услуги";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Стоимость";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DeleteOrderButton);
            this.tabPage4.Controls.Add(this.InsertOrderButton);
            this.tabPage4.Controls.Add(this.OrdersDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(816, 422);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Заказы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_order,
            this.name_service_order,
            this.price_service_order,
            this.id_client_order,
            this.date_of_service,
            this.name_master_order});
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.Size = new System.Drawing.Size(646, 408);
            this.OrdersDataGridView.TabIndex = 1;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            // 
            // id_order
            // 
            this.id_order.HeaderText = "ID Заказа";
            this.id_order.Name = "id_order";
            this.id_order.ReadOnly = true;
            // 
            // name_service_order
            // 
            this.name_service_order.HeaderText = "Услуга";
            this.name_service_order.Name = "name_service_order";
            this.name_service_order.ReadOnly = true;
            // 
            // price_service_order
            // 
            this.price_service_order.HeaderText = "Стоимость";
            this.price_service_order.Name = "price_service_order";
            this.price_service_order.ReadOnly = true;
            // 
            // id_client_order
            // 
            this.id_client_order.HeaderText = "Клиент";
            this.id_client_order.Name = "id_client_order";
            this.id_client_order.ReadOnly = true;
            // 
            // date_of_service
            // 
            this.date_of_service.HeaderText = "Дата оформления заказ";
            this.date_of_service.Name = "date_of_service";
            this.date_of_service.ReadOnly = true;
            // 
            // name_master_order
            // 
            this.name_master_order.HeaderText = "Мастер";
            this.name_master_order.Name = "name_master_order";
            this.name_master_order.ReadOnly = true;
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Location = new System.Drawing.Point(736, 388);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrderButton.TabIndex = 7;
            this.DeleteOrderButton.Text = "Удалить";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InsertOrderButton
            // 
            this.InsertOrderButton.Location = new System.Drawing.Point(655, 388);
            this.InsertOrderButton.Name = "InsertOrderButton";
            this.InsertOrderButton.Size = new System.Drawing.Size(75, 23);
            this.InsertOrderButton.TabIndex = 6;
            this.InsertOrderButton.Text = "Добавить";
            this.InsertOrderButton.UseVisualStyleBackColor = true;
            this.InsertOrderButton.Click += new System.EventHandler(this.InsertButon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 448);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MastersDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button InsertClientsButton;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.DataGridView ClientsDataGrid;
        private System.Windows.Forms.DataGridView ServicesDataGrid;
        private System.Windows.Forms.DataGridView MastersDataGrid;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.Button DeleteClientsButton;
        private System.Windows.Forms.Button DeleteMastersButton;
        private System.Windows.Forms.Button InsertMastersButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_masters;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name_master;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_employment;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_experiance;
        private System.Windows.Forms.Button DeleteServicesButton;
        private System.Windows.Forms.Button InsertServicesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_service_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_service_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_master_order;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button InsertOrderButton;
    }
}

