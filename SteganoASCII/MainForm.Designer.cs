namespace SteganoASCII
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.RTB_Input = new System.Windows.Forms.RichTextBox();
            this.GB_Parametrage = new System.Windows.Forms.GroupBox();
            this.cb_caractereCodant = new System.Windows.Forms.ComboBox();
            this.cb_jeudecaracteres = new System.Windows.Forms.ComboBox();
            this.l_codant = new System.Windows.Forms.Label();
            this.l_jeudecaracteres = new System.Windows.Forms.Label();
            this.TB_Ouput = new System.Windows.Forms.TextBox();
            this.lbl_template = new System.Windows.Forms.Label();
            this.cbb_template = new System.Windows.Forms.ComboBox();
            this.GB_Parametrage.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTB_Input
            // 
            this.RTB_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Input.Location = new System.Drawing.Point(525, 25);
            this.RTB_Input.Name = "RTB_Input";
            this.RTB_Input.Size = new System.Drawing.Size(402, 142);
            this.RTB_Input.TabIndex = 0;
            this.RTB_Input.Text = "";
            this.RTB_Input.TextChanged += new System.EventHandler(this.RTB_Input_TextChanged);
            // 
            // GB_Parametrage
            // 
            this.GB_Parametrage.Controls.Add(this.cbb_template);
            this.GB_Parametrage.Controls.Add(this.cb_caractereCodant);
            this.GB_Parametrage.Controls.Add(this.lbl_template);
            this.GB_Parametrage.Controls.Add(this.cb_jeudecaracteres);
            this.GB_Parametrage.Controls.Add(this.l_codant);
            this.GB_Parametrage.Controls.Add(this.l_jeudecaracteres);
            this.GB_Parametrage.Location = new System.Drawing.Point(12, 25);
            this.GB_Parametrage.Name = "GB_Parametrage";
            this.GB_Parametrage.Size = new System.Drawing.Size(507, 142);
            this.GB_Parametrage.TabIndex = 1;
            this.GB_Parametrage.TabStop = false;
            this.GB_Parametrage.Text = "Paramétrage";
            // 
            // cb_caractereCodant
            // 
            this.cb_caractereCodant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_caractereCodant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_caractereCodant.FormattingEnabled = true;
            this.cb_caractereCodant.Location = new System.Drawing.Point(106, 47);
            this.cb_caractereCodant.Name = "cb_caractereCodant";
            this.cb_caractereCodant.Size = new System.Drawing.Size(61, 21);
            this.cb_caractereCodant.TabIndex = 1;
            // 
            // cb_jeudecaracteres
            // 
            this.cb_jeudecaracteres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_jeudecaracteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_jeudecaracteres.FormattingEnabled = true;
            this.cb_jeudecaracteres.Location = new System.Drawing.Point(106, 17);
            this.cb_jeudecaracteres.Name = "cb_jeudecaracteres";
            this.cb_jeudecaracteres.Size = new System.Drawing.Size(395, 21);
            this.cb_jeudecaracteres.TabIndex = 1;
            this.cb_jeudecaracteres.SelectedIndexChanged += new System.EventHandler(this.cb_jeudecaracteres_SelectedIndexChanged);
            // 
            // l_codant
            // 
            this.l_codant.AutoSize = true;
            this.l_codant.Location = new System.Drawing.Point(7, 50);
            this.l_codant.Name = "l_codant";
            this.l_codant.Size = new System.Drawing.Size(90, 13);
            this.l_codant.TabIndex = 0;
            this.l_codant.Text = "Caractère Codant";
            // 
            // l_jeudecaracteres
            // 
            this.l_jeudecaracteres.AutoSize = true;
            this.l_jeudecaracteres.Location = new System.Drawing.Point(7, 20);
            this.l_jeudecaracteres.Name = "l_jeudecaracteres";
            this.l_jeudecaracteres.Size = new System.Drawing.Size(92, 13);
            this.l_jeudecaracteres.TabIndex = 0;
            this.l_jeudecaracteres.Text = "Jeu de caractères";
            // 
            // TB_Ouput
            // 
            this.TB_Ouput.AcceptsReturn = true;
            this.TB_Ouput.AcceptsTab = true;
            this.TB_Ouput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Ouput.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Ouput.Location = new System.Drawing.Point(12, 173);
            this.TB_Ouput.MaxLength = 327670000;
            this.TB_Ouput.Multiline = true;
            this.TB_Ouput.Name = "TB_Ouput";
            this.TB_Ouput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_Ouput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_Ouput.Size = new System.Drawing.Size(915, 376);
            this.TB_Ouput.TabIndex = 2;
            this.TB_Ouput.WordWrap = false;
            // 
            // lbl_template
            // 
            this.lbl_template.AutoSize = true;
            this.lbl_template.Location = new System.Drawing.Point(7, 78);
            this.lbl_template.Name = "lbl_template";
            this.lbl_template.Size = new System.Drawing.Size(85, 13);
            this.lbl_template.TabIndex = 0;
            this.lbl_template.Text = "Fichier Template";
            // 
            // cbb_template
            // 
            this.cbb_template.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_template.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_template.FormattingEnabled = true;
            this.cbb_template.Location = new System.Drawing.Point(106, 75);
            this.cbb_template.Name = "cbb_template";
            this.cbb_template.Size = new System.Drawing.Size(395, 21);
            this.cbb_template.TabIndex = 1;
            this.cbb_template.SelectedIndexChanged += new System.EventHandler(this.cbb_template_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 561);
            this.Controls.Add(this.TB_Ouput);
            this.Controls.Add(this.GB_Parametrage);
            this.Controls.Add(this.RTB_Input);
            this.Name = "MainForm";
            this.Text = "SteganoASCII v1.0";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.GB_Parametrage.ResumeLayout(false);
            this.GB_Parametrage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Input;
        private System.Windows.Forms.GroupBox GB_Parametrage;
        private System.Windows.Forms.TextBox TB_Ouput;
        private System.Windows.Forms.ComboBox cb_caractereCodant;
        private System.Windows.Forms.ComboBox cb_jeudecaracteres;
        private System.Windows.Forms.Label l_codant;
        private System.Windows.Forms.Label l_jeudecaracteres;
        private System.Windows.Forms.ComboBox cbb_template;
        private System.Windows.Forms.Label lbl_template;
    }
}

