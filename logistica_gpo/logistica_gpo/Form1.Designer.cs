namespace logistica_gpo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crea_matrice = new System.Windows.Forms.Button();
            this.nud_colonne = new System.Windows.Forms.NumericUpDown();
            this.nud_righe = new System.Windows.Forms.NumericUpDown();
            this.auto_inserimento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.righe = new System.Windows.Forms.Label();
            this.btn_NordOvest = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.btn_minimiCosti = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.DataGridView();
            this.btn_clearLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_colonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_righe)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab2)).BeginInit();
            this.SuspendLayout();
            // 
            // crea_matrice
            // 
            this.crea_matrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.crea_matrice.Location = new System.Drawing.Point(218, 8);
            this.crea_matrice.Name = "crea_matrice";
            this.crea_matrice.Size = new System.Drawing.Size(120, 35);
            this.crea_matrice.TabIndex = 0;
            this.crea_matrice.Text = "crea tabella";
            this.crea_matrice.UseVisualStyleBackColor = false;
            this.crea_matrice.Click += new System.EventHandler(this.crea_matrice_Click);
            // 
            // nud_colonne
            // 
            this.nud_colonne.BackColor = System.Drawing.Color.White;
            this.nud_colonne.Location = new System.Drawing.Point(92, 14);
            this.nud_colonne.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_colonne.Name = "nud_colonne";
            this.nud_colonne.Size = new System.Drawing.Size(120, 23);
            this.nud_colonne.TabIndex = 2;
            this.nud_colonne.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_righe
            // 
            this.nud_righe.BackColor = System.Drawing.Color.White;
            this.nud_righe.Location = new System.Drawing.Point(92, 51);
            this.nud_righe.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_righe.Name = "nud_righe";
            this.nud_righe.Size = new System.Drawing.Size(120, 23);
            this.nud_righe.TabIndex = 3;
            this.nud_righe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // auto_inserimento
            // 
            this.auto_inserimento.BackColor = System.Drawing.Color.PaleTurquoise;
            this.auto_inserimento.Location = new System.Drawing.Point(218, 44);
            this.auto_inserimento.Name = "auto_inserimento";
            this.auto_inserimento.Size = new System.Drawing.Size(120, 36);
            this.auto_inserimento.TabIndex = 4;
            this.auto_inserimento.Text = "preinserimento";
            this.auto_inserimento.UseVisualStyleBackColor = false;
            this.auto_inserimento.Click += new System.EventHandler(this.auto_inserimento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produttori";
            // 
            // righe
            // 
            this.righe.AutoSize = true;
            this.righe.Location = new System.Drawing.Point(12, 55);
            this.righe.Name = "righe";
            this.righe.Size = new System.Drawing.Size(76, 15);
            this.righe.TabIndex = 6;
            this.righe.Text = "Consumatori";
            // 
            // btn_NordOvest
            // 
            this.btn_NordOvest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NordOvest.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_NordOvest.Location = new System.Drawing.Point(691, 4);
            this.btn_NordOvest.Name = "btn_NordOvest";
            this.btn_NordOvest.Size = new System.Drawing.Size(174, 35);
            this.btn_NordOvest.TabIndex = 7;
            this.btn_NordOvest.Text = "nord ovest";
            this.btn_NordOvest.UseVisualStyleBackColor = false;
            this.btn_NordOvest.Click += new System.EventHandler(this.btn_NordOvest_Click);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Location = new System.Drawing.Point(871, 4);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(253, 659);
            this.log.TabIndex = 10;
            this.log.Text = "";
            // 
            // btn_minimiCosti
            // 
            this.btn_minimiCosti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimiCosti.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_minimiCosti.Location = new System.Drawing.Point(691, 42);
            this.btn_minimiCosti.Name = "btn_minimiCosti";
            this.btn_minimiCosti.Size = new System.Drawing.Size(174, 36);
            this.btn_minimiCosti.TabIndex = 11;
            this.btn_minimiCosti.Text = "minimi costi";
            this.btn_minimiCosti.UseVisualStyleBackColor = false;
            this.btn_minimiCosti.Click += new System.EventHandler(this.btn_minimiCosti_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 583);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tab);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "nord ovest";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab
            // 
            this.tab.AllowUserToAddRows = false;
            this.tab.AllowUserToDeleteRows = false;
            this.tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(3, 3);
            this.tab.Name = "tab";
            this.tab.RowTemplate.Height = 25;
            this.tab.Size = new System.Drawing.Size(839, 549);
            this.tab.TabIndex = 0;
            this.tab.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tab_EditingControlShowing);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "minimi costi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.AllowUserToAddRows = false;
            this.tab2.AllowUserToDeleteRows = false;
            this.tab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab2.Location = new System.Drawing.Point(3, 3);
            this.tab2.Name = "tab2";
            this.tab2.RowTemplate.Height = 25;
            this.tab2.Size = new System.Drawing.Size(839, 549);
            this.tab2.TabIndex = 3;
            this.tab2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tab2_EditingControlShowing);
            // 
            // btn_clearLog
            // 
            this.btn_clearLog.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_clearLog.Location = new System.Drawing.Point(344, 8);
            this.btn_clearLog.Name = "btn_clearLog";
            this.btn_clearLog.Size = new System.Drawing.Size(67, 45);
            this.btn_clearLog.TabIndex = 13;
            this.btn_clearLog.Text = "cancella log";
            this.btn_clearLog.UseVisualStyleBackColor = false;
            this.btn_clearLog.Click += new System.EventHandler(this.btn_clearLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1136, 681);
            this.Controls.Add(this.btn_clearLog);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_minimiCosti);
            this.Controls.Add(this.log);
            this.Controls.Add(this.btn_NordOvest);
            this.Controls.Add(this.righe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.auto_inserimento);
            this.Controls.Add(this.nud_righe);
            this.Controls.Add(this.nud_colonne);
            this.Controls.Add(this.crea_matrice);
            this.MinimumSize = new System.Drawing.Size(900, 454);
            this.Name = "Form1";
            this.Text = "Ricerca operativa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_colonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_righe)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button crea_matrice;
        private NumericUpDown nud_colonne;
        private NumericUpDown nud_righe;
        private Button auto_inserimento;
        private Label label1;
        private Label righe;
        private Button btn_NordOvest;
        private RichTextBox log;
        private Button btn_minimiCosti;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView tab2;
        private DataGridView tab;
        private Button btn_clearLog;
    }
}