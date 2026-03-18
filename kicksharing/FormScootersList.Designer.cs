namespace kicksharing
{
    partial class FormScootersList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            LbName = new Label();
            BtnLogaut = new Button();
            DgvList = new DataGridView();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvList).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.Window;
            TopPanel.Controls.Add(LbName);
            TopPanel.Controls.Add(BtnLogaut);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(2, 2);
            TopPanel.Name = "TopPanel";
            TopPanel.Padding = new Padding(10);
            TopPanel.Size = new Size(830, 50);
            TopPanel.TabIndex = 0;
            // 
            // LbName
            // 
            LbName.AutoSize = true;
            LbName.Dock = DockStyle.Right;
            LbName.Location = new Point(692, 10);
            LbName.Name = "LbName";
            LbName.Size = new Size(53, 21);
            LbName.TabIndex = 1;
            LbName.Text = "label1";
            // 
            // BtnLogaut
            // 
            BtnLogaut.BackColor = Color.FromArgb(249, 172, 102);
            BtnLogaut.Dock = DockStyle.Right;
            BtnLogaut.FlatAppearance.BorderSize = 0;
            BtnLogaut.FlatStyle = FlatStyle.Flat;
            BtnLogaut.ForeColor = Color.Black;
            BtnLogaut.Location = new Point(745, 10);
            BtnLogaut.Name = "BtnLogaut";
            BtnLogaut.Size = new Size(75, 30);
            BtnLogaut.TabIndex = 0;
            BtnLogaut.Text = "выход";
            BtnLogaut.UseVisualStyleBackColor = false;
            BtnLogaut.Click += BtnLogaut_Click;
            // 
            // DgvList
            // 
            DgvList.AllowUserToAddRows = false;
            DgvList.AllowUserToDeleteRows = false;
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvList.BackgroundColor = SystemColors.Window;
            DgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvList.ColumnHeadersVisible = false;
            DgvList.Dock = DockStyle.Fill;
            DgvList.GridColor = Color.White;
            DgvList.Location = new Point(2, 52);
            DgvList.MultiSelect = false;
            DgvList.Name = "DgvList";
            DgvList.ReadOnly = true;
            DgvList.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvList.Size = new Size(830, 457);
            DgvList.TabIndex = 1;
            // 
            // FormScootersList
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 511);
            Controls.Add(DgvList);
            Controls.Add(TopPanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormScootersList";
            Padding = new Padding(2);
            Text = "FormListBooks";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Label LbName;
        private Button BtnLogaut;
        private DataGridView DgvList;
    }
}