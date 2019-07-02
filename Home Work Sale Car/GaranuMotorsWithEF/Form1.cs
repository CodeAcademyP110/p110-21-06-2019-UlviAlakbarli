using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaranuMotorsWithEF.Model;

namespace GaranuMotorsWithEF
{   
    public partial class Form1 : Form
    {
        private readonly GaranuyMotorsEntities _context;
        public Form1()
        {
            InitializeComponent();
            _context = new GaranuyMotorsEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewBrands.DataSource = _context.Cars.Select(delegate(Car cr){
                    return new {BrandName=cr.Model.Brand.Name,ModelName=cr.Model.Name,Color=cr.Color.Name,Transimission=cr.Transmission.Name,
                    Distance=cr.Distance.Value,EngineValue=cr.EngineVolume.Value,Fuel=cr.FuelType.Name};
            }).ToList();
           
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            AddNewCar addform = new AddNewCar(this,_context);
            addform.Show();
            addform.FormClosed += zzz;
            this.Hide();
        }
        private void zzz(object sender, FormClosedEventArgs e)
        {
            dataGridViewBrands.DataSource = _context.Cars.Select(delegate (Car cr)
            {
                return new
                {
                    BrandName = cr.Model.Brand.Name,
                    ModelName = cr.Model.Name,
                    Color = cr.Color.Name,
                    Transimission = cr.Transmission.Name,
                    Distance = cr.Distance.Value,
                    EngineValue = cr.EngineVolume.Value,
                    Fuel = cr.FuelType.Name
                };
            }).ToList();


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
