﻿namespace Ubuntu_Deploy.Services
{
    public interface IMathService
    {
        Task<long> AddAsync(long a, long b, CancellationToken cancellationToken = default);
    }
}
