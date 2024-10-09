package kroespondencija;

import java.io.*;

public class Sms implements IPoruka, Comparable<IPoruka> {

	private String tekstPoruke;
	private String brojTelefona;
	
	public Sms(String tekstPoruke, String brojTelefona) {
		this.tekstPoruke = tekstPoruke;
		this.brojTelefona = brojTelefona;
	}

	@Override
	public int validiraj() {
		if(brojTelefona.length() < 9)
			return -1;
		return tekstPoruke.length();
	}

	@Override
	public void ispisi() {
		System.out.println("Sms: " + tekstPoruke + "\n");
	}

	@Override
	public void arhiviraj() {
		try {
			FileWriter f = new FileWriter(brojTelefona + ".txt");
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
