package prevoz;

public abstract class Auto {

	protected int konjaza;
	protected int obrtniMoment;
	static protected int redniBroj = 0;
	
	public Auto() {
		konjaza = obrtniMoment = redniBroj = 0;
	}
	
	public Auto(int konjaza, int obrtniMoment) {
		this.konjaza = konjaza;
		this.obrtniMoment = obrtniMoment;
		Auto.redniBroj++;
	}
	
	public abstract double brutalnost();
}
