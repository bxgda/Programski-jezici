package turizam;
import java.io.*;

public class Zimovanje implements Put, Comparable<Put>{

	private String naziv;
	private double brojDana;
	private double cenaPoDanu;
	private double skiPas;
		
	public Zimovanje() {
		naziv = null;
		brojDana = skiPas = cenaPoDanu = 0;
	}
	
	public Zimovanje(String naziv, double brojDana, double cenaPoDanu, double skiPas) {
		this.naziv = naziv;
		if(brojDana > 2)
			this.brojDana = brojDana;
		else 
			this.brojDana = 3;
		this.cenaPoDanu = cenaPoDanu;
		this.skiPas = skiPas;
	}
	
	@Override
	public double vratiCenu() {
		return (brojDana * cenaPoDanu) + ((brojDana - 2) * skiPas);
	}

	@Override
	public void upisiuFajl() {
		try {
			FileWriter f = new FileWriter(vratiCenu() + ".txt");
			BufferedWriter b = new BufferedWriter(f);
			b.write(naziv.split(" ")[0]);
			b.close();
		}
		catch(IOException e) {
			System.out.println(e);
		}
	}

	@Override
	public int compareTo(Put o) {
		if(this.vratiCenu() < o.vratiCenu())
			return -1;
		else if(this.vratiCenu() == o.vratiCenu())
			return 0;
		else 
			return 1;
	}		
}
