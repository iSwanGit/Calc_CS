using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
	public partial class Calculator : Form
	{
		public Calculator()
		{
			InitializeComponent();
		}

		private void btn_Num_Click(object sender, EventArgs e)
		{

			string hit;
			if (e == null)          // 이벤트가 안오면 키보드 누른거
				hit = ((char)sender).ToString();
			else                    // 이벤트 오면 버튼 뚜들김
				hit = ((System.Windows.Forms.Button)sender).Text;
			if (operChanged)	// 
				disp.Text = "";
			if (disp.Text.Length > 12)   // 제한 자릿수 넘어가면 개무시 자리가 남지만 
				return;
			if (disp.Text == "0")
			{
				if (hit != "0" && hit != "00")
				{
					disp.Text = "";
					disp.Text += hit;
				}
			}
			else
			{
				if (disp.Text == "" && hit == "00")
					disp.Text = "0";
				else
					disp.Text += hit;
			}
			operChanged = false;
			equalClicked = false;
			pastOperand = double.Parse(disp.Text);
		}

		private void btn_dot_Click(object sender, EventArgs e)
		{
			if (operChanged)
				disp.Text = "0.";
			if (disp.Text.IndexOf('.') == -1)
				disp.Text += ".";
			operChanged = false;
			equalClicked = false;
		}

		private void btn_ac_Click(object sender, EventArgs e)
		{
			disp.Text = "0"; // All Clear
			disp_proc.Text = "";
			pastCalc = 0.0;  // temp init
			pastOperator = ' ';
			pastOperand = 0.0;  // 피연산자 기억
			operChanged = false;
			equalClicked = false;

		}

		private void btn_bksp_Click(object sender, EventArgs e)
		{
			if (operChanged)    // 연산자 누르자마자 백스페이스 누르지마쇼....;;
				return;
			if (disp.Text != "0")
			{
				if (disp.Text.Length > 1)
					disp.Text = disp.Text.Substring(0, disp.Text.Length - 1);
				else
					disp.Text = "0";
			}
		}

		private void btn_oper_Click(object sender, EventArgs e)
		{
			string hit;
			if (e == null)          // 이벤트가 안오면 키보드 누른거
				hit = ((char)sender).ToString();
			else                    // 이벤트 오면 버튼 뚜들김
				hit = ((System.Windows.Forms.Button)sender).Text;
			if (operChanged)
			{
				if (hit[0] != pastOperator)      // 연산자 다른거 눌러서 바꿈
					pastOperator = hit[0];
				if (disp_proc.Text.Length > 1)
					disp_proc.Text = disp_proc.Text.Substring(0, disp_proc.Text.Length - 2) + pastOperator + " ";
				else
					disp_proc.Text = disp.Text + " " + pastOperator + " ";
				return;
			}

			pastOperand = double.Parse(disp.Text);

			pastCalculator();

			pastOperator = hit[0];  //누른 버튼(연산자) 일단 이전꺼 계산 하고 체인지쓰루
			disp_proc.Text += disp.Text + " " + pastOperator + " ";
			disp.Text = pastCalc.ToString();
			operChanged = true; //연산자 눌렸어요!
			equalClicked = false;

			//MessageBox.Show(pastCalc.ToString());
		}

		double pastCalc = 0.0;  // temp init
		char pastOperator = ' ';
		double pastOperand = 0.0;  // 피연산자 기억
		bool operChanged = false;

		private void pastCalculator()       // 연산 호출
		{
			switch (pastOperator)
			{
				case ' ':
					pastCalc = pastOperand;
					break;
				case '+':
					pastCalc += pastOperand;
					break;
				case '-':
					pastCalc -= pastOperand;
					break;
				case '*':
					pastCalc *= pastOperand;
					break;
				case '/':
					// 0으로 나눌때
					// 를 구현하려 했으나 너무 친절하게 무한대가 나와서 일단 생략...;;

					pastCalc /= pastOperand;
					break;
			}
		}

		bool equalClicked = false;
		private void btn_eq_Click(object sender, EventArgs e)
		{
			disp_proc.Text = "";
			pastCalculator();
			disp.Text = pastCalc.ToString();
			operChanged = true;
			equalClicked = true;
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)     // 숫자 및 연산자
		{
			char keyChar = e.KeyChar;
			if (keyChar >= '0' && keyChar <= '9')
				btn_Num_Click(keyChar, null);
			if (keyChar == '.')
				btn_dot_Click(null, null);
			if (keyChar == '+' || keyChar == '-' ||
				keyChar == '*' || keyChar == '/')
				btn_oper_Click(keyChar, null);
			if (keyChar == '=' || keyChar == '\r')
				btn_eq_Click(null, null);
			if (keyChar == '\b')
				btn_bksp_Click(null, null);
			if (keyChar == 27)  //esc
				btn_ac_Click(null, null);
			if (keyChar == 'n' || keyChar == 'N')
				btn_negate_Click(null, null);
			//if (keyChar == '\r') MessageBox.Show("RRRR");     return은 \r\n   
		}

		private void menu_appInfo_Click(object sender, EventArgs e)
		{
			Help helpWindow = new Help();
			helpWindow.ShowDialog();
		}

		private void btn_negate_Click(object sender, EventArgs e)	// 혼자 검토해보기 으으 졸려 
		{
			string dtext= disp.Text;
			double negated;
			//if (dtext.IndexOf('+') == -1 &&
			//	dtext.IndexOf('-', 1) == -1 &&
			//	dtext.IndexOf('*') == -1 &&
			//	dtext.IndexOf('/') == -1)
			//{
				negated = -double.Parse(dtext);
				disp.Text = negated.ToString();

				if(!operChanged)	//연산자를안건드렸을때
					pastOperand = negated;
				if (equalClicked)
					pastCalc = negated;
			//}	
		}
	}
}

//0나누기 음양수계산 및 전환