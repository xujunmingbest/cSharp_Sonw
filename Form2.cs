using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Snow
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Init();
        }
        public int num1;
        public int num2;
        public int states;
        public int type;
        private void Init()//初始化，可被引用初始化
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            type = comboBox1.SelectedIndex;
            DownLoad();
            states = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            type = comboBox1.SelectedIndex;
            states = 1;
            this.Visible = false;
        }

        #region 加载选项信息

        private void DownLoad()
        {
                comboBox1.Items.Add("混合");
                comboBox1.Items.Add("雪花");
                comboBox1.Items.Add("爱心");
            this.comboBox1.SelectedIndex = 0;
        }

        #endregion

        #region 无界面拖动

        //先定义一个坐标点对象 mypoint         
        private Point mypoint;
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            //鼠标在窗体内按下时，自动记录鼠标的 x y 值，并将它们改为负数             
            mypoint = new Point(-e.X, -e.Y);
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            /* 鼠标在窗体内移动时，首先判断e.Button按下的是哪个鼠标按钮再判断              
             * 是否等于左键按下,MouseButtons.Left这句的意思是鼠标左键按下状态
             */
            if (e.Button == MouseButtons.Left)
            {
                /*新建一个坐标点对象，它的坐标等于（Control.MousePosition;）                  
                 * 桌面上坐标的位置
                 */
                Point myposition = Control.MousePosition;
                /*
                 * myposition.offset中的Offset是坐标平移的意思，现在将在窗体                  
                 * 内点击左键时产生的负数加进来，也就等于 现在鼠标在桌面上的坐标                  
                 * 减去鼠标在窗体内的坐标位置，就等于现在窗体的位置                  
                 */
                myposition.Offset(mypoint.X, mypoint.Y);
                /* 
                 * this.DesktopLocation这句的意思是获取或设置窗体在桌面上的位置                  
                 * 它的位置来自myposition 
                 */
                this.DesktopLocation = myposition;
            }
        }
        #endregion

    }
}
