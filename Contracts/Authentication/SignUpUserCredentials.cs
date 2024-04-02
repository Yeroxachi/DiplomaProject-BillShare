﻿using System.ComponentModel.DataAnnotations;
using Contracts.Attributes;

namespace Contracts.Authentication;

public record SignUpUserCredentials
{
    [EmailAddress]
    public required string Email { get; init; }

    [PasswordValidation(ErrorMessage =
        "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
    public required string Password { get; init; }

    public required string Username { get; init; }
}