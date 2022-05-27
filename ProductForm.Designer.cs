namespace GentlemensCloset
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_options = new System.Windows.Forms.Panel();
            this.button_logout = new Guna.UI2.WinForms.Guna2Button();
            this.button_selling = new Guna.UI2.WinForms.Guna2Button();
            this.button_categories = new Guna.UI2.WinForms.Guna2Button();
            this.button_employees = new Guna.UI2.WinForms.Guna2Button();
            this.panel_user = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.exitPicture = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.DataGridView_products = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox_refresh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_update = new Guna.UI2.WinForms.Guna2Button();
            this.button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.button_add = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_category = new System.Windows.Forms.Label();
            this.textBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_quantity = new System.Windows.Forms.Label();
            this.textBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.panel_options.SuspendLayout();
            this.panel_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPicture)).BeginInit();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_products)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_options
            // 
            this.panel_options.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_options.Controls.Add(this.button_logout);
            this.panel_options.Controls.Add(this.button_selling);
            this.panel_options.Controls.Add(this.button_categories);
            this.panel_options.Controls.Add(this.button_employees);
            this.panel_options.Controls.Add(this.panel_user);
            this.panel_options.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_options.Location = new System.Drawing.Point(0, 0);
            this.panel_options.Margin = new System.Windows.Forms.Padding(2);
            this.panel_options.Name = "panel_options";
            this.panel_options.Size = new System.Drawing.Size(120, 540);
            this.panel_options.TabIndex = 0;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_logout.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_logout.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_logout.Location = new System.Drawing.Point(0, 497);
            this.button_logout.Margin = new System.Windows.Forms.Padding(2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(120, 43);
            this.button_logout.TabIndex = 4;
            this.button_logout.Text = "Salir";
            this.button_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_selling
            // 
            this.button_selling.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_selling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_selling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_selling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_selling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_selling.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_selling.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_selling.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_selling.Location = new System.Drawing.Point(0, 186);
            this.button_selling.Margin = new System.Windows.Forms.Padding(2);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(120, 43);
            this.button_selling.TabIndex = 3;
            this.button_selling.Text = "Ventas";
            this.button_selling.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_selling.Click += new System.EventHandler(this.button_selling_Click);
            // 
            // button_categories
            // 
            this.button_categories.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_categories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_categories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_categories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_categories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_categories.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_categories.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_categories.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_categories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_categories.Location = new System.Drawing.Point(0, 143);
            this.button_categories.Margin = new System.Windows.Forms.Padding(2);
            this.button_categories.Name = "button_categories";
            this.button_categories.Size = new System.Drawing.Size(120, 43);
            this.button_categories.TabIndex = 2;
            this.button_categories.Text = "Categorías";
            this.button_categories.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_categories.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_employees
            // 
            this.button_employees.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_employees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_employees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_employees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_employees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_employees.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_employees.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_employees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_employees.Location = new System.Drawing.Point(0, 100);
            this.button_employees.Margin = new System.Windows.Forms.Padding(2);
            this.button_employees.Name = "button_employees";
            this.button_employees.Size = new System.Drawing.Size(120, 43);
            this.button_employees.TabIndex = 1;
            this.button_employees.Text = "Empleados";
            this.button_employees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_employees.Click += new System.EventHandler(this.button_employees_Click);
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_user.Controls.Add(this.label_username);
            this.panel_user.Controls.Add(this.pictureBox_user);
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user.Location = new System.Drawing.Point(0, 0);
            this.panel_user.Margin = new System.Windows.Forms.Padding(2);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(120, 100);
            this.panel_user.TabIndex = 0;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_username.Location = new System.Drawing.Point(31, 73);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(54, 15);
            this.label_username.TabIndex = 16;
            this.label_username.Text = "ADMIN";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_user.Image")));
            this.pictureBox_user.Location = new System.Drawing.Point(34, 20);
            this.pictureBox_user.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(51, 51);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_user.TabIndex = 0;
            this.pictureBox_user.TabStop = false;
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Controls.Add(this.exitPicture);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(120, 0);
            this.panel_head.Margin = new System.Windows.Forms.Padding(2);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(840, 32);
            this.panel_head.TabIndex = 1;
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Georgia", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_head.Location = new System.Drawing.Point(278, 5);
            this.label_head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(269, 23);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "GESTIONAR PRODUCTOS";
            // 
            // exitPicture
            // 
            this.exitPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitPicture.Image = ((System.Drawing.Image)(resources.GetObject("exitPicture.Image")));
            this.exitPicture.Location = new System.Drawing.Point(799, 0);
            this.exitPicture.Margin = new System.Windows.Forms.Padding(2);
            this.exitPicture.Name = "exitPicture";
            this.exitPicture.Size = new System.Drawing.Size(41, 32);
            this.exitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPicture.TabIndex = 11;
            this.exitPicture.TabStop = false;
            this.exitPicture.Click += new System.EventHandler(this.exitPicture_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_main.Controls.Add(this.DataGridView_products);
            this.panel_main.Controls.Add(this.button_refresh);
            this.panel_main.Controls.Add(this.comboBox_refresh);
            this.panel_main.Controls.Add(this.button_update);
            this.panel_main.Controls.Add(this.button_delete);
            this.panel_main.Controls.Add(this.button_add);
            this.panel_main.Controls.Add(this.comboBox_category);
            this.panel_main.Controls.Add(this.label_category);
            this.panel_main.Controls.Add(this.textBox_price);
            this.panel_main.Controls.Add(this.label_price);
            this.panel_main.Controls.Add(this.textBox_quantity);
            this.panel_main.Controls.Add(this.label_quantity);
            this.panel_main.Controls.Add(this.textBox_name);
            this.panel_main.Controls.Add(this.label_name);
            this.panel_main.Controls.Add(this.textBox_id);
            this.panel_main.Controls.Add(this.label_id);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(120, 32);
            this.panel_main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(840, 508);
            this.panel_main.TabIndex = 14;
            // 
            // DataGridView_products
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView_products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_products.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_products.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_products.EnableHeadersVisualStyles = false;
            this.DataGridView_products.GridColor = System.Drawing.Color.Gray;
            this.DataGridView_products.Location = new System.Drawing.Point(281, 49);
            this.DataGridView_products.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView_products.Name = "DataGridView_products";
            this.DataGridView_products.ReadOnly = true;
            this.DataGridView_products.RowHeadersVisible = false;
            this.DataGridView_products.RowHeadersWidth = 72;
            this.DataGridView_products.RowTemplate.Height = 31;
            this.DataGridView_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_products.Size = new System.Drawing.Size(548, 448);
            this.DataGridView_products.TabIndex = 16;
            this.DataGridView_products.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_products.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_products.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_products.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_products.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_products.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView_products.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.DataGridView_products.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_products.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_products.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_products.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_products.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_products.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_products.ThemeStyle.ReadOnly = true;
            this.DataGridView_products.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_products.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_products.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_products.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_products.ThemeStyle.RowsStyle.Height = 31;
            this.DataGridView_products.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_products.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_products.Click += new System.EventHandler(this.DataGridView_products_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BorderRadius = 5;
            this.button_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_refresh.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_refresh.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(590, 15);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(97, 24);
            this.button_refresh.TabIndex = 15;
            this.button_refresh.Text = "Refrescar";
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_refresh
            // 
            this.comboBox_refresh.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_refresh.BorderColor = System.Drawing.Color.Gray;
            this.comboBox_refresh.BorderRadius = 5;
            this.comboBox_refresh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_refresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_refresh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_refresh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_refresh.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_refresh.ItemHeight = 30;
            this.comboBox_refresh.Location = new System.Drawing.Point(442, 9);
            this.comboBox_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_refresh.Name = "comboBox_refresh";
            this.comboBox_refresh.Size = new System.Drawing.Size(144, 36);
            this.comboBox_refresh.TabIndex = 14;
            this.comboBox_refresh.SelectionChangeCommitted += new System.EventHandler(this.comboBox_refresh_SelectionChangeCommitted);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_update.BorderRadius = 5;
            this.button_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_update.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_update.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(87, 253);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(97, 24);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Actualizar";
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BorderRadius = 5;
            this.button_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_delete.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_delete.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(188, 253);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(88, 24);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Eliminar";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BorderRadius = 5;
            this.button_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_add.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_add.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(4, 253);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(79, 24);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Añadir";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_category.BorderColor = System.Drawing.Color.Gray;
            this.comboBox_category.BorderRadius = 5;
            this.comboBox_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_category.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_category.ItemHeight = 30;
            this.comboBox_category.Location = new System.Drawing.Point(102, 202);
            this.comboBox_category.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(161, 36);
            this.comboBox_category.TabIndex = 9;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_category.Location = new System.Drawing.Point(20, 213);
            this.label_category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(71, 15);
            this.label_category.TabIndex = 8;
            this.label_category.Text = "Categoría";
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_price.BorderColor = System.Drawing.Color.Gray;
            this.textBox_price.BorderRadius = 5;
            this.textBox_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_price.DefaultText = "";
            this.textBox_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_price.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_price.Location = new System.Drawing.Point(102, 169);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.PasswordChar = '\0';
            this.textBox_price.PlaceholderText = "";
            this.textBox_price.SelectedText = "";
            this.textBox_price.Size = new System.Drawing.Size(160, 22);
            this.textBox_price.TabIndex = 7;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_price.Location = new System.Drawing.Point(20, 173);
            this.label_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(47, 15);
            this.label_price.TabIndex = 6;
            this.label_price.Text = "Precio";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_quantity.BorderColor = System.Drawing.Color.Gray;
            this.textBox_quantity.BorderRadius = 5;
            this.textBox_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_quantity.DefaultText = "";
            this.textBox_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_quantity.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_quantity.Location = new System.Drawing.Point(102, 129);
            this.textBox_quantity.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.PasswordChar = '\0';
            this.textBox_quantity.PlaceholderText = "";
            this.textBox_quantity.SelectedText = "";
            this.textBox_quantity.Size = new System.Drawing.Size(160, 22);
            this.textBox_quantity.TabIndex = 5;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_quantity.Location = new System.Drawing.Point(20, 133);
            this.label_quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(68, 15);
            this.label_quantity.TabIndex = 4;
            this.label_quantity.Text = "Cantidad";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_name.BorderColor = System.Drawing.Color.Gray;
            this.textBox_name.BorderRadius = 5;
            this.textBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_name.DefaultText = "";
            this.textBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_name.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_name.Location = new System.Drawing.Point(102, 89);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.PasswordChar = '\0';
            this.textBox_name.PlaceholderText = "";
            this.textBox_name.SelectedText = "";
            this.textBox_name.Size = new System.Drawing.Size(160, 22);
            this.textBox_name.TabIndex = 3;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_name.Location = new System.Drawing.Point(20, 93);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(59, 15);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Nombre";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_id.BorderColor = System.Drawing.Color.Gray;
            this.textBox_id.BorderRadius = 5;
            this.textBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_id.DefaultText = "";
            this.textBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_id.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_id.Location = new System.Drawing.Point(102, 49);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.PasswordChar = '\0';
            this.textBox_id.PlaceholderText = "";
            this.textBox_id.SelectedText = "";
            this.textBox_id.Size = new System.Drawing.Size(160, 22);
            this.textBox_id.TabIndex = 1;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_id.Location = new System.Drawing.Point(20, 53);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(22, 15);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.panel_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel_options.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPicture)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_options;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Panel panel_main;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_category;
        private System.Windows.Forms.Label label_category;
        private Guna.UI2.WinForms.Guna2TextBox textBox_price;
        private System.Windows.Forms.Label label_price;
        private Guna.UI2.WinForms.Guna2TextBox textBox_quantity;
        private System.Windows.Forms.Label label_quantity;
        private Guna.UI2.WinForms.Guna2TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private Guna.UI2.WinForms.Guna2TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private Guna.UI2.WinForms.Guna2Button button_update;
        private Guna.UI2.WinForms.Guna2Button button_delete;
        private Guna.UI2.WinForms.Guna2Button button_add;
        private System.Windows.Forms.PictureBox exitPicture;
        private Guna.UI2.WinForms.Guna2Button button_selling;
        private Guna.UI2.WinForms.Guna2Button button_categories;
        private Guna.UI2.WinForms.Guna2Button button_employees;
        private System.Windows.Forms.Label label_head;
        private Guna.UI2.WinForms.Guna2Button button_refresh;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_refresh;
        private Guna.UI2.WinForms.Guna2Button button_logout;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_products;
    }
}