using System;

// ReSharper disable once CheckNamespace
namespace SurveyService.Common.Transactions
{
    public interface ITransactionManager
    {
        #region Public Methods and Operators

        IDisposable BeginTransaction();

        void CommitTransaction(IDisposable transactionToken);

        void RollbackTransaction(IDisposable transactionToken);

        #endregion
    }
}