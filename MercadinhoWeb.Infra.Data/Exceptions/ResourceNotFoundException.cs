﻿namespace MercadinhoWeb.Infra.Data.Exceptions;

public class ResourceNotFoundException : Exception
{
    public ResourceNotFoundException() : base("Resource not found.") { }

    public ResourceNotFoundException(string message) : base(message) { }
}
