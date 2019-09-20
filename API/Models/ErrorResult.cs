using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Models
{
    public class ErrorResult
    {
        
        private bool hasError { get; set; }
        private List<string> messages { get; set; }
    }
}