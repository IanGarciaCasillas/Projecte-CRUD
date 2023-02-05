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
            this.lstPersonesArray = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLlegirPersonaArray = new System.Windows.Forms.Button();
            this.btnCrearPersonaArray = new System.Windows.Forms.Button();
            this.btnEliminarPersonaArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPersones
            // 
            this.lstPersones.FormattingEnabled = true;
            this.lstPersones.ItemHeight = 15;
            this.lstPersones.Location = new System.Drawing.Point(12, 31);
            this.lstPersones.Name = "lstPersones";
            this.lstPersones.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPersones.Size = new System.Drawing.Size(228, 334);
            this.lstPersones.TabIndex = 1;
            this.lstPersones.SelectedIndexChanged += new System.EventHandler(this.lstPersones_SelectedIndexChanged);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(255, 42);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(97, 36);
            this.btnElimina.TabIndex = 3;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnNovaPersona
            // 
            this.btnNovaPersona.Location = new System.Drawing.Point(255, 329);
            this.btnNovaPersona.Name = "btnNovaPersona";
            this.btnNovaPersona.Size = new System.Drawing.Size(97, 36);
            this.btnNovaPersona.TabIndex = 4;
            this.btnNovaPersona.Text = "Crear nou";
            this.btnNovaPersona.UseVisualStyleBackColor = true;
            this.btnNovaPersona.Click += new System.EventHandler(this.btnNovaPersona_Click);
            // 
            // btnLlegir
            // 
            this.btnLlegir.Location = new System.Drawing.Point(255, 103);
            this.btnLlegir.Name = "btnLlegir";
            this.btnLlegir.Size = new System.Drawing.Size(97, 36);
            this.btnLlegir.TabIndex = 5;
            this.btnLlegir.Text = "Llegir i editar";
            this.btnLlegir.UseVisualStyleBackColor = true;
            this.btnLlegir.Click += new System.EventHandler(this.btnLlegir_Click);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(23, 371);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(97, 36);
            this.btnActualitzar.TabIndex = 7;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // lstPersonesArray
            // 
            this.lstPersonesArray.FormattingEnabled = true;
            this.lstPersonesArray.ItemHeight = 15;
            this.lstPersonesArray.Location = new System.Drawing.Point(402, 31);
            this.lstPersonesArray.Name = "lstPersonesArray";
            this.lstPersonesArray.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPersonesArray.Size = new System.Drawing.Size(228, 334);
            this.lstPersonesArray.TabIndex = 8;
            this.lstPersonesArray.SelectedIndexChanged += new System.EventHandler(this.lstPersonesArray_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "PERSONES OBJECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "PERSONES ARRAY";
            // 
            // btnLlegirPersonaArray
            // 
            this.btnLlegirPersonaArray.Location = new System.Drawing.Point(653, 103);
            this.btnLlegirPersonaArray.Name = "btnLlegirPersonaArray";
            this.btnLlegirPersonaArray.Size = new System.Drawing.Size(97, 36);
            this.btnLlegirPersonaArray.TabIndex = 16;
            this.btnLlegirPersonaArray.Text = "Llegir i editar";
            this.btnLlegirPersonaArray.UseVisualStyleBackColor = true;
            this.btnLlegirPersonaArray.Click += new System.EventHandler(this.btnLlegirPersonaArray_Click);
            // 
            // btnCrearPersonaArray
            // 
            this.btnCrearPersonaArray.Location = new System.Drawing.Point(653, 329);
            this.btnCrearPersonaArray.Name = "btnCrearPersonaArray";
            this.btnCrearPersonaArray.Size = new System.Drawing.Size(97, 36);
            this.btnCrearPersonaArray.TabIndex = 15;
            this.btnCrearPersonaArray.Text = "Crear nou";
            this.btnCrearPersonaArray.UseVisualStyleBackColor = true;
            this.btnCrearPersonaArray.Click += new System.EventHandler(this.btnCrearPersonaArray_Click);
            // 
            // btnEliminarPersonaArray
            // 
            this.btnEliminarPersonaArray.Location = new System.Drawing.Point(653, 42);
            this.btnEliminarPersonaArray.Name = "btnEliminarPersonaArray";
            this.btnEliminarPersonaArray.Size = new System.Drawing.Size(97, 36);
            this.btnEliminarPersonaArray.TabIndex = 14;
            this.btnEliminarPersonaArray.Text = "Elimina";
            this.btnEliminarPersonaArray.UseVisualStyleBackColor = true;
            this.btnEliminarPersonaArray.Click += new System.EventHandler(this.btnEliminarPersonaArray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLlegirPersonaArray);
            this.Controls.Add(this.btnCrearPersonaArray);
            this.Controls.Add(this.btnEliminarPersonaArray);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPersonesArray);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.btnLlegir);
            this.Controls.Add(this.btnNovaPersona);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.lstPersones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lstPersones;
        private Button btnElimina;
        private Button btnNovaPersona;
        private Button btnLlegir;
        private Button btnActualitzar;
        private ListBox lstPersonesArray;
        private Label label1;
        private Label label2;
        private Button btnLlegirPersonaArray;
        private Button btnCrearPersonaArray;
        private Button btnEliminarPersonaArray;
    }
}