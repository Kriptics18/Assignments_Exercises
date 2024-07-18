﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities {
    public class Movies {
        public int Id { get; set; }

        
        [Column(TypeName = "nvarchar(2084)")]
        public string BackdropUrl { get; set; }

        
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Budget { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string? CreatedBy { get; set; }

        
        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

         
        [Column(TypeName = "nvarchar(2084)")]
        public string ImdbUrl { get; set; }

         
        [Column(TypeName = "nvarchar(64)")]
        public string OriginalLanguage { get; set; }

         
        [Column(TypeName = "nvarchar(max)")]
        public string Overview { get; set; }

         
        [Column(TypeName = "nvarchar(2084)")]
        public string PosterUrl { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Price { get; set; }

         
        [Column(TypeName = "datetime2")]
        public DateTime ReleaseDate { get; set; }

         
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Revenue { get; set; }

         
        public int RunTime { get; set; }

         
        [Column(TypeName = "nvarchar(512)")]
        public string Tagline { get; set; }

         
        [MaxLength(256)]
        public string Title { get; set; }

         
        [Column(TypeName = "nvarchar(2084)")]
        public string TmdbUrl { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string? UpdatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedDate { get; set; }

        public ICollection<MovieGenres>? MovieGenres { get; set; }
        public ICollection<MovieCasts>? MovieCasts { get; set; }
        public ICollection<Trailers>? Trailers { get; set; }
        public ICollection<Favorites>? Favorites { get; set; }
        public ICollection<Reviews>? Reviews { get; set; }
        public ICollection<Purchases>? Purchases { get; set; }
    }
}
