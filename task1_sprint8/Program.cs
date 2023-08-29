public class ParallelUtils<T, TR>
{
	private Func<T, T, TR> operation;
	private T operand1;
	private T operand2;

	public TR Result { get; private set; }

	public ParallelUtils(Func<T, T, TR> operation, T operand1, T operand2)
	{
		this.operation = operation;
		this.operand1 = operand1;
		this.operand2 = operand2;
	}

	public void StartEvaluation()
	{
		Thread thread = new Thread(() =>
		{
			Result = operation(operand1, operand2);
		});
		thread.Start();
	}

	public void Evaluate()
	{
		Result = operation(operand1, operand2);
	}
}