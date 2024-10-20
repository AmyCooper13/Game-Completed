namespace Game_Completed
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label1 = new Label();
            lblTurn = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.198143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.6749229F));
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn2, 1, 0);
            tableLayoutPanel1.Controls.Add(btn3, 2, 0);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn9, 2, 2);
            tableLayoutPanel1.Location = new Point(215, 116);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(323, 218);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Location = new Point(3, 147);
            btn7.Name = "btn7";
            btn7.Size = new Size(101, 68);
            btn7.TabIndex = 1;
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(3, 75);
            btn4.Name = "btn4";
            btn4.Size = new Size(101, 66);
            btn4.TabIndex = 1;
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(101, 66);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(110, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(97, 66);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(213, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(107, 66);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(110, 75);
            btn5.Name = "btn5";
            btn5.Size = new Size(97, 66);
            btn5.TabIndex = 3;
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(213, 75);
            btn6.Name = "btn6";
            btn6.Size = new Size(107, 66);
            btn6.TabIndex = 4;
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(110, 147);
            btn8.Name = "btn8";
            btn8.Size = new Size(97, 68);
            btn8.TabIndex = 5;
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(213, 147);
            btn9.Name = "btn9";
            btn9.Size = new Size(107, 68);
            btn9.TabIndex = 6;
            btn9.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 18);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Tik Tac Toe";
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Location = new Point(325, 58);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(0, 20);
            lblTurn.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTurn);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn7;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn8;
        private Button btn9;
        private Label label1;
        private Label lblTurn;
    }
}
