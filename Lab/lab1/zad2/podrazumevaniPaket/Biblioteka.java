package podrazumevaniPaket;
import java.util.*;
import java.io.*;
import literatura.*;

public class Biblioteka <t extends Referenca> {
	
	private ArrayList<t> lista;
	
	public <t>Biblioteka() {
		lista = new ArrayList<>();
	}
	
	public void staviNaPolicu(t o) {
		lista.add(o);
	}
	
	public void urediPolicu() {
		
		lista.sort(null);
		lista.get(0).upisiuFajl();
		lista.get(lista.size() - 1).upisiuFajl();
		try {
			FileOutputStream f = new FileOutputStream("broj.bin");
			BufferedOutputStream b = new BufferedOutputStream(f);
			DataOutputStream d = new DataOutputStream(b);
			d.write(lista.size());
			d.close();
		}
		catch(IOException e) {
			System.out.println(e);
		}
	}
}
