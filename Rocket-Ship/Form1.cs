using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//refs 


namespace Rocket_Ship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String guidValue =  Guid.NewGuid().ToString();
            Console.WriteLine("My Guid = {0}",guidValue);
        }
        #region static variables
        private static int fuelUsage = 0;
        //the speed of the rocket
        private static int currentSpeed = 1;
        //count how many times the W key been clicked
        private static int upKeyClickCount = 0;
        #endregion

        //moving objects using keyboard keys
        private void Game_KeyDown(object sender, KeyEventArgs key)
        {
           
            #region movement controls
            if (key.KeyCode == Keys.W)
            {
                //go up
                //rocket.Top -= 5;
                Rockect_Ship.Top -= currentSpeed;

                upKeyClickCount += 1;
            }

            while (key.KeyCode == Keys.W) {

                Rockect_Ship.Top -= currentSpeed;

                //Thread.Sleep(100);
            };

            Console.WriteLine(upKeyClickCount);
            if (key.KeyCode == Keys.S)
            {
                //go down
                rocket.Top += 5;
            }

            if (key.KeyCode == Keys.A)
            {
                //go toward the left
                rocket.Left -= 10;
            }

            if (key.KeyCode == Keys.D)
            {
                //go towards the right
                rocket.Left += 10;
            }

            #endregion

            #region status bar
            if (key.KeyCode == Keys.H)
            {
                status.Value -= 10;
            }
            //every fith decrease satus bar by  
            if ( upKeyClickCount % 5 == 0)
            {
                currentSpeed += 2;

                status.Value -= fuelUsage;
            }
            //every 10 nth decrease the 
            if (upKeyClickCount % 10 == 0)
            {
               
            }
            #endregion
            if (currentSpeed > 12) {
                fuelUsage = 10;
            }
        }


        public void start_countDown()
        {
            
            String[] counterArray = {"3 ","2 ","1... ","and we have lift off" };
          

            Task.Factory.StartNew(() =>
            {
                for (int count = 0; count < 4; count++)
                {

                    ExecuteSecure(() => counter.Text = counterArray[count]);
                    Console.WriteLine(counter.Text);
                    //counter.Refresh();

                   Thread.Sleep(1000);
                }

                for (int up = 0; up <= 46; up += 2)
                {

                    ExecuteSecure(() => Lanchpanel.Top -= up);

                    Console.WriteLine("up values {0}", up);

                    Thread.Sleep(100);
                }
            });

        }

        private void ExecuteSecure(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => action()));
            }
            else
            {
                action();
            }
        }

        public void ascend_rocket()
        {


            //Thread.Sleep(10000);
            /*Task.Factory.StartNew(() =>
                {
                    for (int up = 0; up < 35; up += 2 ){

                        ExecuteSecure(() => Lanchpanel.Top -= up);
                    Console.WriteLine("up values {0}",up);
                    Thread.Sleep(100);
                
                }
           });*/
        }

        #region button clicks
        private void lanuching(object sender, EventArgs e) {

            start_countDown();
        
        }
        //clicking the text button 
        private void test(object sender, EventArgs e) {

            //test the track bar
            trackBar1.Value = 10;

            //stop wait 2 secs
            Thread.Sleep(200);
           
            trackBar1.Value = 0;
            
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
