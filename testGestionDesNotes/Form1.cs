using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testGestionDesNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        gestion_exmen d = new gestion_exmen();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "TypeNiveau";
            comboBox1.ValueMember = "idNiveau";

            comboBox1.DataSource = d.niveau.Select(p => new
            {
                p.idNiveau,
                p.TypeNiveau
            }).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DisplayMember = "nomFiliere";
            comboBox2.ValueMember = "idFiliere";
            comboBox2.DataSource = d.filiere.Select(p => new
            {
                p.idFiliere,
                p.nomFiliere
            }).ToList();

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idN = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            int idF = Convert.ToInt32(comboBox2.SelectedValue.ToString());

            comboBox3.DisplayMember = "nomGroupe";
            comboBox3.ValueMember = "idGroupe";
            comboBox3.DataSource = d.groupe.Where(c => c.idFiliere == idF && c.idNiveau == idN)
                .Select(p => new
                {
                    p.idGroupe,
                    p.nomGroupe
                }).ToList();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idF = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            listBox1.DisplayMember = "nomMatiere";
            listBox1.ValueMember = "idMatiere";
            listBox1.DataSource = (from fl in d.filiere
                                   where fl.idFiliere == idF
                                   from mat in fl.matiere
                                   select new
                                   {
                                       idMatiere = mat.idMatiere,
                                       nomMatiere = mat.nomMatiere
                                   }
                                   ).ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idM = Convert.ToInt32(listBox1.SelectedValue.ToString());
            int idG = Convert.ToInt32(comboBox3.SelectedValue.ToString());
            int idF = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            d.thebest(idF);

            
            dataGridView1.DataSource = d.examen.Where(c=> c.idMatiere == idM && c.inscrit.idGroupe==idG).Select(n=> n.inscrit.etudiant.nomEtudiant).ToList();
           
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            d.SaveChanges();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
