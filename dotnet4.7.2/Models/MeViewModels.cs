using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnet4._7._2.Models
{
    // MeController アクションによって返されるモデル。
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}