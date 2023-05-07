namespace Projeto_Agenda_Contatos
{
    partial class FormAGENDA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAGENDA));
            textBox1 = new TextBox();
            textBoxNOME = new TextBox();
            textBoxSOBRENOME = new TextBox();
            textBoxTELEFONE = new TextBox();
            textBoxCELULAR = new TextBox();
            textBoxEMAIL = new TextBox();
            textBoxLINKEDIN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBoxSTATUS = new GroupBox();
            radioButtonBLOQUEADO = new RadioButton();
            radioButtonDESBLOQUEADO = new RadioButton();
            dataGridViewCONTATOS = new DataGridView();
            buttonCADASTRAR = new Button();
            buttonALTERAR = new Button();
            buttonEXCLUIR = new Button();
            textBoxID = new TextBox();
            label7 = new Label();
            buttonLIMPAR = new Button();
            buttonFECHAR = new Button();
            groupBoxSTATUS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCONTATOS).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RoyalBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(2, 14);
            textBox1.Margin = new Padding(6, 5, 6, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 34);
            textBox1.TabIndex = 0;
            textBox1.Text = "Agenda de contatos";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNOME
            // 
            textBoxNOME.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNOME.Location = new Point(2, 101);
            textBoxNOME.Name = "textBoxNOME";
            textBoxNOME.Size = new Size(277, 29);
            textBoxNOME.TabIndex = 1;
            // 
            // textBoxSOBRENOME
            // 
            textBoxSOBRENOME.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSOBRENOME.Location = new Point(2, 165);
            textBoxSOBRENOME.Name = "textBoxSOBRENOME";
            textBoxSOBRENOME.Size = new Size(277, 29);
            textBoxSOBRENOME.TabIndex = 2;
            // 
            // textBoxTELEFONE
            // 
            textBoxTELEFONE.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTELEFONE.Location = new Point(2, 228);
            textBoxTELEFONE.Name = "textBoxTELEFONE";
            textBoxTELEFONE.Size = new Size(277, 29);
            textBoxTELEFONE.TabIndex = 3;
            // 
            // textBoxCELULAR
            // 
            textBoxCELULAR.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCELULAR.Location = new Point(2, 293);
            textBoxCELULAR.Name = "textBoxCELULAR";
            textBoxCELULAR.Size = new Size(277, 29);
            textBoxCELULAR.TabIndex = 4;
            // 
            // textBoxEMAIL
            // 
            textBoxEMAIL.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEMAIL.Location = new Point(2, 357);
            textBoxEMAIL.Name = "textBoxEMAIL";
            textBoxEMAIL.Size = new Size(277, 29);
            textBoxEMAIL.TabIndex = 6;
            // 
            // textBoxLINKEDIN
            // 
            textBoxLINKEDIN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLINKEDIN.Location = new Point(2, 420);
            textBoxLINKEDIN.Name = "textBoxLINKEDIN";
            textBoxLINKEDIN.Size = new Size(277, 29);
            textBoxLINKEDIN.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 72);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 8;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 137);
            label2.Name = "label2";
            label2.Size = new Size(110, 24);
            label2.TabIndex = 9;
            label2.Text = "Sobrenome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(2, 201);
            label3.Name = "label3";
            label3.Size = new Size(85, 24);
            label3.TabIndex = 10;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(2, 266);
            label4.Name = "label4";
            label4.Size = new Size(69, 24);
            label4.TabIndex = 11;
            label4.Text = "Celular";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 330);
            label5.Name = "label5";
            label5.Size = new Size(57, 24);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(2, 393);
            label6.Name = "label6";
            label6.Size = new Size(81, 24);
            label6.TabIndex = 13;
            label6.Text = "LinkedIn";
            // 
            // groupBoxSTATUS
            // 
            groupBoxSTATUS.Anchor = AnchorStyles.None;
            groupBoxSTATUS.BackColor = Color.Transparent;
            groupBoxSTATUS.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxSTATUS.Controls.Add(radioButtonBLOQUEADO);
            groupBoxSTATUS.Controls.Add(radioButtonDESBLOQUEADO);
            groupBoxSTATUS.FlatStyle = FlatStyle.Flat;
            groupBoxSTATUS.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxSTATUS.ForeColor = Color.White;
            groupBoxSTATUS.Location = new Point(2, 473);
            groupBoxSTATUS.Name = "groupBoxSTATUS";
            groupBoxSTATUS.Size = new Size(277, 104);
            groupBoxSTATUS.TabIndex = 14;
            groupBoxSTATUS.TabStop = false;
            groupBoxSTATUS.Text = "Status";
            groupBoxSTATUS.Enter += groupBoxSTATUS_Enter;
            // 
            // radioButtonBLOQUEADO
            // 
            radioButtonBLOQUEADO.AutoSize = true;
            radioButtonBLOQUEADO.Location = new Point(10, 62);
            radioButtonBLOQUEADO.Name = "radioButtonBLOQUEADO";
            radioButtonBLOQUEADO.Size = new Size(120, 28);
            radioButtonBLOQUEADO.TabIndex = 1;
            radioButtonBLOQUEADO.TabStop = true;
            radioButtonBLOQUEADO.Text = "Bloqueado";
            radioButtonBLOQUEADO.UseVisualStyleBackColor = true;
            radioButtonBLOQUEADO.CheckedChanged += radioButtonBLOQUEADO_CheckedChanged;
            // 
            // radioButtonDESBLOQUEADO
            // 
            radioButtonDESBLOQUEADO.AutoSize = true;
            radioButtonDESBLOQUEADO.Location = new Point(10, 28);
            radioButtonDESBLOQUEADO.Name = "radioButtonDESBLOQUEADO";
            radioButtonDESBLOQUEADO.Size = new Size(152, 28);
            radioButtonDESBLOQUEADO.TabIndex = 0;
            radioButtonDESBLOQUEADO.TabStop = true;
            radioButtonDESBLOQUEADO.Text = "Desbloqueado";
            radioButtonDESBLOQUEADO.UseVisualStyleBackColor = true;
            radioButtonDESBLOQUEADO.CheckedChanged += radioButtonDESBLOQUEADO_CheckedChanged;
            // 
            // dataGridViewCONTATOS
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCONTATOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCONTATOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCONTATOS.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCONTATOS.Location = new Point(310, 72);
            dataGridViewCONTATOS.Name = "dataGridViewCONTATOS";
            dataGridViewCONTATOS.RowTemplate.Height = 25;
            dataGridViewCONTATOS.Size = new Size(843, 185);
            dataGridViewCONTATOS.TabIndex = 15;
            dataGridViewCONTATOS.MouseClick += dataGridViewCONTATOS_MouseClick;
            // 
            // buttonCADASTRAR
            // 
            buttonCADASTRAR.BackColor = Color.Transparent;
            buttonCADASTRAR.FlatAppearance.BorderSize = 0;
            buttonCADASTRAR.FlatStyle = FlatStyle.Flat;
            buttonCADASTRAR.ForeColor = Color.White;
            buttonCADASTRAR.Image = Properties.Resources.contato_png;
            buttonCADASTRAR.Location = new Point(412, 555);
            buttonCADASTRAR.Name = "buttonCADASTRAR";
            buttonCADASTRAR.Size = new Size(140, 32);
            buttonCADASTRAR.TabIndex = 16;
            buttonCADASTRAR.Text = "Cadastrar";
            buttonCADASTRAR.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCADASTRAR.UseVisualStyleBackColor = false;
            buttonCADASTRAR.Click += buttonCADASTRAR_Click;
            // 
            // buttonALTERAR
            // 
            buttonALTERAR.BackColor = Color.Transparent;
            buttonALTERAR.FlatAppearance.BorderSize = 0;
            buttonALTERAR.FlatStyle = FlatStyle.Flat;
            buttonALTERAR.ForeColor = Color.White;
            buttonALTERAR.Image = Properties.Resources.troca__1_;
            buttonALTERAR.Location = new Point(569, 555);
            buttonALTERAR.Name = "buttonALTERAR";
            buttonALTERAR.Size = new Size(122, 32);
            buttonALTERAR.TabIndex = 17;
            buttonALTERAR.Text = "Alterar";
            buttonALTERAR.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonALTERAR.UseVisualStyleBackColor = false;
            buttonALTERAR.Click += buttonALTERAR_Click;
            // 
            // buttonEXCLUIR
            // 
            buttonEXCLUIR.BackColor = Color.Transparent;
            buttonEXCLUIR.FlatAppearance.BorderSize = 0;
            buttonEXCLUIR.FlatStyle = FlatStyle.Flat;
            buttonEXCLUIR.ForeColor = Color.Transparent;
            buttonEXCLUIR.Image = Properties.Resources.contato;
            buttonEXCLUIR.Location = new Point(715, 555);
            buttonEXCLUIR.Name = "buttonEXCLUIR";
            buttonEXCLUIR.Size = new Size(114, 32);
            buttonEXCLUIR.TabIndex = 18;
            buttonEXCLUIR.Text = "Excluir";
            buttonEXCLUIR.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEXCLUIR.UseVisualStyleBackColor = false;
            buttonEXCLUIR.Click += buttonEXCLUIR_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(639, 520);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(110, 29);
            textBoxID.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(680, 493);
            label7.Name = "label7";
            label7.Size = new Size(27, 24);
            label7.TabIndex = 20;
            label7.Text = "ID";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLIMPAR
            // 
            buttonLIMPAR.BackColor = Color.Transparent;
            buttonLIMPAR.FlatAppearance.BorderSize = 0;
            buttonLIMPAR.FlatStyle = FlatStyle.Flat;
            buttonLIMPAR.ForeColor = Color.Transparent;
            buttonLIMPAR.Image = Properties.Resources.esfregar;
            buttonLIMPAR.Location = new Point(856, 555);
            buttonLIMPAR.Name = "buttonLIMPAR";
            buttonLIMPAR.Size = new Size(114, 32);
            buttonLIMPAR.TabIndex = 21;
            buttonLIMPAR.Text = "Limpar";
            buttonLIMPAR.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLIMPAR.UseVisualStyleBackColor = false;
            buttonLIMPAR.Click += buttonLIMPAR_Click;
            // 
            // buttonFECHAR
            // 
            buttonFECHAR.BackColor = Color.Transparent;
            buttonFECHAR.FlatAppearance.BorderSize = 0;
            buttonFECHAR.FlatStyle = FlatStyle.Flat;
            buttonFECHAR.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFECHAR.ForeColor = Color.Transparent;
            buttonFECHAR.Image = Properties.Resources.saida;
            buttonFECHAR.Location = new Point(1039, 555);
            buttonFECHAR.Name = "buttonFECHAR";
            buttonFECHAR.Size = new Size(114, 32);
            buttonFECHAR.TabIndex = 22;
            buttonFECHAR.Text = "Fechar";
            buttonFECHAR.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFECHAR.UseVisualStyleBackColor = false;
            buttonFECHAR.Click += buttonFECHAR_Click;
            // 
            // FormAGENDA
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3257989;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1156, 599);
            Controls.Add(buttonFECHAR);
            Controls.Add(buttonLIMPAR);
            Controls.Add(label7);
            Controls.Add(textBoxID);
            Controls.Add(buttonEXCLUIR);
            Controls.Add(buttonALTERAR);
            Controls.Add(buttonCADASTRAR);
            Controls.Add(dataGridViewCONTATOS);
            Controls.Add(groupBoxSTATUS);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLINKEDIN);
            Controls.Add(textBoxEMAIL);
            Controls.Add(textBoxCELULAR);
            Controls.Add(textBoxTELEFONE);
            Controls.Add(textBoxSOBRENOME);
            Controls.Add(textBoxNOME);
            Controls.Add(textBox1);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormAGENDA";
            Text = "Agenda de Contatos";
            groupBoxSTATUS.ResumeLayout(false);
            groupBoxSTATUS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCONTATOS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBoxNOME;
        private TextBox textBoxSOBRENOME;
        private TextBox textBoxTELEFONE;
        private TextBox textBoxCELULAR;
        private TextBox textBoxEMAIL;
        private TextBox textBoxLINKEDIN;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBoxSTATUS;
        private DataGridView dataGridViewCONTATOS;
        private Button buttonCADASTRAR;
        private Button buttonALTERAR;
        private Button buttonEXCLUIR;
        private TextBox textBoxID;
        private Label label7;
        private RadioButton radioButtonBLOQUEADO;
        private RadioButton radioButtonDESBLOQUEADO;
        private Button buttonLIMPAR;
        private Button buttonFECHAR;
    }
}