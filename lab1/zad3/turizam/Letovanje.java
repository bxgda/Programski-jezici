package turizam;
import java.io.*;

public class Letovanje implements Put, Comparable<Put>{

	private String naziv;
	private double brojDana;
	private double cenaPoDanu;
	
	public Letovanje() {
		naziv = null;
		brojDana = cenaPoDanu = 0;
	}
	
	public Letovanje(String naziv, double brojDana, double cenaPoDanu) {
		this.naziv = naziv;
		this.brojDana = brojDana;
		this.cenaPoDanu = cenaPoDanu;
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

	@Override
	public double vratiCenu() {
		return (brojDana * cenaPoDanu) * (1 + Math.random());
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

		
}
