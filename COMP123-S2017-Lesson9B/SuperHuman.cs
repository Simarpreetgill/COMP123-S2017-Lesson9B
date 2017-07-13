﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Name- Simar Gill
 * Date- July13,2017
 * Description-This is the SuperHuman class that extends the Human abstract class
 * Version- 0.5 - Added the DisplaySkills stub method to satisfy the SupewrHuman sub class
 */
namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the SuperHuman Sub Class
    /// It inherits from the Human Superclass.
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE FILEDS
        private List<Power> _powers;

        // PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers; //returns a reference to the Powers List
            }
        }
        // CONSTRUCTORS
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }
        //PRIVATE METHODS
        /// <summary>
        /// This method initializes and assigns default values to Class Fields
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }
        // PUBLIC METHODS
        /// <summary>
        /// This method adds a power to SuperHumans Class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AdPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Name:  " + power.Name + "Rank: " + power.Rank);

            }
        }
        /// <summary>
        /// This ToString method overrides the built-in object.ToString Method
        /// It outputs a string that displays the superhuman's name and their power list.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "----------------------------------------------------------";
            outputString += "Super Human Name:" + this.Name + "\n";
            outputString = "-----------------------------------------------------------------";
            foreach (Power power in this.Powers)
            {
                outputString += "Power:" + power.Name + "Rank:" + power.Rank + "\n";
            }
            outputString = "-----------------------------------------------------------------";
            return outputString;
        }
        /// <summary>
        /// This method overrides the Human abstract superclass DisplaySkills Method
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not implemented");
        }
    }
}