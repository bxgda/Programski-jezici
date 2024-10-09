package moon;

import java.io.*;

public class Eagle implements Comparable<Eagle> {

	private int redniBroj;
	private int kargoKapacitet;
	
	public Eagle(int redniBroj) {
		this.redniBroj = redniBroj;
		ucitaj();
	}
	
	private void ucitaj() {
		try {
			FileReader f = new FileReader(Integer.toString(redniBroj) + ".txt");
			BufferedReader b = new BufferedReader(f);
			kargoKapacitet = Integer.parseInt(b.readLine());
			b.close();
		}
		catch (IOException e) {
			System.out.println(e);
		}
	}
	
	public int getKargoKapacitet() {
		return kargoKapacitet;
	}
	
	public int getRedniBroj() {
		return redniBroj;
	}
	
	@Override
	public int compareTo(Eagle o) {
		
		// posto nista ne kaze kako treba da ih sortiram
		// napravio sam compareTo da ih sortira obrnuto (od najtezeg do najlakseg)
		// jer je posle jednostavnije da upisem u fajl prva tri, a ne zadnja tri
		
		if (this.kargoKapacitet < o.kargoKapacitet)
			return 1;
		else if (this.kargoKapacitet == o.kargoKapacitet)
			return 0;
		else 
			return -1;
		
		// inace bi ovako motano u oblande bio obican sort
		// return ((Integer)this.kargoKapacitet).compareTo(o.kargoKapacitet);
	}
	
}
