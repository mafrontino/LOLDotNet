namespace LOLDotNet.LeagueLibraryClient
{
    partial class LeagueLibraryDashboard
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
            this.lbxChampions = new System.Windows.Forms.ListBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxGeneral = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartype = new System.Windows.Forms.TextBox();
            this.txtLore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxChampions
            // 
            this.lbxChampions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxChampions.FormattingEnabled = true;
            this.lbxChampions.ItemHeight = 20;
            this.lbxChampions.Location = new System.Drawing.Point(20, 20);
            this.lbxChampions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxChampions.Name = "lbxChampions";
            this.lbxChampions.Size = new System.Drawing.Size(220, 744);
            this.lbxChampions.TabIndex = 0;
            this.lbxChampions.SelectedIndexChanged += new System.EventHandler(this.lbxChampions_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(60, 32);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // gbxGeneral
            // 
            this.gbxGeneral.Controls.Add(this.label4);
            this.gbxGeneral.Controls.Add(this.txtPartype);
            this.gbxGeneral.Controls.Add(this.txtLore);
            this.gbxGeneral.Controls.Add(this.label3);
            this.gbxGeneral.Controls.Add(this.txtTitle);
            this.gbxGeneral.Controls.Add(this.label2);
            this.gbxGeneral.Controls.Add(this.txtId);
            this.gbxGeneral.Controls.Add(this.label1);
            this.gbxGeneral.Location = new System.Drawing.Point(248, 20);
            this.gbxGeneral.Name = "gbxGeneral";
            this.gbxGeneral.Size = new System.Drawing.Size(838, 446);
            this.gbxGeneral.TabIndex = 3;
            this.gbxGeneral.TabStop = false;
            this.gbxGeneral.Text = "General Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Partype";
            // 
            // txtPartype
            // 
            this.txtPartype.Location = new System.Drawing.Point(329, 19);
            this.txtPartype.Name = "txtPartype";
            this.txtPartype.ReadOnly = true;
            this.txtPartype.Size = new System.Drawing.Size(130, 26);
            this.txtPartype.TabIndex = 7;
            // 
            // txtLore
            // 
            this.txtLore.Location = new System.Drawing.Point(68, 123);
            this.txtLore.Multiline = true;
            this.txtLore.Name = "txtLore";
            this.txtLore.ReadOnly = true;
            this.txtLore.Size = new System.Drawing.Size(731, 124);
            this.txtLore.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lore";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(60, 78);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(190, 26);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // LeagueLibraryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 805);
            this.Controls.Add(this.gbxGeneral);
            this.Controls.Add(this.lbxChampions);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LeagueLibraryDashboard";
            this.Text = "LeagueLibraryDashboard";
            this.gbxGeneral.ResumeLayout(false);
            this.gbxGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxChampions;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxGeneral;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPartype;
    }
}