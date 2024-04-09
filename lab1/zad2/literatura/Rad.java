package literatura;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class Rad implements Referenca, Comparable<Referenca> {

	private int godina;
	private int isbn;
	
	public Rad() {
		godina = isbn = 0;
	}
	
	public Rad(int godina, int isbn) {
		this.godina = godina;
		this.isbn = isbn;
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
			b.write(isbn % 10);
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
