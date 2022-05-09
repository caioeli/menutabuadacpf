
namespace menutabuadacpf.cpf
{
    partial class TelaCPF
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelcpf = new System.Windows.Forms.Label();
            this.textBoxcpf = new System.Windows.Forms.TextBox();
            this.labelvalidador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verifique se seu CPF é Válido";
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Font = new System.Drawing.Font("Swis721 Cn BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelcpf.Location = new System.Drawing.Point(12, 146);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(43, 19);
            this.labelcpf.TabIndex = 1;
            this.labelcpf.Text = "CPF :";
            // 
            // textBoxcpf
            // 
            this.textBoxcpf.Location = new System.Drawing.Point(61, 146);
            this.textBoxcpf.Name = "textBoxcpf";
            this.textBoxcpf.Size = new System.Drawing.Size(210, 23);
            this.textBoxcpf.TabIndex = 2;
            // 
            // labelvalidador
            // 
            this.labelvalidador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelvalidador.Location = new System.Drawing.Point(26, 209);
            this.labelvalidador.Name = "labelvalidador";
            this.labelvalidador.Size = new System.Drawing.Size(341, 133);
            this.labelvalidador.TabIndex = 4;
            this.labelvalidador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaCPF
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(403, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelvalidador);
            this.Controls.Add(this.textBoxcpf);
            this.Controls.Add(this.labelcpf);
            this.Controls.Add(this.label1);
            this.Name = "TelaCPF";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validador de  CPF";
            this.Load += new System.EventHandler(this.TelaCPF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelcpf;
        private System.Windows.Forms.TextBox textBoxcpf;
        private System.Windows.Forms.Label labelvalidador;
        private System.Windows.Forms.Button button1;
    }
}