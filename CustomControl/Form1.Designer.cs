
namespace CustomControl
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
            this.sliderControl2 = new CustomControl.SliderControl();
            this.sliderControl1 = new CustomControl.SliderControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sliderControl2
            // 
            this.sliderControl2.Location = new System.Drawing.Point(363, 149);
            this.sliderControl2.Name = "sliderControl2";
            this.sliderControl2.Size = new System.Drawing.Size(103, 152);
            this.sliderControl2.TabIndex = 1;
            this.sliderControl2.Text = "sliderControl2";
            this.sliderControl2.MouseValueClick += new System.EventHandler(this.sliderControl2_MouseValueClick);
            // 
            // sliderControl1
            // 
            this.sliderControl1.Location = new System.Drawing.Point(68, 65);
            this.sliderControl1.Name = "sliderControl1";
            this.sliderControl1.Size = new System.Drawing.Size(75, 152);
            this.sliderControl1.TabIndex = 0;
            this.sliderControl1.Text = "sliderControl1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sliderControl2);
            this.Controls.Add(this.sliderControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SliderControl sliderControl1;
        private SliderControl sliderControl2;
        private System.Windows.Forms.Label label1;
    }
}

