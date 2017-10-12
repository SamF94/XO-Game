namespace XOGame
{
    partial class XOForm
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
            this._00Button = new System.Windows.Forms.Button();
            this._01Button = new System.Windows.Forms.Button();
            this._02Button = new System.Windows.Forms.Button();
            this._10Button = new System.Windows.Forms.Button();
            this._11Button = new System.Windows.Forms.Button();
            this._12Button = new System.Windows.Forms.Button();
            this._20Button = new System.Windows.Forms.Button();
            this._21Button = new System.Windows.Forms.Button();
            this._22Button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._turnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _00Button
            // 
            this._00Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._00Button.Location = new System.Drawing.Point(12, 12);
            this._00Button.Name = "_00Button";
            this._00Button.Size = new System.Drawing.Size(75, 75);
            this._00Button.TabIndex = 0;
            this._00Button.UseVisualStyleBackColor = true;
            this._00Button.Click += new System.EventHandler(this._00Button_Click);
            // 
            // _01Button
            // 
            this._01Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._01Button.Location = new System.Drawing.Point(104, 12);
            this._01Button.Name = "_01Button";
            this._01Button.Size = new System.Drawing.Size(75, 75);
            this._01Button.TabIndex = 1;
            this._01Button.UseVisualStyleBackColor = true;
            this._01Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // _02Button
            // 
            this._02Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._02Button.Location = new System.Drawing.Point(197, 12);
            this._02Button.Name = "_02Button";
            this._02Button.Size = new System.Drawing.Size(75, 75);
            this._02Button.TabIndex = 2;
            this._02Button.UseVisualStyleBackColor = true;
            this._02Button.Click += new System.EventHandler(this._02Button_Click);
            // 
            // _10Button
            // 
            this._10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._10Button.Location = new System.Drawing.Point(12, 93);
            this._10Button.Name = "_10Button";
            this._10Button.Size = new System.Drawing.Size(75, 75);
            this._10Button.TabIndex = 3;
            this._10Button.UseVisualStyleBackColor = true;
            this._10Button.Click += new System.EventHandler(this._10Button_Click);
            // 
            // _11Button
            // 
            this._11Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._11Button.Location = new System.Drawing.Point(104, 93);
            this._11Button.Name = "_11Button";
            this._11Button.Size = new System.Drawing.Size(75, 75);
            this._11Button.TabIndex = 4;
            this._11Button.UseVisualStyleBackColor = true;
            this._11Button.Click += new System.EventHandler(this._11Button_Click);
            // 
            // _12Button
            // 
            this._12Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._12Button.Location = new System.Drawing.Point(197, 93);
            this._12Button.Name = "_12Button";
            this._12Button.Size = new System.Drawing.Size(75, 75);
            this._12Button.TabIndex = 5;
            this._12Button.UseVisualStyleBackColor = true;
            this._12Button.Click += new System.EventHandler(this._12Button_Click);
            // 
            // _20Button
            // 
            this._20Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._20Button.Location = new System.Drawing.Point(12, 174);
            this._20Button.Name = "_20Button";
            this._20Button.Size = new System.Drawing.Size(75, 75);
            this._20Button.TabIndex = 6;
            this._20Button.UseVisualStyleBackColor = true;
            this._20Button.Click += new System.EventHandler(this._20Button_Click);
            // 
            // _21Button
            // 
            this._21Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._21Button.Location = new System.Drawing.Point(104, 174);
            this._21Button.Name = "_21Button";
            this._21Button.Size = new System.Drawing.Size(75, 75);
            this._21Button.TabIndex = 7;
            this._21Button.UseVisualStyleBackColor = true;
            this._21Button.Click += new System.EventHandler(this._21Button_Click);
            // 
            // _22Button
            // 
            this._22Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._22Button.Location = new System.Drawing.Point(197, 174);
            this._22Button.Name = "_22Button";
            this._22Button.Size = new System.Drawing.Size(75, 75);
            this._22Button.TabIndex = 8;
            this._22Button.UseVisualStyleBackColor = true;
            this._22Button.Click += new System.EventHandler(this._22Button_Click);
            // 
            // _turnLabel
            // 
            this._turnLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._turnLabel.Location = new System.Drawing.Point(0, 298);
            this._turnLabel.Name = "_turnLabel";
            this._turnLabel.Size = new System.Drawing.Size(284, 13);
            this._turnLabel.TabIndex = 9;
            this._turnLabel.Text = "label1";
            // 
            // XOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XOGame.Properties.Resources.smallSpace1;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this._turnLabel);
            this.Controls.Add(this._22Button);
            this.Controls.Add(this._21Button);
            this.Controls.Add(this._20Button);
            this.Controls.Add(this._12Button);
            this.Controls.Add(this._11Button);
            this.Controls.Add(this._10Button);
            this.Controls.Add(this._02Button);
            this.Controls.Add(this._01Button);
            this.Controls.Add(this._00Button);
            this.Name = "XOForm";
            this.Text = "XO Wars";
            this.Load += new System.EventHandler(this.XOForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _00Button;
        private System.Windows.Forms.Button _01Button;
        private System.Windows.Forms.Button _02Button;
        private System.Windows.Forms.Button _10Button;
        private System.Windows.Forms.Button _11Button;
        private System.Windows.Forms.Button _12Button;
        private System.Windows.Forms.Button _20Button;
        private System.Windows.Forms.Button _21Button;
        private System.Windows.Forms.Button _22Button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label _turnLabel;
    }
}

