namespace Evernote.WinForms.Forms
{
    partial class SharesMeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGshares = new System.Windows.Forms.DataGridView();
            this.contextMenuDGShare = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnupdateDGShare = new System.Windows.Forms.ToolStripMenuItem();
            this.shareMeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chboxnotefromMe = new System.Windows.Forms.RadioButton();
            this.chboxnotoMe = new System.Windows.Forms.RadioButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerofNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGshares)).BeginInit();
            this.contextMenuDGShare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shareMeViewBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGshares
            // 
            this.dataGshares.AllowUserToAddRows = false;
            this.dataGshares.AllowUserToDeleteRows = false;
            this.dataGshares.AllowUserToResizeColumns = false;
            this.dataGshares.AllowUserToResizeRows = false;
            this.dataGshares.AutoGenerateColumns = false;
            this.dataGshares.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGshares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGshares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGshares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.OwnerofNote,
            this.headerDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.changedDataGridViewTextBoxColumn});
            this.dataGshares.ContextMenuStrip = this.contextMenuDGShare;
            this.dataGshares.DataSource = this.shareMeViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGshares.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGshares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGshares.Location = new System.Drawing.Point(3, 3);
            this.dataGshares.MultiSelect = false;
            this.dataGshares.Name = "dataGshares";
            this.dataGshares.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGshares.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGshares.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGshares.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGshares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGshares.Size = new System.Drawing.Size(559, 488);
            this.dataGshares.TabIndex = 0;
            this.dataGshares.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGshares_CellDoubleClick);
            // 
            // contextMenuDGShare
            // 
            this.contextMenuDGShare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnupdateDGShare});
            this.contextMenuDGShare.Name = "contextMenuDGShare";
            this.contextMenuDGShare.Size = new System.Drawing.Size(129, 26);
            // 
            // btnupdateDGShare
            // 
            this.btnupdateDGShare.Name = "btnupdateDGShare";
            this.btnupdateDGShare.Size = new System.Drawing.Size(128, 22);
            this.btnupdateDGShare.Text = "Обновить";
            this.btnupdateDGShare.Click += new System.EventHandler(this.btnupdateDGShare_Click);
            // 
            // shareMeViewBindingSource
            // 
            this.shareMeViewBindingSource.DataSource = typeof(Evernote.WinForms.ViewModel.SharetoMeView);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.25446F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.74554F));
            this.tableLayoutPanel1.Controls.Add(this.dataGshares, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(714, 494);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(568, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(143, 488);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.chboxnotefromMe);
            this.panel1.Controls.Add(this.chboxnotoMe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 156);
            this.panel1.TabIndex = 0;
            // 
            // chboxnotefromMe
            // 
            this.chboxnotefromMe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chboxnotefromMe.AutoSize = true;
            this.chboxnotefromMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chboxnotefromMe.Location = new System.Drawing.Point(21, 87);
            this.chboxnotefromMe.Name = "chboxnotefromMe";
            this.chboxnotefromMe.Size = new System.Drawing.Size(78, 20);
            this.chboxnotefromMe.TabIndex = 1;
            this.chboxnotefromMe.Text = "От меня";
            this.chboxnotefromMe.UseVisualStyleBackColor = true;
            this.chboxnotefromMe.CheckedChanged += new System.EventHandler(this.chboxnotefromMe_CheckedChanged);
            // 
            // chboxnotoMe
            // 
            this.chboxnotoMe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chboxnotoMe.AutoSize = true;
            this.chboxnotoMe.Checked = true;
            this.chboxnotoMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chboxnotoMe.Location = new System.Drawing.Point(21, 40);
            this.chboxnotoMe.Name = "chboxnotoMe";
            this.chboxnotoMe.Size = new System.Drawing.Size(53, 20);
            this.chboxnotoMe.TabIndex = 0;
            this.chboxnotoMe.TabStop = true;
            this.chboxnotoMe.Text = "Мне";
            this.chboxnotoMe.UseVisualStyleBackColor = true;
            this.chboxnotoMe.CheckedChanged += new System.EventHandler(this.chboxnotoMe_CheckedChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // OwnerofNote
            // 
            this.OwnerofNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OwnerofNote.DataPropertyName = "Owner";
            this.OwnerofNote.HeaderText = "От кого";
            this.OwnerofNote.Name = "OwnerofNote";
            this.OwnerofNote.ReadOnly = true;
            // 
            // headerDataGridViewTextBoxColumn
            // 
            this.headerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerDataGridViewTextBoxColumn.DataPropertyName = "header";
            this.headerDataGridViewTextBoxColumn.HeaderText = "Название";
            this.headerDataGridViewTextBoxColumn.Name = "headerDataGridViewTextBoxColumn";
            this.headerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Создана";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changedDataGridViewTextBoxColumn
            // 
            this.changedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changedDataGridViewTextBoxColumn.DataPropertyName = "Changed";
            this.changedDataGridViewTextBoxColumn.HeaderText = "Изменена";
            this.changedDataGridViewTextBoxColumn.Name = "changedDataGridViewTextBoxColumn";
            this.changedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SharesMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SharesMeForm";
            this.Text = "Заметки";
            this.Load += new System.EventHandler(this.SharesMeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGshares)).EndInit();
            this.contextMenuDGShare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shareMeViewBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGshares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.ContextMenuStrip contextMenuDGShare;
        private System.Windows.Forms.ToolStripMenuItem btnupdateDGShare;
        private System.Windows.Forms.BindingSource shareMeViewBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton chboxnotefromMe;
        private System.Windows.Forms.RadioButton chboxnotoMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerofNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedDataGridViewTextBoxColumn;
    }
}