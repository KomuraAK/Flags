using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioProfLedonBandeiras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Both;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void TrocaBandeira()
        {
            try
            {
                if (Brasil.Checked)
                {
                    textBox1.Text = "O Brasil, oficialmente República Federativa do Brasil, é o maior país da América do Sul e da América Latina. Com 8,5 milhões de quilômetros quadrados e mais de 211 milhões de habitantes, o Brasil é o quinto maior país do mundo em área e o sexto mais populoso.";
                    pictureBox1.Load("../../img/brasil.png");
                }
                if (Chile.Checked)
                {
                    textBox1.Text = "O Chile é um país longo e estreito que se estende ao longo da borda oeste da América do Sul, com mais de 6.000 km de costa do Oceano Pacífico. Santiago, sua capital, fica em um vale cercado pelas montanhas dos Andes e da Cordilheira do Chile. A Plaza de Armas, com palmeiras, contém a catedral neoclássica e o Museu de História Nacional. O enorme Parque Metropolitano oferece piscinas, um jardim botânico e um zoológico.";
                    pictureBox1.Load("../../img/chile.png");
                }
                if (México.Checked)
                {
                    textBox1.Text = "O México, oficialmente os Estados Unidos Mexicanos, é um país da parte sul da América do Norte. Faz fronteira ao norte com os Estados Unidos; ao sul e oeste pelo Oceano Pacífico; ao sudeste pela Guatemala, Belize e o Mar do Caribe; e a leste pelo Golfo do México.";
                    pictureBox1.Load("../../img/mexico.png");
                }
                if (Argentina.Checked)
                {
                    textBox1.Text = "Argentina, oficialmente a República Argentina, é um país na metade sul da América do Sul . Ele compartilha a maior parte do Cone Sul com o Chile a oeste, e também faz fronteira com a Bolívia e Paraguai ao norte, Brasil a nordeste, Uruguai e o Oceano Atlântico Sul a leste, e a passagem de Drake ao sul.";
                    pictureBox1.Load("../../img/argentina.png");
                }
            }
            catch
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TrocaBandeira();
        }

        private void Chile_CheckedChanged(object sender, EventArgs e)
        {
            TrocaBandeira();
        }

        private void México_CheckedChanged(object sender, EventArgs e)
        {
            TrocaBandeira();
        }

        private void Argentina_CheckedChanged(object sender, EventArgs e)
        {
            TrocaBandeira();
        }
    }
}
