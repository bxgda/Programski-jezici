package literatura;

import java.io.*;

public class Knjiga implements Referenca, Comparable<Referenca> {
	
	private int godina;
	private String naslov;
	
	public Knjiga() {
		godina = 0;
		naslov = null;
	}
	
	public Knjiga(int godina, String naslov) {
		this.godina = godina;
		this.naslov = naslov;
	}
	
	@Override
	public int vratiGodinu() {
		return godina;
	}
	@Override
	public void upisiuFajl() {
		try {
			FileWriter f = new FileWriter(godina + ".txt");
			BufferedWriter b = new BufferedWriter(f);
			b.write(naslov.split(" ")[0]);
			b.close();
		}
		catch(IOException e) {
			System.out.println(e);
		}
	}
	@Override
	public int compareTo(Referenca o) {
		if(o.vratiGodinu() > this.vratiGodinu())
			return -1;
		else if(o.vratiGodinu() == this.vratiGodinu())
			return 0;
		else 
			return 1;
	}
}
