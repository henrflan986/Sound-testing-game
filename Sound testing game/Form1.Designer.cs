namespace Sound_testing_game
{
    partial class backGroundColor
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
            this.buttonToStart = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Label();
            this.numberTwo = new System.Windows.Forms.Label();
            this.numberOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonToStart
            // 
            this.buttonToStart.Location = new System.Drawing.Point(297, 170);
            this.buttonToStart.Name = "buttonToStart";
            this.buttonToStart.Size = new System.Drawing.Size(209, 133);
            this.buttonToStart.TabIndex = 1;
            this.buttonToStart.Text = "Start Game";
            this.buttonToStart.UseVisualStyleBackColor = true;
            this.buttonToStart.Click += new System.EventHandler(this.buttonToStart_Click);
            // 
            // number3
            // 
            this.number3.AutoSize = true;
            this.number3.ForeColor = System.Drawing.Color.White;
            this.number3.Location = new System.Drawing.Point(407, 320);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(0, 16);
            this.number3.TabIndex = 2;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // numberTwo
            // 
            this.numberTwo.AutoSize = true;
            this.numberTwo.ForeColor = System.Drawing.Color.Transparent;
            this.numberTwo.Location = new System.Drawing.Point(407, 351);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(0, 16);
            this.numberTwo.TabIndex = 3;
            this.numberTwo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numberOne
            // 
            this.numberOne.AutoSize = true;
            this.numberOne.ForeColor = System.Drawing.Color.White;
            this.numberOne.Location = new System.Drawing.Point(405, 385);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(0, 16);
            this.numberOne.TabIndex = 4;
            // 
            // backGroundColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberOne);
            this.Controls.Add(this.numberTwo);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.buttonToStart);
            this.Name = "backGroundColor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToStart;
        private System.Windows.Forms.Label number3;
        private System.Windows.Forms.Label numberTwo;
        private System.Windows.Forms.Label numberOne;
    }
}

