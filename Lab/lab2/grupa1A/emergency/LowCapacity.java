package emergency;

public class LowCapacity extends Exception {

	private static final long serialVersionUID = 1L;
	
	public LowCapacity(String s) {
		super(s);
	}
	
}