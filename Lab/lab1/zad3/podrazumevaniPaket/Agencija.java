package podrazumevaniPaket;
import java.io.*;
import java.util.ArrayList;
import inflacija.Preskupo;
import turizam.Put;

public class Agencija <t extends Put>{
	
	private ArrayList<t> lista;
	
	public Agencija() {
		lista = new ArrayList<>();
	}
	
	public void dodajPut(t o) {
		lista.add(o);
	}
	
	public void urediPuteve() throws Preskupo {
		lista.sort(null);
		
		for(t p : lista)
			p.upisiuFajl();
		
		if(lista.get(lista.size()-1).vratiCenu() > 2000)
			throw new Preskupo("preskupo je\n");
		else {
			try {
				FileOutputStream f = new FileOutputStream("exkluziva.bin");
				BufferedOutputStream b = new BufferedOutputStream(f);
				DataOutputStream d = new DataOutputStream(b);
				d.writeDouble(lista.get(lista.size()-1).vratiCenu());
				d.close();
			}
			catch(IOException e) {
				System.out.println(e);
			}
		}
	}
}
