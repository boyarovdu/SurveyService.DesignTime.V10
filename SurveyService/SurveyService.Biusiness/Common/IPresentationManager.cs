using System;
using System.Collections.Generic;
using SurveyService.Persistance.Common;

namespace SurveyService.Biusiness.Common
{
    interface IPresentationManager
    {
        IEnumerable<TResult> ExecuteEnumerable<TResult>(IStoredProcedure<TResult> procedure);

        TResult ExecuteScalar<TResult>(IStoredProcedure<TResult> procedure);

        int ExecuteNonQuery(IStoredProcedure<int> procedure);
    }
}
