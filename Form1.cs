using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Algortimo LZW
 * Teoria de la Información
 * Autor: Daniela Cisneros
*/

namespace AlgoritmoLzw
{
    public partial class Form1 : Form
    {
        string cad,car;
        List<string> alfabeto = new List<string>();
        List<int> Codigo = new List<int>();
        List<int> CodigoAsoDic = new List<int>();
        List<string> Salida = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnAgregar.Visible = false;
            label2.Visible = false;
            LbDiccionario.Visible = false;
            LbSalida.Visible = false;
            TxtComprimir.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            BtnComprimir.Visible = false;
            BtnDescomprimir.Visible = false;
            BtnLimpiar.Visible = false;
            LbCodigo.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            BtnCodigo.Visible = false;
            TxtCodigo.Visible = false;
            BtnBorrar1.Visible = false;
            BtnBorrar2.Visible = false;
            label8.Visible = false;
        }
        public static bool EstaEn(List<string> lista, string x)
        {
            Boolean flag = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == x)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool EstaEn2(List<int> lista, int x)
        {
            Boolean flag = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == x)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public void HacerVisible()
        {
            label2.Visible = true;
            LbDiccionario.Visible = true;
            LbSalida.Visible = true;
            TxtComprimir.Visible =  true;
            label3.Visible = true;
            label4.Visible = true;
            BtnEjecutar.Visible = false;
            BtnLimpiar.Visible = true;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                HacerVisible();
                label2.Text = "Ingrese una frase:";
                BtnAgregar.Visible = false;
                BtnComprimir.Visible = true;
                LbCodigo.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                BtnCodigo.Visible = false;
                TxtCodigo.Visible = false;
                BtnBorrar2.Visible = false;
                BtnBorrar1.Visible = false;
            }
            else if(radioButton2.Checked==true)
            {
                HacerVisible();
                label2.Text = "Ingrese caracter:";
                BtnAgregar.Visible = true;
                BtnDescomprimir.Visible = true;
                LbCodigo.Visible = true;
                label5.Visible = true;
                label6.Visible = true ;
                BtnCodigo.Visible = true; 
                TxtCodigo.Visible = true;
                BtnBorrar2.Visible = true;
                BtnBorrar1.Visible = true;
                label8.Visible = true;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            car = TxtComprimir.Text;
            LbDiccionario.Items.Add(car);
            TxtComprimir.Text = "";
            TxtComprimir.Select();
            TxtComprimir.SelectAll();
        }
        private void BtnDescomprimir_Click(object sender, EventArgs e)
        {
            int i = 0, cod_viejo, cod_nuevo;
            string caracter, cadena,cad_descomp;
            foreach(string x in LbDiccionario.Items)
            {
                alfabeto.Add(x);
            }
            foreach (string x in LbCodigo.Items)
            {
                Codigo.Add(Convert.ToInt32(x));
            }
            cod_viejo = Codigo[0];
            caracter = alfabeto[cod_viejo].ToString();
            Salida.Add(caracter);
            cad_descomp = caracter;
            while (i < LbCodigo.Items.Count-1)
            {
                cod_nuevo = Codigo[i + 1];
                CodigoAsoDic.Clear();
                for (int a = 0; a < alfabeto.Count; a++)
                {
                    CodigoAsoDic.Add(a);
                }
                if (!EstaEn2(CodigoAsoDic,cod_nuevo))
                {
                    cadena = alfabeto[cod_viejo].ToString();
                    cadena += caracter;
                }
                else
                {
                    cadena = alfabeto[cod_nuevo].ToString();
                }
                Salida.Add(cadena);
                cad_descomp += cadena;
                caracter = cadena.Substring(0, 1); 
                alfabeto.Add(alfabeto[cod_viejo].ToString() + caracter);
                cod_viejo = cod_nuevo;
                i++;
            }
            LbDiccionario.Items.Clear();
            foreach (string x in alfabeto)
            {
                LbDiccionario.Items.Add(x);
            }
            foreach (string x in Salida)
            {
                LbSalida.Items.Add(x);
            }
            label7.Text = "Cadena descomprimida: "+ cad_descomp;
        }
        private void BtnComprimir_Click(object sender, EventArgs e)
        {
            cad = TxtComprimir.Text;
            string wk, k, w = null;
            int i = 0;
            foreach (char x in cad)
            {
                if (!EstaEn(alfabeto, x.ToString()))
                {
                    alfabeto.Add(x.ToString());
                }
            }
            while (i < cad.Length)
            {
                k = cad.Substring(i, 1);
                wk = w + k;
                if (EstaEn(alfabeto, wk))
                {
                    w = wk;
                }
                else
                {
                    Codigo.Add(alfabeto.IndexOf(w));
                    alfabeto.Add(wk);
                    w = k;
                }
                i++;
            }
            Codigo.Add(alfabeto.IndexOf(w));
            foreach (string x in alfabeto)
            {
                LbDiccionario.Items.Add(x);
            }
            foreach (int x in Codigo)
            {
                LbSalida.Items.Add(x);
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            alfabeto.Clear();
            Salida.Clear();
            Codigo.Clear();
            CodigoAsoDic.Clear();
            LbDiccionario.Items.Clear();
            LbSalida.Items.Clear();
            TxtComprimir.Text = "";
            BtnEjecutar.Visible = true;
            BtnComprimir.Visible = false;
            LbCodigo.Items.Clear();
            label7.Text = "";
        }
        private void BtnBorrar1_Click(object sender, EventArgs e)
        {
            LbDiccionario.Items.Remove(LbDiccionario.SelectedItem);
        }

        private void BtnBorrar2_Click(object sender, EventArgs e)
        {
            LbCodigo.Items.Remove(LbCodigo.SelectedItem);
        }

        private void TxtComprimir_TextChanged(object sender, EventArgs e)
        {
            //label8.Visible = true;
        }

        private void BtnCodigo_Click(object sender, EventArgs e)
        { 
            car = TxtCodigo.Text;
            LbCodigo.Items.Add(car);
            TxtCodigo.Text = "";
            TxtCodigo.Select();
            TxtCodigo.SelectAll();
        }
    }
}

