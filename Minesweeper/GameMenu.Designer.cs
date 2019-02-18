namespace Minesweeper
{
    partial class GameMenu
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
            this.rdEasy = new System.Windows.Forms.RadioButton();
            this.grDifficulty = new System.Windows.Forms.GroupBox();
            this.rdHard = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.btnSaveOptions = new System.Windows.Forms.Button();
            this.txtRows = new System.Windows.Forms.NumericUpDown();
            this.txtCols = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCols)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Minesweeper";
            // 
            // rdEasy
            // 
            this.rdEasy.AutoSize = true;
            this.rdEasy.Location = new System.Drawing.Point(43, 19);
            this.rdEasy.Name = "rdEasy";
            this.rdEasy.Size = new System.Drawing.Size(48, 17);
            this.rdEasy.TabIndex = 1;
            this.rdEasy.TabStop = true;
            this.rdEasy.Text = "Easy";
            this.rdEasy.UseVisualStyleBackColor = true;
            // 
            // grDifficulty
            // 
            this.grDifficulty.Controls.Add(this.rdHard);
            this.grDifficulty.Controls.Add(this.rdMedium);
            this.grDifficulty.Controls.Add(this.rdEasy);
            this.grDifficulty.Location = new System.Drawing.Point(40, 63);
            this.grDifficulty.Name = "grDifficulty";
            this.grDifficulty.Size = new System.Drawing.Size(384, 51);
            this.grDifficulty.TabIndex = 2;
            this.grDifficulty.TabStop = false;
            this.grDifficulty.Text = "Difficulty Level";
            // 
            // rdHard
            // 
            this.rdHard.AutoSize = true;
            this.rdHard.Location = new System.Drawing.Point(251, 17);
            this.rdHard.Name = "rdHard";
            this.rdHard.Size = new System.Drawing.Size(48, 17);
            this.rdHard.TabIndex = 3;
            this.rdHard.TabStop = true;
            this.rdHard.Text = "Hard";
            this.rdHard.UseVisualStyleBackColor = true;
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(150, 17);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(62, 17);
            this.rdMedium.TabIndex = 2;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            // 
            // btnSaveOptions
            // 
            this.btnSaveOptions.Location = new System.Drawing.Point(325, 167);
            this.btnSaveOptions.Name = "btnSaveOptions";
            this.btnSaveOptions.Size = new System.Drawing.Size(99, 28);
            this.btnSaveOptions.TabIndex = 4;
            this.btnSaveOptions.Text = "Save";
            this.btnSaveOptions.UseVisualStyleBackColor = true;
            this.btnSaveOptions.Click += new System.EventHandler(this.btnSaveOptions_Click);
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(83, 136);
            this.txtRows.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(120, 20);
            this.txtRows.TabIndex = 5;
            this.txtRows.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(219, 136);
            this.txtCols.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(120, 20);
            this.txtCols.TabIndex = 6;
            this.txtCols.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rows (X)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Columns (Y) ";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 205);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.btnSaveOptions);
            this.Controls.Add(this.grDifficulty);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            this.grDifficulty.ResumeLayout(false);
            this.grDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdEasy;
        private System.Windows.Forms.GroupBox grDifficulty;
        private System.Windows.Forms.RadioButton rdHard;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.Button btnSaveOptions;
        private System.Windows.Forms.NumericUpDown txtRows;
        private System.Windows.Forms.NumericUpDown txtCols;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}