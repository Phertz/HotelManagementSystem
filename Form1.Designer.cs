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
            this.Coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToOrderColumns = true;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna1,
            this.Coluna2,
            this.Coluna3,
            this.Coluna4});
            this.dgvReservas.Location = new System.Drawing.Point(850, 12);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(406, 150);
            this.dgvReservas.TabIndex = 1;
            // 
            // Coluna1
            // 
            this.Coluna1.HeaderText = "Column1";
            this.Coluna1.Name = "Coluna1";
            this.Coluna1.ReadOnly = true;
            // 
            // Coluna2
            // 
            this.Coluna2.HeaderText = "Column1";
            this.Coluna2.Name = "Coluna2";
            this.Coluna2.ReadOnly = true;
            // 
            // Coluna3
            // 
            this.Coluna3.HeaderText = "Column1";
            this.Coluna3.Name = "Coluna3";
            this.Coluna3.ReadOnly = true;
            // 
            // Coluna4
            // 
            this.Coluna4.HeaderText = "Column1";
            this.Coluna4.Name = "Coluna4";
            this.Coluna4.ReadOnly = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(434, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(434, 113);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(280, 20);
            this.txtSobrenome.TabIndex = 3;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(434, 157);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(280, 20);
            this.txtDocumento.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(434, 203);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(280, 20);
            this.txtTelefone.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(434, 254);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(393, 67);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 7;
            this.lblnome.Text = "Nome";
            // 
            // lblsobre
            // 
            this.lblsobre.AutoSize = true;
            this.lblsobre.Location = new System.Drawing.Point(393, 116);
            this.lblsobre.Name = "lblsobre";
            this.lblsobre.Size = new System.Drawing.Size(35, 13);
            this.lblsobre.TabIndex = 8;
            this.lblsobre.Text = "Sobre";
            // 
            // lbldoc
            // 
            this.lbldoc.AutoSize = true;
            this.lbldoc.Location = new System.Drawing.Point(345, 164);
            this.lbldoc.Name = "lbldoc";
            this.lbldoc.Size = new System.Drawing.Size(83, 13);
            this.lbldoc.TabIndex = 9;
            this.lbldoc.Text = "Doc. Identidade";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(379, 206);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(49, 13);
            this.lbltel.TabIndex = 10;
            this.lbltel.Text = "Telefone";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(379, 261);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 11;
            this.lblemail.Text = "E-mail";
            // 
            // btnregistrarHospede
            // 
            this.btnregistrarHospede.Location = new System.Drawing.Point(534, 305);
            this.btnregistrarHospede.Name = "btnregistrarHospede";
            this.btnregistrarHospede.Size = new System.Drawing.Size(93, 23);
            this.btnregistrarHospede.TabIndex = 12;
            this.btnregistrarHospede.Text = "Registrar";
            this.btnregistrarHospede.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.Location = new System.Drawing.Point(31, 41);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.Highlight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "REGISTRO";
            // 
            // btnFazerReserva
            // 
            this.btnFazerReserva.Location = new System.Drawing.Point(1124, 278);
            this.btnFazerReserva.Name = "btnFazerReserva";
            this.btnFazerReserva.Size = new System.Drawing.Size(93, 23);
            this.btnFazerReserva.TabIndex = 14;
            this.btnFazerReserva.Text = "Reserva";
            this.btnFazerReserva.UseVisualStyleBackColor = true;
            // 
            // btnListarReservas
            // 
            this.btnListarReservas.Location = new System.Drawing.Point(944, 184);
            this.btnListarReservas.Name = "btnListarReservas";
            this.btnListarReservas.Size = new System.Drawing.Size(93, 23);
            this.btnListarReservas.TabIndex = 15;
            this.btnListarReservas.Text = "Listar Reservas";
            this.btnListarReservas.UseVisualStyleBackColor = true;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(1078, 183);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 16;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(1078, 221);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 17;
            // 
            // txtDocumentoHospede
            // 
            this.txtDocumentoHospede.Location = new System.Drawing.Point(1124, 345);
            this.txtDocumentoHospede.Name = "txtDocumentoHospede";
            this.txtDocumentoHospede.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentoHospede.TabIndex = 18;
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Location = new System.Drawing.Point(1124, 389);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroQuarto.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1027, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "documento valido";
            // 
            // lblnquarto
            // 
            this.lblnquarto.AutoSize = true;
            this.lblnquarto.Location = new System.Drawing.Point(1049, 389);
            this.lblnquarto.Name = "lblnquarto";
            this.lblnquarto.Size = new System.Drawing.Size(69, 13);
            this.lblnquarto.TabIndex = 21;
            this.lblnquarto.Text = "Nº do Quarto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 653);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna4;
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
    }
}

