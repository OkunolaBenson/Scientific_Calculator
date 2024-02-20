namespace Calculator
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
            btnBS = new Button();
            txtResult = new TextBox();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnPM = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnAdd = new Button();
            btn4 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btnSub = new Button();
            btn1 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btnMult = new Button();
            btn0 = new Button();
            btnEqual = new Button();
            btnDot = new Button();
            btnDiv = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            standardToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            btnPI = new Button();
            btnLog = new Button();
            btnSqrt = new Button();
            btnx2 = new Button();
            bnSinh = new Button();
            btnDec = new Button();
            btnSin = new Button();
            btnx3 = new Button();
            btnCosh = new Button();
            btnBin = new Button();
            btnCos = new Button();
            btn1x = new Button();
            btnTanh = new Button();
            btnHex = new Button();
            btnTan = new Button();
            btnInx = new Button();
            btnExp = new Button();
            btnOct = new Button();
            btnMod = new Button();
            btnPercent = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBS
            // 
            btnBS.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnBS.Location = new Point(12, 80);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(75, 77);
            btnBS.TabIndex = 0;
            btnBS.Text = "⌫";
            btnBS.UseVisualStyleBackColor = true;
            btnBS.Click += btnBS_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtResult.Location = new Point(12, 36);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(674, 38);
            txtResult.TabIndex = 1;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnClearEntry.Location = new Point(93, 80);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(75, 77);
            btnClearEntry.TabIndex = 0;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnClear.Location = new Point(174, 80);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 77);
            btnClear.TabIndex = 0;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnPM.Location = new Point(255, 80);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(75, 77);
            btnPM.TabIndex = 0;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn7.Location = new Point(12, 163);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 77);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn9.Location = new Point(174, 163);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 77);
            btn9.TabIndex = 0;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn8.Location = new Point(93, 163);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 77);
            btn8.TabIndex = 0;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnAdd.Location = new Point(255, 163);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 77);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += numberoperator;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn4.Location = new Point(12, 246);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 77);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn6.Location = new Point(174, 246);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 77);
            btn6.TabIndex = 0;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn5.Location = new Point(93, 246);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 77);
            btn5.TabIndex = 0;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnSub.Location = new Point(255, 246);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 77);
            btnSub.TabIndex = 0;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += numberoperator;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn1.Location = new Point(12, 329);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 77);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn3.Location = new Point(174, 329);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 77);
            btn3.TabIndex = 0;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn2.Location = new Point(93, 329);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 77);
            btn2.TabIndex = 0;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnMult.Location = new Point(255, 329);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(75, 77);
            btnMult.TabIndex = 0;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += numberoperator;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn0.Location = new Point(12, 412);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 77);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnEqual.Location = new Point(174, 412);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(75, 77);
            btnEqual.TabIndex = 0;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnDot.Location = new Point(93, 412);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(75, 77);
            btnDot.TabIndex = 0;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += EnterNumbers;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnDiv.Location = new Point(255, 412);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 77);
            btnDiv.TabIndex = 0;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += numberoperator;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(703, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, scientificToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            standardToolStripMenuItem.Size = new Size(180, 22);
            standardToolStripMenuItem.Text = "Standard";
            standardToolStripMenuItem.Click += standardToolStripMenuItem_Click;
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            scientificToolStripMenuItem.Size = new Size(180, 22);
            scientificToolStripMenuItem.Text = "Scientific";
            scientificToolStripMenuItem.Click += scientificToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // btnPI
            // 
            btnPI.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnPI.Location = new Point(368, 80);
            btnPI.Name = "btnPI";
            btnPI.Size = new Size(75, 77);
            btnPI.TabIndex = 0;
            btnPI.Text = "π";
            btnPI.UseVisualStyleBackColor = true;
            btnPI.Click += btnPI_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnLog.Location = new Point(449, 80);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(75, 77);
            btnLog.TabIndex = 0;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnSqrt.Location = new Point(530, 80);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(75, 77);
            btnSqrt.TabIndex = 0;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnx2
            // 
            btnx2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnx2.Location = new Point(611, 80);
            btnx2.Name = "btnx2";
            btnx2.Size = new Size(75, 77);
            btnx2.TabIndex = 0;
            btnx2.Text = "x²";
            btnx2.UseVisualStyleBackColor = true;
            btnx2.Click += btnx2_Click;
            // 
            // bnSinh
            // 
            bnSinh.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            bnSinh.Location = new Point(368, 163);
            bnSinh.Name = "bnSinh";
            bnSinh.Size = new Size(75, 77);
            bnSinh.TabIndex = 0;
            bnSinh.Text = "Sinh";
            bnSinh.UseVisualStyleBackColor = true;
            bnSinh.Click += bnSinh_Click;
            // 
            // btnDec
            // 
            btnDec.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnDec.Location = new Point(530, 163);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(75, 77);
            btnDec.TabIndex = 0;
            btnDec.Text = "Dec";
            btnDec.UseVisualStyleBackColor = true;
            btnDec.Click += btnDec_Click;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnSin.Location = new Point(449, 163);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(75, 77);
            btnSin.TabIndex = 0;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // btnx3
            // 
            btnx3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnx3.Location = new Point(611, 163);
            btnx3.Name = "btnx3";
            btnx3.Size = new Size(75, 77);
            btnx3.TabIndex = 0;
            btnx3.Text = "x³";
            btnx3.UseVisualStyleBackColor = true;
            btnx3.Click += btnx3_Click;
            // 
            // btnCosh
            // 
            btnCosh.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnCosh.Location = new Point(368, 246);
            btnCosh.Name = "btnCosh";
            btnCosh.Size = new Size(75, 77);
            btnCosh.TabIndex = 0;
            btnCosh.Text = "Cosh";
            btnCosh.UseVisualStyleBackColor = true;
            btnCosh.Click += btnCosh_Click;
            // 
            // btnBin
            // 
            btnBin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnBin.Location = new Point(530, 246);
            btnBin.Name = "btnBin";
            btnBin.Size = new Size(75, 77);
            btnBin.TabIndex = 0;
            btnBin.Text = "Bin";
            btnBin.UseVisualStyleBackColor = true;
            btnBin.Click += btnBin_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnCos.Location = new Point(449, 246);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(75, 77);
            btnCos.TabIndex = 0;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btn1x
            // 
            btn1x.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn1x.Location = new Point(611, 246);
            btn1x.Name = "btn1x";
            btn1x.Size = new Size(75, 77);
            btn1x.TabIndex = 0;
            btn1x.Text = "1/x";
            btn1x.UseVisualStyleBackColor = true;
            btn1x.Click += btn1x_Click;
            // 
            // btnTanh
            // 
            btnTanh.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnTanh.Location = new Point(368, 329);
            btnTanh.Name = "btnTanh";
            btnTanh.Size = new Size(75, 77);
            btnTanh.TabIndex = 0;
            btnTanh.Text = "Tanh";
            btnTanh.UseVisualStyleBackColor = true;
            btnTanh.Click += btnTanh_Click;
            // 
            // btnHex
            // 
            btnHex.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnHex.Location = new Point(530, 329);
            btnHex.Name = "btnHex";
            btnHex.Size = new Size(75, 77);
            btnHex.TabIndex = 0;
            btnHex.Text = "Hex";
            btnHex.UseVisualStyleBackColor = true;
            btnHex.Click += btnHex_Click;
            // 
            // btnTan
            // 
            btnTan.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnTan.Location = new Point(449, 329);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(75, 77);
            btnTan.TabIndex = 0;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = true;
            btnTan.Click += btnTan_Click;
            // 
            // btnInx
            // 
            btnInx.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnInx.Location = new Point(611, 329);
            btnInx.Name = "btnInx";
            btnInx.Size = new Size(75, 77);
            btnInx.TabIndex = 0;
            btnInx.Text = "In x";
            btnInx.UseVisualStyleBackColor = true;
            btnInx.Click += btnInx_Click;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnExp.Location = new Point(368, 412);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(75, 77);
            btnExp.TabIndex = 0;
            btnExp.Text = "Exp";
            btnExp.UseVisualStyleBackColor = true;
            btnExp.Click += numberoperator;
            // 
            // btnOct
            // 
            btnOct.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnOct.Location = new Point(530, 412);
            btnOct.Name = "btnOct";
            btnOct.Size = new Size(75, 77);
            btnOct.TabIndex = 0;
            btnOct.Text = "Oct";
            btnOct.UseVisualStyleBackColor = true;
            btnOct.Click += btnOct_Click;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnMod.Location = new Point(449, 412);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 77);
            btnMod.TabIndex = 0;
            btnMod.Text = "Mod";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += numberoperator;
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnPercent.Location = new Point(611, 412);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(75, 77);
            btnPercent.TabIndex = 0;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 500);
            Controls.Add(txtResult);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnDot);
            Controls.Add(btn2);
            Controls.Add(btnSub);
            Controls.Add(btn5);
            Controls.Add(btnEqual);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn0);
            Controls.Add(btnPercent);
            Controls.Add(btnInx);
            Controls.Add(btn1x);
            Controls.Add(btnx3);
            Controls.Add(btnx2);
            Controls.Add(btnMod);
            Controls.Add(btnOct);
            Controls.Add(btnTan);
            Controls.Add(btnHex);
            Controls.Add(btnCos);
            Controls.Add(btnBin);
            Controls.Add(btnExp);
            Controls.Add(btnSin);
            Controls.Add(btnTanh);
            Controls.Add(btnDec);
            Controls.Add(btnCosh);
            Controls.Add(btnLog);
            Controls.Add(bnSinh);
            Controls.Add(btnSqrt);
            Controls.Add(btnPI);
            Controls.Add(btnPM);
            Controls.Add(btn1);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btnClearEntry);
            Controls.Add(btn7);
            Controls.Add(btnClear);
            Controls.Add(btnBS);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBS;
        private TextBox txtResult;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnPM;
        private Button btn7;
        private Button btn9;
        private Button btn8;
        private Button btnAdd;
        private Button btn4;
        private Button btn6;
        private Button btn5;
        private Button btnSub;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btnMult;
        private Button btn0;
        private Button btnEqual;
        private Button btnDot;
        private Button btnDiv;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnPI;
        private Button btnLog;
        private Button btnSqrt;
        private Button btnx2;
        private Button bnSinh;
        private Button btnDec;
        private Button btnSin;
        private Button btnx3;
        private Button btnCosh;
        private Button btnBin;
        private Button btnCos;
        private Button btn1x;
        private Button btnTanh;
        private Button btnHex;
        private Button btnTan;
        private Button btnInx;
        private Button btnExp;
        private Button btnOct;
        private Button btnMod;
        private Button btnPercent;
    }
}
