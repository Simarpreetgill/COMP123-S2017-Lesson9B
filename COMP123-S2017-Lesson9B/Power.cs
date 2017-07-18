using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Name- Simar Gill
 * Date- July13,2017
 * Description-THis is the new Power data type
 * derive from
 * Version- 0.1 - Add a custom constructor to assign name and rank
 */
namespace COMP123_S2017_Lesson9B
{

    /// <summary>
    /// The Power class contains the data and structure of the each Super Power.
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        // CONSTRUCTORS -----------------------------------------

        /// <summary>
        /// This is the Power construtor.
        /// Takes two parameters - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}