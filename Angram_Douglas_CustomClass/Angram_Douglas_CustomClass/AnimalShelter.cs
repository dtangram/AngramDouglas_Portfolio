using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_CustomClass
{
    class AnimalShelter
    {
        //Create variables to hold the number of dogs in the shelter, the max and minimal.
        int mMaxNumber;
        int mLowestNumber;
        int mCurrentNumber;

        //Create constructor method.
        public AnimalShelter(int _maxNumber, int _lowestNumber, int _curentNumber)
        {
            mMaxNumber = _maxNumber;
            mLowestNumber = _lowestNumber;
            mCurrentNumber = _curentNumber;
        }

        //Create the getter method for the max number of dogs.
        public int GetMaxNumber()
        {
            //Return the value of max number.
            return mMaxNumber;
        }

        //Create the getter method for the lowest number of dogs.
        public int GetLowestNumber()
        {
            //Return the value of lowest number.
            return mLowestNumber;
        }

        //Create the getter method for the current number of dogs.
        public int GetCurrentNumber()
        {
            //Return the value of current number.
            return mCurrentNumber;
        }

        //Create setter for the max number of dogs.
        public void SetMaxNumber(int _maxNumber)
        {
            //Assign the value of the max number member variable to the parameter _maxNumber.
            mMaxNumber = _maxNumber;
        }

        //Create setter for the max number of dogs.
        public void SetLowestNumber(int _lowestNumber)
        {
            //Assign the value of the max number member variable to the parameter _maxNumber.
            mLowestNumber = _lowestNumber;
        }

        //Create setter for the max number of dogs.
        public void SetCurrentNumber(int _currentNumber)
        {
            //Assign the value of the max number member variable to the parameter _maxNumber.
            mCurrentNumber = _currentNumber;
        }
    }
}
