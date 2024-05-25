using LaboratorioFinCurso.data.data_acces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioFinCurso
{
    public partial class Form1 : Form
    {


        private string[] companias =
        {
            "Atari",
            "Coleco",
            "Mattel",
            "Microsoft",
            "Nintendo",
            "Ouya Inc",
            "Sega",
            "Sony"
        };

        public Form1()
        {
            InitializeComponent();
          
            consolas1 = new ConexionBD();
        }
        private ConexionBD consolas1;
        private void bttonCargar_Click(object sender, EventArgs e)
        {
            DataTable cargaC = consolas1.LeerBD();
            Consolasleer.DataSource = cargaC;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCompania.Items.AddRange(companias);
        }
 
    
    
    
    
    
    
    
    
    
    
    
    
    }
}