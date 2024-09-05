namespace Situação_de_Aprendizagem___CASA_VETERINÁRIA
{
    partial class Frm_InformaçõesAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InformaçõesAnimal));
            this.picSair = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCadastrarExames = new System.Windows.Forms.Button();
            this.dtInformaçõesAnimal = new System.Windows.Forms.DataGridView();
            this.colCodExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInformaçõesAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // picSair
            // 
            this.picSair.Image = ((System.Drawing.Image)(resources.GetObject("picSair.Image")));
            this.picSair.Location = new System.Drawing.Point(754, 12);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(34, 31);
            this.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSair.TabIndex = 146;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(62, 13);
            this.lblUser.TabIndex = 145;
            this.lblUser.Text = "Usuário:  ";
            // 
            // btnCadastrarExames
            // 
            this.btnCadastrarExames.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCadastrarExames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarExames.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarExames.Location = new System.Drawing.Point(305, 385);
            this.btnCadastrarExames.Name = "btnCadastrarExames";
            this.btnCadastrarExames.Size = new System.Drawing.Size(172, 44);
            this.btnCadastrarExames.TabIndex = 144;
            this.btnCadastrarExames.Text = "CADASTRAR EXAMES";
            this.btnCadastrarExames.UseVisualStyleBackColor = false;
            this.btnCadastrarExames.Click += new System.EventHandler(this.btnCadastrarExames_Click);
            // 
            // dtInformaçõesAnimal
            // 
            this.dtInformaçõesAnimal.AllowUserToAddRows = false;
            this.dtInformaçõesAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInformaçõesAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodExame,
            this.colNomeExame});
            this.dtInformaçõesAnimal.Location = new System.Drawing.Point(81, 79);
            this.dtInformaçõesAnimal.Name = "dtInformaçõesAnimal";
            this.dtInformaçõesAnimal.ReadOnly = true;
            this.dtInformaçõesAnimal.Size = new System.Drawing.Size(626, 283);
            this.dtInformaçõesAnimal.TabIndex = 143;
            // 
            // colCodExame
            // 
            this.colCodExame.HeaderText = "Código Exame";
            this.colCodExame.Name = "colCodExame";
            this.colCodExame.ReadOnly = true;
            // 
            // colNomeExame
            // 
            this.colNomeExame.HeaderText = "Nome Exame";
            this.colNomeExame.Name = "colNomeExame";
            this.colNomeExame.ReadOnly = true;
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Location = new System.Drawing.Point(81, 60);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(55, 13);
            this.lblNomeAnimal.TabIndex = 147;
            this.lblNomeAnimal.Text = "Paciente: ";
            // 
            // Frm_InformaçõesAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomeAnimal);
            this.Controls.Add(this.picSair);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCadastrarExames);
            this.Controls.Add(this.dtInformaçõesAnimal);
            this.Name = "Frm_InformaçõesAnimal";
            this.Text = "Principal Do Veterinário";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_InformaçõesAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInformaçõesAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCadastrarExames;
        private System.Windows.Forms.DataGridView dtInformaçõesAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeExame;
        private System.Windows.Forms.Label lblNomeAnimal;
    }
}