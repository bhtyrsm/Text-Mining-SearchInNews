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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewNews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewNews.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewNews.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridViewNews.Location = new System.Drawing.Point(11, 100);
            this.gridViewNews.Name = "gridViewNews";
            this.gridViewNews.RowTemplate.Height = 24;
            this.gridViewNews.Size = new System.Drawing.Size(759, 337);
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
            this.btnSeacrh.Location = new System.Drawing.Point(621, 55);
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
            this.txtSearch.Location = new System.Drawing.Point(454, 55);
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
            this.ClientSize = new System.Drawing.Size(780, 449);
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

