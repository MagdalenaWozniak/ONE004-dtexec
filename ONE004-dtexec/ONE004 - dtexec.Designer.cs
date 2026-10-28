using System.Windows.Forms;

namespace ONE004_dtexec
{
    partial class Title
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Title));
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.title1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl6 = new System.Windows.Forms.Label();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dTP1
            // 
            this.dTP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP1.CustomFormat = "yyyy.MM.dd";
            this.dTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP1.Location = new System.Drawing.Point(141, 60);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(269, 20);
            this.dTP1.TabIndex = 0;
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.title1.Location = new System.Drawing.Point(116, 9);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(195, 25);
            this.title1.TabIndex = 1;
            this.title1.Text = "Proszę wypełnić pola";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lb2.Location = new System.Drawing.Point(12, 60);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(66, 17);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Data od: ";
            // 
            // dTP2
            // 
            this.dTP2.CustomFormat = "yyyy.MM.dd";
            this.dTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP2.Location = new System.Drawing.Point(141, 93);
            this.dTP2.Name = "dTP2";
            this.dTP2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dTP2.Size = new System.Drawing.Size(269, 20);
            this.dTP2.TabIndex = 0;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lb3.Location = new System.Drawing.Point(12, 93);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(66, 17);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Data do: ";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lb4.Location = new System.Drawing.Point(12, 126);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(112, 17);
            this.lb4.TabIndex = 2;
            this.lb4.Text = "Ścieżka exportu:";
            // 
            // tB1
            // 
            this.tB1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB1.Location = new System.Drawing.Point(141, 126);
            this.tB1.Name = "tB1";
            this.tB1.ReadOnly = true;
            this.tB1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tB1.Size = new System.Drawing.Size(202, 20);
            this.tB1.TabIndex = 3;
            this.tB1.Text = "Pulpit";
            this.tB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tB1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBox1_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.button1.Location = new System.Drawing.Point(15, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Wykonaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.ForeColor = System.Drawing.Color.Firebrick;
            this.lb5.Location = new System.Drawing.Point(15, 200);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(0, 13);
            this.lb5.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "Wybierz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lbl6.Location = new System.Drawing.Point(12, 159);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(87, 17);
            this.lbl6.TabIndex = 2;
            this.lbl6.Text = "Nazwa pliku:";
            // 
            // tB2
            // 
            this.tB2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tB2.Location = new System.Drawing.Point(141, 159);
            this.tB2.Name = "tB2";
            this.tB2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tB2.Size = new System.Drawing.Size(269, 20);
            this.tB2.TabIndex = 3;
            this.tB2.Text = "Audyt";
            this.tB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB2_KeyPress);
            // 
            // title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 281);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.dTP2);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.dTP1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "title";
            this.Text = "ONE004 dtexec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.DateTimePicker dTP2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb5;
        private Button button2;
        private Label lbl6;
        private TextBox tB2;
    }
}

