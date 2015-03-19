using System.Collections.Generic;
using System.Data.Entity;

namespace SurveyService.Persistance.Common
{
    public interface IProcedureManager
    {
        IEnumerable<TResult> ExecuteStoredProcedure<TResult>(Database database, IStoredProcedure<TResult> procedure);
    }
}
