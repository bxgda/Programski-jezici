package main;

import bernardino.*;
import klopa.*;

public class MainClass {
	public static void main(String[] args) {
		Frizider f = new Frizider();
		
		try {
			Namirnica n = new Namirnica("keleraba");
			f.dodajNamirnicu(n);
			
			n = new Namirnica("kelj");
			f.dodajNamirnicu(n);
			
			n = new Namirnica("jabuka");
			f.dodajNamirnicu(n);
			
			//Namirnica koja baca gresku
			//n = new Namirnica("kruska"); 
			//f.dodajNamirnicu(n);
		}catch(McDonalds mc) {
			System.out.println(mc);
			System.exit(0);
		}
		
		f.velikoSpremanje();
	}
}
