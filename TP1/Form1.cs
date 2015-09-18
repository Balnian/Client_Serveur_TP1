using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rotation;
using Circulaire;
using OuEx;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Chiffrer(String MotAChiffrer)
        {
            
        }

        private void RB_Rotation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BT_Chiffrer_Click(object sender, EventArgs e)
        {
            if (RB_Rotation.Checked)
            {
                TB_Apres.Text = Rotations.Chiffrer(TB_Avant.Text, (int)NmUPDOWN.Value);
            }
            else if (RB_Circulaire.Checked)
            {
                TB_Apres.Text = Circulaires.Chiffrer(TB_Avant.Text, (int)NmUPDOWN.Value);
            }
            else if (RB_OuEx.Checked)
            {
                TB_Apres.Text = OuExs.ChiffrerDechiffrer(TB_Avant.Text, (int)NmUPDOWN.Value);
            }
            
        }

        private void BT_Dechiffrer_Click(object sender, EventArgs e)
        {
            if (RB_Rotation.Checked)
            {
                TB_Avant.Text = Rotations.Dechiffrer(TB_Apres.Text, (int)NmUPDOWN.Value);
            }
            else if (RB_Circulaire.Checked)
            {
                TB_Avant.Text = Circulaires.Dechiffrer(TB_Apres.Text, (int)NmUPDOWN.Value);
            }
            else if (RB_OuEx.Checked)
            {
                TB_Avant.Text = OuExs.ChiffrerDechiffrer(TB_Apres.Text, (int)NmUPDOWN.Value);
            }
        }
    }
}
