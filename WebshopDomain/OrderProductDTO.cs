using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopDomain
{
    //Deze klasse is bedoeld om een groot probleem binnen het WCF te vermijden.
    //WCF kan heel moeilijk gaan doen als je complexe objecten zoals order heen en weer wilt sturen
    //Door deze klasse te grbuiken geeft WCF geen fouten, wel zijn er meer calls nodig.
    public class OrderProductDTO
    {
        public int quantity { get; set; }
        public int product { get; set; }
    }
}
