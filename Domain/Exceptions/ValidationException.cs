using System;
using System.Collections.Generic;

namespace Domain.Exceptions
{
    public class CustomError
    {
        public CustomError(int code, string message)
        {
            this.Code = code;
            this.Message = message;
        }
        public int Code { get; }
        public string Message { get; }
    }
    public class FieldError
    {
        public FieldError(string field)
        {
            this.Field = field;
            Errors = new List<CustomError>();
        }
        public string Field { get;}
        public List<CustomError> Errors { get; }
        public void AddError(int code, string message)
        {
            this.Errors.Add(new CustomError(code, message));
        }
        public List<FieldError> InnerErrors { get; set; }
    }
    public class ValidationException : Exception
    {
        public int? Code { get; set; }
        public List<FieldError> Errors { get; set; }
        public ValidationException() : base() 
        {
            this.Errors = new List<FieldError>();
        }
        public bool HaveErrors()
        {
            return this.Errors.Count > 0;
        }
        public ValidationException(string message, int? code = null) : base(message)
        {
            this.Code = code;
            this.Errors = new List<FieldError>();
        }
        public ValidationException(string message) : base(message) 
        {
            this.Errors = new List<FieldError>();
        }
        public ValidationException SetErrorField(string field, int code)
        {
            this.SetErrorField(field, code, "");
            return this;
        }
        public ValidationException SetErrorField(string field, string message)
        {
            this.SetErrorField(field, 0, message);
            return this;
        }
        public ValidationException SetErrorField(string field, int code, string message)
        {
            var mError = this.Errors.Find(e => e.Field == field);
            if(mError == null)
            {
                mError = new FieldError(field);
                this.Errors.Add(mError);
            }
            mError.AddError(code, message);
            return this;
        }
        public static ValidationException Builder()
        {
            return new ValidationException();
        }

        public static void Throw(string message)
        {
            throw new ValidationException(message);
        }
    }
}
