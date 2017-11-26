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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnadd = new System.Windows.Forms.ToolStripSplitButton();
            this.btnaddNote = new System.Windows.Forms.ToolStripMenuItem();
            this.btnaddcategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnshareNote = new System.Windows.Forms.ToolStripButton();
            this.btnUserdataShow = new System.Windows.Forms.ToolStripButton();
            this.btnNoteMe = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGNotes = new System.Windows.Forms.DataGridView();
            this.idnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuNote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowallNote = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNoteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnchangenote = new System.Windows.Forms.ToolStripMenuItem();
            this.btndellNote = new System.Windows.Forms.ToolStripMenuItem();
            this.btnaddintoCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShare = new System.Windows.Forms.ToolStripMenuItem();
            this.contetnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sharedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuDataGridNotes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowAllNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGcategories = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuCategories = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnaddnewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btndellCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.brnRenameCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnaddNoteContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btndellfromcategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGNotes)).BeginInit();
            this.contextMenuNote.SuspendLayout();
            this.contextMenuDataGridNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGcategories)).BeginInit();
            this.contextMenuCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 459);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.toolStrip1.Size = new System.Drawing.Size(80, 459);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
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
            this.btnNoteMe.Size = new System.Drawing.Size(78, 54);
            this.btnNoteMe.Text = "Заметки мне";
            this.btnNoteMe.Click += new System.EventHandler(this.btnNoteMe_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::Evernote.WinForms.Properties.Resources.Exit;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 54);
            this.btnExit.Text = "Выход";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.83334F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.23399F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.766004F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(715, 453);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGNotes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(211, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 438);
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
            this.dataGNotes.AutoGenerateColumns = false;
            this.dataGNotes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnote,
            this.header,
            this.contetnt,
            this.ownerDataGridViewTextBoxColumn,
            this.created,
            this.changed,
            this.categoriesDataGridViewTextBoxColumn,
            this.sharedDataGridViewTextBoxColumn});
            this.dataGNotes.ContextMenuStrip = this.contextMenuDataGridNotes;
            this.dataGNotes.DataSource = this.noteBindingSource;
            this.dataGNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGNotes.Location = new System.Drawing.Point(3, 18);
            this.dataGNotes.MultiSelect = false;
            this.dataGNotes.Name = "dataGNotes";
            this.dataGNotes.ReadOnly = true;
            this.dataGNotes.RowHeadersVisible = false;
            this.dataGNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGNotes.Size = new System.Drawing.Size(495, 417);
            this.dataGNotes.TabIndex = 0;
            this.dataGNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGNotes_CellDoubleClick);
            // 
            // idnote
            // 
            this.idnote.DataPropertyName = "Id";
            this.idnote.HeaderText = "Id";
            this.idnote.Name = "idnote";
            this.idnote.ReadOnly = true;
            this.idnote.Visible = false;
            // 
            // header
            // 
            this.header.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.header.ContextMenuStrip = this.contextMenuNote;
            this.header.DataPropertyName = "header";
            this.header.HeaderText = "Название";
            this.header.Name = "header";
            this.header.ReadOnly = true;
            // 
            // contextMenuNote
            // 
            this.contextMenuNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowallNote,
            this.btnAddNoteMenu,
            this.btnchangenote,
            this.btndellNote,
            this.btnaddintoCategory,
            this.btnShare,
            this.btndellfromcategory});
            this.contextMenuNote.Name = "contextMenuNote";
            this.contextMenuNote.Size = new System.Drawing.Size(198, 158);
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
            // btnchangenote
            // 
            this.btnchangenote.Name = "btnchangenote";
            this.btnchangenote.Size = new System.Drawing.Size(197, 22);
            this.btnchangenote.Text = "Изменить";
            this.btnchangenote.Click += new System.EventHandler(this.btnchangenote_Click);
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
            // contetnt
            // 
            this.contetnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contetnt.ContextMenuStrip = this.contextMenuNote;
            this.contetnt.DataPropertyName = "text";
            this.contetnt.HeaderText = "Содержимое";
            this.contetnt.Name = "contetnt";
            this.contetnt.ReadOnly = true;
            this.contetnt.Visible = false;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerDataGridViewTextBoxColumn.Visible = false;
            // 
            // created
            // 
            this.created.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.created.ContextMenuStrip = this.contextMenuNote;
            this.created.DataPropertyName = "Created";
            this.created.HeaderText = "Создано";
            this.created.Name = "created";
            this.created.ReadOnly = true;
            // 
            // changed
            // 
            this.changed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changed.ContextMenuStrip = this.contextMenuNote;
            this.changed.DataPropertyName = "Changed";
            this.changed.HeaderText = "Изменено";
            this.changed.Name = "changed";
            this.changed.ReadOnly = true;
            // 
            // categoriesDataGridViewTextBoxColumn
            // 
            this.categoriesDataGridViewTextBoxColumn.DataPropertyName = "Categories";
            this.categoriesDataGridViewTextBoxColumn.HeaderText = "Categories";
            this.categoriesDataGridViewTextBoxColumn.Name = "categoriesDataGridViewTextBoxColumn";
            this.categoriesDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriesDataGridViewTextBoxColumn.Visible = false;
            // 
            // sharedDataGridViewTextBoxColumn
            // 
            this.sharedDataGridViewTextBoxColumn.DataPropertyName = "Shared";
            this.sharedDataGridViewTextBoxColumn.HeaderText = "Shared";
            this.sharedDataGridViewTextBoxColumn.Name = "sharedDataGridViewTextBoxColumn";
            this.sharedDataGridViewTextBoxColumn.ReadOnly = true;
            this.sharedDataGridViewTextBoxColumn.Visible = false;
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
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(Evernote.Note);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGcategories);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 438);
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
            this.dataGcategories.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGcategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGcategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn});
            this.dataGcategories.DataSource = this.categoryBindingSource;
            this.dataGcategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGcategories.Location = new System.Drawing.Point(3, 18);
            this.dataGcategories.MultiSelect = false;
            this.dataGcategories.Name = "dataGcategories";
            this.dataGcategories.ReadOnly = true;
            this.dataGcategories.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGcategories.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGcategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGcategories.Size = new System.Drawing.Size(196, 417);
            this.dataGcategories.TabIndex = 0;
            this.dataGcategories.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGcategories_CellMouseClick);
            this.dataGcategories.SelectionChanged += new System.EventHandler(this.dataGcategories_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.ContextMenuStrip = this.contextMenuCategories;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuCategories
            // 
            this.contextMenuCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnaddnewCategory,
            this.btndellCategory,
            this.brnRenameCategory});
            this.contextMenuCategories.Name = "contextMenuCategories";
            this.contextMenuCategories.Size = new System.Drawing.Size(189, 70);
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
            this.brnRenameCategory.Text = "Переименовать";
            this.brnRenameCategory.Click += new System.EventHandler(this.brnRenameCategory_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Evernote.Model.Category);
            // 
            // btnaddNoteContextMenu
            // 
            this.btnaddNoteContextMenu.Name = "btnaddNoteContextMenu";
            this.btnaddNoteContextMenu.Size = new System.Drawing.Size(192, 22);
            this.btnaddNoteContextMenu.Text = "Добавить";
            this.btnaddNoteContextMenu.Click += new System.EventHandler(this.btnaddNoteContextMenu_Click);
            // 
            // btndellfromcategory
            // 
            this.btndellfromcategory.Name = "btndellfromcategory";
            this.btndellfromcategory.Size = new System.Drawing.Size(197, 22);
            this.btndellfromcategory.Text = "Убрать из категории";
            this.btndellfromcategory.Click += new System.EventHandler(this.btndellfromcategory_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(801, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindows";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainWindows_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGNotes)).EndInit();
            this.contextMenuNote.ResumeLayout(false);
            this.contextMenuDataGridNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGcategories)).EndInit();
            this.contextMenuCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripSplitButton btnadd;
        private System.Windows.Forms.ToolStripMenuItem btnaddNote;
        private System.Windows.Forms.ToolStripMenuItem btnaddcategory;
        private System.Windows.Forms.ToolStripButton btnshareNote;
        private System.Windows.Forms.ToolStripButton btnUserdataShow;
        private System.Windows.Forms.ToolStripButton btnNoteMe;
        private System.Windows.Forms.ContextMenuStrip contextMenuNote;
        private System.Windows.Forms.ToolStripMenuItem btnShowallNote;
        private System.Windows.Forms.ToolStripMenuItem btnAddNoteMenu;
        private System.Windows.Forms.ToolStripMenuItem btndellNote;
        private System.Windows.Forms.ToolStripMenuItem btnchangenote;
        private System.Windows.Forms.ToolStripMenuItem btnaddintoCategory;
        private System.Windows.Forms.ToolStripMenuItem btnShare;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridView dataGNotes;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.DataGridView dataGcategories;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuDataGridNotes;
        private System.Windows.Forms.ToolStripMenuItem btnShowAllNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuCategories;
        private System.Windows.Forms.ToolStripMenuItem btnaddnewCategory;
        private System.Windows.Forms.ToolStripMenuItem btndellCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn header;
        private System.Windows.Forms.DataGridViewTextBoxColumn contetnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn created;
        private System.Windows.Forms.DataGridViewTextBoxColumn changed;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharedDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem brnRenameCategory;
        private System.Windows.Forms.ToolStripMenuItem btnaddNoteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btndellfromcategory;
    }
}

