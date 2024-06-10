class Stack
{
	private int[] niz;
	private int top;
	private readonly object lockObject = new object();

	public Stack(int dim)
	{
		top = 0;
		niz = new int[dim]; 
	}

	public void Push(int el)
	{
		Monitor.Enter(lockObject);
		try
		{
			if (top + 1 == niz.Length)
			   throw new Exception("stack overflow");

			niz[top++] = el;
		}
		finally
		{
			Monitor.Exit(lockObject);
		}
	}

	public int Pop()
	{
		Monitor.Enter(lockObject);
		try
		{
			if (top == 0)
				throw new Exception("stack underflow");

			return niz[--top];
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			return -1;
		}
		finally
		{
			Monitor.Exit(lockObject);
		}
	}
}