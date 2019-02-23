using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
/*

    Goal is to create a Algorithm 

    Algorithm = Instructions

    Grab the number of people (value) in each block i create
 
*/
#endregion
namespace Rocket_Ship
{
    class Race
    {
        //an array/list that will hold all the years going to be used
        private int[] years;


        private int startYear = 2000;

        //holds he amount of people per country/state/block
        private int numberOfPepoleBlockOne;

        private int numberOfPepoleBlockTwo;

        private String BlockName1;

        private String BlockName2;

        #region Constructors
        //default constructor
        public Race() { }

        /* *
         * blockNum1 = the value of form elenment block 1
         * blockNum2 = the value of form elenment block 2
         * 
        */
        public Race(int blockNum1, int blockNum2,String blockName1, String blockName2) {
            setNumBlock1(blockNum1);

            setNumBlock2(blockNum2);

            setBlockName1(blockName1);

            setBlockName2(blockName2);
        }
        #endregion

        #region Setters/Getters

        public void setNumBlock1(int numberOfPepoleBlockOne) {
            this.numberOfPepoleBlockOne = numberOfPepoleBlockOne;
        }

        public int getNumBlock1() {
            return numberOfPepoleBlockTwo;
        }

        public void setNumBlock2(int numberOfPepoleBlockTwo)
        {
            this.numberOfPepoleBlockTwo = numberOfPepoleBlockTwo;
        }

        public int getNumBlock2()
        {
            return numberOfPepoleBlockTwo;
        }

        public void setBlockName1(String blockname1) {
            this.BlockName1 = blockname1;
        }

        public String getBlockName1() {
            return BlockName1;
        }

        private void setBlockName2(String blockname2) {
            this.BlockName1 = blockname2;
        }

        private String getBlockName2() {
            return BlockName2;
        }


        #endregion



    }
}
