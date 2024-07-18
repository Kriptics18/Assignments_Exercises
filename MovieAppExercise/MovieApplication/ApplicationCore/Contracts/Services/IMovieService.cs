﻿using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services {
    public interface IMovieService {

        IEnumerable<MovieCardModel> GetTestMovieCards();

        Task<Movies> GetMovieDetailsAsync(int id);

    }
}
