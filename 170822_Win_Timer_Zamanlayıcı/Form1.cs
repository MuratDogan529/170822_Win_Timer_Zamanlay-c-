using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170822_Win_Timer_Zamanlayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*  while(true)
              {
                  sayac++;
                  label1.Text=sayac.ToString();
                  Application.DoEvents();//while çalışır durur yapılacak işlem varrsa onu yapar s
                  //sonra döngüyü devam ettirir.Böylece donmadan sayar
                  Thread.Sleep(1000);//uygulamayı 1saniye uyutur(1000ms)
              }*/
           timer1.Start();
           
        } 
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
                sayac++;
                label1.Text = sayac.ToString();
               
            
        }
    }
}