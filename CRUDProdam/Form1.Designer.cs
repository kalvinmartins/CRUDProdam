namespace CRUDProdam
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.ViewClientes = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnimg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AccessibleName = "nome";
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(38, 87);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // CPF
            // 
            this.CPF.AccessibleName = "cpf";
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(38, 176);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(27, 13);
            this.CPF.TabIndex = 2;
            this.CPF.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(104, 131);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 4;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(104, 176);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 5;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            // 
            // Tel
            // 
            this.Tel.AccessibleName = "tel";
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(38, 131);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(49, 13);
            this.Tel.TabIndex = 6;
            this.Tel.Text = "Telefone";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "btnadd";
            this.btnAdd.Location = new System.Drawing.Point(41, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUp
            // 
            this.btnUp.AccessibleName = "btnUpdate";
            this.btnUp.Location = new System.Drawing.Point(129, 224);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "Editar ";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDel
            // 
            this.btnDel.AccessibleName = "btndel";
            this.btnDel.Location = new System.Drawing.Point(228, 224);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Deletar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCan
            // 
            this.btnCan.AccessibleName = "btncancel";
            this.btnCan.Location = new System.Drawing.Point(41, 253);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(262, 23);
            this.btnCan.TabIndex = 10;
            this.btnCan.Text = "Cancelar operação";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // ViewClientes
            // 
            this.ViewClientes.AccessibleName = "";
            this.ViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewClientes.Location = new System.Drawing.Point(343, 87);
            this.ViewClientes.Name = "ViewClientes";
            this.ViewClientes.Size = new System.Drawing.Size(443, 189);
            this.ViewClientes.TabIndex = 11;
            this.ViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblID
            // 
            this.lblID.AccessibleName = "nome";
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(340, 59);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AccessibleName = "tel";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "OBS:  Em caso de duvida consultar o Print a seguir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnimg
            // 
            this.btnimg.AccessibleName = "btnadd";
            this.btnimg.Location = new System.Drawing.Point(306, 322);
            this.btnimg.Name = "btnimg";
            this.btnimg.Size = new System.Drawing.Size(75, 23);
            this.btnimg.TabIndex = 14;
            this.btnimg.Text = "Clique aqui";
            this.btnimg.UseVisualStyleBackColor = true;
            this.btnimg.Click += new System.EventHandler(this.btnimg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.btnimg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.ViewClientes);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.DataGridView ViewClientes;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnimg;
    }
}

