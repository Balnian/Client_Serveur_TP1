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

        private void BT_Chiffrer_Click(object sender, EventArgs e)
        {
            //Regarde quel Radio Button est coché.
            if (RB_Rotation.Checked)
            {
                //Si Rotation coché lorsque le button chiffrer est appuyé envoit mot crypter dans le text box après
                TB_Apres.Text = Rotations.Chiffrer(TB_Avant.Text, (int)NmUPDOWN.Value);
            }
            else if (RB_Circulaire.Checked)
            {
                //Si Circulaire coché lorsque le button chiffrer est appuyé envoit mot crypter dans le text box après 
                TB_Apres.Text = Circulaires.Chiffrer(TB_Avant.Text, (int)NmUPDOWN.Value);
            }
            else if (RB_OuEx.Checked)
            {
                //Si Ou Exclusif coché lorsque le button chiffrer est appuyé envoit mot crypter dans le text box après
                TB_Apres.Text = OuExs.ChiffrerDechiffrer(TB_Avant.Text, (int)NmUPDOWN.Value);
            }
            
        }

        private void BT_Dechiffrer_Click(object sender, EventArgs e)
        {
            //Regarde quel Radio button est coché
            if (RB_Rotation.Checked)
            {
                //Si Rotation coché lorsque le button déchiffrer est appuyé envoit mot décrypter dans le text box avant
                TB_Avant.Text = Rotations.Dechiffrer(TB_Apres.Text, (int)NmUPDOWN.Value);
            }
            else if (RB_Circulaire.Checked)
            {
                //Si Circulaire coché lorsque le button déchiffrer est appuyé envoit mot décrypter dans le text box avant
                TB_Avant.Text = Circulaires.Dechiffrer(TB_Apres.Text, (int)NmUPDOWN.Value);
            }
            else if (RB_OuEx.Checked)
            {
                //Si Ou exclusif coché lorsque le button déchiffrer est appuyé envoit mot décrypter dans le text box avant
                TB_Avant.Text = OuExs.ChiffrerDechiffrer(TB_Apres.Text, (int)NmUPDOWN.Value);
            }
        }
    }
}
