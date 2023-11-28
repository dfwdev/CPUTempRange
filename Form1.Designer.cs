namespace TempUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnResetAvgMinMax = new System.Windows.Forms.Button();
            this.btnResetTempSpread = new System.Windows.Forms.Button();
            this.tempSpreadDataGridView = new System.Windows.Forms.DataGridView();
            this.sensorDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tempSpreadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnResetAvgMinMax
            // 
            this.btnResetAvgMinMax.Location = new System.Drawing.Point(20, 700);
            this.btnResetAvgMinMax.Name = "btnResetAvgMinMax";
            this.btnResetAvgMinMax.Size = new System.Drawing.Size(260, 40);
            this.btnResetAvgMinMax.TabIndex = 24;
            this.btnResetAvgMinMax.Text = "Reset Avg/Min/Max";
            this.btnResetAvgMinMax.UseVisualStyleBackColor = true;
            this.btnResetAvgMinMax.Click += new System.EventHandler(this.BtnResetAvgMinMax_Click);
            // 
            // btnResetTempSpread
            // 
            this.btnResetTempSpread.Location = new System.Drawing.Point(640, 700);
            this.btnResetTempSpread.Name = "btnResetTempSpread";
            this.btnResetTempSpread.Size = new System.Drawing.Size(210, 40);
            this.btnResetTempSpread.TabIndex = 25;
            this.btnResetTempSpread.Text = "Reset Spread";
            this.btnResetTempSpread.UseVisualStyleBackColor = true;
            this.btnResetTempSpread.Click += new System.EventHandler(this.BtnResetTempSpread_Click);
            // 
            // tempSpreadDataGridView
            // 
            this.tempSpreadDataGridView.AllowUserToAddRows = false;
            this.tempSpreadDataGridView.AllowUserToDeleteRows = false;
            this.tempSpreadDataGridView.AllowUserToResizeColumns = false;
            this.tempSpreadDataGridView.AllowUserToResizeRows = false;
            this.tempSpreadDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tempSpreadDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tempSpreadDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tempSpreadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tempSpreadDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.tempSpreadDataGridView.Enabled = false;
            this.tempSpreadDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.tempSpreadDataGridView.Location = new System.Drawing.Point(640, 20);
            this.tempSpreadDataGridView.MultiSelect = false;
            this.tempSpreadDataGridView.Name = "tempSpreadDataGridView";
            this.tempSpreadDataGridView.ReadOnly = true;
            this.tempSpreadDataGridView.RowHeadersVisible = false;
            this.tempSpreadDataGridView.RowHeadersWidth = 62;
            this.tempSpreadDataGridView.RowTemplate.Height = 28;
            this.tempSpreadDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tempSpreadDataGridView.Size = new System.Drawing.Size(210, 660);
            this.tempSpreadDataGridView.TabIndex = 26;
            // 
            // sensorDataGridView
            // 
            this.sensorDataGridView.AllowUserToAddRows = false;
            this.sensorDataGridView.AllowUserToDeleteRows = false;
            this.sensorDataGridView.AllowUserToResizeColumns = false;
            this.sensorDataGridView.AllowUserToResizeRows = false;
            this.sensorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.sensorDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sensorDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sensorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sensorDataGridView.Enabled = false;
            this.sensorDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.sensorDataGridView.Location = new System.Drawing.Point(20, 20);
            this.sensorDataGridView.MultiSelect = false;
            this.sensorDataGridView.Name = "sensorDataGridView";
            this.sensorDataGridView.ReadOnly = true;
            this.sensorDataGridView.RowHeadersVisible = false;
            this.sensorDataGridView.RowHeadersWidth = 62;
            this.sensorDataGridView.RowTemplate.Height = 28;
            this.sensorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.sensorDataGridView.Size = new System.Drawing.Size(600, 660);
            this.sensorDataGridView.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 761);
            this.Controls.Add(this.sensorDataGridView);
            this.Controls.Add(this.tempSpreadDataGridView);
            this.Controls.Add(this.btnResetTempSpread);
            this.Controls.Add(this.btnResetAvgMinMax);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "CPU Temp Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempSpreadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnResetAvgMinMax;
        private System.Windows.Forms.Button btnResetTempSpread;
        private System.Windows.Forms.DataGridView tempSpreadDataGridView;
        private System.Windows.Forms.DataGridView sensorDataGridView;
    }
}

