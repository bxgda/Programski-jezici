package moon;

import java.io.*;
import java.util.ArrayList;

import emergency.*;

public class MoonBaseAlpha {
	
	private ArrayList<Eagle> lista;
	
	public MoonBaseAlpha() {
		lista = new ArrayList<>();
	}
	
	public void dodaj(Eagle e) {
		lista.add(e);
	}
	
	public void uzbuna() throws LowCapacity {
		
		if (lista.isEmpty())
			return;
		
		lista.sort(null);
		
		if (lista.get(0).getKargoKapacitet() < 100)
			throw new LowCapacity("Brate, ispod 100 tona ti kapacitet najvece letelica...");
		
		try {
			FileOutputStream fos = new FileOutputStream("eagle.bin");
			BufferedOutputStream bos = new BufferedOutputStream(fos);
			DataOutputStream dos = new DataOutputStream(bos);
			
			// Upsiuje tri najteza ili ako uopste nema 3 u listi onda upise kolko moze
			for (int i = 0; i < Math.min(3, lista.size()); ++i) {
				
				dos.writeInt(lista.get(i).getRedniBroj());
				
				System.out.println(lista.get(i).getRedniBroj());	// na konzolu cisto da vidim sta mi upisuje u fajl
		
			}
			
			dos.close();
		}
		catch (IOException e) {
			System.out.println(e);
		}	
	}
}
