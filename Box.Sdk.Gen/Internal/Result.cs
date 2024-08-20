
using System;

namespace Box.Sdk.Gen.Internal
{
  internal class Result<T>
  {
    public T? Value { get; }
    public bool IsSuccess { get; }
    public Exception? Exception { get; }

    private Result(bool isSuccess, T? value = default, Exception? exception = default)
    {
      IsSuccess = isSuccess;
      Value = value;
      Exception = exception;
    }

    public static Result<T> Ok(T value)
    {
      return new Result<T>(true, value);
    }

    public static Result<T> Fail(Exception ex)
    {
      return new Result<T>(false, default(T), ex);
    }
  }
}