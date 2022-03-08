using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
        }
        
        public override string Attack()
        {
           return $"{this.Name} Lançou magia";
        }
        public string Attack(int bonus)
        {
        	if (bonus > 6)
        	{
        		return $"{this.Name} Lançou magia super efetiva com dano de: {bonus}";
        	}
        	else
        	{
        		return $"{this.Name} Lançou magia fraca com dano de: {bonus}";
        	}
        }
    }
}