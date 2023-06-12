namespace Proiect_3
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
            this.btn_S = new System.Windows.Forms.RadioButton();
            this.btn_M = new System.Windows.Forms.RadioButton();
            this.btn_L = new System.Windows.Forms.RadioButton();
            this.btn_iarna = new System.Windows.Forms.RadioButton();
            this.tip_vara = new System.Windows.Forms.RadioButton();
            this.add_click = new System.Windows.Forms.Button();
            this.producator = new System.Windows.Forms.TextBox();
            this.pret = new System.Windows.Forms.TextBox();
            this.afisare_Click = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_S
            // 
            this.btn_S.AutoSize = true;
            this.btn_S.Location = new System.Drawing.Point(394, 41);
            this.btn_S.Name = "btn_S";
            this.btn_S.Size = new System.Drawing.Size(32, 17);
            this.btn_S.TabIndex = 0;
            this.btn_S.TabStop = true;
            this.btn_S.Text = "S";
            this.btn_S.UseVisualStyleBackColor = true;
            this.btn_S.CheckedChanged += new System.EventHandler(this.btn_S_CheckedChanged);
            // 
            // btn_M
            // 
            this.btn_M.AutoSize = true;
            this.btn_M.Location = new System.Drawing.Point(394, 64);
            this.btn_M.Name = "btn_M";
            this.btn_M.Size = new System.Drawing.Size(34, 17);
            this.btn_M.TabIndex = 1;
            this.btn_M.TabStop = true;
            this.btn_M.Text = "M";
            this.btn_M.UseVisualStyleBackColor = true;
            this.btn_M.CheckedChanged += new System.EventHandler(this.btn_M_CheckedChanged);
            // 
            // btn_L
            // 
            this.btn_L.AutoSize = true;
            this.btn_L.Location = new System.Drawing.Point(394, 87);
            this.btn_L.Name = "btn_L";
            this.btn_L.Size = new System.Drawing.Size(31, 17);
            this.btn_L.TabIndex = 2;
            this.btn_L.TabStop = true;
            this.btn_L.Text = "L";
            this.btn_L.UseVisualStyleBackColor = true;
            this.btn_L.CheckedChanged += new System.EventHandler(this.btn_L_CheckedChanged);
            // 
            // btn_iarna
            // 
            this.btn_iarna.AutoSize = true;
            this.btn_iarna.Location = new System.Drawing.Point(394, 142);
            this.btn_iarna.Name = "btn_iarna";
            this.btn_iarna.Size = new System.Drawing.Size(49, 17);
            this.btn_iarna.TabIndex = 3;
            this.btn_iarna.TabStop = true;
            this.btn_iarna.Text = "Iarna";
            this.btn_iarna.UseVisualStyleBackColor = true;
            this.btn_iarna.CheckedChanged += new System.EventHandler(this.btn_iarna_CheckedChanged);
            // 
            // tip_vara
            // 
            this.tip_vara.AutoSize = true;
            this.tip_vara.Location = new System.Drawing.Point(394, 174);
            this.tip_vara.Name = "tip_vara";
            this.tip_vara.Size = new System.Drawing.Size(47, 17);
            this.tip_vara.TabIndex = 4;
            this.tip_vara.TabStop = true;
            this.tip_vara.Text = "Vara";
            this.tip_vara.UseVisualStyleBackColor = true;
            this.tip_vara.CheckedChanged += new System.EventHandler(this.tip_vara_CheckedChanged);
            // 
            // add_click
            // 
            this.add_click.Location = new System.Drawing.Point(150, 113);
            this.add_click.Name = "add_click";
            this.add_click.Size = new System.Drawing.Size(75, 23);
            this.add_click.TabIndex = 5;
            this.add_click.Text = "Adauga";
            this.add_click.UseVisualStyleBackColor = true;
            this.add_click.Click += new System.EventHandler(this.add_click_Click);
            // 
            // producator
            // 
            this.producator.Location = new System.Drawing.Point(70, 197);
            this.producator.Name = "producator";
            this.producator.Size = new System.Drawing.Size(100, 20);
            this.producator.TabIndex = 6;
            this.producator.Text = "Producator";
            // 
            // pret
            // 
            this.pret.Location = new System.Drawing.Point(70, 253);
            this.pret.Name = "pret";
            this.pret.Size = new System.Drawing.Size(100, 20);
            this.pret.TabIndex = 7;
            this.pret.Text = "Pret";
            // 
            // afisare_Click
            // 
            this.afisare_Click.Location = new System.Drawing.Point(150, 58);
            this.afisare_Click.Name = "afisare_Click";
            this.afisare_Click.Size = new System.Drawing.Size(75, 23);
            this.afisare_Click.TabIndex = 8;
            this.afisare_Click.Text = "Afisare";
            this.afisare_Click.UseVisualStyleBackColor = true;
            this.afisare_Click.Click += new System.EventHandler(this.afisare_Click_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(511, 161);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(240, 150);
            this.dataGrid.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.afisare_Click);
            this.Controls.Add(this.pret);
            this.Controls.Add(this.producator);
            this.Controls.Add(this.add_click);
            this.Controls.Add(this.tip_vara);
            this.Controls.Add(this.btn_iarna);
            this.Controls.Add(this.btn_L);
            this.Controls.Add(this.btn_M);
            this.Controls.Add(this.btn_S);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btn_S;
        private System.Windows.Forms.RadioButton btn_M;
        private System.Windows.Forms.RadioButton btn_L;
        private System.Windows.Forms.RadioButton btn_iarna;
        private System.Windows.Forms.RadioButton tip_vara;
        private System.Windows.Forms.Button add_click;
        private System.Windows.Forms.TextBox producator;
        private System.Windows.Forms.TextBox pret;
        private System.Windows.Forms.Button afisare_Click;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}
