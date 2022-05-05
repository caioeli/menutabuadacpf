
namespace menutabuadacpf.View.tabusada
{
    partial class TelaTabuada
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
            this.labeltit = new System.Windows.Forms.Label();
            this.textBoxnum = new System.Windows.Forms.TextBox();
            this.listBoxresult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labeltit
            // 
            this.labeltit.AutoSize = true;
            this.labeltit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeltit.Location = new System.Drawing.Point(50, 58);
            this.labeltit.Name = "labeltit";
            this.labeltit.Size = new System.Drawing.Size(229, 32);
            this.labeltit.TabIndex = 0;
            this.labeltit.Text = "Calcular a Tabuada";
            // 
            // textBoxnum
            // 
            this.textBoxnum.Location = new System.Drawing.Point(133, 132);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.Size = new System.Drawing.Size(50, 23);
            this.textBoxnum.TabIndex = 1;
            this.textBoxnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxnum_KeyPress);
            // 
            // listBoxresult
            // 
            this.listBoxresult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxresult.FormattingEnabled = true;
            this.listBoxresult.ItemHeight = 30;
            this.listBoxresult.Location = new System.Drawing.Point(70, 182);
            this.listBoxresult.Name = "listBoxresult";
            this.listBoxresult.Size = new System.Drawing.Size(190, 214);
            this.listBoxresult.TabIndex = 2;
            this.listBoxresult.UseWaitCursor = true;
            this.listBoxresult.SelectedIndexChanged += new System.EventHandler(this.listBoxresult_SelectedIndexChanged);
            // 
            // TelaTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.listBoxresult);
            this.Controls.Add(this.textBoxnum);
            this.Controls.Add(this.labeltit);
            this.KeyPreview = true;
            this.Name = "TelaTabuada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltit;
        private System.Windows.Forms.TextBox textBoxnum;
        private System.Windows.Forms.ListBox listBoxresult;
    }
}