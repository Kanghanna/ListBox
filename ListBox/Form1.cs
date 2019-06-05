using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {

        string OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text; // label의 텍스트인 "결과 : " 를 OrgStr에 추가
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddList();
        }

        private void AddList()
        {
            if (TextCheck()) //값을 제대로 입력했는지 확인
            {
                this.lbView.Items.Add(this.txtList.Text); //txt박스에 입력된 텍스트를 listBox에 행으로 추가하는 것 
                this.txtList.Text = ""; //추가하고 나면 txt박스 값 지우기
            }
        }

        private bool TextCheck()
        {
           if(this.txtList.Text == "") //txt박스가 비어있는지 확인
            {
                MessageBox.Show("항목을 입력해주세요.",
                    "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.txtList.Focus();
                return false;
            }
           else
            {
                return true;
            }
        }

        private void LbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.lbView.Text; //label 값에 결과 :  + listBox 내용
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                AddList();
            }
        }
    }
}
