﻿using Domain.Entities.BasesEntities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("embargos")]
    public class Embargo : GeoSpatialBaseIntersection
    {
        [Key]
        [Column("gid")]
        public int Id { get; init; }

        [Column("geom", TypeName = "geometry(Polygon, 4674)")]
        public Geometry? Geom { get; init; }

        [Column("area_intersect_ha")]
        public double AreaIntersectHa { get; init; }

        [Column("numero_tad")]
        public string IdentificationEmbargoTerm { get; private set; } = string.Empty;

        [Column("data_tad")]
        public DateOnly EmbargoIssuanceDate { get; private set; }

        [Column("nom_pessoa")] 
        public string? NameEmbargoed {  get; private set; } = string.Empty;

        [Column("cpf_cnpj_i")]
        public string? CPF_CNPJ { get; private set; } = string.Empty;

        [Column("processo_t")]
        public string? AdministrativeProcessNumber { get; private set; } = string.Empty;

        [Column("qtd_area_d")]
        public string? TotalEmbargoArea { get; private set; } = string.Empty;

        [Column("num_auto_i")]
        public string? InflationActNumber { get; private set; } = string.Empty;

        [Column("des_infrac")]
        public string? InfractionDescription { get; private set; } = string.Empty;

        [Column("status_tad")]
        public string Status { get; private set; } = string.Empty;

        [Column("data_cadas")]
        public DateOnly RegistrationDate { get; private set; }

        [Column("legislacao")]
        public string? Legislation { get; private set; } = string.Empty;

        [Column("artigo_leg")]
        public string? Article { get; private set; } = string.Empty;

        [Column("percentage_of_the_property_area")]
        public double PercentageOfThePropertyArea { get; init; }
        protected Embargo() { }
    }
}
