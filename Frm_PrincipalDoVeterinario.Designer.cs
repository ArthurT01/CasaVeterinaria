namespace Situação_de_Aprendizagem___CASA_VETERINÁRIA
{
    partial class Frm_PrincipalDoVeterinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PrincipalDoVeterinario));
            this.dtListaPacientes = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExames = new System.Windows.Forms.DataGridViewImageColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCadastrarAnimal = new System.Windows.Forms.Button();
            this.picSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListaPacientes
            // 
            this.dtListaPacientes.AllowUserToAddRows = false;
            this.dtListaPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dtListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome,
            this.colExames,
            this.colExcluir});
            this.dtListaPacientes.Location = new System.Drawing.Point(57, 56);
            this.dtListaPacientes.Name = "dtListaPacientes";
            this.dtListaPacientes.ReadOnly = true;
            this.dtListaPacientes.Size = new System.Drawing.Size(688, 321);
            this.dtListaPacientes.TabIndex = 0;
            this.dtListaPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListaPacientes_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colExames
            // 
            this.colExames.HeaderText = "Exames";
            this.colExames.Image = ((System.Drawing.Image)(resources.GetObject("colExames.Image")));
            this.colExames.Name = "colExames";
            this.colExames.ReadOnly = true;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.Image = ((System.Drawing.Image)(resources.GetObject("colExcluir.Image")));
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(13, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(62, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuário:  ";
            // 
            // btnCadastrarAnimal
            // 
            this.btnCadastrarAnimal.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCadastrarAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAnimal.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarAnimal.Location = new System.Drawing.Point(321, 398);
            this.btnCadastrarAnimal.Name = "btnCadastrarAnimal";
            this.btnCadastrarAnimal.Size = new System.Drawing.Size(171, 40);
            this.btnCadastrarAnimal.TabIndex = 2;
            this.btnCadastrarAnimal.Text = "CADASTRAR ANIMAL";
            this.btnCadastrarAnimal.UseVisualStyleBackColor = false;
            this.btnCadastrarAnimal.Click += new System.EventHandler(this.btnCadastrarAnimal_Click);
            // 
            // picSair
            // 
            this.picSair.Image = ((System.Drawing.Image)(resources.GetObject("picSair.Image")));
            this.picSair.Location = new System.Drawing.Point(754, 12);
            this.picSair.Name = "picSair";
            this.picSair.Size = new System.Drawing.Size(34, 31);
            this.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSair.TabIndex = 140;
            this.picSair.TabStop = false;
            this.picSair.Click += new System.EventHandler(this.picSair_Click);
            // 
            // Frm_PrincipalDoVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picSair);
            this.Controls.Add(this.btnCadastrarAnimal);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dtListaPacientes);
            this.Name = "Frm_PrincipalDoVeterinario";
            this.Text = "Principal do Veterinário";
            ((System.ComponentModel.ISupportInitialize)(this.dtListaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListaPacientes;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCadastrarAnimal;
        private System.Windows.Forms.PictureBox picSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewImageColumn colExames;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
    }
}