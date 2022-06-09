
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolos_2_.DTOs;
using Kolos_2_.Models;

namespace Kolos_2_.Services
{
    public interface IMusicDbService
    {
        public Task<IAsyncResult> DownloadMusican();

    }
    public class MusicDbService : IMusicDbService
    {
        private IMusicDbService _context;
        public MusicDbService(IMusicDbService context)
        {
            _context = context;
        }

        public async Task<IActionResult> DownloadMusican(int idMusican)
        {
       
        }
    }
}
