package klopa;
import bernardino.*; 	
import java.io.*;

public class Namirnica implements Comparable<Namirnica>{
	private String tip;
	double procenatProteina, glikemijskiIndeks;
	
	public Namirnica(String tip) throws McDonalds{
		try {
			this.tip = tip;
			
			FileReader fr = new FileReader(tip + ".txt");
			BufferedReader br = new BufferedReader(fr);
			
			this.procenatProteina = Double.parseDouble(br.readLine());			
			this.glikemijskiIndeks = Double.parseDouble(br.readLine());
			
			br.close();
			
			if(this.hranljivost() < 10)
				throw new McDonalds("Hranljivost " + tip + " je manja od 10");
			
		}catch(IOException e) {
			System.out.println("Greska prilikom otvaranja fajla: " + tip + ".txt");
			System.out.println(e);
		}
	}
	
	public double hranljivost() {
		return this.procenatProteina - this.glikemijskiIndeks;
	}

	public int compareTo(Namirnica o) {
		return (this.hranljivost() > o.hranljivost() ? 1 : this.hranljivost() == o.hranljivost() ? 0 : -1);
	}
	
	public void print() {
		System.out.println("Tip: " + tip + " | procenat proteina: " + procenatProteina + " | glikemijski indeks namirnice: " + glikemijskiIndeks + " | hranljivost: " + this.hranljivost());
	}
}
