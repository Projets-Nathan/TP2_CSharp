namespace TP2
{
    partial class FVisionneuse_Image
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Stretch1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Afficher1 = new System.Windows.Forms.Button();
            this.Effacer1 = new System.Windows.Forms.Button();
            this.ArrierePlan1 = new System.Windows.Forms.Button();
            this.Fermer1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Stretch1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(882, 399);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Stretch1
            // 
            this.Stretch1.AutoSize = true;
            this.Stretch1.Location = new System.Drawing.Point(3, 408);
            this.Stretch1.Name = "Stretch1";
            this.Stretch1.Size = new System.Drawing.Size(70, 20);
            this.Stretch1.TabIndex = 1;
            this.Stretch1.Text = "Stretch";
            this.Stretch1.UseVisualStyleBackColor = true;
            this.Stretch1.CheckedChanged += new System.EventHandler(this.Stretch1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Afficher1);
            this.flowLayoutPanel1.Controls.Add(this.Effacer1);
            this.flowLayoutPanel1.Controls.Add(this.ArrierePlan1);
            this.flowLayoutPanel1.Controls.Add(this.Fermer1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(136, 408);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(749, 39);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Afficher1
            // 
            this.Afficher1.AutoSize = true;
            this.Afficher1.Location = new System.Drawing.Point(590, 3);
            this.Afficher1.Name = "Afficher1";
            this.Afficher1.Size = new System.Drawing.Size(156, 26);
            this.Afficher1.TabIndex = 0;
            this.Afficher1.Text = "Afficher une image";
            this.Afficher1.UseVisualStyleBackColor = true;
            this.Afficher1.Click += new System.EventHandler(this.Afficher1_Click);
            // 
            // Effacer1
            // 
            this.Effacer1.AutoSize = true;
            this.Effacer1.Location = new System.Drawing.Point(428, 3);
            this.Effacer1.Name = "Effacer1";
            this.Effacer1.Size = new System.Drawing.Size(156, 26);
            this.Effacer1.TabIndex = 1;
            this.Effacer1.Text = "Effacer une image";
            this.Effacer1.UseVisualStyleBackColor = true;
            this.Effacer1.Click += new System.EventHandler(this.Effacer1_Click);
            // 
            // ArrierePlan1
            // 
            this.ArrierePlan1.AutoSize = true;
            this.ArrierePlan1.Location = new System.Drawing.Point(266, 3);
            this.ArrierePlan1.Name = "ArrierePlan1";
            this.ArrierePlan1.Size = new System.Drawing.Size(156, 26);
            this.ArrierePlan1.TabIndex = 2;
            this.ArrierePlan1.Text = "Définir l\'arrière plan";
            this.ArrierePlan1.UseVisualStyleBackColor = true;
            this.ArrierePlan1.Click += new System.EventHandler(this.ArrierePlan1_Click);
            // 
            // Fermer1
            // 
            this.Fermer1.AutoSize = true;
            this.Fermer1.Location = new System.Drawing.Point(113, 3);
            this.Fermer1.Name = "Fermer1";
            this.Fermer1.Size = new System.Drawing.Size(147, 26);
            this.Fermer1.TabIndex = 3;
            this.Fermer1.Text = "Fermer";
            this.Fermer1.UseVisualStyleBackColor = true;
            this.Fermer1.Click += new System.EventHandler(this.Fermer1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Sélectionner un fichier image";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FVisionneuse_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FVisionneuse_Image";
            this.Text = "Visioneuse d\'image";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Stretch1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Afficher1;
        private System.Windows.Forms.Button Effacer1;
        private System.Windows.Forms.Button ArrierePlan1;
        private System.Windows.Forms.Button Fermer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

