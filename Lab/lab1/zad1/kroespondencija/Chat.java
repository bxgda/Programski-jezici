package kroespondencija;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class Chat implements IPoruka, Comparable<IPoruka> {

	private String tekstPoruke;
	private String username;
	
	public Chat(String tekstPoruke, String username) {
		this.tekstPoruke = tekstPoruke;
		this.username = username;
	}
	
	@Override
	public int validiraj() {
		if(tekstPoruke.length() == 0)
			return -1;
		return tekstPoruke.length();
	}

	@Override
	public void ispisi() {
		System.out.println("Chat: " + tekstPoruke + "\n");
	}

	@Override
	public void arhiviraj() {
		try {
			FileWriter f = new FileWriter(username + ".txt");
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
