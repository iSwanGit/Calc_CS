namespace calc
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
			this.btn_0 = new System.Windows.Forms.Button();
			this.btn_1 = new System.Windows.Forms.Button();
			this.btn_2 = new System.Windows.Forms.Button();
			this.btn_3 = new System.Windows.Forms.Button();
			this.btn_4 = new System.Windows.Forms.Button();
			this.btn_5 = new System.Windows.Forms.Button();
			this.btn_6 = new System.Windows.Forms.Button();
			this.btn_7 = new System.Windows.Forms.Button();
			this.btn_8 = new System.Windows.Forms.Button();
			this.btn_9 = new System.Windows.Forms.Button();
			this.btn_plus = new System.Windows.Forms.Button();
			this.btn_minus = new System.Windows.Forms.Button();
			this.btn_eq = new System.Windows.Forms.Button();
			this.btn_multi = new System.Windows.Forms.Button();
			this.btn_div = new System.Windows.Forms.Button();
			this.btn_ac = new System.Windows.Forms.Button();
			this.btn_bksp = new System.Windows.Forms.Button();
			this.btn_dot = new System.Windows.Forms.Button();
			this.btn_00 = new System.Windows.Forms.Button();
			this.disp = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menu_appInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.disp_proc = new System.Windows.Forms.Label();
			this.btn_negate = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_0
			// 
			this.btn_0.Location = new System.Drawing.Point(12, 219);
			this.btn_0.Name = "btn_0";
			this.btn_0.Size = new System.Drawing.Size(47, 30);
			this.btn_0.TabIndex = 0;
			this.btn_0.TabStop = false;
			this.btn_0.Text = "0";
			this.btn_0.UseVisualStyleBackColor = true;
			this.btn_0.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// btn_1
			// 
			this.btn_1.Location = new System.Drawing.Point(12, 183);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new System.Drawing.Size(47, 30);
			this.btn_1.TabIndex = 1;
			this.btn_1.TabStop = false;
			this.btn_1.Text = "1";
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// btn_2
			// 
			this.btn_2.Location = new System.Drawing.Point(65, 183);
			this.btn_2.Name = "btn_2";
			this.btn_2.Size = new System.Drawing.Size(47, 30);
			this.btn_2.TabIndex = 2;
			this.btn_2.TabStop = false;
			this.btn_2.Text = "2";
			this.btn_2.UseVisualStyleBackColor = true;
			this.btn_2.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// btn_3
			// 
			this.btn_3.Location = new System.Drawing.Point(118, 183);
			this.btn_3.Name = "btn_3";
			this.btn_3.Size = new System.Drawing.Size(47, 30);
			this.btn_3.TabIndex = 3;
			this.btn_3.TabStop = false;
			this.btn_3.Text = "3";
			this.btn_3.UseVisualStyleBackColor = true;
			this.btn_3.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// btn_4
			// 
			this.btn_4.Location = new System.Drawing.Point(12, 147);
			this.btn_4.Name = "btn_4";
			this.btn_4.Size = new System.Drawing.Size(47, 30);
			this.btn_4.TabIndex = 4;
			this.btn_4.TabStop = false;
			this.btn_4.Text = "4";
			this.btn_4.UseVisualStyleBackColor = true;
			this.btn_4.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// btn_5
			// 
			this.btn_5.Location = new System.Drawing.Point(65, 147);
			this.btn_5.Name = "btn_5";
			this.btn_5.Size = new System.Drawing.Size(47, 30);
			this.btn_5.TabIndex = 5;
			this.btn_5.TabStop = false;
			this.btn_5.Text = "5";
			this.btn_5.UseVisualStyleBackColor = true;
			this.btn_5.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// btn_6
			// 
			this.btn_6.Location = new System.Drawing.Point(118, 147);
			this.btn_6.Name = "btn_6";
			this.btn_6.Size = new System.Drawing.Size(47, 30);
			this.btn_6.TabIndex = 6;
			this.btn_6.TabStop = false;
			this.btn_6.Text = "6";
			this.btn_6.UseVisualStyleBackColor = true;
			this.btn_6.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// btn_7
			// 
			this.btn_7.Location = new System.Drawing.Point(12, 111);
			this.btn_7.Name = "btn_7";
			this.btn_7.Size = new System.Drawing.Size(47, 30);
			this.btn_7.TabIndex = 7;
			this.btn_7.TabStop = false;
			this.btn_7.Text = "7";
			this.btn_7.UseVisualStyleBackColor = true;
			this.btn_7.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// btn_8
			// 
			this.btn_8.Location = new System.Drawing.Point(65, 111);
			this.btn_8.Name = "btn_8";
			this.btn_8.Size = new System.Drawing.Size(47, 30);
			this.btn_8.TabIndex = 8;
			this.btn_8.TabStop = false;
			this.btn_8.Text = "8";
			this.btn_8.UseVisualStyleBackColor = true;
			this.btn_8.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// btn_9
			// 
			this.btn_9.Location = new System.Drawing.Point(118, 111);
			this.btn_9.Name = "btn_9";
			this.btn_9.Size = new System.Drawing.Size(47, 30);
			this.btn_9.TabIndex = 9;
			this.btn_9.TabStop = false;
			this.btn_9.Text = "9";
			this.btn_9.UseVisualStyleBackColor = true;
			this.btn_9.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// btn_plus
			// 
			this.btn_plus.Location = new System.Drawing.Point(171, 147);
			this.btn_plus.Name = "btn_plus";
			this.btn_plus.Size = new System.Drawing.Size(47, 30);
			this.btn_plus.TabIndex = 10;
			this.btn_plus.TabStop = false;
			this.btn_plus.Text = "+";
			this.btn_plus.UseVisualStyleBackColor = true;
			this.btn_plus.Click += new System.EventHandler(this.btn_oper_Click);
			// 
			// btn_minus
			// 
			this.btn_minus.Location = new System.Drawing.Point(224, 147);
			this.btn_minus.Name = "btn_minus";
			this.btn_minus.Size = new System.Drawing.Size(47, 30);
			this.btn_minus.TabIndex = 11;
			this.btn_minus.TabStop = false;
			this.btn_minus.Text = "-";
			this.btn_minus.UseVisualStyleBackColor = true;
			this.btn_minus.Click += new System.EventHandler(this.btn_oper_Click);
			// 
			// btn_eq
			// 
			this.btn_eq.Location = new System.Drawing.Point(224, 219);
			this.btn_eq.Name = "btn_eq";
			this.btn_eq.Size = new System.Drawing.Size(47, 30);
			this.btn_eq.TabIndex = 12;
			this.btn_eq.TabStop = false;
			this.btn_eq.Text = "=";
			this.btn_eq.UseVisualStyleBackColor = true;
			this.btn_eq.Click += new System.EventHandler(this.btn_eq_Click);
			// 
			// btn_multi
			// 
			this.btn_multi.Location = new System.Drawing.Point(171, 183);
			this.btn_multi.Name = "btn_multi";
			this.btn_multi.Size = new System.Drawing.Size(47, 30);
			this.btn_multi.TabIndex = 13;
			this.btn_multi.TabStop = false;
			this.btn_multi.Text = "*";
			this.btn_multi.UseVisualStyleBackColor = true;
			this.btn_multi.Click += new System.EventHandler(this.btn_oper_Click);
			// 
			// btn_div
			// 
			this.btn_div.Location = new System.Drawing.Point(224, 183);
			this.btn_div.Name = "btn_div";
			this.btn_div.Size = new System.Drawing.Size(47, 30);
			this.btn_div.TabIndex = 14;
			this.btn_div.TabStop = false;
			this.btn_div.Text = "/";
			this.btn_div.UseVisualStyleBackColor = true;
			this.btn_div.Click += new System.EventHandler(this.btn_oper_Click);
			// 
			// btn_ac
			// 
			this.btn_ac.Location = new System.Drawing.Point(224, 111);
			this.btn_ac.Name = "btn_ac";
			this.btn_ac.Size = new System.Drawing.Size(47, 30);
			this.btn_ac.TabIndex = 15;
			this.btn_ac.TabStop = false;
			this.btn_ac.Text = "AC";
			this.btn_ac.UseVisualStyleBackColor = true;
			this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
			// 
			// btn_bksp
			// 
			this.btn_bksp.Location = new System.Drawing.Point(171, 111);
			this.btn_bksp.Name = "btn_bksp";
			this.btn_bksp.Size = new System.Drawing.Size(47, 30);
			this.btn_bksp.TabIndex = 16;
			this.btn_bksp.TabStop = false;
			this.btn_bksp.Text = "BS";
			this.btn_bksp.UseVisualStyleBackColor = true;
			this.btn_bksp.Click += new System.EventHandler(this.btn_bksp_Click);
			// 
			// btn_dot
			// 
			this.btn_dot.Location = new System.Drawing.Point(118, 219);
			this.btn_dot.Name = "btn_dot";
			this.btn_dot.Size = new System.Drawing.Size(47, 30);
			this.btn_dot.TabIndex = 17;
			this.btn_dot.TabStop = false;
			this.btn_dot.Text = ".";
			this.btn_dot.UseVisualStyleBackColor = true;
			this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
			// 
			// btn_00
			// 
			this.btn_00.Location = new System.Drawing.Point(65, 219);
			this.btn_00.Name = "btn_00";
			this.btn_00.Size = new System.Drawing.Size(47, 30);
			this.btn_00.TabIndex = 18;
			this.btn_00.TabStop = false;
			this.btn_00.Text = "00";
			this.btn_00.UseVisualStyleBackColor = true;
			this.btn_00.Click += new System.EventHandler(this.btn_Num_Click);
			// 
			// disp
			// 
			this.disp.BackColor = System.Drawing.Color.White;
			this.disp.Font = new System.Drawing.Font("맑은 고딕", 15F);
			this.disp.Location = new System.Drawing.Point(12, 52);
			this.disp.Name = "disp";
			this.disp.Size = new System.Drawing.Size(259, 56);
			this.disp.TabIndex = 19;
			this.disp.Text = "0";
			this.disp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_appInfo});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 20;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menu_appInfo
			// 
			this.menu_appInfo.Name = "menu_appInfo";
			this.menu_appInfo.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.menu_appInfo.Size = new System.Drawing.Size(98, 20);
			this.menu_appInfo.Text = "계산기 정보 (&I)";
			this.menu_appInfo.Click += new System.EventHandler(this.menu_appInfo_Click);
			// 
			// disp_proc
			// 
			this.disp_proc.BackColor = System.Drawing.Color.LavenderBlush;
			this.disp_proc.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.disp_proc.Location = new System.Drawing.Point(12, 29);
			this.disp_proc.Name = "disp_proc";
			this.disp_proc.Size = new System.Drawing.Size(259, 23);
			this.disp_proc.TabIndex = 21;
			this.disp_proc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_negate
			// 
			this.btn_negate.Location = new System.Drawing.Point(171, 219);
			this.btn_negate.Name = "btn_negate";
			this.btn_negate.Size = new System.Drawing.Size(47, 30);
			this.btn_negate.TabIndex = 22;
			this.btn_negate.TabStop = false;
			this.btn_negate.Text = "±";
			this.btn_negate.UseVisualStyleBackColor = true;
			this.btn_negate.Click += new System.EventHandler(this.btn_negate_Click);
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btn_negate);
			this.Controls.Add(this.disp_proc);
			this.Controls.Add(this.disp);
			this.Controls.Add(this.btn_00);
			this.Controls.Add(this.btn_dot);
			this.Controls.Add(this.btn_bksp);
			this.Controls.Add(this.btn_ac);
			this.Controls.Add(this.btn_div);
			this.Controls.Add(this.btn_multi);
			this.Controls.Add(this.btn_eq);
			this.Controls.Add(this.btn_minus);
			this.Controls.Add(this.btn_plus);
			this.Controls.Add(this.btn_9);
			this.Controls.Add(this.btn_8);
			this.Controls.Add(this.btn_7);
			this.Controls.Add(this.btn_6);
			this.Controls.Add(this.btn_5);
			this.Controls.Add(this.btn_4);
			this.Controls.Add(this.btn_3);
			this.Controls.Add(this.btn_2);
			this.Controls.Add(this.btn_1);
			this.Controls.Add(this.btn_0);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Calculator";
			this.Text = "Calc";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_eq;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.Button btn_bksp;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Label disp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_appInfo;
        private System.Windows.Forms.Label disp_proc;
		private System.Windows.Forms.Button btn_negate;
    }
}

