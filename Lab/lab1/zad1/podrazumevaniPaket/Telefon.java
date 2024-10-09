package podrazumevaniPaket;

import java.util.ArrayList;
import izuzeci.NevalidnaPoruka;
import kroespondencija.IPoruka;

public class Telefon <t extends IPoruka> {
	
	private ArrayList<t> lista;
	
	public Telefon() {
		lista = new ArrayList<>();
	}
	
	public void dodajPoruku(t poruka) {
		lista.add(poruka);
	}
	
	public void zavediRed() {
		lista.sort(null);
	}
	
	public int procitajPoruku() throws NevalidnaPoruka {
		
		if(lista.isEmpty())
			return -1;
		
		IPoruka temp = lista.remove(lista.size() - 1);
		
		if(temp.validiraj() == -1)
			throw new NevalidnaPoruka("nevalidna poruka!\n");
		
		temp.ispisi();
		temp.arhiviraj();
		return 1;
	}
}
