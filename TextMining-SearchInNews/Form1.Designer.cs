namespace TextMining_SearchInNews
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewNews = new System.Windows.Forms.DataGridView();
            this.btnGetNews = new System.Windows.Forms.Button();
            this.btnSeacrh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNews)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewNews
            // 
            this.gridViewNews.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewNews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewNews.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewNews.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridViewNews.Location = new System.Drawing.Point(11, 100);
            this.gridViewNews.Name = "gridViewNews";
            this.gridViewNews.RowTemplate.Height = 24;
            this.gridViewNews.Size = new System.Drawing.Size(960, 337);
            this.gridViewNews.TabIndex = 0;
            // 
            // btnGetNews
            // 
            this.btnGetNews.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGetNews.ForeColor = System.Drawing.Color.White;
            this.btnGetNews.Location = new System.Drawing.Point(11, 55);
            this.btnGetNews.Name = "btnGetNews";
            this.btnGetNews.Size = new System.Drawing.Size(148, 39);
            this.btnGetNews.TabIndex = 1;
            this.btnGetNews.Text = "GET NEWS";
            this.btnGetNews.UseVisualStyleBackColor = false;
            this.btnGetNews.Click += new System.EventHandler(this.btnGetNews_Click);
            // 
            // btnSeacrh
            // 
            this.btnSeacrh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSeacrh.ForeColor = System.Drawing.Color.White;
            this.btnSeacrh.Location = new System.Drawing.Point(823, 55);
            this.btnSeacrh.Name = "btnSeacrh";
            this.btnSeacrh.Size = new System.Drawing.Size(148, 39);
            this.btnSeacrh.TabIndex = 2;
            this.btnSeacrh.Text = "SEARCH";
            this.btnSeacrh.UseVisualStyleBackColor = false;
            this.btnSeacrh.Click += new System.EventHandler(this.btnSeacrh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(655, 55);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 39);
            this.txtSearch.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 449);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSeacrh);
            this.Controls.Add(this.btnGetNews);
            this.Controls.Add(this.gridViewNews);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.Text = "Text Mining in News";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewNews;
        private System.Windows.Forms.Button btnGetNews;
        private System.Windows.Forms.Button btnSeacrh;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

