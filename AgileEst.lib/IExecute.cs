namespace AgileEst.lib
{
	public interface IExecute<TReturn>
	{
		TReturn Execute();
	}

	public interface IExecute<TReturn, TParam>
	{
		TReturn Execute(TParam input);
	}
}