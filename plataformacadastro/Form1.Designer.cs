namespace plataformacadastro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxProduto = new System.Windows.Forms.PictureBox();
            this.pictureBoxCliente = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProduto
            // 
            this.pictureBoxProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProduto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProduto.Image")));
            this.pictureBoxProduto.Location = new System.Drawing.Point(321, 117);
            this.pictureBoxProduto.Name = "pictureBoxProduto";
            this.pictureBoxProduto.Size = new System.Drawing.Size(100, 98);
            this.pictureBoxProduto.TabIndex = 0;
            this.pictureBoxProduto.TabStop = false;
            this.pictureBoxProduto.Click += new System.EventHandler(this.pictureBoxProduto_Click);
            // 
            // pictureBoxCliente
            // 
            this.pictureBoxCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCliente.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCliente.Image")));
            this.pictureBoxCliente.Location = new System.Drawing.Point(106, 117);
            this.pictureBoxCliente.Name = "pictureBoxCliente";
            this.pictureBoxCliente.Size = new System.Drawing.Size(97, 92);
            this.pictureBoxCliente.TabIndex = 1;
            this.pictureBoxCliente.TabStop = false;
            this.pictureBoxCliente.Click += new System.EventHandler(this.pictureBoxCliente_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "BEM-VINDO";
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.Location = new System.Drawing.Point(81, 249);
            this.buttonCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(145, 49);
            this.buttonCliente.TabIndex = 3;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonProduto
            // 
            this.buttonProduto.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduto.Location = new System.Drawing.Point(300, 249);
            this.buttonProduto.Name = "buttonProduto";
            this.buttonProduto.Size = new System.Drawing.Size(145, 49);
            this.buttonProduto.TabIndex = 4;
            this.buttonProduto.Text = "Produto";
            this.buttonProduto.UseVisualStyleBackColor = false;
            this.buttonProduto.Click += new System.EventHandler(this.buttonProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(506, 404);
            this.Controls.Add(this.buttonProduto);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCliente);
            this.Controls.Add(this.pictureBoxProduto);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProduto;
        private System.Windows.Forms.PictureBox pictureBoxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonProduto;
    }
}

