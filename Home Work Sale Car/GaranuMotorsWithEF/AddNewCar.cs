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
    public partial class AddNewCar : Form
    {
        private readonly Form1 form1;
        
        private readonly GaranuyMotorsEntities _context;
        public AddNewCar(Form1 f, GaranuyMotorsEntities _cont)
        {
            InitializeComponent();
            form1 = f;
            _context = _cont;
            


        }

        private void AddNewCar_Load(object sender, EventArgs e)
        {
            
            cmbBrand.Items.AddRange(_context.Brands.Select(mdl =>  new ComboBoxItem { Id = mdl.Id, Name = mdl.Name }).ToArray());
            foreach(var item in _context.FuelTypes.ToArray())
            {
                cmbFuelName.Items.Add(item);

            }
            
            
            foreach (var item in _context.Transmissions.ToArray())
            {
                cmbTransimission.Items.Add(item);
            }
            
            cmbColor.Items.AddRange(_context.Colors.ToArray());
        }

        private void AddNewCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
            
        }

        private void CmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModelName.Items.Clear();
            ComboBoxItem selectedItem = new ComboBoxItem();
            selectedItem = cmbBrand.SelectedItem as ComboBoxItem;
            cmbModelName.Items.AddRange(_context.Models.Where(md=>md.BrandId==selectedItem.Id).ToArray());
        }

        private async void BtnAddNewCar_Click(object sender, EventArgs e)
        {
            Model.Model cmodel = cmbModelName.SelectedItem as Model.Model;
            int modelId = cmodel.Id;
            FuelType cfuel = cmbFuelName.SelectedItem as FuelType;
            int fuelid = cfuel.Id;
            DateTime pdate = dateProduced.Value;
            Transmission cTran = cmbTransimission.SelectedItem as Transmission;
            int transmId = cTran.Id;
            decimal evalue = numericEngine.Value;
            decimal distance = numericDistance.Value;
            Model.Color ccolor = cmbColor.SelectedItem as Model.Color;
            int colorId = ccolor.Id;
             _context.Cars.Add(new Car
            {
                ModelId = modelId,
                FuelId = fuelid,
                ProductionDate = pdate,
                TransmissionId = transmId,
                EngineVolume = evalue,
                Distance=distance,
                ColorId=colorId

            }) ;
           
            await _context.SaveChangesAsync();
            MessageBox.Show("New Car Added");
        }
    }
}
