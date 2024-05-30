namespace HotelManagementSystem
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
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsobre = new System.Windows.Forms.Label();
            this.lbldoc = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnregistrarHospede = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFazerReserva = new System.Windows.Forms.Button();
            this.btnListarReservas = new System.Windows.Forms.Button();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.txtDocumentoHospede = new System.Windows.Forms.TextBox();
            this.txtNumeroQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnquarto = new System.Windows.Forms.Label();
            this.NomeColuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToOrderColumns = true;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeColuna,
            this.Sobre,
            this.Telefone,
            this.Email});
            this.dgvReservas.Location = new System.Drawing.Point(1133, 15);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.Size = new System.Drawing.Size(541, 185);
            this.dgvReservas.TabIndex = 1;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(579, 74);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(579, 139);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(372, 22);
            this.txtSobrenome.TabIndex = 3;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(579, 193);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(372, 22);
            this.txtDocumento.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(579, 250);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(372, 22);
            this.txtTelefone.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(579, 313);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(372, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(524, 82);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(44, 16);
            this.lblnome.TabIndex = 7;
            this.lblnome.Text = "Nome";
            // 
            // lblsobre
            // 
            this.lblsobre.AutoSize = true;
            this.lblsobre.Location = new System.Drawing.Point(524, 143);
            this.lblsobre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsobre.Name = "lblsobre";
            this.lblsobre.Size = new System.Drawing.Size(44, 16);
            this.lblsobre.TabIndex = 8;
            this.lblsobre.Text = "Sobre";
            // 
            // lbldoc
            // 
            this.lbldoc.AutoSize = true;
            this.lbldoc.Location = new System.Drawing.Point(460, 202);
            this.lbldoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldoc.Name = "lbldoc";
            this.lbldoc.Size = new System.Drawing.Size(102, 16);
            this.lbldoc.TabIndex = 9;
            this.lbldoc.Text = "Doc. Identidade";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(505, 254);
            this.lbltel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(61, 16);
            this.lbltel.TabIndex = 10;
            this.lbltel.Text = "Telefone";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(505, 321);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(45, 16);
            this.lblemail.TabIndex = 11;
            this.lblemail.Text = "E-mail";
            // 
            // btnregistrarHospede
            // 
            this.btnregistrarHospede.Location = new System.Drawing.Point(712, 375);
            this.btnregistrarHospede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnregistrarHospede.Name = "btnregistrarHospede";
            this.btnregistrarHospede.Size = new System.Drawing.Size(124, 28);
            this.btnregistrarHospede.TabIndex = 12;
            this.btnregistrarHospede.Text = "Registrar";
            this.btnregistrarHospede.UseVisualStyleBackColor = true;
            this.btnregistrarHospede.Click += new System.EventHandler(this.btnregistrarHospede_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.Location = new System.Drawing.Point(41, 50);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.Highlight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "REGISTRO";
            // 
            // btnFazerReserva
            // 
            this.btnFazerReserva.Location = new System.Drawing.Point(1499, 533);
            this.btnFazerReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFazerReserva.Name = "btnFazerReserva";
            this.btnFazerReserva.Size = new System.Drawing.Size(124, 28);
            this.btnFazerReserva.TabIndex = 14;
            this.btnFazerReserva.Text = "Reserva";
            this.btnFazerReserva.UseVisualStyleBackColor = true;
            this.btnFazerReserva.Click += new System.EventHandler(this.btnFazerReserva_Click_1);
            // 
            // btnListarReservas
            // 
            this.btnListarReservas.Location = new System.Drawing.Point(1259, 226);
            this.btnListarReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarReservas.Name = "btnListarReservas";
            this.btnListarReservas.Size = new System.Drawing.Size(124, 28);
            this.btnListarReservas.TabIndex = 15;
            this.btnListarReservas.Text = "Listar Reservas";
            this.btnListarReservas.UseVisualStyleBackColor = true;
            this.btnListarReservas.Click += new System.EventHandler(this.btnListarReservas_Click_1);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(1437, 225);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(265, 22);
            this.dtpCheckIn.TabIndex = 16;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(1437, 272);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(265, 22);
            this.dtpCheckOut.TabIndex = 17;
            // 
            // txtDocumentoHospede
            // 
            this.txtDocumentoHospede.Location = new System.Drawing.Point(1499, 425);
            this.txtDocumentoHospede.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumentoHospede.Name = "txtDocumentoHospede";
            this.txtDocumentoHospede.Size = new System.Drawing.Size(132, 22);
            this.txtDocumentoHospede.TabIndex = 18;
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Location = new System.Drawing.Point(1499, 479);
            this.txtNumeroQuarto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new System.Drawing.Size(132, 22);
            this.txtNumeroQuarto.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1369, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "documento valido";
            // 
            // lblnquarto
            // 
            this.lblnquarto.AutoSize = true;
            this.lblnquarto.Location = new System.Drawing.Point(1399, 479);
            this.lblnquarto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnquarto.Name = "lblnquarto";
            this.lblnquarto.Size = new System.Drawing.Size(84, 16);
            this.lblnquarto.TabIndex = 21;
            this.lblnquarto.Text = "Nº do Quarto";
            // 
            // NomeColuna
            // 
            this.NomeColuna.DataPropertyName = "NomeData";
            this.NomeColuna.HeaderText = "Nome";
            this.NomeColuna.MinimumWidth = 6;
            this.NomeColuna.Name = "NomeColuna";
            this.NomeColuna.ReadOnly = true;
            this.NomeColuna.Width = 125;
            // 
            // Sobre
            // 
            this.Sobre.HeaderText = "Sobre";
            this.Sobre.MinimumWidth = 6;
            this.Sobre.Name = "Sobre";
            this.Sobre.ReadOnly = true;
            this.Sobre.Width = 125;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MinimumWidth = 6;
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 804);
            this.Controls.Add(this.lblnquarto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.txtDocumentoHospede);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.btnListarReservas);
            this.Controls.Add(this.btnFazerReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnregistrarHospede);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lbldoc);
            this.Controls.Add(this.lblsobre);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvReservas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsobre;
        private System.Windows.Forms.Label lbldoc;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnregistrarHospede;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFazerReserva;
        private System.Windows.Forms.Button btnListarReservas;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.TextBox txtDocumentoHospede;
        private System.Windows.Forms.TextBox txtNumeroQuarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnquarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

