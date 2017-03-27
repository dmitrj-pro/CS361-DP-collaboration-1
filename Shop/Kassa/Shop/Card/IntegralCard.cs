using System;

namespace Shop
{
	public class IntegralCard:ICard
	{
		public string name(){
			return "Интегральная карта";
		}
		public double reCount(int c){
			return c*0.85;
		}
		public bool isNext(int c){
			return false;
		}
	}
}

