using System;
using ZeroAllocationWebAPI.Models;
using System.Span;
using Microsoft.Extensions.ObjectPooling;

namespace ZeroAllocationWebAPI.Services
{
    public class ZeroAllocService
    {
        public void ProcessComplexObject(ComplexObject object)
        {
            Span<byte> buffer = stackalloc.alloc(1024);
            object.Name.AsSpan().CopyToSpan(buffer);
            // do more processing here
        }
    }
}