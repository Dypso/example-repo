using System;
using ZeroAllocationWebAPI.Models;
using System.Span;
using Microsoft.Extensions.ObjectPooling;

// This service implements zero allocation techniques
namespace ZeroAllocationWebAPI.Services
{
    public class ZeroAllocService
    {
        // Processes a complex object with zero allocation
        public void ProcessComplexObject(ComplexObject object)
        {
            // Allocate memory on the stack
            Span<byte> buffer = stackallo.alloc(1024);
            // Copy data from the object to the buffer
            object.Name.AsSpan().CopyToSpan(buffer);
            // Additional processing can be done here
        }
    }
}