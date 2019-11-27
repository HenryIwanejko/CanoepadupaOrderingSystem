namespace CanoepadupaOrderingSystem.Forms
{
    partial class OrderBasketForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbProductNameValue = new System.Windows.Forms.ComboBox();
            this.lblWholesalePrice = new System.Windows.Forms.Label();
            this.lblPoductName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRRPValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWholesalePriceValue = new System.Windows.Forms.Label();
            this.lblRRP = new System.Windows.Forms.Label();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvOrderBasket = new System.Windows.Forms.ListView();
            this.productNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wholesalePriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rrpHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumberOfProducts = new System.Windows.Forms.Label();
            this.lblNumberOfItems = new System.Windows.Forms.Label();
            this.lblNumberOfItemsValue = new System.Windows.Forms.Label();
            this.lblNumberOfProductsValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalWithDiscount = new System.Windows.Forms.Label();
            this.lblTotalWithDiscountValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearBasket = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 452);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(649, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 70);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblWholesalePrice, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPoductName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRRP, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDescriptionValue, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDescription, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblQuantity, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(633, 84);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.nudQuantity, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(539, 28);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(91, 53);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.Location = new System.Drawing.Point(3, 3);
            this.nudQuantity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(85, 20);
            this.nudQuantity.TabIndex = 0;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.cmbProductNameValue, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(152, 53);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // cmbProductNameValue
            // 
            this.cmbProductNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductNameValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductNameValue.FormattingEnabled = true;
            this.cmbProductNameValue.Location = new System.Drawing.Point(3, 3);
            this.cmbProductNameValue.Name = "cmbProductNameValue";
            this.cmbProductNameValue.Size = new System.Drawing.Size(146, 21);
            this.cmbProductNameValue.TabIndex = 0;
            this.cmbProductNameValue.SelectedIndexChanged += new System.EventHandler(this.cmbProductNameValue_SelectedIndexChanged);
            // 
            // lblWholesalePrice
            // 
            this.lblWholesalePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWholesalePrice.AutoSize = true;
            this.lblWholesalePrice.Location = new System.Drawing.Point(161, 0);
            this.lblWholesalePrice.Name = "lblWholesalePrice";
            this.lblWholesalePrice.Size = new System.Drawing.Size(104, 25);
            this.lblWholesalePrice.TabIndex = 2;
            this.lblWholesalePrice.Text = "Wholesale Price";
            this.lblWholesalePrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblPoductName
            // 
            this.lblPoductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoductName.AutoSize = true;
            this.lblPoductName.Location = new System.Drawing.Point(3, 0);
            this.lblPoductName.Name = "lblPoductName";
            this.lblPoductName.Size = new System.Drawing.Size(152, 25);
            this.lblPoductName.TabIndex = 0;
            this.lblPoductName.Text = "Product Name";
            this.lblPoductName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblRRPValue, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(271, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(104, 53);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lblRRPValue
            // 
            this.lblRRPValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRRPValue.AutoSize = true;
            this.lblRRPValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRRPValue.Location = new System.Drawing.Point(3, 3);
            this.lblRRPValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblRRPValue.Name = "lblRRPValue";
            this.lblRRPValue.Size = new System.Drawing.Size(98, 18);
            this.lblRRPValue.TabIndex = 4;
            this.lblRRPValue.Text = "£";
            this.lblRRPValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lblWholesalePriceValue, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(161, 28);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(104, 53);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lblWholesalePriceValue
            // 
            this.lblWholesalePriceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWholesalePriceValue.AutoSize = true;
            this.lblWholesalePriceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWholesalePriceValue.Location = new System.Drawing.Point(3, 3);
            this.lblWholesalePriceValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblWholesalePriceValue.Name = "lblWholesalePriceValue";
            this.lblWholesalePriceValue.Size = new System.Drawing.Size(98, 18);
            this.lblWholesalePriceValue.TabIndex = 4;
            this.lblWholesalePriceValue.Text = "£";
            this.lblWholesalePriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRRP
            // 
            this.lblRRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRRP.AutoSize = true;
            this.lblRRP.Location = new System.Drawing.Point(271, 0);
            this.lblRRP.Name = "lblRRP";
            this.lblRRP.Size = new System.Drawing.Size(104, 25);
            this.lblRRP.TabIndex = 6;
            this.lblRRP.Text = "RRP";
            this.lblRRP.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescriptionValue.Location = new System.Drawing.Point(381, 28);
            this.lblDescriptionValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(152, 56);
            this.lblDescriptionValue.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(381, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(152, 25);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(539, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(91, 25);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.AutoScroll = true;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(633, 356);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lsvOrderBasket);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Basket";
            // 
            // lsvOrderBasket
            // 
            this.lsvOrderBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvOrderBasket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productNumberHeader,
            this.productNameHeader,
            this.quantityHeader,
            this.wholesalePriceHeader,
            this.rrpHeader,
            this.totalHeader,
            this.descriptionHeader});
            this.lsvOrderBasket.FullRowSelect = true;
            this.lsvOrderBasket.Location = new System.Drawing.Point(3, 17);
            this.lsvOrderBasket.Name = "lsvOrderBasket";
            this.lsvOrderBasket.Size = new System.Drawing.Size(621, 273);
            this.lsvOrderBasket.TabIndex = 0;
            this.lsvOrderBasket.UseCompatibleStateImageBehavior = false;
            this.lsvOrderBasket.View = System.Windows.Forms.View.Details;
            this.lsvOrderBasket.SelectedIndexChanged += new System.EventHandler(this.lsvOrderBasket_SelectedIndexChanged);
            // 
            // productNumberHeader
            // 
            this.productNumberHeader.Text = "Product Number";
            this.productNumberHeader.Width = 89;
            // 
            // productNameHeader
            // 
            this.productNameHeader.Text = "Product Name";
            this.productNameHeader.Width = 93;
            // 
            // quantityHeader
            // 
            this.quantityHeader.Text = "Quantity";
            this.quantityHeader.Width = 54;
            // 
            // wholesalePriceHeader
            // 
            this.wholesalePriceHeader.Text = "Wholesale Price";
            this.wholesalePriceHeader.Width = 79;
            // 
            // rrpHeader
            // 
            this.rrpHeader.Text = "RRP";
            // 
            // totalHeader
            // 
            this.totalHeader.Text = "Total";
            this.totalHeader.Width = 85;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.Width = 159;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.tableLayoutPanel11);
            this.groupBox3.Location = new System.Drawing.Point(3, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 48);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Basket Details";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel11.AutoScroll = true;
            this.tableLayoutPanel11.ColumnCount = 8;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.Controls.Add(this.lblNumberOfProducts, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.lblNumberOfItems, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.lblNumberOfItemsValue, 3, 0);
            this.tableLayoutPanel11.Controls.Add(this.lblNumberOfProductsValue, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.lblTotal, 4, 0);
            this.tableLayoutPanel11.Controls.Add(this.lblTotalValue, 5, 0);
            this.tableLayoutPanel11.Controls.Add(this.lblTotalWithDiscount, 6, 0);
            this.tableLayoutPanel11.Controls.Add(this.lblTotalWithDiscountValue, 7, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(617, 21);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // lblNumberOfProducts
            // 
            this.lblNumberOfProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfProducts.AutoSize = true;
            this.lblNumberOfProducts.Location = new System.Drawing.Point(3, 0);
            this.lblNumberOfProducts.Name = "lblNumberOfProducts";
            this.lblNumberOfProducts.Size = new System.Drawing.Size(86, 21);
            this.lblNumberOfProducts.TabIndex = 0;
            this.lblNumberOfProducts.Text = "No. Products:";
            this.lblNumberOfProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberOfItems
            // 
            this.lblNumberOfItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfItems.AutoSize = true;
            this.lblNumberOfItems.Location = new System.Drawing.Point(156, 0);
            this.lblNumberOfItems.Name = "lblNumberOfItems";
            this.lblNumberOfItems.Size = new System.Drawing.Size(55, 21);
            this.lblNumberOfItems.TabIndex = 2;
            this.lblNumberOfItems.Text = "No. Items:";
            this.lblNumberOfItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberOfItemsValue
            // 
            this.lblNumberOfItemsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfItemsValue.AutoSize = true;
            this.lblNumberOfItemsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberOfItemsValue.Location = new System.Drawing.Point(217, 0);
            this.lblNumberOfItemsValue.Name = "lblNumberOfItemsValue";
            this.lblNumberOfItemsValue.Size = new System.Drawing.Size(55, 21);
            this.lblNumberOfItemsValue.TabIndex = 3;
            this.lblNumberOfItemsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberOfProductsValue
            // 
            this.lblNumberOfProductsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfProductsValue.AutoSize = true;
            this.lblNumberOfProductsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberOfProductsValue.Location = new System.Drawing.Point(95, 0);
            this.lblNumberOfProductsValue.Name = "lblNumberOfProductsValue";
            this.lblNumberOfProductsValue.Size = new System.Drawing.Size(55, 21);
            this.lblNumberOfProductsValue.TabIndex = 1;
            this.lblNumberOfProductsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(278, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 21);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalValue.Location = new System.Drawing.Point(355, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(71, 21);
            this.lblTotalValue.TabIndex = 5;
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalWithDiscount
            // 
            this.lblTotalWithDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalWithDiscount.AutoSize = true;
            this.lblTotalWithDiscount.Location = new System.Drawing.Point(432, 0);
            this.lblTotalWithDiscount.Name = "lblTotalWithDiscount";
            this.lblTotalWithDiscount.Size = new System.Drawing.Size(101, 21);
            this.lblTotalWithDiscount.TabIndex = 6;
            this.lblTotalWithDiscount.Text = "Total w/ Discount:";
            this.lblTotalWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalWithDiscountValue
            // 
            this.lblTotalWithDiscountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalWithDiscountValue.AutoSize = true;
            this.lblTotalWithDiscountValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalWithDiscountValue.Location = new System.Drawing.Point(539, 0);
            this.lblTotalWithDiscountValue.Name = "lblTotalWithDiscountValue";
            this.lblTotalWithDiscountValue.Size = new System.Drawing.Size(75, 21);
            this.lblTotalWithDiscountValue.TabIndex = 7;
            this.lblTotalWithDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.AutoSize = true;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(642, 93);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(154, 356);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel9);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 243);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basket";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.AutoSize = true;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.btnClearBasket, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.btnRemoveItem, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnCheckOut, 0, 3);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(138, 218);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // btnClearBasket
            // 
            this.btnClearBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearBasket.AutoSize = true;
            this.btnClearBasket.Location = new System.Drawing.Point(3, 46);
            this.btnClearBasket.Name = "btnClearBasket";
            this.btnClearBasket.Size = new System.Drawing.Size(132, 37);
            this.btnClearBasket.TabIndex = 1;
            this.btnClearBasket.Text = "Clear Basket";
            this.btnClearBasket.UseVisualStyleBackColor = true;
            this.btnClearBasket.Click += new System.EventHandler(this.btnClearBasket_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.AutoSize = true;
            this.btnRemoveItem.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(132, 37);
            this.btnRemoveItem.TabIndex = 0;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.AutoSize = true;
            this.btnCheckOut.Location = new System.Drawing.Point(3, 176);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(132, 39);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel10.AutoScroll = true;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.btnExit, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 252);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(148, 101);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(3, 53);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 45);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 44);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // OrderBasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrderBasketForm";
            this.Text = "OrderBasketForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblWholesalePrice;
        private System.Windows.Forms.Label lblPoductName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblRRPValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblWholesalePriceValue;
        private System.Windows.Forms.Label lblRRP;
        private System.Windows.Forms.Label lblDescriptionValue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbProductNameValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvOrderBasket;
        private System.Windows.Forms.ColumnHeader productNumberHeader;
        private System.Windows.Forms.ColumnHeader productNameHeader;
        private System.Windows.Forms.ColumnHeader quantityHeader;
        private System.Windows.Forms.ColumnHeader rrpHeader;
        private System.Windows.Forms.ColumnHeader totalHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.ColumnHeader wholesalePriceHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearBasket;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label lblNumberOfProducts;
        private System.Windows.Forms.Label lblNumberOfItems;
        private System.Windows.Forms.Label lblNumberOfProductsValue;
        private System.Windows.Forms.Label lblNumberOfItemsValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalWithDiscount;
        private System.Windows.Forms.Label lblTotalWithDiscountValue;
    }
}