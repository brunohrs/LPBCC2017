namespace Locacao
{
    partial class frmLocacao
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvLocacao = new System.Windows.Forms.DataGridView();
            this.btnInsLoc = new System.Windows.Forms.Button();
            this.btnUpdLoc = new System.Windows.Forms.Button();
            this.btnDelLoc = new System.Windows.Forms.Button();
            this.btnSaveLoc = new System.Windows.Forms.Button();
            this.btnCancLoc = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblLocID = new System.Windows.Forms.Label();
            this.pnlLocacao = new System.Windows.Forms.Panel();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.pnlItemLoc = new System.Windows.Forms.Panel();
            this.btnILBaixa = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvItemLocacao = new System.Windows.Forms.DataGridView();
            this.btnCanIL = new System.Windows.Forms.Button();
            this.btnInsIL = new System.Windows.Forms.Button();
            this.btnSaveIL = new System.Windows.Forms.Button();
            this.btnDelIL = new System.Windows.Forms.Button();
            this.btnUpdIL = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblItmLocID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacao)).BeginInit();
            this.pnlLocacao.SuspendLayout();
            this.pnlItemLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(435, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados de Locação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Locação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(134, 109);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 30);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // dgvLocacao
            // 
            this.dgvLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocacao.Location = new System.Drawing.Point(34, 223);
            this.dgvLocacao.Name = "dgvLocacao";
            this.dgvLocacao.RowTemplate.Height = 24;
            this.dgvLocacao.Size = new System.Drawing.Size(1047, 150);
            this.dgvLocacao.TabIndex = 6;
            this.dgvLocacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocacao_CellContentClick);
            this.dgvLocacao.DoubleClick += new System.EventHandler(this.dgvLocacao_DoubleClick);
            // 
            // btnInsLoc
            // 
            this.btnInsLoc.Location = new System.Drawing.Point(38, 166);
            this.btnInsLoc.Name = "btnInsLoc";
            this.btnInsLoc.Size = new System.Drawing.Size(101, 36);
            this.btnInsLoc.TabIndex = 7;
            this.btnInsLoc.Text = "&Inserir";
            this.btnInsLoc.UseVisualStyleBackColor = true;
            this.btnInsLoc.Click += new System.EventHandler(this.btnInsLoc_Click);
            // 
            // btnUpdLoc
            // 
            this.btnUpdLoc.Location = new System.Drawing.Point(221, 166);
            this.btnUpdLoc.Name = "btnUpdLoc";
            this.btnUpdLoc.Size = new System.Drawing.Size(101, 36);
            this.btnUpdLoc.TabIndex = 8;
            this.btnUpdLoc.Text = "&Editar";
            this.btnUpdLoc.UseVisualStyleBackColor = true;
            this.btnUpdLoc.Click += new System.EventHandler(this.btnUpdLoc_Click);
            // 
            // btnDelLoc
            // 
            this.btnDelLoc.Location = new System.Drawing.Point(404, 166);
            this.btnDelLoc.Name = "btnDelLoc";
            this.btnDelLoc.Size = new System.Drawing.Size(116, 36);
            this.btnDelLoc.TabIndex = 9;
            this.btnDelLoc.Text = "&Remover";
            this.btnDelLoc.UseVisualStyleBackColor = true;
            this.btnDelLoc.Click += new System.EventHandler(this.btnDelLoc_Click);
            // 
            // btnSaveLoc
            // 
            this.btnSaveLoc.Location = new System.Drawing.Point(587, 166);
            this.btnSaveLoc.Name = "btnSaveLoc";
            this.btnSaveLoc.Size = new System.Drawing.Size(101, 36);
            this.btnSaveLoc.TabIndex = 10;
            this.btnSaveLoc.Text = "&Gravar";
            this.btnSaveLoc.UseVisualStyleBackColor = true;
            this.btnSaveLoc.Click += new System.EventHandler(this.btnSaveLoc_Click);
            // 
            // btnCancLoc
            // 
            this.btnCancLoc.Location = new System.Drawing.Point(770, 166);
            this.btnCancLoc.Name = "btnCancLoc";
            this.btnCancLoc.Size = new System.Drawing.Size(115, 36);
            this.btnCancLoc.TabIndex = 11;
            this.btnCancLoc.Text = "&Cancelar";
            this.btnCancLoc.UseVisualStyleBackColor = true;
            this.btnCancLoc.Click += new System.EventHandler(this.btnCancLoc_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(953, 166);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 36);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblLocID
            // 
            this.lblLocID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLocID.Location = new System.Drawing.Point(134, 22);
            this.lblLocID.Name = "lblLocID";
            this.lblLocID.Size = new System.Drawing.Size(100, 23);
            this.lblLocID.TabIndex = 13;
            // 
            // pnlLocacao
            // 
            this.pnlLocacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLocacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLocacao.Controls.Add(this.label1);
            this.pnlLocacao.Controls.Add(this.dtpData);
            this.pnlLocacao.Controls.Add(this.cmbCliente);
            this.pnlLocacao.Controls.Add(this.lblLocID);
            this.pnlLocacao.Controls.Add(this.btnSair);
            this.pnlLocacao.Controls.Add(this.btnCancLoc);
            this.pnlLocacao.Controls.Add(this.btnSaveLoc);
            this.pnlLocacao.Controls.Add(this.btnDelLoc);
            this.pnlLocacao.Controls.Add(this.btnUpdLoc);
            this.pnlLocacao.Controls.Add(this.btnInsLoc);
            this.pnlLocacao.Controls.Add(this.dgvLocacao);
            this.pnlLocacao.Controls.Add(this.txtCliente);
            this.pnlLocacao.Controls.Add(this.label4);
            this.pnlLocacao.Controls.Add(this.label3);
            this.pnlLocacao.Controls.Add(this.label2);
            this.pnlLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLocacao.Location = new System.Drawing.Point(35, 12);
            this.pnlLocacao.Name = "pnlLocacao";
            this.pnlLocacao.Size = new System.Drawing.Size(1136, 397);
            this.pnlLocacao.TabIndex = 14;
            this.pnlLocacao.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLocacao_Paint);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(134, 62);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(386, 30);
            this.dtpData.TabIndex = 15;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(240, 106);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(386, 33);
            this.cmbCliente.TabIndex = 14;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // pnlItemLoc
            // 
            this.pnlItemLoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlItemLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItemLoc.Controls.Add(this.txtValor);
            this.pnlItemLoc.Controls.Add(this.lblEntrega);
            this.pnlItemLoc.Controls.Add(this.lblDias);
            this.pnlItemLoc.Controls.Add(this.lblTotal);
            this.pnlItemLoc.Controls.Add(this.label12);
            this.pnlItemLoc.Controls.Add(this.btnILBaixa);
            this.pnlItemLoc.Controls.Add(this.lblStatus);
            this.pnlItemLoc.Controls.Add(this.label5);
            this.pnlItemLoc.Controls.Add(this.label6);
            this.pnlItemLoc.Controls.Add(this.dgvItemLocacao);
            this.pnlItemLoc.Controls.Add(this.btnCanIL);
            this.pnlItemLoc.Controls.Add(this.btnInsIL);
            this.pnlItemLoc.Controls.Add(this.btnSaveIL);
            this.pnlItemLoc.Controls.Add(this.btnDelIL);
            this.pnlItemLoc.Controls.Add(this.btnUpdIL);
            this.pnlItemLoc.Controls.Add(this.cmbProduto);
            this.pnlItemLoc.Controls.Add(this.txtProduto);
            this.pnlItemLoc.Controls.Add(this.lblItmLocID);
            this.pnlItemLoc.Controls.Add(this.label11);
            this.pnlItemLoc.Controls.Add(this.label10);
            this.pnlItemLoc.Controls.Add(this.label9);
            this.pnlItemLoc.Controls.Add(this.label8);
            this.pnlItemLoc.Controls.Add(this.label7);
            this.pnlItemLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlItemLoc.Location = new System.Drawing.Point(35, 429);
            this.pnlItemLoc.Name = "pnlItemLoc";
            this.pnlItemLoc.Size = new System.Drawing.Size(1136, 415);
            this.pnlItemLoc.TabIndex = 15;
            // 
            // btnILBaixa
            // 
            this.btnILBaixa.Location = new System.Drawing.Point(722, 178);
            this.btnILBaixa.Name = "btnILBaixa";
            this.btnILBaixa.Size = new System.Drawing.Size(125, 37);
            this.btnILBaixa.TabIndex = 21;
            this.btnILBaixa.Text = "Baixar";
            this.btnILBaixa.UseVisualStyleBackColor = true;
            this.btnILBaixa.Click += new System.EventHandler(this.btnILBaixa_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(630, 51);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 28);
            this.lblStatus.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Itens de Locação";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvItemLocacao
            // 
            this.dgvItemLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemLocacao.Location = new System.Drawing.Point(23, 234);
            this.dgvItemLocacao.Name = "dgvItemLocacao";
            this.dgvItemLocacao.RowTemplate.Height = 24;
            this.dgvItemLocacao.Size = new System.Drawing.Size(1100, 153);
            this.dgvItemLocacao.TabIndex = 17;
            this.dgvItemLocacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemLocacao_CellContentClick);
            this.dgvItemLocacao.DoubleClick += new System.EventHandler(this.dgvItemLocacao_DoubleClick);
            // 
            // btnCanIL
            // 
            this.btnCanIL.Location = new System.Drawing.Point(986, 178);
            this.btnCanIL.Name = "btnCanIL";
            this.btnCanIL.Size = new System.Drawing.Size(125, 37);
            this.btnCanIL.TabIndex = 16;
            this.btnCanIL.Text = "&Cancelar";
            this.btnCanIL.UseVisualStyleBackColor = true;
            this.btnCanIL.Click += new System.EventHandler(this.btnCanIL_Click);
            // 
            // btnInsIL
            // 
            this.btnInsIL.Location = new System.Drawing.Point(326, 178);
            this.btnInsIL.Name = "btnInsIL";
            this.btnInsIL.Size = new System.Drawing.Size(125, 37);
            this.btnInsIL.TabIndex = 15;
            this.btnInsIL.Text = "&Inserir";
            this.btnInsIL.UseVisualStyleBackColor = true;
            this.btnInsIL.Click += new System.EventHandler(this.btnInsIL_Click);
            // 
            // btnSaveIL
            // 
            this.btnSaveIL.Location = new System.Drawing.Point(854, 178);
            this.btnSaveIL.Name = "btnSaveIL";
            this.btnSaveIL.Size = new System.Drawing.Size(125, 37);
            this.btnSaveIL.TabIndex = 14;
            this.btnSaveIL.Text = "&Gravar";
            this.btnSaveIL.UseVisualStyleBackColor = true;
            this.btnSaveIL.Click += new System.EventHandler(this.btnSaveIL_Click);
            // 
            // btnDelIL
            // 
            this.btnDelIL.Location = new System.Drawing.Point(590, 178);
            this.btnDelIL.Name = "btnDelIL";
            this.btnDelIL.Size = new System.Drawing.Size(125, 37);
            this.btnDelIL.TabIndex = 13;
            this.btnDelIL.Text = "&Remover";
            this.btnDelIL.UseVisualStyleBackColor = true;
            this.btnDelIL.Click += new System.EventHandler(this.btnDelIL_Click);
            // 
            // btnUpdIL
            // 
            this.btnUpdIL.Location = new System.Drawing.Point(458, 178);
            this.btnUpdIL.Name = "btnUpdIL";
            this.btnUpdIL.Size = new System.Drawing.Size(125, 37);
            this.btnUpdIL.TabIndex = 12;
            this.btnUpdIL.Text = "&Editar";
            this.btnUpdIL.UseVisualStyleBackColor = true;
            this.btnUpdIL.Click += new System.EventHandler(this.btnUpdIL_Click);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(287, 43);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(246, 33);
            this.cmbProduto.TabIndex = 11;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            this.cmbProduto.Leave += new System.EventHandler(this.cmbProduto_Leave);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(206, 46);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(75, 30);
            this.txtProduto.TabIndex = 7;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            this.txtProduto.Leave += new System.EventHandler(this.txtProduto_Leave);
            // 
            // lblItmLocID
            // 
            this.lblItmLocID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblItmLocID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItmLocID.Location = new System.Drawing.Point(206, 13);
            this.lblItmLocID.Name = "lblItmLocID";
            this.lblItmLocID.Size = new System.Drawing.Size(75, 25);
            this.lblItmLocID.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Dias:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Valor R$:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Entrega:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(109, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total R$:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(206, 198);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 30);
            this.lblTotal.TabIndex = 23;
            // 
            // lblDias
            // 
            this.lblDias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDias.Location = new System.Drawing.Point(206, 160);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(97, 30);
            this.lblDias.TabIndex = 25;
            // 
            // lblEntrega
            // 
            this.lblEntrega.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEntrega.Location = new System.Drawing.Point(206, 87);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(166, 30);
            this.lblEntrega.TabIndex = 26;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(206, 124);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 30);
            this.txtValor.TabIndex = 27;
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 882);
            this.ControlBox = false;
            this.Controls.Add(this.pnlItemLoc);
            this.Controls.Add(this.pnlLocacao);
            this.Name = "frmLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação de Ferramentas";
            this.Load += new System.EventHandler(this.frmLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacao)).EndInit();
            this.pnlLocacao.ResumeLayout(false);
            this.pnlLocacao.PerformLayout();
            this.pnlItemLoc.ResumeLayout(false);
            this.pnlItemLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemLocacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvLocacao;
        private System.Windows.Forms.Button btnInsLoc;
        private System.Windows.Forms.Button btnUpdLoc;
        private System.Windows.Forms.Button btnDelLoc;
        private System.Windows.Forms.Button btnSaveLoc;
        private System.Windows.Forms.Button btnCancLoc;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblLocID;
        private System.Windows.Forms.Panel pnlLocacao;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Panel pnlItemLoc;
        private System.Windows.Forms.DataGridView dgvItemLocacao;
        private System.Windows.Forms.Button btnCanIL;
        private System.Windows.Forms.Button btnInsIL;
        private System.Windows.Forms.Button btnSaveIL;
        private System.Windows.Forms.Button btnDelIL;
        private System.Windows.Forms.Button btnUpdIL;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblItmLocID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnILBaixa;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.TextBox txtValor;
    }
}