﻿namespace Portfolio.Repository;

public class ConnectionStringOption
{
    public const string Key = "ConnectionStrings";
    public string SqlCon { get; set; } = default!;

    public string SqlCon2 { get; set; } = default!;
}

