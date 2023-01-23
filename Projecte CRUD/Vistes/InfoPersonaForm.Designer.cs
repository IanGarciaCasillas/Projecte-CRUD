namespace Projecte_CRUD.Vistes
{
    partial class InfoPersonaForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.txbNivell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAnsExperiencia = new System.Windows.Forms.TextBox();
            this.btnAddLlenguatge = new System.Windows.Forms.Button();
            this.txbLlenguatge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbLlenguatge = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbProfesion = new System.Windows.Forms.TextBox();
            this.chbDisponViatjar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEdat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.btnEliminarLeng = new System.Windows.Forms.Button();
            this.btnUpdatePerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nivell";
            // 
            // txbNivell
            // 
            this.txbNivell.Location = new System.Drawing.Point(74, 320);
            this.txbNivell.Name = "txbNivell";
            this.txbNivell.Size = new System.Drawing.Size(100, 23);
            this.txbNivell.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Anys d\'experiencia";
            // 
            // txbAnsExperiencia
            // 
            this.txbAnsExperiencia.Location = new System.Drawing.Point(141, 286);
            this.txbAnsExperiencia.Name = "txbAnsExperiencia";
            this.txbAnsExperiencia.Size = new System.Drawing.Size(100, 23);
            this.txbAnsExperiencia.TabIndex = 28;
            // 
            // btnAddLlenguatge
            // 
            this.btnAddLlenguatge.Location = new System.Drawing.Point(234, 144);
            this.btnAddLlenguatge.Name = "btnAddLlenguatge";
            this.btnAddLlenguatge.Size = new System.Drawing.Size(75, 23);
            this.btnAddLlenguatge.TabIndex = 27;
            this.btnAddLlenguatge.Text = "Afegir";
            this.btnAddLlenguatge.UseVisualStyleBackColor = true;
            this.btnAddLlenguatge.Click += new System.EventHandler(this.btnAddLlenguatge_Click);
            // 
            // txbLlenguatge
            // 
            this.txbLlenguatge.Location = new System.Drawing.Point(107, 141);
            this.txbLlenguatge.Name = "txbLlenguatge";
            this.txbLlenguatge.Size = new System.Drawing.Size(121, 23);
            this.txbLlenguatge.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Llenguatges";
            // 
            // lsbLlenguatge
            // 
            this.lsbLlenguatge.FormattingEnabled = true;
            this.lsbLlenguatge.ItemHeight = 15;
            this.lsbLlenguatge.Location = new System.Drawing.Point(30, 170);
            this.lsbLlenguatge.Name = "lsbLlenguatge";
            this.lsbLlenguatge.Size = new System.Drawing.Size(120, 109);
            this.lsbLlenguatge.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Profesion";
            // 
            // txbProfesion
            // 
            this.txbProfesion.Location = new System.Drawing.Point(95, 94);
            this.txbProfesion.Name = "txbProfesion";
            this.txbProfesion.Size = new System.Drawing.Size(100, 23);
            this.txbProfesion.TabIndex = 22;
            // 
            // chbDisponViatjar
            // 
            this.chbDisponViatjar.AutoSize = true;
            this.chbDisponViatjar.Location = new System.Drawing.Point(30, 376);
            this.chbDisponViatjar.Name = "chbDisponViatjar";
            this.chbDisponViatjar.Size = new System.Drawing.Size(151, 19);
            this.chbDisponViatjar.TabIndex = 21;
            this.chbDisponViatjar.Text = "Disponibilitat per viatjar";
            this.chbDisponViatjar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Edat";
            // 
            // txbEdat
            // 
            this.txbEdat.Location = new System.Drawing.Point(74, 58);
            this.txbEdat.Name = "txbEdat";
            this.txbEdat.Size = new System.Drawing.Size(100, 23);
            this.txbEdat.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nom";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(74, 20);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(100, 23);
            this.txbNom.TabIndex = 17;
            // 
            // btnEliminarLeng
            // 
            this.btnEliminarLeng.Location = new System.Drawing.Point(156, 257);
            this.btnEliminarLeng.Name = "btnEliminarLeng";
            this.btnEliminarLeng.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLeng.TabIndex = 32;
            this.btnEliminarLeng.Text = "Eliminar";
            this.btnEliminarLeng.UseVisualStyleBackColor = true;
            this.btnEliminarLeng.Click += new System.EventHandler(this.btnEliminarLeng_Click);
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.Location = new System.Drawing.Point(661, 384);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Size = new System.Drawing.Size(127, 54);
            this.btnUpdatePerson.TabIndex = 33;
            this.btnUpdatePerson.Text = "Actualitzar";
            this.btnUpdatePerson.UseVisualStyleBackColor = true;
            this.btnUpdatePerson.Click += new System.EventHandler(this.btnUpdatePerson_Click);
            // 
            // InfoPersonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdatePerson);
            this.Controls.Add(this.btnEliminarLeng);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbNivell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbAnsExperiencia);
            this.Controls.Add(this.btnAddLlenguatge);
            this.Controls.Add(this.txbLlenguatge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsbLlenguatge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbProfesion);
            this.Controls.Add(this.chbDisponViatjar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEdat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNom);
            this.Name = "InfoPersonaForm";
            this.Text = "InfoPersonaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private TextBox txbNivell;
        private Label label5;
        private TextBox txbAnsExperiencia;
        private Button btnAddLlenguatge;
        private TextBox txbLlenguatge;
        private Label label4;
        private ListBox lsbLlenguatge;
        private Label label2;
        private TextBox txbProfesion;
        private CheckBox chbDisponViatjar;
        private Label label3;
        private TextBox txbEdat;
        private Label label1;
        private TextBox txbNom;
        private Button btnEliminarLeng;
        private Button btnUpdatePerson;
    }
}