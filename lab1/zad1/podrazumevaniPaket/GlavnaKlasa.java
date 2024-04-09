package podrazumevaniPaket;

import java.io.*;
import java.util.Scanner;

import kroespondencija.*;
import izuzeci.*;

public class GlavnaKlasa {

	public static void main(String[] args) {
		
		IPoruka sms, email, chat;
		String tekst;
		
		Scanner tast = new Scanner(System.in);
		
		//Sms
		System.out.println("brojtelefona: ");
		String brojTelefona = tast.nextLine();
		System.out.println("tekst sms-a: ");
		tekst = tast.nextLine();
		sms = new Sms(tekst, brojTelefona);
		
		//Email
		System.out.println("Email adresa: ");
		String adresa = tast.nextLine();
		System.out.println("tekst email-a: ");
		tekst = tast.nextLine();
		email = new Email(tekst, adresa);
		
		//Chat
		System.out.println("username: ");
		String username = tast.nextLine();
		System.out.println("tekst chat-a: ");
		tekst = tast.nextLine();
		chat = new Chat(tekst, username);
		
		tast.close();
		
		Telefon<IPoruka> telefon = new Telefon<>();
		
		telefon.dodajPoruku(sms);
		telefon.dodajPoruku(email);
		telefon.dodajPoruku(chat);
		
		telefon.zavediRed();
		
		try {
			int br = 0;
			while(telefon.procitajPoruku() != -1)
				br++;
			try {
				FileOutputStream fos = new FileOutputStream("izlaz.bin");
				BufferedOutputStream bos = new BufferedOutputStream(fos);
				DataOutputStream dos = new DataOutputStream(bos);
				dos.writeInt(br);
				dos.close();
			}
			catch (IOException e) {
				System.out.println(e);
			}
		}
		catch (NevalidnaPoruka np) {
			System.out.println(np);
		}
	}
}
