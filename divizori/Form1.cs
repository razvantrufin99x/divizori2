using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divizori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool divizor(int x, int d)
        {
            if (x % d == 0)  return true; 
            else return false;
        }

        public bool par(int x)
        {
            if(x%2==0) return true;
            else return false;
        }
        public int middle(int x)
        {
            int y = 0;

            if (par(x) == true) { y = x / 2; }
            else { y = (x - 1) / 2; }

            return y;
        }
        public List<int> listadedivizori(int x)
        {
            List<int> lista = new List<int>();

            int y = middle(x);

            for (int i =1; i <= y; i++)
            { 
                if(divizor(x,i)==true)
                {
                    lista.Add(i);
                }
            }
            return lista;
        }

   
        public string printLista(ref List<int> l)
        {
            string rez="";

            for (int i = 0; i < l.Count; i++)
            {
                rez += l[i].ToString() + ",";
            }
            return rez;
        }

        public void findalldivizori(int N)
        {
            for (int i = 0; i < N; i++)
            {
                int k = i;
                List<int> r = new List<int>();
                r = listadedivizori(k);
                this.textBox1.Text += "\r\n";
                this.textBox1.Text += k.ToString() + " , ";
                this.textBox1.Text += printLista(ref r);
                
                this.textBox1.Text += r.Count.ToString();
                if (r.Count == 1) {
                    this.textBox1.Text += ",";
                    this.textBox1.Text += " prime ";
                }
                //this.textBox1.Text += "\r\n";
            }
        }
        public void findallprimes(int N)
        {
            for (int i = 0; i < N; i++)
            {
                int k = i;
                List<int> r = new List<int>();
                r = listadedivizori(k);

                if (r.Count == 1)
                {

                    this.textBox1.Text += "\r\n";
                this.textBox1.Text += k.ToString() + " , ";
                this.textBox1.Text += printLista(ref r);

                this.textBox1.Text += r.Count.ToString();
                
                    this.textBox1.Text += ",";
                    this.textBox1.Text += " prime ";
                }
                //this.textBox1.Text += "\r\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //findalldivizori(500);
            //findallprimes(5000);
        }
    }
}
