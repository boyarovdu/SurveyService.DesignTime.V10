using System;

// ReSharper disable once CheckNamespace
namespace SurveyService.Common.Transactions
{
    public interface ITransaction : IDisposable
    {
        bool IsStarted { get; }

        bool IsComplete { get; }

        bool IsRollbacked { get; }

        bool IsFinished { get; }

        void Start();

        void Complete();

        void Rollback();
    }
}
