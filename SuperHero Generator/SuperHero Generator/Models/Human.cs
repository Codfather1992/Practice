using SuperHero_Generator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Generator.Models
{
    public class Human:Being,IBeing
    {
        public int Age { get; set; }
        public  Human()
        {
            Move(1, 2);
        }

        public void move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
