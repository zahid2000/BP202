namespace Core.Utilities.Results;

public class SuccessResult : Result
{
    public SuccessResult() : base(true) { }
    public SuccessResult(params string[] message) : base(true, message) { }
}

