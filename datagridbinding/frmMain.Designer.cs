namespace datagridbinding
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsError = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sampleQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sample1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sample2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sample3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sample4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sample5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.stsError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(693, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "Count = 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel2.Text = "time =0";
            // 
            // stsError
            // 
            this.stsError.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stsError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.stsError.ForeColor = System.Drawing.Color.Red;
            this.stsError.Name = "stsError";
            this.stsError.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sampleQueriesToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sampleQueriesToolStripMenuItem
            // 
            this.sampleQueriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sample1ToolStripMenuItem,
            this.sample2ToolStripMenuItem,
            this.sample3ToolStripMenuItem,
            this.sample4ToolStripMenuItem,
            this.sample5ToolStripMenuItem});
            this.sampleQueriesToolStripMenuItem.Name = "sampleQueriesToolStripMenuItem";
            this.sampleQueriesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.sampleQueriesToolStripMenuItem.Text = "Sample Queries";
            // 
            // sample1ToolStripMenuItem
            // 
            this.sample1ToolStripMenuItem.Name = "sample1ToolStripMenuItem";
            this.sample1ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sample1ToolStripMenuItem.Text = "Sample 1";
            this.sample1ToolStripMenuItem.Click += new System.EventHandler(this.sample1ToolStripMenuItem_Click);
            // 
            // sample2ToolStripMenuItem
            // 
            this.sample2ToolStripMenuItem.Name = "sample2ToolStripMenuItem";
            this.sample2ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sample2ToolStripMenuItem.Text = "Sample 2";
            this.sample2ToolStripMenuItem.Click += new System.EventHandler(this.sample2ToolStripMenuItem_Click);
            // 
            // sample3ToolStripMenuItem
            // 
            this.sample3ToolStripMenuItem.Name = "sample3ToolStripMenuItem";
            this.sample3ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sample3ToolStripMenuItem.Text = "Sample 3";
            this.sample3ToolStripMenuItem.Click += new System.EventHandler(this.sample3ToolStripMenuItem_Click);
            // 
            // sample4ToolStripMenuItem
            // 
            this.sample4ToolStripMenuItem.Name = "sample4ToolStripMenuItem";
            this.sample4ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sample4ToolStripMenuItem.Text = "Sample 4";
            this.sample4ToolStripMenuItem.Click += new System.EventHandler(this.sample4ToolStripMenuItem_Click);
            // 
            // sample5ToolStripMenuItem
            // 
            this.sample5ToolStripMenuItem.Name = "sample5ToolStripMenuItem";
            this.sample5ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sample5ToolStripMenuItem.Text = "Sample 5";
            this.sample5ToolStripMenuItem.Click += new System.EventHandler(this.sample5ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(693, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "serial<100";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 317);
            this.dataGridView1.TabIndex = 7;
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Visible = false;
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 386);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Query Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stsError;
        private System.Windows.Forms.ToolStripMenuItem sampleQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sample1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sample2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sample3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sample4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sample5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}

