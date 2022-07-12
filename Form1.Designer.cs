namespace CSharp
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.sign = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.euler = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.squared = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.lastOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.sign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.ForeColor = System.Drawing.Color.White;
            this.sign.Location = new System.Drawing.Point(0, 389);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(78, 61);
            this.sign.TabIndex = 0;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.opHandle);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(150)))));
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(77, 389);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(78, 61);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.numHandler);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dot.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.ForeColor = System.Drawing.Color.White;
            this.dot.Location = new System.Drawing.Point(154, 389);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(78, 61);
            this.dot.TabIndex = 2;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.opHandle);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(130)))));
            this.equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equal.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.Color.White;
            this.equal.Location = new System.Drawing.Point(231, 389);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(129, 61);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.ln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ln.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.ForeColor = System.Drawing.Color.White;
            this.ln.Location = new System.Drawing.Point(231, 329);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(78, 61);
            this.ln.TabIndex = 10;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = false;
            this.ln.Click += new System.EventHandler(this.opHandle);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(130)))));
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.Color.White;
            this.plus.Location = new System.Drawing.Point(308, 329);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(52, 61);
            this.plus.TabIndex = 9;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.opHandle);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(150)))));
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(154, 329);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(78, 61);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numHandler);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(150)))));
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(77, 329);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(78, 61);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numHandler);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(150)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(0, 329);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 61);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numHandler);
            // 
            // factorial
            // 
            this.factorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.factorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.factorial.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial.ForeColor = System.Drawing.Color.White;
            this.factorial.Location = new System.Drawing.Point(231, 209);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(78, 61);
            this.factorial.TabIndex = 20;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = false;
            this.factorial.Click += new System.EventHandler(this.opHandle);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(130)))));
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.ForeColor = System.Drawing.Color.White;
            this.multiply.Location = new System.Drawing.Point(308, 209);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(52, 61);
            this.multiply.TabIndex = 19;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.opHandle);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(150)))));
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(154, 209);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(78, 61);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numHandler);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(150)))));
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(77, 209);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(78, 61);
            this.btn8.TabIndex = 17;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numHandler);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(150)))));
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(0, 209);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(78, 61);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numHandler);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(231, 269);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(78, 61);
            this.log.TabIndex = 15;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.opHandle);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(130)))));
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.Color.White;
            this.minus.Location = new System.Drawing.Point(308, 269);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(52, 61);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.opHandle);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(150)))));
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(154, 269);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(78, 61);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numHandler);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(150)))));
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(77, 269);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 61);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numHandler);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(82)))), ((int)(((byte)(150)))));
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(0, 269);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(78, 61);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numHandler);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(130)))));
            this.backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backspace.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.ForeColor = System.Drawing.Color.White;
            this.backspace.Location = new System.Drawing.Point(231, 89);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(129, 61);
            this.backspace.TabIndex = 30;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(130)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(0, 89);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(78, 61);
            this.clear.TabIndex = 28;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // pi
            // 
            this.pi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(130)))));
            this.pi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pi.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pi.ForeColor = System.Drawing.Color.White;
            this.pi.Location = new System.Drawing.Point(77, 89);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(155, 61);
            this.pi.TabIndex = 27;
            this.pi.Text = "π";
            this.pi.UseVisualStyleBackColor = false;
            this.pi.Click += new System.EventHandler(this.numHandler);
            // 
            // euler
            // 
            this.euler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.euler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.euler.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euler.ForeColor = System.Drawing.Color.White;
            this.euler.Location = new System.Drawing.Point(231, 149);
            this.euler.Name = "euler";
            this.euler.Size = new System.Drawing.Size(78, 61);
            this.euler.TabIndex = 25;
            this.euler.Text = "e";
            this.euler.UseVisualStyleBackColor = false;
            this.euler.Click += new System.EventHandler(this.numHandler);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(130)))));
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.Color.White;
            this.divide.Location = new System.Drawing.Point(308, 149);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(52, 61);
            this.divide.TabIndex = 24;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.opHandle);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.button28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button28.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(154, 149);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(78, 61);
            this.button28.TabIndex = 23;
            this.button28.Text = "|x|";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.opHandle);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.sqrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sqrt.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt.ForeColor = System.Drawing.Color.White;
            this.sqrt.Location = new System.Drawing.Point(77, 149);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(78, 61);
            this.sqrt.TabIndex = 22;
            this.sqrt.Text = "√x";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.opHandle);
            // 
            // squared
            // 
            this.squared.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.squared.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squared.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squared.ForeColor = System.Drawing.Color.White;
            this.squared.Location = new System.Drawing.Point(0, 149);
            this.squared.Name = "squared";
            this.squared.Size = new System.Drawing.Size(78, 61);
            this.squared.TabIndex = 21;
            this.squared.Text = "xʸ";
            this.squared.UseVisualStyleBackColor = false;
            this.squared.Click += new System.EventHandler(this.opHandle);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(119)))));
            this.display.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.display.Location = new System.Drawing.Point(12, 9);
            this.display.Name = "display";
            this.display.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.display.Size = new System.Drawing.Size(336, 77);
            this.display.TabIndex = 31;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lastOp
            // 
            this.lastOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(119)))));
            this.lastOp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastOp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastOp.Location = new System.Drawing.Point(27, 10);
            this.lastOp.Name = "lastOp";
            this.lastOp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastOp.Size = new System.Drawing.Size(318, 14);
            this.lastOp.TabIndex = 32;
            this.lastOp.Text = "0 + 0 =";
            this.lastOp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(49)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.lastOp);
            this.Controls.Add(this.display);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.euler);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.squared);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.log);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.sign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Opacity = 0.97D;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button pi;
        private System.Windows.Forms.Button euler;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button squared;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Label lastOp;
    }
}

