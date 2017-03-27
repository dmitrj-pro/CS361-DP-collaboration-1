using System;

namespace Shop
{
	public class NullCard:ICard
	{
		public string name(){
			return "Отсутствует";
		}
		public double reCount(int c){
			return c;
		}
		public bool isNext(int c){
			if (c >= 5000)
				return true;
			return false;
		}
	}
}

