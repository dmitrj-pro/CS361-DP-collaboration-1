using System;

namespace Shop
{
	public class TransCard:ICard
	{
		public string name(){
			return "Транзисторная карта";
		}
		public double reCount(int c){
			return c*0.9;
		}
		public bool isNext(int c){
			return c>=25000;
		}
	}
}

