namespace GentlemensCloset
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.dataGridView_orderList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_main = new System.Windows.Forms.Panel();
            this.textBox_IDbill = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_amount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_sellsList = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button_addId = new Guna.UI2.WinForms.Guna2Button();
            this.label_currency = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_date = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button_print = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_products = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridView_bills = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox_products = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_addOrder = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_quantity = new System.Windows.Forms.Label();
            this.textBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_head = new System.Windows.Forms.Label();
            this.exitPicture = new System.Windows.Forms.PictureBox();
            this.panel_head = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.panel_options = new System.Windows.Forms.Panel();
            this.button_logout = new Guna.UI2.WinForms.Guna2Button();
            this.button_productos = new Guna.UI2.WinForms.Guna2Button();
            this.button_categories = new Guna.UI2.WinForms.Guna2Button();
            this.button_employees = new Guna.UI2.WinForms.Guna2Button();
            this.panel_user = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orderList)).BeginInit();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPicture)).BeginInit();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.panel_options.SuspendLayout();
            this.panel_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_orderList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_orderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_orderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_orderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_orderList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_orderList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_orderList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_orderList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_orderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_orderList.ColumnHeadersHeight = 24;
            this.dataGridView_orderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.price,
            this.quantity,
            this.total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_orderList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_orderList.EnableHeadersVisualStyles = false;
            this.dataGridView_orderList.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_orderList.Location = new System.Drawing.Point(281, 49);
            this.dataGridView_orderList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_orderList.Name = "dataGridView_orderList";
            this.dataGridView_orderList.ReadOnly = true;
            this.dataGridView_orderList.RowHeadersVisible = false;
            this.dataGridView_orderList.RowHeadersWidth = 72;
            this.dataGridView_orderList.RowTemplate.Height = 31;
            this.dataGridView_orderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_orderList.Size = new System.Drawing.Size(548, 144);
            this.dataGridView_orderList.TabIndex = 16;
            this.dataGridView_orderList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_orderList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_orderList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_orderList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_orderList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_orderList.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_orderList.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_orderList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_orderList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_orderList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_orderList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_orderList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_orderList.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_orderList.ThemeStyle.ReadOnly = true;
            this.dataGridView_orderList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_orderList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_orderList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_orderList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_orderList.ThemeStyle.RowsStyle.Height = 31;
            this.dataGridView_orderList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_orderList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 9;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.MinimumWidth = 9;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Precio";
            this.price.MinimumWidth = 9;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Cantidad";
            this.quantity.MinimumWidth = 9;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 9;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_main.Controls.Add(this.textBox_IDbill);
            this.panel_main.Controls.Add(this.guna2HtmlLabel1);
            this.panel_main.Controls.Add(this.label_amount);
            this.panel_main.Controls.Add(this.label_sellsList);
            this.panel_main.Controls.Add(this.button_addId);
            this.panel_main.Controls.Add(this.label_currency);
            this.panel_main.Controls.Add(this.label_date);
            this.panel_main.Controls.Add(this.button_print);
            this.panel_main.Controls.Add(this.dataGridView_products);
            this.panel_main.Controls.Add(this.dataGridView_bills);
            this.panel_main.Controls.Add(this.dataGridView_orderList);
            this.panel_main.Controls.Add(this.button_refresh);
            this.panel_main.Controls.Add(this.comboBox_products);
            this.panel_main.Controls.Add(this.button_addOrder);
            this.panel_main.Controls.Add(this.textBox_quantity);
            this.panel_main.Controls.Add(this.label_quantity);
            this.panel_main.Controls.Add(this.textBox_price);
            this.panel_main.Controls.Add(this.label_price);
            this.panel_main.Controls.Add(this.textBox_name);
            this.panel_main.Controls.Add(this.label_id);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(120, 32);
            this.panel_main.Margin = new System.Windows.Forms.Padding(2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(840, 508);
            this.panel_main.TabIndex = 17;
            // 
            // textBox_IDbill
            // 
            this.textBox_IDbill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_IDbill.BorderColor = System.Drawing.Color.Gray;
            this.textBox_IDbill.BorderRadius = 5;
            this.textBox_IDbill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_IDbill.DefaultText = "";
            this.textBox_IDbill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_IDbill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_IDbill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_IDbill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_IDbill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_IDbill.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IDbill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_IDbill.Location = new System.Drawing.Point(645, 238);
            this.textBox_IDbill.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_IDbill.Name = "textBox_IDbill";
            this.textBox_IDbill.PasswordChar = '\0';
            this.textBox_IDbill.PlaceholderText = "";
            this.textBox_IDbill.SelectedText = "";
            this.textBox_IDbill.Size = new System.Drawing.Size(90, 22);
            this.textBox_IDbill.TabIndex = 30;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(564, 240);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(76, 18);
            this.guna2HtmlLabel1.TabIndex = 29;
            this.guna2HtmlLabel1.Text = "ID Cuenta";
            // 
            // label_amount
            // 
            this.label_amount.BackColor = System.Drawing.Color.Transparent;
            this.label_amount.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_amount.Location = new System.Drawing.Point(671, 198);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(101, 18);
            this.label_amount.TabIndex = 27;
            this.label_amount.Text = "Total a pagar:";
            // 
            // label_sellsList
            // 
            this.label_sellsList.BackColor = System.Drawing.Color.Transparent;
            this.label_sellsList.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sellsList.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_sellsList.Location = new System.Drawing.Point(282, 240);
            this.label_sellsList.Name = "label_sellsList";
            this.label_sellsList.Size = new System.Drawing.Size(118, 18);
            this.label_sellsList.TabIndex = 26;
            this.label_sellsList.Text = "Lista de pedidos";
            // 
            // button_addId
            // 
            this.button_addId.BorderRadius = 5;
            this.button_addId.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_addId.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_addId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_addId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_addId.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_addId.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addId.ForeColor = System.Drawing.Color.White;
            this.button_addId.Location = new System.Drawing.Point(739, 237);
            this.button_addId.Margin = new System.Windows.Forms.Padding(2);
            this.button_addId.Name = "button_addId";
            this.button_addId.Size = new System.Drawing.Size(90, 24);
            this.button_addId.TabIndex = 25;
            this.button_addId.Text = "Añadir";
            this.button_addId.Click += new System.EventHandler(this.button_addId_Click);
            // 
            // label_currency
            // 
            this.label_currency.BackColor = System.Drawing.Color.Transparent;
            this.label_currency.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currency.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_currency.Location = new System.Drawing.Point(773, 198);
            this.label_currency.Name = "label_currency";
            this.label_currency.Size = new System.Drawing.Size(13, 18);
            this.label_currency.TabIndex = 24;
            this.label_currency.Text = "    €";
            // 
            // label_date
            // 
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_date.Location = new System.Drawing.Point(746, 26);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(83, 18);
            this.label_date.TabIndex = 22;
            this.label_date.Text = "21/01/2022";
            // 
            // button_print
            // 
            this.button_print.BorderRadius = 5;
            this.button_print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_print.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_print.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(739, 461);
            this.button_print.Margin = new System.Windows.Forms.Padding(2);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(90, 24);
            this.button_print.TabIndex = 21;
            this.button_print.Text = "Imprimir";
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // dataGridView_products
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView_products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_products.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_products.ColumnHeadersHeight = 24;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_products.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_products.EnableHeadersVisualStyles = false;
            this.dataGridView_products.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_products.Location = new System.Drawing.Point(23, 271);
            this.dataGridView_products.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.ReadOnly = true;
            this.dataGridView_products.RowHeadersVisible = false;
            this.dataGridView_products.RowHeadersWidth = 72;
            this.dataGridView_products.RowTemplate.Height = 31;
            this.dataGridView_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_products.Size = new System.Drawing.Size(239, 180);
            this.dataGridView_products.TabIndex = 18;
            this.dataGridView_products.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_products.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_products.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_products.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_products.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_products.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_products.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_products.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_products.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_products.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_products.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_products.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_products.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_products.ThemeStyle.ReadOnly = true;
            this.dataGridView_products.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_products.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_products.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_products.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_products.ThemeStyle.RowsStyle.Height = 31;
            this.dataGridView_products.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_products.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_products.Click += new System.EventHandler(this.dataGridView_products_Click);
            // 
            // dataGridView_bills
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView_bills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_bills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_bills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bills.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_bills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_bills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_bills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_bills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_bills.ColumnHeadersHeight = 24;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_bills.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_bills.EnableHeadersVisualStyles = false;
            this.dataGridView_bills.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_bills.Location = new System.Drawing.Point(281, 271);
            this.dataGridView_bills.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_bills.Name = "dataGridView_bills";
            this.dataGridView_bills.ReadOnly = true;
            this.dataGridView_bills.RowHeadersVisible = false;
            this.dataGridView_bills.RowHeadersWidth = 72;
            this.dataGridView_bills.RowTemplate.Height = 31;
            this.dataGridView_bills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_bills.Size = new System.Drawing.Size(548, 180);
            this.dataGridView_bills.TabIndex = 17;
            this.dataGridView_bills.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_bills.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_bills.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_bills.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_bills.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_bills.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_bills.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_bills.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_bills.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_bills.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_bills.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_bills.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_bills.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_bills.ThemeStyle.ReadOnly = true;
            this.dataGridView_bills.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_bills.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_bills.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_bills.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_bills.ThemeStyle.RowsStyle.Height = 31;
            this.dataGridView_bills.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_bills.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.button_refresh.Location = new System.Drawing.Point(172, 237);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(90, 24);
            this.button_refresh.TabIndex = 15;
            this.button_refresh.Text = "Refrescar";
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_products
            // 
            this.comboBox_products.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_products.BorderColor = System.Drawing.Color.Gray;
            this.comboBox_products.BorderRadius = 5;
            this.comboBox_products.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_products.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_products.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_products.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_products.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_products.ItemHeight = 30;
            this.comboBox_products.Location = new System.Drawing.Point(23, 231);
            this.comboBox_products.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_products.Name = "comboBox_products";
            this.comboBox_products.Size = new System.Drawing.Size(144, 36);
            this.comboBox_products.TabIndex = 14;
            this.comboBox_products.SelectionChangeCommitted += new System.EventHandler(this.comboBox_products_SelectionChangeCommitted);
            // 
            // button_addOrder
            // 
            this.button_addOrder.BorderRadius = 5;
            this.button_addOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_addOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_addOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_addOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_addOrder.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_addOrder.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addOrder.ForeColor = System.Drawing.Color.White;
            this.button_addOrder.Location = new System.Drawing.Point(172, 169);
            this.button_addOrder.Margin = new System.Windows.Forms.Padding(2);
            this.button_addOrder.Name = "button_addOrder";
            this.button_addOrder.Size = new System.Drawing.Size(90, 24);
            this.button_addOrder.TabIndex = 10;
            this.button_addOrder.Text = "Añadir";
            this.button_addOrder.Click += new System.EventHandler(this.button_addOrder_Click);
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
            this.textBox_price.Location = new System.Drawing.Point(102, 89);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.PasswordChar = '\0';
            this.textBox_price.PlaceholderText = "";
            this.textBox_price.SelectedText = "";
            this.textBox_price.Size = new System.Drawing.Size(160, 22);
            this.textBox_price.TabIndex = 3;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_price.Location = new System.Drawing.Point(20, 93);
            this.label_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(47, 15);
            this.label_price.TabIndex = 2;
            this.label_price.Text = "Precio";
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
            this.textBox_name.Location = new System.Drawing.Point(102, 49);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.PasswordChar = '\0';
            this.textBox_name.PlaceholderText = "";
            this.textBox_name.SelectedText = "";
            this.textBox_name.Size = new System.Drawing.Size(160, 22);
            this.textBox_name.TabIndex = 1;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_id.Location = new System.Drawing.Point(20, 53);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(59, 15);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Nombre";
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Georgia", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_head.Location = new System.Drawing.Point(306, 5);
            this.label_head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(221, 23);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "GESTIONAR VENTAS";
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
            this.panel_head.TabIndex = 16;
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.Image = global::GentlemensCloset.Properties.Resources.admin_settings_male_100px;
            this.pictureBox_user.Location = new System.Drawing.Point(34, 20);
            this.pictureBox_user.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(51, 51);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_user.TabIndex = 0;
            this.pictureBox_user.TabStop = false;
            // 
            // panel_options
            // 
            this.panel_options.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_options.Controls.Add(this.button_logout);
            this.panel_options.Controls.Add(this.button_productos);
            this.panel_options.Controls.Add(this.button_categories);
            this.panel_options.Controls.Add(this.button_employees);
            this.panel_options.Controls.Add(this.panel_user);
            this.panel_options.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_options.Location = new System.Drawing.Point(0, 0);
            this.panel_options.Margin = new System.Windows.Forms.Padding(2);
            this.panel_options.Name = "panel_options";
            this.panel_options.Size = new System.Drawing.Size(120, 540);
            this.panel_options.TabIndex = 15;
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
            // button_productos
            // 
            this.button_productos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_productos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_productos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_productos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_productos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_productos.FillColor = System.Drawing.Color.RoyalBlue;
            this.button_productos.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_productos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_productos.Location = new System.Drawing.Point(0, 186);
            this.button_productos.Margin = new System.Windows.Forms.Padding(2);
            this.button_productos.Name = "button_productos";
            this.button_productos.Size = new System.Drawing.Size(120, 43);
            this.button_productos.TabIndex = 3;
            this.button_productos.Text = "Productos";
            this.button_productos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_productos.Click += new System.EventHandler(this.button_productos_Click);
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
            this.button_categories.Click += new System.EventHandler(this.button_categories_Click);
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
            this.label_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.RoyalBlue;
            this.label_username.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_username.Location = new System.Drawing.Point(20, 73);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(76, 15);
            this.label_username.TabIndex = 16;
            this.label_username.Text = "GREGORY";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.panel_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orderList)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPicture)).EndInit();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.panel_options.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_orderList;
        private System.Windows.Forms.Panel panel_main;
        private Guna.UI2.WinForms.Guna2Button button_refresh;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_products;
        private Guna.UI2.WinForms.Guna2Button button_addOrder;
        private Guna.UI2.WinForms.Guna2TextBox textBox_quantity;
        private System.Windows.Forms.Label label_quantity;
        private Guna.UI2.WinForms.Guna2TextBox textBox_price;
        private System.Windows.Forms.Label label_price;
        private Guna.UI2.WinForms.Guna2TextBox textBox_name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox exitPicture;
        private System.Windows.Forms.Panel panel_head;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Panel panel_options;
        private Guna.UI2.WinForms.Guna2Button button_logout;
        private Guna.UI2.WinForms.Guna2Button button_productos;
        private Guna.UI2.WinForms.Guna2Button button_categories;
        private Guna.UI2.WinForms.Guna2Button button_employees;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Label label_username;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_sellsList;
        private Guna.UI2.WinForms.Guna2Button button_addId;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_currency;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_date;
        private Guna.UI2.WinForms.Guna2Button button_print;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_products;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_bills;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_amount;
        private Guna.UI2.WinForms.Guna2TextBox textBox_IDbill;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}