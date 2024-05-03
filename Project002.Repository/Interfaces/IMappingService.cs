using Project002.Repository.DTOs;
using Project002.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project002.Repository.Interfaces
{
    public interface IMappingService
    {
        public Samurai AddSamurai(SamuraiDTO samuraiDTO);

    }
}
