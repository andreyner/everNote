using System;

namespace Evernote.WinForms
{
    partial class MainWindows
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuNote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowallNote = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNoteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btndellNote = new System.Windows.Forms.ToolStripMenuItem();
            this.btnaddintoCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShare = new System.Windows.Forms.ToolStripMenuItem();
            this.btndellfromcategory = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDataGridNotes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowAllNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnaddNoteContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnaddnewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btndellCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.brnRenameCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnshowallcatergory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGNotes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGcategories = new System.Windows.Forms.DataGridView();
            this.contextMenuDatagridCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnshowallcategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBnote = new System.Windows.Forms.CheckBox();
            this.checkBcategory = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBfind = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnadd = new System.Windows.Forms.ToolStripSplitButton();
            this.btnaddNote = new System.Windows.Forms.ToolStripMenuItem();
            this.btnaddcategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnshareNote = new System.Windows.Forms.ToolStripButton();
            this.btnUserdataShow = new System.Windows.Forms.ToolStripButton();
            this.btnNoteMe = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.ImageCategory = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImageNote = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnfind = new System.Windows.Forms.Button();
            this.btndropselectedcategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnclearselection = new System.Windows.Forms.ToolStripMenuItem();
            this.btnnewcategory = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuNote.SuspendLayout();
            this.contextMenuDataGridNotes.SuspendLayout();
            this.contextMenuCategories.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGNotes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGcategories)).BeginInit();
            this.contextMenuDatagridCategory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuNote
            // 
            this.contextMenuNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowallNote,
            this.btnAddNoteMenu,
            this.btndellNote,
            this.btnaddintoCategory,
            this.btnShare,
            this.btndellfromcategory});
            this.contextMenuNote.Name = "contextMenuNote";
            this.contextMenuNote.Size = new System.Drawing.Size(198, 136);
            // 
            // btnShowallNote
            // 
            this.btnShowallNote.Name = "btnShowallNote";
            this.btnShowallNote.Size = new System.Drawing.Size(197, 22);
            this.btnShowallNote.Text = "Показать все заметки";
            this.btnShowallNote.Click += new System.EventHandler(this.btnShowallNote_Click);
            // 
            // btnAddNoteMenu
            // 
            this.btnAddNoteMenu.Name = "btnAddNoteMenu";
            this.btnAddNoteMenu.Size = new System.Drawing.Size(197, 22);
            this.btnAddNoteMenu.Text = "Добавить";
            this.btnAddNoteMenu.Click += new System.EventHandler(this.btnAddNoteMenu_Click);
            // 
            // btndellNote
            // 
            this.btndellNote.Name = "btndellNote";
            this.btndellNote.Size = new System.Drawing.Size(197, 22);
            this.btndellNote.Text = "Удалить";
            this.btndellNote.Click += new System.EventHandler(this.btndellNote_Click);
            // 
            // btnaddintoCategory
            // 
            this.btnaddintoCategory.Name = "btnaddintoCategory";
            this.btnaddintoCategory.Size = new System.Drawing.Size(197, 22);
            this.btnaddintoCategory.Text = "Добавить в категорию";
            this.btnaddintoCategory.Click += new System.EventHandler(this.btnaddintoCategory_Click);
            // 
            // btnShare
            // 
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(197, 22);
            this.btnShare.Text = "Поделиться";
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // btndellfromcategory
            // 
            this.btndellfromcategory.Name = "btndellfromcategory";
            this.btndellfromcategory.Size = new System.Drawing.Size(197, 22);
            this.btndellfromcategory.Text = "Убрать из категории";
            this.btndellfromcategory.Click += new System.EventHandler(this.btndellfromcategory_Click);
            // 
            // contextMenuDataGridNotes
            // 
            this.contextMenuDataGridNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowAllNotes,
            this.btnaddNoteContextMenu});
            this.contextMenuDataGridNotes.Name = "btnShowAllNotes";
            this.contextMenuDataGridNotes.Size = new System.Drawing.Size(193, 48);
            // 
            // btnShowAllNotes
            // 
            this.btnShowAllNotes.Name = "btnShowAllNotes";
            this.btnShowAllNotes.Size = new System.Drawing.Size(192, 22);
            this.btnShowAllNotes.Text = "Показать все заметки";
            this.btnShowAllNotes.Click += new System.EventHandler(this.btnShowAllNotes_Click);
            // 
            // btnaddNoteContextMenu
            // 
            this.btnaddNoteContextMenu.Name = "btnaddNoteContextMenu";
            this.btnaddNoteContextMenu.Size = new System.Drawing.Size(192, 22);
            this.btnaddNoteContextMenu.Text = "Добавить";
            this.btnaddNoteContextMenu.Click += new System.EventHandler(this.btnaddNoteContextMenu_Click);
            // 
            // contextMenuCategories
            // 
            this.contextMenuCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnaddnewCategory,
            this.btndellCategory,
            this.brnRenameCategory,
            this.btnshowallcatergory,
            this.btndropselectedcategory});
            this.contextMenuCategories.Name = "contextMenuCategories";
            this.contextMenuCategories.Size = new System.Drawing.Size(189, 114);
            // 
            // btnaddnewCategory
            // 
            this.btnaddnewCategory.Name = "btnaddnewCategory";
            this.btnaddnewCategory.Size = new System.Drawing.Size(188, 22);
            this.btnaddnewCategory.Text = "Добавить категорию";
            this.btnaddnewCategory.Click += new System.EventHandler(this.btnaddnewCategory_Click);
            // 
            // btndellCategory
            // 
            this.btndellCategory.Name = "btndellCategory";
            this.btndellCategory.Size = new System.Drawing.Size(188, 22);
            this.btndellCategory.Text = "Удалить";
            this.btndellCategory.Click += new System.EventHandler(this.btndellCategory_Click);
            // 
            // brnRenameCategory
            // 
            this.brnRenameCategory.Name = "brnRenameCategory";
            this.brnRenameCategory.Size = new System.Drawing.Size(188, 22);
            this.brnRenameCategory.Text = "Редактировать";
            this.brnRenameCategory.Click += new System.EventHandler(this.brnRenameCategory_Click);
            // 
            // btnshowallcatergory
            // 
            this.btnshowallcatergory.Name = "btnshowallcatergory";
            this.btnshowallcatergory.Size = new System.Drawing.Size(188, 22);
            this.btnshowallcatergory.Text = "Показать все";
            this.btnshowallcatergory.Click += new System.EventHandler(this.btnshowallcatergory_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(57, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnadd,
            this.btnshareNote,
            this.btnUserdataShow,
            this.btnNoteMe,
            this.btnExit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.tableLayoutPanel1.SetRowSpan(this.toolStrip1, 2);
            this.toolStrip1.Size = new System.Drawing.Size(105, 459);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGNotes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(351, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 415);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заметки";
            // 
            // dataGNotes
            // 
            this.dataGNotes.AllowUserToAddRows = false;
            this.dataGNotes.AllowUserToDeleteRows = false;
            this.dataGNotes.AllowUserToResizeColumns = false;
            this.dataGNotes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGNotes.AutoGenerateColumns = false;
            this.dataGNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGNotes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageNote,
            this.idDataGridViewTextBoxColumn1,
            this.headerDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.createdDataGridViewTextBoxColumn,
            this.changedDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGNotes.ContextMenuStrip = this.contextMenuDataGridNotes;
            this.dataGNotes.DataSource = this.noteBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGNotes.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGNotes.Location = new System.Drawing.Point(3, 18);
            this.dataGNotes.MultiSelect = false;
            this.dataGNotes.Name = "dataGNotes";
            this.dataGNotes.ReadOnly = true;
            this.dataGNotes.RowHeadersVisible = false;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGNotes.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGNotes.Size = new System.Drawing.Size(696, 394);
            this.dataGNotes.TabIndex = 0;
            this.dataGNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGNotes_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGcategories);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(108, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Категории";
            // 
            // dataGcategories
            // 
            this.dataGcategories.AllowUserToAddRows = false;
            this.dataGcategories.AllowUserToDeleteRows = false;
            this.dataGcategories.AllowUserToResizeColumns = false;
            this.dataGcategories.AllowUserToResizeRows = false;
            this.dataGcategories.AutoGenerateColumns = false;
            this.dataGcategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGcategories.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGcategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGcategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGcategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageCategory,
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGcategories.ContextMenuStrip = this.contextMenuDatagridCategory;
            this.dataGcategories.DataSource = this.categoryBindingSource;
            this.dataGcategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGcategories.Location = new System.Drawing.Point(3, 18);
            this.dataGcategories.MultiSelect = false;
            this.dataGcategories.Name = "dataGcategories";
            this.dataGcategories.ReadOnly = true;
            this.dataGcategories.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGcategories.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGcategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGcategories.Size = new System.Drawing.Size(231, 394);
            this.dataGcategories.TabIndex = 0;
            this.dataGcategories.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGcategories_CellMouseClick);
            this.dataGcategories.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGcategories_CellMouseDoubleClick);
            this.dataGcategories.SelectionChanged += new System.EventHandler(this.dataGcategories_SelectionChanged);
            // 
            // contextMenuDatagridCategory
            // 
            this.contextMenuDatagridCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnshowallcategory,
            this.btnclearselection,
            this.btnnewcategory});
            this.contextMenuDatagridCategory.Name = "contextMenuDatagridCategory";
            this.contextMenuDatagridCategory.Size = new System.Drawing.Size(189, 92);
            // 
            // btnshowallcategory
            // 
            this.btnshowallcategory.Name = "btnshowallcategory";
            this.btnshowallcategory.Size = new System.Drawing.Size(188, 22);
            this.btnshowallcategory.Text = "Показать все";
            this.btnshowallcategory.Click += new System.EventHandler(this.btnshowallcategory_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.10606F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.95076F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.496732F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.50327F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 459);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.151048F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.32525F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.31753F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.15493F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Controls.Add(this.checkBnote, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBcategory, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBfind, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnfind, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(108, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(945, 32);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // checkBnote
            // 
            this.checkBnote.AutoSize = true;
            this.checkBnote.Checked = true;
            this.checkBnote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBnote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBnote.Location = new System.Drawing.Point(85, 3);
            this.checkBnote.Name = "checkBnote";
            this.checkBnote.Size = new System.Drawing.Size(132, 26);
            this.checkBnote.TabIndex = 6;
            this.checkBnote.Text = "По заметкам";
            this.checkBnote.UseVisualStyleBackColor = true;
            // 
            // checkBcategory
            // 
            this.checkBcategory.AutoSize = true;
            this.checkBcategory.Checked = true;
            this.checkBcategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBcategory.Location = new System.Drawing.Point(223, 3);
            this.checkBcategory.Name = "checkBcategory";
            this.checkBcategory.Size = new System.Drawing.Size(141, 26);
            this.checkBcategory.TabIndex = 5;
            this.checkBcategory.Text = "По категориям";
            this.checkBcategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBfind
            // 
            this.txtBfind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBfind.Location = new System.Drawing.Point(370, 3);
            this.txtBfind.Multiline = true;
            this.txtBfind.Name = "txtBfind";
            this.txtBfind.Size = new System.Drawing.Size(528, 26);
            this.txtBfind.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.ContextMenuStrip = this.contextMenuCategories;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle13.NullValue")));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewImageColumn1.FillWeight = 45F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Evernote.WinForms.Properties.Resources.note_icon;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn2.ContextMenuStrip = this.contextMenuNote;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle14.NullValue")));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewImageColumn2.FillWeight = 45F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Evernote.WinForms.Properties.Resources.category;
            this.dataGridViewImageColumn2.MinimumWidth = 30;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = false;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnadd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnaddNote,
            this.btnaddcategory});
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnadd.Image = global::Evernote.WinForms.Properties.Resources.add1;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(57, 50);
            this.btnadd.ToolTipText = "Добавить";
            // 
            // btnaddNote
            // 
            this.btnaddNote.Name = "btnaddNote";
            this.btnaddNote.Size = new System.Drawing.Size(158, 26);
            this.btnaddNote.Text = "Заметку";
            this.btnaddNote.Click += new System.EventHandler(this.btnaddNote_Click);
            // 
            // btnaddcategory
            // 
            this.btnaddcategory.Name = "btnaddcategory";
            this.btnaddcategory.Size = new System.Drawing.Size(158, 26);
            this.btnaddcategory.Text = "Категорию";
            this.btnaddcategory.Click += new System.EventHandler(this.btnaddcategory_Click);
            // 
            // btnshareNote
            // 
            this.btnshareNote.AutoSize = false;
            this.btnshareNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshareNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnshareNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnshareNote.Image = global::Evernote.WinForms.Properties.Resources.share;
            this.btnshareNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnshareNote.Name = "btnshareNote";
            this.btnshareNote.Size = new System.Drawing.Size(57, 50);
            this.btnshareNote.ToolTipText = "Поделиться";
            this.btnshareNote.Click += new System.EventHandler(this.btnshareNote_Click);
            // 
            // btnUserdataShow
            // 
            this.btnUserdataShow.AutoSize = false;
            this.btnUserdataShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserdataShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUserdataShow.Image = global::Evernote.WinForms.Properties.Resources.user;
            this.btnUserdataShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUserdataShow.Name = "btnUserdataShow";
            this.btnUserdataShow.Size = new System.Drawing.Size(57, 50);
            this.btnUserdataShow.Text = "toolStripButton1";
            this.btnUserdataShow.ToolTipText = "Мои данные";
            this.btnUserdataShow.Click += new System.EventHandler(this.btnUserdataShow_Click);
            // 
            // btnNoteMe
            // 
            this.btnNoteMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNoteMe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNoteMe.Image = global::Evernote.WinForms.Properties.Resources.reminder;
            this.btnNoteMe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNoteMe.Name = "btnNoteMe";
            this.btnNoteMe.Size = new System.Drawing.Size(103, 54);
            this.btnNoteMe.Text = "Заметки мне";
            this.btnNoteMe.Click += new System.EventHandler(this.btnNoteMe_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::Evernote.WinForms.Properties.Resources.Exit;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 54);
            this.btnExit.Text = "Выход";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ImageCategory
            // 
            this.ImageCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ImageCategory.ContextMenuStrip = this.contextMenuCategories;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.ImageCategory.HeaderText = "";
            this.ImageCategory.Image = global::Evernote.WinForms.Properties.Resources.category_tpc;
            this.ImageCategory.Name = "ImageCategory";
            this.ImageCategory.ReadOnly = true;
            this.ImageCategory.Width = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.ContextMenuStrip = this.contextMenuCategories;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Evernote.Model.Category);
            // 
            // ImageNote
            // 
            this.ImageNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ImageNote.ContextMenuStrip = this.contextMenuNote;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageNote.DefaultCellStyle = dataGridViewCellStyle7;
            this.ImageNote.FillWeight = 45F;
            this.ImageNote.HeaderText = "";
            this.ImageNote.Image = global::Evernote.WinForms.Properties.Resources.note_icon_dhv_FDK;
            this.ImageNote.MinimumWidth = 30;
            this.ImageNote.Name = "ImageNote";
            this.ImageNote.ReadOnly = true;
            this.ImageNote.Width = 30;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // headerDataGridViewTextBoxColumn
            // 
            this.headerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerDataGridViewTextBoxColumn.ContextMenuStrip = this.contextMenuNote;
            this.headerDataGridViewTextBoxColumn.DataPropertyName = "header";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.headerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.headerDataGridViewTextBoxColumn.HeaderText = "Название";
            this.headerDataGridViewTextBoxColumn.Name = "headerDataGridViewTextBoxColumn";
            this.headerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.ContextMenuStrip = this.contextMenuNote;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "text";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.textDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.textDataGridViewTextBoxColumn.HeaderText = "Содержимое";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Owner";
            this.dataGridViewTextBoxColumn2.HeaderText = "Owner";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn.Visible = false;
            // 
            // changedDataGridViewTextBoxColumn
            // 
            this.changedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changedDataGridViewTextBoxColumn.ContextMenuStrip = this.contextMenuNote;
            this.changedDataGridViewTextBoxColumn.DataPropertyName = "Changed";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.changedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.changedDataGridViewTextBoxColumn.HeaderText = "Дата изменения";
            this.changedDataGridViewTextBoxColumn.Name = "changedDataGridViewTextBoxColumn";
            this.changedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Categories";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categories";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Shared";
            this.dataGridViewTextBoxColumn4.HeaderText = "Shared";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(Evernote.Note);
            // 
            // btnfind
            // 
            this.btnfind.BackgroundImage = global::Evernote.WinForms.Properties.Resources.find;
            this.btnfind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnfind.Location = new System.Drawing.Point(904, 3);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(38, 26);
            this.btnfind.TabIndex = 2;
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btndropselectedcategory
            // 
            this.btndropselectedcategory.Name = "btndropselectedcategory";
            this.btndropselectedcategory.Size = new System.Drawing.Size(188, 22);
            this.btndropselectedcategory.Text = "Снять выделение";
            this.btndropselectedcategory.Click += new System.EventHandler(this.btndropselectedcategory_Click);
            // 
            // btnclearselection
            // 
            this.btnclearselection.Name = "btnclearselection";
            this.btnclearselection.Size = new System.Drawing.Size(188, 22);
            this.btnclearselection.Text = "Снять выделение";
            this.btnclearselection.Click += new System.EventHandler(this.btnclearselection_Click);
            // 
            // btnnewcategory
            // 
            this.btnnewcategory.Name = "btnnewcategory";
            this.btnnewcategory.Size = new System.Drawing.Size(188, 22);
            this.btnnewcategory.Text = "Добавить категорию";
            this.btnnewcategory.Click += new System.EventHandler(this.btnnewcategory_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1056, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindows";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainWindows_Load);
            this.contextMenuNote.ResumeLayout(false);
            this.contextMenuDataGridNotes.ResumeLayout(false);
            this.contextMenuCategories.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGNotes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGcategories)).EndInit();
            this.contextMenuDatagridCategory.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuNote;
        private System.Windows.Forms.ToolStripMenuItem btnShowallNote;
        private System.Windows.Forms.ToolStripMenuItem btnAddNoteMenu;
        private System.Windows.Forms.ToolStripMenuItem btndellNote;
        private System.Windows.Forms.ToolStripMenuItem btnaddintoCategory;
        private System.Windows.Forms.ToolStripMenuItem btnShare;
        private System.Windows.Forms.ContextMenuStrip contextMenuDataGridNotes;
        private System.Windows.Forms.ToolStripMenuItem btnShowAllNotes;
        private System.Windows.Forms.ContextMenuStrip contextMenuCategories;
        private System.Windows.Forms.ToolStripMenuItem btnaddnewCategory;
        private System.Windows.Forms.ToolStripMenuItem btndellCategory;
        private System.Windows.Forms.ToolStripMenuItem brnRenameCategory;
        private System.Windows.Forms.ToolStripMenuItem btnaddNoteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btndellfromcategory;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn header;
        private System.Windows.Forms.DataGridViewTextBoxColumn contetnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn created;
        private System.Windows.Forms.DataGridViewTextBoxColumn changed;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnadd;
        private System.Windows.Forms.ToolStripMenuItem btnaddNote;
        private System.Windows.Forms.ToolStripMenuItem btnaddcategory;
        private System.Windows.Forms.ToolStripButton btnshareNote;
        private System.Windows.Forms.ToolStripButton btnUserdataShow;
        private System.Windows.Forms.ToolStripButton btnNoteMe;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGcategories;
        private System.Windows.Forms.DataGridViewImageColumn ImageCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBfind;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.DataGridViewImageColumn ImageNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem btnshowallcatergory;
        private System.Windows.Forms.ContextMenuStrip contextMenuDatagridCategory;
        private System.Windows.Forms.ToolStripMenuItem btnshowallcategory;
        private System.Windows.Forms.CheckBox checkBnote;
        private System.Windows.Forms.CheckBox checkBcategory;
        private System.Windows.Forms.ToolStripMenuItem btndropselectedcategory;
        private System.Windows.Forms.ToolStripMenuItem btnclearselection;
        private System.Windows.Forms.ToolStripMenuItem btnnewcategory;
    }
}

