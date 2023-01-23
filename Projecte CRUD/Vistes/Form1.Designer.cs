namespace Projecte_CRUD
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
            this.lstPersones = new System.Windows.Forms.ListBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnNovaPersona = new System.Windows.Forms.Button();
            this.btnLlegir = new System.Windows.Forms.Button();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPersones
            // 
            this.lstPersones.FormattingEnabled = true;
            this.lstPersones.ItemHeight = 15;
            this.lstPersones.Location = new System.Drawing.Point(1, 1);
            this.lstPersones.Name = "lstPersones";
            this.lstPersones.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPersones.Size = new System.Drawing.Size(336, 334);
            this.lstPersones.TabIndex = 1;
            this.lstPersones.SelectedIndexChanged += new System.EventHandler(this.lstPersones_SelectedIndexChanged);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(356, 12);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(97, 36);
            this.btnElimina.TabIndex = 3;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnNovaPersona
            // 
            this.btnNovaPersona.Location = new System.Drawing.Point(356, 299);
            this.btnNovaPersona.Name = "btnNovaPersona";
            this.btnNovaPersona.Size = new System.Drawing.Size(97, 36);
            this.btnNovaPersona.TabIndex = 4;
            this.btnNovaPersona.Text = "Crear nou";
            this.btnNovaPersona.UseVisualStyleBackColor = true;
            this.btnNovaPersona.Click += new System.EventHandler(this.btnNovaPersona_Click);
            // 
            // btnLlegir
            // 
            this.btnLlegir.Location = new System.Drawing.Point(356, 80);
            this.btnLlegir.Name = "btnLlegir";
            this.btnLlegir.Size = new System.Drawing.Size(97, 36);
            this.btnLlegir.TabIndex = 5;
            this.btnLlegir.Text = "Llegir i editar";
            this.btnLlegir.UseVisualStyleBackColor = true;
            this.btnLlegir.Click += new System.EventHandler(this.btnLlegir_Click);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(12, 341);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(97, 36);
            this.btnActualitzar.TabIndex = 7;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.btnLlegir);
            this.Controls.Add(this.btnNovaPersona);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.lstPersones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox lstPersones;
        private Button btnElimina;
        private Button btnNovaPersona;
        private Button btnLlegir;
        private Button btnActualitzar;
    }
}