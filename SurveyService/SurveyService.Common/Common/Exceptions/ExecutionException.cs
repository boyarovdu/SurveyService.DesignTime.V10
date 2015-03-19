using System;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization;
using SurveyService.Common.Exceptions;

// ReSharper disable once CheckNamespace
namespace SurveyService.Common.Exceptions
{
    [Serializable]
    public class ExecutionException : RootException
    {
        #region Constructors and Destructors

        public ExecutionException()
        {
        }

        public ExecutionException(string message)
            : base(message)
        {
        }

        public ExecutionException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected ExecutionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            Contract.Assert(info != null);

            this.ErrorCode = info.GetInt32("Code");
            this.ErrorSubcode = info.GetInt32("Subcode");
            this.ErrorSource = info.GetString("ErrorSource");
        }

        #endregion

        #region Properties

        public int ErrorCode { get; set; }

        public int ErrorSubcode { get; set; }

        public string ErrorSource { get; set; }

        #endregion

        #region Methods

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Code", this.ErrorCode);
            info.AddValue("Subcode", this.ErrorSubcode);
            info.AddValue("ErrorSource", this.ErrorSource);
        }

        #endregion
    }
}