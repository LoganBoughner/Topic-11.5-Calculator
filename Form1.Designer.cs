namespace Topic_11._5_Calculator
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnExponent = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.txtNumOne = new System.Windows.Forms.TextBox();
            this.txtNumTwo = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(164, 88);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "----";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Visible = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(307, 88);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Visible = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(450, 88);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Visible = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnExponent
            // 
            this.btnExponent.Location = new System.Drawing.Point(21, 117);
            this.btnExponent.Name = "btnExponent";
            this.btnExponent.Size = new System.Drawing.Size(75, 23);
            this.btnExponent.TabIndex = 4;
            this.btnExponent.Text = "^";
            this.btnExponent.UseVisualStyleBackColor = true;
            this.btnExponent.Visible = false;
            this.btnExponent.Click += new System.EventHandler(this.btnExponent_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.Location = new System.Drawing.Point(164, 117);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(75, 23);
            this.btnRoot.TabIndex = 5;
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Visible = false;
            this.btnRoot.Click += new System.EventHandler(this.BtnRoot_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(307, 117);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 6;
            this.btnAverage.Text = "AVERAGE";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Visible = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // txtNumOne
            // 
            this.txtNumOne.Location = new System.Drawing.Point(84, 52);
            this.txtNumOne.Name = "txtNumOne";
            this.txtNumOne.Size = new System.Drawing.Size(100, 20);
            this.txtNumOne.TabIndex = 9;
            // 
            // txtNumTwo
            // 
            this.txtNumTwo.Location = new System.Drawing.Point(297, 52);
            this.txtNumTwo.Name = "txtNumTwo";
            this.txtNumTwo.Size = new System.Drawing.Size(100, 20);
            this.txtNumTwo.TabIndex = 10;
            this.txtNumTwo.TextChanged += new System.EventHandler(this.txtNumTwo_TextChanged);
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(224, 55);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(48, 13);
            this.lblOperator.TabIndex = 11;
            this.lblOperator.Text = "Operator";
            this.lblOperator.Visible = false;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(403, 55);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(39, 13);
            this.lblEquals.TabIndex = 12;
            this.lblEquals.Text = "Equals";
            this.lblEquals.Visible = false;
            this.lblEquals.Click += new System.EventHandler(this.lblEquals_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(450, 117);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 23);
            this.btnEqual.TabIndex = 13;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Visible = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(448, 55);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(41, 13);
            this.lblAns.TabIndex = 14;
            this.lblAns.Text = "answer";
            this.lblAns.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 151);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtNumTwo);
            this.Controls.Add(this.txtNumOne);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnExponent);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Caculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnExponent;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.TextBox txtNumOne;
        private System.Windows.Forms.TextBox txtNumTwo;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label lblAns;
    }
}

