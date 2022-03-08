using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public abstract class Hero 
    {
    	public string Name;
    	public int Level;
    	public string HeroType;
        public Hero(string Name, int Level, string HeroType)
        {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
        }
        public Hero(){
        	
        }
        
        public virtual string Attack()
        {
        	return this.Name + "Lançou magia";
        }
    }
}