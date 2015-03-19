using System;

namespace SurveyService.Model.Entities
{
    public abstract class BaseEntity
    {
        public virtual long Id { get; set; }

        public virtual DateTime Created { get; set; }

        public virtual DateTime? Modified { get; set; }

    }
}
