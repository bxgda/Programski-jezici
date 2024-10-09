package paket;

import moon.*;

import emergency.*;

public class GlavnaKlasa {

	public static void main(String[] args) {
		
		MoonBaseAlpha baza = new MoonBaseAlpha();
		
		Eagle e1 = new Eagle(1);
		Eagle e2 = new Eagle(2);
		Eagle e3 = new Eagle(3);
		Eagle e4 = new Eagle(4);
		Eagle e5 = new Eagle(5);
		
		baza.dodaj(e1);
		baza.dodaj(e2);
		baza.dodaj(e3);
		baza.dodaj(e4);
		baza.dodaj(e5);
		
		try {
			baza.uzbuna();
		} catch (LowCapacity e) {
			System.out.println(e);
		}
		
	}
	
}
