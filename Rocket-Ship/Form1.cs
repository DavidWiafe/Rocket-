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

namespace Rocket_Ship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private static double fuelUsage;

        private static int currentSpeed = 1;

        private static int upKeyClickCount = 0;

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

                status.Value -= 2;
            }
            #endregion
        }


        public void start_countDown()
        {
            
            String[] counterArray = {"3 ","2 ","1... ","and we have lift off" };

            Task.Factory.StartNew(() =>
            {
                for (int count = 0; count < 4; count++)
                {

                    ExecuteSecure(() => counter.Text = counterArray[count]);

                    //counter.Refresh();

                    Thread.Sleep(1000);
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
            int up = 0;

            
           for(; up < 35; up += 5 ){
                
                Rockect_Ship.Top -= up;

               // up++;

            }

        }

        #region button clicks
        private void lanuching(object sender, EventArgs e) {

            start_countDown();

            ascend_rocket();

        }

        #endregion

    }
}
