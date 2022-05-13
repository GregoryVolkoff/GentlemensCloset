namespace GentlemensCloset
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.panel_options = new System.Windows.Forms.Panel();
            this.button_logout = new Guna.UI2.WinForms.Guna2Button();
            this.button_selling = new Guna.UI2.WinForms.Guna2Button();
            this.button_category = new Guna.UI2.WinForms.Guna2Button();
            this.button_employee = new Guna.UI2.WinForms.Guna2Button();
            this.panel_user = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.exitPicture = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.DataGridView_categories = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_update = new Guna.UI2.WinForms.Guna2Button();
            this.button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.button_add = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_description = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_options
            // 
            this.panel_options.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_options.Controls.Add(this.button_logout);
            this.panel_options.Controls.Add(this.button_selling);
            this.panel_options.Controls.Add(this.button_category);
            this.panel_options.Controls.Add(this.button_employee);
            this.panel_options.Controls.Add(this.panel_user);
            this.panel_options.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_options.Location = new System.Drawing.Point(0, 0);
            this.panel_options.Margin = new System.Windows.Forms.Padding(2);
            this.panel_options.Name = "panel_options";
            this.panel_options.Size = new System.Drawing.Size(120, 540);
            this.panel_options.TabIndex = 1;
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
            this.button_selling.Location = new System.Drawing.Point(0, 183);
            this.button_selling.Margin = new System.Windows.Forms.Padding(2);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(120, 43);
            this.button_selling.TabIndex = 3;
            this.button_selling.Text = "Venta";
            this.button_selling.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button_category
            // 
            this.button_category.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_category.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_category.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_category.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_category.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_category.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_category.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_category.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_category.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_category.Location = new System.Drawing.Point(0, 140);
            this.button_category.Margin = new System.Windows.Forms.Padding(2);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(120, 43);
            this.button_category.TabIndex = 2;
            this.button_category.Text = "Producto";
            this.button_category.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button_employee
            // 
            this.button_employee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_employee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_employee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_employee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_employee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_employee.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_employee.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_employee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_employee.Location = new System.Drawing.Point(0, 97);
            this.button_employee.Margin = new System.Windows.Forms.Padding(2);
            this.button_employee.Name = "button_employee";
            this.button_employee.Size = new System.Drawing.Size(120, 43);
            this.button_employee.TabIndex = 1;
            this.button_employee.Text = "Empleado";
            this.button_employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.panel_user.Size = new System.Drawing.Size(120, 97);
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
            this.pictureBox_user.Location = new System.Drawing.Point(28, 17);
            this.pictureBox_user.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(55, 54);
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
            this.panel_head.Size = new System.Drawing.Size(840, 31);
            this.panel_head.TabIndex = 2;
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Georgia", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_head.Location = new System.Drawing.Point(281, 6);
            this.label_head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(273, 23);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "GESTIONAR CATEGORIAS";
            // 
            // exitPicture
            // 
            this.exitPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitPicture.Image = ((System.Drawing.Image)(resources.GetObject("exitPicture.Image")));
            this.exitPicture.Location = new System.Drawing.Point(799, 0);
            this.exitPicture.Margin = new System.Windows.Forms.Padding(2);
            this.exitPicture.Name = "exitPicture";
            this.exitPicture.Size = new System.Drawing.Size(41, 31);
            this.exitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPicture.TabIndex = 11;
            this.exitPicture.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_main.Controls.Add(this.DataGridView_categories);
            this.panel_main.Controls.Add(this.button_update);
            this.panel_main.Controls.Add(this.button_delete);
            this.panel_main.Controls.Add(this.button_add);
            this.panel_main.Controls.Add(this.textBox_description);
            this.panel_main.Controls.Add(this.label_description);
            this.panel_main.Controls.Add(this.textBox_name);
            this.panel_main.Controls.Add(this.label_name);
            this.panel_main.Controls.Add(this.textBox_id);
            this.panel_main.Controls.Add(this.label_id);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(120, 31);
            this.panel_main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(840, 509);
            this.panel_main.TabIndex = 3;
            // 
            // DataGridView_categories
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_categories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_categories.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView_categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_categories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_categories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_categories.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_categories.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_categories.EnableHeadersVisualStyles = false;
            this.DataGridView_categories.GridColor = System.Drawing.Color.DarkGray;
            this.DataGridView_categories.Location = new System.Drawing.Point(341, 38);
            this.DataGridView_categories.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView_categories.Name = "DataGridView_categories";
            this.DataGridView_categories.ReadOnly = true;
            this.DataGridView_categories.RowHeadersVisible = false;
            this.DataGridView_categories.RowHeadersWidth = 72;
            this.DataGridView_categories.RowTemplate.Height = 31;
            this.DataGridView_categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_categories.Size = new System.Drawing.Size(470, 442);
            this.DataGridView_categories.TabIndex = 16;
            this.DataGridView_categories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_categories.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_categories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_categories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_categories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_categories.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView_categories.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.DataGridView_categories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_categories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_categories.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_categories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_categories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_categories.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_categories.ThemeStyle.ReadOnly = true;
            this.DataGridView_categories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_categories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_categories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_categories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_categories.ThemeStyle.RowsStyle.Height = 31;
            this.DataGridView_categories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_categories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_categories.Click += new System.EventHandler(this.DataGridView_categories_Click);
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
            this.button_update.Location = new System.Drawing.Point(124, 171);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(98, 24);
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
            this.button_delete.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(226, 171);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(98, 24);
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
            this.button_add.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(22, 172);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(98, 24);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Añadir";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_description
            // 
            this.textBox_description.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_description.BorderColor = System.Drawing.Color.Gray;
            this.textBox_description.BorderRadius = 5;
            this.textBox_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_description.DefaultText = "";
            this.textBox_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_description.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_description.Location = new System.Drawing.Point(101, 127);
            this.textBox_description.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.PasswordChar = '\0';
            this.textBox_description.PlaceholderText = "";
            this.textBox_description.SelectedText = "";
            this.textBox_description.Size = new System.Drawing.Size(223, 22);
            this.textBox_description.TabIndex = 5;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_description.Location = new System.Drawing.Point(19, 132);
            this.label_description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(83, 15);
            this.label_description.TabIndex = 4;
            this.label_description.Text = "Descripción";
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
            this.textBox_name.Location = new System.Drawing.Point(101, 82);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.PasswordChar = '\0';
            this.textBox_name.PlaceholderText = "";
            this.textBox_name.SelectedText = "";
            this.textBox_name.Size = new System.Drawing.Size(223, 22);
            this.textBox_name.TabIndex = 3;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_name.Location = new System.Drawing.Point(19, 87);
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
            this.textBox_id.Location = new System.Drawing.Point(101, 38);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.PasswordChar = '\0';
            this.textBox_id.PlaceholderText = "";
            this.textBox_id.SelectedText = "";
            this.textBox_id.Size = new System.Drawing.Size(223, 22);
            this.textBox_id.TabIndex = 1;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_id.Location = new System.Drawing.Point(19, 42);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(22, 15);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.panel_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.panel_options.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPicture)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_categories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Panel panel_options;
        private Guna.UI2.WinForms.Guna2Button button_logout;
        private Guna.UI2.WinForms.Guna2Button button_selling;
        private Guna.UI2.WinForms.Guna2Button button_category;
        private Guna.UI2.WinForms.Guna2Button button_employee;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox exitPicture;
        private System.Windows.Forms.Panel panel_main;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_categories;
        private Guna.UI2.WinForms.Guna2Button button_update;
        private Guna.UI2.WinForms.Guna2Button button_delete;
        private Guna.UI2.WinForms.Guna2Button button_add;
        private Guna.UI2.WinForms.Guna2TextBox textBox_description;
        private System.Windows.Forms.Label label_description;
        private Guna.UI2.WinForms.Guna2TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private Guna.UI2.WinForms.Guna2TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
    }
}