using System;

namespace Shop
{
	public class LampCard:ICard
	{
		public string name(){
			return "Ламповая карта";
		}
		public double reCount(int c){
			return c*0.95;
		}
		public bool isNext(int c){
			return c>=12500;
		}
	}
}

