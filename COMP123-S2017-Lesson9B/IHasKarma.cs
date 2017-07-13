using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Name- Simar Gill
 * Date- July13,2017
 * Description-This is interfacelists the signature for superHero sub class
 * Version- 0.1 - Declare the Karma property
 */
namespace COMP123_S2017_Lesson9B
{

    public interface IHasKarma
    {
        // PUBLIC PROPERTIES
        int Karma { get; set; }
    }
}
