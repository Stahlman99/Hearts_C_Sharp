using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearts
{
    public partial class Form1 : Form
    {
        GameManager TheGame { get; set; } = new GameManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheGame.Shuffle();
            textBox2.Text = TheGame.DisplayDeck();

            Pass_Cards_Btn.Location = Deal_Cards_Btn.Location;
            Deal_Cards_Btn.Location = button1.Location;
            button1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Deal_Cards_Btn_Click(object sender, EventArgs e)
        {
            TheGame.Deal(TheGame.Deck);

            TheGame.Player1.SortHand();
            textBox1.Text = TheGame.Player1.PrintHand();

            Deal_Cards_Btn.Visible = false;

            Pass_Cards_Btn.Location = Deal_Cards_Btn.Location;
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            TheGame.Shuffle();
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            Deal_Cards_Btn.Visible = true;
            Pass_Cards_Btn.Visible = true;
            Start_Btn.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
