namespace DVLD_System
{
    partial class frmApplicationTypes
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
            this.dgvAppTypes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotalRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicaitonTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAppTypes
            // 
            this.dgvAppTypes.AllowUserToAddRows = false;
            this.dgvAppTypes.AllowUserToDeleteRows = false;
            this.dgvAppTypes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAppTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppTypes.Location = new System.Drawing.Point(86, 163);
            this.dgvAppTypes.Name = "dgvAppTypes";
            this.dgvAppTypes.ReadOnly = true;
            this.dgvAppTypes.RowHeadersWidth = 51;
            this.dgvAppTypes.RowTemplate.Height = 24;
            this.dgvAppTypes.Size = new System.Drawing.Size(667, 228);
            this.dgvAppTypes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record : ";
            // 
            // lbltotalRecord
            // 
            this.lbltotalRecord.AutoSize = true;
            this.lbltotalRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltotalRecord.Location = new System.Drawing.Point(195, 415);
            this.lbltotalRecord.Name = "lbltotalRecord";
            this.lbltotalRecord.Size = new System.Drawing.Size(74, 29);
            this.lbltotalRecord.TabIndex = 2;
            this.lbltotalRecord.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(210, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Manage Application Types";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicaitonTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(257, 60);
            // 
            // editApplicaitonTypeToolStripMenuItem
            // 
            this.editApplicaitonTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.editApplicaitonTypeToolStripMenuItem.Image = global::DVLD_System.Properties.Resources.edit;
            this.editApplicaitonTypeToolStripMenuItem.Name = "editApplicaitonTypeToolStripMenuItem";
            this.editApplicaitonTypeToolStripMenuItem.Size = new System.Drawing.Size(256, 28);
            this.editApplicaitonTypeToolStripMenuItem.Text = "Edit Applicaiton Type";
            this.editApplicaitonTypeToolStripMenuItem.Click += new System.EventHandler(this.editApplicaitonTypeToolStripMenuItem_Click);
            // 
            // frmApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotalRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppTypes);
            this.Name = "frmApplicationTypes";
            this.Text = "frmApplicationTypes";
            this.Activated += new System.EventHandler(this.frmApplicationTypes_Activated);
            this.Load += new System.EventHandler(this.frmApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotalRecord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editApplicaitonTypeToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}