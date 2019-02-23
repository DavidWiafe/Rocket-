using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocket_Ship
{
    public partial class Form2 : Form
    {
         Race r1 = new Race(  );

        public Form2()
        {
            InitializeComponent();
            Console.WriteLine();
         
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void RedBlockPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stratButton_Click(object sender, EventArgs e)
        {
            //change the users text (string) to an interger
            String redTextString = redTextBox.Text;
            int redTextInt = int.Parse(redTextString);

            Console.WriteLine(redTextInt);
            //  r1.setBlockName1(redLabel.Name);
            Console.WriteLine("{0} = Red Name \n" +
                "{1} = Red Population\n" +
                "{2} Blue Name \n"
                +"{3} Blue Population");
        }
    }
}
