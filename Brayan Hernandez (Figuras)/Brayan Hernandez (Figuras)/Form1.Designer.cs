namespace Brayan_Hernandez__Figuras_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnlimpiarcubo = new System.Windows.Forms.Button();
            this.btncalcularcubo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblresultvolcubo = new System.Windows.Forms.Label();
            this.lblresultareacubo = new System.Windows.Forms.Label();
            this.lblvolumencubo = new System.Windows.Forms.Label();
            this.lblareacubo = new System.Windows.Forms.Label();
            this.txtcubo = new System.Windows.Forms.TextBox();
            this.lblladocubo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnlimpiarcilindro = new System.Windows.Forms.Button();
            this.btncalcularcilindro = new System.Windows.Forms.Button();
            this.lblresultvolumencilindro = new System.Windows.Forms.Label();
            this.lblresultareacilindro = new System.Windows.Forms.Label();
            this.lblvolumencilindro = new System.Windows.Forms.Label();
            this.lblcilindroarea = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblaltura = new System.Windows.Forms.Label();
            this.txtcilindroradio = new System.Windows.Forms.TextBox();
            this.lblradiocilindro = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnlimpiaresfera = new System.Windows.Forms.Button();
            this.btncalcularesfera = new System.Windows.Forms.Button();
            this.lblresultvolumenesfera = new System.Windows.Forms.Label();
            this.lblvolumen = new System.Windows.Forms.Label();
            this.lblresultareaesfera = new System.Windows.Forms.Label();
            this.lblareaesfera = new System.Windows.Forms.Label();
            this.txtesferaradio = new System.Windows.Forms.TextBox();
            this.lblradioesfera = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Wheat;
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.btnlimpiarcubo);
            this.tabPage1.Controls.Add(this.btncalcularcubo);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.lblresultvolcubo);
            this.tabPage1.Controls.Add(this.lblresultareacubo);
            this.tabPage1.Controls.Add(this.lblvolumencubo);
            this.tabPage1.Controls.Add(this.lblareacubo);
            this.tabPage1.Controls.Add(this.txtcubo);
            this.tabPage1.Controls.Add(this.lblladocubo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1056, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cubo";
            // 
            // btnlimpiarcubo
            // 
            this.btnlimpiarcubo.Location = new System.Drawing.Point(287, 310);
            this.btnlimpiarcubo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiarcubo.Name = "btnlimpiarcubo";
            this.btnlimpiarcubo.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiarcubo.TabIndex = 8;
            this.btnlimpiarcubo.Text = "Limpiar";
            this.btnlimpiarcubo.UseVisualStyleBackColor = true;
            this.btnlimpiarcubo.Click += new System.EventHandler(this.btnlimpiarcubo_Click);
            // 
            // btncalcularcubo
            // 
            this.btncalcularcubo.Location = new System.Drawing.Point(83, 310);
            this.btncalcularcubo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalcularcubo.Name = "btncalcularcubo";
            this.btncalcularcubo.Size = new System.Drawing.Size(100, 28);
            this.btncalcularcubo.TabIndex = 7;
            this.btncalcularcubo.Text = "Calcular";
            this.btncalcularcubo.UseVisualStyleBackColor = true;
            this.btncalcularcubo.Click += new System.EventHandler(this.btncalcularcubo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Brayan_Hernandez__Figuras_.Properties.Resources.cubo;
            this.pictureBox1.Location = new System.Drawing.Point(575, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblresultvolcubo
            // 
            this.lblresultvolcubo.AutoSize = true;
            this.lblresultvolcubo.Location = new System.Drawing.Point(255, 220);
            this.lblresultvolcubo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultvolcubo.Name = "lblresultvolcubo";
            this.lblresultvolcubo.Size = new System.Drawing.Size(46, 17);
            this.lblresultvolcubo.TabIndex = 5;
            this.lblresultvolcubo.Text = "label2";
            // 
            // lblresultareacubo
            // 
            this.lblresultareacubo.AutoSize = true;
            this.lblresultareacubo.Location = new System.Drawing.Point(251, 158);
            this.lblresultareacubo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultareacubo.Name = "lblresultareacubo";
            this.lblresultareacubo.Size = new System.Drawing.Size(46, 17);
            this.lblresultareacubo.TabIndex = 4;
            this.lblresultareacubo.Text = "label1";
            // 
            // lblvolumencubo
            // 
            this.lblvolumencubo.AutoSize = true;
            this.lblvolumencubo.Location = new System.Drawing.Point(79, 222);
            this.lblvolumencubo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvolumencubo.Name = "lblvolumencubo";
            this.lblvolumencubo.Size = new System.Drawing.Size(67, 17);
            this.lblvolumencubo.TabIndex = 3;
            this.lblvolumencubo.Text = "Volumen:";
            // 
            // lblareacubo
            // 
            this.lblareacubo.AutoSize = true;
            this.lblareacubo.Location = new System.Drawing.Point(83, 158);
            this.lblareacubo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblareacubo.Name = "lblareacubo";
            this.lblareacubo.Size = new System.Drawing.Size(46, 17);
            this.lblareacubo.TabIndex = 2;
            this.lblareacubo.Text = "Area: ";
            // 
            // txtcubo
            // 
            this.txtcubo.Location = new System.Drawing.Point(255, 90);
            this.txtcubo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcubo.Name = "txtcubo";
            this.txtcubo.Size = new System.Drawing.Size(132, 22);
            this.txtcubo.TabIndex = 1;
            // 
            // lblladocubo
            // 
            this.lblladocubo.Location = new System.Drawing.Point(79, 94);
            this.lblladocubo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblladocubo.Name = "lblladocubo";
            this.lblladocubo.Size = new System.Drawing.Size(133, 28);
            this.lblladocubo.TabIndex = 0;
            this.lblladocubo.Text = "Medida del lado: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btnlimpiarcilindro);
            this.tabPage2.Controls.Add(this.btncalcularcilindro);
            this.tabPage2.Controls.Add(this.lblresultvolumencilindro);
            this.tabPage2.Controls.Add(this.lblresultareacilindro);
            this.tabPage2.Controls.Add(this.lblvolumencilindro);
            this.tabPage2.Controls.Add(this.lblcilindroarea);
            this.tabPage2.Controls.Add(this.txtaltura);
            this.tabPage2.Controls.Add(this.lblaltura);
            this.tabPage2.Controls.Add(this.txtcilindroradio);
            this.tabPage2.Controls.Add(this.lblradiocilindro);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1056, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cilindro";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Brayan_Hernandez__Figuras_.Properties.Resources.Cilindro;
            this.pictureBox2.Location = new System.Drawing.Point(644, 74);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 268);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnlimpiarcilindro
            // 
            this.btnlimpiarcilindro.Location = new System.Drawing.Point(307, 354);
            this.btnlimpiarcilindro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiarcilindro.Name = "btnlimpiarcilindro";
            this.btnlimpiarcilindro.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiarcilindro.TabIndex = 9;
            this.btnlimpiarcilindro.Text = "Limpiar";
            this.btnlimpiarcilindro.UseVisualStyleBackColor = true;
            this.btnlimpiarcilindro.Click += new System.EventHandler(this.btnlimpiarcilindro_Click);
            // 
            // btncalcularcilindro
            // 
            this.btncalcularcilindro.Location = new System.Drawing.Point(93, 354);
            this.btncalcularcilindro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalcularcilindro.Name = "btncalcularcilindro";
            this.btncalcularcilindro.Size = new System.Drawing.Size(100, 28);
            this.btncalcularcilindro.TabIndex = 8;
            this.btncalcularcilindro.Text = "Calcular";
            this.btncalcularcilindro.UseVisualStyleBackColor = true;
            this.btncalcularcilindro.Click += new System.EventHandler(this.btncalcularcilindro_Click);
            // 
            // lblresultvolumencilindro
            // 
            this.lblresultvolumencilindro.AutoSize = true;
            this.lblresultvolumencilindro.Location = new System.Drawing.Point(307, 283);
            this.lblresultvolumencilindro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultvolumencilindro.Name = "lblresultvolumencilindro";
            this.lblresultvolumencilindro.Size = new System.Drawing.Size(46, 17);
            this.lblresultvolumencilindro.TabIndex = 7;
            this.lblresultvolumencilindro.Text = "label4";
            // 
            // lblresultareacilindro
            // 
            this.lblresultareacilindro.AutoSize = true;
            this.lblresultareacilindro.Location = new System.Drawing.Point(303, 224);
            this.lblresultareacilindro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultareacilindro.Name = "lblresultareacilindro";
            this.lblresultareacilindro.Size = new System.Drawing.Size(46, 17);
            this.lblresultareacilindro.TabIndex = 6;
            this.lblresultareacilindro.Text = "label3";
            // 
            // lblvolumencilindro
            // 
            this.lblvolumencilindro.AutoSize = true;
            this.lblvolumencilindro.Location = new System.Drawing.Point(93, 283);
            this.lblvolumencilindro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvolumencilindro.Name = "lblvolumencilindro";
            this.lblvolumencilindro.Size = new System.Drawing.Size(71, 17);
            this.lblvolumencilindro.TabIndex = 5;
            this.lblvolumencilindro.Text = "Volumen: ";
            // 
            // lblcilindroarea
            // 
            this.lblcilindroarea.AutoSize = true;
            this.lblcilindroarea.Location = new System.Drawing.Point(89, 224);
            this.lblcilindroarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcilindroarea.Name = "lblcilindroarea";
            this.lblcilindroarea.Size = new System.Drawing.Size(42, 17);
            this.lblcilindroarea.TabIndex = 4;
            this.lblcilindroarea.Text = "Area:";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(307, 156);
            this.txtaltura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(132, 22);
            this.txtaltura.TabIndex = 3;
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(89, 156);
            this.lblaltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(133, 17);
            this.lblaltura.TabIndex = 2;
            this.lblaltura.Text = "Medida de la altura:";
            // 
            // txtcilindroradio
            // 
            this.txtcilindroradio.Location = new System.Drawing.Point(307, 91);
            this.txtcilindroradio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcilindroradio.Name = "txtcilindroradio";
            this.txtcilindroradio.Size = new System.Drawing.Size(132, 22);
            this.txtcilindroradio.TabIndex = 1;
            // 
            // lblradiocilindro
            // 
            this.lblradiocilindro.AutoSize = true;
            this.lblradiocilindro.Location = new System.Drawing.Point(89, 91);
            this.lblradiocilindro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblradiocilindro.Name = "lblradiocilindro";
            this.lblradiocilindro.Size = new System.Drawing.Size(126, 17);
            this.lblradiocilindro.TabIndex = 0;
            this.lblradiocilindro.Text = "Medida del Radio: ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.btnlimpiaresfera);
            this.tabPage3.Controls.Add(this.btncalcularesfera);
            this.tabPage3.Controls.Add(this.lblresultvolumenesfera);
            this.tabPage3.Controls.Add(this.lblvolumen);
            this.tabPage3.Controls.Add(this.lblresultareaesfera);
            this.tabPage3.Controls.Add(this.lblareaesfera);
            this.tabPage3.Controls.Add(this.txtesferaradio);
            this.tabPage3.Controls.Add(this.lblradioesfera);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1056, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Esfera";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Brayan_Hernandez__Figuras_.Properties.Resources.esfera;
            this.pictureBox3.Location = new System.Drawing.Point(579, 80);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(332, 272);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // btnlimpiaresfera
            // 
            this.btnlimpiaresfera.Location = new System.Drawing.Point(295, 324);
            this.btnlimpiaresfera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiaresfera.Name = "btnlimpiaresfera";
            this.btnlimpiaresfera.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiaresfera.TabIndex = 7;
            this.btnlimpiaresfera.Text = "Limpiar";
            this.btnlimpiaresfera.UseVisualStyleBackColor = true;
            this.btnlimpiaresfera.Click += new System.EventHandler(this.btnlimpiaresfera_Click);
            // 
            // btncalcularesfera
            // 
            this.btncalcularesfera.Location = new System.Drawing.Point(101, 325);
            this.btncalcularesfera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalcularesfera.Name = "btncalcularesfera";
            this.btncalcularesfera.Size = new System.Drawing.Size(100, 28);
            this.btncalcularesfera.TabIndex = 6;
            this.btncalcularesfera.Text = "Calcular";
            this.btncalcularesfera.UseVisualStyleBackColor = true;
            this.btncalcularesfera.Click += new System.EventHandler(this.btncalcularesfera_Click);
            // 
            // lblresultvolumenesfera
            // 
            this.lblresultvolumenesfera.AutoSize = true;
            this.lblresultvolumenesfera.Location = new System.Drawing.Point(299, 236);
            this.lblresultvolumenesfera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultvolumenesfera.Name = "lblresultvolumenesfera";
            this.lblresultvolumenesfera.Size = new System.Drawing.Size(46, 17);
            this.lblresultvolumenesfera.TabIndex = 5;
            this.lblresultvolumenesfera.Text = "label3";
            // 
            // lblvolumen
            // 
            this.lblvolumen.AutoSize = true;
            this.lblvolumen.Location = new System.Drawing.Point(101, 238);
            this.lblvolumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvolumen.Name = "lblvolumen";
            this.lblvolumen.Size = new System.Drawing.Size(71, 17);
            this.lblvolumen.TabIndex = 4;
            this.lblvolumen.Text = "Volumen: ";
            // 
            // lblresultareaesfera
            // 
            this.lblresultareaesfera.AutoSize = true;
            this.lblresultareaesfera.Location = new System.Drawing.Point(295, 171);
            this.lblresultareaesfera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultareaesfera.Name = "lblresultareaesfera";
            this.lblresultareaesfera.Size = new System.Drawing.Size(46, 17);
            this.lblresultareaesfera.TabIndex = 3;
            this.lblresultareaesfera.Text = "label1";
            // 
            // lblareaesfera
            // 
            this.lblareaesfera.AutoSize = true;
            this.lblareaesfera.CausesValidation = false;
            this.lblareaesfera.Location = new System.Drawing.Point(97, 159);
            this.lblareaesfera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblareaesfera.Name = "lblareaesfera";
            this.lblareaesfera.Size = new System.Drawing.Size(46, 17);
            this.lblareaesfera.TabIndex = 2;
            this.lblareaesfera.Text = "Area: ";
            // 
            // txtesferaradio
            // 
            this.txtesferaradio.Location = new System.Drawing.Point(295, 81);
            this.txtesferaradio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtesferaradio.Name = "txtesferaradio";
            this.txtesferaradio.Size = new System.Drawing.Size(132, 22);
            this.txtesferaradio.TabIndex = 1;
            // 
            // lblradioesfera
            // 
            this.lblradioesfera.AutoSize = true;
            this.lblradioesfera.Location = new System.Drawing.Point(97, 85);
            this.lblradioesfera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblradioesfera.Name = "lblradioesfera";
            this.lblradioesfera.Size = new System.Drawing.Size(126, 17);
            this.lblradioesfera.TabIndex = 0;
            this.lblradioesfera.Text = "Medida del Radio: ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(389, 48);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 459);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Figuras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblresultvolcubo;
        private System.Windows.Forms.Label lblresultareacubo;
        private System.Windows.Forms.Label lblvolumencubo;
        private System.Windows.Forms.Label lblareacubo;
        private System.Windows.Forms.TextBox txtcubo;
        private System.Windows.Forms.Label lblladocubo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnlimpiarcubo;
        private System.Windows.Forms.Button btncalcularcubo;
        private System.Windows.Forms.Label lblresultvolumencilindro;
        private System.Windows.Forms.Label lblresultareacilindro;
        private System.Windows.Forms.Label lblvolumencilindro;
        private System.Windows.Forms.Label lblcilindroarea;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.TextBox txtcilindroradio;
        private System.Windows.Forms.Label lblradiocilindro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnlimpiarcilindro;
        private System.Windows.Forms.Button btncalcularcilindro;
        private System.Windows.Forms.Button btnlimpiaresfera;
        private System.Windows.Forms.Button btncalcularesfera;
        private System.Windows.Forms.Label lblresultvolumenesfera;
        private System.Windows.Forms.Label lblvolumen;
        private System.Windows.Forms.Label lblresultareaesfera;
        private System.Windows.Forms.Label lblareaesfera;
        private System.Windows.Forms.TextBox txtesferaradio;
        private System.Windows.Forms.Label lblradioesfera;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

