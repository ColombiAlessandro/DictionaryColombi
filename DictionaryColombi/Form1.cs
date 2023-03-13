using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryColombi
{
    public partial class Form1 : Form
    {
        Colletta colletta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colletta = new Colletta();
            SetHeaderList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confermaSomma_Click(object sender, EventArgs e)
        {
        }
        private void SetHeaderList()
        {
            list.View = View.Details;
            list.FullRowSelect = true;
            String[] intestazione = new string[] { "NOME", "SOMMA"};
            for (int i = 0; i < intestazione.Length; i++)
            {
                list.Columns.Add(intestazione[i]);
            }
            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void updateCarrView()
        {

            list.Items.Clear();
            list.View = View.Details;
            list.FullRowSelect = true;
            string[] riga = colletta.ToString().Split(':');
            for(int i=0; i < colletta.Elenco.Count; i++)
            {
                ListViewItem item = new ListViewItem(riga[i].Split(';'));
                list.Items.Add(item);
            }
            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
        }

        private void confermaPersona_Click(object sender, EventArgs e)
        {
            try
            {
                colletta.AggiungiPersone(textBox1.Text, numericUpDown1.Value);
                sommatotale.Text = "Somma totale: " + colletta.SommaTotale.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                updateCarrView();
            }
        }
    }
}
