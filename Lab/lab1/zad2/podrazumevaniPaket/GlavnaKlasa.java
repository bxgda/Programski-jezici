package podrazumevaniPaket;
import java.util.Scanner;
import izuzeci.*;
import literatura.*;

public class GlavnaKlasa {

	public static void main(String[] args) {
		
		Biblioteka<Referenca> b1 = new Biblioteka<Referenca>();
		Referenca k1 = new Knjiga(1988, "Knjiga ima ime");
		Referenca k2 = new Knjiga(1998, "Nema knjiga");
		Referenca r1 = new Rad(1990, 12345);
		Referenca r2 = new Rad(2000, 72345);
		
		b1.staviNaPolicu(k1);
		b1.staviNaPolicu(k2);
		b1.staviNaPolicu(r1);
		b1.staviNaPolicu(r2);
		
		Knjiga unos;
		try {
			Scanner tast = new Scanner(System.in);
			System.out.println("godina: ");
			int godina = tast.nextInt();	
			if(godina == 0)
				throw new Bozic("godina ne moze da bude 0");
			tast.nextLine();
			System.out.println("naslov: ");
			String naslov = tast.nextLine();
			unos = new Knjiga(godina, naslov);
		}
		catch(Bozic e) {
			System.out.println(e);
			unos = new Knjiga(2024, "Ris papira");
		}
		b1.staviNaPolicu(unos);
		b1.urediPolicu();
			
	}

}
