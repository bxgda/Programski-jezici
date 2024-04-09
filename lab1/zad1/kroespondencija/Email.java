package kroespondencija;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class Email implements IPoruka, Comparable<IPoruka> {
	
	private String tekstPoruke;
	private String adresa;
	
	public Email(String tekstPoruke, String adresa) {
		this.tekstPoruke = tekstPoruke;
		this.adresa = adresa;
	}
	
	
	@Override
	public int validiraj() {
		if(!adresa.contains("@")) 
			return -1;
		return tekstPoruke.length();
	}

	@Override
	public void ispisi() {
		System.out.println("Email: " + tekstPoruke + "\n");
	}

	@Override
	public void arhiviraj() {
		try {
			FileWriter f = new FileWriter(adresa.split("@")[0] + ".txt");
			BufferedWriter b = new BufferedWriter(f);
			b.write(tekstPoruke);
			b.close();
		}
		catch (IOException e) {
			System.out.println(e);
		}
	}

	@Override
	public int compareTo(IPoruka o) {
		if(this.tekstPoruke.length() < o.validiraj())
			return -1;
		else if (this.tekstPoruke.length() == o.validiraj())
			return 0;
		return 1;
	}
}
