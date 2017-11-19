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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGshares = new System.Windows.Forms.DataGridView();
            this.contextMenuDGShare = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnupdateDGShare = new System.Windows.Forms.ToolStripMenuItem();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sharedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGshares)).BeginInit();
            this.contextMenuDGShare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
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
            this.User,
            this.name,
            this.textDataGridViewTextBoxColumn,
            this.createdDate,
            this.changedDate,
            this.categoriesDataGridViewTextBoxColumn,
            this.sharedDataGridViewTextBoxColumn});
            this.dataGshares.ContextMenuStrip = this.contextMenuDGShare;
            this.dataGshares.DataSource = this.noteBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGshares.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGshares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGshares.Location = new System.Drawing.Point(0, 0);
            this.dataGshares.MultiSelect = false;
            this.dataGshares.Name = "dataGshares";
            this.dataGshares.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGshares.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGshares.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            this.dataGshares.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGshares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGshares.Size = new System.Drawing.Size(617, 463);
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
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(Evernote.Note);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User.DataPropertyName = "Owner";
            this.User.HeaderText = "Owner";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "header";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.DefaultCellStyle = dataGridViewCellStyle2;
            this.name.HeaderText = "Назание";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Текст";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            this.textDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdDate
            // 
            this.createdDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdDate.DataPropertyName = "Created";
            this.createdDate.HeaderText = "Дата создания";
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            // 
            // changedDate
            // 
            this.changedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changedDate.DataPropertyName = "Changed";
            this.changedDate.HeaderText = "Дата изменения";
            this.changedDate.Name = "changedDate";
            this.changedDate.ReadOnly = true;
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
            // SharesMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 463);
            this.Controls.Add(this.dataGshares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SharesMeForm";
            this.Text = "Заметки мне";
            ((System.ComponentModel.ISupportInitialize)(this.dataGshares)).EndInit();
            this.contextMenuDGShare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGshares;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.ContextMenuStrip contextMenuDGShare;
        private System.Windows.Forms.ToolStripMenuItem btnupdateDGShare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharedDataGridViewTextBoxColumn;
    }
}