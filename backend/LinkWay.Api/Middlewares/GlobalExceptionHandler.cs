
using LinkWay.Application.Common.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace LinkWay.Api.Middlewares;

public sealed class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext context, Exception exception, CancellationToken cancellationToken)
    {
        ProblemDetails problem;
        if (exception is FluentValidation.ValidationException validationException)
        {
            var errors = validationException.Errors
                .GroupBy(error => error.PropertyName)
                .ToDictionary(group => group.Key,
                    group => group.Select(error => error.ErrorMessage).ToArray());

            problem = new ValidationProblemDetails(errors)
            {
                Title = "Bad Request",
                Status = StatusCodes.Status400BadRequest
            };
        }
        else if (exception is ConflictException)
        {
            problem = new ProblemDetails
            {
                Title = "Conflict",
                Status = StatusCodes.Status409Conflict,
                Detail = exception.Message
            };
        }
        else if (exception is NotFoundException)
        {
            problem = new ProblemDetails
            {
                Title = "Not Found",
                Status = StatusCodes.Status404NotFound,
                Detail = exception.Message
            };
        }
        else if (exception is BadRequestException)
        {
            problem = new ProblemDetails
            {
                Title = "Bad Request",
                Status = StatusCodes.Status400BadRequest,
                Detail = exception.Message
            };
        }
        else if (exception is TimeoutException)
        {
            logger.LogError(exception, "Request timed out.");
            problem = new ProblemDetails
            {
                Title = "Gateway Timeout",
                Status = StatusCodes.Status504GatewayTimeout,
                Detail = "The operation timed out. Please try again."
            };
        }
        else
        {
            logger.LogError(exception, "An unexpected error occurred.");
            problem = new ProblemDetails
            {
                Title = "Internal Server Error",
                Status = StatusCodes.Status500InternalServerError,
                Detail = "An unexpected server error occurred."
            };
        }

        problem.Extensions["traceId"] = context.TraceIdentifier;
        context.Response.StatusCode = problem.Status!.Value;
        await context.Response.WriteAsJsonAsync(problem, cancellationToken);
        return true;
    }
}
