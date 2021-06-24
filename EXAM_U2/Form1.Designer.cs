namespace EXAM_U2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTLAST = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNINSERT = new System.Windows.Forms.Button();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(12, 52);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(47, 22);
            this.TXTID.TabIndex = 1;
            // 
            // TXTNAME
            // 
            this.TXTNAME.Location = new System.Drawing.Point(86, 52);
            this.TXTNAME.Name = "TXTNAME";
            this.TXTNAME.Size = new System.Drawing.Size(154, 22);
            this.TXTNAME.TabIndex = 3;
            this.TXTNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNAME_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAME";
            // 
            // TXTLAST
            // 
            this.TXTLAST.Location = new System.Drawing.Point(266, 52);
            this.TXTLAST.Name = "TXTLAST";
            this.TXTLAST.Size = new System.Drawing.Size(196, 22);
            this.TXTLAST.TabIndex = 5;
            this.TXTLAST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTLAST_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "LASTNAME";
            // 
            // BTNINSERT
            // 
            this.BTNINSERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINSERT.Location = new System.Drawing.Point(477, 18);
            this.BTNINSERT.Name = "BTNINSERT";
            this.BTNINSERT.Size = new System.Drawing.Size(148, 79);
            this.BTNINSERT.TabIndex = 6;
            this.BTNINSERT.Text = "INSERT";
            this.BTNINSERT.UseVisualStyleBackColor = true;
            this.BTNINSERT.Click += new System.EventHandler(this.BTNINSERT_Click);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUPDATE.Location = new System.Drawing.Point(642, 18);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(188, 79);
            this.BTNUPDATE.TabIndex = 7;
            this.BTNUPDATE.Text = "UPDATE";
            this.BTNUPDATE.UseVisualStyleBackColor = true;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 313);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNUPDATE);
            this.Controls.Add(this.BTNINSERT);
            this.Controls.Add(this.TXTLAST);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.TextBox TXTNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTLAST;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNINSERT;
        private System.Windows.Forms.Button BTNUPDATE;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

