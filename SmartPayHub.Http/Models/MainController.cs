using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SmartPayHub.Application.Common.Interfaces;

namespace SmartPayHub.Http.Models
{
    public abstract class MainController(IErrorNotifier errorNotifier) : ControllerBase
    {
        private readonly IErrorNotifier _errorNotifier = errorNotifier;

        protected ActionResult CustomResponse(object? result = null)
        {
            if (IsValidOperation())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            if (_errorNotifier.HasNotFoundNotification())
            {
                return NotFound(new
                {
                    success = false,
                    errors = GetErrors()
                });
            }

            if (_errorNotifier.HasUnauthorizedFoundNotification())
            {
                return Unauthorized();
            }

            return BadRequest(new
            {
                success = false,
                errors = GetErrors()
            });
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid)
            {
                NotifyInvalidModelError(modelState);
            }

            return CustomResponse();
        }

        protected void NotifyInvalidModelError(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(e => e.Errors);
            foreach (var error in errors)
            {
                string errorMsg = error.Exception?.Message ?? error.ErrorMessage;
                _errorNotifier.AddNotification(errorMsg);
            }
        }

        protected bool IsValidOperation()
        {
            return !_errorNotifier.HasNotification();
        }

        protected IEnumerable<string> GetErrors()
        {
            return _errorNotifier.GetNotifications().Select(n => n.Message);
        }
    }
}
