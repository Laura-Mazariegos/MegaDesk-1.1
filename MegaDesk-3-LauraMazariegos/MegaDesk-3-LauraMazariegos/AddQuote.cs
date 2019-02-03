using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MegaDesk_3_LauraMazariegos
{

    

    public partial class AddQuote : Form
    {
        DeskFinish material;
        string custName;
        string width;
        string height; 

        public Stream MegaDesk_Quotes { get; private set; }

        public AddQuote()
        {
            InitializeComponent();
            List<DeskFinish> FinishList = Enum.GetValues(typeof(DeskFinish))
                .Cast<DeskFinish>().ToList();
            materialComboBox.DataSource = FinishList;

            List<Drawers> NumDrawers = Enum.GetValues(typeof(Drawers))
                .Cast<Drawers>().ToList();
            drawersComboBox.DataSource = NumDrawers;

            List<FinishTime> Express= Enum.GetValues(typeof(FinishTime))
                .Cast<FinishTime>().ToList();
            expressComboBox.DataSource = Express;

        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                material = (DeskFinish)materialComboBox.SelectedValue;
                System.IO.TextWriter textOut = new System.IO.StreamWriter(MegaDesk_Quotes);
                textOut.WriteLine(custName);
                textOut.WriteLine(width);
                textOut.WriteLine(height);
                textOut.WriteLine(materialInput);
                textOut.WriteLine(drawersInput);
                textOut.WriteLine(expressComboBox);
                textOut.Close();
            }
            catch 
            {
                Console.WriteLine("Please select a value...");
                Console.WriteLine("Quote not saved.");
              
            }

        }

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
                var mainMenu = (MainMenu)Tag;
                mainMenu.Show();
                Close();            
        }

       

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            custName = Console.ReadLine();
            
        }

        private void widthInput_TextChanged(object sender, EventArgs e)
        {
            width = Console.ReadLine();
           
        }

        private void heightInput_TextChanged(object sender, EventArgs e)
        {
            height = Console.ReadLine();
           
        }

        

        
    }
}
