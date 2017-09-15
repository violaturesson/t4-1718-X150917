﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise150917
{
    public partial class CarsInStock : Form
    {
        private Stock _stock = new Stock();

        List<Car> _cars = new List<Car>();
            
        public CarsInStock()
        {
            _cars.Add(new Car { Make = "Volvo", Model = "V70", Color = "Red", Milage = 1240 });
            _cars.Add(new Car { Make = "Audi", Model = "A3", Color = "White", Milage = 34000 });
            _cars.Add(new Car { Make = "Volvo", Model = "V70", Color = "Black", Milage = 505 });
            _cars.Add(new Car { Make = "BMW", Model = "750", Color = "Green", Milage = 28500 });
            _cars.Add(new Car { Make = "Skoda", Model = "Octavia", Color = "Red", Milage = 820 });
            _cars.Add(new Car { Make = "Volvo", Model = "V60", Color = "Red", Milage = 12890 });
            _cars.Add(new Car { Make = "Audi", Model = "Q3", Color = "Black", Milage = 22300 });
            _cars.Add(new Car { Make = "BMW", Model = "328", Color = "White", Milage = 5500 });
            _cars.Add(new Car { Make = "Volvo", Model = "V60", Color = "Black", Milage = 1402 });
            _cars.Add(new Car { Make = "Opel", Model = "Ascona", Color = "Black", Milage = 6750 });

            InitializeComponent();

            //Set-up form
            Text = "Cars in stock";

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

            foreach (Car c in _cars)
            {
                listBox1.Items.Add(c);
            }

            listBox1.SelectedIndexChanged += new EventHandler((sender, e) =>
              {
                  Car c = (Car)listBox1.SelectedItem;
              });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car c = (Car)listBox1.SelectedItem;
            Display(c);
        }

        private void Display(Car c)
        {
            textBox1.Text = "Märke: " + c.Make;
            textBox2.Text = "Modell: " + c.Model;
            textBox3.Text = "Färg: " + c.Color;
            textBox4.Text = "Mätarställning: " + c.Milage;

        }
    }
}
