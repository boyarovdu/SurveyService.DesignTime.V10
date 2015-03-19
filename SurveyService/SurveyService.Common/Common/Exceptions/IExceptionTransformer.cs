using System;

// ReSharper disable once CheckNamespace
namespace SurveyService.Common.Exceptions
{
    public interface IExceptionTransformer
    {
        Exception TransformException(Exception ex, string policyName);
    }
}
